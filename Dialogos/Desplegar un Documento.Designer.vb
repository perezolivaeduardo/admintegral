<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_una_factura
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
        Dim FolioLabel As System.Windows.Forms.Label
        Dim SerieLabel As System.Windows.Forms.Label
        Dim Id_almacenLabel As System.Windows.Forms.Label
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim Id_directorioLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Folio_pedidoLabel As System.Windows.Forms.Label
        Dim FacturaLabel As System.Windows.Forms.Label
        Dim FechafacturaLabel As System.Windows.Forms.Label
        Dim FechasurtidoLabel As System.Windows.Forms.Label
        Dim VenceLabel As System.Windows.Forms.Label
        Dim Sub0Label As System.Windows.Forms.Label
        Dim Descuento0Label As System.Windows.Forms.Label
        Dim Iva15Label As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim Label4 As System.Windows.Forms.Label
        Me.Sql_documento_impresionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ImporteTextBox = New System.Windows.Forms.TextBox
        Me.Sql_documentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Iva15TextBox = New System.Windows.Forms.TextBox
        Me.Iva10TextBox = New System.Windows.Forms.TextBox
        Me.Descunto15TextBox = New System.Windows.Forms.TextBox
        Me.Descunto10TextBox = New System.Windows.Forms.TextBox
        Me.Descuento0TextBox = New System.Windows.Forms.TextBox
        Me.Sub15TextBox = New System.Windows.Forms.TextBox
        Me.Sub10TextBox = New System.Windows.Forms.TextBox
        Me.Sub0TextBox = New System.Windows.Forms.TextBox
        Me.VenceDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FechasurtidoTextBox = New System.Windows.Forms.TextBox
        Me.FechafacturaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FacturaTextBox = New System.Windows.Forms.TextBox
        Me.Folio_pedidoTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox
        Me.AlmacenTextBox = New System.Windows.Forms.TextBox
        Me.Id_almacenTextBox = New System.Windows.Forms.TextBox
        Me.SerieTextBox = New System.Windows.Forms.TextBox
        Me.FolioTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.boton_salir = New System.Windows.Forms.Button
        Me.Sql_documento_impresionDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgvpagos = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Sql_documentosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentosTableAdapter
        Me.Sql_documento_impresionTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documento_impresionTableAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        FolioLabel = New System.Windows.Forms.Label
        SerieLabel = New System.Windows.Forms.Label
        Id_almacenLabel = New System.Windows.Forms.Label
        AlmacenLabel = New System.Windows.Forms.Label
        Id_directorioLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        Folio_pedidoLabel = New System.Windows.Forms.Label
        FacturaLabel = New System.Windows.Forms.Label
        FechafacturaLabel = New System.Windows.Forms.Label
        FechasurtidoLabel = New System.Windows.Forms.Label
        VenceLabel = New System.Windows.Forms.Label
        Sub0Label = New System.Windows.Forms.Label
        Descuento0Label = New System.Windows.Forms.Label
        Iva15Label = New System.Windows.Forms.Label
        ImporteLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        CType(Me.Sql_documento_impresionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Sql_documentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Sql_documento_impresionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Location = New System.Drawing.Point(13, 15)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(32, 13)
        FolioLabel.TabIndex = 0
        FolioLabel.Text = "Folio:"
        '
        'SerieLabel
        '
        SerieLabel.AutoSize = True
        SerieLabel.Location = New System.Drawing.Point(131, 15)
        SerieLabel.Name = "SerieLabel"
        SerieLabel.Size = New System.Drawing.Size(32, 13)
        SerieLabel.TabIndex = 2
        SerieLabel.Text = "serie:"
        '
        'Id_almacenLabel
        '
        Id_almacenLabel.AutoSize = True
        Id_almacenLabel.Location = New System.Drawing.Point(206, 15)
        Id_almacenLabel.Name = "Id_almacenLabel"
        Id_almacenLabel.Size = New System.Drawing.Size(61, 13)
        Id_almacenLabel.TabIndex = 4
        Id_almacenLabel.Text = "id almacen:"
        '
        'AlmacenLabel
        '
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Location = New System.Drawing.Point(313, 15)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(51, 13)
        AlmacenLabel.TabIndex = 6
        AlmacenLabel.Text = "Almacen:"
        '
        'Id_directorioLabel
        '
        Id_directorioLabel.AutoSize = True
        Id_directorioLabel.Location = New System.Drawing.Point(9, 41)
        Id_directorioLabel.Name = "Id_directorioLabel"
        Id_directorioLabel.Size = New System.Drawing.Size(22, 13)
        Id_directorioLabel.TabIndex = 8
        Id_directorioLabel.Text = "Id :"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(127, 40)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 10
        NombreLabel.Text = "Nombre:"
        '
        'Folio_pedidoLabel
        '
        Folio_pedidoLabel.AutoSize = True
        Folio_pedidoLabel.Location = New System.Drawing.Point(9, 67)
        Folio_pedidoLabel.Name = "Folio_pedidoLabel"
        Folio_pedidoLabel.Size = New System.Drawing.Size(64, 13)
        Folio_pedidoLabel.TabIndex = 12
        Folio_pedidoLabel.Text = "folio pedido:"
        '
        'FacturaLabel
        '
        FacturaLabel.AutoSize = True
        FacturaLabel.Location = New System.Drawing.Point(180, 67)
        FacturaLabel.Name = "FacturaLabel"
        FacturaLabel.Size = New System.Drawing.Size(43, 13)
        FacturaLabel.TabIndex = 14
        FacturaLabel.Text = "factura:"
        '
        'FechafacturaLabel
        '
        FechafacturaLabel.AutoSize = True
        FechafacturaLabel.Location = New System.Drawing.Point(312, 68)
        FechafacturaLabel.Name = "FechafacturaLabel"
        FechafacturaLabel.Size = New System.Drawing.Size(55, 13)
        FechafacturaLabel.TabIndex = 16
        FechafacturaLabel.Text = "F.Factura:"
        '
        'FechasurtidoLabel
        '
        FechasurtidoLabel.AutoSize = True
        FechasurtidoLabel.Location = New System.Drawing.Point(5, 93)
        FechasurtidoLabel.Name = "FechasurtidoLabel"
        FechasurtidoLabel.Size = New System.Drawing.Size(68, 13)
        FechasurtidoLabel.TabIndex = 18
        FechasurtidoLabel.Text = "fechasurtido:"
        '
        'VenceLabel
        '
        VenceLabel.AutoSize = True
        VenceLabel.Location = New System.Drawing.Point(185, 91)
        VenceLabel.Name = "VenceLabel"
        VenceLabel.Size = New System.Drawing.Size(40, 13)
        VenceLabel.TabIndex = 20
        VenceLabel.Text = "vence:"
        '
        'Sub0Label
        '
        Sub0Label.AutoSize = True
        Sub0Label.Location = New System.Drawing.Point(628, 7)
        Sub0Label.Name = "Sub0Label"
        Sub0Label.Size = New System.Drawing.Size(40, 13)
        Sub0Label.TabIndex = 22
        Sub0Label.Text = "Exento"
        '
        'Descuento0Label
        '
        Descuento0Label.AutoSize = True
        Descuento0Label.Location = New System.Drawing.Point(725, 8)
        Descuento0Label.Name = "Descuento0Label"
        Descuento0Label.Size = New System.Drawing.Size(27, 13)
        Descuento0Label.TabIndex = 26
        Descuento0Label.Text = ""
        '
        'Iva15Label
        '
        Iva15Label.AutoSize = True
        Iva15Label.Location = New System.Drawing.Point(818, 7)
        Iva15Label.Name = "Iva15Label"
        Iva15Label.Size = New System.Drawing.Size(27, 13)
        Iva15Label.TabIndex = 31
        Iva15Label.Text = Trim(My.Settings.iva2.ToString) + "%"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(742, 100)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(45, 13)
        ImporteLabel.TabIndex = 33
        ImporteLabel.Text = "Importe:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(547, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 13)
        Label1.TabIndex = 35
        Label1.Text = "Subtotal:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(531, 48)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(65, 13)
        Label2.TabIndex = 36
        Label2.Text = "Descuento :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(655, 73)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(42, 13)
        Label3.TabIndex = 37
        Label3.Text = "I.V.A. : "
        '
        'Sql_documento_impresionBindingSource
        '
        Me.Sql_documento_impresionBindingSource.DataMember = "sql_documento_impresion"
        Me.Sql_documento_impresionBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Label1)
        Me.SplitContainer1.Panel1.Controls.Add(ImporteLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ImporteTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Iva15Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Iva15TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Iva10TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Descunto15TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Descunto10TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Descuento0Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Descuento0TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Sub15TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Sub10TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Sub0Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Sub0TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(VenceLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VenceDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(FechasurtidoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FechasurtidoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(FechafacturaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FechafacturaDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(FacturaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FacturaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Folio_pedidoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Folio_pedidoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Id_directorioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_directorioTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(AlmacenLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AlmacenTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Id_almacenLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_almacenTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(SerieLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SerieTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(FolioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FolioTextBox)
        Me.SplitContainer1.Panel1.Enabled = False
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(905, 470)
        Me.SplitContainer1.SplitterDistance = 123
        Me.SplitContainer1.TabIndex = 0
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.BackColor = System.Drawing.Color.White
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "Importe", True))
        Me.ImporteTextBox.Location = New System.Drawing.Point(793, 93)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.ReadOnly = True
        Me.ImporteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImporteTextBox.TabIndex = 34
        '
        'Sql_documentosBindingSource
        '
        Me.Sql_documentosBindingSource.DataMember = "sql_documentos"
        Me.Sql_documentosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Iva15TextBox
        '
        Me.Iva15TextBox.BackColor = System.Drawing.Color.White
        Me.Iva15TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "iva15", True))
        Me.Iva15TextBox.Location = New System.Drawing.Point(793, 69)
        Me.Iva15TextBox.Name = "Iva15TextBox"
        Me.Iva15TextBox.ReadOnly = True
        Me.Iva15TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Iva15TextBox.TabIndex = 32
        '
        'Iva10TextBox
        '
        Me.Iva10TextBox.BackColor = System.Drawing.Color.White
        Me.Iva10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "iva10", True))
        Me.Iva10TextBox.Location = New System.Drawing.Point(704, 69)
        Me.Iva10TextBox.Name = "Iva10TextBox"
        Me.Iva10TextBox.ReadOnly = True
        Me.Iva10TextBox.Size = New System.Drawing.Size(83, 20)
        Me.Iva10TextBox.TabIndex = 31
        '
        'Descunto15TextBox
        '
        Me.Descunto15TextBox.BackColor = System.Drawing.Color.White
        Me.Descunto15TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "descunto15", True))
        Me.Descunto15TextBox.Location = New System.Drawing.Point(793, 46)
        Me.Descunto15TextBox.Name = "Descunto15TextBox"
        Me.Descunto15TextBox.ReadOnly = True
        Me.Descunto15TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Descunto15TextBox.TabIndex = 30
        '
        'Descunto10TextBox
        '
        Me.Descunto10TextBox.BackColor = System.Drawing.Color.White
        Me.Descunto10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "descunto10", True))
        Me.Descunto10TextBox.Location = New System.Drawing.Point(704, 46)
        Me.Descunto10TextBox.Name = "Descunto10TextBox"
        Me.Descunto10TextBox.ReadOnly = True
        Me.Descunto10TextBox.Size = New System.Drawing.Size(83, 20)
        Me.Descunto10TextBox.TabIndex = 29
        '
        'Descuento0TextBox
        '
        Me.Descuento0TextBox.BackColor = System.Drawing.Color.White
        Me.Descuento0TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "descuento0", True))
        Me.Descuento0TextBox.Location = New System.Drawing.Point(597, 45)
        Me.Descuento0TextBox.Name = "Descuento0TextBox"
        Me.Descuento0TextBox.ReadOnly = True
        Me.Descuento0TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Descuento0TextBox.TabIndex = 27
        '
        'Sub15TextBox
        '
        Me.Sub15TextBox.BackColor = System.Drawing.Color.White
        Me.Sub15TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "sub15", True))
        Me.Sub15TextBox.Location = New System.Drawing.Point(793, 23)
        Me.Sub15TextBox.Name = "Sub15TextBox"
        Me.Sub15TextBox.ReadOnly = True
        Me.Sub15TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sub15TextBox.TabIndex = 26
        '
        'Sub10TextBox
        '
        Me.Sub10TextBox.BackColor = System.Drawing.Color.White
        Me.Sub10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "sub10", True))
        Me.Sub10TextBox.Location = New System.Drawing.Point(704, 23)
        Me.Sub10TextBox.Name = "Sub10TextBox"
        Me.Sub10TextBox.ReadOnly = True
        Me.Sub10TextBox.Size = New System.Drawing.Size(83, 20)
        Me.Sub10TextBox.TabIndex = 25
        '
        'Sub0TextBox
        '
        Me.Sub0TextBox.BackColor = System.Drawing.Color.White
        Me.Sub0TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "sub0", True))
        Me.Sub0TextBox.Location = New System.Drawing.Point(597, 23)
        Me.Sub0TextBox.Name = "Sub0TextBox"
        Me.Sub0TextBox.ReadOnly = True
        Me.Sub0TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sub0TextBox.TabIndex = 23
        '
        'VenceDateTimePicker
        '
        Me.VenceDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sql_documentosBindingSource, "vence", True))
        Me.VenceDateTimePicker.Enabled = False
        Me.VenceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VenceDateTimePicker.Location = New System.Drawing.Point(231, 87)
        Me.VenceDateTimePicker.Name = "VenceDateTimePicker"
        Me.VenceDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.VenceDateTimePicker.TabIndex = 21
        '
        'FechasurtidoTextBox
        '
        Me.FechasurtidoTextBox.BackColor = System.Drawing.Color.White
        Me.FechasurtidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "fechasurtido", True))
        Me.FechasurtidoTextBox.Location = New System.Drawing.Point(76, 90)
        Me.FechasurtidoTextBox.Name = "FechasurtidoTextBox"
        Me.FechasurtidoTextBox.ReadOnly = True
        Me.FechasurtidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FechasurtidoTextBox.TabIndex = 19
        '
        'FechafacturaDateTimePicker
        '
        Me.FechafacturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sql_documentosBindingSource, "fechafactura", True))
        Me.FechafacturaDateTimePicker.Enabled = False
        Me.FechafacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechafacturaDateTimePicker.Location = New System.Drawing.Point(372, 64)
        Me.FechafacturaDateTimePicker.Name = "FechafacturaDateTimePicker"
        Me.FechafacturaDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.FechafacturaDateTimePicker.TabIndex = 17
        '
        'FacturaTextBox
        '
        Me.FacturaTextBox.BackColor = System.Drawing.Color.White
        Me.FacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "factura", True))
        Me.FacturaTextBox.Location = New System.Drawing.Point(229, 64)
        Me.FacturaTextBox.Name = "FacturaTextBox"
        Me.FacturaTextBox.ReadOnly = True
        Me.FacturaTextBox.Size = New System.Drawing.Size(78, 20)
        Me.FacturaTextBox.TabIndex = 15
        '
        'Folio_pedidoTextBox
        '
        Me.Folio_pedidoTextBox.BackColor = System.Drawing.Color.White
        Me.Folio_pedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "folio_pedido", True))
        Me.Folio_pedidoTextBox.Location = New System.Drawing.Point(76, 64)
        Me.Folio_pedidoTextBox.Name = "Folio_pedidoTextBox"
        Me.Folio_pedidoTextBox.ReadOnly = True
        Me.Folio_pedidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Folio_pedidoTextBox.TabIndex = 13
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BackColor = System.Drawing.Color.White
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(169, 38)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(301, 20)
        Me.NombreTextBox.TabIndex = 11
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.BackColor = System.Drawing.Color.White
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "id_directorio", True))
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(34, 38)
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.ReadOnly = True
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(64, 20)
        Me.Id_directorioTextBox.TabIndex = 9
        '
        'AlmacenTextBox
        '
        Me.AlmacenTextBox.BackColor = System.Drawing.Color.White
        Me.AlmacenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "Almacen", True))
        Me.AlmacenTextBox.Location = New System.Drawing.Point(370, 12)
        Me.AlmacenTextBox.Name = "AlmacenTextBox"
        Me.AlmacenTextBox.ReadOnly = True
        Me.AlmacenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlmacenTextBox.TabIndex = 7
        '
        'Id_almacenTextBox
        '
        Me.Id_almacenTextBox.BackColor = System.Drawing.Color.White
        Me.Id_almacenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "id_almacen", True))
        Me.Id_almacenTextBox.Location = New System.Drawing.Point(273, 12)
        Me.Id_almacenTextBox.Name = "Id_almacenTextBox"
        Me.Id_almacenTextBox.ReadOnly = True
        Me.Id_almacenTextBox.Size = New System.Drawing.Size(34, 20)
        Me.Id_almacenTextBox.TabIndex = 5
        '
        'SerieTextBox
        '
        Me.SerieTextBox.BackColor = System.Drawing.Color.White
        Me.SerieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "serie", True))
        Me.SerieTextBox.Location = New System.Drawing.Point(169, 12)
        Me.SerieTextBox.Name = "SerieTextBox"
        Me.SerieTextBox.ReadOnly = True
        Me.SerieTextBox.Size = New System.Drawing.Size(24, 20)
        Me.SerieTextBox.TabIndex = 3
        '
        'FolioTextBox
        '
        Me.FolioTextBox.BackColor = System.Drawing.Color.White
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "Folio", True))
        Me.FolioTextBox.Location = New System.Drawing.Point(51, 12)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.ReadOnly = True
        Me.FolioTextBox.Size = New System.Drawing.Size(74, 20)
        Me.FolioTextBox.TabIndex = 1
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
        Me.TabControl1.Size = New System.Drawing.Size(905, 343)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.boton_salir)
        Me.TabPage1.Controls.Add(Me.Sql_documento_impresionDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(897, 317)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Documento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(790, 291)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(99, 23)
        Me.boton_salir.TabIndex = 0
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'Sql_documento_impresionDataGridView
        '
        Me.Sql_documento_impresionDataGridView.AllowUserToAddRows = False
        Me.Sql_documento_impresionDataGridView.AllowUserToDeleteRows = False
        Me.Sql_documento_impresionDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sql_documento_impresionDataGridView.AutoGenerateColumns = False
        Me.Sql_documento_impresionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_documento_impresionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn52, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58})
        Me.Sql_documento_impresionDataGridView.DataSource = Me.Sql_documento_impresionBindingSource
        Me.Sql_documento_impresionDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Sql_documento_impresionDataGridView.Name = "Sql_documento_impresionDataGridView"
        Me.Sql_documento_impresionDataGridView.ReadOnly = True
        Me.Sql_documento_impresionDataGridView.RowHeadersVisible = False
        Me.Sql_documento_impresionDataGridView.Size = New System.Drawing.Size(891, 282)
        Me.Sql_documento_impresionDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "td"
        Me.DataGridViewTextBoxColumn9.HeaderText = "td"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 41
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 54
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "serie"
        Me.DataGridViewTextBoxColumn11.HeaderText = "serie"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 54
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "id_prodcuto"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Width = 41
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Width = 88
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "factor"
        Me.DataGridViewTextBoxColumn36.HeaderText = "factor"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Width = 59
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "ud"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ud"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Width = 44
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Width = 66
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn40.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Width = 73
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "costo"
        DataGridViewCellStyle17.Format = "N2"
        Me.DataGridViewTextBoxColumn41.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn41.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Visible = False
        Me.DataGridViewTextBoxColumn41.Width = 58
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "cos_desc"
        DataGridViewCellStyle18.Format = "N2"
        Me.DataGridViewTextBoxColumn42.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn42.HeaderText = "cos_desc"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Visible = False
        Me.DataGridViewTextBoxColumn42.Width = 78
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "cos_flete"
        DataGridViewCellStyle19.Format = "N2"
        Me.DataGridViewTextBoxColumn43.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn43.HeaderText = "cos_flete"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Visible = False
        Me.DataGridViewTextBoxColumn43.Width = 75
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "cos_iva10"
        DataGridViewCellStyle20.Format = "N2"
        Me.DataGridViewTextBoxColumn44.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn44.HeaderText = "cos_iva10"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Visible = False
        Me.DataGridViewTextBoxColumn44.Width = 81
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "cos_iva15"
        DataGridViewCellStyle21.Format = "N2"
        Me.DataGridViewTextBoxColumn45.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn45.HeaderText = "cos_iva15"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Visible = False
        Me.DataGridViewTextBoxColumn45.Width = 81
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "venta"
        DataGridViewCellStyle22.Format = "N2"
        Me.DataGridViewTextBoxColumn46.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn46.HeaderText = "venta"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Width = 59
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Vta_desc"
        DataGridViewCellStyle23.Format = "N2"
        Me.DataGridViewTextBoxColumn47.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn47.HeaderText = "Vta_desc"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Visible = False
        Me.DataGridViewTextBoxColumn47.Width = 77
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "Vta_iva10"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Vta_iva10"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Visible = False
        Me.DataGridViewTextBoxColumn48.Width = 80
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "Vta_iva15"
        DataGridViewCellStyle24.Format = "N2"
        Me.DataGridViewTextBoxColumn49.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn49.HeaderText = "Vta_iva15"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Visible = False
        Me.DataGridViewTextBoxColumn49.Width = 80
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "n"
        Me.DataGridViewTextBoxColumn50.HeaderText = "n"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        Me.DataGridViewTextBoxColumn50.Visible = False
        Me.DataGridViewTextBoxColumn50.Width = 38
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "peso"
        Me.DataGridViewTextBoxColumn52.HeaderText = "peso"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Visible = False
        Me.DataGridViewTextBoxColumn52.Width = 55
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "caducidad"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "caducidad"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 63
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "precio_unico"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "precio_unico"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 74
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "nick"
        Me.DataGridViewTextBoxColumn53.HeaderText = "nick"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Width = 52
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        Me.DataGridViewTextBoxColumn54.Width = 68
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "Tdoc"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Tdoc"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Visible = False
        Me.DataGridViewTextBoxColumn55.Width = 57
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "puerta"
        Me.DataGridViewTextBoxColumn56.HeaderText = "puerta"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Width = 62
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "quien"
        Me.DataGridViewTextBoxColumn57.HeaderText = "quien"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Width = 58
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Comentarios"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Comentarios"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Width = 90
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvpagos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(897, 317)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pagos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvpagos
        '
        Me.dgvpagos.AllowUserToAddRows = False
        Me.dgvpagos.AllowUserToDeleteRows = False
        Me.dgvpagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvpagos.Location = New System.Drawing.Point(3, 3)
        Me.dgvpagos.Name = "dgvpagos"
        Me.dgvpagos.ReadOnly = True
        Me.dgvpagos.Size = New System.Drawing.Size(891, 260)
        Me.dgvpagos.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(897, 317)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Impresion del Documento"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "admintegralDataSet_sql_documento_impresion"
        ReportDataSource3.Value = Me.Sql_documento_impresionBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "AdminTegral.factura.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(897, 317)
        Me.ReportViewer.TabIndex = 1
        '
        'Sql_documentosTableAdapter
        '
        Me.Sql_documentosTableAdapter.ClearBeforeFill = True
        '
        'Sql_documento_impresionTableAdapter
        '
        Me.Sql_documento_impresionTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(369, 90)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(70, 13)
        Label4.TabIndex = 38
        Label4.Text = "Tipo cartera :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentosBindingSource, "id_cartera", True))
        Me.TextBox1.Location = New System.Drawing.Point(445, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(25, 20)
        Me.TextBox1.TabIndex = 39
        '
        'Consultar_una_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(905, 470)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Consultar_una_factura"
        Me.Text = "Consultar Un Documento"
        CType(Me.Sql_documento_impresionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Sql_documentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Sql_documento_impresionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Sql_documentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_documentosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentosTableAdapter
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlmacenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_almacenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SerieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sub15TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sub10TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sub0TextBox As System.Windows.Forms.TextBox
    Friend WithEvents VenceDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechasurtidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechafacturaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FacturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Folio_pedidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Iva15TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Iva10TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descunto15TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descunto10TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descuento0TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sql_documento_impresionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_documento_impresionTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documento_impresionTableAdapter
    Friend WithEvents Sql_documento_impresionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents dgvpagos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
