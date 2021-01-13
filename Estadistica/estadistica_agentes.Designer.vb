<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estadistica_agentes
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_generar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.año = New System.Windows.Forms.NumericUpDown
        Me.mes = New System.Windows.Forms.ComboBox
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.kagentes = New System.Windows.Forms.TextBox
        Me.cxc_est_agentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.cxc_est_agentesTableAdapter = New AdminTegral.reporteDataSetTableAdapters.cxc_est_agentesTableAdapter
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.año, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxc_est_agentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.kagentes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_generar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.año)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(914, 416)
        Me.SplitContainer1.SplitterDistance = 52
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.Location = New System.Drawing.Point(836, 14)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_generar
        '
        Me.btn_generar.Enabled = False
        Me.btn_generar.Location = New System.Drawing.Point(288, 12)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(108, 23)
        Me.btn_generar.TabIndex = 3
        Me.btn_generar.Text = "Generar de Nuevo"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'año
        '
        Me.año.Location = New System.Drawing.Point(136, 12)
        Me.año.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.año.Minimum = New Decimal(New Integer() {2009, 0, 0, 0})
        Me.año.Name = "año"
        Me.año.Size = New System.Drawing.Size(65, 20)
        Me.año.TabIndex = 1
        Me.año.Value = New Decimal(New Integer() {2011, 0, 0, 0})
        '
        'mes
        '
        Me.mes.FormattingEnabled = True
        Me.mes.Items.AddRange(New Object() {"Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"})
        Me.mes.Location = New System.Drawing.Point(9, 12)
        Me.mes.Name = "mes"
        Me.mes.Size = New System.Drawing.Size(121, 21)
        Me.mes.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "reporteDataSet_cxc_est_agentes"
        ReportDataSource1.Value = Me.cxc_est_agentesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.comparativo_recuperacion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(914, 360)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(402, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "# de Agentes  (separado por comas)"
        '
        'kagentes
        '
        Me.kagentes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AdminTegral.My.MySettings.Default, "kagentes", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.kagentes.Location = New System.Drawing.Point(587, 16)
        Me.kagentes.Name = "kagentes"
        Me.kagentes.Size = New System.Drawing.Size(188, 20)
        Me.kagentes.TabIndex = 5
        Me.kagentes.Text = Global.AdminTegral.My.MySettings.Default.kagentes
        '
        'cxc_est_agentesBindingSource
        '
        Me.cxc_est_agentesBindingSource.DataMember = "cxc_est_agentes"
        Me.cxc_est_agentesBindingSource.DataSource = Me.reporteDataSet
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxc_est_agentesTableAdapter
        '
        Me.cxc_est_agentesTableAdapter.ClearBeforeFill = True
        '
        'estadistica_agentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(914, 416)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "estadistica_agentes"
        Me.Text = "Comparativo Ventas  vs recuperacion"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.año, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxc_est_agentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents mes As System.Windows.Forms.ComboBox
    Friend WithEvents año As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cxc_est_agentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents cxc_est_agentesTableAdapter As AdminTegral.reporteDataSetTableAdapters.cxc_est_agentesTableAdapter
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kagentes As System.Windows.Forms.TextBox
End Class
