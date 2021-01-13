Public Class Editar_producto

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Editar_producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.AdmintegralDataSet.productos)
        Me.Unidades_productosBindingSource.EndEdit()
        Me.Unidades_productosTableAdapter.Update(Me.AdmintegralDataSet.Unidades_productos)
    End Sub

    Public Sub cargar(ByVal id As Integer)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Unidades_productos' Puede moverla o quitarla según sea necesario.
        Me.Unidades_productosTableAdapter.FillById(Me.AdmintegralDataSet.Unidades_productos, id)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.FillByID(Me.AdmintegralDataSet.productos, id)
    End Sub

    Private Sub Unidades_productosDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Dim costo, venta As String
        costo = dgv.CurrentRow.Cells("dgvcosto").Value
        venta = dgv.CurrentRow.Cells("dgvventa").Value
        If venta < costo Then
            MsgBox("El precio de venta no puede ser menor que el costo")
        End If
    End Sub

    Private Sub Id_DirectorioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_DirectorioTextBox.TextChanged
        Try
            Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
            Me.proveedor.Text = adap.GetDataByID(Me.Id_DirectorioTextBox.Text, 1).Rows(0).Item("Nombre")
        Catch ex As Exception
            Me.proveedor.Text = ""
        End Try
    End Sub
End Class