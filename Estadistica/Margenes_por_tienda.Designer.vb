<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Margenes_por_tienda
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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.rpt_utilidad_por_tiendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.al = New System.Windows.Forms.DateTimePicker
        Me.del = New System.Windows.Forms.DateTimePicker
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rpt_utilidad_por_tiendaTableAdapter = New AdminTegral.reporteDataSetTableAdapters.rpt_utilidad_por_tiendaTableAdapter
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.rpt_utilidad_por_tiendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rpt_utilidad_por_tiendaBindingSource
        '
        Me.rpt_utilidad_por_tiendaBindingSource.DataMember = "rpt_utilidad_por_tienda"
        Me.rpt_utilidad_por_tiendaBindingSource.DataSource = Me.reporteDataSet
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.al)
        Me.SplitContainer1.Panel1.Controls.Add(Me.del)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(838, 317)
        Me.SplitContainer1.SplitterDistance = 36
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Por Tienda"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periodo :"
        '
        'al
        '
        Me.al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.al.Location = New System.Drawing.Point(174, 8)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(101, 20)
        Me.al.TabIndex = 1
        '
        'del
        '
        Me.del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.del.Location = New System.Drawing.Point(67, 8)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(101, 20)
        Me.del.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "reporteDataSet_rpt_utilidad_por_tienda"
        ReportDataSource4.Value = Me.rpt_utilidad_por_tiendaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.ventas_netas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(838, 277)
        Me.ReportViewer1.TabIndex = 0
        '
        'rpt_utilidad_por_tiendaTableAdapter
        '
        Me.rpt_utilidad_por_tiendaTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "tabla"
        ReportDataSource3.Value = Me.rpt_utilidad_por_tiendaBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "AdminTegral.ventas_netas_vendedor.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(838, 277)
        Me.ReportViewer2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(399, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Por Vendedor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Margenes_por_tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 317)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Margenes_por_tienda"
        Me.Text = "Margenes_por_tienda"
        CType(Me.rpt_utilidad_por_tiendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents al As System.Windows.Forms.DateTimePicker
    Friend WithEvents del As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rpt_utilidad_por_tiendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents rpt_utilidad_por_tiendaTableAdapter As AdminTegral.reporteDataSetTableAdapters.rpt_utilidad_por_tiendaTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
