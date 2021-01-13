Public Class cotizacion_relacion

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim folio As Integer = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells(1).Value
        imprimir(folio, False)
    End Sub 'Boton Imprimir

    Private Sub Boton_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_agregar.Click
        My.Forms.cotizaciones.Show()
        Me.Sql_documentos_clientesTableAdapter.FillByCotizaciones(Me.AdmintegralDataSet.sql_documentos_clientes)
    End Sub 'Boton nueva e imprimir

    Public Sub imprimir(ByVal folio As Integer, ByVal mandar_mail As Boolean)
        If folio = 0 Then Exit Sub
        Dim Email_cliente As String = ""
        Try
            Me.sql_documento_impresionTableAdapter.FillByundocumento(Me.AdmintegralDataSet.sql_documento_impresion, 10, folio, " ")
            Dim t As Decimal = Me.AdmintegralDataSet.sql_documento_impresion.Rows(0).Item("importe")
            Email_cliente = Me.AdmintegralDataSet.sql_documento_impresion.Rows(0).Item("email")
            Dim comision1 As Decimal = t * cia.comidebito
            Dim comision2 As Decimal = t * cia.comicredito
            Dim infopago As String = "Si paga con T. Debito " + Format(comision1, "N2") + ", con tarjeta " + Format(comision2, "N2")

            Dim letras, ct As String
            ct = Mid(Format(t - Fix(t), ".00"), 2, 2)
            letras = "Son:(" + Num2Text(Fix(t)) + " PESOS " + ct.ToString + "/100 M.N.)"
            Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter

            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("imletras", letras, False)
            rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", "Usuario: " + user.nombre, False)
            rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("infpago", infopago, False)
            Me.ReportViewer1.LocalReport.SetParameters(rp)

            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.Visible = True
            Me.ToolStrip2.Visible = True
            Me.ToolStrip1.Visible = False
        Catch ex As Exception

        End Try

        Dim filepdf As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\cotizacion" + folio.ToString + ".pdf"

        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Mandaer por correo la cotizacion " + filepdf + "?"
        msgtitulo = "Email"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub


      

        '===============================================================================================
        ' GENERA EL PDF DEL ARCHIVO
        '===============================================================================================
        Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim deviceInfo As String
        Dim bytes As Byte()
        Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        lr.ReportPath = "cotizaciones.rdlc"
        deviceInfo = "<DeviceInfo><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"
        bytes = ReportViewer1.LocalReport.Render("pdf", deviceInfo, mimeType, encoding, extension, streamids, warnings)
        Dim fs As New System.IO.FileStream(filepdf, System.IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        smtp = buzon()
        Email_cliente = InputBox("Direccion de correo para envio :", "Direccion Email", Email_cliente)

        If mandar_correo(Email_cliente, "Cotizacion Abarrotera Bara", "Anexamos Cotizacion Solicitada", filepdf, "") Then
            MsgBox("Cotizacion " + filepdf + " Enviada!")
        End If


    End Sub

    Private Sub cotizacion_relacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AdmintegralDataSet.EnforceConstraints = False
        Me.Sql_documentos_clientesTableAdapter.FillByCotizaciones(Me.AdmintegralDataSet.sql_documentos_clientes)
        Dim Filtro As String = "fechafactura = '" + sfecha.Value.Date + "'"
        Me.Sql_documentos_clientesBindingSource.Filter = Filtro
    End Sub

    Private Sub boton_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_excel.Click
        Dim folio As Integer = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells(1).Value
        Me.sql_documento_impresionTableAdapter.FillByundocumento(Me.AdmintegralDataSet.sql_documento_impresion, 10, folio, "  ")

        Dim t As Decimal = Me.AdmintegralDataSet.sql_documento_impresion.Compute("sum(importe)", "")
        Dim letras, ct As String
        ct = Mid(Format(t - Fix(t), ".00"), 2, 2)
        letras = "Son:(" + Num2Text(Fix(t)) + " PESOS " + ct.ToString + "/100 M.N.)"
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter

        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("imletras", letras, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", "Usuario: " + user.nombre, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)


        Dim file1 As String = "\Cotizacion_" + folio.ToString + ".xls"
        Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim deviceInfo As String
        Dim bytes As Byte()
        Dim file As String
        file = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        deviceInfo = "< deviceInfo ><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"

        bytes = ReportViewer1.LocalReport.Render("Excel", Nothing, _
          mimeType, encoding, extension, streamids, warnings)

        Dim fs As New System.IO.FileStream(file + file1, System.IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        Dim x As MsgBoxResult
        x = MessageBox.Show("Cotizacion guardada en " + file + file1 + ",  quiere Abrir el archvo? ", "Abrir Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        If x = MsgBoxResult.Yes Then
            Dim Proceso As New Process()
            Proceso.StartInfo.FileName = file + file1
            Proceso.StartInfo.Arguments = ""
            Proceso.Start()
        End If
    End Sub

    Private Sub boton_cerrar_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cerrar_reporte.Click
        Me.ReportViewer1.Visible = False
        Me.ToolStrip2.Visible = False
        Me.ToolStrip1.Visible = True
    End Sub

    Private Sub sfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sfecha.ValueChanged
        Dim Filtro As String = "fechafactura = '" + sfecha.Value.Date + "'"
        Me.Sql_documentos_clientesBindingSource.Filter = Filtro
    End Sub

    Private Sub Sql_documentos_clientesDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_documentos_clientesDataGridView.CellDoubleClick
        Dim folio As Integer = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells(1).Value
        My.Forms.cotizaciones.Show()
        My.Forms.cotizaciones.repetir_documento(10, folio, "  ", True)
        Me.Sql_documentos_clientesTableAdapter.FillByCotizaciones(Me.AdmintegralDataSet.sql_documentos_clientes)
    End Sub

    Public Sub refill()
        Me.Sql_documentos_clientesTableAdapter.FillByCotizaciones(Me.AdmintegralDataSet.sql_documentos_clientes)
    End Sub

    Private Sub boton_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_modificar.Click
        Dim folio As Integer = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells(1).Value
        My.Forms.cotizaciones.Show()
        My.Forms.cotizaciones.repetir_documento(10, folio, "  ", True)
        Me.Sql_documentos_clientesTableAdapter.FillByCotizaciones(Me.AdmintegralDataSet.sql_documentos_clientes)
    End Sub
End Class