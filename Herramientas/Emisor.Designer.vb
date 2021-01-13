<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emisor
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
        Dim RFCLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CodigopostalLabel As System.Windows.Forms.Label
        Dim CertificadoLabel As System.Windows.Forms.Label
        Dim LlaveprivadaLabel As System.Windows.Forms.Label
        Dim RutaarchivodigitalLabel As System.Windows.Forms.Label
        Me.FeiDataset = New AdminTegral.feiDataset()
        Me.EmisorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmisorTableAdapter = New AdminTegral.feiDatasetTableAdapters.emisorTableAdapter()
        Me.RFCTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CodigopostalTextBox = New System.Windows.Forms.TextBox()
        Me.CertificadoTextBox = New System.Windows.Forms.TextBox()
        Me.LlaveprivadaTextBox = New System.Windows.Forms.TextBox()
        Me.RutaarchivodigitalTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        RFCLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CodigopostalLabel = New System.Windows.Forms.Label()
        CertificadoLabel = New System.Windows.Forms.Label()
        LlaveprivadaLabel = New System.Windows.Forms.Label()
        RutaarchivodigitalLabel = New System.Windows.Forms.Label()
        CType(Me.FeiDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmisorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Location = New System.Drawing.Point(70, 30)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(31, 13)
        RFCLabel.TabIndex = 1
        RFCLabel.Text = "RFC:"
        '
        'FeiDataset
        '
        Me.FeiDataset.DataSetName = "feiDataset"
        Me.FeiDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmisorBindingSource
        '
        Me.EmisorBindingSource.DataMember = "emisor"
        Me.EmisorBindingSource.DataSource = Me.FeiDataset
        '
        'EmisorTableAdapter
        '
        Me.EmisorTableAdapter.ClearBeforeFill = True
        '
        'RFCTextBox
        '
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "RFC", True))
        Me.RFCTextBox.Location = New System.Drawing.Point(107, 27)
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RFCTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(54, 56)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(107, 53)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(474, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'CodigopostalLabel
        '
        CodigopostalLabel.AutoSize = True
        CodigopostalLabel.Location = New System.Drawing.Point(30, 82)
        CodigopostalLabel.Name = "CodigopostalLabel"
        CodigopostalLabel.Size = New System.Drawing.Size(71, 13)
        CodigopostalLabel.TabIndex = 5
        CodigopostalLabel.Text = "Codigopostal:"
        '
        'CodigopostalTextBox
        '
        Me.CodigopostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Codigopostal", True))
        Me.CodigopostalTextBox.Location = New System.Drawing.Point(107, 79)
        Me.CodigopostalTextBox.Name = "CodigopostalTextBox"
        Me.CodigopostalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigopostalTextBox.TabIndex = 6
        '
        'CertificadoLabel
        '
        CertificadoLabel.AutoSize = True
        CertificadoLabel.Location = New System.Drawing.Point(58, 108)
        CertificadoLabel.Name = "CertificadoLabel"
        CertificadoLabel.Size = New System.Drawing.Size(43, 13)
        CertificadoLabel.TabIndex = 7
        CertificadoLabel.Text = "Usuario"
        '
        'CertificadoTextBox
        '
        Me.CertificadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "certificado", True))
        Me.CertificadoTextBox.Location = New System.Drawing.Point(107, 105)
        Me.CertificadoTextBox.Name = "CertificadoTextBox"
        Me.CertificadoTextBox.Size = New System.Drawing.Size(474, 20)
        Me.CertificadoTextBox.TabIndex = 8
        '
        'LlaveprivadaLabel
        '
        LlaveprivadaLabel.AutoSize = True
        LlaveprivadaLabel.Location = New System.Drawing.Point(40, 138)
        LlaveprivadaLabel.Name = "LlaveprivadaLabel"
        LlaveprivadaLabel.Size = New System.Drawing.Size(61, 13)
        LlaveprivadaLabel.TabIndex = 9
        LlaveprivadaLabel.Text = "Contraseña"
        '
        'LlaveprivadaTextBox
        '
        Me.LlaveprivadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "llaveprivada", True))
        Me.LlaveprivadaTextBox.Location = New System.Drawing.Point(107, 131)
        Me.LlaveprivadaTextBox.Name = "LlaveprivadaTextBox"
        Me.LlaveprivadaTextBox.Size = New System.Drawing.Size(474, 20)
        Me.LlaveprivadaTextBox.TabIndex = 10
        '
        'RutaarchivodigitalLabel
        '
        RutaarchivodigitalLabel.AutoSize = True
        RutaarchivodigitalLabel.Location = New System.Drawing.Point(20, 169)
        RutaarchivodigitalLabel.Name = "RutaarchivodigitalLabel"
        RutaarchivodigitalLabel.Size = New System.Drawing.Size(81, 13)
        RutaarchivodigitalLabel.TabIndex = 11
        RutaarchivodigitalLabel.Text = "Archivo Digital :"
        '
        'RutaarchivodigitalTextBox
        '
        Me.RutaarchivodigitalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "rutaarchivodigital", True))
        Me.RutaarchivodigitalTextBox.Location = New System.Drawing.Point(107, 166)
        Me.RutaarchivodigitalTextBox.Name = "RutaarchivodigitalTextBox"
        Me.RutaarchivodigitalTextBox.Size = New System.Drawing.Size(474, 20)
        Me.RutaarchivodigitalTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Emisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 271)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RutaarchivodigitalLabel)
        Me.Controls.Add(Me.RutaarchivodigitalTextBox)
        Me.Controls.Add(LlaveprivadaLabel)
        Me.Controls.Add(Me.LlaveprivadaTextBox)
        Me.Controls.Add(CertificadoLabel)
        Me.Controls.Add(Me.CertificadoTextBox)
        Me.Controls.Add(CodigopostalLabel)
        Me.Controls.Add(Me.CodigopostalTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(RFCLabel)
        Me.Controls.Add(Me.RFCTextBox)
        Me.Name = "Emisor"
        Me.Text = "Emisor"
        CType(Me.FeiDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmisorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FeiDataset As AdminTegral.feiDataset
    Friend WithEvents EmisorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmisorTableAdapter As AdminTegral.feiDatasetTableAdapters.emisorTableAdapter
    Friend WithEvents RFCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigopostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CertificadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LlaveprivadaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RutaarchivodigitalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
