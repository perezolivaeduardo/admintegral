<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pedir_documento
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
        Me.opfactura = New System.Windows.Forms.RadioButton
        Me.opTicket = New System.Windows.Forms.RadioButton
        Me.folio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.boton_salir = New System.Windows.Forms.Button
        Me.opnc = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'opfactura
        '
        Me.opfactura.AutoSize = True
        Me.opfactura.Checked = True
        Me.opfactura.Location = New System.Drawing.Point(11, 8)
        Me.opfactura.Name = "opfactura"
        Me.opfactura.Size = New System.Drawing.Size(61, 17)
        Me.opfactura.TabIndex = 0
        Me.opfactura.TabStop = True
        Me.opfactura.Text = "Factura"
        Me.opfactura.UseVisualStyleBackColor = True
        '
        'opTicket
        '
        Me.opTicket.AutoSize = True
        Me.opTicket.Location = New System.Drawing.Point(72, 8)
        Me.opTicket.Name = "opTicket"
        Me.opTicket.Size = New System.Drawing.Size(55, 17)
        Me.opTicket.TabIndex = 1
        Me.opTicket.Text = "Ticket"
        Me.opTicket.UseVisualStyleBackColor = True
        '
        'folio
        '
        Me.folio.Location = New System.Drawing.Point(83, 31)
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(100, 20)
        Me.folio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Documento :"
        '
        'boton_salir
        '
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(128, 63)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(55, 24)
        Me.boton_salir.TabIndex = 4
        Me.boton_salir.Text = "Esc."
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'opnc
        '
        Me.opnc.AutoSize = True
        Me.opnc.Location = New System.Drawing.Point(133, 8)
        Me.opnc.Name = "opnc"
        Me.opnc.Size = New System.Drawing.Size(40, 17)
        Me.opnc.TabIndex = 5
        Me.opnc.Text = "NC"
        Me.opnc.UseVisualStyleBackColor = True
        '
        'pedir_documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(198, 91)
        Me.Controls.Add(Me.opnc)
        Me.Controls.Add(Me.boton_salir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.folio)
        Me.Controls.Add(Me.opTicket)
        Me.Controls.Add(Me.opfactura)
        Me.Name = "pedir_documento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opfactura As System.Windows.Forms.RadioButton
    Friend WithEvents opTicket As System.Windows.Forms.RadioButton
    Friend WithEvents folio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents opnc As System.Windows.Forms.RadioButton
End Class
