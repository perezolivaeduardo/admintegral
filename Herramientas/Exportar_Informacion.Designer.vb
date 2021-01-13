<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exportar_Informacion
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.boton_internet = New System.Windows.Forms.ToolStripButton
        Me.boton_usb = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.barra = New System.Windows.Forms.ProgressBar
        Me.filenametxt = New System.Windows.Forms.TextBox
        Me.Folder = New System.Windows.Forms.FolderBrowserDialog
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_internet, Me.boton_usb, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 164)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(733, 71)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_internet
        '
        Me.boton_internet.Image = Global.AdminTegral.My.Resources.Resources.Up___Down
        Me.boton_internet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_internet.Name = "boton_internet"
        Me.boton_internet.Size = New System.Drawing.Size(137, 68)
        Me.boton_internet.Text = "Por Internet"
        '
        'boton_usb
        '
        Me.boton_usb.Image = Global.AdminTegral.My.Resources.Resources.Usb
        Me.boton_usb.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_usb.Name = "boton_usb"
        Me.boton_usb.Size = New System.Drawing.Size(117, 68)
        Me.boton_usb.Text = "Por USB"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.AdminTegral.My.Resources.Resources.Log_Off
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.logoSAT
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(140, 68)
        Me.ToolStripButton1.Text = "Enviar CFD's"
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(121, 51)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(291, 26)
        Me.fecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione la fecha que quiere enviar :"
        '
        'barra
        '
        Me.barra.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.barra.Location = New System.Drawing.Point(94, 117)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(544, 23)
        Me.barra.TabIndex = 3
        '
        'filenametxt
        '
        Me.filenametxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filenametxt.Enabled = False
        Me.filenametxt.Location = New System.Drawing.Point(0, 141)
        Me.filenametxt.Name = "filenametxt"
        Me.filenametxt.Size = New System.Drawing.Size(733, 20)
        Me.filenametxt.TabIndex = 4
        '
        'Folder
        '
        Me.Folder.Description = "Unidad Destino"
        Me.Folder.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Adobe_Reader
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(131, 68)
        Me.ToolStripButton2.Text = "Enviar PDF"
        '
        'Exportar_Informacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 235)
        Me.Controls.Add(Me.filenametxt)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Exportar_Informacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Datos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_internet As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_usb As System.Windows.Forms.ToolStripButton
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents barra As System.Windows.Forms.ProgressBar
    Friend WithEvents filenametxt As System.Windows.Forms.TextBox
    Friend WithEvents Folder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
