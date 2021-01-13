Public Class ver_tabla

    Public Sub cargar(ByVal tabla As DataTable)
        dgv.DataSource = tabla
    End Sub

End Class