Imports System.Windows.Forms

Public Class Pedir_folio

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Pedir_folio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        folio.Focus()
        folio.Select()
    End Sub

   

    Private Sub Pedir_folio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.serie.Text = caja.SerieTextBox.Text
        folio.Focus()
        folio.SelectAll()
    End Sub

    Private Sub folio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles folio.KeyPress
        If e.KeyChar = chr13 Then
            Me.serie.Focus()
        End If
    End Sub

    Private Sub serie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles serie.KeyPress
        If e.KeyChar = chr13 Then
            Me.OK_Button.Focus()
        End If
    End Sub
End Class
