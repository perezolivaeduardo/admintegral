Imports System.Windows.Forms


Public Class seleccionar_grupo
    Dim bscatalogo As New BindingSource
    Public idgrupo As String
    Dim rw As Integer
    Private Sub seleccionar(ByVal rw As Integer)
        idgrupo = dgv.Rows(rw).Cells(0).Value
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        bscatalogo.Filter = ""
        TextBox1.Text = ""
        TextBox1.Focus()
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim cmd, cs As String, adaptadordedatos As New Data.SqlClient.SqlDataAdapter
        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT grupos.id_grupos, grupos.Grupo from grupos"
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        'Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.Fill(tabla)
        dgv.DataSource = tabla
        bscatalogo.DataSource = tabla
        dgv.StandardTab = True
        dgv.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.ReadOnly = True
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim filtro As String
        filtro = preparar_filtro("Grupo", TextBox1.Text)
        bscatalogo.Filter = filtro
        If dgv.Rows.Count > 0 Then
            dgv.CurrentRow.Selected = True
        End If
    End Sub

    Private Sub dgv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.DoubleClick
        rw = dgv.CurrentRow.Index.ToString
        seleccionar(rw)
    End Sub

    Private Sub dgv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub


    Protected Overrides Function ProcessCmdKey( _
    ByRef msg As System.Windows.Forms.Message, _
    ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Enter Then
            rw = dgv.CurrentRow.Index.ToString
            seleccionar(rw)
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = "{tab}" Then
            dgv.Focus()
        End If
    End Sub
End Class
