<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos_imprimir
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
        Me.Reportpedido = New Microsoft.Reporting.WinForms.ReportViewer
        Me.sql_pedido_detalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.sql_pedido_detalleTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_pedido_detalleTableAdapter
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.sql_pedido_detalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Reportpedido)
        Me.SplitContainer1.Size = New System.Drawing.Size(907, 506)
        Me.SplitContainer1.SplitterDistance = 39
        Me.SplitContainer1.TabIndex = 0
        '
        'Reportpedido
        '
        Me.Reportpedido.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_sql_pedido_detalle"
        ReportDataSource1.Value = Me.sql_pedido_detalleBindingSource
        Me.Reportpedido.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Reportpedido.LocalReport.ReportEmbeddedResource = "AdminTegral.Pedido_Imprimir.rdlc"
        Me.Reportpedido.Location = New System.Drawing.Point(0, 0)
        Me.Reportpedido.Name = "Reportpedido"
        Me.Reportpedido.Size = New System.Drawing.Size(907, 463)
        Me.Reportpedido.TabIndex = 0
        '
        'sql_pedido_detalleBindingSource
        '
        Me.sql_pedido_detalleBindingSource.DataMember = "sql_pedido_detalle"
        Me.sql_pedido_detalleBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sql_pedido_detalleTableAdapter
        '
        Me.sql_pedido_detalleTableAdapter.ClearBeforeFill = True
        '
        'Pedidos_imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Pedidos_imprimir"
        Me.Text = "Pedidos_imprimir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.sql_pedido_detalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Reportpedido As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_pedido_detalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents sql_pedido_detalleTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_pedido_detalleTableAdapter
End Class
