Public Class diario_ventas

    Public Sub cargar_reporte(ByVal serie As String, ByVal fecha As Date, ByVal reporte As String, ByVal fechaAL As Date)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_documentos_clientes' Puede moverla o quitarla según sea necesario.
        Me.admintegralDataSet.sql_documentos_clientes.Clear()
        Me.admintegralDataSet.EnforceConstraints = False
        Me.sql_documentos_clientesTableAdapter.FillByseriePeriodo(Me.admintegralDataSet.sql_documentos_clientes, serie, Format(fecha, "yyyy-MM-dd"), Format(fechaAL, "yyyy-MM-dd"))
        preparar_reporte(reporte)
    End Sub

    Private Sub preparar_reporte(ByVal reporte As String)
        For j As Integer = 0 To Me.admintegralDataSet.sql_documentos_clientes.Rows.Count - 1
            With Me.admintegralDataSet.sql_documentos_clientes
                If .Rows(j).Item("status") <> 0 Then
                    .Rows(j).Item("Nombre") = "**** CANCELADA ***"
                    .Rows(j).Item("sub0") = 0
                    .Rows(j).Item("sub10") = 0
                    .Rows(j).Item("iva10") = 0
                    .Rows(j).Item("importe") = 0
                    .Rows(j).Item("ieps") = 0
                End If
                If .Rows(j).Item("id_cartera") = 3 Then
                    .Rows(j).Item("id_cartera") = 0
                End If

            End With
        Next

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Dim rp(0 To 5) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("cajero", user.nombre, True)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("caja", My.Settings.ncaja, True)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("fecha_reporte", Format(Now.Date, "d") + " Hr:" + Format(Now, "HH:MM"), True)
        rp(3) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Format(fecha.Value.Date, "d"), True)
        rp(4) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, True)
        rp(5) = rptlogo

        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Boton_todo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_todo.Click
        cargar_reporte(serietxt.Text, fecha.Value.Date, "Diario de Ventas TODO", fechaAL.Value.Date)
    End Sub

    Private Sub boton_tiket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_tiket.Click
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_documentos_clientes' Puede moverla o quitarla según sea necesario.
        Me.admintegralDataSet.sql_documentos_clientes.Clear()
        Me.sql_documentos_clientesTableAdapter.FillBytd_serie_fecha(Me.admintegralDataSet.sql_documentos_clientes, 5, serietxt.Text, fecha.Value.Date)
        preparar_reporte("Diario de Ventas Tikets")
    End Sub

    Private Sub boton_facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_facturas.Click
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_documentos_clientes' Puede moverla o quitarla según sea necesario.
        Me.admintegralDataSet.sql_documentos_clientes.Clear()
        Me.sql_documentos_clientesTableAdapter.FillByTD_fecha(Me.admintegralDataSet.sql_documentos_clientes, 6, fecha.Value.Date, fechaAL.Value)
        preparar_reporte("Diario de Ventas Facturas")
    End Sub

    Private Sub boton_f_credito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_f_credito.Click
        ' Reporte de Facturas a Credito
        Me.admintegralDataSet.sql_documentos_clientes.Clear()
        Me.sql_documentos_clientesTableAdapter.FillBy_td_serie_fecha_fp(Me.admintegralDataSet.sql_documentos_clientes, 6, serietxt.Text, fecha.Value.Date, 2)
        preparar_reporte("Diario de Ventas CREDITO")
    End Sub

    Private Sub boton_fac_cont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_fac_cont.Click
        ' Reporte de Facturas a Credito
        Me.admintegralDataSet.sql_documentos_clientes.Clear()
        Me.sql_documentos_clientesTableAdapter.FillBy_td_serie_fecha_fp(Me.admintegralDataSet.sql_documentos_clientes, 6, serietxt.Text, fecha.Value.Date, 0)
        preparar_reporte("Diario de Ventas CONTADO")
    End Sub

   
    Private Sub fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecha.ValueChanged
        fechaAL.Value = fecha.Value
    End Sub
End Class