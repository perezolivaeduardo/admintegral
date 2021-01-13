<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catalogo_y_etiquetas
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
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(catalogo_y_etiquetas))
        Me.Lista_de_ventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.boton_sin_iva = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ivatxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Factortxt = New System.Windows.Forms.TextBox
        Me.boton_validar = New System.Windows.Forms.Button
        Me.id_prov = New System.Windows.Forms.TextBox
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.DirectorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.boton_cargar_grupo = New System.Windows.Forms.Button
        Me.idgp = New System.Windows.Forms.TextBox
        Me.GrupoComboBox = New System.Windows.Forms.ComboBox
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.listanombres = New System.Windows.Forms.ListBox
        Me.Lista = New System.Windows.Forms.ListBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.filtro = New System.Windows.Forms.TextBox
        Me.boton_add_prov = New System.Windows.Forms.Button
        Me.idtxt = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.aplicar_filtros = New System.Windows.Forms.CheckBox
        Me.Lista_de_ventasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        Me.GruposTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
        Me.DirectorioTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.boton_todos = New System.Windows.Forms.Button
        GrupoLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        CType(Me.Lista_de_ventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(7, 9)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(39, 13)
        GrupoLabel.TabIndex = 0
        GrupoLabel.Text = "Grupo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(3, 40)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'Lista_de_ventasBindingSource
        '
        Me.Lista_de_ventasBindingSource.DataMember = "Lista_de_ventas"
        Me.Lista_de_ventasBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(885, 427)
        Me.SplitContainer1.SplitterDistance = 115
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_todos)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_sin_iva)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ivatxt)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Factortxt)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.boton_validar)
        Me.SplitContainer2.Panel2.Controls.Add(Me.id_prov)
        Me.SplitContainer2.Panel2.Controls.Add(NombreLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.boton_cargar_grupo)
        Me.SplitContainer2.Panel2.Controls.Add(Me.idgp)
        Me.SplitContainer2.Panel2.Controls.Add(GrupoLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GrupoComboBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(885, 115)
        Me.SplitContainer2.SplitterDistance = 293
        Me.SplitContainer2.TabIndex = 0
        '
        'boton_sin_iva
        '
        Me.boton_sin_iva.Location = New System.Drawing.Point(139, 30)
        Me.boton_sin_iva.Name = "boton_sin_iva"
        Me.boton_sin_iva.Size = New System.Drawing.Size(131, 23)
        Me.boton_sin_iva.TabIndex = 11
        Me.boton_sin_iva.Text = "Productos S/IVA"
        Me.boton_sin_iva.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(17, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Filtro segun IVA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "%IVA :"
        '
        'ivatxt
        '
        Me.ivatxt.Location = New System.Drawing.Point(75, 57)
        Me.ivatxt.Name = "ivatxt"
        Me.ivatxt.Size = New System.Drawing.Size(43, 20)
        Me.ivatxt.TabIndex = 8
        Me.ivatxt.Text = "11"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Factor :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Productos con IVA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Factortxt
        '
        Me.Factortxt.Location = New System.Drawing.Point(75, 31)
        Me.Factortxt.Name = "Factortxt"
        Me.Factortxt.Size = New System.Drawing.Size(43, 20)
        Me.Factortxt.TabIndex = 5
        Me.Factortxt.Text = "3"
        '
        'boton_validar
        '
        Me.boton_validar.Location = New System.Drawing.Point(10, 85)
        Me.boton_validar.Name = "boton_validar"
        Me.boton_validar.Size = New System.Drawing.Size(106, 23)
        Me.boton_validar.TabIndex = 7
        Me.boton_validar.Text = "Validar Movimiento"
        Me.boton_validar.UseVisualStyleBackColor = True
        '
        'id_prov
        '
        Me.id_prov.Location = New System.Drawing.Point(51, 40)
        Me.id_prov.Name = "id_prov"
        Me.id_prov.Size = New System.Drawing.Size(40, 20)
        Me.id_prov.TabIndex = 6
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.DirectorioBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(97, 37)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(364, 21)
        Me.NombreComboBox.TabIndex = 5
        Me.NombreComboBox.ValueMember = "id_directorio"
        '
        'DirectorioBindingSource
        '
        Me.DirectorioBindingSource.DataMember = "Directorio"
        Me.DirectorioBindingSource.DataSource = Me.admintegralDataSet
        '
        'boton_cargar_grupo
        '
        Me.boton_cargar_grupo.Location = New System.Drawing.Point(467, 8)
        Me.boton_cargar_grupo.Name = "boton_cargar_grupo"
        Me.boton_cargar_grupo.Size = New System.Drawing.Size(106, 23)
        Me.boton_cargar_grupo.TabIndex = 3
        Me.boton_cargar_grupo.Text = "Cargar Grupo"
        Me.boton_cargar_grupo.UseVisualStyleBackColor = True
        '
        'idgp
        '
        Me.idgp.Location = New System.Drawing.Point(51, 10)
        Me.idgp.Name = "idgp"
        Me.idgp.Size = New System.Drawing.Size(40, 20)
        Me.idgp.TabIndex = 2
        '
        'GrupoComboBox
        '
        Me.GrupoComboBox.DataSource = Me.GruposBindingSource
        Me.GrupoComboBox.DisplayMember = "Grupo"
        Me.GrupoComboBox.FormattingEnabled = True
        Me.GrupoComboBox.Location = New System.Drawing.Point(97, 9)
        Me.GrupoComboBox.Name = "GrupoComboBox"
        Me.GrupoComboBox.Size = New System.Drawing.Size(364, 21)
        Me.GrupoComboBox.TabIndex = 1
        Me.GrupoComboBox.ValueMember = "id_grupos"
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.admintegralDataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(885, 313)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(877, 287)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Etiquetas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_Lista_de_ventas"
        ReportDataSource1.Value = Me.Lista_de_ventasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.etiquetas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(871, 281)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Controls.Add(Me.aplicar_filtros)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(877, 287)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filtros"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.listanombres)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Lista)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.filtro)
        Me.SplitContainer3.Panel1.Controls.Add(Me.boton_add_prov)
        Me.SplitContainer3.Panel1.Controls.Add(Me.idtxt)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer3.Size = New System.Drawing.Size(392, 281)
        Me.SplitContainer3.SplitterDistance = 252
        Me.SplitContainer3.TabIndex = 7
        '
        'listanombres
        '
        Me.listanombres.FormattingEnabled = True
        Me.listanombres.Location = New System.Drawing.Point(88, 58)
        Me.listanombres.Name = "listanombres"
        Me.listanombres.Size = New System.Drawing.Size(276, 160)
        Me.listanombres.TabIndex = 6
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(18, 58)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(64, 160)
        Me.Lista.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(18, 224)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Quitar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'filtro
        '
        Me.filtro.Location = New System.Drawing.Point(14, 6)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(350, 20)
        Me.filtro.TabIndex = 4
        Me.filtro.Visible = False
        '
        'boton_add_prov
        '
        Me.boton_add_prov.Location = New System.Drawing.Point(90, 32)
        Me.boton_add_prov.Name = "boton_add_prov"
        Me.boton_add_prov.Size = New System.Drawing.Size(50, 23)
        Me.boton_add_prov.TabIndex = 2
        Me.boton_add_prov.Text = "Agregar"
        Me.boton_add_prov.UseVisualStyleBackColor = True
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(18, 32)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(64, 20)
        Me.idtxt.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.toolStripSeparator})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(392, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Abrir lista"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar lista"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'aplicar_filtros
        '
        Me.aplicar_filtros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aplicar_filtros.AutoSize = True
        Me.aplicar_filtros.Location = New System.Drawing.Point(780, 264)
        Me.aplicar_filtros.Name = "aplicar_filtros"
        Me.aplicar_filtros.Size = New System.Drawing.Size(88, 17)
        Me.aplicar_filtros.TabIndex = 5
        Me.aplicar_filtros.Text = "Aplicar Filtros"
        Me.aplicar_filtros.UseVisualStyleBackColor = True
        '
        'Lista_de_ventasTableAdapter
        '
        Me.Lista_de_ventasTableAdapter.ClearBeforeFill = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'DirectorioTableAdapter
        '
        Me.DirectorioTableAdapter.ClearBeforeFill = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Archivos Lista *.lst|*.lst"
        Me.SaveFileDialog1.InitialDirectory = "c:\tmp"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Archivos Lista *.lst|*.lst"
        Me.OpenFileDialog1.InitialDirectory = "c:\tmp"
        '
        'boton_todos
        '
        Me.boton_todos.Location = New System.Drawing.Point(139, 84)
        Me.boton_todos.Name = "boton_todos"
        Me.boton_todos.Size = New System.Drawing.Size(131, 23)
        Me.boton_todos.TabIndex = 12
        Me.boton_todos.Text = "Todos"
        Me.boton_todos.UseVisualStyleBackColor = True
        '
        'catalogo_y_etiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 427)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "catalogo_y_etiquetas"
        Me.Text = "catalogo_y_etiquetas"
        CType(Me.Lista_de_ventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DirectorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Lista_de_ventasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Lista_de_ventasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ivatxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Factortxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
    Friend WithEvents GrupoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents idgp As System.Windows.Forms.TextBox
    Friend WithEvents boton_cargar_grupo As System.Windows.Forms.Button
    Friend WithEvents DirectorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectorioTableAdapter As AdminTegral.admintegralDataSetTableAdapters.DirectorioTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents id_prov As System.Windows.Forms.TextBox
    Friend WithEvents boton_sin_iva As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents boton_add_prov As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Lista As System.Windows.Forms.ListBox
    Friend WithEvents idtxt As System.Windows.Forms.TextBox
    Friend WithEvents filtro As System.Windows.Forms.TextBox
    Friend WithEvents aplicar_filtros As System.Windows.Forms.CheckBox
    Friend WithEvents listanombres As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents boton_validar As System.Windows.Forms.Button
    Friend WithEvents boton_todos As System.Windows.Forms.Button
End Class
