<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autorizacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.usuariotxt = New System.Windows.Forms.TextBox
        Me.pwtxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grupo = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Button1 = New System.Windows.Forms.Button
        Me.boton_cambiar = New System.Windows.Forms.Button
        Me.npw1 = New System.Windows.Forms.TextBox
        Me.npw = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cpw = New System.Windows.Forms.TextBox
        Me.cusuario = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(71, 80)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'usuariotxt
        '
        Me.usuariotxt.Location = New System.Drawing.Point(116, 8)
        Me.usuariotxt.MaxLength = 10
        Me.usuariotxt.Name = "usuariotxt"
        Me.usuariotxt.Size = New System.Drawing.Size(100, 20)
        Me.usuariotxt.TabIndex = 1
        '
        'pwtxt
        '
        Me.pwtxt.Location = New System.Drawing.Point(116, 36)
        Me.pwtxt.MaxLength = 10
        Me.pwtxt.Name = "pwtxt"
        Me.pwtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.pwtxt.Size = New System.Drawing.Size(100, 20)
        Me.pwtxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminTegral.My.Resources.Resources.Vista_Key
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Grupo
        '
        Me.Grupo.Controls.Add(Me.TableLayoutPanel2)
        Me.Grupo.Controls.Add(Me.npw1)
        Me.Grupo.Controls.Add(Me.npw)
        Me.Grupo.Controls.Add(Me.Label6)
        Me.Grupo.Controls.Add(Me.Label5)
        Me.Grupo.Controls.Add(Me.Label3)
        Me.Grupo.Controls.Add(Me.Label4)
        Me.Grupo.Controls.Add(Me.cpw)
        Me.Grupo.Controls.Add(Me.cusuario)
        Me.Grupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grupo.Location = New System.Drawing.Point(0, 0)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Size = New System.Drawing.Size(227, 118)
        Me.Grupo.TabIndex = 6
        Me.Grupo.TabStop = False
        Me.Grupo.Text = "Cambiar Clave"
        Me.Grupo.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.boton_cambiar, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(75, 83)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(76, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancelar"
        '
        'boton_cambiar
        '
        Me.boton_cambiar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.boton_cambiar.Enabled = False
        Me.boton_cambiar.Location = New System.Drawing.Point(3, 3)
        Me.boton_cambiar.Name = "boton_cambiar"
        Me.boton_cambiar.Size = New System.Drawing.Size(67, 23)
        Me.boton_cambiar.TabIndex = 0
        Me.boton_cambiar.Text = "Cambiar"
        '
        'npw1
        '
        Me.npw1.Location = New System.Drawing.Point(85, 96)
        Me.npw1.MaxLength = 10
        Me.npw1.Name = "npw1"
        Me.npw1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.npw1.Size = New System.Drawing.Size(100, 20)
        Me.npw1.TabIndex = 12
        '
        'npw
        '
        Me.npw.Location = New System.Drawing.Point(85, 74)
        Me.npw.MaxLength = 10
        Me.npw.Name = "npw"
        Me.npw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.npw.Size = New System.Drawing.Size(100, 20)
        Me.npw.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Confirmar :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nueva clave :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Usuario :"
        '
        'cpw
        '
        Me.cpw.Location = New System.Drawing.Point(85, 44)
        Me.cpw.MaxLength = 10
        Me.cpw.Name = "cpw"
        Me.cpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cpw.Size = New System.Drawing.Size(100, 20)
        Me.cpw.TabIndex = 6
        '
        'cusuario
        '
        Me.cusuario.Location = New System.Drawing.Point(85, 19)
        Me.cusuario.MaxLength = 10
        Me.cusuario.Name = "cusuario"
        Me.cusuario.Size = New System.Drawing.Size(100, 20)
        Me.cusuario.TabIndex = 5
        '
        'Autorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(227, 118)
        Me.Controls.Add(Me.Grupo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pwtxt)
        Me.Controls.Add(Me.usuariotxt)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Autorizacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizacion"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo.ResumeLayout(False)
        Me.Grupo.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents usuariotxt As System.Windows.Forms.TextBox
    Friend WithEvents pwtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grupo As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents boton_cambiar As System.Windows.Forms.Button
    Friend WithEvents npw1 As System.Windows.Forms.TextBox
    Friend WithEvents npw As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cpw As System.Windows.Forms.TextBox
    Friend WithEvents cusuario As System.Windows.Forms.TextBox

End Class
