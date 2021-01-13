<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cat_provedores
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
        Dim RutaLabel As System.Windows.Forms.Label
        Dim LimiteLabel As System.Windows.Forms.Label
        Dim DesglosarLabel As System.Windows.Forms.Label
        Dim Id_agenteLabel As System.Windows.Forms.Label
        Dim ComercialLabel As System.Windows.Forms.Label
        Dim Cuenta_contableLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim DiasLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim RFCLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Id_directorioLabel As System.Windows.Forms.Label
        Dim ComentaiosLabel As System.Windows.Forms.Label
        Dim User_altaLabel As System.Windows.Forms.Label
        Dim Fecha_altaLabel As System.Windows.Forms.Label
        Dim LeyendaLabel As System.Windows.Forms.Label
        Dim FormaLabel As System.Windows.Forms.Label
        Dim MetodoLabel As System.Windows.Forms.Label
        Dim UsoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim EdoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cat_provedores))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.filtro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DirectorioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta_contable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EdoTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox1 = New System.Windows.Forms.TextBox()
        Me.UsoTextBox = New System.Windows.Forms.TextBox()
        Me.MetodoTextBox = New System.Windows.Forms.TextBox()
        Me.FormaTextBox = New System.Windows.Forms.TextBox()
        Me.LeyendaTextBox = New System.Windows.Forms.TextBox()
        Me.ComentaiosTextBox = New System.Windows.Forms.TextBox()
        Me.CodigopostalTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.RFCTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.User_alta = New System.Windows.Forms.TextBox()
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.RFCTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WebTextBox = New System.Windows.Forms.TextBox()
        Me.DiasTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.Cuenta_contableTextBox = New System.Windows.Forms.TextBox()
        Me.ComercialTextBox = New System.Windows.Forms.TextBox()
        Me.Id_agenteTextBox = New System.Windows.Forms.TextBox()
        Me.LimiteTextBox = New System.Windows.Forms.TextBox()
        Me.RutaTextBox = New System.Windows.Forms.TextBox()
        Me.formacombo = New System.Windows.Forms.ComboBox()
        Me.Fei_metodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.ListasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btp_crear_fei = New System.Windows.Forms.Button()
        Me.fecha_alta = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.suspendido = New System.Windows.Forms.Label()
        Me.DesglosarCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.exml = New System.Windows.Forms.TextBox()
        Me.epdf = New System.Windows.Forms.TextBox()
        Me.eemail = New System.Windows.Forms.TextBox()
        Me.Sql_documentos_clientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgvfolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvserie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DirectorioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DirectorioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btn_fei = New System.Windows.Forms.ToolStripButton()
        Me.Tool_verfacturas = New System.Windows.Forms.ToolStripButton()
        Me.Boton_salir = New System.Windows.Forms.Button()
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter()
        Me.AgentesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter()
        Me.ListasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter()
        Me.Fei_metodosTableAdapter = New AdminTegral.feiDatasetTableAdapters.fei_metodosTableAdapter()
        Me.Sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter()
        RutaLabel = New System.Windows.Forms.Label()
        LimiteLabel = New System.Windows.Forms.Label()
        DesglosarLabel = New System.Windows.Forms.Label()
        Id_agenteLabel = New System.Windows.Forms.Label()
        ComercialLabel = New System.Windows.Forms.Label()
        Cuenta_contableLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        DiasLabel = New System.Windows.Forms.Label()
        WebLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        RFCLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Id_directorioLabel = New System.Windows.Forms.Label()
        ComentaiosLabel = New System.Windows.Forms.Label()
        User_altaLabel = New System.Windows.Forms.Label()
        Fecha_altaLabel = New System.Windows.Forms.Label()
        LeyendaLabel = New System.Windows.Forms.Label()
        FormaLabel = New System.Windows.Forms.Label()
        MetodoLabel = New System.Windows.Forms.Label()
        UsoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        EdoLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DirectorioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Fei_metodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DirectorioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'RutaLabel
        '
        RutaLabel.AutoSize = True
        RutaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RutaLabel.Location = New System.Drawing.Point(553, 158)
        RutaLabel.Name = "RutaLabel"
        RutaLabel.Size = New System.Drawing.Size(39, 16)
        RutaLabel.TabIndex = 77
        RutaLabel.Text = "Ruta:"
        '
        'LimiteLabel
        '
        LimiteLabel.AutoSize = True
        LimiteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LimiteLabel.Location = New System.Drawing.Point(43, 269)
        LimiteLabel.Name = "LimiteLabel"
        LimiteLabel.Size = New System.Drawing.Size(46, 16)
        LimiteLabel.TabIndex = 75
        LimiteLabel.Text = "Limite:"
        '
        'DesglosarLabel
        '
        DesglosarLabel.AutoSize = True
        DesglosarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesglosarLabel.Location = New System.Drawing.Point(231, 244)
        DesglosarLabel.Name = "DesglosarLabel"
        DesglosarLabel.Size = New System.Drawing.Size(74, 16)
        DesglosarLabel.TabIndex = 73
        DesglosarLabel.Text = "Desglosar:"
        '
        'Id_agenteLabel
        '
        Id_agenteLabel.AutoSize = True
        Id_agenteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_agenteLabel.Location = New System.Drawing.Point(525, 131)
        Id_agenteLabel.Name = "Id_agenteLabel"
        Id_agenteLabel.Size = New System.Drawing.Size(67, 16)
        Id_agenteLabel.TabIndex = 71
        Id_agenteLabel.Text = "id agente:"
        '
        'ComercialLabel
        '
        ComercialLabel.AutoSize = True
        ComercialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComercialLabel.Location = New System.Drawing.Point(19, 318)
        ComercialLabel.Name = "ComercialLabel"
        ComercialLabel.Size = New System.Drawing.Size(70, 16)
        ComercialLabel.TabIndex = 69
        ComercialLabel.Text = "comercial:"
        '
        'Cuenta_contableLabel
        '
        Cuenta_contableLabel.AutoSize = True
        Cuenta_contableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cuenta_contableLabel.Location = New System.Drawing.Point(505, 104)
        Cuenta_contableLabel.Name = "Cuenta_contableLabel"
        Cuenta_contableLabel.Size = New System.Drawing.Size(89, 16)
        Cuenta_contableLabel.TabIndex = 67
        Cuenta_contableLabel.Text = "Cta. contable:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IvaLabel.Location = New System.Drawing.Point(143, 244)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(29, 16)
        IvaLabel.TabIndex = 65
        IvaLabel.Text = "iva:"
        '
        'DiasLabel
        '
        DiasLabel.AutoSize = True
        DiasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiasLabel.Location = New System.Drawing.Point(47, 244)
        DiasLabel.Name = "DiasLabel"
        DiasLabel.Size = New System.Drawing.Size(39, 16)
        DiasLabel.TabIndex = 63
        DiasLabel.Text = "Dias:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WebLabel.Location = New System.Drawing.Point(46, 294)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(40, 16)
        WebLabel.TabIndex = 61
        WebLabel.Text = "Web:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(559, 41)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 16)
        EmailLabel.TabIndex = 59
        EmailLabel.Text = "Email:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CelularLabel.Location = New System.Drawing.Point(806, 14)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(53, 16)
        CelularLabel.TabIndex = 57
        CelularLabel.Text = "Celular:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(539, 17)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(65, 16)
        TelefonoLabel.TabIndex = 55
        TelefonoLabel.Text = "Telefono:"
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Location = New System.Drawing.Point(220, 16)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(31, 13)
        RFCLabel.TabIndex = 53
        RFCLabel.Text = "RFC:"
        AddHandler RFCLabel.Click, AddressOf Me.RFCLabel_Click
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(65, 158)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 51
        CPLabel.Text = "CP:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(31, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(60, 16)
        NombreLabel.TabIndex = 41
        NombreLabel.Text = "Nombre:"
        '
        'Id_directorioLabel
        '
        Id_directorioLabel.AutoSize = True
        Id_directorioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_directorioLabel.Location = New System.Drawing.Point(10, 18)
        Id_directorioLabel.Name = "Id_directorioLabel"
        Id_directorioLabel.Size = New System.Drawing.Size(81, 16)
        Id_directorioLabel.TabIndex = 37
        Id_directorioLabel.Text = "id directorio:"
        '
        'ComentaiosLabel
        '
        ComentaiosLabel.AutoSize = True
        ComentaiosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentaiosLabel.Location = New System.Drawing.Point(6, 345)
        ComentaiosLabel.Name = "ComentaiosLabel"
        ComentaiosLabel.Size = New System.Drawing.Size(83, 16)
        ComentaiosLabel.TabIndex = 79
        ComentaiosLabel.Text = "Comentaios:"
        '
        'User_altaLabel
        '
        User_altaLabel.AutoSize = True
        User_altaLabel.Location = New System.Drawing.Point(843, 210)
        User_altaLabel.Name = "User_altaLabel"
        User_altaLabel.Size = New System.Drawing.Size(32, 13)
        User_altaLabel.TabIndex = 81
        User_altaLabel.Text = "User:"
        '
        'Fecha_altaLabel
        '
        Fecha_altaLabel.AutoSize = True
        Fecha_altaLabel.Location = New System.Drawing.Point(534, 211)
        Fecha_altaLabel.Name = "Fecha_altaLabel"
        Fecha_altaLabel.Size = New System.Drawing.Size(57, 13)
        Fecha_altaLabel.TabIndex = 82
        Fecha_altaLabel.Text = "fecha alta:"
        '
        'LeyendaLabel
        '
        LeyendaLabel.AutoSize = True
        LeyendaLabel.Location = New System.Drawing.Point(498, 182)
        LeyendaLabel.Name = "LeyendaLabel"
        LeyendaLabel.Size = New System.Drawing.Size(94, 13)
        LeyendaLabel.TabIndex = 98
        LeyendaLabel.Text = "% Pago oportuno :"
        '
        'FormaLabel
        '
        FormaLabel.AutoSize = True
        FormaLabel.Location = New System.Drawing.Point(47, 184)
        FormaLabel.Name = "FormaLabel"
        FormaLabel.Size = New System.Drawing.Size(36, 13)
        FormaLabel.TabIndex = 104
        FormaLabel.Text = "forma:"
        '
        'MetodoLabel
        '
        MetodoLabel.AutoSize = True
        MetodoLabel.Location = New System.Drawing.Point(44, 210)
        MetodoLabel.Name = "MetodoLabel"
        MetodoLabel.Size = New System.Drawing.Size(45, 13)
        MetodoLabel.TabIndex = 105
        MetodoLabel.Text = "metodo:"
        '
        'UsoLabel
        '
        UsoLabel.AutoSize = True
        UsoLabel.Location = New System.Drawing.Point(139, 213)
        UsoLabel.Name = "UsoLabel"
        UsoLabel.Size = New System.Drawing.Size(27, 13)
        UsoLabel.TabIndex = 106
        UsoLabel.Text = "uso:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(28, 68)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 107
        DireccionLabel.Text = "Direccion:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(38, 94)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(45, 13)
        ColoniaLabel.TabIndex = 108
        ColoniaLabel.Text = "Colonia:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(40, 120)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 109
        CiudadLabel.Text = "Ciudad:"
        '
        'EdoLabel
        '
        EdoLabel.AutoSize = True
        EdoLabel.Location = New System.Drawing.Point(234, 120)
        EdoLabel.Name = "EdoLabel"
        EdoLabel.Size = New System.Drawing.Size(29, 13)
        EdoLabel.TabIndex = 110
        EdoLabel.Text = "Edo:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1036, 557)
        Me.SplitContainer1.SplitterDistance = 46
        Me.SplitContainer1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1036, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Catalogo de Productos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DirectorioBindingNavigator)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Boton_salir)
        Me.SplitContainer2.Size = New System.Drawing.Size(1036, 507)
        Me.SplitContainer2.SplitterDistance = 454
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer3.Panel1.Controls.Add(Me.filtro)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.id)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1036, 454)
        Me.SplitContainer3.SplitterDistance = 28
        Me.SplitContainer3.TabIndex = 0
        '
        'filtro
        '
        Me.filtro.BackColor = System.Drawing.Color.LightSteelBlue
        Me.filtro.Location = New System.Drawing.Point(205, 2)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(237, 20)
        Me.filtro.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filtrar :"
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.LightSteelBlue
        Me.id.Location = New System.Drawing.Point(79, 2)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(56, 20)
        Me.id.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar  ID :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1036, 422)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DirectorioDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1028, 396)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DirectorioDataGridView
        '
        Me.DirectorioDataGridView.AllowUserToAddRows = False
        Me.DirectorioDataGridView.AllowUserToOrderColumns = True
        Me.DirectorioDataGridView.AutoGenerateColumns = False
        Me.DirectorioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DirectorioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.comercial, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.dgvemail, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn12, Me.cuenta_contable})
        Me.DirectorioDataGridView.DataSource = Me.DirectorioBindingSource
        Me.DirectorioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DirectorioDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.DirectorioDataGridView.Name = "DirectorioDataGridView"
        Me.DirectorioDataGridView.RowHeadersVisible = False
        Me.DirectorioDataGridView.Size = New System.Drawing.Size(1022, 390)
        Me.DirectorioDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_directorio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "tipo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "tipo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'comercial
        '
        Me.comercial.DataPropertyName = "comercial"
        Me.comercial.HeaderText = "comercial"
        Me.comercial.Name = "comercial"
        Me.comercial.Width = 77
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Colonia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Colonia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 67
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Edo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Edo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 51
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CP"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 46
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "RFC"
        Me.DataGridViewTextBoxColumn8.HeaderText = "RFC"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 53
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 74
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Celular"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Celular"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 64
        '
        'dgvemail
        '
        Me.dgvemail.DataPropertyName = "email"
        Me.dgvemail.HeaderText = "email"
        Me.dgvemail.Name = "dgvemail"
        Me.dgvemail.Width = 56
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Limite"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Limite"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 59
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Dias"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Dias"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 53
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "iva"
        Me.DataGridViewTextBoxColumn16.HeaderText = "iva"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 46
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Web"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Web"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 55
        '
        'cuenta_contable
        '
        Me.cuenta_contable.DataPropertyName = "cuenta_contable"
        Me.cuenta_contable.HeaderText = "cuenta_contable"
        Me.cuenta_contable.Name = "cuenta_contable"
        Me.cuenta_contable.Width = 112
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "AdmintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage2.Controls.Add(EdoLabel)
        Me.TabPage2.Controls.Add(Me.EdoTextBox)
        Me.TabPage2.Controls.Add(Me.CiudadTextBox)
        Me.TabPage2.Controls.Add(Me.ColoniaTextBox)
        Me.TabPage2.Controls.Add(Me.DireccionTextBox1)
        Me.TabPage2.Controls.Add(Me.UsoTextBox)
        Me.TabPage2.Controls.Add(Me.MetodoTextBox)
        Me.TabPage2.Controls.Add(Me.FormaTextBox)
        Me.TabPage2.Controls.Add(Me.LeyendaTextBox)
        Me.TabPage2.Controls.Add(Me.ComentaiosTextBox)
        Me.TabPage2.Controls.Add(Me.CodigopostalTextBox)
        Me.TabPage2.Controls.Add(Me.EstadoTextBox)
        Me.TabPage2.Controls.Add(Me.LocalidadTextBox)
        Me.TabPage2.Controls.Add(Me.ColoniaTextBox1)
        Me.TabPage2.Controls.Add(Me.EmailTextBox1)
        Me.TabPage2.Controls.Add(Me.RFCTextBox1)
        Me.TabPage2.Controls.Add(Me.NombreTextBox1)
        Me.TabPage2.Controls.Add(Me.IdTextBox)
        Me.TabPage2.Controls.Add(Me.User_alta)
        Me.TabPage2.Controls.Add(Me.Id_directorioTextBox)
        Me.TabPage2.Controls.Add(Me.TipoTextBox)
        Me.TabPage2.Controls.Add(Me.NombreTextBox)
        Me.TabPage2.Controls.Add(Me.DireccionTextBox)
        Me.TabPage2.Controls.Add(Me.CPTextBox)
        Me.TabPage2.Controls.Add(Me.RFCTextBox)
        Me.TabPage2.Controls.Add(Me.TelefonoTextBox)
        Me.TabPage2.Controls.Add(Me.CelularTextBox)
        Me.TabPage2.Controls.Add(Me.EmailTextBox)
        Me.TabPage2.Controls.Add(Me.WebTextBox)
        Me.TabPage2.Controls.Add(Me.DiasTextBox)
        Me.TabPage2.Controls.Add(Me.IvaTextBox)
        Me.TabPage2.Controls.Add(Me.Cuenta_contableTextBox)
        Me.TabPage2.Controls.Add(Me.ComercialTextBox)
        Me.TabPage2.Controls.Add(Me.Id_agenteTextBox)
        Me.TabPage2.Controls.Add(Me.LimiteTextBox)
        Me.TabPage2.Controls.Add(Me.RutaTextBox)
        Me.TabPage2.Controls.Add(CiudadLabel)
        Me.TabPage2.Controls.Add(ColoniaLabel)
        Me.TabPage2.Controls.Add(DireccionLabel)
        Me.TabPage2.Controls.Add(UsoLabel)
        Me.TabPage2.Controls.Add(MetodoLabel)
        Me.TabPage2.Controls.Add(FormaLabel)
        Me.TabPage2.Controls.Add(Me.formacombo)
        Me.TabPage2.Controls.Add(Me.DescripcionComboBox)
        Me.TabPage2.Controls.Add(Me.NombreComboBox)
        Me.TabPage2.Controls.Add(LeyendaLabel)
        Me.TabPage2.Controls.Add(Me.btp_crear_fei)
        Me.TabPage2.Controls.Add(Fecha_altaLabel)
        Me.TabPage2.Controls.Add(Me.fecha_alta)
        Me.TabPage2.Controls.Add(User_altaLabel)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(ComentaiosLabel)
        Me.TabPage2.Controls.Add(Me.suspendido)
        Me.TabPage2.Controls.Add(Id_directorioLabel)
        Me.TabPage2.Controls.Add(NombreLabel)
        Me.TabPage2.Controls.Add(CPLabel)
        Me.TabPage2.Controls.Add(RFCLabel)
        Me.TabPage2.Controls.Add(TelefonoLabel)
        Me.TabPage2.Controls.Add(CelularLabel)
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.Controls.Add(WebLabel)
        Me.TabPage2.Controls.Add(DiasLabel)
        Me.TabPage2.Controls.Add(IvaLabel)
        Me.TabPage2.Controls.Add(Cuenta_contableLabel)
        Me.TabPage2.Controls.Add(ComercialLabel)
        Me.TabPage2.Controls.Add(Id_agenteLabel)
        Me.TabPage2.Controls.Add(DesglosarLabel)
        Me.TabPage2.Controls.Add(Me.DesglosarCheckBox)
        Me.TabPage2.Controls.Add(LimiteLabel)
        Me.TabPage2.Controls.Add(RutaLabel)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1028, 396)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ficha"
        '
        'EdoTextBox
        '
        Me.EdoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Edo", True))
        Me.EdoTextBox.Location = New System.Drawing.Point(269, 117)
        Me.EdoTextBox.Name = "EdoTextBox"
        Me.EdoTextBox.Size = New System.Drawing.Size(143, 20)
        Me.EdoTextBox.TabIndex = 111
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(89, 117)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(127, 20)
        Me.CiudadTextBox.TabIndex = 110
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(89, 91)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(323, 20)
        Me.ColoniaTextBox.TabIndex = 109
        '
        'DireccionTextBox1
        '
        Me.DireccionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Direccion", True))
        Me.DireccionTextBox1.Location = New System.Drawing.Point(89, 65)
        Me.DireccionTextBox1.Name = "DireccionTextBox1"
        Me.DireccionTextBox1.Size = New System.Drawing.Size(321, 20)
        Me.DireccionTextBox1.TabIndex = 108
        '
        'UsoTextBox
        '
        Me.UsoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "uso", True))
        Me.UsoTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsoTextBox.Location = New System.Drawing.Point(172, 210)
        Me.UsoTextBox.Name = "UsoTextBox"
        Me.UsoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsoTextBox.TabIndex = 107
        '
        'MetodoTextBox
        '
        Me.MetodoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "metodo", True))
        Me.MetodoTextBox.ForeColor = System.Drawing.Color.Black
        Me.MetodoTextBox.Location = New System.Drawing.Point(89, 207)
        Me.MetodoTextBox.Name = "MetodoTextBox"
        Me.MetodoTextBox.Size = New System.Drawing.Size(44, 20)
        Me.MetodoTextBox.TabIndex = 106
        '
        'FormaTextBox
        '
        Me.FormaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "forma", True))
        Me.FormaTextBox.ForeColor = System.Drawing.Color.Black
        Me.FormaTextBox.Location = New System.Drawing.Point(89, 181)
        Me.FormaTextBox.Name = "FormaTextBox"
        Me.FormaTextBox.Size = New System.Drawing.Size(44, 20)
        Me.FormaTextBox.TabIndex = 105
        '
        'LeyendaTextBox
        '
        Me.LeyendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "leyenda", True))
        Me.LeyendaTextBox.ForeColor = System.Drawing.Color.Black
        Me.LeyendaTextBox.Location = New System.Drawing.Point(597, 179)
        Me.LeyendaTextBox.Name = "LeyendaTextBox"
        Me.LeyendaTextBox.Size = New System.Drawing.Size(39, 20)
        Me.LeyendaTextBox.TabIndex = 26
        '
        'ComentaiosTextBox
        '
        Me.ComentaiosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Comentarios", True))
        Me.ComentaiosTextBox.ForeColor = System.Drawing.Color.Black
        Me.ComentaiosTextBox.Location = New System.Drawing.Point(89, 338)
        Me.ComentaiosTextBox.MaxLength = 100
        Me.ComentaiosTextBox.Multiline = True
        Me.ComentaiosTextBox.Name = "ComentaiosTextBox"
        Me.ComentaiosTextBox.Size = New System.Drawing.Size(407, 52)
        Me.ComentaiosTextBox.TabIndex = 22
        '
        'CodigopostalTextBox
        '
        Me.CodigopostalTextBox.Location = New System.Drawing.Point(375, 345)
        Me.CodigopostalTextBox.Name = "CodigopostalTextBox"
        Me.CodigopostalTextBox.Size = New System.Drawing.Size(29, 20)
        Me.CodigopostalTextBox.TabIndex = 98
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.Location = New System.Drawing.Point(340, 345)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(29, 20)
        Me.EstadoTextBox.TabIndex = 97
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.Location = New System.Drawing.Point(305, 345)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(29, 20)
        Me.LocalidadTextBox.TabIndex = 95
        '
        'ColoniaTextBox1
        '
        Me.ColoniaTextBox1.Location = New System.Drawing.Point(276, 345)
        Me.ColoniaTextBox1.Name = "ColoniaTextBox1"
        Me.ColoniaTextBox1.Size = New System.Drawing.Size(29, 20)
        Me.ColoniaTextBox1.TabIndex = 94
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.BackColor = System.Drawing.Color.White
        Me.EmailTextBox1.ForeColor = System.Drawing.Color.Black
        Me.EmailTextBox1.Location = New System.Drawing.Point(608, 39)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(362, 20)
        Me.EmailTextBox1.TabIndex = 15
        '
        'RFCTextBox1
        '
        Me.RFCTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RFCTextBox1.Location = New System.Drawing.Point(420, 9)
        Me.RFCTextBox1.Name = "RFCTextBox1"
        Me.RFCTextBox1.Size = New System.Drawing.Size(87, 20)
        Me.RFCTextBox1.TabIndex = 87
        Me.RFCTextBox1.Visible = False
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.Location = New System.Drawing.Point(245, 345)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(29, 20)
        Me.NombreTextBox1.TabIndex = 86
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(344, 372)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(45, 20)
        Me.IdTextBox.TabIndex = 85
        '
        'User_alta
        '
        Me.User_alta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "user_alta", True))
        Me.User_alta.ForeColor = System.Drawing.Color.Black
        Me.User_alta.Location = New System.Drawing.Point(882, 207)
        Me.User_alta.Name = "User_alta"
        Me.User_alta.Size = New System.Drawing.Size(71, 20)
        Me.User_alta.TabIndex = 82
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "id_directorio", True))
        Me.Id_directorioTextBox.ForeColor = System.Drawing.Color.Black
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(91, 14)
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.ReadOnly = True
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(44, 20)
        Me.Id_directorioTextBox.TabIndex = 0
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "tipo", True))
        Me.TipoTextBox.ForeColor = System.Drawing.Color.Black
        Me.TipoTextBox.Location = New System.Drawing.Point(141, 14)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.ReadOnly = True
        Me.TipoTextBox.Size = New System.Drawing.Size(20, 20)
        Me.TipoTextBox.TabIndex = 40
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BackColor = System.Drawing.Color.White
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.ForeColor = System.Drawing.Color.Black
        Me.NombreTextBox.Location = New System.Drawing.Point(89, 37)
        Me.NombreTextBox.MaxLength = 75
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(323, 22)
        Me.NombreTextBox.TabIndex = 2
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.BackColor = System.Drawing.Color.White
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.ForeColor = System.Drawing.Color.White
        Me.DireccionTextBox.Location = New System.Drawing.Point(187, 357)
        Me.DireccionTextBox.MaxLength = 75
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(62, 22)
        Me.DireccionTextBox.TabIndex = 49
        '
        'CPTextBox
        '
        Me.CPTextBox.BackColor = System.Drawing.Color.White
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "CP", True))
        Me.CPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPTextBox.ForeColor = System.Drawing.Color.Black
        Me.CPTextBox.Location = New System.Drawing.Point(89, 155)
        Me.CPTextBox.MaxLength = 5
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(111, 22)
        Me.CPTextBox.TabIndex = 12
        '
        'RFCTextBox
        '
        Me.RFCTextBox.BackColor = System.Drawing.Color.White
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "RFC", True))
        Me.RFCTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RFCTextBox.ForeColor = System.Drawing.Color.Black
        Me.RFCTextBox.Location = New System.Drawing.Point(253, 12)
        Me.RFCTextBox.MaxLength = 14
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.Size = New System.Drawing.Size(157, 22)
        Me.RFCTextBox.TabIndex = 1
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BackColor = System.Drawing.Color.White
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Telefono", True))
        Me.TelefonoTextBox.ForeColor = System.Drawing.Color.Black
        Me.TelefonoTextBox.Location = New System.Drawing.Point(610, 13)
        Me.TelefonoTextBox.MaxLength = 15
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(166, 20)
        Me.TelefonoTextBox.TabIndex = 13
        '
        'CelularTextBox
        '
        Me.CelularTextBox.BackColor = System.Drawing.Color.White
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Celular", True))
        Me.CelularTextBox.ForeColor = System.Drawing.Color.Black
        Me.CelularTextBox.Location = New System.Drawing.Point(859, 13)
        Me.CelularTextBox.MaxLength = 15
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(111, 20)
        Me.CelularTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(608, 38)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(24, 20)
        Me.EmailTextBox.TabIndex = 60
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Web", True))
        Me.WebTextBox.ForeColor = System.Drawing.Color.Black
        Me.WebTextBox.Location = New System.Drawing.Point(89, 291)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(407, 20)
        Me.WebTextBox.TabIndex = 20
        '
        'DiasTextBox
        '
        Me.DiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Dias", True))
        Me.DiasTextBox.ForeColor = System.Drawing.Color.Black
        Me.DiasTextBox.Location = New System.Drawing.Point(89, 242)
        Me.DiasTextBox.MaxLength = 3
        Me.DiasTextBox.Name = "DiasTextBox"
        Me.DiasTextBox.Size = New System.Drawing.Size(39, 20)
        Me.DiasTextBox.TabIndex = 16
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "iva", True))
        Me.IvaTextBox.ForeColor = System.Drawing.Color.Black
        Me.IvaTextBox.Location = New System.Drawing.Point(177, 242)
        Me.IvaTextBox.MaxLength = 2
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(39, 20)
        Me.IvaTextBox.TabIndex = 17
        '
        'Cuenta_contableTextBox
        '
        Me.Cuenta_contableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "cuenta_contable", True))
        Me.Cuenta_contableTextBox.ForeColor = System.Drawing.Color.Black
        Me.Cuenta_contableTextBox.Location = New System.Drawing.Point(597, 102)
        Me.Cuenta_contableTextBox.MaxLength = 20
        Me.Cuenta_contableTextBox.Name = "Cuenta_contableTextBox"
        Me.Cuenta_contableTextBox.Size = New System.Drawing.Size(162, 20)
        Me.Cuenta_contableTextBox.TabIndex = 23
        '
        'ComercialTextBox
        '
        Me.ComercialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "comercial", True))
        Me.ComercialTextBox.ForeColor = System.Drawing.Color.Black
        Me.ComercialTextBox.Location = New System.Drawing.Point(89, 315)
        Me.ComercialTextBox.MaxLength = 50
        Me.ComercialTextBox.Name = "ComercialTextBox"
        Me.ComercialTextBox.Size = New System.Drawing.Size(407, 20)
        Me.ComercialTextBox.TabIndex = 21
        '
        'Id_agenteTextBox
        '
        Me.Id_agenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "id_agente", True))
        Me.Id_agenteTextBox.ForeColor = System.Drawing.Color.Black
        Me.Id_agenteTextBox.Location = New System.Drawing.Point(597, 129)
        Me.Id_agenteTextBox.MaxLength = 3
        Me.Id_agenteTextBox.Name = "Id_agenteTextBox"
        Me.Id_agenteTextBox.Size = New System.Drawing.Size(39, 20)
        Me.Id_agenteTextBox.TabIndex = 24
        '
        'LimiteTextBox
        '
        Me.LimiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Limite", True))
        Me.LimiteTextBox.ForeColor = System.Drawing.Color.Black
        Me.LimiteTextBox.Location = New System.Drawing.Point(89, 267)
        Me.LimiteTextBox.MaxLength = 7
        Me.LimiteTextBox.Name = "LimiteTextBox"
        Me.LimiteTextBox.Size = New System.Drawing.Size(104, 20)
        Me.LimiteTextBox.TabIndex = 19
        '
        'RutaTextBox
        '
        Me.RutaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Ruta", True))
        Me.RutaTextBox.ForeColor = System.Drawing.Color.Black
        Me.RutaTextBox.Location = New System.Drawing.Point(597, 155)
        Me.RutaTextBox.MaxLength = 3
        Me.RutaTextBox.Name = "RutaTextBox"
        Me.RutaTextBox.Size = New System.Drawing.Size(39, 20)
        Me.RutaTextBox.TabIndex = 25
        '
        'formacombo
        '
        Me.formacombo.DataSource = Me.Fei_metodosBindingSource
        Me.formacombo.DisplayMember = "metodo"
        Me.formacombo.ForeColor = System.Drawing.Color.Black
        Me.formacombo.FormattingEnabled = True
        Me.formacombo.Location = New System.Drawing.Point(139, 180)
        Me.formacombo.Name = "formacombo"
        Me.formacombo.Size = New System.Drawing.Size(133, 21)
        Me.formacombo.TabIndex = 104
        Me.formacombo.ValueMember = "codigo"
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DirectorioBindingSource, "Ruta", True))
        Me.DescripcionComboBox.DataSource = Me.ListasBindingSource
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.ForeColor = System.Drawing.Color.Black
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(642, 156)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(311, 21)
        Me.DescripcionComboBox.TabIndex = 101
        Me.DescripcionComboBox.ValueMember = "id"
        '
        'ListasBindingSource
        '
        Me.ListasBindingSource.DataMember = "Listas"
        Me.ListasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DirectorioBindingSource, "id_agente", True))
        Me.NombreComboBox.DataSource = Me.AgentesBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.ForeColor = System.Drawing.Color.Black
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(642, 129)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(311, 21)
        Me.NombreComboBox.TabIndex = 100
        Me.NombreComboBox.ValueMember = "id_agente"
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'btp_crear_fei
        '
        Me.btp_crear_fei.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btp_crear_fei.Enabled = False
        Me.btp_crear_fei.Location = New System.Drawing.Point(922, 289)
        Me.btp_crear_fei.Name = "btp_crear_fei"
        Me.btp_crear_fei.Size = New System.Drawing.Size(48, 23)
        Me.btp_crear_fei.TabIndex = 84
        Me.btp_crear_fei.Text = "Crear registro F.E."
        Me.btp_crear_fei.UseVisualStyleBackColor = True
        Me.btp_crear_fei.Visible = False
        '
        'fecha_alta
        '
        Me.fecha_alta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DirectorioBindingSource, "fecha_alta", True))
        Me.fecha_alta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_alta.Location = New System.Drawing.Point(597, 207)
        Me.fecha_alta.Name = "fecha_alta"
        Me.fecha_alta.Size = New System.Drawing.Size(83, 20)
        Me.fecha_alta.TabIndex = 83
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(167, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 21)
        Me.Button3.TabIndex = 81
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'suspendido
        '
        Me.suspendido.AutoSize = True
        Me.suspendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suspendido.ForeColor = System.Drawing.Color.Red
        Me.suspendido.Location = New System.Drawing.Point(737, 200)
        Me.suspendido.Name = "suspendido"
        Me.suspendido.Size = New System.Drawing.Size(126, 25)
        Me.suspendido.TabIndex = 79
        Me.suspendido.Text = "Suspendido"
        '
        'DesglosarCheckBox
        '
        Me.DesglosarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DirectorioBindingSource, "Desglosar", True))
        Me.DesglosarCheckBox.ForeColor = System.Drawing.Color.Black
        Me.DesglosarCheckBox.Location = New System.Drawing.Point(311, 243)
        Me.DesglosarCheckBox.Name = "DesglosarCheckBox"
        Me.DesglosarCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.DesglosarCheckBox.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(834, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 34)
        Me.Panel1.TabIndex = 37
        Me.Panel1.Visible = False
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(8, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(84, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1028, 396)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Relacion de Facturas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.Button6)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Button5)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer4.Panel2.Controls.Add(Me.exml)
        Me.SplitContainer4.Panel2.Controls.Add(Me.epdf)
        Me.SplitContainer4.Panel2.Controls.Add(Me.eemail)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Sql_documentos_clientesDataGridView)
        Me.SplitContainer4.Size = New System.Drawing.Size(1022, 390)
        Me.SplitContainer4.SplitterDistance = 58
        Me.SplitContainer4.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(525, 265)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "ver pdf"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(525, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Mandar por correo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Archivos :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-Mail"
        '
        'exml
        '
        Me.exml.Enabled = False
        Me.exml.Location = New System.Drawing.Point(72, 255)
        Me.exml.Name = "exml"
        Me.exml.Size = New System.Drawing.Size(433, 20)
        Me.exml.TabIndex = 3
        '
        'epdf
        '
        Me.epdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.epdf.Enabled = False
        Me.epdf.Location = New System.Drawing.Point(72, 270)
        Me.epdf.Name = "epdf"
        Me.epdf.Size = New System.Drawing.Size(433, 20)
        Me.epdf.TabIndex = 2
        '
        'eemail
        '
        Me.eemail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.eemail.Location = New System.Drawing.Point(72, 244)
        Me.eemail.Name = "eemail"
        Me.eemail.Size = New System.Drawing.Size(433, 20)
        Me.eemail.TabIndex = 1
        '
        'Sql_documentos_clientesDataGridView
        '
        Me.Sql_documentos_clientesDataGridView.AllowUserToAddRows = False
        Me.Sql_documentos_clientesDataGridView.AllowUserToDeleteRows = False
        Me.Sql_documentos_clientesDataGridView.AutoGenerateColumns = False
        Me.Sql_documentos_clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_documentos_clientesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_documentos_clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_documentos_clientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvfolio, Me.dgvserie, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40})
        Me.Sql_documentos_clientesDataGridView.DataSource = Me.Sql_documentos_clientesBindingSource
        Me.Sql_documentos_clientesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_documentos_clientesDataGridView.Name = "Sql_documentos_clientesDataGridView"
        Me.Sql_documentos_clientesDataGridView.ReadOnly = True
        Me.Sql_documentos_clientesDataGridView.RowHeadersVisible = False
        Me.Sql_documentos_clientesDataGridView.Size = New System.Drawing.Size(996, 202)
        Me.Sql_documentos_clientesDataGridView.TabIndex = 0
        '
        'dgvfolio
        '
        Me.dgvfolio.DataPropertyName = "Folio"
        Me.dgvfolio.HeaderText = "Folio"
        Me.dgvfolio.Name = "dgvfolio"
        Me.dgvfolio.ReadOnly = True
        Me.dgvfolio.Width = 54
        '
        'dgvserie
        '
        Me.dgvserie.DataPropertyName = "serie"
        Me.dgvserie.HeaderText = "serie"
        Me.dgvserie.Name = "dgvserie"
        Me.dgvserie.ReadOnly = True
        Me.dgvserie.Width = 54
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 69
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "factura"
        Me.DataGridViewTextBoxColumn24.HeaderText = "factura"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 65
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "fechafactura"
        Me.DataGridViewTextBoxColumn25.HeaderText = "fechafactura"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 92
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Importe"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Width = 67
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "id_cartera"
        Me.DataGridViewTextBoxColumn39.HeaderText = "id_cartera"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Width = 79
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn40.HeaderText = "status"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Width = 60
        '
        'Sql_documentos_clientesBindingSource
        '
        Me.Sql_documentos_clientesBindingSource.DataMember = "sql_documentos_clientes"
        Me.Sql_documentos_clientesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'DirectorioBindingNavigator
        '
        Me.DirectorioBindingNavigator.AddNewItem = Nothing
        Me.DirectorioBindingNavigator.BindingSource = Me.DirectorioBindingSource
        Me.DirectorioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DirectorioBindingNavigator.DeleteItem = Nothing
        Me.DirectorioBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.DirectorioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.DirectorioBindingNavigatorSaveItem, Me.btn_fei, Me.Tool_verfacturas})
        Me.DirectorioBindingNavigator.Location = New System.Drawing.Point(13, 9)
        Me.DirectorioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DirectorioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DirectorioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DirectorioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DirectorioBindingNavigator.Name = "DirectorioBindingNavigator"
        Me.DirectorioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DirectorioBindingNavigator.Size = New System.Drawing.Size(530, 25)
        Me.DirectorioBindingNavigator.TabIndex = 2
        Me.DirectorioBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.add
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'DirectorioBindingNavigatorSaveItem
        '
        Me.DirectorioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DirectorioBindingNavigatorSaveItem.Enabled = False
        Me.DirectorioBindingNavigatorSaveItem.Image = CType(resources.GetObject("DirectorioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DirectorioBindingNavigatorSaveItem.Name = "DirectorioBindingNavigatorSaveItem"
        Me.DirectorioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DirectorioBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'btn_fei
        '
        Me.btn_fei.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_fei.Image = Global.AdminTegral.My.Resources.Resources.file_edit
        Me.btn_fei.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_fei.Name = "btn_fei"
        Me.btn_fei.Size = New System.Drawing.Size(183, 22)
        Me.btn_fei.Text = "Datos Facturacion Electronica"
        '
        'Tool_verfacturas
        '
        Me.Tool_verfacturas.Image = CType(resources.GetObject("Tool_verfacturas.Image"), System.Drawing.Image)
        Me.Tool_verfacturas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_verfacturas.Name = "Tool_verfacturas"
        Me.Tool_verfacturas.Size = New System.Drawing.Size(90, 22)
        Me.Tool_verfacturas.Text = "Ver Facturas"
        '
        'Boton_salir
        '
        Me.Boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Boton_salir.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.Boton_salir.Location = New System.Drawing.Point(773, 6)
        Me.Boton_salir.Name = "Boton_salir"
        Me.Boton_salir.Size = New System.Drawing.Size(31, 28)
        Me.Boton_salir.TabIndex = 38
        Me.Boton_salir.UseVisualStyleBackColor = True
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'ListasTableAdapter
        '
        Me.ListasTableAdapter.ClearBeforeFill = True
        '
        'Fei_metodosTableAdapter
        '
        Me.Fei_metodosTableAdapter.ClearBeforeFill = True
        '
        'Sql_documentos_clientesTableAdapter
        '
        Me.Sql_documentos_clientesTableAdapter.ClearBeforeFill = True
        '
        'frm_cat_provedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Boton_salir
        Me.ClientSize = New System.Drawing.Size(1036, 557)
        Me.Controls.Add(Me.SplitContainer1)
        Me.KeyPreview = True
        Me.Name = "frm_cat_provedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DirectorioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Fei_metodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DirectorioBindingNavigator.ResumeLayout(False)
        Me.DirectorioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents DirectorioBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DirectorioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Boton_salir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_fei As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AgentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
    Friend WithEvents ListasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
    Friend WithEvents Fei_metodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fei_metodosTableAdapter As AdminTegral.feiDatasetTableAdapters.fei_metodosTableAdapter
    Friend WithEvents Sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents Tool_verfacturas As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DirectorioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comercial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvemail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta_contable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents EdoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColoniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UsoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MetodoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LeyendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentaiosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigopostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColoniaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RFCTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_alta As System.Windows.Forms.TextBox
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RFCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cuenta_contableTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComercialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_agenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LimiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RutaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents formacombo As System.Windows.Forms.ComboBox
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btp_crear_fei As System.Windows.Forms.Button
    Friend WithEvents fecha_alta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents suspendido As System.Windows.Forms.Label
    Friend WithEvents DesglosarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents exml As System.Windows.Forms.TextBox
    Friend WithEvents epdf As System.Windows.Forms.TextBox
    Friend WithEvents eemail As System.Windows.Forms.TextBox
    Friend WithEvents Sql_documentos_clientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents dgvfolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvserie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
