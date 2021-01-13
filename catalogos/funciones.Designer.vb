<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class funciones
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
        Me.Combofunciones = New System.Windows.Forms.ComboBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.dgvusuarios = New System.Windows.Forms.DataGridView
        Me.dgvpermiso = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvpermiso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Combofunciones
        '
        Me.Combofunciones.FormattingEnabled = True
        Me.Combofunciones.Location = New System.Drawing.Point(69, 9)
        Me.Combofunciones.Name = "Combofunciones"
        Me.Combofunciones.Size = New System.Drawing.Size(310, 21)
        Me.Combofunciones.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Combofunciones)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(683, 392)
        Me.SplitContainer1.SplitterDistance = 38
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvusuarios)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvpermiso)
        Me.SplitContainer2.Size = New System.Drawing.Size(681, 348)
        Me.SplitContainer2.SplitterDistance = 274
        Me.SplitContainer2.TabIndex = 0
        '
        'dgvusuarios
        '
        Me.dgvusuarios.AllowUserToAddRows = False
        Me.dgvusuarios.AllowUserToDeleteRows = False
        Me.dgvusuarios.AllowUserToResizeColumns = False
        Me.dgvusuarios.AllowUserToResizeRows = False
        Me.dgvusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvusuarios.Location = New System.Drawing.Point(0, 81)
        Me.dgvusuarios.Name = "dgvusuarios"
        Me.dgvusuarios.Size = New System.Drawing.Size(274, 267)
        Me.dgvusuarios.TabIndex = 0
        '
        'dgvpermiso
        '
        Me.dgvpermiso.AllowUserToAddRows = False
        Me.dgvpermiso.AllowUserToDeleteRows = False
        Me.dgvpermiso.AllowUserToOrderColumns = True
        Me.dgvpermiso.AllowUserToResizeColumns = False
        Me.dgvpermiso.AllowUserToResizeRows = False
        Me.dgvpermiso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvpermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpermiso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvpermiso.Location = New System.Drawing.Point(0, 81)
        Me.dgvpermiso.Name = "dgvpermiso"
        Me.dgvpermiso.Size = New System.Drawing.Size(403, 267)
        Me.dgvpermiso.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Funcion :"
        '
        'funciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 392)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "funciones"
        Me.Text = "funciones"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvpermiso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Combofunciones As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvusuarios As System.Windows.Forms.DataGridView
    Friend WithEvents dgvpermiso As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
