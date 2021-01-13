<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja_corte
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
        Me.log_cajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.admintegralDataSet = New AdminTegral.admintegralDataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.serietxt = New System.Windows.Forms.TextBox()
        Me.boton_facturadia = New System.Windows.Forms.Button()
        Me.foliotxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reportadotxt = New System.Windows.Forms.TextBox()
        Me.dgvmoneda = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.boton_salir = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dgvfolios = New System.Windows.Forms.DataGridView()
        Me.dgvresumen = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cobrado = New System.Windows.Forms.TextBox()
        Me.dgcobrado = New System.Windows.Forms.DataGridView()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.rpt_corte_foliosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpt_corte_Formas_pagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpt_corte_documento_formaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_monedasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpt_corte_retirosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpt_corte_foliosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_corte_foliosTableAdapter()
        Me.rpt_corte_Formas_pagoTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_corte_Formas_pagoTableAdapter()
        Me.rpt_corte_documento_formaTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_corte_documento_formaTableAdapter()
        Me.tbl_monedasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.tbl_monedasTableAdapter()
        Me.rpt_corte_retirosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.rpt_corte_retirosTableAdapter()
        Me.log_cajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter()
        CType(Me.log_cajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvmoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvfolios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvresumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgcobrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_corte_foliosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_corte_Formas_pagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_corte_documento_formaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_monedasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_corte_retirosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'log_cajasBindingSource
        '
        Me.log_cajasBindingSource.DataMember = "log_cajas"
        Me.log_cajasBindingSource.DataSource = Me.admintegralDataSet
        '
        'admintegralDataSet
        '
        Me.admintegralDataSet.DataSetName = "admintegralDataSet"
        Me.admintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.serietxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_facturadia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.foliotxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.reportadotxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvmoneda)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvfolios)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvresumen)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Cobrado)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgcobrado)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Size = New System.Drawing.Size(715, 565)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 430)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Factura Global :"
        '
        'serietxt
        '
        Me.serietxt.Enabled = False
        Me.serietxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serietxt.Location = New System.Drawing.Point(260, 428)
        Me.serietxt.Name = "serietxt"
        Me.serietxt.Size = New System.Drawing.Size(28, 26)
        Me.serietxt.TabIndex = 11
        '
        'boton_facturadia
        '
        Me.boton_facturadia.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.boton_facturadia.Location = New System.Drawing.Point(110, 493)
        Me.boton_facturadia.Name = "boton_facturadia"
        Me.boton_facturadia.Size = New System.Drawing.Size(181, 27)
        Me.boton_facturadia.TabIndex = 8
        Me.boton_facturadia.Text = "Timbrar Factura Publico General"
        Me.boton_facturadia.UseVisualStyleBackColor = True
        '
        'foliotxt
        '
        Me.foliotxt.Enabled = False
        Me.foliotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foliotxt.Location = New System.Drawing.Point(168, 428)
        Me.foliotxt.Name = "foliotxt"
        Me.foliotxt.Size = New System.Drawing.Size(94, 26)
        Me.foliotxt.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Reportado:"
        '
        'reportadotxt
        '
        Me.reportadotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportadotxt.Location = New System.Drawing.Point(188, 393)
        Me.reportadotxt.Name = "reportadotxt"
        Me.reportadotxt.ReadOnly = True
        Me.reportadotxt.Size = New System.Drawing.Size(100, 29)
        Me.reportadotxt.TabIndex = 6
        Me.reportadotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvmoneda
        '
        Me.dgvmoneda.AllowUserToAddRows = False
        Me.dgvmoneda.AllowUserToDeleteRows = False
        Me.dgvmoneda.AllowUserToResizeColumns = False
        Me.dgvmoneda.AllowUserToResizeRows = False
        Me.dgvmoneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvmoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmoneda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvmoneda.Location = New System.Drawing.Point(6, 10)
        Me.dgvmoneda.Name = "dgvmoneda"
        Me.dgvmoneda.RowHeadersVisible = False
        Me.dgvmoneda.Size = New System.Drawing.Size(285, 377)
        Me.dgvmoneda.StandardTab = True
        Me.dgvmoneda.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.Image = Global.AdminTegral.My.Resources.Resources.caja
        Me.PictureBox1.Location = New System.Drawing.Point(17, 475)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 78)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(219, 526)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 27)
        Me.boton_salir.TabIndex = 2
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "log"
        ReportDataSource1.Value = Me.log_cajasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.rpt_Corte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(411, 565)
        Me.ReportViewer1.TabIndex = 9
        '
        'dgvfolios
        '
        Me.dgvfolios.AllowUserToAddRows = False
        Me.dgvfolios.AllowUserToDeleteRows = False
        Me.dgvfolios.AllowUserToOrderColumns = True
        Me.dgvfolios.AllowUserToResizeColumns = False
        Me.dgvfolios.AllowUserToResizeRows = False
        Me.dgvfolios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvfolios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfolios.Location = New System.Drawing.Point(5, 118)
        Me.dgvfolios.Name = "dgvfolios"
        Me.dgvfolios.ReadOnly = True
        Me.dgvfolios.RowHeadersVisible = False
        Me.dgvfolios.Size = New System.Drawing.Size(203, 84)
        Me.dgvfolios.TabIndex = 8
        '
        'dgvresumen
        '
        Me.dgvresumen.AllowUserToAddRows = False
        Me.dgvresumen.AllowUserToDeleteRows = False
        Me.dgvresumen.AllowUserToOrderColumns = True
        Me.dgvresumen.AllowUserToResizeRows = False
        Me.dgvresumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvresumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvresumen.Location = New System.Drawing.Point(19, 217)
        Me.dgvresumen.Name = "dgvresumen"
        Me.dgvresumen.ReadOnly = True
        Me.dgvresumen.RowHeadersVisible = False
        Me.dgvresumen.Size = New System.Drawing.Size(431, 72)
        Me.dgvresumen.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total Cobrado:"
        '
        'Cobrado
        '
        Me.Cobrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cobrado.Location = New System.Drawing.Point(327, 187)
        Me.Cobrado.Name = "Cobrado"
        Me.Cobrado.ReadOnly = True
        Me.Cobrado.Size = New System.Drawing.Size(100, 24)
        Me.Cobrado.TabIndex = 4
        Me.Cobrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgcobrado
        '
        Me.dgcobrado.AllowUserToAddRows = False
        Me.dgcobrado.AllowUserToDeleteRows = False
        Me.dgcobrado.AllowUserToOrderColumns = True
        Me.dgcobrado.AllowUserToResizeColumns = False
        Me.dgcobrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgcobrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcobrado.Location = New System.Drawing.Point(212, 3)
        Me.dgcobrado.Name = "dgcobrado"
        Me.dgcobrado.ReadOnly = True
        Me.dgcobrado.RowHeadersVisible = False
        Me.dgcobrado.Size = New System.Drawing.Size(215, 179)
        Me.dgcobrado.TabIndex = 3
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(203, 109)
        Me.dgv.TabIndex = 1
        '
        'rpt_corte_foliosBindingSource
        '
        Me.rpt_corte_foliosBindingSource.DataMember = "rpt_corte_folios"
        Me.rpt_corte_foliosBindingSource.DataSource = Me.admintegralDataSet
        '
        'rpt_corte_Formas_pagoBindingSource
        '
        Me.rpt_corte_Formas_pagoBindingSource.DataMember = "rpt_corte_Formas_pago"
        Me.rpt_corte_Formas_pagoBindingSource.DataSource = Me.admintegralDataSet
        '
        'rpt_corte_documento_formaBindingSource
        '
        Me.rpt_corte_documento_formaBindingSource.DataMember = "rpt_corte_documento_forma"
        Me.rpt_corte_documento_formaBindingSource.DataSource = Me.admintegralDataSet
        '
        'tbl_monedasBindingSource
        '
        Me.tbl_monedasBindingSource.DataMember = "tbl_monedas"
        Me.tbl_monedasBindingSource.DataSource = Me.admintegralDataSet
        '
        'rpt_corte_retirosBindingSource
        '
        Me.rpt_corte_retirosBindingSource.DataMember = "rpt_corte_retiros"
        Me.rpt_corte_retirosBindingSource.DataSource = Me.admintegralDataSet
        '
        'rpt_corte_foliosTableAdapter
        '
        Me.rpt_corte_foliosTableAdapter.ClearBeforeFill = True
        '
        'rpt_corte_Formas_pagoTableAdapter
        '
        Me.rpt_corte_Formas_pagoTableAdapter.ClearBeforeFill = True
        '
        'rpt_corte_documento_formaTableAdapter
        '
        Me.rpt_corte_documento_formaTableAdapter.ClearBeforeFill = True
        '
        'tbl_monedasTableAdapter
        '
        Me.tbl_monedasTableAdapter.ClearBeforeFill = True
        '
        'rpt_corte_retirosTableAdapter
        '
        Me.rpt_corte_retirosTableAdapter.ClearBeforeFill = True
        '
        'log_cajasTableAdapter
        '
        Me.log_cajasTableAdapter.ClearBeforeFill = True
        '
        'caja_corte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(715, 565)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "caja_corte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "caja_corte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.log_cajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvmoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvfolios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvresumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgcobrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_corte_foliosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_corte_Formas_pagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_corte_documento_formaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_monedasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_corte_retirosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents dgcobrado As System.Windows.Forms.DataGridView
    Friend WithEvents Cobrado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvmoneda As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents reportadotxt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvresumen As System.Windows.Forms.DataGridView
    Friend WithEvents dgvfolios As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rpt_corte_foliosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents admintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents rpt_corte_Formas_pagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_corte_documento_formaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tbl_monedasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_corte_retirosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents log_cajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpt_corte_foliosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_corte_foliosTableAdapter
    Friend WithEvents rpt_corte_Formas_pagoTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_corte_Formas_pagoTableAdapter
    Friend WithEvents rpt_corte_documento_formaTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_corte_documento_formaTableAdapter
    Friend WithEvents tbl_monedasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.tbl_monedasTableAdapter
    Friend WithEvents rpt_corte_retirosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.rpt_corte_retirosTableAdapter
    Friend WithEvents log_cajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter
    Friend WithEvents boton_facturadia As System.Windows.Forms.Button
    Friend WithEvents serietxt As System.Windows.Forms.TextBox
    Friend WithEvents foliotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
