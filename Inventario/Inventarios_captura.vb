Public Class Inventarios_captura
    Dim tabla As New DataTable
    Dim adap As New admintegralDataSetTableAdapters.inventario_fisicoTableAdapter

    Private Sub Inventarios_captura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet1.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet1.productos)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet1.inventario_fisico' Puede moverla o quitarla según sea necesario.
        Me.Inventario_fisicoTableAdapter.Fill(Me.AdmintegralDataSet1.inventario_fisico)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        Dim column As New DataColumn
        column = New DataColumn("Unidad", System.Type.GetType("System.String"))
        tabla.Columns.Add(column)
        column = New DataColumn("Contado", System.Type.GetType("System.Int32"))
        tabla.Columns.Add(column)
        column = New DataColumn("factor", System.Type.GetType("System.Int32"))
        tabla.Columns.Add(column)
        column = New DataColumn("Unidades", System.Type.GetType("System.Int32"))
        column.Expression = "contado * factor"
        tabla.Columns.Add(column)
        dgv.DataSource = tabla

    End Sub

    Private Sub codigotxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigotxt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim ix1 As Integer = catbs.Find("codigo", Trim(codigotxt.Text))
            If ix1 < 0 Then MsgBox("no existe") : codigotxt.SelectAll() : codigotxt.Focus() : Exit Sub
            Dim id As Integer
            id = tabla_catalogo.Rows(ix1).Item("id_producto")
            idtxt.Text = id
            codigotxt.Text = tabla_catalogo.Rows(ix1).Item("codigo")
            descripcion.Text = tabla_catalogo.Rows(ix1).Item("Descripcion")
            cargar(id)
        End If
    End Sub

    Private Sub cargar(ByVal id As Integer)
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim cmd, cs As String
        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT unidad,0 as contado,unidades as factor "
        cmd += "FROM unidades_productos where id_producto = " + id.ToString
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        'Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        tabla.Clear()
        AdaptadorDeDatos.Fill(tabla)
        dgv.DataSource = tabla
        dgv.Columns(0).ReadOnly = True
        dgv.Columns(2).ReadOnly = True
        dgv.Columns(3).ReadOnly = True
        If tabla.Rows.Count > 0 Then
            dgv.CurrentCell = dgv.Rows(0).Cells(1)
        End If
        unidades.Text = tabla.Compute("sum (unidades)", "")
    End Sub

    Private Sub idtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idtxt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim ix1 As Integer = catbs.Find("id_producto", Trim(idtxt.Text))
            If ix1 < 0 Then MsgBox("no existe") : codigotxt.SelectAll() : codigotxt.Focus() : Exit Sub
            Dim id As Integer
            id = tabla_catalogo.Rows(ix1).Item("id_producto")
            idtxt.Text = id
            codigotxt.Text = tabla_catalogo.Rows(ix1).Item("codigo")
            descripcion.Text = tabla_catalogo.Rows(ix1).Item("descripcion")
            cargar(id)
        End If
    End Sub

    Private Sub dgv_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        tabla.AcceptChanges()
        unidades.Text = tabla.Compute("sum (unidades)", "")
    End Sub

    Private Sub dgv_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEnter
        Try
            dgv.CurrentCell = dgv.CurrentRow.Cells(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub guardar()
        Dim al, id, cantidad As Integer, f As Date
        f = fecha.Value.Date
        al = Me.Id_almacen.Text
        id = Me.idtxt.Text
        cantidad = unidades.Text
        Dim costo As Double
        status.Text = "Guardando Registro"
        Try
            adap.Insert(id, al, f, cantidad, 0, 0) 'GUARDA EN LA TABLA DE INVENTARIOS
            Me.Inventario_fisicoTableAdapter.Fill(Me.AdmintegralDataSet1.inventario_fisico)
        Catch ex As Exception
            Try
                adap.Actualiza_inventario(user.id, cantidad, id, al, f, al, f, id)
            Catch ex1 As Exception
                MsgBox(ex.Message)
            End Try
        End Try
        status.Text = "Borrando Movimiento"
        Dim adapm As New admintegralDataSetTableAdapters.movimientosTableAdapter
        adapm.movimientos_borra_registro_inventario_fisico(al, id, f)
        Dim d As New Mi_Documento
        d.a00_id_doc = 11
        d.a01_Folio = 0
        d.a02_serie = ""
        d.a03_Almacen = al
        d.a06_fecha_registro = f
        d.a09_fecha_factura = f
        d.a10_fecha_surtido = f
        d.a11_fecha_vence = f

        Dim result As Boolean = Agregar_documento(d)
        status.Text = "Guardando"
        Try
            adapm.Insert(al, 11, 0, "", id, f, id, 1, 0, 1, cantidad, costo, 0, 0, 0, 0, 0, 0, 0, 0, cantidad, costo, 0, 0, 0, 0, 15, 0, 0, 0, 0, 1, Now.Date, 0, 0, 0, 0, 0)
        Catch ex As Exception
            MsgBox("Error al guardar Inventario)")
        End Try

        status.Text = "Actualizando Existencias"
        Try
            adapm.anula_anteriores_al_inventario(al, f, id)
        Catch ex As Exception
            MsgBox("Error al actualizar Existencias")
        End Try

        Me.Inventario_fisicoTableAdapter.Fill(Me.AdmintegralDataSet1.inventario_fisico)
        status.Text = "Terminado"
    End Sub

    Private Sub Boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_guardar.Click
        guardar()
    End Sub

    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        Dim f As DateTime
        f = fecha.Value.Date
        Dim filtro As String = "fecha = '" + f + "'"
        Me.InventariofisicoBindingSource.Filter = filtro
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        Try
        Catch ex As Exception
        End Try
    End Sub
 
End Class