<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_catalogo
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.rpt_catalogo_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ruta = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.BindingSourcerutas = New System.Windows.Forms.BindingSource(Me.components)
        Me.clientes_credito = New System.Windows.Forms.Button
        Me.boton_ok = New System.Windows.Forms.Button
        Me.idagente = New System.Windows.Forms.TextBox
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.AgentesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
        Me.rpt_catalogo_clientesTableAdapter = New AdminTegral.reporteDataSetTableAdapters.rpt_catalogo_clientesTableAdapter
        Me.btn_ruta = New System.Windows.Forms.Button
        NombreLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.rpt_catalogo_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.BindingSourcerutas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(8, 15)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(57, 16)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Agente :"
        '
        'rpt_catalogo_clientesBindingSource
        '
        Me.rpt_catalogo_clientesBindingSource.DataMember = "rpt_catalogo_clientes"
        Me.rpt_catalogo_clientesBindingSource.DataSource = Me.reporteDataSet
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(21, 45)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(42, 16)
        Label1.TabIndex = 7
        Label1.Text = "Ruta :"
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_ruta)
        Me.SplitContainer1.Panel1.Controls.Add(Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ruta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.clientes_credito)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_ok)
        Me.SplitContainer1.Panel1.Controls.Add(Me.idagente)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(694, 381)
        Me.SplitContainer1.SplitterDistance = 70
        Me.SplitContainer1.TabIndex = 0
        '
        'ruta
        '
        Me.ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ruta.Location = New System.Drawing.Point(69, 42)
        Me.ruta.Name = "ruta"
        Me.ruta.Size = New System.Drawing.Size(39, 22)
        Me.ruta.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.BindingSourcerutas
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(114, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'BindingSourcerutas
        '
        Me.BindingSourcerutas.AllowNew = False
        '
        'clientes_credito
        '
        Me.clientes_credito.Location = New System.Drawing.Point(553, 11)
        Me.clientes_credito.Name = "clientes_credito"
        Me.clientes_credito.Size = New System.Drawing.Size(129, 24)
        Me.clientes_credito.TabIndex = 4
        Me.clientes_credito.Tag = ""
        Me.clientes_credito.Text = "Clientes de credito"
        Me.clientes_credito.UseVisualStyleBackColor = True
        '
        'boton_ok
        '
        Me.boton_ok.Location = New System.Drawing.Point(414, 12)
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(129, 24)
        Me.boton_ok.TabIndex = 3
        Me.boton_ok.Tag = ""
        Me.boton_ok.Text = "Clientes de contado"
        Me.boton_ok.UseVisualStyleBackColor = True
        '
        'idagente
        '
        Me.idagente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idagente.Location = New System.Drawing.Point(69, 12)
        Me.idagente.Name = "idagente"
        Me.idagente.Size = New System.Drawing.Size(39, 22)
        Me.idagente.TabIndex = 2
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgentesBindingSource, "Nombre", True))
        Me.NombreComboBox.DataSource = Me.AgentesBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(114, 12)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(294, 24)
        Me.NombreComboBox.TabIndex = 1
        Me.NombreComboBox.ValueMember = "id_agente"
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "reporteDataSet_rpt_catalogo_clientes"
        ReportDataSource3.Value = Me.rpt_catalogo_clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.catalogo_clientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(694, 307)
        Me.ReportViewer1.TabIndex = 0
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'rpt_catalogo_clientesTableAdapter
        '
        Me.rpt_catalogo_clientesTableAdapter.ClearBeforeFill = True
        '
        'btn_ruta
        '
        Me.btn_ruta.Location = New System.Drawing.Point(414, 40)
        Me.btn_ruta.Name = "btn_ruta"
        Me.btn_ruta.Size = New System.Drawing.Size(129, 24)
        Me.btn_ruta.TabIndex = 8
        Me.btn_ruta.Tag = ""
        Me.btn_ruta.Text = "Clientes de la ruta"
        Me.btn_ruta.UseVisualStyleBackColor = True
        '
        'cxc_catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 381)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cxc_catalogo"
        Me.Text = "cxc_catalogo"
        CType(Me.rpt_catalogo_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BindingSourcerutas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents AgentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents idagente As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rpt_catalogo_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents rpt_catalogo_clientesTableAdapter As AdminTegral.reporteDataSetTableAdapters.rpt_catalogo_clientesTableAdapter
    Friend WithEvents boton_ok As System.Windows.Forms.Button
    Friend WithEvents clientes_credito As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BindingSourcerutas As System.Windows.Forms.BindingSource
    Friend WithEvents ruta As System.Windows.Forms.TextBox
    Friend WithEvents btn_ruta As System.Windows.Forms.Button
End Class
