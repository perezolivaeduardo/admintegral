<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entradas_relacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.nueva_entrada = New System.Windows.Forms.ToolStripButton()
        Me.boton_modificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Boton_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.boton_relacion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.filtrotxt = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.filtrofactura = New System.Windows.Forms.ToolStripTextBox()
        Me.Sql_documentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Sql_documentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Sql_documentosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentosTableAdapter()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvid_prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.npedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ieps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Sql_documentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_documentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(912, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Entradas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nueva_entrada, Me.boton_modificar, Me.ToolStripButton1, Me.Boton_imprimir, Me.boton_relacion, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.filtrotxt, Me.ToolStripLabel2, Me.filtrofactura})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 29)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(912, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'nueva_entrada
        '
        Me.nueva_entrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.nueva_entrada.Image = Global.AdminTegral.My.Resources.Resources.page_add
        Me.nueva_entrada.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nueva_entrada.Name = "nueva_entrada"
        Me.nueva_entrada.Size = New System.Drawing.Size(23, 22)
        Me.nueva_entrada.Text = "Nueva_entrada"
        '
        'boton_modificar
        '
        Me.boton_modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_modificar.Image = Global.AdminTegral.My.Resources.Resources.overlays
        Me.boton_modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_modificar.Name = "boton_modificar"
        Me.boton_modificar.Size = New System.Drawing.Size(23, 22)
        Me.boton_modificar.Text = "Modificar Entrada"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.page_delete
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Boton_imprimir
        '
        Me.Boton_imprimir.Image = Global.AdminTegral.My.Resources.Resources.Printer_Green
        Me.Boton_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_imprimir.Name = "Boton_imprimir"
        Me.Boton_imprimir.Size = New System.Drawing.Size(134, 22)
        Me.Boton_imprimir.Text = "Re-Imprimir Entrada"
        '
        'boton_relacion
        '
        Me.boton_relacion.Image = Global.AdminTegral.My.Resources.Resources.Vista__50_
        Me.boton_relacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_relacion.Name = "boton_relacion"
        Me.boton_relacion.Size = New System.Drawing.Size(136, 22)
        Me.boton_relacion.Text = "Relacion de Entradas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel1.Text = "Filtrar :"
        '
        'filtrotxt
        '
        Me.filtrotxt.Name = "filtrotxt"
        Me.filtrotxt.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel2.Text = "Factura :"
        '
        'filtrofactura
        '
        Me.filtrofactura.Name = "filtrofactura"
        Me.filtrofactura.Size = New System.Drawing.Size(100, 25)
        '
        'Sql_documentosDataGridView
        '
        Me.Sql_documentosDataGridView.AllowUserToAddRows = False
        Me.Sql_documentosDataGridView.AllowUserToDeleteRows = False
        Me.Sql_documentosDataGridView.AllowUserToResizeColumns = False
        Me.Sql_documentosDataGridView.AllowUserToResizeRows = False
        Me.Sql_documentosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sql_documentosDataGridView.AutoGenerateColumns = False
        Me.Sql_documentosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_documentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Folio, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.dgvid_prov, Me.dgv_nombre, Me.npedido, Me.dgvfactura, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.ieps, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.Sql_documentosDataGridView.DataSource = Me.Sql_documentosBindingSource
        Me.Sql_documentosDataGridView.Location = New System.Drawing.Point(0, 57)
        Me.Sql_documentosDataGridView.Name = "Sql_documentosDataGridView"
        Me.Sql_documentosDataGridView.RowHeadersVisible = False
        Me.Sql_documentosDataGridView.Size = New System.Drawing.Size(912, 341)
        Me.Sql_documentosDataGridView.TabIndex = 7
        '
        'Sql_documentosBindingSource
        '
        Me.Sql_documentosBindingSource.DataMember = "sql_documentos"
        Me.Sql_documentosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "AdmintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 398)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(912, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status1
        '
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(0, 17)
        '
        'Sql_documentosTableAdapter
        '
        Me.Sql_documentosTableAdapter.ClearBeforeFill = True
        '
        'Folio
        '
        Me.Folio.DataPropertyName = "Folio"
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.Width = 54
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_almacen"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Alm"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 49
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Almacen"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 73
        '
        'dgvid_prov
        '
        Me.dgvid_prov.DataPropertyName = "id_directorio"
        Me.dgvid_prov.HeaderText = "Prov."
        Me.dgvid_prov.Name = "dgvid_prov"
        Me.dgvid_prov.Width = 57
        '
        'dgv_nombre
        '
        Me.dgv_nombre.DataPropertyName = "Nombre"
        Me.dgv_nombre.HeaderText = "Nombre"
        Me.dgv_nombre.Name = "dgv_nombre"
        Me.dgv_nombre.Width = 69
        '
        'npedido
        '
        Me.npedido.DataPropertyName = "folio_pedido"
        Me.npedido.HeaderText = "folio_pedido"
        Me.npedido.Name = "npedido"
        Me.npedido.Width = 89
        '
        'dgvfactura
        '
        Me.dgvfactura.DataPropertyName = "factura"
        Me.dgvfactura.HeaderText = "Factura"
        Me.dgvfactura.Name = "dgvfactura"
        Me.dgvfactura.Width = 68
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fechafactura"
        Me.DataGridViewTextBoxColumn7.HeaderText = "F. Factura"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fechasurtido"
        Me.DataGridViewTextBoxColumn8.HeaderText = "F.Surtido"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 74
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "vence"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Vence"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 63
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "sub0"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn12.HeaderText = "sub0"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 55
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "sub10"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn13.HeaderText = "sub10"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 61
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "sub15"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn14.HeaderText = "sub15"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 61
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "descuento0"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn15.HeaderText = "descuento0"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 88
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "descunto10"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn16.HeaderText = "descunto10"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 88
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "descunto15"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn17.HeaderText = "descunto15"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 88
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "iva10"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn18.HeaderText = "iva16"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 58
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "iva15"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn19.HeaderText = "iva15"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 58
        '
        'ieps
        '
        Me.ieps.DataPropertyName = "ieps"
        DataGridViewCellStyle9.Format = "n2"
        Me.ieps.DefaultCellStyle = DataGridViewCellStyle9
        Me.ieps.HeaderText = "IEPS"
        Me.ieps.Name = "ieps"
        Me.ieps.Width = 56
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Importe"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn20.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 67
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "id_cartera"
        Me.DataGridViewTextBoxColumn21.HeaderText = "id_cartera"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 79
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn22.HeaderText = "status"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Visible = False
        Me.DataGridViewTextBoxColumn22.Width = 60
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "id_almacen_entrada"
        Me.DataGridViewTextBoxColumn23.HeaderText = "id_almacen_entrada"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Visible = False
        Me.DataGridViewTextBoxColumn23.Width = 128
        '
        'Entradas_relacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 420)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Sql_documentosDataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Entradas_relacion"
        Me.Text = "Entradas_relacion"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Sql_documentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_documentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents AdmintegralDataSet As AdminTegral.AdmintegralDataSet
    Friend WithEvents Sql_documentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_documentosTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.sql_documentosTableAdapter
    Friend WithEvents Sql_documentosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents nueva_entrada As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boton_modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Boton_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_relacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents filtrotxt As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents filtrofactura As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvid_prov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents npedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvfactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ieps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
