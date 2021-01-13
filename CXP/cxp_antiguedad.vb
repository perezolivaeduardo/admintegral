Public Class cxp_antiguedad
    Public Sub completo()
        Me.cxp_antiguedadTableAdapter.Fill(Me.integraDataSet.cxp_antiguedad)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub un_proveedor(ByVal id As Integer)
        Me.cxp_antiguedadTableAdapter.FillByid(Me.integraDataSet.cxp_antiguedad, id)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class