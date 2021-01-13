Public Class ver_folios

    Private Sub ver_folios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As String
        cmd = "SELECT dbo.Documentos.almacen, dbo.tbl_Tipodoc.td, dbo.tbl_Tipodoc.Descripciom, MAX(dbo.Documentos.Folio) AS folio FROM dbo.Documentos INNER JOIN dbo.tbl_Tipodoc ON dbo.Documentos.td = dbo.tbl_Tipodoc.td GROUP BY dbo.tbl_Tipodoc.td, dbo.Documentos.almacen, dbo.tbl_Tipodoc.Descripciom HAVING dbo.Documentos.almacen = " + My.Settings.almacen.ToString
        dgv.DataSource = leer_tabla(cmd)
    End Sub
End Class