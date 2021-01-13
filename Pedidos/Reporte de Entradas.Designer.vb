<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_de_Entradas
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
        Me.sql_documentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.checkpv = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.nombreprovtxt = New System.Windows.Forms.TextBox
        Me.id_provtxt = New System.Windows.Forms.TextBox
        Me.boton_provecho = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.fecha_al = New System.Windows.Forms.DateTimePicker
        Me.fecha_del = New System.Windows.Forms.DateTimePicker
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.sql_documentosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentosTableAdapter
        CType(Me.sql_documentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sql_documentosBindingSource
        '
        Me.sql_documentosBindingSource.DataMember = "sql_documentos"
        Me.sql_documentosBindingSource.DataSource = Me.admintegralDataSet
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.checkpv)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_provecho)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha_al)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha_del)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(804, 410)
        Me.SplitContainer1.SplitterDistance = 39
        Me.SplitContainer1.TabIndex = 0
        '
        'checkpv
        '
        Me.checkpv.AutoSize = True
        Me.checkpv.Location = New System.Drawing.Point(328, 17)
        Me.checkpv.Name = "checkpv"
        Me.checkpv.Size = New System.Drawing.Size(78, 17)
        Me.checkpv.TabIndex = 7
        Me.checkpv.Text = "X provedor"
        Me.checkpv.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.nombreprovtxt)
        Me.Panel1.Controls.Add(Me.id_provtxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(407, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 39)
        Me.Panel1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nombreprovtxt
        '
        Me.nombreprovtxt.Location = New System.Drawing.Point(71, 9)
        Me.nombreprovtxt.Name = "nombreprovtxt"
        Me.nombreprovtxt.Size = New System.Drawing.Size(252, 20)
        Me.nombreprovtxt.TabIndex = 6
        '
        'id_provtxt
        '
        Me.id_provtxt.Location = New System.Drawing.Point(12, 9)
        Me.id_provtxt.Name = "id_provtxt"
        Me.id_provtxt.Size = New System.Drawing.Size(53, 20)
        Me.id_provtxt.TabIndex = 5
        '
        'boton_provecho
        '
        Me.boton_provecho.Location = New System.Drawing.Point(278, 11)
        Me.boton_provecho.Name = "boton_provecho"
        Me.boton_provecho.Size = New System.Drawing.Size(39, 23)
        Me.boton_provecho.TabIndex = 4
        Me.boton_provecho.Text = "Ok"
        Me.boton_provecho.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "al"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periodo del:"
        '
        'fecha_al
        '
        Me.fecha_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_al.Location = New System.Drawing.Point(185, 12)
        Me.fecha_al.Name = "fecha_al"
        Me.fecha_al.Size = New System.Drawing.Size(87, 20)
        Me.fecha_al.TabIndex = 1
        '
        'fecha_del
        '
        Me.fecha_del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_del.Location = New System.Drawing.Point(74, 12)
        Me.fecha_del.Name = "fecha_del"
        Me.fecha_del.Size = New System.Drawing.Size(87, 20)
        Me.fecha_del.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_sql_documentos"
        ReportDataSource1.Value = Me.sql_documentosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.Relacion_documentos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(804, 367)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_documentosTableAdapter
        '
        Me.sql_documentosTableAdapter.ClearBeforeFill = True
        '
        'Reporte_de_Entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 410)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Reporte_de_Entradas"
        Me.Text = "Reporte_de_Entradas"
        CType(Me.sql_documentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents boton_provecho As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_del As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_documentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents sql_documentosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentosTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nombreprovtxt As System.Windows.Forms.TextBox
    Friend WithEvents id_provtxt As System.Windows.Forms.TextBox
    Friend WithEvents checkpv As System.Windows.Forms.CheckBox
End Class
