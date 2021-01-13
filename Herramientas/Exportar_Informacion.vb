Public Class Exportar_Informacion
    Dim file As String
    Dim fileftp
    Dim fileorigen As String

    Private Sub exportar_archivos(ByVal fecha As Date)
        Dim cs As String = My.Settings.AdmintegralConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim tbl1 As DataTable = ds.Tables.Add("Documentos")
        Dim tbl2 As DataTable = ds.Tables.Add("movimientos")
        Dim tbl3 As DataTable = ds.Tables.Add("pagos")
        Dim tbl4 As DataTable = ds.Tables.Add("pagos_detalle")
        Dim tbl5 As DataTable = ds.Tables.Add("comentarios")
        Dim tbl6 As DataTable = ds.Tables.Add("tmp_productos")
        Dim tbl7 As DataTable = ds.Tables.Add("log_cajas")
        Dim tbl8 As DataTable = ds.Tables.Add("dolares")
        Dim tbl9 As DataTable = ds.Tables.Add("fei_cfd")
        Dim tbl As New DataTable
        Dim sql As String = "Select * from paths where id = 2"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl)
        Dim path As String
        path = tbl.Rows(0).Item(2)

        fileorigen = Trim(path) + "Mov_caja_" + My.Settings.ncaja.ToString + "_" + Format(fecha, "ddMyyyy") + ".xml"
        fileftp = My.Settings.ftppath_cortes + "Mov_caja_" + My.Settings.ncaja.ToString + "_" + Format(fecha, "ddMyyyy") + ".xml"
        file = "Mov_caja_" + My.Settings.ncaja.ToString + "_" + Format(fecha, "ddMyyyy") + ".xml"
        filenametxt.Text = fileorigen
        filenametxt.Refresh()
        Me.Refresh()

        'carga documentos
        sql = "SELECT * from documentos WHERE fechafactura = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl1)

        'carga movimientos
        sql = "SELECT * from movimientos WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl2)

        'Cargar Pgaos
        sql = "SELECT * from pagos WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl3)

        sql = "SELECT  pagos_detalle.id_pago, pagos_detalle.id_doc, pagos_detalle.folio, pagos_detalle.serie, pagos_detalle.abono, pagos_detalle.caja FROM pagos_detalle INNER JOIN " _
        & "Pagos ON pagos_detalle.id_pago = Pagos.id_pago " _
        & " WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl4)

        sql = "SELECT Comentarios.td, Comentarios.folio, Comentarios.serie, Comentarios.puerta, Comentarios.quien, Comentarios.Comentarios " _
        & "FROM Comentarios INNER JOIN " _
        & " Documentos ON Comentarios.td = Documentos.td AND Comentarios.folio = Documentos.Folio AND Comentarios.serie = Documentos.serie " _
        & " WHERE Documentos.fregistro = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl5)

        'Cargar Productos Temporales
        sql = "SELECT * from tmp_productos "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl6)

        'Cargar Pgaos
        sql = "SELECT * from log_cajas WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl7)

        'Cargar dolares
        sql = "SELECT * from dolares WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl8)

        sql = "SELECT * FROM  fei_cfd WHERE (fecha >= CONVERT(DATETIME, '[fecha] 00:00:00', 102)) and (fecha <= CONVERT(DATETIME, '[fecha] 23:59:00', 102))"
        sql = sql.Replace("[fecha]", Format(fecha, "yyyy-M-dd"))
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl9)


        ds.WriteXml(fileorigen)
    End Sub

    Private Sub boton_internet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_internet.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        exportar_archivos(fecha.Value)
        ftp()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ftp()
        'Create a link to an FtpServer
        Dim ftp As New Utilities.FTP.FTPclient(My.Settings.ftpserver, My.Settings.ftpuser, My.Settings.ftppw)
        'upload a file
        barra.Visible = True
        Me.Refresh()
        ftp.Upload(fileorigen, fileftp)
        barra.Visible = False
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub boton_usb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_usb.Click
        exportar_archivos(fecha.Value)
        Folder.ShowDialog()
        Dim filedestino As String = Folder.SelectedPath + "\" + file
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            FileCopy(fileorigen, filedestino)
            MsgBox("Archivo " + filedestino + " Copiado", MsgBoxStyle.Information)
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub exportar_base(ByVal fecha As Date)
        Dim cs As String = My.Settings.AdmintegralConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim tbl1 As DataTable = ds.Tables.Add("Documentos")
        Dim tbl2 As DataTable = ds.Tables.Add("movimientos")
        Dim tbl3 As DataTable = ds.Tables.Add("pagos")
        Dim tbl4 As DataTable = ds.Tables.Add("pagos_detalle")
        Dim tbl5 As DataTable = ds.Tables.Add("comentarios")
        Dim tbl6 As DataTable = ds.Tables.Add("tmp_productos")
        Dim tbl7 As DataTable = ds.Tables.Add("log_cajas")
        Dim tbl As New DataTable
        Dim sql As String = "Select * from paths where id = 2"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl)
        Dim path As String
        path = tbl.Rows(0).Item(2)

        fileorigen = Trim(path) + "Mov_caja_" + My.Settings.ncaja.ToString + "_" + Format(fecha, "ddMyyyy") + ".xml"
        fileftp = My.Settings.ftppath_cortes + "Mov_caja_" + My.Settings.ncaja.ToString + "_" + Format(fecha, "ddMyyyy") + ".xml"
        file = "Mov_caja_" + My.Settings.ncaja.ToString + "_" + Format(fecha, "ddMyyyy") + ".xml"
        filenametxt.Text = fileorigen
        filenametxt.Refresh()
        Me.Refresh()

        'carga documentos
        sql = "SELECT * from documentos WHERE fechafactura = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl1)

        'carga movimientos
        sql = "SELECT * from movimientos WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl2)

        'Cargar Pgaos
        sql = "SELECT * from pagos WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl3)

        sql = "SELECT  pagos_detalle.id_pago, pagos_detalle.id_doc, pagos_detalle.folio, pagos_detalle.serie, pagos_detalle.abono FROM pagos_detalle INNER JOIN " _
        & "Pagos ON pagos_detalle.id_pago = Pagos.id_pago " _
        & " WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl4)

        sql = "SELECT Comentarios.td, Comentarios.folio, Comentarios.serie, Comentarios.puerta, Comentarios.quien, Comentarios.Comentarios " _
        & "FROM Comentarios INNER JOIN " _
        & " Documentos ON Comentarios.td = Documentos.td AND Comentarios.folio = Documentos.Folio AND Comentarios.serie = Documentos.serie " _
        & " WHERE Documentos.fregistro = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl5)

        'Cargar Productos Temporales
        sql = "SELECT * from tmp_productos "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl6)

        'Cargar Pgaos
        sql = "SELECT * from log_cajas WHERE fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl7)
        ds.WriteXml(fileorigen)
    End Sub

    Private Sub exportar_pagos(ByVal fecha As Date)
        Dim cs As String = My.Settings.AdmintegralConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim tbl3 As DataTable = ds.Tables.Add("pagos")
        Dim tbl4 As DataTable = ds.Tables.Add("pagos_detalle")
        Dim tbl As New DataTable
        Dim sql As String = "Select * from paths where id = 2"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl)
        Dim path As String
        path = tbl.Rows(0).Item(2)

        'Cargar Pgaos
        sql = "SELECT * from pagos WHERE agente <>0 and id_fp=1 and fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl3)

        sql = "SELECT  pagos_detalle.id_pago, pagos_detalle.id_doc, pagos_detalle.folio, pagos_detalle.serie, pagos_detalle.abono FROM pagos_detalle INNER JOIN " _
        & "Pagos ON pagos_detalle.id_pago = Pagos.id_pago " _
        & " WHERE agente <>0 and id_fp=1 and  fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102)  "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl4)

        ds.WriteXml(fileorigen)
    End Sub

    Private Sub exportar_cfd()
        Dim cs As String = My.Settings.AdmintegralConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim tbl1 As DataTable = ds.Tables.Add("fei_cfd")
        Dim tbl As New DataTable
        Dim sql As String = "Select * from paths where id = 2"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl)
        Dim path As String
        path = tbl.Rows(0).Item(2)

        fileorigen = Trim(path) + "cfd_caja_" + My.Settings.ncaja.ToString + ".xml"
        fileftp = My.Settings.ftppath_cortes + "cfd_caja_" + My.Settings.ncaja.ToString + ".xml"
        file = "cfd_caja_" + My.Settings.ncaja.ToString + ".xml"
        filenametxt.Text = fileorigen
        filenametxt.Refresh()
        Me.Refresh()

        'Cargar Productos Temporales
        sql = "SELECT * from fei_cfd "
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl1)
        ds.WriteXml(fileorigen)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        exportar_cfd()
        Folder.ShowDialog()
        Dim filedestino As String = Folder.SelectedPath + "\" + file
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            FileCopy(fileorigen, filedestino)
            MsgBox("Archivo " + filedestino + " Copiado", MsgBoxStyle.Information)
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ini()
        Dim sql As String
        Sql = "SELECT * FROM  fei_cfd WHERE (fecha >= CONVERT(DATETIME, '[fecha] 00:00:00', 102)) and (fecha <= CONVERT(DATETIME, '[fecha] 23:59:00', 102))"
        sql = sql.Replace("[fecha]", Format(fecha.Value, "yyyy-M-dd"))
        Dim tbl As DataTable
        tbl = leer_tabla(sql)
        Dim xlmfile, pdffile As String

        barra.Maximum = tbl.Rows.Count
        For j As Integer = 0 To tbl.Rows.Count - 1
            barra.Value = j

            xlmfile = dfei.ruta + tbl.Rows(j).Item("rutaynombrecfd")
            pdffile = xlmfile.Replace(".xlm", ".pdf")

            Dim xmlftp As String = My.Settings.ftpfei + tbl.Rows(j).Item("rutaynombrecfd")
            Dim pdfftp As String = xmlftp.Replace(".xlm", ".pdf")

            Try
                ftp(pdffile, pdfftp)
                'MsgBox(pdffile + "/" + pdfftp)
            Catch ex As Exception

            End Try

            Try
                ftp(pdffile, pdfftp)
                'MsgBox(pdffile + "/" + pdfftp)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub ftp(ByVal fileorigen As String, ByVal fileftp As String)
        If My.Settings.terminal = True Then
            Try
                Dim ftp As New Utilities.FTP.FTPclient(My.Settings.ftpserver, My.Settings.ftpuser, My.Settings.ftppw)
                Me.Refresh()
                ftp.Upload(fileorigen, fileftp)
            Catch ex As Exception

            End Try


        End If
    End Sub
End Class