Public Class Kardex_resumen

    Public Sub caragr(ByVal id_producto As Integer)
        Dim cmd As String = "select * from sql_kardex_producto where id_doc <3 and id_producto = " + id_producto.ToString + " order by fechafactura DESC"
        Dim tbl As DataTable = leer_tabla(cmd)
        If tbl.Rows.Count = 0 Then Me.ReportViewer1.Visible = False Else Me.ReportViewer1.Visible = True
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
End Class