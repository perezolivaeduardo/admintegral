Public Class pedir_documento

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub folio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles folio.KeyPress
        If e.KeyChar = chr13 Then
            Dim c1, c2 As String, td As Integer = 6
            c1 = Mid(folio.Text, 1, 1)
            c2 = Mid(folio.Text, 2)
            If Me.opTicket.Checked = True Then td = 5
            If Me.opnc.Checked = True Then td = 7
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            My.Forms.Consultar_una_factura.cargar_docuemnto(td, c2, c1)
            Me.Close()
            Windows.Forms.Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub folio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles folio.TextChanged

    End Sub
End Class