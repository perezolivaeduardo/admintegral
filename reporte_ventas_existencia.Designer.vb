<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_ventas_existencia
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.reporte_ventas_existenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet()
        Me.panel = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.reporte_ventas_existenciaTableAdapter = New AdminTegral.reporteDataSetTableAdapters.reporte_ventas_existenciaTableAdapter()
        CType(Me.reporte_ventas_existenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.Panel1.SuspendLayout()
        Me.panel.Panel2.SuspendLayout()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'reporte_ventas_existenciaBindingSource
        '
        Me.reporte_ventas_existenciaBindingSource.DataMember = "reporte_ventas_existencia"
        Me.reporte_ventas_existenciaBindingSource.DataSource = Me.reporteDataSet
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panel
        '
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'panel.Panel1
        '
        Me.panel.Panel1.Controls.Add(Me.Button2)
        Me.panel.Panel1.Controls.Add(Me.Button3)
        Me.panel.Panel1.Controls.Add(Me.Label1)
        Me.panel.Panel1.Controls.Add(Me.nombre)
        Me.panel.Panel1.Controls.Add(Me.id)
        Me.panel.Panel1.Controls.Add(Me.Button1)
        '
        'panel.Panel2
        '
        Me.panel.Panel2.Controls.Add(Me.ReportViewer1)
        Me.panel.Size = New System.Drawing.Size(834, 366)
        Me.panel.SplitterDistance = 40
        Me.panel.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(656, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Preparar Reporte "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(763, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Proveedor :"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(123, 12)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(305, 20)
        Me.nombre.TabIndex = 2
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(67, 12)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(50, 20)
        Me.id.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(434, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "reporteDataSet_reporte_ventas_existencia"
        ReportDataSource1.Value = Me.reporte_ventas_existenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.reporte_ventas_existencia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(834, 322)
        Me.ReportViewer1.TabIndex = 0
        '
        'reporte_ventas_existenciaTableAdapter
        '
        Me.reporte_ventas_existenciaTableAdapter.ClearBeforeFill = True
        '
        'reporte_ventas_existencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 366)
        Me.Controls.Add(Me.panel)
        Me.Name = "reporte_ventas_existencia"
        Me.Text = "Reporte de Ventas y existencia"
        CType(Me.reporte_ventas_existenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.Panel1.ResumeLayout(False)
        Me.panel.Panel1.PerformLayout()
        Me.panel.Panel2.ResumeLayout(False)
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reporte_ventas_existenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents reporte_ventas_existenciaTableAdapter As AdminTegral.reporteDataSetTableAdapters.reporte_ventas_existenciaTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
