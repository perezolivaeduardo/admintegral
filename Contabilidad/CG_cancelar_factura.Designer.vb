<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CG_cancelar_factura
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
        Me.Foliotxt = New System.Windows.Forms.TextBox
        Me.opfactura = New System.Windows.Forms.RadioButton
        Me.opticket = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.fechatxt = New System.Windows.Forms.TextBox
        Me.estatus = New System.Windows.Forms.TextBox
        Me.forma = New System.Windows.Forms.TextBox
        Me.opncredito = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.cliente = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.importe = New System.Windows.Forms.TextBox
        Me.Boton_salir = New System.Windows.Forms.Button
        Me.boton_cancelar = New System.Windows.Forms.Button
        Me.optraspaso = New System.Windows.Forms.RadioButton
        Me.tentra = New System.Windows.Forms.TextBox
        Me.lbltentra = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lista = New System.Windows.Forms.CheckedListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Foliotxt
        '
        Me.Foliotxt.Location = New System.Drawing.Point(93, 63)
        Me.Foliotxt.Name = "Foliotxt"
        Me.Foliotxt.Size = New System.Drawing.Size(92, 20)
        Me.Foliotxt.TabIndex = 3
        '
        'opfactura
        '
        Me.opfactura.AutoSize = True
        Me.opfactura.Checked = True
        Me.opfactura.Location = New System.Drawing.Point(93, 40)
        Me.opfactura.Name = "opfactura"
        Me.opfactura.Size = New System.Drawing.Size(61, 17)
        Me.opfactura.TabIndex = 0
        Me.opfactura.TabStop = True
        Me.opfactura.Text = "Factura"
        Me.opfactura.UseVisualStyleBackColor = True
        '
        'opticket
        '
        Me.opticket.AutoSize = True
        Me.opticket.Location = New System.Drawing.Point(160, 40)
        Me.opticket.Name = "opticket"
        Me.opticket.Size = New System.Drawing.Size(55, 17)
        Me.opticket.TabIndex = 1
        Me.opticket.Text = "Ticket"
        Me.opticket.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cancelar Factura"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(46, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Folio :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(7, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Documento :"
        '
        'fechatxt
        '
        Me.fechatxt.Enabled = False
        Me.fechatxt.Location = New System.Drawing.Point(93, 89)
        Me.fechatxt.Name = "fechatxt"
        Me.fechatxt.Size = New System.Drawing.Size(92, 20)
        Me.fechatxt.TabIndex = 8
        '
        'estatus
        '
        Me.estatus.Enabled = False
        Me.estatus.Location = New System.Drawing.Point(93, 115)
        Me.estatus.Name = "estatus"
        Me.estatus.Size = New System.Drawing.Size(92, 20)
        Me.estatus.TabIndex = 9
        '
        'forma
        '
        Me.forma.Enabled = False
        Me.forma.Location = New System.Drawing.Point(93, 141)
        Me.forma.Name = "forma"
        Me.forma.Size = New System.Drawing.Size(92, 20)
        Me.forma.TabIndex = 10
        '
        'opncredito
        '
        Me.opncredito.AutoSize = True
        Me.opncredito.Location = New System.Drawing.Point(221, 40)
        Me.opncredito.Name = "opncredito"
        Me.opncredito.Size = New System.Drawing.Size(87, 17)
        Me.opncredito.TabIndex = 2
        Me.opncredito.Text = "N. de Credito"
        Me.opncredito.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(38, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(32, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Estatus :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 270)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(720, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 17)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(34, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Forma :"
        '
        'cliente
        '
        Me.cliente.Enabled = False
        Me.cliente.Location = New System.Drawing.Point(93, 167)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(322, 20)
        Me.cliente.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(34, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cliente :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label8.Location = New System.Drawing.Point(32, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Importe :"
        '
        'importe
        '
        Me.importe.Enabled = False
        Me.importe.Location = New System.Drawing.Point(93, 197)
        Me.importe.Name = "importe"
        Me.importe.Size = New System.Drawing.Size(92, 20)
        Me.importe.TabIndex = 19
        Me.importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Boton_salir
        '
        Me.Boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Boton_salir.Location = New System.Drawing.Point(340, 244)
        Me.Boton_salir.Name = "Boton_salir"
        Me.Boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.Boton_salir.TabIndex = 20
        Me.Boton_salir.Text = "Salir"
        Me.Boton_salir.UseVisualStyleBackColor = True
        '
        'boton_cancelar
        '
        Me.boton_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_cancelar.Enabled = False
        Me.boton_cancelar.Location = New System.Drawing.Point(259, 244)
        Me.boton_cancelar.Name = "boton_cancelar"
        Me.boton_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.boton_cancelar.TabIndex = 21
        Me.boton_cancelar.Text = "Cancelar"
        Me.boton_cancelar.UseVisualStyleBackColor = True
        '
        'optraspaso
        '
        Me.optraspaso.AutoSize = True
        Me.optraspaso.Location = New System.Drawing.Point(314, 41)
        Me.optraspaso.Name = "optraspaso"
        Me.optraspaso.Size = New System.Drawing.Size(69, 17)
        Me.optraspaso.TabIndex = 22
        Me.optraspaso.Text = "Traspaso"
        Me.optraspaso.UseVisualStyleBackColor = True
        '
        'tentra
        '
        Me.tentra.Location = New System.Drawing.Point(314, 104)
        Me.tentra.Name = "tentra"
        Me.tentra.ReadOnly = True
        Me.tentra.Size = New System.Drawing.Size(60, 20)
        Me.tentra.TabIndex = 23
        Me.tentra.Visible = False
        '
        'lbltentra
        '
        Me.lbltentra.AutoSize = True
        Me.lbltentra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltentra.ForeColor = System.Drawing.Color.AliceBlue
        Me.lbltentra.Location = New System.Drawing.Point(286, 85)
        Me.lbltentra.Name = "lbltentra"
        Me.lbltentra.Size = New System.Drawing.Size(114, 16)
        Me.lbltentra.TabIndex = 24
        Me.lbltentra.Text = "Almacen Entrada."
        Me.lbltentra.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lista)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 233)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Canceladas en esta Sesion"
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(3, 16)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(194, 184)
        Me.lista.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Valida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CG_cancelar_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.Boton_salir
        Me.ClientSize = New System.Drawing.Size(720, 292)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltentra)
        Me.Controls.Add(Me.tentra)
        Me.Controls.Add(Me.optraspaso)
        Me.Controls.Add(Me.boton_cancelar)
        Me.Controls.Add(Me.Boton_salir)
        Me.Controls.Add(Me.importe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.opncredito)
        Me.Controls.Add(Me.forma)
        Me.Controls.Add(Me.estatus)
        Me.Controls.Add(Me.fechatxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.opticket)
        Me.Controls.Add(Me.opfactura)
        Me.Controls.Add(Me.Foliotxt)
        Me.Name = "CG_cancelar_factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelar un Docuemento"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Foliotxt As System.Windows.Forms.TextBox
    Friend WithEvents opfactura As System.Windows.Forms.RadioButton
    Friend WithEvents opticket As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fechatxt As System.Windows.Forms.TextBox
    Friend WithEvents estatus As System.Windows.Forms.TextBox
    Friend WithEvents forma As System.Windows.Forms.TextBox
    Friend WithEvents opncredito As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents importe As System.Windows.Forms.TextBox
    Friend WithEvents Boton_salir As System.Windows.Forms.Button
    Friend WithEvents boton_cancelar As System.Windows.Forms.Button
    Friend WithEvents optraspaso As System.Windows.Forms.RadioButton
    Friend WithEvents tentra As System.Windows.Forms.TextBox
    Friend WithEvents lbltentra As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lista As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
