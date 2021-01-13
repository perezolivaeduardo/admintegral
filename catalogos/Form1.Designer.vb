<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FeiDataset = New AdminTegral.feiDataset()
        Me.Cfdi_documentos_relacionadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cfdi_documentos_relacionadosTableAdapter = New AdminTegral.feiDatasetTableAdapters.cfdi_documentos_relacionadosTableAdapter()
        Me.Cfdi_documentos_relacionadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cfdi_documentos_relacionadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cfdi_documentos_relacionadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FeiDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cfdi_documentos_relacionadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cfdi_documentos_relacionadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cfdi_documentos_relacionadosBindingNavigator.SuspendLayout()
        CType(Me.Cfdi_documentos_relacionadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FeiDataset
        '
        Me.FeiDataset.DataSetName = "feiDataset"
        Me.FeiDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cfdi_documentos_relacionadosBindingSource
        '
        Me.Cfdi_documentos_relacionadosBindingSource.DataMember = "cfdi_documentos_relacionados"
        Me.Cfdi_documentos_relacionadosBindingSource.DataSource = Me.FeiDataset
        '
        'Cfdi_documentos_relacionadosTableAdapter
        '
        Me.Cfdi_documentos_relacionadosTableAdapter.ClearBeforeFill = True
        '
        'Cfdi_documentos_relacionadosBindingNavigator
        '
        Me.Cfdi_documentos_relacionadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Cfdi_documentos_relacionadosBindingNavigator.BindingSource = Me.Cfdi_documentos_relacionadosBindingSource
        Me.Cfdi_documentos_relacionadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Cfdi_documentos_relacionadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Cfdi_documentos_relacionadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Cfdi_documentos_relacionadosBindingNavigatorSaveItem})
        Me.Cfdi_documentos_relacionadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cfdi_documentos_relacionadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Cfdi_documentos_relacionadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Cfdi_documentos_relacionadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Cfdi_documentos_relacionadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Cfdi_documentos_relacionadosBindingNavigator.Name = "Cfdi_documentos_relacionadosBindingNavigator"
        Me.Cfdi_documentos_relacionadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Cfdi_documentos_relacionadosBindingNavigator.Size = New System.Drawing.Size(390, 25)
        Me.Cfdi_documentos_relacionadosBindingNavigator.TabIndex = 0
        Me.Cfdi_documentos_relacionadosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Cfdi_documentos_relacionadosBindingNavigatorSaveItem
        '
        Me.Cfdi_documentos_relacionadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cfdi_documentos_relacionadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cfdi_documentos_relacionadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cfdi_documentos_relacionadosBindingNavigatorSaveItem.Name = "Cfdi_documentos_relacionadosBindingNavigatorSaveItem"
        Me.Cfdi_documentos_relacionadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Cfdi_documentos_relacionadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Cfdi_documentos_relacionadosDataGridView
        '
        Me.Cfdi_documentos_relacionadosDataGridView.AutoGenerateColumns = False
        Me.Cfdi_documentos_relacionadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cfdi_documentos_relacionadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Cfdi_documentos_relacionadosDataGridView.DataSource = Me.Cfdi_documentos_relacionadosBindingSource
        Me.Cfdi_documentos_relacionadosDataGridView.Location = New System.Drawing.Point(45, 87)
        Me.Cfdi_documentos_relacionadosDataGridView.Name = "Cfdi_documentos_relacionadosDataGridView"
        Me.Cfdi_documentos_relacionadosDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Cfdi_documentos_relacionadosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "uuid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "uuid"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "metodo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "metodo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Importe"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "saldo_anterior"
        Me.DataGridViewTextBoxColumn5.HeaderText = "saldo_anterior"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nuevo_saldo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nuevo_saldo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 392)
        Me.Controls.Add(Me.Cfdi_documentos_relacionadosDataGridView)
        Me.Controls.Add(Me.Cfdi_documentos_relacionadosBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FeiDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cfdi_documentos_relacionadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cfdi_documentos_relacionadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cfdi_documentos_relacionadosBindingNavigator.ResumeLayout(False)
        Me.Cfdi_documentos_relacionadosBindingNavigator.PerformLayout()
        CType(Me.Cfdi_documentos_relacionadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FeiDataset As AdminTegral.feiDataset
    Friend WithEvents Cfdi_documentos_relacionadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cfdi_documentos_relacionadosTableAdapter As AdminTegral.feiDatasetTableAdapters.cfdi_documentos_relacionadosTableAdapter
    Friend WithEvents Cfdi_documentos_relacionadosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Cfdi_documentos_relacionadosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cfdi_documentos_relacionadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
