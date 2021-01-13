<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Existencias_reporte
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
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.sql_existencias_x_almacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.boton_ok = New System.Windows.Forms.Button()
        Me.AlmacenComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_almacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sql_existencias_x_almacenTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_existencias_x_almacenTableAdapter()
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter()
        Me.reporteDataSet = New AdminTegral.reporteDataSet()
        AlmacenLabel = New System.Windows.Forms.Label()
        CType(Me.sql_existencias_x_almacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlmacenLabel
        '
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Location = New System.Drawing.Point(13, 12)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(51, 13)
        AlmacenLabel.TabIndex = 2
        AlmacenLabel.Text = "Almacen:"
        '
        'sql_existencias_x_almacenBindingSource
        '
        Me.sql_existencias_x_almacenBindingSource.DataMember = "sql_existencias_x_almacen"
        Me.sql_existencias_x_almacenBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(779, 461)
        Me.SplitContainer1.SplitterDistance = 49
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.boton_ok)
        Me.SplitContainer2.Panel2.Controls.Add(AlmacenLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.AlmacenComboBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(776, 44)
        Me.SplitContainer2.SplitterDistance = 478
        Me.SplitContainer2.TabIndex = 4
        '
        'boton_ok
        '
        Me.boton_ok.Location = New System.Drawing.Point(248, 9)
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(41, 23)
        Me.boton_ok.TabIndex = 2
        Me.boton_ok.Text = "Ok"
        Me.boton_ok.UseVisualStyleBackColor = True
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox.DisplayMember = "Almacen"
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Location = New System.Drawing.Point(70, 9)
        Me.AlmacenComboBox.Name = "AlmacenComboBox"
        Me.AlmacenComboBox.Size = New System.Drawing.Size(159, 21)
        Me.AlmacenComboBox.TabIndex = 3
        Me.AlmacenComboBox.ValueMember = "id_almacen"
        '
        'Tbl_almacenesBindingSource
        '
        Me.Tbl_almacenesBindingSource.DataMember = "tbl_almacenes"
        Me.Tbl_almacenesBindingSource.DataSource = Me.admintegralDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "tabla"
        ReportDataSource1.Value = Me.sql_existencias_x_almacenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.Existencias_almacen.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(779, 408)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_existencias_x_almacenTableAdapter
        '
        Me.sql_existencias_x_almacenTableAdapter.ClearBeforeFill = True
        '
        'Tbl_almacenesTableAdapter
        '
        Me.Tbl_almacenesTableAdapter.ClearBeforeFill = True
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Existencias_reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 461)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Existencias_reporte"
        Me.Text = "Existencias_reporte"
        CType(Me.sql_existencias_x_almacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_existencias_x_almacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents sql_existencias_x_almacenTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_existencias_x_almacenTableAdapter
    Friend WithEvents boton_ok As System.Windows.Forms.Button
    Friend WithEvents Tbl_almacenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_almacenesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
    Friend WithEvents AlmacenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
End Class
