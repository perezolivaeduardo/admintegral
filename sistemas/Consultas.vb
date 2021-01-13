Public Class Consultas
    Dim filtro As String
    Private Sub Consultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Sql_existencias_compraybaseTableAdapter.Fill(Me.AdmintegralDataSet.sql_existencias_compraybase)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If TextBox1.Text.Length > 0 Then
                filtro = preparar_filtro("descripcion", TextBox1.Text)
                Me.Sql_existencias_compraybaseBindingSource.Filter = filtro
            Else
                Me.Sql_existencias_compraybaseBindingSource.Filter = ""
            End If
        End If
    End Sub


    
End Class