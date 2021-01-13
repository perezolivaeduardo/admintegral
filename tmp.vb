Public Class tmp

    Private Sub tmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Agentes' Puede moverla o quitarla según sea necesario.
        Me.AgentesTableAdapter.Fill(Me.admintegralDataSet.Agentes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class