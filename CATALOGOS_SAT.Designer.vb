<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CATALOGOS_SAT
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
        Me.SAT_catalogosDataSet = New AdminTegral.SAT_catalogosDataSet()
        Me.Productos_ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Productos_ServiciosTableAdapter = New AdminTegral.SAT_catalogosDataSetTableAdapters.Productos_ServiciosTableAdapter()
        Me.TableAdapterManager = New AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager()
        Me.Productos_ServiciosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl = New System.Windows.Forms.StatusStrip()
        CType(Me.SAT_catalogosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productos_ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productos_ServiciosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SAT_catalogosDataSet
        '
        Me.SAT_catalogosDataSet.DataSetName = "SAT_catalogosDataSet"
        Me.SAT_catalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Productos_ServiciosBindingSource
        '
        Me.Productos_ServiciosBindingSource.DataMember = "Productos_Servicios"
        Me.Productos_ServiciosBindingSource.DataSource = Me.SAT_catalogosDataSet
        '
        'Productos_ServiciosTableAdapter
        '
        Me.Productos_ServiciosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Productos_ServiciosTableAdapter = Me.Productos_ServiciosTableAdapter
        Me.TableAdapterManager.sat_codigospostalesTableAdapter = Nothing
        Me.TableAdapterManager.sat_formasdepagoTableAdapter = Nothing
        Me.TableAdapterManager.sat_metodosdepagoTableAdapter = Nothing
        Me.TableAdapterManager.sat_regimenTableAdapter = Nothing
        Me.TableAdapterManager.sat_tiporelacionTableAdapter = Nothing
        Me.TableAdapterManager.sat_unidadesTableAdapter = Nothing
        Me.TableAdapterManager.sat_usoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Productos_ServiciosDataGridView
        '
        Me.Productos_ServiciosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Productos_ServiciosDataGridView.AutoGenerateColumns = False
        Me.Productos_ServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Productos_ServiciosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Productos_ServiciosDataGridView.DataSource = Me.Productos_ServiciosBindingSource
        Me.Productos_ServiciosDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Productos_ServiciosDataGridView.Name = "Productos_ServiciosDataGridView"
        Me.Productos_ServiciosDataGridView.Size = New System.Drawing.Size(345, 220)
        Me.Productos_ServiciosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "clave_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "clave_producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'lbl
        '
        Me.lbl.Location = New System.Drawing.Point(0, 315)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(369, 22)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "StatusStrip1"
        '
        'CATALOGOS_SAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 337)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Productos_ServiciosDataGridView)
        Me.Name = "CATALOGOS_SAT"
        Me.Text = "CATALOGOS_SAT"
        CType(Me.SAT_catalogosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productos_ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productos_ServiciosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SAT_catalogosDataSet As AdminTegral.SAT_catalogosDataSet
    Friend WithEvents Productos_ServiciosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Productos_ServiciosTableAdapter As AdminTegral.SAT_catalogosDataSetTableAdapters.Productos_ServiciosTableAdapter
    Friend WithEvents TableAdapterManager As AdminTegral.SAT_catalogosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Productos_ServiciosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl As System.Windows.Forms.StatusStrip
End Class
