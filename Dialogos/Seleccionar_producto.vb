Imports System.Windows.Forms

Public Class Buscar_productos
    Dim bscatalogo As New BindingSource
    Public codigo As String
    Dim rw As Integer
    Private Sub seleccionar(ByVal rw As Integer)
        producto.a1id = dgv.Rows(rw).Cells("id_producto").Value
        producto.a2descripcion = dgv.Rows(rw).Cells("Descripcion").Value
        producto.a3factor = dgv.Rows(rw).Cells("factorc").Value
        producto.a4uc = dgv.Rows(rw).Cells("uc").Value
        producto.a5ub = dgv.Rows(rw).Cells("ub_und").Value
        producto.a6iva = dgv.Rows(rw).Cells("iva").Value
        producto.a7codigo = dgv.Rows(rw).Cells("codigo").Value
        producto.a8costo = dgv.Rows(rw).Cells("costoc").Value
        producto.a9idprov = dgv.Rows(rw).Cells("id_directorio").Value
        producto.a9caducidad = dgv.Rows(rw).Cells("caducidad").Value
        producto.ieps = dgv.Rows(rw).Cells("ieps").Value
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        bscatalogo.Filter = ""
        TextBox1.Text = ""
        TextBox1.Focus()
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv.DataSource = tabla_catalogo
        bscatalogo.DataSource = tabla_catalogo
        dgv.StandardTab = True
        dgv.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.Columns(0).Visible = False  'id producto
        dgv.Columns(1).Visible = False 'id_provedor
        dgv.Columns("codigo").DisplayIndex = 0
        dgv.ReadOnly = True
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim filtro As String
        filtro = preparar_filtro("Descripcion", TextBox1.Text)
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
            bscatalogo.Filter = ""
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey( _
    ByRef msg As System.Windows.Forms.Message, _
    ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Enter Then
            If dgv.SelectedRows.Count > 1 Then
                MsgBox(dgv.SelectedRows.Count - 1)
            End If
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

    Private Sub ExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasToolStripMenuItem.Click
        Dim id As Integer, descripcion As String
        id = dgv.CurrentRow.Cells(0).Value
        descripcion = dgv.CurrentRow.Cells("descripcion").Value
        My.Forms.pop_existencia.calcular(id, descripcion)
        My.Forms.pop_existencia.Left = Me.Left + Me.Width + 10
        My.Forms.pop_existencia.Top = Me.Top
        My.Forms.pop_existencia.ShowDialog()

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class
