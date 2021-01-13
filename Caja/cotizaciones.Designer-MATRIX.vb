<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotizaciones
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
        Dim Id_cajaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim SerieLabel As System.Windows.Forms.Label
        Dim LocalLabel As System.Windows.Forms.Label
        Dim CajonLabel As System.Windows.Forms.Label
        Dim Abrir_cajonLabel As System.Windows.Forms.Label
        Dim lblFolio As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim Id_cajaLabel1 As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim HorainicioLabel As System.Windows.Forms.Label
        Dim Iduser_abrioLabel As System.Windows.Forms.Label
        Dim HoracierreLabel As System.Windows.Forms.Label
        Dim Iduser_cerroLabel As System.Windows.Forms.Label
        Dim Id_contadoLabel As System.Windows.Forms.Label
        Dim Id_valesLabel As System.Windows.Forms.Label
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim FactorLabel As System.Windows.Forms.Label
        Dim UnidadesLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim VentaLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim Id_unidadLabel As System.Windows.Forms.Label
        Dim EdoLabel As System.Windows.Forms.Label
        Dim DesglosarLabel As System.Windows.Forms.Label
        Dim Precio_unicoLabel As System.Windows.Forms.Label
        Dim IepsLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.sql_documento_impresionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtajustar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.boton_margen = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtmargen = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Total_credito = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.total_debito = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.folio = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.csaldo = New System.Windows.Forms.TextBox()
        Me.cnombre = New System.Windows.Forms.TextBox()
        Me.idcliente = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.boton_UPD_folios = New System.Windows.Forms.Button()
        Me.Id_cajaTextBox1 = New System.Windows.Forms.TextBox()
        Me.Log_cajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HorainicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Iduser_abrioTextBox = New System.Windows.Forms.TextBox()
        Me.HoracierreDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Iduser_cerroTextBox = New System.Windows.Forms.TextBox()
        Me.Id_contadoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_valesTextBox = New System.Windows.Forms.TextBox()
        Me.AlmacenTextBox = New System.Windows.Forms.TextBox()
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemisionTextBox = New System.Windows.Forms.TextBox()
        Me.SeriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FolioTextBox = New System.Windows.Forms.TextBox()
        Me.Id_cajaTextBox = New System.Windows.Forms.TextBox()
        Me.sucursaltxt = New System.Windows.Forms.TextBox()
        Me.SerieTextBox = New System.Windows.Forms.TextBox()
        Me.LocalCheckBox = New System.Windows.Forms.CheckBox()
        Me.CajonCheckBox = New System.Windows.Forms.CheckBox()
        Me.Abrir_cajonTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConsultarExistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosNegadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IepsTextBox = New System.Windows.Forms.TextBox()
        Me.Lista_de_ventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Precio_unicoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.comentarios = New System.Windows.Forms.TextBox()
        Me.grupo1 = New System.Windows.Forms.GroupBox()
        Me.lblunidad = New System.Windows.Forms.Label()
        Me.lblprod = New System.Windows.Forms.Label()
        Me.dgvexistencia = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.facturastxt = New System.Windows.Forms.TextBox()
        Me.lineastxt = New System.Windows.Forms.TextBox()
        Me.Id_unidadTextBox = New System.Windows.Forms.TextBox()
        Me.canttxt = New System.Windows.Forms.TextBox()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.VentaTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadesTextBox = New System.Windows.Forms.TextBox()
        Me.FactorTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.linea = New System.Windows.Forms.TextBox()
        Me.Boton_salir = New System.Windows.Forms.Button()
        Me.CodigoTextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cdesglosar = New System.Windows.Forms.CheckBox()
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cedo = New System.Windows.Forms.TextBox()
        Me.cagente = New System.Windows.Forms.TextBox()
        Me.ccomercial = New System.Windows.Forms.TextBox()
        Me.fvence = New System.Windows.Forms.DateTimePicker()
        Me.Listatxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cdias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.climite = New System.Windows.Forms.TextBox()
        Me.ccolonia = New System.Windows.Forms.TextBox()
        Me.cciudad = New System.Windows.Forms.TextBox()
        Me.crfc = New System.Windows.Forms.TextBox()
        Me.cdireccion = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tot10 = New System.Windows.Forms.TextBox()
        Me.tot0 = New System.Windows.Forms.TextBox()
        Me.iva10 = New System.Windows.Forms.TextBox()
        Me.desc10 = New System.Windows.Forms.TextBox()
        Me.desc0 = New System.Windows.Forms.TextBox()
        Me.sub10 = New System.Windows.Forms.TextBox()
        Me.sub0 = New System.Windows.Forms.TextBox()
        Me.dgvpago = New System.Windows.Forms.DataGridView()
        Me.dgvdoc = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.boton_agregar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.filtropedido = New System.Windows.Forms.TextBox()
        Me.dgvpedido = New System.Windows.Forms.DataGridView()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiarioDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturaVariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agregar_Un_producto_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_agregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.boton_cliente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.CargarUltimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.boton_puerta = New System.Windows.Forms.ToolStripButton()
        Me.boton_guardar = New System.Windows.Forms.ToolStripButton()
        Me.Lista_de_ventasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter()
        Me.CajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter()
        Me.SeriesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.SeriesTableAdapter()
        Me.Log_cajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.boton_NC = New System.Windows.Forms.ToolStripButton()
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter()
        Me.sql_documento_impresionTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documento_impresionTableAdapter()
        Id_cajaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        SerieLabel = New System.Windows.Forms.Label()
        LocalLabel = New System.Windows.Forms.Label()
        CajonLabel = New System.Windows.Forms.Label()
        Abrir_cajonLabel = New System.Windows.Forms.Label()
        lblFolio = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        AlmacenLabel = New System.Windows.Forms.Label()
        Id_cajaLabel1 = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        HorainicioLabel = New System.Windows.Forms.Label()
        Iduser_abrioLabel = New System.Windows.Forms.Label()
        HoracierreLabel = New System.Windows.Forms.Label()
        Iduser_cerroLabel = New System.Windows.Forms.Label()
        Id_contadoLabel = New System.Windows.Forms.Label()
        Id_valesLabel = New System.Windows.Forms.Label()
        Id_productoLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        FactorLabel = New System.Windows.Forms.Label()
        UnidadesLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        VentaLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        Id_unidadLabel = New System.Windows.Forms.Label()
        EdoLabel = New System.Windows.Forms.Label()
        DesglosarLabel = New System.Windows.Forms.Label()
        Precio_unicoLabel = New System.Windows.Forms.Label()
        IepsLabel = New System.Windows.Forms.Label()
        CType(Me.sql_documento_impresionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.Log_cajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Lista_de_ventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo1.SuspendLayout()
        CType(Me.dgvexistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvpago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvpedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_cajaLabel
        '
        Id_cajaLabel.AutoSize = True
        Id_cajaLabel.Location = New System.Drawing.Point(27, 15)
        Id_cajaLabel.Name = "Id_cajaLabel"
        Id_cajaLabel.Size = New System.Drawing.Size(41, 13)
        Id_cajaLabel.TabIndex = 0
        Id_cajaLabel.Text = "id caja:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(27, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'SerieLabel
        '
        SerieLabel.AutoSize = True
        SerieLabel.Location = New System.Drawing.Point(27, 67)
        SerieLabel.Name = "SerieLabel"
        SerieLabel.Size = New System.Drawing.Size(34, 13)
        SerieLabel.TabIndex = 4
        SerieLabel.Text = "Serie:"
        '
        'LocalLabel
        '
        LocalLabel.AutoSize = True
        LocalLabel.Location = New System.Drawing.Point(27, 95)
        LocalLabel.Name = "LocalLabel"
        LocalLabel.Size = New System.Drawing.Size(32, 13)
        LocalLabel.TabIndex = 6
        LocalLabel.Text = "local:"
        '
        'CajonLabel
        '
        CajonLabel.AutoSize = True
        CajonLabel.Location = New System.Drawing.Point(23, 130)
        CajonLabel.Name = "CajonLabel"
        CajonLabel.Size = New System.Drawing.Size(36, 13)
        CajonLabel.TabIndex = 14
        CajonLabel.Text = "cajon:"
        '
        'Abrir_cajonLabel
        '
        Abrir_cajonLabel.AutoSize = True
        Abrir_cajonLabel.Location = New System.Drawing.Point(23, 157)
        Abrir_cajonLabel.Name = "Abrir_cajonLabel"
        Abrir_cajonLabel.Size = New System.Drawing.Size(59, 13)
        Abrir_cajonLabel.TabIndex = 16
        Abrir_cajonLabel.Text = "abrir cajon:"
        '
        'lblFolio
        '
        lblFolio.AutoSize = True
        lblFolio.Enabled = False
        lblFolio.Location = New System.Drawing.Point(168, 67)
        lblFolio.Name = "lblFolio"
        lblFolio.Size = New System.Drawing.Size(35, 13)
        lblFolio.TabIndex = 33
        lblFolio.Text = "Folio :"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Enabled = False
        Label13.Location = New System.Drawing.Point(272, 67)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(56, 13)
        Label13.TabIndex = 34
        Label13.Text = "Remision :"
        '
        'AlmacenLabel
        '
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Enabled = False
        AlmacenLabel.Location = New System.Drawing.Point(179, 93)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(50, 13)
        AlmacenLabel.TabIndex = 34
        AlmacenLabel.Text = "almacen:"
        '
        'Id_cajaLabel1
        '
        Id_cajaLabel1.AutoSize = True
        Id_cajaLabel1.Enabled = False
        Id_cajaLabel1.Location = New System.Drawing.Point(539, 23)
        Id_cajaLabel1.Name = "Id_cajaLabel1"
        Id_cajaLabel1.Size = New System.Drawing.Size(41, 13)
        Id_cajaLabel1.TabIndex = 35
        Id_cajaLabel1.Text = "id caja:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Enabled = False
        FechaLabel.Location = New System.Drawing.Point(539, 50)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 37
        FechaLabel.Text = "fecha:"
        '
        'HorainicioLabel
        '
        HorainicioLabel.AutoSize = True
        HorainicioLabel.Enabled = False
        HorainicioLabel.Location = New System.Drawing.Point(539, 76)
        HorainicioLabel.Name = "HorainicioLabel"
        HorainicioLabel.Size = New System.Drawing.Size(55, 13)
        HorainicioLabel.TabIndex = 39
        HorainicioLabel.Text = "horainicio:"
        '
        'Iduser_abrioLabel
        '
        Iduser_abrioLabel.AutoSize = True
        Iduser_abrioLabel.Enabled = False
        Iduser_abrioLabel.Location = New System.Drawing.Point(539, 101)
        Iduser_abrioLabel.Name = "Iduser_abrioLabel"
        Iduser_abrioLabel.Size = New System.Drawing.Size(64, 13)
        Iduser_abrioLabel.TabIndex = 41
        Iduser_abrioLabel.Text = "iduser abrio:"
        '
        'HoracierreLabel
        '
        HoracierreLabel.AutoSize = True
        HoracierreLabel.Enabled = False
        HoracierreLabel.Location = New System.Drawing.Point(539, 128)
        HoracierreLabel.Name = "HoracierreLabel"
        HoracierreLabel.Size = New System.Drawing.Size(57, 13)
        HoracierreLabel.TabIndex = 43
        HoracierreLabel.Text = "horacierre:"
        '
        'Iduser_cerroLabel
        '
        Iduser_cerroLabel.AutoSize = True
        Iduser_cerroLabel.Enabled = False
        Iduser_cerroLabel.Location = New System.Drawing.Point(539, 153)
        Iduser_cerroLabel.Name = "Iduser_cerroLabel"
        Iduser_cerroLabel.Size = New System.Drawing.Size(65, 13)
        Iduser_cerroLabel.TabIndex = 45
        Iduser_cerroLabel.Text = "iduser cerro:"
        '
        'Id_contadoLabel
        '
        Id_contadoLabel.AutoSize = True
        Id_contadoLabel.Enabled = False
        Id_contadoLabel.Location = New System.Drawing.Point(539, 179)
        Id_contadoLabel.Name = "Id_contadoLabel"
        Id_contadoLabel.Size = New System.Drawing.Size(60, 13)
        Id_contadoLabel.TabIndex = 47
        Id_contadoLabel.Text = "id contado:"
        '
        'Id_valesLabel
        '
        Id_valesLabel.AutoSize = True
        Id_valesLabel.Enabled = False
        Id_valesLabel.Location = New System.Drawing.Point(539, 205)
        Id_valesLabel.Name = "Id_valesLabel"
        Id_valesLabel.Size = New System.Drawing.Size(46, 13)
        Id_valesLabel.TabIndex = 49
        Id_valesLabel.Text = "id vales:"
        '
        'Id_productoLabel
        '
        Id_productoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Id_productoLabel.AutoSize = True
        Id_productoLabel.Location = New System.Drawing.Point(-367, 53)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(63, 13)
        Id_productoLabel.TabIndex = 9
        Id_productoLabel.Text = "id producto:"
        '
        'CodigoLabel
        '
        CodigoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(75, 42)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 10
        CodigoLabel.Text = "Codigo:"
        '
        'FactorLabel
        '
        FactorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FactorLabel.AutoSize = True
        FactorLabel.Location = New System.Drawing.Point(-361, 92)
        FactorLabel.Name = "FactorLabel"
        FactorLabel.Size = New System.Drawing.Size(37, 13)
        FactorLabel.TabIndex = 11
        FactorLabel.Text = "factor:"
        '
        'UnidadesLabel
        '
        UnidadesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UnidadesLabel.AutoSize = True
        UnidadesLabel.Location = New System.Drawing.Point(-364, 120)
        UnidadesLabel.Name = "UnidadesLabel"
        UnidadesLabel.Size = New System.Drawing.Size(53, 13)
        UnidadesLabel.TabIndex = 12
        UnidadesLabel.Text = "unidades:"
        '
        'CostoLabel
        '
        CostoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(-363, 147)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(36, 13)
        CostoLabel.TabIndex = 14
        CostoLabel.Text = "costo:"
        '
        'VentaLabel
        '
        VentaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        VentaLabel.AutoSize = True
        VentaLabel.Location = New System.Drawing.Point(-368, 177)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(37, 13)
        VentaLabel.TabIndex = 16
        VentaLabel.Text = "venta:"
        '
        'PesoLabel
        '
        PesoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(-352, 201)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(33, 13)
        PesoLabel.TabIndex = 18
        PesoLabel.Text = "peso:"
        '
        'IvaLabel
        '
        IvaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(-367, 234)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 20
        IvaLabel.Text = "iva:"
        '
        'Id_unidadLabel
        '
        Id_unidadLabel.AutoSize = True
        Id_unidadLabel.Location = New System.Drawing.Point(449, 179)
        Id_unidadLabel.Name = "Id_unidadLabel"
        Id_unidadLabel.Size = New System.Drawing.Size(53, 13)
        Id_unidadLabel.TabIndex = 23
        Id_unidadLabel.Text = "id unidad:"
        '
        'EdoLabel
        '
        EdoLabel.AutoSize = True
        EdoLabel.Enabled = False
        EdoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EdoLabel.Location = New System.Drawing.Point(420, 104)
        EdoLabel.Name = "EdoLabel"
        EdoLabel.Size = New System.Drawing.Size(50, 24)
        EdoLabel.TabIndex = 38
        EdoLabel.Text = "Edo:"
        '
        'DesglosarLabel
        '
        DesglosarLabel.AutoSize = True
        DesglosarLabel.Enabled = False
        DesglosarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesglosarLabel.Location = New System.Drawing.Point(409, 189)
        DesglosarLabel.Name = "DesglosarLabel"
        DesglosarLabel.Size = New System.Drawing.Size(99, 24)
        DesglosarLabel.TabIndex = 40
        DesglosarLabel.Text = "Desglosar:"
        '
        'Precio_unicoLabel
        '
        Precio_unicoLabel.AutoSize = True
        Precio_unicoLabel.Location = New System.Drawing.Point(179, 97)
        Precio_unicoLabel.Name = "Precio_unicoLabel"
        Precio_unicoLabel.Size = New System.Drawing.Size(68, 13)
        Precio_unicoLabel.TabIndex = 40
        Precio_unicoLabel.Text = "precio unico:"
        '
        'IepsLabel
        '
        IepsLabel.AutoSize = True
        IepsLabel.Location = New System.Drawing.Point(147, 125)
        IepsLabel.Name = "IepsLabel"
        IepsLabel.Size = New System.Drawing.Size(29, 13)
        IepsLabel.TabIndex = 41
        IepsLabel.Text = "ieps:"
        '
        'sql_documento_impresionBindingSource
        '
        Me.sql_documento_impresionBindingSource.DataMember = "sql_documento_impresion"
        Me.sql_documento_impresionBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 66)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label21)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Total_credito)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer1.Panel1.Controls.Add(Me.total_debito)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.folio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label28)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsaldo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.csaldo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cnombre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.idcliente)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1153, 384)
        Me.SplitContainer1.SplitterDistance = 87
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel.Controls.Add(Me.Button1)
        Me.Panel.Controls.Add(Me.Label22)
        Me.Panel.Controls.Add(Me.txtajustar)
        Me.Panel.Controls.Add(Me.Label17)
        Me.Panel.Controls.Add(Me.txtcosto)
        Me.Panel.Controls.Add(Me.boton_margen)
        Me.Panel.Controls.Add(Me.Label16)
        Me.Panel.Controls.Add(Me.txtmargen)
        Me.Panel.Location = New System.Drawing.Point(10, 39)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(674, 45)
        Me.Panel.TabIndex = 51
        Me.Panel.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(608, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Ajusta"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(416, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 23)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Ajustar a :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label22.Visible = False
        '
        'txtajustar
        '
        Me.txtajustar.Location = New System.Drawing.Point(502, 13)
        Me.txtajustar.Name = "txtajustar"
        Me.txtajustar.Size = New System.Drawing.Size(100, 20)
        Me.txtajustar.TabIndex = 50
        Me.txtajustar.Visible = False
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(187, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 23)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Costo paquete :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcosto
        '
        Me.txtcosto.Enabled = False
        Me.txtcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto.Location = New System.Drawing.Point(323, 14)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(93, 22)
        Me.txtcosto.TabIndex = 3
        '
        'boton_margen
        '
        Me.boton_margen.Location = New System.Drawing.Point(135, 12)
        Me.boton_margen.Name = "boton_margen"
        Me.boton_margen.Size = New System.Drawing.Size(49, 23)
        Me.boton_margen.TabIndex = 2
        Me.boton_margen.Text = "Aplicar"
        Me.boton_margen.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Aplicar Margen :"
        '
        'txtmargen
        '
        Me.txtmargen.Location = New System.Drawing.Point(93, 13)
        Me.txtmargen.Name = "txtmargen"
        Me.txtmargen.Size = New System.Drawing.Size(36, 20)
        Me.txtmargen.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(945, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 23)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Credito :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Total_credito
        '
        Me.Total_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_credito.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Total_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_credito.ForeColor = System.Drawing.Color.White
        Me.Total_credito.Location = New System.Drawing.Point(1039, 46)
        Me.Total_credito.Name = "Total_credito"
        Me.Total_credito.ReadOnly = True
        Me.Total_credito.Size = New System.Drawing.Size(102, 29)
        Me.Total_credito.TabIndex = 49
        Me.Total_credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(745, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 23)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Debito :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'total_debito
        '
        Me.total_debito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total_debito.BackColor = System.Drawing.Color.LightSteelBlue
        Me.total_debito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_debito.ForeColor = System.Drawing.Color.White
        Me.total_debito.Location = New System.Drawing.Point(834, 49)
        Me.total_debito.Name = "total_debito"
        Me.total_debito.ReadOnly = True
        Me.total_debito.Size = New System.Drawing.Size(102, 29)
        Me.total_debito.TabIndex = 47
        Me.total_debito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(951, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 23)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Folio :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'folio
        '
        Me.folio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.folio.Enabled = False
        Me.folio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folio.Location = New System.Drawing.Point(1036, 4)
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        Me.folio.Size = New System.Drawing.Size(105, 31)
        Me.folio.TabIndex = 45
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(7, 12)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 15)
        Me.Label28.TabIndex = 38
        Me.Label28.Text = "Cliente:"
        '
        'lblsaldo
        '
        Me.lblsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaldo.ForeColor = System.Drawing.Color.White
        Me.lblsaldo.Location = New System.Drawing.Point(456, 13)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(69, 23)
        Me.lblsaldo.TabIndex = 28
        Me.lblsaldo.Text = "Saldo:"
        Me.lblsaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblsaldo.Visible = False
        '
        'csaldo
        '
        Me.csaldo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.csaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csaldo.Location = New System.Drawing.Point(531, 6)
        Me.csaldo.Name = "csaldo"
        Me.csaldo.ReadOnly = True
        Me.csaldo.Size = New System.Drawing.Size(153, 29)
        Me.csaldo.TabIndex = 2
        Me.csaldo.Visible = False
        '
        'cnombre
        '
        Me.cnombre.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnombre.Location = New System.Drawing.Point(137, 9)
        Me.cnombre.Name = "cnombre"
        Me.cnombre.ReadOnly = True
        Me.cnombre.Size = New System.Drawing.Size(321, 24)
        Me.cnombre.TabIndex = 1
        Me.cnombre.Text = "Publico en General"
        '
        'idcliente
        '
        Me.idcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idcliente.Location = New System.Drawing.Point(68, 9)
        Me.idcliente.Name = "idcliente"
        Me.idcliente.Size = New System.Drawing.Size(63, 24)
        Me.idcliente.TabIndex = 0
        Me.idcliente.Text = "0"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1153, 293)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage4.Controls.Add(Me.boton_UPD_folios)
        Me.TabPage4.Controls.Add(Id_cajaLabel1)
        Me.TabPage4.Controls.Add(Me.Id_cajaTextBox1)
        Me.TabPage4.Controls.Add(FechaLabel)
        Me.TabPage4.Controls.Add(Me.FechaDateTimePicker)
        Me.TabPage4.Controls.Add(HorainicioLabel)
        Me.TabPage4.Controls.Add(Me.HorainicioDateTimePicker)
        Me.TabPage4.Controls.Add(Iduser_abrioLabel)
        Me.TabPage4.Controls.Add(Me.Iduser_abrioTextBox)
        Me.TabPage4.Controls.Add(HoracierreLabel)
        Me.TabPage4.Controls.Add(Me.HoracierreDateTimePicker)
        Me.TabPage4.Controls.Add(Iduser_cerroLabel)
        Me.TabPage4.Controls.Add(Me.Iduser_cerroTextBox)
        Me.TabPage4.Controls.Add(Id_contadoLabel)
        Me.TabPage4.Controls.Add(Me.Id_contadoTextBox)
        Me.TabPage4.Controls.Add(Id_valesLabel)
        Me.TabPage4.Controls.Add(Me.Id_valesTextBox)
        Me.TabPage4.Controls.Add(AlmacenLabel)
        Me.TabPage4.Controls.Add(Me.AlmacenTextBox)
        Me.TabPage4.Controls.Add(Label13)
        Me.TabPage4.Controls.Add(lblFolio)
        Me.TabPage4.Controls.Add(Me.RemisionTextBox)
        Me.TabPage4.Controls.Add(Me.FolioTextBox)
        Me.TabPage4.Controls.Add(Id_cajaLabel)
        Me.TabPage4.Controls.Add(Me.Id_cajaTextBox)
        Me.TabPage4.Controls.Add(NombreLabel)
        Me.TabPage4.Controls.Add(Me.sucursaltxt)
        Me.TabPage4.Controls.Add(SerieLabel)
        Me.TabPage4.Controls.Add(Me.SerieTextBox)
        Me.TabPage4.Controls.Add(LocalLabel)
        Me.TabPage4.Controls.Add(Me.LocalCheckBox)
        Me.TabPage4.Controls.Add(CajonLabel)
        Me.TabPage4.Controls.Add(Me.CajonCheckBox)
        Me.TabPage4.Controls.Add(Abrir_cajonLabel)
        Me.TabPage4.Controls.Add(Me.Abrir_cajonTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1145, 264)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Caja"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'boton_UPD_folios
        '
        Me.boton_UPD_folios.Location = New System.Drawing.Point(404, 61)
        Me.boton_UPD_folios.Name = "boton_UPD_folios"
        Me.boton_UPD_folios.Size = New System.Drawing.Size(36, 23)
        Me.boton_UPD_folios.TabIndex = 51
        Me.boton_UPD_folios.Text = "Button1"
        Me.boton_UPD_folios.UseVisualStyleBackColor = True
        '
        'Id_cajaTextBox1
        '
        Me.Id_cajaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "id_caja", True))
        Me.Id_cajaTextBox1.Enabled = False
        Me.Id_cajaTextBox1.Location = New System.Drawing.Point(610, 20)
        Me.Id_cajaTextBox1.Name = "Id_cajaTextBox1"
        Me.Id_cajaTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.Id_cajaTextBox1.TabIndex = 36
        '
        'Log_cajasBindingSource
        '
        Me.Log_cajasBindingSource.DataMember = "log_cajas"
        Me.Log_cajasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Log_cajasBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(610, 46)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 38
        '
        'HorainicioDateTimePicker
        '
        Me.HorainicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Log_cajasBindingSource, "horainicio", True))
        Me.HorainicioDateTimePicker.Enabled = False
        Me.HorainicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HorainicioDateTimePicker.Location = New System.Drawing.Point(610, 72)
        Me.HorainicioDateTimePicker.Name = "HorainicioDateTimePicker"
        Me.HorainicioDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HorainicioDateTimePicker.TabIndex = 40
        '
        'Iduser_abrioTextBox
        '
        Me.Iduser_abrioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "iduser_abrio", True))
        Me.Iduser_abrioTextBox.Enabled = False
        Me.Iduser_abrioTextBox.Location = New System.Drawing.Point(610, 98)
        Me.Iduser_abrioTextBox.Name = "Iduser_abrioTextBox"
        Me.Iduser_abrioTextBox.Size = New System.Drawing.Size(47, 20)
        Me.Iduser_abrioTextBox.TabIndex = 42
        '
        'HoracierreDateTimePicker
        '
        Me.HoracierreDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Log_cajasBindingSource, "horacierre", True))
        Me.HoracierreDateTimePicker.Enabled = False
        Me.HoracierreDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoracierreDateTimePicker.Location = New System.Drawing.Point(610, 124)
        Me.HoracierreDateTimePicker.Name = "HoracierreDateTimePicker"
        Me.HoracierreDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HoracierreDateTimePicker.TabIndex = 44
        '
        'Iduser_cerroTextBox
        '
        Me.Iduser_cerroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "iduser_cerro", True))
        Me.Iduser_cerroTextBox.Enabled = False
        Me.Iduser_cerroTextBox.Location = New System.Drawing.Point(610, 150)
        Me.Iduser_cerroTextBox.Name = "Iduser_cerroTextBox"
        Me.Iduser_cerroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Iduser_cerroTextBox.TabIndex = 46
        '
        'Id_contadoTextBox
        '
        Me.Id_contadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "id_contado", True))
        Me.Id_contadoTextBox.Enabled = False
        Me.Id_contadoTextBox.Location = New System.Drawing.Point(610, 176)
        Me.Id_contadoTextBox.Name = "Id_contadoTextBox"
        Me.Id_contadoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_contadoTextBox.TabIndex = 48
        '
        'Id_valesTextBox
        '
        Me.Id_valesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "id_vales", True))
        Me.Id_valesTextBox.Enabled = False
        Me.Id_valesTextBox.Location = New System.Drawing.Point(610, 202)
        Me.Id_valesTextBox.Name = "Id_valesTextBox"
        Me.Id_valesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_valesTextBox.TabIndex = 50
        '
        'AlmacenTextBox
        '
        Me.AlmacenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "almacen", True))
        Me.AlmacenTextBox.Enabled = False
        Me.AlmacenTextBox.Location = New System.Drawing.Point(235, 90)
        Me.AlmacenTextBox.Name = "AlmacenTextBox"
        Me.AlmacenTextBox.Size = New System.Drawing.Size(31, 20)
        Me.AlmacenTextBox.TabIndex = 35
        '
        'CajasBindingSource
        '
        Me.CajasBindingSource.DataMember = "cajas"
        Me.CajasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'RemisionTextBox
        '
        Me.RemisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeriesBindingSource, "remision", True))
        Me.RemisionTextBox.Enabled = False
        Me.RemisionTextBox.Location = New System.Drawing.Point(334, 64)
        Me.RemisionTextBox.Name = "RemisionTextBox"
        Me.RemisionTextBox.Size = New System.Drawing.Size(57, 20)
        Me.RemisionTextBox.TabIndex = 32
        '
        'SeriesBindingSource
        '
        Me.SeriesBindingSource.DataMember = "Series"
        Me.SeriesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'FolioTextBox
        '
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeriesBindingSource, "Folio", True))
        Me.FolioTextBox.Enabled = False
        Me.FolioTextBox.Location = New System.Drawing.Point(209, 64)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.Size = New System.Drawing.Size(57, 20)
        Me.FolioTextBox.TabIndex = 31
        '
        'Id_cajaTextBox
        '
        Me.Id_cajaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "id_caja", True))
        Me.Id_cajaTextBox.Enabled = False
        Me.Id_cajaTextBox.Location = New System.Drawing.Point(129, 12)
        Me.Id_cajaTextBox.Name = "Id_cajaTextBox"
        Me.Id_cajaTextBox.Size = New System.Drawing.Size(37, 20)
        Me.Id_cajaTextBox.TabIndex = 1
        '
        'sucursaltxt
        '
        Me.sucursaltxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "Nombre", True))
        Me.sucursaltxt.Enabled = False
        Me.sucursaltxt.Location = New System.Drawing.Point(129, 38)
        Me.sucursaltxt.Name = "sucursaltxt"
        Me.sucursaltxt.Size = New System.Drawing.Size(137, 20)
        Me.sucursaltxt.TabIndex = 3
        '
        'SerieTextBox
        '
        Me.SerieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "Serie", True))
        Me.SerieTextBox.Enabled = False
        Me.SerieTextBox.Location = New System.Drawing.Point(129, 64)
        Me.SerieTextBox.Name = "SerieTextBox"
        Me.SerieTextBox.Size = New System.Drawing.Size(37, 20)
        Me.SerieTextBox.TabIndex = 5
        '
        'LocalCheckBox
        '
        Me.LocalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CajasBindingSource, "local", True))
        Me.LocalCheckBox.Enabled = False
        Me.LocalCheckBox.Location = New System.Drawing.Point(129, 90)
        Me.LocalCheckBox.Name = "LocalCheckBox"
        Me.LocalCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.LocalCheckBox.TabIndex = 7
        '
        'CajonCheckBox
        '
        Me.CajonCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CajasBindingSource, "cajon", True))
        Me.CajonCheckBox.Enabled = False
        Me.CajonCheckBox.Location = New System.Drawing.Point(129, 116)
        Me.CajonCheckBox.Name = "CajonCheckBox"
        Me.CajonCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.CajonCheckBox.TabIndex = 15
        '
        'Abrir_cajonTextBox
        '
        Me.Abrir_cajonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "abrir_cajon", True))
        Me.Abrir_cajonTextBox.Enabled = False
        Me.Abrir_cajonTextBox.Location = New System.Drawing.Point(129, 146)
        Me.Abrir_cajonTextBox.Name = "Abrir_cajonTextBox"
        Me.Abrir_cajonTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Abrir_cajonTextBox.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Controls.Add(IepsLabel)
        Me.TabPage1.Controls.Add(Me.IepsTextBox)
        Me.TabPage1.Controls.Add(Precio_unicoLabel)
        Me.TabPage1.Controls.Add(Me.Precio_unicoCheckBox)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.comentarios)
        Me.TabPage1.Controls.Add(Me.grupo1)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.facturastxt)
        Me.TabPage1.Controls.Add(Id_unidadLabel)
        Me.TabPage1.Controls.Add(Me.lineastxt)
        Me.TabPage1.Controls.Add(Me.Id_unidadTextBox)
        Me.TabPage1.Controls.Add(Me.canttxt)
        Me.TabPage1.Controls.Add(Me.idtxt)
        Me.TabPage1.Controls.Add(IvaLabel)
        Me.TabPage1.Controls.Add(Me.IvaTextBox)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(PesoLabel)
        Me.TabPage1.Controls.Add(Me.totaltxt)
        Me.TabPage1.Controls.Add(Me.PesoTextBox)
        Me.TabPage1.Controls.Add(VentaLabel)
        Me.TabPage1.Controls.Add(Me.VentaTextBox)
        Me.TabPage1.Controls.Add(CostoLabel)
        Me.TabPage1.Controls.Add(Me.CostoTextBox)
        Me.TabPage1.Controls.Add(UnidadesLabel)
        Me.TabPage1.Controls.Add(Me.UnidadesTextBox)
        Me.TabPage1.Controls.Add(FactorLabel)
        Me.TabPage1.Controls.Add(Me.FactorTextBox)
        Me.TabPage1.Controls.Add(CodigoLabel)
        Me.TabPage1.Controls.Add(Me.CodigoComboBox)
        Me.TabPage1.Controls.Add(Id_productoLabel)
        Me.TabPage1.Controls.Add(Me.Id_productoTextBox)
        Me.TabPage1.Controls.Add(Me.UnidadTextBox)
        Me.TabPage1.Controls.Add(Me.DescripcionTextBox)
        Me.TabPage1.Controls.Add(Me.linea)
        Me.TabPage1.Controls.Add(Me.Boton_salir)
        Me.TabPage1.Controls.Add(Me.CodigoTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1145, 264)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nota"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.Location = New System.Drawing.Point(0, 41)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(841, 170)
        Me.dgv.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarExistenciaToolStripMenuItem, Me.ProductosNegadosToolStripMenuItem, Me.BorrarProductoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 70)
        '
        'ConsultarExistenciaToolStripMenuItem
        '
        Me.ConsultarExistenciaToolStripMenuItem.Name = "ConsultarExistenciaToolStripMenuItem"
        Me.ConsultarExistenciaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ConsultarExistenciaToolStripMenuItem.Text = "Consultar Existencia"
        '
        'ProductosNegadosToolStripMenuItem
        '
        Me.ProductosNegadosToolStripMenuItem.Name = "ProductosNegadosToolStripMenuItem"
        Me.ProductosNegadosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ProductosNegadosToolStripMenuItem.Text = "Productos Negados"
        '
        'BorrarProductoToolStripMenuItem
        '
        Me.BorrarProductoToolStripMenuItem.Name = "BorrarProductoToolStripMenuItem"
        Me.BorrarProductoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.BorrarProductoToolStripMenuItem.Text = "Borrar Producto"
        '
        'IepsTextBox
        '
        Me.IepsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "ieps", True))
        Me.IepsTextBox.Location = New System.Drawing.Point(182, 122)
        Me.IepsTextBox.Name = "IepsTextBox"
        Me.IepsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IepsTextBox.TabIndex = 42
        '
        'Lista_de_ventasBindingSource
        '
        Me.Lista_de_ventasBindingSource.DataMember = "Lista_de_ventas"
        Me.Lista_de_ventasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Precio_unicoCheckBox
        '
        Me.Precio_unicoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Lista_de_ventasBindingSource, "precio_unico", True))
        Me.Precio_unicoCheckBox.Location = New System.Drawing.Point(253, 92)
        Me.Precio_unicoCheckBox.Name = "Precio_unicoCheckBox"
        Me.Precio_unicoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Precio_unicoCheckBox.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(3, 217)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 15)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Comentarios :"
        '
        'comentarios
        '
        Me.comentarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.comentarios.Location = New System.Drawing.Point(101, 217)
        Me.comentarios.MaxLength = 200
        Me.comentarios.Multiline = True
        Me.comentarios.Name = "comentarios"
        Me.comentarios.Size = New System.Drawing.Size(512, 44)
        Me.comentarios.TabIndex = 34
        '
        'grupo1
        '
        Me.grupo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupo1.Controls.Add(Me.lblunidad)
        Me.grupo1.Controls.Add(Me.lblprod)
        Me.grupo1.Controls.Add(Me.dgvexistencia)
        Me.grupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo1.ForeColor = System.Drawing.Color.White
        Me.grupo1.Location = New System.Drawing.Point(847, 6)
        Me.grupo1.Name = "grupo1"
        Me.grupo1.Size = New System.Drawing.Size(288, 243)
        Me.grupo1.TabIndex = 33
        Me.grupo1.TabStop = False
        Me.grupo1.Text = "Existencias"
        Me.grupo1.Visible = False
        '
        'lblunidad
        '
        Me.lblunidad.AutoSize = True
        Me.lblunidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunidad.Location = New System.Drawing.Point(15, 57)
        Me.lblunidad.Name = "lblunidad"
        Me.lblunidad.Size = New System.Drawing.Size(59, 18)
        Me.lblunidad.TabIndex = 2
        Me.lblunidad.Text = "Label12"
        '
        'lblprod
        '
        Me.lblprod.AutoSize = True
        Me.lblprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprod.Location = New System.Drawing.Point(15, 27)
        Me.lblprod.Name = "lblprod"
        Me.lblprod.Size = New System.Drawing.Size(59, 18)
        Me.lblprod.TabIndex = 1
        Me.lblprod.Text = "Label12"
        '
        'dgvexistencia
        '
        Me.dgvexistencia.AllowUserToAddRows = False
        Me.dgvexistencia.AllowUserToDeleteRows = False
        Me.dgvexistencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvexistencia.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvexistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvexistencia.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvexistencia.Location = New System.Drawing.Point(3, 90)
        Me.dgvexistencia.Name = "dgvexistencia"
        Me.dgvexistencia.RowHeadersVisible = False
        Me.dgvexistencia.Size = New System.Drawing.Size(282, 150)
        Me.dgvexistencia.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(358, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 23)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Facturas:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Visible = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(249, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 23)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Lineas :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'facturastxt
        '
        Me.facturastxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.facturastxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facturastxt.Location = New System.Drawing.Point(452, 12)
        Me.facturastxt.Name = "facturastxt"
        Me.facturastxt.ReadOnly = True
        Me.facturastxt.Size = New System.Drawing.Size(40, 24)
        Me.facturastxt.TabIndex = 30
        Me.facturastxt.Text = "0"
        Me.facturastxt.Visible = False
        '
        'lineastxt
        '
        Me.lineastxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lineastxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lineastxt.Location = New System.Drawing.Point(315, 12)
        Me.lineastxt.Name = "lineastxt"
        Me.lineastxt.ReadOnly = True
        Me.lineastxt.Size = New System.Drawing.Size(40, 24)
        Me.lineastxt.TabIndex = 29
        Me.lineastxt.Text = "0"
        '
        'Id_unidadTextBox
        '
        Me.Id_unidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "id_unidad", True))
        Me.Id_unidadTextBox.Location = New System.Drawing.Point(397, 191)
        Me.Id_unidadTextBox.Name = "Id_unidadTextBox"
        Me.Id_unidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_unidadTextBox.TabIndex = 24
        '
        'canttxt
        '
        Me.canttxt.Location = New System.Drawing.Point(397, 145)
        Me.canttxt.Name = "canttxt"
        Me.canttxt.Size = New System.Drawing.Size(50, 20)
        Me.canttxt.TabIndex = 23
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(397, 119)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(50, 20)
        Me.idtxt.TabIndex = 22
        '
        'IvaTextBox
        '
        Me.IvaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(-334, 231)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(23, 20)
        Me.IvaTextBox.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(551, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 23)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Total :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totaltxt
        '
        Me.totaltxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totaltxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.totaltxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltxt.Location = New System.Drawing.Point(636, 6)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.ReadOnly = True
        Me.totaltxt.Size = New System.Drawing.Size(170, 31)
        Me.totaltxt.TabIndex = 26
        Me.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PesoTextBox
        '
        Me.PesoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(-310, 198)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PesoTextBox.TabIndex = 19
        '
        'VentaTextBox
        '
        Me.VentaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "venta", True))
        Me.VentaTextBox.Location = New System.Drawing.Point(-322, 174)
        Me.VentaTextBox.Name = "VentaTextBox"
        Me.VentaTextBox.Size = New System.Drawing.Size(60, 20)
        Me.VentaTextBox.TabIndex = 17
        '
        'CostoTextBox
        '
        Me.CostoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(-321, 147)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(57, 20)
        Me.CostoTextBox.TabIndex = 15
        '
        'UnidadesTextBox
        '
        Me.UnidadesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnidadesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "unidades", True))
        Me.UnidadesTextBox.Location = New System.Drawing.Point(-306, 118)
        Me.UnidadesTextBox.Name = "UnidadesTextBox"
        Me.UnidadesTextBox.Size = New System.Drawing.Size(42, 20)
        Me.UnidadesTextBox.TabIndex = 13
        '
        'FactorTextBox
        '
        Me.FactorTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FactorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "factor", True))
        Me.FactorTextBox.Location = New System.Drawing.Point(-321, 91)
        Me.FactorTextBox.Name = "FactorTextBox"
        Me.FactorTextBox.Size = New System.Drawing.Size(57, 20)
        Me.FactorTextBox.TabIndex = 12
        '
        'CodigoComboBox
        '
        Me.CodigoComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodigoComboBox.DataSource = Me.Lista_de_ventasBindingSource
        Me.CodigoComboBox.DisplayMember = "Codigo"
        Me.CodigoComboBox.FormattingEnabled = True
        Me.CodigoComboBox.Location = New System.Drawing.Point(405, 171)
        Me.CodigoComboBox.Name = "CodigoComboBox"
        Me.CodigoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CodigoComboBox.TabIndex = 11
        Me.CodigoComboBox.ValueMember = "id_producto"
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(-361, 69)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Id_productoTextBox.TabIndex = 10
        '
        'UnidadTextBox
        '
        Me.UnidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Unidad", True))
        Me.UnidadTextBox.Location = New System.Drawing.Point(397, 96)
        Me.UnidadTextBox.Name = "UnidadTextBox"
        Me.UnidadTextBox.Size = New System.Drawing.Size(59, 20)
        Me.UnidadTextBox.TabIndex = 8
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(397, 61)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(179, 20)
        Me.DescripcionTextBox.TabIndex = 7
        '
        'linea
        '
        Me.linea.BackColor = System.Drawing.Color.LightSteelBlue
        Me.linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linea.Location = New System.Drawing.Point(2, 6)
        Me.linea.Name = "linea"
        Me.linea.Size = New System.Drawing.Size(233, 29)
        Me.linea.TabIndex = 2
        '
        'Boton_salir
        '
        Me.Boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Boton_salir.Location = New System.Drawing.Point(575, 96)
        Me.Boton_salir.Name = "Boton_salir"
        Me.Boton_salir.Size = New System.Drawing.Size(62, 23)
        Me.Boton_salir.TabIndex = 0
        Me.Boton_salir.Text = "Button1"
        Me.Boton_salir.UseVisualStyleBackColor = True
        '
        'CodigoTextBox1
        '
        Me.CodigoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Codigo", True))
        Me.CodigoTextBox1.Location = New System.Drawing.Point(315, 165)
        Me.CodigoTextBox1.Name = "CodigoTextBox1"
        Me.CodigoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox1.TabIndex = 40
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1145, 264)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Pagar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage3.Controls.Add(DesglosarLabel)
        Me.TabPage3.Controls.Add(Me.cdesglosar)
        Me.TabPage3.Controls.Add(EdoLabel)
        Me.TabPage3.Controls.Add(Me.cedo)
        Me.TabPage3.Controls.Add(Me.cagente)
        Me.TabPage3.Controls.Add(Me.ccomercial)
        Me.TabPage3.Controls.Add(Me.fvence)
        Me.TabPage3.Controls.Add(Me.Listatxt)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.cdias)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.climite)
        Me.TabPage3.Controls.Add(Me.ccolonia)
        Me.TabPage3.Controls.Add(Me.cciudad)
        Me.TabPage3.Controls.Add(Me.crfc)
        Me.TabPage3.Controls.Add(Me.cdireccion)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1145, 264)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Datos Cliente"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cdesglosar
        '
        Me.cdesglosar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cdesglosar.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DirectorioBindingSource, "Desglosar", True))
        Me.cdesglosar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdesglosar.Location = New System.Drawing.Point(514, 190)
        Me.cdesglosar.Name = "cdesglosar"
        Me.cdesglosar.Size = New System.Drawing.Size(32, 24)
        Me.cdesglosar.TabIndex = 41
        Me.cdesglosar.UseVisualStyleBackColor = False
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'cedo
        '
        Me.cedo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cedo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Edo", True))
        Me.cedo.Enabled = False
        Me.cedo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedo.Location = New System.Drawing.Point(476, 104)
        Me.cedo.Name = "cedo"
        Me.cedo.ReadOnly = True
        Me.cedo.Size = New System.Drawing.Size(212, 29)
        Me.cedo.TabIndex = 39
        '
        'cagente
        '
        Me.cagente.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cagente.Enabled = False
        Me.cagente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cagente.Location = New System.Drawing.Point(631, 184)
        Me.cagente.Name = "cagente"
        Me.cagente.ReadOnly = True
        Me.cagente.Size = New System.Drawing.Size(57, 29)
        Me.cagente.TabIndex = 38
        '
        'ccomercial
        '
        Me.ccomercial.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ccomercial.Enabled = False
        Me.ccomercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccomercial.Location = New System.Drawing.Point(27, 6)
        Me.ccomercial.Name = "ccomercial"
        Me.ccomercial.ReadOnly = True
        Me.ccomercial.Size = New System.Drawing.Size(563, 29)
        Me.ccomercial.TabIndex = 37
        '
        'fvence
        '
        Me.fvence.Enabled = False
        Me.fvence.Location = New System.Drawing.Point(640, 11)
        Me.fvence.Name = "fvence"
        Me.fvence.Size = New System.Drawing.Size(200, 20)
        Me.fvence.TabIndex = 28
        '
        'Listatxt
        '
        Me.Listatxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Listatxt.Enabled = False
        Me.Listatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listatxt.Location = New System.Drawing.Point(568, 184)
        Me.Listatxt.Name = "Listatxt"
        Me.Listatxt.ReadOnly = True
        Me.Listatxt.Size = New System.Drawing.Size(57, 29)
        Me.Listatxt.TabIndex = 26
        Me.Listatxt.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Dias :"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Limite  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "R.F.C.  :"
        '
        'cdias
        '
        Me.cdias.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cdias.Enabled = False
        Me.cdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdias.Location = New System.Drawing.Point(126, 184)
        Me.cdias.Name = "cdias"
        Me.cdias.ReadOnly = True
        Me.cdias.Size = New System.Drawing.Size(74, 29)
        Me.cdias.TabIndex = 3
        Me.cdias.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ciudad  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Colonia :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Direccion :"
        '
        'climite
        '
        Me.climite.BackColor = System.Drawing.Color.LightSteelBlue
        Me.climite.Enabled = False
        Me.climite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.climite.Location = New System.Drawing.Point(126, 138)
        Me.climite.Name = "climite"
        Me.climite.ReadOnly = True
        Me.climite.Size = New System.Drawing.Size(179, 29)
        Me.climite.TabIndex = 7
        Me.climite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ccolonia
        '
        Me.ccolonia.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ccolonia.Enabled = False
        Me.ccolonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccolonia.Location = New System.Drawing.Point(126, 71)
        Me.ccolonia.Name = "ccolonia"
        Me.ccolonia.ReadOnly = True
        Me.ccolonia.Size = New System.Drawing.Size(562, 29)
        Me.ccolonia.TabIndex = 6
        '
        'cciudad
        '
        Me.cciudad.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cciudad.Enabled = False
        Me.cciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cciudad.Location = New System.Drawing.Point(126, 104)
        Me.cciudad.Name = "cciudad"
        Me.cciudad.ReadOnly = True
        Me.cciudad.Size = New System.Drawing.Size(282, 29)
        Me.cciudad.TabIndex = 5
        '
        'crfc
        '
        Me.crfc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.crfc.Enabled = False
        Me.crfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crfc.Location = New System.Drawing.Point(404, 139)
        Me.crfc.Name = "crfc"
        Me.crfc.ReadOnly = True
        Me.crfc.Size = New System.Drawing.Size(284, 29)
        Me.crfc.TabIndex = 4
        '
        'cdireccion
        '
        Me.cdireccion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cdireccion.Enabled = False
        Me.cdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdireccion.Location = New System.Drawing.Point(126, 41)
        Me.cdireccion.Name = "cdireccion"
        Me.cdireccion.ReadOnly = True
        Me.cdireccion.Size = New System.Drawing.Size(562, 29)
        Me.cdireccion.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Controls.Add(Me.tot10)
        Me.TabPage5.Controls.Add(Me.tot0)
        Me.TabPage5.Controls.Add(Me.iva10)
        Me.TabPage5.Controls.Add(Me.desc10)
        Me.TabPage5.Controls.Add(Me.desc0)
        Me.TabPage5.Controls.Add(Me.sub10)
        Me.TabPage5.Controls.Add(Me.sub0)
        Me.TabPage5.Controls.Add(Me.dgvpago)
        Me.TabPage5.Controls.Add(Me.dgvdoc)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1145, 264)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Sys"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(49, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Total :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(137, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "I.V.A.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(22, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Descuento :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(28, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Sub-Total :"
        '
        'tot10
        '
        Me.tot10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tot10.Enabled = False
        Me.tot10.Location = New System.Drawing.Point(178, 101)
        Me.tot10.Name = "tot10"
        Me.tot10.ReadOnly = True
        Me.tot10.Size = New System.Drawing.Size(82, 20)
        Me.tot10.TabIndex = 45
        '
        'tot0
        '
        Me.tot0.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tot0.Enabled = False
        Me.tot0.Location = New System.Drawing.Point(91, 101)
        Me.tot0.Name = "tot0"
        Me.tot0.ReadOnly = True
        Me.tot0.Size = New System.Drawing.Size(82, 20)
        Me.tot0.TabIndex = 44
        '
        'iva10
        '
        Me.iva10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.iva10.Enabled = False
        Me.iva10.Location = New System.Drawing.Point(178, 80)
        Me.iva10.Name = "iva10"
        Me.iva10.ReadOnly = True
        Me.iva10.Size = New System.Drawing.Size(82, 20)
        Me.iva10.TabIndex = 43
        '
        'desc10
        '
        Me.desc10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.desc10.Enabled = False
        Me.desc10.Location = New System.Drawing.Point(178, 58)
        Me.desc10.Name = "desc10"
        Me.desc10.ReadOnly = True
        Me.desc10.Size = New System.Drawing.Size(82, 20)
        Me.desc10.TabIndex = 42
        '
        'desc0
        '
        Me.desc0.BackColor = System.Drawing.Color.LightSteelBlue
        Me.desc0.Enabled = False
        Me.desc0.Location = New System.Drawing.Point(91, 58)
        Me.desc0.Name = "desc0"
        Me.desc0.ReadOnly = True
        Me.desc0.Size = New System.Drawing.Size(82, 20)
        Me.desc0.TabIndex = 41
        '
        'sub10
        '
        Me.sub10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.sub10.Enabled = False
        Me.sub10.Location = New System.Drawing.Point(178, 36)
        Me.sub10.Name = "sub10"
        Me.sub10.ReadOnly = True
        Me.sub10.Size = New System.Drawing.Size(82, 20)
        Me.sub10.TabIndex = 40
        '
        'sub0
        '
        Me.sub0.BackColor = System.Drawing.Color.LightSteelBlue
        Me.sub0.Enabled = False
        Me.sub0.Location = New System.Drawing.Point(91, 36)
        Me.sub0.Name = "sub0"
        Me.sub0.ReadOnly = True
        Me.sub0.Size = New System.Drawing.Size(82, 20)
        Me.sub0.TabIndex = 39
        '
        'dgvpago
        '
        Me.dgvpago.AllowUserToAddRows = False
        Me.dgvpago.AllowUserToDeleteRows = False
        Me.dgvpago.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvpago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpago.Location = New System.Drawing.Point(316, 113)
        Me.dgvpago.Name = "dgvpago"
        Me.dgvpago.ReadOnly = True
        Me.dgvpago.Size = New System.Drawing.Size(495, 87)
        Me.dgvpago.TabIndex = 38
        Me.dgvpago.Visible = False
        '
        'dgvdoc
        '
        Me.dgvdoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvdoc.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdoc.Location = New System.Drawing.Point(316, 6)
        Me.dgvdoc.Name = "dgvdoc"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.dgvdoc.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdoc.Size = New System.Drawing.Size(495, 101)
        Me.dgvdoc.TabIndex = 37
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage6.Controls.Add(Me.boton_agregar)
        Me.TabPage6.Controls.Add(Me.Label14)
        Me.TabPage6.Controls.Add(Me.filtropedido)
        Me.TabPage6.Controls.Add(Me.dgvpedido)
        Me.TabPage6.Controls.Add(Me.CodigoTextBox)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1145, 264)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "existencias"
        '
        'boton_agregar
        '
        Me.boton_agregar.Location = New System.Drawing.Point(616, 13)
        Me.boton_agregar.Name = "boton_agregar"
        Me.boton_agregar.Size = New System.Drawing.Size(130, 23)
        Me.boton_agregar.TabIndex = 40
        Me.boton_agregar.Text = "[F12] Agregar"
        Me.boton_agregar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(8, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 15)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Filtro :"
        '
        'filtropedido
        '
        Me.filtropedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtropedido.Location = New System.Drawing.Point(62, 9)
        Me.filtropedido.Name = "filtropedido"
        Me.filtropedido.Size = New System.Drawing.Size(345, 24)
        Me.filtropedido.TabIndex = 1
        '
        'dgvpedido
        '
        Me.dgvpedido.AllowUserToAddRows = False
        Me.dgvpedido.AllowUserToDeleteRows = False
        Me.dgvpedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvpedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvpedido.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpedido.Location = New System.Drawing.Point(11, 38)
        Me.dgvpedido.Name = "dgvpedido"
        Me.dgvpedido.Size = New System.Drawing.Size(752, 218)
        Me.dgvpedido.TabIndex = 0
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(522, 122)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 41
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AllowMerge = False
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaToolStripMenuItem, Me.VentaToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1153, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip1"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiarioDeVentasToolStripMenuItem, Me.BuscarProductoToolStripMenuItem, Me.CapturaVariosToolStripMenuItem})
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'DiarioDeVentasToolStripMenuItem
        '
        Me.DiarioDeVentasToolStripMenuItem.Name = "DiarioDeVentasToolStripMenuItem"
        Me.DiarioDeVentasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DiarioDeVentasToolStripMenuItem.Text = "Diario de Ventas"
        '
        'BuscarProductoToolStripMenuItem
        '
        Me.BuscarProductoToolStripMenuItem.Name = "BuscarProductoToolStripMenuItem"
        Me.BuscarProductoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.BuscarProductoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.BuscarProductoToolStripMenuItem.Text = "Buscar Producto"
        '
        'CapturaVariosToolStripMenuItem
        '
        Me.CapturaVariosToolStripMenuItem.Name = "CapturaVariosToolStripMenuItem"
        Me.CapturaVariosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.CapturaVariosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CapturaVariosToolStripMenuItem.Text = "captura varios"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.Agregar_Un_producto_menu, Me.btn_agregar})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'Agregar_Un_producto_menu
        '
        Me.Agregar_Un_producto_menu.Name = "Agregar_Un_producto_menu"
        Me.Agregar_Un_producto_menu.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.Agregar_Un_producto_menu.Size = New System.Drawing.Size(189, 22)
        Me.Agregar_Un_producto_menu.Text = "Agergar_producto"
        '
        'btn_agregar
        '
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.btn_agregar.Size = New System.Drawing.Size(189, 22)
        Me.btn_agregar.Text = "Agregar Grupo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowMerge = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.boton_cliente, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.boton_puerta, Me.boton_guardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1153, 39)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.Vista__132_
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Borrar Nota"
        '
        'boton_cliente
        '
        Me.boton_cliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_cliente.Image = Global.AdminTegral.My.Resources.Resources.Administrator
        Me.boton_cliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_cliente.Name = "boton_cliente"
        Me.boton_cliente.Size = New System.Drawing.Size(36, 36)
        Me.boton_cliente.Text = "Buscar Cliente"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarUltimaToolStripMenuItem, Me.SuspenderToolStripMenuItem, Me.CargarToolStripMenuItem})
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Folder_Red
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(48, 36)
        Me.ToolStripButton2.Text = "Operaciones Suspendidas"
        '
        'CargarUltimaToolStripMenuItem
        '
        Me.CargarUltimaToolStripMenuItem.Name = "CargarUltimaToolStripMenuItem"
        Me.CargarUltimaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CargarUltimaToolStripMenuItem.Text = "Cargar Ultima"
        '
        'SuspenderToolStripMenuItem
        '
        Me.SuspenderToolStripMenuItem.Image = Global.AdminTegral.My.Resources.Resources.Export
        Me.SuspenderToolStripMenuItem.Name = "SuspenderToolStripMenuItem"
        Me.SuspenderToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SuspenderToolStripMenuItem.Text = "Suspender"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Image = Global.AdminTegral.My.Resources.Resources.Import
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CargarToolStripMenuItem.Text = "Cargar Suspendida"
        '
        'boton_puerta
        '
        Me.boton_puerta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.boton_puerta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_puerta.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.boton_puerta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_puerta.Name = "boton_puerta"
        Me.boton_puerta.Size = New System.Drawing.Size(36, 36)
        Me.boton_puerta.Text = "ToolStripButton3"
        '
        'boton_guardar
        '
        Me.boton_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_guardar.Image = Global.AdminTegral.My.Resources.Resources.Printer_Green
        Me.boton_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(36, 36)
        Me.boton_guardar.Text = "ToolStripButton3"
        '
        'Lista_de_ventasTableAdapter
        '
        Me.Lista_de_ventasTableAdapter.ClearBeforeFill = True
        '
        'CajasTableAdapter
        '
        Me.CajasTableAdapter.ClearBeforeFill = True
        '
        'SeriesTableAdapter
        '
        Me.SeriesTableAdapter.ClearBeforeFill = True
        '
        'Log_cajasTableAdapter
        '
        Me.Log_cajasTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.boton_NC})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 63)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1153, 39)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        Me.ToolStrip2.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'boton_NC
        '
        Me.boton_NC.Image = Global.AdminTegral.My.Resources.Resources.file_edit
        Me.boton_NC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_NC.Name = "boton_NC"
        Me.boton_NC.Size = New System.Drawing.Size(164, 36)
        Me.boton_NC.Text = "Nueva Nota de Credito"
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'sql_documento_impresionTableAdapter
        '
        Me.sql_documento_impresionTableAdapter.ClearBeforeFill = True
        '
        'cotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.Boton_salir
        Me.ClientSize = New System.Drawing.Size(1153, 472)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "cotizaciones"
        Me.Text = "Cotizaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.sql_documento_impresionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.Log_cajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Lista_de_ventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo1.ResumeLayout(False)
        Me.grupo1.PerformLayout()
        CType(Me.dgvexistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvpago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dgvpedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents idcliente As System.Windows.Forms.TextBox
    Friend WithEvents cnombre As System.Windows.Forms.TextBox
    Friend WithEvents csaldo As System.Windows.Forms.TextBox
    Friend WithEvents crfc As System.Windows.Forms.TextBox
    Friend WithEvents cdireccion As System.Windows.Forms.TextBox
    Friend WithEvents cciudad As System.Windows.Forms.TextBox
    Friend WithEvents ccolonia As System.Windows.Forms.TextBox
    Friend WithEvents cdias As System.Windows.Forms.TextBox
    Friend WithEvents climite As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Lista_de_ventasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_de_ventasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
    Friend WithEvents totaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents Id_cajaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sucursaltxt As System.Windows.Forms.TextBox
    Friend WithEvents SerieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CajonCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Abrir_cajonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Listatxt As System.Windows.Forms.TextBox
    Friend WithEvents lblsaldo As System.Windows.Forms.Label
    Friend WithEvents Agregar_Un_producto_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeriesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.SeriesTableAdapter
    Friend WithEvents RemisionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlmacenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fvence As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiarioDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Log_cajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Log_cajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter
    Friend WithEvents Id_cajaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HorainicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Iduser_abrioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoracierreDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Iduser_cerroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_contadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_valesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boton_cliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SuspenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents facturastxt As System.Windows.Forms.TextBox
    Friend WithEvents lineastxt As System.Windows.Forms.TextBox
    Friend WithEvents Id_unidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents canttxt As System.Windows.Forms.TextBox
    Friend WithEvents idtxt As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidadesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FactorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_productoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents linea As System.Windows.Forms.TextBox
    Friend WithEvents Boton_salir As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BorrarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ccomercial As System.Windows.Forms.TextBox
    Friend WithEvents cagente As System.Windows.Forms.TextBox
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents cedo As System.Windows.Forms.TextBox
    Friend WithEvents boton_UPD_folios As System.Windows.Forms.Button
    Friend WithEvents cdesglosar As System.Windows.Forms.CheckBox
    Friend WithEvents BuscarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarUltimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_agregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tot10 As System.Windows.Forms.TextBox
    Friend WithEvents tot0 As System.Windows.Forms.TextBox
    Friend WithEvents iva10 As System.Windows.Forms.TextBox
    Friend WithEvents desc10 As System.Windows.Forms.TextBox
    Friend WithEvents desc0 As System.Windows.Forms.TextBox
    Friend WithEvents sub10 As System.Windows.Forms.TextBox
    Friend WithEvents sub0 As System.Windows.Forms.TextBox
    Friend WithEvents dgvpago As System.Windows.Forms.DataGridView
    Friend WithEvents dgvdoc As System.Windows.Forms.DataGridView
    Friend WithEvents boton_puerta As System.Windows.Forms.ToolStripButton
    Friend WithEvents folio As System.Windows.Forms.TextBox
    Friend WithEvents boton_NC As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sql_documento_impresionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sql_documento_impresionTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documento_impresionTableAdapter
    Friend WithEvents grupo1 As System.Windows.Forms.GroupBox
    Friend WithEvents ConsultarExistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosNegadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvexistencia As System.Windows.Forms.DataGridView
    Friend WithEvents lblprod As System.Windows.Forms.Label
    Friend WithEvents lblunidad As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Total_credito As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents total_debito As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dgvpedido As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents filtropedido As System.Windows.Forms.TextBox
    Friend WithEvents boton_agregar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents comentarios As System.Windows.Forms.TextBox
    Friend WithEvents CapturaVariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtmargen As System.Windows.Forms.TextBox
    Friend WithEvents boton_margen As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtajustar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Precio_unicoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IepsTextBox As System.Windows.Forms.TextBox
End Class
