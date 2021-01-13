Public Class Pedidos_Relacion

    Private Sub Nuevo_pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_pedido.Click
        'My.Forms.Pedidos_crear.MdiParent = Me
        My.Forms.Pedidos_crear.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.PedidosDataGridView.Dispose()
        Me.Close()
    End Sub

    Public Sub recarga()
        Me.Sql_relacion_pedidosTableAdapter.Fill(Me.AdmintegralDataSet.sql_relacion_pedidos)
    End Sub

    Private Sub Pedidos_Relacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Sql_relacion_pedidosTableAdapter.Fill(Me.AdmintegralDataSet.sql_relacion_pedidos)
    End Sub

    Private Sub filtro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles filtro.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim filtro As String
            filtro = "Nombre like '%" + Me.filtro.Text + "%'"
            Me.SqlrelacionpedidosBindingSource.Filter = filtro
        End If
    End Sub

    Private Sub boton_recibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_recibir.Click, RecibirPedidoToolStripMenuItem.Click
        Dim x As Integer, st As Integer
        Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        Try
            st = Me.PedidosDataGridView.CurrentRow.Cells(12).Value 'status
            gprov.id = Me.PedidosDataGridView.CurrentRow.Cells("dgvidprov").Value
            gprov.nombre = Me.PedidosDataGridView.CurrentRow.Cells("dgvnombre").Value
        Catch ex As Exception

        End Try

        Try
            gprov.dias = adap.dias_Credito(1, gprov.id)
            adap.Dispose()
        Catch ex As Exception

        End Try


        If st <> 0 And st <> 11 Then
            MsgBox("Este pedido ya tiene entrada")
            Exit Sub
        End If
        Try

        Catch ex As Exception
            x = Me.PedidosDataGridView.CurrentRow.Cells(0).Value
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            My.Forms.Entrada_nueva.npedido = x
            My.Forms.Entrada_nueva.Show()
        End Try

        Me.Close()
    End Sub

    Private Sub Toolmodificarpedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toolmodificarpedido.Click, PedidosDataGridView.DoubleClick
        Dim x As Integer, st As Integer
        st = Me.PedidosDataGridView.CurrentRow.Cells(12).Value 'status
        If st <> 0 And st <> 11 Then
            MsgBox("Solo se pueden Modificar Pedidos Pendientes")
        End If
        x = Me.PedidosDataGridView.CurrentRow.Cells(0).Value
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.pedidos_modificar.cargar_pedido(x)
        My.Forms.pedidos_modificar.Visible = False
        My.Forms.pedidos_modificar.Show()
        My.Forms.pedidos_modificar.calcular()
        My.Forms.pedidos_modificar.Visible = True
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'Modificar Pedido

    
    Private Sub boton_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_imprimir.Click
        Dim x As Integer, st As Integer
        st = Me.PedidosDataGridView.CurrentRow.Cells(12).Value 'status
        x = Me.PedidosDataGridView.CurrentRow.Cells(0).Value
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.Pedidos_imprimir.cargar(x)
        My.Forms.Pedidos_imprimir.Visible = False
        My.Forms.Pedidos_imprimir.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub
End Class