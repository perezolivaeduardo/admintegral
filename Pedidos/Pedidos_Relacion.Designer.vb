<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos_Relacion
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Nuevo_pedido = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.Toolmodificarpedido = New System.Windows.Forms.ToolStripButton
        Me.boton_recibir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.filtro = New System.Windows.Forms.ToolStripTextBox
        Me.PedidosDataGridView = New System.Windows.Forms.DataGridView
        Me.IdpedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvidprov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvnombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EnviadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DiasdesurtidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComentariosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescurntoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioentradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecibirPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AtenderPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SqlrelacionpedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Sql_relacion_pedidosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_relacion_pedidosTableAdapter
        Me.boton_imprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SqlrelacionpedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(840, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pedios a Proveedores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo_pedido, Me.ToolStripButton1, Me.Toolmodificarpedido, Me.boton_imprimir, Me.boton_recibir, Me.ToolStripLabel1, Me.filtro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 29)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(840, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Nuevo_pedido
        '
        Me.Nuevo_pedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo_pedido.Image = Global.AdminTegral.My.Resources.Resources.page_add
        Me.Nuevo_pedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo_pedido.Name = "Nuevo_pedido"
        Me.Nuevo_pedido.Size = New System.Drawing.Size(23, 22)
        Me.Nuevo_pedido.Text = "Nuevo Pedido"
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
        'Toolmodificarpedido
        '
        Me.Toolmodificarpedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Toolmodificarpedido.Image = Global.AdminTegral.My.Resources.Resources.overlays
        Me.Toolmodificarpedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Toolmodificarpedido.Name = "Toolmodificarpedido"
        Me.Toolmodificarpedido.Size = New System.Drawing.Size(23, 22)
        Me.Toolmodificarpedido.Text = "Modificar Pedido"
        '
        'boton_recibir
        '
        Me.boton_recibir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_recibir.Image = Global.AdminTegral.My.Resources.Resources.lorry
        Me.boton_recibir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_recibir.Name = "boton_recibir"
        Me.boton_recibir.Size = New System.Drawing.Size(23, 22)
        Me.boton_recibir.Text = "ToolStripButton2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel1.Text = "Buscar :"
        '
        'filtro
        '
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(150, 25)
        '
        'PedidosDataGridView
        '
        Me.PedidosDataGridView.AllowUserToAddRows = False
        Me.PedidosDataGridView.AllowUserToDeleteRows = False
        Me.PedidosDataGridView.AutoGenerateColumns = False
        Me.PedidosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpedidoDataGridViewTextBoxColumn, Me.dgvidprov, Me.dgvnombre, Me.FechaDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.AgenteDataGridViewTextBoxColumn, Me.EnviadoDataGridViewCheckBoxColumn, Me.DiasdesurtidoDataGridViewTextBoxColumn, Me.ComentariosDataGridViewTextBoxColumn, Me.PivaDataGridViewTextBoxColumn, Me.DescurntoDataGridViewTextBoxColumn, Me.FolioentradaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.PedidosDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PedidosDataGridView.DataSource = Me.SqlrelacionpedidosBindingSource
        Me.PedidosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PedidosDataGridView.Location = New System.Drawing.Point(0, 54)
        Me.PedidosDataGridView.Name = "PedidosDataGridView"
        Me.PedidosDataGridView.ReadOnly = True
        Me.PedidosDataGridView.RowHeadersVisible = False
        Me.PedidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PedidosDataGridView.Size = New System.Drawing.Size(840, 355)
        Me.PedidosDataGridView.TabIndex = 6
        '
        'IdpedidoDataGridViewTextBoxColumn
        '
        Me.IdpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido"
        Me.IdpedidoDataGridViewTextBoxColumn.HeaderText = "Pedido"
        Me.IdpedidoDataGridViewTextBoxColumn.Name = "IdpedidoDataGridViewTextBoxColumn"
        Me.IdpedidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdpedidoDataGridViewTextBoxColumn.Width = 65
        '
        'dgvidprov
        '
        Me.dgvidprov.DataPropertyName = "id_directorio"
        Me.dgvidprov.HeaderText = "id_directorio"
        Me.dgvidprov.Name = "dgvidprov"
        Me.dgvidprov.ReadOnly = True
        Me.dgvidprov.Visible = False
        Me.dgvidprov.Width = 89
        '
        'dgvnombre
        '
        Me.dgvnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvnombre.DataPropertyName = "Nombre"
        Me.dgvnombre.HeaderText = "Nombre"
        Me.dgvnombre.Name = "dgvnombre"
        Me.dgvnombre.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 59
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 67
        '
        'AgenteDataGridViewTextBoxColumn
        '
        Me.AgenteDataGridViewTextBoxColumn.DataPropertyName = "agente"
        Me.AgenteDataGridViewTextBoxColumn.HeaderText = "agente"
        Me.AgenteDataGridViewTextBoxColumn.Name = "AgenteDataGridViewTextBoxColumn"
        Me.AgenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgenteDataGridViewTextBoxColumn.Width = 65
        '
        'EnviadoDataGridViewCheckBoxColumn
        '
        Me.EnviadoDataGridViewCheckBoxColumn.DataPropertyName = "enviado"
        Me.EnviadoDataGridViewCheckBoxColumn.HeaderText = "enviado"
        Me.EnviadoDataGridViewCheckBoxColumn.Name = "EnviadoDataGridViewCheckBoxColumn"
        Me.EnviadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EnviadoDataGridViewCheckBoxColumn.Visible = False
        Me.EnviadoDataGridViewCheckBoxColumn.Width = 51
        '
        'DiasdesurtidoDataGridViewTextBoxColumn
        '
        Me.DiasdesurtidoDataGridViewTextBoxColumn.DataPropertyName = "Diasdesurtido"
        Me.DiasdesurtidoDataGridViewTextBoxColumn.HeaderText = "Diasdesurtido"
        Me.DiasdesurtidoDataGridViewTextBoxColumn.Name = "DiasdesurtidoDataGridViewTextBoxColumn"
        Me.DiasdesurtidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiasdesurtidoDataGridViewTextBoxColumn.Visible = False
        Me.DiasdesurtidoDataGridViewTextBoxColumn.Width = 96
        '
        'ComentariosDataGridViewTextBoxColumn
        '
        Me.ComentariosDataGridViewTextBoxColumn.DataPropertyName = "comentarios"
        Me.ComentariosDataGridViewTextBoxColumn.HeaderText = "comentarios"
        Me.ComentariosDataGridViewTextBoxColumn.Name = "ComentariosDataGridViewTextBoxColumn"
        Me.ComentariosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComentariosDataGridViewTextBoxColumn.Width = 89
        '
        'PivaDataGridViewTextBoxColumn
        '
        Me.PivaDataGridViewTextBoxColumn.DataPropertyName = "piva"
        Me.PivaDataGridViewTextBoxColumn.HeaderText = "piva"
        Me.PivaDataGridViewTextBoxColumn.Name = "PivaDataGridViewTextBoxColumn"
        Me.PivaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PivaDataGridViewTextBoxColumn.Visible = False
        Me.PivaDataGridViewTextBoxColumn.Width = 52
        '
        'DescurntoDataGridViewTextBoxColumn
        '
        Me.DescurntoDataGridViewTextBoxColumn.DataPropertyName = "descurnto"
        Me.DescurntoDataGridViewTextBoxColumn.HeaderText = "descurnto"
        Me.DescurntoDataGridViewTextBoxColumn.Name = "DescurntoDataGridViewTextBoxColumn"
        Me.DescurntoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescurntoDataGridViewTextBoxColumn.Visible = False
        Me.DescurntoDataGridViewTextBoxColumn.Width = 79
        '
        'FolioentradaDataGridViewTextBoxColumn
        '
        Me.FolioentradaDataGridViewTextBoxColumn.DataPropertyName = "folio_entrada"
        Me.FolioentradaDataGridViewTextBoxColumn.HeaderText = "folio_entrada"
        Me.FolioentradaDataGridViewTextBoxColumn.Name = "FolioentradaDataGridViewTextBoxColumn"
        Me.FolioentradaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioentradaDataGridViewTextBoxColumn.Visible = False
        Me.FolioentradaDataGridViewTextBoxColumn.Width = 93
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Visible = False
        Me.StatusDataGridViewTextBoxColumn.Width = 60
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 65
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPedidoToolStripMenuItem, Me.RecibirPedidoToolStripMenuItem, Me.AtenderPendientesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 70)
        '
        'NuevoPedidoToolStripMenuItem
        '
        Me.NuevoPedidoToolStripMenuItem.Name = "NuevoPedidoToolStripMenuItem"
        Me.NuevoPedidoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NuevoPedidoToolStripMenuItem.Text = "Nuevo Pedido"
        '
        'RecibirPedidoToolStripMenuItem
        '
        Me.RecibirPedidoToolStripMenuItem.Name = "RecibirPedidoToolStripMenuItem"
        Me.RecibirPedidoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RecibirPedidoToolStripMenuItem.Text = "Recibir Pedido"
        '
        'AtenderPendientesToolStripMenuItem
        '
        Me.AtenderPendientesToolStripMenuItem.Name = "AtenderPendientesToolStripMenuItem"
        Me.AtenderPendientesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AtenderPendientesToolStripMenuItem.Text = "Atender Pendientes"
        '
        'SqlrelacionpedidosBindingSource
        '
        Me.SqlrelacionpedidosBindingSource.DataMember = "sql_relacion_pedidos"
        Me.SqlrelacionpedidosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "AdmintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sql_relacion_pedidosTableAdapter
        '
        Me.Sql_relacion_pedidosTableAdapter.ClearBeforeFill = True
        '
        'boton_imprimir
        '
        Me.boton_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_imprimir.Image = Global.AdminTegral.My.Resources.Resources.Printer_Green
        Me.boton_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_imprimir.Name = "boton_imprimir"
        Me.boton_imprimir.Size = New System.Drawing.Size(23, 22)
        Me.boton_imprimir.Text = "ToolStripButton2"
        '
        'Pedidos_Relacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.PedidosDataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pedidos_Relacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos_Relacion"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SqlrelacionpedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents PedidosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Nuevo_pedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents filtro As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AdmintegralDataSet As AdminTegral.AdmintegralDataSet
    Friend WithEvents SqlrelacionpedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_relacion_pedidosTableAdapter As AdminTegral.AdmintegralDataSetTableAdapters.sql_relacion_pedidosTableAdapter
    Friend WithEvents boton_recibir As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdpedidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvidprov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvnombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnviadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DiasdesurtidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentariosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescurntoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioentradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RecibirPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtenderPendientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Toolmodificarpedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_imprimir As System.Windows.Forms.ToolStripButton
End Class
