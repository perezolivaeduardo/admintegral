Public Class cxc_relacion_Cheques

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
    Private Sub reporte_recibidos()
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.cxc_relacion_cheques' Puede moverla o quitarla según sea necesario.
        Me.cxc_relacion_chequesTableAdapter.FillByrecibido(Me.admintegralDataSet.cxc_relacion_cheques, fecha.Value.Date, fechaal.Value.Date)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("Reporte", "Cheques Recibidos el " + Format(fecha.Value, "d"), False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub reporte_depositar()
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.cxc_relacion_cheques' Puede moverla o quitarla según sea necesario.
        Me.cxc_relacion_chequesTableAdapter.FillBydeposito(Me.admintegralDataSet.cxc_relacion_cheques, fecha.Value.Date, fechaal.Value.Date)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("Reporte", "Cheques para depositar el " + Format(fecha.Value, "d"), False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(2) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        If recibidos.Checked = True Then
            reporte_recibidos()
        Else
            reporte_depositar()
        End If
    End Sub

    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        fechaal.Value = fecha.Value
    End Sub

    Public Sub cheques_x_ID(ByVal id As Integer)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.cxc_relacion_cheques' Puede moverla o quitarla según sea necesario.
        Me.cxc_relacion_chequesTableAdapter.FillById(Me.admintegralDataSet.cxc_relacion_cheques, id)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("Reporte", "Todos los cheques de un Cliente", False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class