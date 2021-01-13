<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kardex_resumen
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
        Me.sql_kardex_productoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.sql_kardex_productoTableAdapter = New AdminTegral.reporteDataSetTableAdapters.sql_kardex_productoTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.boton_salir = New System.Windows.Forms.Button
        CType(Me.sql_kardex_productoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sql_kardex_productoBindingSource
        '
        Me.sql_kardex_productoBindingSource.DataMember = "sql_kardex_producto"
        Me.sql_kardex_productoBindingSource.DataSource = Me.reporteDataSet
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Size = New System.Drawing.Size(637, 357)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "tabla"
        ReportDataSource1.Value = Me.sql_kardex_productoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.repote_kardex_producto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(637, 357)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_kardex_productoTableAdapter
        '
        Me.sql_kardex_productoTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(65, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sin Movimientos"
        '
        'boton_salir
        '
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(406, 128)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 2
        Me.boton_salir.Text = "Esc"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'Kardex_resumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(637, 357)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Kardex_resumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.sql_kardex_productoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_kardex_productoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents sql_kardex_productoTableAdapter As AdminTegral.reporteDataSetTableAdapters.sql_kardex_productoTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boton_salir As System.Windows.Forms.Button
End Class
