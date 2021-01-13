Public Class cxc_resumen_diario

    Private Sub cxc_resumen_diario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        Me.cxc_resumen_diarioTableAdapter.FillByperiodo(Me.reporteDataSet.cxc_resumen_diario, fechadel.Value, fechaal.Value)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        Dim reporte As String = "Resumen de Cobranza por Dia del " + fechadel.Value.ToShortDateString + " al " + fechaal.Value.ToShortDateString
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
End Class