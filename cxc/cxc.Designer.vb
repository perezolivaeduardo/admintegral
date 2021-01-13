<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Id_agenteLabel As System.Windows.Forms.Label
        Dim RutaLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.cxc_pagos_detalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.cxc_saldos_x_facturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.filtrotxt = New System.Windows.Forms.TextBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lblcheques = New System.Windows.Forms.Label
        Me.RutaTextBox = New System.Windows.Forms.TextBox
        Me.Id_agenteTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.comentarios = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Direcciontxt = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.email = New System.Windows.Forms.TextBox
        Me.boton_guardar = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.disponible = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.limite = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.boton_calculadora = New System.Windows.Forms.ToolStripButton
        Me.boton_excel = New System.Windows.Forms.ToolStripButton
        Me.boton_reporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.boton_Cheques = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.boton_compras = New System.Windows.Forms.ToolStripButton
        Me.boton_Cotizaciones = New System.Windows.Forms.ToolStripButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.nombre = New System.Windows.Forms.TextBox
        Me.saldotxt = New System.Windows.Forms.TextBox
        Me.boton_salir = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.idtxt = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.Solosaldos = New System.Windows.Forms.CheckBox
        Me.dgvfacturas = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerDetalleDeLaFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerCFDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnviarArchivosCFDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.boton_todoslospagos = New System.Windows.Forms.Button
        Me.dgvpagos = New System.Windows.Forms.DataGridView
        Me.DirectorioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.cxc_saldos_x_facturaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
        Me.cxc_pagos_detalleTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_pagos_detalleTableAdapter
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
        Label1 = New System.Windows.Forms.Label
        Id_agenteLabel = New System.Windows.Forms.Label
        RutaLabel = New System.Windows.Forms.Label
        CType(Me.cxc_pagos_detalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxc_saldos_x_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 37)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(40, 13)
        Label1.TabIndex = 1
        Label1.Text = "Buscar"
        '
        'Id_agenteLabel
        '
        Id_agenteLabel.AutoSize = True
        Id_agenteLabel.Location = New System.Drawing.Point(11, 72)
        Id_agenteLabel.Name = "Id_agenteLabel"
        Id_agenteLabel.Size = New System.Drawing.Size(54, 13)
        Id_agenteLabel.TabIndex = 17
        Id_agenteLabel.Text = "id agente:"
        '
        'RutaLabel
        '
        RutaLabel.AutoSize = True
        RutaLabel.Location = New System.Drawing.Point(14, 117)
        RutaLabel.Name = "RutaLabel"
        RutaLabel.Size = New System.Drawing.Size(33, 13)
        RutaLabel.TabIndex = 18
        RutaLabel.Text = "Ruta:"
        '
        'cxc_pagos_detalleBindingSource
        '
        Me.cxc_pagos_detalleBindingSource.DataMember = "cxc_pagos_detalle"
        Me.cxc_pagos_detalleBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxc_saldos_x_facturaBindingSource
        '
        Me.cxc_saldos_x_facturaBindingSource.DataMember = "cxc_saldos_x_factura"
        Me.cxc_saldos_x_facturaBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'DirectorioBindingSource
        '
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
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(4, 60)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(348, 311)
        Me.dgv.TabIndex = 3
        '
        'filtrotxt
        '
        Me.filtrotxt.Location = New System.Drawing.Point(59, 34)
        Me.filtrotxt.Name = "filtrotxt"
        Me.filtrotxt.Size = New System.Drawing.Size(186, 20)
        Me.filtrotxt.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblcheques)
        Me.SplitContainer1.Panel1.Controls.Add(RutaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RutaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Id_agenteLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_agenteTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_guardar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.disponible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.limite)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nombre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.saldotxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.idtxt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(927, 538)
        Me.SplitContainer1.SplitterDistance = 160
        Me.SplitContainer1.TabIndex = 1
        '
        'lblcheques
        '
        Me.lblcheques.AutoSize = True
        Me.lblcheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcheques.ForeColor = System.Drawing.Color.White
        Me.lblcheques.Location = New System.Drawing.Point(545, 136)
        Me.lblcheques.Name = "lblcheques"
        Me.lblcheques.Size = New System.Drawing.Size(20, 18)
        Me.lblcheques.TabIndex = 20
        Me.lblcheques.Text = "..."
        '
        'RutaTextBox
        '
        Me.RutaTextBox.Location = New System.Drawing.Point(13, 131)
        Me.RutaTextBox.Name = "RutaTextBox"
        Me.RutaTextBox.ReadOnly = True
        Me.RutaTextBox.Size = New System.Drawing.Size(40, 20)
        Me.RutaTextBox.TabIndex = 19
        '
        'Id_agenteTextBox
        '
        Me.Id_agenteTextBox.Location = New System.Drawing.Point(12, 88)
        Me.Id_agenteTextBox.Name = "Id_agenteTextBox"
        Me.Id_agenteTextBox.ReadOnly = True
        Me.Id_agenteTextBox.Size = New System.Drawing.Size(40, 20)
        Me.Id_agenteTextBox.TabIndex = 18
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(92, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(447, 86)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.comentarios)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(439, 60)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Comentarios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'comentarios
        '
        Me.comentarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentarios.Location = New System.Drawing.Point(3, 3)
        Me.comentarios.MaxLength = 100
        Me.comentarios.Multiline = True
        Me.comentarios.Name = "comentarios"
        Me.comentarios.Size = New System.Drawing.Size(433, 54)
        Me.comentarios.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Direcciontxt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(439, 60)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Direccion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Direcciontxt
        '
        Me.Direcciontxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Direcciontxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direcciontxt.Location = New System.Drawing.Point(3, 3)
        Me.Direcciontxt.MaxLength = 100
        Me.Direcciontxt.Multiline = True
        Me.Direcciontxt.Name = "Direcciontxt"
        Me.Direcciontxt.Size = New System.Drawing.Size(433, 54)
        Me.Direcciontxt.TabIndex = 14
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.email)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(439, 60)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Email"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(6, 21)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(345, 20)
        Me.email.TabIndex = 0
        '
        'boton_guardar
        '
        Me.boton_guardar.Location = New System.Drawing.Point(545, 108)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(75, 23)
        Me.boton_guardar.TabIndex = 16
        Me.boton_guardar.Text = "Guardar"
        Me.boton_guardar.UseVisualStyleBackColor = True
        Me.boton_guardar.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AdminTegral.My.Resources.Resources.Note_Bag
        Me.PictureBox2.Location = New System.Drawing.Point(545, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(692, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Disponible :"
        '
        'disponible
        '
        Me.disponible.BackColor = System.Drawing.Color.LightSteelBlue
        Me.disponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disponible.ForeColor = System.Drawing.Color.White
        Me.disponible.Location = New System.Drawing.Point(783, 102)
        Me.disponible.Name = "disponible"
        Me.disponible.ReadOnly = True
        Me.disponible.Size = New System.Drawing.Size(141, 29)
        Me.disponible.TabIndex = 11
        Me.disponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(722, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Limite :"
        '
        'limite
        '
        Me.limite.BackColor = System.Drawing.Color.LightSteelBlue
        Me.limite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limite.ForeColor = System.Drawing.Color.White
        Me.limite.Location = New System.Drawing.Point(783, 72)
        Me.limite.Name = "limite"
        Me.limite.ReadOnly = True
        Me.limite.Size = New System.Drawing.Size(141, 29)
        Me.limite.TabIndex = 9
        Me.limite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.boton_calculadora, Me.boton_excel, Me.boton_reporte, Me.ToolStripButton2, Me.boton_Cheques, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.boton_compras, Me.boton_Cotizaciones})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(927, 39)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.search
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Buscar un Cliente"
        '
        'boton_calculadora
        '
        Me.boton_calculadora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_calculadora.Image = Global.AdminTegral.My.Resources.Resources.Calc
        Me.boton_calculadora.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_calculadora.Name = "boton_calculadora"
        Me.boton_calculadora.Size = New System.Drawing.Size(36, 36)
        Me.boton_calculadora.Text = "Calculadora"
        '
        'boton_excel
        '
        Me.boton_excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_excel.Image = Global.AdminTegral.My.Resources.Resources.excel
        Me.boton_excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_excel.Name = "boton_excel"
        Me.boton_excel.Size = New System.Drawing.Size(36, 36)
        Me.boton_excel.Text = "ToolStripButton2"
        '
        'boton_reporte
        '
        Me.boton_reporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_reporte.Image = Global.AdminTegral.My.Resources.Resources.Printer_Green
        Me.boton_reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_reporte.Name = "boton_reporte"
        Me.boton_reporte.Size = New System.Drawing.Size(36, 36)
        Me.boton_reporte.Text = "ToolStripButton2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Log_Off
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'boton_Cheques
        '
        Me.boton_Cheques.Image = Global.AdminTegral.My.Resources.Resources.Vista__155_
        Me.boton_Cheques.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_Cheques.Name = "boton_Cheques"
        Me.boton_Cheques.Size = New System.Drawing.Size(109, 36)
        Me.boton_Cheques.Text = "Ver Cheques"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.AdminTegral.My.Resources.Resources.Help_Documents_2
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(82, 36)
        Me.ToolStripButton3.Text = "Auxiliar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.AdminTegral.My.Resources.Resources.Administrator
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(152, 36)
        Me.ToolStripButton4.Text = "Catalogo de Clientes"
        '
        'boton_compras
        '
        Me.boton_compras.Image = Global.AdminTegral.My.Resources.Resources.shoppingcart_remove
        Me.boton_compras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_compras.Name = "boton_compras"
        Me.boton_compras.Size = New System.Drawing.Size(160, 36)
        Me.boton_compras.Text = "Productos comprados"
        '
        'boton_Cotizaciones
        '
        Me.boton_Cotizaciones.Image = Global.AdminTegral.My.Resources.Resources.folder_blue_favourite
        Me.boton_Cotizaciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_Cotizaciones.Name = "boton_Cotizaciones"
        Me.boton_Cotizaciones.Size = New System.Drawing.Size(152, 36)
        Me.boton_Cotizaciones.Text = "Productos Cotizados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(723, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Saldo :"
        '
        'nombre
        '
        Me.nombre.BackColor = System.Drawing.Color.LightSteelBlue
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.Color.White
        Me.nombre.Location = New System.Drawing.Point(157, 42)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(382, 29)
        Me.nombre.TabIndex = 6
        '
        'saldotxt
        '
        Me.saldotxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.saldotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldotxt.ForeColor = System.Drawing.Color.White
        Me.saldotxt.Location = New System.Drawing.Point(783, 42)
        Me.saldotxt.Name = "saldotxt"
        Me.saldotxt.ReadOnly = True
        Me.saldotxt.Size = New System.Drawing.Size(141, 29)
        Me.saldotxt.TabIndex = 5
        Me.saldotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(858, 20)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(57, 19)
        Me.boton_salir.TabIndex = 4
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID &Cliente:"
        '
        'idtxt
        '
        Me.idtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtxt.Location = New System.Drawing.Point(92, 42)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(59, 24)
        Me.idtxt.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgv)
        Me.SplitContainer2.Panel1.Controls.Add(Me.filtrotxt)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(927, 374)
        Me.SplitContainer2.SplitterDistance = 354
        Me.SplitContainer2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminTegral.My.Resources.Resources.Binoculars
        Me.PictureBox1.Location = New System.Drawing.Point(251, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer3.Panel1.Controls.Add(Me.Solosaldos)
        Me.SplitContainer3.Panel1.Controls.Add(Me.dgvfacturas)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(569, 374)
        Me.SplitContainer3.SplitterDistance = 305
        Me.SplitContainer3.TabIndex = 0
        '
        'Solosaldos
        '
        Me.Solosaldos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Solosaldos.AutoSize = True
        Me.Solosaldos.Location = New System.Drawing.Point(6, 345)
        Me.Solosaldos.Name = "Solosaldos"
        Me.Solosaldos.Size = New System.Drawing.Size(178, 17)
        Me.Solosaldos.TabIndex = 1
        Me.Solosaldos.Text = "Mostrar facturas solo con saldos"
        Me.Solosaldos.UseVisualStyleBackColor = True
        '
        'dgvfacturas
        '
        Me.dgvfacturas.AllowUserToAddRows = False
        Me.dgvfacturas.AllowUserToDeleteRows = False
        Me.dgvfacturas.AllowUserToResizeColumns = False
        Me.dgvfacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvfacturas.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfacturas.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvfacturas.GridColor = System.Drawing.Color.Blue
        Me.dgvfacturas.Location = New System.Drawing.Point(3, 3)
        Me.dgvfacturas.Name = "dgvfacturas"
        Me.dgvfacturas.ReadOnly = True
        Me.dgvfacturas.RowHeadersVisible = False
        Me.dgvfacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvfacturas.Size = New System.Drawing.Size(299, 339)
        Me.dgvfacturas.TabIndex = 0
        Me.dgvfacturas.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerDetalleDeLaFacturaToolStripMenuItem, Me.VerCFDToolStripMenuItem, Me.EnviarArchivosCFDToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 70)
        '
        'VerDetalleDeLaFacturaToolStripMenuItem
        '
        Me.VerDetalleDeLaFacturaToolStripMenuItem.Name = "VerDetalleDeLaFacturaToolStripMenuItem"
        Me.VerDetalleDeLaFacturaToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VerDetalleDeLaFacturaToolStripMenuItem.Text = "Ver detalle de la factura"
        '
        'VerCFDToolStripMenuItem
        '
        Me.VerCFDToolStripMenuItem.Name = "VerCFDToolStripMenuItem"
        Me.VerCFDToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VerCFDToolStripMenuItem.Text = "Ver CFD"
        '
        'EnviarArchivosCFDToolStripMenuItem
        '
        Me.EnviarArchivosCFDToolStripMenuItem.Name = "EnviarArchivosCFDToolStripMenuItem"
        Me.EnviarArchivosCFDToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EnviarArchivosCFDToolStripMenuItem.Text = "Enviar archivos CFD"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer4.Panel1.Controls.Add(Me.boton_todoslospagos)
        Me.SplitContainer4.Panel1.Controls.Add(Me.dgvpagos)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer4.Size = New System.Drawing.Size(260, 374)
        Me.SplitContainer4.SplitterDistance = 168
        Me.SplitContainer4.TabIndex = 0
        '
        'boton_todoslospagos
        '
        Me.boton_todoslospagos.Location = New System.Drawing.Point(3, 3)
        Me.boton_todoslospagos.Name = "boton_todoslospagos"
        Me.boton_todoslospagos.Size = New System.Drawing.Size(266, 21)
        Me.boton_todoslospagos.TabIndex = 4
        Me.boton_todoslospagos.Text = "Ver Todos los pagos"
        Me.boton_todoslospagos.UseVisualStyleBackColor = True
        '
        'dgvpagos
        '
        Me.dgvpagos.AllowUserToAddRows = False
        Me.dgvpagos.AllowUserToDeleteRows = False
        Me.dgvpagos.AllowUserToResizeColumns = False
        Me.dgvpagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvpagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvpagos.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpagos.GridColor = System.Drawing.Color.Blue
        Me.dgvpagos.Location = New System.Drawing.Point(3, 29)
        Me.dgvpagos.Name = "dgvpagos"
        Me.dgvpagos.ReadOnly = True
        Me.dgvpagos.RowHeadersVisible = False
        Me.dgvpagos.Size = New System.Drawing.Size(254, 136)
        Me.dgvpagos.TabIndex = 1
        Me.dgvpagos.TabStop = False
        '
        'DirectorioBindingSource1
        '
        Me.DirectorioBindingSource1.DataMember = "Directorio"
        Me.DirectorioBindingSource1.DataSource = Me.AdmintegralDataSet
        '
        'ReportViewer
        '
        Me.ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "pagos"
        ReportDataSource1.Value = Me.cxc_pagos_detalleBindingSource
        ReportDataSource2.Name = "facturas"
        ReportDataSource2.Value = Me.cxc_saldos_x_facturaBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "AdminTegral.cxc_saldo.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 42)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(927, 493)
        Me.ReportViewer.TabIndex = 2
        Me.ReportViewer.Visible = False
        '
        'cxc_saldos_x_facturaTableAdapter
        '
        Me.cxc_saldos_x_facturaTableAdapter.ClearBeforeFill = True
        '
        'cxc_pagos_detalleTableAdapter
        '
        Me.cxc_pagos_detalleTableAdapter.ClearBeforeFill = True
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'cxc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(927, 538)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "cxc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disponible :"
        CType(Me.cxc_pagos_detalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxc_saldos_x_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents filtrotxt As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idtxt As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents dgvfacturas As System.Windows.Forms.DataGridView
    Friend WithEvents saldotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvpagos As System.Windows.Forms.DataGridView
    Friend WithEvents boton_todoslospagos As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_calculadora As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents boton_excel As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents cxc_saldos_x_facturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cxc_pagos_detalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cxc_saldos_x_facturaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
    Friend WithEvents cxc_pagos_detalleTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_pagos_detalleTableAdapter
    Friend WithEvents Solosaldos As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents disponible As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents limite As System.Windows.Forms.TextBox
    Friend WithEvents comentarios As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_guardar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Direcciontxt As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerDetalleDeLaFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boton_Cheques As System.Windows.Forms.ToolStripButton
    Friend WithEvents DirectorioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents RutaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_agenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblcheques As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boton_compras As System.Windows.Forms.ToolStripButton
    Friend WithEvents VerCFDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boton_Cotizaciones As System.Windows.Forms.ToolStripButton
    Friend WithEvents EnviarArchivosCFDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
