Public Class Pedidos_crear
    Private AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
    Private bindingSource1 As New BindingSource()
    Dim tabla As New DataTable() 'tabla del detalle de pedido


    Private Sub Pedidos_crear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.View_gruposporprovTableAdapter.Fill(Me.AdmintegralDataSet.View_gruposporprov)
            Me.View_DeptosporprovTableAdapter.Fill(Me.AdmintegralDataSet.View_Deptosporprov)

        Catch ex As Exception

        End Try

        Me.DirectorioTableAdapter.FillBytipo(Me.AdmintegralDataSet.Directorio, 1)

        Me.todos_grupos.Checked = True
        Me.todos_deptos.Checked = True
        

    End Sub

    Private Sub todos_deptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todos_deptos.CheckedChanged
        Me.dgvdeptos.Enabled = Not Me.todos_deptos.Checked
    End Sub

    Private Sub todos_grupos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todos_grupos.CheckedChanged
        Me.dgvgrupos.Enabled = Not Me.todos_grupos.Checked
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Dim f As Date = Date.Now
        al.Text = Date.Now
        del.Text = f.AddDays(Me.NumericUpDown1.Value * -1)
    End Sub

    Private Sub Boton_preparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_preparar.Click
        Dim x As MsgBoxResult
        x = MsgBox("Preparar Pedido", MsgBoxStyle.YesNo, "")
        If x <> MsgBoxResult.Yes Then Exit Sub
        preparar_pedido()
    End Sub

    Private Sub preparar_pedido()
        Dim pv As Integer
        Dim cmd, cs As String
        Me.status1.Text = "Preparando Consulta"
        pv = Me.NombreComboBox.SelectedValue
        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT id_Producto,ub_und,ub_costo,ub_venta,ISNULL(sql_Existencias.Existencia, 0) AS existenciaB,0.000 as [vendidasb] ,iduc,uc,factorc,0 as [pedido],0 as [costopedido],0 as [facturado],0 as [costofactura],0 as [Entrada],0 as [costoentrada]  FROM sql_Undcompra "
        cmd = cmd + " LEFT OUTER JOIN sql_Existencias ON sql_Undcompra.id_Producto = sql_Existencias.id_prodcuto"
        cmd = cmd + " WHERE id_Directorio = " + pv.ToString

        If IvaTextBox.Text = "" Then IvaTextBox.Text = "15"
        If DiasTextBox.Text = "" Then DiasTextBox.Text = "0"

        If Me.todos_deptos.CheckState = CheckState.Unchecked Then 'Si selecciono algunos deptos
            Dim j As Integer
            Dim d As String, filtrodep As String
            filtrodep = " and ("
            For j = 0 To Me.dgvdeptos.Rows.Count - 1
                If Me.dgvdeptos.Rows(j).Cells(2).Value = True Then
                    If filtrodep.Length > 6 Then filtrodep = filtrodep + " or "
                    d = Me.dgvdeptos.Rows(j).Cells(0).Value
                    filtrodep = filtrodep + "id_Depto = " + d + " "
                    End If
            Next
            filtrodep = filtrodep + ")"
            cmd = cmd + filtrodep
            End If

        If Me.todos_grupos.CheckState = CheckState.Unchecked Then
            Dim j As Integer, g, filtrogpo As String
            filtrogpo = " and ("
            For j = 0 To Me.dgvgrupos.Rows.Count - 1
                If Me.dgvgrupos.Rows(j).Cells(2).Value = True Then
                    If filtrogpo.Length > 6 Then filtrogpo = filtrogpo + " or "
                    g = Me.dgvgrupos.Rows(j).Cells(0).Value
                    filtrogpo = filtrogpo + "id_Grupo = " + g
                    End If
            Next
            filtrogpo = filtrogpo + ")"
            cmd = cmd + filtrogpo
        End If


        '  Genera la consulta y la carga en el grid
        '=======================================================
        status1.Text = "Calculando Existencias" : status1.Visible = True
        Me.Refresh()
        Me.StatusStrip1.Refresh()
        Me.AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(Me.AdaptadorDeDatos)

        Try
            Me.AdaptadorDeDatos.Fill(tabla)
            Me.bindingSource1.DataSource = tabla
            dgv.DataSource = Me.bindingSource1
            dgv.Refresh()
        Catch ex As Exception
            MsgBox("Error al crearla consulta")
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Me.Refresh()
        If dgv.Rows.Count = 0 Then MsgBox("No existe productos para este criterio de Busqueda") : Exit Sub
        status1.Text = "Calculando Ventas "
        barra.Visible = True : barra.Maximum = Me.dgv.Rows.Count
        Dim adap As New AdmintegralDataSetTableAdapters.movimientosTableAdapter
        Dim id As Long, vendidas As Single
        Dim celdaventas As Integer = 5
        For j As Integer = 0 To Me.dgv.Rows.Count - 2
            barra.Value = j
            id = Me.dgv.Rows(j).Cells(0).Value
            Try
                vendidas = IIf(adap.und_ven_periodoxid(del.Text, al.Text, id) = -1, 0, adap.und_ven_periodoxid(del.Text, al.Text, id))
            Catch ex As Exception
                vendidas = 0
            End Try

            Me.dgv.Rows(j).Cells(celdaventas).Value = CDbl(vendidas)
            tabla.Rows(j).Item(5) = vendidas
        Next
        barra.Visible = False
        adap.Dispose()
        status1.Text = "Guardando Pedido"

        Dim dpedido As New AdmintegralDataSetTableAdapters.Pedidos_detalleTableAdapter
        Dim apedido As New AdmintegralDataSetTableAdapters.pedidosTableAdapter
        Dim np As Long
        Try
            np = apedido.nuevo_folio
        Catch ex As Exception
            np = 1
        End Try

        apedido.Insert(np, pv.ToString, Now.Date, "?", False, DiasTextBox.Text, " ", Val(IvaTextBox.Text), 0, 0, 0, 0)
        apedido.Dispose()
        barra.Visible = True
        barra.Value = 0 : Dim rw As Integer
        Dim r As DataRow
        For rw = 0 To Me.dgv.Rows.Count - 2
            barra.Value = rw
            r = tabla.Rows(rw)
            dpedido.Insert(np, r.Item(0), r.Item(1), r.Item(2), r.Item(3), r.Item(4), r.Item(5), r.Item(6), r.Item(7), r.Item(8), 0, 0, 0, 0, 0, 0, " ")
        Next
        barra.Visible = False
        dpedido.Dispose()
        status1.Text = "Pedido Preparado"

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.pedidos_modificar.MdiParent = Me.MdiParent
        My.Forms.pedidos_modificar.cargar_pedido(np)
        My.Forms.pedidos_modificar.Visible = False
        My.Forms.pedidos_modificar.Show()
        My.Forms.pedidos_modificar.calcular()
        My.Forms.pedidos_modificar.Visible = True
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.Close()
    End Sub 'Prepra la consulta del pedido

    
    Private Sub idpv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idpv.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Try
                Dim i As Integer = idpv.Text
                Dim ix As Integer = Me.DirectorioBindingSource.Find("id_directorio", i)
                If ix >= 0 Then
                    Me.DirectorioBindingSource.Position = ix
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class