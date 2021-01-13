<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kardex
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
        Dim AlmacenLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Descripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Existencia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.id = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Dgvexistencia = New System.Windows.Forms.DataGridView
        Me.dgvresumen = New System.Windows.Forms.DataGridView
        Me.dgvalmacen = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.ntraspsal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ntraspent = New System.Windows.Forms.TextBox
        Me.ndevcliente = New System.Windows.Forms.TextBox
        Me.nventas = New System.Windows.Forms.TextBox
        Me.ndevoluc = New System.Windows.Forms.TextBox
        Me.nentrada = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.vista_estrecha = New System.Windows.Forms.CheckBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Id_almacenTextBox = New System.Windows.Forms.TextBox
        Me.Tbl_almacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.AlmacenComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
        Me.Button2 = New System.Windows.Forms.Button
        AlmacenLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Dgvexistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvresumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvalmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlmacenLabel
        '
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlmacenLabel.Location = New System.Drawing.Point(17, 24)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(69, 18)
        AlmacenLabel.TabIndex = 1
        AlmacenLabel.Text = "Almacen:"
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Descripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Existencia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(953, 514)
        Me.SplitContainer1.SplitterDistance = 40
        Me.SplitContainer1.TabIndex = 0
        '
        'Descripcion
        '
        Me.Descripcion.Enabled = False
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(186, 9)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(323, 26)
        Me.Descripcion.TabIndex = 5
        Me.Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(758, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Existencia :"
        '
        'Existencia
        '
        Me.Existencia.Enabled = False
        Me.Existencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Existencia.Location = New System.Drawing.Point(853, 7)
        Me.Existencia.Name = "Existencia"
        Me.Existencia.Size = New System.Drawing.Size(97, 26)
        Me.Existencia.TabIndex = 3
        Me.Existencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id_producto :"
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(112, 9)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(68, 24)
        Me.id.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.Dgvexistencia)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvresumen)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvalmacen)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ntraspsal)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ntraspent)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ndevcliente)
        Me.SplitContainer2.Panel2.Controls.Add(Me.nventas)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ndevoluc)
        Me.SplitContainer2.Panel2.Controls.Add(Me.nentrada)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.vista_estrecha)
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Id_almacenTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.AlmacenComboBox)
        Me.SplitContainer2.Panel2.Controls.Add(AlmacenLabel)
        Me.SplitContainer2.Size = New System.Drawing.Size(953, 470)
        Me.SplitContainer2.SplitterDistance = 324
        Me.SplitContainer2.TabIndex = 0
        '
        'Dgvexistencia
        '
        Me.Dgvexistencia.AllowUserToAddRows = False
        Me.Dgvexistencia.AllowUserToDeleteRows = False
        Me.Dgvexistencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgvexistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.Dgvexistencia.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.Dgvexistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvexistencia.Location = New System.Drawing.Point(9, 3)
        Me.Dgvexistencia.Name = "Dgvexistencia"
        Me.Dgvexistencia.ReadOnly = True
        Me.Dgvexistencia.RowHeadersVisible = False
        Me.Dgvexistencia.Size = New System.Drawing.Size(312, 150)
        Me.Dgvexistencia.TabIndex = 3
        '
        'dgvresumen
        '
        Me.dgvresumen.AllowUserToAddRows = False
        Me.dgvresumen.AllowUserToDeleteRows = False
        Me.dgvresumen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvresumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgvresumen.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvresumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvresumen.Location = New System.Drawing.Point(9, 152)
        Me.dgvresumen.Name = "dgvresumen"
        Me.dgvresumen.ReadOnly = True
        Me.dgvresumen.RowHeadersVisible = False
        Me.dgvresumen.Size = New System.Drawing.Size(312, 150)
        Me.dgvresumen.TabIndex = 2
        '
        'dgvalmacen
        '
        Me.dgvalmacen.AllowUserToAddRows = False
        Me.dgvalmacen.AllowUserToDeleteRows = False
        Me.dgvalmacen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvalmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgvalmacen.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvalmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvalmacen.Location = New System.Drawing.Point(9, 301)
        Me.dgvalmacen.Name = "dgvalmacen"
        Me.dgvalmacen.ReadOnly = True
        Me.dgvalmacen.RowHeadersVisible = False
        Me.dgvalmacen.Size = New System.Drawing.Size(312, 143)
        Me.dgvalmacen.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ntraspsal
        '
        Me.ntraspsal.Enabled = False
        Me.ntraspsal.Location = New System.Drawing.Point(98, 415)
        Me.ntraspsal.Name = "ntraspsal"
        Me.ntraspsal.Size = New System.Drawing.Size(45, 20)
        Me.ntraspsal.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Trasp. Salida :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Trasp. entrada:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Devol. Clientes :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Ventas :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Devoluciones :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Entradas :"
        '
        'ntraspent
        '
        Me.ntraspent.Enabled = False
        Me.ntraspent.Location = New System.Drawing.Point(98, 395)
        Me.ntraspent.Name = "ntraspent"
        Me.ntraspent.Size = New System.Drawing.Size(45, 20)
        Me.ntraspent.TabIndex = 11
        '
        'ndevcliente
        '
        Me.ndevcliente.Enabled = False
        Me.ndevcliente.Location = New System.Drawing.Point(98, 375)
        Me.ndevcliente.Name = "ndevcliente"
        Me.ndevcliente.Size = New System.Drawing.Size(45, 20)
        Me.ndevcliente.TabIndex = 10
        '
        'nventas
        '
        Me.nventas.Enabled = False
        Me.nventas.Location = New System.Drawing.Point(98, 355)
        Me.nventas.Name = "nventas"
        Me.nventas.Size = New System.Drawing.Size(45, 20)
        Me.nventas.TabIndex = 9
        '
        'ndevoluc
        '
        Me.ndevoluc.Enabled = False
        Me.ndevoluc.Location = New System.Drawing.Point(98, 335)
        Me.ndevoluc.Name = "ndevoluc"
        Me.ndevoluc.Size = New System.Drawing.Size(45, 20)
        Me.ndevoluc.TabIndex = 8
        '
        'nentrada
        '
        Me.nentrada.Enabled = False
        Me.nentrada.Location = New System.Drawing.Point(98, 315)
        Me.nentrada.Name = "nentrada"
        Me.nentrada.Size = New System.Drawing.Size(45, 20)
        Me.nentrada.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(199, 308)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(414, 120)
        Me.DataGridView1.TabIndex = 6
        '
        'vista_estrecha
        '
        Me.vista_estrecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.vista_estrecha.AutoSize = True
        Me.vista_estrecha.Checked = True
        Me.vista_estrecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.vista_estrecha.Location = New System.Drawing.Point(8, 450)
        Me.vista_estrecha.Name = "vista_estrecha"
        Me.vista_estrecha.Size = New System.Drawing.Size(94, 17)
        Me.vista_estrecha.TabIndex = 5
        Me.vista_estrecha.Text = "Vista Estrecha"
        Me.vista_estrecha.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgv.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(8, 51)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(605, 251)
        Me.dgv.TabIndex = 0
        '
        'Id_almacenTextBox
        '
        Me.Id_almacenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_almacenesBindingSource, "id_almacen", True))
        Me.Id_almacenTextBox.Location = New System.Drawing.Point(84, 24)
        Me.Id_almacenTextBox.Name = "Id_almacenTextBox"
        Me.Id_almacenTextBox.ReadOnly = True
        Me.Id_almacenTextBox.Size = New System.Drawing.Size(30, 20)
        Me.Id_almacenTextBox.TabIndex = 4
        '
        'Tbl_almacenesBindingSource
        '
        Me.Tbl_almacenesBindingSource.DataMember = "tbl_almacenes"
        Me.Tbl_almacenesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AlmacenComboBox.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox.DisplayMember = "Almacen"
        Me.AlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlmacenComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Location = New System.Drawing.Point(120, 24)
        Me.AlmacenComboBox.Name = "AlmacenComboBox"
        Me.AlmacenComboBox.Size = New System.Drawing.Size(302, 21)
        Me.AlmacenComboBox.TabIndex = 2
        Me.AlmacenComboBox.ValueMember = "id_almacen"
        '
        'Tbl_almacenesTableAdapter
        '
        Me.Tbl_almacenesTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(450, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "check"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 514)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Kardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kardex"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Dgvexistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvresumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvalmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Tbl_almacenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_almacenesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
    Friend WithEvents AlmacenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Id_almacenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vista_estrecha As System.Windows.Forms.CheckBox
    Friend WithEvents dgvresumen As System.Windows.Forms.DataGridView
    Friend WithEvents dgvalmacen As System.Windows.Forms.DataGridView
    Friend WithEvents Dgvexistencia As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Existencia As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ntraspent As System.Windows.Forms.TextBox
    Friend WithEvents ndevcliente As System.Windows.Forms.TextBox
    Friend WithEvents nventas As System.Windows.Forms.TextBox
    Friend WithEvents ndevoluc As System.Windows.Forms.TextBox
    Friend WithEvents nentrada As System.Windows.Forms.TextBox
    Friend WithEvents ntraspsal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
