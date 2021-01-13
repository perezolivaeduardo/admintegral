<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_new_producto
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
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim Provedorelabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CapacidadLabel As System.Windows.Forms.Label
        Dim MargenLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim ComisionableLabel As System.Windows.Forms.Label
        Dim ComisionLabel As System.Windows.Forms.Label
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim Cve_provedorLabel As System.Windows.Forms.Label
        Dim IepsLabel As System.Windows.Forms.Label
        Dim Codigo_satLabel As System.Windows.Forms.Label
        Dim Unidad_satLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.IepsTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_altaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.CaducidadLabel = New System.Windows.Forms.Label()
        Me.CaducidadCheckBox = New System.Windows.Forms.CheckBox()
        Me.Cve_provedorTextBox = New System.Windows.Forms.TextBox()
        Me.Und_detalleTextBox = New System.Windows.Forms.TextBox()
        Me.Und_compraTextBox = New System.Windows.Forms.TextBox()
        Me.Und_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.ventatxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.costotxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.unidadtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoComboBox = New System.Windows.Forms.ComboBox()
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_DeptoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_DirectorioTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MargenTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.ComisionableCheckBox = New System.Windows.Forms.CheckBox()
        Me.ComisionTextBox = New System.Windows.Forms.TextBox()
        Me.Id_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.boton_guardar = New System.Windows.Forms.Button()
        Me.Boton_Salir = New System.Windows.Forms.Button()
        Me.Unidades_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter()
        Me.DepartamentosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DepartamentosTableAdapter()
        Me.GruposTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter()
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter()
        Me.ErrorP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Unidades_productosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Unidades_productosTableAdapter()
        Me.Codigo_satTextBox = New System.Windows.Forms.TextBox()
        Me.Unidad_satTextBox = New System.Windows.Forms.TextBox()
        MarcaLabel = New System.Windows.Forms.Label()
        Provedorelabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CapacidadLabel = New System.Windows.Forms.Label()
        MargenLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        ComisionableLabel = New System.Windows.Forms.Label()
        ComisionLabel = New System.Windows.Forms.Label()
        Id_usuarioLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        GrupoLabel = New System.Windows.Forms.Label()
        Cve_provedorLabel = New System.Windows.Forms.Label()
        IepsLabel = New System.Windows.Forms.Label()
        Codigo_satLabel = New System.Windows.Forms.Label()
        Unidad_satLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Unidades_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(42, 65)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 6
        MarcaLabel.Text = "Marca:"
        '
        'Provedorelabel
        '
        Provedorelabel.AutoSize = True
        Provedorelabel.Location = New System.Drawing.Point(26, 91)
        Provedorelabel.Name = "Provedorelabel"
        Provedorelabel.Size = New System.Drawing.Size(56, 13)
        Provedorelabel.TabIndex = 8
        Provedorelabel.Text = "Provedor :"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(16, 173)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 10
        DescripcionLabel.Text = "Descripcion:"
        '
        'CapacidadLabel
        '
        CapacidadLabel.AutoSize = True
        CapacidadLabel.Location = New System.Drawing.Point(5, 199)
        CapacidadLabel.Name = "CapacidadLabel"
        CapacidadLabel.Size = New System.Drawing.Size(79, 13)
        CapacidadLabel.TabIndex = 12
        CapacidadLabel.Text = "Peso en Grms.:"
        '
        'MargenLabel
        '
        MargenLabel.AutoSize = True
        MargenLabel.Location = New System.Drawing.Point(37, 225)
        MargenLabel.Name = "MargenLabel"
        MargenLabel.Size = New System.Drawing.Size(45, 13)
        MargenLabel.TabIndex = 14
        MargenLabel.Text = "margen:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(157, 222)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 16
        IvaLabel.Text = "iva:"
        '
        'ComisionableLabel
        '
        ComisionableLabel.AutoSize = True
        ComisionableLabel.Location = New System.Drawing.Point(18, 253)
        ComisionableLabel.Name = "ComisionableLabel"
        ComisionableLabel.Size = New System.Drawing.Size(71, 13)
        ComisionableLabel.TabIndex = 18
        ComisionableLabel.Text = "comisionable:"
        '
        'ComisionLabel
        '
        ComisionLabel.AutoSize = True
        ComisionLabel.Location = New System.Drawing.Point(125, 253)
        ComisionLabel.Name = "ComisionLabel"
        ComisionLabel.Size = New System.Drawing.Size(51, 13)
        ComisionLabel.TabIndex = 20
        ComisionLabel.Text = "comision:"
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Enabled = False
        Id_usuarioLabel.Location = New System.Drawing.Point(92, 371)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(32, 13)
        Id_usuarioLabel.TabIndex = 24
        Id_usuarioLabel.Text = "User:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Enabled = False
        StatusLabel.Location = New System.Drawing.Point(16, 372)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(38, 13)
        StatusLabel.TabIndex = 26
        StatusLabel.Text = "status:"
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.Location = New System.Drawing.Point(5, 13)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(77, 13)
        DepartamentoLabel.TabIndex = 28
        DepartamentoLabel.Text = "Departamento:"
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(43, 35)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(39, 13)
        GrupoLabel.TabIndex = 29
        GrupoLabel.Text = "Grupo:"
        '
        'Cve_provedorLabel
        '
        Cve_provedorLabel.AutoSize = True
        Cve_provedorLabel.Location = New System.Drawing.Point(8, 114)
        Cve_provedorLabel.Name = "Cve_provedorLabel"
        Cve_provedorLabel.Size = New System.Drawing.Size(73, 13)
        Cve_provedorLabel.TabIndex = 46
        Cve_provedorLabel.Text = "cve provedor:"
        '
        'IepsLabel
        '
        IepsLabel.AutoSize = True
        IepsLabel.Location = New System.Drawing.Point(247, 222)
        IepsLabel.Name = "IepsLabel"
        IepsLabel.Size = New System.Drawing.Size(29, 13)
        IepsLabel.TabIndex = 50
        IepsLabel.Text = "ieps:"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(480, 495)
        Me.SplitContainer1.SplitterDistance = 40
        Me.SplitContainer1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 40)
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
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Unidad_satLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Unidad_satTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Codigo_satLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Codigo_satTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(IepsLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.IepsTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PesoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Fecha_altaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TipoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.CaducidadLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.CaducidadCheckBox)
        Me.SplitContainer2.Panel1.Controls.Add(Cve_provedorLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Cve_provedorTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Und_detalleTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Und_compraTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Und_ventaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_productoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblid)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ventatxt)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.costotxt)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.codigo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.unidadtxt)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(GrupoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GrupoComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(DepartamentoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DepartamentoComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_DeptoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_GrupoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(MarcaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MarcaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Provedorelabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_DirectorioTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(DescripcionLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DescripcionTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(CapacidadLabel)
        Me.SplitContainer2.Panel1.Controls.Add(MargenLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MargenTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(IvaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.IvaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(ComisionableLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComisionableCheckBox)
        Me.SplitContainer2.Panel1.Controls.Add(ComisionLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComisionTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Id_usuarioLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_usuarioTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(StatusLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.StatusTextBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.boton_guardar)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Boton_Salir)
        Me.SplitContainer2.Size = New System.Drawing.Size(480, 451)
        Me.SplitContainer2.SplitterDistance = 403
        Me.SplitContainer2.TabIndex = 0
        '
        'IepsTextBox
        '
        Me.IepsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "ieps", True))
        Me.IepsTextBox.Location = New System.Drawing.Point(282, 219)
        Me.IepsTextBox.Name = "IepsTextBox"
        Me.IepsTextBox.Size = New System.Drawing.Size(49, 20)
        Me.IepsTextBox.TabIndex = 51
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "AdmintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(95, 196)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(55, 20)
        Me.PesoTextBox.TabIndex = 50
        '
        'Fecha_altaTextBox
        '
        Me.Fecha_altaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "fecha_alta", True))
        Me.Fecha_altaTextBox.Location = New System.Drawing.Point(167, 365)
        Me.Fecha_altaTextBox.Name = "Fecha_altaTextBox"
        Me.Fecha_altaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Fecha_altaTextBox.TabIndex = 49
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "tipo", True))
        Me.TipoTextBox.Enabled = False
        Me.TipoTextBox.Location = New System.Drawing.Point(355, 364)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(17, 20)
        Me.TipoTextBox.TabIndex = 48
        '
        'CaducidadLabel
        '
        Me.CaducidadLabel.AutoSize = True
        Me.CaducidadLabel.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CaducidadLabel.Location = New System.Drawing.Point(270, 242)
        Me.CaducidadLabel.Name = "CaducidadLabel"
        Me.CaducidadLabel.Size = New System.Drawing.Size(61, 26)
        Me.CaducidadLabel.TabIndex = 46
        Me.CaducidadLabel.Text = "Controlar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Caducidad:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CaducidadCheckBox
        '
        Me.CaducidadCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "caducidad", True))
        Me.CaducidadCheckBox.Location = New System.Drawing.Point(255, 248)
        Me.CaducidadCheckBox.Name = "CaducidadCheckBox"
        Me.CaducidadCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.CaducidadCheckBox.TabIndex = 47
        '
        'Cve_provedorTextBox
        '
        Me.Cve_provedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "cve_provedor", True))
        Me.Cve_provedorTextBox.Location = New System.Drawing.Point(95, 114)
        Me.Cve_provedorTextBox.MaxLength = 15
        Me.Cve_provedorTextBox.Name = "Cve_provedorTextBox"
        Me.Cve_provedorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cve_provedorTextBox.TabIndex = 5
        '
        'Und_detalleTextBox
        '
        Me.Und_detalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "und_detalle", True))
        Me.Und_detalleTextBox.Enabled = False
        Me.Und_detalleTextBox.Location = New System.Drawing.Point(329, 365)
        Me.Und_detalleTextBox.Name = "Und_detalleTextBox"
        Me.Und_detalleTextBox.Size = New System.Drawing.Size(20, 20)
        Me.Und_detalleTextBox.TabIndex = 46
        '
        'Und_compraTextBox
        '
        Me.Und_compraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "und_compra", True))
        Me.Und_compraTextBox.Enabled = False
        Me.Und_compraTextBox.Location = New System.Drawing.Point(301, 365)
        Me.Und_compraTextBox.Name = "Und_compraTextBox"
        Me.Und_compraTextBox.Size = New System.Drawing.Size(22, 20)
        Me.Und_compraTextBox.TabIndex = 45
        '
        'Und_ventaTextBox
        '
        Me.Und_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "und_venta", True))
        Me.Und_ventaTextBox.Enabled = False
        Me.Und_ventaTextBox.Location = New System.Drawing.Point(273, 365)
        Me.Und_ventaTextBox.Name = "Und_ventaTextBox"
        Me.Und_ventaTextBox.Size = New System.Drawing.Size(22, 20)
        Me.Und_ventaTextBox.TabIndex = 44
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_Producto", True))
        Me.Id_productoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(372, 8)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.ReadOnly = True
        Me.Id_productoTextBox.Size = New System.Drawing.Size(71, 26)
        Me.Id_productoTextBox.TabIndex = 43
        '
        'lblid
        '
        Me.lblid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblid.Location = New System.Drawing.Point(386, 11)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(57, 20)
        Me.lblid.TabIndex = 42
        Me.lblid.Text = "Label7"
        Me.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblid.Visible = False
        '
        'ventatxt
        '
        Me.ventatxt.Location = New System.Drawing.Point(95, 332)
        Me.ventatxt.MaxLength = 10
        Me.ventatxt.Name = "ventatxt"
        Me.ventatxt.Size = New System.Drawing.Size(100, 20)
        Me.ventatxt.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "P. Venta:"
        '
        'costotxt
        '
        Me.costotxt.Location = New System.Drawing.Point(95, 306)
        Me.costotxt.MaxLength = 10
        Me.costotxt.Name = "costotxt"
        Me.costotxt.Size = New System.Drawing.Size(100, 20)
        Me.costotxt.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Costo :"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(95, 143)
        Me.codigo.MaxLength = 20
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(200, 20)
        Me.codigo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Unida Base :"
        '
        'unidadtxt
        '
        Me.unidadtxt.Location = New System.Drawing.Point(95, 279)
        Me.unidadtxt.MaxLength = 6
        Me.unidadtxt.Name = "unidadtxt"
        Me.unidadtxt.Size = New System.Drawing.Size(100, 20)
        Me.unidadtxt.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Codigo Barras :"
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "id_Directorio", True))
        Me.NombreComboBox.DataSource = Me.DirectorioBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(128, 84)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(335, 21)
        Me.NombreComboBox.TabIndex = 4
        Me.NombreComboBox.ValueMember = "id_directorio"
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'GrupoComboBox
        '
        Me.GrupoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "id_Grupo", True))
        Me.GrupoComboBox.DataSource = Me.GruposBindingSource
        Me.GrupoComboBox.DisplayMember = "Grupo"
        Me.GrupoComboBox.FormattingEnabled = True
        Me.GrupoComboBox.Location = New System.Drawing.Point(128, 36)
        Me.GrupoComboBox.Name = "GrupoComboBox"
        Me.GrupoComboBox.Size = New System.Drawing.Size(221, 21)
        Me.GrupoComboBox.TabIndex = 2
        Me.GrupoComboBox.ValueMember = "id_grupos"
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'DepartamentoComboBox
        '
        Me.DepartamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "id_Depto", True))
        Me.DepartamentoComboBox.DataSource = Me.DepartamentosBindingSource
        Me.DepartamentoComboBox.DisplayMember = "Departamento"
        Me.DepartamentoComboBox.FormattingEnabled = True
        Me.DepartamentoComboBox.Location = New System.Drawing.Point(128, 9)
        Me.DepartamentoComboBox.Name = "DepartamentoComboBox"
        Me.DepartamentoComboBox.Size = New System.Drawing.Size(221, 21)
        Me.DepartamentoComboBox.TabIndex = 1
        Me.DepartamentoComboBox.ValueMember = "id_depto"
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "Departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Id_DeptoTextBox
        '
        Me.Id_DeptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "id_depto", True))
        Me.Id_DeptoTextBox.Enabled = False
        Me.Id_DeptoTextBox.Location = New System.Drawing.Point(95, 10)
        Me.Id_DeptoTextBox.Name = "Id_DeptoTextBox"
        Me.Id_DeptoTextBox.ReadOnly = True
        Me.Id_DeptoTextBox.Size = New System.Drawing.Size(27, 20)
        Me.Id_DeptoTextBox.TabIndex = 3
        '
        'Id_GrupoTextBox
        '
        Me.Id_GrupoTextBox.Location = New System.Drawing.Point(95, 36)
        Me.Id_GrupoTextBox.Name = "Id_GrupoTextBox"
        Me.Id_GrupoTextBox.Size = New System.Drawing.Size(27, 20)
        Me.Id_GrupoTextBox.TabIndex = 5
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(95, 62)
        Me.MarcaTextBox.MaxLength = 15
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MarcaTextBox.TabIndex = 3
        '
        'Id_DirectorioTextBox
        '
        Me.Id_DirectorioTextBox.Location = New System.Drawing.Point(95, 84)
        Me.Id_DirectorioTextBox.Name = "Id_DirectorioTextBox"
        Me.Id_DirectorioTextBox.Size = New System.Drawing.Size(27, 20)
        Me.Id_DirectorioTextBox.TabIndex = 9
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(95, 170)
        Me.DescripcionTextBox.MaxLength = 40
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescripcionTextBox.TabIndex = 7
        '
        'MargenTextBox
        '
        Me.MargenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "margen", True))
        Me.MargenTextBox.Location = New System.Drawing.Point(95, 222)
        Me.MargenTextBox.MaxLength = 5
        Me.MargenTextBox.Name = "MargenTextBox"
        Me.MargenTextBox.Size = New System.Drawing.Size(55, 20)
        Me.MargenTextBox.TabIndex = 9
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(182, 222)
        Me.IvaTextBox.MaxLength = 2
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(55, 20)
        Me.IvaTextBox.TabIndex = 10
        '
        'ComisionableCheckBox
        '
        Me.ComisionableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "comisionable", True))
        Me.ComisionableCheckBox.Location = New System.Drawing.Point(95, 248)
        Me.ComisionableCheckBox.Name = "ComisionableCheckBox"
        Me.ComisionableCheckBox.Size = New System.Drawing.Size(27, 24)
        Me.ComisionableCheckBox.TabIndex = 11
        '
        'ComisionTextBox
        '
        Me.ComisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "comision", True))
        Me.ComisionTextBox.Location = New System.Drawing.Point(182, 248)
        Me.ComisionTextBox.MaxLength = 10
        Me.ComisionTextBox.Name = "ComisionTextBox"
        Me.ComisionTextBox.Size = New System.Drawing.Size(57, 20)
        Me.ComisionTextBox.TabIndex = 12
        '
        'Id_usuarioTextBox
        '
        Me.Id_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_usuario", True))
        Me.Id_usuarioTextBox.Enabled = False
        Me.Id_usuarioTextBox.Location = New System.Drawing.Point(128, 365)
        Me.Id_usuarioTextBox.Name = "Id_usuarioTextBox"
        Me.Id_usuarioTextBox.Size = New System.Drawing.Size(36, 20)
        Me.Id_usuarioTextBox.TabIndex = 25
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "status", True))
        Me.StatusTextBox.Enabled = False
        Me.StatusTextBox.Location = New System.Drawing.Point(56, 368)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(25, 20)
        Me.StatusTextBox.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Guarda y otro Igual"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'boton_guardar
        '
        Me.boton_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_guardar.Location = New System.Drawing.Point(343, 7)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(64, 23)
        Me.boton_guardar.TabIndex = 1
        Me.boton_guardar.Text = "Guardar"
        Me.boton_guardar.UseVisualStyleBackColor = True
        '
        'Boton_Salir
        '
        Me.Boton_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Boton_Salir.Location = New System.Drawing.Point(413, 7)
        Me.Boton_Salir.Name = "Boton_Salir"
        Me.Boton_Salir.Size = New System.Drawing.Size(64, 23)
        Me.Boton_Salir.TabIndex = 0
        Me.Boton_Salir.Text = "Cancelar"
        Me.Boton_Salir.UseVisualStyleBackColor = True
        '
        'Unidades_productosBindingSource
        '
        Me.Unidades_productosBindingSource.DataMember = "productos_Unidades_productos"
        Me.Unidades_productosBindingSource.DataSource = Me.ProductosBindingSource
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'ErrorP
        '
        Me.ErrorP.ContainerControl = Me
        '
        'Unidades_productosTableAdapter
        '
        Me.Unidades_productosTableAdapter.ClearBeforeFill = True
        '
        'Codigo_satLabel
        '
        Codigo_satLabel.AutoSize = True
        Codigo_satLabel.Location = New System.Drawing.Point(234, 285)
        Codigo_satLabel.Name = "Codigo_satLabel"
        Codigo_satLabel.Size = New System.Drawing.Size(67, 13)
        Codigo_satLabel.TabIndex = 51
        Codigo_satLabel.Text = "Codigo SAT:"
        '
        'Codigo_satTextBox
        '
        Me.Codigo_satTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "codigo_sat", True))
        Me.Codigo_satTextBox.Location = New System.Drawing.Point(307, 282)
        Me.Codigo_satTextBox.Name = "Codigo_satTextBox"
        Me.Codigo_satTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Codigo_satTextBox.TabIndex = 52
        '
        'Unidad_satLabel
        '
        Unidad_satLabel.AutoSize = True
        Unidad_satLabel.Location = New System.Drawing.Point(234, 312)
        Unidad_satLabel.Name = "Unidad_satLabel"
        Unidad_satLabel.Size = New System.Drawing.Size(63, 13)
        Unidad_satLabel.TabIndex = 52
        Unidad_satLabel.Text = "Unidad Sat:"
        '
        'Unidad_satTextBox
        '
        Me.Unidad_satTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "unidad_sat", True))
        Me.Unidad_satTextBox.Location = New System.Drawing.Point(307, 309)
        Me.Unidad_satTextBox.Name = "Unidad_satTextBox"
        Me.Unidad_satTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unidad_satTextBox.TabIndex = 53
        '
        'frm_new_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Boton_Salir
        Me.ClientSize = New System.Drawing.Size(480, 495)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_new_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Nuevo Producto"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Unidades_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As Global.AdminTegral.AdmintegralDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Global.AdminTegral.AdmintegralDataSetTableAdapters.productosTableAdapter
    Friend WithEvents Id_DeptoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_GrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_DirectorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MargenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComisionableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ComisionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_usuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosTableAdapter As Global.AdminTegral.AdmintegralDataSetTableAdapters.DepartamentosTableAdapter
    Friend WithEvents DepartamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As Global.AdminTegral.AdmintegralDataSetTableAdapters.GruposTableAdapter
    Friend WithEvents GrupoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents boton_guardar As System.Windows.Forms.Button
    Friend WithEvents Boton_Salir As System.Windows.Forms.Button
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As Global.AdminTegral.AdmintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorP As System.Windows.Forms.ErrorProvider
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents unidadtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ventatxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents costotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Unidades_productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Unidades_productosTableAdapter As Global.AdminTegral.AdmintegralDataSetTableAdapters.Unidades_productosTableAdapter
    Friend WithEvents Id_productoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Und_detalleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Und_compraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Und_ventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cve_provedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaducidadCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CaducidadLabel As System.Windows.Forms.Label
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_altaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IepsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unidad_satTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Codigo_satTextBox As System.Windows.Forms.TextBox
End Class
