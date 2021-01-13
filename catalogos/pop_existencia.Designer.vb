<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_existencia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pop_existencia))
        Me.grupo1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.netos = New System.Windows.Forms.CheckBox()
        Me.lblprod = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.boton_resumen = New System.Windows.Forms.Button()
        Me.boton_fisico = New System.Windows.Forms.Button()
        Me.dgvini = New System.Windows.Forms.DataGridView()
        Me.dgvexistencia = New System.Windows.Forms.DataGridView()
        Me.boton_salir = New System.Windows.Forms.Button()
        Me.dataresumen = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.grupo1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvexistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataresumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupo1
        '
        Me.grupo1.Controls.Add(Me.SplitContainer1)
        Me.grupo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo1.ForeColor = System.Drawing.Color.Black
        Me.grupo1.Location = New System.Drawing.Point(0, 0)
        Me.grupo1.Name = "grupo1"
        Me.grupo1.Size = New System.Drawing.Size(692, 378)
        Me.grupo1.TabIndex = 34
        Me.grupo1.TabStop = False
        Me.grupo1.Text = "Existencias"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 22)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(686, 353)
        Me.SplitContainer1.SplitterDistance = 319
        Me.SplitContainer1.TabIndex = 11
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.netos)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblprod)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_resumen)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_fisico)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.boton_salir)
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvini)
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvexistencia)
        Me.SplitContainer2.Panel2.Controls.Add(Me.dataresumen)
        Me.SplitContainer2.Size = New System.Drawing.Size(686, 319)
        Me.SplitContainer2.SplitterDistance = 82
        Me.SplitContainer2.TabIndex = 0
        '
        'netos
        '
        Me.netos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.netos.AutoSize = True
        Me.netos.Location = New System.Drawing.Point(574, 56)
        Me.netos.Name = "netos"
        Me.netos.Size = New System.Drawing.Size(106, 24)
        Me.netos.TabIndex = 9
        Me.netos.Text = "Solo Netos"
        Me.netos.UseVisualStyleBackColor = True
        '
        'lblprod
        '
        Me.lblprod.AutoSize = True
        Me.lblprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprod.ForeColor = System.Drawing.Color.Black
        Me.lblprod.Location = New System.Drawing.Point(3, 0)
        Me.lblprod.Name = "lblprod"
        Me.lblprod.Size = New System.Drawing.Size(59, 18)
        Me.lblprod.TabIndex = 1
        Me.lblprod.Text = "Label12"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Inv.Inicial"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'boton_resumen
        '
        Me.boton_resumen.Location = New System.Drawing.Point(207, 41)
        Me.boton_resumen.Name = "boton_resumen"
        Me.boton_resumen.Size = New System.Drawing.Size(117, 24)
        Me.boton_resumen.TabIndex = 8
        Me.boton_resumen.Text = "Quitar Filtro"
        Me.boton_resumen.UseVisualStyleBackColor = True
        Me.boton_resumen.Visible = False
        '
        'boton_fisico
        '
        Me.boton_fisico.Location = New System.Drawing.Point(4, 41)
        Me.boton_fisico.Name = "boton_fisico"
        Me.boton_fisico.Size = New System.Drawing.Size(96, 26)
        Me.boton_fisico.TabIndex = 4
        Me.boton_fisico.Text = "Existencia"
        Me.boton_fisico.UseVisualStyleBackColor = True
        '
        'dgvini
        '
        Me.dgvini.AllowUserToAddRows = False
        Me.dgvini.AllowUserToDeleteRows = False
        Me.dgvini.AllowUserToResizeColumns = False
        Me.dgvini.AllowUserToResizeRows = False
        Me.dgvini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvini.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.dgvini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvini.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvini.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvini.GridColor = System.Drawing.Color.LightGreen
        Me.dgvini.Location = New System.Drawing.Point(0, 0)
        Me.dgvini.Name = "dgvini"
        Me.dgvini.RowHeadersVisible = False
        Me.dgvini.Size = New System.Drawing.Size(686, 233)
        Me.dgvini.TabIndex = 3
        Me.dgvini.Visible = False
        '
        'dgvexistencia
        '
        Me.dgvexistencia.AllowUserToAddRows = False
        Me.dgvexistencia.AllowUserToDeleteRows = False
        Me.dgvexistencia.AllowUserToResizeColumns = False
        Me.dgvexistencia.AllowUserToResizeRows = False
        Me.dgvexistencia.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvexistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvexistencia.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvexistencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvexistencia.GridColor = System.Drawing.Color.White
        Me.dgvexistencia.Location = New System.Drawing.Point(0, 0)
        Me.dgvexistencia.Name = "dgvexistencia"
        Me.dgvexistencia.RowHeadersVisible = False
        Me.dgvexistencia.Size = New System.Drawing.Size(686, 233)
        Me.dgvexistencia.TabIndex = 0
        '
        'boton_salir
        '
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(297, -30)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(78, 23)
        Me.boton_salir.TabIndex = 2
        Me.boton_salir.Text = "Button1"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'dataresumen
        '
        Me.dataresumen.AllowUserToAddRows = False
        Me.dataresumen.AllowUserToDeleteRows = False
        Me.dataresumen.AllowUserToResizeColumns = False
        Me.dataresumen.AllowUserToResizeRows = False
        Me.dataresumen.BackgroundColor = System.Drawing.Color.Khaki
        Me.dataresumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataresumen.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataresumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataresumen.GridColor = System.Drawing.Color.White
        Me.dataresumen.Location = New System.Drawing.Point(0, 0)
        Me.dataresumen.Name = "dataresumen"
        Me.dataresumen.RowHeadersVisible = False
        Me.dataresumen.Size = New System.Drawing.Size(686, 233)
        Me.dataresumen.TabIndex = 7
        Me.dataresumen.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 5)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(686, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripButton1.Text = "CargarResumen"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton2.Text = "Cargar detalle"
        '
        'pop_existencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(692, 378)
        Me.Controls.Add(Me.grupo1)
        Me.Name = "pop_existencia"
        Me.Opacity = 0.95R
        Me.grupo1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvexistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataresumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupo1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblprod As System.Windows.Forms.Label
    Friend WithEvents dgvexistencia As System.Windows.Forms.DataGridView
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents boton_fisico As System.Windows.Forms.Button
    Friend WithEvents dgvini As System.Windows.Forms.DataGridView
    Friend WithEvents dataresumen As System.Windows.Forms.DataGridView
    Friend WithEvents boton_resumen As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents netos As System.Windows.Forms.CheckBox
End Class
