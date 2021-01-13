<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ncargo
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
        Dim RFCLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim NoexteriorLabel As System.Windows.Forms.Label
        Dim NointeriorLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim MunicipioLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim CodigopostalLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ncargo))
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.idcliente = New System.Windows.Forms.TextBox
        Me.RFCTextBox = New System.Windows.Forms.TextBox
        Me.Fei_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntegraDataSet = New AdminTegral.integraDataSet
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.CalleTextBox = New System.Windows.Forms.TextBox
        Me.NoexteriorTextBox = New System.Windows.Forms.TextBox
        Me.NointeriorTextBox = New System.Windows.Forms.TextBox
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox
        Me.MunicipioTextBox = New System.Windows.Forms.TextBox
        Me.EstadoTextBox = New System.Windows.Forms.TextBox
        Me.PaisTextBox = New System.Windows.Forms.TextBox
        Me.CodigopostalTextBox = New System.Windows.Forms.TextBox
        Me.concepto = New System.Windows.Forms.TextBox
        Me.subtotal = New System.Windows.Forms.TextBox
        Me.iva = New System.Windows.Forms.TextBox
        Me.total = New System.Windows.Forms.TextBox
        Me.btn_cliente = New System.Windows.Forms.Button
        Me.Fei_clientesTableAdapter = New AdminTegral.integraDataSetTableAdapters.fei_clientesTableAdapter
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.DefinirSerieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.autoriza = New System.Windows.Forms.TextBox
        Me.btn_guardar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.metodo = New System.Windows.Forms.TextBox
        Me.cuenta = New System.Windows.Forms.TextBox
        RFCLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        CalleLabel = New System.Windows.Forms.Label
        NoexteriorLabel = New System.Windows.Forms.Label
        NointeriorLabel = New System.Windows.Forms.Label
        ReferenciaLabel = New System.Windows.Forms.Label
        ColoniaLabel = New System.Windows.Forms.Label
        LocalidadLabel = New System.Windows.Forms.Label
        MunicipioLabel = New System.Windows.Forms.Label
        EstadoLabel = New System.Windows.Forms.Label
        PaisLabel = New System.Windows.Forms.Label
        CodigopostalLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        CType(Me.Fei_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Location = New System.Drawing.Point(44, 37)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(31, 13)
        RFCLabel.TabIndex = 3
        RFCLabel.Text = "RFC:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(28, 63)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.Location = New System.Drawing.Point(43, 89)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(32, 13)
        CalleLabel.TabIndex = 7
        CalleLabel.Text = "calle:"
        '
        'NoexteriorLabel
        '
        NoexteriorLabel.AutoSize = True
        NoexteriorLabel.Location = New System.Drawing.Point(192, 89)
        NoexteriorLabel.Name = "NoexteriorLabel"
        NoexteriorLabel.Size = New System.Drawing.Size(45, 13)
        NoexteriorLabel.TabIndex = 9
        NoexteriorLabel.Text = "No. Ext:"
        '
        'NointeriorLabel
        '
        NointeriorLabel.AutoSize = True
        NointeriorLabel.Location = New System.Drawing.Point(298, 89)
        NointeriorLabel.Name = "NointeriorLabel"
        NointeriorLabel.Size = New System.Drawing.Size(53, 13)
        NointeriorLabel.TabIndex = 11
        NointeriorLabel.Text = "N.Interior:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(13, 115)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 13)
        ReferenciaLabel.TabIndex = 13
        ReferenciaLabel.Text = "Referencia:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(31, 143)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(44, 13)
        ColoniaLabel.TabIndex = 15
        ColoniaLabel.Text = "colonia:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(366, 143)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(56, 13)
        LocalidadLabel.TabIndex = 17
        LocalidadLabel.Text = "Localidad:"
        '
        'MunicipioLabel
        '
        MunicipioLabel.AutoSize = True
        MunicipioLabel.Location = New System.Drawing.Point(20, 169)
        MunicipioLabel.Name = "MunicipioLabel"
        MunicipioLabel.Size = New System.Drawing.Size(55, 13)
        MunicipioLabel.TabIndex = 19
        MunicipioLabel.Text = "Municipio:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(187, 169)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 21
        EstadoLabel.Text = "Estado:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(388, 172)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 23
        PaisLabel.Text = "Pais:"
        '
        'CodigopostalLabel
        '
        CodigopostalLabel.AutoSize = True
        CodigopostalLabel.Location = New System.Drawing.Point(210, 33)
        CodigopostalLabel.Name = "CodigopostalLabel"
        CodigopostalLabel.Size = New System.Drawing.Size(33, 13)
        CodigopostalLabel.TabIndex = 25
        CodigopostalLabel.Text = "C.P. :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(44, 8)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(18, 13)
        Label1.TabIndex = 29
        Label1.Text = "ID"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(28, 196)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(171, 13)
        Label2.TabIndex = 31
        Label2.Text = "Concepto (200 caracteres maximo)"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(399, 304)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(52, 13)
        Label3.TabIndex = 35
        Label3.Text = "Subtotal :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(412, 334)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(39, 13)
        Label4.TabIndex = 36
        Label4.Text = "I.V.A. :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(414, 360)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(37, 13)
        Label5.TabIndex = 37
        Label5.Text = "Total :"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(20, 307)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(51, 13)
        Label6.TabIndex = 41
        Label6.Text = "Autoriza :"
        '
        'idcliente
        '
        Me.idcliente.Location = New System.Drawing.Point(81, 8)
        Me.idcliente.Name = "idcliente"
        Me.idcliente.Size = New System.Drawing.Size(44, 20)
        Me.idcliente.TabIndex = 0
        '
        'RFCTextBox
        '
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "RFC", True))
        Me.RFCTextBox.Enabled = False
        Me.RFCTextBox.Location = New System.Drawing.Point(81, 34)
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RFCTextBox.TabIndex = 4
        Me.RFCTextBox.TabStop = False
        '
        'Fei_clientesBindingSource
        '
        Me.Fei_clientesBindingSource.DataMember = "fei_clientes"
        Me.Fei_clientesBindingSource.DataSource = Me.IntegraDataSet
        '
        'IntegraDataSet
        '
        Me.IntegraDataSet.DataSetName = "integraDataSet"
        Me.IntegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(81, 60)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(476, 20)
        Me.NombreTextBox.TabIndex = 6
        Me.NombreTextBox.TabStop = False
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "calle", True))
        Me.CalleTextBox.Enabled = False
        Me.CalleTextBox.Location = New System.Drawing.Point(81, 86)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CalleTextBox.TabIndex = 8
        Me.CalleTextBox.TabStop = False
        '
        'NoexteriorTextBox
        '
        Me.NoexteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "noexterior", True))
        Me.NoexteriorTextBox.Enabled = False
        Me.NoexteriorTextBox.Location = New System.Drawing.Point(243, 86)
        Me.NoexteriorTextBox.Name = "NoexteriorTextBox"
        Me.NoexteriorTextBox.Size = New System.Drawing.Size(50, 20)
        Me.NoexteriorTextBox.TabIndex = 10
        Me.NoexteriorTextBox.TabStop = False
        '
        'NointeriorTextBox
        '
        Me.NointeriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "nointerior", True))
        Me.NointeriorTextBox.Enabled = False
        Me.NointeriorTextBox.Location = New System.Drawing.Point(357, 86)
        Me.NointeriorTextBox.Name = "NointeriorTextBox"
        Me.NointeriorTextBox.Size = New System.Drawing.Size(50, 20)
        Me.NointeriorTextBox.TabIndex = 12
        Me.NointeriorTextBox.TabStop = False
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "referencia", True))
        Me.ReferenciaTextBox.Enabled = False
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(81, 112)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(476, 20)
        Me.ReferenciaTextBox.TabIndex = 14
        Me.ReferenciaTextBox.TabStop = False
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "colonia", True))
        Me.ColoniaTextBox.Enabled = False
        Me.ColoniaTextBox.Location = New System.Drawing.Point(81, 140)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(270, 20)
        Me.ColoniaTextBox.TabIndex = 16
        Me.ColoniaTextBox.TabStop = False
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "localidad", True))
        Me.LocalidadTextBox.Enabled = False
        Me.LocalidadTextBox.Location = New System.Drawing.Point(424, 140)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(133, 20)
        Me.LocalidadTextBox.TabIndex = 18
        Me.LocalidadTextBox.TabStop = False
        '
        'MunicipioTextBox
        '
        Me.MunicipioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "municipio", True))
        Me.MunicipioTextBox.Enabled = False
        Me.MunicipioTextBox.Location = New System.Drawing.Point(81, 166)
        Me.MunicipioTextBox.Name = "MunicipioTextBox"
        Me.MunicipioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MunicipioTextBox.TabIndex = 20
        Me.MunicipioTextBox.TabStop = False
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "estado", True))
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(236, 166)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(115, 20)
        Me.EstadoTextBox.TabIndex = 22
        Me.EstadoTextBox.TabStop = False
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "pais", True))
        Me.PaisTextBox.Enabled = False
        Me.PaisTextBox.Location = New System.Drawing.Point(424, 166)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 24
        Me.PaisTextBox.TabStop = False
        '
        'CodigopostalTextBox
        '
        Me.CodigopostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fei_clientesBindingSource, "Codigopostal", True))
        Me.CodigopostalTextBox.Enabled = False
        Me.CodigopostalTextBox.Location = New System.Drawing.Point(287, 30)
        Me.CodigopostalTextBox.Name = "CodigopostalTextBox"
        Me.CodigopostalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigopostalTextBox.TabIndex = 26
        Me.CodigopostalTextBox.TabStop = False
        '
        'concepto
        '
        Me.concepto.Location = New System.Drawing.Point(23, 212)
        Me.concepto.MaxLength = 200
        Me.concepto.Multiline = True
        Me.concepto.Name = "concepto"
        Me.concepto.Size = New System.Drawing.Size(534, 86)
        Me.concepto.TabIndex = 30
        '
        'subtotal
        '
        Me.subtotal.Location = New System.Drawing.Point(457, 304)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(100, 20)
        Me.subtotal.TabIndex = 32
        Me.subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'iva
        '
        Me.iva.Enabled = False
        Me.iva.Location = New System.Drawing.Point(457, 330)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(100, 20)
        Me.iva.TabIndex = 33
        Me.iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'total
        '
        Me.total.Enabled = False
        Me.total.Location = New System.Drawing.Point(457, 356)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 34
        Me.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_cliente
        '
        Me.btn_cliente.Location = New System.Drawing.Point(131, 8)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_cliente.TabIndex = 38
        Me.btn_cliente.Text = "..."
        Me.btn_cliente.UseVisualStyleBackColor = True
        '
        'Fei_clientesTableAdapter
        '
        Me.Fei_clientesTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 418)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(577, 22)
        Me.StatusStrip1.TabIndex = 39
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefinirSerieToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'DefinirSerieToolStripMenuItem
        '
        Me.DefinirSerieToolStripMenuItem.Name = "DefinirSerieToolStripMenuItem"
        Me.DefinirSerieToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DefinirSerieToolStripMenuItem.Text = "Definir Serie"
        '
        'autoriza
        '
        Me.autoriza.Location = New System.Drawing.Point(74, 304)
        Me.autoriza.Name = "autoriza"
        Me.autoriza.Size = New System.Drawing.Size(277, 20)
        Me.autoriza.TabIndex = 40
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Location = New System.Drawing.Point(499, 394)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(58, 21)
        Me.btn_guardar.TabIndex = 42
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Location = New System.Drawing.Point(435, 394)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(58, 21)
        Me.btn_salir.TabIndex = 43
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'metodo
        '
        Me.metodo.Location = New System.Drawing.Point(115, 350)
        Me.metodo.Name = "metodo"
        Me.metodo.Size = New System.Drawing.Size(190, 20)
        Me.metodo.TabIndex = 44
        '
        'cuenta
        '
        Me.cuenta.Location = New System.Drawing.Point(115, 376)
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Size = New System.Drawing.Size(66, 20)
        Me.cuenta.TabIndex = 45
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(17, 353)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(92, 13)
        Label7.TabIndex = 46
        Label7.Text = "Metodo de Pago :"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(17, 383)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(89, 13)
        Label8.TabIndex = 47
        Label8.Text = "No. Cta. (4 Dig.) :"
        '
        'Ncargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 440)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.cuenta)
        Me.Controls.Add(Me.metodo)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.autoriza)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_cliente)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.concepto)
        Me.Controls.Add(Label1)
        Me.Controls.Add(RFCLabel)
        Me.Controls.Add(Me.RFCTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CalleLabel)
        Me.Controls.Add(Me.CalleTextBox)
        Me.Controls.Add(NoexteriorLabel)
        Me.Controls.Add(Me.NoexteriorTextBox)
        Me.Controls.Add(NointeriorLabel)
        Me.Controls.Add(Me.NointeriorTextBox)
        Me.Controls.Add(ReferenciaLabel)
        Me.Controls.Add(Me.ReferenciaTextBox)
        Me.Controls.Add(ColoniaLabel)
        Me.Controls.Add(Me.ColoniaTextBox)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Controls.Add(MunicipioLabel)
        Me.Controls.Add(Me.MunicipioTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(CodigopostalLabel)
        Me.Controls.Add(Me.CodigopostalTextBox)
        Me.Controls.Add(Me.idcliente)
        Me.Name = "Ncargo"
        Me.Text = "Nota de Cargo"
        CType(Me.Fei_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idcliente As System.Windows.Forms.TextBox
    Friend WithEvents IntegraDataSet As AdminTegral.integraDataSet
    Friend WithEvents Fei_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fei_clientesTableAdapter As AdminTegral.integraDataSetTableAdapters.fei_clientesTableAdapter
    Friend WithEvents RFCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoexteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NointeriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColoniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MunicipioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigopostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents concepto As System.Windows.Forms.TextBox
    Friend WithEvents subtotal As System.Windows.Forms.TextBox
    Friend WithEvents iva As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents btn_cliente As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents DefinirSerieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents autoriza As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents metodo As System.Windows.Forms.TextBox
    Friend WithEvents cuenta As System.Windows.Forms.TextBox
End Class
