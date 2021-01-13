<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxp_pagos
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
        Dim id As System.Windows.Forms.Label
        Dim Id_bancoLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim FechaLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btn_registra = New System.Windows.Forms.Button
        Me.btn_buscar_proveedor = New System.Windows.Forms.Button
        Me.nombre = New System.Windows.Forms.TextBox
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox
        Me.Id_bancoTextBox = New System.Windows.Forms.TextBox
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox
        Me.ImporteTextBox = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Cxp_saldos_diasDataGridView = New System.Windows.Forms.DataGridView
        Me.btn_salir = New System.Windows.Forms.Button
        Me.Cxp_abonosDataGridView = New System.Windows.Forms.DataGridView
        Me.btn_guardar = New System.Windows.Forms.Button
        Me.Cxp_chequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntegraDataSet = New AdminTegral.integraDataSet
        Me.dgvfactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvimporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cxp_saldos_diasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvfactabono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvabono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cxp_abonosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cxp_chequesTableAdapter = New AdminTegral.integraDataSetTableAdapters.cxp_chequesTableAdapter
        Me.Cxp_saldos_diasTableAdapter = New AdminTegral.integraDataSetTableAdapters.cxp_saldos_diasTableAdapter
        Me.Cxp_abonosTableAdapter = New AdminTegral.integraDataSetTableAdapters.cxp_abonosTableAdapter
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        id = New System.Windows.Forms.Label
        Id_bancoLabel = New System.Windows.Forms.Label
        ReferenciaLabel = New System.Windows.Forms.Label
        ComentariosLabel = New System.Windows.Forms.Label
        ImporteLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Cxp_saldos_diasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cxp_abonosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cxp_chequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cxp_saldos_diasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cxp_abonosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        id.AutoSize = True
        id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        id.Location = New System.Drawing.Point(80, 18)
        id.Name = "id"
        id.Size = New System.Drawing.Size(26, 18)
        id.TabIndex = 0
        id.Text = "ID:"
        '
        'Id_bancoLabel
        '
        Id_bancoLabel.AutoSize = True
        Id_bancoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_bancoLabel.Location = New System.Drawing.Point(47, 42)
        Id_bancoLabel.Name = "Id_bancoLabel"
        Id_bancoLabel.Size = New System.Drawing.Size(59, 18)
        Id_bancoLabel.TabIndex = 2
        Id_bancoLabel.Text = "Banco :"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReferenciaLabel.Location = New System.Drawing.Point(12, 69)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(94, 18)
        ReferenciaLabel.TabIndex = 4
        ReferenciaLabel.Text = "Documento :"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentariosLabel.Location = New System.Drawing.Point(11, 106)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(95, 18)
        ComentariosLabel.TabIndex = 6
        ComentariosLabel.Text = "comentarios:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImporteLabel.Location = New System.Drawing.Point(583, 109)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(62, 18)
        ImporteLabel.TabIndex = 8
        ImporteLabel.Text = "Importe:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(8, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(120, 18)
        Label1.TabIndex = 13
        Label1.Text = "Abono a facturas"
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(FechaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_registra)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_buscar_proveedor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nombre)
        Me.SplitContainer1.Panel1.Controls.Add(id)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_directorioTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Id_bancoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_bancoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ReferenciaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ReferenciaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ComentariosLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComentariosTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ImporteLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ImporteTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 467)
        Me.SplitContainer1.SplitterDistance = 178
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_registra
        '
        Me.btn_registra.Enabled = False
        Me.btn_registra.Location = New System.Drawing.Point(15, 142)
        Me.btn_registra.Name = "btn_registra"
        Me.btn_registra.Size = New System.Drawing.Size(105, 23)
        Me.btn_registra.TabIndex = 12
        Me.btn_registra.Text = "Registrar Facturas"
        Me.btn_registra.UseVisualStyleBackColor = True
        '
        'btn_buscar_proveedor
        '
        Me.btn_buscar_proveedor.Location = New System.Drawing.Point(565, 11)
        Me.btn_buscar_proveedor.Name = "btn_buscar_proveedor"
        Me.btn_buscar_proveedor.Size = New System.Drawing.Size(32, 23)
        Me.btn_buscar_proveedor.TabIndex = 11
        Me.btn_buscar_proveedor.Text = "..."
        Me.btn_buscar_proveedor.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.Enabled = False
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(156, 11)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(403, 26)
        Me.nombre.TabIndex = 10
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cxp_chequesBindingSource, "id_directorio", True))
        Me.Id_directorioTextBox.Enabled = False
        Me.Id_directorioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(112, 12)
        Me.Id_directorioTextBox.MaxLength = 5
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(38, 24)
        Me.Id_directorioTextBox.TabIndex = 1
        '
        'Id_bancoTextBox
        '
        Me.Id_bancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cxp_chequesBindingSource, "id_banco", True))
        Me.Id_bancoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_bancoTextBox.Location = New System.Drawing.Point(112, 43)
        Me.Id_bancoTextBox.MaxLength = 20
        Me.Id_bancoTextBox.Name = "Id_bancoTextBox"
        Me.Id_bancoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Id_bancoTextBox.TabIndex = 3
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cxp_chequesBindingSource, "referencia", True))
        Me.ReferenciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(112, 73)
        Me.ReferenciaTextBox.MaxLength = 20
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(193, 24)
        Me.ReferenciaTextBox.TabIndex = 5
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cxp_chequesBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(112, 103)
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(447, 24)
        Me.ComentariosTextBox.TabIndex = 7
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cxp_chequesBindingSource, "importe", True))
        Me.ImporteTextBox.Enabled = False
        Me.ImporteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImporteTextBox.Location = New System.Drawing.Point(651, 106)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(105, 24)
        Me.ImporteTextBox.TabIndex = 9
        Me.ImporteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.Cxp_saldos_diasDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_salir)
        Me.SplitContainer2.Panel2.Controls.Add(Label1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Cxp_abonosDataGridView)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_guardar)
        Me.SplitContainer2.Size = New System.Drawing.Size(800, 285)
        Me.SplitContainer2.SplitterDistance = 493
        Me.SplitContainer2.TabIndex = 0
        '
        'Cxp_saldos_diasDataGridView
        '
        Me.Cxp_saldos_diasDataGridView.AllowUserToAddRows = False
        Me.Cxp_saldos_diasDataGridView.AllowUserToDeleteRows = False
        Me.Cxp_saldos_diasDataGridView.AllowUserToResizeColumns = False
        Me.Cxp_saldos_diasDataGridView.AllowUserToResizeRows = False
        Me.Cxp_saldos_diasDataGridView.AutoGenerateColumns = False
        Me.Cxp_saldos_diasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Cxp_saldos_diasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvfactura, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.dgvimporte, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Cxp_saldos_diasDataGridView.DataSource = Me.Cxp_saldos_diasBindingSource
        Me.Cxp_saldos_diasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cxp_saldos_diasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Cxp_saldos_diasDataGridView.Name = "Cxp_saldos_diasDataGridView"
        Me.Cxp_saldos_diasDataGridView.ReadOnly = True
        Me.Cxp_saldos_diasDataGridView.RowHeadersVisible = False
        Me.Cxp_saldos_diasDataGridView.Size = New System.Drawing.Size(493, 285)
        Me.Cxp_saldos_diasDataGridView.TabIndex = 0
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(126, 230)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 14
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Cxp_abonosDataGridView
        '
        Me.Cxp_abonosDataGridView.AllowUserToAddRows = False
        Me.Cxp_abonosDataGridView.AllowUserToDeleteRows = False
        Me.Cxp_abonosDataGridView.AllowUserToResizeColumns = False
        Me.Cxp_abonosDataGridView.AllowUserToResizeRows = False
        Me.Cxp_abonosDataGridView.AutoGenerateColumns = False
        Me.Cxp_abonosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Cxp_abonosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.dgvfactabono, Me.dgvabono})
        Me.Cxp_abonosDataGridView.DataSource = Me.Cxp_abonosBindingSource
        Me.Cxp_abonosDataGridView.Location = New System.Drawing.Point(7, 42)
        Me.Cxp_abonosDataGridView.Name = "Cxp_abonosDataGridView"
        Me.Cxp_abonosDataGridView.RowHeadersVisible = False
        Me.Cxp_abonosDataGridView.Size = New System.Drawing.Size(275, 172)
        Me.Cxp_abonosDataGridView.TabIndex = 12
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(207, 230)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 12
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Cxp_chequesBindingSource
        '
        Me.Cxp_chequesBindingSource.DataMember = "cxp_cheques"
        Me.Cxp_chequesBindingSource.DataSource = Me.IntegraDataSet
        '
        'IntegraDataSet
        '
        Me.IntegraDataSet.DataSetName = "integraDataSet"
        Me.IntegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvfactura
        '
        Me.dgvfactura.DataPropertyName = "factura"
        Me.dgvfactura.HeaderText = "factura"
        Me.dgvfactura.Name = "dgvfactura"
        Me.dgvfactura.ReadOnly = True
        Me.dgvfactura.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ffactura"
        DataGridViewCellStyle13.Format = "d"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 62
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fvencimiento"
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vence"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 63
        '
        'dgvimporte
        '
        Me.dgvimporte.DataPropertyName = "importe"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        Me.dgvimporte.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvimporte.HeaderText = "importe"
        Me.dgvimporte.Name = "dgvimporte"
        Me.dgvimporte.ReadOnly = True
        Me.dgvimporte.Width = 66
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "abonado"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn9.HeaderText = "abonado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 74
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "saldo"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn10.HeaderText = "saldo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 57
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "dias"
        Me.DataGridViewTextBoxColumn11.HeaderText = "dias"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 51
        '
        'Cxp_saldos_diasBindingSource
        '
        Me.Cxp_saldos_diasBindingSource.DataMember = "cxp_saldos_dias"
        Me.Cxp_saldos_diasBindingSource.DataSource = Me.IntegraDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_directorio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_banco"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_banco"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 76
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "referencia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "referencia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 79
        '
        'dgvfactabono
        '
        Me.dgvfactabono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvfactabono.DataPropertyName = "factura"
        Me.dgvfactabono.HeaderText = "factura"
        Me.dgvfactabono.Name = "dgvfactabono"
        '
        'dgvabono
        '
        Me.dgvabono.DataPropertyName = "importe"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        Me.dgvabono.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvabono.HeaderText = "importe"
        Me.dgvabono.Name = "dgvabono"
        Me.dgvabono.Width = 66
        '
        'Cxp_abonosBindingSource
        '
        Me.Cxp_abonosBindingSource.DataMember = "cxp_abonos"
        Me.Cxp_abonosBindingSource.DataSource = Me.IntegraDataSet
        '
        'Cxp_chequesTableAdapter
        '
        Me.Cxp_chequesTableAdapter.ClearBeforeFill = True
        '
        'Cxp_saldos_diasTableAdapter
        '
        Me.Cxp_saldos_diasTableAdapter.ClearBeforeFill = True
        '
        'Cxp_abonosTableAdapter
        '
        Me.Cxp_abonosTableAdapter.ClearBeforeFill = True
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(332, 77)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 13
        FechaLabel.Text = "fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Cxp_chequesBindingSource, "fecha", True))
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cxp_chequesBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(375, 73)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(184, 20)
        Me.FechaDateTimePicker.TabIndex = 14
        '
        'cxp_pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cxp_pagos"
        Me.Text = "Registro de facturas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Cxp_saldos_diasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cxp_abonosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cxp_chequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cxp_saldos_diasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cxp_abonosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents IntegraDataSet As AdminTegral.integraDataSet
    Friend WithEvents Cxp_chequesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cxp_chequesTableAdapter As AdminTegral.integraDataSetTableAdapters.cxp_chequesTableAdapter
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_bancoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_buscar_proveedor As System.Windows.Forms.Button
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Cxp_saldos_diasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cxp_saldos_diasTableAdapter As AdminTegral.integraDataSetTableAdapters.cxp_saldos_diasTableAdapter
    Friend WithEvents Cxp_saldos_diasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Cxp_abonosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cxp_abonosTableAdapter As AdminTegral.integraDataSetTableAdapters.cxp_abonosTableAdapter
    Friend WithEvents Cxp_abonosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btn_registra As System.Windows.Forms.Button
    Friend WithEvents dgvfactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvimporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvfactabono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvabono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
