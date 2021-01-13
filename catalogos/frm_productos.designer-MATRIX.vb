<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productos
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
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.poxxo = New System.Windows.Forms.CheckBox()
        Me.provtxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gptxt = New System.Windows.Forms.TextBox()
        Me.lblgrupos = New System.Windows.Forms.Label()
        Me.GrupoComboBox = New System.Windows.Forms.ComboBox()
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.boton_proveedor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombreproveedor = New System.Windows.Forms.TextBox()
        Me.idprov = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitCatalogo = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FiltrararToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarFiltrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXISTENCIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuspenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReActivarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.recalcular = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.boton_borrar_unidad = New System.Windows.Forms.ToolStripButton()
        Me.Unidades_productosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdproductoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdunidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperadorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FactorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosUnidadesproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.boton_salir = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvpendientes = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvs = New System.Windows.Forms.DataGridView()
        Me.dgvsid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_almacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Almacen = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblalmacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Productos_stoksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.boton_panel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_general = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ProductosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter()
        Me.Unidades_productosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Unidades_productosTableAdapter()
        Me.GruposTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter()
        Me.Productos_stoksTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.productos_stoksTableAdapter()
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter()
        Me.dgvid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_sat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad_sat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvprov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDeptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subgrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDirectorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvdescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvmargen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_oxxo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ieps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisionableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ComisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UndventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UndcompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnddetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaducidadDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PreciounicoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        GrupoLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitCatalogo.Panel1.SuspendLayout()
        Me.SplitCatalogo.Panel2.SuspendLayout()
        Me.SplitCatalogo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.Unidades_productosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosUnidadesproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvpendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblalmacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productos_stoksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(8, 19)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(39, 13)
        GrupoLabel.TabIndex = 0
        GrupoLabel.Text = "Grupo:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.poxxo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.provtxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1120, 512)
        Me.SplitContainer1.SplitterDistance = 94
        Me.SplitContainer1.TabIndex = 1
        '
        'poxxo
        '
        Me.poxxo.AutoSize = True
        Me.poxxo.Checked = True
        Me.poxxo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.poxxo.Location = New System.Drawing.Point(541, 21)
        Me.poxxo.Name = "poxxo"
        Me.poxxo.Size = New System.Drawing.Size(83, 17)
        Me.poxxo.TabIndex = 8
        Me.poxxo.Text = "Precio Oxxo"
        Me.poxxo.UseVisualStyleBackColor = True
        '
        'provtxt
        '
        Me.provtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.provtxt.Location = New System.Drawing.Point(839, 65)
        Me.provtxt.Name = "provtxt"
        Me.provtxt.Size = New System.Drawing.Size(269, 20)
        Me.provtxt.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Image = Global.AdminTegral.My.Resources.Resources.repeat
        Me.Button2.Location = New System.Drawing.Point(516, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(4, 7)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(506, 84)
        Me.TabControl2.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(498, 58)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Descripcion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.Location = New System.Drawing.Point(78, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.gptxt)
        Me.TabPage3.Controls.Add(Me.lblgrupos)
        Me.TabPage3.Controls.Add(GrupoLabel)
        Me.TabPage3.Controls.Add(Me.GrupoComboBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(498, 58)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Grupo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gptxt
        '
        Me.gptxt.Location = New System.Drawing.Point(49, 17)
        Me.gptxt.Name = "gptxt"
        Me.gptxt.Size = New System.Drawing.Size(38, 20)
        Me.gptxt.TabIndex = 3
        '
        'lblgrupos
        '
        Me.lblgrupos.AutoSize = True
        Me.lblgrupos.Location = New System.Drawing.Point(380, 23)
        Me.lblgrupos.Name = "lblgrupos"
        Me.lblgrupos.Size = New System.Drawing.Size(0, 13)
        Me.lblgrupos.TabIndex = 2
        '
        'GrupoComboBox
        '
        Me.GrupoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposBindingSource, "Grupo", True))
        Me.GrupoComboBox.DataSource = Me.GruposBindingSource
        Me.GrupoComboBox.DisplayMember = "Grupo"
        Me.GrupoComboBox.FormattingEnabled = True
        Me.GrupoComboBox.Location = New System.Drawing.Point(93, 16)
        Me.GrupoComboBox.Name = "GrupoComboBox"
        Me.GrupoComboBox.Size = New System.Drawing.Size(259, 21)
        Me.GrupoComboBox.TabIndex = 1
        Me.GrupoComboBox.ValueMember = "id_grupos"
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "AdmintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.boton_proveedor)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.nombreproveedor)
        Me.TabPage5.Controls.Add(Me.idprov)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(498, 58)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Por Proveedor"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'boton_proveedor
        '
        Me.boton_proveedor.Location = New System.Drawing.Point(443, 15)
        Me.boton_proveedor.Name = "boton_proveedor"
        Me.boton_proveedor.Size = New System.Drawing.Size(38, 23)
        Me.boton_proveedor.TabIndex = 3
        Me.boton_proveedor.Text = "..."
        Me.boton_proveedor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor :"
        '
        'nombreproveedor
        '
        Me.nombreproveedor.Enabled = False
        Me.nombreproveedor.Location = New System.Drawing.Point(121, 15)
        Me.nombreproveedor.Name = "nombreproveedor"
        Me.nombreproveedor.Size = New System.Drawing.Size(311, 20)
        Me.nombreproveedor.TabIndex = 1
        '
        'idprov
        '
        Me.idprov.Location = New System.Drawing.Point(72, 15)
        Me.idprov.Name = "idprov"
        Me.idprov.Size = New System.Drawing.Size(43, 20)
        Me.idprov.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1120, 94)
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitCatalogo)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1120, 414)
        Me.SplitContainer2.SplitterDistance = 381
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitCatalogo
        '
        Me.SplitCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.SplitCatalogo.Name = "SplitCatalogo"
        Me.SplitCatalogo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitCatalogo.Panel1
        '
        Me.SplitCatalogo.Panel1.AutoScroll = True
        Me.SplitCatalogo.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitCatalogo.Panel2
        '
        Me.SplitCatalogo.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitCatalogo.Size = New System.Drawing.Size(1120, 381)
        Me.SplitCatalogo.SplitterDistance = 259
        Me.SplitCatalogo.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvid, Me.codigo_sat, Me.unidad_sat, Me.dgvprov, Me.IdDeptoDataGridViewTextBoxColumn, Me.IdGrupo, Me.subgrupo, Me.MarcaDataGridViewTextBoxColumn, Me.IdDirectorioDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.dgvdescripcion, Me.PesoDataGridViewTextBoxColumn, Me.dgvmargen, Me.precio_oxxo, Me.IvaDataGridViewTextBoxColumn, Me.ieps, Me.ComisionableDataGridViewCheckBoxColumn, Me.ComisionDataGridViewTextBoxColumn, Me.FechaaltaDataGridViewTextBoxColumn, Me.IdusuarioDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.UndventaDataGridViewTextBoxColumn, Me.UndcompraDataGridViewTextBoxColumn, Me.UnddetalleDataGridViewTextBoxColumn, Me.CaducidadDataGridViewCheckBoxColumn, Me.PreciounicoDataGridViewCheckBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.ProductosBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1120, 259)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrararToolStripMenuItem, Me.QuitarFiltrosToolStripMenuItem, Me.VerEntradasToolStripMenuItem, Me.EXISTENCIASToolStripMenuItem, Me.KardexToolStripMenuItem, Me.ToolStripSeparator2, Me.SuspenderToolStripMenuItem, Me.ReActivarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 164)
        '
        'FiltrararToolStripMenuItem
        '
        Me.FiltrararToolStripMenuItem.Name = "FiltrararToolStripMenuItem"
        Me.FiltrararToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.FiltrararToolStripMenuItem.Text = "Filtrarar"
        '
        'QuitarFiltrosToolStripMenuItem
        '
        Me.QuitarFiltrosToolStripMenuItem.Name = "QuitarFiltrosToolStripMenuItem"
        Me.QuitarFiltrosToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.QuitarFiltrosToolStripMenuItem.Text = "Quitar Filtros"
        '
        'VerEntradasToolStripMenuItem
        '
        Me.VerEntradasToolStripMenuItem.Name = "VerEntradasToolStripMenuItem"
        Me.VerEntradasToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.VerEntradasToolStripMenuItem.Text = "Ver Entradas"
        '
        'EXISTENCIASToolStripMenuItem
        '
        Me.EXISTENCIASToolStripMenuItem.Name = "EXISTENCIASToolStripMenuItem"
        Me.EXISTENCIASToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EXISTENCIASToolStripMenuItem.Text = "EXISTENCIAS"
        '
        'KardexToolStripMenuItem
        '
        Me.KardexToolStripMenuItem.Name = "KardexToolStripMenuItem"
        Me.KardexToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.KardexToolStripMenuItem.Text = "Kardex"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(140, 6)
        '
        'SuspenderToolStripMenuItem
        '
        Me.SuspenderToolStripMenuItem.Name = "SuspenderToolStripMenuItem"
        Me.SuspenderToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SuspenderToolStripMenuItem.Text = "Suspender"
        '
        'ReActivarToolStripMenuItem
        '
        Me.ReActivarToolStripMenuItem.Name = "ReActivarToolStripMenuItem"
        Me.ReActivarToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ReActivarToolStripMenuItem.Text = "Re-Activar"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1120, 118)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.recalcular)
        Me.TabPage1.Controls.Add(Me.ToolStrip2)
        Me.TabPage1.Controls.Add(Me.Unidades_productosDataGridView)
        Me.TabPage1.Controls.Add(Me.boton_salir)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1112, 92)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Unidades"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'recalcular
        '
        Me.recalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recalcular.AutoSize = True
        Me.recalcular.Checked = Global.AdminTegral.My.MySettings.Default.recalcularprecios
        Me.recalcular.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.AdminTegral.My.MySettings.Default, "recalcularprecios", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.recalcular.Location = New System.Drawing.Point(950, 6)
        Me.recalcular.Name = "recalcular"
        Me.recalcular.Size = New System.Drawing.Size(162, 17)
        Me.recalcular.TabIndex = 3
        Me.recalcular.Text = "Recalcular Automaticamente"
        Me.recalcular.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_borrar_unidad})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(24, 86)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        Me.ToolStrip2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'boton_borrar_unidad
        '
        Me.boton_borrar_unidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_borrar_unidad.Image = Global.AdminTegral.My.Resources.Resources.tag_blue_delete
        Me.boton_borrar_unidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_borrar_unidad.Name = "boton_borrar_unidad"
        Me.boton_borrar_unidad.Size = New System.Drawing.Size(21, 20)
        Me.boton_borrar_unidad.Text = "Borrar Unidad"
        '
        'Unidades_productosDataGridView
        '
        Me.Unidades_productosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Unidades_productosDataGridView.AutoGenerateColumns = False
        Me.Unidades_productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Unidades_productosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn1, Me.IdunidadDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.descripcion, Me.UnidadDataGridViewTextBoxColumn, Me.OperadorDataGridViewCheckBoxColumn, Me.FactorDataGridViewTextBoxColumn, Me.UnidadesDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.VentaDataGridViewTextBoxColumn})
        Me.Unidades_productosDataGridView.DataSource = Me.ProductosUnidadesproductosBindingSource
        Me.Unidades_productosDataGridView.Location = New System.Drawing.Point(30, 6)
        Me.Unidades_productosDataGridView.Name = "Unidades_productosDataGridView"
        Me.Unidades_productosDataGridView.RowHeadersVisible = False
        Me.Unidades_productosDataGridView.Size = New System.Drawing.Size(726, 86)
        Me.Unidades_productosDataGridView.TabIndex = 0
        '
        'IdproductoDataGridViewTextBoxColumn1
        '
        Me.IdproductoDataGridViewTextBoxColumn1.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn1.HeaderText = "ID_P"
        Me.IdproductoDataGridViewTextBoxColumn1.Name = "IdproductoDataGridViewTextBoxColumn1"
        Me.IdproductoDataGridViewTextBoxColumn1.Width = 56
        '
        'IdunidadDataGridViewTextBoxColumn
        '
        Me.IdunidadDataGridViewTextBoxColumn.DataPropertyName = "id_unidad"
        Me.IdunidadDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdunidadDataGridViewTextBoxColumn.Name = "IdunidadDataGridViewTextBoxColumn"
        Me.IdunidadDataGridViewTextBoxColumn.Width = 40
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Width = 65
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.MaxInputLength = 20
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 86
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.Width = 66
        '
        'OperadorDataGridViewCheckBoxColumn
        '
        Me.OperadorDataGridViewCheckBoxColumn.DataPropertyName = "Operador"
        Me.OperadorDataGridViewCheckBoxColumn.HeaderText = "Operador"
        Me.OperadorDataGridViewCheckBoxColumn.Name = "OperadorDataGridViewCheckBoxColumn"
        Me.OperadorDataGridViewCheckBoxColumn.Width = 57
        '
        'FactorDataGridViewTextBoxColumn
        '
        Me.FactorDataGridViewTextBoxColumn.DataPropertyName = "factor"
        Me.FactorDataGridViewTextBoxColumn.HeaderText = "factor"
        Me.FactorDataGridViewTextBoxColumn.Name = "FactorDataGridViewTextBoxColumn"
        Me.FactorDataGridViewTextBoxColumn.Width = 59
        '
        'UnidadesDataGridViewTextBoxColumn
        '
        Me.UnidadesDataGridViewTextBoxColumn.DataPropertyName = "unidades"
        Me.UnidadesDataGridViewTextBoxColumn.HeaderText = "unidades"
        Me.UnidadesDataGridViewTextBoxColumn.Name = "UnidadesDataGridViewTextBoxColumn"
        Me.UnidadesDataGridViewTextBoxColumn.Width = 75
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.Width = 58
        '
        'VentaDataGridViewTextBoxColumn
        '
        Me.VentaDataGridViewTextBoxColumn.DataPropertyName = "venta"
        Me.VentaDataGridViewTextBoxColumn.HeaderText = "venta"
        Me.VentaDataGridViewTextBoxColumn.Name = "VentaDataGridViewTextBoxColumn"
        Me.VentaDataGridViewTextBoxColumn.Width = 59
        '
        'ProductosUnidadesproductosBindingSource
        '
        Me.ProductosUnidadesproductosBindingSource.DataMember = "productos_Unidades_productos"
        Me.ProductosUnidadesproductosBindingSource.DataSource = Me.ProductosBindingSource
        '
        'boton_salir
        '
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(398, 35)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 2
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvpendientes)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1112, 92)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Pendientes"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvpendientes
        '
        Me.dgvpendientes.AllowUserToAddRows = False
        Me.dgvpendientes.AllowUserToDeleteRows = False
        Me.dgvpendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvpendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvpendientes.Location = New System.Drawing.Point(3, 3)
        Me.dgvpendientes.Name = "dgvpendientes"
        Me.dgvpendientes.ReadOnly = True
        Me.dgvpendientes.RowHeadersVisible = False
        Me.dgvpendientes.Size = New System.Drawing.Size(1106, 86)
        Me.dgvpendientes.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(Me.Button3)
        Me.TabPage6.Controls.Add(Me.dgvs)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1112, 92)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Stock's"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(715, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Guardar Cambios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvs
        '
        Me.dgvs.AllowUserToAddRows = False
        Me.dgvs.AllowUserToDeleteRows = False
        Me.dgvs.AllowUserToResizeColumns = False
        Me.dgvs.AllowUserToResizeRows = False
        Me.dgvs.AutoGenerateColumns = False
        Me.dgvs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvsid, Me.id_almacen, Me.Almacen, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.dgvs.DataSource = Me.Productos_stoksBindingSource
        Me.dgvs.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvs.Location = New System.Drawing.Point(0, 0)
        Me.dgvs.Name = "dgvs"
        Me.dgvs.RowHeadersVisible = False
        Me.dgvs.Size = New System.Drawing.Size(688, 92)
        Me.dgvs.TabIndex = 0
        '
        'dgvsid
        '
        Me.dgvsid.DataPropertyName = "id_producto"
        Me.dgvsid.HeaderText = "ID"
        Me.dgvsid.Name = "dgvsid"
        Me.dgvsid.ReadOnly = True
        Me.dgvsid.Width = 43
        '
        'id_almacen
        '
        Me.id_almacen.DataPropertyName = "id_almacen"
        Me.id_almacen.HeaderText = "TD"
        Me.id_almacen.Name = "id_almacen"
        Me.id_almacen.ReadOnly = True
        Me.id_almacen.Width = 47
        '
        'Almacen
        '
        Me.Almacen.DataPropertyName = "id_almacen"
        Me.Almacen.DataSource = Me.TblalmacenesBindingSource
        Me.Almacen.DisplayMember = "Almacen"
        Me.Almacen.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Almacen.HeaderText = "Almacen"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        Me.Almacen.ValueMember = "id_almacen"
        Me.Almacen.Width = 54
        '
        'TblalmacenesBindingSource
        '
        Me.TblalmacenesBindingSource.DataMember = "tbl_almacenes"
        Me.TblalmacenesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "stock"
        Me.DataGridViewTextBoxColumn3.HeaderText = "stock"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 58
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "promedio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "promedio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'Productos_stoksBindingSource
        '
        Me.Productos_stoksBindingSource.DataMember = "productos_stoks"
        Me.Productos_stoksBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CopiarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton, Me.boton_panel, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.btn_general, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1120, 29)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.NuevoToolStripButton.Text = "&Nuevo Producto (form)"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.AbrirToolStripButton.Text = "&Abrir"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.Enabled = False
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(69, 26)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.CopiarToolStripButton.Text = "&Copiar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'boton_panel
        '
        Me.boton_panel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.boton_panel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_panel.Image = Global.AdminTegral.My.Resources.Resources.bullet_arrow_bottom
        Me.boton_panel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_panel.Name = "boton_panel"
        Me.boton_panel.Size = New System.Drawing.Size(23, 26)
        Me.boton_panel.Text = "Panel Up/Down"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.add
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(107, 26)
        Me.ToolStripButton1.Text = "Nuevo Articulo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'btn_general
        '
        Me.btn_general.Image = Global.AdminTegral.My.Resources.Resources.avedesk
        Me.btn_general.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_general.Name = "btn_general"
        Me.btn_general.Size = New System.Drawing.Size(173, 26)
        Me.btn_general.Text = "Actualizar Catalogo General"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Binoculars
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(161, 26)
        Me.ToolStripButton2.Text = "Ver productos Sin Codigo"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Unidades_productosTableAdapter
        '
        Me.Unidades_productosTableAdapter.ClearBeforeFill = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'Productos_stoksTableAdapter
        '
        Me.Productos_stoksTableAdapter.ClearBeforeFill = True
        '
        'Tbl_almacenesTableAdapter
        '
        Me.Tbl_almacenesTableAdapter.ClearBeforeFill = True
        '
        'dgvid
        '
        Me.dgvid.DataPropertyName = "id_Producto"
        Me.dgvid.HeaderText = "Id"
        Me.dgvid.Name = "dgvid"
        Me.dgvid.Width = 41
        '
        'codigo_sat
        '
        Me.codigo_sat.DataPropertyName = "codigo_sat"
        Me.codigo_sat.HeaderText = "codigo_sat"
        Me.codigo_sat.Name = "codigo_sat"
        Me.codigo_sat.Width = 84
        '
        'unidad_sat
        '
        Me.unidad_sat.DataPropertyName = "unidad_sat"
        Me.unidad_sat.HeaderText = "unidad_sat"
        Me.unidad_sat.Name = "unidad_sat"
        Me.unidad_sat.Width = 84
        '
        'dgvprov
        '
        Me.dgvprov.DataPropertyName = "cve_provedor"
        Me.dgvprov.HeaderText = "PV"
        Me.dgvprov.Name = "dgvprov"
        Me.dgvprov.Width = 46
        '
        'IdDeptoDataGridViewTextBoxColumn
        '
        Me.IdDeptoDataGridViewTextBoxColumn.DataPropertyName = "id_Depto"
        Me.IdDeptoDataGridViewTextBoxColumn.HeaderText = "Dep"
        Me.IdDeptoDataGridViewTextBoxColumn.Name = "IdDeptoDataGridViewTextBoxColumn"
        Me.IdDeptoDataGridViewTextBoxColumn.Width = 52
        '
        'IdGrupo
        '
        Me.IdGrupo.DataPropertyName = "id_Grupo"
        Me.IdGrupo.HeaderText = "Gp"
        Me.IdGrupo.Name = "IdGrupo"
        Me.IdGrupo.Width = 46
        '
        'subgrupo
        '
        Me.subgrupo.DataPropertyName = "subgrupo"
        Me.subgrupo.HeaderText = "SG"
        Me.subgrupo.Name = "subgrupo"
        Me.subgrupo.Width = 47
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.Width = 62
        '
        'IdDirectorioDataGridViewTextBoxColumn
        '
        Me.IdDirectorioDataGridViewTextBoxColumn.DataPropertyName = "id_Directorio"
        Me.IdDirectorioDataGridViewTextBoxColumn.HeaderText = "Prov"
        Me.IdDirectorioDataGridViewTextBoxColumn.Name = "IdDirectorioDataGridViewTextBoxColumn"
        Me.IdDirectorioDataGridViewTextBoxColumn.Width = 54
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.Visible = False
        Me.TipoDataGridViewTextBoxColumn.Width = 49
        '
        'dgvdescripcion
        '
        Me.dgvdescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvdescripcion.DataPropertyName = "Descripcion"
        Me.dgvdescripcion.HeaderText = "Descripcion"
        Me.dgvdescripcion.MaxInputLength = 300
        Me.dgvdescripcion.Name = "dgvdescripcion"
        Me.dgvdescripcion.Width = 400
        '
        'PesoDataGridViewTextBoxColumn
        '
        Me.PesoDataGridViewTextBoxColumn.DataPropertyName = "peso"
        Me.PesoDataGridViewTextBoxColumn.HeaderText = "peso"
        Me.PesoDataGridViewTextBoxColumn.Name = "PesoDataGridViewTextBoxColumn"
        Me.PesoDataGridViewTextBoxColumn.Width = 55
        '
        'dgvmargen
        '
        Me.dgvmargen.DataPropertyName = "margen"
        Me.dgvmargen.HeaderText = "margen"
        Me.dgvmargen.Name = "dgvmargen"
        Me.dgvmargen.Width = 67
        '
        'precio_oxxo
        '
        Me.precio_oxxo.DataPropertyName = "precio_oxxo"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral
        Me.precio_oxxo.DefaultCellStyle = DataGridViewCellStyle1
        Me.precio_oxxo.HeaderText = "precio_oxxo"
        Me.precio_oxxo.Name = "precio_oxxo"
        Me.precio_oxxo.Width = 89
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "iva"
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.Width = 46
        '
        'ieps
        '
        Me.ieps.DataPropertyName = "ieps"
        Me.ieps.HeaderText = "ieps"
        Me.ieps.Name = "ieps"
        Me.ieps.Width = 51
        '
        'ComisionableDataGridViewCheckBoxColumn
        '
        Me.ComisionableDataGridViewCheckBoxColumn.DataPropertyName = "comisionable"
        Me.ComisionableDataGridViewCheckBoxColumn.HeaderText = "comisionable"
        Me.ComisionableDataGridViewCheckBoxColumn.Name = "ComisionableDataGridViewCheckBoxColumn"
        Me.ComisionableDataGridViewCheckBoxColumn.Width = 74
        '
        'ComisionDataGridViewTextBoxColumn
        '
        Me.ComisionDataGridViewTextBoxColumn.DataPropertyName = "comision"
        Me.ComisionDataGridViewTextBoxColumn.HeaderText = "comision"
        Me.ComisionDataGridViewTextBoxColumn.Name = "ComisionDataGridViewTextBoxColumn"
        Me.ComisionDataGridViewTextBoxColumn.Width = 73
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fecha_alta"
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "fecha_alta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        Me.FechaaltaDataGridViewTextBoxColumn.Visible = False
        Me.FechaaltaDataGridViewTextBoxColumn.Width = 82
        '
        'IdusuarioDataGridViewTextBoxColumn
        '
        Me.IdusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.Name = "IdusuarioDataGridViewTextBoxColumn"
        Me.IdusuarioDataGridViewTextBoxColumn.Visible = False
        Me.IdusuarioDataGridViewTextBoxColumn.Width = 80
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Visible = False
        Me.StatusDataGridViewTextBoxColumn.Width = 60
        '
        'UndventaDataGridViewTextBoxColumn
        '
        Me.UndventaDataGridViewTextBoxColumn.DataPropertyName = "und_venta"
        Me.UndventaDataGridViewTextBoxColumn.HeaderText = "UV"
        Me.UndventaDataGridViewTextBoxColumn.Name = "UndventaDataGridViewTextBoxColumn"
        Me.UndventaDataGridViewTextBoxColumn.Width = 47
        '
        'UndcompraDataGridViewTextBoxColumn
        '
        Me.UndcompraDataGridViewTextBoxColumn.DataPropertyName = "und_compra"
        Me.UndcompraDataGridViewTextBoxColumn.HeaderText = "UC"
        Me.UndcompraDataGridViewTextBoxColumn.Name = "UndcompraDataGridViewTextBoxColumn"
        Me.UndcompraDataGridViewTextBoxColumn.Width = 47
        '
        'UnddetalleDataGridViewTextBoxColumn
        '
        Me.UnddetalleDataGridViewTextBoxColumn.DataPropertyName = "und_detalle"
        Me.UnddetalleDataGridViewTextBoxColumn.HeaderText = "UD"
        Me.UnddetalleDataGridViewTextBoxColumn.Name = "UnddetalleDataGridViewTextBoxColumn"
        Me.UnddetalleDataGridViewTextBoxColumn.Width = 48
        '
        'CaducidadDataGridViewCheckBoxColumn
        '
        Me.CaducidadDataGridViewCheckBoxColumn.DataPropertyName = "caducidad"
        Me.CaducidadDataGridViewCheckBoxColumn.HeaderText = "caducidad"
        Me.CaducidadDataGridViewCheckBoxColumn.Name = "CaducidadDataGridViewCheckBoxColumn"
        Me.CaducidadDataGridViewCheckBoxColumn.Width = 63
        '
        'PreciounicoDataGridViewCheckBoxColumn
        '
        Me.PreciounicoDataGridViewCheckBoxColumn.DataPropertyName = "precio_unico"
        Me.PreciounicoDataGridViewCheckBoxColumn.HeaderText = "P Unico"
        Me.PreciounicoDataGridViewCheckBoxColumn.Name = "PreciounicoDataGridViewCheckBoxColumn"
        Me.PreciounicoDataGridViewCheckBoxColumn.Width = 51
        '
        'frm_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(1120, 512)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Productos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitCatalogo.Panel1.ResumeLayout(False)
        Me.SplitCatalogo.Panel2.ResumeLayout(False)
        CType(Me.SplitCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitCatalogo.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.Unidades_productosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosUnidadesproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvpendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dgvs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblalmacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productos_stoksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitCatalogo As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.AdmintegralDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.productosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Unidades_productosTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.Unidades_productosTableAdapter
    Friend WithEvents Unidades_productosDataGridView As System.Windows.Forms.DataGridView
    'Friend WithEvents FKUnidadesproductosproductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopiarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_panel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_borrar_unidad As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.GruposTableAdapter
    Friend WithEvents GrupoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lblgrupos As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProductosUnidadesproductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FiltrararToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarFiltrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgvpendientes As System.Windows.Forms.DataGridView
    Friend WithEvents recalcular As System.Windows.Forms.CheckBox
    Friend WithEvents VerEntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nombreproveedor As System.Windows.Forms.TextBox
    Friend WithEvents idprov As System.Windows.Forms.TextBox
    Friend WithEvents boton_proveedor As System.Windows.Forms.Button
    Friend WithEvents gptxt As System.Windows.Forms.TextBox
    Friend WithEvents EXISTENCIASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReActivarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents IdproductoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdunidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperadorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FactorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provtxt As System.Windows.Forms.TextBox
    Friend WithEvents KardexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_general As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Productos_stoksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Productos_stoksTableAdapter As AdminTegral.admintegralDataSetTableAdapters.productos_stoksTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgvs As System.Windows.Forms.DataGridView
    Friend WithEvents TblalmacenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_almacenesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
    Friend WithEvents dgvsid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Almacen As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents poxxo As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo_sat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad_sat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvprov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDeptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subgrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDirectorioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvdescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvmargen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_oxxo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ieps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComisionableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ComisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UndventaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UndcompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnddetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaducidadDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PreciounicoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
