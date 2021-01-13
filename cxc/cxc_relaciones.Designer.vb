<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_relaciones
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cxc_relaciones))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.cxc_saldos_x_facturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.boton_reporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.boton_guardar = New System.Windows.Forms.ToolStripButton
        Me.boton_leer_relacion = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.diasvencidos = New System.Windows.Forms.TextBox
        Me.chkseleccion = New System.Windows.Forms.CheckBox
        Me.chkruta = New System.Windows.Forms.CheckBox
        Me.boton_ruta = New System.Windows.Forms.Button
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox
        Me.ListasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rutatxt = New System.Windows.Forms.TextBox
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.idtxt = New System.Windows.Forms.TextBox
        Me.fecha_corte = New System.Windows.Forms.DateTimePicker
        Me.chktodas = New System.Windows.Forms.CheckBox
        Me.boton_Ok = New System.Windows.Forms.Button
        Me.id_agente = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Button2 = New System.Windows.Forms.Button
        Me.boton_deselect = New System.Windows.Forms.Button
        Me.filtroclientes = New System.Windows.Forms.TextBox
        Me.boton_select = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.solosaldos = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Boton_quitar_Seleccion_facturas = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.dgvfacturas = New System.Windows.Forms.DataGridView
        Me.AgentesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
        Me.cxc_saldos_x_facturaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
        Me.ListasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
        NombreLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.cxc_saldos_x_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(43, 11)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(61, 18)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Agente :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(599, 11)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 18)
        Label1.TabIndex = 7
        Label1.Text = "Corte :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(34, 7)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(53, 18)
        Label3.TabIndex = 9
        Label3.Text = "Filtrar :"
        '
        'cxc_saldos_x_facturaBindingSource
        '
        Me.cxc_saldos_x_facturaBindingSource.DataMember = "cxc_saldos_x_factura"
        Me.cxc_saldos_x_facturaBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.boton_reporte, Me.ToolStripButton1, Me.boton_guardar, Me.boton_leer_relacion, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1025, 57)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton3.Text = "Calculadora"
        '
        'boton_reporte
        '
        Me.boton_reporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_reporte.Enabled = False
        Me.boton_reporte.Image = CType(resources.GetObject("boton_reporte.Image"), System.Drawing.Image)
        Me.boton_reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_reporte.Name = "boton_reporte"
        Me.boton_reporte.Size = New System.Drawing.Size(54, 54)
        Me.boton_reporte.Text = "ToolStripButton2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton1.Text = "Salir"
        '
        'boton_guardar
        '
        Me.boton_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_guardar.Image = Global.AdminTegral.My.Resources.Resources.Save
        Me.boton_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(54, 54)
        Me.boton_guardar.Text = "Guardar Lista"
        '
        'boton_leer_relacion
        '
        Me.boton_leer_relacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_leer_relacion.Image = Global.AdminTegral.My.Resources.Resources.folder_blue_mypictures
        Me.boton_leer_relacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_leer_relacion.Name = "boton_leer_relacion"
        Me.boton_leer_relacion.Size = New System.Drawing.Size(54, 54)
        Me.boton_leer_relacion.Text = "Leer Relacion"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Vista__50_
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(109, 54)
        Me.ToolStripButton2.Text = "Catalogo"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 57)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.diasvencidos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkseleccion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkruta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_ruta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DescripcionComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rutatxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.idtxt)
        Me.SplitContainer1.Panel1.Controls.Add(Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha_corte)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chktodas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_Ok)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id_agente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1025, 460)
        Me.SplitContainer1.SplitterDistance = 65
        Me.SplitContainer1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(945, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Dias."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(746, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cargar las que tengan mas de"
        '
        'diasvencidos
        '
        Me.diasvencidos.Location = New System.Drawing.Point(900, 35)
        Me.diasvencidos.Name = "diasvencidos"
        Me.diasvencidos.Size = New System.Drawing.Size(39, 20)
        Me.diasvencidos.TabIndex = 17
        '
        'chkseleccion
        '
        Me.chkseleccion.AutoSize = True
        Me.chkseleccion.Location = New System.Drawing.Point(602, 37)
        Me.chkseleccion.Name = "chkseleccion"
        Me.chkseleccion.Size = New System.Drawing.Size(138, 17)
        Me.chkseleccion.TabIndex = 16
        Me.chkseleccion.Text = "Cargarlos Seleccionado"
        Me.chkseleccion.UseVisualStyleBackColor = True
        '
        'chkruta
        '
        Me.chkruta.AutoSize = True
        Me.chkruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkruta.Location = New System.Drawing.Point(37, 35)
        Me.chkruta.Name = "chkruta"
        Me.chkruta.Size = New System.Drawing.Size(61, 20)
        Me.chkruta.TabIndex = 15
        Me.chkruta.Text = "Ruta :"
        Me.chkruta.UseVisualStyleBackColor = True
        '
        'boton_ruta
        '
        Me.boton_ruta.Location = New System.Drawing.Point(503, 35)
        Me.boton_ruta.Name = "boton_ruta"
        Me.boton_ruta.Size = New System.Drawing.Size(76, 25)
        Me.boton_ruta.TabIndex = 14
        Me.boton_ruta.Text = "Cargar Ruta"
        Me.boton_ruta.UseVisualStyleBackColor = True
        Me.boton_ruta.Visible = False
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataSource = Me.ListasBindingSource
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(161, 37)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(336, 21)
        Me.DescripcionComboBox.TabIndex = 13
        Me.DescripcionComboBox.ValueMember = "id"
        Me.DescripcionComboBox.Visible = False
        '
        'ListasBindingSource
        '
        Me.ListasBindingSource.DataMember = "Listas"
        Me.ListasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'rutatxt
        '
        Me.rutatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rutatxt.Location = New System.Drawing.Point(103, 35)
        Me.rutatxt.Name = "rutatxt"
        Me.rutatxt.Size = New System.Drawing.Size(54, 22)
        Me.rutatxt.TabIndex = 12
        Me.rutatxt.Visible = False
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.AgentesBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(161, 9)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(337, 26)
        Me.NombreComboBox.TabIndex = 3
        Me.NombreComboBox.ValueMember = "id_agente"
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'idtxt
        '
        Me.idtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtxt.Location = New System.Drawing.Point(103, 9)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(54, 24)
        Me.idtxt.TabIndex = 0
        '
        'fecha_corte
        '
        Me.fecha_corte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_corte.Location = New System.Drawing.Point(653, 11)
        Me.fecha_corte.Name = "fecha_corte"
        Me.fecha_corte.Size = New System.Drawing.Size(104, 20)
        Me.fecha_corte.TabIndex = 6
        '
        'chktodas
        '
        Me.chktodas.AutoSize = True
        Me.chktodas.Location = New System.Drawing.Point(765, 13)
        Me.chktodas.Name = "chktodas"
        Me.chktodas.Size = New System.Drawing.Size(86, 17)
        Me.chktodas.TabIndex = 5
        Me.chktodas.Text = "Cargar todas"
        Me.chktodas.UseVisualStyleBackColor = True
        '
        'boton_Ok
        '
        Me.boton_Ok.Enabled = False
        Me.boton_Ok.Location = New System.Drawing.Point(504, 8)
        Me.boton_Ok.Name = "boton_Ok"
        Me.boton_Ok.Size = New System.Drawing.Size(75, 27)
        Me.boton_Ok.TabIndex = 4
        Me.boton_Ok.Text = "Cargar Todo"
        Me.boton_Ok.UseVisualStyleBackColor = True
        '
        'id_agente
        '
        Me.id_agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_agente.Location = New System.Drawing.Point(375, 11)
        Me.id_agente.Name = "id_agente"
        Me.id_agente.Size = New System.Drawing.Size(33, 24)
        Me.id_agente.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel1.Controls.Add(Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_deselect)
        Me.SplitContainer2.Panel1.Controls.Add(Me.filtroclientes)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_select)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvClientes)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ReportViewer)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer2.Panel2.Controls.Add(Me.solosaldos)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Boton_quitar_Seleccion_facturas)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvfacturas)
        Me.SplitContainer2.Size = New System.Drawing.Size(1025, 391)
        Me.SplitContainer2.SplitterDistance = 478
        Me.SplitContainer2.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(357, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Ver Seleccion"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'boton_deselect
        '
        Me.boton_deselect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.boton_deselect.Location = New System.Drawing.Point(123, 357)
        Me.boton_deselect.Name = "boton_deselect"
        Me.boton_deselect.Size = New System.Drawing.Size(116, 28)
        Me.boton_deselect.TabIndex = 8
        Me.boton_deselect.Text = "Quitar Seleccion"
        Me.boton_deselect.UseVisualStyleBackColor = True
        '
        'filtroclientes
        '
        Me.filtroclientes.AcceptsReturn = True
        Me.filtroclientes.Location = New System.Drawing.Point(94, 3)
        Me.filtroclientes.Name = "filtroclientes"
        Me.filtroclientes.Size = New System.Drawing.Size(392, 20)
        Me.filtroclientes.TabIndex = 8
        '
        'boton_select
        '
        Me.boton_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.boton_select.Location = New System.Drawing.Point(3, 357)
        Me.boton_select.Name = "boton_select"
        Me.boton_select.Size = New System.Drawing.Size(116, 28)
        Me.boton_select.TabIndex = 7
        Me.boton_select.Text = "Seleccionar"
        Me.boton_select.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(262, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Quitar Filtro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(0, 29)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(475, 322)
        Me.dgvClientes.TabIndex = 0
        '
        'ReportViewer
        '
        Me.ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "facturas"
        ReportDataSource1.Value = Me.cxc_saldos_x_facturaBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "AdminTegral.cxc_relacion.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(3, 28)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(925, 363)
        Me.ReportViewer.TabIndex = 10
        Me.ReportViewer.Visible = False
        '
        'solosaldos
        '
        Me.solosaldos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.solosaldos.AutoSize = True
        Me.solosaldos.Location = New System.Drawing.Point(433, 356)
        Me.solosaldos.Name = "solosaldos"
        Me.solosaldos.Size = New System.Drawing.Size(101, 17)
        Me.solosaldos.TabIndex = 11
        Me.solosaldos.Text = "Solo con saldos"
        Me.solosaldos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Facturas"
        '
        'Boton_quitar_Seleccion_facturas
        '
        Me.Boton_quitar_Seleccion_facturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton_quitar_Seleccion_facturas.Location = New System.Drawing.Point(177, 358)
        Me.Boton_quitar_Seleccion_facturas.Name = "Boton_quitar_Seleccion_facturas"
        Me.Boton_quitar_Seleccion_facturas.Size = New System.Drawing.Size(116, 28)
        Me.Boton_quitar_Seleccion_facturas.TabIndex = 9
        Me.Boton_quitar_Seleccion_facturas.Text = "Quitar Seleccion"
        Me.Boton_quitar_Seleccion_facturas.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(69, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 28)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Seleccionar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvfacturas
        '
        Me.dgvfacturas.AllowUserToAddRows = False
        Me.dgvfacturas.AllowUserToDeleteRows = False
        Me.dgvfacturas.AllowUserToResizeColumns = False
        Me.dgvfacturas.AllowUserToResizeRows = False
        Me.dgvfacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvfacturas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfacturas.Location = New System.Drawing.Point(3, 29)
        Me.dgvfacturas.Name = "dgvfacturas"
        Me.dgvfacturas.RowHeadersVisible = False
        Me.dgvfacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvfacturas.Size = New System.Drawing.Size(537, 323)
        Me.dgvfacturas.TabIndex = 1
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'cxc_saldos_x_facturaTableAdapter
        '
        Me.cxc_saldos_x_facturaTableAdapter.ClearBeforeFill = True
        '
        'ListasTableAdapter
        '
        Me.ListasTableAdapter.ClearBeforeFill = True
        '
        'cxc_relaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 517)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "cxc_relaciones"
        Me.Text = "Relacion de Cobranza"
        CType(Me.cxc_saldos_x_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents id_agente As System.Windows.Forms.TextBox
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents AgentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents boton_Ok As System.Windows.Forms.Button
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvfacturas As System.Windows.Forms.DataGridView
    Friend WithEvents boton_select As System.Windows.Forms.Button
    Friend WithEvents boton_deselect As System.Windows.Forms.Button
    Friend WithEvents chktodas As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cxc_saldos_x_facturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cxc_saldos_x_facturaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
    Friend WithEvents fecha_corte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Boton_quitar_Seleccion_facturas As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents filtroclientes As System.Windows.Forms.TextBox
    Friend WithEvents solosaldos As System.Windows.Forms.CheckBox
    Friend WithEvents idtxt As System.Windows.Forms.TextBox
    Friend WithEvents boton_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents rutatxt As System.Windows.Forms.TextBox
    Friend WithEvents ListasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
    Friend WithEvents boton_ruta As System.Windows.Forms.Button
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents chkruta As System.Windows.Forms.CheckBox
    Friend WithEvents boton_leer_relacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkseleccion As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents diasvencidos As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
