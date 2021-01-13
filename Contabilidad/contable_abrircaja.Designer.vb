<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contable_abrircaja
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.rpt_resumen_cobranzaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Log_cajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Log_cajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter
        Me.Log_cajasDataGridView = New System.Windows.Forms.DataGridView
        Me.idcaja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Abrio = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cerro = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.UsuariosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvcerrada = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsuariosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.usuariosTableAdapter
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.boton_imprimir = New System.Windows.Forms.ToolStripButton
        Me.boton_abrir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.boton_refresh = New System.Windows.Forms.ToolStripButton
        Me.dgvpagos = New System.Windows.Forms.DataGridView
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rpt_resumen_cobranzaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_resumen_cobranzaTableAdapter
        Me.sfecha = New System.Windows.Forms.DateTimePicker
        Me.Dgv_retiros = New System.Windows.Forms.DataGridView
        CType(Me.rpt_resumen_cobranzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log_cajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log_cajasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_retiros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpt_resumen_cobranzaBindingSource
        '
        Me.rpt_resumen_cobranzaBindingSource.DataMember = "rpt_resumen_cobranza"
        Me.rpt_resumen_cobranzaBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Log_cajasBindingSource
        '
        Me.Log_cajasBindingSource.DataMember = "log_cajas"
        Me.Log_cajasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Log_cajasTableAdapter
        '
        Me.Log_cajasTableAdapter.ClearBeforeFill = True
        '
        'Log_cajasDataGridView
        '
        Me.Log_cajasDataGridView.AllowUserToAddRows = False
        Me.Log_cajasDataGridView.AllowUserToDeleteRows = False
        Me.Log_cajasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Log_cajasDataGridView.AutoGenerateColumns = False
        Me.Log_cajasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Log_cajasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcaja, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Abrio, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.cerro, Me.dgvcerrada, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Log_cajasDataGridView.DataSource = Me.Log_cajasBindingSource
        Me.Log_cajasDataGridView.Location = New System.Drawing.Point(4, 74)
        Me.Log_cajasDataGridView.Name = "Log_cajasDataGridView"
        Me.Log_cajasDataGridView.ReadOnly = True
        Me.Log_cajasDataGridView.RowHeadersVisible = False
        Me.Log_cajasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Log_cajasDataGridView.Size = New System.Drawing.Size(780, 244)
        Me.Log_cajasDataGridView.TabIndex = 1
        '
        'idcaja
        '
        Me.idcaja.DataPropertyName = "id_caja"
        Me.idcaja.HeaderText = "id_caja"
        Me.idcaja.Name = "idcaja"
        Me.idcaja.ReadOnly = True
        Me.idcaja.Width = 66
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 59
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "horainicio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hora Inicio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 83
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "iduser_abrio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "iduser_abrio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 89
        '
        'Abrio
        '
        Me.Abrio.DataPropertyName = "iduser_abrio"
        Me.Abrio.DataSource = Me.UsuariosBindingSource
        Me.Abrio.DisplayMember = "nick"
        Me.Abrio.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Abrio.HeaderText = "Abrio"
        Me.Abrio.Name = "Abrio"
        Me.Abrio.ReadOnly = True
        Me.Abrio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Abrio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Abrio.ValueMember = "id_usuario"
        Me.Abrio.Width = 56
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "horacierre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hora Cierre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 85
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "iduser_cerro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "iduser_cerro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 90
        '
        'cerro
        '
        Me.cerro.DataPropertyName = "iduser_cerro"
        Me.cerro.DataSource = Me.UsuariosBindingSource1
        Me.cerro.DisplayMember = "Nombre"
        Me.cerro.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cerro.HeaderText = "cerro"
        Me.cerro.Name = "cerro"
        Me.cerro.ReadOnly = True
        Me.cerro.ValueMember = "id_usuario"
        Me.cerro.Width = 37
        '
        'UsuariosBindingSource1
        '
        Me.UsuariosBindingSource1.DataMember = "usuarios"
        Me.UsuariosBindingSource1.DataSource = Me.AdmintegralDataSet
        '
        'dgvcerrada
        '
        Me.dgvcerrada.DataPropertyName = "cerrada"
        Me.dgvcerrada.HeaderText = "cerrada"
        Me.dgvcerrada.Name = "dgvcerrada"
        Me.dgvcerrada.ReadOnly = True
        Me.dgvcerrada.Width = 49
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "serieF"
        Me.DataGridViewTextBoxColumn9.HeaderText = "serieF"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "folio"
        Me.DataGridViewTextBoxColumn10.HeaderText = "folio"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 51
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_imprimir, Me.boton_abrir, Me.ToolStripButton3, Me.boton_refresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 71)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_imprimir
        '
        Me.boton_imprimir.Image = Global.AdminTegral.My.Resources.Resources.Printer_Green
        Me.boton_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_imprimir.Name = "boton_imprimir"
        Me.boton_imprimir.Size = New System.Drawing.Size(160, 68)
        Me.boton_imprimir.Text = "Imprimir Detalle"
        '
        'boton_abrir
        '
        Me.boton_abrir.Image = Global.AdminTegral.My.Resources.Resources.Password
        Me.boton_abrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_abrir.Name = "boton_abrir"
        Me.boton_abrir.Size = New System.Drawing.Size(127, 68)
        Me.boton_abrir.Text = "Abrir Caja"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.AdminTegral.My.Resources.Resources.Log_Off
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'boton_refresh
        '
        Me.boton_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_refresh.Image = Global.AdminTegral.My.Resources.Resources.Restart_2
        Me.boton_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_refresh.Name = "boton_refresh"
        Me.boton_refresh.Size = New System.Drawing.Size(68, 68)
        Me.boton_refresh.Text = "Actualizar Datos"
        '
        'dgvpagos
        '
        Me.dgvpagos.AllowUserToAddRows = False
        Me.dgvpagos.AllowUserToDeleteRows = False
        Me.dgvpagos.AllowUserToOrderColumns = True
        Me.dgvpagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvpagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpagos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvpagos.Location = New System.Drawing.Point(4, 324)
        Me.dgvpagos.Name = "dgvpagos"
        Me.dgvpagos.ReadOnly = True
        Me.dgvpagos.RowHeadersVisible = False
        Me.dgvpagos.Size = New System.Drawing.Size(295, 80)
        Me.dgvpagos.TabIndex = 4
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "resumen"
        ReportDataSource1.Value = Me.rpt_resumen_cobranzaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.cajas_resumen_cobranza.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(39, 135)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(514, 145)
        Me.ReportViewer1.TabIndex = 12
        Me.ReportViewer1.Visible = False
        '
        'rpt_resumen_cobranzaTableAdapter
        '
        Me.rpt_resumen_cobranzaTableAdapter.ClearBeforeFill = True
        '
        'sfecha
        '
        Me.sfecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfecha.Location = New System.Drawing.Point(413, 12)
        Me.sfecha.Name = "sfecha"
        Me.sfecha.Size = New System.Drawing.Size(301, 26)
        Me.sfecha.TabIndex = 13
        '
        'Dgv_retiros
        '
        Me.Dgv_retiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_retiros.Location = New System.Drawing.Point(723, 417)
        Me.Dgv_retiros.Name = "Dgv_retiros"
        Me.Dgv_retiros.Size = New System.Drawing.Size(50, 15)
        Me.Dgv_retiros.TabIndex = 14
        Me.Dgv_retiros.Visible = False
        '
        'contable_abrircaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 444)
        Me.Controls.Add(Me.Dgv_retiros)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.sfecha)
        Me.Controls.Add(Me.dgvpagos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Log_cajasDataGridView)
        Me.Name = "contable_abrircaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "contable_abrircaja"
        CType(Me.rpt_resumen_cobranzaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log_cajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log_cajasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_retiros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Log_cajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Log_cajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter
    Friend WithEvents Log_cajasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents UsuariosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_abrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvpagos As System.Windows.Forms.DataGridView
    Friend WithEvents idcaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Abrio As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cerro As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgvcerrada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rpt_resumen_cobranzaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_resumen_cobranzaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_resumen_cobranzaTableAdapter
    Friend WithEvents sfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents boton_refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents Dgv_retiros As System.Windows.Forms.DataGridView
End Class
