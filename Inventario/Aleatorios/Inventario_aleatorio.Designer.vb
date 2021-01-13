<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario_aleatorio
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fconteo = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Inv_aleatorioDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgv_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntegraDataSet = New AdminTegral.integraDataSet()
        Me.dgv_existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_fisico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Inv_aleatorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_genera = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Sql_inv_aleatorio_fijoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_inv_aleatorio_fijoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.items_adicion = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ProductosinvaleatorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosinvaleatorioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sql_inv_aleatorio_fijoTableAdapter = New AdminTegral.integraDataSetTableAdapters.sql_inv_aleatorio_fijoTableAdapter()
        Me.Inv_aleatorioTableAdapter = New AdminTegral.integraDataSetTableAdapters.inv_aleatorioTableAdapter()
        Me.ProductosTableAdapter = New AdminTegral.integraDataSetTableAdapters.productosTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Inv_aleatorioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_aleatorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Sql_inv_aleatorio_fijoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_inv_aleatorio_fijoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ProductosinvaleatorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosinvaleatorioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1136, 397)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.fconteo)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Inv_aleatorioDataGridView)
        Me.TabPage1.Controls.Add(Me.btn_genera)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1128, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventario Aleatorio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(174, 339)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Aplicar diferencias"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha :"
        '
        'fconteo
        '
        Me.fconteo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fconteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fconteo.Location = New System.Drawing.Point(98, 23)
        Me.fconteo.Name = "fconteo"
        Me.fconteo.Size = New System.Drawing.Size(311, 26)
        Me.fconteo.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(1035, 342)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Inv_aleatorioDataGridView
        '
        Me.Inv_aleatorioDataGridView.AllowUserToAddRows = False
        Me.Inv_aleatorioDataGridView.AllowUserToDeleteRows = False
        Me.Inv_aleatorioDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_aleatorioDataGridView.AutoGenerateColumns = False
        Me.Inv_aleatorioDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Inv_aleatorioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Inv_aleatorioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_fecha, Me.dgv_id, Me.descripcion, Me.dgv_existencia, Me.dgv_fisico, Me.DataGridViewCheckBoxColumn1})
        Me.Inv_aleatorioDataGridView.DataSource = Me.Inv_aleatorioBindingSource
        Me.Inv_aleatorioDataGridView.Location = New System.Drawing.Point(18, 71)
        Me.Inv_aleatorioDataGridView.Name = "Inv_aleatorioDataGridView"
        Me.Inv_aleatorioDataGridView.RowHeadersVisible = False
        Me.Inv_aleatorioDataGridView.Size = New System.Drawing.Size(1092, 246)
        Me.Inv_aleatorioDataGridView.TabIndex = 1
        '
        'dgv_fecha
        '
        Me.dgv_fecha.DataPropertyName = "fecha"
        Me.dgv_fecha.HeaderText = "fecha"
        Me.dgv_fecha.Name = "dgv_fecha"
        Me.dgv_fecha.ReadOnly = True
        '
        'dgv_id
        '
        Me.dgv_id.DataPropertyName = "id_producto"
        Me.dgv_id.HeaderText = "id_producto"
        Me.dgv_id.Name = "dgv_id"
        Me.dgv_id.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.descripcion.DataPropertyName = "id_producto"
        Me.descripcion.DataSource = Me.ProductosBindingSource
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle1
        Me.descripcion.DisplayMember = "Descripcion"
        Me.descripcion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.descripcion.ValueMember = "id_Producto"
        Me.descripcion.Width = 500
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.IntegraDataSet
        '
        'IntegraDataSet
        '
        Me.IntegraDataSet.DataSetName = "integraDataSet"
        Me.IntegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgv_existencia
        '
        Me.dgv_existencia.DataPropertyName = "exiatencia_libros"
        Me.dgv_existencia.HeaderText = "exiatencia_libros"
        Me.dgv_existencia.Name = "dgv_existencia"
        Me.dgv_existencia.ReadOnly = True
        '
        'dgv_fisico
        '
        Me.dgv_fisico.DataPropertyName = "fisico"
        Me.dgv_fisico.HeaderText = "fisico"
        Me.dgv_fisico.Name = "dgv_fisico"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "aplicado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "aplicado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'Inv_aleatorioBindingSource
        '
        Me.Inv_aleatorioBindingSource.DataMember = "inv_aleatorio"
        Me.Inv_aleatorioBindingSource.DataSource = Me.IntegraDataSet
        '
        'btn_genera
        '
        Me.btn_genera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_genera.Location = New System.Drawing.Point(18, 339)
        Me.btn_genera.Name = "btn_genera"
        Me.btn_genera.Size = New System.Drawing.Size(150, 23)
        Me.btn_genera.TabIndex = 1
        Me.btn_genera.Text = "Genera Inventario del dia"
        Me.btn_genera.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Sql_inv_aleatorio_fijoDataGridView)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.idtxt)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1128, 371)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Productos Fijos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Sql_inv_aleatorio_fijoDataGridView
        '
        Me.Sql_inv_aleatorio_fijoDataGridView.AllowUserToAddRows = False
        Me.Sql_inv_aleatorio_fijoDataGridView.AllowUserToDeleteRows = False
        Me.Sql_inv_aleatorio_fijoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sql_inv_aleatorio_fijoDataGridView.AutoGenerateColumns = False
        Me.Sql_inv_aleatorio_fijoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_inv_aleatorio_fijoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_inv_aleatorio_fijoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Sql_inv_aleatorio_fijoDataGridView.DataSource = Me.Sql_inv_aleatorio_fijoBindingSource
        Me.Sql_inv_aleatorio_fijoDataGridView.Location = New System.Drawing.Point(22, 55)
        Me.Sql_inv_aleatorio_fijoDataGridView.Name = "Sql_inv_aleatorio_fijoDataGridView"
        Me.Sql_inv_aleatorio_fijoDataGridView.RowHeadersVisible = False
        Me.Sql_inv_aleatorio_fijoDataGridView.Size = New System.Drawing.Size(868, 220)
        Me.Sql_inv_aleatorio_fijoDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Sql_inv_aleatorio_fijoBindingSource
        '
        Me.Sql_inv_aleatorio_fijoBindingSource.DataMember = "sql_inv_aleatorio_fijo"
        Me.Sql_inv_aleatorio_fijoBindingSource.DataSource = Me.IntegraDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Agrgar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Agregar un producto a la lista ID:"
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(175, 317)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(63, 20)
        Me.idtxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(17, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto que se Inventariar Permanentemente"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.items_adicion)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1128, 371)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Configurar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(506, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cuantos productos adicionales a los fisicos se inventarean :"
        '
        'items_adicion
        '
        Me.items_adicion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AdminTegral.My.MySettings.Default, "items_adicionales", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.items_adicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.items_adicion.Location = New System.Drawing.Point(539, 34)
        Me.items_adicion.Name = "items_adicion"
        Me.items_adicion.Size = New System.Drawing.Size(55, 29)
        Me.items_adicion.TabIndex = 0
        Me.items_adicion.Text = Global.AdminTegral.My.MySettings.Default.items_adicionales
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1128, 371)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Historial"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ProductosinvaleatorioBindingSource
        '
        Me.ProductosinvaleatorioBindingSource.DataMember = "productos_inv_aleatorio"
        Me.ProductosinvaleatorioBindingSource.DataSource = Me.Inv_aleatorioBindingSource
        '
        'ProductosinvaleatorioBindingSource1
        '
        Me.ProductosinvaleatorioBindingSource1.DataMember = "productos_inv_aleatorio"
        Me.ProductosinvaleatorioBindingSource1.DataSource = Me.Inv_aleatorioBindingSource
        '
        'Sql_inv_aleatorio_fijoTableAdapter
        '
        Me.Sql_inv_aleatorio_fijoTableAdapter.ClearBeforeFill = True
        '
        'Inv_aleatorioTableAdapter
        '
        Me.Inv_aleatorioTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblstatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1153, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblstatus
        '
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(12, 17)
        Me.lblstatus.Text = "-"
        '
        'Inventario_aleatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 453)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Inventario_aleatorio"
        Me.Text = "Inventario_aleatorio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Inv_aleatorioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_aleatorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Sql_inv_aleatorio_fijoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_inv_aleatorio_fijoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ProductosinvaleatorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosinvaleatorioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents items_adicion As System.Windows.Forms.TextBox
    Friend WithEvents IntegraDataSet As AdminTegral.integraDataSet
    Friend WithEvents btn_genera As System.Windows.Forms.Button
    Friend WithEvents Sql_inv_aleatorio_fijoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sql_inv_aleatorio_fijoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_inv_aleatorio_fijoTableAdapter As AdminTegral.integraDataSetTableAdapters.sql_inv_aleatorio_fijoTableAdapter
    Friend WithEvents Inv_aleatorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_aleatorioTableAdapter As AdminTegral.integraDataSetTableAdapters.inv_aleatorioTableAdapter
    Friend WithEvents Inv_aleatorioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As AdminTegral.integraDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosinvaleatorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ProductosinvaleatorioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fconteo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_fisico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblstatus As System.Windows.Forms.ToolStripStatusLabel
End Class
