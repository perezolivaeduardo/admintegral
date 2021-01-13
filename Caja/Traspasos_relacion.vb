Public Class Traspasos_relacion
    Dim tbl As New DataTable
    Private Sub idalmacen_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles idalmacen.Enter
        idalmacen.SelectAll()
    End Sub


    Private Sub idalmacen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idalmacen.KeyPress
        If e.KeyChar = chr13 Then
            Dim op As New TextBox
            op = sender
            Dim adap As New admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
            Try
                almacen.Text = adap.leer(op.Text).ToString
                cargar(op.Text)
            Catch ex As Exception
                MsgBox("Teclee numero de almacen")
                op.Text = ""
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub cargar(ByVal almacen As String)
        Dim cmd As String
        cmd = "SELECT dbo.Documentos.Folio, dbo.Documentos.fechafactura AS fecha,  " _
        & "tbl_almacenes_1.id_almacen AS identrada, tbl_almacenes_1.Almacen AS Entrada,dbo.Documentos.status AS status FROM dbo.Documentos INNER JOIN " _
        & "dbo.tbl_almacenes ON dbo.Documentos.almacen = dbo.tbl_almacenes.id_almacen INNER JOIN " _
        & "dbo.tbl_almacenes AS tbl_almacenes_1 ON dbo.Documentos.id_almacen_entrada = tbl_almacenes_1.id_almacen INNER JOIN " _
        & "dbo.usuarios ON dbo.Documentos.id_user = dbo.usuarios.id_usuario " _
        & "WHERE dbo.Documentos.td = 3 and dbo.tbl_almacenes.id_almacen = " + almacen
        tbl = leer_tabla(cmd)
        dgv.DataSource = tbl
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            .Columns("entrada").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
        idalmacen.SelectAll()
        If dgv.Rows.Count = 0 Then Me.boton_cancelar.Enabled = False Else Me.boton_cancelar.Enabled = True
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cancelar.Click
        If dgv.Rows.Count = 0 Then Exit Sub
        Dim folio As Integer
        folio = dgv.CurrentRow.Cells(0).Value
        Dim ok As MsgBoxResult, msg As String = "Quiere Cancelar el Traspaso " + folio.ToString + " del almacen " + Me.idalmacen.Text

        Dim x1 As usuario = autoriza_funcion(5)
        If x1.id = 0 Then MsgBox("No Autorizado") : Exit Sub


        ok = MsgBox(msg, MsgBoxStyle.YesNo, "Cancelar Traspaso")
        If ok = MsgBoxResult.Yes Then
            marcar_documento(3, folio, idalmacen.Text)
            marcar_documento(4, folio, idalmacen.Text)
            cargar(idalmacen.Text)
        End If

    End Sub

    Private Sub boton_puerta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_puerta.Click
        Me.Close()
    End Sub

    Private Sub Traspasos_relacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cmd As String = "select almacen from cajas where id_caja =" + My.Settings.ncaja.ToString
        Dim tb As New DataTable
        tb = leer_tabla(cmd)
        Me.almacen.Text = tb.Rows(0).Item(0)
        cargar(almacen.Text)
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        My.Forms.traspasos_reporte.Show()
    End Sub
End Class