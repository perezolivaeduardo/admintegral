Public Class frm_agentes


    Private Sub AgentesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AgentesBindingSource.EndEdit()
        Me.AgentesTableAdapter.Update(Me.AdmintegralDataSet.Agentes)

    End Sub

    Private Sub frm_agentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AgentesTableAdapter.Fill(Me.AdmintegralDataSet.Agentes)

    End Sub
End Class