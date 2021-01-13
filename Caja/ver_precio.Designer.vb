<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ver_precio
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
        Me.productotxt = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.uniadtxt = New System.Windows.Forms.TextBox
        Me.preciotxt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'productotxt
        '
        Me.productotxt.Enabled = False
        Me.productotxt.Location = New System.Drawing.Point(2, 12)
        Me.productotxt.Multiline = True
        Me.productotxt.Name = "productotxt"
        Me.productotxt.ReadOnly = True
        Me.productotxt.Size = New System.Drawing.Size(661, 43)
        Me.productotxt.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(588, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ESC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'uniadtxt
        '
        Me.uniadtxt.Enabled = False
        Me.uniadtxt.Location = New System.Drawing.Point(5, 57)
        Me.uniadtxt.Multiline = True
        Me.uniadtxt.Name = "uniadtxt"
        Me.uniadtxt.ReadOnly = True
        Me.uniadtxt.Size = New System.Drawing.Size(348, 43)
        Me.uniadtxt.TabIndex = 2
        '
        'preciotxt
        '
        Me.preciotxt.Enabled = False
        Me.preciotxt.Location = New System.Drawing.Point(5, 106)
        Me.preciotxt.Multiline = True
        Me.preciotxt.Name = "preciotxt"
        Me.preciotxt.ReadOnly = True
        Me.preciotxt.Size = New System.Drawing.Size(348, 43)
        Me.preciotxt.TabIndex = 3
        '
        'ver_precio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(672, 169)
        Me.Controls.Add(Me.preciotxt)
        Me.Controls.Add(Me.uniadtxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.productotxt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "ver_precio"
        Me.Opacity = 0.95
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productotxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents uniadtxt As System.Windows.Forms.TextBox
    Friend WithEvents preciotxt As System.Windows.Forms.TextBox
End Class
