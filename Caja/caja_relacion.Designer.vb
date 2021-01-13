<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja_relacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(caja_relacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.boton_todas = New System.Windows.Forms.ToolStripButton()
        Me.Boton_Facturas = New System.Windows.Forms.ToolStripButton()
        Me.Boton_Tickets = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Boton_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.btp_por_facturar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Sql_documentos_clientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgvtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvfolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvserie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvimporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.Sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Sql_documentos_clientesDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(765, 383)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_todas, Me.Boton_Facturas, Me.Boton_Tickets, Me.ToolStripSeparator1, Me.Boton_cancelar, Me.btn_imprimir, Me.btp_por_facturar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(765, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_todas
        '
        Me.boton_todas.Image = Global.AdminTegral.My.Resources.Resources.Vista__50_
        Me.boton_todas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_todas.Name = "boton_todas"
        Me.boton_todas.Size = New System.Drawing.Size(74, 36)
        Me.boton_todas.Text = "Todas"
        '
        'Boton_Facturas
        '
        Me.Boton_Facturas.Image = Global.AdminTegral.My.Resources.Resources.impresoradematrix
        Me.Boton_Facturas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_Facturas.Name = "Boton_Facturas"
        Me.Boton_Facturas.Size = New System.Drawing.Size(87, 36)
        Me.Boton_Facturas.Text = "Facturas"
        '
        'Boton_Tickets
        '
        Me.Boton_Tickets.Image = Global.AdminTegral.My.Resources.Resources.impresora_rollo
        Me.Boton_Tickets.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_Tickets.Name = "Boton_Tickets"
        Me.Boton_Tickets.Size = New System.Drawing.Size(103, 36)
        Me.Boton_Tickets.Text = "Remisiones"
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
        Me.Boton_cancelar.Size = New System.Drawing.Size(89, 36)
        Me.Boton_cancelar.Text = "Cancelar"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Enabled = False
        Me.btn_imprimir.Image = Global.AdminTegral.My.Resources.Resources.Adobe_Reader
        Me.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(127, 36)
        Me.btn_imprimir.Text = "Reimprimir CFD"
        '
        'btp_por_facturar
        '
        Me.btp_por_facturar.Image = CType(resources.GetObject("btp_por_facturar.Image"), System.Drawing.Image)
        Me.btp_por_facturar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btp_por_facturar.Name = "btp_por_facturar"
        Me.btp_por_facturar.Size = New System.Drawing.Size(96, 36)
        Me.btp_por_facturar.Text = "X Facturar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(86, 36)
        Me.ToolStripButton1.Text = "Facturar"
        '
        'Sql_documentos_clientesDataGridView
        '
        Me.Sql_documentos_clientesDataGridView.AllowUserToAddRows = False
        Me.Sql_documentos_clientesDataGridView.AllowUserToDeleteRows = False
        Me.Sql_documentos_clientesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sql_documentos_clientesDataGridView.AutoGenerateColumns = False
        Me.Sql_documentos_clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Sql_documentos_clientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvtd, Me.dgvfolio, Me.dgvserie, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.dgvimporte, Me.dgvstatus, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30})
        Me.Sql_documentos_clientesDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Sql_documentos_clientesDataGridView.DataSource = Me.Sql_documentos_clientesBindingSource
        Me.Sql_documentos_clientesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Sql_documentos_clientesDataGridView.Name = "Sql_documentos_clientesDataGridView"
        Me.Sql_documentos_clientesDataGridView.ReadOnly = True
        Me.Sql_documentos_clientesDataGridView.RowHeadersVisible = False
        Me.Sql_documentos_clientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Sql_documentos_clientesDataGridView.Size = New System.Drawing.Size(759, 323)
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
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechafactura"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fechafactura"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 92
        '
        'dgvimporte
        '
        Me.dgvimporte.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.dgvimporte.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvimporte.HeaderText = "Importe"
        Me.dgvimporte.Name = "dgvimporte"
        Me.dgvimporte.ReadOnly = True
        Me.dgvimporte.Width = 67
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 26)
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar Factura"
        '
        'Sql_documentos_clientesBindingSource
        '
        Me.Sql_documentos_clientesBindingSource.DataMember = "sql_documentos_clientes"
        Me.Sql_documentos_clientesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sql_documentos_clientesTableAdapter
        '
        Me.Sql_documentos_clientesTableAdapter.ClearBeforeFill = True
        '
        'caja_relacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 383)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "caja_relacion"
        Me.Text = "caja_relacion"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents Sql_documentos_clientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_todas As System.Windows.Forms.ToolStripButton
    Friend WithEvents Boton_Facturas As System.Windows.Forms.ToolStripButton
    Friend WithEvents Boton_Tickets As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Boton_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btp_por_facturar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvtd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvfolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvserie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvimporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
