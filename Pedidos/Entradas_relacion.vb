Public Class Entradas_relacion

    Private Sub Entradas_relacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Sql_documentosTableAdapter.FillByTd(Me.AdmintegralDataSet.sql_documentos, 1) 'lee entradas nadamas
    End Sub ' Load (carga relacion de entradas)

    Private Sub nueva_entrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nueva_entrada.Click
        My.Forms.Entrada_nueva.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub ' Nueva Entrada

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim x As MsgBoxResult
        Dim folio, np As Integer

        folio = Me.Sql_documentosDataGridView.CurrentRow.Cells("folio").Value
        np = Me.Sql_documentosDataGridView.CurrentRow.Cells("npedido").Value

        x = MsgBox("Quiere borrar la entrada :" + folio.ToString, MsgBoxStyle.YesNo, "Borrar Entrada")
        If x = MsgBoxResult.No Then Exit Sub
        Status1.Text = "Borrando Entrada " + folio.ToString
        Dim adap As New AdmintegralDataSetTableAdapters.movimientosTableAdapter
        Dim adap1 As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim adap5 As New admintegralDataSetTableAdapters.ComentariosTableAdapter

        Try
            Status1.Text = "Borrando Movimientos..."
            adap.borrar_movimientos(1, folio, "")

            Status1.Text = "Borrando Documento..."
            adap1.borrar_documento(1, folio)
            Me.Sql_documentosTableAdapter.FillByTd(Me.AdmintegralDataSet.sql_documentos, 1) 'lee entradas nadamas

            Status1.Text = "Borrar Comentarios"
            adap5.Borra_comentarios(1, folio)

            Status1.Text = "Entrada Borrada.."
        Catch ex As Exception
            MsgBox("Error al tratar de Borrar")
        End Try

        Status1.Text = "Entrada Borrada"
        If np > 0 Then
            Dim adap2 As New AdmintegralDataSetTableAdapters.pedidosTableAdapter
            Dim adap3 As New AdmintegralDataSetTableAdapters.Pedidos_detalleTableAdapter
            Status1.Text = "Actualizando Pedido"
            Try
                adap2.actualiza_entrada(0, 0, np)
            Catch ex As Exception
                MsgBox("No se actualizo el pedido " + np.ToString)
            End Try
            Try
                Status1.Text = "Actualizando Detalle de Pedido"
                adap3.ped_borrar_entrada(" ", np)
            Catch ex As Exception

            End Try
            Status1.Text = "Entrada Borrada"
        End If
    End Sub ' Borrar Documento

    Private Sub boton_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_modificar.Click
        Dim folio As Long
        Try
            folio = Me.Sql_documentosDataGridView.CurrentRow.Cells("folio").Value
            gprov.id = Me.Sql_documentosDataGridView.CurrentRow.Cells("dgvid_prov").Value
            gprov.nombre = Me.Sql_documentosDataGridView.CurrentRow.Cells("dgv_nombre").Value
            My.Forms.Entreadas_modifica.nentrada = folio
            My.Forms.Entreadas_modifica.Show()
            My.Forms.Entreadas_modifica.cargar_entrada()
        Catch ex As Exception

        End Try
    End Sub ' Llama a modificar Domunetos

    Private Sub Boton_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_imprimir.Click
        Dim Folio As String = Me.Sql_documentosDataGridView.CurrentRow.Cells("folio").Value
        My.Forms.documentos_imprimir.cargar(1, Folio, " ")
        My.Forms.documentos_imprimir.Show()
    End Sub

    Private Sub boton_relacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_relacion.Click
        My.Forms.Reporte_de_Entradas.Show()
    End Sub

    

    Private Sub filtrotxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles filtrotxt.TextChanged
        Try
            Dim fil As String = "nombre like '%" + filtrotxt.Text + "%' or id_directorio =" + Val(filtrotxt.Text).ToString
            Me.Sql_documentosBindingSource.Filter = fil
        Catch ex As Exception
            Me.Sql_documentosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub filtrotxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrotxt.Click

    End Sub

    Private Sub filtrofactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrofactura.TextChanged
        Try
            Dim fil As String = "factura like '%" + filtrofactura.Text + "%'"
            Me.Sql_documentosBindingSource.Filter = fil
        Catch ex As Exception
            Me.Sql_documentosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub filtrofactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrofactura.Click

    End Sub
End Class
