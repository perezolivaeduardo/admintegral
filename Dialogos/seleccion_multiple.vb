Public Class seleccion_multiple
    Dim bscatalogo As New BindingSource

    Private Sub seleccion_multiple_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        selectable.Clear()
    End Sub

    Private Sub seleccion_multiple_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgv.DataSource = tabla_catalogo
        bscatalogo.DataSource = tabla_catalogo
        dgv.StandardTab = True
        dgv.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        ' dgv.Columns(0).Visible = False  'id producto
        dgv.Columns(1).Visible = False 'id_provedor
        dgv.Columns("codigo").DisplayIndex = 0
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim filtro As String
        filtro = preparar_filtro("Descripcion", TextBox1.Text)
        bscatalogo.Filter = filtro
    End Sub

   
    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        ReDim productos(0 To dgv.SelectedRows.Count - 1)
        If dgv.SelectedRows.Count > 0 Then
            For j As Integer = 0 To dgv.SelectedRows.Count - 1
                productos(j).a1id = dgv.SelectedRows(j).Cells("id_producto").Value
                productos(j).a2descripcion = dgv.SelectedRows(j).Cells("Descripcion").Value.ToString.Trim
                productos(j).a3factor = dgv.SelectedRows(j).Cells("factorc").Value
                productos(j).a4uc = dgv.SelectedRows(j).Cells("uc").Value
                productos(j).a5ub = dgv.SelectedRows(j).Cells("ub_und").Value
                productos(j).a6iva = dgv.SelectedRows(j).Cells("iva").Value
                productos(j).a7codigo = dgv.SelectedRows(j).Cells("codigo").Value
                productos(j).a8costo = dgv.SelectedRows(j).Cells("costoc").Value
                productos(j).a9idprov = dgv.SelectedRows(j).Cells("id_directorio").Value
                productos(j).ieps = dgv.SelectedRows(j).Cells("ieps").Value
            Next j
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_salir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim nr As Integer = Entrada_nueva.dgv.CurrentRow.Index
        Entrada_nueva.dgv.SuspendLayout()
        Dim u As Und
        u = sk_leer_UndCompra(dgv.CurrentRow.Cells("id_producto").Value)
        With Entrada_nueva.mytable.Rows(nr)
            .Item("id") = dgv.CurrentRow.Cells("id_producto").Value
            .Item("Descripcion") = dgv.CurrentRow.Cells("Descripcion").Value.ToString.Trim
            .Item("factor") = dgv.CurrentRow.Cells("factorc").Value
            .Item("und") = dgv.CurrentRow.Cells("uc").Value
            .Item("ub_und") = dgv.CurrentRow.Cells("ub_und").Value
            .Item("iva") = dgv.CurrentRow.Cells("iva").Value
            .Item("ud_Costo") = u.a4_costo
            .Item("codigo") = dgv.CurrentRow.Cells("codigo").Value
            .Item("id_uc") = u.a9_uc_id
            .Item("ud_Costo_base") = u.a4_costo
            .Item("caduca") = dgv.CurrentRow.Cells("caducidad").Value
            .Item("pieps") = dgv.CurrentRow.Cells("ieps").Value
        End With
        Entrada_nueva.dgv.CurrentCell = Entrada_nueva.dgv.Rows(Entrada_nueva.dgv.CurrentRow.Index + 1).Cells(0)
        dgv.ResumeLayout()
    End Sub

End Class