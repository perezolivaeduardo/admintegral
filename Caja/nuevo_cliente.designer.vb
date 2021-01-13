<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevo_cliente
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
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim EdoLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim RFCLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim DiasLabel As System.Windows.Forms.Label
        Dim ComercialLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim MetodoLabel As System.Windows.Forms.Label
        Dim FormaLabel As System.Windows.Forms.Label
        Dim UsoLabel As System.Windows.Forms.Label
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter()
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.EdoTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.RFCTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WebTextBox = New System.Windows.Forms.TextBox()
        Me.DiasTextBox = New System.Windows.Forms.TextBox()
        Me.ComercialTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.MetodoTextBox = New System.Windows.Forms.TextBox()
        Me.FormaTextBox = New System.Windows.Forms.TextBox()
        Me.UsoTextBox = New System.Windows.Forms.TextBox()
        Me.SAT_catalogosDataSet = New AdminTegral.SAT_catalogosDataSet()
        Me.Sat_metodosdepagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sat_metodosdepagoTableAdapter = New AdminTegral.SAT_catalogosDataSetTableAdapters.sat_metodosdepagoTableAdapter()
        Me.TableAdapterManager = New AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager()
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.Sat_formasdepagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sat_formasdepagoTableAdapter = New AdminTegral.SAT_catalogosDataSetTableAdapters.sat_formasdepagoTableAdapter()
        Me.DescripcionComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Sat_usoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sat_usoTableAdapter = New AdminTegral.SAT_catalogosDataSetTableAdapters.sat_usoTableAdapter()
        Me.UsoComboBox = New System.Windows.Forms.ComboBox()
        NombreLabel1 = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        EdoLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        RFCLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        WebLabel = New System.Windows.Forms.Label()
        DiasLabel = New System.Windows.Forms.Label()
        ComercialLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        MetodoLabel = New System.Windows.Forms.Label()
        FormaLabel = New System.Windows.Forms.Label()
        UsoLabel = New System.Windows.Forms.Label()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAT_catalogosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sat_metodosdepagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sat_formasdepagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sat_usoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "id_directorio", True))
        Me.Id_directorioTextBox.Enabled = False
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(666, 9)
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(49, 20)
        Me.Id_directorioTextBox.TabIndex = 1
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "tipo", True))
        Me.TipoTextBox.Enabled = False
        Me.TipoTextBox.Location = New System.Drawing.Point(632, 9)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(28, 20)
        Me.TipoTextBox.TabIndex = 3
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(31, 41)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(47, 13)
        NombreLabel1.TabIndex = 5
        NombreLabel1.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(84, 38)
        Me.NombreTextBox.MaxLength = 75
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(511, 20)
        Me.NombreTextBox.TabIndex = 1
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(23, 67)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 6
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(84, 64)
        Me.DireccionTextBox.MaxLength = 75
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(511, 20)
        Me.DireccionTextBox.TabIndex = 2
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(33, 93)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(45, 13)
        ColoniaLabel.TabIndex = 8
        ColoniaLabel.Text = "Colonia:"
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(84, 90)
        Me.ColoniaTextBox.MaxLength = 30
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(207, 20)
        Me.ColoniaTextBox.TabIndex = 3
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(313, 93)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 10
        CiudadLabel.Text = "Ciudad:"
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(362, 90)
        Me.CiudadTextBox.MaxLength = 30
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(233, 20)
        Me.CiudadTextBox.TabIndex = 4
        '
        'EdoLabel
        '
        EdoLabel.AutoSize = True
        EdoLabel.Location = New System.Drawing.Point(49, 119)
        EdoLabel.Name = "EdoLabel"
        EdoLabel.Size = New System.Drawing.Size(29, 13)
        EdoLabel.TabIndex = 12
        EdoLabel.Text = "Edo:"
        '
        'EdoTextBox
        '
        Me.EdoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Edo", True))
        Me.EdoTextBox.Location = New System.Drawing.Point(84, 116)
        Me.EdoTextBox.Name = "EdoTextBox"
        Me.EdoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EdoTextBox.TabIndex = 5
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(202, 119)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 14
        CPLabel.Text = "CP:"
        '
        'CPTextBox
        '
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "CP", True))
        Me.CPTextBox.Location = New System.Drawing.Point(232, 116)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPTextBox.TabIndex = 6
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Location = New System.Drawing.Point(47, 15)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(31, 13)
        RFCLabel.TabIndex = 16
        RFCLabel.Text = "RFC:"
        '
        'RFCTextBox
        '
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "RFC", True))
        Me.RFCTextBox.Location = New System.Drawing.Point(84, 12)
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RFCTextBox.TabIndex = 0
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(26, 145)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 18
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(84, 142)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 7
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(184, 148)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 20
        CelularLabel.Text = "Celular:"
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(232, 145)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 8
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(44, 171)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "E mail:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(84, 168)
        Me.EmailTextBox.MaxLength = 100
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(511, 20)
        Me.EmailTextBox.TabIndex = 9
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.Location = New System.Drawing.Point(45, 197)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(33, 13)
        WebLabel.TabIndex = 24
        WebLabel.Text = "Web:"
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Web", True))
        Me.WebTextBox.Location = New System.Drawing.Point(84, 194)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(511, 20)
        Me.WebTextBox.TabIndex = 10
        '
        'DiasLabel
        '
        DiasLabel.AutoSize = True
        DiasLabel.Location = New System.Drawing.Point(47, 223)
        DiasLabel.Name = "DiasLabel"
        DiasLabel.Size = New System.Drawing.Size(31, 13)
        DiasLabel.TabIndex = 26
        DiasLabel.Text = "Dias:"
        '
        'DiasTextBox
        '
        Me.DiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Dias", True))
        Me.DiasTextBox.Location = New System.Drawing.Point(84, 220)
        Me.DiasTextBox.MaxLength = 3
        Me.DiasTextBox.Name = "DiasTextBox"
        Me.DiasTextBox.Size = New System.Drawing.Size(41, 20)
        Me.DiasTextBox.TabIndex = 11
        '
        'ComercialLabel
        '
        ComercialLabel.AutoSize = True
        ComercialLabel.Location = New System.Drawing.Point(23, 249)
        ComercialLabel.Name = "ComercialLabel"
        ComercialLabel.Size = New System.Drawing.Size(55, 13)
        ComercialLabel.TabIndex = 28
        ComercialLabel.Text = "comercial:"
        '
        'ComercialTextBox
        '
        Me.ComercialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "comercial", True))
        Me.ComercialTextBox.Location = New System.Drawing.Point(84, 246)
        Me.ComercialTextBox.MaxLength = 50
        Me.ComercialTextBox.Name = "ComercialTextBox"
        Me.ComercialTextBox.Size = New System.Drawing.Size(511, 20)
        Me.ComercialTextBox.TabIndex = 12
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(10, 275)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 30
        ComentariosLabel.Text = "Comentarios:"
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(84, 272)
        Me.ComentariosTextBox.MaxLength = 100
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(511, 20)
        Me.ComentariosTextBox.TabIndex = 13
        '
        'MetodoLabel
        '
        MetodoLabel.AutoSize = True
        MetodoLabel.Location = New System.Drawing.Point(33, 308)
        MetodoLabel.Name = "MetodoLabel"
        MetodoLabel.Size = New System.Drawing.Size(45, 13)
        MetodoLabel.TabIndex = 32
        MetodoLabel.Text = "metodo:"
        '
        'MetodoTextBox
        '
        Me.MetodoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "metodo", True))
        Me.MetodoTextBox.Location = New System.Drawing.Point(84, 305)
        Me.MetodoTextBox.Name = "MetodoTextBox"
        Me.MetodoTextBox.Size = New System.Drawing.Size(41, 20)
        Me.MetodoTextBox.TabIndex = 14
        '
        'FormaLabel
        '
        FormaLabel.AutoSize = True
        FormaLabel.Location = New System.Drawing.Point(42, 334)
        FormaLabel.Name = "FormaLabel"
        FormaLabel.Size = New System.Drawing.Size(36, 13)
        FormaLabel.TabIndex = 36
        FormaLabel.Text = "forma:"
        '
        'FormaTextBox
        '
        Me.FormaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "forma", True))
        Me.FormaTextBox.Location = New System.Drawing.Point(84, 331)
        Me.FormaTextBox.Name = "FormaTextBox"
        Me.FormaTextBox.Size = New System.Drawing.Size(41, 20)
        Me.FormaTextBox.TabIndex = 15
        '
        'UsoLabel
        '
        UsoLabel.AutoSize = True
        UsoLabel.Location = New System.Drawing.Point(51, 360)
        UsoLabel.Name = "UsoLabel"
        UsoLabel.Size = New System.Drawing.Size(27, 13)
        UsoLabel.TabIndex = 38
        UsoLabel.Text = "uso:"
        '
        'UsoTextBox
        '
        Me.UsoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirectorioBindingSource, "uso", True))
        Me.UsoTextBox.Location = New System.Drawing.Point(84, 357)
        Me.UsoTextBox.Name = "UsoTextBox"
        Me.UsoTextBox.Size = New System.Drawing.Size(41, 20)
        Me.UsoTextBox.TabIndex = 16
        Me.UsoTextBox.Text = "G03"
        '
        'SAT_catalogosDataSet
        '
        Me.SAT_catalogosDataSet.DataSetName = "SAT_catalogosDataSet"
        Me.SAT_catalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sat_metodosdepagoBindingSource
        '
        Me.Sat_metodosdepagoBindingSource.DataMember = "sat_metodosdepago"
        Me.Sat_metodosdepagoBindingSource.DataSource = Me.SAT_catalogosDataSet
        '
        'Sat_metodosdepagoTableAdapter
        '
        Me.Sat_metodosdepagoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Productos_ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.sat_codigospostalesTableAdapter = Nothing
        Me.TableAdapterManager.sat_formasdepagoTableAdapter = Me.Sat_formasdepagoTableAdapter
        Me.TableAdapterManager.sat_metodosdepagoTableAdapter = Me.Sat_metodosdepagoTableAdapter
        Me.TableAdapterManager.sat_regimenTableAdapter = Nothing
        Me.TableAdapterManager.sat_tiporelacionTableAdapter = Nothing
        Me.TableAdapterManager.sat_unidadesTableAdapter = Nothing
        Me.TableAdapterManager.sat_usoTableAdapter = Me.Sat_usoTableAdapter
        Me.TableAdapterManager.UpdateOrder = AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataSource = Me.Sat_metodosdepagoBindingSource
        Me.DescripcionComboBox.DisplayMember = "descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(131, 304)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(131, 21)
        Me.DescripcionComboBox.TabIndex = 40
        Me.DescripcionComboBox.ValueMember = "metodo"
        '
        'Sat_formasdepagoBindingSource
        '
        Me.Sat_formasdepagoBindingSource.DataMember = "sat_formasdepago"
        Me.Sat_formasdepagoBindingSource.DataSource = Me.SAT_catalogosDataSet
        '
        'Sat_formasdepagoTableAdapter
        '
        Me.Sat_formasdepagoTableAdapter.ClearBeforeFill = True
        '
        'DescripcionComboBox1
        '
        Me.DescripcionComboBox1.DataSource = Me.Sat_formasdepagoBindingSource
        Me.DescripcionComboBox1.DisplayMember = "descripcion"
        Me.DescripcionComboBox1.FormattingEnabled = True
        Me.DescripcionComboBox1.Location = New System.Drawing.Point(131, 330)
        Me.DescripcionComboBox1.Name = "DescripcionComboBox1"
        Me.DescripcionComboBox1.Size = New System.Drawing.Size(131, 21)
        Me.DescripcionComboBox1.TabIndex = 41
        Me.DescripcionComboBox1.ValueMember = "formaDEpago"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(520, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Sat_usoBindingSource
        '
        Me.Sat_usoBindingSource.DataMember = "sat_uso"
        Me.Sat_usoBindingSource.DataSource = Me.SAT_catalogosDataSet
        '
        'Sat_usoTableAdapter
        '
        Me.Sat_usoTableAdapter.ClearBeforeFill = True
        '
        'UsoComboBox
        '
        Me.UsoComboBox.DataSource = Me.Sat_usoBindingSource
        Me.UsoComboBox.DisplayMember = "Uso"
        Me.UsoComboBox.FormattingEnabled = True
        Me.UsoComboBox.Location = New System.Drawing.Point(131, 357)
        Me.UsoComboBox.Name = "UsoComboBox"
        Me.UsoComboBox.Size = New System.Drawing.Size(131, 21)
        Me.UsoComboBox.TabIndex = 44
        Me.UsoComboBox.ValueMember = "id_uso"
        '
        'nuevo_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 405)
        Me.Controls.Add(Me.UsoComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DescripcionComboBox1)
        Me.Controls.Add(Me.DescripcionComboBox)
        Me.Controls.Add(UsoLabel)
        Me.Controls.Add(Me.UsoTextBox)
        Me.Controls.Add(FormaLabel)
        Me.Controls.Add(Me.FormaTextBox)
        Me.Controls.Add(MetodoLabel)
        Me.Controls.Add(Me.MetodoTextBox)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Controls.Add(ComercialLabel)
        Me.Controls.Add(Me.ComercialTextBox)
        Me.Controls.Add(DiasLabel)
        Me.Controls.Add(Me.DiasTextBox)
        Me.Controls.Add(WebLabel)
        Me.Controls.Add(Me.WebTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(RFCLabel)
        Me.Controls.Add(Me.RFCTextBox)
        Me.Controls.Add(CPLabel)
        Me.Controls.Add(Me.CPTextBox)
        Me.Controls.Add(EdoLabel)
        Me.Controls.Add(Me.EdoTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(ColoniaLabel)
        Me.Controls.Add(Me.ColoniaTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Me.Id_directorioTextBox)
        Me.Name = "nuevo_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nuevo_cliente"
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAT_catalogosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sat_metodosdepagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sat_formasdepagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sat_usoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColoniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RFCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComercialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MetodoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SAT_catalogosDataSet As AdminTegral.SAT_catalogosDataSet
    Friend WithEvents Sat_metodosdepagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sat_metodosdepagoTableAdapter As AdminTegral.SAT_catalogosDataSetTableAdapters.sat_metodosdepagoTableAdapter
    Friend WithEvents TableAdapterManager As AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sat_formasdepagoTableAdapter As AdminTegral.SAT_catalogosDataSetTableAdapters.sat_formasdepagoTableAdapter
    Friend WithEvents Sat_formasdepagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Sat_usoTableAdapter As AdminTegral.SAT_catalogosDataSetTableAdapters.sat_usoTableAdapter
    Friend WithEvents Sat_usoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsoComboBox As System.Windows.Forms.ComboBox
End Class
