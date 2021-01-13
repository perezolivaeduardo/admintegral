Public Class cierre_de_mes

    Private Sub Sys_periodoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Sys_periodoBindingSource.EndEdit()
        Me.Sys_periodoTableAdapter.Update(Me.IntegraDataSet.sys_periodo)

    End Sub

    Private Sub cierre_de_mes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.sql_kardex_resumen' Puede moverla o quitarla según sea necesario.
        Me.Sql_kardex_resumenTableAdapter.Fill(Me.IntegraDataSet.sql_kardex_resumen)
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.sys_periodo' Puede moverla o quitarla según sea necesario.
        Me.Sys_periodoTableAdapter.Fill(Me.IntegraDataSet.sys_periodo)

        Dim reporte As String = "Resumen de movimientos del " + DelDateTimePicker.Value.ToShortDateString + " al " + AlDateTimePicker.Value.ToShortDateString

        Dim rp(0 To 0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("Reporte", reporte, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)






        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        cierre_mes()
        Me.Sys_periodoTableAdapter.Fill(Me.IntegraDataSet.sys_periodo)


    End Sub
End Class