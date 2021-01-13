<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ListasDataGridView = New System.Windows.Forms.DataGridView
        Me.Boton_salir = New System.Windows.Forms.Button
        Me.ListasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ListasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ListasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.ListasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ListasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListasBindingNavigator.SuspendLayout()
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(349, 444)
        Me.SplitContainer1.SplitterDistance = 38
        Me.SplitContainer1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listas de Precios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListasDataGridView)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Boton_salir)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ListasBindingNavigator)
        Me.SplitContainer2.Size = New System.Drawing.Size(349, 402)
        Me.SplitContainer2.SplitterDistance = 362
        Me.SplitContainer2.TabIndex = 0
        '
        'ListasDataGridView
        '
        Me.ListasDataGridView.AutoGenerateColumns = False
        Me.ListasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.ListasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.cargo})
        Me.ListasDataGridView.DataSource = Me.ListasBindingSource
        Me.ListasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ListasDataGridView.Name = "ListasDataGridView"
        Me.ListasDataGridView.RowHeadersVisible = False
        Me.ListasDataGridView.Size = New System.Drawing.Size(349, 362)
        Me.ListasDataGridView.TabIndex = 1
        '
        'Boton_salir
        '
        Me.Boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Boton_salir.Location = New System.Drawing.Point(267, 132)
        Me.Boton_salir.Name = "Boton_salir"
        Me.Boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.Boton_salir.TabIndex = 1
        Me.Boton_salir.Text = "Button1"
        Me.Boton_salir.UseVisualStyleBackColor = True
        '
        'ListasBindingNavigator
        '
        Me.ListasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListasBindingNavigator.BindingSource = Me.ListasBindingSource
        Me.ListasBindingNavigator.CountItem = Nothing
        Me.ListasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListasBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListasBindingNavigatorSaveItem})
        Me.ListasBindingNavigator.Location = New System.Drawing.Point(0, 11)
        Me.ListasBindingNavigator.MoveFirstItem = Nothing
        Me.ListasBindingNavigator.MoveLastItem = Nothing
        Me.ListasBindingNavigator.MoveNextItem = Nothing
        Me.ListasBindingNavigator.MovePreviousItem = Nothing
        Me.ListasBindingNavigator.Name = "ListasBindingNavigator"
        Me.ListasBindingNavigator.PositionItem = Nothing
        Me.ListasBindingNavigator.Size = New System.Drawing.Size(349, 25)
        Me.ListasBindingNavigator.TabIndex = 2
        Me.ListasBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ListasBindingNavigatorSaveItem
        '
        Me.ListasBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ListasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListasBindingNavigatorSaveItem.Image = Global.AdminTegral.My.Resources.Resources.door_out
        Me.ListasBindingNavigatorSaveItem.Name = "ListasBindingNavigatorSaveItem"
        Me.ListasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ListasBindingNavigatorSaveItem.Text = "Guardar datos"
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
        'ListasTableAdapter
        '
        Me.ListasTableAdapter.ClearBeforeFill = True
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
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'cargo
        '
        Me.cargo.DataPropertyName = "cargo"
        Me.cargo.HeaderText = "cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.Width = 59
        '
        'frm_listas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Boton_salir
        Me.ClientSize = New System.Drawing.Size(349, 444)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_listas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ListasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListasBindingNavigator.ResumeLayout(False)
        Me.ListasBindingNavigator.PerformLayout()
        CType(Me.ListasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Boton_salir As System.Windows.Forms.Button
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents ListasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.ListasTableAdapter
    Friend WithEvents ListasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
