<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja_ncredito
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
        Me.opticket = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.foliotxt = New System.Windows.Forms.TextBox
        Me.nombretxt = New System.Windows.Forms.TextBox
        Me.fechatxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.importetxt = New System.Windows.Forms.TextBox
        Me.Boton_generar = New System.Windows.Forms.Button
        Me.statustxt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.abonadotxt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.boton_salir = New System.Windows.Forms.Button
        Me.ncreditotxt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtconcepto = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtrecibio = New System.Windows.Forms.TextBox
        Me.txtbono = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.boton_bonificar = New System.Windows.Forms.Button
        Me.saldotxt = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkDevol = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'opfactura
        '
        Me.opfactura.AutoSize = True
        Me.opfactura.Checked = True
        Me.opfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opfactura.Location = New System.Drawing.Point(189, 12)
        Me.opfactura.Name = "opfactura"
        Me.opfactura.Size = New System.Drawing.Size(76, 22)
        Me.opfactura.TabIndex = 0
        Me.opfactura.TabStop = True
        Me.opfactura.Text = "Factura"
        Me.opfactura.UseVisualStyleBackColor = True
        '
        'opticket
        '
        Me.opticket.AutoSize = True
        Me.opticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opticket.Location = New System.Drawing.Point(271, 12)
        Me.opticket.Name = "opticket"
        Me.opticket.Size = New System.Drawing.Size(66, 22)
        Me.opticket.TabIndex = 1
        Me.opticket.Text = "Ticket"
        Me.opticket.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio :"
        '
        'foliotxt
        '
        Me.foliotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foliotxt.Location = New System.Drawing.Point(74, 29)
        Me.foliotxt.Name = "foliotxt"
        Me.foliotxt.Size = New System.Drawing.Size(96, 24)
        Me.foliotxt.TabIndex = 3
        '
        'nombretxt
        '
        Me.nombretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombretxt.Location = New System.Drawing.Point(74, 59)
        Me.nombretxt.Name = "nombretxt"
        Me.nombretxt.ReadOnly = True
        Me.nombretxt.Size = New System.Drawing.Size(258, 24)
        Me.nombretxt.TabIndex = 4
        '
        'fechatxt
        '
        Me.fechatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechatxt.Location = New System.Drawing.Point(74, 89)
        Me.fechatxt.Name = "fechatxt"
        Me.fechatxt.ReadOnly = True
        Me.fechatxt.Size = New System.Drawing.Size(92, 24)
        Me.fechatxt.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Importe :"
        '
        'importetxt
        '
        Me.importetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importetxt.Location = New System.Drawing.Point(234, 89)
        Me.importetxt.Name = "importetxt"
        Me.importetxt.ReadOnly = True
        Me.importetxt.Size = New System.Drawing.Size(98, 24)
        Me.importetxt.TabIndex = 9
        Me.importetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Boton_generar
        '
        Me.Boton_generar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton_generar.Enabled = False
        Me.Boton_generar.Location = New System.Drawing.Point(271, 275)
        Me.Boton_generar.Name = "Boton_generar"
        Me.Boton_generar.Size = New System.Drawing.Size(75, 23)
        Me.Boton_generar.TabIndex = 10
        Me.Boton_generar.Text = "Aplicar"
        Me.Boton_generar.UseVisualStyleBackColor = True
        Me.Boton_generar.Visible = False
        '
        'statustxt
        '
        Me.statustxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statustxt.Location = New System.Drawing.Point(74, 119)
        Me.statustxt.Name = "statustxt"
        Me.statustxt.ReadOnly = True
        Me.statustxt.Size = New System.Drawing.Size(25, 24)
        Me.statustxt.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Status:"
        '
        'abonadotxt
        '
        Me.abonadotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abonadotxt.Location = New System.Drawing.Point(234, 116)
        Me.abonadotxt.Name = "abonadotxt"
        Me.abonadotxt.ReadOnly = True
        Me.abonadotxt.Size = New System.Drawing.Size(98, 24)
        Me.abonadotxt.TabIndex = 14
        Me.abonadotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Abonado:"
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(197, 329)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 15
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'ncreditotxt
        '
        Me.ncreditotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ncreditotxt.Location = New System.Drawing.Point(97, 149)
        Me.ncreditotxt.Name = "ncreditotxt"
        Me.ncreditotxt.ReadOnly = True
        Me.ncreditotxt.Size = New System.Drawing.Size(59, 24)
        Me.ncreditotxt.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "N.Credito :"
        '
        'txtconcepto
        '
        Me.txtconcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconcepto.Location = New System.Drawing.Point(17, 200)
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(341, 24)
        Me.txtconcepto.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Concepto :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Autorizacion :"
        '
        'txtrecibio
        '
        Me.txtrecibio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecibio.Location = New System.Drawing.Point(18, 245)
        Me.txtrecibio.Name = "txtrecibio"
        Me.txtrecibio.Size = New System.Drawing.Size(341, 24)
        Me.txtrecibio.TabIndex = 21
        '
        'txtbono
        '
        Me.txtbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbono.Location = New System.Drawing.Point(110, 272)
        Me.txtbono.Name = "txtbono"
        Me.txtbono.Size = New System.Drawing.Size(98, 24)
        Me.txtbono.TabIndex = 23
        Me.txtbono.Text = "0"
        Me.txtbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Bonificar :"
        '
        'boton_bonificar
        '
        Me.boton_bonificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_bonificar.Enabled = False
        Me.boton_bonificar.Location = New System.Drawing.Point(274, 327)
        Me.boton_bonificar.Name = "boton_bonificar"
        Me.boton_bonificar.Size = New System.Drawing.Size(75, 23)
        Me.boton_bonificar.TabIndex = 25
        Me.boton_bonificar.Text = "Bonificar"
        Me.boton_bonificar.UseVisualStyleBackColor = True
        '
        'saldotxt
        '
        Me.saldotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldotxt.Location = New System.Drawing.Point(234, 144)
        Me.saldotxt.Name = "saldotxt"
        Me.saldotxt.ReadOnly = True
        Me.saldotxt.Size = New System.Drawing.Size(98, 24)
        Me.saldotxt.TabIndex = 27
        Me.saldotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(179, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Saldo :"
        '
        'chkDevol
        '
        Me.chkDevol.AutoSize = True
        Me.chkDevol.Location = New System.Drawing.Point(23, 302)
        Me.chkDevol.Name = "chkDevol"
        Me.chkDevol.Size = New System.Drawing.Size(148, 17)
        Me.chkDevol.TabIndex = 28
        Me.chkDevol.Text = "Devolucion de Mercancia"
        Me.chkDevol.UseVisualStyleBackColor = True
        Me.chkDevol.Visible = False
        '
        'caja_ncredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(361, 362)
        Me.Controls.Add(Me.chkDevol)
        Me.Controls.Add(Me.saldotxt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.boton_bonificar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtbono)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtrecibio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtconcepto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ncreditotxt)
        Me.Controls.Add(Me.boton_salir)
        Me.Controls.Add(Me.abonadotxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.statustxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Boton_generar)
        Me.Controls.Add(Me.importetxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fechatxt)
        Me.Controls.Add(Me.nombretxt)
        Me.Controls.Add(Me.foliotxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.opticket)
        Me.Controls.Add(Me.opfactura)
        Me.Name = "caja_ncredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de Credito (Completa)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opfactura As System.Windows.Forms.RadioButton
    Friend WithEvents opticket As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents foliotxt As System.Windows.Forms.TextBox
    Friend WithEvents nombretxt As System.Windows.Forms.TextBox
    Friend WithEvents fechatxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents importetxt As System.Windows.Forms.TextBox
    Friend WithEvents Boton_generar As System.Windows.Forms.Button
    Friend WithEvents statustxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents abonadotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents ncreditotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtconcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtrecibio As System.Windows.Forms.TextBox
    Friend WithEvents txtbono As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents boton_bonificar As System.Windows.Forms.Button
    Friend WithEvents saldotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkDevol As System.Windows.Forms.CheckBox
End Class
