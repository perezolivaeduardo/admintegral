<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas
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
        Dim TurnoLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim Id_directorioLabel As System.Windows.Forms.Label
        Dim AgenteLabel As System.Windows.Forms.Label
        Dim AsuntoLabel As System.Windows.Forms.Label
        Dim Comentarios_recepcionLabel As System.Windows.Forms.Label
        Dim Id_directorioLabel1 As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim AgenteLabel1 As System.Windows.Forms.Label
        Dim TelOficinaLabel As System.Windows.Forms.Label
        Dim TelCelLabel As System.Windows.Forms.Label
        Dim Correo1Label As System.Windows.Forms.Label
        Dim Correo2Label As System.Windows.Forms.Label
        Dim Nombre_jefeLabel As System.Windows.Forms.Label
        Dim Telefono_jefeLabel As System.Windows.Forms.Label
        Dim Celular_jefeLabel As System.Windows.Forms.Label
        Dim Correo_jefeLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim AsuntoLabel1 As System.Windows.Forms.Label
        Dim Comentarios_recepcionLabel1 As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim AtendidoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citas))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.boton_modifica = New System.Windows.Forms.ToolStripButton
        Me.boton_borrar_cita = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Boton_pedido = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.Sql_citasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.atendido = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Sql_citasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteDataSet = New AdminTegral.reporteDataSet
        Me.Boton_actualizar = New System.Windows.Forms.Button
        Me.Comentarios_recepcionTextBox1 = New System.Windows.Forms.TextBox
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsuntoTextBox1 = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.AtendidoCheckBox = New System.Windows.Forms.CheckBox
        Me.FechaTextBox = New System.Windows.Forms.TextBox
        Me.Nombre_agente = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_salir_cita = New System.Windows.Forms.Button
        Me.Boton_guardar = New System.Windows.Forms.Button
        Me.nombreprovedor = New System.Windows.Forms.TextBox
        Me.TurnoTextBox = New System.Windows.Forms.TextBox
        Me.HoraTextBox = New System.Windows.Forms.TextBox
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox
        Me.AgenteTextBox = New System.Windows.Forms.TextBox
        Me.AsuntoTextBox = New System.Windows.Forms.TextBox
        Me.Comentarios_recepcionTextBox = New System.Windows.Forms.TextBox
        Me.Panelalta = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.btn_canelar_alta_agente = New System.Windows.Forms.Button
        Me.barra1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AgendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_nuevo_agente = New System.Windows.Forms.ToolStripButton
        Me.Id_directorioTextBox1 = New System.Windows.Forms.TextBox
        Me.NumeroTextBox = New System.Windows.Forms.TextBox
        Me.AgenteTextBox1 = New System.Windows.Forms.TextBox
        Me.TelOficinaTextBox = New System.Windows.Forms.TextBox
        Me.TelCelTextBox = New System.Windows.Forms.TextBox
        Me.Correo1TextBox = New System.Windows.Forms.TextBox
        Me.Correo2TextBox = New System.Windows.Forms.TextBox
        Me.Nombre_jefeTextBox = New System.Windows.Forms.TextBox
        Me.Telefono_jefeTextBox = New System.Windows.Forms.TextBox
        Me.Celular_jefeTextBox = New System.Windows.Forms.TextBox
        Me.Correo_jefeTextBox = New System.Windows.Forms.TextBox
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CitasTableAdapter = New AdminTegral.reporteDataSetTableAdapters.citasTableAdapter
        Me.AgendaTableAdapter = New AdminTegral.reporteDataSetTableAdapters.agendaTableAdapter
        Me.Sql_citasTableAdapter = New AdminTegral.reporteDataSetTableAdapters.sql_citasTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        TurnoLabel = New System.Windows.Forms.Label
        HoraLabel = New System.Windows.Forms.Label
        Id_directorioLabel = New System.Windows.Forms.Label
        AgenteLabel = New System.Windows.Forms.Label
        AsuntoLabel = New System.Windows.Forms.Label
        Comentarios_recepcionLabel = New System.Windows.Forms.Label
        Id_directorioLabel1 = New System.Windows.Forms.Label
        NumeroLabel = New System.Windows.Forms.Label
        AgenteLabel1 = New System.Windows.Forms.Label
        TelOficinaLabel = New System.Windows.Forms.Label
        TelCelLabel = New System.Windows.Forms.Label
        Correo1Label = New System.Windows.Forms.Label
        Correo2Label = New System.Windows.Forms.Label
        Nombre_jefeLabel = New System.Windows.Forms.Label
        Telefono_jefeLabel = New System.Windows.Forms.Label
        Celular_jefeLabel = New System.Windows.Forms.Label
        Correo_jefeLabel = New System.Windows.Forms.Label
        ComentariosLabel = New System.Windows.Forms.Label
        AsuntoLabel1 = New System.Windows.Forms.Label
        Comentarios_recepcionLabel1 = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        AtendidoLabel = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Sql_citasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_citasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panelalta.SuspendLayout()
        CType(Me.barra1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barra1.SuspendLayout()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TurnoLabel
        '
        TurnoLabel.AutoSize = True
        TurnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TurnoLabel.Location = New System.Drawing.Point(13, 46)
        TurnoLabel.Name = "TurnoLabel"
        TurnoLabel.Size = New System.Drawing.Size(46, 18)
        TurnoLabel.TabIndex = 2
        TurnoLabel.Text = "turno:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HoraLabel.Location = New System.Drawing.Point(134, 46)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(42, 18)
        HoraLabel.TabIndex = 4
        HoraLabel.Text = "hora:"
        '
        'Id_directorioLabel
        '
        Id_directorioLabel.AutoSize = True
        Id_directorioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_directorioLabel.Location = New System.Drawing.Point(17, 91)
        Id_directorioLabel.Name = "Id_directorioLabel"
        Id_directorioLabel.Size = New System.Drawing.Size(62, 18)
        Id_directorioLabel.TabIndex = 6
        Id_directorioLabel.Text = "Id. Prov:"
        '
        'AgenteLabel
        '
        AgenteLabel.AutoSize = True
        AgenteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgenteLabel.Location = New System.Drawing.Point(17, 126)
        AgenteLabel.Name = "AgenteLabel"
        AgenteLabel.Size = New System.Drawing.Size(56, 18)
        AgenteLabel.TabIndex = 8
        AgenteLabel.Text = "agente:"
        '
        'AsuntoLabel
        '
        AsuntoLabel.AutoSize = True
        AsuntoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AsuntoLabel.Location = New System.Drawing.Point(20, 164)
        AsuntoLabel.Name = "AsuntoLabel"
        AsuntoLabel.Size = New System.Drawing.Size(58, 18)
        AsuntoLabel.TabIndex = 10
        AsuntoLabel.Text = "Asunto:"
        '
        'Comentarios_recepcionLabel
        '
        Comentarios_recepcionLabel.AutoSize = True
        Comentarios_recepcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Comentarios_recepcionLabel.Location = New System.Drawing.Point(21, 190)
        Comentarios_recepcionLabel.Name = "Comentarios_recepcionLabel"
        Comentarios_recepcionLabel.Size = New System.Drawing.Size(164, 18)
        Comentarios_recepcionLabel.TabIndex = 12
        Comentarios_recepcionLabel.Text = "comentarios recepcion:"
        '
        'Id_directorioLabel1
        '
        Id_directorioLabel1.AutoSize = True
        Id_directorioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_directorioLabel1.Location = New System.Drawing.Point(17, 20)
        Id_directorioLabel1.Name = "Id_directorioLabel1"
        Id_directorioLabel1.Size = New System.Drawing.Size(92, 18)
        Id_directorioLabel1.TabIndex = 0
        Id_directorioLabel1.Text = "Id Directorio:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroLabel.Location = New System.Drawing.Point(167, 17)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(63, 18)
        NumeroLabel.TabIndex = 2
        NumeroLabel.Text = "numero:"
        '
        'AgenteLabel1
        '
        AgenteLabel1.AutoSize = True
        AgenteLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgenteLabel1.Location = New System.Drawing.Point(52, 50)
        AgenteLabel1.Name = "AgenteLabel1"
        AgenteLabel1.Size = New System.Drawing.Size(57, 18)
        AgenteLabel1.TabIndex = 4
        AgenteLabel1.Text = "Agente:"
        '
        'TelOficinaLabel
        '
        TelOficinaLabel.AutoSize = True
        TelOficinaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelOficinaLabel.Location = New System.Drawing.Point(27, 88)
        TelOficinaLabel.Name = "TelOficinaLabel"
        TelOficinaLabel.Size = New System.Drawing.Size(82, 18)
        TelOficinaLabel.TabIndex = 6
        TelOficinaLabel.Text = "Tel Oficina:"
        '
        'TelCelLabel
        '
        TelCelLabel.AutoSize = True
        TelCelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelCelLabel.Location = New System.Drawing.Point(267, 92)
        TelCelLabel.Name = "TelCelLabel"
        TelCelLabel.Size = New System.Drawing.Size(62, 18)
        TelCelLabel.TabIndex = 8
        TelCelLabel.Text = "Celular :"
        '
        'Correo1Label
        '
        Correo1Label.AutoSize = True
        Correo1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo1Label.Location = New System.Drawing.Point(42, 116)
        Correo1Label.Name = "Correo1Label"
        Correo1Label.Size = New System.Drawing.Size(67, 18)
        Correo1Label.TabIndex = 10
        Correo1Label.Text = "Correo1:"
        '
        'Correo2Label
        '
        Correo2Label.AutoSize = True
        Correo2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo2Label.Location = New System.Drawing.Point(42, 142)
        Correo2Label.Name = "Correo2Label"
        Correo2Label.Size = New System.Drawing.Size(67, 18)
        Correo2Label.TabIndex = 12
        Correo2Label.Text = "Correo2:"
        '
        'Nombre_jefeLabel
        '
        Nombre_jefeLabel.AutoSize = True
        Nombre_jefeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_jefeLabel.Location = New System.Drawing.Point(16, 173)
        Nombre_jefeLabel.Name = "Nombre_jefeLabel"
        Nombre_jefeLabel.Size = New System.Drawing.Size(93, 18)
        Nombre_jefeLabel.TabIndex = 14
        Nombre_jefeLabel.Text = "Nombre jefe:"
        '
        'Telefono_jefeLabel
        '
        Telefono_jefeLabel.AutoSize = True
        Telefono_jefeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefono_jefeLabel.Location = New System.Drawing.Point(17, 204)
        Telefono_jefeLabel.Name = "Telefono_jefeLabel"
        Telefono_jefeLabel.Size = New System.Drawing.Size(92, 18)
        Telefono_jefeLabel.TabIndex = 16
        Telefono_jefeLabel.Text = "telefono jefe:"
        '
        'Celular_jefeLabel
        '
        Celular_jefeLabel.AutoSize = True
        Celular_jefeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Celular_jefeLabel.Location = New System.Drawing.Point(227, 207)
        Celular_jefeLabel.Name = "Celular_jefeLabel"
        Celular_jefeLabel.Size = New System.Drawing.Size(82, 18)
        Celular_jefeLabel.TabIndex = 18
        Celular_jefeLabel.Text = "celular jefe:"
        '
        'Correo_jefeLabel
        '
        Correo_jefeLabel.AutoSize = True
        Correo_jefeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo_jefeLabel.Location = New System.Drawing.Point(26, 238)
        Correo_jefeLabel.Name = "Correo_jefeLabel"
        Correo_jefeLabel.Size = New System.Drawing.Size(83, 18)
        Correo_jefeLabel.TabIndex = 20
        Correo_jefeLabel.Text = "correo jefe:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentariosLabel.Location = New System.Drawing.Point(11, 265)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(98, 18)
        ComentariosLabel.TabIndex = 22
        ComentariosLabel.Text = "Comentarios:"
        '
        'AsuntoLabel1
        '
        AsuntoLabel1.AutoSize = True
        AsuntoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AsuntoLabel1.Location = New System.Drawing.Point(12, 9)
        AsuntoLabel1.Name = "AsuntoLabel1"
        AsuntoLabel1.Size = New System.Drawing.Size(68, 20)
        AsuntoLabel1.TabIndex = 0
        AsuntoLabel1.Text = "Asunto :"
        '
        'Comentarios_recepcionLabel1
        '
        Comentarios_recepcionLabel1.AutoSize = True
        Comentarios_recepcionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Comentarios_recepcionLabel1.Location = New System.Drawing.Point(273, 7)
        Comentarios_recepcionLabel1.Name = "Comentarios_recepcionLabel1"
        Comentarios_recepcionLabel1.Size = New System.Drawing.Size(107, 20)
        Comentarios_recepcionLabel1.TabIndex = 2
        Comentarios_recepcionLabel1.Text = "Comentarios :"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(11, 14)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(48, 18)
        FechaLabel.TabIndex = 18
        FechaLabel.Text = "fecha:"
        '
        'AtendidoLabel
        '
        AtendidoLabel.AutoSize = True
        AtendidoLabel.Location = New System.Drawing.Point(15, 323)
        AtendidoLabel.Name = "AtendidoLabel"
        AtendidoLabel.Size = New System.Drawing.Size(51, 13)
        AtendidoLabel.TabIndex = 19
        AtendidoLabel.Text = "atendido:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.boton_modifica, Me.boton_borrar_cita, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.Boton_pedido, Me.ToolStripButton2, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(988, 71)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(165, 68)
        Me.ToolStripButton1.Text = "Nueva Visita"
        '
        'boton_modifica
        '
        Me.boton_modifica.Image = CType(resources.GetObject("boton_modifica.Image"), System.Drawing.Image)
        Me.boton_modifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_modifica.Name = "boton_modifica"
        Me.boton_modifica.Size = New System.Drawing.Size(150, 68)
        Me.boton_modifica.Text = "Modificar Cita"
        '
        'boton_borrar_cita
        '
        Me.boton_borrar_cita.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_borrar_cita.Image = CType(resources.GetObject("boton_borrar_cita.Image"), System.Drawing.Image)
        Me.boton_borrar_cita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_borrar_cita.Name = "boton_borrar_cita"
        Me.boton_borrar_cita.Size = New System.Drawing.Size(153, 68)
        Me.boton_borrar_cita.Text = "Borrar Cita"
        Me.boton_borrar_cita.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 71)
        '
        'Boton_pedido
        '
        Me.Boton_pedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Boton_pedido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_pedido.Image = CType(resources.GetObject("Boton_pedido.Image"), System.Drawing.Image)
        Me.Boton_pedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_pedido.Name = "Boton_pedido"
        Me.Boton_pedido.Size = New System.Drawing.Size(68, 68)
        Me.Boton_pedido.Text = "Pedido"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.repeat
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton2.Text = "Actualiza Citas"
        Me.ToolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.AdminTegral.My.Resources.Resources.Help_Documents_2
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton4.Text = "Pedidos_detallado"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 71)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(988, 535)
        Me.SplitContainer1.SplitterDistance = 389
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.Sql_citasDataGridView)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.Boton_actualizar)
        Me.SplitContainer3.Panel2.Controls.Add(Comentarios_recepcionLabel1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Comentarios_recepcionTextBox1)
        Me.SplitContainer3.Panel2.Controls.Add(AsuntoLabel1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.AsuntoTextBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(389, 535)
        Me.SplitContainer3.SplitterDistance = 434
        Me.SplitContainer3.TabIndex = 0
        '
        'Sql_citasDataGridView
        '
        Me.Sql_citasDataGridView.AllowUserToAddRows = False
        Me.Sql_citasDataGridView.AllowUserToDeleteRows = False
        Me.Sql_citasDataGridView.AllowUserToResizeColumns = False
        Me.Sql_citasDataGridView.AllowUserToResizeRows = False
        Me.Sql_citasDataGridView.AutoGenerateColumns = False
        Me.Sql_citasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sql_citasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Sql_citasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.atendido})
        Me.Sql_citasDataGridView.DataSource = Me.Sql_citasBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sql_citasDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.Sql_citasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_citasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_citasDataGridView.Name = "Sql_citasDataGridView"
        Me.Sql_citasDataGridView.ReadOnly = True
        Me.Sql_citasDataGridView.RowHeadersVisible = False
        Me.Sql_citasDataGridView.Size = New System.Drawing.Size(389, 434)
        Me.Sql_citasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn1.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 69
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "turno"
        Me.DataGridViewTextBoxColumn2.HeaderText = "turno"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 67
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "hora"
        Me.DataGridViewTextBoxColumn3.HeaderText = "hora"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 63
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 87
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Agente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Agente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 78
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "asunto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "asunto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "comentarios_recepcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "comentarios_recepcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 189
        '
        'atendido
        '
        Me.atendido.DataPropertyName = "atendido"
        Me.atendido.HeaderText = "atendido"
        Me.atendido.Name = "atendido"
        Me.atendido.ReadOnly = True
        Me.atendido.Width = 70
        '
        'Sql_citasBindingSource
        '
        Me.Sql_citasBindingSource.DataMember = "sql_citas"
        Me.Sql_citasBindingSource.DataSource = Me.ReporteDataSet
        '
        'ReporteDataSet
        '
        Me.ReporteDataSet.DataSetName = "reporteDataSet"
        Me.ReporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Boton_actualizar
        '
        Me.Boton_actualizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Boton_actualizar.Location = New System.Drawing.Point(302, 55)
        Me.Boton_actualizar.Name = "Boton_actualizar"
        Me.Boton_actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Boton_actualizar.TabIndex = 4
        Me.Boton_actualizar.Text = "Actualizar"
        Me.Boton_actualizar.UseVisualStyleBackColor = True
        '
        'Comentarios_recepcionTextBox1
        '
        Me.Comentarios_recepcionTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Comentarios_recepcionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "comentarios_recepcion", True))
        Me.Comentarios_recepcionTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comentarios_recepcionTextBox1.Location = New System.Drawing.Point(395, 7)
        Me.Comentarios_recepcionTextBox1.MaxLength = 200
        Me.Comentarios_recepcionTextBox1.Multiline = True
        Me.Comentarios_recepcionTextBox1.Name = "Comentarios_recepcionTextBox1"
        Me.Comentarios_recepcionTextBox1.Size = New System.Drawing.Size(31, 87)
        Me.Comentarios_recepcionTextBox1.TabIndex = 3
        '
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "citas"
        Me.CitasBindingSource.DataSource = Me.ReporteDataSet
        '
        'AsuntoTextBox1
        '
        Me.AsuntoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "asunto", True))
        Me.AsuntoTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsuntoTextBox1.Location = New System.Drawing.Point(12, 32)
        Me.AsuntoTextBox1.MaxLength = 50
        Me.AsuntoTextBox1.Name = "AsuntoTextBox1"
        Me.AsuntoTextBox1.Size = New System.Drawing.Size(248, 26)
        Me.AsuntoTextBox1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(AtendidoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AtendidoCheckBox)
        Me.SplitContainer2.Panel1.Controls.Add(FechaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.FechaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Nombre_agente)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_salir_cita)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Boton_guardar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.nombreprovedor)
        Me.SplitContainer2.Panel1.Controls.Add(TurnoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TurnoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(HoraLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.HoraTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Id_directorioLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_directorioTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(AgenteLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AgenteTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(AsuntoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AsuntoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Comentarios_recepcionLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Comentarios_recepcionTextBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panelalta)
        Me.SplitContainer2.Panel2.Controls.Add(Me.barra1)
        Me.SplitContainer2.Panel2.Controls.Add(Id_directorioLabel1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Id_directorioTextBox1)
        Me.SplitContainer2.Panel2.Controls.Add(NumeroLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.NumeroTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(AgenteLabel1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.AgenteTextBox1)
        Me.SplitContainer2.Panel2.Controls.Add(TelOficinaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TelOficinaTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(TelCelLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TelCelTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Correo1Label)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Correo1TextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Correo2Label)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Correo2TextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Nombre_jefeLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Nombre_jefeTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Telefono_jefeLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Telefono_jefeTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Celular_jefeLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Celular_jefeTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Correo_jefeLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Correo_jefeTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(ComentariosLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ComentariosTextBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(595, 535)
        Me.SplitContainer2.SplitterDistance = 308
        Me.SplitContainer2.TabIndex = 0
        '
        'AtendidoCheckBox
        '
        Me.AtendidoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CitasBindingSource, "atendido", True))
        Me.AtendidoCheckBox.Location = New System.Drawing.Point(72, 318)
        Me.AtendidoCheckBox.Name = "AtendidoCheckBox"
        Me.AtendidoCheckBox.Size = New System.Drawing.Size(35, 24)
        Me.AtendidoCheckBox.TabIndex = 20
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "fecha", True))
        Me.FechaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaTextBox.Location = New System.Drawing.Point(91, 14)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FechaTextBox.TabIndex = 19
        '
        'Nombre_agente
        '
        Me.Nombre_agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_agente.Location = New System.Drawing.Point(129, 119)
        Me.Nombre_agente.Name = "Nombre_agente"
        Me.Nombre_agente.ReadOnly = True
        Me.Nombre_agente.Size = New System.Drawing.Size(303, 24)
        Me.Nombre_agente.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 21)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_salir_cita
        '
        Me.btn_salir_cita.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_salir_cita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir_cita.Location = New System.Drawing.Point(16, 313)
        Me.btn_salir_cita.Name = "btn_salir_cita"
        Me.btn_salir_cita.Size = New System.Drawing.Size(91, 29)
        Me.btn_salir_cita.TabIndex = 16
        Me.btn_salir_cita.Text = "Cancelar"
        Me.btn_salir_cita.UseVisualStyleBackColor = True
        '
        'Boton_guardar
        '
        Me.Boton_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Boton_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_guardar.Location = New System.Drawing.Point(113, 313)
        Me.Boton_guardar.Name = "Boton_guardar"
        Me.Boton_guardar.Size = New System.Drawing.Size(91, 29)
        Me.Boton_guardar.TabIndex = 15
        Me.Boton_guardar.Text = "Guardar"
        Me.Boton_guardar.UseVisualStyleBackColor = True
        '
        'nombreprovedor
        '
        Me.nombreprovedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreprovedor.Location = New System.Drawing.Point(129, 88)
        Me.nombreprovedor.Name = "nombreprovedor"
        Me.nombreprovedor.Size = New System.Drawing.Size(303, 24)
        Me.nombreprovedor.TabIndex = 14
        '
        'TurnoTextBox
        '
        Me.TurnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "turno", True))
        Me.TurnoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnoTextBox.Location = New System.Drawing.Point(91, 46)
        Me.TurnoTextBox.Name = "TurnoTextBox"
        Me.TurnoTextBox.ReadOnly = True
        Me.TurnoTextBox.Size = New System.Drawing.Size(37, 24)
        Me.TurnoTextBox.TabIndex = 3
        '
        'HoraTextBox
        '
        Me.HoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "hora", True))
        Me.HoraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraTextBox.Location = New System.Drawing.Point(182, 43)
        Me.HoraTextBox.MaxLength = 5
        Me.HoraTextBox.Name = "HoraTextBox"
        Me.HoraTextBox.Size = New System.Drawing.Size(55, 24)
        Me.HoraTextBox.TabIndex = 5
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "id_directorio", True))
        Me.Id_directorioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(86, 87)
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(37, 24)
        Me.Id_directorioTextBox.TabIndex = 7
        '
        'AgenteTextBox
        '
        Me.AgenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "agente", True))
        Me.AgenteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgenteTextBox.Location = New System.Drawing.Point(86, 119)
        Me.AgenteTextBox.Name = "AgenteTextBox"
        Me.AgenteTextBox.ReadOnly = True
        Me.AgenteTextBox.Size = New System.Drawing.Size(37, 24)
        Me.AgenteTextBox.TabIndex = 9
        '
        'AsuntoTextBox
        '
        Me.AsuntoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "asunto", True))
        Me.AsuntoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsuntoTextBox.Location = New System.Drawing.Point(89, 157)
        Me.AsuntoTextBox.Name = "AsuntoTextBox"
        Me.AsuntoTextBox.Size = New System.Drawing.Size(366, 24)
        Me.AsuntoTextBox.TabIndex = 11
        '
        'Comentarios_recepcionTextBox
        '
        Me.Comentarios_recepcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "comentarios_recepcion", True))
        Me.Comentarios_recepcionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comentarios_recepcionTextBox.Location = New System.Drawing.Point(16, 217)
        Me.Comentarios_recepcionTextBox.MaxLength = 200
        Me.Comentarios_recepcionTextBox.Multiline = True
        Me.Comentarios_recepcionTextBox.Name = "Comentarios_recepcionTextBox"
        Me.Comentarios_recepcionTextBox.Size = New System.Drawing.Size(439, 95)
        Me.Comentarios_recepcionTextBox.TabIndex = 13
        '
        'Panelalta
        '
        Me.Panelalta.Controls.Add(Me.Button3)
        Me.Panelalta.Controls.Add(Me.btn_canelar_alta_agente)
        Me.Panelalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panelalta.Location = New System.Drawing.Point(218, 373)
        Me.Panelalta.Name = "Panelalta"
        Me.Panelalta.Size = New System.Drawing.Size(220, 34)
        Me.Panelalta.TabIndex = 25
        Me.Panelalta.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(140, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_canelar_alta_agente
        '
        Me.btn_canelar_alta_agente.Location = New System.Drawing.Point(59, 10)
        Me.btn_canelar_alta_agente.Name = "btn_canelar_alta_agente"
        Me.btn_canelar_alta_agente.Size = New System.Drawing.Size(75, 23)
        Me.btn_canelar_alta_agente.TabIndex = 0
        Me.btn_canelar_alta_agente.Text = "Cancel"
        Me.btn_canelar_alta_agente.UseVisualStyleBackColor = True
        '
        'barra1
        '
        Me.barra1.AddNewItem = Nothing
        Me.barra1.BindingSource = Me.AgendaBindingSource
        Me.barra1.CountItem = Me.BindingNavigatorCountItem
        Me.barra1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.barra1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.btn_nuevo_agente})
        Me.barra1.Location = New System.Drawing.Point(0, 508)
        Me.barra1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.barra1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.barra1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.barra1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.barra1.Name = "barra1"
        Me.barra1.PositionItem = Me.BindingNavigatorPositionItem
        Me.barra1.Size = New System.Drawing.Size(281, 25)
        Me.barra1.TabIndex = 24
        Me.barra1.Text = "Agenda"
        '
        'AgendaBindingSource
        '
        Me.AgendaBindingSource.DataMember = "agenda"
        Me.AgendaBindingSource.DataSource = Me.ReporteDataSet
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(70, 20)
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
        'btn_nuevo_agente
        '
        Me.btn_nuevo_agente.Image = CType(resources.GetObject("btn_nuevo_agente.Image"), System.Drawing.Image)
        Me.btn_nuevo_agente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nuevo_agente.Name = "btn_nuevo_agente"
        Me.btn_nuevo_agente.Size = New System.Drawing.Size(103, 20)
        Me.btn_nuevo_agente.Text = "Nuevo Agente"
        '
        'Id_directorioTextBox1
        '
        Me.Id_directorioTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Id_directorio", True))
        Me.Id_directorioTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_directorioTextBox1.Location = New System.Drawing.Point(118, 14)
        Me.Id_directorioTextBox1.Name = "Id_directorioTextBox1"
        Me.Id_directorioTextBox1.ReadOnly = True
        Me.Id_directorioTextBox1.Size = New System.Drawing.Size(36, 24)
        Me.Id_directorioTextBox1.TabIndex = 1
        Me.Id_directorioTextBox1.TabStop = False
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "numero", True))
        Me.NumeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroTextBox.Location = New System.Drawing.Point(241, 14)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.ReadOnly = True
        Me.NumeroTextBox.Size = New System.Drawing.Size(42, 24)
        Me.NumeroTextBox.TabIndex = 3
        Me.NumeroTextBox.TabStop = False
        '
        'AgenteTextBox1
        '
        Me.AgenteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Agente", True))
        Me.AgenteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgenteTextBox1.Location = New System.Drawing.Point(118, 44)
        Me.AgenteTextBox1.MaxLength = 40
        Me.AgenteTextBox1.Name = "AgenteTextBox1"
        Me.AgenteTextBox1.Size = New System.Drawing.Size(322, 24)
        Me.AgenteTextBox1.TabIndex = 5
        '
        'TelOficinaTextBox
        '
        Me.TelOficinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "TelOficina", True))
        Me.TelOficinaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelOficinaTextBox.Location = New System.Drawing.Point(118, 85)
        Me.TelOficinaTextBox.MaxLength = 20
        Me.TelOficinaTextBox.Name = "TelOficinaTextBox"
        Me.TelOficinaTextBox.Size = New System.Drawing.Size(112, 24)
        Me.TelOficinaTextBox.TabIndex = 7
        '
        'TelCelTextBox
        '
        Me.TelCelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "TelCel", True))
        Me.TelCelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelCelTextBox.Location = New System.Drawing.Point(331, 86)
        Me.TelCelTextBox.MaxLength = 20
        Me.TelCelTextBox.Name = "TelCelTextBox"
        Me.TelCelTextBox.Size = New System.Drawing.Size(105, 24)
        Me.TelCelTextBox.TabIndex = 9
        '
        'Correo1TextBox
        '
        Me.Correo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "correo1", True))
        Me.Correo1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo1TextBox.Location = New System.Drawing.Point(118, 113)
        Me.Correo1TextBox.MaxLength = 100
        Me.Correo1TextBox.Name = "Correo1TextBox"
        Me.Correo1TextBox.Size = New System.Drawing.Size(319, 24)
        Me.Correo1TextBox.TabIndex = 11
        '
        'Correo2TextBox
        '
        Me.Correo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "correo2", True))
        Me.Correo2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo2TextBox.Location = New System.Drawing.Point(118, 139)
        Me.Correo2TextBox.MaxLength = 100
        Me.Correo2TextBox.Name = "Correo2TextBox"
        Me.Correo2TextBox.Size = New System.Drawing.Size(319, 24)
        Me.Correo2TextBox.TabIndex = 13
        '
        'Nombre_jefeTextBox
        '
        Me.Nombre_jefeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Nombre_jefe", True))
        Me.Nombre_jefeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_jefeTextBox.Location = New System.Drawing.Point(118, 169)
        Me.Nombre_jefeTextBox.MaxLength = 40
        Me.Nombre_jefeTextBox.Name = "Nombre_jefeTextBox"
        Me.Nombre_jefeTextBox.Size = New System.Drawing.Size(313, 24)
        Me.Nombre_jefeTextBox.TabIndex = 15
        '
        'Telefono_jefeTextBox
        '
        Me.Telefono_jefeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "telefono_jefe", True))
        Me.Telefono_jefeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono_jefeTextBox.Location = New System.Drawing.Point(118, 204)
        Me.Telefono_jefeTextBox.MaxLength = 20
        Me.Telefono_jefeTextBox.Name = "Telefono_jefeTextBox"
        Me.Telefono_jefeTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Telefono_jefeTextBox.TabIndex = 17
        '
        'Celular_jefeTextBox
        '
        Me.Celular_jefeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "celular_jefe", True))
        Me.Celular_jefeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Celular_jefeTextBox.Location = New System.Drawing.Point(315, 205)
        Me.Celular_jefeTextBox.MaxLength = 20
        Me.Celular_jefeTextBox.Name = "Celular_jefeTextBox"
        Me.Celular_jefeTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Celular_jefeTextBox.TabIndex = 19
        '
        'Correo_jefeTextBox
        '
        Me.Correo_jefeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "correo_jefe", True))
        Me.Correo_jefeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo_jefeTextBox.Location = New System.Drawing.Point(114, 235)
        Me.Correo_jefeTextBox.Name = "Correo_jefeTextBox"
        Me.Correo_jefeTextBox.Size = New System.Drawing.Size(322, 24)
        Me.Correo_jefeTextBox.TabIndex = 21
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(114, 265)
        Me.ComentariosTextBox.MaxLength = 200
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(317, 74)
        Me.ComentariosTextBox.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(0, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(988, 86)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Preparando Pedido"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'AgendaTableAdapter
        '
        Me.AgendaTableAdapter.ClearBeforeFill = True
        '
        'Sql_citasTableAdapter
        '
        Me.Sql_citasTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.AdminTegral.My.Resources.Resources.avedesk
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(196, 68)
        Me.ToolStripButton5.Text = "Actualiza Movimientos"
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 606)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Citas"
        Me.Text = "Citas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Sql_citasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_citasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panelalta.ResumeLayout(False)
        CType(Me.barra1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barra1.ResumeLayout(False)
        Me.barra1.PerformLayout()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_borrar_cita As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents CitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CitasTableAdapter As AdminTegral.reporteDataSetTableAdapters.citasTableAdapter
    Friend WithEvents TurnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AsuntoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comentarios_recepcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nombreprovedor As System.Windows.Forms.TextBox
    Friend WithEvents btn_salir_cita As System.Windows.Forms.Button
    Friend WithEvents Boton_guardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Nombre_agente As System.Windows.Forms.TextBox
    Friend WithEvents AgendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgendaTableAdapter As AdminTegral.reporteDataSetTableAdapters.agendaTableAdapter
    Friend WithEvents Id_directorioTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgenteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TelOficinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelCelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_jefeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_jefeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Celular_jefeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_jefeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents barra1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Panelalta As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_canelar_alta_agente As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_agente As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Sql_citasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_citasTableAdapter As AdminTegral.reporteDataSetTableAdapters.sql_citasTableAdapter
    Friend WithEvents Sql_citasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Comentarios_recepcionTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AsuntoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Boton_actualizar As System.Windows.Forms.Button
    Friend WithEvents FechaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_modifica As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Boton_pedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AtendidoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents atendido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class
