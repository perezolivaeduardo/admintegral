Public Class frm_productos_tabla

    
    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.AdmintegralDataSet.productos)

    End Sub

    Private Sub frm_productos_tabla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Unidades_productosTableAdapter.Fill(Me.AdmintegralDataSet.Unidades_productos)
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)

    End Sub
End Class