<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensage
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
        Me.Button_ok = New System.Windows.Forms.Button
        Me.mensaje = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button_ok
        '
        Me.Button_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ok.Location = New System.Drawing.Point(272, 141)
        Me.Button_ok.Name = "Button_ok"
        Me.Button_ok.Size = New System.Drawing.Size(80, 36)
        Me.Button_ok.TabIndex = 0
        Me.Button_ok.Text = "Ok"
        Me.Button_ok.UseVisualStyleBackColor = True
        '
        'mensaje
        '
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.Color.Blue
        Me.mensaje.Location = New System.Drawing.Point(-3, -5)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(624, 76)
        Me.mensaje.TabIndex = 0
        Me.mensaje.Text = "Label1"
        Me.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mensage
        '
        Me.AcceptButton = Me.Button_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(619, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.Button_ok)
        Me.Name = "Mensage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.DarkRed
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_ok As System.Windows.Forms.Button
    Friend WithEvents mensaje As System.Windows.Forms.Label
End Class
