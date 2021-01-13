Public Class usuarios
    Dim tblop As New DataTable

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.UsuariosBindingSource.EndEdit()
            Me.UsuariosTableAdapter.Update(Me.AdmintegralDataSet.usuarios)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.AdmintegralDataSet.usuarios)
        ' Declare variables for DataColumn and DataRow objects.
        Dim column As New DataColumn

        column = New DataColumn("x", System.Type.GetType("System.Int32"))
        column.Unique = False
        tblop.Columns.Add(column)

        column = New DataColumn("y", System.Type.GetType("System.Int32"))
        column.Unique = False
        tblop.Columns.Add(column)

        column = New DataColumn("Opcion", System.Type.GetType("System.String"))
        column.AllowDBNull = False : tblop.Columns.Add(column)

        column = New DataColumn("Activo", GetType(Boolean))
        column.AllowDBNull = False : tblop.Columns.Add(column)

        dgv.DataSource = tblop
        With dgv
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End With
    End Sub

    Private Sub cargar(ByVal id As Integer)
        tblop.Clear()
        Dim cmd As String
        cmd = "SELECT     id_user, nivel, opcion, valor FROM tbl_menus " _
        & "WHERE id_user = " + id.ToString
        Dim tbl As DataTable = leer_tabla(cmd)

        Dim op(0 To 20, 0 To 20) As Boolean
        Dim menu(0 To 20, 0 To 20) As String
        Dim x, y, j As Integer

        For j = 0 To tbl.Rows.Count - 1
            x = tbl.Rows(j).Item(1)
            y = tbl.Rows(j).Item(2)
            op(x, y) = tbl.Rows(j).Item(3)
        Next

        Dim cmdmenu As String
        cmdmenu = "SELECT nivel, opcion, descripcion FROM tbl_menu_opciones "

        Dim dr1 As DataRow
        'tblop.Columns.Add(New DataColumn("nivel", GetType(Integer)))
        'tblop.Columns.Add(New DataColumn("opcion", GetType(Integer)))
        'tblop.Columns.Add(New DataColumn("descripcio", GetType(String)))
        'tblop.Columns.Add(New DataColumn("valor", GetType(Boolean)))

        Dim tblmenu As DataTable = leer_tabla(cmdmenu)
        For j = 0 To tblmenu.Rows.Count - 1
            x = tblmenu.Rows(j).Item(0)
            y = tblmenu.Rows(j).Item(1)
            menu(x, y) = tblmenu.Rows(j).Item(2)
          
            dr1 = tblop.NewRow

            Try
                dr1(0) = x : dr1(1) = y : dr1(2) = menu(x, y) : dr1(3) = op(x, y)
                tblop.Rows.Add(dr1)
            Catch ex As Exception

            End Try

        Next j

        If tbl.Rows.Count < tblmenu.Rows.Count Then crear(id)
    End Sub

    Private Sub Id_usuarioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_usuarioTextBox.TextChanged
        Me.PwTextBox.PasswordChar = "*"
        cargar(Me.Id_usuarioTextBox.Text)
    End Sub

    Private Sub boton_Buardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Buardar.Click
        Dim adap As New admintegralDataSetTableAdapters.tbl_menusTableAdapter
        Dim x, y, j As Integer, op As Boolean
        Dim id As Integer = Me.Id_usuarioTextBox.Text
        For j = 0 To tblop.Rows.Count - 1
            x = tblop.Rows(j).Item(0)
            y = tblop.Rows(j).Item(1)
            op = tblop.Rows(j).Item(3)
            Try
                adap.actualiza(op, id, x, y)
            Catch ex As Exception
                adap.insertar(id, x, y, op)
            End Try
        Next
    End Sub

    Private Sub crear(ByVal id As Integer)
        Dim adap As New admintegralDataSetTableAdapters.tbl_menusTableAdapter
        Dim cmdmenu As String
        Dim x, y, j As Integer
        cmdmenu = "SELECT nivel, opcion, descripcion FROM tbl_menu_opciones "
        Dim tblmenu As DataTable = leer_tabla(cmdmenu)
        For j = 0 To tblmenu.Rows.Count - 1
            x = tblmenu.Rows(j).Item(0)
            y = tblmenu.Rows(j).Item(1)
            Try
                adap.insertar(id, x, y, False)
            Catch ex As Exception
            End Try
        Next j

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Id_usuarioTextBox.Enabled = True
        Me.Id_usuarioTextBox.Focus()
    End Sub

    Private Sub PwLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.Id_usuarioTextBox.Text <> "1" Then Me.PwTextBox.PasswordChar = ""
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        My.Forms.funciones_asignar.caragar(Me.Id_usuarioTextBox.Text, Me.NombreTextBox.Text)
        My.Forms.funciones_asignar.ShowDialog()
    End Sub
End Class