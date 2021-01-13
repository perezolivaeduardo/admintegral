Public Class Devolucion_relacion
    Public tipo_de_documento As Integer
    Private Sub Devolucion_relacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Sql_documentosTableAdapter.FillByTd(Me.AdmintegralDataSet.sql_documentos, 2) 'lee Devoluciones nadamas
    End Sub ' Load (carga relacion de Devolcion)

    Private Sub nueva_devolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nueva_Devolucion.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        '  My.Forms.devolucion_nueva.MdiParent = Me
        My.Forms.devolucion_nueva.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub ' Nueva Devolucion

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim x As MsgBoxResult
        Dim folio, np As Integer

        folio = Me.Sql_documentosDataGridView.CurrentRow.Cells("folio").Value
        np = Me.Sql_documentosDataGridView.CurrentRow.Cells("npedido").Value

        x = MsgBox("Quiere borrar la Devolucion :" + folio.ToString, MsgBoxStyle.YesNo, "Borrar Devolucion")
        If x = MsgBoxResult.No Then Exit Sub
        Status1.Text = "Borrando Devolucion" + folio.ToString
        Dim adap As New AdmintegralDataSetTableAdapters.movimientosTableAdapter
        Dim adap1 As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim adap5 As New admintegralDataSetTableAdapters.ComentariosTableAdapter

        Try
            Status1.Text = "Borrando Movimientos..."
            adap.borrar_movimientos(2, folio, "")

            Status1.Text = "Borrando Documento..."
            adap1.UpdateStatus(1, user.id, 2, folio, "")
            Me.Sql_documentosTableAdapter.FillByTd(Me.AdmintegralDataSet.sql_documentos, 1) 'lee entradas nadamas

            Status1.Text = "Borrar Comentarios"
            adap5.Borra_comentarios(2, folio)

            Status1.Text = "Devolucion Cancelada.."
        Catch ex As Exception
            MsgBox("Error al tratar de Borrar")
        End Try
    End Sub ' Borrar Documento

    Private Sub Boton_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_imprimir.Click
        Dim Folio As String = Me.Sql_documentosDataGridView.CurrentRow.Cells("folio").Value
        My.Forms.documentos_imprimir.Show()
        My.Forms.documentos_imprimir.cargar(2, Folio, " ")

    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
End Class