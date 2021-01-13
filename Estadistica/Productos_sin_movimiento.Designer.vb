<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos_sin_movimiento
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
        Me.rpt_sin_ventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label2 = New System.Windows.Forms.Label
        Me.boton_refresh = New System.Windows.Forms.Button
        Me.grupotxt = New System.Windows.Forms.TextBox
        Me.alma = New System.Windows.Forms.CheckBox
        Me.AlmacenComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_almacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.boton_cargar = New System.Windows.Forms.Button
        Me.al = New System.Windows.Forms.DateTimePicker
        Me.del = New System.Windows.Forms.DateTimePicker
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rpt_sin_ventasTableAdapter = New AdminTegral.reporteDataSetTableAdapters.rpt_sin_ventasTableAdapter
        Me.Tbl_almacenesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
        Me.Label3 = New System.Windows.Forms.Label
        Me.proveedortxt = New System.Windows.Forms.TextBox
        Me.boton_busca_prov = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.rpt_sin_ventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rpt_sin_ventasBindingSource
        '
        Me.rpt_sin_ventasBindingSource.DataMember = "rpt_sin_ventas"
        Me.rpt_sin_ventasBindingSource.DataSource = Me.reporteDataSet
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.alma)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AlmacenComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_cargar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.al)
        Me.SplitContainer1.Panel1.Controls.Add(Me.del)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(880, 341)
        Me.SplitContainer1.SplitterDistance = 77
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Grupo :"
        '
        'boton_refresh
        '
        Me.boton_refresh.AutoSize = True
        Me.boton_refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.boton_refresh.Image = Global.AdminTegral.My.Resources.Resources.repeat
        Me.boton_refresh.Location = New System.Drawing.Point(408, 31)
        Me.boton_refresh.Name = "boton_refresh"
        Me.boton_refresh.Size = New System.Drawing.Size(30, 30)
        Me.boton_refresh.TabIndex = 8
        Me.boton_refresh.UseVisualStyleBackColor = True
        '
        'grupotxt
        '
        Me.grupotxt.Location = New System.Drawing.Point(85, 10)
        Me.grupotxt.Name = "grupotxt"
        Me.grupotxt.Size = New System.Drawing.Size(112, 20)
        Me.grupotxt.TabIndex = 7
        Me.grupotxt.Text = "TODOS"
        '
        'alma
        '
        Me.alma.AutoSize = True
        Me.alma.Location = New System.Drawing.Point(37, 43)
        Me.alma.Name = "alma"
        Me.alma.Size = New System.Drawing.Size(67, 17)
        Me.alma.TabIndex = 6
        Me.alma.Text = "Almacen"
        Me.alma.UseVisualStyleBackColor = True
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.DataSource = Me.Tbl_almacenesBindingSource
        Me.AlmacenComboBox.DisplayMember = "Almacen"
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Location = New System.Drawing.Point(110, 39)
        Me.AlmacenComboBox.Name = "AlmacenComboBox"
        Me.AlmacenComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AlmacenComboBox.TabIndex = 5
        Me.AlmacenComboBox.ValueMember = "id_almacen"
        '
        'Tbl_almacenesBindingSource
        '
        Me.Tbl_almacenesBindingSource.DataMember = "tbl_almacenes"
        Me.Tbl_almacenesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Periodo sin Ventas :"
        '
        'boton_cargar
        '
        Me.boton_cargar.Location = New System.Drawing.Point(316, 37)
        Me.boton_cargar.Name = "boton_cargar"
        Me.boton_cargar.Size = New System.Drawing.Size(75, 23)
        Me.boton_cargar.TabIndex = 2
        Me.boton_cargar.Text = "Cargar"
        Me.boton_cargar.UseVisualStyleBackColor = True
        '
        'al
        '
        Me.al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.al.Location = New System.Drawing.Point(222, 13)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(88, 20)
        Me.al.TabIndex = 1
        '
        'del
        '
        Me.del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.del.Location = New System.Drawing.Point(110, 13)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(88, 20)
        Me.del.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "tabla"
        ReportDataSource4.Value = Me.rpt_sin_ventasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.productos_sin_ventas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(880, 260)
        Me.ReportViewer1.TabIndex = 0
        '
        'rpt_sin_ventasTableAdapter
        '
        Me.rpt_sin_ventasTableAdapter.ClearBeforeFill = True
        '
        'Tbl_almacenesTableAdapter
        '
        Me.Tbl_almacenesTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Proveedor :"
        '
        'proveedortxt
        '
        Me.proveedortxt.Location = New System.Drawing.Point(85, 39)
        Me.proveedortxt.Name = "proveedortxt"
        Me.proveedortxt.Size = New System.Drawing.Size(282, 20)
        Me.proveedortxt.TabIndex = 11
        Me.proveedortxt.Text = "TODOS"
        '
        'boton_busca_prov
        '
        Me.boton_busca_prov.Location = New System.Drawing.Point(373, 36)
        Me.boton_busca_prov.Name = "boton_busca_prov"
        Me.boton_busca_prov.Size = New System.Drawing.Size(26, 23)
        Me.boton_busca_prov.TabIndex = 12
        Me.boton_busca_prov.Text = "..."
        Me.boton_busca_prov.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grupotxt)
        Me.Panel1.Controls.Add(Me.boton_busca_prov)
        Me.Panel1.Controls.Add(Me.boton_refresh)
        Me.Panel1.Controls.Add(Me.proveedortxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(426, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 72)
        Me.Panel1.TabIndex = 13
        '
        'Productos_sin_movimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 341)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Productos_sin_movimiento"
        Me.Text = "Productos_sin_movimiento"
        CType(Me.rpt_sin_ventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Tbl_almacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rpt_sin_ventasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents rpt_sin_ventasTableAdapter As AdminTegral.reporteDataSetTableAdapters.rpt_sin_ventasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boton_cargar As System.Windows.Forms.Button
    Friend WithEvents al As System.Windows.Forms.DateTimePicker
    Friend WithEvents del As System.Windows.Forms.DateTimePicker
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Tbl_almacenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_almacenesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
    Friend WithEvents AlmacenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents alma As System.Windows.Forms.CheckBox
    Friend WithEvents boton_refresh As System.Windows.Forms.Button
    Friend WithEvents grupotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents proveedortxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents boton_busca_prov As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
