<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Poliza_ingresos
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.Preparar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.al = New System.Windows.Forms.DateTimePicker
        Me.del = New System.Windows.Forms.DateTimePicker
        Me.grupo_poliza = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.verpoliza = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.archivo = New System.Windows.Forms.TextBox
        Me.carpetadestino = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.referencia = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.concepto = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.i7 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.i6 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.i5 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.i4 = New System.Windows.Forms.TextBox
        Me.i3 = New System.Windows.Forms.TextBox
        Me.i2 = New System.Windows.Forms.TextBox
        Me.i1 = New System.Windows.Forms.TextBox
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.grupo_poliza.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupo_poliza)
        Me.SplitContainer1.Size = New System.Drawing.Size(604, 444)
        Me.SplitContainer1.SplitterDistance = 39
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer2.Panel1Collapsed = True
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Preparar)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.al)
        Me.SplitContainer2.Panel2.Controls.Add(Me.del)
        Me.SplitContainer2.Size = New System.Drawing.Size(604, 39)
        Me.SplitContainer2.SplitterDistance = 283
        Me.SplitContainer2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Preparar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha :"
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(51, 8)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(100, 20)
        Me.fecha.TabIndex = 0
        '
        'Preparar
        '
        Me.Preparar.Location = New System.Drawing.Point(328, 7)
        Me.Preparar.Name = "Preparar"
        Me.Preparar.Size = New System.Drawing.Size(70, 23)
        Me.Preparar.TabIndex = 5
        Me.Preparar.Text = "Generar"
        Me.Preparar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "al"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Periodo del :"
        '
        'al
        '
        Me.al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.al.Location = New System.Drawing.Point(201, 8)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(100, 20)
        Me.al.TabIndex = 2
        '
        'del
        '
        Me.del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.del.Location = New System.Drawing.Point(79, 8)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(100, 20)
        Me.del.TabIndex = 1
        '
        'grupo_poliza
        '
        Me.grupo_poliza.Controls.Add(Me.Button4)
        Me.grupo_poliza.Controls.Add(Me.Button2)
        Me.grupo_poliza.Controls.Add(Me.verpoliza)
        Me.grupo_poliza.Controls.Add(Me.Label11)
        Me.grupo_poliza.Controls.Add(Me.Label10)
        Me.grupo_poliza.Controls.Add(Me.archivo)
        Me.grupo_poliza.Controls.Add(Me.carpetadestino)
        Me.grupo_poliza.Controls.Add(Me.Label9)
        Me.grupo_poliza.Controls.Add(Me.referencia)
        Me.grupo_poliza.Controls.Add(Me.Label8)
        Me.grupo_poliza.Controls.Add(Me.concepto)
        Me.grupo_poliza.Controls.Add(Me.Label22)
        Me.grupo_poliza.Controls.Add(Me.i7)
        Me.grupo_poliza.Controls.Add(Me.Label21)
        Me.grupo_poliza.Controls.Add(Me.i6)
        Me.grupo_poliza.Controls.Add(Me.Label20)
        Me.grupo_poliza.Controls.Add(Me.i5)
        Me.grupo_poliza.Controls.Add(Me.Label19)
        Me.grupo_poliza.Controls.Add(Me.Label18)
        Me.grupo_poliza.Controls.Add(Me.Label17)
        Me.grupo_poliza.Controls.Add(Me.Label16)
        Me.grupo_poliza.Controls.Add(Me.i4)
        Me.grupo_poliza.Controls.Add(Me.i3)
        Me.grupo_poliza.Controls.Add(Me.i2)
        Me.grupo_poliza.Controls.Add(Me.i1)
        Me.grupo_poliza.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_poliza.Location = New System.Drawing.Point(0, 0)
        Me.grupo_poliza.Name = "grupo_poliza"
        Me.grupo_poliza.Size = New System.Drawing.Size(604, 379)
        Me.grupo_poliza.TabIndex = 13
        Me.grupo_poliza.TabStop = False
        Me.grupo_poliza.Text = "Datos para Poliza"
        Me.grupo_poliza.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(487, 313)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Abrir carpeta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(411, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 23)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Cambiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'verpoliza
        '
        Me.verpoliza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.verpoliza.AutoSize = True
        Me.verpoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verpoliza.Location = New System.Drawing.Point(106, 341)
        Me.verpoliza.Name = "verpoliza"
        Me.verpoliza.Size = New System.Drawing.Size(91, 17)
        Me.verpoliza.TabIndex = 36
        Me.verpoliza.Text = "Abrir poliza txt"
        Me.verpoliza.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Carpeta :"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Archivo :"
        '
        'archivo
        '
        Me.archivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.archivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.archivo.Location = New System.Drawing.Point(106, 283)
        Me.archivo.Name = "archivo"
        Me.archivo.ReadOnly = True
        Me.archivo.Size = New System.Drawing.Size(292, 20)
        Me.archivo.TabIndex = 33
        '
        'carpetadestino
        '
        Me.carpetadestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.carpetadestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carpetadestino.Location = New System.Drawing.Point(106, 315)
        Me.carpetadestino.Name = "carpetadestino"
        Me.carpetadestino.ReadOnly = True
        Me.carpetadestino.Size = New System.Drawing.Size(299, 20)
        Me.carpetadestino.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 52)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Referencia :"
        '
        'referencia
        '
        Me.referencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.referencia.Location = New System.Drawing.Point(106, 51)
        Me.referencia.Name = "referencia"
        Me.referencia.Size = New System.Drawing.Size(375, 24)
        Me.referencia.TabIndex = 23
        Me.referencia.Text = "referencia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Concepto :"
        '
        'concepto
        '
        Me.concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.concepto.Location = New System.Drawing.Point(106, 19)
        Me.concepto.Name = "concepto"
        Me.concepto.Size = New System.Drawing.Size(375, 24)
        Me.concepto.TabIndex = 21
        Me.concepto.Text = "DEPOSITO Y VENTAS DEL DIA"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(46, 257)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 18)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Al 11% :"
        '
        'i7
        '
        Me.i7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i7.Location = New System.Drawing.Point(106, 253)
        Me.i7.Name = "i7"
        Me.i7.ReadOnly = True
        Me.i7.Size = New System.Drawing.Size(115, 24)
        Me.i7.TabIndex = 12
        Me.i7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(47, 229)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 18)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "al 10% :"
        '
        'i6
        '
        Me.i6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i6.Location = New System.Drawing.Point(106, 225)
        Me.i6.Name = "i6"
        Me.i6.ReadOnly = True
        Me.i6.Size = New System.Drawing.Size(115, 24)
        Me.i6.TabIndex = 10
        Me.i6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(29, 201)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 18)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Cobranza :"
        '
        'i5
        '
        Me.i5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i5.Location = New System.Drawing.Point(106, 197)
        Me.i5.Name = "i5"
        Me.i5.ReadOnly = True
        Me.i5.Size = New System.Drawing.Size(115, 24)
        Me.i5.TabIndex = 8
        Me.i5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(57, 173)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 18)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "I.V.A. :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(47, 142)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 18)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "al 11% :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(54, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 18)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "al 0% :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(45, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 18)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Ventas :"
        '
        'i4
        '
        Me.i4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i4.Location = New System.Drawing.Point(106, 169)
        Me.i4.Name = "i4"
        Me.i4.ReadOnly = True
        Me.i4.Size = New System.Drawing.Size(115, 24)
        Me.i4.TabIndex = 3
        Me.i4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'i3
        '
        Me.i3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i3.Location = New System.Drawing.Point(106, 141)
        Me.i3.Name = "i3"
        Me.i3.ReadOnly = True
        Me.i3.Size = New System.Drawing.Size(115, 24)
        Me.i3.TabIndex = 2
        Me.i3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'i2
        '
        Me.i2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i2.Location = New System.Drawing.Point(106, 113)
        Me.i2.Name = "i2"
        Me.i2.ReadOnly = True
        Me.i2.Size = New System.Drawing.Size(115, 24)
        Me.i2.TabIndex = 1
        Me.i2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'i1
        '
        Me.i1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i1.Location = New System.Drawing.Point(106, 85)
        Me.i1.Name = "i1"
        Me.i1.ReadOnly = True
        Me.i1.Size = New System.Drawing.Size(115, 24)
        Me.i1.TabIndex = 0
        Me.i1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Poliza_ingresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 444)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Poliza_ingresos"
        Me.Text = "Poliza_ingresos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.grupo_poliza.ResumeLayout(False)
        Me.grupo_poliza.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grupo_poliza As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents i7 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents i6 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents i5 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents i4 As System.Windows.Forms.TextBox
    Friend WithEvents i3 As System.Windows.Forms.TextBox
    Friend WithEvents i2 As System.Windows.Forms.TextBox
    Friend WithEvents i1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents referencia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents concepto As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents verpoliza As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents archivo As System.Windows.Forms.TextBox
    Friend WithEvents carpetadestino As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents al As System.Windows.Forms.DateTimePicker
    Friend WithEvents del As System.Windows.Forms.DateTimePicker
    Friend WithEvents Preparar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
