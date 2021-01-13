<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cierre_de_mes
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
        Dim DelLabel As System.Windows.Forms.Label
        Dim AlLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Sql_kardex_resumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntegraDataSet = New AdminTegral.integraDataSet()
        Me.DelDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Sys_periodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sql_kardex_resumenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sys_periodoTableAdapter = New AdminTegral.integraDataSetTableAdapters.sys_periodoTableAdapter()
        Me.Sql_kardex_resumenTableAdapter = New AdminTegral.integraDataSetTableAdapters.sql_kardex_resumenTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        DelLabel = New System.Windows.Forms.Label()
        AlLabel = New System.Windows.Forms.Label()
        CType(Me.Sql_kardex_resumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sys_periodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_kardex_resumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DelLabel
        '
        DelLabel.AutoSize = True
        DelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DelLabel.Location = New System.Drawing.Point(12, 14)
        DelLabel.Name = "DelLabel"
        DelLabel.Size = New System.Drawing.Size(91, 18)
        DelLabel.TabIndex = 3
        DelLabel.Text = "Periodo del :"
        '
        'AlLabel
        '
        AlLabel.AutoSize = True
        AlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlLabel.Location = New System.Drawing.Point(225, 16)
        AlLabel.Name = "AlLabel"
        AlLabel.Size = New System.Drawing.Size(23, 18)
        AlLabel.TabIndex = 5
        AlLabel.Text = "al:"
        '
        'Sql_kardex_resumenBindingSource
        '
        Me.Sql_kardex_resumenBindingSource.DataMember = "sql_kardex_resumen"
        Me.Sql_kardex_resumenBindingSource.DataSource = Me.IntegraDataSet
        '
        'IntegraDataSet
        '
        Me.IntegraDataSet.DataSetName = "integraDataSet"
        Me.IntegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DelDateTimePicker
        '
        Me.DelDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sys_periodoBindingSource, "del", True))
        Me.DelDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DelDateTimePicker.Location = New System.Drawing.Point(109, 14)
        Me.DelDateTimePicker.Name = "DelDateTimePicker"
        Me.DelDateTimePicker.Size = New System.Drawing.Size(108, 24)
        Me.DelDateTimePicker.TabIndex = 4
        '
        'Sys_periodoBindingSource
        '
        Me.Sys_periodoBindingSource.DataMember = "sys_periodo"
        Me.Sys_periodoBindingSource.DataSource = Me.IntegraDataSet
        '
        'AlDateTimePicker
        '
        Me.AlDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sys_periodoBindingSource, "al", True))
        Me.AlDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AlDateTimePicker.Location = New System.Drawing.Point(255, 12)
        Me.AlDateTimePicker.Name = "AlDateTimePicker"
        Me.AlDateTimePicker.Size = New System.Drawing.Size(108, 24)
        Me.AlDateTimePicker.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(719, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "GENERAR CIERRE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sql_kardex_resumenDataGridView
        '
        Me.Sql_kardex_resumenDataGridView.AutoGenerateColumns = False
        Me.Sql_kardex_resumenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_kardex_resumenDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_kardex_resumenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_kardex_resumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Sql_kardex_resumenDataGridView.DataSource = Me.Sql_kardex_resumenBindingSource
        Me.Sql_kardex_resumenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_kardex_resumenDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Sql_kardex_resumenDataGridView.Name = "Sql_kardex_resumenDataGridView"
        Me.Sql_kardex_resumenDataGridView.RowHeadersVisible = False
        Me.Sql_kardex_resumenDataGridView.Size = New System.Drawing.Size(843, 323)
        Me.Sql_kardex_resumenDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 86
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 58
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "inicial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "inicial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 58
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "entradas"
        Me.DataGridViewTextBoxColumn5.HeaderText = "entradas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 73
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "devoluciones"
        Me.DataGridViewTextBoxColumn6.HeaderText = "devoluciones"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 95
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ventas"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ventas"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 64
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "nc"
        Me.DataGridViewTextBoxColumn8.HeaderText = "nc"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 44
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ajustes"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ajustes"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 65
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "final"
        Me.DataGridViewTextBoxColumn10.HeaderText = "final"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 51
        '
        'Sys_periodoTableAdapter
        '
        Me.Sys_periodoTableAdapter.ClearBeforeFill = True
        '
        'Sql_kardex_resumenTableAdapter
        '
        Me.Sql_kardex_resumenTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(857, 355)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Sql_kardex_resumenDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(849, 329)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "tabla"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(849, 329)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reporte"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sql_kardex_resumenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.Cierres de mes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(843, 323)
        Me.ReportViewer1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 427)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(871, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cierre_de_mes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 449)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DelLabel)
        Me.Controls.Add(Me.DelDateTimePicker)
        Me.Controls.Add(AlLabel)
        Me.Controls.Add(Me.AlDateTimePicker)
        Me.Name = "cierre_de_mes"
        Me.Text = "CIERRE DE MES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Sql_kardex_resumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sys_periodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_kardex_resumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IntegraDataSet As AdminTegral.integraDataSet
    Friend WithEvents Sys_periodoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sys_periodoTableAdapter As AdminTegral.integraDataSetTableAdapters.sys_periodoTableAdapter
    Friend WithEvents DelDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AlDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Sql_kardex_resumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_kardex_resumenTableAdapter As AdminTegral.integraDataSetTableAdapters.sql_kardex_resumenTableAdapter
    Friend WithEvents Sql_kardex_resumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
