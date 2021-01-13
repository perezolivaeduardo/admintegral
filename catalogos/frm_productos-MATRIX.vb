Public Class frm_productos
    Dim cargado As Boolean = False
    Dim filtro As String
    Dim ultimo As Integer = 0
    Dim nuevo As Boolean = False

    

    Private Sub frm_productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        Me.ProductosBindingSource.Filter = "id_producto  = -1"
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.Unidades_productosTableAdapter.Fill(Me.AdmintegralDataSet.Unidades_productos)
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)
        Me.Productos_stoksTableAdapter.Fill(Me.AdmintegralDataSet.productos_stoks)

        Me.GruposTableAdapter.Fill(Me.AdmintegralDataSet.Grupos)
        ' ultimo = adap.productos_nuevo_id() - 1 : Me.Text = "Catalogo de Productos,Exsten " + ultimo.ToString + " registros en la base de datos"
        filtro = ""
        Me.ProductosBindingSource.Filter = filtro
        Me.Refresh()
        monitorea()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If TextBox1.Text.Length > 0 Then
                If Val(TextBox1.Text) > 0 Then
                    Dim miix As Long = leer_id(TextBox1.Text)
                    If miix >= 0 Then

                        Dim ix As Long = Me.ProductosBindingSource.Find("id_producto", miix.ToString)
                        Me.ProductosBindingSource.Position = ix
                        Exit Sub
                    End If

                End If
                If TextBox1.Text = "" Then Exit Sub
                filtro = preparar_filtro("descripcion", TextBox1.Text)
                Me.ProductosBindingSource.Filter = filtro
            Else
                Me.ProductosBindingSource.Filter = ""
            End If
        End If
    End Sub ' ejecuta el filrtro

    Private Sub boton_panel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_panel.Click
        Me.SplitCatalogo.Panel2Collapsed = Not Me.SplitCatalogo.Panel2Collapsed
        If Me.SplitCatalogo.Panel2Collapsed = False Then
            Me.boton_panel.Image = My.Resources.bullet_arrow_bottom
        Else
            Me.boton_panel.Image = My.Resources.bullet_arrow_top
        End If
    End Sub ' expande/contrae panel del catalogo

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        My.Forms.frm_new_producto.ShowDialog()
        ' Me.Unidades_productosTableAdapter.Fill(Me.AdmintegralDataSet.Unidades_productos)
        ' Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)
    End Sub ' Nuevo Producto

    Private Sub boton_borrar_unidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_borrar_unidad.Click
        Dim undid As Integer, und As String
        undid = Me.Unidades_productosDataGridView.CurrentRow.Cells(1).Value
        If undid = 1 Then
            MsgBox("No se puede Borrar la unidad Base")
            Exit Sub
        End If
        und = Me.Unidades_productosDataGridView.CurrentRow.Cells(3).Value
        Dim x As MsgBoxResult
        x = MsgBox("Borra esta unidad: " + und, MsgBoxStyle.YesNo, "Borrar Unidad")
        If x = MsgBoxResult.Yes Then
            Try
                Me.ProductosUnidadesproductosBindingSource.RemoveCurrent()
                MsgBox("borrada")
                Me.GuardarToolStripButton.Enabled = True
            Catch ex As Exception
                MsgBox("No se pudo Borrar")
            End Try

        End If

    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        guardar_todo()
        Me.GuardarToolStripButton.Enabled = False : Beep()
    End Sub 'Boton guardar

    Private Sub guardar_todo()
        'Guardar Cambios en Productos
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.AdmintegralDataSet.productos)

        'Guardar Cambios de Unidades
        Me.Validate()
        Me.Unidades_productosDataGridView.EndEdit()
        Me.Unidades_productosTableAdapter.Update(Me.AdmintegralDataSet.Unidades_productos)
        'Carga en el catalogo en memoria
        If nuevo = True Then
            Dim ixi As Integer = InputBox("Teclee el stock para este producto", "Stock", "")
            Dim tblt As DataTable = leer_tabla("select * from tbl_almacenes")
            Dim sadap As New admintegralDataSetTableAdapters.productos_stoksTableAdapter
            ' genera Stocks
            For jj As Integer = 0 To tblt.Rows.Count - 1
                sadap.Insert(ultimo, tblt.Rows(jj).Item(0), ixi, 0)
            Next
            sadap.Dispose()
            nuevo = False
            Me.Productos_stoksTableAdapter.Fill(Me.AdmintegralDataSet.productos_stoks)
        End If
        cargar_catalogo()


    End Sub

    Private Sub DataGridView1_CancelRowEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.QuestionEventArgs) Handles DataGridView1.CancelRowEdit
        Stop
    End Sub ' Guarda los recordset

    Private Sub ProductosDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Unidades_productosDataGridView.CellEndEdit, DataGridView1.CellEndEdit
        'modificadas las columnas
        Me.GuardarToolStripButton.Enabled = True
        Dim grid As New DataGridView
        grid = sender
        ' Solo si es datagrid Unidades
        If grid.Name = Me.Unidades_productosDataGridView.Name Then
            If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Then
                'cuida que no se cambie la unidad BASE
                If e.RowIndex = 0 Then
                    'MsgBox("Unidad Base debe de ser 1 y No se puede cambiar", MsgBoxStyle.Information)
                    grid.CurrentRow.Cells(6).Value = 1
                    grid.CurrentRow.Cells(7).Value = 1
                    Exit Sub
                End If

                Dim dividir As Boolean, factor As Integer, unidades As Double
                Dim cu, pu, cuu, puu As Double
                If e.RowIndex > 0 Then
                    cu = 0 : pu = 0
                    Try
                        cu = grid.Rows(0).Cells(8).Value
                        pu = grid.Rows(0).Cells(9).Value
                    Catch ex As Exception

                    End Try

                End If
                Try
                    dividir = grid.CurrentRow.Cells(5).Value
                Catch ex As Exception
                    grid.CurrentRow.Cells(5).Value = False
                    dividir = False
                End Try

                Try
                    factor = grid.CurrentRow.Cells(6).Value
                Catch ex As Exception
                    grid.CurrentRow.Cells(6).Value = 0
                    factor = 0
                End Try


                If dividir = False Then
                    unidades = factor
                Else
                    If factor = 0 Then factor = 1
                    unidades = 1 / factor
                End If
                grid.CurrentRow.Cells(7).Value = unidades
                puu = unidades * pu
                cuu = unidades * cu
                grid.CurrentRow.Cells(8).Value = CDbl(Format(cuu, "#,##0.00"))
                grid.CurrentRow.Cells(9).Value = CDbl(Format(puu, "#,##0.00"))
            End If

            If e.ColumnIndex = 8 Or e.ColumnIndex = 9 And e.RowIndex = 0 Then
                Dim unidades As Double
                Dim cu, pu, cuu, puu, npu, margen As Double
                Try
                    cu = grid.Rows(0).Cells(8).Value
                    pu = grid.Rows(0).Cells(9).Value
                Catch ex As Exception

                End Try
                'calcula el precio de venta segun costo
                margen = Me.DataGridView1.CurrentRow.Cells("dgvmargen").Value
                npu = cu * (1 + (margen / 100))
                If pu < npu Then pu = npu : grid.Rows(0).Cells(9).Value = npu

                If grid.Rows.Count > 2 And Me.recalcular.Checked = True Then
                    Dim rw As Integer
                    For rw = 1 To grid.Rows.Count - 2
                        unidades = grid.Rows(rw).Cells(7).Value
                        puu = unidades * pu
                        cuu = unidades * cu
                        grid.Rows(rw).Cells(8).Value = CDbl(Format(cuu, "#,##0.00"))
                        grid.Rows(rw).Cells(9).Value = CDbl(Format(puu, "#,##0.00"))
                    Next
                End If
            End If
        End If
    End Sub '=============================GRID DE UNIDADES

    Private Sub boton_salir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        If Me.GuardarToolStripButton.Enabled = True Then
            Dim x As MsgBoxResult
            x = MsgBox("Quiere guardar los datos antes de Salir?", MsgBoxStyle.YesNo, "Salir sin Guardar")
            If x = MsgBoxResult.Yes Then guardar_todo()
        End If
        Me.GruposBindingSource.Dispose()
        Me.Close()
    End Sub ' Boton Salir

    Private Sub Unidades_productosDataGridView_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Unidades_productosDataGridView.CellBeginEdit
        'modificadas las columnas
        If e.RowIndex > 0 Then
            If e.ColumnIndex = 8 Then
                e.Cancel = True
            End If
        End If
    End Sub ' no puede modificar costo de tipos >1

    Private Sub GrupoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoComboBox.SelectedIndexChanged
        Try
            filtro = "id_grupo =" + Me.GrupoComboBox.SelectedValue.ToString
            Me.ProductosBindingSource.Filter = filtro
            lblgrupos.Text = Me.DataGridView1.Rows.Count
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        filtro = ""
        Me.ProductosBindingSource.Filter = filtro
    End Sub 'Quitar Filtro

    Private Sub AyudaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripButton.Click
        Me.WindowState = FormWindowState.Minimized
        Main.Show()
    End Sub 'Salir (minimiza)

    Private Sub FiltrararToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltrararToolStripMenuItem.Click
        Dim mifiltro As String
        With Me.DataGridView1
            mifiltro = .Columns(.CurrentCellAddress.X).DataPropertyName + " = " + .CurrentCell.Value.ToString
            MsgBox(.CurrentCellAddress.X)
            Try
                If filtro.Length > 0 Then
                    filtro += " and " + mifiltro
                Else : filtro = mifiltro
                End If
            Catch ex As Exception
                filtro = mifiltro
            End Try
            Try
                Me.ProductosBindingSource.Filter = filtro
            Catch ex As Exception

            End Try

        End With
    End Sub ' Filtrar segun Valor de clumna

    Private Sub QuitarFiltrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarFiltrosToolStripMenuItem.Click
        filtro = ""
        Me.ProductosBindingSource.Filter = filtro
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim adap As New admintegralDataSetTableAdapters.productosTableAdapter
        adap = ProductosTableAdapter
        Me.ProductosBindingSource.AddNew()
        If ultimo = 0 Then
            ultimo = adap.productos_nuevo_id()
        Else
            ultimo += 1
        End If
        nuevo = True
        Me.DataGridView1.CurrentRow.Cells("dgvmargen").Value = My.Settings.margen
        Me.DataGridView1.CurrentRow.Cells(0).Value = ultimo

        'Me.DataGridView1.Columns.in = Me.DataGridView1.CurrentRow.Cells(1).ColumnIndex
        Me.DataGridView1.Focus()
    End Sub

    Private Sub DataGridView1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = chr13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub monitorea()
        depura()
        Dim cmd As String, tmptbl As DataTable
        cmd = "select * from tmp_productos"
        tmptbl = leer_tabla(cmd)
        If tmptbl.Rows.Count > 0 Then
            dgvpendientes.DataSource = tmptbl
            Dim f As New Form
            Dim dgv As New DataGrid
            dgv.Parent = f
            dgv.Dock = DockStyle.Fill
            dgv.ReadOnly = True
            f.Width = 400
            f.TopMost = True
            dgv.DataSource = tmptbl
            f.Show()
        End If
    End Sub
    Private Sub depura()
        Dim adap As New admintegralDataSetTableAdapters.tmp_productosTableAdapter
        adap.borrar_temporal()
        adap.Dispose()
    End Sub

    Private Sub DataGridView1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        Stop
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.ColumnIndex = 5 Then
            Dim x As DialogResult
            x = My.Forms.buscar_provedor.ShowDialog()
            If x <> Windows.Forms.DialogResult.OK Then Exit Sub
            DataGridView1.CurrentRow.Cells(e.ColumnIndex).Value = gprov.id
        End If
        If e.ColumnIndex = 3 Then
            My.Forms.seleccionar_grupo.ShowDialog()
            DataGridView1.CurrentRow.Cells(e.ColumnIndex).Value = My.Forms.seleccionar_grupo.idgrupo
        End If
    End Sub

    Private Sub VerEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerEntradasToolStripMenuItem.Click
        Dim id As Integer
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            id = Me.DataGridView1.CurrentRow.Cells(0).Value
        Catch ex As Exception
            id = 0
        End Try
        If id > 0 Then My.Forms.Kardex_resumen.caragr(id) : My.Forms.Kardex_resumen.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub idprov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idprov.KeyPress
        If e.KeyChar = chr13 Then
            Dim adam As New admintegralDataSetTableAdapters.DirectorioTableAdapter
            Try
                Me.nombreproveedor.Text = adam.GetDataByID(idprov.Text, 1).Rows(0).Item("Nombre")
                filtro = "id_directorio =" + idprov.Text
                Me.ProductosBindingSource.Filter = filtro
            Catch ex As Exception
                Me.nombreproveedor.Text = ""
                idprov.Text = ""
            End Try

        End If
    End Sub

    Private Sub boton_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_proveedor.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'My.Forms.Entreada_nueva.MdiParent = Me
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.idprov.Text = gprov.id
        Me.nombreproveedor.Text = gprov.nombre
        filtro = "id_directorio =" + idprov.Text
        Me.ProductosBindingSource.Filter = filtro
    End Sub

    Private Sub gptxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gptxt.KeyPress
        If e.KeyChar = chr13 Then
            Try
                Me.GruposBindingSource.Position = Me.GruposBindingSource.Find("id_grupos", gptxt.Text)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub EXISTENCIASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXISTENCIASToolStripMenuItem.Click
        Dim id As Integer, descripcion As String
        id = Me.DataGridView1.CurrentRow.Cells("dgvid").Value
        descripcion = Me.DataGridView1.CurrentRow.Cells("dgvDescripcion").Value
        My.Forms.pop_existencia.calcular(id, descripcion)
        My.Forms.pop_existencia.Show()

    End Sub

    Private Sub deshabilitar()
        Dim gp, cv As Integer, cmd As String
        Dim ix As MsgBoxResult = MsgBox("Seguro que quiere suspender este producto", MsgBoxStyle.YesNo, "Suspender producto(s)")
        If ix = MsgBoxResult.Yes Then
            cmd = " UPDATE [integra].[dbo].[productos] SET [id_grupo_original] = [id_Grupo], [id_Grupo] = " + My.Settings.grupo_suspendidos.ToString
            cmd += " WHERE id_producto = " + DataGridView1.SelectedRows.Item(0).Cells(0).Value.ToString

            If DataGridView1.SelectedRows.Count > 1 Then
                For j As Integer = 1 To DataGridView1.SelectedRows.Count - 1
                    With DataGridView1.SelectedRows.Item(j)
                        gp = .Cells("idgrupo").Value
                        cv = .Cells("dgvid").Value
                        cmd += " or id_producto = " + cv.ToString
                    End With
                Next
            End If
            Actualiza_registros(cmd)
           MsgBox("los registros ya se han habilitado, ya los vera clasificados en su siguiente consulta")
        End If

    End Sub

    Private Sub SuspenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspenderToolStripMenuItem.Click
        deshabilitar()
    End Sub

    Private Sub habilitar()
        Dim gp, cv As Integer, cmd As String
        Dim ix As MsgBoxResult = MsgBox("Seguro que quiere Re-Activar estos productos", MsgBoxStyle.YesNo, "Activar Producto(s)")
        If ix = MsgBoxResult.Yes Then

            cmd = " UPDATE [integra].[dbo].[productos] SET [id_Grupo]=[id_grupo_original] , [id_grupo_original]=0 "
            cmd += " WHERE id_producto = " + Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value.ToString
            If DataGridView1.SelectedRows.Count > 1 Then
                For j As Integer = 1 To DataGridView1.SelectedRows.Count - 1
                    With DataGridView1.SelectedRows.Item(j)
                        gp = .Cells("gp").Value
                        cv = .Cells("clave").Value
                        cmd += " or id_producto = " + cv.ToString
                    End With
                Next
            End If
            Actualiza_registros(cmd)
            MsgBox("los registros ya se han habilitado, ya los vera clasificados en su siguiente consulta")
        End If
    End Sub

    Private Sub ReActivarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReActivarToolStripMenuItem.Click
        habilitar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim pv As Integer = Me.DataGridView1.CurrentRow.Cells("dgvprov").Value
            desplegarprov(pv)
        Catch ex As Exception

        End Try
        Try
            Dim f As String = "id_producto =" + Me.DataGridView1.CurrentRow.Cells("dgvid").Value.ToString
            Me.Productos_stoksBindingSource.Filter = f
        Catch ex As Exception

        End Try
        

    End Sub
    Private Sub desplegarprov(ByVal pv As Integer)
        leer_provedor(pv)
        Me.provtxt.Text = gprov.nombre
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim pv As Integer = Me.DataGridView1.CurrentRow.Cells("dgvprov").Value
            desplegarprov(pv)
        Catch ex As Exception

        End Try
        
    End Sub

  
    Private Sub KardexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KardexToolStripMenuItem.Click
        Dim id As Integer, descripcion As String
        id = Me.DataGridView1.CurrentRow.Cells("dgvid").Value
        My.Forms.Kardex.cargar(id)
        My.Forms.Kardex.Show()
    End Sub

    Private Sub btn_general_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_general.Click
        crear_catalog_general()
        MsgBox("Catalogo General Actualizado")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Validate()
        Me.Productos_stoksBindingSource.EndEdit()
        Me.Productos_stoksTableAdapter.Update(Me.AdmintegralDataSet.productos_stoks)
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub poxxo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles poxxo.CheckedChanged
        Try
            Me.DataGridView1.Columns("precio_oxxo").Visible = Me.poxxo.Checked
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.ProductosBindingSource.Filter = "codigo_sat = '01010101'"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
