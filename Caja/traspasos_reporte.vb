Public Class traspasos_reporte

    Private Sub traspasos_reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_traspasos' Puede moverla o quitarla según sea necesario.
        Me.sql_traspasosTableAdapter.FillByfecha(Me.admintegralDataSet.sql_traspasos, Now.Date, Now.Date)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(1) = rptlogo
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Relacion de Traspasos " + Now.Date.ToShortDateString, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub boton_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_refresh.Click
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_traspasos' Puede moverla o quitarla según sea necesario.
        Me.sql_traspasosTableAdapter.FillByfecha(Me.admintegralDataSet.sql_traspasos, del.Value.Date, al.Value.Date)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(1) = rptlogo
        If del.Value <> al.Value Then
            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Traspasos del " + del.Value.Date.ToShortDateString + " al " + al.Value.Date.ToShortDateString, False)
        Else

            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Relacion de Traspasos del " + del.Value.Date.ToShortDateString, False)
        End If

        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class