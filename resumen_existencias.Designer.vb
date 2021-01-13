<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resumen_existencias
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.sql_resumen_de_exist_costo_almacen_grupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.sql_resumen_de_exist_costo_almacen_grupoTableAdapter = New AdminTegral.reporteDataSetTableAdapters.sql_resumen_de_exist_costo_almacen_grupoTableAdapter
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_ok = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        CType(Me.sql_resumen_de_exist_costo_almacen_grupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "reporteDataSet_sql_resumen_de_exist_costo_almacen_grupo"
        ReportDataSource2.Value = Me.sql_resumen_de_exist_costo_almacen_grupoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.resumne_exis_alm_gpo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 51)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(580, 361)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_resumen_de_exist_costo_almacen_grupoBindingSource
        '
        Me.sql_resumen_de_exist_costo_almacen_grupoBindingSource.DataMember = "sql_resumen_de_exist_costo_almacen_grupo"
        Me.sql_resumen_de_exist_costo_almacen_grupoBindingSource.DataSource = Me.reporteDataSet
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sql_resumen_de_exist_costo_almacen_grupoTableAdapter
        '
        Me.sql_resumen_de_exist_costo_almacen_grupoTableAdapter.ClearBeforeFill = True
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(120, 12)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(102, 20)
        Me.fecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha de existencia :"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(228, 13)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 3
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.Location = New System.Drawing.Point(527, 13)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(53, 23)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "Esc"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'resumen_existencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(581, 408)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "resumen_existencias"
        Me.Text = "resumen_existencias"
        CType(Me.sql_resumen_de_exist_costo_almacen_grupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_resumen_de_exist_costo_almacen_grupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents sql_resumen_de_exist_costo_almacen_grupoTableAdapter As AdminTegral.reporteDataSetTableAdapters.sql_resumen_de_exist_costo_almacen_grupoTableAdapter
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
End Class
