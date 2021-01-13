<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caja_status
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
        Dim Id_cajaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim HorainicioLabel As System.Windows.Forms.Label
        Dim Iduser_abrioLabel As System.Windows.Forms.Label
        Dim HoracierreLabel As System.Windows.Forms.Label
        Dim Iduser_cerroLabel As System.Windows.Forms.Label
        Dim Id_contadoLabel As System.Windows.Forms.Label
        Dim Id_valesLabel As System.Windows.Forms.Label
        Dim CerradaLabel As System.Windows.Forms.Label
        Dim SerieFLabel As System.Windows.Forms.Label
        Dim FolioLabel As System.Windows.Forms.Label
        Me.AdmintegralDataSet = New AdminTegral.admintegralDataSet
        Me.Log_cajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Log_cajasTableAdapter = New AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter
        Me.Id_cajaTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.HorainicioDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Iduser_abrioTextBox = New System.Windows.Forms.TextBox
        Me.HoracierreDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Iduser_cerroTextBox = New System.Windows.Forms.TextBox
        Me.Id_contadoTextBox = New System.Windows.Forms.TextBox
        Me.Id_valesTextBox = New System.Windows.Forms.TextBox
        Me.CerradaCheckBox = New System.Windows.Forms.CheckBox
        Me.SerieFTextBox = New System.Windows.Forms.TextBox
        Me.FolioTextBox = New System.Windows.Forms.TextBox
        Me.boton_ok = New System.Windows.Forms.Button
        Id_cajaLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        HorainicioLabel = New System.Windows.Forms.Label
        Iduser_abrioLabel = New System.Windows.Forms.Label
        HoracierreLabel = New System.Windows.Forms.Label
        Iduser_cerroLabel = New System.Windows.Forms.Label
        Id_contadoLabel = New System.Windows.Forms.Label
        Id_valesLabel = New System.Windows.Forms.Label
        CerradaLabel = New System.Windows.Forms.Label
        SerieFLabel = New System.Windows.Forms.Label
        FolioLabel = New System.Windows.Forms.Label
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log_cajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_cajaLabel
        '
        Id_cajaLabel.AutoSize = True
        Id_cajaLabel.Location = New System.Drawing.Point(27, 28)
        Id_cajaLabel.Name = "Id_cajaLabel"
        Id_cajaLabel.Size = New System.Drawing.Size(41, 13)
        Id_cajaLabel.TabIndex = 2
        Id_cajaLabel.Text = "id caja:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(31, 55)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "fecha:"
        '
        'HorainicioLabel
        '
        HorainicioLabel.AutoSize = True
        HorainicioLabel.Location = New System.Drawing.Point(13, 81)
        HorainicioLabel.Name = "HorainicioLabel"
        HorainicioLabel.Size = New System.Drawing.Size(55, 13)
        HorainicioLabel.TabIndex = 6
        HorainicioLabel.Text = "horainicio:"
        '
        'Iduser_abrioLabel
        '
        Iduser_abrioLabel.AutoSize = True
        Iduser_abrioLabel.Location = New System.Drawing.Point(4, 106)
        Iduser_abrioLabel.Name = "Iduser_abrioLabel"
        Iduser_abrioLabel.Size = New System.Drawing.Size(75, 13)
        Iduser_abrioLabel.TabIndex = 8
        Iduser_abrioLabel.Text = "Id. quien Abrio"
        '
        'HoracierreLabel
        '
        HoracierreLabel.AutoSize = True
        HoracierreLabel.Location = New System.Drawing.Point(11, 133)
        HoracierreLabel.Name = "HoracierreLabel"
        HoracierreLabel.Size = New System.Drawing.Size(57, 13)
        HoracierreLabel.TabIndex = 10
        HoracierreLabel.Text = "horacierre:"
        '
        'Iduser_cerroLabel
        '
        Iduser_cerroLabel.AutoSize = True
        Iduser_cerroLabel.Location = New System.Drawing.Point(3, 158)
        Iduser_cerroLabel.Name = "Iduser_cerroLabel"
        Iduser_cerroLabel.Size = New System.Drawing.Size(78, 13)
        Iduser_cerroLabel.TabIndex = 12
        Iduser_cerroLabel.Text = "Id quien Cierra:"
        '
        'Id_contadoLabel
        '
        Id_contadoLabel.AutoSize = True
        Id_contadoLabel.Location = New System.Drawing.Point(8, 184)
        Id_contadoLabel.Name = "Id_contadoLabel"
        Id_contadoLabel.Size = New System.Drawing.Size(60, 13)
        Id_contadoLabel.TabIndex = 14
        Id_contadoLabel.Text = "id contado:"
        '
        'Id_valesLabel
        '
        Id_valesLabel.AutoSize = True
        Id_valesLabel.Location = New System.Drawing.Point(22, 211)
        Id_valesLabel.Name = "Id_valesLabel"
        Id_valesLabel.Size = New System.Drawing.Size(46, 13)
        Id_valesLabel.TabIndex = 16
        Id_valesLabel.Text = "id vales:"
        '
        'CerradaLabel
        '
        CerradaLabel.AutoSize = True
        CerradaLabel.Location = New System.Drawing.Point(22, 238)
        CerradaLabel.Name = "CerradaLabel"
        CerradaLabel.Size = New System.Drawing.Size(46, 13)
        CerradaLabel.TabIndex = 18
        CerradaLabel.Text = "cerrada:"
        '
        'SerieFLabel
        '
        SerieFLabel.AutoSize = True
        SerieFLabel.Location = New System.Drawing.Point(111, 238)
        SerieFLabel.Name = "SerieFLabel"
        SerieFLabel.Size = New System.Drawing.Size(41, 13)
        SerieFLabel.TabIndex = 20
        SerieFLabel.Text = "serie F:"
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Location = New System.Drawing.Point(204, 238)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(29, 13)
        FolioLabel.TabIndex = 22
        FolioLabel.Text = "folio:"
        '
        'AdmintegralDataSet
        '
        Me.AdmintegralDataSet.DataSetName = "admintegralDataSet"
        Me.AdmintegralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Log_cajasBindingSource
        '
        Me.Log_cajasBindingSource.DataMember = "log_cajas"
        Me.Log_cajasBindingSource.DataSource = Me.AdmintegralDataSet
        '
        'Log_cajasTableAdapter
        '
        Me.Log_cajasTableAdapter.ClearBeforeFill = True
        '
        'Id_cajaTextBox
        '
        Me.Id_cajaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "id_caja", True))
        Me.Id_cajaTextBox.Enabled = False
        Me.Id_cajaTextBox.Location = New System.Drawing.Point(83, 25)
        Me.Id_cajaTextBox.Name = "Id_cajaTextBox"
        Me.Id_cajaTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Id_cajaTextBox.TabIndex = 3
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Log_cajasBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(83, 51)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'HorainicioDateTimePicker
        '
        Me.HorainicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Log_cajasBindingSource, "horainicio", True))
        Me.HorainicioDateTimePicker.Enabled = False
        Me.HorainicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HorainicioDateTimePicker.Location = New System.Drawing.Point(83, 77)
        Me.HorainicioDateTimePicker.Name = "HorainicioDateTimePicker"
        Me.HorainicioDateTimePicker.Size = New System.Drawing.Size(106, 20)
        Me.HorainicioDateTimePicker.TabIndex = 7
        '
        'Iduser_abrioTextBox
        '
        Me.Iduser_abrioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "iduser_abrio", True))
        Me.Iduser_abrioTextBox.Enabled = False
        Me.Iduser_abrioTextBox.Location = New System.Drawing.Point(83, 103)
        Me.Iduser_abrioTextBox.Name = "Iduser_abrioTextBox"
        Me.Iduser_abrioTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Iduser_abrioTextBox.TabIndex = 9
        '
        'HoracierreDateTimePicker
        '
        Me.HoracierreDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Log_cajasBindingSource, "horacierre", True))
        Me.HoracierreDateTimePicker.Enabled = False
        Me.HoracierreDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoracierreDateTimePicker.Location = New System.Drawing.Point(83, 129)
        Me.HoracierreDateTimePicker.Name = "HoracierreDateTimePicker"
        Me.HoracierreDateTimePicker.Size = New System.Drawing.Size(106, 20)
        Me.HoracierreDateTimePicker.TabIndex = 11
        '
        'Iduser_cerroTextBox
        '
        Me.Iduser_cerroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "iduser_cerro", True))
        Me.Iduser_cerroTextBox.Enabled = False
        Me.Iduser_cerroTextBox.Location = New System.Drawing.Point(83, 155)
        Me.Iduser_cerroTextBox.Name = "Iduser_cerroTextBox"
        Me.Iduser_cerroTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Iduser_cerroTextBox.TabIndex = 13
        '
        'Id_contadoTextBox
        '
        Me.Id_contadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "id_contado", True))
        Me.Id_contadoTextBox.Enabled = False
        Me.Id_contadoTextBox.Location = New System.Drawing.Point(83, 181)
        Me.Id_contadoTextBox.Name = "Id_contadoTextBox"
        Me.Id_contadoTextBox.Size = New System.Drawing.Size(39, 20)
        Me.Id_contadoTextBox.TabIndex = 15
        '
        'Id_valesTextBox
        '
        Me.Id_valesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "id_vales", True))
        Me.Id_valesTextBox.Enabled = False
        Me.Id_valesTextBox.Location = New System.Drawing.Point(83, 208)
        Me.Id_valesTextBox.Name = "Id_valesTextBox"
        Me.Id_valesTextBox.Size = New System.Drawing.Size(39, 20)
        Me.Id_valesTextBox.TabIndex = 17
        '
        'CerradaCheckBox
        '
        Me.CerradaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Log_cajasBindingSource, "cerrada", True))
        Me.CerradaCheckBox.Enabled = False
        Me.CerradaCheckBox.Location = New System.Drawing.Point(83, 233)
        Me.CerradaCheckBox.Name = "CerradaCheckBox"
        Me.CerradaCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.CerradaCheckBox.TabIndex = 19
        '
        'SerieFTextBox
        '
        Me.SerieFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "serieF", True))
        Me.SerieFTextBox.Enabled = False
        Me.SerieFTextBox.Location = New System.Drawing.Point(157, 235)
        Me.SerieFTextBox.Name = "SerieFTextBox"
        Me.SerieFTextBox.Size = New System.Drawing.Size(32, 20)
        Me.SerieFTextBox.TabIndex = 21
        '
        'FolioTextBox
        '
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Log_cajasBindingSource, "folio", True))
        Me.FolioTextBox.Enabled = False
        Me.FolioTextBox.Location = New System.Drawing.Point(238, 235)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.Size = New System.Drawing.Size(106, 20)
        Me.FolioTextBox.TabIndex = 23
        '
        'boton_ok
        '
        Me.boton_ok.Location = New System.Drawing.Point(269, 274)
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(75, 23)
        Me.boton_ok.TabIndex = 24
        Me.boton_ok.Text = "Ok"
        Me.boton_ok.UseVisualStyleBackColor = True
        '
        'caja_status
        '
        Me.AcceptButton = Me.boton_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(367, 308)
        Me.Controls.Add(Me.boton_ok)
        Me.Controls.Add(Id_cajaLabel)
        Me.Controls.Add(Me.Id_cajaTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(HorainicioLabel)
        Me.Controls.Add(Me.HorainicioDateTimePicker)
        Me.Controls.Add(Iduser_abrioLabel)
        Me.Controls.Add(Me.Iduser_abrioTextBox)
        Me.Controls.Add(HoracierreLabel)
        Me.Controls.Add(Me.HoracierreDateTimePicker)
        Me.Controls.Add(Iduser_cerroLabel)
        Me.Controls.Add(Me.Iduser_cerroTextBox)
        Me.Controls.Add(Id_contadoLabel)
        Me.Controls.Add(Me.Id_contadoTextBox)
        Me.Controls.Add(Id_valesLabel)
        Me.Controls.Add(Me.Id_valesTextBox)
        Me.Controls.Add(CerradaLabel)
        Me.Controls.Add(Me.CerradaCheckBox)
        Me.Controls.Add(SerieFLabel)
        Me.Controls.Add(Me.SerieFTextBox)
        Me.Controls.Add(FolioLabel)
        Me.Controls.Add(Me.FolioTextBox)
        Me.Name = "caja_status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Caja"
        CType(Me.AdmintegralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log_cajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdmintegralDataSet As AdminTegral.admintegralDataSet
    Friend WithEvents Log_cajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Log_cajasTableAdapter As AdminTegral.admintegralDataSetTableAdapters.log_cajasTableAdapter
    Friend WithEvents Id_cajaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HorainicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Iduser_abrioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoracierreDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Iduser_cerroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_contadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_valesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CerradaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SerieFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents boton_ok As System.Windows.Forms.Button
End Class
