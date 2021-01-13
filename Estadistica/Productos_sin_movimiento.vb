Public Class Productos_sin_movimiento

    Private Sub Productos_sin_movimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
    End Sub
    Private Sub actualizar_info()
        Dim fdel, fal As String
        fdel = Format(del.Value.Date, "yyyy-MM-dd")
        fal = Format(al.Value.Date, "yyyy-MM-dd")
        'consulta para actualizar ultima fecha de entrada.
        Dim cmd As String = "UPDATE  productos_info SET fecha_u_entrada = sys_ultima_feha_entrada.[F.entrada] "
        cmd += " FROM productos_info INNER JOIN sys_ultima_feha_entrada ON productos_info.Id = sys_ultima_feha_entrada.id_prodcuto "
        comando(cmd)

        'actualiza unidades vendidas
        cmd = "UPDATE productos_info set uvendidas = 0"
        If comando(cmd) = False Then MsgBox("Error al poner a ceros u.vendidas")

        cmd = "Update productos_info set uvendidas = 1 FROM movimientos INNER JOIN productos_info ON movimientos.id_prodcuto = productos_info.Id "
        cmd += "WHERE (movimientos.id_doc = 5 OR movimientos.id_doc = 6) AND (movimientos.fecha > CONVERT(DATETIME, '[del] 00:00:00', 102)) "
        cmd += " AND (movimientos.fecha < CONVERT(DATETIME, '[al] 00:00:00', 102)) "
        If alma.Checked = True Then
            cmd += "AND movimientos.almacen = " + Me.AlmacenComboBox.SelectedValue.ToString
        End If
        cmd = cmd.Replace("[del]", fdel)
        cmd = cmd.Replace("[al]", fal)

        If comando(cmd) = False Then MsgBox("Error determinar unidades vendidas")



    End Sub



    Private Sub boton_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cargar.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        actualizar_info()
        'TODO: esta línea de código carga datos en la tabla 'reporteDataSet.rpt_sin_ventas' Puede moverla o quitarla según sea necesario.
        Me.rpt_sin_ventasTableAdapter.Fill(Me.reporteDataSet.rpt_sin_ventas)
        refrescar()
        Panel1.Enabled = True
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub boton_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_refresh.Click
        REFRESCAR()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.grupotxt.Text = "TODOS"
    End Sub

    Private Sub boton_busca_prov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_busca_prov.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Me.proveedortxt.Text = gprov.nombre
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.proveedortxt.Text = "TODOS"
    End Sub

    Private Sub refrescar()
        Dim rep As String
        If Me.alma.Checked = False Then
            rep = "Productos sin ventas en el periodo en todas las tiendas"
        Else
            rep = "Productos sin ventas en el periodo en " + Me.AlmacenComboBox.Text
        End If
        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("GRUPO", Me.grupotxt.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", rep, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("proveedor", Me.proveedortxt.Text, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class