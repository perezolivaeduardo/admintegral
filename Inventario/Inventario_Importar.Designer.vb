<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario_Importar
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
        Dim Label16 As System.Windows.Forms.Label
        Dim AlmacenLabel1 As System.Windows.Forms.Label
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_Importar))
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.sql_existencias_x_almacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.rpt_inventario_fisicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_almacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.rpt_hojas_para_inventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter()
        Me.rpt_inventario_fisicoTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_inventario_fisicoTableAdapter()
        Me.sql_existencias_x_almacenTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_existencias_x_almacenTableAdapter()
        Me.rpt_hojas_para_inventarioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_hojas_para_inventarioTableAdapter()
        Me.GruposTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter()
        Me.rpt_stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpt_stockTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_stockTableAdapter()
        Me.reporteDataSet = New AdminTegral.reporteDataSet()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.barra = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.IgualarFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblstatus = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblufecha = New System.Windows.Forms.ToolStripLabel()
        Me.lblbarra = New System.Windows.Forms.Label()
        Me.boton_valida = New System.Windows.Forms.Button()
        Me.idalmacen = New System.Windows.Forms.TextBox()
        Me.filetxt = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.boton_salir = New System.Windows.Forms.Button()
        Me.boton_aplicar = New System.Windows.Forms.Button()
        Me.boton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fecha_inventario = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlmacenComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_aplica = New System.Windows.Forms.Button()
        Me.kfolio = New System.Windows.Forms.TextBox()
        Me.kalma = New System.Windows.Forms.TextBox()
        Me.fconteo = New System.Windows.Forms.TextBox()
        Me.alma = New System.Windows.Forms.TextBox()
        Me.fileinvtxt = New System.Windows.Forms.TextBox()
        Me.lblfolio = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgvcontado = New System.Windows.Forms.DataGridView()
        Me.bta_abrir_inv = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.btn_cargar_archivo_stock = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.boton_ajustar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.factor = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.Boton_refresh_stoks = New System.Windows.Forms.ToolStripButton()
        Me.lblstat = New System.Windows.Forms.ToolStripLabel()
        Me.boton_reporte = New System.Windows.Forms.ToolStripSplitButton()
        Me.SugerenciaDeSurtidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeStockYExistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.filtrar = New System.Windows.Forms.TextBox()
        Me.idgrupo = New System.Windows.Forms.TextBox()
        Me.combogrupo = New System.Windows.Forms.ComboBox()
        Me.dgvstock = New System.Windows.Forms.DataGridView()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtexcluir = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.filename = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.boton_hoja_prov = New System.Windows.Forms.Button()
        Me.idprov = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.nombreprov = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.filenametxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fecha_conteo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combo_almacen = New System.Windows.Forms.ComboBox()
        Me.boton_preparar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.selecgrupos = New System.Windows.Forms.TextBox()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.boton_guardar_hoja = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblfilename = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btn_resumen = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.boton_imprimir_Existencias = New System.Windows.Forms.Button()
        Me.fecha_existencia = New System.Windows.Forms.DateTimePicker()
        Me.AlmacenComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ReportViewerresume = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.dgvinv = New System.Windows.Forms.DataGridView()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Radiotodos = New System.Windows.Forms.RadioButton()
        Me.Radiopositivos = New System.Windows.Forms.RadioButton()
        Me.Radionegavtivos = New System.Windows.Forms.RadioButton()
        GrupoLabel = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        AlmacenLabel1 = New System.Windows.Forms.Label()
        AlmacenLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.sql_existencias_x_almacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_inventario_fisicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_hojas_para_inventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.dgvcontado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.factor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvinv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(9, 8)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(39, 13)
        GrupoLabel.TabIndex = 0
        GrupoLabel.Text = "Grupo:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(303, 8)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(69, 13)
        Label16.TabIndex = 3
        Label16.Text = "Descripcion :"
        '
        'AlmacenLabel1
        '
        AlmacenLabel1.AutoSize = True
        AlmacenLabel1.Location = New System.Drawing.Point(6, 43)
        AlmacenLabel1.Name = "AlmacenLabel1"
        AlmacenLabel1.Size = New System.Drawing.Size(51, 13)
        AlmacenLabel1.TabIndex = 0
        AlmacenLabel1.Text = "Almacen:"
        '
        'AlmacenLabel
        '
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Location = New System.Drawing.Point(21, 8)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(51, 13)
        AlmacenLabel.TabIndex = 0
        AlmacenLabel.Text = "Almacen:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(223, 11)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(67, 13)
        Label6.TabIndex = 3
        Label6.Text = "Fecha corte:"
        '
        'sql_existencias_x_almacenBindingSource
        '
        Me.sql_existencias_x_almacenBindingSource.DataMember = "sql_existencias_x_almacen"
        Me.sql_existencias_x_almacenBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpt_inventario_fisicoBindingSource
        '
        Me.rpt_inventario_fisicoBindingSource.DataMember = "rpt_inventario_fisico"
        Me.rpt_inventario_fisicoBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Tbl_almacenesBindingSource
        '
        Me.Tbl_almacenesBindingSource.DataMember = "tbl_almacenes"
        Me.Tbl_almacenesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Archivos Xls|*.Xls"
        '
        'rpt_hojas_para_inventarioBindingSource
        '
        Me.rpt_hojas_para_inventarioBindingSource.DataMember = "rpt_hojas_para_inventario"
        Me.rpt_hojas_para_inventarioBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Tbl_almacenesTableAdapter
        '
        Me.Tbl_almacenesTableAdapter.ClearBeforeFill = True
        '
        'rpt_inventario_fisicoTableAdapter
        '
        Me.rpt_inventario_fisicoTableAdapter.ClearBeforeFill = True
        '
        'sql_existencias_x_almacenTableAdapter
        '
        Me.sql_existencias_x_almacenTableAdapter.ClearBeforeFill = True
        '
        'rpt_hojas_para_inventarioTableAdapter
        '
        Me.rpt_hojas_para_inventarioTableAdapter.ClearBeforeFill = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'rpt_stockBindingSource
        '
        Me.rpt_stockBindingSource.DataMember = "rpt_stock"
        Me.rpt_stockBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'rpt_stockTableAdapter
        '
        Me.rpt_stockTableAdapter.ClearBeforeFill = True
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.ToolStrip)
        Me.TabPage1.Controls.Add(Me.lblbarra)
        Me.TabPage1.Controls.Add(Me.boton_valida)
        Me.TabPage1.Controls.Add(Me.idalmacen)
        Me.TabPage1.Controls.Add(Me.filetxt)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.boton_salir)
        Me.TabPage1.Controls.Add(Me.boton_aplicar)
        Me.TabPage1.Controls.Add(Me.boton)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Fecha_inventario)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.AlmacenComboBox)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.Color.SteelBlue
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(909, 427)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "-"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barra, Me.ToolStripButton1, Me.lblstatus, Me.ToolStripSeparator2, Me.lblufecha})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(899, 25)
        Me.ToolStrip.TabIndex = 18
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'barra
        '
        Me.barra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(100, 22)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IgualarFechaToolStripMenuItem, Me.CambiarFechaToolStripMenuItem})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripButton1.Text = "Hoja de Invenario"
        '
        'IgualarFechaToolStripMenuItem
        '
        Me.IgualarFechaToolStripMenuItem.Name = "IgualarFechaToolStripMenuItem"
        Me.IgualarFechaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.IgualarFechaToolStripMenuItem.Text = "Igualar Fecha"
        '
        'CambiarFechaToolStripMenuItem
        '
        Me.CambiarFechaToolStripMenuItem.Name = "CambiarFechaToolStripMenuItem"
        Me.CambiarFechaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CambiarFechaToolStripMenuItem.Text = "Cambiar Fecha"
        '
        'lblstatus
        '
        Me.lblstatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(0, 22)
        Me.lblstatus.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblufecha
        '
        Me.lblufecha.Name = "lblufecha"
        Me.lblufecha.Size = New System.Drawing.Size(0, 22)
        '
        'lblbarra
        '
        Me.lblbarra.AutoSize = True
        Me.lblbarra.Location = New System.Drawing.Point(669, 202)
        Me.lblbarra.Name = "lblbarra"
        Me.lblbarra.Size = New System.Drawing.Size(10, 13)
        Me.lblbarra.TabIndex = 17
        Me.lblbarra.Text = "."
        '
        'boton_valida
        '
        Me.boton_valida.Enabled = False
        Me.boton_valida.Location = New System.Drawing.Point(493, 177)
        Me.boton_valida.Name = "boton_valida"
        Me.boton_valida.Size = New System.Drawing.Size(60, 23)
        Me.boton_valida.TabIndex = 16
        Me.boton_valida.Text = "Validar"
        Me.boton_valida.UseVisualStyleBackColor = True
        '
        'idalmacen
        '
        Me.idalmacen.Enabled = False
        Me.idalmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idalmacen.Location = New System.Drawing.Point(152, 43)
        Me.idalmacen.Name = "idalmacen"
        Me.idalmacen.Size = New System.Drawing.Size(23, 26)
        Me.idalmacen.TabIndex = 14
        '
        'filetxt
        '
        Me.filetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filetxt.Location = New System.Drawing.Point(152, 141)
        Me.filetxt.Name = "filetxt"
        Me.filetxt.Size = New System.Drawing.Size(497, 26)
        Me.filetxt.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(152, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 26)
        Me.TextBox1.TabIndex = 7
        '
        'boton_salir
        '
        Me.boton_salir.Location = New System.Drawing.Point(624, 176)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 13
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'boton_aplicar
        '
        Me.boton_aplicar.Enabled = False
        Me.boton_aplicar.Location = New System.Drawing.Point(559, 177)
        Me.boton_aplicar.Name = "boton_aplicar"
        Me.boton_aplicar.Size = New System.Drawing.Size(59, 23)
        Me.boton_aplicar.TabIndex = 12
        Me.boton_aplicar.Text = "Aplicar"
        Me.boton_aplicar.UseVisualStyleBackColor = True
        '
        'boton
        '
        Me.boton.Location = New System.Drawing.Point(655, 147)
        Me.boton.Name = "boton"
        Me.boton.Size = New System.Drawing.Size(42, 23)
        Me.boton.TabIndex = 11
        Me.boton.Text = "..."
        Me.boton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(59, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Archivo :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dgv)
        Me.Panel1.Location = New System.Drawing.Point(3, 218)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 202)
        Me.Panel1.TabIndex = 8
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(778, 202)
        Me.dgv.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(17, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quien Conto:"
        '
        'Fecha_inventario
        '
        Me.Fecha_inventario.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_inventario.Enabled = False
        Me.Fecha_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_inventario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_inventario.Location = New System.Drawing.Point(152, 77)
        Me.Fecha_inventario.Name = "Fecha_inventario"
        Me.Fecha_inventario.Size = New System.Drawing.Size(125, 26)
        Me.Fecha_inventario.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(71, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha :"
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox.DisplayMember = "Almacen"
        Me.AlmacenComboBox.Enabled = False
        Me.AlmacenComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Location = New System.Drawing.Point(181, 44)
        Me.AlmacenComboBox.Name = "AlmacenComboBox"
        Me.AlmacenComboBox.Size = New System.Drawing.Size(196, 26)
        Me.AlmacenComboBox.TabIndex = 3
        Me.AlmacenComboBox.ValueMember = "id_almacen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(48, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Almacen :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(499, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Importar Inventario de Excel"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.btn_salir)
        Me.TabPage7.Controls.Add(Me.btn_aplica)
        Me.TabPage7.Controls.Add(Me.kfolio)
        Me.TabPage7.Controls.Add(Me.kalma)
        Me.TabPage7.Controls.Add(Me.fconteo)
        Me.TabPage7.Controls.Add(Me.alma)
        Me.TabPage7.Controls.Add(Me.fileinvtxt)
        Me.TabPage7.Controls.Add(Me.lblfolio)
        Me.TabPage7.Controls.Add(Me.Label15)
        Me.TabPage7.Controls.Add(Me.Label14)
        Me.TabPage7.Controls.Add(Me.dgvcontado)
        Me.TabPage7.Controls.Add(Me.bta_abrir_inv)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(909, 427)
        Me.TabPage7.TabIndex = 5
        Me.TabPage7.Text = "Importar inventario contado"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Location = New System.Drawing.Point(754, 89)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_aplica
        '
        Me.btn_aplica.Enabled = False
        Me.btn_aplica.Location = New System.Drawing.Point(206, 68)
        Me.btn_aplica.Name = "btn_aplica"
        Me.btn_aplica.Size = New System.Drawing.Size(105, 23)
        Me.btn_aplica.TabIndex = 10
        Me.btn_aplica.Text = "Aplicar Inventario"
        Me.btn_aplica.UseVisualStyleBackColor = True
        '
        'kfolio
        '
        Me.kfolio.Location = New System.Drawing.Point(93, 92)
        Me.kfolio.Name = "kfolio"
        Me.kfolio.ReadOnly = True
        Me.kfolio.Size = New System.Drawing.Size(107, 20)
        Me.kfolio.TabIndex = 9
        Me.kfolio.Visible = False
        '
        'kalma
        '
        Me.kalma.Location = New System.Drawing.Point(141, 40)
        Me.kalma.Name = "kalma"
        Me.kalma.ReadOnly = True
        Me.kalma.Size = New System.Drawing.Size(171, 20)
        Me.kalma.TabIndex = 7
        '
        'fconteo
        '
        Me.fconteo.Location = New System.Drawing.Point(93, 68)
        Me.fconteo.Name = "fconteo"
        Me.fconteo.ReadOnly = True
        Me.fconteo.Size = New System.Drawing.Size(107, 20)
        Me.fconteo.TabIndex = 6
        '
        'alma
        '
        Me.alma.Location = New System.Drawing.Point(83, 40)
        Me.alma.Name = "alma"
        Me.alma.ReadOnly = True
        Me.alma.Size = New System.Drawing.Size(52, 20)
        Me.alma.TabIndex = 5
        '
        'fileinvtxt
        '
        Me.fileinvtxt.Location = New System.Drawing.Point(8, 16)
        Me.fileinvtxt.Name = "fileinvtxt"
        Me.fileinvtxt.ReadOnly = True
        Me.fileinvtxt.Size = New System.Drawing.Size(304, 20)
        Me.fileinvtxt.TabIndex = 0
        '
        'lblfolio
        '
        Me.lblfolio.AutoSize = True
        Me.lblfolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfolio.Location = New System.Drawing.Point(38, 94)
        Me.lblfolio.Name = "lblfolio"
        Me.lblfolio.Size = New System.Drawing.Size(49, 18)
        Me.lblfolio.TabIndex = 8
        Me.lblfolio.Text = "Folio :"
        Me.lblfolio.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 18)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Fecha Inv.:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 18)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Almacen:"
        '
        'dgvcontado
        '
        Me.dgvcontado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvcontado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcontado.Location = New System.Drawing.Point(6, 118)
        Me.dgvcontado.Name = "dgvcontado"
        Me.dgvcontado.Size = New System.Drawing.Size(835, 293)
        Me.dgvcontado.TabIndex = 2
        '
        'bta_abrir_inv
        '
        Me.bta_abrir_inv.Location = New System.Drawing.Point(318, 16)
        Me.bta_abrir_inv.Name = "bta_abrir_inv"
        Me.bta_abrir_inv.Size = New System.Drawing.Size(75, 23)
        Me.bta_abrir_inv.TabIndex = 1
        Me.bta_abrir_inv.Text = "Abrir"
        Me.bta_abrir_inv.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.SplitContainer5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(909, 427)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Stocks"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.AutoScroll = True
        Me.SplitContainer5.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer5.Panel1.Controls.Add(Me.btn_cargar_archivo_stock)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer5.Panel1.Controls.Add(Me.ToolStrip3)
        Me.SplitContainer5.Panel1.Controls.Add(AlmacenLabel1)
        Me.SplitContainer5.Panel1.Controls.Add(Me.AlmacenComboBox2)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer5.Size = New System.Drawing.Size(903, 421)
        Me.SplitContainer5.SplitterDistance = 230
        Me.SplitContainer5.TabIndex = 0
        '
        'btn_cargar_archivo_stock
        '
        Me.btn_cargar_archivo_stock.Location = New System.Drawing.Point(58, 125)
        Me.btn_cargar_archivo_stock.Name = "btn_cargar_archivo_stock"
        Me.btn_cargar_archivo_stock.Size = New System.Drawing.Size(154, 23)
        Me.btn_cargar_archivo_stock.TabIndex = 6
        Me.btn_cargar_archivo_stock.Text = "captura desde archvio"
        Me.btn_cargar_archivo_stock.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 221)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 200)
        Me.Panel2.TabIndex = 5
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(230, 200)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.boton_ajustar)
        Me.TabPage6.Controls.Add(Me.Label12)
        Me.TabPage6.Controls.Add(Me.Label11)
        Me.TabPage6.Controls.Add(Me.factor)
        Me.TabPage6.Controls.Add(Me.Label10)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(222, 174)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Ajustar Stock's"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'boton_ajustar
        '
        Me.boton_ajustar.Location = New System.Drawing.Point(124, 145)
        Me.boton_ajustar.Name = "boton_ajustar"
        Me.boton_ajustar.Size = New System.Drawing.Size(92, 23)
        Me.boton_ajustar.TabIndex = 4
        Me.boton_ajustar.Text = "Ajustar Stock"
        Me.boton_ajustar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(141, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Dias de Venta."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Ajustar el Stock a"
        '
        'factor
        '
        Me.factor.Location = New System.Drawing.Point(96, 87)
        Me.factor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.factor.Name = "factor"
        Me.factor.Size = New System.Drawing.Size(42, 20)
        Me.factor.TabIndex = 1
        Me.factor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-1, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 48)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Ajustar los stock's de acuerdo al " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "promerio diario de ventas, se puede" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ajustar " & _
    "par 'x' Dias de ventas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cargar Existencias"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cargar Stocks"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Boton_refresh_stoks, Me.lblstat, Me.boton_reporte})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(230, 25)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'Boton_refresh_stoks
        '
        Me.Boton_refresh_stoks.Image = Global.AdminTegral.My.Resources.Resources.repeat
        Me.Boton_refresh_stoks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_refresh_stoks.Name = "Boton_refresh_stoks"
        Me.Boton_refresh_stoks.Size = New System.Drawing.Size(135, 22)
        Me.Boton_refresh_stoks.Text = "Actualiza Promedios"
        '
        'lblstat
        '
        Me.lblstat.Name = "lblstat"
        Me.lblstat.Size = New System.Drawing.Size(10, 22)
        Me.lblstat.Text = " "
        '
        'boton_reporte
        '
        Me.boton_reporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_reporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SugerenciaDeSurtidoToolStripMenuItem, Me.ReporteDeStockYExistToolStripMenuItem})
        Me.boton_reporte.Image = Global.AdminTegral.My.Resources.Resources.fileprint
        Me.boton_reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_reporte.Name = "boton_reporte"
        Me.boton_reporte.Size = New System.Drawing.Size(32, 22)
        Me.boton_reporte.Text = "Reporte de Stok"
        '
        'SugerenciaDeSurtidoToolStripMenuItem
        '
        Me.SugerenciaDeSurtidoToolStripMenuItem.Name = "SugerenciaDeSurtidoToolStripMenuItem"
        Me.SugerenciaDeSurtidoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.SugerenciaDeSurtidoToolStripMenuItem.Text = "Sugerencia de Surtido"
        '
        'ReporteDeStockYExistToolStripMenuItem
        '
        Me.ReporteDeStockYExistToolStripMenuItem.Name = "ReporteDeStockYExistToolStripMenuItem"
        Me.ReporteDeStockYExistToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ReporteDeStockYExistToolStripMenuItem.Text = "Reporte de Stock y Exist."
        '
        'AlmacenComboBox2
        '
        Me.AlmacenComboBox2.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox2.DisplayMember = "Almacen"
        Me.AlmacenComboBox2.FormattingEnabled = True
        Me.AlmacenComboBox2.Location = New System.Drawing.Point(58, 40)
        Me.AlmacenComboBox2.Name = "AlmacenComboBox2"
        Me.AlmacenComboBox2.Size = New System.Drawing.Size(154, 21)
        Me.AlmacenComboBox2.TabIndex = 1
        Me.AlmacenComboBox2.ValueMember = "id_almacen"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.AutoScroll = True
        Me.SplitContainer6.Panel1.Controls.Add(Me.filtrar)
        Me.SplitContainer6.Panel1.Controls.Add(Label16)
        Me.SplitContainer6.Panel1.Controls.Add(Me.idgrupo)
        Me.SplitContainer6.Panel1.Controls.Add(GrupoLabel)
        Me.SplitContainer6.Panel1.Controls.Add(Me.combogrupo)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.dgvstock)
        Me.SplitContainer6.Panel2.Controls.Add(Me.ReportViewer4)
        Me.SplitContainer6.Size = New System.Drawing.Size(669, 421)
        Me.SplitContainer6.SplitterDistance = 45
        Me.SplitContainer6.TabIndex = 0
        '
        'filtrar
        '
        Me.filtrar.Location = New System.Drawing.Point(378, 6)
        Me.filtrar.Name = "filtrar"
        Me.filtrar.Size = New System.Drawing.Size(168, 20)
        Me.filtrar.TabIndex = 4
        '
        'idgrupo
        '
        Me.idgrupo.Location = New System.Drawing.Point(51, 6)
        Me.idgrupo.Name = "idgrupo"
        Me.idgrupo.Size = New System.Drawing.Size(45, 20)
        Me.idgrupo.TabIndex = 2
        '
        'combogrupo
        '
        Me.combogrupo.DataSource = Me.GruposBindingSource
        Me.combogrupo.DisplayMember = "Grupo"
        Me.combogrupo.FormattingEnabled = True
        Me.combogrupo.Location = New System.Drawing.Point(109, 5)
        Me.combogrupo.Name = "combogrupo"
        Me.combogrupo.Size = New System.Drawing.Size(161, 21)
        Me.combogrupo.TabIndex = 1
        Me.combogrupo.ValueMember = "id_grupos"
        '
        'dgvstock
        '
        Me.dgvstock.AllowUserToAddRows = False
        Me.dgvstock.AllowUserToDeleteRows = False
        Me.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvstock.Location = New System.Drawing.Point(0, 0)
        Me.dgvstock.Name = "dgvstock"
        Me.dgvstock.Size = New System.Drawing.Size(669, 372)
        Me.dgvstock.TabIndex = 0
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "AdminTegral.reporte_stocks.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(669, 372)
        Me.ReportViewer4.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(909, 427)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Perparar Hoja"
        Me.TabPage4.UseVisualStyleBackColor = True
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
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button6)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button8)
        Me.SplitContainer3.Panel1.Controls.Add(Me.boton_hoja_prov)
        Me.SplitContainer3.Panel1.Controls.Add(Me.idprov)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button5)
        Me.SplitContainer3.Panel1.Controls.Add(Me.nombreprov)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer3.Panel1.Controls.Add(Me.filenametxt)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer3.Panel1.Controls.Add(Me.fecha_conteo)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer3.Panel1.Controls.Add(Me.combo_almacen)
        Me.SplitContainer3.Panel1.Controls.Add(Me.boton_preparar)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer3.Panel1.Controls.Add(Me.selecgrupos)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(909, 427)
        Me.SplitContainer3.SplitterDistance = 217
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtexcluir)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.filename)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 108)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear archivo"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(141, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Excluir Grupos  (Ej.  100,25,)"
        '
        'txtexcluir
        '
        Me.txtexcluir.Location = New System.Drawing.Point(6, 79)
        Me.txtexcluir.Name = "txtexcluir"
        Me.txtexcluir.Size = New System.Drawing.Size(181, 20)
        Me.txtexcluir.TabIndex = 18
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(145, 40)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(46, 23)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "..."
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'filename
        '
        Me.filename.Location = New System.Drawing.Point(6, 19)
        Me.filename.Name = "filename"
        Me.filename.Size = New System.Drawing.Size(185, 20)
        Me.filename.TabIndex = 15
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 170)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 22)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Preparar Todo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(121, 396)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(78, 23)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "Crear archivo"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'boton_hoja_prov
        '
        Me.boton_hoja_prov.Enabled = False
        Me.boton_hoja_prov.Location = New System.Drawing.Point(129, 253)
        Me.boton_hoja_prov.Name = "boton_hoja_prov"
        Me.boton_hoja_prov.Size = New System.Drawing.Size(75, 22)
        Me.boton_hoja_prov.TabIndex = 13
        Me.boton_hoja_prov.Text = "Preparar Hoja"
        Me.boton_hoja_prov.UseVisualStyleBackColor = True
        '
        'idprov
        '
        Me.idprov.Location = New System.Drawing.Point(69, 201)
        Me.idprov.Name = "idprov"
        Me.idprov.ReadOnly = True
        Me.idprov.Size = New System.Drawing.Size(44, 20)
        Me.idprov.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(121, 201)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(34, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'nombreprov
        '
        Me.nombreprov.Location = New System.Drawing.Point(8, 227)
        Me.nombreprov.Name = "nombreprov"
        Me.nombreprov.ReadOnly = True
        Me.nombreprov.Size = New System.Drawing.Size(207, 20)
        Me.nombreprov.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Proveedor:"
        '
        'filenametxt
        '
        Me.filenametxt.Enabled = False
        Me.filenametxt.Location = New System.Drawing.Point(8, 105)
        Me.filenametxt.Name = "filenametxt"
        Me.filenametxt.Size = New System.Drawing.Size(196, 20)
        Me.filenametxt.TabIndex = 8
        Me.filenametxt.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Fecha de Conteo :"
        '
        'fecha_conteo
        '
        Me.fecha_conteo.Location = New System.Drawing.Point(8, 79)
        Me.fecha_conteo.Name = "fecha_conteo"
        Me.fecha_conteo.Size = New System.Drawing.Size(200, 20)
        Me.fecha_conteo.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Almacen :"
        '
        'combo_almacen
        '
        Me.combo_almacen.DataSource = Me.Tbl_almacenesBindingSource
        Me.combo_almacen.DisplayMember = "Almacen"
        Me.combo_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_almacen.FormattingEnabled = True
        Me.combo_almacen.Location = New System.Drawing.Point(8, 32)
        Me.combo_almacen.Name = "combo_almacen"
        Me.combo_almacen.Size = New System.Drawing.Size(196, 26)
        Me.combo_almacen.TabIndex = 4
        Me.combo_almacen.ValueMember = "id_almacen"
        '
        'boton_preparar
        '
        Me.boton_preparar.Enabled = False
        Me.boton_preparar.Location = New System.Drawing.Point(129, 170)
        Me.boton_preparar.Name = "boton_preparar"
        Me.boton_preparar.Size = New System.Drawing.Size(75, 22)
        Me.boton_preparar.TabIndex = 2
        Me.boton_preparar.Text = "Preparar Hoja"
        Me.boton_preparar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Seleccionar Grupos (ej. 1,2,4)"
        '
        'selecgrupos
        '
        Me.selecgrupos.Location = New System.Drawing.Point(11, 144)
        Me.selecgrupos.Name = "selecgrupos"
        Me.selecgrupos.Size = New System.Drawing.Size(193, 20)
        Me.selecgrupos.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer4.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer4.Panel2.Controls.Add(Me.ReportViewer3)
        Me.SplitContainer4.Size = New System.Drawing.Size(688, 427)
        Me.SplitContainer4.SplitterDistance = 55
        Me.SplitContainer4.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_guardar_hoja})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(688, 39)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'boton_guardar_hoja
        '
        Me.boton_guardar_hoja.Image = Global.AdminTegral.My.Resources.Resources.excel
        Me.boton_guardar_hoja.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_guardar_hoja.Name = "boton_guardar_hoja"
        Me.boton_guardar_hoja.Size = New System.Drawing.Size(113, 36)
        Me.boton_guardar_hoja.Text = "Guardar Hoja"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblfilename})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 346)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(688, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblfilename
        '
        Me.lblfilename.Name = "lblfilename"
        Me.lblfilename.Size = New System.Drawing.Size(0, 17)
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "AdminTegral.hojas_para_inventario.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(688, 368)
        Me.ReportViewer3.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1038, 427)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Existencias"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.Radionegavtivos)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Radiopositivos)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Radiotodos)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_resumen)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_imprimir_Existencias)
        Me.SplitContainer2.Panel1.Controls.Add(Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.fecha_existencia)
        Me.SplitContainer2.Panel1.Controls.Add(AlmacenLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AlmacenComboBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ReportViewer2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ReportViewerresume)
        Me.SplitContainer2.Size = New System.Drawing.Size(1032, 421)
        Me.SplitContainer2.SplitterDistance = 63
        Me.SplitContainer2.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(840, 8)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Excel"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btn_resumen
        '
        Me.btn_resumen.Location = New System.Drawing.Point(734, 8)
        Me.btn_resumen.Name = "btn_resumen"
        Me.btn_resumen.Size = New System.Drawing.Size(100, 23)
        Me.btn_resumen.TabIndex = 7
        Me.btn_resumen.Text = "Resume x Gpo"
        Me.btn_resumen.UseVisualStyleBackColor = True
        Me.btn_resumen.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(921, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Negativos"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(618, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Resumen de Costo "
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'boton_imprimir_Existencias
        '
        Me.boton_imprimir_Existencias.Location = New System.Drawing.Point(454, 6)
        Me.boton_imprimir_Existencias.Name = "boton_imprimir_Existencias"
        Me.boton_imprimir_Existencias.Size = New System.Drawing.Size(56, 23)
        Me.boton_imprimir_Existencias.TabIndex = 4
        Me.boton_imprimir_Existencias.Text = "Ok"
        Me.boton_imprimir_Existencias.UseVisualStyleBackColor = True
        '
        'fecha_existencia
        '
        Me.fecha_existencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_existencia.Location = New System.Drawing.Point(296, 9)
        Me.fecha_existencia.Name = "fecha_existencia"
        Me.fecha_existencia.Size = New System.Drawing.Size(140, 20)
        Me.fecha_existencia.TabIndex = 2
        '
        'AlmacenComboBox1
        '
        Me.AlmacenComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_almacenesBindingSource, "Almacen", True))
        Me.AlmacenComboBox1.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox1.DisplayMember = "Almacen"
        Me.AlmacenComboBox1.FormattingEnabled = True
        Me.AlmacenComboBox1.Location = New System.Drawing.Point(78, 8)
        Me.AlmacenComboBox1.Name = "AlmacenComboBox1"
        Me.AlmacenComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.AlmacenComboBox1.TabIndex = 1
        Me.AlmacenComboBox1.ValueMember = "id_almacen"
        '
        'ReportViewerresume
        '
        Me.ReportViewerresume.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "admintegralDataSet_sql_existencias_x_almacen"
        ReportDataSource6.Value = Me.sql_existencias_x_almacenBindingSource
        Me.ReportViewerresume.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewerresume.LocalReport.ReportEmbeddedResource = "AdminTegral.Existencias_CostoXalmacen.rdlc"
        Me.ReportViewerresume.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerresume.Name = "ReportViewerresume"
        Me.ReportViewerresume.Size = New System.Drawing.Size(1032, 354)
        Me.ReportViewerresume.TabIndex = 2
        Me.ReportViewerresume.Visible = False
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer2.DocumentMapWidth = 200
        ReportDataSource5.Name = "tabla"
        ReportDataSource5.Value = Me.sql_existencias_x_almacenBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "AdminTegral.Existencias_almacen.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1032, 354)
        Me.ReportViewer2.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(909, 427)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de Inventarios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvinv)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(903, 421)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(266, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.repeat
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.AdminTegral.My.Resources.Resources.Delete
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripButton4.Text = "Reporte Contado"
        '
        'dgvinv
        '
        Me.dgvinv.AllowUserToAddRows = False
        Me.dgvinv.AllowUserToDeleteRows = False
        Me.dgvinv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvinv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinv.Location = New System.Drawing.Point(3, 44)
        Me.dgvinv.Name = "dgvinv"
        Me.dgvinv.ReadOnly = True
        Me.dgvinv.RowHeadersVisible = False
        Me.dgvinv.Size = New System.Drawing.Size(263, 372)
        Me.dgvinv.TabIndex = 0
        '
        'ReportViewer5
        '
        Me.ReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource7.Name = "tabla"
        ReportDataSource7.Value = Me.sql_existencias_x_almacenBindingSource
        Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "AdminTegral.Existencias_almacen.rdlc"
        Me.ReportViewer5.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.Size = New System.Drawing.Size(633, 421)
        Me.ReportViewer5.TabIndex = 1
        Me.ReportViewer5.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource8.Name = "admintegralDataSet_rpt_inventario_fisico"
        ReportDataSource8.Value = Me.rpt_inventario_fisicoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.inventario_fisico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(633, 421)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1046, 453)
        Me.TabControl1.TabIndex = 0
        '
        'Radiotodos
        '
        Me.Radiotodos.AutoSize = True
        Me.Radiotodos.Checked = True
        Me.Radiotodos.Location = New System.Drawing.Point(5, 39)
        Me.Radiotodos.Name = "Radiotodos"
        Me.Radiotodos.Size = New System.Drawing.Size(50, 17)
        Me.Radiotodos.TabIndex = 9
        Me.Radiotodos.TabStop = True
        Me.Radiotodos.Text = "Todo"
        Me.Radiotodos.UseVisualStyleBackColor = True
        '
        'Radiopositivos
        '
        Me.Radiopositivos.AutoSize = True
        Me.Radiopositivos.Location = New System.Drawing.Point(61, 39)
        Me.Radiopositivos.Name = "Radiopositivos"
        Me.Radiopositivos.Size = New System.Drawing.Size(97, 17)
        Me.Radiopositivos.TabIndex = 10
        Me.Radiopositivos.Text = "Solo Existencia"
        Me.Radiopositivos.UseVisualStyleBackColor = True
        '
        'Radionegavtivos
        '
        Me.Radionegavtivos.AutoSize = True
        Me.Radionegavtivos.Location = New System.Drawing.Point(164, 39)
        Me.Radionegavtivos.Name = "Radionegavtivos"
        Me.Radionegavtivos.Size = New System.Drawing.Size(97, 17)
        Me.Radionegavtivos.TabIndex = 11
        Me.Radionegavtivos.Text = "Solo Negativos"
        Me.Radionegavtivos.UseVisualStyleBackColor = True
        '
        'Inventario_Importar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 453)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Inventario_Importar"
        Me.Text = "Captura de Inventarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sql_existencias_x_almacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_inventario_fisicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_hojas_para_inventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.dgvcontado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.factor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel1.PerformLayout()
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvinv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Tbl_almacenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_almacenesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rpt_inventario_fisicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_inventario_fisicoTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_inventario_fisicoTableAdapter
    Friend WithEvents sql_existencias_x_almacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sql_existencias_x_almacenTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_existencias_x_almacenTableAdapter
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents rpt_hojas_para_inventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_hojas_para_inventarioTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_hojas_para_inventarioTableAdapter
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
    Friend WithEvents rpt_stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_stockTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_stockTableAdapter
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents barra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents IgualarFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblstatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblufecha As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblbarra As System.Windows.Forms.Label
    Friend WithEvents boton_valida As System.Windows.Forms.Button
    Friend WithEvents idalmacen As System.Windows.Forms.TextBox
    Friend WithEvents filetxt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents boton_aplicar As System.Windows.Forms.Button
    Friend WithEvents boton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Fecha_inventario As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AlmacenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_aplica As System.Windows.Forms.Button
    Friend WithEvents kfolio As System.Windows.Forms.TextBox
    Friend WithEvents kalma As System.Windows.Forms.TextBox
    Friend WithEvents fconteo As System.Windows.Forms.TextBox
    Friend WithEvents alma As System.Windows.Forms.TextBox
    Friend WithEvents fileinvtxt As System.Windows.Forms.TextBox
    Friend WithEvents lblfolio As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dgvcontado As System.Windows.Forms.DataGridView
    Friend WithEvents bta_abrir_inv As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_cargar_archivo_stock As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents boton_ajustar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents factor As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents Boton_refresh_stoks As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblstat As System.Windows.Forms.ToolStripLabel
    Friend WithEvents boton_reporte As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SugerenciaDeSurtidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeStockYExistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlmacenComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents filtrar As System.Windows.Forms.TextBox
    Friend WithEvents idgrupo As System.Windows.Forms.TextBox
    Friend WithEvents combogrupo As System.Windows.Forms.ComboBox
    Friend WithEvents dgvstock As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents filename As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents boton_hoja_prov As System.Windows.Forms.Button
    Friend WithEvents idprov As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents nombreprov As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents filenametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents fecha_conteo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents combo_almacen As System.Windows.Forms.ComboBox
    Friend WithEvents boton_preparar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents selecgrupos As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_guardar_hoja As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblfilename As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btn_resumen As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents boton_imprimir_Existencias As System.Windows.Forms.Button
    Friend WithEvents fecha_existencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents AlmacenComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewerresume As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvinv As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtexcluir As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Radionegavtivos As System.Windows.Forms.RadioButton
    Friend WithEvents Radiopositivos As System.Windows.Forms.RadioButton
    Friend WithEvents Radiotodos As System.Windows.Forms.RadioButton
End Class
