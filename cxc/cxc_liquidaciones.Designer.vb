<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_liquidaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cxc_liquidaciones))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.cxc_saldos_x_facturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.boton_reporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.boton_borrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Button1 = New System.Windows.Forms.Button
        Me.boton_un_cliente = New System.Windows.Forms.Button
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.chkvencidas = New System.Windows.Forms.CheckBox
        Me.boton_Ok = New System.Windows.Forms.Button
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.id_agente = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.boton_carga_cobranza = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Combocobranza = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.filtrocliente = New System.Windows.Forms.TextBox
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.pagar = New System.Windows.Forms.DataGridViewButtonColumn
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.Boton_saltar = New System.Windows.Forms.Button
        Me.Boton_aplicar = New System.Windows.Forms.Button
        Me.Boton_salir_boleta = New System.Windows.Forms.Button
        Me.boton_guardar = New System.Windows.Forms.Button
        Me.grupo = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.pgcliente = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblagente = New System.Windows.Forms.Label
        Me.saldo = New System.Windows.Forms.TextBox
        Me.pgidcliente = New System.Windows.Forms.TextBox
        Me.agentecliente = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.idagentecliente = New System.Windows.Forms.TextBox
        Me.Boton_cancelar = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.pgvence = New System.Windows.Forms.DateTimePicker
        Me.pgfecha = New System.Windows.Forms.DateTimePicker
        Me.boton_cambiar_boleta = New System.Windows.Forms.Button
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_formasdepagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pgimporte = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.pgreferencia = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pgdocumento = New System.Windows.Forms.TextBox
        Me.pgforma = New System.Windows.Forms.TextBox
        Me.pgboleta = New System.Windows.Forms.TextBox
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.aplicadotxt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvfacturas = New System.Windows.Forms.DataGridView
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.abono = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.dsaldo = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.dimporte = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.dfecha = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.dcliente = New System.Windows.Forms.TextBox
        Me.dfolio = New System.Windows.Forms.TextBox
        Me.boton_reinicia_chofer = New System.Windows.Forms.Button
        Me.boton_guarda_chofer = New System.Windows.Forms.Button
        Me.dgvchofer = New System.Windows.Forms.DataGridView
        Me.AgentesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
        Me.cxc_saldos_x_facturaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
        Me.Tbl_formasdepagoTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_formasdepagoTableAdapter
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        NombreLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.cxc_saldos_x_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.grupo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_formasdepagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvchofer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Location = New System.Drawing.Point(765, 13)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 18)
        Label1.TabIndex = 7
        Label1.Text = "Fecha :"
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.boton_reporte, Me.ToolStripButton1, Me.boton_borrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1109, 57)
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
        Me.boton_reporte.Image = CType(resources.GetObject("boton_reporte.Image"), System.Drawing.Image)
        Me.boton_reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_reporte.Name = "boton_reporte"
        Me.boton_reporte.Size = New System.Drawing.Size(54, 54)
        Me.boton_reporte.Text = "Reporte de Cobranza"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'boton_borrar
        '
        Me.boton_borrar.Image = Global.AdminTegral.My.Resources.Resources.Recycle_Bin_Empty_2
        Me.boton_borrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_borrar.Name = "boton_borrar"
        Me.boton_borrar.Size = New System.Drawing.Size(132, 54)
        Me.boton_borrar.Text = "Borrar Recibo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Highlight
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(168, 54)
        Me.ToolStripButton2.Text = "Consultar un Recibo"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 57)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_un_cliente)
        Me.SplitContainer1.Panel1.Controls.Add(Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkvencidas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_Ok)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id_agente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1109, 428)
        Me.SplitContainer1.SplitterDistance = 52
        Me.SplitContainer1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(649, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Chofer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'boton_un_cliente
        '
        Me.boton_un_cliente.Location = New System.Drawing.Point(568, 8)
        Me.boton_un_cliente.Name = "boton_un_cliente"
        Me.boton_un_cliente.Size = New System.Drawing.Size(75, 27)
        Me.boton_un_cliente.TabIndex = 8
        Me.boton_un_cliente.Text = "Un cliente"
        Me.boton_un_cliente.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(828, 14)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(104, 20)
        Me.fecha.TabIndex = 6
        '
        'chkvencidas
        '
        Me.chkvencidas.AutoSize = True
        Me.chkvencidas.Location = New System.Drawing.Point(938, 17)
        Me.chkvencidas.Name = "chkvencidas"
        Me.chkvencidas.Size = New System.Drawing.Size(92, 17)
        Me.chkvencidas.TabIndex = 5
        Me.chkvencidas.Text = "solo Vencidas"
        Me.chkvencidas.UseVisualStyleBackColor = True
        '
        'boton_Ok
        '
        Me.boton_Ok.Location = New System.Drawing.Point(487, 7)
        Me.boton_Ok.Name = "boton_Ok"
        Me.boton_Ok.Size = New System.Drawing.Size(75, 27)
        Me.boton_Ok.TabIndex = 4
        Me.boton_Ok.Text = "Cargar"
        Me.boton_Ok.UseVisualStyleBackColor = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.AgentesBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(161, 8)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(320, 26)
        Me.NombreComboBox.TabIndex = 3
        Me.NombreComboBox.ValueMember = "id_agente"
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'id_agente
        '
        Me.id_agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_agente.Location = New System.Drawing.Point(110, 8)
        Me.id_agente.Name = "id_agente"
        Me.id_agente.Size = New System.Drawing.Size(45, 24)
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_carga_cobranza)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Combocobranza)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.filtrocliente)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvClientes)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1109, 372)
        Me.SplitContainer2.SplitterDistance = 575
        Me.SplitContainer2.TabIndex = 0
        '
        'boton_carga_cobranza
        '
        Me.boton_carga_cobranza.Location = New System.Drawing.Point(482, 25)
        Me.boton_carga_cobranza.Name = "boton_carga_cobranza"
        Me.boton_carga_cobranza.Size = New System.Drawing.Size(56, 23)
        Me.boton_carga_cobranza.TabIndex = 33
        Me.boton_carga_cobranza.Text = "Cargar"
        Me.boton_carga_cobranza.UseVisualStyleBackColor = True
        Me.boton_carga_cobranza.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(340, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 18)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Folios Pendientes"
        '
        'Combocobranza
        '
        Me.Combocobranza.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combocobranza.FormattingEnabled = True
        Me.Combocobranza.Location = New System.Drawing.Point(343, 24)
        Me.Combocobranza.Name = "Combocobranza"
        Me.Combocobranza.Size = New System.Drawing.Size(138, 26)
        Me.Combocobranza.TabIndex = 31
        Me.Combocobranza.Text = "Seleccione un Folio"
        Me.Combocobranza.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Filtrar :"
        '
        'filtrocliente
        '
        Me.filtrocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtrocliente.Location = New System.Drawing.Point(15, 24)
        Me.filtrocliente.Name = "filtrocliente"
        Me.filtrocliente.Size = New System.Drawing.Size(306, 24)
        Me.filtrocliente.TabIndex = 11
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pagar})
        Me.dgvClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvClientes.Location = New System.Drawing.Point(0, 57)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.Size = New System.Drawing.Size(575, 315)
        Me.dgvClientes.TabIndex = 0
        '
        'pagar
        '
        Me.pagar.HeaderText = "Pagar"
        Me.pagar.Name = "pagar"
        Me.pagar.Width = 41
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.Boton_saltar)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Boton_aplicar)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Boton_salir_boleta)
        Me.SplitContainer3.Panel1.Controls.Add(Me.boton_guardar)
        Me.SplitContainer3.Panel1.Controls.Add(Me.grupo)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Boton_cancelar)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer3.Panel1.Controls.Add(Me.pgvence)
        Me.SplitContainer3.Panel1.Controls.Add(Me.pgfecha)
        Me.SplitContainer3.Panel1.Controls.Add(Me.boton_cambiar_boleta)
        Me.SplitContainer3.Panel1.Controls.Add(Me.DescripcionComboBox)
        Me.SplitContainer3.Panel1.Controls.Add(Me.pgimporte)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer3.Panel1.Controls.Add(Me.pgreferencia)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.pgdocumento)
        Me.SplitContainer3.Panel1.Controls.Add(Me.pgforma)
        Me.SplitContainer3.Panel1.Controls.Add(Me.pgboleta)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(530, 372)
        Me.SplitContainer3.SplitterDistance = 486
        Me.SplitContainer3.TabIndex = 11
        '
        'Boton_saltar
        '
        Me.Boton_saltar.Location = New System.Drawing.Point(355, 116)
        Me.Boton_saltar.Name = "Boton_saltar"
        Me.Boton_saltar.Size = New System.Drawing.Size(58, 22)
        Me.Boton_saltar.TabIndex = 33
        Me.Boton_saltar.Text = "Saltar"
        Me.Boton_saltar.UseVisualStyleBackColor = True
        '
        'Boton_aplicar
        '
        Me.Boton_aplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Boton_aplicar.Location = New System.Drawing.Point(209, 283)
        Me.Boton_aplicar.Name = "Boton_aplicar"
        Me.Boton_aplicar.Size = New System.Drawing.Size(118, 23)
        Me.Boton_aplicar.TabIndex = 32
        Me.Boton_aplicar.Text = "Abono Automatico"
        Me.Boton_aplicar.UseVisualStyleBackColor = True
        '
        'Boton_salir_boleta
        '
        Me.Boton_salir_boleta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Boton_salir_boleta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Boton_salir_boleta.Location = New System.Drawing.Point(104, 337)
        Me.Boton_salir_boleta.Name = "Boton_salir_boleta"
        Me.Boton_salir_boleta.Size = New System.Drawing.Size(102, 23)
        Me.Boton_salir_boleta.TabIndex = 31
        Me.Boton_salir_boleta.Text = "Salir"
        Me.Boton_salir_boleta.UseVisualStyleBackColor = True
        '
        'boton_guardar
        '
        Me.boton_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.boton_guardar.Enabled = False
        Me.boton_guardar.Location = New System.Drawing.Point(229, 337)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(98, 23)
        Me.boton_guardar.TabIndex = 30
        Me.boton_guardar.Text = "Guardar"
        Me.boton_guardar.UseVisualStyleBackColor = True
        '
        'grupo
        '
        Me.grupo.Controls.Add(Me.PictureBox3)
        Me.grupo.Controls.Add(Me.pgcliente)
        Me.grupo.Controls.Add(Me.Label14)
        Me.grupo.Controls.Add(Me.lblagente)
        Me.grupo.Controls.Add(Me.saldo)
        Me.grupo.Controls.Add(Me.pgidcliente)
        Me.grupo.Controls.Add(Me.agentecliente)
        Me.grupo.Controls.Add(Me.Label3)
        Me.grupo.Controls.Add(Me.idagentecliente)
        Me.grupo.Location = New System.Drawing.Point(9, 2)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(417, 103)
        Me.grupo.TabIndex = 29
        Me.grupo.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AdminTegral.My.Resources.Resources.Note_Bag
        Me.PictureBox3.Location = New System.Drawing.Point(4, 58)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'pgcliente
        '
        Me.pgcliente.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pgcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgcliente.ForeColor = System.Drawing.Color.White
        Me.pgcliente.Location = New System.Drawing.Point(117, 39)
        Me.pgcliente.Name = "pgcliente"
        Me.pgcliente.ReadOnly = True
        Me.pgcliente.Size = New System.Drawing.Size(291, 24)
        Me.pgcliente.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(248, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 18)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Saldo :"
        '
        'lblagente
        '
        Me.lblagente.AutoSize = True
        Me.lblagente.Location = New System.Drawing.Point(5, 22)
        Me.lblagente.Name = "lblagente"
        Me.lblagente.Size = New System.Drawing.Size(47, 13)
        Me.lblagente.TabIndex = 26
        Me.lblagente.Text = "Agente :"
        '
        'saldo
        '
        Me.saldo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo.ForeColor = System.Drawing.Color.White
        Me.saldo.Location = New System.Drawing.Point(308, 67)
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Size = New System.Drawing.Size(100, 24)
        Me.saldo.TabIndex = 27
        Me.saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pgidcliente
        '
        Me.pgidcliente.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pgidcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgidcliente.ForeColor = System.Drawing.Color.White
        Me.pgidcliente.Location = New System.Drawing.Point(52, 39)
        Me.pgidcliente.Name = "pgidcliente"
        Me.pgidcliente.ReadOnly = True
        Me.pgidcliente.Size = New System.Drawing.Size(59, 24)
        Me.pgidcliente.TabIndex = 3
        '
        'agentecliente
        '
        Me.agentecliente.BackColor = System.Drawing.Color.CornflowerBlue
        Me.agentecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agentecliente.ForeColor = System.Drawing.Color.White
        Me.agentecliente.Location = New System.Drawing.Point(117, 15)
        Me.agentecliente.Name = "agentecliente"
        Me.agentecliente.ReadOnly = True
        Me.agentecliente.Size = New System.Drawing.Size(291, 22)
        Me.agentecliente.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cliente :"
        '
        'idagentecliente
        '
        Me.idagentecliente.BackColor = System.Drawing.Color.CornflowerBlue
        Me.idagentecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idagentecliente.ForeColor = System.Drawing.Color.White
        Me.idagentecliente.Location = New System.Drawing.Point(52, 15)
        Me.idagentecliente.Name = "idagentecliente"
        Me.idagentecliente.ReadOnly = True
        Me.idagentecliente.Size = New System.Drawing.Size(59, 22)
        Me.idagentecliente.TabIndex = 24
        '
        'Boton_cancelar
        '
        Me.Boton_cancelar.Location = New System.Drawing.Point(291, 116)
        Me.Boton_cancelar.Name = "Boton_cancelar"
        Me.Boton_cancelar.Size = New System.Drawing.Size(58, 22)
        Me.Boton_cancelar.TabIndex = 23
        Me.Boton_cancelar.Text = "Cancelar"
        Me.Boton_cancelar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Vence :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Fecha :"
        '
        'pgvence
        '
        Me.pgvence.Enabled = False
        Me.pgvence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.pgvence.Location = New System.Drawing.Point(112, 198)
        Me.pgvence.Name = "pgvence"
        Me.pgvence.Size = New System.Drawing.Size(87, 20)
        Me.pgvence.TabIndex = 6
        '
        'pgfecha
        '
        Me.pgfecha.Enabled = False
        Me.pgfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.pgfecha.Location = New System.Drawing.Point(112, 172)
        Me.pgfecha.Name = "pgfecha"
        Me.pgfecha.Size = New System.Drawing.Size(87, 20)
        Me.pgfecha.TabIndex = 5
        '
        'boton_cambiar_boleta
        '
        Me.boton_cambiar_boleta.Location = New System.Drawing.Point(227, 116)
        Me.boton_cambiar_boleta.Name = "boton_cambiar_boleta"
        Me.boton_cambiar_boleta.Size = New System.Drawing.Size(58, 22)
        Me.boton_cambiar_boleta.TabIndex = 18
        Me.boton_cambiar_boleta.Text = "Cambiar"
        Me.boton_cambiar_boleta.UseVisualStyleBackColor = True
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataSource = Me.Tbl_formasdepagoBindingSource
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(154, 145)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(195, 21)
        Me.DescripcionComboBox.TabIndex = 17
        Me.DescripcionComboBox.ValueMember = "id_fp"
        '
        'Tbl_formasdepagoBindingSource
        '
        Me.Tbl_formasdepagoBindingSource.DataMember = "tbl_formasdepago"
        Me.Tbl_formasdepagoBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'pgimporte
        '
        Me.pgimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgimporte.Location = New System.Drawing.Point(110, 282)
        Me.pgimporte.Name = "pgimporte"
        Me.pgimporte.Size = New System.Drawing.Size(89, 22)
        Me.pgimporte.TabIndex = 9
        Me.pgimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Importe :"
        '
        'pgreferencia
        '
        Me.pgreferencia.Enabled = False
        Me.pgreferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgreferencia.Location = New System.Drawing.Point(112, 254)
        Me.pgreferencia.Name = "pgreferencia"
        Me.pgreferencia.Size = New System.Drawing.Size(215, 22)
        Me.pgreferencia.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Referencia :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Documento/Banco :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Forma de Pago :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Recibo:"
        '
        'pgdocumento
        '
        Me.pgdocumento.Enabled = False
        Me.pgdocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgdocumento.Location = New System.Drawing.Point(110, 224)
        Me.pgdocumento.Name = "pgdocumento"
        Me.pgdocumento.Size = New System.Drawing.Size(217, 22)
        Me.pgdocumento.TabIndex = 7
        '
        'pgforma
        '
        Me.pgforma.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_formasdepagoBindingSource, "id_fp", True))
        Me.pgforma.Enabled = False
        Me.pgforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgforma.Location = New System.Drawing.Point(110, 144)
        Me.pgforma.Name = "pgforma"
        Me.pgforma.Size = New System.Drawing.Size(38, 22)
        Me.pgforma.TabIndex = 4
        '
        'pgboleta
        '
        Me.pgboleta.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pgboleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgboleta.ForeColor = System.Drawing.Color.White
        Me.pgboleta.Location = New System.Drawing.Point(112, 111)
        Me.pgboleta.Name = "pgboleta"
        Me.pgboleta.ReadOnly = True
        Me.pgboleta.Size = New System.Drawing.Size(111, 26)
        Me.pgboleta.TabIndex = 2
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.aplicadotxt)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer4.Panel1.Controls.Add(Me.dgvfacturas)
        Me.SplitContainer4.Panel1Collapsed = True
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer4.Size = New System.Drawing.Size(40, 372)
        Me.SplitContainer4.SplitterDistance = 25
        Me.SplitContainer4.TabIndex = 13
        '
        'aplicadotxt
        '
        Me.aplicadotxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.aplicadotxt.Enabled = False
        Me.aplicadotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aplicadotxt.Location = New System.Drawing.Point(486, 384)
        Me.aplicadotxt.Name = "aplicadotxt"
        Me.aplicadotxt.Size = New System.Drawing.Size(108, 26)
        Me.aplicadotxt.TabIndex = 14
        Me.aplicadotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-10, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(307, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Haga clic en el saldo si va a abonar el total"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(365, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total aplicado :"
        '
        'dgvfacturas
        '
        Me.dgvfacturas.AllowUserToAddRows = False
        Me.dgvfacturas.AllowUserToDeleteRows = False
        Me.dgvfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvfacturas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvfacturas.Location = New System.Drawing.Point(0, 0)
        Me.dgvfacturas.Name = "dgvfacturas"
        Me.dgvfacturas.RowHeadersVisible = False
        Me.dgvfacturas.Size = New System.Drawing.Size(25, 100)
        Me.dgvfacturas.TabIndex = 1
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer5.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer5.Panel1.Controls.Add(Me.abono)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer5.Panel1.Controls.Add(Me.dsaldo)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer5.Panel1.Controls.Add(Me.dimporte)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer5.Panel1.Controls.Add(Me.dfecha)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer5.Panel1.Controls.Add(Me.dcliente)
        Me.SplitContainer5.Panel1.Controls.Add(Me.dfolio)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer5.Panel2.Controls.Add(Me.boton_reinicia_chofer)
        Me.SplitContainer5.Panel2.Controls.Add(Me.boton_guarda_chofer)
        Me.SplitContainer5.Panel2.Controls.Add(Me.dgvchofer)
        Me.SplitContainer5.Size = New System.Drawing.Size(50, 372)
        Me.SplitContainer5.SplitterDistance = 167
        Me.SplitContainer5.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.AdminTegral.My.Resources.Resources.Transmit
        Me.PictureBox2.Location = New System.Drawing.Point(-81, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(41, 135)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 16)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Abono :"
        '
        'abono
        '
        Me.abono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abono.Location = New System.Drawing.Point(102, 132)
        Me.abono.Name = "abono"
        Me.abono.Size = New System.Drawing.Size(100, 22)
        Me.abono.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(41, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 16)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Saldo :"
        '
        'dsaldo
        '
        Me.dsaldo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.dsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsaldo.ForeColor = System.Drawing.Color.White
        Me.dsaldo.Location = New System.Drawing.Point(102, 105)
        Me.dsaldo.Name = "dsaldo"
        Me.dsaldo.ReadOnly = True
        Me.dsaldo.Size = New System.Drawing.Size(100, 22)
        Me.dsaldo.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(37, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 16)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Importe :"
        '
        'dimporte
        '
        Me.dimporte.BackColor = System.Drawing.Color.CornflowerBlue
        Me.dimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dimporte.ForeColor = System.Drawing.Color.White
        Me.dimporte.Location = New System.Drawing.Point(102, 80)
        Me.dimporte.Name = "dimporte"
        Me.dimporte.ReadOnly = True
        Me.dimporte.Size = New System.Drawing.Size(100, 22)
        Me.dimporte.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(41, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 16)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Fecha :"
        '
        'dfecha
        '
        Me.dfecha.BackColor = System.Drawing.Color.CornflowerBlue
        Me.dfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dfecha.ForeColor = System.Drawing.Color.White
        Me.dfecha.Location = New System.Drawing.Point(102, 56)
        Me.dfecha.Name = "dfecha"
        Me.dfecha.ReadOnly = True
        Me.dfecha.Size = New System.Drawing.Size(100, 22)
        Me.dfecha.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(41, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Cliente :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(41, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Folio :"
        '
        'dcliente
        '
        Me.dcliente.BackColor = System.Drawing.Color.CornflowerBlue
        Me.dcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcliente.ForeColor = System.Drawing.Color.White
        Me.dcliente.Location = New System.Drawing.Point(102, 33)
        Me.dcliente.Name = "dcliente"
        Me.dcliente.ReadOnly = True
        Me.dcliente.Size = New System.Drawing.Size(284, 22)
        Me.dcliente.TabIndex = 1
        '
        'dfolio
        '
        Me.dfolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dfolio.Location = New System.Drawing.Point(102, 9)
        Me.dfolio.Name = "dfolio"
        Me.dfolio.Size = New System.Drawing.Size(100, 22)
        Me.dfolio.TabIndex = 0
        '
        'boton_reinicia_chofer
        '
        Me.boton_reinicia_chofer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.boton_reinicia_chofer.Location = New System.Drawing.Point(3, 175)
        Me.boton_reinicia_chofer.Name = "boton_reinicia_chofer"
        Me.boton_reinicia_chofer.Size = New System.Drawing.Size(102, 23)
        Me.boton_reinicia_chofer.TabIndex = 17
        Me.boton_reinicia_chofer.Text = "Reinicia Recibo"
        Me.boton_reinicia_chofer.UseVisualStyleBackColor = True
        '
        'boton_guarda_chofer
        '
        Me.boton_guarda_chofer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.boton_guarda_chofer.Location = New System.Drawing.Point(399, 175)
        Me.boton_guarda_chofer.Name = "boton_guarda_chofer"
        Me.boton_guarda_chofer.Size = New System.Drawing.Size(102, 23)
        Me.boton_guarda_chofer.TabIndex = 16
        Me.boton_guarda_chofer.Text = "Guardar"
        Me.boton_guarda_chofer.UseVisualStyleBackColor = True
        '
        'dgvchofer
        '
        Me.dgvchofer.AllowUserToAddRows = False
        Me.dgvchofer.AllowUserToDeleteRows = False
        Me.dgvchofer.AllowUserToOrderColumns = True
        Me.dgvchofer.AllowUserToResizeColumns = False
        Me.dgvchofer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvchofer.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgvchofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvchofer.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvchofer.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dgvchofer.Location = New System.Drawing.Point(0, 0)
        Me.dgvchofer.Name = "dgvchofer"
        Me.dgvchofer.Size = New System.Drawing.Size(50, 169)
        Me.dgvchofer.TabIndex = 0
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'cxc_saldos_x_facturaTableAdapter
        '
        Me.cxc_saldos_x_facturaTableAdapter.ClearBeforeFill = True
        '
        'Tbl_formasdepagoTableAdapter
        '
        Me.Tbl_formasdepagoTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer
        '
        ReportDataSource1.Name = "facturas"
        ReportDataSource1.Value = Me.cxc_saldos_x_facturaBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "AdminTegral.cxc_relacion.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(1010, 313)
        Me.ReportViewer.TabIndex = 11
        Me.ReportViewer.Visible = False
        '
        'cxc_liquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 485)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "cxc_liquidaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO de Cobranza"
        CType(Me.cxc_saldos_x_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.grupo.ResumeLayout(False)
        Me.grupo.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_formasdepagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvchofer, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvfacturas As System.Windows.Forms.DataGridView
    Friend WithEvents chkvencidas As System.Windows.Forms.CheckBox
    Friend WithEvents cxc_saldos_x_facturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cxc_saldos_x_facturaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents pagar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents pgboleta As System.Windows.Forms.TextBox
    Friend WithEvents pgreferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pgdocumento As System.Windows.Forms.TextBox
    Friend WithEvents pgforma As System.Windows.Forms.TextBox
    Friend WithEvents pgidcliente As System.Windows.Forms.TextBox
    Friend WithEvents pgcliente As System.Windows.Forms.TextBox
    Friend WithEvents pgimporte As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tbl_formasdepagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_formasdepagoTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_formasdepagoTableAdapter
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents filtrocliente As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents boton_cambiar_boleta As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pgvence As System.Windows.Forms.DateTimePicker
    Friend WithEvents pgfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents boton_un_cliente As System.Windows.Forms.Button
    Friend WithEvents Boton_cancelar As System.Windows.Forms.Button
    Friend WithEvents boton_borrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents idagentecliente As System.Windows.Forms.TextBox
    Friend WithEvents agentecliente As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents saldo As System.Windows.Forms.TextBox
    Friend WithEvents lblagente As System.Windows.Forms.Label
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dcliente As System.Windows.Forms.TextBox
    Friend WithEvents dfolio As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents abono As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dsaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dimporte As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dfecha As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvchofer As System.Windows.Forms.DataGridView
    Friend WithEvents boton_reinicia_chofer As System.Windows.Forms.Button
    Friend WithEvents boton_guarda_chofer As System.Windows.Forms.Button
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Combocobranza As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents boton_carga_cobranza As System.Windows.Forms.Button
    Friend WithEvents Boton_aplicar As System.Windows.Forms.Button
    Friend WithEvents Boton_salir_boleta As System.Windows.Forms.Button
    Friend WithEvents boton_guardar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents aplicadotxt As System.Windows.Forms.TextBox
    Friend WithEvents Boton_saltar As System.Windows.Forms.Button
End Class
