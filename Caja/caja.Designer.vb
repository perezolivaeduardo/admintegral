<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja
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
        Dim Label12 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim DesglosarLabel1 As System.Windows.Forms.Label
        Dim SepararLabel As System.Windows.Forms.Label
        Dim IepsLabel As System.Windows.Forms.Label
        Dim FormaLabel As System.Windows.Forms.Label
        Dim MetodoLabel As System.Windows.Forms.Label
        Dim UsoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(caja))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.boton_cancelar_solicitud = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logo_oxxo = New System.Windows.Forms.PictureBox()
        Me.lbltipoventa = New System.Windows.Forms.Label()
        Me.Boton_avisar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SeriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblcredito = New System.Windows.Forms.Label()
        Me.txtrecibio = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtconcepto = New System.Windows.Forms.TextBox()
        Me.folionc = New System.Windows.Forms.TextBox()
        Me.boton_autorizar = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.excedetxt = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Total_credito = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.total_debito = New System.Windows.Forms.TextBox()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.csaldo = New System.Windows.Forms.TextBox()
        Me.cnombre = New System.Windows.Forms.TextBox()
        Me.idcliente = New System.Windows.Forms.TextBox()
        Me.lblexcede = New System.Windows.Forms.Label()
        Me.leyendatxt = New System.Windows.Forms.TextBox()
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
        Me.BorrarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertirPiezasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IepsTextBox = New System.Windows.Forms.TextBox()
        Me.Lista_de_ventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.panel_paquete = New System.Windows.Forms.GroupBox()
        Me.pTOTAL = New System.Windows.Forms.TextBox()
        Me.ptot = New System.Windows.Forms.TextBox()
        Me.piva = New System.Windows.Forms.TextBox()
        Me.psub = New System.Windows.Forms.TextBox()
        Me.pdescripcion = New System.Windows.Forms.TextBox()
        Me.pcantidad = New System.Windows.Forms.TextBox()
        Me.SepararCheckBox = New System.Windows.Forms.CheckBox()
        Me.imgcambiarprecio = New System.Windows.Forms.PictureBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.listaventas_codigo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.facturastxt = New System.Windows.Forms.TextBox()
        Me.lineastxt = New System.Windows.Forms.TextBox()
        Me.Id_unidadTextBox = New System.Windows.Forms.TextBox()
        Me.canttxt = New System.Windows.Forms.TextBox()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.boton_ver_precio = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Precio_unicoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UsoTextBox = New System.Windows.Forms.TextBox()
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetodoTextBox = New System.Windows.Forms.TextBox()
        Me.FormaTextBox = New System.Windows.Forms.TextBox()
        Me.formaComboBox = New System.Windows.Forms.ComboBox()
        Me.Fei_metodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeiDataset = New AdminTegral.feiDataset()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pago_num_notatxt = New System.Windows.Forms.TextBox()
        Me.pago_nctxt = New System.Windows.Forms.TextBox()
        Me.GroupEfectivo = New System.Windows.Forms.GroupBox()
        Me.Dll = New System.Windows.Forms.TextBox()
        Me.lbldolares = New System.Windows.Forms.Label()
        Me.chequechk = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Pago_ncheque = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Pago_bancotxt = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.pago_bancostxt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pago_valestxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pago_efectivotxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Grouptarjeta = New System.Windows.Forms.GroupBox()
        Me.boton_Solicita = New System.Windows.Forms.Button()
        Me.lbltipotarjeta = New System.Windows.Forms.Label()
        Me.tarjeta_vales = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tarjeta_efectivo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Tarjeta_importe = New System.Windows.Forms.TextBox()
        Me.Banco_tarjeta = New System.Windows.Forms.TextBox()
        Me.pago_banco = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Totalpagar = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.comisiontxt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtpagado = New System.Windows.Forms.TextBox()
        Me.lblcambio = New System.Windows.Forms.Label()
        Me.cambiotxt = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cemail = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.ccp = New System.Windows.Forms.TextBox()
        Me.crfc = New System.Windows.Forms.TextBox()
        Me.cdesglosar = New System.Windows.Forms.CheckBox()
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
        Me.cdireccion = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.IEPSTXT = New System.Windows.Forms.TextBox()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mod_total = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.mod_descripcion = New System.Windows.Forms.TextBox()
        Me.mod_linea = New System.Windows.Forms.TextBox()
        Me.mod_id = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiarioDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditoContadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agregar_Un_producto_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_pago_contado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Pago_debito = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Pago_credito = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesEnVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarprecioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerraCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarPrecioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivarDesactivarFacturacionFDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimbrarPublicoEnGeneraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarDocumentoDeCiereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivadoModuloDeCFDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.boton_cliente = New System.Windows.Forms.ToolStripButton()
        Me.boton_factura = New System.Windows.Forms.ToolStripButton()
        Me.boton_credito = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.boton_pago_contado = New System.Windows.Forms.ToolStripButton()
        Me.boton_pago_tarjeta = New System.Windows.Forms.ToolStripSplitButton()
        Me.DebitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.boton_pago_credito = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Boton_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.boton_relacion = New System.Windows.Forms.ToolStripButton()
        Me.boton_repetir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.CargarUltimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarPEDIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturarCotizacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturarCostoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaCostoSIVAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.boton_retirar = New System.Windows.Forms.ToolStripButton()
        Me.Boton_ver_Autorzaciones = New System.Windows.Forms.ToolStripButton()
        Me.Boton_corte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.boton_puerta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.boton_Entradas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.boton_traspasos = New System.Windows.Forms.ToolStripButton()
        Me.boton_resumen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.boton_reimprimir_ticket = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripSplitButton()
        Me.DeinirCarpetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcarpeta = New System.Windows.Forms.ToolStripTextBox()
        Me.rfolio = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.BTN_NUEVO_CLIENTE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.boton_NC = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lista_de_ventasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter()
        Me.CajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter()
        Me.SeriesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.SeriesTableAdapter()
        Me.Log_cajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblleyenda = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblsepara = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProductosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.Fei_metodosTableAdapter = New AdminTegral.feiDatasetTableAdapters.fei_metodosTableAdapter()
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter()
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
        Label12 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        DesglosarLabel1 = New System.Windows.Forms.Label()
        SepararLabel = New System.Windows.Forms.Label()
        IepsLabel = New System.Windows.Forms.Label()
        FormaLabel = New System.Windows.Forms.Label()
        MetodoLabel = New System.Windows.Forms.Label()
        UsoLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.logo_oxxo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.Log_cajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Lista_de_ventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_paquete.SuspendLayout()
        CType(Me.imgcambiarprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fei_metodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeiDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupEfectivo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Grouptarjeta.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvpago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
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
        Id_cajaLabel1.Location = New System.Drawing.Point(563, 23)
        Id_cajaLabel1.Name = "Id_cajaLabel1"
        Id_cajaLabel1.Size = New System.Drawing.Size(41, 13)
        Id_cajaLabel1.TabIndex = 35
        Id_cajaLabel1.Text = "id caja:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Enabled = False
        FechaLabel.Location = New System.Drawing.Point(567, 50)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 37
        FechaLabel.Text = "fecha:"
        '
        'HorainicioLabel
        '
        HorainicioLabel.AutoSize = True
        HorainicioLabel.Enabled = False
        HorainicioLabel.Location = New System.Drawing.Point(549, 76)
        HorainicioLabel.Name = "HorainicioLabel"
        HorainicioLabel.Size = New System.Drawing.Size(55, 13)
        HorainicioLabel.TabIndex = 39
        HorainicioLabel.Text = "horainicio:"
        '
        'Iduser_abrioLabel
        '
        Iduser_abrioLabel.AutoSize = True
        Iduser_abrioLabel.Enabled = False
        Iduser_abrioLabel.Location = New System.Drawing.Point(540, 101)
        Iduser_abrioLabel.Name = "Iduser_abrioLabel"
        Iduser_abrioLabel.Size = New System.Drawing.Size(64, 13)
        Iduser_abrioLabel.TabIndex = 41
        Iduser_abrioLabel.Text = "iduser abrio:"
        '
        'HoracierreLabel
        '
        HoracierreLabel.AutoSize = True
        HoracierreLabel.Enabled = False
        HoracierreLabel.Location = New System.Drawing.Point(547, 128)
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
        Id_contadoLabel.Location = New System.Drawing.Point(544, 179)
        Id_contadoLabel.Name = "Id_contadoLabel"
        Id_contadoLabel.Size = New System.Drawing.Size(60, 13)
        Id_contadoLabel.TabIndex = 47
        Id_contadoLabel.Text = "id contado:"
        '
        'Id_valesLabel
        '
        Id_valesLabel.AutoSize = True
        Id_valesLabel.Enabled = False
        Id_valesLabel.Location = New System.Drawing.Point(558, 205)
        Id_valesLabel.Name = "Id_valesLabel"
        Id_valesLabel.Size = New System.Drawing.Size(46, 13)
        Id_valesLabel.TabIndex = 49
        Id_valesLabel.Text = "id vales:"
        '
        'Id_productoLabel
        '
        Id_productoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Id_productoLabel.AutoSize = True
        Id_productoLabel.Location = New System.Drawing.Point(-248, 53)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(63, 13)
        Id_productoLabel.TabIndex = 9
        Id_productoLabel.Text = "id producto:"
        '
        'CodigoLabel
        '
        CodigoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(58, 126)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 10
        CodigoLabel.Text = "Codigo:"
        '
        'FactorLabel
        '
        FactorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FactorLabel.AutoSize = True
        FactorLabel.Location = New System.Drawing.Point(-242, 92)
        FactorLabel.Name = "FactorLabel"
        FactorLabel.Size = New System.Drawing.Size(37, 13)
        FactorLabel.TabIndex = 11
        FactorLabel.Text = "factor:"
        '
        'UnidadesLabel
        '
        UnidadesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UnidadesLabel.AutoSize = True
        UnidadesLabel.Location = New System.Drawing.Point(-245, 120)
        UnidadesLabel.Name = "UnidadesLabel"
        UnidadesLabel.Size = New System.Drawing.Size(53, 13)
        UnidadesLabel.TabIndex = 12
        UnidadesLabel.Text = "unidades:"
        '
        'CostoLabel
        '
        CostoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(-244, 147)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(36, 13)
        CostoLabel.TabIndex = 14
        CostoLabel.Text = "costo:"
        '
        'VentaLabel
        '
        VentaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        VentaLabel.AutoSize = True
        VentaLabel.Location = New System.Drawing.Point(-249, 177)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(37, 13)
        VentaLabel.TabIndex = 16
        VentaLabel.Text = "venta:"
        '
        'PesoLabel
        '
        PesoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(-233, 201)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(33, 13)
        PesoLabel.TabIndex = 18
        PesoLabel.Text = "peso:"
        '
        'IvaLabel
        '
        IvaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(-248, 234)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 20
        IvaLabel.Text = "iva:"
        '
        'Id_unidadLabel
        '
        Id_unidadLabel.AutoSize = True
        Id_unidadLabel.Location = New System.Drawing.Point(458, 214)
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
        EdoLabel.Location = New System.Drawing.Point(420, 153)
        EdoLabel.Name = "EdoLabel"
        EdoLabel.Size = New System.Drawing.Size(50, 24)
        EdoLabel.TabIndex = 38
        EdoLabel.Text = "Edo:"
        '
        'Label12
        '
        Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label12.AutoSize = True
        Label12.Enabled = False
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(822, 6)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(82, 25)
        Label12.TabIndex = 42
        Label12.Text = "Ticket :"
        '
        'Label31
        '
        Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label31.AutoSize = True
        Label31.Enabled = False
        Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label31.Location = New System.Drawing.Point(603, 9)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(71, 25)
        Label31.TabIndex = 41
        Label31.Text = "Folio :"
        '
        'DesglosarLabel1
        '
        DesglosarLabel1.AutoSize = True
        DesglosarLabel1.Location = New System.Drawing.Point(412, 244)
        DesglosarLabel1.Name = "DesglosarLabel1"
        DesglosarLabel1.Size = New System.Drawing.Size(57, 13)
        DesglosarLabel1.TabIndex = 42
        DesglosarLabel1.Text = "Desglosar:"
        '
        'SepararLabel
        '
        SepararLabel.AutoSize = True
        SepararLabel.Location = New System.Drawing.Point(273, 206)
        SepararLabel.Name = "SepararLabel"
        SepararLabel.Size = New System.Drawing.Size(45, 13)
        SepararLabel.TabIndex = 42
        SepararLabel.Text = "separar:"
        '
        'IepsLabel
        '
        IepsLabel.AutoSize = True
        IepsLabel.Location = New System.Drawing.Point(69, 212)
        IepsLabel.Name = "IepsLabel"
        IepsLabel.Size = New System.Drawing.Size(29, 13)
        IepsLabel.TabIndex = 44
        IepsLabel.Text = "ieps:"
        '
        'FormaLabel
        '
        FormaLabel.AutoSize = True
        FormaLabel.Location = New System.Drawing.Point(16, 55)
        FormaLabel.Name = "FormaLabel"
        FormaLabel.Size = New System.Drawing.Size(36, 13)
        FormaLabel.TabIndex = 106
        FormaLabel.Text = "forma:"
        '
        'MetodoLabel
        '
        MetodoLabel.AutoSize = True
        MetodoLabel.Location = New System.Drawing.Point(7, 84)
        MetodoLabel.Name = "MetodoLabel"
        MetodoLabel.Size = New System.Drawing.Size(45, 13)
        MetodoLabel.TabIndex = 107
        MetodoLabel.Text = "metodo:"
        '
        'UsoLabel
        '
        UsoLabel.AutoSize = True
        UsoLabel.Location = New System.Drawing.Point(25, 115)
        UsoLabel.Name = "UsoLabel"
        UsoLabel.Size = New System.Drawing.Size(27, 13)
        UsoLabel.TabIndex = 108
        UsoLabel.Text = "uso:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_cancelar_solicitud)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtrecibio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label33)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtconcepto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.folionc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_autorizar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label28)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblstatus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.excedetxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label21)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Total_credito)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer1.Panel1.Controls.Add(Me.total_debito)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsaldo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.csaldo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cnombre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.idcliente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblexcede)
        Me.SplitContainer1.Panel1.Controls.Add(Me.leyendatxt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 463)
        Me.SplitContainer1.SplitterDistance = 87
        Me.SplitContainer1.TabIndex = 1
        '
        'boton_cancelar_solicitud
        '
        Me.boton_cancelar_solicitud.Location = New System.Drawing.Point(901, 4)
        Me.boton_cancelar_solicitud.Name = "boton_cancelar_solicitud"
        Me.boton_cancelar_solicitud.Size = New System.Drawing.Size(106, 23)
        Me.boton_cancelar_solicitud.TabIndex = 49
        Me.boton_cancelar_solicitud.Text = "Cancelar Solicitud"
        Me.boton_cancelar_solicitud.UseVisualStyleBackColor = True
        Me.boton_cancelar_solicitud.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.logo_oxxo)
        Me.Panel1.Controls.Add(Me.lbltipoventa)
        Me.Panel1.Controls.Add(Me.Boton_avisar)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Label12)
        Me.Panel1.Controls.Add(Me.lblcredito)
        Me.Panel1.Controls.Add(Label31)
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 47)
        Me.Panel1.TabIndex = 43
        '
        'logo_oxxo
        '
        Me.logo_oxxo.Image = Global.AdminTegral.My.Resources.Resources.Ok_2
        Me.logo_oxxo.Location = New System.Drawing.Point(408, 4)
        Me.logo_oxxo.Name = "logo_oxxo"
        Me.logo_oxxo.Size = New System.Drawing.Size(72, 33)
        Me.logo_oxxo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo_oxxo.TabIndex = 45
        Me.logo_oxxo.TabStop = False
        Me.logo_oxxo.Visible = False
        '
        'lbltipoventa
        '
        Me.lbltipoventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipoventa.ForeColor = System.Drawing.Color.White
        Me.lbltipoventa.Location = New System.Drawing.Point(4, 6)
        Me.lbltipoventa.Name = "lbltipoventa"
        Me.lbltipoventa.Size = New System.Drawing.Size(129, 31)
        Me.lbltipoventa.TabIndex = 44
        Me.lbltipoventa.Text = "factura"
        Me.lbltipoventa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Boton_avisar
        '
        Me.Boton_avisar.Location = New System.Drawing.Point(272, 10)
        Me.Boton_avisar.Name = "Boton_avisar"
        Me.Boton_avisar.Size = New System.Drawing.Size(120, 23)
        Me.Boton_avisar.TabIndex = 43
        Me.Boton_avisar.Text = "Avisar a Cobranza"
        Me.Boton_avisar.UseVisualStyleBackColor = True
        Me.Boton_avisar.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeriesBindingSource, "remision", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(902, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(143, 31)
        Me.TextBox1.TabIndex = 40
        '
        'SeriesBindingSource
        '
        Me.SeriesBindingSource.DataMember = "Series"
        Me.SeriesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeriesBindingSource, "Folio", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(680, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(143, 31)
        Me.TextBox2.TabIndex = 39
        '
        'lblcredito
        '
        Me.lblcredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcredito.ForeColor = System.Drawing.Color.White
        Me.lblcredito.Location = New System.Drawing.Point(139, 6)
        Me.lblcredito.Name = "lblcredito"
        Me.lblcredito.Size = New System.Drawing.Size(127, 31)
        Me.lblcredito.TabIndex = 5
        Me.lblcredito.Text = "Contado"
        Me.lblcredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtrecibio
        '
        Me.txtrecibio.Location = New System.Drawing.Point(86, 65)
        Me.txtrecibio.MaxLength = 20
        Me.txtrecibio.Name = "txtrecibio"
        Me.txtrecibio.Size = New System.Drawing.Size(358, 20)
        Me.txtrecibio.TabIndex = 48
        Me.txtrecibio.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(9, 45)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 15)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "Concepto:"
        '
        'txtconcepto
        '
        Me.txtconcepto.AutoCompleteCustomSource.AddRange(New String() {"Mal Surtido", "Faltante", "Mal estado", "Caducado", "Error de Facturacion", "Por precio", "No lo quizo el cliente", "No fue lo que pidio ", "No alcanzo a pagar", "No se subio el producto", "Por Fecha de caducidad proxima"})
        Me.txtconcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtconcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtconcepto.Location = New System.Drawing.Point(86, 42)
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(358, 20)
        Me.txtconcepto.TabIndex = 46
        Me.txtconcepto.Visible = False
        '
        'folionc
        '
        Me.folionc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.folionc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folionc.ForeColor = System.Drawing.Color.White
        Me.folionc.Location = New System.Drawing.Point(1009, 2)
        Me.folionc.Name = "folionc"
        Me.folionc.ReadOnly = True
        Me.folionc.Size = New System.Drawing.Size(142, 31)
        Me.folionc.TabIndex = 45
        Me.folionc.Visible = False
        '
        'boton_autorizar
        '
        Me.boton_autorizar.Location = New System.Drawing.Point(892, 3)
        Me.boton_autorizar.Name = "boton_autorizar"
        Me.boton_autorizar.Size = New System.Drawing.Size(106, 27)
        Me.boton_autorizar.TabIndex = 35
        Me.boton_autorizar.Text = "Solicitar Autorizacion"
        Me.boton_autorizar.UseVisualStyleBackColor = True
        Me.boton_autorizar.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(7, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 15)
        Me.Label28.TabIndex = 38
        Me.Label28.Text = "Cliente:"
        '
        'lblstatus
        '
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.White
        Me.lblstatus.Location = New System.Drawing.Point(897, 5)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(101, 23)
        Me.lblstatus.TabIndex = 37
        Me.lblstatus.Text = "Pendiente"
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblstatus.Visible = False
        '
        'excedetxt
        '
        Me.excedetxt.BackColor = System.Drawing.Color.Red
        Me.excedetxt.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excedetxt.ForeColor = System.Drawing.Color.White
        Me.excedetxt.Location = New System.Drawing.Point(783, 4)
        Me.excedetxt.Name = "excedetxt"
        Me.excedetxt.ReadOnly = True
        Me.excedetxt.Size = New System.Drawing.Size(103, 27)
        Me.excedetxt.TabIndex = 33
        Me.excedetxt.Text = "0.0"
        Me.excedetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.excedetxt.Visible = False
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(1055, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 23)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Credito :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Total_credito
        '
        Me.Total_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_credito.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Total_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_credito.ForeColor = System.Drawing.Color.White
        Me.Total_credito.Location = New System.Drawing.Point(1152, 56)
        Me.Total_credito.Name = "Total_credito"
        Me.Total_credito.ReadOnly = True
        Me.Total_credito.Size = New System.Drawing.Size(102, 29)
        Me.Total_credito.TabIndex = 31
        Me.Total_credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(1065, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 23)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Debito :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'total_debito
        '
        Me.total_debito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total_debito.BackColor = System.Drawing.Color.LightSteelBlue
        Me.total_debito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_debito.ForeColor = System.Drawing.Color.White
        Me.total_debito.Location = New System.Drawing.Point(1150, 26)
        Me.total_debito.Name = "total_debito"
        Me.total_debito.ReadOnly = True
        Me.total_debito.Size = New System.Drawing.Size(102, 29)
        Me.total_debito.TabIndex = 29
        Me.total_debito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblsaldo
        '
        Me.lblsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaldo.ForeColor = System.Drawing.Color.White
        Me.lblsaldo.Location = New System.Drawing.Point(456, 6)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(103, 23)
        Me.lblsaldo.TabIndex = 28
        Me.lblsaldo.Text = "Disponible:"
        Me.lblsaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'csaldo
        '
        Me.csaldo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.csaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csaldo.ForeColor = System.Drawing.Color.White
        Me.csaldo.Location = New System.Drawing.Point(563, 4)
        Me.csaldo.Name = "csaldo"
        Me.csaldo.ReadOnly = True
        Me.csaldo.Size = New System.Drawing.Size(128, 29)
        Me.csaldo.TabIndex = 2
        '
        'cnombre
        '
        Me.cnombre.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnombre.Location = New System.Drawing.Point(133, 6)
        Me.cnombre.Name = "cnombre"
        Me.cnombre.ReadOnly = True
        Me.cnombre.Size = New System.Drawing.Size(321, 24)
        Me.cnombre.TabIndex = 1
        Me.cnombre.Text = "Publico en General"
        '
        'idcliente
        '
        Me.idcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idcliente.Location = New System.Drawing.Point(68, 6)
        Me.idcliente.Name = "idcliente"
        Me.idcliente.Size = New System.Drawing.Size(59, 24)
        Me.idcliente.TabIndex = 0
        Me.idcliente.Text = "0"
        '
        'lblexcede
        '
        Me.lblexcede.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexcede.ForeColor = System.Drawing.Color.White
        Me.lblexcede.Location = New System.Drawing.Point(690, 7)
        Me.lblexcede.Name = "lblexcede"
        Me.lblexcede.Size = New System.Drawing.Size(91, 23)
        Me.lblexcede.TabIndex = 34
        Me.lblexcede.Text = "Autorizar :"
        Me.lblexcede.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblexcede.Visible = False
        '
        'leyendatxt
        '
        Me.leyendatxt.Location = New System.Drawing.Point(460, 10)
        Me.leyendatxt.Name = "leyendatxt"
        Me.leyendatxt.Size = New System.Drawing.Size(31, 20)
        Me.leyendatxt.TabIndex = 50
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
        Me.TabControl1.Size = New System.Drawing.Size(1254, 372)
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
        Me.TabPage4.Size = New System.Drawing.Size(1246, 343)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Caja"
        '
        'boton_UPD_folios
        '
        Me.boton_UPD_folios.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        Me.TabPage1.Controls.Add(Me.panel_paquete)
        Me.TabPage1.Controls.Add(SepararLabel)
        Me.TabPage1.Controls.Add(Me.SepararCheckBox)
        Me.TabPage1.Controls.Add(Me.imgcambiarprecio)
        Me.TabPage1.Controls.Add(Me.CodigoTextBox)
        Me.TabPage1.Controls.Add(Me.listaventas_codigo)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.facturastxt)
        Me.TabPage1.Controls.Add(Id_unidadLabel)
        Me.TabPage1.Controls.Add(Me.lineastxt)
        Me.TabPage1.Controls.Add(Me.Id_unidadTextBox)
        Me.TabPage1.Controls.Add(Me.canttxt)
        Me.TabPage1.Controls.Add(Me.idtxt)
        Me.TabPage1.Controls.Add(IvaLabel)
        Me.TabPage1.Controls.Add(Me.IvaTextBox)
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
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Precio_unicoCheckBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1246, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nota"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgv.Location = New System.Drawing.Point(10, 50)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1127, 214)
        Me.dgv.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarProductoToolStripMenuItem, Me.ConvertirPiezasToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(159, 48)
        '
        'BorrarProductoToolStripMenuItem
        '
        Me.BorrarProductoToolStripMenuItem.Name = "BorrarProductoToolStripMenuItem"
        Me.BorrarProductoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BorrarProductoToolStripMenuItem.Text = "Borrar Producto"
        '
        'ConvertirPiezasToolStripMenuItem
        '
        Me.ConvertirPiezasToolStripMenuItem.Name = "ConvertirPiezasToolStripMenuItem"
        Me.ConvertirPiezasToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ConvertirPiezasToolStripMenuItem.Text = "Convertir Piezas"
        '
        'IepsTextBox
        '
        Me.IepsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "ieps", True))
        Me.IepsTextBox.Location = New System.Drawing.Point(170, 214)
        Me.IepsTextBox.Name = "IepsTextBox"
        Me.IepsTextBox.Size = New System.Drawing.Size(65, 20)
        Me.IepsTextBox.TabIndex = 45
        '
        'Lista_de_ventasBindingSource
        '
        Me.Lista_de_ventasBindingSource.DataMember = "Lista_de_ventas"
        Me.Lista_de_ventasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'panel_paquete
        '
        Me.panel_paquete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panel_paquete.Controls.Add(Me.pTOTAL)
        Me.panel_paquete.Controls.Add(Me.ptot)
        Me.panel_paquete.Controls.Add(Me.piva)
        Me.panel_paquete.Controls.Add(Me.psub)
        Me.panel_paquete.Controls.Add(Me.pdescripcion)
        Me.panel_paquete.Controls.Add(Me.pcantidad)
        Me.panel_paquete.Location = New System.Drawing.Point(8, 289)
        Me.panel_paquete.Name = "panel_paquete"
        Me.panel_paquete.Size = New System.Drawing.Size(966, 48)
        Me.panel_paquete.TabIndex = 44
        Me.panel_paquete.TabStop = False
        Me.panel_paquete.Text = "Datos con los que se va a Facturar"
        Me.panel_paquete.Visible = False
        '
        'pTOTAL
        '
        Me.pTOTAL.Location = New System.Drawing.Point(653, 19)
        Me.pTOTAL.Name = "pTOTAL"
        Me.pTOTAL.Size = New System.Drawing.Size(57, 20)
        Me.pTOTAL.TabIndex = 5
        '
        'ptot
        '
        Me.ptot.Location = New System.Drawing.Point(580, 19)
        Me.ptot.Name = "ptot"
        Me.ptot.Size = New System.Drawing.Size(57, 20)
        Me.ptot.TabIndex = 4
        '
        'piva
        '
        Me.piva.Location = New System.Drawing.Point(516, 19)
        Me.piva.Name = "piva"
        Me.piva.Size = New System.Drawing.Size(57, 20)
        Me.piva.TabIndex = 3
        '
        'psub
        '
        Me.psub.Location = New System.Drawing.Point(453, 19)
        Me.psub.Name = "psub"
        Me.psub.Size = New System.Drawing.Size(57, 20)
        Me.psub.TabIndex = 2
        '
        'pdescripcion
        '
        Me.pdescripcion.Location = New System.Drawing.Point(61, 19)
        Me.pdescripcion.Name = "pdescripcion"
        Me.pdescripcion.Size = New System.Drawing.Size(381, 20)
        Me.pdescripcion.TabIndex = 1
        '
        'pcantidad
        '
        Me.pcantidad.Location = New System.Drawing.Point(13, 19)
        Me.pcantidad.Name = "pcantidad"
        Me.pcantidad.Size = New System.Drawing.Size(38, 20)
        Me.pcantidad.TabIndex = 0
        '
        'SepararCheckBox
        '
        Me.SepararCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Lista_de_ventasBindingSource, "separar", True))
        Me.SepararCheckBox.Location = New System.Drawing.Point(324, 201)
        Me.SepararCheckBox.Name = "SepararCheckBox"
        Me.SepararCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SepararCheckBox.TabIndex = 43
        '
        'imgcambiarprecio
        '
        Me.imgcambiarprecio.Image = Global.AdminTegral.My.Resources.Resources.dollar
        Me.imgcambiarprecio.Location = New System.Drawing.Point(306, 2)
        Me.imgcambiarprecio.Name = "imgcambiarprecio"
        Me.imgcambiarprecio.Size = New System.Drawing.Size(32, 36)
        Me.imgcambiarprecio.TabIndex = 41
        Me.imgcambiarprecio.TabStop = False
        Me.imgcambiarprecio.Visible = False
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(545, 191)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 40
        '
        'listaventas_codigo
        '
        Me.listaventas_codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listaventas_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Codigo", True))
        Me.listaventas_codigo.Location = New System.Drawing.Point(513, 125)
        Me.listaventas_codigo.Name = "listaventas_codigo"
        Me.listaventas_codigo.Size = New System.Drawing.Size(73, 20)
        Me.listaventas_codigo.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(198, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 23)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Lin:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'facturastxt
        '
        Me.facturastxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.facturastxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facturastxt.Location = New System.Drawing.Point(268, 8)
        Me.facturastxt.Name = "facturastxt"
        Me.facturastxt.ReadOnly = True
        Me.facturastxt.Size = New System.Drawing.Size(28, 24)
        Me.facturastxt.TabIndex = 30
        Me.facturastxt.Text = "0"
        Me.facturastxt.Visible = False
        '
        'lineastxt
        '
        Me.lineastxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lineastxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lineastxt.Location = New System.Drawing.Point(232, 7)
        Me.lineastxt.Name = "lineastxt"
        Me.lineastxt.ReadOnly = True
        Me.lineastxt.Size = New System.Drawing.Size(33, 24)
        Me.lineastxt.TabIndex = 29
        Me.lineastxt.Text = "0"
        '
        'Id_unidadTextBox
        '
        Me.Id_unidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "id_unidad", True))
        Me.Id_unidadTextBox.Location = New System.Drawing.Point(404, 191)
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
        Me.IvaTextBox.Location = New System.Drawing.Point(-215, 231)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(23, 20)
        Me.IvaTextBox.TabIndex = 21
        '
        'totaltxt
        '
        Me.totaltxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totaltxt.BackColor = System.Drawing.Color.RoyalBlue
        Me.totaltxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltxt.Location = New System.Drawing.Point(954, 3)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.ReadOnly = True
        Me.totaltxt.Size = New System.Drawing.Size(185, 40)
        Me.totaltxt.TabIndex = 26
        Me.totaltxt.Text = "0.00"
        Me.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PesoTextBox
        '
        Me.PesoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(-191, 198)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PesoTextBox.TabIndex = 19
        '
        'VentaTextBox
        '
        Me.VentaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "venta", True))
        Me.VentaTextBox.Location = New System.Drawing.Point(736, 168)
        Me.VentaTextBox.Name = "VentaTextBox"
        Me.VentaTextBox.Size = New System.Drawing.Size(73, 20)
        Me.VentaTextBox.TabIndex = 17
        '
        'CostoTextBox
        '
        Me.CostoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(10, 147)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(57, 20)
        Me.CostoTextBox.TabIndex = 15
        '
        'UnidadesTextBox
        '
        Me.UnidadesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnidadesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "unidades", True))
        Me.UnidadesTextBox.Location = New System.Drawing.Point(-187, 118)
        Me.UnidadesTextBox.Name = "UnidadesTextBox"
        Me.UnidadesTextBox.Size = New System.Drawing.Size(42, 20)
        Me.UnidadesTextBox.TabIndex = 13
        '
        'FactorTextBox
        '
        Me.FactorTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FactorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "factor", True))
        Me.FactorTextBox.Location = New System.Drawing.Point(-202, 91)
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
        Me.CodigoComboBox.Location = New System.Drawing.Point(524, 144)
        Me.CodigoComboBox.Name = "CodigoComboBox"
        Me.CodigoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CodigoComboBox.TabIndex = 11
        Me.CodigoComboBox.ValueMember = "id_producto"
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(288, 70)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(76, 20)
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
        Me.DescripcionTextBox.Location = New System.Drawing.Point(202, 119)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(179, 20)
        Me.DescripcionTextBox.TabIndex = 7
        '
        'linea
        '
        Me.linea.BackColor = System.Drawing.Color.LightSteelBlue
        Me.linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linea.Location = New System.Drawing.Point(6, 8)
        Me.linea.Name = "linea"
        Me.linea.Size = New System.Drawing.Size(188, 29)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.boton_ver_precio)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(344, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 39)
        Me.Panel2.TabIndex = 37
        '
        'boton_ver_precio
        '
        Me.boton_ver_precio.AutoSize = True
        Me.boton_ver_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_ver_precio.Location = New System.Drawing.Point(317, 0)
        Me.boton_ver_precio.Name = "boton_ver_precio"
        Me.boton_ver_precio.Size = New System.Drawing.Size(131, 32)
        Me.boton_ver_precio.TabIndex = 36
        Me.boton_ver_precio.Text = "[F8] Ver Precio"
        Me.boton_ver_precio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boton_ver_precio.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(113, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 32)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "[F6] Debito"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 32)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "[F5] Efectivo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(213, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 32)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "[F7] Credito"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(265, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 23)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Fac:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(876, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 23)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Total :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Precio_unicoCheckBox
        '
        Me.Precio_unicoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Lista_de_ventasBindingSource, "precio_unico", True))
        Me.Precio_unicoCheckBox.Location = New System.Drawing.Point(301, 162)
        Me.Precio_unicoCheckBox.Name = "Precio_unicoCheckBox"
        Me.Precio_unicoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Precio_unicoCheckBox.TabIndex = 42
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage2.Controls.Add(UsoLabel)
        Me.TabPage2.Controls.Add(Me.UsoTextBox)
        Me.TabPage2.Controls.Add(MetodoLabel)
        Me.TabPage2.Controls.Add(Me.MetodoTextBox)
        Me.TabPage2.Controls.Add(FormaLabel)
        Me.TabPage2.Controls.Add(Me.FormaTextBox)
        Me.TabPage2.Controls.Add(Me.formaComboBox)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupEfectivo)
        Me.TabPage2.Controls.Add(Me.Grouptarjeta)
        Me.TabPage2.Controls.Add(Me.Label32)
        Me.TabPage2.Controls.Add(Me.Totalpagar)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.comisiontxt)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txtpagado)
        Me.TabPage2.Controls.Add(Me.lblcambio)
        Me.TabPage2.Controls.Add(Me.cambiotxt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1246, 343)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Pagar"
        '
        'UsoTextBox
        '
        Me.UsoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "uso", True))
        Me.UsoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsoTextBox.Location = New System.Drawing.Point(58, 112)
        Me.UsoTextBox.Name = "UsoTextBox"
        Me.UsoTextBox.Size = New System.Drawing.Size(54, 24)
        Me.UsoTextBox.TabIndex = 109
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'MetodoTextBox
        '
        Me.MetodoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "metodo", True))
        Me.MetodoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetodoTextBox.Location = New System.Drawing.Point(58, 81)
        Me.MetodoTextBox.Name = "MetodoTextBox"
        Me.MetodoTextBox.Size = New System.Drawing.Size(54, 24)
        Me.MetodoTextBox.TabIndex = 108
        '
        'FormaTextBox
        '
        Me.FormaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "forma", True))
        Me.FormaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaTextBox.Location = New System.Drawing.Point(58, 52)
        Me.FormaTextBox.Name = "FormaTextBox"
        Me.FormaTextBox.Size = New System.Drawing.Size(54, 24)
        Me.FormaTextBox.TabIndex = 107
        '
        'formaComboBox
        '
        Me.formaComboBox.DataSource = Me.Fei_metodosBindingSource
        Me.formaComboBox.DisplayMember = "metodo"
        Me.formaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formaComboBox.FormattingEnabled = True
        Me.formaComboBox.Location = New System.Drawing.Point(129, 52)
        Me.formaComboBox.Name = "formaComboBox"
        Me.formaComboBox.Size = New System.Drawing.Size(155, 26)
        Me.formaComboBox.TabIndex = 106
        Me.formaComboBox.ValueMember = "codigo"
        '
        'Fei_metodosBindingSource
        '
        Me.Fei_metodosBindingSource.DataMember = "fei_metodos"
        Me.Fei_metodosBindingSource.DataSource = Me.FeiDataset
        '
        'FeiDataset
        '
        Me.FeiDataset.DataSetName = "feiDataset"
        Me.FeiDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pago_num_notatxt)
        Me.GroupBox1.Controls.Add(Me.pago_nctxt)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(336, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 48)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nota de Credito"
        '
        'pago_num_notatxt
        '
        Me.pago_num_notatxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pago_num_notatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pago_num_notatxt.ForeColor = System.Drawing.Color.Black
        Me.pago_num_notatxt.Location = New System.Drawing.Point(110, 14)
        Me.pago_num_notatxt.MaxLength = 6
        Me.pago_num_notatxt.Name = "pago_num_notatxt"
        Me.pago_num_notatxt.Size = New System.Drawing.Size(68, 26)
        Me.pago_num_notatxt.TabIndex = 8
        '
        'pago_nctxt
        '
        Me.pago_nctxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pago_nctxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pago_nctxt.ForeColor = System.Drawing.Color.Black
        Me.pago_nctxt.Location = New System.Drawing.Point(189, 14)
        Me.pago_nctxt.MaxLength = 15
        Me.pago_nctxt.Name = "pago_nctxt"
        Me.pago_nctxt.Size = New System.Drawing.Size(137, 26)
        Me.pago_nctxt.TabIndex = 9
        Me.pago_nctxt.Text = "0"
        Me.pago_nctxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupEfectivo
        '
        Me.GroupEfectivo.Controls.Add(Me.Dll)
        Me.GroupEfectivo.Controls.Add(Me.lbldolares)
        Me.GroupEfectivo.Controls.Add(Me.chequechk)
        Me.GroupEfectivo.Controls.Add(Me.GroupBox2)
        Me.GroupEfectivo.Controls.Add(Me.pago_valestxt)
        Me.GroupEfectivo.Controls.Add(Me.Label15)
        Me.GroupEfectivo.Controls.Add(Me.pago_efectivotxt)
        Me.GroupEfectivo.Controls.Add(Me.Label14)
        Me.GroupEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupEfectivo.Location = New System.Drawing.Point(286, 10)
        Me.GroupEfectivo.Name = "GroupEfectivo"
        Me.GroupEfectivo.Size = New System.Drawing.Size(456, 259)
        Me.GroupEfectivo.TabIndex = 4
        Me.GroupEfectivo.TabStop = False
        Me.GroupEfectivo.Text = "Pago de Contado"
        '
        'Dll
        '
        Me.Dll.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Dll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dll.ForeColor = System.Drawing.Color.Black
        Me.Dll.Location = New System.Drawing.Point(278, 88)
        Me.Dll.MaxLength = 15
        Me.Dll.Name = "Dll"
        Me.Dll.Size = New System.Drawing.Size(143, 26)
        Me.Dll.TabIndex = 14
        Me.Dll.Text = "0"
        Me.Dll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbldolares
        '
        Me.lbldolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldolares.Location = New System.Drawing.Point(6, 94)
        Me.lbldolares.Name = "lbldolares"
        Me.lbldolares.Size = New System.Drawing.Size(258, 20)
        Me.lbldolares.TabIndex = 15
        Me.lbldolares.Text = "Dolares :"
        Me.lbldolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chequechk
        '
        Me.chequechk.AutoSize = True
        Me.chequechk.Location = New System.Drawing.Point(175, 121)
        Me.chequechk.Name = "chequechk"
        Me.chequechk.Size = New System.Drawing.Size(89, 24)
        Me.chequechk.TabIndex = 13
        Me.chequechk.Text = "cheque :"
        Me.chequechk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Pago_ncheque)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Pago_bancotxt)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.pago_bancostxt)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(94, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 110)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'Pago_ncheque
        '
        Me.Pago_ncheque.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Pago_ncheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pago_ncheque.ForeColor = System.Drawing.Color.Black
        Me.Pago_ncheque.Location = New System.Drawing.Point(81, 42)
        Me.Pago_ncheque.MaxLength = 20
        Me.Pago_ncheque.Name = "Pago_ncheque"
        Me.Pago_ncheque.Size = New System.Drawing.Size(250, 26)
        Me.Pago_ncheque.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(42, 45)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 20)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "No."
        '
        'Pago_bancotxt
        '
        Me.Pago_bancotxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Pago_bancotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pago_bancotxt.ForeColor = System.Drawing.Color.Black
        Me.Pago_bancotxt.Location = New System.Drawing.Point(82, 11)
        Me.Pago_bancotxt.MaxLength = 20
        Me.Pago_bancotxt.Name = "Pago_bancotxt"
        Me.Pago_bancotxt.Size = New System.Drawing.Size(250, 26)
        Me.Pago_bancotxt.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(13, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 20)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Banco"
        '
        'pago_bancostxt
        '
        Me.pago_bancostxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pago_bancostxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pago_bancostxt.ForeColor = System.Drawing.Color.Black
        Me.pago_bancostxt.Location = New System.Drawing.Point(189, 75)
        Me.pago_bancostxt.MaxLength = 15
        Me.pago_bancostxt.Name = "pago_bancostxt"
        Me.pago_bancostxt.Size = New System.Drawing.Size(143, 26)
        Me.pago_bancostxt.TabIndex = 7
        Me.pago_bancostxt.Text = "0"
        Me.pago_bancostxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(104, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Importe :"
        '
        'pago_valestxt
        '
        Me.pago_valestxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pago_valestxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pago_valestxt.ForeColor = System.Drawing.Color.Black
        Me.pago_valestxt.Location = New System.Drawing.Point(278, 56)
        Me.pago_valestxt.MaxLength = 15
        Me.pago_valestxt.Name = "pago_valestxt"
        Me.pago_valestxt.Size = New System.Drawing.Size(143, 26)
        Me.pago_valestxt.TabIndex = 4
        Me.pago_valestxt.Text = "0"
        Me.pago_valestxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(208, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 20)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Vales :"
        '
        'pago_efectivotxt
        '
        Me.pago_efectivotxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pago_efectivotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pago_efectivotxt.ForeColor = System.Drawing.Color.Black
        Me.pago_efectivotxt.Location = New System.Drawing.Point(278, 25)
        Me.pago_efectivotxt.MaxLength = 15
        Me.pago_efectivotxt.Name = "pago_efectivotxt"
        Me.pago_efectivotxt.Size = New System.Drawing.Size(143, 26)
        Me.pago_efectivotxt.TabIndex = 2
        Me.pago_efectivotxt.Text = "0"
        Me.pago_efectivotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(191, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 20)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Efectivo :"
        '
        'Grouptarjeta
        '
        Me.Grouptarjeta.BackgroundImage = Global.AdminTegral.My.Resources.Resources.visa
        Me.Grouptarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Grouptarjeta.Controls.Add(Me.boton_Solicita)
        Me.Grouptarjeta.Controls.Add(Me.lbltipotarjeta)
        Me.Grouptarjeta.Controls.Add(Me.tarjeta_vales)
        Me.Grouptarjeta.Controls.Add(Me.Label25)
        Me.Grouptarjeta.Controls.Add(Me.tarjeta_efectivo)
        Me.Grouptarjeta.Controls.Add(Me.Label26)
        Me.Grouptarjeta.Controls.Add(Me.Label24)
        Me.Grouptarjeta.Controls.Add(Me.Label23)
        Me.Grouptarjeta.Controls.Add(Me.Label22)
        Me.Grouptarjeta.Controls.Add(Me.Tarjeta_importe)
        Me.Grouptarjeta.Controls.Add(Me.Banco_tarjeta)
        Me.Grouptarjeta.Controls.Add(Me.pago_banco)
        Me.Grouptarjeta.Location = New System.Drawing.Point(339, 16)
        Me.Grouptarjeta.Name = "Grouptarjeta"
        Me.Grouptarjeta.Size = New System.Drawing.Size(313, 259)
        Me.Grouptarjeta.TabIndex = 8
        Me.Grouptarjeta.TabStop = False
        '
        'boton_Solicita
        '
        Me.boton_Solicita.Location = New System.Drawing.Point(236, 208)
        Me.boton_Solicita.Name = "boton_Solicita"
        Me.boton_Solicita.Size = New System.Drawing.Size(75, 30)
        Me.boton_Solicita.TabIndex = 15
        Me.boton_Solicita.Text = "Imprimir"
        Me.boton_Solicita.UseVisualStyleBackColor = True
        '
        'lbltipotarjeta
        '
        Me.lbltipotarjeta.AutoSize = True
        Me.lbltipotarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipotarjeta.Location = New System.Drawing.Point(113, 16)
        Me.lbltipotarjeta.Name = "lbltipotarjeta"
        Me.lbltipotarjeta.Size = New System.Drawing.Size(76, 24)
        Me.lbltipotarjeta.TabIndex = 13
        Me.lbltipotarjeta.Text = "Label12"
        '
        'tarjeta_vales
        '
        Me.tarjeta_vales.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tarjeta_vales.Enabled = False
        Me.tarjeta_vales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarjeta_vales.Location = New System.Drawing.Point(87, 208)
        Me.tarjeta_vales.Name = "tarjeta_vales"
        Me.tarjeta_vales.Size = New System.Drawing.Size(143, 31)
        Me.tarjeta_vales.TabIndex = 14
        Me.tarjeta_vales.Text = "0"
        Me.tarjeta_vales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Enabled = False
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 215)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(57, 20)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Vales :"
        '
        'tarjeta_efectivo
        '
        Me.tarjeta_efectivo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tarjeta_efectivo.Enabled = False
        Me.tarjeta_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarjeta_efectivo.Location = New System.Drawing.Point(87, 171)
        Me.tarjeta_efectivo.Name = "tarjeta_efectivo"
        Me.tarjeta_efectivo.Size = New System.Drawing.Size(143, 31)
        Me.tarjeta_efectivo.TabIndex = 13
        Me.tarjeta_efectivo.Text = "0"
        Me.tarjeta_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(7, 178)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 20)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Efectivo :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 134)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 20)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Importe :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 96)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 20)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "# tarjeta :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 59)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 20)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Banco :"
        '
        'Tarjeta_importe
        '
        Me.Tarjeta_importe.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Tarjeta_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tarjeta_importe.Location = New System.Drawing.Point(87, 134)
        Me.Tarjeta_importe.Name = "Tarjeta_importe"
        Me.Tarjeta_importe.Size = New System.Drawing.Size(143, 31)
        Me.Tarjeta_importe.TabIndex = 12
        Me.Tarjeta_importe.Text = "0"
        Me.Tarjeta_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Banco_tarjeta
        '
        Me.Banco_tarjeta.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Banco_tarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banco_tarjeta.Location = New System.Drawing.Point(87, 96)
        Me.Banco_tarjeta.MaxLength = 20
        Me.Banco_tarjeta.Name = "Banco_tarjeta"
        Me.Banco_tarjeta.Size = New System.Drawing.Size(196, 31)
        Me.Banco_tarjeta.TabIndex = 11
        '
        'pago_banco
        '
        Me.pago_banco.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pago_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pago_banco.Location = New System.Drawing.Point(87, 59)
        Me.pago_banco.MaxLength = 20
        Me.pago_banco.Name = "pago_banco"
        Me.pago_banco.Size = New System.Drawing.Size(196, 31)
        Me.pago_banco.TabIndex = 10
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(795, 32)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(166, 23)
        Me.Label32.TabIndex = 29
        Me.Label32.Text = "Total  a Pagar:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Totalpagar
        '
        Me.Totalpagar.AcceptsReturn = True
        Me.Totalpagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Totalpagar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Totalpagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totalpagar.Location = New System.Drawing.Point(967, 25)
        Me.Totalpagar.Name = "Totalpagar"
        Me.Totalpagar.ReadOnly = True
        Me.Totalpagar.Size = New System.Drawing.Size(170, 31)
        Me.Totalpagar.TabIndex = 28
        Me.Totalpagar.TabStop = False
        Me.Totalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 271)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(189, 31)
        Me.Button4.TabIndex = 99
        Me.Button4.TabStop = False
        Me.Button4.Text = "[F4] Regresar a Nota"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(990, 179)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 20)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Comision :"
        '
        'comisiontxt
        '
        Me.comisiontxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comisiontxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.comisiontxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comisiontxt.Location = New System.Drawing.Point(994, 202)
        Me.comisiontxt.Name = "comisiontxt"
        Me.comisiontxt.ReadOnly = True
        Me.comisiontxt.Size = New System.Drawing.Size(143, 31)
        Me.comisiontxt.TabIndex = 99
        Me.comisiontxt.TabStop = False
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(990, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 20)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Total Recibdo:"
        '
        'txtpagado
        '
        Me.txtpagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpagado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtpagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpagado.Location = New System.Drawing.Point(994, 102)
        Me.txtpagado.Name = "txtpagado"
        Me.txtpagado.ReadOnly = True
        Me.txtpagado.Size = New System.Drawing.Size(143, 31)
        Me.txtpagado.TabIndex = 99
        Me.txtpagado.TabStop = False
        '
        'lblcambio
        '
        Me.lblcambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcambio.AutoSize = True
        Me.lblcambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio.Location = New System.Drawing.Point(990, 246)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(71, 20)
        Me.lblcambio.TabIndex = 8
        Me.lblcambio.Text = "Cambio :"
        '
        'cambiotxt
        '
        Me.cambiotxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cambiotxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cambiotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cambiotxt.Location = New System.Drawing.Point(994, 269)
        Me.cambiotxt.Name = "cambiotxt"
        Me.cambiotxt.ReadOnly = True
        Me.cambiotxt.Size = New System.Drawing.Size(143, 31)
        Me.cambiotxt.TabIndex = 99
        Me.cambiotxt.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage3.Controls.Add(Me.cemail)
        Me.TabPage3.Controls.Add(Me.telefono)
        Me.TabPage3.Controls.Add(Me.ccp)
        Me.TabPage3.Controls.Add(Me.crfc)
        Me.TabPage3.Controls.Add(DesglosarLabel1)
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
        Me.TabPage3.Controls.Add(Me.cdireccion)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1246, 343)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Datos Cliente"
        '
        'cemail
        '
        Me.cemail.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cemail.Location = New System.Drawing.Point(733, 153)
        Me.cemail.Name = "cemail"
        Me.cemail.ReadOnly = True
        Me.cemail.Size = New System.Drawing.Size(212, 29)
        Me.cemail.TabIndex = 49
        '
        'telefono
        '
        Me.telefono.BackColor = System.Drawing.Color.LightSteelBlue
        Me.telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.Location = New System.Drawing.Point(733, 107)
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Size = New System.Drawing.Size(212, 29)
        Me.telefono.TabIndex = 48
        '
        'ccp
        '
        Me.ccp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ccp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccp.Location = New System.Drawing.Point(126, 268)
        Me.ccp.Name = "ccp"
        Me.ccp.ReadOnly = True
        Me.ccp.Size = New System.Drawing.Size(74, 29)
        Me.ccp.TabIndex = 45
        '
        'crfc
        '
        Me.crfc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.crfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crfc.Location = New System.Drawing.Point(476, 183)
        Me.crfc.Name = "crfc"
        Me.crfc.ReadOnly = True
        Me.crfc.Size = New System.Drawing.Size(212, 29)
        Me.crfc.TabIndex = 44
        '
        'cdesglosar
        '
        Me.cdesglosar.Location = New System.Drawing.Point(475, 239)
        Me.cdesglosar.Name = "cdesglosar"
        Me.cdesglosar.Size = New System.Drawing.Size(48, 24)
        Me.cdesglosar.TabIndex = 43
        '
        'cedo
        '
        Me.cedo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cedo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedo.Location = New System.Drawing.Point(476, 153)
        Me.cedo.Name = "cedo"
        Me.cedo.ReadOnly = True
        Me.cedo.Size = New System.Drawing.Size(212, 29)
        Me.cedo.TabIndex = 39
        '
        'cagente
        '
        Me.cagente.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cagente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cagente.Location = New System.Drawing.Point(631, 233)
        Me.cagente.Name = "cagente"
        Me.cagente.ReadOnly = True
        Me.cagente.Size = New System.Drawing.Size(57, 29)
        Me.cagente.TabIndex = 38
        '
        'ccomercial
        '
        Me.ccomercial.BackColor = System.Drawing.Color.LightSteelBlue
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
        Me.Listatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listatxt.Location = New System.Drawing.Point(568, 233)
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
        Me.Label6.Location = New System.Drawing.Point(66, 233)
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
        Me.Label5.Location = New System.Drawing.Point(48, 188)
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
        Me.Label4.Location = New System.Drawing.Point(320, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "R.F.C.  :"
        '
        'cdias
        '
        Me.cdias.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdias.Location = New System.Drawing.Point(126, 233)
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
        Me.Label3.Location = New System.Drawing.Point(37, 152)
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
        Me.Label2.Location = New System.Drawing.Point(39, 107)
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
        Me.Label1.Location = New System.Drawing.Point(22, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Direccion :"
        '
        'climite
        '
        Me.climite.BackColor = System.Drawing.Color.LightSteelBlue
        Me.climite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.climite.Location = New System.Drawing.Point(126, 187)
        Me.climite.Name = "climite"
        Me.climite.ReadOnly = True
        Me.climite.Size = New System.Drawing.Size(179, 29)
        Me.climite.TabIndex = 7
        Me.climite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ccolonia
        '
        Me.ccolonia.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ccolonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccolonia.Location = New System.Drawing.Point(126, 107)
        Me.ccolonia.MaxLength = 50
        Me.ccolonia.Name = "ccolonia"
        Me.ccolonia.Size = New System.Drawing.Size(562, 29)
        Me.ccolonia.TabIndex = 6
        '
        'cciudad
        '
        Me.cciudad.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cciudad.Location = New System.Drawing.Point(126, 153)
        Me.cciudad.Name = "cciudad"
        Me.cciudad.ReadOnly = True
        Me.cciudad.Size = New System.Drawing.Size(282, 29)
        Me.cciudad.TabIndex = 5
        '
        'cdireccion
        '
        Me.cdireccion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdireccion.Location = New System.Drawing.Point(126, 60)
        Me.cdireccion.MaxLength = 100
        Me.cdireccion.Multiline = True
        Me.cdireccion.Name = "cdireccion"
        Me.cdireccion.Size = New System.Drawing.Size(714, 30)
        Me.cdireccion.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage5.Controls.Add(Me.Label34)
        Me.TabPage5.Controls.Add(Me.IEPSTXT)
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
        Me.TabPage5.Size = New System.Drawing.Size(1246, 343)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Sys"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Enabled = False
        Me.Label34.Location = New System.Drawing.Point(137, 112)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(34, 13)
        Me.Label34.TabIndex = 51
        Me.Label34.Text = "IEPS:"
        '
        'IEPSTXT
        '
        Me.IEPSTXT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.IEPSTXT.Enabled = False
        Me.IEPSTXT.Location = New System.Drawing.Point(178, 106)
        Me.IEPSTXT.Name = "IEPSTXT"
        Me.IEPSTXT.ReadOnly = True
        Me.IEPSTXT.Size = New System.Drawing.Size(82, 20)
        Me.IEPSTXT.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(51, 139)
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
        Me.tot10.Location = New System.Drawing.Point(180, 132)
        Me.tot10.Name = "tot10"
        Me.tot10.ReadOnly = True
        Me.tot10.Size = New System.Drawing.Size(82, 20)
        Me.tot10.TabIndex = 45
        '
        'tot0
        '
        Me.tot0.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tot0.Enabled = False
        Me.tot0.Location = New System.Drawing.Point(93, 132)
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
        '
        'dgvdoc
        '
        Me.dgvdoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvdoc.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdoc.Location = New System.Drawing.Point(316, 6)
        Me.dgvdoc.Name = "dgvdoc"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.dgvdoc.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdoc.Size = New System.Drawing.Size(495, 101)
        Me.dgvdoc.TabIndex = 37
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1246, 343)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Facturar servicio"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DescripcionComboBox)
        Me.GroupBox3.Controls.Add(Me.mod_total)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.mod_descripcion)
        Me.GroupBox3.Controls.Add(Me.mod_linea)
        Me.GroupBox3.Controls.Add(Me.mod_id)
        Me.GroupBox3.Location = New System.Drawing.Point(259, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(540, 264)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facturacion servicios"
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataSource = Me.ProductosBindingSource
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(9, 19)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(525, 21)
        Me.DescripcionComboBox.TabIndex = 21
        Me.DescripcionComboBox.ValueMember = "id_Producto"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'mod_total
        '
        Me.mod_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mod_total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "venta", True))
        Me.mod_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_total.Location = New System.Drawing.Point(403, 189)
        Me.mod_total.Name = "mod_total"
        Me.mod_total.Size = New System.Drawing.Size(131, 24)
        Me.mod_total.TabIndex = 18
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(9, 189)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Modifica"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'mod_descripcion
        '
        Me.mod_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Descripcion", True))
        Me.mod_descripcion.Enabled = False
        Me.mod_descripcion.Location = New System.Drawing.Point(9, 86)
        Me.mod_descripcion.MaxLength = 300
        Me.mod_descripcion.Multiline = True
        Me.mod_descripcion.Name = "mod_descripcion"
        Me.mod_descripcion.Size = New System.Drawing.Size(525, 97)
        Me.mod_descripcion.TabIndex = 8
        '
        'mod_linea
        '
        Me.mod_linea.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mod_linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_linea.Location = New System.Drawing.Point(9, 51)
        Me.mod_linea.Name = "mod_linea"
        Me.mod_linea.Size = New System.Drawing.Size(188, 29)
        Me.mod_linea.TabIndex = 3
        '
        'mod_id
        '
        Me.mod_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mod_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "id_producto", True))
        Me.mod_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_id.Location = New System.Drawing.Point(145, 51)
        Me.mod_id.Name = "mod_id"
        Me.mod_id.Size = New System.Drawing.Size(43, 24)
        Me.mod_id.TabIndex = 19
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaToolStripMenuItem, Me.VentaToolStripMenuItem, Me.FuncionesToolStripMenuItem, Me.FeiToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1254, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip1"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiarioDeVentasToolStripMenuItem, Me.BuscarProductoToolStripMenuItem, Me.AbrirCajaToolStripMenuItem, Me.TipoDeCambioToolStripMenuItem})
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'DiarioDeVentasToolStripMenuItem
        '
        Me.DiarioDeVentasToolStripMenuItem.Name = "DiarioDeVentasToolStripMenuItem"
        Me.DiarioDeVentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DiarioDeVentasToolStripMenuItem.Text = "Diario de Ventas"
        '
        'BuscarProductoToolStripMenuItem
        '
        Me.BuscarProductoToolStripMenuItem.Name = "BuscarProductoToolStripMenuItem"
        Me.BuscarProductoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.BuscarProductoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BuscarProductoToolStripMenuItem.Text = "Buscar Producto"
        '
        'AbrirCajaToolStripMenuItem
        '
        Me.AbrirCajaToolStripMenuItem.Name = "AbrirCajaToolStripMenuItem"
        Me.AbrirCajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbrirCajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbrirCajaToolStripMenuItem.Text = "Abrir caja"
        '
        'TipoDeCambioToolStripMenuItem
        '
        Me.TipoDeCambioToolStripMenuItem.Name = "TipoDeCambioToolStripMenuItem"
        Me.TipoDeCambioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoDeCambioToolStripMenuItem.Text = "Tipo de Cambio"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.FacturaNotaToolStripMenuItem, Me.CreditoContadoToolStripMenuItem, Me.Agregar_Un_producto_menu, Me.PagarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'FacturaNotaToolStripMenuItem
        '
        Me.FacturaNotaToolStripMenuItem.Name = "FacturaNotaToolStripMenuItem"
        Me.FacturaNotaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FacturaNotaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.FacturaNotaToolStripMenuItem.Text = "Factura/Nota"
        '
        'CreditoContadoToolStripMenuItem
        '
        Me.CreditoContadoToolStripMenuItem.Name = "CreditoContadoToolStripMenuItem"
        Me.CreditoContadoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.CreditoContadoToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CreditoContadoToolStripMenuItem.Text = "Credito/Contado"
        '
        'Agregar_Un_producto_menu
        '
        Me.Agregar_Un_producto_menu.Name = "Agregar_Un_producto_menu"
        Me.Agregar_Un_producto_menu.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.Agregar_Un_producto_menu.Size = New System.Drawing.Size(204, 22)
        Me.Agregar_Un_producto_menu.Text = "Agergar_producto"
        '
        'PagarToolStripMenuItem
        '
        Me.PagarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_pago_contado, Me.mnu_Pago_debito, Me.mnu_Pago_credito})
        Me.PagarToolStripMenuItem.Name = "PagarToolStripMenuItem"
        Me.PagarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.PagarToolStripMenuItem.Text = "Pagar"
        '
        'mnu_pago_contado
        '
        Me.mnu_pago_contado.Name = "mnu_pago_contado"
        Me.mnu_pago_contado.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnu_pago_contado.Size = New System.Drawing.Size(141, 22)
        Me.mnu_pago_contado.Text = "Contado"
        '
        'mnu_Pago_debito
        '
        Me.mnu_Pago_debito.Name = "mnu_Pago_debito"
        Me.mnu_Pago_debito.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.mnu_Pago_debito.Size = New System.Drawing.Size(141, 22)
        Me.mnu_Pago_debito.Text = "T.Debito"
        '
        'mnu_Pago_credito
        '
        Me.mnu_Pago_credito.Name = "mnu_Pago_credito"
        Me.mnu_Pago_credito.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.mnu_Pago_credito.Size = New System.Drawing.Size(141, 22)
        Me.mnu_Pago_credito.Text = "T.Credito"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'FuncionesToolStripMenuItem
        '
        Me.FuncionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DevolucionesEnVentaToolStripMenuItem, Me.CambiarprecioToolStripMenuItem, Me.BorrarNotaToolStripMenuItem, Me.CerraCajaToolStripMenuItem, Me.ResumenDeDocumentosToolStripMenuItem, Me.VerificarPrecioToolStripMenuItem, Me.EliminarDocumentosToolStripMenuItem, Me.ActivarDesactivarFacturacionFDiaToolStripMenuItem, Me.TimbrarPublicoEnGeneraToolStripMenuItem, Me.GenerarDocumentoDeCiereToolStripMenuItem})
        Me.FuncionesToolStripMenuItem.Name = "FuncionesToolStripMenuItem"
        Me.FuncionesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.FuncionesToolStripMenuItem.Text = "Funciones"
        '
        'DevolucionesEnVentaToolStripMenuItem
        '
        Me.DevolucionesEnVentaToolStripMenuItem.Name = "DevolucionesEnVentaToolStripMenuItem"
        Me.DevolucionesEnVentaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DevolucionesEnVentaToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.DevolucionesEnVentaToolStripMenuItem.Text = "Devoluciones en venta"
        '
        'CambiarprecioToolStripMenuItem
        '
        Me.CambiarprecioToolStripMenuItem.Name = "CambiarprecioToolStripMenuItem"
        Me.CambiarprecioToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CambiarprecioToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.CambiarprecioToolStripMenuItem.Text = "Pedir Precio"
        '
        'BorrarNotaToolStripMenuItem
        '
        Me.BorrarNotaToolStripMenuItem.Name = "BorrarNotaToolStripMenuItem"
        Me.BorrarNotaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.BorrarNotaToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.BorrarNotaToolStripMenuItem.Text = "borrar nota"
        '
        'CerraCajaToolStripMenuItem
        '
        Me.CerraCajaToolStripMenuItem.Name = "CerraCajaToolStripMenuItem"
        Me.CerraCajaToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.CerraCajaToolStripMenuItem.Text = "Cerra Caja"
        '
        'ResumenDeDocumentosToolStripMenuItem
        '
        Me.ResumenDeDocumentosToolStripMenuItem.Name = "ResumenDeDocumentosToolStripMenuItem"
        Me.ResumenDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ResumenDeDocumentosToolStripMenuItem.Text = "Resumen de Documentos"
        '
        'VerificarPrecioToolStripMenuItem
        '
        Me.VerificarPrecioToolStripMenuItem.Name = "VerificarPrecioToolStripMenuItem"
        Me.VerificarPrecioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.VerificarPrecioToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.VerificarPrecioToolStripMenuItem.Text = "Verificar Precio"
        '
        'EliminarDocumentosToolStripMenuItem
        '
        Me.EliminarDocumentosToolStripMenuItem.Name = "EliminarDocumentosToolStripMenuItem"
        Me.EliminarDocumentosToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.EliminarDocumentosToolStripMenuItem.Text = "Eliminar Documentos"
        '
        'ActivarDesactivarFacturacionFDiaToolStripMenuItem
        '
        Me.ActivarDesactivarFacturacionFDiaToolStripMenuItem.Name = "ActivarDesactivarFacturacionFDiaToolStripMenuItem"
        Me.ActivarDesactivarFacturacionFDiaToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ActivarDesactivarFacturacionFDiaToolStripMenuItem.Text = "Activar/Desactivar Facturacion PG"
        '
        'TimbrarPublicoEnGeneraToolStripMenuItem
        '
        Me.TimbrarPublicoEnGeneraToolStripMenuItem.Name = "TimbrarPublicoEnGeneraToolStripMenuItem"
        Me.TimbrarPublicoEnGeneraToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.TimbrarPublicoEnGeneraToolStripMenuItem.Text = "Timbrar Publico en genera"
        '
        'GenerarDocumentoDeCiereToolStripMenuItem
        '
        Me.GenerarDocumentoDeCiereToolStripMenuItem.Name = "GenerarDocumentoDeCiereToolStripMenuItem"
        Me.GenerarDocumentoDeCiereToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.GenerarDocumentoDeCiereToolStripMenuItem.Text = "Generar Documento de ciere"
        '
        'FeiToolStripMenuItem
        '
        Me.FeiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivadoModuloDeCFDToolStripMenuItem})
        Me.FeiToolStripMenuItem.Name = "FeiToolStripMenuItem"
        Me.FeiToolStripMenuItem.Size = New System.Drawing.Size(34, 20)
        Me.FeiToolStripMenuItem.Text = "Fei"
        '
        'ActivadoModuloDeCFDToolStripMenuItem
        '
        Me.ActivadoModuloDeCFDToolStripMenuItem.Checked = True
        Me.ActivadoModuloDeCFDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActivadoModuloDeCFDToolStripMenuItem.Enabled = False
        Me.ActivadoModuloDeCFDToolStripMenuItem.Name = "ActivadoModuloDeCFDToolStripMenuItem"
        Me.ActivadoModuloDeCFDToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ActivadoModuloDeCFDToolStripMenuItem.Text = "Activado Modulo de CFD"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowMerge = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.boton_cliente, Me.boton_factura, Me.boton_credito, Me.ToolStripSeparator1, Me.boton_pago_contado, Me.boton_pago_tarjeta, Me.boton_pago_credito, Me.ToolStripSeparator2, Me.Boton_imprimir, Me.ToolStripSeparator3, Me.boton_relacion, Me.boton_repetir, Me.ToolStripButton2, Me.boton_retirar, Me.Boton_ver_Autorzaciones, Me.Boton_corte, Me.ToolStripButton5, Me.boton_puerta, Me.ToolStripButton6, Me.boton_Entradas, Me.ToolStripButton3, Me.boton_traspasos, Me.boton_resumen, Me.ToolStripButton8, Me.ToolStripButton7, Me.boton_reimprimir_ticket, Me.ToolStripButton9, Me.ToolStripButton10, Me.BTN_NUEVO_CLIENTE})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1254, 39)
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
        'boton_factura
        '
        Me.boton_factura.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.boton_factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.boton_factura.Checked = True
        Me.boton_factura.CheckOnClick = True
        Me.boton_factura.CheckState = System.Windows.Forms.CheckState.Checked
        Me.boton_factura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boton_factura.Image = CType(resources.GetObject("boton_factura.Image"), System.Drawing.Image)
        Me.boton_factura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_factura.Name = "boton_factura"
        Me.boton_factura.Size = New System.Drawing.Size(50, 36)
        Me.boton_factura.Text = "Factura"
        Me.boton_factura.ToolTipText = "Factura/Remision"
        '
        'boton_credito
        '
        Me.boton_credito.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.boton_credito.Checked = True
        Me.boton_credito.CheckOnClick = True
        Me.boton_credito.CheckState = System.Windows.Forms.CheckState.Checked
        Me.boton_credito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boton_credito.Image = CType(resources.GetObject("boton_credito.Image"), System.Drawing.Image)
        Me.boton_credito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_credito.Name = "boton_credito"
        Me.boton_credito.Size = New System.Drawing.Size(50, 36)
        Me.boton_credito.Text = "Credito"
        Me.boton_credito.ToolTipText = "Credito/Contado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'boton_pago_contado
        '
        Me.boton_pago_contado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_pago_contado.Image = Global.AdminTegral.My.Resources.Resources.dollar
        Me.boton_pago_contado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_pago_contado.Name = "boton_pago_contado"
        Me.boton_pago_contado.Size = New System.Drawing.Size(36, 36)
        Me.boton_pago_contado.Text = "Pago en Efectivo"
        '
        'boton_pago_tarjeta
        '
        Me.boton_pago_tarjeta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_pago_tarjeta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebitoToolStripMenuItem, Me.CreditoToolStripMenuItem})
        Me.boton_pago_tarjeta.Image = Global.AdminTegral.My.Resources.Resources.visa
        Me.boton_pago_tarjeta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_pago_tarjeta.Name = "boton_pago_tarjeta"
        Me.boton_pago_tarjeta.Size = New System.Drawing.Size(48, 36)
        Me.boton_pago_tarjeta.Text = "Pago con Tarjeta"
        '
        'DebitoToolStripMenuItem
        '
        Me.DebitoToolStripMenuItem.Name = "DebitoToolStripMenuItem"
        Me.DebitoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DebitoToolStripMenuItem.Text = "Debito"
        '
        'CreditoToolStripMenuItem
        '
        Me.CreditoToolStripMenuItem.Name = "CreditoToolStripMenuItem"
        Me.CreditoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CreditoToolStripMenuItem.Text = "Credito"
        '
        'boton_pago_credito
        '
        Me.boton_pago_credito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_pago_credito.Enabled = False
        Me.boton_pago_credito.Image = Global.AdminTegral.My.Resources.Resources.file_edit
        Me.boton_pago_credito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_pago_credito.Name = "boton_pago_credito"
        Me.boton_pago_credito.Size = New System.Drawing.Size(36, 36)
        Me.boton_pago_credito.Text = "Credito"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'Boton_imprimir
        '
        Me.Boton_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Boton_imprimir.Enabled = False
        Me.Boton_imprimir.Image = Global.AdminTegral.My.Resources.Resources.Printer_Green
        Me.Boton_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_imprimir.Name = "Boton_imprimir"
        Me.Boton_imprimir.Size = New System.Drawing.Size(36, 36)
        Me.Boton_imprimir.Text = "Imprimir y Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'boton_relacion
        '
        Me.boton_relacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_relacion.Image = Global.AdminTegral.My.Resources.Resources.Vista__50_
        Me.boton_relacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_relacion.Name = "boton_relacion"
        Me.boton_relacion.Size = New System.Drawing.Size(36, 36)
        Me.boton_relacion.Text = "Relacion de Facturas"
        '
        'boton_repetir
        '
        Me.boton_repetir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_repetir.Image = Global.AdminTegral.My.Resources.Resources.Note_2
        Me.boton_repetir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_repetir.Name = "boton_repetir"
        Me.boton_repetir.Size = New System.Drawing.Size(36, 36)
        Me.boton_repetir.Text = "Recuperar Ticket/Factura"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarUltimaToolStripMenuItem, Me.SuspenderToolStripMenuItem, Me.CargarToolStripMenuItem, Me.CargarPEDIDOToolStripMenuItem, Me.FacturarCotizacionToolStripMenuItem, Me.FacturarCostoToolStripMenuItem, Me.FacturaCostoSIVAToolStripMenuItem})
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Folder_Red
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(48, 36)
        Me.ToolStripButton2.Text = "Operaciones Suspendidas"
        '
        'CargarUltimaToolStripMenuItem
        '
        Me.CargarUltimaToolStripMenuItem.Image = Global.AdminTegral.My.Resources.Resources.Shutdown_5
        Me.CargarUltimaToolStripMenuItem.Name = "CargarUltimaToolStripMenuItem"
        Me.CargarUltimaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CargarUltimaToolStripMenuItem.Text = "Cargar Operacion"
        '
        'SuspenderToolStripMenuItem
        '
        Me.SuspenderToolStripMenuItem.Image = Global.AdminTegral.My.Resources.Resources.Export
        Me.SuspenderToolStripMenuItem.Name = "SuspenderToolStripMenuItem"
        Me.SuspenderToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SuspenderToolStripMenuItem.Text = "Suspender"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Image = Global.AdminTegral.My.Resources.Resources.Import
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CargarToolStripMenuItem.Text = "Cargar Suspendida"
        '
        'CargarPEDIDOToolStripMenuItem
        '
        Me.CargarPEDIDOToolStripMenuItem.Image = Global.AdminTegral.My.Resources.Resources.page_add
        Me.CargarPEDIDOToolStripMenuItem.Name = "CargarPEDIDOToolStripMenuItem"
        Me.CargarPEDIDOToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CargarPEDIDOToolStripMenuItem.Text = "Facturar PEDIDO"
        '
        'FacturarCotizacionToolStripMenuItem
        '
        Me.FacturarCotizacionToolStripMenuItem.Image = Global.AdminTegral.My.Resources.Resources.folder_blue_favourite
        Me.FacturarCotizacionToolStripMenuItem.Name = "FacturarCotizacionToolStripMenuItem"
        Me.FacturarCotizacionToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.FacturarCotizacionToolStripMenuItem.Text = "Facturar Cotizacion"
        '
        'FacturarCostoToolStripMenuItem
        '
        Me.FacturarCostoToolStripMenuItem.Name = "FacturarCostoToolStripMenuItem"
        Me.FacturarCostoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.FacturarCostoToolStripMenuItem.Text = "Facturar Costo C/IVA"
        '
        'FacturaCostoSIVAToolStripMenuItem
        '
        Me.FacturaCostoSIVAToolStripMenuItem.Name = "FacturaCostoSIVAToolStripMenuItem"
        Me.FacturaCostoSIVAToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.FacturaCostoSIVAToolStripMenuItem.Text = "Factura Costo S/IVA"
        '
        'boton_retirar
        '
        Me.boton_retirar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_retirar.Image = Global.AdminTegral.My.Resources.Resources.dinero
        Me.boton_retirar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_retirar.Name = "boton_retirar"
        Me.boton_retirar.Size = New System.Drawing.Size(36, 36)
        Me.boton_retirar.Text = "Retiro de Dinero"
        '
        'Boton_ver_Autorzaciones
        '
        Me.Boton_ver_Autorzaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Boton_ver_Autorzaciones.Image = Global.AdminTegral.My.Resources.Resources.avedesk
        Me.Boton_ver_Autorzaciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_ver_Autorzaciones.Name = "Boton_ver_Autorzaciones"
        Me.Boton_ver_Autorzaciones.Size = New System.Drawing.Size(36, 36)
        Me.Boton_ver_Autorzaciones.Text = "Ver Autorizacion Pendiente"
        Me.Boton_ver_Autorzaciones.Visible = False
        '
        'Boton_corte
        '
        Me.Boton_corte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Boton_corte.Image = Global.AdminTegral.My.Resources.Resources.Vista_Options
        Me.Boton_corte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_corte.Name = "Boton_corte"
        Me.Boton_corte.Size = New System.Drawing.Size(36, 36)
        Me.Boton_corte.Text = "Corte de Caja"
        Me.Boton_corte.Visible = False
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.AdminTegral.My.Resources.Resources.cash1
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton5.Text = "Abrir Cajon"
        '
        'boton_puerta
        '
        Me.boton_puerta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.boton_puerta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_puerta.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.boton_puerta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_puerta.Name = "boton_puerta"
        Me.boton_puerta.Size = New System.Drawing.Size(36, 36)
        Me.boton_puerta.Text = "Salir"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.AdminTegral.My.Resources.Resources.Transmit
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton6.Text = "Relacion para Choferes"
        '
        'boton_Entradas
        '
        Me.boton_Entradas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_Entradas.Image = Global.AdminTegral.My.Resources.Resources.shoppingcart_remove
        Me.boton_Entradas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_Entradas.Name = "boton_Entradas"
        Me.boton_Entradas.Size = New System.Drawing.Size(36, 36)
        Me.boton_Entradas.Text = "Entradas"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.AdminTegral.My.Resources.Resources.Vista_Info
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "Status de la Caja"
        '
        'boton_traspasos
        '
        Me.boton_traspasos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_traspasos.Image = Global.AdminTegral.My.Resources.Resources.mes_téléchargements
        Me.boton_traspasos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_traspasos.Name = "boton_traspasos"
        Me.boton_traspasos.Size = New System.Drawing.Size(36, 36)
        Me.boton_traspasos.Text = "Traspaso de Mercancia"
        Me.boton_traspasos.Visible = False
        '
        'boton_resumen
        '
        Me.boton_resumen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_resumen.Image = Global.AdminTegral.My.Resources.Resources.Calc
        Me.boton_resumen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_resumen.Name = "boton_resumen"
        Me.boton_resumen.Size = New System.Drawing.Size(36, 36)
        Me.boton_resumen.Text = "Resumen de Ventas"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.AdminTegral.My.Resources.Resources.impresoradematrix
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.AdminTegral.My.Resources.Resources.Download_3
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton7.Text = "Bajar Actualizacion"
        '
        'boton_reimprimir_ticket
        '
        Me.boton_reimprimir_ticket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_reimprimir_ticket.Image = Global.AdminTegral.My.Resources.Resources.impresora_rollo
        Me.boton_reimprimir_ticket.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_reimprimir_ticket.Name = "boton_reimprimir_ticket"
        Me.boton_reimprimir_ticket.Size = New System.Drawing.Size(36, 36)
        Me.boton_reimprimir_ticket.Text = "Reimprimir un ticket"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeinirCarpetaToolStripMenuItem, Me.rcarpeta, Me.rfolio})
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(48, 36)
        Me.ToolStripButton9.Text = "ToolStripButton9"
        '
        'DeinirCarpetaToolStripMenuItem
        '
        Me.DeinirCarpetaToolStripMenuItem.Name = "DeinirCarpetaToolStripMenuItem"
        Me.DeinirCarpetaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DeinirCarpetaToolStripMenuItem.Text = "deinir carpeta"
        '
        'rcarpeta
        '
        Me.rcarpeta.Name = "rcarpeta"
        Me.rcarpeta.Size = New System.Drawing.Size(100, 23)
        Me.rcarpeta.Text = "F:\24jun2010\operaciones\"
        '
        'rfolio
        '
        Me.rfolio.Name = "rfolio"
        Me.rfolio.Size = New System.Drawing.Size(100, 23)
        Me.rfolio.Text = "15488969006"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(125, 36)
        Me.ToolStripButton10.Text = "Imprimir Precio"
        '
        'BTN_NUEVO_CLIENTE
        '
        Me.BTN_NUEVO_CLIENTE.Image = Global.AdminTegral.My.Resources.Resources.add
        Me.BTN_NUEVO_CLIENTE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_NUEVO_CLIENTE.Name = "BTN_NUEVO_CLIENTE"
        Me.BTN_NUEVO_CLIENTE.Size = New System.Drawing.Size(118, 36)
        Me.BTN_NUEVO_CLIENTE.Text = "Nuevo Cliente"
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
        'Timer1
        '
        Me.Timer1.Interval = 5000
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status2, Me.lblleyenda, Me.lblsepara})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1254, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel1.Text = "Ok"
        '
        'status2
        '
        Me.status2.Name = "status2"
        Me.status2.Size = New System.Drawing.Size(0, 17)
        '
        'lblleyenda
        '
        Me.lblleyenda.Name = "lblleyenda"
        Me.lblleyenda.Size = New System.Drawing.Size(10, 17)
        Me.lblleyenda.Text = " "
        '
        'lblsepara
        '
        Me.lblsepara.Name = "lblsepara"
        Me.lblsepara.Size = New System.Drawing.Size(47, 17)
        Me.lblsepara.Text = "Normal"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument
        '
        '
        'Fei_metodosTableAdapter
        '
        Me.Fei_metodosTableAdapter.ClearBeforeFill = True
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.Boton_salir
        Me.ClientSize = New System.Drawing.Size(1254, 551)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "caja"
        Me.ShowIcon = False
        Me.Text = "caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo_oxxo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.Log_cajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Lista_de_ventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_paquete.ResumeLayout(False)
        Me.panel_paquete.PerformLayout()
        CType(Me.imgcambiarprecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fei_metodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeiDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupEfectivo.ResumeLayout(False)
        Me.GroupEfectivo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Grouptarjeta.ResumeLayout(False)
        Me.Grouptarjeta.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvpago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents FacturaNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblcredito As System.Windows.Forms.Label
    Friend WithEvents CreditoContadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents boton_factura As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_credito As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents boton_pago_contado As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_pago_credito As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pago_efectivotxt As System.Windows.Forms.TextBox
    Friend WithEvents PagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_pago_contado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Pago_debito As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Pago_credito As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupEfectivo As System.Windows.Forms.GroupBox
    Friend WithEvents pago_valestxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblcambio As System.Windows.Forms.Label
    Friend WithEvents cambiotxt As System.Windows.Forms.TextBox
    Friend WithEvents pago_bancostxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtpagado As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Boton_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_cliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boton_relacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_repetir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SuspenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Total_credito As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents total_debito As System.Windows.Forms.TextBox
    Friend WithEvents Grouptarjeta As System.Windows.Forms.GroupBox
    Friend WithEvents pago_banco As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Tarjeta_importe As System.Windows.Forms.TextBox
    Friend WithEvents Banco_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tarjeta_vales As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tarjeta_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblexcede As System.Windows.Forms.Label
    Friend WithEvents excedetxt As System.Windows.Forms.TextBox
    Friend WithEvents Boton_ver_Autorzaciones As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_autorizar As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
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
    Friend WithEvents Boton_corte As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents comisiontxt As System.Windows.Forms.TextBox
    Friend WithEvents boton_retirar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BorrarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boton_pago_tarjeta As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents DebitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ccomercial As System.Windows.Forms.TextBox
    Friend WithEvents cagente As System.Windows.Forms.TextBox
    Friend WithEvents cedo As System.Windows.Forms.TextBox
    Friend WithEvents boton_UPD_folios As System.Windows.Forms.Button
    Friend WithEvents BuscarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarUltimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Pago_bancotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Pago_ncheque As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lbltipotarjeta As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Totalpagar As System.Windows.Forms.TextBox
    Friend WithEvents boton_puerta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents folionc As System.Windows.Forms.TextBox
    Friend WithEvents boton_NC As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CargarPEDIDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturarCotizacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cdesglosar As System.Windows.Forms.CheckBox
    Friend WithEvents crfc As System.Windows.Forms.TextBox
    Friend WithEvents listaventas_codigo As System.Windows.Forms.TextBox
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pago_num_notatxt As System.Windows.Forms.TextBox
    Friend WithEvents pago_nctxt As System.Windows.Forms.TextBox
    Friend WithEvents Boton_avisar As System.Windows.Forms.Button
    Friend WithEvents boton_Entradas As System.Windows.Forms.ToolStripButton
    Friend WithEvents chequechk As System.Windows.Forms.CheckBox
    Friend WithEvents boton_Solicita As System.Windows.Forms.Button
    Friend WithEvents FuncionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesEnVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarprecioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgcambiarprecio As System.Windows.Forms.PictureBox
    Friend WithEvents boton_traspasos As System.Windows.Forms.ToolStripButton
    Friend WithEvents Precio_unicoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ccp As System.Windows.Forms.TextBox
    Friend WithEvents boton_resumen As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtconcepto As System.Windows.Forms.TextBox
    Friend WithEvents lbltipoventa As System.Windows.Forms.Label
    Friend WithEvents txtrecibio As System.Windows.Forms.TextBox
    Friend WithEvents ConvertirPiezasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_cancelar_solicitud As System.Windows.Forms.Button
    Friend WithEvents AbrirCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerraCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenDeDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boton_reimprimir_ticket As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents DeinirCarpetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rcarpeta As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents rfolio As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents boton_ver_precio As System.Windows.Forms.Button
    Friend WithEvents VerificarPrecioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Dll As System.Windows.Forms.TextBox
    Friend WithEvents lbldolares As System.Windows.Forms.Label
    Friend WithEvents TipoDeCambioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivadoModuloDeCFDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents leyendatxt As System.Windows.Forms.TextBox
    Friend WithEvents lblleyenda As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ActivarDesactivarFacturacionFDiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblsepara As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter
    Friend WithEvents SepararCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents panel_paquete As System.Windows.Forms.GroupBox
    Friend WithEvents pTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents ptot As System.Windows.Forms.TextBox
    Friend WithEvents piva As System.Windows.Forms.TextBox
    Friend WithEvents psub As System.Windows.Forms.TextBox
    Friend WithEvents pdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents pcantidad As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents logo_oxxo As System.Windows.Forms.PictureBox
    Friend WithEvents FacturarCostoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaCostoSIVAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents IEPSTXT As System.Windows.Forms.TextBox
    Friend WithEvents IepsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents FeiDataset As AdminTegral.feiDataset
    Friend WithEvents Fei_metodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fei_metodosTableAdapter As AdminTegral.feiDatasetTableAdapters.fei_metodosTableAdapter
    Friend WithEvents formaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TimbrarPublicoEnGeneraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarDocumentoDeCiereToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents UsoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MetodoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cemail As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents mod_total As System.Windows.Forms.TextBox
    Friend WithEvents mod_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents mod_linea As System.Windows.Forms.TextBox
    Friend WithEvents mod_id As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_NUEVO_CLIENTE As System.Windows.Forms.ToolStripButton
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
