<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadistica_de_cobranza
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.al = New System.Windows.Forms.DateTimePicker
        Me.del = New System.Windows.Forms.DateTimePicker
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.boton_por_agente = New System.Windows.Forms.ToolStripButton
        Me.boton_por_zona = New System.Windows.Forms.ToolStripButton
        Me.Reportagente = New Microsoft.Reporting.WinForms.ReportViewer
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.rpt_cobranza_x_zona_agenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpt_cobranza_x_zona_agenteTableAdapter = New AdminTegral.reporteDataSetTableAdapters.rpt_cobranza_x_zona_agenteTableAdapter
        Me.Reportzona = New Microsoft.Reporting.WinForms.ReportViewer
        Me.boton_ok = New System.Windows.Forms.Button
        Me.boton_salir = New System.Windows.Forms.ToolStripButton
        Me.boton_Esc = New System.Windows.Forms.Button
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_cobranza_x_zona_agenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Reportagente)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Reportzona)
        Me.SplitContainer1.Size = New System.Drawing.Size(766, 347)
        Me.SplitContainer1.SplitterDistance = 54
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_Esc)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_ok)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.al)
        Me.SplitContainer2.Panel1.Controls.Add(Me.del)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Size = New System.Drawing.Size(766, 54)
        Me.SplitContainer2.SplitterDistance = 340
        Me.SplitContainer2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Periodo :"
        '
        'al
        '
        Me.al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.al.Location = New System.Drawing.Point(123, 23)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(112, 20)
        Me.al.TabIndex = 10
        '
        'del
        '
        Me.del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.del.Location = New System.Drawing.Point(5, 23)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(112, 20)
        Me.del.TabIndex = 9
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_por_agente, Me.boton_por_zona, Me.boton_salir, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(422, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_por_agente
        '
        Me.boton_por_agente.Image = Global.AdminTegral.My.Resources.Resources.Administrator
        Me.boton_por_agente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_por_agente.Name = "boton_por_agente"
        Me.boton_por_agente.Size = New System.Drawing.Size(102, 36)
        Me.boton_por_agente.Text = "Por Agente"
        '
        'boton_por_zona
        '
        Me.boton_por_zona.Image = Global.AdminTegral.My.Resources.Resources.Map
        Me.boton_por_zona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_por_zona.Name = "boton_por_zona"
        Me.boton_por_zona.Size = New System.Drawing.Size(91, 36)
        Me.boton_por_zona.Text = "Por Zona"
        '
        'Reportagente
        '
        Me.Reportagente.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "reporteDataSet_rpt_cobranza_x_zona_agente"
        ReportDataSource1.Value = Me.rpt_cobranza_x_zona_agenteBindingSource
        Me.Reportagente.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Reportagente.LocalReport.ReportEmbeddedResource = "AdminTegral.est_cobranza_agente.rdlc"
        Me.Reportagente.Location = New System.Drawing.Point(0, 0)
        Me.Reportagente.Name = "Reportagente"
        Me.Reportagente.Size = New System.Drawing.Size(766, 289)
        Me.Reportagente.TabIndex = 0
        Me.Reportagente.Visible = False
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpt_cobranza_x_zona_agenteBindingSource
        '
        Me.rpt_cobranza_x_zona_agenteBindingSource.DataMember = "rpt_cobranza_x_zona_agente"
        Me.rpt_cobranza_x_zona_agenteBindingSource.DataSource = Me.reporteDataSet
        '
        'rpt_cobranza_x_zona_agenteTableAdapter
        '
        Me.rpt_cobranza_x_zona_agenteTableAdapter.ClearBeforeFill = True
        '
        'Reportzona
        '
        Me.Reportzona.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "reporteDataSet_rpt_cobranza_x_zona_agente"
        ReportDataSource2.Value = Me.rpt_cobranza_x_zona_agenteBindingSource
        Me.Reportzona.LocalReport.DataSources.Add(ReportDataSource2)
        Me.Reportzona.LocalReport.ReportEmbeddedResource = "AdminTegral.est_cobranza_zona.rdlc"
        Me.Reportzona.Location = New System.Drawing.Point(0, 0)
        Me.Reportzona.Name = "Reportzona"
        Me.Reportzona.Size = New System.Drawing.Size(766, 289)
        Me.Reportzona.TabIndex = 1
        Me.Reportzona.Visible = False
        '
        'boton_ok
        '
        Me.boton_ok.Location = New System.Drawing.Point(241, 21)
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(39, 23)
        Me.boton_ok.TabIndex = 12
        Me.boton_ok.Text = "Ok"
        Me.boton_ok.UseVisualStyleBackColor = True
        '
        'boton_salir
        '
        Me.boton_salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.boton_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_salir.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.boton_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(36, 36)
        Me.boton_salir.Text = "ToolStripButton1"
        '
        'boton_Esc
        '
        Me.boton_Esc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_Esc.Location = New System.Drawing.Point(286, 21)
        Me.boton_Esc.Name = "boton_Esc"
        Me.boton_Esc.Size = New System.Drawing.Size(39, 23)
        Me.boton_Esc.TabIndex = 13
        Me.boton_Esc.Text = "Esc"
        Me.boton_Esc.UseVisualStyleBackColor = True
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.repeat
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(100, 36)
        Me.ToolStripButton2.Text = "Otra Fecha"
        '
        'Estadistica_de_cobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_Esc
        Me.ClientSize = New System.Drawing.Size(766, 347)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Estadistica_de_cobranza"
        Me.Text = "Estadistica_de_cobranza"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_cobranza_x_zona_agenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents al As System.Windows.Forms.DateTimePicker
    Friend WithEvents del As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_por_agente As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_por_zona As System.Windows.Forms.ToolStripButton
    Friend WithEvents Reportagente As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rpt_cobranza_x_zona_agenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents rpt_cobranza_x_zona_agenteTableAdapter As AdminTegral.reporteDataSetTableAdapters.rpt_cobranza_x_zona_agenteTableAdapter
    Friend WithEvents Reportzona As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents boton_ok As System.Windows.Forms.Button
    Friend WithEvents boton_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_Esc As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
