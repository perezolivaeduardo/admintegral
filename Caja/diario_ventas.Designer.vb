<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diario_ventas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.boton_fac_cont = New System.Windows.Forms.Button()
        Me.boton_f_credito = New System.Windows.Forms.Button()
        Me.boton_facturas = New System.Windows.Forms.Button()
        Me.boton_tiket = New System.Windows.Forms.Button()
        Me.Boton_todo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.serietxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fechaAL = New System.Windows.Forms.DateTimePicker()
        Me.sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechaAL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_fac_cont)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_f_credito)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_facturas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_tiket)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Boton_todo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.serietxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(889, 472)
        Me.SplitContainer1.SplitterDistance = 61
        Me.SplitContainer1.TabIndex = 0
        '
        'boton_fac_cont
        '
        Me.boton_fac_cont.Location = New System.Drawing.Point(649, 7)
        Me.boton_fac_cont.Name = "boton_fac_cont"
        Me.boton_fac_cont.Size = New System.Drawing.Size(92, 23)
        Me.boton_fac_cont.TabIndex = 8
        Me.boton_fac_cont.Text = "Fact. Contado"
        Me.boton_fac_cont.UseVisualStyleBackColor = True
        '
        'boton_f_credito
        '
        Me.boton_f_credito.Location = New System.Drawing.Point(546, 7)
        Me.boton_f_credito.Name = "boton_f_credito"
        Me.boton_f_credito.Size = New System.Drawing.Size(97, 23)
        Me.boton_f_credito.TabIndex = 7
        Me.boton_f_credito.Text = "Fact. Credito"
        Me.boton_f_credito.UseVisualStyleBackColor = True
        '
        'boton_facturas
        '
        Me.boton_facturas.Location = New System.Drawing.Point(486, 6)
        Me.boton_facturas.Name = "boton_facturas"
        Me.boton_facturas.Size = New System.Drawing.Size(54, 23)
        Me.boton_facturas.TabIndex = 6
        Me.boton_facturas.Text = "Facturas"
        Me.boton_facturas.UseVisualStyleBackColor = True
        '
        'boton_tiket
        '
        Me.boton_tiket.Location = New System.Drawing.Point(426, 6)
        Me.boton_tiket.Name = "boton_tiket"
        Me.boton_tiket.Size = New System.Drawing.Size(54, 23)
        Me.boton_tiket.TabIndex = 5
        Me.boton_tiket.Text = "Tiket"
        Me.boton_tiket.UseVisualStyleBackColor = True
        '
        'Boton_todo
        '
        Me.Boton_todo.Location = New System.Drawing.Point(366, 5)
        Me.Boton_todo.Name = "Boton_todo"
        Me.Boton_todo.Size = New System.Drawing.Size(54, 23)
        Me.Boton_todo.TabIndex = 4
        Me.Boton_todo.Text = "Periodo"
        Me.Boton_todo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha  del :"
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(150, 6)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(81, 20)
        Me.fecha.TabIndex = 2
        '
        'serietxt
        '
        Me.serietxt.Location = New System.Drawing.Point(52, 6)
        Me.serietxt.Name = "serietxt"
        Me.serietxt.Size = New System.Drawing.Size(28, 20)
        Me.serietxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serie "
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_sql_documentos_clientes"
        ReportDataSource1.Value = Me.sql_documentos_clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.Diario_ventas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(889, 407)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "al:"
        '
        'fechaAL
        '
        Me.fechaAL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaAL.Location = New System.Drawing.Point(261, 8)
        Me.fechaAL.Name = "fechaAL"
        Me.fechaAL.Size = New System.Drawing.Size(85, 20)
        Me.fechaAL.TabIndex = 10
        '
        'sql_documentos_clientesBindingSource
        '
        Me.sql_documentos_clientesBindingSource.DataMember = "sql_documentos_clientes"
        Me.sql_documentos_clientesBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sql_documentos_clientesTableAdapter
        '
        Me.sql_documentos_clientesTableAdapter.ClearBeforeFill = True
        '
        'diario_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 472)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "diario_ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "diario_ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Boton_todo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents serietxt As System.Windows.Forms.TextBox
    Friend WithEvents boton_facturas As System.Windows.Forms.Button
    Friend WithEvents boton_tiket As System.Windows.Forms.Button
    Friend WithEvents boton_f_credito As System.Windows.Forms.Button
    Friend WithEvents boton_fac_cont As System.Windows.Forms.Button
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents fechaAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
