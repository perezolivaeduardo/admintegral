<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kardex_consultar
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
        Dim Id_directorioLabel As System.Windows.Forms.Label
        Dim AgenteLabel As System.Windows.Forms.Label
        Dim TelOficinaLabel As System.Windows.Forms.Label
        Dim TelCelLabel As System.Windows.Forms.Label
        Dim Correo1Label As System.Windows.Forms.Label
        Dim Correo2Label As System.Windows.Forms.Label
        Dim Nombre_jefeLabel As System.Windows.Forms.Label
        Dim Telefono_jefeLabel As System.Windows.Forms.Label
        Dim Celular_jefeLabel As System.Windows.Forms.Label
        Dim Correo_jefeLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kardex_consultar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.sql_para_pedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.reporte_ventas_existenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteDataSet = New AdminTegral.reporteDataSet()
        Me.resumen_ventas_existenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.boton_guardar = New System.Windows.Forms.ToolStrip()
        Me.Boton_preparar = New System.Windows.Forms.ToolStripButton()
        Me.boton_ver_grid = New System.Windows.Forms.ToolStripButton()
        Me.Boton_imprimir_conteo = New System.Windows.Forms.ToolStripButton()
        Me.boton_imprimir_pedido = New System.Windows.Forms.ToolStripButton()
        Me.botonguarda = New System.Windows.Forms.ToolStripMenuItem()
        Me.boton_captura = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuspenderArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReActivaArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitAnalisisventas = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.boton_x_proveedor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.combogrupo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.boton_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.dgvendedores = New System.Windows.Forms.DataGridView()
        Me.dgventas = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.AgendaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.boton_agregar_agente = New System.Windows.Forms.ToolStripButton()
        Me.Boton_guardar_cambio = New System.Windows.Forms.ToolStripButton()
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.AgenteTextBox = New System.Windows.Forms.TextBox()
        Me.TelOficinaTextBox = New System.Windows.Forms.TextBox()
        Me.TelCelTextBox = New System.Windows.Forms.TextBox()
        Me.Correo1TextBox = New System.Windows.Forms.TextBox()
        Me.Correo2TextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_jefeTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono_jefeTextBox = New System.Windows.Forms.TextBox()
        Me.Celular_jefeTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_jefeTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btn_preparar = New System.Windows.Forms.Button()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.chkgrupo = New System.Windows.Forms.CheckBox()
        Me.combo_grupos = New System.Windows.Forms.ComboBox()
        Me.nombretxt = New System.Windows.Forms.TextBox()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fecha_al = New System.Windows.Forms.DateTimePicker()
        Me.fecha_del = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RastrearProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_ver = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiezasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiezaXCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiezaXExhibidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExhibidoresXCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostoXPiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostoXExhibidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostoXCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorPiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorexhibidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorCajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarDiseñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcarColumnasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculoAutomaticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.boton_inactivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.agente = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tcajas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ivapv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.iva = New System.Windows.Forms.TextBox()
        Me.subtotal = New System.Windows.Forms.TextBox()
        Me.sql_para_pedidoTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_para_pedidoTableAdapter()
        Me.AgendaTableAdapter = New AdminTegral.reporteDataSetTableAdapters.agendaTableAdapter()
        Me.resumen_ventas_existenciaTableAdapter = New AdminTegral.reporteDataSetTableAdapters.resumen_ventas_existenciaTableAdapter()
        Me.reporte_ventas_existenciaTableAdapter = New AdminTegral.reporteDataSetTableAdapters.reporte_ventas_existenciaTableAdapter()
        Me.rpt_resumen_cobranzaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpt_resumen_cobranzaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_resumen_cobranzaTableAdapter()
        Id_directorioLabel = New System.Windows.Forms.Label()
        AgenteLabel = New System.Windows.Forms.Label()
        TelOficinaLabel = New System.Windows.Forms.Label()
        TelCelLabel = New System.Windows.Forms.Label()
        Correo1Label = New System.Windows.Forms.Label()
        Correo2Label = New System.Windows.Forms.Label()
        Nombre_jefeLabel = New System.Windows.Forms.Label()
        Telefono_jefeLabel = New System.Windows.Forms.Label()
        Celular_jefeLabel = New System.Windows.Forms.Label()
        Correo_jefeLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        CType(Me.sql_para_pedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporte_ventas_existenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resumen_ventas_existenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.boton_guardar.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitAnalisisventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitAnalisisventas.Panel1.SuspendLayout()
        Me.SplitAnalisisventas.Panel2.SuspendLayout()
        Me.SplitAnalisisventas.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.AgendaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.rpt_resumen_cobranzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_directorioLabel
        '
        Id_directorioLabel.AutoSize = True
        Id_directorioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_directorioLabel.Location = New System.Drawing.Point(84, 62)
        Id_directorioLabel.Name = "Id_directorioLabel"
        Id_directorioLabel.Size = New System.Drawing.Size(23, 18)
        Id_directorioLabel.TabIndex = 0
        Id_directorioLabel.Text = "Id:"
        '
        'AgenteLabel
        '
        AgenteLabel.AutoSize = True
        AgenteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgenteLabel.Location = New System.Drawing.Point(50, 95)
        AgenteLabel.Name = "AgenteLabel"
        AgenteLabel.Size = New System.Drawing.Size(57, 18)
        AgenteLabel.TabIndex = 4
        AgenteLabel.Text = "Agente:"
        '
        'TelOficinaLabel
        '
        TelOficinaLabel.AutoSize = True
        TelOficinaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelOficinaLabel.Location = New System.Drawing.Point(25, 121)
        TelOficinaLabel.Name = "TelOficinaLabel"
        TelOficinaLabel.Size = New System.Drawing.Size(82, 18)
        TelOficinaLabel.TabIndex = 6
        TelOficinaLabel.Text = "Tel Oficina:"
        '
        'TelCelLabel
        '
        TelCelLabel.AutoSize = True
        TelCelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelCelLabel.Location = New System.Drawing.Point(231, 121)
        TelCelLabel.Name = "TelCelLabel"
        TelCelLabel.Size = New System.Drawing.Size(58, 18)
        TelCelLabel.TabIndex = 8
        TelCelLabel.Text = "Tel Cel:"
        '
        'Correo1Label
        '
        Correo1Label.AutoSize = True
        Correo1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo1Label.Location = New System.Drawing.Point(43, 152)
        Correo1Label.Name = "Correo1Label"
        Correo1Label.Size = New System.Drawing.Size(67, 18)
        Correo1Label.TabIndex = 10
        Correo1Label.Text = "Correo1:"
        '
        'Correo2Label
        '
        Correo2Label.AutoSize = True
        Correo2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo2Label.Location = New System.Drawing.Point(43, 178)
        Correo2Label.Name = "Correo2Label"
        Correo2Label.Size = New System.Drawing.Size(67, 18)
        Correo2Label.TabIndex = 12
        Correo2Label.Text = "Correo2:"
        '
        'Nombre_jefeLabel
        '
        Nombre_jefeLabel.AutoSize = True
        Nombre_jefeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_jefeLabel.Location = New System.Drawing.Point(14, 221)
        Nombre_jefeLabel.Name = "Nombre_jefeLabel"
        Nombre_jefeLabel.Size = New System.Drawing.Size(93, 18)
        Nombre_jefeLabel.TabIndex = 14
        Nombre_jefeLabel.Text = "Nombre jefe:"
        '
        'Telefono_jefeLabel
        '
        Telefono_jefeLabel.AutoSize = True
        Telefono_jefeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefono_jefeLabel.Location = New System.Drawing.Point(15, 251)
        Telefono_jefeLabel.Name = "Telefono_jefeLabel"
        Telefono_jefeLabel.Size = New System.Drawing.Size(97, 18)
        Telefono_jefeLabel.TabIndex = 16
        Telefono_jefeLabel.Text = "Telefono jefe:"
        '
        'Celular_jefeLabel
        '
        Celular_jefeLabel.AutoSize = True
        Celular_jefeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Celular_jefeLabel.Location = New System.Drawing.Point(264, 251)
        Celular_jefeLabel.Name = "Celular_jefeLabel"
        Celular_jefeLabel.Size = New System.Drawing.Size(85, 18)
        Celular_jefeLabel.TabIndex = 18
        Celular_jefeLabel.Text = "Celular jefe:"
        '
        'Correo_jefeLabel
        '
        Correo_jefeLabel.AutoSize = True
        Correo_jefeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo_jefeLabel.Location = New System.Drawing.Point(24, 281)
        Correo_jefeLabel.Name = "Correo_jefeLabel"
        Correo_jefeLabel.Size = New System.Drawing.Size(86, 18)
        Correo_jefeLabel.TabIndex = 20
        Correo_jefeLabel.Text = "Correo jefe:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentariosLabel.Location = New System.Drawing.Point(12, 311)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(95, 18)
        ComentariosLabel.TabIndex = 22
        ComentariosLabel.Text = "comentarios:"
        '
        'sql_para_pedidoBindingSource
        '
        Me.sql_para_pedidoBindingSource.DataMember = "sql_para_pedido"
        Me.sql_para_pedidoBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reporte_ventas_existenciaBindingSource
        '
        Me.reporte_ventas_existenciaBindingSource.DataMember = "reporte_ventas_existencia"
        Me.reporte_ventas_existenciaBindingSource.DataSource = Me.ReporteDataSet
        '
        'ReporteDataSet
        '
        Me.ReporteDataSet.DataSetName = "reporteDataSet"
        Me.ReporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'resumen_ventas_existenciaBindingSource
        '
        Me.resumen_ventas_existenciaBindingSource.DataMember = "resumen_ventas_existencia"
        Me.resumen_ventas_existenciaBindingSource.DataSource = Me.ReporteDataSet
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 104)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 512)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(966, 486)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pedido"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_guardar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer)
        Me.SplitContainer1.Size = New System.Drawing.Size(960, 480)
        Me.SplitContainer1.SplitterDistance = 29
        Me.SplitContainer1.TabIndex = 0
        '
        'boton_guardar
        '
        Me.boton_guardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boton_guardar.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.boton_guardar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Boton_preparar, Me.boton_ver_grid, Me.Boton_imprimir_conteo, Me.boton_imprimir_pedido, Me.botonguarda, Me.boton_captura, Me.ToolStripButton3})
        Me.boton_guardar.Location = New System.Drawing.Point(0, 0)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(960, 29)
        Me.boton_guardar.TabIndex = 8
        Me.boton_guardar.Text = "ToolStrip2"
        '
        'Boton_preparar
        '
        Me.Boton_preparar.Enabled = False
        Me.Boton_preparar.Image = CType(resources.GetObject("Boton_preparar.Image"), System.Drawing.Image)
        Me.Boton_preparar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_preparar.Name = "Boton_preparar"
        Me.Boton_preparar.Size = New System.Drawing.Size(127, 26)
        Me.Boton_preparar.Text = "Preparar Pedido"
        '
        'boton_ver_grid
        '
        Me.boton_ver_grid.Image = CType(resources.GetObject("boton_ver_grid.Image"), System.Drawing.Image)
        Me.boton_ver_grid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_ver_grid.Name = "boton_ver_grid"
        Me.boton_ver_grid.Size = New System.Drawing.Size(88, 26)
        Me.boton_ver_grid.Text = "Ver tabla"
        Me.boton_ver_grid.Visible = False
        '
        'Boton_imprimir_conteo
        '
        Me.Boton_imprimir_conteo.Image = CType(resources.GetObject("Boton_imprimir_conteo.Image"), System.Drawing.Image)
        Me.Boton_imprimir_conteo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_imprimir_conteo.Name = "Boton_imprimir_conteo"
        Me.Boton_imprimir_conteo.Size = New System.Drawing.Size(155, 26)
        Me.Boton_imprimir_conteo.Text = "Hoja para Inventarios"
        Me.Boton_imprimir_conteo.Visible = False
        '
        'boton_imprimir_pedido
        '
        Me.boton_imprimir_pedido.Image = CType(resources.GetObject("boton_imprimir_pedido.Image"), System.Drawing.Image)
        Me.boton_imprimir_pedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_imprimir_pedido.Name = "boton_imprimir_pedido"
        Me.boton_imprimir_pedido.Size = New System.Drawing.Size(129, 26)
        Me.boton_imprimir_pedido.Text = "Imprimir Pedido"
        Me.boton_imprimir_pedido.Visible = False
        '
        'botonguarda
        '
        Me.botonguarda.Image = CType(resources.GetObject("botonguarda.Image"), System.Drawing.Image)
        Me.botonguarda.Name = "botonguarda"
        Me.botonguarda.Size = New System.Drawing.Size(133, 29)
        Me.botonguarda.Text = "Guardar Pedido"
        Me.botonguarda.Visible = False
        '
        'boton_captura
        '
        Me.boton_captura.Image = CType(resources.GetObject("boton_captura.Image"), System.Drawing.Image)
        Me.boton_captura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_captura.Name = "boton_captura"
        Me.boton_captura.Size = New System.Drawing.Size(129, 26)
        Me.boton_captura.Text = "Capturar Pedido"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 26)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv.Location = New System.Drawing.Point(-3, -1)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv.Size = New System.Drawing.Size(960, 362)
        Me.dgv.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuspenderArticuloToolStripMenuItem, Me.ReActivaArticuloToolStripMenuItem, Me.VerEntradasToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 70)
        '
        'SuspenderArticuloToolStripMenuItem
        '
        Me.SuspenderArticuloToolStripMenuItem.Name = "SuspenderArticuloToolStripMenuItem"
        Me.SuspenderArticuloToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SuspenderArticuloToolStripMenuItem.Text = "Suspender Articulo"
        '
        'ReActivaArticuloToolStripMenuItem
        '
        Me.ReActivaArticuloToolStripMenuItem.Name = "ReActivaArticuloToolStripMenuItem"
        Me.ReActivaArticuloToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ReActivaArticuloToolStripMenuItem.Text = "Re Activa Articulo"
        '
        'VerEntradasToolStripMenuItem
        '
        Me.VerEntradasToolStripMenuItem.Name = "VerEntradasToolStripMenuItem"
        Me.VerEntradasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.VerEntradasToolStripMenuItem.Text = "Ver Entradas"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "tablapedido"
        ReportDataSource1.Value = Me.sql_para_pedidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.pedido.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(960, 362)
        Me.ReportViewer1.TabIndex = 2
        Me.ReportViewer1.Visible = False
        '
        'ReportViewer
        '
        Me.ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "tablapedido"
        ReportDataSource2.Value = Me.sql_para_pedidoBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "AdminTegral.ped_hojadeconteo.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, -1)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(960, 362)
        Me.ReportViewer.TabIndex = 0
        Me.ReportViewer.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitAnalisisventas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(966, 486)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Analisis de Ventas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitAnalisisventas
        '
        Me.SplitAnalisisventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitAnalisisventas.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitAnalisisventas.Location = New System.Drawing.Point(0, 0)
        Me.SplitAnalisisventas.Name = "SplitAnalisisventas"
        Me.SplitAnalisisventas.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitAnalisisventas.Panel1
        '
        Me.SplitAnalisisventas.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitAnalisisventas.Panel2
        '
        Me.SplitAnalisisventas.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitAnalisisventas.Size = New System.Drawing.Size(966, 486)
        Me.SplitAnalisisventas.SplitterDistance = 44
        Me.SplitAnalisisventas.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_x_proveedor, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.combogrupo, Me.ToolStripButton2, Me.boton_Exportar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(966, 44)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'boton_x_proveedor
        '
        Me.boton_x_proveedor.Image = CType(resources.GetObject("boton_x_proveedor.Image"), System.Drawing.Image)
        Me.boton_x_proveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_x_proveedor.Name = "boton_x_proveedor"
        Me.boton_x_proveedor.Size = New System.Drawing.Size(158, 41)
        Me.boton_x_proveedor.Text = "Resumen x Proveedor"
        Me.boton_x_proveedor.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(142, 41)
        Me.ToolStripButton1.Text = "Calcular por grupo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 44)
        '
        'combogrupo
        '
        Me.combogrupo.Name = "combogrupo"
        Me.combogrupo.Size = New System.Drawing.Size(160, 23)
        Me.combogrupo.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(89, 41)
        Me.ToolStripButton2.Text = "Imprimir"
        Me.ToolStripButton2.Visible = False
        '
        'boton_Exportar
        '
        Me.boton_Exportar.Image = CType(resources.GetObject("boton_Exportar.Image"), System.Drawing.Image)
        Me.boton_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_Exportar.Name = "boton_Exportar"
        Me.boton_Exportar.Size = New System.Drawing.Size(87, 41)
        Me.boton_Exportar.Text = "Exportar"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvendedores)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgventas)
        Me.SplitContainer2.Size = New System.Drawing.Size(966, 438)
        Me.SplitContainer2.SplitterDistance = 400
        Me.SplitContainer2.TabIndex = 0
        '
        'dgvendedores
        '
        Me.dgvendedores.AllowUserToAddRows = False
        Me.dgvendedores.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvendedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvendedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvendedores.Location = New System.Drawing.Point(0, 0)
        Me.dgvendedores.Name = "dgvendedores"
        Me.dgvendedores.ReadOnly = True
        Me.dgvendedores.RowHeadersVisible = False
        Me.dgvendedores.Size = New System.Drawing.Size(400, 438)
        Me.dgvendedores.TabIndex = 0
        '
        'dgventas
        '
        Me.dgventas.AllowUserToAddRows = False
        Me.dgventas.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        Me.dgventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgventas.Location = New System.Drawing.Point(0, 0)
        Me.dgventas.Name = "dgventas"
        Me.dgventas.ReadOnly = True
        Me.dgventas.RowHeadersVisible = False
        Me.dgventas.Size = New System.Drawing.Size(562, 438)
        Me.dgventas.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage3.Controls.Add(Me.SplitContainer3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(966, 486)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Directorio de Agente"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.AgendaDataGridView)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer3.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.SplitContainer3.Panel2.Controls.Add(Id_directorioLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Id_directorioTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Me.NumeroTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(AgenteLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.AgenteTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(TelOficinaLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.TelOficinaTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(TelCelLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.TelCelTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Correo1Label)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Correo1TextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Correo2Label)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Correo2TextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Nombre_jefeLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Nombre_jefeTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Telefono_jefeLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Telefono_jefeTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Celular_jefeLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Celular_jefeTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Correo_jefeLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Correo_jefeTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(ComentariosLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ComentariosTextBox)
        Me.SplitContainer3.Size = New System.Drawing.Size(960, 480)
        Me.SplitContainer3.SplitterDistance = 415
        Me.SplitContainer3.TabIndex = 0
        '
        'AgendaDataGridView
        '
        Me.AgendaDataGridView.AllowUserToAddRows = False
        Me.AgendaDataGridView.AllowUserToDeleteRows = False
        Me.AgendaDataGridView.AllowUserToResizeColumns = False
        Me.AgendaDataGridView.AllowUserToResizeRows = False
        Me.AgendaDataGridView.AutoGenerateColumns = False
        Me.AgendaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AgendaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.AgendaDataGridView.DataSource = Me.AgendaBindingSource
        Me.AgendaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgendaDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.AgendaDataGridView.Name = "AgendaDataGridView"
        Me.AgendaDataGridView.ReadOnly = True
        Me.AgendaDataGridView.RowHeadersVisible = False
        Me.AgendaDataGridView.Size = New System.Drawing.Size(415, 480)
        Me.AgendaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_directorio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pv"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "numero"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 41
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Agente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Agente"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 40
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'AgendaBindingSource
        '
        Me.AgendaBindingSource.DataMember = "agenda"
        Me.AgendaBindingSource.DataSource = Me.ReporteDataSet
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(541, 43)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "AGENDA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.boton_agregar_agente, Me.Boton_guardar_cambio})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 441)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(541, 39)
        Me.BindingNavigator1.TabIndex = 24
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 36)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 39)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'boton_agregar_agente
        '
        Me.boton_agregar_agente.Image = CType(resources.GetObject("boton_agregar_agente.Image"), System.Drawing.Image)
        Me.boton_agregar_agente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_agregar_agente.Name = "boton_agregar_agente"
        Me.boton_agregar_agente.Size = New System.Drawing.Size(126, 36)
        Me.boton_agregar_agente.Text = "Agregar Agente"
        '
        'Boton_guardar_cambio
        '
        Me.Boton_guardar_cambio.Image = CType(resources.GetObject("Boton_guardar_cambio.Image"), System.Drawing.Image)
        Me.Boton_guardar_cambio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Boton_guardar_cambio.Name = "Boton_guardar_cambio"
        Me.Boton_guardar_cambio.Size = New System.Drawing.Size(135, 36)
        Me.Boton_guardar_cambio.Text = "Guardar_cambios"
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Id_directorio", True))
        Me.Id_directorioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(117, 62)
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(33, 24)
        Me.Id_directorioTextBox.TabIndex = 1
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "numero", True))
        Me.NumeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroTextBox.Location = New System.Drawing.Point(156, 62)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(61, 24)
        Me.NumeroTextBox.TabIndex = 3
        '
        'AgenteTextBox
        '
        Me.AgenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Agente", True))
        Me.AgenteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgenteTextBox.Location = New System.Drawing.Point(117, 92)
        Me.AgenteTextBox.MaxLength = 40
        Me.AgenteTextBox.Name = "AgenteTextBox"
        Me.AgenteTextBox.Size = New System.Drawing.Size(395, 24)
        Me.AgenteTextBox.TabIndex = 5
        '
        'TelOficinaTextBox
        '
        Me.TelOficinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "TelOficina", True))
        Me.TelOficinaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelOficinaTextBox.Location = New System.Drawing.Point(117, 118)
        Me.TelOficinaTextBox.MaxLength = 15
        Me.TelOficinaTextBox.Name = "TelOficinaTextBox"
        Me.TelOficinaTextBox.Size = New System.Drawing.Size(100, 24)
        Me.TelOficinaTextBox.TabIndex = 7
        '
        'TelCelTextBox
        '
        Me.TelCelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "TelCel", True))
        Me.TelCelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelCelTextBox.Location = New System.Drawing.Point(299, 118)
        Me.TelCelTextBox.MaxLength = 15
        Me.TelCelTextBox.Name = "TelCelTextBox"
        Me.TelCelTextBox.Size = New System.Drawing.Size(100, 24)
        Me.TelCelTextBox.TabIndex = 9
        '
        'Correo1TextBox
        '
        Me.Correo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "correo1", True))
        Me.Correo1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo1TextBox.Location = New System.Drawing.Point(117, 149)
        Me.Correo1TextBox.MaxLength = 100
        Me.Correo1TextBox.Name = "Correo1TextBox"
        Me.Correo1TextBox.Size = New System.Drawing.Size(395, 24)
        Me.Correo1TextBox.TabIndex = 11
        '
        'Correo2TextBox
        '
        Me.Correo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "correo2", True))
        Me.Correo2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo2TextBox.Location = New System.Drawing.Point(117, 175)
        Me.Correo2TextBox.MaxLength = 100
        Me.Correo2TextBox.Name = "Correo2TextBox"
        Me.Correo2TextBox.Size = New System.Drawing.Size(395, 24)
        Me.Correo2TextBox.TabIndex = 13
        '
        'Nombre_jefeTextBox
        '
        Me.Nombre_jefeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Nombre_jefe", True))
        Me.Nombre_jefeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_jefeTextBox.Location = New System.Drawing.Point(117, 218)
        Me.Nombre_jefeTextBox.MaxLength = 40
        Me.Nombre_jefeTextBox.Name = "Nombre_jefeTextBox"
        Me.Nombre_jefeTextBox.Size = New System.Drawing.Size(395, 24)
        Me.Nombre_jefeTextBox.TabIndex = 15
        '
        'Telefono_jefeTextBox
        '
        Me.Telefono_jefeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "telefono_jefe", True))
        Me.Telefono_jefeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono_jefeTextBox.Location = New System.Drawing.Point(117, 248)
        Me.Telefono_jefeTextBox.MaxLength = 15
        Me.Telefono_jefeTextBox.Name = "Telefono_jefeTextBox"
        Me.Telefono_jefeTextBox.Size = New System.Drawing.Size(117, 24)
        Me.Telefono_jefeTextBox.TabIndex = 17
        '
        'Celular_jefeTextBox
        '
        Me.Celular_jefeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "celular_jefe", True))
        Me.Celular_jefeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Celular_jefeTextBox.Location = New System.Drawing.Point(356, 248)
        Me.Celular_jefeTextBox.MaxLength = 15
        Me.Celular_jefeTextBox.Name = "Celular_jefeTextBox"
        Me.Celular_jefeTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Celular_jefeTextBox.TabIndex = 19
        '
        'Correo_jefeTextBox
        '
        Me.Correo_jefeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "correo_jefe", True))
        Me.Correo_jefeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo_jefeTextBox.Location = New System.Drawing.Point(117, 278)
        Me.Correo_jefeTextBox.MaxLength = 100
        Me.Correo_jefeTextBox.Name = "Correo_jefeTextBox"
        Me.Correo_jefeTextBox.Size = New System.Drawing.Size(395, 24)
        Me.Correo_jefeTextBox.TabIndex = 21
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(117, 308)
        Me.ComentariosTextBox.MaxLength = 100
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(395, 63)
        Me.ComentariosTextBox.TabIndex = 23
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btn_preparar)
        Me.TabPage4.Controls.Add(Me.ReportViewer2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(966, 486)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Ventas por Tienda"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btn_preparar
        '
        Me.btn_preparar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_preparar.Location = New System.Drawing.Point(888, 455)
        Me.btn_preparar.Name = "btn_preparar"
        Me.btn_preparar.Size = New System.Drawing.Size(75, 23)
        Me.btn_preparar.TabIndex = 1
        Me.btn_preparar.Text = "Preparar"
        Me.btn_preparar.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource3.Name = "reporteDataSet_reporte_ventas_existencia"
        ReportDataSource3.Value = Me.reporte_ventas_existenciaBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "AdminTegral.reporte_ventas_existencia.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 6)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(960, 444)
        Me.ReportViewer2.TabIndex = 0
        '
        'chkgrupo
        '
        Me.chkgrupo.AutoSize = True
        Me.chkgrupo.Location = New System.Drawing.Point(13, 45)
        Me.chkgrupo.Name = "chkgrupo"
        Me.chkgrupo.Size = New System.Drawing.Size(55, 17)
        Me.chkgrupo.TabIndex = 8
        Me.chkgrupo.Text = "Grupo"
        Me.chkgrupo.UseVisualStyleBackColor = True
        '
        'combo_grupos
        '
        Me.combo_grupos.FormattingEnabled = True
        Me.combo_grupos.Location = New System.Drawing.Point(68, 45)
        Me.combo_grupos.Name = "combo_grupos"
        Me.combo_grupos.Size = New System.Drawing.Size(320, 21)
        Me.combo_grupos.TabIndex = 5
        Me.combo_grupos.Visible = False
        '
        'nombretxt
        '
        Me.nombretxt.Enabled = False
        Me.nombretxt.Location = New System.Drawing.Point(68, 19)
        Me.nombretxt.Name = "nombretxt"
        Me.nombretxt.Size = New System.Drawing.Size(320, 20)
        Me.nombretxt.TabIndex = 4
        Me.nombretxt.TabStop = False
        '
        'id_txt
        '
        Me.id_txt.Location = New System.Drawing.Point(16, 19)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(46, 20)
        Me.id_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periodo :"
        '
        'fecha_al
        '
        Me.fecha_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_al.Location = New System.Drawing.Point(571, 19)
        Me.fecha_al.Name = "fecha_al"
        Me.fecha_al.Size = New System.Drawing.Size(101, 20)
        Me.fecha_al.TabIndex = 2
        '
        'fecha_del
        '
        Me.fecha_del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_del.Location = New System.Drawing.Point(464, 19)
        Me.fecha_del.Name = "fecha_del"
        Me.fecha_del.Size = New System.Drawing.Size(101, 20)
        Me.fecha_del.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.menu_ver, Me.boton_inactivos})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RastrearProveedorToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.ToolStripSeparator4, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RastrearProveedorToolStripMenuItem
        '
        Me.RastrearProveedorToolStripMenuItem.Name = "RastrearProveedorToolStripMenuItem"
        Me.RastrearProveedorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.RastrearProveedorToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RastrearProveedorToolStripMenuItem.Text = "Rastrear proveedor"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AbrirToolStripMenuItem.Text = "&Abrir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(189, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'menu_ver
        '
        Me.menu_ver.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdGrupoToolStripMenuItem, Me.GrupoToolStripMenuItem, Me.PiezasToolStripMenuItem, Me.CostoToolStripMenuItem, Me.PreciosDeVentaToolStripMenuItem, Me.ToolStripSeparator1, Me.GuardarDiseñoToolStripMenuItem, Me.MarcarColumnasToolStripMenuItem, Me.CalculoAutomaticoToolStripMenuItem})
        Me.menu_ver.Name = "menu_ver"
        Me.menu_ver.Size = New System.Drawing.Size(35, 20)
        Me.menu_ver.Text = "Ver"
        '
        'IdGrupoToolStripMenuItem
        '
        Me.IdGrupoToolStripMenuItem.CheckOnClick = True
        Me.IdGrupoToolStripMenuItem.Name = "IdGrupoToolStripMenuItem"
        Me.IdGrupoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IdGrupoToolStripMenuItem.Text = "id_Grupo"
        '
        'GrupoToolStripMenuItem
        '
        Me.GrupoToolStripMenuItem.Checked = True
        Me.GrupoToolStripMenuItem.CheckOnClick = True
        Me.GrupoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GrupoToolStripMenuItem.Name = "GrupoToolStripMenuItem"
        Me.GrupoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GrupoToolStripMenuItem.Text = "Grupo"
        '
        'PiezasToolStripMenuItem
        '
        Me.PiezasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PiezaXCajaToolStripMenuItem, Me.PiezaXExhibidorToolStripMenuItem, Me.ExhibidoresXCajaToolStripMenuItem})
        Me.PiezasToolStripMenuItem.Name = "PiezasToolStripMenuItem"
        Me.PiezasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PiezasToolStripMenuItem.Text = "Piezas"
        '
        'PiezaXCajaToolStripMenuItem
        '
        Me.PiezaXCajaToolStripMenuItem.Checked = True
        Me.PiezaXCajaToolStripMenuItem.CheckOnClick = True
        Me.PiezaXCajaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PiezaXCajaToolStripMenuItem.Name = "PiezaXCajaToolStripMenuItem"
        Me.PiezaXCajaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PiezaXCajaToolStripMenuItem.Text = "Pieza x Caja"
        '
        'PiezaXExhibidorToolStripMenuItem
        '
        Me.PiezaXExhibidorToolStripMenuItem.Checked = True
        Me.PiezaXExhibidorToolStripMenuItem.CheckOnClick = True
        Me.PiezaXExhibidorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PiezaXExhibidorToolStripMenuItem.DoubleClickEnabled = True
        Me.PiezaXExhibidorToolStripMenuItem.Name = "PiezaXExhibidorToolStripMenuItem"
        Me.PiezaXExhibidorToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PiezaXExhibidorToolStripMenuItem.Text = "Pieza x Exhibidor"
        '
        'ExhibidoresXCajaToolStripMenuItem
        '
        Me.ExhibidoresXCajaToolStripMenuItem.CheckOnClick = True
        Me.ExhibidoresXCajaToolStripMenuItem.Name = "ExhibidoresXCajaToolStripMenuItem"
        Me.ExhibidoresXCajaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExhibidoresXCajaToolStripMenuItem.Text = "Exhibidores X Caja"
        '
        'CostoToolStripMenuItem
        '
        Me.CostoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CostoXPiezaToolStripMenuItem, Me.CostoXExhibidorToolStripMenuItem, Me.CostoXCajaToolStripMenuItem})
        Me.CostoToolStripMenuItem.Name = "CostoToolStripMenuItem"
        Me.CostoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CostoToolStripMenuItem.Text = "Costo"
        '
        'CostoXPiezaToolStripMenuItem
        '
        Me.CostoXPiezaToolStripMenuItem.Checked = True
        Me.CostoXPiezaToolStripMenuItem.CheckOnClick = True
        Me.CostoXPiezaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CostoXPiezaToolStripMenuItem.Name = "CostoXPiezaToolStripMenuItem"
        Me.CostoXPiezaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CostoXPiezaToolStripMenuItem.Text = "Costo x Pieza"
        '
        'CostoXExhibidorToolStripMenuItem
        '
        Me.CostoXExhibidorToolStripMenuItem.CheckOnClick = True
        Me.CostoXExhibidorToolStripMenuItem.Name = "CostoXExhibidorToolStripMenuItem"
        Me.CostoXExhibidorToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CostoXExhibidorToolStripMenuItem.Text = "Costo x Exhibidor"
        '
        'CostoXCajaToolStripMenuItem
        '
        Me.CostoXCajaToolStripMenuItem.Checked = True
        Me.CostoXCajaToolStripMenuItem.CheckOnClick = True
        Me.CostoXCajaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CostoXCajaToolStripMenuItem.Name = "CostoXCajaToolStripMenuItem"
        Me.CostoXCajaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CostoXCajaToolStripMenuItem.Text = "Costo x Caja"
        '
        'PreciosDeVentaToolStripMenuItem
        '
        Me.PreciosDeVentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorPiezaToolStripMenuItem, Me.PorexhibidorToolStripMenuItem, Me.PorCajaToolStripMenuItem1})
        Me.PreciosDeVentaToolStripMenuItem.Name = "PreciosDeVentaToolStripMenuItem"
        Me.PreciosDeVentaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreciosDeVentaToolStripMenuItem.Text = "Precios de Venta"
        '
        'PorPiezaToolStripMenuItem
        '
        Me.PorPiezaToolStripMenuItem.Checked = True
        Me.PorPiezaToolStripMenuItem.CheckOnClick = True
        Me.PorPiezaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PorPiezaToolStripMenuItem.Name = "PorPiezaToolStripMenuItem"
        Me.PorPiezaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PorPiezaToolStripMenuItem.Text = "Por Pieza"
        '
        'PorexhibidorToolStripMenuItem
        '
        Me.PorexhibidorToolStripMenuItem.Checked = True
        Me.PorexhibidorToolStripMenuItem.CheckOnClick = True
        Me.PorexhibidorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PorexhibidorToolStripMenuItem.Name = "PorexhibidorToolStripMenuItem"
        Me.PorexhibidorToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PorexhibidorToolStripMenuItem.Text = "Por  Exhibidor"
        '
        'PorCajaToolStripMenuItem1
        '
        Me.PorCajaToolStripMenuItem1.CheckOnClick = True
        Me.PorCajaToolStripMenuItem1.Name = "PorCajaToolStripMenuItem1"
        Me.PorCajaToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.PorCajaToolStripMenuItem1.Text = "Por Caja"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'GuardarDiseñoToolStripMenuItem
        '
        Me.GuardarDiseñoToolStripMenuItem.Name = "GuardarDiseñoToolStripMenuItem"
        Me.GuardarDiseñoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GuardarDiseñoToolStripMenuItem.Text = "Guardar Diseño"
        '
        'MarcarColumnasToolStripMenuItem
        '
        Me.MarcarColumnasToolStripMenuItem.Name = "MarcarColumnasToolStripMenuItem"
        Me.MarcarColumnasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarcarColumnasToolStripMenuItem.Text = "Marcar Columnas"
        '
        'CalculoAutomaticoToolStripMenuItem
        '
        Me.CalculoAutomaticoToolStripMenuItem.Checked = True
        Me.CalculoAutomaticoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CalculoAutomaticoToolStripMenuItem.Name = "CalculoAutomaticoToolStripMenuItem"
        Me.CalculoAutomaticoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculoAutomaticoToolStripMenuItem.Text = "Calculo Automatico"
        '
        'boton_inactivos
        '
        Me.boton_inactivos.Enabled = False
        Me.boton_inactivos.Name = "boton_inactivos"
        Me.boton_inactivos.Size = New System.Drawing.Size(128, 20)
        Me.boton_inactivos.Text = "Articulos INACTIVOS"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.agente)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.chkgrupo)
        Me.Panel1.Controls.Add(Me.nombretxt)
        Me.Panel1.Controls.Add(Me.fecha_del)
        Me.Panel1.Controls.Add(Me.combo_grupos)
        Me.Panel1.Controls.Add(Me.fecha_al)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.id_txt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 74)
        Me.Panel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Agente :"
        '
        'agente
        '
        Me.agente.Location = New System.Drawing.Point(464, 50)
        Me.agente.MaxLength = 30
        Me.agente.Name = "agente"
        Me.agente.Size = New System.Drawing.Size(208, 20)
        Me.agente.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.tcajas)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ivapv)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.total)
        Me.Panel2.Controls.Add(Me.iva)
        Me.Panel2.Controls.Add(Me.subtotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(684, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 74)
        Me.Panel2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CAJAS"
        '
        'tcajas
        '
        Me.tcajas.Location = New System.Drawing.Point(14, 51)
        Me.tcajas.Name = "tcajas"
        Me.tcajas.Size = New System.Drawing.Size(64, 20)
        Me.tcajas.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total :"
        '
        'ivapv
        '
        Me.ivapv.BackColor = System.Drawing.Color.AliceBlue
        Me.ivapv.Enabled = False
        Me.ivapv.ForeColor = System.Drawing.Color.Black
        Me.ivapv.Location = New System.Drawing.Point(103, 25)
        Me.ivapv.Name = "ivapv"
        Me.ivapv.Size = New System.Drawing.Size(34, 20)
        Me.ivapv.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(141, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "IVA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sub-Total :"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.AliceBlue
        Me.total.Enabled = False
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.Color.Black
        Me.total.Location = New System.Drawing.Point(179, 49)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(105, 22)
        Me.total.TabIndex = 2
        Me.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'iva
        '
        Me.iva.BackColor = System.Drawing.Color.AliceBlue
        Me.iva.Enabled = False
        Me.iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iva.ForeColor = System.Drawing.Color.Black
        Me.iva.Location = New System.Drawing.Point(179, 25)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(104, 22)
        Me.iva.TabIndex = 1
        Me.iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'subtotal
        '
        Me.subtotal.BackColor = System.Drawing.Color.AliceBlue
        Me.subtotal.Enabled = False
        Me.subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.ForeColor = System.Drawing.Color.Black
        Me.subtotal.Location = New System.Drawing.Point(179, 2)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(104, 22)
        Me.subtotal.TabIndex = 0
        Me.subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'sql_para_pedidoTableAdapter
        '
        Me.sql_para_pedidoTableAdapter.ClearBeforeFill = True
        '
        'AgendaTableAdapter
        '
        Me.AgendaTableAdapter.ClearBeforeFill = True
        '
        'resumen_ventas_existenciaTableAdapter
        '
        Me.resumen_ventas_existenciaTableAdapter.ClearBeforeFill = True
        '
        'reporte_ventas_existenciaTableAdapter
        '
        Me.reporte_ventas_existenciaTableAdapter.ClearBeforeFill = True
        '
        'rpt_resumen_cobranzaBindingSource
        '
        Me.rpt_resumen_cobranzaBindingSource.DataMember = "rpt_resumen_cobranza"
        Me.rpt_resumen_cobranzaBindingSource.DataSource = Me.admintegralDataSet
        '
        'rpt_resumen_cobranzaTableAdapter
        '
        Me.rpt_resumen_cobranzaTableAdapter.ClearBeforeFill = True
        '
        'Kardex_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Name = "Kardex_consultar"
        Me.Text = "Kardex_consultar"
        CType(Me.sql_para_pedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporte_ventas_existenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resumen_ventas_existenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.boton_guardar.ResumeLayout(False)
        Me.boton_guardar.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitAnalisisventas.Panel1.ResumeLayout(False)
        Me.SplitAnalisisventas.Panel1.PerformLayout()
        Me.SplitAnalisisventas.Panel2.ResumeLayout(False)
        CType(Me.SplitAnalisisventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitAnalisisventas.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.AgendaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.rpt_resumen_cobranzaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_del As System.Windows.Forms.DateTimePicker
    Friend WithEvents nombretxt As System.Windows.Forms.TextBox
    Friend WithEvents id_txt As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    'Friend WithEvents rpt_consulta_movimientosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_consulta_movimientosTableAdapter
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents combo_grupos As System.Windows.Forms.ComboBox
    Friend WithEvents chkgrupo As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_ver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PiezasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PiezaXCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PiezaXExhibidorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExhibidoresXCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CostoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CostoXPiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CostoXExhibidorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CostoXCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorPiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorexhibidorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorCajaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarDiseñoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sql_para_pedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents sql_para_pedidoTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_para_pedidoTableAdapter
    Friend WithEvents MarcarColumnasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitAnalisisventas As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvendedores As System.Windows.Forms.DataGridView
    Friend WithEvents dgventas As System.Windows.Forms.DataGridView
    Friend WithEvents combogrupo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents boton_x_proveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_Exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_guardar As System.Windows.Forms.ToolStrip
    Friend WithEvents Boton_preparar As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_ver_grid As System.Windows.Forms.ToolStripButton
    Friend WithEvents Boton_imprimir_conteo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ivapv As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents boton_imprimir_pedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents subtotal As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents iva As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents botonguarda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents agente As System.Windows.Forms.TextBox
    Friend WithEvents RastrearProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculoAutomaticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SuspenderArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReActivaArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerEntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boton_captura As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tcajas As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents AgendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgendaTableAdapter As AdminTegral.reporteDataSetTableAdapters.agendaTableAdapter
    Friend WithEvents AgendaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelOficinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelCelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_jefeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_jefeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Celular_jefeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_jefeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boton_agregar_agente As System.Windows.Forms.ToolStripButton
    Friend WithEvents Boton_guardar_cambio As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents boton_inactivos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents resumen_ventas_existenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents resumen_ventas_existenciaTableAdapter As AdminTegral.reporteDataSetTableAdapters.resumen_ventas_existenciaTableAdapter
    Friend WithEvents btn_preparar As System.Windows.Forms.Button
    Friend WithEvents reporte_ventas_existenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporte_ventas_existenciaTableAdapter As AdminTegral.reporteDataSetTableAdapters.reporte_ventas_existenciaTableAdapter
    Friend WithEvents rpt_resumen_cobranzaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_resumen_cobranzaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_resumen_cobranzaTableAdapter
End Class
