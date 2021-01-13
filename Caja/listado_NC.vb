Public Class listado_NC

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim reporte As String
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_documentos_clientes' Puede moverla o quitarla según sea necesario.
        If opnc.Checked = True Then
            Me.sql_documentos_clientesTableAdapter.FillByncredito(Me.admintegralDataSet.sql_documentos_clientes, fecha_al.Value.Date, fecha_del.Value.Date)
            reporte = "Relacion de Notas de Credito"
        Else
            Me.sql_documentos_clientesTableAdapter.FillBybonificaciones(Me.admintegralDataSet.sql_documentos_clientes, fecha_al.Value.Date, fecha_del.Value.Date)
            reporte = "Relacion de Bonificaciones"
        End If


        Dim ti As String
        With Me.admintegralDataSet.sql_documentos_clientes
            For j As Integer = 0 To .Rows.Count - 1
                If .Rows(j).Item("status") = 1 Then
                    .Rows(j).Item("Nombre") = "***  Cancelada   ***"
                    For y As Integer = 14 To 23 : .Rows(j).Item(y) = 0 : Next y
                End If
            Next
        End With

        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter
        If fecha_del.Value.Date = fecha_al.Value.Date Then
            ti = Format(fecha_del.Value.Date, "D")
            rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("encabezados", True, False)
        Else
            ti = "Periodo del " + Format(fecha_del.Value, "d") + " al " + Format(fecha_al.Value, "d")
            rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("encabezados", False, False)
        End If
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("Titulo", ti, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(3) = rptlogo
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class