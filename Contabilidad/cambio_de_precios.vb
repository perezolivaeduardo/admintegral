Public Class cambio_de_precios
    Dim bs As New BindingSource

    Private Sub cargar_entrada(ByVal folio As Integer)
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String
        cmd = "SELECT dbo.productos.id_Directorio AS Pv, dbo.productos.id_Grupo AS Gp, dbo.productos.id_Producto AS Id, dbo.productos.Descripcion, dbo.productos.margen, " _
        & " dbo.Unidades_productos.Unidad, dbo.Unidades_productos.factor, productos_info.costo_anterior as 'C.Ante', dbo.Unidades_productos.costo, dbo.Unidades_productos.venta, " _
        & " ROUND((dbo.Unidades_productos.venta / dbo.Unidades_productos.costo - .099) * 10, 2) AS Mr, case when dbo.productos.precio_unico=0 then ROUND(dbo.Unidades_productos.costo * 1.1, 2) else  dbo.Unidades_productos.venta END AS NPV " _
        & " FROM dbo.productos INNER JOIN " _
        & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto INNER JOIN " _
        & " dbo.movimientos ON dbo.Unidades_productos.id_producto = dbo.movimientos.id_prodcuto INNER JOIN " _
        & "productos_info ON productos.id_Producto = productos_info.Id " _
        & " WHERE dbo.movimientos.id_doc = 1 And dbo.Unidades_productos.factor = 1 And dbo.movimientos.folio_doc = " + folio.ToString
        Dim tbl As DataTable = leer_tabla(cmd)
        dgv.Parent = Me.SplitContainer2.Panel2
        bs.DataSource = tbl
        dgv.DataSource = bs
        If dgv.Columns.Count = 12 Then
            Dim column As New DataGridViewCheckBoxColumn
            With column
                .Name = "S"
                .HeaderText = "S"
                .DataPropertyName = "S"
            End With
            dgv.Columns.Insert(12, column)
        End If

        dgv.Columns("NPV").DefaultCellStyle.Format = "N2"
        dgv.Columns("NPV").DefaultCellStyle.BackColor = Color.YellowGreen
        dgv.Columns("VENTA").DefaultCellStyle.Format = "N2"
        dgv.Columns("costo").DefaultCellStyle.Format = "N2"
        dgv.Columns("C.Ante").DefaultCellStyle.Format = "N2"
        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                If .Cells("NPV").Value < .Cells("venta").Value Then .DefaultCellStyle.ForeColor = Color.Green
                If .Cells("NPV").Value > .Cells("venta").Value Then .DefaultCellStyle.ForeColor = Color.Red
            End With
        Next
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub dgv_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        dgv.CurrentRow.Cells("s").Value = True
    End Sub

    Private Sub SeleccionarTodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarTodosToolStripMenuItem.Click, ToolStripMenuItem1.Click
        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                .Cells("s").Value = True
            End With
        Next
    End Sub

    Private Sub QuitarSeleccionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarSeleccionToolStripMenuItem.Click, ToolStripMenuItem2.Click
        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                .Cells("s").Value = False
            End With
        Next
    End Sub

    Private Sub ToolStripTextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStripTextBox1.KeyPress
        If e.KeyChar = chr13 Then
            cargar_entrada(Me.ToolStripTextBox1.Text)
        End If
    End Sub

    Private Sub guardar_cambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_cambios.Click, ToolStripButton2.Click
        Dim adap As New admintegralDataSetTableAdapters.cambio_de_preciosTableAdapter
        dgv.RefreshEdit()
        Dim id, entrada As Integer, pv As Decimal, pva As Decimal, costo As Decimal, costoa As Decimal
        Try
            entrada = Me.ToolStripTextBox1.Text
        Catch ex As Exception
            entrada = 0
        End Try

        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                If .Cells("s").Value = True Then
                    id = .Cells("id").Value
                    pv = .Cells("npv").Value
                    pva = .Cells("venta").Value
                    costo = .Cells("costo").Value
                    costoa = .Cells("C.Ante").Value
                    'actualiza Unidades_precio
                    cambio_precio(id, costo, costoa, pva, pv)
                    'Agrega registro a Bitacora
                    adap.Insert(Now.Date, id, costoa, costo, pva, pv, user.id, Now.Date, True, entrada)
                End If
            End With
        Next
    End Sub

    Private Sub cambio_precio(ByVal id As Integer, ByVal costo As Decimal, ByVal costoa As Decimal, ByVal pva As Decimal, ByVal pv As Decimal)
        Dim cmd As String
        cmd = "UPDATE [integra].[dbo].[Unidades_productos]  SET  [venta] = " + pv.ToString + "*[factor] WHERE id_producto= " + id.ToString
        comando(cmd)
        ' MsgBox(id)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim ix As MsgBoxResult = MsgBox("Aplicar Margen a los seleccionados", MsgBoxStyle.YesNo, "Aplicar Margen")
        Dim pv As Decimal
        If ix = MsgBoxResult.Yes Then
            For j As Integer = 0 To dgv.Rows.Count - 1
                With dgv.Rows(j)
                    If .Cells("s").Value = True Then
                        pv = .Cells("costo").Value * (1 + (Me.margentxt.Text / 100))
                        .Cells("npv").Value = Math.Round(pv, 2)
                    End If
                End With
            Next
        End If
    End Sub

    Private Sub DirectorioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DirectorioBindingSource.EndEdit()
        Me.DirectorioTableAdapter.Update(Me.AdmintegralDataSet.Directorio)
    End Sub

    Private Sub cambio_de_precios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GruposTableAdapter.Fill(Me.AdmintegralDataSet.Grupos)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Directorio' Puede moverla o quitarla según sea necesario.
        Me.DirectorioTableAdapter.FillBytipo(Me.AdmintegralDataSet.Directorio, 1)
        validar_nuevos_productos()
    End Sub

    Private Sub NombreComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedValueChanged
        idpv.Text = NombreComboBox.SelectedValue
        xprov.Checked = True
    End Sub

    Private Sub GrupoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoComboBox.SelectedIndexChanged
        idgp.Text = GrupoComboBox.SelectedValue
        Me.xgrupo.Checked = True
    End Sub

    Private Sub idpv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idpv.KeyPress
        Dim ix As Integer
        If e.KeyChar = chr13 Then
            ix = Me.DirectorioBindingSource.Find("id_directorio", idpv.Text)
            Me.DirectorioBindingSource.Position = ix
        End If
    End Sub

    Private Sub idgp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idgp.KeyPress
        Dim ix As Integer
        ix = Me.GruposBindingSource.Find("id_grupos", Me.idgp.Text)
        Try
            Me.GruposBindingSource.Position = ix
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargar_catalogo()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String
        cmd = "SELECT dbo.productos.id_Directorio AS Pv, dbo.productos.id_Grupo AS Gp, dbo.productos.id_Producto AS Id, dbo.productos.Descripcion, dbo.productos.margen, " _
        & " dbo.Unidades_productos.Unidad, dbo.Unidades_productos.factor, productos_info.costo_anterior as 'C.Ante', dbo.Unidades_productos.costo, dbo.Unidades_productos.venta, " _
        & " ROUND((dbo.Unidades_productos.venta / dbo.Unidades_productos.costo - .099) * 10, 2) AS Mr, case when dbo.productos.precio_unico=0 then ROUND(dbo.Unidades_productos.costo * 1.1, 2) else  dbo.Unidades_productos.venta END AS NPV " _
        & " FROM dbo.productos INNER JOIN " _
        & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto INNER JOIN " _
        & "productos_info ON productos.id_Producto = productos_info.Id " _
        & " WHERE dbo.Unidades_productos.factor = 1 "
        If xgrupo.Checked = True Then cmd += " And dbo.productos.id_Grupo = " + idgp.Text
        If xprov.Checked = True Then cmd += " And dbo.productos.id_Directorio = " + idpv.Text
        If Me.chkdescripcion.Checked = True Then cmd += " and dbo.productos.Descripcion like '%" + Me.descripciontxt.Text + "%'"
        Dim tbl As DataTable = leer_tabla(cmd)
        bs.DataSource = tbl
        dgv.DataSource = bs
        If dgv.Columns.Count = 12 Then
            Dim column As New DataGridViewCheckBoxColumn
            With column
                .Name = "S"
                .HeaderText = "S"
                .DataPropertyName = "S"
            End With
            dgv.Columns.Insert(12, column)
        End If

        dgv.Columns("NPV").DefaultCellStyle.Format = "N2"
        dgv.Columns("NPV").DefaultCellStyle.BackColor = Color.YellowGreen
        dgv.Columns("VENTA").DefaultCellStyle.Format = "N2"
        dgv.Columns("costo").DefaultCellStyle.Format = "N2"
        dgv.Columns("C.Ante").DefaultCellStyle.Format = "N2"
        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                If .Cells("NPV").Value < .Cells("venta").Value Then .DefaultCellStyle.ForeColor = Color.Green
                If .Cells("NPV").Value > .Cells("venta").Value Then .DefaultCellStyle.ForeColor = Color.Red
            End With
        Next
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub boton_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Cargar.Click
        cargar_catalogo()
        dgv.Parent = Me.SplitContainer3.Panel2

    End Sub

    Private Sub aplicar_catalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aplicar_catalogo.Click
        Dim ix As MsgBoxResult = MsgBox("Aplicar Margen a los seleccionados", MsgBoxStyle.YesNo, "Aplicar Margen")
        Dim pv As Decimal
        If ix = MsgBoxResult.Yes Then
            For j As Integer = 0 To dgv.Rows.Count - 1
                With dgv.Rows(j)
                    If .Cells("s").Value = True Then
                        pv = .Cells("costo").Value * (1 + (Me.margen1txt.Text / 100))
                        .Cells("npv").Value = Math.Round(pv, 2)
                    End If
                End With
            Next
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 2 Then
            Dim cmd As String = "SELECT fecha FROM cambio_de_precios GROUP BY fecha order by fecha DESC"
            Dim tbl As DataTable = leer_tabla(cmd)
            dgvfechas.DataSource = tbl
        End If
    End Sub
    Private Sub cargar_reporte(ByVal fecha As Date)
        Me.rpt_cambio_de_preciosTableAdapter.FillByFecha(Me.AdmintegralDataSet.rpt_cambio_de_precios, fecha)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Cambio de Precios " + fecha.ToShortDateString, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dgvfechas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfechas.CellClick
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        cargar_reporte(dgvfechas.CurrentRow.Cells("fecha").Value)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
    End Sub ' Etiquetas de lo que cambio de precio
    Private Sub cargar_etiquetas(ByVal fecha As Date)
        Dim cmd = "SELECT     Lista_de_ventas.id_producto, Lista_de_ventas.id_unidad, Lista_de_ventas.Codigo, Lista_de_ventas.Unidad, Lista_de_ventas.factor, Lista_de_ventas.unidades, " _
