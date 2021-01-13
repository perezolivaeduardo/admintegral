Public Class ver_precio

    Private Sub ver_precio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Public Sub mensage(ByVal prod As String, ByVal und As String, ByVal prec As String)
        Me.productotxt.Text = prod
        Me.uniadtxt.Text = und
        Me.preciotxt.Text = prec
        Me.productotxt.SelectionLength = 0
        Me.uniadtxt.SelectionLength = 0
        Me.preciotxt.SelectionLength = 0
    End Sub
End Class