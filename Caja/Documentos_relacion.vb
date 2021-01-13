Public Class Documentos_relacion
    Dim td As Integer
    Dim serie As String

    Private Sub boton_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cargar.Click
        td = Me.tipocombo.SelectedIndex + 5
        serie = serietxt.Text
        Me.Sql_documentos_clientesTableAdapter.FillBytipo_serie(Me.AdmintegralDataSet.sql_documentos_clientes, td, serie)
    End Sub

    Private Sub boton_filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_filtro.Click
        Dim f As String = "fechafactura = '" + fecha.Text + "'"
        Me.Sql_documentos_clientesBindingSource.Filter = f
    End Sub
End Class