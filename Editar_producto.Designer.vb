<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_producto
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
        Dim Id_ProductoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim MargenLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Id_ProductoTextBox = New System.Windows.Forms.TextBox
        Me.MarcaTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.PesoTextBox = New System.Windows.Forms.TextBox
        Me.MargenTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Unidades_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.boton_salir = New System.Windows.Forms.Button
        Me.boton_guardar = New System.Windows.Forms.Button
        Me.Id_DirectorioTextBox = New System.Windows.Forms.TextBox
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvventa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter
        Me.Unidades_productosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Me.proveedor = New System.Windows.Forms.TextBox
        Id_ProductoLabel = New System.Windows.Forms.Label
        MarcaLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        PesoLabel = New System.Windows.Forms.Label
        MargenLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Unidades_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ProductoLabel
        '
        Id_ProductoLabel.AutoSize = True
        Id_ProductoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_ProductoLabel.Location = New System.Drawing.Point(99, 19)
        Id_ProductoLabel.Name = "Id_ProductoLabel"
        Id_ProductoLabel.Size = New System.Drawing.Size(30, 18)
        Id_ProductoLabel.TabIndex = 1
        Id_ProductoLabel.Text = "ID :"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(75, 78)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(54, 18)
        MarcaLabel.TabIndex = 2
        MarcaLabel.Text = "Marca:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(38, 105)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(91, 18)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PesoLabel.Location = New System.Drawing.Point(222, 138)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(45, 18)
        PesoLabel.TabIndex = 6
        PesoLabel.Text = "peso:"
        '
        'MargenLabel
        '
        MargenLabel.AutoSize = True
        MargenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MargenLabel.Location = New System.Drawing.Point(67, 135)
        MargenLabel.Name = "MargenLabel"
        MargenLabel.Size = New System.Drawing.Size(62, 18)
        MargenLabel.TabIndex = 8
        MargenLabel.Text = "margen:"
        '
        'Id_ProductoTextBox
        '
        Me.Id_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_Producto", True))
        Me.Id_ProductoTextBox.Enabled = False
        Me.Id_ProductoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_ProductoTextBox.Location = New System.Drawing.Point(136, 22)
        Me.Id_ProductoTextBox.Name = "Id_ProductoTextBox"
        Me.Id_ProductoTextBox.Size = New System.Drawing.Size(61, 24)
        Me.Id_ProductoTextBox.TabIndex = 2
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Marca", True))
        Me.MarcaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaTextBox.Location = New System.Drawing.Point(136, 78)
        Me.MarcaTextBox.MaxLength = 15
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(131, 24)
        Me.MarcaTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(136, 108)
        Me.DescripcionTextBox.MaxLength = 65
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(395, 24)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "peso", True))
        Me.PesoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PesoTextBox.Location = New System.Drawing.Point(273, 135)
        Me.PesoTextBox.MaxLength = 5
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(61, 24)
        Me.PesoTextBox.TabIndex = 7
        '
        'MargenTextBox
        '
        Me.MargenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "margen", True))
        Me.MargenTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MargenTextBox.Location = New System.Drawing.Point(136, 135)
        Me.MargenTextBox.MaxLength = 5
        Me.MargenTextBox.Name = "MargenTextBox"
        Me.MargenTextBox.Size = New System.Drawing.Size(61, 24)
        Me.MargenTextBox.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 177)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Presentaciones"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.dgvcosto, Me.dgvventa})
        Me.dgv.DataSource = Me.Unidades_productosBindingSource
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 20)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(598, 154)
        Me.dgv.TabIndex = 0
        '
        'Unidades_productosBindingSource
        '
        Me.Unidades_productosBindingSource.DataMember = "productos_Unidades_productos"
        Me.Unidades_productosBindingSource.DataSource = Me.ProductosBindingSource
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(449, 345)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 11
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'boton_guardar
        '
        Me.boton_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_guardar.Location = New System.Drawing.Point(538, 345)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(75, 23)
        Me.boton_guardar.TabIndex = 12
        Me.boton_guardar.Text = "Guardar"
        Me.boton_guardar.UseVisualStyleBackColor = True
        '
        'Id_DirectorioTextBox
        '
        Me.Id_DirectorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_Directorio", True))
        Me.Id_DirectorioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_DirectorioTextBox.Location = New System.Drawing.Point(136, 49)
        Me.Id_DirectorioTextBox.Name = "Id_DirectorioTextBox"
        Me.Id_DirectorioTextBox.Size = New System.Drawing.Size(39, 24)
        Me.Id_DirectorioTextBox.TabIndex = 14
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(6, 49)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(123, 18)
        Label1.TabIndex = 15
        Label1.Text = "ID de Proveedor :"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_unidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 2
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 44
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 78
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Operador"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Operador"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 57
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "factor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "factor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 59
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "unidades"
        Me.DataGridViewTextBoxColumn6.HeaderText = "unidades"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 92
        '
        'dgvcosto
        '
        Me.dgvcosto.DataPropertyName = "costo"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgvcosto.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcosto.HeaderText = "costo"
        Me.dgvcosto.MaxInputLength = 10
        Me.dgvcosto.Name = "dgvcosto"
        Me.dgvcosto.Width = 71
        '
        'dgvventa
        '
        Me.dgvventa.DataPropertyName = "venta"
        DataGridViewCellStyle2.Format = "N2"
        Me.dgvventa.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvventa.HeaderText = "venta"
        Me.dgvventa.MaxInputLength = 10
        Me.dgvventa.Name = "dgvventa"
        Me.dgvventa.Width = 68
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Unidades_productosTableAdapter
        '
        Me.Unidades_productosTableAdapter.ClearBeforeFill = True
        '
        'proveedor
        '
        Me.proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proveedor.Location = New System.Drawing.Point(181, 47)
        Me.proveedor.Name = "proveedor"
        Me.proveedor.ReadOnly = True
        Me.proveedor.Size = New System.Drawing.Size(350, 24)
        Me.proveedor.TabIndex = 16
        '
        'Editar_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(629, 393)
        Me.Controls.Add(Me.proveedor)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Id_DirectorioTextBox)
        Me.Controls.Add(Me.boton_guardar)
        Me.Controls.Add(Me.boton_salir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(MargenLabel)
        Me.Controls.Add(Me.MargenTextBox)
        Me.Controls.Add(PesoLabel)
        Me.Controls.Add(Me.PesoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(Id_ProductoLabel)
        Me.Controls.Add(Me.Id_ProductoTextBox)
        Me.Name = "Editar_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar_producto"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Unidades_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter
    Friend WithEvents Id_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MargenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Unidades_productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Unidades_productosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.Unidades_productosTableAdapter
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents boton_guardar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_DirectorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents proveedor As System.Windows.Forms.TextBox
End Class
