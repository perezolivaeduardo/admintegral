<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja_entradas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.diastxt = New System.Windows.Forms.TextBox()
        Me.vencetxt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gruponc = New System.Windows.Forms.GroupBox()
        Me.numeronc = New System.Windows.Forms.TextBox()
        Me.importenc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sucursal = New System.Windows.Forms.TextBox()
        Me.almacen = New System.Windows.Forms.TextBox()
        Me.serie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.piva = New System.Windows.Forms.TextBox()
        Me.TOTAL = New System.Windows.Forms.TextBox()
        Me.IVA = New System.Windows.Forms.TextBox()
        Me.subtotal = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.TextBox()
        Me.nfactura = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lblmodo = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgventrada = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvdevolucion = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.boton_guardar_producto = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.niva = New System.Windows.Forms.TextBox()
        Me.Tmp_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.ncosto = New System.Windows.Forms.TextBox()
        Me.ndescripcion = New System.Windows.Forms.TextBox()
        Me.ncodigo = New System.Windows.Forms.TextBox()
        Me.Tmp_productosDataGridView = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idprov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nprov = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.boton_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.dgvrelacion = New System.Windows.Forms.DataGridView()
        Me.Linea = New System.Windows.Forms.TextBox()
        Me.boton_salir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.comentarios = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProvedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tmp_productosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tmp_productosTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gruponc.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgventrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvdevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Tmp_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tmp_productosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvrelacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.diastxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.vencetxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gruponc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.sucursal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.almacen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.serie)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.piva)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TOTAL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IVA)
        Me.SplitContainer1.Panel1.Controls.Add(Me.subtotal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nfactura)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nombre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(814, 526)
        Me.SplitContainer1.SplitterDistance = 137
        Me.SplitContainer1.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(343, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 18)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Dias:"
        '
        'diastxt
        '
        Me.diastxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diastxt.Location = New System.Drawing.Point(389, 34)
        Me.diastxt.Name = "diastxt"
        Me.diastxt.ReadOnly = True
        Me.diastxt.Size = New System.Drawing.Size(34, 24)
        Me.diastxt.TabIndex = 24
        Me.diastxt.TabStop = False
        Me.diastxt.Text = "11"
        '
        'vencetxt
        '
        Me.vencetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vencetxt.Location = New System.Drawing.Point(346, 59)
        Me.vencetxt.Name = "vencetxt"
        Me.vencetxt.ReadOnly = True
        Me.vencetxt.Size = New System.Drawing.Size(120, 24)
        Me.vencetxt.TabIndex = 23
        Me.vencetxt.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(283, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 18)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Vence:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(561, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'gruponc
        '
        Me.gruponc.Controls.Add(Me.numeronc)
        Me.gruponc.Controls.Add(Me.importenc)
        Me.gruponc.Controls.Add(Me.Label8)
        Me.gruponc.Controls.Add(Me.Label7)
        Me.gruponc.Location = New System.Drawing.Point(13, 83)
        Me.gruponc.Name = "gruponc"
        Me.gruponc.Size = New System.Drawing.Size(450, 37)
        Me.gruponc.TabIndex = 8
        Me.gruponc.TabStop = False
        Me.gruponc.Visible = False
        '
        'numeronc
        '
        Me.numeronc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeronc.Location = New System.Drawing.Point(148, 9)
        Me.numeronc.Name = "numeronc"
        Me.numeronc.Size = New System.Drawing.Size(82, 24)
        Me.numeronc.TabIndex = 5
        '
        'importenc
        '
        Me.importenc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importenc.Location = New System.Drawing.Point(333, 10)
        Me.importenc.Name = "importenc"
        Me.importenc.ReadOnly = True
        Me.importenc.Size = New System.Drawing.Size(100, 24)
        Me.importenc.TabIndex = 4
        Me.importenc.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(263, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Importe :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nota Credito No:"
        '
        'sucursal
        '
        Me.sucursal.Location = New System.Drawing.Point(507, 72)
        Me.sucursal.Name = "sucursal"
        Me.sucursal.Size = New System.Drawing.Size(70, 20)
        Me.sucursal.TabIndex = 20
        Me.sucursal.Text = "  "
        Me.sucursal.Visible = False
        '
        'almacen
        '
        Me.almacen.Location = New System.Drawing.Point(13, 91)
        Me.almacen.Name = "almacen"
        Me.almacen.Size = New System.Drawing.Size(67, 20)
        Me.almacen.TabIndex = 19
        Me.almacen.Text = "  "
        Me.almacen.Visible = False
        '
        'serie
        '
        Me.serie.Location = New System.Drawing.Point(15, 62)
        Me.serie.Name = "serie"
        Me.serie.Size = New System.Drawing.Size(29, 20)
        Me.serie.TabIndex = 18
        Me.serie.Text = "  "
        Me.serie.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(468, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "IVA:"
        '
        'piva
        '
        Me.piva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piva.Location = New System.Drawing.Point(507, 36)
        Me.piva.Name = "piva"
        Me.piva.ReadOnly = True
        Me.piva.Size = New System.Drawing.Size(52, 24)
        Me.piva.TabIndex = 16
        Me.piva.TabStop = False
        Me.piva.Text = "11"
        '
        'TOTAL
        '
        Me.TOTAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL.Location = New System.Drawing.Point(704, 72)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Size = New System.Drawing.Size(100, 24)
        Me.TOTAL.TabIndex = 15
        Me.TOTAL.TabStop = False
        Me.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IVA
        '
        Me.IVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IVA.Location = New System.Drawing.Point(704, 45)
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        Me.IVA.Size = New System.Drawing.Size(100, 24)
        Me.IVA.TabIndex = 14
        Me.IVA.TabStop = False
        Me.IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'subtotal
        '
        Me.subtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.Location = New System.Drawing.Point(704, 19)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Size = New System.Drawing.Size(100, 24)
        Me.subtotal.TabIndex = 13
        Me.subtotal.TabStop = False
        Me.subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(160, 59)
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Size = New System.Drawing.Size(120, 24)
        Me.fecha.TabIndex = 12
        Me.fecha.TabStop = False
        '
        'nfactura
        '
        Me.nfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nfactura.Location = New System.Drawing.Point(160, 34)
        Me.nfactura.MaxLength = 15
        Me.nfactura.Name = "nfactura"
        Me.nfactura.Size = New System.Drawing.Size(120, 24)
        Me.nfactura.TabIndex = 1
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(160, 8)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(399, 24)
        Me.nombre.TabIndex = 10
        Me.nombre.TabStop = False
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(96, 8)
        Me.id.MaxLength = 5
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(60, 24)
        Me.id.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(650, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(662, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IVA :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(629, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subtotal :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero de Factura :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Proveedor :"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblmodo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Linea)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer2.Panel2.Controls.Add(Me.boton_salir)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer2.Panel2.Controls.Add(Me.comentarios)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Size = New System.Drawing.Size(814, 385)
        Me.SplitContainer2.SplitterDistance = 307
        Me.SplitContainer2.TabIndex = 0
        '
        'lblmodo
        '
        Me.lblmodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodo.Location = New System.Drawing.Point(719, 5)
        Me.lblmodo.Name = "lblmodo"
        Me.lblmodo.Size = New System.Drawing.Size(85, 18)
        Me.lblmodo.TabIndex = 4
        Me.lblmodo.Text = "-"
        Me.lblmodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(811, 274)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgventrada)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(803, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Entrada"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgventrada
        '
        Me.dgventrada.AllowUserToAddRows = False
        Me.dgventrada.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        Me.dgventrada.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgventrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgventrada.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgventrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgventrada.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgventrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgventrada.Location = New System.Drawing.Point(3, 3)
        Me.dgventrada.Name = "dgventrada"
        Me.dgventrada.RowHeadersVisible = False
        Me.dgventrada.Size = New System.Drawing.Size(797, 242)
        Me.dgventrada.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvdevolucion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(803, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Devolucion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvdevolucion
        '
        Me.dgvdevolucion.AllowUserToAddRows = False
        Me.dgvdevolucion.AllowUserToDeleteRows = False
        Me.dgvdevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvdevolucion.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvdevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdevolucion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvdevolucion.Location = New System.Drawing.Point(3, 3)
        Me.dgvdevolucion.Name = "dgvdevolucion"
        Me.dgvdevolucion.RowHeadersVisible = False
        Me.dgvdevolucion.Size = New System.Drawing.Size(797, 242)
        Me.dgvdevolucion.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.boton_guardar_producto)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.niva)
        Me.TabPage3.Controls.Add(Me.ncosto)
        Me.TabPage3.Controls.Add(Me.ndescripcion)
        Me.TabPage3.Controls.Add(Me.ncodigo)
        Me.TabPage3.Controls.Add(Me.Tmp_productosDataGridView)
        Me.TabPage3.Controls.Add(Me.nprov)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(803, 248)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Producto Nuevo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 24)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Producto Nuevo"
        '
        'boton_guardar_producto
        '
        Me.boton_guardar_producto.Location = New System.Drawing.Point(224, 213)
        Me.boton_guardar_producto.Name = "boton_guardar_producto"
        Me.boton_guardar_producto.Size = New System.Drawing.Size(75, 23)
        Me.boton_guardar_producto.TabIndex = 10
        Me.boton_guardar_producto.Text = "Guardar"
        Me.boton_guardar_producto.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(139, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Codigo :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Descripcion :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Costo Unitario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "% de IVA :"
        '
        'niva
        '
        Me.niva.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tmp_productosBindingSource, "piva", True))
        Me.niva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.niva.Location = New System.Drawing.Point(112, 146)
        Me.niva.MaxLength = 2
        Me.niva.Name = "niva"
        Me.niva.Size = New System.Drawing.Size(38, 22)
        Me.niva.TabIndex = 4
        '
        'Tmp_productosBindingSource
        '
        Me.Tmp_productosBindingSource.DataMember = "tmp_productos"
        Me.Tmp_productosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ncosto
        '
        Me.ncosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tmp_productosBindingSource, "costo", True))
        Me.ncosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ncosto.Location = New System.Drawing.Point(112, 118)
        Me.ncosto.MaxLength = 10
        Me.ncosto.Name = "ncosto"
        Me.ncosto.Size = New System.Drawing.Size(100, 22)
        Me.ncosto.TabIndex = 3
        '
        'ndescripcion
        '
        Me.ndescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tmp_productosBindingSource, "descripcion", True))
        Me.ndescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndescripcion.Location = New System.Drawing.Point(9, 88)
        Me.ndescripcion.MaxLength = 60
        Me.ndescripcion.Name = "ndescripcion"
        Me.ndescripcion.Size = New System.Drawing.Size(297, 22)
        Me.ndescripcion.TabIndex = 2
        '
        'ncodigo
        '
        Me.ncodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tmp_productosBindingSource, "codigo", True))
        Me.ncodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ncodigo.Location = New System.Drawing.Point(69, 43)
        Me.ncodigo.Name = "ncodigo"
        Me.ncodigo.ReadOnly = True
        Me.ncodigo.Size = New System.Drawing.Size(236, 22)
        Me.ncodigo.TabIndex = 1
        '
        'Tmp_productosDataGridView
        '
        Me.Tmp_productosDataGridView.AllowUserToAddRows = False
        Me.Tmp_productosDataGridView.AllowUserToDeleteRows = False
        Me.Tmp_productosDataGridView.AutoGenerateColumns = False
        Me.Tmp_productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Tmp_productosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.idprov, Me.descripcion, Me.costo, Me.DataGridViewTextBoxColumn1})
        Me.Tmp_productosDataGridView.DataSource = Me.Tmp_productosBindingSource
        Me.Tmp_productosDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.Tmp_productosDataGridView.Location = New System.Drawing.Point(308, 0)
        Me.Tmp_productosDataGridView.Name = "Tmp_productosDataGridView"
        Me.Tmp_productosDataGridView.ReadOnly = True
        Me.Tmp_productosDataGridView.RowHeadersVisible = False
        Me.Tmp_productosDataGridView.Size = New System.Drawing.Size(495, 248)
        Me.Tmp_productosDataGridView.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 64
        '
        'idprov
        '
        Me.idprov.DataPropertyName = "id_provedor"
        Me.idprov.HeaderText = "Prov"
        Me.idprov.Name = "idprov"
        Me.idprov.ReadOnly = True
        Me.idprov.Width = 54
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 88
        '
        'costo
        '
        Me.costo.DataPropertyName = "costo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.costo.DefaultCellStyle = DataGridViewCellStyle3
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Width = 58
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "piva"
        Me.DataGridViewTextBoxColumn1.HeaderText = "piva"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 52
        '
        'nprov
        '
        Me.nprov.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tmp_productosBindingSource, "id_provedor", True))
        Me.nprov.Location = New System.Drawing.Point(236, 45)
        Me.nprov.Name = "nprov"
        Me.nprov.ReadOnly = True
        Me.nprov.Size = New System.Drawing.Size(63, 20)
        Me.nprov.TabIndex = 14
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ToolStrip1)
        Me.TabPage4.Controls.Add(Me.dgvrelacion)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(803, 248)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Relacion de Entradas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.boton_cancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(803, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.lorry
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton1.Text = "Entradas "
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Refresh
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripButton2.Text = "Devoluciones "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'boton_cancelar
        '
        Me.boton_cancelar.Image = Global.AdminTegral.My.Resources.Resources.Delete
        Me.boton_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_cancelar.Name = "boton_cancelar"
        Me.boton_cancelar.Size = New System.Drawing.Size(69, 22)
        Me.boton_cancelar.Text = "Cancela"
        Me.boton_cancelar.Visible = False
        '
        'dgvrelacion
        '
        Me.dgvrelacion.AllowUserToAddRows = False
        Me.dgvrelacion.AllowUserToDeleteRows = False
        Me.dgvrelacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvrelacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvrelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrelacion.Location = New System.Drawing.Point(3, 28)
        Me.dgvrelacion.Name = "dgvrelacion"
        Me.dgvrelacion.ReadOnly = True
        Me.dgvrelacion.RowHeadersVisible = False
        Me.dgvrelacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvrelacion.Size = New System.Drawing.Size(795, 220)
        Me.dgvrelacion.TabIndex = 0
        '
        'Linea
        '
        Me.Linea.Enabled = False
        Me.Linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linea.Location = New System.Drawing.Point(6, 3)
        Me.Linea.Name = "Linea"
        Me.Linea.Size = New System.Drawing.Size(169, 24)
        Me.Linea.TabIndex = 2
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(727, 51)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 4
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 18)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Comentarios :"
        '
        'comentarios
        '
        Me.comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentarios.Location = New System.Drawing.Point(112, 2)
        Me.comentarios.MaxLength = 200
        Me.comentarios.Multiline = True
        Me.comentarios.Name = "comentarios"
        Me.comentarios.Size = New System.Drawing.Size(377, 64)
        Me.comentarios.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(727, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem, Me.BuscarProvedorToolStripMenuItem})
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.CatalogoToolStripMenuItem.Text = "catalogo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'BuscarProvedorToolStripMenuItem
        '
        Me.BuscarProvedorToolStripMenuItem.Name = "BuscarProvedorToolStripMenuItem"
        Me.BuscarProvedorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.BuscarProvedorToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.BuscarProvedorToolStripMenuItem.Text = "Buscar Provedor"
        '
        'Tmp_productosTableAdapter
        '
        Me.Tmp_productosTableAdapter.ClearBeforeFill = True
        '
        'caja_entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(814, 550)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "caja_entradas"
        Me.Text = "caja_entradas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gruponc.ResumeLayout(False)
        Me.gruponc.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgventrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvdevolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Tmp_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tmp_productosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvrelacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgventrada As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gruponc As System.Windows.Forms.GroupBox
    Friend WithEvents numeronc As System.Windows.Forms.TextBox
    Friend WithEvents importenc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.TextBox
    Friend WithEvents nfactura As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents IVA As System.Windows.Forms.TextBox
    Friend WithEvents subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Linea As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents piva As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvdevolucion As System.Windows.Forms.DataGridView
    Friend WithEvents lblmodo As System.Windows.Forms.Label
    Friend WithEvents serie As System.Windows.Forms.TextBox
    Friend WithEvents almacen As System.Windows.Forms.TextBox
    Friend WithEvents sucursal As System.Windows.Forms.TextBox
    Friend WithEvents comentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Tmp_productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tmp_productosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tmp_productosTableAdapter
    Friend WithEvents Tmp_productosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents niva As System.Windows.Forms.TextBox
    Friend WithEvents ncosto As System.Windows.Forms.TextBox
    Friend WithEvents ndescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ncodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents boton_guardar_producto As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents nprov As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idprov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarProvedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvrelacion As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boton_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents vencetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents diastxt As System.Windows.Forms.TextBox
End Class
