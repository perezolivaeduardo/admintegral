<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pedidos_modificar
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim AgenteLabel As System.Windows.Forms.Label
        Dim EnviadoLabel As System.Windows.Forms.Label
        Dim DiasdesurtidoLabel As System.Windows.Forms.Label
        Dim PivaLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pedidos_modificar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Id_pedidoTextBox = New System.Windows.Forms.TextBox
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.provedortxt = New System.Windows.Forms.TextBox
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox
        Me.PivaTextBox = New System.Windows.Forms.TextBox
        Me.DiasdesurtidoTextBox = New System.Windows.Forms.TextBox
        Me.EnviadoCheckBox = New System.Windows.Forms.CheckBox
        Me.AgenteTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox
        Me.ImporteTextBox = New System.Windows.Forms.TextBox
        Me.StatusTextBox = New System.Windows.Forms.TextBox
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.boton_onoff_base = New System.Windows.Forms.ToolStripButton
        Me.boton_sugerir = New System.Windows.Forms.ToolStripButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.boton_imprimir = New System.Windows.Forms.Button
        Me.lblinfo = New System.Windows.Forms.Label
        Me.total = New System.Windows.Forms.TextBox
        Me.boton_cancelar = New System.Windows.Forms.Button
        Me.boto_guardar = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosdetallepedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pedidos_detalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PedidosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.pedidosTableAdapter
        Me.Pedidos_detalleTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Pedidos_detalleTableAdapter
        Me.ProductosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.productosTableAdapter
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.costob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pventab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EUB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VUB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PVC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EUC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VUC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvpedido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Subst = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        FechaLabel = New System.Windows.Forms.Label
        AgenteLabel = New System.Windows.Forms.Label
        EnviadoLabel = New System.Windows.Forms.Label
        DiasdesurtidoLabel = New System.Windows.Forms.Label
        PivaLabel = New System.Windows.Forms.Label
        ComentariosLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdetallepedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pedidos_detalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(31, 34)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 2
        FechaLabel.Text = "fecha:"
        '
        'AgenteLabel
        '
        AgenteLabel.AutoSize = True
        AgenteLabel.Location = New System.Drawing.Point(25, 63)
        AgenteLabel.Name = "AgenteLabel"
        AgenteLabel.Size = New System.Drawing.Size(43, 13)
        AgenteLabel.TabIndex = 5
        AgenteLabel.Text = "agente:"
        '
        'EnviadoLabel
        '
        EnviadoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        EnviadoLabel.AutoSize = True
        EnviadoLabel.Location = New System.Drawing.Point(895, 56)
        EnviadoLabel.Name = "EnviadoLabel"
        EnviadoLabel.Size = New System.Drawing.Size(52, 13)
        EnviadoLabel.TabIndex = 7
        EnviadoLabel.Text = "Enviado :"
        '
        'DiasdesurtidoLabel
        '
        DiasdesurtidoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiasdesurtidoLabel.AutoSize = True
        DiasdesurtidoLabel.Location = New System.Drawing.Point(916, 35)
        DiasdesurtidoLabel.Name = "DiasdesurtidoLabel"
        DiasdesurtidoLabel.Size = New System.Drawing.Size(31, 13)
        DiasdesurtidoLabel.TabIndex = 9
        DiasdesurtidoLabel.Text = "Dias:"
        '
        'PivaLabel
        '
        PivaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PivaLabel.AutoSize = True
        PivaLabel.Location = New System.Drawing.Point(920, 11)
        PivaLabel.Name = "PivaLabel"
        PivaLabel.Size = New System.Drawing.Size(27, 13)
        PivaLabel.TabIndex = 11
        PivaLabel.Text = "IVA:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(614, 19)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(67, 13)
        ComentariosLabel.TabIndex = 13
        ComentariosLabel.Text = "comentarios:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_pedidoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(989, 406)
        Me.SplitContainer1.SplitterDistance = 30
        Me.SplitContainer1.TabIndex = 0
        '
        'Id_pedidoTextBox
        '
        Me.Id_pedidoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Id_pedidoTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Id_pedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "id_pedido", True))
        Me.Id_pedidoTextBox.Enabled = False
        Me.Id_pedidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_pedidoTextBox.Location = New System.Drawing.Point(906, 1)
        Me.Id_pedidoTextBox.Name = "Id_pedidoTextBox"
        Me.Id_pedidoTextBox.Size = New System.Drawing.Size(79, 31)
        Me.Id_pedidoTextBox.TabIndex = 1
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "AdmintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(989, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pedios a Proveedores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer2.Panel1.Controls.Add(Me.provedortxt)
        Me.SplitContainer2.Panel1.Controls.Add(ComentariosLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComentariosTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(PivaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PivaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(DiasdesurtidoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DiasdesurtidoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(EnviadoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.EnviadoCheckBox)
        Me.SplitContainer2.Panel1.Controls.Add(AgenteLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AgenteTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(FechaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_directorioTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ImporteTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.StatusTextBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(989, 372)
        Me.SplitContainer2.SplitterDistance = 86
        Me.SplitContainer2.TabIndex = 0
        '
        'provedortxt
        '
        Me.provedortxt.Location = New System.Drawing.Point(115, 11)
        Me.provedortxt.Name = "provedortxt"
        Me.provedortxt.ReadOnly = True
        Me.provedortxt.Size = New System.Drawing.Size(301, 20)
        Me.provedortxt.TabIndex = 17
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(320, 39)
        Me.ComentariosTextBox.MaxLength = 50
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(534, 47)
        Me.ComentariosTextBox.TabIndex = 14
        '
        'PivaTextBox
        '
        Me.PivaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "piva", True))
        Me.PivaTextBox.Enabled = False
        Me.PivaTextBox.Location = New System.Drawing.Point(953, 8)
        Me.PivaTextBox.Name = "PivaTextBox"
        Me.PivaTextBox.Size = New System.Drawing.Size(24, 20)
        Me.PivaTextBox.TabIndex = 12
        '
        'DiasdesurtidoTextBox
        '
        Me.DiasdesurtidoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiasdesurtidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "Diasdesurtido", True))
        Me.DiasdesurtidoTextBox.Enabled = False
        Me.DiasdesurtidoTextBox.Location = New System.Drawing.Point(953, 31)
        Me.DiasdesurtidoTextBox.Name = "DiasdesurtidoTextBox"
        Me.DiasdesurtidoTextBox.Size = New System.Drawing.Size(24, 20)
        Me.DiasdesurtidoTextBox.TabIndex = 10
        '
        'EnviadoCheckBox
        '
        Me.EnviadoCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnviadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PedidosBindingSource, "enviado", True))
        Me.EnviadoCheckBox.Enabled = False
        Me.EnviadoCheckBox.Location = New System.Drawing.Point(953, 51)
        Me.EnviadoCheckBox.Name = "EnviadoCheckBox"
        Me.EnviadoCheckBox.Size = New System.Drawing.Size(27, 24)
        Me.EnviadoCheckBox.TabIndex = 8
        '
        'AgenteTextBox
        '
        Me.AgenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "agente", True))
        Me.AgenteTextBox.Location = New System.Drawing.Point(74, 62)
        Me.AgenteTextBox.MaxLength = 30
        Me.AgenteTextBox.Name = "AgenteTextBox"
        Me.AgenteTextBox.Size = New System.Drawing.Size(223, 20)
        Me.AgenteTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Provedor :"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(74, 36)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(223, 20)
        Me.FechaDateTimePicker.TabIndex = 3
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "id_directorio", True))
        Me.Id_directorioTextBox.Enabled = False
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(74, 10)
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.ReadOnly = True
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(35, 20)
        Me.Id_directorioTextBox.TabIndex = 2
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "Importe", True))
        Me.ImporteTextBox.Location = New System.Drawing.Point(320, 39)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImporteTextBox.TabIndex = 15
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(320, 57)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(23, 20)
        Me.StatusTextBox.TabIndex = 16
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(989, 282)
        Me.SplitContainer3.SplitterDistance = 36
        Me.SplitContainer3.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_onoff_base, Me.boton_sugerir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(24, 282)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_onoff_base
        '
        Me.boton_onoff_base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_onoff_base.Image = CType(resources.GetObject("boton_onoff_base.Image"), System.Drawing.Image)
        Me.boton_onoff_base.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_onoff_base.Name = "boton_onoff_base"
        Me.boton_onoff_base.Size = New System.Drawing.Size(21, 20)
        Me.boton_onoff_base.Text = "Ver/ocultar BASE"
        Me.boton_onoff_base.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'boton_sugerir
        '
        Me.boton_sugerir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_sugerir.Image = Global.AdminTegral.My.Resources.Resources.Search_1
        Me.boton_sugerir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_sugerir.Name = "boton_sugerir"
        Me.boton_sugerir.Size = New System.Drawing.Size(21, 20)
        Me.boton_sugerir.Text = "Sugeridos"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(949, 282)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.boton_imprimir)
        Me.TabPage1.Controls.Add(Me.lblinfo)
        Me.TabPage1.Controls.Add(Me.total)
        Me.TabPage1.Controls.Add(Me.boton_cancelar)
        Me.TabPage1.Controls.Add(Me.boto_guardar)
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(941, 256)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pedido"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'boton_imprimir
        '
        Me.boton_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_imprimir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.boton_imprimir.Location = New System.Drawing.Point(564, 227)
        Me.boton_imprimir.Name = "boton_imprimir"
        Me.boton_imprimir.Size = New System.Drawing.Size(75, 23)
        Me.boton_imprimir.TabIndex = 5
        Me.boton_imprimir.Text = "Imprimir"
        Me.boton_imprimir.UseVisualStyleBackColor = True
        '
        'lblinfo
        '
        Me.lblinfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Location = New System.Drawing.Point(6, 235)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(39, 13)
        Me.lblinfo.TabIndex = 4
        Me.lblinfo.Text = "Label3"
        '
        'total
        '
        Me.total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(833, 227)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 26)
        Me.total.TabIndex = 3
        Me.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'boton_cancelar
        '
        Me.boton_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_cancelar.Location = New System.Drawing.Point(726, 227)
        Me.boton_cancelar.Name = "boton_cancelar"
        Me.boton_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.boton_cancelar.TabIndex = 2
        Me.boton_cancelar.Text = "Cancelar"
        Me.boton_cancelar.UseVisualStyleBackColor = True
        '
        'boto_guardar
        '
        Me.boto_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boto_guardar.Location = New System.Drawing.Point(645, 227)
        Me.boto_guardar.Name = "boto_guardar"
        Me.boto_guardar.Size = New System.Drawing.Size(75, 23)
        Me.boto_guardar.TabIndex = 1
        Me.boto_guardar.Text = "Guardar"
        Me.boto_guardar.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Descripcion, Me.DataGridViewTextBoxColumn3, Me.costob, Me.pventab, Me.EUB, Me.VUB, Me.FAC, Me.DataGridViewTextBoxColumn9, Me.CC, Me.PVC, Me.EUC, Me.VUC, Me.dgvpedido, Me.dgvcosto, Me.Subst, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn1})
        Me.dgv.DataSource = Me.PedidosdetallepedidosBindingSource
        Me.dgv.Location = New System.Drawing.Point(3, 6)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(930, 215)
        Me.dgv.TabIndex = 0
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'PedidosdetallepedidosBindingSource
        '
        Me.PedidosdetallepedidosBindingSource.DataSource = Me.Pedidos_detalleBindingSource
        '
        'Pedidos_detalleBindingSource
        '
        Me.Pedidos_detalleBindingSource.DataMember = "Pedidos_detalle"
        Me.Pedidos_detalleBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(887, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historial"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'Pedidos_detalleTableAdapter
        '
        Me.Pedidos_detalleTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 41
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Descripcion.DataPropertyName = "id_producto"
        Me.Descripcion.DataSource = Me.ProductosBindingSource
        Me.Descripcion.DisplayMember = "Descripcion"
        Me.Descripcion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Descripcion.DisplayStyleForCurrentCellOnly = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Descripcion.ValueMember = "id_Producto"
        Me.Descripcion.Width = 88
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "uB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Und."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 55
        '
        'costob
        '
        Me.costob.DataPropertyName = "costoB"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.costob.DefaultCellStyle = DataGridViewCellStyle1
        Me.costob.HeaderText = "Costo"
        Me.costob.Name = "costob"
        Me.costob.ReadOnly = True
        Me.costob.Width = 59
        '
        'pventab
        '
        Me.pventab.DataPropertyName = "pventaB"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.pventab.DefaultCellStyle = DataGridViewCellStyle2
        Me.pventab.HeaderText = "Venta"
        Me.pventab.Name = "pventab"
        Me.pventab.ReadOnly = True
        Me.pventab.Width = 60
        '
        'EUB
        '
        Me.EUB.DataPropertyName = "ExistenciaB"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.EUB.DefaultCellStyle = DataGridViewCellStyle3
        Me.EUB.HeaderText = "EUB"
        Me.EUB.Name = "EUB"
        Me.EUB.ReadOnly = True
        Me.EUB.ToolTipText = "Exist. en unidad Base"
        Me.EUB.Width = 54
        '
        'VUB
        '
        Me.VUB.DataPropertyName = "VendidasB"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.VUB.DefaultCellStyle = DataGridViewCellStyle4
        Me.VUB.HeaderText = "VUB"
        Me.VUB.Name = "VUB"
        Me.VUB.ReadOnly = True
        Me.VUB.ToolTipText = "Vendiads Und. Base"
        Me.VUB.Width = 54
        '
        'FAC
        '
        Me.FAC.DataPropertyName = "factorC"
        Me.FAC.HeaderText = "Factor"
        Me.FAC.Name = "FAC"
        Me.FAC.ReadOnly = True
        Me.FAC.Width = 62
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "uC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Und."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 55
        '
        'CC
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CC.DefaultCellStyle = DataGridViewCellStyle5
        Me.CC.HeaderText = "Costo"
        Me.CC.Name = "CC"
        Me.CC.ReadOnly = True
        Me.CC.Width = 59
        '
        'PVC
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PVC.DefaultCellStyle = DataGridViewCellStyle6
        Me.PVC.HeaderText = "P.Venta"
        Me.PVC.Name = "PVC"
        Me.PVC.ReadOnly = True
        Me.PVC.Width = 70
        '
        'EUC
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.EUC.DefaultCellStyle = DataGridViewCellStyle7
        Me.EUC.HeaderText = "Exist"
        Me.EUC.Name = "EUC"
        Me.EUC.ReadOnly = True
        Me.EUC.Width = 54
        '
        'VUC
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.VUC.DefaultCellStyle = DataGridViewCellStyle8
        Me.VUC.HeaderText = "Vend."
        Me.VUC.Name = "VUC"
        Me.VUC.ReadOnly = True
        Me.VUC.ToolTipText = "Vendidas en unidad de Compra"
        Me.VUC.Width = 60
        '
        'dgvpedido
        '
        Me.dgvpedido.DataPropertyName = "pedido"
        Me.dgvpedido.HeaderText = "pedido"
        Me.dgvpedido.Name = "dgvpedido"
        Me.dgvpedido.Width = 64
        '
        'dgvcosto
        '
        Me.dgvcosto.DataPropertyName = "costoPedido"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.dgvcosto.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvcosto.HeaderText = "costoPedido"
        Me.dgvcosto.Name = "dgvcosto"
        Me.dgvcosto.Width = 91
        '
        'Subst
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Subst.DefaultCellStyle = DataGridViewCellStyle10
        Me.Subst.HeaderText = "Sub.Tot."
        Me.Subst.Name = "Subst"
        Me.Subst.ReadOnly = True
        Me.Subst.Width = 73
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "iduC"
        Me.DataGridViewTextBoxColumn8.HeaderText = "iduC"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 53
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Facturado"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Facturado"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "costofactura"
        Me.DataGridViewTextBoxColumn14.HeaderText = "costofactura"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 91
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "entro"
        Me.DataGridViewTextBoxColumn15.HeaderText = "entro"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 56
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "costoentrada"
        Me.DataGridViewTextBoxColumn16.HeaderText = "costoentrada"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 94
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "comentario"
        Me.DataGridViewTextBoxColumn17.HeaderText = "comentario"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 84
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_pedido"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_pedido"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 78
        '
        'pedidos_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_cancelar
        Me.ClientSize = New System.Drawing.Size(989, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "pedidos_modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdetallepedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pedidos_detalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.AdmintegralDataSet
    Friend WithEvents PedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.pedidosTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_pedidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PivaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiasdesurtidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnviadoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AgenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_onoff_base As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Pedidos_detalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pedidos_detalleTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.Pedidos_detalleTableAdapter
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.productosTableAdapter
    Friend WithEvents PedidosdetallepedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents boto_guardar As System.Windows.Forms.Button
    Friend WithEvents boton_cancelar As System.Windows.Forms.Button
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents boton_sugerir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents provedortxt As System.Windows.Forms.TextBox
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents boton_imprimir As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pventab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EUB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VUB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PVC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvpedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subst As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
