Imports System.Windows.Forms
Public Class Autorizacion
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
        Me.usuariotxt.Text = ""
        Me.pwtxt.Text = ""
        Me.usuariotxt.Focus()
    End Sub

    Private Sub Autorizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = chr13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Grupo.Visible = True
        Me.Height = 187
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Grupo.Visible = False
        Me.Height = 139
        Me.Close()
    End Sub
    Public Sub cambiar_clave()
        Grupo.Visible = True
        Me.Height = 187
    End Sub

    Private Sub boton_cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cambiar.Click
        Dim tblusuarios As New admintegralDataSetTableAdapters.usuariosTableAdapter
        Dim id As Integer
        Try
            id = tblusuarios.lee_id(Me.cusuario.Text, Me.cpw.Text)
        Catch ex As Exception
        End Try
        If id > 0 Then
            tblusuarios.cambia_pw(Me.npw.Text, id)
            MsgBox("Clave cambiada")
            Me.Close()
        Else
            MsgBox("Verificar Usuario y Contraseña")
        End If
    End Sub

    Private Sub npw1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles npw1.TextChanged, npw.TextChanged
        If npw.Text = npw1.Text Then
            Me.boton_cambiar.Enabled = True
        Else
            Me.boton_cambiar.Enabled = False
        End If
    End Sub


End Class
