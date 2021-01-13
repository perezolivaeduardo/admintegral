<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxp_antiguedad
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.cxc_est_agentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cxc_est_agentesTableAdapter = New AdminTegral.reporteDataSetTableAdapters.cxc_est_agentesTableAdapter
        Me.integraDataSet = New AdminTegral.integraDataSet
        Me.cxp_antiguedadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cxp_antiguedadTableAdapter = New AdminTegral.integraDataSetTableAdapters.cxp_antiguedadTableAdapter
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxc_est_agentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.integraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxp_antiguedadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "reporteDataSet_cxc_est_agentes"
        ReportDataSource1.Value = Me.cxc_est_agentesBindingSource
        ReportDataSource2.Name = "integraDataSet_cxp_antiguedad"
        ReportDataSource2.Value = Me.cxp_antiguedadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.cxp_antiguedad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(778, 392)
        Me.ReportViewer1.TabIndex = 0
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxc_est_agentesBindingSource
        '
        Me.cxc_est_agentesBindingSource.DataMember = "cxc_est_agentes"
        Me.cxc_est_agentesBindingSource.DataSource = Me.reporteDataSet
        '
        'cxc_est_agentesTableAdapter
        '
        Me.cxc_est_agentesTableAdapter.ClearBeforeFill = True
        '
        'integraDataSet
        '
        Me.integraDataSet.DataSetName = "integraDataSet"
        Me.integraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxp_antiguedadBindingSource
        '
        Me.cxp_antiguedadBindingSource.DataMember = "cxp_antiguedad"
        Me.cxp_antiguedadBindingSource.DataSource = Me.integraDataSet
        '
        'cxp_antiguedadTableAdapter
        '
        Me.cxp_antiguedadTableAdapter.ClearBeforeFill = True
        '
        'cxp_antiguedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 392)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "cxp_antiguedad"
        Me.Text = "cxp_antiguedad"
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxc_est_agentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.integraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxp_antiguedadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cxc_est_agentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents cxp_antiguedadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents integraDataSet As AdminTegral.integraDataSet
    Friend WithEvents cxc_est_agentesTableAdapter As AdminTegral.reporteDataSetTableAdapters.cxc_est_agentesTableAdapter
    Friend WithEvents cxp_antiguedadTableAdapter As AdminTegral.integraDataSetTableAdapters.cxp_antiguedadTableAdapter
End Class
