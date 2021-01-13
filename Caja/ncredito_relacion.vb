Public Class ncredito_relacion
    Public tipo_de_documento As Integer

    Private Sub nueva_entrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nueva_entrada.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.caja_ncredito.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub ' Nueva Devolucion

    Private Sub ncredito_relacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Sql_documentosTableAdapter.FillBytd(Me.AdmintegralDataSet.sql_documentos, 7) 'lee Devoluciones nadamas
    End Sub

    Private Sub Boton_borra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_borra.Click
        Dim x As MsgBoxResult
        Dim folio, np As Integer

        folio = Me.Sql_documentosDataGridView.CurrentRow.Cells("folio").Value
        np = Me.Sql_documentosDataGridView.CurrentRow.Cells("npedido").Value

        x = MsgBox("Quiere borrar la Nota de Credito :" + folio.ToString, MsgBoxStyle.YesNo, "Borrar Devolucion")
        If x = MsgBoxResult.No Then Exit Sub
        Status1.Text = "Borrando Devolucion" + folio.ToString
        Dim adap As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim adap1 As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim adap5 As New admintegralDataSetTableAdapters.ComentariosTableAdapter

        Try
            Status1.Text = "Borrando Movimientos..."
            adap.borrar_movimientos(2, folio, "")

            Status1.Text = "Borrando Documento..."
            adap1.borrar_documento(2, folio)
            Me.Sql_documentosTableAdapter.FillByTd(Me.AdmintegralDataSet.sql_documentos, 2) 'lee entradas nadamas

            Status1.Text = "Borrar Comentarios"
            adap5.Borra_comentarios(2, folio)

            Status1.Text = "Devolucion Borrada.."
        Catch ex As Exception
            MsgBox("Error al tratar de Borrar")
        End Try
    End Sub ' Boton Borrar

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub baton_dev_parcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baton_dev_parcial.Click
        My.Forms.caja.tipo_venta = 7
        My.Forms.caja.Show()
    End Sub

    Private Sub boton_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_imprimir.Click
        My.Forms.listado_NC.Show()
    End Sub

End Class