Public Class ver_dev_tienda
    Public resultado As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            resultado = dgv.CurrentRow.Cells("serie").Value.ToString.Trim + dgv.CurrentRow.Cells("folio").Value.ToString.Trim
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub caragr(ByVal cmd As String)
        Try
            dgv.DataSource = leer_tabla(cmd)
            dgv.Columns(5).DefaultCellStyle.Format = "dd/MM/yyyy"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Try
            resultado = dgv.CurrentRow.Cells("serie").Value.ToString.Trim + dgv.CurrentRow.Cells("folio").Value.ToString.Trim
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            resultado = dgv.CurrentRow.Cells("serie").Value.ToString.Trim + dgv.CurrentRow.Cells("folio").Value.ToString.Trim
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    
End Class