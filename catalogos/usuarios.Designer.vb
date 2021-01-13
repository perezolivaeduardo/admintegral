<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuarios
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
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Dim NickLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim PwLabel As System.Windows.Forms.Label
        Dim MasterLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuarios))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.UsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_usuarioTextBox = New System.Windows.Forms.TextBox
        Me.NickTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox
        Me.PwTextBox = New System.Windows.Forms.TextBox
        Me.MasterCheckBox = New System.Windows.Forms.CheckBox
        Me.boton_Buardar = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.UsuariosTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.usuariosTableAdapter
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Id_usuarioLabel = New System.Windows.Forms.Label
        NickLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        UsuarioLabel = New System.Windows.Forms.Label
        PwLabel = New System.Windows.Forms.Label
        MasterLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuariosBindingNavigator.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Location = New System.Drawing.Point(20, 263)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(55, 13)
        Id_usuarioLabel.TabIndex = 0
        Id_usuarioLabel.Text = "id usuario:"
        '
        'NickLabel
        '
        NickLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        NickLabel.AutoSize = True
        NickLabel.Location = New System.Drawing.Point(20, 289)
        NickLabel.Name = "NickLabel"
        NickLabel.Size = New System.Drawing.Size(30, 13)
        NickLabel.TabIndex = 2
        NickLabel.Text = "nick:"
        '
        'NombreLabel
        '
        NombreLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(20, 315)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(20, 341)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 6
        UsuarioLabel.Text = "Usuario:"
        '
        'PwLabel
        '
        PwLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        PwLabel.AutoSize = True
        PwLabel.Location = New System.Drawing.Point(20, 367)
        PwLabel.Name = "PwLabel"
        PwLabel.Size = New System.Drawing.Size(24, 13)
        PwLabel.TabIndex = 8
        PwLabel.Text = "pw:"
        AddHandler PwLabel.Click, AddressOf Me.PwLabel_Click
        '
        'MasterLabel
        '
        MasterLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        MasterLabel.AutoSize = True
        MasterLabel.Location = New System.Drawing.Point(20, 395)
        MasterLabel.Name = "MasterLabel"
        MasterLabel.Size = New System.Drawing.Size(41, 13)
        MasterLabel.TabIndex = 10
        MasterLabel.Text = "master:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.UsuariosBindingNavigator)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UsuariosDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Id_usuarioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_usuarioTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(NickLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NickTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(UsuarioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UsuarioTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(PwLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PwTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MasterLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MasterCheckBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.boton_Buardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Size = New System.Drawing.Size(664, 450)
        Me.SplitContainer1.SplitterDistance = 358
        Me.SplitContainer1.TabIndex = 0
        '
        'UsuariosBindingNavigator
        '
        Me.UsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsuariosBindingNavigator.BindingSource = Me.UsuariosBindingSource
        Me.UsuariosBindingNavigator.CountItem = Nothing
        Me.UsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsuariosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsuariosBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 425)
        Me.UsuariosBindingNavigator.MoveFirstItem = Nothing
        Me.UsuariosBindingNavigator.MoveLastItem = Nothing
        Me.UsuariosBindingNavigator.MoveNextItem = Nothing
        Me.UsuariosBindingNavigator.MovePreviousItem = Nothing
        Me.UsuariosBindingNavigator.Name = "UsuariosBindingNavigator"
        Me.UsuariosBindingNavigator.PositionItem = Nothing
        Me.UsuariosBindingNavigator.Size = New System.Drawing.Size(358, 25)
        Me.UsuariosBindingNavigator.TabIndex = 1
        Me.UsuariosBindingNavigator.Text = "BindingNavigator1"
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
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'UsuariosBindingNavigatorSaveItem
        '
        Me.UsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsuariosBindingNavigatorSaveItem.Name = "UsuariosBindingNavigatorSaveItem"
        Me.UsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AllowUserToAddRows = False
        Me.UsuariosDataGridView.AllowUserToDeleteRows = False
        Me.UsuariosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.RowHeadersVisible = False
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(343, 236)
        Me.UsuariosDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nick"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nick"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 52
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "User"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 54
        '
        'Id_usuarioTextBox
        '
        Me.Id_usuarioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Id_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "id_usuario", True))
        Me.Id_usuarioTextBox.Enabled = False
        Me.Id_usuarioTextBox.Location = New System.Drawing.Point(81, 260)
        Me.Id_usuarioTextBox.Name = "Id_usuarioTextBox"
        Me.Id_usuarioTextBox.Size = New System.Drawing.Size(38, 20)
        Me.Id_usuarioTextBox.TabIndex = 1
        '
        'NickTextBox
        '
        Me.NickTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NickTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "nick", True))
        Me.NickTextBox.Location = New System.Drawing.Point(81, 286)
        Me.NickTextBox.MaxLength = 6
        Me.NickTextBox.Name = "NickTextBox"
        Me.NickTextBox.Size = New System.Drawing.Size(60, 20)
        Me.NickTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(81, 312)
        Me.NombreTextBox.MaxLength = 30
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(196, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(81, 338)
        Me.UsuarioTextBox.MaxLength = 10
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UsuarioTextBox.TabIndex = 7
        '
        'PwTextBox
        '
        Me.PwTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PwTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "pw", True))
        Me.PwTextBox.Location = New System.Drawing.Point(81, 364)
        Me.PwTextBox.MaxLength = 10
        Me.PwTextBox.Name = "PwTextBox"
        Me.PwTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PwTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PwTextBox.TabIndex = 9
        '
        'MasterCheckBox
        '
        Me.MasterCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MasterCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosBindingSource, "master", True))
        Me.MasterCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsuariosBindingSource, "master", True))
        Me.MasterCheckBox.Location = New System.Drawing.Point(81, 390)
        Me.MasterCheckBox.Name = "MasterCheckBox"
        Me.MasterCheckBox.Size = New System.Drawing.Size(38, 24)
        Me.MasterCheckBox.TabIndex = 11
        '
        'boton_Buardar
        '
        Me.boton_Buardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_Buardar.Location = New System.Drawing.Point(215, 415)
        Me.boton_Buardar.Name = "boton_Buardar"
        Me.boton_Buardar.Size = New System.Drawing.Size(75, 23)
        Me.boton_Buardar.TabIndex = 1
        Me.boton_Buardar.Text = "Guardar"
        Me.boton_Buardar.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(302, 408)
        Me.dgv.TabIndex = 0
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.AdminTegral.My.Resources.Resources.Vista_Key
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripButton1.Text = "Funciones Especiales"
        '
        'usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "usuarios"
        Me.Text = "usuarios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuariosBindingNavigator.ResumeLayout(False)
        Me.UsuariosBindingNavigator.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As AdminTegral.admintegralDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents UsuariosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UsuariosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UsuariosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Id_usuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NickTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PwTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MasterCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents boton_Buardar As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
