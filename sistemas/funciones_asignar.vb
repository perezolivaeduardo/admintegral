Public Class funciones_asignar

    Private Sub funciones_asignar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub caragar(ByVal mid As Integer, ByVal nombre As String)
        Me.id.Text = mid : Me.Usuariotxt.Text = nombre
        Me.dgvpendientes.DataSource = leer_tabla("select id_funcion as fn,descripcion from sys_funciones_pendientes where id_usuario=" + id.Text)
        Me.dgvasignadas.DataSource = leer_tabla("select id_funcion as fn,descripcion from sql_funciones_asignadas where id_usuario= " + id.Text)
    End Sub

    Private Sub dgvpendientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvpendientes.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_permisosTableAdapter
            Dim idfuncion As Integer = dgvpendientes.CurrentRow.Cells(0).Value
            adap.Insert(Me.id.Text, idfuncion, 1)
            adap.Connection.Close()
            refill()
        End If
    End Sub
    Private Sub refill()
        Me.dgvpendientes.DataSource = leer_tabla("select id_funcion as fn,descripcion from sys_funciones_pendientes where id_usuario=" + id.Text)
        Me.dgvasignadas.DataSource = leer_tabla("select id_funcion as fn,descripcion from sql_funciones_asignadas where id_usuario= " + id.Text)
    End Sub

    Private Sub dgvasignadas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvasignadas.CellContentClick
        If e.RowIndex >= 0 Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_permisosTableAdapter
            Dim idfuncion As Integer = Me.dgvasignadas.CurrentRow.Cells(0).Value
            adap.borrar_funcion(Me.id.Text, idfuncion)
            adap.Connection.Close()
            refill()
        End If
    End Sub

    Private Sub dgvpendientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvpendientes.CellContentClick

    End Sub
End Class