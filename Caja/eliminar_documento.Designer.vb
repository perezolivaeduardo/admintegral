<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminar_documento
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
        Dim Id_directorioLabel As System.Windows.Forms.Label
        Dim FechafacturaLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Me.td = New System.Windows.Forms.TextBox
        Me.serie = New System.Windows.Forms.TextBox
        Me.folio = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ImporteTextBox = New System.Windows.Forms.TextBox
        Me.Sql_documentos_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.FechafacturaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.Id_directorioTextBox = New System.Windows.Forms.TextBox
        Me.Sql_documentos_clientesTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
        Id_directorioLabel = New System.Windows.Forms.Label
        FechafacturaLabel = New System.Windows.Forms.Label
        ImporteLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_directorioLabel
        '
        Id_directorioLabel.AutoSize = True
        Id_directorioLabel.Location = New System.Drawing.Point(18, 34)
        Id_directorioLabel.Name = "Id_directorioLabel"
        Id_directorioLabel.Size = New System.Drawing.Size(64, 13)
        Id_directorioLabel.TabIndex = 0
        Id_directorioLabel.Text = "id directorio:"
        '
        'FechafacturaLabel
        '
        FechafacturaLabel.AutoSize = True
        FechafacturaLabel.Location = New System.Drawing.Point(12, 61)
        FechafacturaLabel.Name = "FechafacturaLabel"
        FechafacturaLabel.Size = New System.Drawing.Size(70, 13)
        FechafacturaLabel.TabIndex = 3
        FechafacturaLabel.Text = "fechafactura:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(37, 86)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(45, 13)
        ImporteLabel.TabIndex = 5
        ImporteLabel.Text = "Importe:"
        '
        'td
        '
        Me.td.Location = New System.Drawing.Point(30, 12)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(32, 20)
        Me.td.TabIndex = 0
        Me.td.TabStop = False
        Me.td.Text = "6"
        '
        'serie
        '
        Me.serie.Location = New System.Drawing.Point(127, 12)
        Me.serie.Name = "serie"
        Me.serie.Size = New System.Drawing.Size(32, 20)
        Me.serie.TabIndex = 1
        '
        'folio
        '
        Me.folio.Location = New System.Drawing.Point(196, 12)
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(100, 20)
        Me.folio.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(355, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(412, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Serie:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Folio :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ImporteLabel)
        Me.GroupBox1.Controls.Add(Me.ImporteTextBox)
        Me.GroupBox1.Controls.Add(FechafacturaLabel)
        Me.GroupBox1.Controls.Add(Me.FechafacturaDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Id_directorioLabel)
        Me.GroupBox1.Controls.Add(Me.Id_directorioTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 123)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la factura"
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentos_clientesBindingSource, "Importe", True))
        Me.ImporteTextBox.Location = New System.Drawing.Point(88, 83)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImporteTextBox.TabIndex = 6
        '
        'Sql_documentos_clientesBindingSource
        '
        Me.Sql_documentos_clientesBindingSource.DataMember = "sql_documentos_clientes"
        Me.Sql_documentos_clientesBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechafacturaDateTimePicker
        '
        Me.FechafacturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sql_documentos_clientesBindingSource, "fechafactura", True))
        Me.FechafacturaDateTimePicker.Location = New System.Drawing.Point(88, 57)
        Me.FechafacturaDateTimePicker.Name = "FechafacturaDateTimePicker"
        Me.FechafacturaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechafacturaDateTimePicker.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentos_clientesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(138, 31)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(308, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'Id_directorioTextBox
        '
        Me.Id_directorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_documentos_clientesBindingSource, "id_directorio", True))
        Me.Id_directorioTextBox.Location = New System.Drawing.Point(88, 31)
        Me.Id_directorioTextBox.Name = "Id_directorioTextBox"
        Me.Id_directorioTextBox.Size = New System.Drawing.Size(44, 20)
        Me.Id_directorioTextBox.TabIndex = 1
        '
        'Sql_documentos_clientesTableAdapter
        '
        Me.Sql_documentos_clientesTableAdapter.ClearBeforeFill = True
        '
        'eliminar_documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 213)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.folio)
        Me.Controls.Add(Me.serie)
        Me.Controls.Add(Me.td)
        Me.Name = "eliminar_documento"
        Me.Text = "eliminar_documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Sql_documentos_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents td As System.Windows.Forms.TextBox
    Friend WithEvents serie As System.Windows.Forms.TextBox
    Friend WithEvents folio As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Sql_documentos_clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_documentos_clientesTableAdapter As AdminTegral.admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
    Friend WithEvents FechafacturaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_directorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
End Class
