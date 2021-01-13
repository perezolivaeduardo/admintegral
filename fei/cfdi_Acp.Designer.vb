<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cfdi_Acp
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.emisorbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.DomicilioFiscalbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.regimenbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.receptorbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.domiciliobs = New System.Windows.Forms.BindingSource(Me.components)
        Me.conceptobs = New System.Windows.Forms.BindingSource(Me.components)
        Me.comprobantebs = New System.Windows.Forms.BindingSource(Me.components)
        Me.timbrebs = New System.Windows.Forms.BindingSource(Me.components)
        Me.qrcode = New System.Windows.Forms.PictureBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.trasladosbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.impuestobs = New System.Windows.Forms.BindingSource(Me.components)
        Me.retencionbs = New System.Windows.Forms.BindingSource(Me.components)
        Me.complementobs = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fei_facturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt0 = New System.Windows.Forms.TextBox()
        Me.txt16 = New System.Windows.Forms.TextBox()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.ttelefono = New System.Windows.Forms.TextBox()
        CType(Me.emisorbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomicilioFiscalbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regimenbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receptorbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.domiciliobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.conceptobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comprobantebs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timbrebs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qrcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trasladosbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.impuestobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.retencionbs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.complementobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fei_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'qrcode
        '
        Me.qrcode.Location = New System.Drawing.Point(3, 1)
        Me.qrcode.Name = "qrcode"
        Me.qrcode.Size = New System.Drawing.Size(144, 153)
        Me.qrcode.TabIndex = 0
        Me.qrcode.TabStop = False
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "emisor"
        ReportDataSource1.Value = Me.emisorbs
        ReportDataSource2.Name = "DomicilioFiscal"
        ReportDataSource2.Value = Me.DomicilioFiscalbs
        ReportDataSource3.Name = "regimen"
        ReportDataSource3.Value = Me.regimenbs
        ReportDataSource4.Name = "Receptor"
        ReportDataSource4.Value = Me.receptorbs
        ReportDataSource5.Name = "Domicilio"
        ReportDataSource5.Value = Me.domiciliobs
        ReportDataSource6.Name = "concepto"
        ReportDataSource6.Value = Me.conceptobs
        ReportDataSource7.Name = "Comprobante"
        ReportDataSource7.Value = Me.comprobantebs
        ReportDataSource8.Name = "timbre"
        ReportDataSource8.Value = Me.timbrebs
        ReportDataSource9.Name = "detalleds"
        ReportDataSource9.Value = Me.Fei_facturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AdminTegral.cfdi.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(546, 70)
        Me.ReportViewer1.TabIndex = 1
        '
        'txt0
        '
        Me.txt0.Location = New System.Drawing.Point(276, 90)
        Me.txt0.Name = "txt0"
        Me.txt0.Size = New System.Drawing.Size(100, 20)
        Me.txt0.TabIndex = 2
        '
        'txt16
        '
        Me.txt16.Location = New System.Drawing.Point(276, 116)
        Me.txt16.Name = "txt16"
        Me.txt16.Size = New System.Drawing.Size(100, 20)
        Me.txt16.TabIndex = 3
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(449, 77)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(100, 20)
        Me.tid.TabIndex = 4
        '
        'ttelefono
        '
        Me.ttelefono.Location = New System.Drawing.Point(449, 116)
        Me.ttelefono.Name = "ttelefono"
        Me.ttelefono.Size = New System.Drawing.Size(100, 20)
        Me.ttelefono.TabIndex = 5
        '
        'cfdi_Acp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 167)
        Me.Controls.Add(Me.ttelefono)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.txt16)
        Me.Controls.Add(Me.txt0)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.qrcode)
        Me.Name = "cfdi_Acp"
        Me.Text = "CFDI"
        CType(Me.emisorbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomicilioFiscalbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regimenbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receptorbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.domiciliobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.conceptobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comprobantebs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timbrebs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qrcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trasladosbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.impuestobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.retencionbs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.complementobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fei_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents qrcode As System.Windows.Forms.PictureBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents emisorbs As System.Windows.Forms.BindingSource
    Friend WithEvents DomicilioFiscalbs As System.Windows.Forms.BindingSource
    Friend WithEvents regimenbs As System.Windows.Forms.BindingSource
    Friend WithEvents receptorbs As System.Windows.Forms.BindingSource
    Friend WithEvents domiciliobs As System.Windows.Forms.BindingSource
    Friend WithEvents conceptobs As System.Windows.Forms.BindingSource
    Friend WithEvents comprobantebs As System.Windows.Forms.BindingSource
    Friend WithEvents timbrebs As System.Windows.Forms.BindingSource
    Friend WithEvents trasladosbs As System.Windows.Forms.BindingSource
    Friend WithEvents impuestobs As System.Windows.Forms.BindingSource
    Friend WithEvents retencionbs As System.Windows.Forms.BindingSource
    Friend WithEvents complementobs As System.Windows.Forms.BindingSource
    Friend WithEvents Fei_facturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txt0 As System.Windows.Forms.TextBox
    Friend WithEvents txt16 As System.Windows.Forms.TextBox
    Friend WithEvents tid As System.Windows.Forms.TextBox
    Friend WithEvents ttelefono As System.Windows.Forms.TextBox
End Class
