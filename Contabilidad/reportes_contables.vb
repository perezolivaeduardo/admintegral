Public Class reportes_contables
    Dim ds As New DataSet("clientes")
    Dim tablefactura As DataTable
    Dim tablepagos As DataTable

    Private AppExcel As New Object
    Private LibroExcel As New Object
    Private HojaExcel As New Object

   
    Private Sub reporte_hacienda(ByVal ini As Date, ByVal fin As Date)
        Dim da As New SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim cs As String = My.Settings.AdmintegralConnectionString
        Dim cmd As String
        Dim reporte As String
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        tbl.Clear()
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        If ini = fin Then ' un dia
            cmd = "SELECT  serie, SUM(sub0) AS sub0, SUM(sub10) AS sub10, SUM(iva10) AS iva10, SUM(Importe) AS importe " _
            & " FROM sql_documentos_clientes WHERE td = 6 AND status = 0 " _
            & " and fechasurtido = CONVERT(DATETIME, '" + Format(ini, "yyyy-M-dd") + "', 102) " _
            & "GROUP BY  serie order by serie"

            da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
            Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(da)
            reporte = Format(fechainicial.Value.Date, "D")
            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", reporte, False)
        End If

        If ini <> fin Then ' un dia
            cmd = "SELECT  fechasurtido, SUM(sub0) AS sub0, SUM(sub10) AS sub10, SUM(iva10) AS iva10, SUM(Importe) AS importe " _
            & " FROM sql_documentos_clientes WHERE td = 6 AND status = 0 " _
            & " and fechasurtido >= CONVERT(DATETIME, '" + Format(ini, "yyyy-M-dd") + "', 102) " _
            & " and fechasurtido <= CONVERT(DATETIME, '" + Format(fin, "yyyy-M-dd") + "', 102) " _
            & "GROUP BY  fechasurtido order by fechasurtido "

            da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
            Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(da)
            reporte = "Del " + Format(ini, "%d") + " al " + Format(fin, "%d") + " de " + Format(fin, "MMMM") + " de " + Format(fin, "yyyy")
            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", reporte, False)
        End If


        da.Fill(tbl)
        If ini <> fin Then
            Try
                Me.reporte_hacienda_resumen.LocalReport.DataSources.RemoveAt(0)
                Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("resumen", tbl)

                Me.reporte_hacienda_resumen.LocalReport.DataSources.Add(datasource)
                Me.reporte_hacienda_resumen.LocalReport.SetParameters(rp)

                Me.reporte_hacienda_resumen.RefreshReport()
            Catch ex As Exception

            End Try
        Else
            Try
                Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
                Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("resumen", tbl)
                Me.ReportViewer1.LocalReport.EnableExternalImages = True
                Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
                ReportViewer1.LocalReport.EnableExternalImages = True
                rp(1) = rptlogo
                Me.ReportViewer1.LocalReport.SetParameters(rp)

                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception

            End Try

        End If


    End Sub

 
    Private Sub boton_rhacienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_rhacienda.Click
        Me.reporte_hacienda_resumen.Visible = False
        Me.ReportDiario.Visible = False
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.Visible = True
        reporte_hacienda(Me.fechainicial.Value, Me.fechainicial.Value)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ReportDiario.Visible = False
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.Visible = False
        Me.reporte_hacienda_resumen.Visible = True
        Me.reporte_hacienda_resumen.Visible = True
        reporte_hacienda(Me.fechainicial.Value, Me.fechafinal.Value)
    End Sub

   
    Private Sub reportes_contables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cxc_saldo_al_corte_resumenTableAdapter.Fill(Me.reporteDataSet.cxc_saldo_al_corte_resumen)
        
        'Me.sql_documentos_clientesTableAdapter.Fill(Me.admintegralDataSet.sql_documentos_clientes)

        Me.AgentesTableAdapter.Fill(Me.admintegralDataSet.Agentes)
        id.Text = NombreComboBox.SelectedValue
        cargar_bloc()
        Me.Report_ietu.LocalReport.EnableExternalImages = True
        Me.reporte_costos.LocalReport.EnableExternalImages = True
        Me.report_saldos.LocalReport.EnableExternalImages = True
        Me.Report_ietu.RefreshReport()
        Me.reporte_costos.RefreshReport()
        Me.report_saldos.RefreshReport()
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        id.Text = NombreComboBox.SelectedValue
    End Sub

    Private Sub cargar_bloc()
        Dim cmd As String, tabla As DataTable
        cmd = "SELECT  tbl_boletas.id_agente as ID, Agentes.Nombre, tbl_boletas.inicial, tbl_boletas.final, tbl_boletas.validada " _
        & " FROM tbl_boletas INNER JOIN Agentes ON tbl_boletas.id_agente = Agentes.id_agente Order by tbl_boletas.final DESC"
        tabla = leer_tabla(cmd)
        dgv.DataSource = tabla
        folio_ini.Text = tabla.Rows(0).Item("final") + 1
        validar_folio()
    End Sub

    Private Sub id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim ix As Integer = Me.AgentesBindingSource.Find("id_agente", id.Text)
            If ix > -1 Then
                Me.AgentesBindingSource.Position = ix
            Else
                id.Text = NombreComboBox.SelectedValue
            End If
            id.SelectAll()
        End If
    End Sub

 
    Private Sub folio_ini_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        validar_folio()
    End Sub
    Private Sub validar_folio()
        boton_asignar.Enabled = False
        Try
            Dim x As Integer = Val(folio_ini.Text) + 49
            Dim x1 As Integer = Val(folio_ini.Text)
            folio_fin.Text = x
            If x1 Mod 50 = 1 Then
                boton_asignar.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub boton_asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_asignar.Click
        Dim ix As MsgBoxResult
        ix = MsgBox("Asignar bloc a " + Me.NombreComboBox.Text, MsgBoxStyle.YesNo, "Asignar Bloc")
        If ix = MsgBoxResult.Yes Then asignar(id.Text, folio_ini.Text)
    End Sub
    Private Sub asignar(ByVal id As Integer, ByVal folio As Long)
        Dim ok As Boolean
        ok = asignar_bloc(id, folio)
        cargar_bloc()
    End Sub

    Private Sub folio_ini_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles folio_ini.KeyPress
        If e.KeyChar = chr13 Then
            validar_folio()
        End If
    End Sub

    Private Sub folio_ini_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs)
        validar_folio()
    End Sub

    Private Sub boto_comisiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boto_comisiones.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.cxc_detalle_comisionesTableAdapter.FillByperiodo(Me.admintegralDataSet.cxc_detalle_comisiones, fecha_del.Value.Date, Fecha_al.Value.Date)
        Dim titulo As String
        If fecha_del.Value.Month = Fecha_al.Value.Month Then
            titulo = "Periodo del " + fecha_del.Value.Day.ToString + " al " + Fecha_al.Value.Day.ToString + " de " + Format(Fecha_al.Value, "MMMM") + " de " + Fecha_al.Value.Year.ToString
        Else
            titulo = "Periodo del " + fecha_del.Value.Day.ToString + " de " + Format(fecha_del.Value, "MMMM") + " al " + Fecha_al.Value.Day.ToString + " de " + Format(Fecha_al.Value, "MMMM") + " de " + Fecha_al.Value.Year.ToString
        End If
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer2.LocalReport.EnableExternalImages = True
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("titulo", titulo, False)
        Me.ReportViewer2.LocalReport.SetParameters(rp)

        'Me.ReportViewer1.LocalReport.SetParameters(rp1)
        Me.ReportViewer2.RefreshReport()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.reporte_hacienda_resumen.Visible = False
        Me.ReportDiario.Visible = True
        Me.ReportViewer1.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_documentos_clientes' Puede moverla o quitarla según sea necesario.
        Me.sql_documentos_clientesTableAdapter.FillByTD_fecha(Me.admintegralDataSet.sql_documentos_clientes, 6, Me.fechainicial.Value.Date, Me.fechainicial.Value.Date)
        For j As Integer = 0 To Me.admintegralDataSet.sql_documentos_clientes.Rows.Count - 1
            With Me.admintegralDataSet.sql_documentos_clientes
                If .Rows(j).Item("status") <> 0 Then
                    .Rows(j).Item("Nombre") = "**** CANCELADA ***"
                    .Rows(j).Item("sub0") = 0
                    .Rows(j).Item("sub10") = 0
                    .Rows(j).Item("iva10") = 0
                    .Rows(j).Item("importe") = 0
                End If
            End With
        Next
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("titulo", "fecha :" + Format(Me.fechainicial.Value.Date, "d"), False)
        Me.ReportDiario.LocalReport.SetParameters(rp)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportDiario.Visible = True
        Me.ReportDiario.Refresh()
        Me.ReportDiario.RefreshReport()

    End Sub


    Private Sub boton_ietu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ietu.Click
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.CG_IETU' Puede moverla o quitarla según sea necesario.
        Me.CG_IETUTableAdapter.FillByperiodo(Me.admintegralDataSet.CG_IETU, ietu_del.Value.Date, ietu_al.Value.Date)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("titulo", "IETU DEL MES DE " + Format(Me.ietu_del.Value.Date, "MMMM"), False)
        Me.Report_ietu.LocalReport.SetParameters(rp)
        Me.Report_ietu.Refresh()
        Me.Report_ietu.RefreshReport()

    End Sub

    Private Sub boton_costo_ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_costo_ventas.Click
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.excel_costos' Puede moverla o quitarla según sea necesario.
        Me.excel_costosTableAdapter.FillBycosto_ventas(Me.admintegralDataSet.excel_costos, del.Value.Date, al.Value.Date)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "COSTO DE VENTAS", False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", "Del " + del.Value.Day.ToString + "al " + al.Value.Day.ToString + " de " + Format(al.Value, "MMMM yyyy"), False)
        Me.reporte_costos.LocalReport.SetParameters(rp)
        Me.reporte_costos.RefreshReport()
    End Sub

    Private Sub boton_costo_devoluc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_costo_devoluc.Click
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.excel_costos' Puede moverla o quitarla según sea necesario.
        Me.excel_costosTableAdapter.FillByosto_devoluc(Me.admintegralDataSet.excel_costos, del.Value, al.Value)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "COSTO DE Devoluciones", False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", "Del " + del.Value.Day.ToString + "al " + al.Value.Day.ToString + " de " + Format(al.Value, "MMMM yyyy"), False)
        Me.reporte_costos.LocalReport.SetParameters(rp)
        Me.reporte_costos.RefreshReport()
    End Sub

    Private Sub del_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del.ValueChanged
        al.Value = del.Value.AddDays(Date.DaysInMonth(del.Value.Year, del.Value.Month) - 1)
    End Sub

    Private Sub boton_ok_saldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok_saldos.Click
        boton_ok_saldos.Enabled = False
        Dim cmd1 As String, fe As String
        barra.Visible = True
        barra.Maximum = 5 : barra.Value = 1
        cmd1 = " delete  from tmp_abonos"
        Dim ok1 As Boolean = comando(cmd1)

        cmd1 = "INSERT INTO [tmp_abonos] ([id_doc],[folio],[serie],[abono])" _
        & " SELECT     dbo.pagos_detalle.id_doc, dbo.pagos_detalle.folio, dbo.pagos_detalle.serie, SUM(dbo.pagos_detalle.abono) AS abono " _
        & "FROM dbo.Pagos INNER JOIN dbo.pagos_detalle ON dbo.Pagos.id_pago = dbo.pagos_detalle.id_pago AND dbo.Pagos.caja = dbo.pagos_detalle.caja " _
        & "WHERE dbo.Pagos.fecha < CONVERT(DATETIME, '[fecha] 23:59:00', 102) " _
        & "GROUP BY dbo.pagos_detalle.id_doc, dbo.pagos_detalle.folio, dbo.pagos_detalle.serie HAVING(dbo.pagos_detalle.id_doc = 6)"
        fe = Format(fecha_corte.Value, "yyyy-MM-dd")
        cmd1 = cmd1.Replace("[fecha]", fe)
        Dim ok As Boolean = comando(cmd1)
        : barra.Value = 2


        cmd1 = "UPDATE [Documentos] set [abonos] = 0 where td=6 "
        ok = comando(cmd1)
        barra.Value = 3

        cmd1 = "UPDATE [Documentos] set [abonos] = tmp_abonos.abono " _
        & " FROM  Documentos INNER JOIN tmp_abonos ON Documentos.serie = tmp_abonos.serie AND Documentos.Folio = tmp_abonos.folio AND Documentos.td = tmp_abonos.id_doc "
        ok = comando(cmd1)
        barra.Value = 4

        cmd1 = "SELECT id_directorio, Nombre, SUM(Importe) AS Cargos, SUM(abonos) AS Abonos, SUM(saldo) AS Importe " _
        & " FROM dbo.cxc_saldo_al_corte WHERE fechafactura < CONVERT(DATETIME, '[fecha] 23:59:00', 102) " _
        & " GROUP BY id_directorio, Nombre ORDER BY id_directorio"
        cmd1 = cmd1.Replace("[fecha]", fe)
        Dim tbl As DataTable = leer_tabla(cmd1)

        Me.report_saldos.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        report_saldos.LocalReport.DataSources.Add(datasource)
        barra.Value = 5
        Dim reporte As String = "Saldos Globales al " + fecha_corte.Value.ToShortDateString
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        Me.report_saldos.LocalReport.SetParameters(rp)

        report_saldos.RefreshReport()
        report_saldos.Visible = True
        Me.Button3.Visible = True
    End Sub

    Private Sub fecha_corte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha_corte.ValueChanged, fecha_corte.Enter
        Me.boton_ok_saldos.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '===============================================================================================
        '   Genera la consulta para excel
        '===============================================================================================
        Dim cmd1, fe As String
        Dim cmd As String = "DROP view  [dbo].[cxc_integracion_de_saldos]"
        comando1(cmd)
        fe = Format(fecha_corte.Value, "yyyy-MM-dd")
        cmd1 = "CREATE VIEW [dbo].[cxc_integracion_de_saldos] AS " _
        & "SELECT dbo.Directorio.id_directorio, dbo.Directorio.Nombre, dbo.Documentos.td, dbo.Documentos.Folio, dbo.Documentos.serie, dbo.Documentos.fechafactura," _
        & "dbo.Documentos.sub0, dbo.Documentos.sub10, dbo.Documentos.iva10, dbo.Documentos.Importe, dbo.Documentos.abonos, " _
        & "dbo.Documentos.Importe - dbo.Documentos.abonos AS saldo, dbo.Documentos.status FROM dbo.Directorio INNER JOIN " _
        & "dbo.Documentos ON dbo.Directorio.id_directorio = dbo.Documentos.id_directorio INNER JOIN " _
        & "dbo.Agentes ON dbo.Directorio.id_agente = dbo.Agentes.id_agente " _
        & " WHERE (dbo.Documentos.td = 6) AND (dbo.Documentos.id_cartera = 2) AND (dbo.Documentos.status = 0) AND (dbo.Directorio.tipo = 2) AND " _
        & "(dbo.Documentos.fechafactura < CONVERT(DATETIME, '[fecha] 23:50:00', 102)) AND (dbo.Documentos.Importe - dbo.Documentos.abonos > 0) "
        cmd1 = cmd1.Replace("[fecha]", fe)
        comando(cmd1)


        Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
        Dim path As String = Trim(adap.path(11))
        Dim FileExcel As String = path + "Integracion de Saldos.xlsx"

        System.Diagnostics.Process.Start(FileExcel)

        '==============================================================================================
    End Sub


    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class