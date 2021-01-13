<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agentes_pedidos
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
        Me.boton_carpeta = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.listbox = New System.Windows.Forms.CheckedListBox
        Me.boton_seleccionar = New System.Windows.Forms.Button
        Me.boton_quitar = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.boton_imprimir = New System.Windows.Forms.Button
        Me.boton_salir = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_carpeta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.boton_salir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.boton_imprimir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.listbox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.boton_seleccionar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.boton_quitar)
        Me.SplitContainer1.Size = New System.Drawing.Size(520, 325)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 0
        '
        'boton_carpeta
        '
        Me.boton_carpeta.Location = New System.Drawing.Point(467, 5)
        Me.boton_carpeta.Name = "boton_carpeta"
        Me.boton_carpeta.Size = New System.Drawing.Size(41, 20)
        Me.boton_carpeta.TabIndex = 2
        Me.boton_carpeta.Text = "..."
        Me.boton_carpeta.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(350, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carpeta de Pedidos :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 223)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(355, 21)
        Me.ComboBox1.TabIndex = 35
        '
        'listbox
        '
        Me.listbox.FormattingEnabled = True
        Me.listbox.Location = New System.Drawing.Point(12, 3)
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(355, 214)
        Me.listbox.TabIndex = 3
        '
        'boton_seleccionar
        '
        Me.boton_seleccionar.Location = New System.Drawing.Point(373, 60)
        Me.boton_seleccionar.Name = "boton_seleccionar"
        Me.boton_seleccionar.Size = New System.Drawing.Size(105, 23)
        Me.boton_seleccionar.TabIndex = 2
        Me.boton_seleccionar.Text = "Seleccionar Todo"
        Me.boton_seleccionar.UseVisualStyleBackColor = True
        '
        'boton_quitar
        '
        Me.boton_quitar.Location = New System.Drawing.Point(373, 31)
        Me.boton_quitar.Name = "boton_quitar"
        Me.boton_quitar.Size = New System.Drawing.Size(105, 23)
        Me.boton_quitar.TabIndex = 1
        Me.boton_quitar.Text = "Quitar Seleccion"
        Me.boton_quitar.UseVisualStyleBackColor = True
        '
        'boton_imprimir
        '
        Me.boton_imprimir.Location = New System.Drawing.Point(378, 226)
        Me.boton_imprimir.Name = "boton_imprimir"
        Me.boton_imprimir.Size = New System.Drawing.Size(100, 23)
        Me.boton_imprimir.TabIndex = 36
        Me.boton_imprimir.Text = "Imprimir"
        Me.boton_imprimir.UseVisualStyleBackColor = True
        '
        'boton_salir
        '
        Me.boton_salir.Location = New System.Drawing.Point(373, 194)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(105, 23)
        Me.boton_salir.TabIndex = 37
        Me.boton_salir.Text = "Salir"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'agentes_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(520, 325)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "agentes_pedidos"
        Me.Text = "agentes_pedidos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boton_seleccionar As System.Windows.Forms.Button
    Friend WithEvents boton_quitar As System.Windows.Forms.Button
    Friend WithEvents boton_carpeta As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents listbox As System.Windows.Forms.CheckedListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents boton_imprimir As System.Windows.Forms.Button
    Friend WithEvents boton_salir As System.Windows.Forms.Button
End Class
