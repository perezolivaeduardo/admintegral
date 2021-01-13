Public Class lista_de_entradas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        prepara_reporte()
        prepara_consulta()
    End Sub
    Private Sub prepara_reporte()
        Dim cmd As String
        cmd = "delete  from tmp_lista_entradas "
        comando(cmd)

        cmd = "insert into tmp_lista_entradas (id,cajas) SELECT  dbo.productos.id_Producto, " _
        & " SUM(dbo.movimientos.cantidad) AS llego FROM  dbo.Documentos INNER JOIN " _
& " dbo.movimientos ON dbo.Documentos.td = dbo.movimientos.id_doc AND dbo.Documentos.Folio = dbo.movimientos.folio_doc AND " _
& "  dbo.Documentos.serie = dbo.movimientos.serie INNER JOIN " _
& "  dbo.productos ON dbo.movimientos.id_prodcuto = dbo.productos.id_Producto INNER JOIN " _
& " dbo.Unidades_productos ON dbo.movimientos.id_prodcuto = dbo.Unidades_productos.id_producto AND " _
& " dbo.movimientos.ud = dbo.Unidades_productos.id_unidad " _
& " WHERE (dbo.Documentos.td = 1) "
        Dim s As String
        Dim split As String() = Me.excluirtxt.Text.Split(New [Char]() {","})
        For Each s In split
            cmd += " and dbo.productos.id_directorio <> " + s.ToString
        Next
        cmd += "  AND (dbo.Documentos.fechafactura " _
        & " BETWEEN CONVERT(DATETIME, '[fechadel] 00:00:00', 102) AND CONVERT(DATETIME, '[fechaal] 23:59:00', 102)) " _
        & " GROUP BY dbo.productos.id_Producto"
        cmd = cmd.Replace("[fechadel]", Format(fechadel.Value, "yyyy-MM-dd"))
        cmd = cmd.Replace("[fechaal]", Format(fechaal.Value, "yyyy-MM-dd"))
        comando(cmd)

    End Sub

    Private Sub prepara_consulta()
        Dim cmd As String
        cmd = "SELECT  dbo.productos.id_Producto, Unidades_productos_1.Codigo, dbo.productos.id_Grupo, dbo.productos.Descripcion, " _
        & " dbo.tmp_lista_entradas.cajas AS [llego cajas], " _
        & " CASE WHEN precio_unico = 0 THEN ROUND((dbo.Unidades_productos.venta * [Factor] + dbo.Unidades_productos.venta * [Factor] * dbo.productos.iva / 100), 2) " _
        & " ELSE ROUND((dbo.Unidades_productos.venta + dbo.Unidades_productos.venta * dbo.productos.iva / 100), 2) END AS PZ, " _
        & " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_1.venta * [Factor] + Unidades_productos_1.venta * [Factor] * dbo.productos.iva / 100), 2) " _
        & " ELSE ROUND((Unidades_productos_1.venta + Unidades_productos_1.venta * dbo.productos.iva / 100), 2) END AS EXH, " _
        & " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_2.venta * [Factor] + Unidades_productos_2.venta * [Factor] * dbo.productos.iva / 100), 2) " _
        & " ELSE ROUND((Unidades_productos_2.venta + Unidades_productos_2.venta * dbo.productos.iva / 100), 2) END AS CJ " _
        & " FROM dbo.productos INNER JOIN " _
        & "dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND " _
        & "dbo.productos.und_detalle = dbo.Unidades_productos.id_unidad INNER JOIN " _
        & "dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
        & "dbo.productos.und_venta = Unidades_productos_1.id_unidad INNER JOIN " _
        & "dbo.Unidades_productos AS Unidades_productos_2 ON dbo.productos.id_Producto = Unidades_productos_2.id_producto AND " _
        & "dbo.productos.und_compra = Unidades_productos_2.id_unidad INNER JOIN " _
        & "dbo.tmp_lista_entradas ON dbo.productos.id_Producto = dbo.tmp_lista_entradas.id " _
        & "GROUP BY dbo.productos.id_Producto, dbo.productos.Descripcion, " _
        & "CASE WHEN precio_unico = 0 THEN ROUND((dbo.Unidades_productos.venta * [Factor] + dbo.Unidades_productos.venta * [Factor] * dbo.productos.iva / 100), 2) " _
        & "ELSE ROUND((dbo.Unidades_productos.venta + dbo.Unidades_productos.venta * dbo.productos.iva / 100), 2) END, " _
        & "CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_1.venta * [Factor] + Unidades_productos_1.venta * [Factor] * dbo.productos.iva / 100), 2) " _
        & "ELSE ROUND((Unidades_productos_1.venta + Unidades_productos_1.venta * dbo.productos.iva / 100), 2) END, " _
        & "CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_2.venta * [Factor] + Unidades_productos_2.venta * [Factor] * dbo.productos.iva / 100), 2) " _
        & "ELSE ROUND((Unidades_productos_2.venta + Unidades_productos_2.venta * dbo.productos.iva / 100), 2) END, dbo.productos.id_Grupo, " _
        & " Unidades_productos_1.Codigo, dbo.productos.status, dbo.tmp_lista_entradas.cajas " _
        & " HAVING(dbo.productos.status = 0) ORDER BY dbo.productos.id_Grupo, dbo.productos.Descripcion "

        Dim micmd As String = cmd.Replace("[Factor]", Me.factortxt.Text)
        Dim reporte As String = "Del " + fechadel.Value.ToShortDateString + " al " + fechaal.Value.ToShortDateString

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = rptlogo

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Dim tbl As DataTable = leer_tabla(micmd)
        Try
            ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Catch ex As Exception

        End Try

        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub lista_de_entradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Listas' Puede moverla o quitarla según sea necesario.
        Me.ListasTableAdapter.Fill(Me.AdmintegralDataSet.Listas)
    End Sub

    Private Sub CargoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoTextBox.TextChanged
        factortxt.Text = CargoTextBox.Text / 100 + 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class