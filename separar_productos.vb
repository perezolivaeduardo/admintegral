Public Class separar_productos

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.AdmintegralDataSet.productos)

    End Sub

    Private Sub separar_productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.AdmintegralDataSet.Grupos)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.AdmintegralDataSet.productos)
        Me.Close()
    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Me.ProductosBindingSource.Filter = "id_grupo = " + Me.idgp.Text
    End Sub

    Private Sub btn_marcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_marcar.Click
        For j As Integer = 0 To Me.ProductosDataGridView.Rows.Count - 1
            With Me.ProductosDataGridView.Rows(j)
                .Cells("dgvseparar").Value = True
            End With
        Next
    End Sub

    Private Sub btn_desmarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_desmarcar.Click
        For j As Integer = 0 To Me.ProductosDataGridView.Rows.Count - 1
            With Me.ProductosDataGridView.Rows(j)
                .Cells("dgvseparar").Value = False
            End With
        Next
    End Sub

    Private Sub fil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fil.TextChanged
        Try
            Dim filtro As String
            filtro = preparar_filtro("descripcion", fil.Text)
            Me.ProductosBindingSource.Filter = filtro

        Catch ex As Exception

        End Try
    End Sub
End Class