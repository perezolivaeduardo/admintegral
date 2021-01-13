<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autorizaciones
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
        Me.AutorizacionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AutorizacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.boton_refresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.boton_rechazar = New System.Windows.Forms.ToolStripButton
        Me.boton_ver_todas = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.AutomaticoONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.boton_ok = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.AutorizacionesDataGridView = New System.Windows.Forms.DataGridView
        Me.SqlclientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.AutorizacionesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.autorizacionesTableAdapter
        Me.Sql_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_clientesTableAdapter
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cajaname = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.dgvimporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvautoriza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvfecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.AutorizacionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AutorizacionesBindingNavigator.SuspendLayout()
        CType(Me.AutorizacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorizacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SqlclientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AutorizacionesBindingNavigator
        '
        Me.AutorizacionesBindingNavigator.AddNewItem = Nothing
        Me.AutorizacionesBindingNavigator.BindingSource = Me.AutorizacionesBindingSource
        Me.AutorizacionesBindingNavigator.CountItem = Nothing
        Me.AutorizacionesBindingNavigator.DeleteItem = Nothing
        Me.AutorizacionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_refresh, Me.ToolStripButton2, Me.boton_rechazar, Me.boton_ver_todas, Me.ToolStripSplitButton1, Me.boton_ok, Me.ToolStripButton1, Me.ToolStripButton3})
        Me.AutorizacionesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AutorizacionesBindingNavigator.MoveFirstItem = Nothing
        Me.AutorizacionesBindingNavigator.MoveLastItem = Nothing
        Me.AutorizacionesBindingNavigator.MoveNextItem = Nothing
        Me.AutorizacionesBindingNavigator.MovePreviousItem = Nothing
        Me.AutorizacionesBindingNavigator.Name = "AutorizacionesBindingNavigator"
        Me.AutorizacionesBindingNavigator.PositionItem = Nothing
        Me.AutorizacionesBindingNavigator.Size = New System.Drawing.Size(966, 25)
        Me.AutorizacionesBindingNavigator.TabIndex = 0
        Me.AutorizacionesBindingNavigator.Text = "BindingNavigator1"
        '
        'AutorizacionesBindingSource
        '
        Me.AutorizacionesBindingSource.DataMember = "autorizaciones"
        Me.AutorizacionesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'boton_refresh
        '
        Me.boton_refresh.Image = Global.AdminTegral.My.Resources.Resources.avedesk
        Me.boton_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_refresh.Name = "boton_refresh"
        Me.boton_refresh.Size = New System.Drawing.Size(66, 22)
        Me.boton_refresh.Text = "Refresh"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.AdminTegral.My.Resources.Resources.Restart
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton2.Text = "Autorizar"
        '
        'boton_rechazar
        '
        Me.boton_rechazar.Image = Global.AdminTegral.My.Resources.Resources.Delete
        Me.boton_rechazar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_rechazar.Name = "boton_rechazar"
        Me.boton_rechazar.Size = New System.Drawing.Size(74, 22)
        Me.boton_rechazar.Text = "Rechazar"
        '
        'boton_ver_todas
        '
        Me.boton_ver_todas.Image = Global.AdminTegral.My.Resources.Resources.Vista__50_
        Me.boton_ver_todas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_ver_todas.Name = "boton_ver_todas"
        Me.boton_ver_todas.Size = New System.Drawing.Size(77, 22)
        Me.boton_ver_todas.Text = "Ver todos"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutomaticoONToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.AdminTegral.My.Resources.Resources.Binoculars
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'AutomaticoONToolStripMenuItem
        '
        Me.AutomaticoONToolStripMenuItem.Checked = Global.AdminTegral.My.MySettings.Default.Autoriza_Automatico
        Me.AutomaticoONToolStripMenuItem.Name = "AutomaticoONToolStripMenuItem"
        Me.AutomaticoONToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AutomaticoONToolStripMenuItem.Text = "Automatico"
        '
        'boton_ok
        '
        Me.boton_ok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_ok.Image = Global.AdminTegral.My.Resources.Resources.Ok_2
        Me.boton_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(23, 22)
        Me.boton_ok.Text = "ToolStripButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.AdminTegral.My.Resources.Resources.bullet_arrow_bottom
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'AutorizacionesDataGridView
        '
        Me.AutorizacionesDataGridView.AllowUserToAddRows = False
        Me.AutorizacionesDataGridView.AllowUserToDeleteRows = False
        Me.AutorizacionesDataGridView.AutoGenerateColumns = False
        Me.AutorizacionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AutorizacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.cajaname, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.id_cliente, Me.DataGridViewTextBoxColumn5, Me.dgvimporte, Me.dgvautoriza, Me.dgvfecha, Me.dgvstatus, Me.DataGridViewTextBoxColumn10})
        Me.AutorizacionesDataGridView.DataSource = Me.AutorizacionesBindingSource
        Me.AutorizacionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutorizacionesDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.AutorizacionesDataGridView.Name = "AutorizacionesDataGridView"
        Me.AutorizacionesDataGridView.ReadOnly = True
        Me.AutorizacionesDataGridView.RowHeadersVisible = False
        Me.AutorizacionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AutorizacionesDataGridView.Size = New System.Drawing.Size(966, 271)
        Me.AutorizacionesDataGridView.TabIndex = 1
        '
        'SqlclientesBindingSource
        '
        Me.SqlclientesBindingSource.DataMember = "sql_clientes"
        Me.SqlclientesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 15000
        '
        'AutorizacionesTableAdapter
        '
        Me.AutorizacionesTableAdapter.ClearBeforeFill = True
        '
        'Sql_clientesTableAdapter
        '
        Me.Sql_clientesTableAdapter.ClearBeforeFill = True
        '
        'CajasBindingSource
        '
        Me.CajasBindingSource.DataMember = "cajas"
        Me.CajasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'CajasTableAdapter
        '
        Me.CajasTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "caja"
        Me.DataGridViewTextBoxColumn2.HeaderText = "#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 39
        '
        'cajaname
        '
        Me.cajaname.DataPropertyName = "caja"
        Me.cajaname.DataSource = Me.CajasBindingSource
        Me.cajaname.DisplayMember = "Nombre"
        Me.cajaname.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cajaname.HeaderText = "Caja"
        Me.cajaname.Name = "cajaname"
        Me.cajaname.ReadOnly = True
        Me.cajaname.ValueMember = "id_caja"
        Me.cajaname.Width = 34
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 59
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_user"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_user"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 66
        '
        'id_cliente
        '
        Me.id_cliente.DataPropertyName = "id_cliente"
        Me.id_cliente.HeaderText = "Id-cliente"
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.ReadOnly = True
        Me.id_cliente.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.SqlclientesBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "id_directorio"
        Me.DataGridViewTextBoxColumn5.Width = 64
        '
        'dgvimporte
        '
        Me.dgvimporte.DataPropertyName = "importe"
        Me.dgvimporte.HeaderText = "importe"
        Me.dgvimporte.Name = "dgvimporte"
        Me.dgvimporte.ReadOnly = True
        Me.dgvimporte.Width = 66
        '
        'dgvautoriza
        '
        Me.dgvautoriza.DataPropertyName = "user_autorizo"
        Me.dgvautoriza.HeaderText = "user_autorizo"
        Me.dgvautoriza.Name = "dgvautoriza"
        Me.dgvautoriza.ReadOnly = True
        Me.dgvautoriza.Width = 95
        '
        'dgvfecha
        '
        Me.dgvfecha.DataPropertyName = "fecha_autorizacion"
        Me.dgvfecha.HeaderText = "fecha_autorizacion"
        Me.dgvfecha.Name = "dgvfecha"
        Me.dgvfecha.ReadOnly = True
        Me.dgvfecha.Visible = False
        Me.dgvfecha.Width = 122
        '
        'dgvstatus
        '
        Me.dgvstatus.DataPropertyName = "status"
        Me.dgvstatus.HeaderText = "status"
        Me.dgvstatus.Name = "dgvstatus"
        Me.dgvstatus.ReadOnly = True
        Me.dgvstatus.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "memo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "memo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'Autorizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.AutorizacionesDataGridView)
        Me.Controls.Add(Me.AutorizacionesBindingNavigator)
        Me.Name = "Autorizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.AutorizacionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AutorizacionesBindingNavigator.ResumeLayout(False)
        Me.AutorizacionesBindingNavigator.PerformLayout()
        CType(Me.AutorizacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorizacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SqlclientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents AutorizacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutorizacionesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.autorizacionesTableAdapter
    Friend WithEvents AutorizacionesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents AutorizacionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents boton_refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SqlclientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_clientesTableAdapter
    Friend WithEvents boton_rechazar As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_ver_todas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents AutomaticoONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boton_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cajaname As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgvimporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvautoriza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvfecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
