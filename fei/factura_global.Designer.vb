<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class factura_global
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.emisorbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.DomicilioFiscalbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.regimenbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.receptorbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.domiciliobs = New System.Windows.Forms.BindingSource(Me.components)
        Me.conceptobs = New System.Windows.Forms.BindingSource(Me.components)
        Me.comprobantebs = New System.Windows.Forms.BindingSource(Me.components)
        Me.timbrebs = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.st = New System.Windows.Forms.TextBox()
        Me.iv = New System.Windows.Forms.TextBox()
        Me.ieps = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.trasladosbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.impuestobs = New System.Windows.Forms.BindingSource(Me.components)
        Me.retencionbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.complementobs = New System.Windows.Forms.BindingSource(Me.components)
        Me.qrcode = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.del = New System.Windows.Forms.TextBox()
        Me.al = New System.Windows.Forms.TextBox()
        Me.tasa0 = New System.Windows.Forms.TextBox()
        Me.tasa16 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.metodo = New System.Windows.Forms.TextBox()
        Me.cuenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcuenta = New System.Windows.Forms.Label()
        Me.txtleyenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfolio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.detallebs = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeiDataset = New AdminTegral.feiDataset()
        Me.DetalleTableAdapter = New AdminTegral.feiDatasetTableAdapters.detalleTableAdapter()
        Me.forma = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.emisorbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomicilioFiscalbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regimenbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receptorbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.domiciliobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.conceptobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comprobantebs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timbrebs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trasladosbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.impuestobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.retencionbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.complementobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qrcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detallebs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeiDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(22, 95)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Size = New System.Drawing.Size(707, 194)
        Me.dgv.TabIndex = 0
        '
        'st
        '
        Me.st.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.st.Location = New System.Drawing.Point(629, 295)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(100, 20)
        Me.st.TabIndex = 1
        Me.st.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'iv
        '
        Me.iv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iv.Location = New System.Drawing.Point(629, 321)
        Me.iv.Name = "iv"
        Me.iv.Size = New System.Drawing.Size(100, 20)
        Me.iv.TabIndex = 2
        Me.iv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ieps
        '
        Me.ieps.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ieps.Location = New System.Drawing.Point(629, 347)
        Me.ieps.Name = "ieps"
        Me.ieps.Size = New System.Drawing.Size(100, 20)
        Me.ieps.TabIndex = 3
        Me.ieps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'total
        '
        Me.total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total.Location = New System.Drawing.Point(629, 373)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 4
        Me.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(145, 36)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(123, 20)
        Me.fecha.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'qrcode
        '
        Me.qrcode.Location = New System.Drawing.Point(571, 136)
        Me.qrcode.Name = "qrcode"
        Me.qrcode.Size = New System.Drawing.Size(144, 153)
        Me.qrcode.TabIndex = 8
        Me.qrcode.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Genera Factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'del
        '
        Me.del.Location = New System.Drawing.Point(399, 136)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(53, 20)
        Me.del.TabIndex = 10
        '
        'al
        '
        Me.al.Location = New System.Drawing.Point(467, 136)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(53, 20)
        Me.al.TabIndex = 11
        '
        'tasa0
        '
        Me.tasa0.Location = New System.Drawing.Point(437, 295)
        Me.tasa0.Name = "tasa0"
        Me.tasa0.Size = New System.Drawing.Size(100, 20)
        Me.tasa0.TabIndex = 12
        Me.tasa0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tasa16
        '
        Me.tasa16.Location = New System.Drawing.Point(437, 321)
        Me.tasa16.Name = "tasa16"
        Me.tasa16.Size = New System.Drawing.Size(100, 20)
        Me.tasa16.TabIndex = 13
        Me.tasa16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(394, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tasa 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tasa 16"
        '
        'metodo
        '
        Me.metodo.Location = New System.Drawing.Point(73, 295)
        Me.metodo.Name = "metodo"
        Me.metodo.Size = New System.Drawing.Size(100, 20)
        Me.metodo.TabIndex = 16
        Me.metodo.Text = "PUE"
        '
        'cuenta
        '
        Me.cuenta.Location = New System.Drawing.Point(73, 322)
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Size = New System.Drawing.Size(100, 20)
        Me.cuenta.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Metodo"
        '
        'lblcuenta
        '
        Me.lblcuenta.AutoSize = True
        Me.lblcuenta.Location = New System.Drawing.Point(27, 325)
        Me.lblcuenta.Name = "lblcuenta"
        Me.lblcuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblcuenta.TabIndex = 19
        Me.lblcuenta.Text = "Cuenta"
        '
        'txtleyenda
        '
        Me.txtleyenda.Location = New System.Drawing.Point(45, 381)
        Me.txtleyenda.Multiline = True
        Me.txtleyenda.Name = "txtleyenda"
        Me.txtleyenda.Size = New System.Drawing.Size(492, 42)
        Me.txtleyenda.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(571, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Subtotal :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(580, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "I.V.A. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(582, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "IEPS :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(571, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "TOTAL :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Factura global del dia :"
        '
        'txtfolio
        '
        Me.txtfolio.Location = New System.Drawing.Point(437, 33)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.Size = New System.Drawing.Size(100, 20)
        Me.txtfolio.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(369, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Folio CFDI :"
        '
        'detallebs
        '
        Me.detallebs.DataMember = "detalle"
        Me.detallebs.DataSource = Me.FeiDataset
        '
        'FeiDataset
        '
        Me.FeiDataset.DataSetName = "feiDataset"
        Me.FeiDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleTableAdapter
        '
        Me.DetalleTableAdapter.ClearBeforeFill = True
        '
        'forma
        '
        Me.forma.Location = New System.Drawing.Point(73, 348)
        Me.forma.Name = "forma"
        Me.forma.Size = New System.Drawing.Size(100, 20)
        Me.forma.TabIndex = 28
        Me.forma.Text = "01"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(437, 354)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 29
        Me.TextBox1.Text = "P01"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Forma :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(402, 357)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "USO"
        '
        'factura_global
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 435)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.forma)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtfolio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtleyenda)
        Me.Controls.Add(Me.lblcuenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cuenta)
        Me.Controls.Add(Me.metodo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tasa16)
        Me.Controls.Add(Me.tasa0)
        Me.Controls.Add(Me.al)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.ieps)
        Me.Controls.Add(Me.iv)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.qrcode)
        Me.Name = "factura_global"
        Me.Text = "factura_global"
        CType(Me.emisorbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomicilioFiscalbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regimenbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receptorbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.domiciliobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.conceptobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comprobantebs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timbrebs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trasladosbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.impuestobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.retencionbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.complementobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qrcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detallebs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeiDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents st As System.Windows.Forms.TextBox
    Friend WithEvents iv As System.Windows.Forms.TextBox
    Friend WithEvents ieps As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents emisorbs As System.Windows.Forms.BindingSource
    Friend WithEvents DomicilioFiscalbs As System.Windows.Forms.BindingSource
    Friend WithEvents regimenbs As System.Windows.Forms.BindingSource
    Friend WithEvents receptorbs As System.Windows.Forms.BindingSource
    Friend WithEvents domiciliobs As System.Windows.Forms.BindingSource
    Friend WithEvents conceptobs As System.Windows.Forms.BindingSource
    Friend WithEvents comprobantebs As System.Windows.Forms.BindingSource
    Friend WithEvents timbrebs As System.Windows.Forms.BindingSource
    Friend WithEvents trasladosbs As System.Windows.Forms.BindingSource
    Friend WithEvents impuestobs As System.Windows.Forms.BindingSource
    Friend WithEvents retencionbs As System.Windows.Forms.BindingSource
    Friend WithEvents complementobs As System.Windows.Forms.BindingSource
    Friend WithEvents qrcode As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents del As System.Windows.Forms.TextBox
    Friend WithEvents al As System.Windows.Forms.TextBox
    Friend WithEvents detallebs As System.Windows.Forms.BindingSource
    Friend WithEvents FeiDataset As AdminTegral.feiDataset
    Friend WithEvents DetalleTableAdapter As AdminTegral.feiDatasetTableAdapters.detalleTableAdapter
    Friend WithEvents tasa0 As System.Windows.Forms.TextBox
    Friend WithEvents tasa16 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents metodo As System.Windows.Forms.TextBox
    Friend WithEvents cuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblcuenta As System.Windows.Forms.Label
    Friend WithEvents txtleyenda As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtfolio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents forma As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
