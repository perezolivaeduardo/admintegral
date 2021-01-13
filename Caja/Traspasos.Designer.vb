<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class traspasos
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
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim FactorLabel As System.Windows.Forms.Label
        Dim UnidadesLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim VentaLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim Id_unidadLabel As System.Windows.Forms.Label
        Dim Abrir_cajonLabel As System.Windows.Forms.Label
        Dim CajonLabel As System.Windows.Forms.Label
        Dim LocalLabel As System.Windows.Forms.Label
        Dim SerieLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Id_cajaLabel As System.Windows.Forms.Label
        Dim lblFolio As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim Id_valesLabel As System.Windows.Forms.Label
        Dim Id_contadoLabel As System.Windows.Forms.Label
        Dim Iduser_cerroLabel As System.Windows.Forms.Label
        Dim HoracierreLabel As System.Windows.Forms.Label
        Dim Iduser_abrioLabel As System.Windows.Forms.Label
        Dim HorainicioLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Id_cajaLabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(traspasos))
        Me.sql_documento_impresionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Almacenentrada = New System.Windows.Forms.ComboBox
        Me.Tbl_almacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.puerta = New System.Windows.Forms.TextBox
        Me.Quie = New System.Windows.Forms.Label
        Me.quien = New System.Windows.Forms.TextBox
        Me.folio = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.almacensalida = New System.Windows.Forms.TextBox
        Me.identrada = New System.Windows.Forms.TextBox
        Me.idsalida = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.boton_UPD_folios = New System.Windows.Forms.Button
        Me.Id_cajaTextBox1 = New System.Windows.Forms.TextBox
        Me.Log_cajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Iduser_abrioTextBox = New System.Windows.Forms.TextBox
        Me.Iduser_cerroTextBox = New System.Windows.Forms.TextBox
        Me.Id_contadoTextBox = New System.Windows.Forms.TextBox
        Me.Id_valesTextBox = New System.Windows.Forms.TextBox
        Me.AlmacenTextBox = New System.Windows.Forms.TextBox
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemisionTextBox = New System.Windows.Forms.TextBox
        Me.SeriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FolioTextBox = New System.Windows.Forms.TextBox
        Me.Id_cajaTextBox = New System.Windows.Forms.TextBox
        Me.sucursaltxt = New System.Windows.Forms.TextBox
        Me.SerieTextBox = New System.Windows.Forms.TextBox
        Me.Abrir_cajonTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.HorainicioDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.HoracierreDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LocalCheckBox = New System.Windows.Forms.CheckBox
        Me.CajonCheckBox = New System.Windows.Forms.CheckBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConsultarExistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductosNegadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label15 = New System.Windows.Forms.Label
        Me.comentarios = New System.Windows.Forms.TextBox
        Me.lineastxt = New System.Windows.Forms.TextBox
        Me.Id_unidadTextBox = New System.Windows.Forms.TextBox
        Me.Lista_de_ventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.canttxt = New System.Windows.Forms.TextBox
        Me.idtxt = New System.Windows.Forms.TextBox
        Me.IvaTextBox = New System.Windows.Forms.TextBox
        Me.PesoTextBox = New System.Windows.Forms.TextBox
        Me.VentaTextBox = New System.Windows.Forms.TextBox
        Me.CostoTextBox = New System.Windows.Forms.TextBox
        Me.UnidadesTextBox = New System.Windows.Forms.TextBox
        Me.FactorTextBox = New System.Windows.Forms.TextBox
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox
        Me.UnidadTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.linea = New System.Windows.Forms.TextBox
        Me.CodigoTextBox1 = New System.Windows.Forms.TextBox
        Me.grupo1 = New System.Windows.Forms.GroupBox
        Me.lblunidad = New System.Windows.Forms.Label
        Me.lblprod = New System.Windows.Forms.Label
        Me.dgvexistencia = New System.Windows.Forms.DataGridView
        Me.Label18 = New System.Windows.Forms.Label
        Me.Boton_salir = New System.Windows.Forms.Button
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.dgvpedido = New System.Windows.Forms.DataGridView
        Me.boton_agregar = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.filtropedido = New System.Windows.Forms.TextBox
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DiarioDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CapturaVariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Agregar_Un_producto_menu = New System.Windows.Forms.ToolStripMenuItem
        Me.btn_agregar = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.CargarUltimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuspenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.boton_puerta = New System.Windows.Forms.ToolStripButton
        Me.boton_guardar = New System.Windows.Forms.ToolStripButton
        Me.boton_repetir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.boton_reimprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.boton_NC = New System.Windows.Forms.ToolStripButton
        Me.Lista_de_ventasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        Me.CajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter
        Me.SeriesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.SeriesTableAdapter
        Me.Log_cajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
        Me.sql_documento_impresionTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documento_impresionTableAdapter
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
        Me.btn_refresh = New System.Windows.Forms.ToolStripButton
        Id_productoLabel = New System.Windows.Forms.Label
        CodigoLabel = New System.Windows.Forms.Label
        FactorLabel = New System.Windows.Forms.Label
        UnidadesLabel = New System.Windows.Forms.Label
        CostoLabel = New System.Windows.Forms.Label
        VentaLabel = New System.Windows.Forms.Label
        PesoLabel = New System.Windows.Forms.Label
        IvaLabel = New System.Windows.Forms.Label
        Id_unidadLabel = New System.Windows.Forms.Label
        Abrir_cajonLabel = New System.Windows.Forms.Label
        CajonLabel = New System.Windows.Forms.Label
        LocalLabel = New System.Windows.Forms.Label
        SerieLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        Id_cajaLabel = New System.Windows.Forms.Label
        lblFolio = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        AlmacenLabel = New System.Windows.Forms.Label
        Id_valesLabel = New System.Windows.Forms.Label
        Id_contadoLabel = New System.Windows.Forms.Label
        Iduser_cerroLabel = New System.Windows.Forms.Label
        HoracierreLabel = New System.Windows.Forms.Label
        Iduser_abrioLabel = New System.Windows.Forms.Label
        HorainicioLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        Id_cajaLabel1 = New System.Windows.Forms.Label
        CType(Me.sql_documento_impresionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvpedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
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
        'Abrir_cajonLabel
        '
        Abrir_cajonLabel.AutoSize = True
        Abrir_cajonLabel.Location = New System.Drawing.Point(23, 157)
        Abrir_cajonLabel.Name = "Abrir_cajonLabel"
        Abrir_cajonLabel.Size = New System.Drawing.Size(59, 13)
        Abrir_cajonLabel.TabIndex = 16
        Abrir_cajonLabel.Text = "abrir cajon:"
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
        'LocalLabel
        '
        LocalLabel.AutoSize = True
        LocalLabel.Location = New System.Drawing.Point(27, 95)
        LocalLabel.Name = "LocalLabel"
        LocalLabel.Size = New System.Drawing.Size(32, 13)
        LocalLabel.TabIndex = 6
        LocalLabel.Text = "local:"
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
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(27, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Almacenentrada)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.puerta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Quie)
        Me.SplitContainer1.Panel1.Controls.Add(Me.quien)
        Me.SplitContainer1.Panel1.Controls.Add(Me.folio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.almacensalida)
        Me.SplitContainer1.Panel1.Controls.Add(Me.identrada)
        Me.SplitContainer1.Panel1.Controls.Add(Me.idsalida)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1153, 384)
        Me.SplitContainer1.SplitterDistance = 65
        Me.SplitContainer1.TabIndex = 1
        '
        'Almacenentrada
        '
        Me.Almacenentrada.DataSource = Me.Tbl_almacenesBindingSource
        Me.Almacenentrada.DisplayMember = "Almacen"
        Me.Almacenentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Almacenentrada.FormattingEnabled = True
        Me.Almacenentrada.Location = New System.Drawing.Point(197, 35)
        Me.Almacenentrada.Name = "Almacenentrada"
        Me.Almacenentrada.Size = New System.Drawing.Size(247, 24)
        Me.Almacenentrada.TabIndex = 58
        Me.Almacenentrada.ValueMember = "id_almacen"
        '
        'Tbl_almacenesBindingSource
        '
        Me.Tbl_almacenesBindingSource.DataMember = "tbl_almacenes"
        Me.Tbl_almacenesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(548, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Puerta :"
        '
        'puerta
        '
        Me.puerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puerta.Location = New System.Drawing.Point(613, 8)
        Me.puerta.MaxLength = 1
        Me.puerta.Name = "puerta"
        Me.puerta.Size = New System.Drawing.Size(28, 24)
        Me.puerta.TabIndex = 56
        '
        'Quie
        '
        Me.Quie.AutoSize = True
        Me.Quie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quie.Location = New System.Drawing.Point(476, 40)
        Me.Quie.Name = "Quie"
        Me.Quie.Size = New System.Drawing.Size(131, 18)
        Me.Quie.TabIndex = 55
        Me.Quie.Text = "Quien Transporta :"
        '
        'quien
        '
        Me.quien.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quien.Location = New System.Drawing.Point(613, 34)
        Me.quien.MaxLength = 20
        Me.quien.Name = "quien"
        Me.quien.Size = New System.Drawing.Size(266, 24)
        Me.quien.TabIndex = 54
        '
        'folio
        '
        Me.folio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.folio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folio.Location = New System.Drawing.Point(1050, 5)
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        Me.folio.Size = New System.Drawing.Size(98, 24)
        Me.folio.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 18)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Almacen Entrada :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(27, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 18)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Almacen Salida:"
        '
        'almacensalida
        '
        Me.almacensalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.almacensalida.Location = New System.Drawing.Point(197, 9)
        Me.almacensalida.Name = "almacensalida"
        Me.almacensalida.ReadOnly = True
        Me.almacensalida.Size = New System.Drawing.Size(247, 24)
        Me.almacensalida.TabIndex = 49
        '
        'identrada
        '
        Me.identrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.identrada.Location = New System.Drawing.Point(146, 35)
        Me.identrada.Name = "identrada"
        Me.identrada.Size = New System.Drawing.Size(45, 24)
        Me.identrada.TabIndex = 48
        '
        'idsalida
        '
        Me.idsalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idsalida.Location = New System.Drawing.Point(146, 9)
        Me.idsalida.Name = "idsalida"
        Me.idsalida.Size = New System.Drawing.Size(45, 24)
        Me.idsalida.TabIndex = 47
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1153, 315)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage4.Controls.Add(Me.boton_UPD_folios)
        Me.TabPage4.Controls.Add(Id_cajaLabel1)
        Me.TabPage4.Controls.Add(Me.Id_cajaTextBox1)
        Me.TabPage4.Controls.Add(Me.Iduser_abrioTextBox)
        Me.TabPage4.Controls.Add(Me.Iduser_cerroTextBox)
        Me.TabPage4.Controls.Add(Me.Id_contadoTextBox)
        Me.TabPage4.Controls.Add(Me.Id_valesTextBox)
        Me.TabPage4.Controls.Add(Me.AlmacenTextBox)
        Me.TabPage4.Controls.Add(Me.RemisionTextBox)
        Me.TabPage4.Controls.Add(Me.FolioTextBox)
        Me.TabPage4.Controls.Add(Me.Id_cajaTextBox)
        Me.TabPage4.Controls.Add(Me.sucursaltxt)
        Me.TabPage4.Controls.Add(Me.SerieTextBox)
        Me.TabPage4.Controls.Add(Me.Abrir_cajonTextBox)
        Me.TabPage4.Controls.Add(FechaLabel)
        Me.TabPage4.Controls.Add(Me.FechaDateTimePicker)
        Me.TabPage4.Controls.Add(HorainicioLabel)
        Me.TabPage4.Controls.Add(Me.HorainicioDateTimePicker)
        Me.TabPage4.Controls.Add(Iduser_abrioLabel)
        Me.TabPage4.Controls.Add(HoracierreLabel)
        Me.TabPage4.Controls.Add(Me.HoracierreDateTimePicker)
        Me.TabPage4.Controls.Add(Iduser_cerroLabel)
        Me.TabPage4.Controls.Add(Id_contadoLabel)
        Me.TabPage4.Controls.Add(Id_valesLabel)
        Me.TabPage4.Controls.Add(AlmacenLabel)
        Me.TabPage4.Controls.Add(Label13)
        Me.TabPage4.Controls.Add(lblFolio)
        Me.TabPage4.Controls.Add(Id_cajaLabel)
        Me.TabPage4.Controls.Add(NombreLabel)
        Me.TabPage4.Controls.Add(SerieLabel)
        Me.TabPage4.Controls.Add(LocalLabel)
        Me.TabPage4.Controls.Add(Me.LocalCheckBox)
        Me.TabPage4.Controls.Add(CajonLabel)
        Me.TabPage4.Controls.Add(Me.CajonCheckBox)
        Me.TabPage4.Controls.Add(Abrir_cajonLabel)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1145, 286)
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
        'Iduser_abrioTextBox
        '
        Me.Iduser_abrioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "iduser_abrio", True))
        Me.Iduser_abrioTextBox.Enabled = False
        Me.Iduser_abrioTextBox.Location = New System.Drawing.Point(610, 98)
        Me.Iduser_abrioTextBox.Name = "Iduser_abrioTextBox"
        Me.Iduser_abrioTextBox.Size = New System.Drawing.Size(47, 20)
        Me.Iduser_abrioTextBox.TabIndex = 42
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
        'Abrir_cajonTextBox
        '
        Me.Abrir_cajonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "abrir_cajon", True))
        Me.Abrir_cajonTextBox.Enabled = False
        Me.Abrir_cajonTextBox.Location = New System.Drawing.Point(129, 146)
        Me.Abrir_cajonTextBox.Name = "Abrir_cajonTextBox"
        Me.Abrir_cajonTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Abrir_cajonTextBox.TabIndex = 17
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
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.comentarios)
        Me.TabPage1.Controls.Add(Me.lineastxt)
        Me.TabPage1.Controls.Add(Me.Id_unidadTextBox)
        Me.TabPage1.Controls.Add(Me.canttxt)
        Me.TabPage1.Controls.Add(Me.idtxt)
        Me.TabPage1.Controls.Add(Me.IvaTextBox)
        Me.TabPage1.Controls.Add(Me.PesoTextBox)
        Me.TabPage1.Controls.Add(Me.VentaTextBox)
        Me.TabPage1.Controls.Add(Me.CostoTextBox)
        Me.TabPage1.Controls.Add(Me.UnidadesTextBox)
        Me.TabPage1.Controls.Add(Me.FactorTextBox)
        Me.TabPage1.Controls.Add(Me.Id_productoTextBox)
        Me.TabPage1.Controls.Add(Me.UnidadTextBox)
        Me.TabPage1.Controls.Add(Me.DescripcionTextBox)
        Me.TabPage1.Controls.Add(Me.linea)
        Me.TabPage1.Controls.Add(Me.CodigoTextBox1)
        Me.TabPage1.Controls.Add(Me.grupo1)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Id_unidadLabel)
        Me.TabPage1.Controls.Add(IvaLabel)
        Me.TabPage1.Controls.Add(PesoLabel)
        Me.TabPage1.Controls.Add(VentaLabel)
        Me.TabPage1.Controls.Add(CostoLabel)
        Me.TabPage1.Controls.Add(UnidadesLabel)
        Me.TabPage1.Controls.Add(FactorLabel)
        Me.TabPage1.Controls.Add(CodigoLabel)
        Me.TabPage1.Controls.Add(Id_productoLabel)
        Me.TabPage1.Controls.Add(Me.Boton_salir)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1145, 286)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nota"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Location = New System.Drawing.Point(0, 41)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(806, 192)
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
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(3, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 15)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Comentarios :"
        '
        'comentarios
        '
        Me.comentarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.comentarios.Location = New System.Drawing.Point(101, 239)
        Me.comentarios.MaxLength = 200
        Me.comentarios.Multiline = True
        Me.comentarios.Name = "comentarios"
        Me.comentarios.Size = New System.Drawing.Size(512, 44)
        Me.comentarios.TabIndex = 34
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
        'Lista_de_ventasBindingSource
        '
        Me.Lista_de_ventasBindingSource.DataMember = "Lista_de_ventas"
        Me.Lista_de_ventasBindingSource.DataSource = Me.AdmintegralDataSet
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
        'CodigoTextBox1
        '
        Me.CodigoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Codigo", True))
        Me.CodigoTextBox1.Location = New System.Drawing.Point(315, 165)
        Me.CodigoTextBox1.Name = "CodigoTextBox1"
        Me.CodigoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox1.TabIndex = 40
        '
        'grupo1
        '
        Me.grupo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupo1.Controls.Add(Me.lblunidad)
        Me.grupo1.Controls.Add(Me.lblprod)
        Me.grupo1.Controls.Add(Me.dgvexistencia)
        Me.grupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo1.ForeColor = System.Drawing.Color.White
        Me.grupo1.Location = New System.Drawing.Point(847, 27)
        Me.grupo1.Name = "grupo1"
        Me.grupo1.Size = New System.Drawing.Size(288, 222)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvexistencia.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvexistencia.Location = New System.Drawing.Point(3, 69)
        Me.dgvexistencia.Name = "dgvexistencia"
        Me.dgvexistencia.RowHeadersVisible = False
        Me.dgvexistencia.Size = New System.Drawing.Size(282, 150)
        Me.dgvexistencia.TabIndex = 0
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
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage6.Controls.Add(Me.dgvpedido)
        Me.TabPage6.Controls.Add(Me.boton_agregar)
        Me.TabPage6.Controls.Add(Me.Label14)
        Me.TabPage6.Controls.Add(Me.filtropedido)
        Me.TabPage6.Controls.Add(Me.CodigoTextBox)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1145, 286)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Seleccionar"
        Me.TabPage6.UseVisualStyleBackColor = True
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
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_de_ventasBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(522, 122)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 41
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.AdmintegralDataSet
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
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar_Un_producto_menu, Me.btn_agregar})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.boton_puerta, Me.boton_guardar, Me.boton_repetir, Me.ToolStripButton3, Me.boton_reimprimir, Me.btn_refresh})
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
        'boton_repetir
        '
        Me.boton_repetir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_repetir.Image = Global.AdminTegral.My.Resources.Resources.Note_2
        Me.boton_repetir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_repetir.Name = "boton_repetir"
        Me.boton_repetir.Size = New System.Drawing.Size(36, 36)
        Me.boton_repetir.Text = "Recuperar Ticket/Factura"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.AdminTegral.My.Resources.Resources.Vista__50_
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'boton_reimprimir
        '
        Me.boton_reimprimir.Image = CType(resources.GetObject("boton_reimprimir.Image"), System.Drawing.Image)
        Me.boton_reimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_reimprimir.Name = "boton_reimprimir"
        Me.boton_reimprimir.Size = New System.Drawing.Size(107, 36)
        Me.boton_reimprimir.Text = "RE-Imprimir"
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
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'sql_documento_impresionTableAdapter
        '
        Me.sql_documento_impresionTableAdapter.ClearBeforeFill = True
        '
        'Tbl_almacenesTableAdapter
        '
        Me.Tbl_almacenesTableAdapter.ClearBeforeFill = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_refresh.Image = Global.AdminTegral.My.Resources.Resources.repeat
        Me.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(140, 36)
        Me.btn_refresh.Text = "Refrescar catalogo"
        '
        'traspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.Boton_salir
        Me.ClientSize = New System.Drawing.Size(1153, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "traspasos"
        Me.ShowIcon = False
        Me.Text = "Registro de Traspasos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sql_documento_impresionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dgvpedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Lista_de_ventasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_de_ventasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents Agregar_Un_producto_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeriesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.SeriesTableAdapter
    Friend WithEvents DiarioDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Log_cajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Log_cajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SuspenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BorrarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents BuscarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarUltimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_agregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boton_puerta As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_NC As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sql_documento_impresionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sql_documento_impresionTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documento_impresionTableAdapter
    Friend WithEvents ConsultarExistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosNegadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturaVariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents almacensalida As System.Windows.Forms.TextBox
    Friend WithEvents identrada As System.Windows.Forms.TextBox
    Friend WithEvents idsalida As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents boton_UPD_folios As System.Windows.Forms.Button
    Friend WithEvents Id_cajaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Iduser_abrioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Iduser_cerroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_contadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_valesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlmacenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemisionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_cajaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sucursaltxt As System.Windows.Forms.TextBox
    Friend WithEvents SerieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Abrir_cajonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HorainicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HoracierreDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LocalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CajonCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents comentarios As System.Windows.Forms.TextBox
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
    Friend WithEvents Id_productoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents linea As System.Windows.Forms.TextBox
    Friend WithEvents CodigoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grupo1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblunidad As System.Windows.Forms.Label
    Friend WithEvents lblprod As System.Windows.Forms.Label
    Friend WithEvents dgvexistencia As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Boton_salir As System.Windows.Forms.Button
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents boton_agregar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents filtropedido As System.Windows.Forms.TextBox
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dgvpedido As System.Windows.Forms.DataGridView
    Friend WithEvents folio As System.Windows.Forms.TextBox
    Friend WithEvents Quie As System.Windows.Forms.Label
    Friend WithEvents quien As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents puerta As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_repetir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_almacenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_almacenesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
    Friend WithEvents Almacenentrada As System.Windows.Forms.ComboBox
    Friend WithEvents boton_reimprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_refresh As System.Windows.Forms.ToolStripButton
End Class
