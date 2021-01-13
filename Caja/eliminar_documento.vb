Public Class eliminar_documento

    Private Sub eliminar_documento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.sql_documentos_clientes' Puede moverla o quitarla según sea necesario.
        Me.Sql_documentos_clientesTableAdapter.fill_un_documento(Me.AdmintegralDataSet.sql_documentos_clientes, td.Text, folio.Text, serie.Text)
        If Me.NombreTextBox.TextLength > 0 Then
            Me.Button3.Enabled = True
        Else
            Me.Button3.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dadap As New integraDataSetTableAdapters.DocumentosTableAdapter
        Dim fadap As New integraDataSetTableAdapters.fei_cfdTableAdapter
        Dim padap As New integraDataSetTableAdapters.pagos_detalleTableAdapter

        dadap.eliminar_registro(Me.td.Text, folio.Text, serie.Text)
        fadap.eliminar_registro(td.Text, folio.Text, serie.Text)
        'padap.Eliminar_registro(td.Text, folio.Text, serie.Text)
        MsgBox("Registro eliminados")

    End Sub
End Class