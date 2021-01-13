<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lista_de_entradas
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CargoTextBox = New System.Windows.Forms.TextBox
        Me.ListasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox
        Me.factortxt = New System.Windows.Forms.TextBox
        Me.fechaal = New System.Windows.Forms.DateTimePicker
        Me.fechadel = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.excluirtxt = New System.Windows.Forms.TextBox
        Me.reporteDataSet = New AdminTegral.reporteDataSet
        Me.rpt_lista_de_entradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpt_lista_de_entradasTableAdapter = New AdminTegral.reporteDataSetTableAdapters.rpt_lista_de_entradasTableAdapter
        Me.ListasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
        Me.Button2 = New System.Windows.Forms.Button
        DescripcionLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_lista_de_entradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(12, 49)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(35, 13)
        DescripcionLabel.TabIndex = 7
        DescripcionLabel.Text = "Lista :"
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
        Me.SplitContainer1.Panel1.Controls.Add(Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DescripcionComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CargoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(DescripcionLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.factortxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechaal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fechadel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(602, 456)
        Me.SplitContainer1.SplitterDistance = 72
        Me.SplitContainer1.TabIndex = 0
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListasBindingSource, "cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(182, 50)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.ReadOnly = True
        Me.CargoTextBox.Size = New System.Drawing.Size(54, 20)
        Me.CargoTextBox.TabIndex = 9
        '
        'ListasBindingSource
        '
        Me.ListasBindingSource.DataMember = "Listas"
        Me.ListasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataSource = Me.ListasBindingSource
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(53, 48)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(220, 21)
        Me.DescripcionComboBox.TabIndex = 8
        Me.DescripcionComboBox.ValueMember = "id"
        '
        'factortxt
        '
        Me.factortxt.Location = New System.Drawing.Point(339, 46)
        Me.factortxt.Name = "factortxt"
        Me.factortxt.ReadOnly = True
        Me.factortxt.Size = New System.Drawing.Size(54, 20)
        Me.factortxt.TabIndex = 6
        '
        'fechaal
        '
        Me.fechaal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaal.Location = New System.Drawing.Point(227, 10)
        Me.fechaal.Name = "fechaal"
        Me.fechaal.Size = New System.Drawing.Size(95, 20)
        Me.fechaal.TabIndex = 2
        '
        'fechadel
        '
        Me.fechadel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechadel.Location = New System.Drawing.Point(112, 10)
        Me.fechadel.Name = "fechadel"
        Me.fechadel.Size = New System.Drawing.Size(95, 20)
        Me.fechadel.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ReportViewer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.excluirtxt)
        Me.SplitContainer2.Size = New System.Drawing.Size(602, 380)
        Me.SplitContainer2.SplitterDistance = 347
        Me.SplitContainer2.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.lista_de_entradas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(602, 347)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Excluir estos proveedores :"
        '
        'excluirtxt
        '
        Me.excluirtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AdminTegral.My.MySettings.Default, "excluirprovedores", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.excluirtxt.Location = New System.Drawing.Point(152, 6)
        Me.excluirtxt.Name = "excluirtxt"
        Me.excluirtxt.Size = New System.Drawing.Size(438, 20)
        Me.excluirtxt.TabIndex = 0
        Me.excluirtxt.Text = Global.AdminTegral.My.MySettings.Default.excluirprovedores
        '
        'reporteDataSet
        '
        Me.reporteDataSet.DataSetName = "reporteDataSet"
        Me.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpt_lista_de_entradasBindingSource
        '
        Me.rpt_lista_de_entradasBindingSource.DataMember = "rpt_lista_de_entradas"
        Me.rpt_lista_de_entradasBindingSource.DataSource = Me.reporteDataSet
        '
        'rpt_lista_de_entradasTableAdapter
        '
        Me.rpt_lista_de_entradasTableAdapter.ClearBeforeFill = True
        '
        'ListasTableAdapter
        '
        Me.ListasTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 12)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(102, 13)
        Label2.TabIndex = 10
        Label2.Text = "Periodo del reporte :"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(537, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 20)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(279, 51)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 13)
        Label3.TabIndex = 12
        Label3.Text = "Lista :"
        '
        'lista_de_entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(602, 456)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "lista_de_entradas"
        Me.Text = "Lista de Entradas "
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.reporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_lista_de_entradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fechaal As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechadel As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents excluirtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents factortxt As System.Windows.Forms.TextBox
    Friend WithEvents rpt_lista_de_entradasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reporteDataSet As AdminTegral.reporteDataSet
    Friend WithEvents rpt_lista_de_entradasTableAdapter As AdminTegral.reporteDataSetTableAdapters.rpt_lista_de_entradasTableAdapter
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents ListasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
