<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devolucion_nueva
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
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(devolucion_nueva))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tool1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.boton_relacion = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.boton_salir = New System.Windows.Forms.ToolStripButton()
        Me.boton_repetir = New System.Windows.Forms.ToolStripButton()
        Me.boton_suspender = New System.Windows.Forms.ToolStripSplitButton()
        Me.GuardarCotizacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeerCotizacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarDevolucEnTiendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tool2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblFolio = New System.Windows.Forms.ToolStripLabel()
        Me.txtfolio = New System.Windows.Forms.ToolStripTextBox()
        Me.boton_esc = New System.Windows.Forms.ToolStripButton()
        Me.boton_buscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.boton_matris = New System.Windows.Forms.ToolStripButton()
        Me.boton_laser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.facturatxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pdesctext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombreprovtxt = New System.Windows.Forms.TextBox()
        Me.id_provtxt = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.linea = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.piva = New System.Windows.Forms.TextBox()
        Me.AlmacenComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_almacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.comentariotxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Recibiotxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.puertatxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.IEPStxt = New System.Windows.Forms.TextBox()
        Me.iva10txt = New System.Windows.Forms.TextBox()
        Me.descuentotxt = New System.Windows.Forms.TextBox()
        Me.subtotaltxt = New System.Windows.Forms.TextBox()
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer0 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.barra = New System.Windows.Forms.ToolStripProgressBar()
        AlmacenLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer0, System.ComponentModel.ISupportInitialize).BeginInit()
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
        AlmacenLabel.Location = New System.Drawing.Point(14, 33)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechaDevolucion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.facturatxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pdesctext)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nombreprovtxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id_provtxt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(804, 488)
        Me.SplitContainer1.SplitterDistance = 94
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool1, Me.GuardarToolStripButton, Me.boton_relacion, Me.toolStripSeparator1, Me.boton_salir, Me.boton_repetir, Me.boton_suspender, Me.tool2, Me.lblFolio, Me.txtfolio, Me.boton_esc, Me.boton_buscar, Me.ToolStripSeparator2, Me.boton_matris, Me.boton_laser, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(804, 39)
        Me.ToolStrip1.TabIndex = 33
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tool1
        '
        Me.tool1.Name = "tool1"
        Me.tool1.Size = New System.Drawing.Size(6, 39)
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'boton_relacion
        '
        Me.boton_relacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_relacion.Image = CType(resources.GetObject("boton_relacion.Image"), System.Drawing.Image)
        Me.boton_relacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_relacion.Name = "boton_relacion"
        Me.boton_relacion.Size = New System.Drawing.Size(36, 36)
        Me.boton_relacion.Text = "Relacion de Devoluciones"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'boton_salir
        '
        Me.boton_salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.boton_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_salir.Image = CType(resources.GetObject("boton_salir.Image"), System.Drawing.Image)
        Me.boton_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(36, 36)
        Me.boton_salir.Text = "ToolStripButton2"
        '
        'boton_repetir
        '
        Me.boton_repetir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_repetir.Image = CType(resources.GetObject("boton_repetir.Image"), System.Drawing.Image)
        Me.boton_repetir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_repetir.Name = "boton_repetir"
        Me.boton_repetir.Size = New System.Drawing.Size(36, 36)
        Me.boton_repetir.Text = "Repetir Documento"
        '
        'boton_suspender
        '
        Me.boton_suspender.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_suspender.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarCotizacionToolStripMenuItem, Me.LeerCotizacionToolStripMenuItem, Me.CargarDevolucEnTiendaToolStripMenuItem})
        Me.boton_suspender.Image = CType(resources.GetObject("boton_suspender.Image"), System.Drawing.Image)
        Me.boton_suspender.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_suspender.Name = "boton_suspender"
        Me.boton_suspender.Size = New System.Drawing.Size(48, 36)
        Me.boton_suspender.Text = "Guardar/leer Cotizacion"
        '
        'GuardarCotizacionToolStripMenuItem
        '
        Me.GuardarCotizacionToolStripMenuItem.Name = "GuardarCotizacionToolStripMenuItem"
        Me.GuardarCotizacionToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.GuardarCotizacionToolStripMenuItem.Text = "Guardar Cotizacion"
        '
        'LeerCotizacionToolStripMenuItem
        '
        Me.LeerCotizacionToolStripMenuItem.Name = "LeerCotizacionToolStripMenuItem"
        Me.LeerCotizacionToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.LeerCotizacionToolStripMenuItem.Text = "Leer Cotizacion"
        '
        'CargarDevolucEnTiendaToolStripMenuItem
        '
        Me.CargarDevolucEnTiendaToolStripMenuItem.Name = "CargarDevolucEnTiendaToolStripMenuItem"
        Me.CargarDevolucEnTiendaToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CargarDevolucEnTiendaToolStripMenuItem.Text = "Cargar Devoluc. en tienda"
        '
        'tool2
        '
        Me.tool2.Name = "tool2"
        Me.tool2.Size = New System.Drawing.Size(6, 39)
        '
        'lblFolio
        '
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(115, 36)
        Me.lblFolio.Text = "Teclee Contrarecibo:"
        Me.lblFolio.Visible = False
        '
        'txtfolio
        '
        Me.txtfolio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtfolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfolio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.Size = New System.Drawing.Size(100, 39)
        Me.txtfolio.Visible = False
        '
        'boton_esc
        '
        Me.boton_esc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_esc.Image = CType(resources.GetObject("boton_esc.Image"), System.Drawing.Image)
        Me.boton_esc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_esc.Name = "boton_esc"
        Me.boton_esc.Size = New System.Drawing.Size(36, 36)
        Me.boton_esc.Text = "ToolStripButton5"
        Me.boton_esc.Visible = False
        '
        'boton_buscar
        '
        Me.boton_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_buscar.Image = CType(resources.GetObject("boton_buscar.Image"), System.Drawing.Image)
        Me.boton_buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_buscar.Name = "boton_buscar"
        Me.boton_buscar.Size = New System.Drawing.Size(36, 36)
        Me.boton_buscar.Text = "ToolStripButton1"
        Me.boton_buscar.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'boton_matris
        '
        Me.boton_matris.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_matris.Enabled = False
        Me.boton_matris.Image = CType(resources.GetObject("boton_matris.Image"), System.Drawing.Image)
        Me.boton_matris.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_matris.Name = "boton_matris"
        Me.boton_matris.Size = New System.Drawing.Size(36, 36)
        Me.boton_matris.Text = "Seleccionar Impresora de Matris"
        '
        'boton_laser
        '
        Me.boton_laser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_laser.Image = CType(resources.GetObject("boton_laser.Image"), System.Drawing.Image)
        Me.boton_laser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_laser.Name = "boton_laser"
        Me.boton_laser.Size = New System.Drawing.Size(36, 36)
        Me.boton_laser.Text = "Seleccionar Laser"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FuncionesToolStripMenuItem
        '
        Me.FuncionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarProductosToolStripMenuItem, Me.BuscarProveedorToolStripMenuItem})
        Me.FuncionesToolStripMenuItem.Name = "FuncionesToolStripMenuItem"
        Me.FuncionesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.FuncionesToolStripMenuItem.Text = "Funciones"
        '
        'BuscarProductosToolStripMenuItem
        '
        Me.BuscarProductosToolStripMenuItem.Name = "BuscarProductosToolStripMenuItem"
        Me.BuscarProductosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.BuscarProductosToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.BuscarProductosToolStripMenuItem.Text = "Buscar Productos"
        '
        'BuscarProveedorToolStripMenuItem
        '
        Me.BuscarProveedorToolStripMenuItem.Name = "BuscarProveedorToolStripMenuItem"
        Me.BuscarProveedorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.BuscarProveedorToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.BuscarProveedorToolStripMenuItem.Text = "Buscar Proveedor"
        '
        'fechaDevolucion
        '
        Me.fechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDevolucion.Location = New System.Drawing.Point(703, 71)
        Me.fechaDevolucion.Name = "fechaDevolucion"
        Me.fechaDevolucion.Size = New System.Drawing.Size(98, 20)
        Me.fechaDevolucion.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(406, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Factura :"
        '
        'facturatxt
        '
        Me.facturatxt.Location = New System.Drawing.Point(461, 67)
        Me.facturatxt.Name = "facturatxt"
        Me.facturatxt.Size = New System.Drawing.Size(100, 20)
        Me.facturatxt.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(613, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "% Descuento:"
        '
        'pdesctext
        '
        Me.pdesctext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdesctext.Enabled = False
        Me.pdesctext.Location = New System.Drawing.Point(687, 32)
        Me.pdesctext.MaxLength = 2
        Me.pdesctext.Name = "pdesctext"
        Me.pdesctext.Size = New System.Drawing.Size(39, 20)
        Me.pdesctext.TabIndex = 6
        Me.pdesctext.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proveedor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(654, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha :"
        '
        'nombreprovtxt
        '
        Me.nombreprovtxt.Location = New System.Drawing.Point(129, 69)
        Me.nombreprovtxt.Name = "nombreprovtxt"
        Me.nombreprovtxt.ReadOnly = True
        Me.nombreprovtxt.Size = New System.Drawing.Size(258, 20)
        Me.nombreprovtxt.TabIndex = 1
        '
        'id_provtxt
        '
        Me.id_provtxt.Location = New System.Drawing.Point(79, 69)
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
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.linea)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgv)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.piva)
        Me.SplitContainer2.Panel2.Controls.Add(AlmacenLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.AlmacenComboBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer2.Panel2.Controls.Add(Me.comentariotxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label9)
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.IEPStxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.iva10txt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.descuentotxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.subtotaltxt)
        Me.SplitContainer2.Size = New System.Drawing.Size(804, 390)
        Me.SplitContainer2.SplitterDistance = 268
        Me.SplitContainer2.TabIndex = 0
        '
        'linea
        '
        Me.linea.BackColor = System.Drawing.Color.LightSteelBlue
        Me.linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linea.Location = New System.Drawing.Point(3, 3)
        Me.linea.Name = "linea"
        Me.linea.Size = New System.Drawing.Size(313, 29)
        Me.linea.TabIndex = 3
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv.Location = New System.Drawing.Point(0, 38)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(804, 230)
        Me.dgv.TabIndex = 0
        '
        'piva
        '
        Me.piva.Location = New System.Drawing.Point(579, 16)
        Me.piva.Name = "piva"
        Me.piva.ReadOnly = True
        Me.piva.Size = New System.Drawing.Size(34, 20)
        Me.piva.TabIndex = 35
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AlmacenComboBox.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox.DisplayMember = "Almacen"
        Me.AlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Location = New System.Drawing.Point(70, 29)
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
        Me.Label15.Location = New System.Drawing.Point(280, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 16)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Concepto de Salida :"
        '
        'comentariotxt
        '
        Me.comentariotxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.comentariotxt.Location = New System.Drawing.Point(283, 26)
        Me.comentariotxt.MaxLength = 150
        Me.comentariotxt.Multiline = True
        Me.comentariotxt.Name = "comentariotxt"
        Me.comentariotxt.Size = New System.Drawing.Size(230, 89)
        Me.comentariotxt.TabIndex = 35
        Me.comentariotxt.Text = " "
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Verifico :"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(545, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "IVA :"
        '
        'Recibiotxt
        '
        Me.Recibiotxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Recibiotxt.Location = New System.Drawing.Point(70, 78)
        Me.Recibiotxt.MaxLength = 20
        Me.Recibiotxt.Name = "Recibiotxt"
        Me.Recibiotxt.Size = New System.Drawing.Size(193, 20)
        Me.Recibiotxt.TabIndex = 33
        Me.Recibiotxt.Text = " "
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Puerta :"
        '
        'puertatxt
        '
        Me.puertatxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.puertatxt.Location = New System.Drawing.Point(70, 55)
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
        Me.Label12.Location = New System.Drawing.Point(14, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(185, 25)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Datos Generales :"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(659, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "TOTAL :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(673, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "IEPS:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(666, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "% IVA :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(642, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Descuento :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(655, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Subtotal :"
        '
        'totaltxt
        '
        Me.totaltxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.totaltxt.Location = New System.Drawing.Point(713, 95)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(88, 20)
        Me.totaltxt.TabIndex = 17
        Me.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IEPStxt
        '
        Me.IEPStxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IEPStxt.Location = New System.Drawing.Point(713, 69)
        Me.IEPStxt.Name = "IEPStxt"
        Me.IEPStxt.Size = New System.Drawing.Size(88, 20)
        Me.IEPStxt.TabIndex = 16
        Me.IEPStxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'iva10txt
        '
        Me.iva10txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.iva10txt.Location = New System.Drawing.Point(713, 47)
        Me.iva10txt.Name = "iva10txt"
        Me.iva10txt.Size = New System.Drawing.Size(88, 20)
        Me.iva10txt.TabIndex = 15
        Me.iva10txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'descuentotxt
        '
        Me.descuentotxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.descuentotxt.Location = New System.Drawing.Point(713, 26)
        Me.descuentotxt.Name = "descuentotxt"
        Me.descuentotxt.Size = New System.Drawing.Size(88, 20)
        Me.descuentotxt.TabIndex = 14
        Me.descuentotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'subtotaltxt
        '
        Me.subtotaltxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.subtotaltxt.Location = New System.Drawing.Point(713, 5)
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
        Me.status1.Image = CType(resources.GetObject("status1.Image"), System.Drawing.Image)
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
        'devolucion_nueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 530)
        Me.Controls.Add(Me.SplitContainer0)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "devolucion_nueva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Devolucion"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer0.Panel1.ResumeLayout(False)
        Me.SplitContainer0.Panel2.ResumeLayout(False)
        Me.SplitContainer0.Panel2.PerformLayout()
        CType(Me.SplitContainer0, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents pdesctext As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IEPStxt As System.Windows.Forms.TextBox
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
    Friend WithEvents fechaDevolucion As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tool1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents linea As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FuncionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents piva As System.Windows.Forms.TextBox
    Friend WithEvents boton_relacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_repetir As System.Windows.Forms.ToolStripButton
    Friend WithEvents BuscarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boton_suspender As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents GuardarCotizacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeerCotizacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarDevolucEnTiendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tool2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblFolio As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtfolio As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents boton_esc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boton_matris As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_laser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boton_buscar As System.Windows.Forms.ToolStripButton
End Class
