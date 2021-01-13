<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alerta_de_facturacion
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RFC = New System.Windows.Forms.TextBox()
        Me.NOMBRE = New System.Windows.Forms.TextBox()
        Me.EMAIL = New System.Windows.Forms.TextBox()
        Me.FORMA = New System.Windows.Forms.TextBox()
        Me.USO = New System.Windows.Forms.TextBox()
        Me.METODO = New System.Windows.Forms.TextBox()
        Me.forma_descripcion = New System.Windows.Forms.TextBox()
        Me.uso_descripcion = New System.Windows.Forms.TextBox()
        Me.metodo_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_valida = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.FORMACOMBO = New System.Windows.Forms.ComboBox()
        Me.Sat_formasdepagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAT_catalogosDataSet = New AdminTegral.SAT_catalogosDataSet()
        Me.Sat_usoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sat_usoTableAdapter = New AdminTegral.SAT_catalogosDataSetTableAdapters.sat_usoTableAdapter()
        Me.TableAdapterManager = New AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager()
        Me.Sat_metodosdepagoTableAdapter = New AdminTegral.SAT_catalogosDataSetTableAdapters.sat_metodosdepagoTableAdapter()
        Me.UsoComboBox = New System.Windows.Forms.ComboBox()
        Me.Sat_metodosdepagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.Sat_formasdepagoTableAdapter = New AdminTegral.SAT_catalogosDataSetTableAdapters.sat_formasdepagoTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panel.SuspendLayout()
        CType(Me.Sat_formasdepagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAT_catalogosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sat_usoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sat_metodosdepagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(678, 258)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RFC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-MAIL :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "METODO :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "USO :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "FORMA DE PAGO :"
        '
        'RFC
        '
        Me.RFC.Location = New System.Drawing.Point(115, 6)
        Me.RFC.Name = "RFC"
        Me.RFC.Size = New System.Drawing.Size(143, 26)
        Me.RFC.TabIndex = 9
        '
        'NOMBRE
        '
        Me.NOMBRE.Location = New System.Drawing.Point(115, 38)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(773, 26)
        Me.NOMBRE.TabIndex = 10
        '
        'EMAIL
        '
        Me.EMAIL.Location = New System.Drawing.Point(115, 98)
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Size = New System.Drawing.Size(777, 26)
        Me.EMAIL.TabIndex = 12
        '
        'FORMA
        '
        Me.FORMA.Location = New System.Drawing.Point(175, 3)
        Me.FORMA.Name = "FORMA"
        Me.FORMA.Size = New System.Drawing.Size(44, 26)
        Me.FORMA.TabIndex = 16
        '
        'USO
        '
        Me.USO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.USO.Location = New System.Drawing.Point(115, 165)
        Me.USO.Name = "USO"
        Me.USO.Size = New System.Drawing.Size(100, 26)
        Me.USO.TabIndex = 15
        '
        'METODO
        '
        Me.METODO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.METODO.Location = New System.Drawing.Point(115, 133)
        Me.METODO.Name = "METODO"
        Me.METODO.Size = New System.Drawing.Size(100, 26)
        Me.METODO.TabIndex = 13
        '
        'forma_descripcion
        '
        Me.forma_descripcion.Enabled = False
        Me.forma_descripcion.Location = New System.Drawing.Point(225, 3)
        Me.forma_descripcion.Name = "forma_descripcion"
        Me.forma_descripcion.Size = New System.Drawing.Size(13, 26)
        Me.forma_descripcion.TabIndex = 17
        '
        'uso_descripcion
        '
        Me.uso_descripcion.Enabled = False
        Me.uso_descripcion.Location = New System.Drawing.Point(231, 162)
        Me.uso_descripcion.Name = "uso_descripcion"
        Me.uso_descripcion.Size = New System.Drawing.Size(10, 26)
        Me.uso_descripcion.TabIndex = 18
        '
        'metodo_descripcion
        '
        Me.metodo_descripcion.Enabled = False
        Me.metodo_descripcion.Location = New System.Drawing.Point(231, 130)
        Me.metodo_descripcion.Name = "metodo_descripcion"
        Me.metodo_descripcion.Size = New System.Drawing.Size(310, 26)
        Me.metodo_descripcion.TabIndex = 19
        '
        'btn_valida
        '
        Me.btn_valida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_valida.Location = New System.Drawing.Point(209, 256)
        Me.btn_valida.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_valida.Name = "btn_valida"
        Me.btn_valida.Size = New System.Drawing.Size(100, 35)
        Me.btn_valida.TabIndex = 20
        Me.btn_valida.Text = "Valida"
        '
        'panel
        '
        Me.panel.Controls.Add(Me.FORMACOMBO)
        Me.panel.Controls.Add(Me.forma_descripcion)
        Me.panel.Controls.Add(Me.Label8)
        Me.panel.Controls.Add(Me.FORMA)
        Me.panel.Location = New System.Drawing.Point(3, 197)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(888, 58)
        Me.panel.TabIndex = 21
        '
        'FORMACOMBO
        '
        Me.FORMACOMBO.DataSource = Me.Sat_formasdepagoBindingSource
        Me.FORMACOMBO.DisplayMember = "descripcion"
        Me.FORMACOMBO.FormattingEnabled = True
        Me.FORMACOMBO.Location = New System.Drawing.Point(225, 3)
        Me.FORMACOMBO.Name = "FORMACOMBO"
        Me.FORMACOMBO.Size = New System.Drawing.Size(660, 28)
        Me.FORMACOMBO.TabIndex = 18
        Me.FORMACOMBO.ValueMember = "formaDEpago"
        '
        'Sat_formasdepagoBindingSource
        '
        Me.Sat_formasdepagoBindingSource.DataMember = "sat_formasdepago"
        Me.Sat_formasdepagoBindingSource.DataSource = Me.SAT_catalogosDataSet
        '
        'SAT_catalogosDataSet
        '
        Me.SAT_catalogosDataSet.DataSetName = "SAT_catalogosDataSet"
        Me.SAT_catalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sat_usoBindingSource
        '
        Me.Sat_usoBindingSource.DataMember = "sat_uso"
        Me.Sat_usoBindingSource.DataSource = Me.SAT_catalogosDataSet
        '
        'Sat_usoTableAdapter
        '
        Me.Sat_usoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Productos_ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.sat_codigospostalesTableAdapter = Nothing
        Me.TableAdapterManager.sat_formasdepagoTableAdapter = Nothing
        Me.TableAdapterManager.sat_metodosdepagoTableAdapter = Me.Sat_metodosdepagoTableAdapter
        Me.TableAdapterManager.sat_regimenTableAdapter = Nothing
        Me.TableAdapterManager.sat_tiporelacionTableAdapter = Nothing
        Me.TableAdapterManager.sat_unidadesTableAdapter = Nothing
        Me.TableAdapterManager.sat_usoTableAdapter = Me.Sat_usoTableAdapter
        Me.TableAdapterManager.UpdateOrder = AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sat_metodosdepagoTableAdapter
        '
        Me.Sat_metodosdepagoTableAdapter.ClearBeforeFill = True
        '
        'UsoComboBox
        '
        Me.UsoComboBox.DataSource = Me.Sat_usoBindingSource
        Me.UsoComboBox.DisplayMember = "Uso"
        Me.UsoComboBox.FormattingEnabled = True
        Me.UsoComboBox.Location = New System.Drawing.Point(228, 162)
        Me.UsoComboBox.Name = "UsoComboBox"
        Me.UsoComboBox.Size = New System.Drawing.Size(663, 28)
        Me.UsoComboBox.TabIndex = 23
        Me.UsoComboBox.ValueMember = "id_uso"
        '
        'Sat_metodosdepagoBindingSource
        '
        Me.Sat_metodosdepagoBindingSource.DataMember = "sat_metodosdepago"
        Me.Sat_metodosdepagoBindingSource.DataSource = Me.SAT_catalogosDataSet
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataSource = Me.Sat_metodosdepagoBindingSource
        Me.DescripcionComboBox.DisplayMember = "descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(228, 130)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(663, 28)
        Me.DescripcionComboBox.TabIndex = 24
        Me.DescripcionComboBox.ValueMember = "metodo"
        '
        'Sat_formasdepagoTableAdapter
        '
        Me.Sat_formasdepagoTableAdapter.ClearBeforeFill = True
        '
        'alerta_de_facturacion
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(916, 321)
        Me.Controls.Add(Me.DescripcionComboBox)
        Me.Controls.Add(Me.UsoComboBox)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.btn_valida)
        Me.Controls.Add(Me.metodo_descripcion)
        Me.Controls.Add(Me.uso_descripcion)
        Me.Controls.Add(Me.USO)
        Me.Controls.Add(Me.METODO)
        Me.Controls.Add(Me.EMAIL)
        Me.Controls.Add(Me.NOMBRE)
        Me.Controls.Add(Me.RFC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alerta_de_facturacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "alerta_de_facturacion"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.Sat_formasdepagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAT_catalogosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sat_usoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sat_metodosdepagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RFC As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents FORMA As System.Windows.Forms.TextBox
    Friend WithEvents USO As System.Windows.Forms.TextBox
    Friend WithEvents METODO As System.Windows.Forms.TextBox
    Friend WithEvents forma_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents uso_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents metodo_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents btn_valida As System.Windows.Forms.Button
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents SAT_catalogosDataSet As AdminTegral.SAT_catalogosDataSet
    Friend WithEvents Sat_usoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sat_usoTableAdapter As AdminTegral.SAT_catalogosDataSetTableAdapters.sat_usoTableAdapter
    Friend WithEvents TableAdapterManager As AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sat_metodosdepagoTableAdapter As AdminTegral.SAT_catalogosDataSetTableAdapters.sat_metodosdepagoTableAdapter
    Friend WithEvents Sat_metodosdepagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sat_formasdepagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sat_formasdepagoTableAdapter As AdminTegral.SAT_catalogosDataSetTableAdapters.sat_formasdepagoTableAdapter
    Friend WithEvents FORMACOMBO As System.Windows.Forms.ComboBox

End Class