& " Lista_de_ventas.costo, Lista_de_ventas.venta, Lista_de_ventas.Descripcion, Lista_de_ventas.peso, Lista_de_ventas.iva, Lista_de_ventas.precio_unico, " _
& "Lista_de_ventas.und_venta, Lista_de_ventas.und_compra FROM Lista_de_ventas INNER JOIN " _
& " cambio_de_precios ON Lista_de_ventas.id_producto = cambio_de_precios.id_producto " _
& "WHERE cambio_de_precios.fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy-mm-dd") + " 00:00:00', 102))"
        Dim tbl As DataTable = leer_tabla(cmd)
        Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("lista", tbl)
        ReportViewer2.LocalReport.DataSources.Add(datasource)

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        'Dim factor As Decimal = 1 + (Val(Me.Factortxt.Text) / 100)
        ' Dim codigo As String
        'codigo = Mid(".........", 1, Val(Factortxt.Text))
        'rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("FACTOR", factor, False)
        'rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("codigo", codigo, False)
        'rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("iva", Me.ivatxt.Text, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(2) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Lista_de_ventas' Puede moverla o quitarla según sea necesario.
        'Me.Lista_de_ventasTableAdapter.FillBytest(Me.AdmintegralDataSet.Lista_de_ventas)
        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Sub descripciontxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles descripciontxt.TextChanged
        Try
            Dim filtro As String = preparar_filtro("descripcion", Me.descripciontxt.Text)
            bs.Filter = filtro
        Catch ex As Exception
            bs.Filter = ""
        End Try
        
    End Sub

    Private Sub boton_cargar_todo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cargar_todo.Click
        cargar_todo()
        dgv.Parent = Me.SplitContainer3.Panel2

    End Sub

    Private Sub cargar_todo()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String
        cmd = "SELECT dbo.productos.id_Directorio AS Pv, dbo.productos.id_Grupo AS Gp, dbo.productos.id_Producto AS Id, dbo.productos.Descripcion, dbo.productos.margen, " _
        & " dbo.Unidades_productos.Unidad, dbo.Unidades_productos.factor, productos_info.costo_anterior as 'C.Ante', dbo.Unidades_productos.costo, dbo.Unidades_productos.venta, " _
        & " ROUND((dbo.Unidades_productos.venta / dbo.Unidades_productos.costo - .099) * 10, 2) AS Mr, case when dbo.productos.precio_unico=0 then ROUND(dbo.Unidades_productos.costo * 1.1, 2) else  dbo.Unidades_productos.venta END AS NPV " _
        & " FROM dbo.productos INNER JOIN " _
        & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto INNER JOIN " _
        & "productos_info ON productos.id_Producto = productos_info.Id " _
        & " WHERE dbo.Unidades_productos.factor = 1 and  dbo.Unidades_productos.costo >0"
        Dim tbl As DataTable = leer_tabla(cmd)
        bs.DataSource = tbl
        dgv.DataSource = bs
        If dgv.Columns.Count = 12 Then
            Dim column As New DataGridViewCheckBoxColumn
            With column
                .Name = "S"
                .HeaderText = "S"
                .DataPropertyName = "S"
            End With
            dgv.Columns.Insert(12, column)
        End If

        dgv.Columns("NPV").DefaultCellStyle.Format = "N2"
        dgv.Columns("NPV").DefaultCellStyle.BackColor = Color.YellowGreen
        dgv.Columns("VENTA").DefaultCellStyle.Format = "N2"
        dgv.Columns("costo").DefaultCellStyle.Format = "N2"
        dgv.Columns("C.Ante").DefaultCellStyle.Format = "N2"
        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                If .Cells("NPV").Value < .Cells("venta").Value Then .DefaultCellStyle.ForeColor = Color.Green
                If .Cells("NPV").Value > .Cells("venta").Value Then .DefaultCellStyle.ForeColor = Color.Red
            End With
        Next
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

End Class




