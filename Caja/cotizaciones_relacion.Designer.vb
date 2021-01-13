<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotizacion_relacion
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.sql_documento_impresionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.sfecha = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Boton_agregar = New System.Windows.Forms.ToolStripButton()
        Me.boton_modificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Boton_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.boton_excel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.boton_cerrar_reporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Sql_documentos_clientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgvtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvfolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvserie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter()
        Me.sql_documento_impresionTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documento_impresionTableAdapter()
        CType(Me.sql_documento_impresionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.sfecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Sql_documentos_clientesDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(781, 383)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 0
        '
        'sfecha
        '
        Me.sfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.sfecha.Location = New System.Drawing.Point(666, 12)
        Me.sfecha.Name = "sfecha"
        Me.sfecha.Size = New System.Drawing.Size(103, 20)
        Me.sfecha.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Boton_agregar, Me.boton_modificar, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.Boton_cancelar, Me.boton_excel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(471, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Boton_agregar
        '
        Me.Boton_agregar.Image = Global.AdminTegral.My.Resources.Resources.page_add
        Me.Boton_agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_agregar.Name = "Boton_agregar"
        Me.Boton_agregar.Size = New System.Drawing.Size(77, 36)
        Me.Boton_agregar.Text = "Nueva"
        '
        'boton_modificar
        '
        Me.boton_modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_modificar.Image = Global.AdminTegral.My.Resources.Resources.overlays
        Me.boton_modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_modificar.Name = "boton_modificar"
        Me.boton_modificar.Size = New System.Drawing.Size(36, 36)
        Me.boton_modificar.Text = "ToolStripButton2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.Printer_Green
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(89, 36)
        Me.ToolStripButton1.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'Boton_cancelar
        '
        Me.Boton_cancelar.Image = Global.AdminTegral.My.Resources.Resources.Delete
        Me.Boton_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_cancelar.Name = "Boton_cancelar"
        Me.Boton_cancelar.Size = New System.Drawing.Size(134, 36)
        Me.Boton_cancelar.Text = "Borrar Cotizacion"
        '
        'boton_excel
        '
        Me.boton_excel.Image = Global.AdminTegral.My.Resources.Resources.excel
        Me.boton_excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_excel.Name = "boton_excel"
        Me.boton_excel.Size = New System.Drawing.Size(117, 36)
        Me.boton_excel.Text = "Exportar_Excel"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_cerrar_reporte, Me.ToolStripSeparator2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(781, 39)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'boton_cerrar_reporte
        '
        Me.boton_cerrar_reporte.Image = Global.AdminTegral.My.Resources.Resources.Log_Off
        Me.boton_cerrar_reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_cerrar_reporte.Name = "boton_cerrar_reporte"
        Me.boton_cerrar_reporte.Size = New System.Drawing.Size(75, 36)
        Me.boton_cerrar_reporte.Text = "Cerrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_sql_documento_impresion"
        ReportDataSource1.Value = Me.sql_documento_impresionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.cotizaciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(781, 338)
        Me.ReportViewer1.TabIndex = 1
        Me.ReportViewer1.Visible = False
        '
        'Sql_documentos_clientesDataGridView
        '
        Me.Sql_documentos_clientesDataGridView.AllowUserToAddRows = False
        Me.Sql_documentos_clientesDataGridView.AllowUserToDeleteRows = False
        Me.Sql_documentos_clientesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sql_documentos_clientesDataGridView.AutoGenerateColumns = False
        Me.Sql_documentos_clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Sql_documentos_clientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvtd, Me.dgvfolio, Me.dgvserie, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.fecha, Me.DataGridViewTextBoxColumn23, Me.dgvstatus, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30})
        Me.Sql_documentos_clientesDataGridView.DataSource = Me.Sql_documentos_clientesBindingSource
        Me.Sql_documentos_clientesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Sql_documentos_clientesDataGridView.Name = "Sql_documentos_clientesDataGridView"
        Me.Sql_documentos_clientesDataGridView.ReadOnly = True
        Me.Sql_documentos_clientesDataGridView.RowHeadersVisible = False
        Me.Sql_documentos_clientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Sql_documentos_clientesDataGridView.Size = New System.Drawing.Size(775, 323)
        Me.Sql_documentos_clientesDataGridView.TabIndex = 0
        '
        'dgvtd
        '
        Me.dgvtd.DataPropertyName = "td"
        Me.dgvtd.HeaderText = "td"
        Me.dgvtd.Name = "dgvtd"
        Me.dgvtd.ReadOnly = True
        Me.dgvtd.Visible = False
        Me.dgvtd.Width = 41
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
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_directorio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 41
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 69
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fechafactura"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 62
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn23.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 67
        '
        'dgvstatus
        '
        Me.dgvstatus.DataPropertyName = "status"
        Me.dgvstatus.HeaderText = "status"
        Me.dgvstatus.Name = "dgvstatus"
        Me.dgvstatus.ReadOnly = True
        Me.dgvstatus.Width = 60
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "ncaja"
        Me.DataGridViewTextBoxColumn27.HeaderText = "ncaja"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        Me.DataGridViewTextBoxColumn27.Width = 58
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "pesoengramos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N"
        Me.DataGridViewTextBoxColumn28.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn28.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 56
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Descripciom"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Documento"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 87
        '
        'Sql_documentos_clientesBindingSource
        '
        Me.Sql_documentos_clientesBindingSource.DataMember = "sql_documentos_clientes"
        Me.Sql_documentos_clientesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Sql_documentos_clientesTableAdapter
        '
        Me.Sql_documentos_clientesTableAdapter.ClearBeforeFill = True
        '
        'sql_documento_impresionTableAdapter
        '
        Me.sql_documento_impresionTableAdapter.ClearBeforeFill = True
        '
        'cotizacion_relacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 383)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cotizacion_relacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacion de Cotizaciones"
        CType(Me.sql_documento_impresionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents Sql_documentos_clientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Boton_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_documento_impresionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sql_documento_impresionTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documento_impresionTableAdapter
    Friend WithEvents Boton_agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_excel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_cerrar_reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents boton_modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvtd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvfolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvserie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
