<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos_crear
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim DiasLabel As System.Windows.Forms.Label
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.View_DeptosporprovTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.View_DeptosporprovTableAdapter
        Me.View_gruposporprovTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.View_gruposporprovTableAdapter
        Me.todos_deptos = New System.Windows.Forms.CheckBox
        Me.todos_grupos = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.del = New System.Windows.Forms.TextBox
        Me.al = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Boton_preparar = New System.Windows.Forms.Button
        Me.Boton_salir = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.dgvdeptos = New System.Windows.Forms.DataGridView
        Me.IddeptoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DepartamentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dps = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ViewDeptosporprovDirectorioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewDeptosporprovDirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.selec = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.dgvgrupos = New System.Windows.Forms.DataGridView
        Me.IdgruposDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrupoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gps = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ViewgruposporprovDirectorioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewgruposporprovDirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.s = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.status1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.barra = New System.Windows.Forms.ToolStripProgressBar
        Me.IvaTextBox = New System.Windows.Forms.TextBox
        Me.DiasTextBox = New System.Windows.Forms.TextBox
        Me.DepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IddeptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdgruposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDirectorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idpv = New System.Windows.Forms.TextBox
        NombreLabel = New System.Windows.Forms.Label
        DepartamentoLabel = New System.Windows.Forms.Label
        GrupoLabel = New System.Windows.Forms.Label
        IvaLabel = New System.Windows.Forms.Label
        DiasLabel = New System.Windows.Forms.Label
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdeptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewDeptosporprovDirectorioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewDeptosporprovDirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvgrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewgruposporprovDirectorioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewgruposporprovDirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(23, 40)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(115, 13)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Nombre del proveedor:"
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.Location = New System.Drawing.Point(31, 114)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(134, 13)
        DepartamentoLabel.TabIndex = 3
        DepartamentoLabel.Text = "Seleccionar departamento:"
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(209, 114)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(96, 13)
        GrupoLabel.TabIndex = 5
        GrupoLabel.Text = "Seleccionar grupo:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Enabled = False
        IvaLabel.Location = New System.Drawing.Point(89, 188)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(27, 13)
        IvaLabel.TabIndex = 20
        IvaLabel.Text = "IVA:"
        '
        'DiasLabel
        '
        DiasLabel.AutoSize = True
        DiasLabel.Enabled = False
        DiasLabel.Location = New System.Drawing.Point(82, 209)
        DiasLabel.Name = "DiasLabel"
        DiasLabel.Size = New System.Drawing.Size(31, 13)
        DiasLabel.TabIndex = 21
        DiasLabel.Text = "Dias:"
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.DirectorioBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NombreComboBox.Location = New System.Drawing.Point(26, 67)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(363, 21)
        Me.NombreComboBox.TabIndex = 1
        Me.NombreComboBox.ValueMember = "id_directorio"
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "AdmintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Preparar Pediodo a Proveedores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'View_DeptosporprovTableAdapter
        '
        Me.View_DeptosporprovTableAdapter.ClearBeforeFill = True
        '
        'View_gruposporprovTableAdapter
        '
        Me.View_gruposporprovTableAdapter.ClearBeforeFill = True
        '
        'todos_deptos
        '
        Me.todos_deptos.AutoSize = True
        Me.todos_deptos.Location = New System.Drawing.Point(24, 286)
        Me.todos_deptos.Name = "todos_deptos"
        Me.todos_deptos.Size = New System.Drawing.Size(145, 17)
        Me.todos_deptos.TabIndex = 7
        Me.todos_deptos.Text = "Todos los departamentos"
        Me.todos_deptos.UseVisualStyleBackColor = True
        '
        'todos_grupos
        '
        Me.todos_grupos.AutoSize = True
        Me.todos_grupos.Location = New System.Drawing.Point(212, 286)
        Me.todos_grupos.Name = "todos_grupos"
        Me.todos_grupos.Size = New System.Drawing.Size(107, 17)
        Me.todos_grupos.TabIndex = 8
        Me.todos_grupos.Text = "Todos los grupos"
        Me.todos_grupos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Periodo de Ventas :"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.AdminTegral.My.MySettings.Default, "periodoVta_pedidos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(103, 325)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(35, 20)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = Global.AdminTegral.My.MySettings.Default.periodoVta_pedidos
        '
        'del
        '
        Me.del.Enabled = False
        Me.del.Location = New System.Drawing.Point(147, 325)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(83, 20)
        Me.del.TabIndex = 11
        '
        'al
        '
        Me.al.Enabled = False
        Me.al.Location = New System.Drawing.Point(252, 324)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(83, 20)
        Me.al.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "al"
        '
        'Boton_preparar
        '
        Me.Boton_preparar.Location = New System.Drawing.Point(252, 372)
        Me.Boton_preparar.Name = "Boton_preparar"
        Me.Boton_preparar.Size = New System.Drawing.Size(75, 23)
        Me.Boton_preparar.TabIndex = 14
        Me.Boton_preparar.Text = "Preparar"
        Me.Boton_preparar.UseVisualStyleBackColor = True
        '
        'Boton_salir
        '
        Me.Boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Boton_salir.Location = New System.Drawing.Point(163, 372)
        Me.Boton_salir.Name = "Boton_salir"
        Me.Boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.Boton_salir.TabIndex = 15
        Me.Boton_salir.Text = "Salir"
        Me.Boton_salir.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(252, 197)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(135, 83)
        Me.dgv.TabIndex = 16
        '
        'dgvdeptos
        '
        Me.dgvdeptos.AllowUserToAddRows = False
        Me.dgvdeptos.AllowUserToDeleteRows = False
        Me.dgvdeptos.AutoGenerateColumns = False
        Me.dgvdeptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvdeptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddeptoDataGridViewTextBoxColumn1, Me.DepartamentoDataGridViewTextBoxColumn1, Me.dps})
        Me.dgvdeptos.DataSource = Me.ViewDeptosporprovDirectorioBindingSource1
        Me.dgvdeptos.Location = New System.Drawing.Point(10, 130)
        Me.dgvdeptos.Name = "dgvdeptos"
        Me.dgvdeptos.ReadOnly = True
        Me.dgvdeptos.RowHeadersVisible = False
        Me.dgvdeptos.Size = New System.Drawing.Size(188, 150)
        Me.dgvdeptos.TabIndex = 22
        '
        'IddeptoDataGridViewTextBoxColumn1
        '
        Me.IddeptoDataGridViewTextBoxColumn1.DataPropertyName = "id_depto"
        Me.IddeptoDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IddeptoDataGridViewTextBoxColumn1.Name = "IddeptoDataGridViewTextBoxColumn1"
        Me.IddeptoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IddeptoDataGridViewTextBoxColumn1.Visible = False
        Me.IddeptoDataGridViewTextBoxColumn1.Width = 41
        '
        'DepartamentoDataGridViewTextBoxColumn1
        '
        Me.DepartamentoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DepartamentoDataGridViewTextBoxColumn1.DataPropertyName = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn1.HeaderText = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn1.Name = "DepartamentoDataGridViewTextBoxColumn1"
        Me.DepartamentoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dps
        '
        Me.dps.HeaderText = "S"
        Me.dps.Name = "dps"
        Me.dps.ReadOnly = True
        Me.dps.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dps.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dps.Width = 39
        '
        'ViewDeptosporprovDirectorioBindingSource1
        '
        Me.ViewDeptosporprovDirectorioBindingSource1.DataMember = "View_Deptosporprov_Directorio"
        Me.ViewDeptosporprovDirectorioBindingSource1.DataSource = Me.DirectorioBindingSource
        '
        'ViewDeptosporprovDirectorioBindingSource
        '
        Me.ViewDeptosporprovDirectorioBindingSource.DataMember = "View_Deptosporprov_Directorio"
        Me.ViewDeptosporprovDirectorioBindingSource.DataSource = Me.DirectorioBindingSource
        '
        'selec
        '
        Me.selec.HeaderText = "S"
        Me.selec.Name = "selec"
        Me.selec.Width = 20
        '
        'dgvgrupos
        '
        Me.dgvgrupos.AllowUserToAddRows = False
        Me.dgvgrupos.AllowUserToDeleteRows = False
        Me.dgvgrupos.AutoGenerateColumns = False
        Me.dgvgrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvgrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdgruposDataGridViewTextBoxColumn1, Me.GrupoDataGridViewTextBoxColumn1, Me.gps})
        Me.dgvgrupos.DataSource = Me.ViewgruposporprovDirectorioBindingSource1
        Me.dgvgrupos.Location = New System.Drawing.Point(212, 130)
        Me.dgvgrupos.Name = "dgvgrupos"
        Me.dgvgrupos.RowHeadersVisible = False
        Me.dgvgrupos.Size = New System.Drawing.Size(179, 150)
        Me.dgvgrupos.TabIndex = 21
        '
        'IdgruposDataGridViewTextBoxColumn1
        '
        Me.IdgruposDataGridViewTextBoxColumn1.DataPropertyName = "id_grupos"
        Me.IdgruposDataGridViewTextBoxColumn1.HeaderText = "id_grupos"
        Me.IdgruposDataGridViewTextBoxColumn1.Name = "IdgruposDataGridViewTextBoxColumn1"
        Me.IdgruposDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdgruposDataGridViewTextBoxColumn1.Visible = False
        Me.IdgruposDataGridViewTextBoxColumn1.Width = 78
        '
        'GrupoDataGridViewTextBoxColumn1
        '
        Me.GrupoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GrupoDataGridViewTextBoxColumn1.DataPropertyName = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn1.HeaderText = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn1.Name = "GrupoDataGridViewTextBoxColumn1"
        Me.GrupoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'gps
        '
        Me.gps.HeaderText = "S"
        Me.gps.Name = "gps"
        Me.gps.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gps.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.gps.Width = 39
        '
        'ViewgruposporprovDirectorioBindingSource1
        '
        Me.ViewgruposporprovDirectorioBindingSource1.DataMember = "View_gruposporprov_Directorio"
        Me.ViewgruposporprovDirectorioBindingSource1.DataSource = Me.DirectorioBindingSource
        '
        'ViewgruposporprovDirectorioBindingSource
        '
        Me.ViewgruposporprovDirectorioBindingSource.DataMember = "View_gruposporprov_Directorio"
        Me.ViewgruposporprovDirectorioBindingSource.DataSource = Me.DirectorioBindingSource
        '
        's
        '
        Me.s.HeaderText = "S"
        Me.s.Name = "s"
        Me.s.Width = 20
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status1, Me.barra})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 398)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(405, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status1
        '
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(0, 17)
        '
        'barra
        '
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(100, 16)
        Me.barra.Visible = False
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "iva", True))
        Me.IvaTextBox.Enabled = False
        Me.IvaTextBox.Location = New System.Drawing.Point(119, 185)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(31, 20)
        Me.IvaTextBox.TabIndex = 21
        '
        'DiasTextBox
        '
        Me.DiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Dias", True))
        Me.DiasTextBox.Enabled = False
        Me.DiasTextBox.Location = New System.Drawing.Point(119, 206)
        Me.DiasTextBox.Name = "DiasTextBox"
        Me.DiasTextBox.Size = New System.Drawing.Size(26, 20)
        Me.DiasTextBox.TabIndex = 22
        '
        'DepartamentoDataGridViewTextBoxColumn
        '
        Me.DepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.Name = "DepartamentoDataGridViewTextBoxColumn"
        Me.DepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartamentoDataGridViewTextBoxColumn.Width = 99
        '
        'IddeptoDataGridViewTextBoxColumn
        '
        Me.IddeptoDataGridViewTextBoxColumn.DataPropertyName = "id_depto"
        Me.IddeptoDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IddeptoDataGridViewTextBoxColumn.Name = "IddeptoDataGridViewTextBoxColumn"
        Me.IddeptoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IddeptoDataGridViewTextBoxColumn.Width = 41
        '
        'IdgruposDataGridViewTextBoxColumn
        '
        Me.IdgruposDataGridViewTextBoxColumn.DataPropertyName = "id_grupos"
        Me.IdgruposDataGridViewTextBoxColumn.HeaderText = "id_grupos"
        Me.IdgruposDataGridViewTextBoxColumn.Name = "IdgruposDataGridViewTextBoxColumn"
        Me.IdgruposDataGridViewTextBoxColumn.Width = 78
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        Me.GrupoDataGridViewTextBoxColumn.Width = 61
        '
        'IdDirectorioDataGridViewTextBoxColumn
        '
        Me.IdDirectorioDataGridViewTextBoxColumn.DataPropertyName = "id_Directorio"
        Me.IdDirectorioDataGridViewTextBoxColumn.HeaderText = "id_Directorio"
        Me.IdDirectorioDataGridViewTextBoxColumn.Name = "IdDirectorioDataGridViewTextBoxColumn"
        Me.IdDirectorioDataGridViewTextBoxColumn.Width = 91
        '
        'idpv
        '
        Me.idpv.Location = New System.Drawing.Point(144, 40)
        Me.idpv.Name = "idpv"
        Me.idpv.Size = New System.Drawing.Size(38, 20)
        Me.idpv.TabIndex = 23
        '
        'Pedidos_crear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Boton_salir
        Me.ClientSize = New System.Drawing.Size(405, 420)
        Me.Controls.Add(Me.idpv)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvgrupos)
        Me.Controls.Add(Me.dgvdeptos)
        Me.Controls.Add(Me.Boton_salir)
        Me.Controls.Add(Me.Boton_preparar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.al)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.todos_grupos)
        Me.Controls.Add(Me.todos_deptos)
        Me.Controls.Add(GrupoLabel)
        Me.Controls.Add(DepartamentoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(DiasLabel)
        Me.Controls.Add(Me.DiasTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Pedidos_crear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos_crear"
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdeptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDeptosporprovDirectorioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDeptosporprovDirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvgrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewgruposporprovDirectorioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewgruposporprovDirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdmintegralDataSet As AdminTegral.AdmintegralDataSet
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents View_DeptosporprovTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.View_DeptosporprovTableAdapter
    Friend WithEvents View_gruposporprovTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.View_gruposporprovTableAdapter
    Friend WithEvents todos_deptos As System.Windows.Forms.CheckBox
    Friend WithEvents todos_grupos As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents del As System.Windows.Forms.TextBox
    Friend WithEvents al As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Boton_preparar As System.Windows.Forms.Button
    Friend WithEvents Boton_salir As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents dgvdeptos As System.Windows.Forms.DataGridView
    Friend WithEvents selec As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgvgrupos As System.Windows.Forms.DataGridView
    Friend WithEvents s As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents barra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IddeptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdgruposDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDirectorioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViewDeptosporprovDirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewgruposporprovDirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IddeptoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartamentoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dps As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ViewDeptosporprovDirectorioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ViewgruposporprovDirectorioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IdgruposDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gps As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents idpv As System.Windows.Forms.TextBox
End Class
