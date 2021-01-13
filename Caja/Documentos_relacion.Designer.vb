<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Documentos_relacion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
        Me.Sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tipocombo = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.serietxt = New System.Windows.Forms.ToolStripTextBox
        Me.boton_cargar = New System.Windows.Forms.ToolStripButton
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
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.fecha = New System.Windows.Forms.ToolStripTextBox
        Me.boton_filtro = New System.Windows.Forms.ToolStripButton
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sql_documentos_clientesTableAdapter
        '
        Me.Sql_documentos_clientesTableAdapter.ClearBeforeFill = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Sql_documentos_clientesDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(795, 438)
        Me.SplitContainer1.SplitterDistance = 34
        Me.SplitContainer1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tipocombo, Me.ToolStripLabel2, Me.serietxt, Me.boton_cargar, Me.ToolStripLabel3, Me.fecha, Me.boton_filtro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(795, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripLabel1.Text = "Tipo de documento :"
        '
        'tipocombo
        '
        Me.tipocombo.Items.AddRange(New Object() {"Ticket's", "Facturas", "N. de Credito", ""})
        Me.tipocombo.Name = "tipocombo"
        Me.tipocombo.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel2.Text = "Serie :"
        '
        'serietxt
        '
        Me.serietxt.Name = "serietxt"
        Me.serietxt.Size = New System.Drawing.Size(30, 25)
        '
        'boton_cargar
        '
        Me.boton_cargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_cargar.Image = Global.AdminTegral.My.Resources.Resources.search
        Me.boton_cargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_cargar.Name = "boton_cargar"
        Me.boton_cargar.Size = New System.Drawing.Size(23, 22)
        Me.boton_cargar.Text = "ToolStripButton1"
        '
        'Sql_documentos_clientesDataGridView
        '
        Me.Sql_documentos_clientesDataGridView.AllowUserToAddRows = False
        Me.Sql_documentos_clientesDataGridView.AllowUserToDeleteRows = False
        Me.Sql_documentos_clientesDataGridView.AutoGenerateColumns = False
        Me.Sql_documentos_clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Sql_documentos_clientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvtd, Me.dgvfolio, Me.dgvserie, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn23, Me.dgvstatus, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30})
        Me.Sql_documentos_clientesDataGridView.DataSource = Me.Sql_documentos_clientesBindingSource
        Me.Sql_documentos_clientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_documentos_clientesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_documentos_clientesDataGridView.Name = "Sql_documentos_clientesDataGridView"
        Me.Sql_documentos_clientesDataGridView.ReadOnly = True
        Me.Sql_documentos_clientesDataGridView.RowHeadersVisible = False
        Me.Sql_documentos_clientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Sql_documentos_clientesDataGridView.Size = New System.Drawing.Size(795, 400)
        Me.Sql_documentos_clientesDataGridView.TabIndex = 1
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
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N"
        Me.DataGridViewTextBoxColumn28.DefaultCellStyle = DataGridViewCellStyle4
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
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel3.Text = "Fecha:"
        '
        'fecha
        '
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(80, 25)
        '
        'boton_filtro
        '
        Me.boton_filtro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_filtro.Image = Global.AdminTegral.My.Resources.Resources.search
        Me.boton_filtro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_filtro.Name = "boton_filtro"
        Me.boton_filtro.Size = New System.Drawing.Size(23, 22)
        Me.boton_filtro.Text = "ToolStripButton1"
        '
        'Documentos_relacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 438)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Documentos_relacion"
        Me.Text = "Documentos Relacion"
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Sql_documentos_clientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents Sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Sql_documentos_clientesDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tipocombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents serietxt As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents boton_cargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents fecha As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents boton_filtro As System.Windows.Forms.ToolStripButton
End Class
