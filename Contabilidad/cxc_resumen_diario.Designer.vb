<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_resumen_diario
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.fechadel = New System.Windows.Forms.DateTimePicker
        Me.fechaal = New System.Windows.Forms.DateTimePicker
        Me.boton_ok = New System.Windows.Forms.Button
        Me.cxc_resumen_diarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.cxc_resumen_diarioTableAdapter = New AdminTegral.reporteDataSetTableAdapters.cxc_resumen_diarioTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.boton_salir = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.cxc_resumen_diarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_ok)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechaal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechadel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(787, 446)
        Me.SplitContainer1.SplitterDistance = 33
        Me.SplitContainer1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "reporteDataSet_cxc_resumen_diario"
        ReportDataSource2.Value = Me.cxc_resumen_diarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.cxc_resumen_por_dia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(787, 409)
        Me.ReportViewer1.TabIndex = 0
        '
        'fechadel
        '
        Me.fechadel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechadel.Location = New System.Drawing.Point(38, 6)
        Me.fechadel.Name = "fechadel"
        Me.fechadel.Size = New System.Drawing.Size(104, 20)
        Me.fechadel.TabIndex = 0
        Me.fechadel.Value = New Date(2010, 3, 1, 0, 0, 0, 0)
        '
        'fechaal
        '
        Me.fechaal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaal.Location = New System.Drawing.Point(172, 6)
        Me.fechaal.Name = "fechaal"
        Me.fechaal.Size = New System.Drawing.Size(104, 20)
        Me.fechaal.TabIndex = 1
        Me.fechaal.Value = New Date(2010, 3, 31, 0, 0, 0, 0)
        '
        'boton_ok
        '
        Me.boton_ok.Location = New System.Drawing.Point(282, 5)
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(39, 21)
        Me.boton_ok.TabIndex = 2
        Me.boton_ok.Text = "Ok"
        Me.boton_ok.UseVisualStyleBackColor = True
        '
        'cxc_resumen_diarioBindingSource
        '
        Me.cxc_resumen_diarioBindingSource.DataMember = "cxc_resumen_diario"
        Me.cxc_resumen_diarioBindingSource.DataSource = Me.reporteDataSet
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxc_resumen_diarioTableAdapter
        '
        Me.cxc_resumen_diarioTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Del :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Al :"
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(736, 6)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(39, 21)
        Me.boton_salir.TabIndex = 5
        Me.boton_salir.Text = "Esc"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'cxc_resumen_diario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(787, 446)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cxc_resumen_diario"
        Me.Text = "cxc_resumen_diario"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.cxc_resumen_diarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents fechaal As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechadel As System.Windows.Forms.DateTimePicker
    Friend WithEvents boton_ok As System.Windows.Forms.Button
    Friend WithEvents cxc_resumen_diarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents cxc_resumen_diarioTableAdapter As AdminTegral.reporteDataSetTableAdapters.cxc_resumen_diarioTableAdapter
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
