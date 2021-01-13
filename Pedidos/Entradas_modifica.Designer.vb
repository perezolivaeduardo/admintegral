<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entreadas_modifica
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
        Me.components = New System.ComponentModel.Container
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entreadas_modifica))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label17 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.fechaentrada = New System.Windows.Forms.DateTimePicker
        Me.fletetxt = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.vence = New System.Windows.Forms.Label
        Me.fechavence = New System.Windows.Forms.DateTimePicker
        Me.fechafactura = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.facturatxt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.piva = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.pdesctext = New System.Windows.Forms.TextBox
        Me.diasc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.nombreprovtxt = New System.Windows.Forms.TextBox
        Me.id_provtxt = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.AlmacenComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_almacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Label15 = New System.Windows.Forms.Label
        Me.comentariotxt = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Recibiotxt = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.puertatxt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.totaltxt = New System.Windows.Forms.TextBox
        Me.iva15txt = New System.Windows.Forms.TextBox
        Me.iva10txt = New System.Windows.Forms.TextBox
        Me.descuentotxt = New System.Windows.Forms.TextBox
        Me.subtotaltxt = New System.Windows.Forms.TextBox
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer0 = New System.Windows.Forms.SplitContainer
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.status1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.barra = New System.Windows.Forms.ToolStripProgressBar
        AlmacenLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer0.Panel1.SuspendLayout()
        Me.SplitContainer0.Panel2.SuspendLayout()
        Me.SplitContainer0.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlmacenLabel
        '
        AlmacenLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Location = New System.Drawing.Point(14, 29)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(51, 13)
        AlmacenLabel.TabIndex = 36
        AlmacenLabel.Text = "Almacen:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechaentrada)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fletetxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.vence)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechavence)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechafactura)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.facturatxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.piva)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pdesctext)
        Me.SplitContainer1.Panel1.Controls.Add(Me.diasc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nombreprovtxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id_provtxt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(804, 488)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(453, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Flete :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.toolStripSeparator, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(804, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Enabled = False
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(337, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Fecha _entrada:"
        '
        'fechaentrada
        '
        Me.fechaentrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaentrada.Location = New System.Drawing.Point(336, 66)
        Me.fechaentrada.Name = "fechaentrada"
        Me.fechaentrada.Size = New System.Drawing.Size(98, 20)
        Me.fechaentrada.TabIndex = 32
        '
        'fletetxt
        '
        Me.fletetxt.Location = New System.Drawing.Point(456, 66)
        Me.fletetxt.Name = "fletetxt"
        Me.fletetxt.Size = New System.Drawing.Size(74, 20)
        Me.fletetxt.TabIndex = 31
        Me.fletetxt.Text = "0"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(672, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Dias Credito :"
        '
        'vence
        '
        Me.vence.AutoSize = True
        Me.vence.Location = New System.Drawing.Point(233, 55)
        Me.vence.Name = "vence"
        Me.vence.Size = New System.Drawing.Size(44, 13)
        Me.vence.TabIndex = 28
        Me.vence.Text = "Vence :"
        '
        'fechavence
        '
        Me.fechavence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechavence.Location = New System.Drawing.Point(232, 69)
        Me.fechavence.Name = "fechavence"
        Me.fechavence.Size = New System.Drawing.Size(98, 20)
        Me.fechavence.TabIndex = 27
        '
        'fechafactura
        '
        Me.fechafactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechafactura.Location = New System.Drawing.Point(128, 69)
        Me.fechafactura.Name = "fechafactura"
        Me.fechafactura.Size = New System.Drawing.Size(98, 20)
        Me.fechafactura.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Factura :"
        '
        'facturatxt
        '
        Me.facturatxt.Location = New System.Drawing.Point(22, 72)
        Me.facturatxt.MaxLength = 15
        Me.facturatxt.Name = "facturatxt"
        Me.facturatxt.Size = New System.Drawing.Size(100, 20)
        Me.facturatxt.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(717, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "IVA :"
        '
        'piva
        '
        Me.piva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.piva.FormattingEnabled = True
        Me.piva.Items.AddRange(New Object() {"16", "11", "0"})
        Me.piva.Location = New System.Drawing.Point(748, 71)
        Me.piva.Name = "piva"
        Me.piva.Size = New System.Drawing.Size(39, 21)
        Me.piva.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(674, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "% Descuento:"
        '
        'pdesctext
        '
        Me.pdesctext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdesctext.Location = New System.Drawing.Point(748, 48)
        Me.pdesctext.MaxLength = 2
        Me.pdesctext.Name = "pdesctext"
        Me.pdesctext.Size = New System.Drawing.Size(39, 20)
        Me.pdesctext.TabIndex = 6
        Me.pdesctext.Text = "0"
        '
        'diasc
        '
        Me.diasc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.diasc.Location = New System.Drawing.Point(748, 25)
        Me.diasc.Name = "diasc"
        Me.diasc.ReadOnly = True
        Me.diasc.Size = New System.Drawing.Size(37, 20)
        Me.diasc.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proveedor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha :"
        '
        'nombreprovtxt
        '
        Me.nombreprovtxt.Location = New System.Drawing.Point(125, 31)
        Me.nombreprovtxt.Name = "nombreprovtxt"
        Me.nombreprovtxt.ReadOnly = True
        Me.nombreprovtxt.Size = New System.Drawing.Size(258, 20)
        Me.nombreprovtxt.TabIndex = 1
        '
        'id_provtxt
        '
        Me.id_provtxt.Location = New System.Drawing.Point(75, 31)
        Me.id_provtxt.Name = "id_provtxt"
        Me.id_provtxt.ReadOnly = True
        Me.id_provtxt.Size = New System.Drawing.Size(44, 20)
        Me.id_provtxt.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(AlmacenLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.AlmacenComboBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer2.Panel2.Controls.Add(Me.comentariotxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Recibiotxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer2.Panel2.Controls.Add(Me.puertatxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.totaltxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.iva15txt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.iva10txt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.descuentotxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.subtotaltxt)
        Me.SplitContainer2.Size = New System.Drawing.Size(804, 384)
        Me.SplitContainer2.SplitterDistance = 266
        Me.SplitContainer2.TabIndex = 0
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AlmacenComboBox.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox.DisplayMember = "Almacen"
        Me.AlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Location = New System.Drawing.Point(70, 25)
        Me.AlmacenComboBox.Name = "AlmacenComboBox"
        Me.AlmacenComboBox.Size = New System.Drawing.Size(193, 21)
        Me.AlmacenComboBox.TabIndex = 37
        Me.AlmacenComboBox.ValueMember = "id_almacen"
        '
        'Tbl_almacenesBindingSource
        '
        Me.Tbl_almacenesBindingSource.DataMember = "tbl_almacenes"
        Me.Tbl_almacenesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "AdmintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(280, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 16)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Comentarios :"
        '
        'comentariotxt
        '
        Me.comentariotxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.comentariotxt.Location = New System.Drawing.Point(283, 22)
        Me.comentariotxt.MaxLength = 50
        Me.comentariotxt.Multiline = True
        Me.comentariotxt.Name = "comentariotxt"
        Me.comentariotxt.Size = New System.Drawing.Size(230, 89)
        Me.comentariotxt.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Recibio :"
        '
        'Recibiotxt
        '
        Me.Recibiotxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Recibiotxt.Location = New System.Drawing.Point(70, 74)
        Me.Recibiotxt.MaxLength = 20
        Me.Recibiotxt.Name = "Recibiotxt"
        Me.Recibiotxt.Size = New System.Drawing.Size(193, 20)
        Me.Recibiotxt.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Puerta :"
        '
        'puertatxt
        '
        Me.puertatxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.puertatxt.Location = New System.Drawing.Point(70, 51)
        Me.puertatxt.MaxLength = 2
        Me.puertatxt.Name = "puertatxt"
        Me.puertatxt.Size = New System.Drawing.Size(39, 20)
        Me.puertatxt.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Location = New System.Drawing.Point(14, -4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(191, 25)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Datos de Entrada :"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(659, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "TOTAL :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(654, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "16% IVA :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(654, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "11 % IVA :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(642, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Descuento :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(655, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Subtotal :"
        '
        'totaltxt
        '
        Me.totaltxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.totaltxt.Location = New System.Drawing.Point(713, 91)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(88, 20)
        Me.totaltxt.TabIndex = 17
        Me.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'iva15txt
        '
        Me.iva15txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.iva15txt.Location = New System.Drawing.Point(713, 65)
        Me.iva15txt.Name = "iva15txt"
        Me.iva15txt.Size = New System.Drawing.Size(88, 20)
        Me.iva15txt.TabIndex = 16
        Me.iva15txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'iva10txt
        '
        Me.iva10txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.iva10txt.Location = New System.Drawing.Point(713, 43)
        Me.iva10txt.Name = "iva10txt"
        Me.iva10txt.Size = New System.Drawing.Size(88, 20)
        Me.iva10txt.TabIndex = 15
        Me.iva10txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'descuentotxt
        '
        Me.descuentotxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.descuentotxt.Location = New System.Drawing.Point(713, 22)
        Me.descuentotxt.Name = "descuentotxt"
        Me.descuentotxt.Size = New System.Drawing.Size(88, 20)
        Me.descuentotxt.TabIndex = 14
        Me.descuentotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'subtotaltxt
        '
        Me.subtotaltxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.subtotaltxt.Location = New System.Drawing.Point(713, 1)
        Me.subtotaltxt.Name = "subtotaltxt"
        Me.subtotaltxt.Size = New System.Drawing.Size(88, 20)
        Me.subtotaltxt.TabIndex = 13
        Me.subtotaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tbl_almacenesTableAdapter
        '
        Me.Tbl_almacenesTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SplitContainer0
        '
        Me.SplitContainer0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer0.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer0.Name = "SplitContainer0"
        Me.SplitContainer0.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer0.Panel1
        '
        Me.SplitContainer0.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer0.Panel2
        '
        Me.SplitContainer0.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer0.Size = New System.Drawing.Size(804, 530)
        Me.SplitContainer0.SplitterDistance = 488
        Me.SplitContainer0.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status1, Me.barra})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 16)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(804, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status1
        '
        Me.status1.AutoSize = False
        Me.status1.Image = Global.AdminTegral.My.Resources.Resources.information
        Me.status1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(587, 17)
        Me.status1.Spring = True
        Me.status1.Text = " "
        Me.status1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'barra
        '
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(200, 16)
        '
        'Entreadas_modifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 530)
        Me.Controls.Add(Me.SplitContainer0)
        Me.Name = "Entreadas_modifica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar_entrada"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer0.Panel1.ResumeLayout(False)
        Me.SplitContainer0.Panel2.ResumeLayout(False)
        Me.SplitContainer0.Panel2.PerformLayout()
        Me.SplitContainer0.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombreprovtxt As System.Windows.Forms.TextBox
    Friend WithEvents id_provtxt As System.Windows.Forms.TextBox
    Friend WithEvents diasc As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents pdesctext As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents piva As System.Windows.Forms.ComboBox
    Friend WithEvents iva15txt As System.Windows.Forms.TextBox
    Friend WithEvents iva10txt As System.Windows.Forms.TextBox
    Friend WithEvents descuentotxt As System.Windows.Forms.TextBox
    Friend WithEvents subtotaltxt As System.Windows.Forms.TextBox
    Friend WithEvents totaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents facturatxt As System.Windows.Forms.TextBox
    Friend WithEvents vence As System.Windows.Forms.Label
    Friend WithEvents fechavence As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechafactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents comentariotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Recibiotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents puertatxt As System.Windows.Forms.TextBox
    Friend WithEvents AdmintegralDataSet As AdminTegral.AdmintegralDataSet
    Friend WithEvents Tbl_almacenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_almacenesTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.tbl_almacenesTableAdapter
    Friend WithEvents AlmacenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SplitContainer0 As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents barra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents fletetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents fechaentrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
