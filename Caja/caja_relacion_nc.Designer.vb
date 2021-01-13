<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja_relacion_nc
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.boton_todas = New System.Windows.Forms.ToolStripButton
        Me.boton_del_dia = New System.Windows.Forms.ToolStripButton
        Me.Boton_cancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.toolabel = New System.Windows.Forms.ToolStripLabel
        Me.Sql_documentos_clientesDataGridView = New System.Windows.Forms.DataGridView
        Me.dgvtd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvfolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvserie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nc_td = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nc_folio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nc_serie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerCFDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Sql_documentos_clientesDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(796, 383)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(635, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar :"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(687, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(411, 9)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(95, 20)
        Me.fecha.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_todas, Me.boton_del_dia, Me.Boton_cancelar, Me.ToolStripSeparator1, Me.toolabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(796, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_todas
        '
        Me.boton_todas.Image = Global.AdminTegral.My.Resources.Resources.Vista__50_
        Me.boton_todas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_todas.Name = "boton_todas"
        Me.boton_todas.Size = New System.Drawing.Size(75, 36)
        Me.boton_todas.Text = "Todas"
        '
        'boton_del_dia
        '
        Me.boton_del_dia.Image = Global.AdminTegral.My.Resources.Resources.Refresh
        Me.boton_del_dia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_del_dia.Name = "boton_del_dia"
        Me.boton_del_dia.Size = New System.Drawing.Size(113, 36)
        Me.boton_del_dia.Text = "Notas del Dia"
        '
        'Boton_cancelar
        '
        Me.Boton_cancelar.Image = Global.AdminTegral.My.Resources.Resources.Delete
        Me.Boton_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_cancelar.Name = "Boton_cancelar"
        Me.Boton_cancelar.Size = New System.Drawing.Size(89, 36)
        Me.Boton_cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'toolabel
        '
        Me.toolabel.Name = "toolabel"
        Me.toolabel.Size = New System.Drawing.Size(90, 36)
        Me.toolabel.Text = "Filtrar por fecha"
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
        Me.Sql_documentos_clientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvtd, Me.dgvfolio, Me.dgvserie, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn23, Me.dgvstatus, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30, Me.nc_td, Me.nc_folio, Me.nc_serie})
        Me.Sql_documentos_clientesDataGridView.DataSource = Me.Sql_documentos_clientesBindingSource
        Me.Sql_documentos_clientesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Sql_documentos_clientesDataGridView.Name = "Sql_documentos_clientesDataGridView"
        Me.Sql_documentos_clientesDataGridView.RowHeadersVisible = False
        Me.Sql_documentos_clientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Sql_documentos_clientesDataGridView.Size = New System.Drawing.Size(790, 332)
        Me.Sql_documentos_clientesDataGridView.TabIndex = 0
        '
        'dgvtd
        '
        Me.dgvtd.DataPropertyName = "td"
        Me.dgvtd.HeaderText = "td"
        Me.dgvtd.Name = "dgvtd"
        Me.dgvtd.Visible = False
        Me.dgvtd.Width = 41
        '
        'dgvfolio
        '
        Me.dgvfolio.DataPropertyName = "Folio"
        Me.dgvfolio.HeaderText = "Folio"
        Me.dgvfolio.Name = "dgvfolio"
        Me.dgvfolio.Width = 54
        '
        'dgvserie
        '
        Me.dgvserie.DataPropertyName = "serie"
        Me.dgvserie.HeaderText = "serie"
        Me.dgvserie.Name = "dgvserie"
        Me.dgvserie.Width = 54
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_directorio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 41
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechafactura"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fechafactura"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 92
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn23.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 67
        '
        'dgvstatus
        '
        Me.dgvstatus.DataPropertyName = "status"
        Me.dgvstatus.HeaderText = "status"
        Me.dgvstatus.Name = "dgvstatus"
        Me.dgvstatus.Width = 60
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "ncaja"
        Me.DataGridViewTextBoxColumn27.HeaderText = "ncaja"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
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
        Me.DataGridViewTextBoxColumn28.Width = 56
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Descripciom"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Documento"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 87
        '
        'nc_td
        '
        Me.nc_td.DataPropertyName = "nc_td"
        Me.nc_td.HeaderText = "TD"
        Me.nc_td.Name = "nc_td"
        Me.nc_td.Width = 47
        '
        'nc_folio
        '
        Me.nc_folio.DataPropertyName = "nc_folio"
        Me.nc_folio.HeaderText = "Folio"
        Me.nc_folio.Name = "nc_folio"
        Me.nc_folio.Width = 54
        '
        'nc_serie
        '
        Me.nc_serie.DataPropertyName = "nc_serie"
        Me.nc_serie.HeaderText = "Serie"
        Me.nc_serie.Name = "nc_serie"
        Me.nc_serie.Width = 56
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerCFDToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'VerCFDToolStripMenuItem
        '
        Me.VerCFDToolStripMenuItem.Name = "VerCFDToolStripMenuItem"
        Me.VerCFDToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerCFDToolStripMenuItem.Text = "Ver CFD"
        '
        'caja_relacion_nc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 383)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "caja_relacion_nc"
        Me.Text = "caja_relacion"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents Sql_documentos_clientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_todas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Boton_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_del_dia As System.Windows.Forms.ToolStripButton
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents toolabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvtd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvfolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvserie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nc_td As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nc_folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nc_serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerCFDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
