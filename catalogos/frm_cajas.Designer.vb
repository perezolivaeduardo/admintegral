<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cajas
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
        Dim Id_cajaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim SerieLabel As System.Windows.Forms.Label
        Dim LocalLabel As System.Windows.Forms.Label
        Dim CajonLabel As System.Windows.Forms.Label
        Dim Abrir_cajonLabel As System.Windows.Forms.Label
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cajas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SeriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.fei_serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_almacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenComboBox = New System.Windows.Forms.ComboBox()
        Me.SerieComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.boton_test = New System.Windows.Forms.Button()
        Me.Abrir_cajonTextBox = New System.Windows.Forms.TextBox()
        Me.AlmacenTextBox = New System.Windows.Forms.TextBox()
        Me.CajonCheckBox = New System.Windows.Forms.CheckBox()
        Me.Id_cajaTextBox = New System.Windows.Forms.TextBox()
        Me.LocalCheckBox = New System.Windows.Forms.CheckBox()
        Me.SerieTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SeriesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Tbl_almacenesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CajasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.CajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter()
        Me.SeriesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.SeriesTableAdapter()
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter()
        Id_cajaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        SerieLabel = New System.Windows.Forms.Label()
        LocalLabel = New System.Windows.Forms.Label()
        CajonLabel = New System.Windows.Forms.Label()
        Abrir_cajonLabel = New System.Windows.Forms.Label()
        AlmacenLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SeriesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Tbl_almacenesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CajasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_cajaLabel
        '
        Id_cajaLabel.AutoSize = True
        Id_cajaLabel.Location = New System.Drawing.Point(26, 50)
        Id_cajaLabel.Name = "Id_cajaLabel"
        Id_cajaLabel.Size = New System.Drawing.Size(41, 13)
        Id_cajaLabel.TabIndex = 0
        Id_cajaLabel.Text = "id caja:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(20, 76)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'SerieLabel
        '
        SerieLabel.AutoSize = True
        SerieLabel.Location = New System.Drawing.Point(33, 102)
        SerieLabel.Name = "SerieLabel"
        SerieLabel.Size = New System.Drawing.Size(34, 13)
        SerieLabel.TabIndex = 4
        SerieLabel.Text = "Serie:"
        '
        'LocalLabel
        '
        LocalLabel.AutoSize = True
        LocalLabel.Location = New System.Drawing.Point(35, 149)
        LocalLabel.Name = "LocalLabel"
        LocalLabel.Size = New System.Drawing.Size(32, 13)
        LocalLabel.TabIndex = 6
        LocalLabel.Text = "local:"
        '
        'CajonLabel
        '
        CajonLabel.AutoSize = True
        CajonLabel.Location = New System.Drawing.Point(31, 179)
        CajonLabel.Name = "CajonLabel"
        CajonLabel.Size = New System.Drawing.Size(36, 13)
        CajonLabel.TabIndex = 14
        CajonLabel.Text = "cajon:"
        '
        'Abrir_cajonLabel
        '
        Abrir_cajonLabel.AutoSize = True
        Abrir_cajonLabel.Location = New System.Drawing.Point(8, 207)
        Abrir_cajonLabel.Name = "Abrir_cajonLabel"
        Abrir_cajonLabel.Size = New System.Drawing.Size(59, 13)
        Abrir_cajonLabel.TabIndex = 16
        Abrir_cajonLabel.Text = "abrir cajon:"
        '
        'AlmacenLabel
        '
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Location = New System.Drawing.Point(16, 128)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(50, 13)
        AlmacenLabel.TabIndex = 19
        AlmacenLabel.Text = "almacen:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(591, 411)
        Me.SplitContainer1.SplitterDistance = 59
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminTegral.My.Resources.Resources.caja
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(591, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cajas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CajasBindingNavigator)
        Me.SplitContainer2.Size = New System.Drawing.Size(591, 348)
        Me.SplitContainer2.SplitterDistance = 304
        Me.SplitContainer2.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(591, 304)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Controls.Add(Me.AlmacenComboBox)
        Me.TabPage1.Controls.Add(Me.SerieComboBox)
        Me.TabPage1.Controls.Add(Me.NombreTextBox)
        Me.TabPage1.Controls.Add(Me.boton_test)
        Me.TabPage1.Controls.Add(Me.Abrir_cajonTextBox)
        Me.TabPage1.Controls.Add(AlmacenLabel)
        Me.TabPage1.Controls.Add(Abrir_cajonLabel)
        Me.TabPage1.Controls.Add(Me.AlmacenTextBox)
        Me.TabPage1.Controls.Add(Me.CajonCheckBox)
        Me.TabPage1.Controls.Add(Id_cajaLabel)
        Me.TabPage1.Controls.Add(CajonLabel)
        Me.TabPage1.Controls.Add(Me.Id_cajaTextBox)
        Me.TabPage1.Controls.Add(Me.LocalCheckBox)
        Me.TabPage1.Controls.Add(NombreLabel)
        Me.TabPage1.Controls.Add(LocalLabel)
        Me.TabPage1.Controls.Add(Me.SerieTextBox)
        Me.TabPage1.Controls.Add(SerieLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(583, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cajas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.fei_serie, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgv.DataSource = Me.CajasBindingSource
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(577, 272)
        Me.dgv.TabIndex = 23
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_caja"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 41
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 69
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Serie"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.SeriesBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "serie"
        Me.DataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn8.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "serie"
        Me.DataGridViewTextBoxColumn8.Width = 56
        '
        'SeriesBindingSource
        '
        Me.SeriesBindingSource.DataMember = "Series"
        Me.SeriesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fei_serie
        '
        Me.fei_serie.DataPropertyName = "fei_serie"
        Me.fei_serie.HeaderText = "Serie CFD"
        Me.fei_serie.Name = "fei_serie"
        Me.fei_serie.Width = 80
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "local"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "local"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 35
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "cajon"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "cajon"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 39
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "abrir_cajon"
        Me.DataGridViewTextBoxColumn9.HeaderText = "abrir_cajon"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 84
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "almacen"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.Tbl_almacenesBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "Almacen"
        Me.DataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn10.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.ValueMember = "id_almacen"
        Me.DataGridViewTextBoxColumn10.Width = 73
        '
        'Tbl_almacenesBindingSource
        '
        Me.Tbl_almacenesBindingSource.DataMember = "tbl_almacenes"
        Me.Tbl_almacenesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'CajasBindingSource
        '
        Me.CajasBindingSource.DataMember = "cajas"
        Me.CajasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CajasBindingSource, "almacen", True))
        Me.AlmacenComboBox.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox.DisplayMember = "Almacen"
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Location = New System.Drawing.Point(72, 125)
        Me.AlmacenComboBox.Name = "AlmacenComboBox"
        Me.AlmacenComboBox.Size = New System.Drawing.Size(134, 21)
        Me.AlmacenComboBox.TabIndex = 23
        Me.AlmacenComboBox.ValueMember = "id_almacen"
        '
        'SerieComboBox
        '
        Me.SerieComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CajasBindingSource, "Serie", True))
        Me.SerieComboBox.DataSource = Me.SeriesBindingSource
        Me.SerieComboBox.DisplayMember = "serie"
        Me.SerieComboBox.FormattingEnabled = True
        Me.SerieComboBox.Location = New System.Drawing.Point(73, 98)
        Me.SerieComboBox.Name = "SerieComboBox"
        Me.SerieComboBox.Size = New System.Drawing.Size(50, 21)
        Me.SerieComboBox.TabIndex = 22
        Me.SerieComboBox.ValueMember = "serie"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(73, 73)
        Me.NombreTextBox.MaxLength = 20
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(174, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'boton_test
        '
        Me.boton_test.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_test.Location = New System.Drawing.Point(169, 204)
        Me.boton_test.Name = "boton_test"
        Me.boton_test.Size = New System.Drawing.Size(46, 20)
        Me.boton_test.TabIndex = 21
        Me.boton_test.Text = "test"
        Me.boton_test.UseVisualStyleBackColor = True
        '
        'Abrir_cajonTextBox
        '
        Me.Abrir_cajonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "abrir_cajon", True))
        Me.Abrir_cajonTextBox.Location = New System.Drawing.Point(73, 204)
        Me.Abrir_cajonTextBox.MaxLength = 10
        Me.Abrir_cajonTextBox.Name = "Abrir_cajonTextBox"
        Me.Abrir_cajonTextBox.Size = New System.Drawing.Size(90, 20)
        Me.Abrir_cajonTextBox.TabIndex = 17
        '
        'AlmacenTextBox
        '
        Me.AlmacenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "almacen", True))
        Me.AlmacenTextBox.Enabled = False
        Me.AlmacenTextBox.Location = New System.Drawing.Point(113, 126)
        Me.AlmacenTextBox.Name = "AlmacenTextBox"
        Me.AlmacenTextBox.Size = New System.Drawing.Size(35, 20)
        Me.AlmacenTextBox.TabIndex = 20
        '
        'CajonCheckBox
        '
        Me.CajonCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CajasBindingSource, "cajon", True))
        Me.CajonCheckBox.Location = New System.Drawing.Point(73, 174)
        Me.CajonCheckBox.Name = "CajonCheckBox"
        Me.CajonCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.CajonCheckBox.TabIndex = 15
        '
        'Id_cajaTextBox
        '
        Me.Id_cajaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "id_caja", True))
        Me.Id_cajaTextBox.Location = New System.Drawing.Point(73, 47)
        Me.Id_cajaTextBox.Name = "Id_cajaTextBox"
        Me.Id_cajaTextBox.Size = New System.Drawing.Size(34, 20)
        Me.Id_cajaTextBox.TabIndex = 1
        '
        'LocalCheckBox
        '
        Me.LocalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CajasBindingSource, "local", True))
        Me.LocalCheckBox.Location = New System.Drawing.Point(73, 144)
        Me.LocalCheckBox.Name = "LocalCheckBox"
        Me.LocalCheckBox.Size = New System.Drawing.Size(34, 24)
        Me.LocalCheckBox.TabIndex = 7
        '
        'SerieTextBox
        '
        Me.SerieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "Serie", True))
        Me.SerieTextBox.Enabled = False
        Me.SerieTextBox.Location = New System.Drawing.Point(89, 128)
        Me.SerieTextBox.MaxLength = 3
        Me.SerieTextBox.Name = "SerieTextBox"
        Me.SerieTextBox.Size = New System.Drawing.Size(34, 20)
        Me.SerieTextBox.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.SeriesDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(583, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Series"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SeriesDataGridView
        '
        Me.SeriesDataGridView.AutoGenerateColumns = False
        Me.SeriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.SeriesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.SeriesDataGridView.DataSource = Me.SeriesBindingSource
        Me.SeriesDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.SeriesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SeriesDataGridView.Name = "SeriesDataGridView"
        Me.SeriesDataGridView.Size = New System.Drawing.Size(252, 272)
        Me.SeriesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "serie"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 56
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 54
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "remision"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ticket"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 62
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Tbl_almacenesDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(583, 278)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Almacenes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Tbl_almacenesDataGridView
        '
        Me.Tbl_almacenesDataGridView.AutoGenerateColumns = False
        Me.Tbl_almacenesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Tbl_almacenesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.direccion})
        Me.Tbl_almacenesDataGridView.DataSource = Me.Tbl_almacenesBindingSource
        Me.Tbl_almacenesDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.Tbl_almacenesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_almacenesDataGridView.Name = "Tbl_almacenesDataGridView"
        Me.Tbl_almacenesDataGridView.Size = New System.Drawing.Size(554, 278)
        Me.Tbl_almacenesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_almacen"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 41
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Almacen"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 73
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "direccion"
        Me.direccion.MaxInputLength = 100
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 75
        '
        'CajasBindingNavigator
        '
        Me.CajasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CajasBindingNavigator.BindingSource = Me.CajasBindingSource
        Me.CajasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CajasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CajasBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CajasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CajasBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.CajasBindingNavigator.Location = New System.Drawing.Point(0, 15)
        Me.CajasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CajasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CajasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CajasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CajasBindingNavigator.Name = "CajasBindingNavigator"
        Me.CajasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CajasBindingNavigator.Size = New System.Drawing.Size(591, 25)
        Me.CajasBindingNavigator.TabIndex = 1
        Me.CajasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CajasBindingNavigatorSaveItem
        '
        Me.CajasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CajasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CajasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CajasBindingNavigatorSaveItem.Name = "CajasBindingNavigatorSaveItem"
        Me.CajasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CajasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Vista__50_
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "On/Off Grid Cajas"
        '
        'CajasTableAdapter
        '
        Me.CajasTableAdapter.ClearBeforeFill = True
        '
        'SeriesTableAdapter
        '
        Me.SeriesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_almacenesTableAdapter
        '
        Me.Tbl_almacenesTableAdapter.ClearBeforeFill = True
        '
        'frm_cajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 411)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_cajas"
        Me.Text = "Catalogo de Cajas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.SeriesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Tbl_almacenesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CajasBindingNavigator.ResumeLayout(False)
        Me.CajasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents CajasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CajasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_cajaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SerieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CajonCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Abrir_cajonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AlmacenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents boton_test As System.Windows.Forms.Button
    Friend WithEvents SeriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeriesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.SeriesTableAdapter
    Friend WithEvents SerieComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SeriesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tbl_almacenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_almacenesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
    Friend WithEvents Tbl_almacenesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AlmacenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents fei_serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
