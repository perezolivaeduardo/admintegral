Public Class buscar_provedor
    Dim BSProv As New BindingSource()
    Private Sub buscar_provedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tabla As New DataTable() 'tabla del detalle de pedido
        Dim cmd, cs As String
        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT id_directorio, Nombre,dias,iva,comentarios FROM Directorio  WHERE tipo = 1"
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.Fill(tabla)
        dgv.DataSource = tabla
        BSProv.Filter = "id_directorio < 0"
        BSProv.DataSource = tabla
        Me.TextBox1.Focus()
    End Sub ' Leeforma

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim s As New TextBox
        s = TextBox1
        If s.Text.Length > 1 Then
            If Val(s.Text) > 0 Then
                BSProv.Filter = preparar_buscar("id_directorio", s.Text)
            Else
                BSProv.Filter = preparar_filtro("Nombre", TextBox1.Text)
            End If
        End If
    End Sub ' filtra por nombre

    Private Sub dgv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.DoubleClick
        If Me.dgv.Rows.Count = 0 Then Exit Sub
        gprov.id = Me.dgv.CurrentRow.Cells(0).Value
        gprov.nombre = Me.dgv.CurrentRow.Cells(1).Value
        gprov.dias = Me.dgv.CurrentRow.Cells(2).Value
        gprov.iva = Me.dgv.CurrentRow.Cells("iva").Value
        Try
            gprov.comentarios = Me.dgv.CurrentRow.Cells("comentarios").Value
        Catch ex As Exception

        End Try


        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub ' Doble click al Grid

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.dgv.Rows.Count = 0 Then Exit Sub
        gprov.id = Me.dgv.CurrentRow.Cells(0).Value
        gprov.nombre = Me.dgv.CurrentRow.Cells(1).Value
        gprov.dias = Me.dgv.CurrentRow.Cells(2).Value
        gprov.iva = Me.dgv.CurrentRow.Cells("iva").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub ' Clic botn Ok 

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        gprov.id = 0
        gprov.nombre = ""
        Me.Close()
    End Sub ' slair

    Private Sub dgv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv.KeyPress
        If Me.dgv.Rows.Count = 0 Then Exit Sub
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            gprov.id = Me.dgv.CurrentRow.Cells(0).Value
            gprov.nombre = Me.dgv.CurrentRow.Cells(1).Value
            gprov.dias = Me.dgv.CurrentRow.Cells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub ' Si da enter en la forma
    Protected Overrides Function ProcessCmdKey( _
      ByRef msg As System.Windows.Forms.Message, _
      ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Enter Then
            Try
                gprov.id = Me.dgv.CurrentRow.Cells(0).Value
                gprov.nombre = Me.dgv.CurrentRow.Cells(1).Value
                gprov.dias = Me.dgv.CurrentRow.Cells(2).Value
                gprov.iva = Me.dgv.CurrentRow.Cells(3).Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception

            End Try

        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
   
End Class