Public Class Margenes_por_tienda

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub cargar(ByVal d As Date, ByVal a As Date)

        Me.ReportViewer1.Visible = True
        Me.ReportViewer2.Visible = False

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer2.LocalReport.EnableExternalImages = True

        Dim pdel, pdal As String, dias As Integer
        pdel = Format(d, "yyyy-MM-dd")
        pdal = Format(a, "yyyy-MM-dd")
        dias = DateDiff(DateInterval.Day, d, a)
        Dim cmd As String
        cmd = "SELECT dbo.movimientos.almacen, dbo.tbl_almacenes.Almacen AS Tienda, SUM(ROUND(dbo.movimientos.ub_costo * dbo.movimientos.ub_cantidad, 2)) AS CostoVenta, " _
        & " SUM(ROUND(dbo.movimientos.ub_venta * dbo.movimientos.ub_cantidad, 2)) AS Venta,SUM(ROUND(dbo.movimientos.ub_venta * dbo.movimientos.ub_cantidad - dbo.movimientos.ub_costo * dbo.movimientos.ub_cantidad, 2)) AS Utilidad " _
        & " ,min(dbo.tbl_almacenes.GastoDiario * [dias]) AS gasto " _
        & " FROM dbo.movimientos INNER JOIN dbo.tbl_almacenes ON dbo.movimientos.almacen = dbo.tbl_almacenes.id_almacen " _
        & " WHERE  dbo.movimientos.status = 0 AND (dbo.movimientos.fecha BETWEEN CONVERT(DATETIME, '[del] 00:00:00', 102) AND CONVERT(DATETIME,'[al] 00:00:00', 102)) AND (dbo.movimientos.id_doc = 5  OR " _
        & " dbo.movimientos.id_doc = 6)GROUP BY dbo.movimientos.almacen, dbo.tbl_almacenes.Almacen"
        cmd = cmd.Replace("[del]", pdel)
        cmd = cmd.Replace("[al]", pdal)
        cmd = cmd.Replace("[dias]", dias.ToString)
        Dim reporte As String = "Periodo de ventas del " + d.ToShortDateString + " al " + a.ToShortDateString

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)


        Dim tbl As DataTable = leer_tabla(cmd)
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        cargar(del.Value, al.Value)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub Margenes_por_tienda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub cargar_por_vendedor(ByVal d As Date, ByVal a As Date)
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer2.LocalReport.EnableExternalImages = True
        Dim pdel, pdal As String, dias As Integer
        pdel = Format(d, "yyyy-MM-dd")
        pdal = Format(a, "yyyy-MM-dd")
        dias = DateDiff(DateInterval.Day, d, a)
        Dim cmd As String
        'cmd = "SELECT dbo.movimientos.almacen, dbo.tbl_almacenes.Almacen AS Tienda, SUM(ROUND(dbo.movimientos.ub_costo * dbo.movimientos.ub_cantidad, 2)) AS CostoVenta, " _
        '& " SUM(ROUND(dbo.movimientos.ub_venta * dbo.movimientos.ub_cantidad, 2)) AS Venta,SUM(ROUND(dbo.movimientos.ub_venta * dbo.movimientos.ub_cantidad - dbo.movimientos.ub_costo * dbo.movimientos.ub_cantidad, 2)) AS Utilidad " _
        '& " ,min(dbo.tbl_almacenes.GastoDiario * [dias]) AS gasto " _
        '& " FROM dbo.movimientos INNER JOIN dbo.tbl_almacenes ON dbo.movimientos.almacen = dbo.tbl_almacenes.id_almacen " _
        '& " WHERE  dbo.movimientos.status = 0 AND (dbo.movimientos.fecha BETWEEN CONVERT(DATETIME, '[del] 00:00:00', 102) AND CONVERT(DATETIME,'[al] 00:00:00', 102)) AND (dbo.movimientos.id_doc = 5  OR " _
        '& " dbo.movimientos.id_doc = 6)GROUP BY dbo.movimientos.almacen, dbo.tbl_almacenes.Almacen"

        cmd = "SELECT Agentes.id_agente as almacen, Agentes.Nombre as tienda, SUM(ROUND(movimientos.ub_costo * movimientos.ub_cantidad, 2)) AS CostoVenta, SUM(ROUND(movimientos.ub_venta * movimientos.ub_cantidad, 2)) AS Venta, " _
        & " SUM(ROUND(movimientos.ub_venta * movimientos.ub_cantidad - movimientos.ub_costo * movimientos.ub_cantidad, 2)) AS Utilidad FROM movimientos INNER JOIN Documentos ON movimientos.id_doc = Documentos.td AND movimientos.folio_doc = Documentos.Folio AND movimientos.serie = Documentos.serie INNER JOIN " _
        & " Directorio ON Documentos.id_directorio = Directorio.id_directorio AND Documentos.tipo_directorio = Directorio.tipo INNER JOIN Agentes ON Directorio.id_agente = Agentes.id_agente " _
        & " WHERE Agentes.id_agente>0 and movimientos.status = 0 AND movimientos.fecha BETWEEN CONVERT(DATETIME, '[del] 00:00:00', 102) AND CONVERT(DATETIME, '[al] 00:00:00', 102) AND movimientos.id_doc = 6 GROUP BY Agentes.Nombre, Agentes.id_agente"
        cmd = cmd.Replace("[del]", pdel)
        cmd = cmd.Replace("[al]", pdal)
        'cmd = cmd.Replace("[dias]", dias.ToString)
        Dim reporte As String = "Periodo de ventas del " + d.ToShortDateString + " al " + a.ToShortDateString

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        Me.ReportViewer2.LocalReport.SetParameters(rp)


        Dim tbl As DataTable = leer_tabla(cmd)
        Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer2.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        cargar_por_vendedor(del.Value, al.Value)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub
End Class