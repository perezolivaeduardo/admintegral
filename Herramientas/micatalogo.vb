Public Class micatalogo

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.AdmintegralDataSet.productos)

    End Sub

    Private Sub micatalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta l�nea de c�digo carga datos en la tabla 'AdmintegralDataSet.productos' Puede moverla o quitarla seg�n sea necesario.
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)

    End Sub
End Class