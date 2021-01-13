<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catalogos
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.freddy_lista_de_precios_localesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Validar = New System.Windows.Forms.Button
        Me.pieza = New System.Windows.Forms.CheckBox
        Me.boton_salir = New System.Windows.Forms.Button
        Me.CargoTextBox = New System.Windows.Forms.TextBox
        Me.ListasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.factortxt = New System.Windows.Forms.TextBox
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.freddy_lista_de_precios_localesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.freddy_lista_de_precios_localesTableAdapter
        Me.ListasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
        Me.chkprovedor = New System.Windows.Forms.CheckBox
        Me.boton_provedor = New System.Windows.Forms.Button
        Me.idprov = New System.Windows.Forms.TextBox
        Me.pvnombre = New System.Windows.Forms.TextBox
        Me.boton_por_provedor = New System.Windows.Forms.Button
        Me.gpotxt = New System.Windows.Forms.TextBox
        Me.chkgrupo = New System.Windows.Forms.CheckBox
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GruposTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
        Me.GrupoComboBox = New System.Windows.Forms.ComboBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.boton_por_descripcion = New System.Windows.Forms.Button
        DescripcionLabel = New System.Windows.Forms.Label
        CType(Me.freddy_lista_de_precios_localesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(7, 13)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(35, 13)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Lista :"
        '
        'freddy_lista_de_precios_localesBindingSource
        '
        Me.freddy_lista_de_precios_localesBindingSource.DataMember = "freddy_lista de precios locales"
        Me.freddy_lista_de_precios_localesBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_por_descripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtdescripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GrupoComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gpotxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkgrupo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_por_provedor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pvnombre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.idprov)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_provedor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkprovedor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Validar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pieza)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CargoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(DescripcionLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DescripcionComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.factortxt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(889, 504)
        Me.SplitContainer1.SplitterDistance = 102
        Me.SplitContainer1.TabIndex = 0
        '
        'Validar
        '
        Me.Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Validar.Location = New System.Drawing.Point(726, 7)
        Me.Validar.Name = "Validar"
        Me.Validar.Size = New System.Drawing.Size(75, 23)
        Me.Validar.TabIndex = 8
        Me.Validar.Text = "Validar"
        Me.Validar.UseVisualStyleBackColor = True
        '
        'pieza
        '
        Me.pieza.AutoSize = True
        Me.pieza.Location = New System.Drawing.Point(472, 13)
        Me.pieza.Name = "pieza"
        Me.pieza.Size = New System.Drawing.Size(106, 17)
        Me.pieza.TabIndex = 7
        Me.pieza.Text = "Quitar col. x Pza."
        Me.pieza.UseVisualStyleBackColor = True
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.Location = New System.Drawing.Point(807, 8)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(70, 22)
        Me.boton_salir.TabIndex = 6
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListasBindingSource, "cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(274, 11)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.ReadOnly = True
        Me.CargoTextBox.Size = New System.Drawing.Size(54, 20)
        Me.CargoTextBox.TabIndex = 5
        '
        'ListasBindingSource
        '
        Me.ListasBindingSource.DataMember = "Listas"
        Me.ListasBindingSource.DataSource = Me.admintegralDataSet
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataSource = Me.ListasBindingSource
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(48, 12)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(220, 21)
        Me.DescripcionComboBox.TabIndex = 3
        Me.DescripcionComboBox.ValueMember = "id"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Completo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'factortxt
        '
        Me.factortxt.Location = New System.Drawing.Point(334, 10)
        Me.factortxt.Name = "factortxt"
        Me.factortxt.ReadOnly = True
        Me.factortxt.Size = New System.Drawing.Size(54, 20)
        Me.factortxt.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "admintegralDataSet_freddy_lista_de_precios_locales"
        ReportDataSource2.Value = Me.freddy_lista_de_precios_localesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.listadeprecios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(889, 398)
        Me.ReportViewer1.TabIndex = 0
        '
        'freddy_lista_de_precios_localesTableAdapter
        '
        Me.freddy_lista_de_precios_localesTableAdapter.ClearBeforeFill = True
        '
        'ListasTableAdapter
        '
        Me.ListasTableAdapter.ClearBeforeFill = True
        '
        'chkprovedor
        '
        Me.chkprovedor.AutoSize = True
        Me.chkprovedor.Location = New System.Drawing.Point(9, 48)
        Me.chkprovedor.Name = "chkprovedor"
        Me.chkprovedor.Size = New System.Drawing.Size(75, 17)
        Me.chkprovedor.TabIndex = 9
        Me.chkprovedor.Text = "Provedor :"
        Me.chkprovedor.UseVisualStyleBackColor = True
        '
        'boton_provedor
        '
        Me.boton_provedor.Location = New System.Drawing.Point(394, 43)
        Me.boton_provedor.Name = "boton_provedor"
        Me.boton_provedor.Size = New System.Drawing.Size(27, 23)
        Me.boton_provedor.TabIndex = 10
        Me.boton_provedor.Text = "..."
        Me.boton_provedor.UseVisualStyleBackColor = True
        '
        'idprov
        '
        Me.idprov.Location = New System.Drawing.Point(82, 46)
        Me.idprov.Name = "idprov"
        Me.idprov.Size = New System.Drawing.Size(39, 20)
        Me.idprov.TabIndex = 11
        '
        'pvnombre
        '
        Me.pvnombre.Location = New System.Drawing.Point(126, 45)
        Me.pvnombre.Name = "pvnombre"
        Me.pvnombre.ReadOnly = True
        Me.pvnombre.Size = New System.Drawing.Size(262, 20)
        Me.pvnombre.TabIndex = 12
        '
        'boton_por_provedor
        '
        Me.boton_por_provedor.Location = New System.Drawing.Point(317, 67)
        Me.boton_por_provedor.Name = "boton_por_provedor"
        Me.boton_por_provedor.Size = New System.Drawing.Size(104, 23)
        Me.boton_por_provedor.TabIndex = 13
        Me.boton_por_provedor.Text = "Filtrado"
        Me.boton_por_provedor.UseVisualStyleBackColor = True
        '
        'gpotxt
        '
        Me.gpotxt.Location = New System.Drawing.Point(82, 70)
        Me.gpotxt.Name = "gpotxt"
        Me.gpotxt.Size = New System.Drawing.Size(39, 20)
        Me.gpotxt.TabIndex = 15
        '
        'chkgrupo
        '
        Me.chkgrupo.AutoSize = True
        Me.chkgrupo.Location = New System.Drawing.Point(9, 73)
        Me.chkgrupo.Name = "chkgrupo"
        Me.chkgrupo.Size = New System.Drawing.Size(61, 17)
        Me.chkgrupo.TabIndex = 14
        Me.chkgrupo.Text = "Grupo :"
        Me.chkgrupo.UseVisualStyleBackColor = True
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.admintegralDataSet
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'GrupoComboBox
        '
        Me.GrupoComboBox.DataSource = Me.GruposBindingSource
        Me.GrupoComboBox.DisplayMember = "Grupo"
        Me.GrupoComboBox.FormattingEnabled = True
        Me.GrupoComboBox.Location = New System.Drawing.Point(126, 69)
        Me.GrupoComboBox.Name = "GrupoComboBox"
        Me.GrupoComboBox.Size = New System.Drawing.Size(179, 21)
        Me.GrupoComboBox.TabIndex = 16
        Me.GrupoComboBox.ValueMember = "id_grupos"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescripcion.Location = New System.Drawing.Point(568, 63)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(206, 20)
        Me.txtdescripcion.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Descripcion :"
        '
        'boton_por_descripcion
        '
        Me.boton_por_descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_por_descripcion.Location = New System.Drawing.Point(780, 60)
        Me.boton_por_descripcion.Name = "boton_por_descripcion"
        Me.boton_por_descripcion.Size = New System.Drawing.Size(97, 23)
        Me.boton_por_descripcion.TabIndex = 19
        Me.boton_por_descripcion.Text = "Por descripcion"
        Me.boton_por_descripcion.UseVisualStyleBackColor = True
        '
        'catalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 504)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "catalogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de precios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.freddy_lista_de_precios_localesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents freddy_lista_de_precios_localesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents freddy_lista_de_precios_localesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.freddy_lista_de_precios_localesTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents factortxt As System.Windows.Forms.TextBox
    Friend WithEvents ListasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents pieza As System.Windows.Forms.CheckBox
    Friend WithEvents Validar As System.Windows.Forms.Button
    Friend WithEvents boton_provedor As System.Windows.Forms.Button
    Friend WithEvents chkprovedor As System.Windows.Forms.CheckBox
    Friend WithEvents pvnombre As System.Windows.Forms.TextBox
    Friend WithEvents idprov As System.Windows.Forms.TextBox
    Friend WithEvents boton_por_provedor As System.Windows.Forms.Button
    Friend WithEvents gpotxt As System.Windows.Forms.TextBox
    Friend WithEvents chkgrupo As System.Windows.Forms.CheckBox
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
    Friend WithEvents GrupoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents boton_por_descripcion As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
End Class
