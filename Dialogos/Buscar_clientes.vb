Public Class Buscar_clientes
    Dim rw As Integer
    Private Sub Buscar_clientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tabla As New DataTable() 'tabla del detalle de pedido
        Dim cmd, cs As String
        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT id_directorio, Nombre, RFC FROM Directorio WHERE tipo = 2"
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.Fill(tabla)
        If tabla.Rows.Count = 0 Then MsgBox("No Existen Clientes") : Exit Sub
        Me.DirectorioBindingSource.DataSource = tabla
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        Me.TextBox1.SelectAll()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim s As New TextBox
        s = TextBox1
        Try
            If s.Text.Length > 0 Then
                If Val(s.Text) > 0 Then
                    Me.DirectorioBindingSource.Filter = preparar_buscar("id_directorio", s.Text)
                Else
                    Me.DirectorioBindingSource.Filter = preparar_filtro("Nombre", TextBox1.Text)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        id_cliente = 0
        Me.Close()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        id_cliente = Me.dgv.CurrentRow.Cells(0).Value
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub

    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        Try
            id_cliente = Me.dgv.CurrentRow.Cells(0).Value
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            Close()
        Catch ex As Exception
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey( _
    ByRef msg As System.Windows.Forms.Message, _
    ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Enter Then
            Try
                rw = dgv.CurrentRow.Index.ToString
                id_cliente = Me.dgv.Rows(rw).Cells(0).Value
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Close()
            Catch ex As Exception

            End Try

        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class