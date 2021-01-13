Public Class funciones
    Dim ds As New DataSet("funciones")
    Dim tbl As DataTable = ds.Tables.Add("funcion")

    Private Sub funciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As String = "select * from tbl_funciones_sistema"
        tbl = leer_tabla(cmd)
        Me.Combofunciones.DataSource = tbl
        Me.Combofunciones.DisplayMember = "descripcion"
        Me.Combofunciones.ValueMember = "id_funcion"
        Dim tbuser As DataTable = leer_tabla("select id_usuario,nombre from usuarios")
        dgvusuarios.DataSource = tbuser


    End Sub

    Private Sub Combofunciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combofunciones.SelectedIndexChanged
        Try
            Dim cmd As String, id_f As String = Me.Combofunciones.SelectedValue.ToString
            cmd = "SELECT tbl_permisos.id_funcion, usuarios.id_usuario, usuarios.Nombre FROM usuarios INNER JOIN tbl_permisos ON usuarios.id_usuario = tbl_permisos.id_usuario where id_funcion=" + id_f
            Me.dgvpermiso.DataSource = leer_tabla(cmd)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvusuarios_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvusuarios.CellDoubleClick
        Dim id As Integer = dgvusuarios.CurrentRow.Cells(0).Value
        Dim fn As String = Me.Combofunciones.SelectedValue.ToString
        agregar(id, fn)

    End Sub

    Private Sub agregar(ByVal id As Integer, ByVal fn As Integer)
        Dim adap As New admintegralDataSetTableAdapters.tbl_permisosTableAdapter
        Try
            adap.Insert(id, fn, 1)
            adap.Dispose()
            Try
                Dim cmd As String, id_f As String = Me.Combofunciones.SelectedValue.ToString
                cmd = "SELECT tbl_permisos.id_funcion, usuarios.id_usuario, usuarios.Nombre FROM usuarios INNER JOIN tbl_permisos ON usuarios.id_usuario = tbl_permisos.id_usuario where id_funcion=" + id_f
                Me.dgvpermiso.DataSource = leer_tabla(cmd)
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub
    Private Sub borrar(ByVal id As Integer, ByVal fn As Integer)
        Dim adap As New admintegralDataSetTableAdapters.tbl_permisosTableAdapter
        Try
            adap.Delete(id, fn, 1)
            adap.Dispose()
            Try
                Dim cmd As String, id_f As String = Me.Combofunciones.SelectedValue.ToString
                cmd = "SELECT tbl_permisos.id_funcion, usuarios.id_usuario, usuarios.Nombre FROM usuarios INNER JOIN tbl_permisos ON usuarios.id_usuario = tbl_permisos.id_usuario where id_funcion=" + id_f
                Me.dgvpermiso.DataSource = leer_tabla(cmd)
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub



    Private Sub dgvpermiso_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvpermiso.CellDoubleClick
        Dim id As Integer = dgvpermiso.CurrentRow.Cells(0).Value
        Dim fn As String = Me.Combofunciones.SelectedValue.ToString
        borrar(id, fn)
    End Sub
End Class