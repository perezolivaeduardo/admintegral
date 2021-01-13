<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class est_ventas_x_dia_tda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(est_ventas_x_dia_tda))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.EST_vtas_x_da_x_diaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.al = New System.Windows.Forms.DateTimePicker
        Me.del = New System.Windows.Forms.DateTimePicker
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.dateweek = New System.Windows.Forms.DateTimePicker
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TSB_tienda = New System.Windows.Forms.ToolStripButton
        Me.TSBvendedor = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.EST_vtas_x_da_x_diaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.EST_vtas_x_da_x_diaTableAdapter
        Me.boton_periodo_vendedor = New System.Windows.Forms.ToolStripButton
        CType(Me.EST_vtas_x_da_x_diaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EST_vtas_x_da_x_diaBindingSource
        '
        Me.EST_vtas_x_da_x_diaBindingSource.DataMember = "EST_vtas_x_da_x_dia"
        Me.EST_vtas_x_da_x_diaBindingSource.DataSource = Me.admintegralDataSet
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.al)
        Me.SplitContainer1.Panel1.Controls.Add(Me.del)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(909, 381)
        Me.SplitContainer1.SplitterDistance = 77
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Periodo :"
        '
        'al
        '
        Me.al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.al.Location = New System.Drawing.Point(176, 43)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(112, 20)
        Me.al.TabIndex = 7
        '
        'del
        '
        Me.del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.del.Location = New System.Drawing.Point(58, 43)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(112, 20)
        Me.del.TabIndex = 6
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.dateweek)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Size = New System.Drawing.Size(909, 37)
        Me.SplitContainer2.SplitterDistance = 187
        Me.SplitContainer2.TabIndex = 5
        '
        'dateweek
        '
        Me.dateweek.CustomFormat = "week"
        Me.dateweek.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateweek.Location = New System.Drawing.Point(23, 9)
        Me.dateweek.Name = "dateweek"
        Me.dateweek.Size = New System.Drawing.Size(102, 20)
        Me.dateweek.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_tienda, Me.TSBvendedor, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.boton_periodo_vendedor, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(658, 39)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSB_tienda
        '
        Me.TSB_tienda.Image = Global.AdminTegral.My.Resources.Resources.Home_Page_3
        Me.TSB_tienda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_tienda.Name = "TSB_tienda"
        Me.TSB_tienda.Size = New System.Drawing.Size(100, 36)
        Me.TSB_tienda.Text = "Por Tienda"
        '
        'TSBvendedor
        '
        Me.TSBvendedor.Image = Global.AdminTegral.My.Resources.Resources.Administrator
        Me.TSBvendedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBvendedor.Name = "TSBvendedor"
        Me.TSBvendedor.Size = New System.Drawing.Size(115, 36)
        Me.TSBvendedor.Text = "Por Vendedor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.Log_Off
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Map
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(91, 36)
        Me.ToolStripButton2.Text = "Por Zona"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(84, 36)
        Me.ToolStripButton3.Text = "Periodo"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.Visible = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(0, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(757, 304)
        Me.dgv.TabIndex = 2
        Me.dgv.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_EST_vtas_x_da_x_dia"
        ReportDataSource1.Value = Me.EST_vtas_x_da_x_diaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.est_vta_x_dia_tda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(909, 300)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "tabla"
        ReportDataSource2.Value = Me.EST_vtas_x_da_x_diaBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "AdminTegral.est_vta_x_tda.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(909, 300)
        Me.ReportViewer2.TabIndex = 1
        Me.ReportViewer2.Visible = False
        '
        'EST_vtas_x_da_x_diaTableAdapter
        '
        Me.EST_vtas_x_da_x_diaTableAdapter.ClearBeforeFill = True
        '
        'boton_periodo_vendedor
        '
        Me.boton_periodo_vendedor.Image = CType(resources.GetObject("boton_periodo_vendedor.Image"), System.Drawing.Image)
        Me.boton_periodo_vendedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_periodo_vendedor.Name = "boton_periodo_vendedor"
        Me.boton_periodo_vendedor.Size = New System.Drawing.Size(147, 36)
        Me.boton_periodo_vendedor.Text = "Vendedores/period."
        '
        'est_ventas_x_dia_tda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 381)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "est_ventas_x_dia_tda"
        Me.Text = "Ventas de la Semana"
        CType(Me.EST_vtas_x_da_x_diaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EST_vtas_x_da_x_diaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents EST_vtas_x_da_x_diaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.EST_vtas_x_da_x_diaTableAdapter
    Friend WithEvents dateweek As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_tienda As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBvendedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents al As System.Windows.Forms.DateTimePicker
    Friend WithEvents del As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boton_periodo_vendedor As System.Windows.Forms.ToolStripButton
End Class
