<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_reasignar_recibo
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
        Dim Id_pagoLabel As System.Windows.Forms.Label
        Dim CajaLabel As System.Windows.Forms.Label
        Dim Id_userLabel As System.Windows.Forms.Label
        Dim FolioLabel As System.Windows.Forms.Label
        Dim AgenteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Id_directorioLabel As System.Windows.Forms.Label
        Dim Id_fpLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim Fecha_apliacionLabel As System.Windows.Forms.Label
        Dim AplicadoLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.boton_salir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.boton_modificar = New System.Windows.Forms.Button
        Me.foliotxt = New System.Windows.Forms.TextBox
        Me.Boton_aplicar = New System.Windows.Forms.Button
        Me.total = New System.Windows.Forms.TextBox
        Me.dgvfacturas = New System.Windows.Forms.DataGridView
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Tbl_formasdepagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.IdpagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IddocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AbonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKpagosdetallepagosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_pagoTextBox = New System.Windows.Forms.TextBox
        Me.CajaTextBox = New System.Windows.Forms.TextBox
        Me.Id_userTextBox = New System.Windows.Forms.TextBox
        Me.FolioTextBox = New System.Windows.Forms.TextBox
        Me.AgenteTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox
        Me.Id_fpTextBox = New System.Windows.Forms.TextBox
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox
        Me.ImporteTextBox = New System.Windows.Forms.TextBox
        Me.Fecha_apliacionDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.AplicadoCheckBox = New System.Windows.Forms.CheckBox
        Me.BancoTextBox = New System.Windows.Forms.TextBox
        Me.PagosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.PagosTableAdapter
        Me.AgentesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
        Me.Tbl_formasdepagoTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_formasdepagoTableAdapter
        Me.Pagos_detalleTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.pagos_detalleTableAdapter
        Id_pagoLabel = New System.Windows.Forms.Label
        CajaLabel = New System.Windows.Forms.Label
        Id_userLabel = New System.Windows.Forms.Label
        FolioLabel = New System.Windows.Forms.Label
        AgenteLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        Id_directorioLabel = New System.Windows.Forms.Label
        Id_fpLabel = New System.Windows.Forms.Label
        ReferenciaLabel = New System.Windows.Forms.Label
        ImporteLabel = New System.Windows.Forms.Label
        Fecha_apliacionLabel = New System.Windows.Forms.Label
        AplicadoLabel = New System.Windows.Forms.Label
        BancoLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_formasdepagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKpagosdetallepagosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_pagoLabel
        '
        Id_pagoLabel.AutoSize = True
        Id_pagoLabel.Location = New System.Drawing.Point(21, 21)
        Id_pagoLabel.Name = "Id_pagoLabel"
        Id_pagoLabel.Size = New System.Drawing.Size(45, 13)
        Id_pagoLabel.TabIndex = 0
        Id_pagoLabel.Text = "id pago:"
        '
        'CajaLabel
        '
        CajaLabel.AutoSize = True
        CajaLabel.Location = New System.Drawing.Point(118, 21)
        CajaLabel.Name = "CajaLabel"
        CajaLabel.Size = New System.Drawing.Size(30, 13)
        CajaLabel.TabIndex = 2
        CajaLabel.Text = "caja:"
        '
        'Id_userLabel
        '
        Id_userLabel.AutoSize = True
        Id_userLabel.Location = New System.Drawing.Point(128, 245)
        Id_userLabel.Name = "Id_userLabel"
        Id_userLabel.Size = New System.Drawing.Size(41, 13)
        Id_userLabel.TabIndex = 4
        Id_userLabel.Text = "id user:"
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Location = New System.Drawing.Point(204, 21)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(29, 13)
        FolioLabel.TabIndex = 6
        FolioLabel.Text = "folio:"
        '
        'AgenteLabel
        '
        AgenteLabel.AutoSize = True
        AgenteLabel.Location = New System.Drawing.Point(23, 54)
        AgenteLabel.Name = "AgenteLabel"
        AgenteLabel.Size = New System.Drawing.Size(43, 13)
        AgenteLabel.TabIndex = 8
        AgenteLabel.Text = "agente:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(29, 84)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 10
        FechaLabel.Text = "fecha:"
        '
        'Id_directorioLabel
        '
        Id_directorioLabel.AutoSize = True
        Id_directorioLabel.Location = New System.Drawing.Point(2, 107)
        Id_directorioLabel.Name = "Id_directorioLabel"
        Id_directorioLabel.Size = New System.Drawing.Size(56, 13)
        Id_directorioLabel.TabIndex = 12
        Id_directorioLabel.Text = "ID Cliente:"
        '
        'Id_fpLabel
        '
        Id_fpLabel.AutoSize = True
        Id_fpLabel.Location = New System.Drawing.Point(36, 133)
        Id_fpLabel.Name = "Id_fpLabel"
        Id_fpLabel.Size = New System.Drawing.Size(30, 13)
        Id_fpLabel.TabIndex = 16
        Id_fpLabel.Text = "id fp:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(9, 159)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(57, 13)
        ReferenciaLabel.TabIndex = 18
        ReferenciaLabel.Text = "referencia:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(21, 211)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(45, 13)
        ImporteLabel.TabIndex = 20
        ImporteLabel.Text = "Importe:"
        '
        'Fecha_apliacionLabel
        '
        Fecha_apliacionLabel.AutoSize = True
        Fecha_apliacionLabel.Location = New System.Drawing.Point(136, 111)
        Fecha_apliacionLabel.Name = "Fecha_apliacionLabel"
        Fecha_apliacionLabel.Size = New System.Drawing.Size(82, 13)
        Fecha_apliacionLabel.TabIndex = 22
        Fecha_apliacionLabel.Text = "fecha apliacion:"
        '
        'AplicadoLabel
        '
        AplicadoLabel.AutoSize = True
        AplicadoLabel.Location = New System.Drawing.Point(15, 245)
        AplicadoLabel.Name = "AplicadoLabel"
        AplicadoLabel.Size = New System.Drawing.Size(51, 13)
        AplicadoLabel.TabIndex = 24
        AplicadoLabel.Text = "Aplicado:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(26, 185)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(40, 13)
        BancoLabel.TabIndex = 26
        BancoLabel.Text = "banco:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_modificar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.foliotxt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Boton_aplicar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.total)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvfacturas)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DescripcionComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Panel2.Controls.Add(Id_pagoLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Id_pagoTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(CajaLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CajaTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Id_userLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Id_userTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(FolioLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FolioTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(AgenteLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AgenteTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(FechaLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer1.Panel2.Controls.Add(Id_directorioLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Id_directorioTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Id_fpLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Id_fpTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(ReferenciaLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReferenciaTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(ImporteLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ImporteTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Fecha_apliacionLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Fecha_apliacionDateTimePicker)
        Me.SplitContainer1.Panel2.Controls.Add(AplicadoLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AplicadoCheckBox)
        Me.SplitContainer1.Panel2.Controls.Add(BancoLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BancoTextBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(749, 368)
        Me.SplitContainer1.SplitterDistance = 38
        Me.SplitContainer1.TabIndex = 0
        '
        'boton_salir
        '
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(667, 3)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 3
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        Me.boton_salir.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Teclee el No. de Recibo :"
        '
        'boton_modificar
        '
        Me.boton_modificar.Location = New System.Drawing.Point(334, 3)
        Me.boton_modificar.Name = "boton_modificar"
        Me.boton_modificar.Size = New System.Drawing.Size(75, 23)
        Me.boton_modificar.TabIndex = 2
        Me.boton_modificar.Text = "Modificar"
        Me.boton_modificar.UseVisualStyleBackColor = True
        Me.boton_modificar.Visible = False
        '
        'foliotxt
        '
        Me.foliotxt.Location = New System.Drawing.Point(139, 8)
        Me.foliotxt.Name = "foliotxt"
        Me.foliotxt.Size = New System.Drawing.Size(94, 20)
        Me.foliotxt.TabIndex = 0
        '
        'Boton_aplicar
        '
        Me.Boton_aplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton_aplicar.Location = New System.Drawing.Point(556, 292)
        Me.Boton_aplicar.Name = "Boton_aplicar"
        Me.Boton_aplicar.Size = New System.Drawing.Size(75, 23)
        Me.Boton_aplicar.TabIndex = 32
        Me.Boton_aplicar.Text = "Aplicar"
        Me.Boton_aplicar.UseVisualStyleBackColor = True
        Me.Boton_aplicar.Visible = False
        '
        'total
        '
        Me.total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total.Location = New System.Drawing.Point(635, 292)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 31
        '
        'dgvfacturas
        '
        Me.dgvfacturas.AllowUserToAddRows = False
        Me.dgvfacturas.AllowUserToDeleteRows = False
        Me.dgvfacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfacturas.Location = New System.Drawing.Point(334, 132)
        Me.dgvfacturas.Name = "dgvfacturas"
        Me.dgvfacturas.RowHeadersVisible = False
        Me.dgvfacturas.Size = New System.Drawing.Size(401, 159)
        Me.dgvfacturas.TabIndex = 30
        Me.dgvfacturas.Visible = False
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PagosBindingSource, "id_fp", True))
        Me.DescripcionComboBox.DataSource = Me.Tbl_formasdepagoBindingSource
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DescripcionComboBox.Enabled = False
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(113, 132)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(160, 21)
        Me.DescripcionComboBox.TabIndex = 29
        Me.DescripcionComboBox.ValueMember = "id_fp"
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_formasdepagoBindingSource
        '
        Me.Tbl_formasdepagoBindingSource.DataMember = "tbl_formasdepago"
        Me.Tbl_formasdepagoBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PagosBindingSource, "agente", True))
        Me.NombreComboBox.DataSource = Me.AgentesBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NombreComboBox.Enabled = False
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(103, 51)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(219, 21)
        Me.NombreComboBox.TabIndex = 28
        Me.NombreComboBox.ValueMember = "id_agente"
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'dgv
        '
        Me.dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpagoDataGridViewTextBoxColumn, Me.IddocDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.AbonoDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.FKpagosdetallepagosdetalleBindingSource
        Me.dgv.Location = New System.Drawing.Point(334, 11)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(186, 116)
        Me.dgv.TabIndex = 27
        '
        'IdpagoDataGridViewTextBoxColumn
        '
        Me.IdpagoDataGridViewTextBoxColumn.DataPropertyName = "id_pago"
        Me.IdpagoDataGridViewTextBoxColumn.HeaderText = "id_pago"
        Me.IdpagoDataGridViewTextBoxColumn.Name = "IdpagoDataGridViewTextBoxColumn"
        Me.IdpagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdpagoDataGridViewTextBoxColumn.Visible = False
        Me.IdpagoDataGridViewTextBoxColumn.Width = 70
        '
        'IddocDataGridViewTextBoxColumn
        '
        Me.IddocDataGridViewTextBoxColumn.DataPropertyName = "id_doc"
        Me.IddocDataGridViewTextBoxColumn.HeaderText = "id_doc"
        Me.IddocDataGridViewTextBoxColumn.Name = "IddocDataGridViewTextBoxColumn"
        Me.IddocDataGridViewTextBoxColumn.ReadOnly = True
        Me.IddocDataGridViewTextBoxColumn.Visible = False
        Me.IddocDataGridViewTextBoxColumn.Width = 64
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioDataGridViewTextBoxColumn.Width = 51
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SerieDataGridViewTextBoxColumn.Width = 54
        '
        'AbonoDataGridViewTextBoxColumn
        '
        Me.AbonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AbonoDataGridViewTextBoxColumn.DataPropertyName = "abono"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.AbonoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.AbonoDataGridViewTextBoxColumn.HeaderText = "abono"
        Me.AbonoDataGridViewTextBoxColumn.Name = "AbonoDataGridViewTextBoxColumn"
        Me.AbonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FKpagosdetallepagosdetalleBindingSource
        '
        Me.FKpagosdetallepagosdetalleBindingSource.DataMember = "FK_pagos_detalle_pagos_detalle"
        Me.FKpagosdetallepagosdetalleBindingSource.DataSource = Me.PagosBindingSource
        '
        'Id_pagoTextBox
        '
        Me.Id_pagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "id_pago", True))
        Me.Id_pagoTextBox.Location = New System.Drawing.Point(73, 17)
        Me.Id_pagoTextBox.Name = "Id_pagoTextBox"
        Me.Id_pagoTextBox.ReadOnly = True
        Me.Id_pagoTextBox.Size = New System.Drawing.Size(39, 20)
        Me.Id_pagoTextBox.TabIndex = 1
        '
        'CajaTextBox
        '
        Me.CajaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "caja", True))
        Me.CajaTextBox.Location = New System.Drawing.Point(154, 17)
        Me.CajaTextBox.Name = "CajaTextBox"
        Me.CajaTextBox.ReadOnly = True
        Me.CajaTextBox.Size = New System.Drawing.Size(34, 20)
        Me.CajaTextBox.TabIndex = 3
        '
        'Id_userTextBox
        '
        Me.Id_userTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "id_user", True))
        Me.Id_userTextBox.Location = New System.Drawing.Point(196, 241)
        Me.Id_userTextBox.Name = "Id_userTextBox"
        Me.Id_userTextBox.ReadOnly = True
        Me.Id_userTextBox.Size = New System.Drawing.Size(22, 20)
        Me.Id_userTextBox.TabIndex = 5
        '
        'FolioTextBox
        '
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "folio", True))
        Me.FolioTextBox.Location = New System.Drawing.Point(255, 17)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.ReadOnly = True
        Me.FolioTextBox.Size = New System.Drawing.Size(48, 20)
        Me.FolioTextBox.TabIndex = 7
        '
        'AgenteTextBox
        '
        Me.AgenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "agente", True))
        Me.AgenteTextBox.Location = New System.Drawing.Point(73, 51)
        Me.AgenteTextBox.Name = "AgenteTextBox"
        Me.AgenteTextBox.ReadOnly = True
        Me.AgenteTextBox.Size = New System.Drawing.Size(21, 20)
        Me.AgenteTextBox.TabIndex = 9
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PagosBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(73, 78)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.FechaDateTimePicker.TabIndex = 11
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "id_directorio", True))
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(73, 107)
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.ReadOnly = True
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(57, 20)
        Me.Id_directorioTextBox.TabIndex = 13
        '
        'Id_fpTextBox
        '
        Me.Id_fpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "id_fp", True))
        Me.Id_fpTextBox.Location = New System.Drawing.Point(73, 133)
        Me.Id_fpTextBox.Name = "Id_fpTextBox"
        Me.Id_fpTextBox.ReadOnly = True
        Me.Id_fpTextBox.Size = New System.Drawing.Size(34, 20)
        Me.Id_fpTextBox.TabIndex = 17
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(73, 159)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.ReadOnly = True
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReferenciaTextBox.TabIndex = 19
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.ImporteTextBox.Location = New System.Drawing.Point(73, 211)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.ReadOnly = True
        Me.ImporteTextBox.Size = New System.Drawing.Size(89, 20)
        Me.ImporteTextBox.TabIndex = 21
        Me.ImporteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fecha_apliacionDateTimePicker
        '
        Me.Fecha_apliacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PagosBindingSource, "fecha_apliacion", True))
        Me.Fecha_apliacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_apliacionDateTimePicker.Location = New System.Drawing.Point(224, 107)
        Me.Fecha_apliacionDateTimePicker.Name = "Fecha_apliacionDateTimePicker"
        Me.Fecha_apliacionDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.Fecha_apliacionDateTimePicker.TabIndex = 23
        '
        'AplicadoCheckBox
        '
        Me.AplicadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PagosBindingSource, "Aplicado", True))
        Me.AplicadoCheckBox.Enabled = False
        Me.AplicadoCheckBox.Location = New System.Drawing.Point(73, 239)
        Me.AplicadoCheckBox.Name = "AplicadoCheckBox"
        Me.AplicadoCheckBox.Size = New System.Drawing.Size(34, 24)
        Me.AplicadoCheckBox.TabIndex = 25
        '
        'BancoTextBox
        '
        Me.BancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "banco", True))
        Me.BancoTextBox.Location = New System.Drawing.Point(73, 185)
        Me.BancoTextBox.Name = "BancoTextBox"
        Me.BancoTextBox.ReadOnly = True
        Me.BancoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BancoTextBox.TabIndex = 27
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_formasdepagoTableAdapter
        '
        Me.Tbl_formasdepagoTableAdapter.ClearBeforeFill = True
        '
        'Pagos_detalleTableAdapter
        '
        Me.Pagos_detalleTableAdapter.ClearBeforeFill = True
        '
        'cxc_reasignar_recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(749, 368)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cxc_reasignar_recibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cxc_reasignar_recibo"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_formasdepagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKpagosdetallepagosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents PagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.PagosTableAdapter
    Friend WithEvents Id_pagoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CajaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_userTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_fpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_apliacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AplicadoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BancoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents AgentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_formasdepagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_formasdepagoTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_formasdepagoTableAdapter
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FKpagosdetallepagosdetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pagos_detalleTableAdapter As AdminTegral.admintegralDataSetTableAdapters.pagos_detalleTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents foliotxt As System.Windows.Forms.TextBox
    Friend WithEvents boton_modificar As System.Windows.Forms.Button
    Friend WithEvents dgvfacturas As System.Windows.Forms.DataGridView
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents IdpagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IddocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Boton_aplicar As System.Windows.Forms.Button
    Friend WithEvents boton_salir As System.Windows.Forms.Button
End Class
