Public Class frm_login
    Dim cadenas(0 To 5) As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        login = identificacion(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text, 0)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        My.Settings.Save()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlname(My.Settings.sqlserver)
        Me.Text = "Login " + sql_servidor + "/" + sql_catalogo
        If My.Settings.Recordar = False Then
            Me.PasswordTextBox.Text = ""
            Me.UsernameTextBox.Text = ""
        End If
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("c:\datos\integral.ini")
        If fileExists Then
            combocadena.Items.Clear()
            Dim l, nombre, cadena As String, i As Integer = 0
            Dim f As Integer = FreeFile() : FileOpen(FreeFile, "c:\datos\integral.ini", OpenMode.Input)
            While Not EOF(f)
                l = LineInput(f)
                nombre = Mid(l, 1, InStr(l, ","))
                cadena = Mid(l, InStr(l, ",") + 1)
                cadenas(i) = cadena : i += 1
                combocadena.Items.Add(nombre)
            End While
            FileClose(f)
        End If

    End Sub 'lee usuario si esta activado recordar

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        My.Settings.Save()
    End Sub

    Private Sub UsernameTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress, PasswordTextBox.KeyPress
        If e.KeyChar = chr13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.Autorizacion.cambiar_clave()
        My.Forms.Autorizacion.ShowDialog()
    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click
        UsernameTextBox.Text = "edu"
        PasswordTextBox.Text = "1"
        'MsgBox(My.Settings.AdmintegralConnectionString)
    End Sub

    Private Sub combocadena_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combocadena.SelectedIndexChanged
        boton_ok.Visible = True
    End Sub

    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        Dim mio As String
        'Carga INI
        '==============================================================================================
        Dim ff As Integer = FreeFile() : FileOpen(ff, "c:\tmp\caja.ini", OpenMode.Input)
        Try

            With My.Settings
                .ncaja = LineInput(ff)
                .solocaja = LineInput(ff)
                .almacen = LineInput(ff)
                .iva = LineInput(ff)
                .margen = LineInput(ff)
                .puedeAutorizar = LineInput(ff)
                .impresora_ticket = LineInput(ff)
                .impresora_factura = LineInput(ff)
                .Impresora_reportes = LineInput(ff)
                mio = LineInput(ff)
                .Cobrar_tarjeta = LineInput(ff)
                .terminal = LineInput(ff)
                .logo = LineInput(ff)
                mio = LineInput(ff)
                .sqlsat = LineInput(ff)
            End With
            FileClose(ff)
        Catch ex As Exception
            FileClose(ff)
        End Try

        My.Settings.sqlserver = cadenas(combocadena.SelectedIndex)
        sqlname(My.Settings.sqlserver)
        Me.Text = "Login  on " + sql_servidor + "/" + sql_catalogo
        My.Settings.Save()
        Dim f As New System.IO.StreamWriter("C:\tmp\caja.ini", False)
        With My.Settings
            f.WriteLine(.ncaja)
            f.WriteLine(.solocaja)
            f.WriteLine(.almacen)
            f.WriteLine(.iva)
            f.WriteLine(.margen)
            f.WriteLine(.puedeAutorizar)
            f.WriteLine(.impresora_ticket)
            f.WriteLine(.impresora_factura)
            f.WriteLine(.Impresora_reportes)
            f.WriteLine(.sqlserver)
            f.WriteLine(.Cobrar_tarjeta)
            f.WriteLine(.terminal)
            f.WriteLine(.logo)
            f.WriteLine("")
            f.WriteLine(.sqlsat)
            f.WriteLine("")
        End With
        f.Close()

    End Sub

    Private Sub LogoPictureBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.DoubleClick
        combocadena.Visible = True
    End Sub
End Class
