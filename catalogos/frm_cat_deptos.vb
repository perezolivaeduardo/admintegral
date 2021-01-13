Public Class frm_cat_deptos

    Private Sub frm_cat_deptos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.Validate()
        Me.DepartamentosBindingSource.EndEdit()
        Me.DepartamentosTableAdapter.Update(Me.AdmintegralDataSet.Departamentos)
    End Sub

    Private Sub frm_cat_deptos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DepartamentosTableAdapter.Fill(Me.AdmintegralDataSet.Departamentos)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
