<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tmp
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgentesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_Agentes"
        ReportDataSource1.Value = Me.AgentesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(401, 438)
        Me.ReportViewer1.TabIndex = 0
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.admintegralDataSet
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'tmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 438)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "tmp"
        Me.Text = "tmp"
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AgentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents AgentesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
End Class
