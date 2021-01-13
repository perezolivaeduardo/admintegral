Public Class estadistica_agentes

   

    Private Sub estadistica_agentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim periodo As String = Me.mes.Text + "/" + año.Value.ToString
        Dim nmes As Integer = Me.mes.SelectedIndex + 1, naño As Integer = año.Value
        If nmes = 12 Then nmes = 0 : naño = año.Value + 1
        Dim corte As Date = DateSerial(naño, nmes + 1, 1)
        corte = corte.AddDays(-1)
        Me.Text = "Comparativo de ventas vs recuperado " + periodo + " fecha de corte :" + corte.ToShortDateString
        Dim cmd As String = "select * from cxc_est_auxiliar where fecha='" + periodo + "'"
        Dim nr = leer_tabla(cmd).Rows.Count


        If nr = 0 Then
            Dim ix As MsgBoxResult = MsgBox("No existe ese periodo quiere generarlo?", MsgBoxStyle.YesNo, "Crear Periodo")

            If ix = MsgBoxResult.Yes Then crear_periodo(periodo, corte)
            MsgBox("periodo generado, haga clic en ver para desplegarlo")
            Exit Sub
        End If

        Me.btn_generar.Enabled = True
        Dim filtroagentes As String = ""
        If Me.kagentes.TextLength > 0 Then
            Dim g() As String
            g = Me.kagentes.Text.Split(",")
            If g.GetLength(0) = 0 Then MsgBox("Definir numeros de agente") : Exit Sub

            For j As Integer = 0 To g.GetLength(0) - 1
                If j = 0 Then
                    If g(j).Length > 0 Then filtroagentes += " id_agente = " + g(j).ToString
                Else
                    If g(j).Length > 0 Then filtroagentes += " or id_agente = " + g(j).ToString
                End If
            Next
        Else
            filtroagentes = " id_agente > 0 "
        End If

        cmd = "SELECT  id_agente, Nombre, Inicial, Facturado, Recuperado, Saldo, clientes, fecha, por FROM cxc_est_agentes " _
        & "WHERE fecha = '[periodo]'  and ([filtro] )ORDER BY Nombre "
        cmd = cmd.Replace("[periodo]", periodo)
        cmd = cmd.Replace("[filtro]", filtroagentes)
        Dim tbl As New DataTable
        tbl = leer_tabla(cmd)

        For j As Integer = 0 To tbl.Rows.Count - 1
            With tbl.Rows(j)
                If .Item("Facturado") > 0 Then
                    .Item("por") = .Item("Recuperado") * 100 / .Item("Facturado")
                Else
                    .Item("por") = .Item("Recuperado") * 100 / .Item("Inicial")
                End If
            End With
        Next

        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", periodo, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)

        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub crear_periodo(ByVal periodo As String, ByVal corte As Date)
        Dim cmd1 As String, fe As String
        Dim cmd As String = "delete  from cxc_est_auxiliar where fecha='" + periodo + "'"
        comando(cmd)

        'borra tabla temporal de abonos
        cmd1 = " delete  from tmp_abonos"
        Dim ok1 As Boolean = comando(cmd1)
        'Sumarisa los abonos por factura
        cmd1 = "INSERT INTO [integra].[dbo].[tmp_abonos] ([id_doc],[folio],[serie],[abono])" _
        & " SELECT     dbo.pagos_detalle.id_doc, dbo.pagos_detalle.folio, dbo.pagos_detalle.serie, SUM(dbo.pagos_detalle.abono) AS abono " _
        & "FROM dbo.Pagos INNER JOIN dbo.pagos_detalle ON dbo.Pagos.id_pago = dbo.pagos_detalle.id_pago AND dbo.Pagos.caja = dbo.pagos_detalle.caja " _
        & "WHERE dbo.Pagos.fecha_apliacion <= CONVERT(DATETIME, '[fecha] 23:59:00', 102) " _
        & "GROUP BY dbo.pagos_detalle.id_doc, dbo.pagos_detalle.folio, dbo.pagos_detalle.serie HAVING dbo.pagos_detalle.id_doc = 6"
        fe = Format(corte, "yyyy-MM-dd")
        cmd1 = cmd1.Replace("[fecha]", fe)
        Dim ok As Boolean = comando(cmd1)

        'pone a ceros los abonos de las facturas
        cmd1 = "UPDATE [integra].[dbo].[Documentos] set [abonos] = 0"
        ok = comando(cmd1)
        'guarda los abonos a la fecha de las facturas (lo que se calculo en abonos)
        cmd1 = "UPDATE [integra].[dbo].[Documentos] set [abonos] = tmp_abonos.abono " _
        & " FROM  Documentos INNER JOIN tmp_abonos ON Documentos.serie = tmp_abonos.serie AND Documentos.Folio = tmp_abonos.folio AND Documentos.td = tmp_abonos.id_doc "
        ok = comando(cmd1)

        cmd1 = "UPDATE Documentos set abonos = Importe WHERE Importe < abonos"
        ok = comando(cmd1)

        'genera saldos finales
        cmd1 = "INSERT INTO cxc_est_auxiliar (id_directorio, cargos, abonos, final, Inicial, id_agente, fecha) " _
        & " SELECT cxc_saldo_al_corte.id_directorio AS id, 0 AS cargos, 0 AS abonos, SUM(cxc_saldo_al_corte.saldo) as final " _
        & ", 0 AS inicial, Directorio.id_agente AS agente, '[periodo]' AS fecha " _
        & " FROM cxc_saldo_al_corte INNER JOIN Directorio ON cxc_saldo_al_corte.id_directorio = Directorio.id_directorio WHERE Directorio.tipo = 2  and  fechafactura <= CONVERT(DATETIME, '[fecha] 23:59:00', 102)" _
        & " GROUP BY cxc_saldo_al_corte.id_directorio, Directorio.id_agente"
        cmd1 = cmd1.Replace("[periodo]", periodo)
        fe = Format(corte, "yyyy-MM-dd")
        cmd1 = cmd1.Replace("[fecha]", fe)
        ok = comando(cmd1)

        Dim del As Date, f1, f2 As String
        del = DateSerial(corte.Year, corte.Month, 1)
        f1 = Format(del, "yyyy-MM-dd")
        f2 = Format(corte, "yyyy-MM-dd")

        ''calcula los abonos del mes y actulizal a tabla
        'cmd1 = "SELECT Documentos.id_directorio, SUM(pagos_detalle.abono) AS abonos FROM pagos_detalle INNER JOIN Pagos ON pagos_detalle.id_pago = Pagos.id_pago AND pagos_detalle.caja = Pagos.caja INNER JOIN Documentos ON pagos_detalle.serie = Documentos.serie AND pagos_detalle.folio = Documentos.Folio AND pagos_detalle.id_doc = Documentos.td " _
        '& " WHERE Documentos.status = 0 AND Documentos.td = 6  AND Documentos.id_cartera = 2 and Documentos.status= 0 AND Pagos.fecha_apliacion BETWEEN CONVERT(DATETIME, '[del] 00:00:00', 102) AND CONVERT(DATETIME,'[al] 23:59:00', 102) " _
        '& "GROUP BY Documentos.id_directorio "

        'cmd1 = cmd1.Replace("[del]", f1)
        'cmd1 = cmd1.Replace("[al]", f2)
        'Dim tbl As DataTable = leer_tabla(cmd1)
        'Dim id As Integer, abono As Double
        'For j As Integer = 0 To tbl.Rows.Count - 1
        '    With tbl.Rows(j)
        '        id = .Item(0)
        '        abono = .Item(1)
        '    End With
        '    cmd = "update cxc_est_auxiliar set abonos =" + abono.ToString + " where id_directorio = " + id.ToString + " and fecha ='" + periodo + "'"
        '    comando(cmd)
        'Next

        'calcula los cargos del mes
        cmd1 = "SELECT id_directorio, SUM(Importe) AS cargo FROM Documentos WHERE (td = 6) and id_Cartera=2 AND (status = 0) AND (fechafactura BETWEEN CONVERT(DATETIME, '[del] 00:00:00', 102) AND CONVERT(DATETIME, '[al] 23:59:00', 102)) GROUP BY id_directorio"
        f1 = Format(del, "yyyy-MM-dd")
        f2 = Format(corte, "yyyy-MM-dd")
        cmd1 = cmd1.Replace("[del]", f1)
        cmd1 = cmd1.Replace("[al]", f2)
        Dim tbl As DataTable
        tbl = leer_tabla(cmd1)
        Dim id1 As Integer, cargo As Double
        For j As Integer = 0 To tbl.Rows.Count - 1
            With tbl.Rows(j)
                id1 = .Item(0)
                cargo = .Item(1)
            End With
            cmd = "update cxc_est_auxiliar set cargos =" + cargo.ToString + " where id_directorio = " + id1.ToString + " and fecha ='" + periodo + "'"
            comando(cmd)
        Next
        'calcula saldo inicial (final preriodo anterior)
        Dim nmes, naño As Integer : naño = Year(corte)
        nmes = Month(corte) - 1
        If nmes = 0 Then nmes = 12 : naño = naño - 1
        Dim panterior As Date = DateSerial(naño, nmes, 1)
        Dim periodoa As String = Me.mes.Items(nmes - 1) + "/" + naño.ToString
        cmd = "select * from cxc_est_auxiliar where fecha='" + periodoa + "'"
        Dim id As Integer, final As Decimal
        tbl = leer_tabla(cmd)
        For j As Integer = 0 To tbl.Rows.Count - 1
            With tbl.Rows(j)
                id = .Item("id_directorio")
                final = .Item("final")
            End With
            cmd = "update cxc_est_auxiliar set inicial =" + final.ToString + " where id_directorio = " + id.ToString + " and fecha ='" + periodo + "'"
            comando(cmd)
        Next


        cmd1 = "UPDATE  cxc_est_auxiliar set cxc_est_auxiliar.abonos = cxc_est_auxiliar.inicial  + cxc_est_auxiliar.cargos - cxc_est_auxiliar.final"
        ok = comando(cmd1)

        cmd1 = "DELETE FROM [integra].[dbo].[cxc_est_auxiliar] WHERE inicial = 0 And cargos = 0 And abonos = 0 And final = 0"
        ok = comando(cmd1)

    End Sub
   

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click
        ''genera de nuevo el reporte
        Dim periodo As String = Me.mes.Text + "/" + año.Value.ToString
        Dim nmes As Integer = Me.mes.SelectedIndex + 1, naño As Integer = año.Value
        If nmes = 12 Then nmes = 0 : naño = año.Value + 1
        Dim corte As Date = DateSerial(naño, nmes + 1, 1)
        corte = corte.AddDays(-1)
        Me.Text = "Comparativo de ventas vs recuperado " + periodo + " fecha de corte :" + corte.ToShortDateString
       crear_periodo(periodo, corte)
        Me.cxc_est_agentesTableAdapter.FillByperiodo(Me.reporteDataSet.cxc_est_agentes, periodo)
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", periodo, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
       
    End Sub
End Class