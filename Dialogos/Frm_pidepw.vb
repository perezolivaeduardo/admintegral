Imports System.Windows.Forms
Public Class frm_pidepw
    Dim cdx, cdy, cdc As Integer, clavedinamica As String, cdpw As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Autorizacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.pwtxt.Text = ""
        Me.pwtxt.Focus()
    End Sub

    Private Sub Autorizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = chr13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    End Class
