Public Class Existencias_reporte

    Private Sub Existencias_reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      

        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.admintegralDataSet.tbl_almacenes)
    End Sub

    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        Dim al As Integer
        admintegralDataSet.EnforceConstraints = False
        al = Me.AlmacenComboBox.SelectedValue
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_existencias_x_almacen' Puede moverla o quitarla según sea necesario.
        Me.sql_existencias_x_almacenTableAdapter.FillBy_Almacen(Me.admintegralDataSet.sql_existencias_x_almacen, al)
        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Reporte de Existencias al " + Format(Now.AddDays(-1), "d"), False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("Almacen", Me.AlmacenComboBox.Text, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(2) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class