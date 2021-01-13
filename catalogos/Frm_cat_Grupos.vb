Public Class frm_cat_grupos

    Private Sub frm_cat_grupos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.Validate()
        Me.GruposBindingSource.EndEdit()
        Me.GruposTableAdapter.Update(Me.AdmintegralDataSet.Grupos)
    End Sub

    Private Sub frm_cat_grupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GruposTableAdapter.Fill(Me.AdmintegralDataSet.Grupos)

    End Sub

    Private Sub Boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_salir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
