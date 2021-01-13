<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_relacion_Cheques
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.boton_salir = New System.Windows.Forms.Button
        Me.boton_ok = New System.Windows.Forms.Button
        Me.depositar = New System.Windows.Forms.RadioButton
        Me.recibidos = New System.Windows.Forms.RadioButton
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.fechaal = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cxc_relacion_chequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet
        Me.cxc_relacion_chequesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cxc_relacion_chequesTableAdapter
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cxc_relacion_chequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechaal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_ok)
        Me.SplitContainer1.Panel1.Controls.Add(Me.depositar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.recibidos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(839, 264)
        Me.SplitContainer1.SplitterDistance = 42
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminTegral.My.Resources.Resources.Vista__155_
        Me.PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'boton_salir
        '
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(752, 9)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 4
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'boton_ok
        '
        Me.boton_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_ok.Location = New System.Drawing.Point(671, 9)
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(75, 23)
        Me.boton_ok.TabIndex = 3
        Me.boton_ok.Text = "Ok"
        Me.boton_ok.UseVisualStyleBackColor = True
        '
        'depositar
        '
        Me.depositar.AutoSize = True
        Me.depositar.Location = New System.Drawing.Point(411, 12)
        Me.depositar.Name = "depositar"
        Me.depositar.Size = New System.Drawing.Size(89, 17)
        Me.depositar.TabIndex = 2
        Me.depositar.Text = "Por Depositar"
        Me.depositar.UseVisualStyleBackColor = True
        '
        'recibidos
        '
        Me.recibidos.AutoSize = True
        Me.recibidos.Checked = True
        Me.recibidos.Location = New System.Drawing.Point(305, 12)
        Me.recibidos.Name = "recibidos"
        Me.recibidos.Size = New System.Drawing.Size(72, 17)
        Me.recibidos.TabIndex = 1
        Me.recibidos.TabStop = True
        Me.recibidos.Text = "Recibidos"
        Me.recibidos.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(77, 12)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(97, 20)
        Me.fecha.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "admintegralDataSet_cxc_relacion_cheques"
        ReportDataSource1.Value = Me.cxc_relacion_chequesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.relacion de Cheques.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(839, 218)
        Me.ReportViewer1.TabIndex = 0
        '
        'fechaal
        '
        Me.fechaal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaal.Location = New System.Drawing.Point(202, 12)
        Me.fechaal.Name = "fechaal"
        Me.fechaal.Size = New System.Drawing.Size(97, 20)
        Me.fechaal.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Del:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Al:"
        '
        'cxc_relacion_chequesBindingSource
        '
        Me.cxc_relacion_chequesBindingSource.DataMember = "cxc_relacion_cheques"
        Me.cxc_relacion_chequesBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cxc_relacion_chequesTableAdapter
        '
        Me.cxc_relacion_chequesTableAdapter.ClearBeforeFill = True
        '
        'cxc_relacion_Cheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(839, 264)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cxc_relacion_Cheques"
        Me.Text = "cxc_relacion_Cheques"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cxc_relacion_chequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cxc_relacion_chequesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents cxc_relacion_chequesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cxc_relacion_chequesTableAdapter
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents boton_ok As System.Windows.Forms.Button
    Friend WithEvents depositar As System.Windows.Forms.RadioButton
    Friend WithEvents recibidos As System.Windows.Forms.RadioButton
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fechaal As System.Windows.Forms.DateTimePicker
End Class
