<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja_retiro
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cajatxt = New System.Windows.Forms.TextBox
        Me.Importe = New System.Windows.Forms.TextBox
        Me.Usern = New System.Windows.Forms.TextBox
        Me.userid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Boton_salir = New System.Windows.Forms.Button
        Me.Boton_aceptar = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.folio = New System.Windows.Forms.TextBox
        Me.dgvmoneda = New System.Windows.Forms.DataGridView
        Me.boton_checar = New System.Windows.Forms.Button
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvmoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cajatxt
        '
        Me.cajatxt.Location = New System.Drawing.Point(63, 16)
        Me.cajatxt.Name = "cajatxt"
        Me.cajatxt.ReadOnly = True
        Me.cajatxt.Size = New System.Drawing.Size(32, 20)
        Me.cajatxt.TabIndex = 1
        Me.cajatxt.TabStop = False
        '
        'Importe
        '
        Me.Importe.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Importe.ForeColor = System.Drawing.SystemColors.Info
        Me.Importe.Location = New System.Drawing.Point(214, 376)
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Size = New System.Drawing.Size(91, 26)
        Me.Importe.TabIndex = 2
        Me.Importe.TabStop = False
        Me.Importe.Text = "0"
        Me.Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Usern
        '
        Me.Usern.Location = New System.Drawing.Point(63, 45)
        Me.Usern.Name = "Usern"
        Me.Usern.ReadOnly = True
        Me.Usern.Size = New System.Drawing.Size(242, 20)
        Me.Usern.TabIndex = 3
        Me.Usern.TabStop = False
        '
        'userid
        '
        Me.userid.Location = New System.Drawing.Point(101, 16)
        Me.userid.Name = "userid"
        Me.userid.ReadOnly = True
        Me.userid.Size = New System.Drawing.Size(32, 20)
        Me.userid.TabIndex = 4
        Me.userid.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Caja/Id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(141, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Importe :"
        '
        'Boton_salir
        '
        Me.Boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Boton_salir.Location = New System.Drawing.Point(190, 8)
        Me.Boton_salir.Name = "Boton_salir"
        Me.Boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.Boton_salir.TabIndex = 8
        Me.Boton_salir.TabStop = False
        Me.Boton_salir.Text = "Salir"
        Me.Boton_salir.UseVisualStyleBackColor = True
        '
        'Boton_aceptar
        '
        Me.Boton_aceptar.Enabled = False
        Me.Boton_aceptar.Location = New System.Drawing.Point(109, 8)
        Me.Boton_aceptar.Name = "Boton_aceptar"
        Me.Boton_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Boton_aceptar.TabIndex = 9
        Me.Boton_aceptar.TabStop = False
        Me.Boton_aceptar.Text = "Aceptar"
        Me.Boton_aceptar.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.boton_checar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Boton_salir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Boton_aceptar)
        Me.SplitContainer1.Size = New System.Drawing.Size(317, 501)
        Me.SplitContainer1.SplitterDistance = 458
        Me.SplitContainer1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.folio)
        Me.Panel1.Controls.Add(Me.dgvmoneda)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cajatxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Importe)
        Me.Panel1.Controls.Add(Me.userid)
        Me.Panel1.Controls.Add(Me.Usern)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 458)
        Me.Panel1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(214, 402)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(91, 26)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Vales:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Dolares :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(214, 428)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 26)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'folio
        '
        Me.folio.Enabled = False
        Me.folio.Location = New System.Drawing.Point(240, 12)
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(65, 20)
        Me.folio.TabIndex = 9
        Me.folio.TabStop = False
        '
        'dgvmoneda
        '
        Me.dgvmoneda.AllowUserToAddRows = False
        Me.dgvmoneda.AllowUserToDeleteRows = False
        Me.dgvmoneda.AllowUserToResizeColumns = False
        Me.dgvmoneda.AllowUserToResizeRows = False
        Me.dgvmoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvmoneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvmoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmoneda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvmoneda.Location = New System.Drawing.Point(15, 71)
        Me.dgvmoneda.Name = "dgvmoneda"
        Me.dgvmoneda.RowHeadersVisible = False
        Me.dgvmoneda.Size = New System.Drawing.Size(293, 299)
        Me.dgvmoneda.TabIndex = 8
        '
        'boton_checar
        '
        Me.boton_checar.Location = New System.Drawing.Point(28, 8)
        Me.boton_checar.Name = "boton_checar"
        Me.boton_checar.Size = New System.Drawing.Size(75, 23)
        Me.boton_checar.TabIndex = 10
        Me.boton_checar.TabStop = False
        Me.boton_checar.Text = "&Resumen"
        Me.boton_checar.UseVisualStyleBackColor = True
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'caja_retiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Boton_salir
        Me.ClientSize = New System.Drawing.Size(317, 513)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "caja_retiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro de Caja"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvmoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents cajatxt As System.Windows.Forms.TextBox
    Friend WithEvents Importe As System.Windows.Forms.TextBox
    Friend WithEvents Usern As System.Windows.Forms.TextBox
    Friend WithEvents userid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Boton_salir As System.Windows.Forms.Button
    Friend WithEvents Boton_aceptar As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents boton_checar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvmoneda As System.Windows.Forms.DataGridView
    Friend WithEvents folio As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
