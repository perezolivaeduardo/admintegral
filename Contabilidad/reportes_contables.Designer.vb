<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportes_contables
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.cxc_detalle_comisionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CG_IETUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.excel_costosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cxc_saldo_al_corte_resumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.cxc_saldos_x_facturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
        Me.AgentesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
        Me.cxc_detalle_comisionesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_detalle_comisionesTableAdapter
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.folio_fin = New System.Windows.Forms.TextBox
        Me.boton_asignar = New System.Windows.Forms.Button
        Me.folio_ini = New System.Windows.Forms.TextBox
        Me.id = New System.Windows.Forms.TextBox
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label7 = New System.Windows.Forms.Label
        Me.boto_comisiones = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.fecha_del = New System.Windows.Forms.DateTimePicker
        Me.Fecha_al = New System.Windows.Forms.DateTimePicker
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.Button1 = New System.Windows.Forms.Button
        Me.fechainicial = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.boton_rhacienda = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.fechafinal = New System.Windows.Forms.DateTimePicker
        Me.reporte_hacienda_resumen = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReportDiario = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.boton_ietu = New System.Windows.Forms.Button
        Me.ietu_del = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ietu_al = New System.Windows.Forms.DateTimePicker
        Me.Report_ietu = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.boton_costo_devoluc = New System.Windows.Forms.Button
        Me.boton_costo_ventas = New System.Windows.Forms.Button
        Me.al = New System.Windows.Forms.DateTimePicker
        Me.del = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.reporte_costos = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
        Me.Button3 = New System.Windows.Forms.Button
        Me.boton_ok_saldos = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.fecha_corte = New System.Windows.Forms.DateTimePicker
        Me.report_saldos = New Microsoft.Reporting.WinForms.ReportViewer
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.barra = New System.Windows.Forms.ToolStripProgressBar
        Me.CG_IETUTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.CG_IETUTableAdapter
        Me.excel_costosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.excel_costosTableAdapter
        Me.cxc_saldos_x_facturaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
        Me.cxc_saldo_al_corte_resumenTableAdapter = New AdminTegral.reporteDataSetTableAdapters.cxc_saldo_al_corte_resumenTableAdapter
        Label6 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        CType(Me.cxc_detalle_comisionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CG_IETUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.excel_costosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxc_saldo_al_corte_resumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxc_saldos_x_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(18, 109)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(84, 18)
        Label6.TabIndex = 6
        Label6.Text = "Folio Final :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(18, 80)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(89, 18)
        Label5.TabIndex = 5
        Label5.Text = "Folio Inicial :"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(18, 22)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(138, 18)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Nombre del Agente:"
        '
        'cxc_detalle_comisionesBindingSource
        '
        Me.cxc_detalle_comisionesBindingSource.DataMember = "cxc_detalle_comisiones"
        Me.cxc_detalle_comisionesBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sql_documentos_clientesBindingSource
        '
        Me.sql_documentos_clientesBindingSource.DataMember = "sql_documentos_clientes"
        Me.sql_documentos_clientesBindingSource.DataSource = Me.admintegralDataSet
        '
        'CG_IETUBindingSource
        '
        Me.CG_IETUBindingSource.DataMember = "CG_IETU"
        Me.CG_IETUBindingSource.DataSource = Me.admintegralDataSet
        '
        'excel_costosBindingSource
        '
        Me.excel_costosBindingSource.DataMember = "excel_costos"
        Me.excel_costosBindingSource.DataSource = Me.admintegralDataSet
        '
        'cxc_saldo_al_corte_resumenBindingSource
        '
        Me.cxc_saldo_al_corte_resumenBindingSource.DataMember = "cxc_saldo_al_corte_resumen"
        Me.cxc_saldo_al_corte_resumenBindingSource.DataSource = Me.reporteDataSet
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxc_saldos_x_facturaBindingSource
        '
        Me.cxc_saldos_x_facturaBindingSource.DataMember = "cxc_saldos_x_factura"
        Me.cxc_saldos_x_facturaBindingSource.DataSource = Me.admintegralDataSet
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.admintegralDataSet
        '
        'sql_documentos_clientesTableAdapter
        '
        Me.sql_documentos_clientesTableAdapter.ClearBeforeFill = True
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'cxc_detalle_comisionesTableAdapter
        '
        Me.cxc_detalle_comisionesTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(873, 448)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dgv)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(865, 419)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Control de Boletas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.folio_fin)
        Me.GroupBox1.Controls.Add(Me.boton_asignar)
        Me.GroupBox1.Controls.Add(Me.folio_ini)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 191)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignar un bloc"
        '
        'folio_fin
        '
        Me.folio_fin.Location = New System.Drawing.Point(113, 107)
        Me.folio_fin.Name = "folio_fin"
        Me.folio_fin.ReadOnly = True
        Me.folio_fin.Size = New System.Drawing.Size(69, 22)
        Me.folio_fin.TabIndex = 4
        '
        'boton_asignar
        '
        Me.boton_asignar.Enabled = False
        Me.boton_asignar.Location = New System.Drawing.Point(307, 144)
        Me.boton_asignar.Name = "boton_asignar"
        Me.boton_asignar.Size = New System.Drawing.Size(75, 23)
        Me.boton_asignar.TabIndex = 0
        Me.boton_asignar.Text = "Asignar Bloc"
        Me.boton_asignar.UseVisualStyleBackColor = True
        '
        'folio_ini
        '
        Me.folio_ini.Location = New System.Drawing.Point(113, 81)
        Me.folio_ini.Name = "folio_ini"
        Me.folio_ini.Size = New System.Drawing.Size(69, 22)
        Me.folio_ini.TabIndex = 3
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(21, 43)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(49, 24)
        Me.id.TabIndex = 2
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgentesBindingSource, "Nombre", True))
        Me.NombreComboBox.DataSource = Me.AgentesBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(87, 43)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(295, 26)
        Me.NombreComboBox.TabIndex = 1
        Me.NombreComboBox.ValueMember = "id_agente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Control de Recibos de Cobro."
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(10, 44)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(464, 150)
        Me.dgv.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(865, 419)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Comisiones"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boto_comisiones)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.fecha_del)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Fecha_al)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ReportViewer2)
        Me.SplitContainer2.Size = New System.Drawing.Size(859, 413)
        Me.SplitContainer2.SplitterDistance = 184
        Me.SplitContainer2.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Reporte de Comisiones"
        '
        'boto_comisiones
        '
        Me.boto_comisiones.Location = New System.Drawing.Point(19, 144)
        Me.boto_comisiones.Name = "boto_comisiones"
        Me.boto_comisiones.Size = New System.Drawing.Size(75, 23)
        Me.boto_comisiones.TabIndex = 13
        Me.boto_comisiones.Text = "Ok"
        Me.boto_comisiones.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha Inicial:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Fecha Inicial:"
        '
        'fecha_del
        '
        Me.fecha_del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_del.Location = New System.Drawing.Point(19, 67)
        Me.fecha_del.Name = "fecha_del"
        Me.fecha_del.Size = New System.Drawing.Size(100, 22)
        Me.fecha_del.TabIndex = 8
        '
        'Fecha_al
        '
        Me.Fecha_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_al.Location = New System.Drawing.Point(19, 107)
        Me.Fecha_al.Name = "Fecha_al"
        Me.Fecha_al.Size = New System.Drawing.Size(100, 22)
        Me.Fecha_al.TabIndex = 11
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_cxc_detalle_comisiones"
        ReportDataSource1.Value = Me.cxc_detalle_comisionesBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "AdminTegral.comisiones.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(671, 413)
        Me.ReportViewer2.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(865, 419)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hacienda"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.fechainicial)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.boton_rhacienda)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.fechafinal)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.reporte_hacienda_resumen)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ReportDiario)
        Me.SplitContainer3.Size = New System.Drawing.Size(859, 413)
        Me.SplitContainer3.SplitterDistance = 173
        Me.SplitContainer3.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Diario de Ventas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fechainicial
        '
        Me.fechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechainicial.Location = New System.Drawing.Point(18, 80)
        Me.fechainicial.Name = "fechainicial"
        Me.fechainicial.Size = New System.Drawing.Size(100, 22)
        Me.fechainicial.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 25)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "del Periodo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicial:"
        '
        'boton_rhacienda
        '
        Me.boton_rhacienda.Location = New System.Drawing.Point(18, 106)
        Me.boton_rhacienda.Name = "boton_rhacienda"
        Me.boton_rhacienda.Size = New System.Drawing.Size(100, 25)
        Me.boton_rhacienda.TabIndex = 1
        Me.boton_rhacienda.Text = "del Dia"
        Me.boton_rhacienda.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Reporte de Hacienda"
        '
        'fechafinal
        '
        Me.fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechafinal.Location = New System.Drawing.Point(18, 192)
        Me.fechafinal.Name = "fechafinal"
        Me.fechafinal.Size = New System.Drawing.Size(100, 22)
        Me.fechafinal.TabIndex = 5
        '
        'reporte_hacienda_resumen
        '
        Me.reporte_hacienda_resumen.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "resumen"
        ReportDataSource2.Value = Me.sql_documentos_clientesBindingSource
        Me.reporte_hacienda_resumen.LocalReport.DataSources.Add(ReportDataSource2)
        Me.reporte_hacienda_resumen.LocalReport.ReportEmbeddedResource = "AdminTegral.reporte_Hacienda_resumen.rdlc"
        Me.reporte_hacienda_resumen.Location = New System.Drawing.Point(0, 0)
        Me.reporte_hacienda_resumen.Name = "reporte_hacienda_resumen"
        Me.reporte_hacienda_resumen.Size = New System.Drawing.Size(682, 413)
        Me.reporte_hacienda_resumen.TabIndex = 11
        Me.reporte_hacienda_resumen.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "resumen"
        ReportDataSource3.Value = Me.sql_documentos_clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.reporte_Hacienda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 413)
        Me.ReportViewer1.TabIndex = 9
        Me.ReportViewer1.Visible = False
        '
        'ReportDiario
        '
        Me.ReportDiario.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "admintegralDataSet_sql_documentos_clientes"
        ReportDataSource4.Value = Me.sql_documentos_clientesBindingSource
        Me.ReportDiario.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportDiario.LocalReport.ReportEmbeddedResource = "AdminTegral.Diario_ventas_contabilidad.rdlc"
        Me.ReportDiario.Location = New System.Drawing.Point(0, 0)
        Me.ReportDiario.Name = "ReportDiario"
        Me.ReportDiario.Size = New System.Drawing.Size(682, 413)
        Me.ReportDiario.TabIndex = 10
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(865, 419)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "IETU"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_ietu)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ietu_del)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ietu_al)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Report_ietu)
        Me.SplitContainer1.Size = New System.Drawing.Size(859, 413)
        Me.SplitContainer1.SplitterDistance = 176
        Me.SplitContainer1.TabIndex = 0
        '
        'boton_ietu
        '
        Me.boton_ietu.Location = New System.Drawing.Point(16, 140)
        Me.boton_ietu.Name = "boton_ietu"
        Me.boton_ietu.Size = New System.Drawing.Size(75, 23)
        Me.boton_ietu.TabIndex = 12
        Me.boton_ietu.Text = "OK"
        Me.boton_ietu.UseVisualStyleBackColor = True
        '
        'ietu_del
        '
        Me.ietu_del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ietu_del.Location = New System.Drawing.Point(16, 56)
        Me.ietu_del.Name = "ietu_del"
        Me.ietu_del.Size = New System.Drawing.Size(100, 22)
        Me.ietu_del.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Fecha Inicial:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Fecha Final:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Reporte de Hacienda"
        '
        'ietu_al
        '
        Me.ietu_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ietu_al.Location = New System.Drawing.Point(21, 104)
        Me.ietu_al.Name = "ietu_al"
        Me.ietu_al.Size = New System.Drawing.Size(100, 22)
        Me.ietu_al.TabIndex = 10
        '
        'Report_ietu
        '
        Me.Report_ietu.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "admintegralDataSet_CG_IETU"
        ReportDataSource5.Value = Me.CG_IETUBindingSource
        Me.Report_ietu.LocalReport.DataSources.Add(ReportDataSource5)
        Me.Report_ietu.LocalReport.ReportEmbeddedResource = "AdminTegral.ietu.rdlc"
        Me.Report_ietu.Location = New System.Drawing.Point(0, 0)
        Me.Report_ietu.Name = "Report_ietu"
        Me.Report_ietu.Size = New System.Drawing.Size(679, 413)
        Me.Report_ietu.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.SplitContainer4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(865, 419)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Costos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.boton_costo_devoluc)
        Me.SplitContainer4.Panel1.Controls.Add(Me.boton_costo_ventas)
        Me.SplitContainer4.Panel1.Controls.Add(Me.al)
        Me.SplitContainer4.Panel1.Controls.Add(Me.del)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label13)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.reporte_costos)
        Me.SplitContainer4.Size = New System.Drawing.Size(859, 413)
        Me.SplitContainer4.SplitterDistance = 56
        Me.SplitContainer4.TabIndex = 0
        '
        'boton_costo_devoluc
        '
        Me.boton_costo_devoluc.Location = New System.Drawing.Point(545, 13)
        Me.boton_costo_devoluc.Name = "boton_costo_devoluc"
        Me.boton_costo_devoluc.Size = New System.Drawing.Size(147, 23)
        Me.boton_costo_devoluc.TabIndex = 5
        Me.boton_costo_devoluc.Text = "Costo Devoluciones"
        Me.boton_costo_devoluc.UseVisualStyleBackColor = True
        '
        'boton_costo_ventas
        '
        Me.boton_costo_ventas.Location = New System.Drawing.Point(410, 13)
        Me.boton_costo_ventas.Name = "boton_costo_ventas"
        Me.boton_costo_ventas.Size = New System.Drawing.Size(129, 23)
        Me.boton_costo_ventas.TabIndex = 4
        Me.boton_costo_ventas.Text = "Costo de Ventas"
        Me.boton_costo_ventas.UseVisualStyleBackColor = True
        '
        'al
        '
        Me.al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.al.Location = New System.Drawing.Point(254, 13)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(108, 22)
        Me.al.TabIndex = 3
        '
        'del
        '
        Me.del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.del.Location = New System.Drawing.Point(113, 13)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(108, 22)
        Me.del.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(227, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Al"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Periodo del :"
        '
        'reporte_costos
        '
        Me.reporte_costos.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "admintegralDataSet_excel_costos"
        ReportDataSource6.Value = Me.excel_costosBindingSource
        Me.reporte_costos.LocalReport.DataSources.Add(ReportDataSource6)
        Me.reporte_costos.LocalReport.ReportEmbeddedResource = "AdminTegral.Reporte_de_costos.rdlc"
        Me.reporte_costos.Location = New System.Drawing.Point(0, 0)
        Me.reporte_costos.Name = "reporte_costos"
        Me.reporte_costos.Size = New System.Drawing.Size(859, 353)
        Me.reporte_costos.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.SplitContainer5)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(865, 419)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Saldos CxC"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer5.Panel1.Controls.Add(Me.boton_ok_saldos)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer5.Panel1.Controls.Add(Me.fecha_corte)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.report_saldos)
        Me.SplitContainer5.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer5.Size = New System.Drawing.Size(859, 413)
        Me.SplitContainer5.SplitterDistance = 47
        Me.SplitContainer5.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(380, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Integracion (Excel)"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'boton_ok_saldos
        '
        Me.boton_ok_saldos.Location = New System.Drawing.Point(250, 13)
        Me.boton_ok_saldos.Name = "boton_ok_saldos"
        Me.boton_ok_saldos.Size = New System.Drawing.Size(111, 23)
        Me.boton_ok_saldos.TabIndex = 2
        Me.boton_ok_saldos.Text = "Vista Previa"
        Me.boton_ok_saldos.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 16)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Fecha de Corte :"
        '
        'fecha_corte
        '
        Me.fecha_corte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_corte.Location = New System.Drawing.Point(128, 13)
        Me.fecha_corte.Name = "fecha_corte"
        Me.fecha_corte.Size = New System.Drawing.Size(105, 22)
        Me.fecha_corte.TabIndex = 0
        '
        'report_saldos
        '
        Me.report_saldos.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource7.Name = "tabla"
        ReportDataSource7.Value = Me.cxc_saldo_al_corte_resumenBindingSource
        Me.report_saldos.LocalReport.DataSources.Add(ReportDataSource7)
        Me.report_saldos.LocalReport.ReportEmbeddedResource = "AdminTegral.contable_saldos_globales.rdlc"
        Me.report_saldos.Location = New System.Drawing.Point(0, 0)
        Me.report_saldos.Name = "report_saldos"
        Me.report_saldos.Size = New System.Drawing.Size(859, 340)
        Me.report_saldos.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barra})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 340)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(859, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'barra
        '
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(100, 16)
        '
        'CG_IETUTableAdapter
        '
        Me.CG_IETUTableAdapter.ClearBeforeFill = True
        '
        'excel_costosTableAdapter
        '
        Me.excel_costosTableAdapter.ClearBeforeFill = True
        '
        'cxc_saldos_x_facturaTableAdapter
        '
        Me.cxc_saldos_x_facturaTableAdapter.ClearBeforeFill = True
        '
        'cxc_saldo_al_corte_resumenTableAdapter
        '
        Me.cxc_saldo_al_corte_resumenTableAdapter.ClearBeforeFill = True
        '
        'reportes_contables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 448)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "reportes_contables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reportes_contables"
        CType(Me.cxc_detalle_comisionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CG_IETUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.excel_costosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxc_saldo_al_corte_resumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxc_saldos_x_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.Panel2.PerformLayout()
        Me.SplitContainer5.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents AgentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
    Friend WithEvents cxc_detalle_comisionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cxc_detalle_comisionesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_detalle_comisionesTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents folio_fin As System.Windows.Forms.TextBox
    Friend WithEvents boton_asignar As System.Windows.Forms.Button
    Friend WithEvents folio_ini As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents boto_comisiones As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents fecha_del As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fechainicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boton_rhacienda As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportDiario As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reporte_hacienda_resumen As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ietu_del As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ietu_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents Report_ietu As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CG_IETUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CG_IETUTableAdapter As AdminTegral.admintegralDataSetTableAdapters.CG_IETUTableAdapter
    Friend WithEvents boton_ietu As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents reporte_costos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents excel_costosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents excel_costosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.excel_costosTableAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents boton_costo_devoluc As System.Windows.Forms.Button
    Friend WithEvents boton_costo_ventas As System.Windows.Forms.Button
    Friend WithEvents al As System.Windows.Forms.DateTimePicker
    Friend WithEvents del As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents report_saldos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents boton_ok_saldos As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents fecha_corte As System.Windows.Forms.DateTimePicker
    Friend WithEvents cxc_saldos_x_facturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cxc_saldos_x_facturaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents barra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents cxc_saldo_al_corte_resumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents cxc_saldo_al_corte_resumenTableAdapter As AdminTegral.reporteDataSetTableAdapters.cxc_saldo_al_corte_resumenTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
