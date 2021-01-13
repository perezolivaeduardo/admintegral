<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_NC
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
        Me.sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.opnc = New System.Windows.Forms.RadioButton
        Me.opboni = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.fecha_al = New System.Windows.Forms.DateTimePicker
        Me.fecha_del = New System.Windows.Forms.DateTimePicker
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
        CType(Me.sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sql_documentos_clientesBindingSource
        '
        Me.sql_documentos_clientesBindingSource.DataMember = "sql_documentos_clientes"
        Me.sql_documentos_clientesBindingSource.DataSource = Me.admintegralDataSet
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.opnc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.opboni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha_al)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha_del)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(744, 301)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 0
        '
        'opnc
        '
        Me.opnc.AutoSize = True
        Me.opnc.Location = New System.Drawing.Point(335, 12)
        Me.opnc.Name = "opnc"
        Me.opnc.Size = New System.Drawing.Size(68, 17)
        Me.opnc.TabIndex = 6
        Me.opnc.TabStop = True
        Me.opnc.Text = "N.credito"
        Me.opnc.UseVisualStyleBackColor = True
        '
        'opboni
        '
        Me.opboni.AutoSize = True
        Me.opboni.Location = New System.Drawing.Point(408, 12)
        Me.opboni.Name = "opboni"
        Me.opboni.Size = New System.Drawing.Size(94, 17)
        Me.opboni.TabIndex = 5
        Me.opboni.TabStop = True
        Me.opboni.Text = "Bonificaciones"
        Me.opboni.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(508, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Al"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periodo del :"
        '
        'fecha_al
        '
        Me.fecha_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_al.Location = New System.Drawing.Point(216, 13)
        Me.fecha_al.Name = "fecha_al"
        Me.fecha_al.Size = New System.Drawing.Size(100, 20)
        Me.fecha_al.TabIndex = 1
        '
        'fecha_del
        '
        Me.fecha_del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_del.Location = New System.Drawing.Point(87, 13)
        Me.fecha_del.Name = "fecha_del"
        Me.fecha_del.Size = New System.Drawing.Size(101, 20)
        Me.fecha_del.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_sql_documentos_clientes"
        ReportDataSource1.Value = Me.sql_documentos_clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.Relacion_de_NC.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(744, 256)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_documentos_clientesTableAdapter
        '
        Me.sql_documentos_clientesTableAdapter.ClearBeforeFill = True
        '
        'listado_NC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 301)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "listado_NC"
        Me.Text = "Relacion de Notas de Credito"
        CType(Me.sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_del As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents opnc As System.Windows.Forms.RadioButton
    Friend WithEvents opboni As System.Windows.Forms.RadioButton
End Class
