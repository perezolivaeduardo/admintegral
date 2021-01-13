<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cargar_cxp_inicial
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.id_directorio = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.DocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntegraDataSet = New AdminTegral.integraDataSet()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Cxp_facturasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Cxp_facturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentosTableAdapter = New AdminTegral.integraDataSetTableAdapters.DocumentosTableAdapter()
        Me.Cxp_facturasTableAdapter = New AdminTegral.integraDataSetTableAdapters.cxp_facturasTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvreg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvvence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvimporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgviva10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgviva15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ieps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Cxp_facturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cxp_facturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 467)
        Me.SplitContainer1.SplitterDistance = 459
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_buscar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.nombre)
        Me.SplitContainer2.Panel1.Controls.Add(Me.id_directorio)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer2.Size = New System.Drawing.Size(459, 467)
        Me.SplitContainer2.SplitterDistance = 53
        Me.SplitContainer2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione Proveedor."
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(303, 29)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(42, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "..."
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(53, 30)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(244, 20)
        Me.nombre.TabIndex = 1
        '
        'id_directorio
        '
        Me.id_directorio.Location = New System.Drawing.Point(3, 30)
        Me.id_directorio.Name = "id_directorio"
        Me.id_directorio.Size = New System.Drawing.Size(44, 20)
        Me.id_directorio.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.dgvreg, Me.DataGridViewTextBoxColumn8, Me.dgvfactura, Me.dgvff, Me.DataGridViewTextBoxColumn11, Me.dgvvence, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.dgvimporte, Me.dgviva10, Me.dgviva15, Me.ieps})
        Me.dgv.DataSource = Me.DocumentosBindingSource
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(459, 410)
        Me.dgv.TabIndex = 0
        '
        'DocumentosBindingSource
        '
        Me.DocumentosBindingSource.DataMember = "Documentos"
        Me.DocumentosBindingSource.DataSource = Me.IntegraDataSet
        '
        'IntegraDataSet
        '
        Me.IntegraDataSet.DataSetName = "integraDataSet"
        Me.IntegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.Cxp_facturasDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(484, 467)
        Me.SplitContainer3.SplitterDistance = 58
        Me.SplitContainer3.TabIndex = 0
        '
        'Cxp_facturasDataGridView
        '
        Me.Cxp_facturasDataGridView.AllowUserToAddRows = False
        Me.Cxp_facturasDataGridView.AllowUserToDeleteRows = False
        Me.Cxp_facturasDataGridView.AllowUserToResizeColumns = False
        Me.Cxp_facturasDataGridView.AllowUserToResizeRows = False
        Me.Cxp_facturasDataGridView.AutoGenerateColumns = False
        Me.Cxp_facturasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Cxp_facturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.Cxp_facturasDataGridView.DataSource = Me.Cxp_facturasBindingSource
        Me.Cxp_facturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cxp_facturasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Cxp_facturasDataGridView.Name = "Cxp_facturasDataGridView"
        Me.Cxp_facturasDataGridView.ReadOnly = True
        Me.Cxp_facturasDataGridView.RowHeadersVisible = False
        Me.Cxp_facturasDataGridView.Size = New System.Drawing.Size(484, 405)
        Me.Cxp_facturasDataGridView.TabIndex = 0
        '
        'Cxp_facturasBindingSource
        '
        Me.Cxp_facturasBindingSource.DataMember = "cxp_facturas"
        Me.Cxp_facturasBindingSource.DataSource = Me.IntegraDataSet
        '
        'DocumentosTableAdapter
        '
        Me.DocumentosTableAdapter.ClearBeforeFill = True
        '
        'Cxp_facturasTableAdapter
        '
        Me.Cxp_facturasTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "td"
        Me.DataGridViewTextBoxColumn1.HeaderText = "td"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 54
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "serie"
        Me.DataGridViewTextBoxColumn3.HeaderText = "serie"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 54
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "almacen"
        Me.DataGridViewTextBoxColumn4.HeaderText = "almacen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 72
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_directorio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PV"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 46
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tipo_directorio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "tipo_directorio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 98
        '
        'dgvreg
        '
        Me.dgvreg.DataPropertyName = "fregistro"
        Me.dgvreg.HeaderText = "fregistro"
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ReadOnly = True
        Me.dgvreg.Width = 69
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "folio_pedido"
        Me.DataGridViewTextBoxColumn8.HeaderText = "folio_pedido"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 89
        '
        'dgvfactura
        '
        Me.dgvfactura.DataPropertyName = "factura"
        Me.dgvfactura.HeaderText = "factura"
        Me.dgvfactura.Name = "dgvfactura"
        Me.dgvfactura.ReadOnly = True
        Me.dgvfactura.Width = 65
        '
        'dgvff
        '
        Me.dgvff.DataPropertyName = "fechafactura"
        Me.dgvff.HeaderText = "fechafactura"
        Me.dgvff.Name = "dgvff"
        Me.dgvff.ReadOnly = True
        Me.dgvff.Width = 92
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fechasurtido"
        Me.DataGridViewTextBoxColumn11.HeaderText = "fechasurtido"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 90
        '
        'dgvvence
        '
        Me.dgvvence.DataPropertyName = "vence"
        Me.dgvvence.HeaderText = "vence"
        Me.dgvvence.Name = "dgvvence"
        Me.dgvvence.ReadOnly = True
        Me.dgvvence.Width = 62
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "porciento_descuento"
        Me.DataGridViewTextBoxColumn13.HeaderText = "porciento_descuento"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 132
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "flete"
        Me.DataGridViewTextBoxColumn14.HeaderText = "flete"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 52
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "sub0"
        Me.DataGridViewTextBoxColumn15.HeaderText = "sub0"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 55
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "sub10"
        Me.DataGridViewTextBoxColumn16.HeaderText = "sub10"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 61
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "sub15"
        Me.DataGridViewTextBoxColumn17.HeaderText = "sub15"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 61
        '
        'dgvimporte
        '
        Me.dgvimporte.DataPropertyName = "Importe"
        Me.dgvimporte.HeaderText = "Importe"
        Me.dgvimporte.Name = "dgvimporte"
        Me.dgvimporte.ReadOnly = True
        Me.dgvimporte.Width = 67
        '
        'dgviva10
        '
        Me.dgviva10.DataPropertyName = "iva10"
        Me.dgviva10.HeaderText = "iva10"
        Me.dgviva10.Name = "dgviva10"
        Me.dgviva10.ReadOnly = True
        Me.dgviva10.Visible = False
        Me.dgviva10.Width = 58
        '
        'dgviva15
        '
        Me.dgviva15.DataPropertyName = "iva15"
        Me.dgviva15.HeaderText = "iva15"
        Me.dgviva15.Name = "dgviva15"
        Me.dgviva15.ReadOnly = True
        Me.dgviva15.Visible = False
        Me.dgviva15.Width = 58
        '
        'ieps
        '
        Me.ieps.DataPropertyName = "ieps"
        Me.ieps.HeaderText = "ieps"
        Me.ieps.Name = "ieps"
        Me.ieps.ReadOnly = True
        Me.ieps.Width = 51
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_directorio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 43
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "factura"
        Me.DataGridViewTextBoxColumn9.HeaderText = "factura"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 65
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ffactura"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ffactura"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 68
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "fregistro"
        Me.DataGridViewTextBoxColumn12.HeaderText = "F.registro"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "fvencimiento"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Vence"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 63
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "iva"
        Me.DataGridViewTextBoxColumn19.HeaderText = "iva"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 46
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ieps"
        Me.DataGridViewTextBoxColumn20.HeaderText = "ieps"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 51
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "importe"
        Me.DataGridViewTextBoxColumn21.HeaderText = "importe"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 66
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn22.HeaderText = "status"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 60
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "abonado"
        Me.DataGridViewTextBoxColumn23.HeaderText = "abonado"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 74
        '
        'cargar_cxp_inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 467)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cargar_cxp_inicial"
        Me.Text = "Cargar Facturas a CXP (inicial)"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Cxp_facturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cxp_facturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents id_directorio As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IntegraDataSet As AdminTegral.integraDataSet
    Friend WithEvents DocumentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentosTableAdapter As AdminTegral.integraDataSetTableAdapters.DocumentosTableAdapter
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Cxp_facturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cxp_facturasTableAdapter As AdminTegral.integraDataSetTableAdapters.cxp_facturasTableAdapter
    Friend WithEvents Cxp_facturasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvfactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvvence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvimporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgviva10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgviva15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ieps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
