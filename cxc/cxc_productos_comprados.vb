Public Class cxc_productos_comprados
    Dim bs As New BindingSource
    Dim tipo_doc As Integer
    Public Sub cargar(ByVal id As Integer, ByVal tipo As Integer)
        tipo_doc = tipo
        'tipo 6= factura  y tipo 10 = cotizacion
        Dim cmd As String = ""
        If tipo = 6 Then
            cmd = "SELECT Documentos.Folio, Documentos.serie, Documentos.fechafactura as Fecha, productos.id_Producto as ID, productos.Descripcion, movimientos.cantidad, movimientos.venta " _
            & " FROM Directorio INNER JOIN Documentos ON Directorio.id_directorio = Documentos.id_directorio AND Directorio.tipo = Documentos.tipo_directorio INNER JOIN " _
            & "movimientos ON Documentos.td = movimientos.id_doc AND Documentos.Folio = movimientos.folio_doc AND Documentos.serie = movimientos.serie INNER JOIN " _
            & "productos ON movimientos.id_prodcuto = productos.id_Producto " _
            & "WHERE Documentos.td = 6 And Documentos.id_directorio = [ID] And Documentos.tipo_directorio = 2 " _
            & "ORDER BY Documentos.fechafactura DESC "
        End If

        If tipo = 10 Then
            cmd = "SELECT Documentos.Folio, Documentos.serie, Documentos.fechafactura as Fecha, productos.id_Producto as ID, productos.Descripcion, movimientos.cantidad, movimientos.venta " _
            & " FROM Directorio INNER JOIN Documentos ON Directorio.id_directorio = Documentos.id_directorio AND Directorio.tipo = Documentos.tipo_directorio INNER JOIN " _
            & "movimientos ON Documentos.td = movimientos.id_doc AND Documentos.Folio = movimientos.folio_doc AND Documentos.serie = movimientos.serie INNER JOIN " _
            & "productos ON movimientos.id_prodcuto = productos.id_Producto " _
            & "WHERE Documentos.td = 10 And Documentos.id_directorio = [ID] And Documentos.tipo_directorio = 2 " _
            & "ORDER BY Documentos.fechafactura DESC "
        End If

        cmd = cmd.Replace("[ID]", id.ToString)
        bs.DataSource = leer_tabla(cmd)
        dgv.DataSource = bs
        dgv.Columns("fecha").DefaultCellStyle.Format = "d"
    End Sub

    Private Sub filtrotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrotxt.TextChanged
        Dim filtro As String
        If filtrotxt.TextLength > 0 Then
            filtro = "descripcion like '%" + filtrotxt.Text + "%'"
            bs.Filter = filtro
        End If
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim folio, serie As String
        folio = dgv.CurrentRow.Cells("folio").Value
        serie = dgv.CurrentRow.Cells("serie").Value
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.Consultar_una_factura.cargar_docuemnto(tipo_doc, folio, serie)
        My.Forms.Consultar_una_factura.ShowDialog()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class
