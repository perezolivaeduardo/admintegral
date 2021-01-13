<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_reportes
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.rpt_resumen_cobranzaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.cxc_Reporte_de_cobranzaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.boton_resumen_x_iva = New System.Windows.Forms.Button()
        Me.boton_excel = New System.Windows.Forms.Button()
        Me.boton_salir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Boton_reporte = New System.Windows.Forms.Button()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.id = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cxc_Reporte_de_cobranzaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_Reporte_de_cobranzaTableAdapter()
        Me.AgentesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter()
        Me.rpt_resumen_cobranzaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_resumen_cobranzaTableAdapter()
        Me.fechaAL = New System.Windows.Forms.DateTimePicker()
        NombreLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.rpt_resumen_cobranzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxc_Reporte_de_cobranzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(7, 15)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Agente :"
        '
        'rpt_resumen_cobranzaBindingSource
        '
        Me.rpt_resumen_cobranzaBindingSource.DataMember = "rpt_resumen_cobranza"
        Me.rpt_resumen_cobranzaBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxc_Reporte_de_cobranzaBindingSource
        '
        Me.cxc_Reporte_de_cobranzaBindingSource.DataMember = "cxc_Reporte_de_cobranza"
        Me.cxc_Reporte_de_cobranzaBindingSource.DataSource = Me.admintegralDataSet
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechaAL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_resumen_x_iva)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_excel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Boton_reporte)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1155, 396)
        Me.SplitContainer1.SplitterDistance = 43
        Me.SplitContainer1.TabIndex = 0
        '
        'boton_resumen_x_iva
        '
        Me.boton_resumen_x_iva.Location = New System.Drawing.Point(910, 11)
        Me.boton_resumen_x_iva.Name = "boton_resumen_x_iva"
        Me.boton_resumen_x_iva.Size = New System.Drawing.Size(106, 23)
        Me.boton_resumen_x_iva.TabIndex = 8
        Me.boton_resumen_x_iva.Text = "Resumen x I.V.A."
        Me.boton_resumen_x_iva.UseVisualStyleBackColor = True
        '
        'boton_excel
        '
        Me.boton_excel.Location = New System.Drawing.Point(1022, 11)
        Me.boton_excel.Name = "boton_excel"
        Me.boton_excel.Size = New System.Drawing.Size(62, 23)
        Me.boton_excel.TabIndex = 7
        Me.boton_excel.Text = "Excel"
        Me.boton_excel.UseVisualStyleBackColor = True
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(1090, 11)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(62, 23)
        Me.boton_salir.TabIndex = 6
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(842, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Resumen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Boton_reporte
        '
        Me.Boton_reporte.Location = New System.Drawing.Point(778, 11)
        Me.Boton_reporte.Name = "Boton_reporte"
        Me.Boton_reporte.Size = New System.Drawing.Size(57, 23)
        Me.Boton_reporte.TabIndex = 4
        Me.Boton_reporte.Text = "Ok"
        Me.Boton_reporte.UseVisualStyleBackColor = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.AgentesBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(100, 11)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(260, 21)
        Me.NombreComboBox.TabIndex = 3
        Me.NombreComboBox.ValueMember = "id_agente"
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.admintegralDataSet
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(439, 11)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(106, 20)
        Me.fecha.TabIndex = 1
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(60, 12)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(38, 20)
        Me.id.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "admintegralDataSet_cxc_Reporte_de_cobranza"
        ReportDataSource1.Value = Me.cxc_Reporte_de_cobranzaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.cxc_reporte_cobranza.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1152, 349)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "resumen"
        ReportDataSource2.Value = Me.rpt_resumen_cobranzaBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "AdminTegral.cxc_resumen1.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1155, 343)
        Me.ReportViewer2.TabIndex = 1
        '
        'cxc_Reporte_de_cobranzaTableAdapter
        '
        Me.cxc_Reporte_de_cobranzaTableAdapter.ClearBeforeFill = True
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'rpt_resumen_cobranzaTableAdapter
        '
        Me.rpt_resumen_cobranzaTableAdapter.ClearBeforeFill = True
        '
        'fechaAL
        '
        Me.fechaAL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaAL.Location = New System.Drawing.Point(580, 11)
        Me.fechaAL.Name = "fechaAL"
        Me.fechaAL.Size = New System.Drawing.Size(106, 20)
        Me.fechaAL.TabIndex = 9
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(551, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(23, 13)
        Label1.TabIndex = 10
        Label1.Text = "AL:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(387, 14)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(46, 13)
        Label2.TabIndex = 11
        Label2.Text = "Periodo:"
        '
        'cxc_reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(1155, 396)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cxc_reportes"
        Me.Text = "cxc_reportes"
        CType(Me.rpt_resumen_cobranzaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxc_Reporte_de_cobranzaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cxc_Reporte_de_cobranzaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents cxc_Reporte_de_cobranzaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_Reporte_de_cobranzaTableAdapter
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents AgentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.AgentesTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Boton_reporte As System.Windows.Forms.Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rpt_resumen_cobranzaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_resumen_cobranzaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_resumen_cobranzaTableAdapter
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents boton_excel As System.Windows.Forms.Button
    Friend WithEvents boton_resumen_x_iva As System.Windows.Forms.Button
    Friend WithEvents fechaAL As System.Windows.Forms.DateTimePicker
End Class
