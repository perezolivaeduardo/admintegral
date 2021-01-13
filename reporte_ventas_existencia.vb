Public Class reporte_ventas_existencia

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Me.id.Text = gprov.id
        Me.nombre.Text = gprov.nombre
    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        crear_reporte(Me.id.Text, Date.Now, Now.AddMonths(-1))
        Dim del, al, periodo As String
        al = Format(Date.Now, "dd-MM-yyyy")
        del = Format(Now.AddMonths(-1), "dd-MM-yyyy")
        periodo = "Periodo del " + del + " al " + al

        'TODO: esta línea de código carga datos en la tabla 'reporteDataSet.reporte_ventas_existencia' Puede moverla o quitarla según sea necesario.
        Me.reporte_ventas_existenciaTableAdapter.Fill(Me.reporteDataSet.reporte_ventas_existencia)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", Me.nombre.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("Periodo", periodo, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class