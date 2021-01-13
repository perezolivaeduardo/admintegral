<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventario_global
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.sql_existencias_x_grupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.descripciontxt = New System.Windows.Forms.TextBox
        Me.chkgrupo = New System.Windows.Forms.CheckBox
        Me.chkprov = New System.Windows.Forms.CheckBox
        Me.GrupoComboBox = New System.Windows.Forms.ComboBox
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.gptxt = New System.Windows.Forms.TextBox
        Me.provedortxt = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.pvtxt = New System.Windows.Forms.TextBox
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.sql_existencias_x_grupoTableAdapter = New AdminTegral.reporteDataSetTableAdapters.sql_existencias_x_grupoTableAdapter
        Me.GruposTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
        Me.Button3 = New System.Windows.Forms.Button
        Me.boton_salir = New System.Windows.Forms.Button
        CType(Me.sql_existencias_x_grupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sql_existencias_x_grupoBindingSource
        '
        Me.sql_existencias_x_grupoBindingSource.DataMember = "sql_existencias_x_grupo"
        Me.sql_existencias_x_grupoBindingSource.DataSource = Me.reporteDataSet
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.descripciontxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkgrupo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkprov)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GrupoComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gptxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.provedortxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pvtxt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(743, 389)
        Me.SplitContainer1.SplitterDistance = 97
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripcion :"
        '
        'descripciontxt
        '
        Me.descripciontxt.Location = New System.Drawing.Point(96, 65)
        Me.descripciontxt.Name = "descripciontxt"
        Me.descripciontxt.Size = New System.Drawing.Size(412, 20)
        Me.descripciontxt.TabIndex = 11
        '
        'chkgrupo
        '
        Me.chkgrupo.AutoSize = True
        Me.chkgrupo.Location = New System.Drawing.Point(14, 42)
        Me.chkgrupo.Name = "chkgrupo"
        Me.chkgrupo.Size = New System.Drawing.Size(61, 17)
        Me.chkgrupo.TabIndex = 10
        Me.chkgrupo.Text = "Grupo :"
        Me.chkgrupo.UseVisualStyleBackColor = True
        '
        'chkprov
        '
        Me.chkprov.AutoSize = True
        Me.chkprov.Location = New System.Drawing.Point(15, 13)
        Me.chkprov.Name = "chkprov"
        Me.chkprov.Size = New System.Drawing.Size(75, 17)
        Me.chkprov.TabIndex = 9
        Me.chkprov.Text = "Provedor :"
        Me.chkprov.UseVisualStyleBackColor = True
        '
        'GrupoComboBox
        '
        Me.GrupoComboBox.DataSource = Me.GruposBindingSource
        Me.GrupoComboBox.DisplayMember = "Grupo"
        Me.GrupoComboBox.FormattingEnabled = True
        Me.GrupoComboBox.Location = New System.Drawing.Point(148, 36)
        Me.GrupoComboBox.Name = "GrupoComboBox"
        Me.GrupoComboBox.Size = New System.Drawing.Size(166, 21)
        Me.GrupoComboBox.TabIndex = 8
        Me.GrupoComboBox.ValueMember = "id_grupos"
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gptxt
        '
        Me.gptxt.Location = New System.Drawing.Point(96, 39)
        Me.gptxt.Name = "gptxt"
        Me.gptxt.Size = New System.Drawing.Size(46, 20)
        Me.gptxt.TabIndex = 5
        '
        'provedortxt
        '
        Me.provedortxt.Location = New System.Drawing.Point(148, 13)
        Me.provedortxt.Name = "provedortxt"
        Me.provedortxt.Size = New System.Drawing.Size(360, 20)
        Me.provedortxt.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(514, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(514, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pvtxt
        '
        Me.pvtxt.Location = New System.Drawing.Point(96, 13)
        Me.pvtxt.Name = "pvtxt"
        Me.pvtxt.Size = New System.Drawing.Size(46, 20)
        Me.pvtxt.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "tabla"
        ReportDataSource1.Value = Me.sql_existencias_x_grupoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.inventario_global.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(743, 288)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_existencias_x_grupoTableAdapter
        '
        Me.sql_existencias_x_grupoTableAdapter.ClearBeforeFill = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(514, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Filtar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'boton_salir
        '
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(691, 68)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(40, 23)
        Me.boton_salir.TabIndex = 14
        Me.boton_salir.Text = "ESC"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'inventario_global
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(743, 389)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "inventario_global"
        Me.Text = "inventario_global"
        CType(Me.sql_existencias_x_grupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pvtxt As System.Windows.Forms.TextBox
    Friend WithEvents sql_existencias_x_grupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents sql_existencias_x_grupoTableAdapter As AdminTegral.reporteDataSetTableAdapters.sql_existencias_x_grupoTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents provedortxt As System.Windows.Forms.TextBox
    Friend WithEvents gptxt As System.Windows.Forms.TextBox
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As AdminTegral.admintegralDataSetTableAdapters.GruposTableAdapter
    Friend WithEvents GrupoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents chkgrupo As System.Windows.Forms.CheckBox
    Friend WithEvents chkprov As System.Windows.Forms.CheckBox
    Friend WithEvents descripciontxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
