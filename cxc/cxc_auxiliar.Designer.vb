<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_auxiliar
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.cxc_catalogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.cxc_auxiliarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.boton_ok = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.id_cli = New System.Windows.Forms.TextBox
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.cxc_auxiliarTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_auxiliarTableAdapter
        Me.cxc_catalogoTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_catalogoTableAdapter
        CType(Me.cxc_catalogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxc_auxiliarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cxc_catalogoBindingSource
        '
        Me.cxc_catalogoBindingSource.DataMember = "cxc_catalogo"
        Me.cxc_catalogoBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxc_auxiliarBindingSource
        '
        Me.cxc_auxiliarBindingSource.DataMember = "cxc_auxiliar"
        Me.cxc_auxiliarBindingSource.DataSource = Me.admintegralDataSet
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_ok)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id_cli)
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(860, 438)
        Me.SplitContainer1.SplitterDistance = 47
        Me.SplitContainer1.TabIndex = 0
        '
        'boton_ok
        '
        Me.boton_ok.Location = New System.Drawing.Point(128, 10)
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(37, 23)
        Me.boton_ok.TabIndex = 2
        Me.boton_ok.Text = "OK"
        Me.boton_ok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Cliente :"
        '
        'id_cli
        '
        Me.id_cli.Location = New System.Drawing.Point(75, 10)
        Me.id_cli.Name = "id_cli"
        Me.id_cli.Size = New System.Drawing.Size(47, 20)
        Me.id_cli.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "admintegralDataSet_cxc_catalogo"
        ReportDataSource2.Value = Me.cxc_catalogoBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "AdminTegral.cxc_catalogo.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(860, 438)
        Me.ReportViewer2.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_cxc_auxiliar"
        ReportDataSource1.Value = Me.cxc_auxiliarBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.cxc_auxiliar.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(860, 438)
        Me.ReportViewer1.TabIndex = 0
        '
        'cxc_auxiliarTableAdapter
        '
        Me.cxc_auxiliarTableAdapter.ClearBeforeFill = True
        '
        'cxc_catalogoTableAdapter
        '
        Me.cxc_catalogoTableAdapter.ClearBeforeFill = True
        '
        'cxc_auxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 438)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cxc_auxiliar"
        CType(Me.cxc_catalogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxc_auxiliarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cxc_auxiliarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents cxc_auxiliarTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_auxiliarTableAdapter
    Friend WithEvents boton_ok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_cli As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cxc_catalogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cxc_catalogoTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_catalogoTableAdapter
End Class
