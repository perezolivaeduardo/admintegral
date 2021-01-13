Public Class mostrar_desactivados


    Public Sub cargar(ByVal tabla As DataTable)
        dgv.DataSource = tabla
        dgv.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub boton_activar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_activar.Click
        Dim cv As Integer, cmd As String
        Dim ix As MsgBoxResult = MsgBox("Seguro que quiere Re-Activar este producto", MsgBoxStyle.YesNo, "Activar Producto")
        If ix = MsgBoxResult.Yes Then
            cv = dgv.CurrentRow.Cells(0).Value
            cmd = "UPDATE [integra].[dbo].[productos] SET [id_Grupo]=[id_grupo_original] "
            cmd += " WHERE id_producto = " + cv.ToString
            comando(cmd)
            MsgBox("Activada!!, se refljaran en la hoja la proxima ves que la cargue", MsgBoxStyle.Information)
            Try
                dgv.Rows.Remove(dgv.CurrentRow)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        Me.boton_activar.Enabled = True
    End Sub
End Class