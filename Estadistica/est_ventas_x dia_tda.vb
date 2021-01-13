Public Class est_ventas_x_dia_tda
    Private Sub est_ventas_x_dia_tda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.EST_vtas_x_da_x_dia' Puede moverla o quitarla según sea necesario.
        Me.EST_vtas_x_da_x_diaTableAdapter.Fill(Me.admintegralDataSet.EST_vtas_x_da_x_dia)
        Me.ReportViewer2.RefreshReport()
    End Sub


    Private Sub TSBvendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBvendedor.Click
        Dim cmd, semana, ano As String
        Dim tbl As New DataTable
        semana = DatePart(DateInterval.WeekOfYear, Me.dateweek.Value)
        ano = DatePart(DateInterval.Year, Me.dateweek.Value)
        cmd = "SELECT DATENAME(weekday, dbo.Documentos.fechasurtido) AS dia, DAY(dbo.Documentos.fechasurtido) AS d, SUM(dbo.Documentos.Importe) AS venta, dbo.Agentes.Nombre,  dbo.Documentos.fechasurtido "
        cmd += "FROM dbo.Documentos INNER JOIN dbo.Directorio ON dbo.Documentos.id_directorio = dbo.Directorio.id_directorio AND dbo.Documentos.tipo_directorio = dbo.Directorio.tipo INNER JOIN "
        cmd += " dbo.Agentes ON dbo.Directorio.id_agente = dbo.Agentes.id_agente "
        cmd += "WHERE (dbo.Documentos.td = 6) AND (dbo.Documentos.status = 0) AND (dbo.Documentos.id_cartera = 2) AND "
        cmd += " (DATENAME(WEEK, dbo.Documentos.fechasurtido) = '" + semana + "') "
        cmd += " and (DATENAME(year, dbo.Documentos.fechasurtido) = '" + ano + "')"
        cmd += " GROUP BY DATENAME(weekday, dbo.Documentos.fechasurtido), dbo.Documentos.fechasurtido, DAY(dbo.Documentos.fechasurtido), dbo.Agentes.Nombre, dbo.Documentos.fechasurtido"
        cmd += " ORDER BY dbo.Documentos.fechasurtido"
        tbl = leer_tabla(cmd)
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)

        Dim ini, fin As Date
        ini = tbl.Rows(0).Item("fechasurtido")
        fin = tbl.Rows(tbl.Rows.Count - 1).Item("fechasurtido")
        Dim reporte, periodo As String
        reporte = "Ventas de la Semana " + semana
        periodo = " del " + ini.ToShortDateString + " al " + fin.ToShortDateString
        Me.ReportViewer2.Visible = False
        Me.ReportViewer1.Visible = True

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", periodo, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub TSB_tienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_tienda.Click
        Dim cmd, semana, ano As String
        Dim tbl As New DataTable
        semana = DatePart(DateInterval.WeekOfYear, Me.dateweek.Value)
        ano = DatePart(DateInterval.Year, Me.dateweek.Value)
        cmd = "SELECT DATENAME(weekday, dbo.Documentos.fechasurtido) AS dia, DAY(dbo.Documentos.fechasurtido) AS d, dbo.cajas.Nombre, "
        cmd += "SUM(dbo.Documentos.Importe) AS venta, dbo.Documentos.fechasurtido,dbo.Documentos.almacen FROM dbo.Documentos INNER JOIN dbo.cajas ON dbo.Documentos.ncaja = dbo.cajas.id_caja "
        cmd += " WHERE dbo.Documentos.td = 6 AND dbo.Documentos.status = 0 AND dbo.cajas.local = 0 AND (DATENAME(WEEK, dbo.Documentos.fechasurtido) = '" + semana + "') "
        cmd += " and (DATENAME(year, dbo.Documentos.fechasurtido) = '" + ano + "') "
        cmd += " GROUP BY dbo.cajas.Nombre, DATENAME(weekday, dbo.Documentos.fechasurtido), dbo.Documentos.fechasurtido, DAY(dbo.Documentos.fechasurtido),dbo.Documentos.fechasurtido,dbo.Documentos.almacen"
        cmd += " ORDER BY dbo.Documentos.almacen, dbo.Documentos.fechasurtido"
        tbl = leer_tabla(cmd)
        If tbl.Rows.Count = 0 Then MsgBox("Sin Registros!!") : Exit Sub
        Try
            Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Catch ex As Exception

        End Try
        Me.ReportViewer2.Visible = False
        Me.ReportViewer1.Visible = True

        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        Dim ini, fin As Date
        ini = tbl.Rows(0).Item("fechasurtido")
        fin = tbl.Rows(tbl.Rows.Count - 1).Item("fechasurtido")
        Dim reporte, periodo As String
        reporte = "Ventas de la Semana " + semana
        periodo = " del " + ini.ToShortDateString + " al " + fin.ToShortDateString
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", periodo, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim cmd, semana, ano As String
        Dim tbl As New DataTable
        semana = DatePart(DateInterval.WeekOfYear, Me.dateweek.Value)
        ano = DatePart(DateInterval.Year, Me.dateweek.Value)
        'cmd = "SELECT DATENAME(weekday, dbo.Documentos.fechasurtido) AS dia, DAY(dbo.Documentos.fechasurtido) AS d, SUM(dbo.Documentos.Importe) AS venta, dbo.Agentes.Nombre,  dbo.Documentos.fechasurtido "
        'cmd += "FROM dbo.Documentos INNER JOIN dbo.Directorio ON dbo.Documentos.id_directorio = dbo.Directorio.id_directorio AND dbo.Documentos.tipo_directorio = dbo.Directorio.tipo INNER JOIN "
        'cmd += " dbo.Agentes ON dbo.Directorio.id_agente = dbo.Agentes.id_agente "
        cmd = "SELECT     TOP 100 PERCENT DATENAME(weekday, dbo.Documentos.fechasurtido) AS dia, DAY(dbo.Documentos.fechasurtido) AS d, STR(dbo.Listas.id) + ' ' + dbo.Listas.Descripcion as Nombre, " _
        & " SUM(dbo.Documentos.Importe) AS venta,  dbo.Documentos.fechasurtido  FROM dbo.Documentos INNER JOIN dbo.Directorio ON dbo.Documentos.id_directorio = dbo.Directorio.id_directorio AND dbo.Documentos.tipo_directorio = dbo.Directorio.tipo INNER JOIN " _
        & " dbo.Listas ON dbo.Directorio.Ruta = dbo.Listas.id "
        cmd += "WHERE (dbo.Documentos.td = 6) AND (dbo.Documentos.status = 0) AND (dbo.Documentos.id_cartera = 2) AND "
        cmd += " (DATENAME(WEEK, dbo.Documentos.fechasurtido) = '" + semana + "') "
        cmd += " and (DATENAME(year, dbo.Documentos.fechasurtido) = '" + ano + "')"
        cmd += " GROUP BY DATENAME(weekday, dbo.Documentos.fechasurtido), dbo.Documentos.fechasurtido, DAY(dbo.Documentos.fechasurtido), STR(dbo.Listas.id) + ' ' + dbo.Listas.Descripcion, dbo.Documentos.fechasurtido"
        cmd += " ORDER BY dbo.Documentos.fechasurtido"
        tbl = leer_tabla(cmd)
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)

        Dim ini, fin As Date
        ini = tbl.Rows(0).Item("fechasurtido")
        fin = tbl.Rows(tbl.Rows.Count - 1).Item("fechasurtido")
        Dim reporte, periodo As String
        reporte = "Ventas de la Semana " + semana
        periodo = " del " + ini.ToShortDateString + " al " + fin.ToShortDateString

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", periodo, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("grafico", True, False)
        Me.ReportViewer2.Visible = False
        Me.ReportViewer1.Visible = True

        Me.ReportViewer1.LocalReport.SetParameters(rp)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim cmd, f1, f2 As String
        f1 = Format(del.Value, "yyyy-MM-dd")
        f2 = Format(al.Value, "yyyy-MM-dd")
        Dim tbl As New DataTable

        cmd = "SELECT dbo.Documentos.fechasurtido AS fecha,  STR(tbl_almacenes.id_almacen)  + tbl_almacenes.Almacen AS Almacen , "
        cmd += "SUM(dbo.Documentos.Importe) AS venta "
        cmd += "FROM Documentos INNER JOIN tbl_almacenes ON Documentos.almacen = tbl_almacenes.id_almacen "
        cmd += " WHERE dbo.Documentos.td = 6 AND dbo.Documentos.status = 0 AND dbo.Documentos.id_cartera <> 2 AND "
        cmd += " fechasurtido BETWEEN CONVERT(DATETIME, '[del] 00:01:01', 102) AND CONVERT(DATETIME, '[al] 00:00:00', 102) "
        cmd += " GROUP BY  dbo.Documentos.fechasurtido,   STR(tbl_almacenes.id_almacen)  + tbl_almacenes.Almacen"
        cmd += " ORDER BY  dbo.Documentos.fechasurtido,  STR(tbl_almacenes.id_almacen)  + tbl_almacenes.Almacen"
        cmd = cmd.Replace("[del]", f1)
        cmd = cmd.Replace("[al]", f2)

        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True

        tbl = leer_tabla(cmd)
        dgv.DataSource = tbl
        If tbl.Rows.Count = 0 Then MsgBox("Sin Registros!!") : Exit Sub
        Try
            Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)
        Catch ex As Exception
        End Try

        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)

        Dim reporte, periodo As String
        reporte = "Reporte de Ventas por Periodo "
        periodo = " del " + f1 + " al " + f2
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", periodo, False)
        Me.ReportViewer2.LocalReport.SetParameters(rp)
        ReportViewer2.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        dgv.Visible = Not dgv.Visible

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub boton_periodo_vendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_periodo_vendedor.Click
        Dim cmd, semana, ano As String
        Dim f1, f2 As String
        f1 = Format(del.Value, "yyyy-MM-dd")
        f2 = Format(al.Value, "yyyy-MM-dd")

        Dim tbl As New DataTable
        semana = DatePart(DateInterval.WeekOfYear, Me.dateweek.Value)
        ano = DatePart(DateInterval.Year, Me.dateweek.Value)
        cmd = "SELECT  dbo.Documentos.fechasurtido AS dia,dbo.Documentos.fechasurtido AS d, SUM(dbo.Documentos.Importe) AS venta, dbo.Agentes.Nombre,  dbo.Documentos.fechasurtido "
        cmd += "FROM dbo.Documentos INNER JOIN dbo.Directorio ON dbo.Documentos.id_directorio = dbo.Directorio.id_directorio AND dbo.Documentos.tipo_directorio = dbo.Directorio.tipo INNER JOIN "
        cmd += " dbo.Agentes ON dbo.Directorio.id_agente = dbo.Agentes.id_agente "
        cmd += "WHERE (dbo.Documentos.td = 6) AND (dbo.Documentos.status = 0) AND (dbo.Documentos.id_cartera = 2) AND "
        cmd += " fechasurtido BETWEEN CONVERT(DATETIME, '[del] 00:01:01', 102) AND CONVERT(DATETIME, '[al] 00:00:00', 102) "
        cmd += " GROUP BY  dbo.Documentos.fechasurtido, dbo.Documentos.fechasurtido, dbo.Documentos.fechasurtido, dbo.Agentes.Nombre, dbo.Documentos.fechasurtido"
        cmd += " ORDER BY dbo.Documentos.fechasurtido"
        cmd = cmd.Replace("[del]", f1)
        cmd = cmd.Replace("[al]", f2)

        tbl = leer_tabla(cmd)

        
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)

        Dim ini, fin As Date
        ini = tbl.Rows(0).Item("fechasurtido")
        fin = tbl.Rows(tbl.Rows.Count - 1).Item("fechasurtido")
        Dim reporte, periodo As String
        reporte = "Ventas de la Semana " + semana
        periodo = " del " + ini.ToShortDateString + " al " + fin.ToShortDateString
        Me.ReportViewer2.Visible = False
        Me.ReportViewer1.Visible = True

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", periodo, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("grafico", True, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class