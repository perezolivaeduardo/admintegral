Public Class frm_listas

    Private Sub frm_listas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListasTableAdapter.Fill(Me.AdmintegralDataSet.Listas)
    End Sub

    Private Sub ListasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListasBindingNavigatorSaveItem.Click, Boton_salir.Click
        Me.Validate()
        Me.ListasBindingSource.EndEdit()
        Me.ListasTableAdapter.Update(Me.AdmintegralDataSet.Listas)
    End Sub
End Class
