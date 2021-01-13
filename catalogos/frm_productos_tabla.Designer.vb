<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productos_tabla
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
        Dim Cve_provedorLabel As System.Windows.Forms.Label
        Dim Id_DeptoLabel As System.Windows.Forms.Label
        Dim Id_GrupoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim Id_DirectorioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim MargenLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim ComisionableLabel As System.Windows.Forms.Label
        Dim ComisionLabel As System.Windows.Forms.Label
        Dim Fecha_altaLabel As System.Windows.Forms.Label
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Und_ventaLabel As System.Windows.Forms.Label
        Dim Und_compraLabel As System.Windows.Forms.Label
        Dim Und_detalleLabel As System.Windows.Forms.Label
        Dim CaducidadLabel As System.Windows.Forms.Label
        Dim Precio_unicoLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Unidades_productosDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unidades_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter
        Me.Unidades_productosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Me.Id_ProductoTextBox = New System.Windows.Forms.TextBox
        Me.Cve_provedorTextBox = New System.Windows.Forms.TextBox
        Me.Id_DeptoTextBox = New System.Windows.Forms.TextBox
        Me.Id_GrupoTextBox = New System.Windows.Forms.TextBox
        Me.MarcaTextBox = New System.Windows.Forms.TextBox
        Me.Id_DirectorioTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.PesoTextBox = New System.Windows.Forms.TextBox
        Me.MargenTextBox = New System.Windows.Forms.TextBox
        Me.IvaTextBox = New System.Windows.Forms.TextBox
        Me.ComisionableCheckBox = New System.Windows.Forms.CheckBox
        Me.ComisionTextBox = New System.Windows.Forms.TextBox
        Me.Fecha_altaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Id_usuarioTextBox = New System.Windows.Forms.TextBox
        Me.StatusTextBox = New System.Windows.Forms.TextBox
        Me.Und_ventaTextBox = New System.Windows.Forms.TextBox
        Me.Und_compraTextBox = New System.Windows.Forms.TextBox
        Me.Und_detalleTextBox = New System.Windows.Forms.TextBox
        Me.CaducidadCheckBox = New System.Windows.Forms.CheckBox
        Me.Precio_unicoCheckBox = New System.Windows.Forms.CheckBox
        Id_ProductoLabel = New System.Windows.Forms.Label
        Cve_provedorLabel = New System.Windows.Forms.Label
        Id_DeptoLabel = New System.Windows.Forms.Label
        Id_GrupoLabel = New System.Windows.Forms.Label
        MarcaLabel = New System.Windows.Forms.Label
        Id_DirectorioLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        PesoLabel = New System.Windows.Forms.Label
        MargenLabel = New System.Windows.Forms.Label
        IvaLabel = New System.Windows.Forms.Label
        ComisionableLabel = New System.Windows.Forms.Label
        ComisionLabel = New System.Windows.Forms.Label
        Fecha_altaLabel = New System.Windows.Forms.Label
        Id_usuarioLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        Und_ventaLabel = New System.Windows.Forms.Label
        Und_compraLabel = New System.Windows.Forms.Label
        Und_detalleLabel = New System.Windows.Forms.Label
        CaducidadLabel = New System.Windows.Forms.Label
        Precio_unicoLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Unidades_productosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Unidades_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(846, 497)
        Me.SplitContainer1.SplitterDistance = 43
        Me.SplitContainer1.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Id_ProductoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_ProductoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Cve_provedorLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Cve_provedorTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Id_DeptoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_DeptoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Id_GrupoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_GrupoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(MarcaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MarcaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Id_DirectorioLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_DirectorioTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(DescripcionLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DescripcionTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(PesoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PesoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(MargenLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MargenTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(IvaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.IvaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(ComisionableLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComisionableCheckBox)
        Me.SplitContainer2.Panel1.Controls.Add(ComisionLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComisionTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Fecha_altaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Fecha_altaDateTimePicker)
        Me.SplitContainer2.Panel1.Controls.Add(Id_usuarioLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_usuarioTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(StatusLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.StatusTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Und_ventaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Und_ventaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Und_compraLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Und_compraTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Und_detalleLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Und_detalleTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(CaducidadLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.CaducidadCheckBox)
        Me.SplitContainer2.Panel1.Controls.Add(Precio_unicoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Precio_unicoCheckBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.Unidades_productosDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(846, 450)
        Me.SplitContainer2.SplitterDistance = 315
        Me.SplitContainer2.TabIndex = 0
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
        'Unidades_productosDataGridView
        '
        Me.Unidades_productosDataGridView.AutoGenerateColumns = False
        Me.Unidades_productosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.Unidades_productosDataGridView.DataSource = Me.Unidades_productosBindingSource
        Me.Unidades_productosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Unidades_productosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Unidades_productosDataGridView.Name = "Unidades_productosDataGridView"
        Me.Unidades_productosDataGridView.Size = New System.Drawing.Size(846, 131)
        Me.Unidades_productosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn19.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "id_unidad"
        Me.DataGridViewTextBoxColumn20.HeaderText = "id_unidad"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Operador"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Operador"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "factor"
        Me.DataGridViewTextBoxColumn23.HeaderText = "factor"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "unidades"
        Me.DataGridViewTextBoxColumn24.HeaderText = "unidades"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn25.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "venta"
        Me.DataGridViewTextBoxColumn26.HeaderText = "venta"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'Unidades_productosBindingSource
        '
        Me.Unidades_productosBindingSource.DataMember = "productos_Unidades_productos"
        Me.Unidades_productosBindingSource.DataSource = Me.ProductosBindingSource
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Unidades_productosTableAdapter
        '
        Me.Unidades_productosTableAdapter.ClearBeforeFill = True
        '
        'Id_ProductoLabel
        '
        Id_ProductoLabel.AutoSize = True
        Id_ProductoLabel.Location = New System.Drawing.Point(23, 12)
        Id_ProductoLabel.Name = "Id_ProductoLabel"
        Id_ProductoLabel.Size = New System.Drawing.Size(67, 13)
        Id_ProductoLabel.TabIndex = 0
        Id_ProductoLabel.Text = "ID Producto:"
        '
        'Id_ProductoTextBox
        '
        Me.Id_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_Producto", True))
        Me.Id_ProductoTextBox.Location = New System.Drawing.Point(102, 9)
        Me.Id_ProductoTextBox.Name = "Id_ProductoTextBox"
        Me.Id_ProductoTextBox.Size = New System.Drawing.Size(88, 20)
        Me.Id_ProductoTextBox.TabIndex = 1
        '
        'Cve_provedorLabel
        '
        Cve_provedorLabel.AutoSize = True
        Cve_provedorLabel.Location = New System.Drawing.Point(14, 38)
        Cve_provedorLabel.Name = "Cve_provedorLabel"
        Cve_provedorLabel.Size = New System.Drawing.Size(73, 13)
        Cve_provedorLabel.TabIndex = 2
        Cve_provedorLabel.Text = "cve provedor:"
        '
        'Cve_provedorTextBox
        '
        Me.Cve_provedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "cve_provedor", True))
        Me.Cve_provedorTextBox.Location = New System.Drawing.Point(102, 35)
        Me.Cve_provedorTextBox.Name = "Cve_provedorTextBox"
        Me.Cve_provedorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cve_provedorTextBox.TabIndex = 3
        '
        'Id_DeptoLabel
        '
        Id_DeptoLabel.AutoSize = True
        Id_DeptoLabel.Location = New System.Drawing.Point(37, 64)
        Id_DeptoLabel.Name = "Id_DeptoLabel"
        Id_DeptoLabel.Size = New System.Drawing.Size(50, 13)
        Id_DeptoLabel.TabIndex = 4
        Id_DeptoLabel.Text = "id Depto:"
        '
        'Id_DeptoTextBox
        '
        Me.Id_DeptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_Depto", True))
        Me.Id_DeptoTextBox.Location = New System.Drawing.Point(102, 61)
        Me.Id_DeptoTextBox.Name = "Id_DeptoTextBox"
        Me.Id_DeptoTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Id_DeptoTextBox.TabIndex = 5
        '
        'Id_GrupoLabel
        '
        Id_GrupoLabel.AutoSize = True
        Id_GrupoLabel.Location = New System.Drawing.Point(37, 90)
        Id_GrupoLabel.Name = "Id_GrupoLabel"
        Id_GrupoLabel.Size = New System.Drawing.Size(50, 13)
        Id_GrupoLabel.TabIndex = 6
        Id_GrupoLabel.Text = "id Grupo:"
        '
        'Id_GrupoTextBox
        '
        Me.Id_GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_Grupo", True))
        Me.Id_GrupoTextBox.Location = New System.Drawing.Point(102, 87)
        Me.Id_GrupoTextBox.Name = "Id_GrupoTextBox"
        Me.Id_GrupoTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Id_GrupoTextBox.TabIndex = 7
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(47, 116)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 8
        MarcaLabel.Text = "Marca:"
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(102, 113)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MarcaTextBox.TabIndex = 9
        '
        'Id_DirectorioLabel
        '
        Id_DirectorioLabel.AutoSize = True
        Id_DirectorioLabel.Location = New System.Drawing.Point(35, 142)
        Id_DirectorioLabel.Name = "Id_DirectorioLabel"
        Id_DirectorioLabel.Size = New System.Drawing.Size(52, 13)
        Id_DirectorioLabel.TabIndex = 10
        Id_DirectorioLabel.Text = "ID_Prov.:"
        '
        'Id_DirectorioTextBox
        '
        Me.Id_DirectorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_Directorio", True))
        Me.Id_DirectorioTextBox.Location = New System.Drawing.Point(102, 139)
        Me.Id_DirectorioTextBox.Name = "Id_DirectorioTextBox"
        Me.Id_DirectorioTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Id_DirectorioTextBox.TabIndex = 11
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(21, 170)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 14
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(102, 167)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescripcionTextBox.TabIndex = 15
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(54, 196)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(33, 13)
        PesoLabel.TabIndex = 16
        PesoLabel.Text = "peso:"
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(102, 193)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PesoTextBox.TabIndex = 17
        '
        'MargenLabel
        '
        MargenLabel.AutoSize = True
        MargenLabel.Location = New System.Drawing.Point(42, 222)
        MargenLabel.Name = "MargenLabel"
        MargenLabel.Size = New System.Drawing.Size(45, 13)
        MargenLabel.TabIndex = 18
        MargenLabel.Text = "margen:"
        '
        'MargenTextBox
        '
        Me.MargenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "margen", True))
        Me.MargenTextBox.Location = New System.Drawing.Point(102, 219)
        Me.MargenTextBox.Name = "MargenTextBox"
        Me.MargenTextBox.Size = New System.Drawing.Size(41, 20)
        Me.MargenTextBox.TabIndex = 19
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(486, 24)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 20
        IvaLabel.Text = "iva:"
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(516, 21)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IvaTextBox.TabIndex = 21
        '
        'ComisionableLabel
        '
        ComisionableLabel.AutoSize = True
        ComisionableLabel.Location = New System.Drawing.Point(439, 52)
        ComisionableLabel.Name = "ComisionableLabel"
        ComisionableLabel.Size = New System.Drawing.Size(71, 13)
        ComisionableLabel.TabIndex = 22
        ComisionableLabel.Text = "comisionable:"
        '
        'ComisionableCheckBox
        '
        Me.ComisionableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "comisionable", True))
        Me.ComisionableCheckBox.Location = New System.Drawing.Point(516, 47)
        Me.ComisionableCheckBox.Name = "ComisionableCheckBox"
        Me.ComisionableCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.ComisionableCheckBox.TabIndex = 23
        '
        'ComisionLabel
        '
        ComisionLabel.AutoSize = True
        ComisionLabel.Location = New System.Drawing.Point(459, 80)
        ComisionLabel.Name = "ComisionLabel"
        ComisionLabel.Size = New System.Drawing.Size(51, 13)
        ComisionLabel.TabIndex = 24
        ComisionLabel.Text = "comision:"
        '
        'ComisionTextBox
        '
        Me.ComisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "comision", True))
        Me.ComisionTextBox.Location = New System.Drawing.Point(516, 77)
        Me.ComisionTextBox.Name = "ComisionTextBox"
        Me.ComisionTextBox.Size = New System.Drawing.Size(43, 20)
        Me.ComisionTextBox.TabIndex = 25
        '
        'Fecha_altaLabel
        '
        Fecha_altaLabel.AutoSize = True
        Fecha_altaLabel.Enabled = False
        Fecha_altaLabel.Location = New System.Drawing.Point(437, 226)
        Fecha_altaLabel.Name = "Fecha_altaLabel"
        Fecha_altaLabel.Size = New System.Drawing.Size(57, 13)
        Fecha_altaLabel.TabIndex = 26
        Fecha_altaLabel.Text = "fecha alta:"
        '
        'Fecha_altaDateTimePicker
        '
        Me.Fecha_altaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "fecha_alta", True))
        Me.Fecha_altaDateTimePicker.Enabled = False
        Me.Fecha_altaDateTimePicker.Location = New System.Drawing.Point(516, 222)
        Me.Fecha_altaDateTimePicker.Name = "Fecha_altaDateTimePicker"
        Me.Fecha_altaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_altaDateTimePicker.TabIndex = 27
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Enabled = False
        Id_usuarioLabel.Location = New System.Drawing.Point(437, 251)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(55, 13)
        Id_usuarioLabel.TabIndex = 28
        Id_usuarioLabel.Text = "id usuario:"
        '
        'Id_usuarioTextBox
        '
        Me.Id_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_usuario", True))
        Me.Id_usuarioTextBox.Enabled = False
        Me.Id_usuarioTextBox.Location = New System.Drawing.Point(516, 248)
        Me.Id_usuarioTextBox.Name = "Id_usuarioTextBox"
        Me.Id_usuarioTextBox.Size = New System.Drawing.Size(43, 20)
        Me.Id_usuarioTextBox.TabIndex = 29
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(152, 291)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(38, 13)
        StatusLabel.TabIndex = 30
        StatusLabel.Text = "status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "status", True))
        Me.StatusTextBox.Enabled = False
        Me.StatusTextBox.Location = New System.Drawing.Point(516, 274)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(43, 20)
        Me.StatusTextBox.TabIndex = 31
        '
        'Und_ventaLabel
        '
        Und_ventaLabel.AutoSize = True
        Und_ventaLabel.Location = New System.Drawing.Point(452, 106)
        Und_ventaLabel.Name = "Und_ventaLabel"
        Und_ventaLabel.Size = New System.Drawing.Size(58, 13)
        Und_ventaLabel.TabIndex = 32
        Und_ventaLabel.Text = "und venta:"
        '
        'Und_ventaTextBox
        '
        Me.Und_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "und_venta", True))
        Me.Und_ventaTextBox.Location = New System.Drawing.Point(516, 103)
        Me.Und_ventaTextBox.Name = "Und_ventaTextBox"
        Me.Und_ventaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Und_ventaTextBox.TabIndex = 33
        '
        'Und_compraLabel
        '
        Und_compraLabel.AutoSize = True
        Und_compraLabel.Location = New System.Drawing.Point(444, 132)
        Und_compraLabel.Name = "Und_compraLabel"
        Und_compraLabel.Size = New System.Drawing.Size(66, 13)
        Und_compraLabel.TabIndex = 34
        Und_compraLabel.Text = "und compra:"
        '
        'Und_compraTextBox
        '
        Me.Und_compraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "und_compra", True))
        Me.Und_compraTextBox.Location = New System.Drawing.Point(516, 129)
        Me.Und_compraTextBox.Name = "Und_compraTextBox"
        Me.Und_compraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Und_compraTextBox.TabIndex = 35
        '
        'Und_detalleLabel
        '
        Und_detalleLabel.AutoSize = True
        Und_detalleLabel.Location = New System.Drawing.Point(448, 158)
        Und_detalleLabel.Name = "Und_detalleLabel"
        Und_detalleLabel.Size = New System.Drawing.Size(62, 13)
        Und_detalleLabel.TabIndex = 36
        Und_detalleLabel.Text = "und detalle:"
        '
        'Und_detalleTextBox
        '
        Me.Und_detalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "und_detalle", True))
        Me.Und_detalleTextBox.Location = New System.Drawing.Point(516, 155)
        Me.Und_detalleTextBox.Name = "Und_detalleTextBox"
        Me.Und_detalleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Und_detalleTextBox.TabIndex = 37
        '
        'CaducidadLabel
        '
        CaducidadLabel.AutoSize = True
        CaducidadLabel.Location = New System.Drawing.Point(450, 186)
        CaducidadLabel.Name = "CaducidadLabel"
        CaducidadLabel.Size = New System.Drawing.Size(61, 13)
        CaducidadLabel.TabIndex = 38
        CaducidadLabel.Text = "Caducidad:"
        '
        'CaducidadCheckBox
        '
        Me.CaducidadCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "caducidad", True))
        Me.CaducidadCheckBox.Location = New System.Drawing.Point(516, 181)
        Me.CaducidadCheckBox.Name = "CaducidadCheckBox"
        Me.CaducidadCheckBox.Size = New System.Drawing.Size(25, 24)
        Me.CaducidadCheckBox.TabIndex = 39
        '
        'Precio_unicoLabel
        '
        Precio_unicoLabel.AutoSize = True
        Precio_unicoLabel.Location = New System.Drawing.Point(555, 184)
        Precio_unicoLabel.Name = "Precio_unicoLabel"
        Precio_unicoLabel.Size = New System.Drawing.Size(71, 13)
        Precio_unicoLabel.TabIndex = 40
        Precio_unicoLabel.Text = "Precio Unico:"
        '
        'Precio_unicoCheckBox
        '
        Me.Precio_unicoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "precio_unico", True))
        Me.Precio_unicoCheckBox.Location = New System.Drawing.Point(629, 181)
        Me.Precio_unicoCheckBox.Name = "Precio_unicoCheckBox"
        Me.Precio_unicoCheckBox.Size = New System.Drawing.Size(29, 24)
        Me.Precio_unicoCheckBox.TabIndex = 41
        '
        'frm_productos_tabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 497)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_productos_tabla"
        Me.Text = "Mantenimiento a Productos"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Unidades_productosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Unidades_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter
    Friend WithEvents Unidades_productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Unidades_productosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.Unidades_productosTableAdapter
    Friend WithEvents Unidades_productosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cve_provedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_DeptoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_GrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_DirectorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MargenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComisionableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ComisionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_altaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_usuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Und_ventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Und_compraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Und_detalleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaducidadCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Precio_unicoCheckBox As System.Windows.Forms.CheckBox
End Class
