<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cxc_info
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
        Me.nombre = New System.Windows.Forms.TextBox
        Me.agente = New System.Windows.Forms.TextBox
        Me.zona = New System.Windows.Forms.TextBox
        Me.direccion = New System.Windows.Forms.TextBox
        Me.colonia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.boton_grafica = New System.Windows.Forms.Button
        Me.boton_salir = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.limitetxt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.disponibletxt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.diasmin = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.diasmax = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.facturasvencidas = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.saldovencido = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.saldo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgvpagos = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgvcompras = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvcompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(91, 8)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(507, 24)
        Me.nombre.TabIndex = 0
        '
        'agente
        '
        Me.agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agente.Location = New System.Drawing.Point(91, 35)
        Me.agente.Name = "agente"
        Me.agente.ReadOnly = True
        Me.agente.Size = New System.Drawing.Size(507, 24)
        Me.agente.TabIndex = 1
        '
        'zona
        '
        Me.zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zona.Location = New System.Drawing.Point(91, 62)
        Me.zona.Name = "zona"
        Me.zona.ReadOnly = True
        Me.zona.Size = New System.Drawing.Size(507, 24)
        Me.zona.TabIndex = 2
        '
        'direccion
        '
        Me.direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.Location = New System.Drawing.Point(91, 89)
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Size = New System.Drawing.Size(507, 24)
        Me.direccion.TabIndex = 3
        '
        'colonia
        '
        Me.colonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colonia.Location = New System.Drawing.Point(91, 116)
        Me.colonia.Name = "colonia"
        Me.colonia.ReadOnly = True
        Me.colonia.Size = New System.Drawing.Size(507, 24)
        Me.colonia.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cliente :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Agente :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_grafica)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.colonia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nombre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.agente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.zona)
        Me.SplitContainer1.Panel1.Controls.Add(Me.direccion)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(730, 381)
        Me.SplitContainer1.SplitterDistance = 146
        Me.SplitContainer1.TabIndex = 7
        '
        'boton_grafica
        '
        Me.boton_grafica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_grafica.Image = Global.AdminTegral.My.Resources.Resources.Disk_Counter
        Me.boton_grafica.Location = New System.Drawing.Point(592, 4)
        Me.boton_grafica.Name = "boton_grafica"
        Me.boton_grafica.Size = New System.Drawing.Size(135, 137)
        Me.boton_grafica.TabIndex = 11
        Me.boton_grafica.UseVisualStyleBackColor = True
        '
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(680, 120)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(47, 23)
        Me.boton_salir.TabIndex = 10
        Me.boton_salir.Text = "Esc"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Colonia :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Zona:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer2.Panel1.Controls.Add(Me.limitetxt)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.disponibletxt)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.diasmin)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer2.Panel1.Controls.Add(Me.diasmax)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer2.Panel1.Controls.Add(Me.facturasvencidas)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer2.Panel1.Controls.Add(Me.saldovencido)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer2.Panel1.Controls.Add(Me.saldo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label12)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(730, 231)
        Me.SplitContainer2.SplitterDistance = 284
        Me.SplitContainer2.TabIndex = 11
        '
        'limitetxt
        '
        Me.limitetxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.limitetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limitetxt.Location = New System.Drawing.Point(153, 169)
        Me.limitetxt.Name = "limitetxt"
        Me.limitetxt.ReadOnly = True
        Me.limitetxt.Size = New System.Drawing.Size(114, 24)
        Me.limitetxt.TabIndex = 13
        Me.limitetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Limite Autorizado:"
        '
        'disponibletxt
        '
        Me.disponibletxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.disponibletxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disponibletxt.Location = New System.Drawing.Point(153, 200)
        Me.disponibletxt.Name = "disponibletxt"
        Me.disponibletxt.ReadOnly = True
        Me.disponibletxt.Size = New System.Drawing.Size(114, 24)
        Me.disponibletxt.TabIndex = 11
        Me.disponibletxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Credito Disp.:"
        '
        'diasmin
        '
        Me.diasmin.BackColor = System.Drawing.Color.LightSteelBlue
        Me.diasmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diasmin.Location = New System.Drawing.Point(185, 132)
        Me.diasmin.Name = "diasmin"
        Me.diasmin.ReadOnly = True
        Me.diasmin.Size = New System.Drawing.Size(44, 24)
        Me.diasmin.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 18)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Factura menos vencida :"
        '
        'diasmax
        '
        Me.diasmax.BackColor = System.Drawing.Color.LightSteelBlue
        Me.diasmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diasmax.Location = New System.Drawing.Point(185, 99)
        Me.diasmax.Name = "diasmax"
        Me.diasmax.ReadOnly = True
        Me.diasmax.Size = New System.Drawing.Size(44, 24)
        Me.diasmax.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 18)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Factura mas vencida :"
        '
        'facturasvencidas
        '
        Me.facturasvencidas.BackColor = System.Drawing.Color.LightSteelBlue
        Me.facturasvencidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facturasvencidas.Location = New System.Drawing.Point(153, 68)
        Me.facturasvencidas.Name = "facturasvencidas"
        Me.facturasvencidas.ReadOnly = True
        Me.facturasvencidas.Size = New System.Drawing.Size(114, 24)
        Me.facturasvencidas.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 18)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Facturas Vencidas :"
        '
        'saldovencido
        '
        Me.saldovencido.BackColor = System.Drawing.Color.LightSteelBlue
        Me.saldovencido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldovencido.Location = New System.Drawing.Point(153, 40)
        Me.saldovencido.Name = "saldovencido"
        Me.saldovencido.ReadOnly = True
        Me.saldovencido.Size = New System.Drawing.Size(114, 24)
        Me.saldovencido.TabIndex = 3
        Me.saldovencido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(36, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Saldo Vencido :"
        '
        'saldo
        '
        Me.saldo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo.Location = New System.Drawing.Point(153, 12)
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Size = New System.Drawing.Size(114, 24)
        Me.saldo.TabIndex = 1
        Me.saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Saldo a la Fecha :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 231)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.Controls.Add(Me.dgvpagos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(434, 205)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ultimo Pago"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvpagos
        '
        Me.dgvpagos.AllowUserToAddRows = False
        Me.dgvpagos.AllowUserToDeleteRows = False
        Me.dgvpagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvpagos.Location = New System.Drawing.Point(3, 3)
        Me.dgvpagos.Name = "dgvpagos"
        Me.dgvpagos.ReadOnly = True
        Me.dgvpagos.RowHeadersVisible = False
        Me.dgvpagos.Size = New System.Drawing.Size(428, 199)
        Me.dgvpagos.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvcompras)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(434, 205)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ultima Compra"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvcompras
        '
        Me.dgvcompras.AllowUserToAddRows = False
        Me.dgvcompras.AllowUserToDeleteRows = False
        Me.dgvcompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcompras.Location = New System.Drawing.Point(3, 3)
        Me.dgvcompras.Name = "dgvcompras"
        Me.dgvcompras.ReadOnly = True
        Me.dgvcompras.RowHeadersVisible = False
        Me.dgvcompras.Size = New System.Drawing.Size(428, 199)
        Me.dgvcompras.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(434, 205)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Estadistica"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cxc_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(730, 381)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "cxc_info"
        Me.Text = "Informacion de un Cliente"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvcompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents agente As System.Windows.Forms.TextBox
    Friend WithEvents zona As System.Windows.Forms.TextBox
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents colonia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents boton_grafica As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents facturasvencidas As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents saldovencido As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents saldo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents diasmin As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents diasmax As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgvpagos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvcompras As System.Windows.Forms.DataGridView
    Friend WithEvents disponibletxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents limitetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
