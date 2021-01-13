Public Class resumen_existencias

    Private Sub resumen_existencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Dim cmd As String
        cmd = "SELECT dbo.tbl_almacenes.Almacen, dbo.Grupos.Grupo, SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n * dbo.movimientos.ub_costo) AS costo FROM dbo.movimientos INNER JOIN " _
        & " dbo.productos ON dbo.movimientos.id_prodcuto = dbo.productos.id_Producto INNER JOIN dbo.Grupos ON dbo.productos.id_Grupo = dbo.Grupos.id_grupos INNER JOIN " _
        & " dbo.tbl_almacenes ON dbo.movimientos.almacen = dbo.tbl_almacenes.id_almacen WHERE " _
        & "dbo.movimientos.fecha <= CONVERT(DATETIME, '[FECHA] 23:59:00', 102) GROUP BY dbo.Grupos.Grupo, dbo.tbl_almacenes.Almacen"
        cmd = cmd.Replace("[FECHA]", Format(Me.fecha.Value, "yyyy-MM-dd"))
        Dim tbl As New DataTable
        tbl = leer_tabla(cmd)

        
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class