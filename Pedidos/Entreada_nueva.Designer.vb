<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entreada_nueva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entreada_nueva))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.piva = New System.Windows.Forms.TextBox
        Me.boton_proveedor = New System.Windows.Forms.Button
        Me.lblcaja = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.boton_relacion = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Cargar_entrada = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.boton_cambios_de_precios = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.boton_save = New System.Windows.Forms.ToolStripButton
        Me.boton_abrir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.fechaEntrada = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.vence = New System.Windows.Forms.Label
        Me.fechavence = New System.Windows.Forms.DateTimePicker
        Me.fechafactura = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.facturatxt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.pdesctext = New System.Windows.Forms.TextBox
        Me.diasc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.nombreprovtxt = New System.Windows.Forms.TextBox
        Me.id_provtxt = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label17 = New System.Windows.Forms.Label
        Me.fletetxt = New System.Windows.Forms.TextBox
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
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.buscartxt = New System.Windows.Forms.TextBox
        Me.Boton_Cerrar = New System.Windows.Forms.Button
        Me.boton_seleccioanr = New System.Windows.Forms.Button
        Me.dgventrada = New System.Windows.Forms.DataGridView
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.dgvcambio = New System.Windows.Forms.DataGridView
        AlmacenLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer0.Panel1.SuspendLayout()
        Me.SplitContainer0.Panel2.SuspendLayout()
        Me.SplitContainer0.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgventrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlmacenLabel
        '
        AlmacenLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Location = New System.Drawing.Point(14, 65)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.piva)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_proveedor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblcaja)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechaEntrada)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.vence)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechavence)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechafactura)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.facturatxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(883, 597)
        Me.SplitContainer1.SplitterDistance = 114
        Me.SplitContainer1.TabIndex = 0
        '
        'piva
        '
        Me.piva.Location = New System.Drawing.Point(770, 71)
        Me.piva.Name = "piva"
        Me.piva.Size = New System.Drawing.Size(37, 20)
        Me.piva.TabIndex = 6
        '
        'boton_proveedor
        '
        Me.boton_proveedor.Location = New System.Drawing.Point(389, 31)
        Me.boton_proveedor.Name = "boton_proveedor"
        Me.boton_proveedor.Size = New System.Drawing.Size(41, 23)
        Me.boton_proveedor.TabIndex = 37
        Me.boton_proveedor.Text = "..."
        Me.boton_proveedor.UseVisualStyleBackColor = True
        '
        'lblcaja
        '
        Me.lblcaja.AutoSize = True
        Me.lblcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaja.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblcaja.Location = New System.Drawing.Point(484, 19)
        Me.lblcaja.Name = "lblcaja"
        Me.lblcaja.Size = New System.Drawing.Size(189, 25)
        Me.lblcaja.TabIndex = 36
        Me.lblcaja.Text = "Entrada en Tienda"
        Me.lblcaja.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_relacion, Me.toolStripSeparator, Me.ImprimirToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton, Me.Cargar_entrada, Me.ToolStripButton1, Me.boton_cambios_de_precios, Me.ToolStripSeparator2, Me.boton_save, Me.boton_abrir, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(883, 25)
        Me.ToolStrip1.TabIndex = 34
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_relacion
        '
        Me.boton_relacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_relacion.Image = Global.AdminTegral.My.Resources.Resources.lorry
        Me.boton_relacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_relacion.Name = "boton_relacion"
        Me.boton_relacion.Size = New System.Drawing.Size(23, 22)
        Me.boton_relacion.Text = "Relacion de Entradas"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
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
        'Cargar_entrada
        '
        Me.Cargar_entrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cargar_entrada.Image = Global.AdminTegral.My.Resources.Resources.shoppingcart_remove
        Me.Cargar_entrada.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cargar_entrada.Name = "Cargar_entrada"
        Me.Cargar_entrada.Size = New System.Drawing.Size(23, 22)
        Me.Cargar_entrada.Text = "Entradas desde Tiendas"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.Registry
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Catalogo de Productos"
        '
        'boton_cambios_de_precios
        '
        Me.boton_cambios_de_precios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_cambios_de_precios.Image = Global.AdminTegral.My.Resources.Resources.dollar
        Me.boton_cambios_de_precios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_cambios_de_precios.Name = "boton_cambios_de_precios"
        Me.boton_cambios_de_precios.Size = New System.Drawing.Size(23, 22)
        Me.boton_cambios_de_precios.Text = "Cambio de precios"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'boton_save
        '
        Me.boton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_save.Image = Global.AdminTegral.My.Resources.Resources.Save
        Me.boton_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_save.Name = "boton_save"
        Me.boton_save.Size = New System.Drawing.Size(23, 22)
        Me.boton_save.Text = "ToolStripButton2"
        '
        'boton_abrir
        '
        Me.boton_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_abrir.Image = Global.AdminTegral.My.Resources.Resources.folder_blue_mypictures
        Me.boton_abrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_abrir.Name = "boton_abrir"
        Me.boton_abrir.Size = New System.Drawing.Size(23, 22)
        Me.boton_abrir.Text = "ToolStripButton2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.repeat
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Refresh Catalogo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(235, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Fecha entrada :"
        '
        'fechaEntrada
        '
        Me.fechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaEntrada.Location = New System.Drawing.Point(232, 69)
        Me.fechaEntrada.Name = "fechaEntrada"
        Me.fechaEntrada.Size = New System.Drawing.Size(98, 20)
        Me.fechaEntrada.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(694, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Dias Credito :"
        '
        'vence
        '
        Me.vence.AutoSize = True
        Me.vence.Location = New System.Drawing.Point(339, 53)
        Me.vence.Name = "vence"
        Me.vence.Size = New System.Drawing.Size(44, 13)
        Me.vence.TabIndex = 28
        Me.vence.Text = "Vence :"
        '
        'fechavence
        '
        Me.fechavence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechavence.Location = New System.Drawing.Point(338, 67)
        Me.fechavence.Name = "fechavence"
        Me.fechavence.Size = New System.Drawing.Size(98, 20)
        Me.fechavence.TabIndex = 4
        '
        'fechafactura
        '
        Me.fechafactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechafactura.Location = New System.Drawing.Point(128, 69)
        Me.fechafactura.Name = "fechafactura"
        Me.fechafactura.Size = New System.Drawing.Size(98, 20)
        Me.fechafactura.TabIndex = 2
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
        Me.facturatxt.MaxLength = 10
        Me.facturatxt.Name = "facturatxt"
        Me.facturatxt.Size = New System.Drawing.Size(100, 20)
        Me.facturatxt.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(739, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "IVA :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(696, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "% Descuento:"
        '
        'pdesctext
        '
        Me.pdesctext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdesctext.Location = New System.Drawing.Point(770, 48)
        Me.pdesctext.MaxLength = 2
        Me.pdesctext.Name = "pdesctext"
        Me.pdesctext.Size = New System.Drawing.Size(39, 20)
        Me.pdesctext.TabIndex = 5
        Me.pdesctext.Text = "0"
        '
        'diasc
        '
        Me.diasc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.diasc.Location = New System.Drawing.Point(770, 25)
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
        Me.nombreprovtxt.TabStop = False
        '
        'id_provtxt
        '
        Me.id_provtxt.Location = New System.Drawing.Point(75, 31)
        Me.id_provtxt.Name = "id_provtxt"
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
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvcambio)
        Me.SplitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label17)
        Me.SplitContainer2.Panel2.Controls.Add(Me.fletetxt)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(883, 479)
        Me.SplitContainer2.SplitterDistance = 328
        Me.SplitContainer2.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(604, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Flete :"
        '
        'fletetxt
        '
        Me.fletetxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fletetxt.Location = New System.Drawing.Point(646, 124)
        Me.fletetxt.Name = "fletetxt"
        Me.fletetxt.Size = New System.Drawing.Size(88, 20)
        Me.fletetxt.TabIndex = 38
        Me.fletetxt.Text = "0"
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AlmacenComboBox.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox.DisplayMember = "Almacen"
        Me.AlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Location = New System.Drawing.Point(70, 61)
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
        Me.Label15.Location = New System.Drawing.Point(299, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 16)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Comentarios :"
        '
        'comentariotxt
        '
        Me.comentariotxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.comentariotxt.Location = New System.Drawing.Point(283, 58)
        Me.comentariotxt.MaxLength = 100
        Me.comentariotxt.Multiline = True
        Me.comentariotxt.Name = "comentariotxt"
        Me.comentariotxt.Size = New System.Drawing.Size(230, 89)
        Me.comentariotxt.TabIndex = 35
        Me.comentariotxt.Text = " "
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Recibio :"
        '
        'Recibiotxt
        '
        Me.Recibiotxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Recibiotxt.Location = New System.Drawing.Point(70, 110)
        Me.Recibiotxt.MaxLength = 20
        Me.Recibiotxt.Name = "Recibiotxt"
        Me.Recibiotxt.Size = New System.Drawing.Size(193, 20)
        Me.Recibiotxt.TabIndex = 33
        Me.Recibiotxt.Text = " "
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Puerta :"
        '
        'puertatxt
        '
        Me.puertatxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.puertatxt.Location = New System.Drawing.Point(70, 87)
        Me.puertatxt.MaxLength = 2
        Me.puertatxt.Name = "puertatxt"
        Me.puertatxt.Size = New System.Drawing.Size(39, 20)
        Me.puertatxt.TabIndex = 31
        Me.puertatxt.Text = "1"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Location = New System.Drawing.Point(33, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(191, 25)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Datos de Entrada :"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(592, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "TOTAL :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(587, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = Trim(My.Settings.iva2.ToString) + "% IVA :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(587, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = Trim(My.Settings.iva.ToString) + "% IVA :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(575, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Descuento :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(588, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Subtotal :"
        '
        'totaltxt
        '
        Me.totaltxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totaltxt.Location = New System.Drawing.Point(646, 87)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(88, 20)
        Me.totaltxt.TabIndex = 17
        Me.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'iva15txt
        '
        Me.iva15txt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iva15txt.Location = New System.Drawing.Point(646, 61)
        Me.iva15txt.Name = "iva15txt"
        Me.iva15txt.Size = New System.Drawing.Size(88, 20)
        Me.iva15txt.TabIndex = 16
        Me.iva15txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'iva10txt
        '
        Me.iva10txt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iva10txt.Location = New System.Drawing.Point(646, 39)
        Me.iva10txt.Name = "iva10txt"
        Me.iva10txt.Size = New System.Drawing.Size(88, 20)
        Me.iva10txt.TabIndex = 15
        Me.iva10txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'descuentotxt
        '
        Me.descuentotxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.descuentotxt.Location = New System.Drawing.Point(646, 18)
        Me.descuentotxt.Name = "descuentotxt"
        Me.descuentotxt.Size = New System.Drawing.Size(88, 20)
        Me.descuentotxt.TabIndex = 14
        Me.descuentotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'subtotaltxt
        '
        Me.subtotaltxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subtotaltxt.Location = New System.Drawing.Point(646, -3)
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
        Me.SplitContainer0.Size = New System.Drawing.Size(883, 642)
        Me.SplitContainer0.SplitterDistance = 597
        Me.SplitContainer0.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status1, Me.barra})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 19)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(883, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status1
        '
        Me.status1.AutoSize = False
        Me.status1.Image = Global.AdminTegral.My.Resources.Resources.information
        Me.status1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(666, 17)
        Me.status1.Spring = True
        Me.status1.Text = " "
        Me.status1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'barra
        '
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(200, 16)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.buscartxt)
        Me.GroupBox1.Controls.Add(Me.Boton_Cerrar)
        Me.GroupBox1.Controls.Add(Me.boton_seleccioanr)
        Me.GroupBox1.Controls.Add(Me.dgventrada)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 642)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entradas Pendientes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Buscar :"
        '
        'buscartxt
        '
        Me.buscartxt.Location = New System.Drawing.Point(68, 20)
        Me.buscartxt.Name = "buscartxt"
        Me.buscartxt.Size = New System.Drawing.Size(288, 20)
        Me.buscartxt.TabIndex = 3
        '
        'Boton_Cerrar
        '
        Me.Boton_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Boton_Cerrar.Location = New System.Drawing.Point(12, 608)
        Me.Boton_Cerrar.Name = "Boton_Cerrar"
        Me.Boton_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Boton_Cerrar.TabIndex = 2
        Me.Boton_Cerrar.Text = "Cerrar"
        Me.Boton_Cerrar.UseVisualStyleBackColor = True
        '
        'boton_seleccioanr
        '
        Me.boton_seleccioanr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.boton_seleccioanr.Location = New System.Drawing.Point(695, 607)
        Me.boton_seleccioanr.Name = "boton_seleccioanr"
        Me.boton_seleccioanr.Size = New System.Drawing.Size(75, 23)
        Me.boton_seleccioanr.TabIndex = 1
        Me.boton_seleccioanr.Text = "Seleccionar"
        Me.boton_seleccioanr.UseVisualStyleBackColor = True
        '
        'dgventrada
        '
        Me.dgventrada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgventrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgventrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventrada.Location = New System.Drawing.Point(6, 54)
        Me.dgventrada.Name = "dgventrada"
        Me.dgventrada.Size = New System.Drawing.Size(868, 548)
        Me.dgventrada.TabIndex = 0
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'dgvcambio
        '
        Me.dgvcambio.AllowUserToAddRows = False
        Me.dgvcambio.AllowUserToDeleteRows = False
        Me.dgvcambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcambio.Location = New System.Drawing.Point(22, 73)
        Me.dgvcambio.Name = "dgvcambio"
        Me.dgvcambio.Size = New System.Drawing.Size(796, 150)
        Me.dgvcambio.TabIndex = 0
        Me.dgvcambio.Visible = False
        '
        'Entreada_nueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 642)
        Me.Controls.Add(Me.SplitContainer0)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Entreada_nueva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entreada_nueva"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgventrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcambio, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents fechaEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents Cargar_entrada As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Boton_Cerrar As System.Windows.Forms.Button
    Friend WithEvents boton_seleccioanr As System.Windows.Forms.Button
    Friend WithEvents dgventrada As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblcaja As System.Windows.Forms.Label
    Friend WithEvents boton_cambios_de_precios As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents fletetxt As System.Windows.Forms.TextBox
    Friend WithEvents boton_proveedor As System.Windows.Forms.Button
    Friend WithEvents boton_relacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents piva As System.Windows.Forms.TextBox
    Friend WithEvents boton_save As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boton_abrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents buscartxt As System.Windows.Forms.TextBox
    Friend WithEvents dgvcambio As System.Windows.Forms.DataGridView
End Class
