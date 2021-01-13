<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambio_de_precios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cambio_de_precios))
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.rpt_cambio_de_preciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.SeleccionarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitarSeleccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.guardar_cambios = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.margentxt = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.descripciontxt = New System.Windows.Forms.TextBox
        Me.chkdescripcion = New System.Windows.Forms.CheckBox
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.margen1txt = New System.Windows.Forms.ToolStripTextBox
        Me.aplicar_catalogo = New System.Windows.Forms.ToolStripButton
        Me.idgp = New System.Windows.Forms.TextBox
        Me.idpv = New System.Windows.Forms.TextBox
        Me.xgrupo = New System.Windows.Forms.CheckBox
        Me.xprov = New System.Windows.Forms.CheckBox
        Me.boton_Cargar = New System.Windows.Forms.Button
        Me.GrupoComboBox = New System.Windows.Forms.ComboBox
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.dgvfechas = New System.Windows.Forms.DataGridView
        Me.Ver = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
        Me.GruposTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
        Me.rpt_cambio_de_preciosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_cambio_de_preciosTableAdapter
        Me.boton_cargar_todo = New System.Windows.Forms.Button
        CType(Me.rpt_cambio_de_preciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.dgvfechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpt_cambio_de_preciosBindingSource
        '
        Me.rpt_cambio_de_preciosBindingSource.DataMember = "rpt_cambio_de_precios"
        Me.rpt_cambio_de_preciosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1021, 461)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1021, 461)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1013, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pon Entrada"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer2.Size = New System.Drawing.Size(1007, 429)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.ToolStripSplitButton1, Me.guardar_cambios, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.margentxt, Me.ToolStripButton1, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1007, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel1.Text = "Entrada"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarTodosToolStripMenuItem, Me.QuitarSeleccionToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.AdminTegral.My.Resources.Resources.Ok_2
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripSplitButton1.Text = "Selectcionar"
        '
        'SeleccionarTodosToolStripMenuItem
        '
        Me.SeleccionarTodosToolStripMenuItem.Name = "SeleccionarTodosToolStripMenuItem"
        Me.SeleccionarTodosToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SeleccionarTodosToolStripMenuItem.Text = "Seleccionar Todos"
        '
        'QuitarSeleccionToolStripMenuItem
        '
        Me.QuitarSeleccionToolStripMenuItem.Name = "QuitarSeleccionToolStripMenuItem"
        Me.QuitarSeleccionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.QuitarSeleccionToolStripMenuItem.Text = "Quitar Seleccion"
        '
        'guardar_cambios
        '
        Me.guardar_cambios.Image = Global.AdminTegral.My.Resources.Resources.Save
        Me.guardar_cambios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.guardar_cambios.Name = "guardar_cambios"
        Me.guardar_cambios.Size = New System.Drawing.Size(114, 22)
        Me.guardar_cambios.Text = "Aplicar Cambios"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel2.Text = "Margen :"
        '
        'margentxt
        '
        Me.margentxt.Name = "margentxt"
        Me.margentxt.Size = New System.Drawing.Size(30, 25)
        Me.margentxt.Text = "10"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.Calc
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripButton1.Text = "Aplicar % margen"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Validar Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Entrada :"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1007, 400)
        Me.dgv.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1013, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Por Proveedor/Grupo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.boton_cargar_todo)
        Me.SplitContainer3.Panel1.Controls.Add(Me.descripciontxt)
        Me.SplitContainer3.Panel1.Controls.Add(Me.chkdescripcion)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.idgp)
        Me.SplitContainer3.Panel1.Controls.Add(Me.idpv)
        Me.SplitContainer3.Panel1.Controls.Add(Me.xgrupo)
        Me.SplitContainer3.Panel1.Controls.Add(Me.xprov)
        Me.SplitContainer3.Panel1.Controls.Add(Me.boton_Cargar)
        Me.SplitContainer3.Panel1.Controls.Add(Me.GrupoComboBox)
        Me.SplitContainer3.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer3.Size = New System.Drawing.Size(1007, 429)
        Me.SplitContainer3.SplitterDistance = 88
        Me.SplitContainer3.TabIndex = 0
        '
        'descripciontxt
        '
        Me.descripciontxt.Location = New System.Drawing.Point(88, 63)
        Me.descripciontxt.Name = "descripciontxt"
        Me.descripciontxt.Size = New System.Drawing.Size(530, 20)
        Me.descripciontxt.TabIndex = 12
        '
        'chkdescripcion
        '
        Me.chkdescripcion.AutoSize = True
        Me.chkdescripcion.Location = New System.Drawing.Point(5, 65)
        Me.chkdescripcion.Name = "chkdescripcion"
        Me.chkdescripcion.Size = New System.Drawing.Size(88, 17)
        Me.chkdescripcion.TabIndex = 11
        Me.chkdescripcion.Text = "Descripcion :"
        Me.chkdescripcion.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton2, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripLabel4, Me.margen1txt, Me.aplicar_catalogo})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1007, 25)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ToolStripSplitButton2.Image = Global.AdminTegral.My.Resources.Resources.Ok_2
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripSplitButton2.Text = "Selectcionar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem1.Text = "Seleccionar Todos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem2.Text = "Quitar Seleccion"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Save
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripButton2.Text = "Aplicar Cambios"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel4.Text = "Margen :"
        '
        'margen1txt
        '
        Me.margen1txt.Name = "margen1txt"
        Me.margen1txt.Size = New System.Drawing.Size(30, 25)
        Me.margen1txt.Text = "10"
        '
        'aplicar_catalogo
        '
        Me.aplicar_catalogo.Image = Global.AdminTegral.My.Resources.Resources.Calc
        Me.aplicar_catalogo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.aplicar_catalogo.Name = "aplicar_catalogo"
        Me.aplicar_catalogo.Size = New System.Drawing.Size(121, 22)
        Me.aplicar_catalogo.Text = "Aplicar % margen"
        '
        'idgp
        '
        Me.idgp.Location = New System.Drawing.Point(690, 35)
        Me.idgp.Name = "idgp"
        Me.idgp.Size = New System.Drawing.Size(35, 20)
        Me.idgp.TabIndex = 9
        '
        'idpv
        '
        Me.idpv.Location = New System.Drawing.Point(88, 36)
        Me.idpv.Name = "idpv"
        Me.idpv.Size = New System.Drawing.Size(44, 20)
        Me.idpv.TabIndex = 8
        '
        'xgrupo
        '
        Me.xgrupo.AutoSize = True
        Me.xgrupo.Location = New System.Drawing.Point(632, 37)
        Me.xgrupo.Name = "xgrupo"
        Me.xgrupo.Size = New System.Drawing.Size(61, 17)
        Me.xgrupo.TabIndex = 7
        Me.xgrupo.Text = "Grupo :"
        Me.xgrupo.UseVisualStyleBackColor = True
        '
        'xprov
        '
        Me.xprov.AutoSize = True
        Me.xprov.Location = New System.Drawing.Point(5, 38)
        Me.xprov.Name = "xprov"
        Me.xprov.Size = New System.Drawing.Size(81, 17)
        Me.xprov.TabIndex = 6
        Me.xprov.Text = "Proveedor :"
        Me.xprov.UseVisualStyleBackColor = True
        '
        'boton_Cargar
        '
        Me.boton_Cargar.Location = New System.Drawing.Point(927, 34)
        Me.boton_Cargar.Name = "boton_Cargar"
        Me.boton_Cargar.Size = New System.Drawing.Size(75, 23)
        Me.boton_Cargar.TabIndex = 5
        Me.boton_Cargar.Text = "Cargar"
        Me.boton_Cargar.UseVisualStyleBackColor = True
        '
        'GrupoComboBox
        '
        Me.GrupoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposBindingSource, "Grupo", True))
        Me.GrupoComboBox.DataSource = Me.GruposBindingSource
        Me.GrupoComboBox.DisplayMember = "Grupo"
        Me.GrupoComboBox.FormattingEnabled = True
        Me.GrupoComboBox.Location = New System.Drawing.Point(731, 35)
        Me.GrupoComboBox.Name = "GrupoComboBox"
        Me.GrupoComboBox.Size = New System.Drawing.Size(190, 21)
        Me.GrupoComboBox.TabIndex = 4
        Me.GrupoComboBox.ValueMember = "id_grupos"
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.DirectorioBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(138, 36)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(480, 21)
        Me.NombreComboBox.TabIndex = 2
        Me.NombreComboBox.ValueMember = "id_directorio"
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1013, 435)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Reporte"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.ToolStrip3)
        Me.SplitContainer4.Panel1.Controls.Add(Me.dgvfechas)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer4.Panel2.Controls.Add(Me.ReportViewer2)
        Me.SplitContainer4.Size = New System.Drawing.Size(1007, 429)
        Me.SplitContainer4.SplitterDistance = 141
        Me.SplitContainer4.TabIndex = 0
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(141, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        Me.ToolStrip3.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'dgvfechas
        '
        Me.dgvfechas.AllowUserToAddRows = False
        Me.dgvfechas.AllowUserToDeleteRows = False
        Me.dgvfechas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvfechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvfechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ver})
        Me.dgvfechas.Location = New System.Drawing.Point(0, 28)
        Me.dgvfechas.Name = "dgvfechas"
        Me.dgvfechas.ReadOnly = True
        Me.dgvfechas.RowHeadersVisible = False
        Me.dgvfechas.Size = New System.Drawing.Size(141, 372)
        Me.dgvfechas.TabIndex = 0
        '
        'Ver
        '
        Me.Ver.HeaderText = "Ver"
        Me.Ver.Name = "Ver"
        Me.Ver.ReadOnly = True
        Me.Ver.Width = 29
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "admintegralDataSet_rpt_cambio_de_precios"
        ReportDataSource3.Value = Me.rpt_cambio_de_preciosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.Cambio_de_precios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(862, 429)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.AutoSize = True
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "admintegralDataSet_Lista_de_ventas"
        ReportDataSource4.Value = Nothing
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "AdminTegral.etiquetas.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(862, 429)
        Me.ReportViewer2.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1013, 435)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'rpt_cambio_de_preciosTableAdapter
        '
        Me.rpt_cambio_de_preciosTableAdapter.ClearBeforeFill = True
        '
        'boton_cargar_todo
        '
        Me.boton_cargar_todo.Location = New System.Drawing.Point(632, 60)
        Me.boton_cargar_todo.Name = "boton_cargar_todo"
        Me.boton_cargar_todo.Size = New System.Drawing.Size(75, 23)
        Me.boton_cargar_todo.TabIndex = 13
        Me.boton_cargar_todo.Text = "Cargar todo"
        Me.boton_cargar_todo.UseVisualStyleBackColor = True
        '
        'cambio_de_precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 461)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cambio_de_precios"
        Me.Text = "cambio_de_precios"
        CType(Me.rpt_cambio_de_preciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.dgvfechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SeleccionarTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarSeleccionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents guardar_cambios As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents margentxt As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
    Friend WithEvents xgrupo As System.Windows.Forms.CheckBox
    Friend WithEvents xprov As System.Windows.Forms.CheckBox
    Friend WithEvents boton_Cargar As System.Windows.Forms.Button
    Friend WithEvents GrupoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents idpv As System.Windows.Forms.TextBox
    Friend WithEvents idgp As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents margen1txt As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents aplicar_catalogo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvfechas As System.Windows.Forms.DataGridView
    Friend WithEvents Ver As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rpt_cambio_de_preciosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_cambio_de_preciosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_cambio_de_preciosTableAdapter
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents descripciontxt As System.Windows.Forms.TextBox
    Friend WithEvents chkdescripcion As System.Windows.Forms.CheckBox
    Friend WithEvents boton_cargar_todo As System.Windows.Forms.Button
End Class
