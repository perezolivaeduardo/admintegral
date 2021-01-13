Public Class pop_existencia
    Public myid As Integer
    Dim bs As New BindingSource
    Private Sub pop_existencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub calcular(ByVal id As Integer, ByVal descripcion As String)
        myid = id
        Dim a, factor As String
        a = "" : factor = ""
        Try
            a = id : factor = 1
            lblprod.Text = descripcion
        Catch ex As Exception

        End Try
        Dim cmd As String, tb As New DataTable
        cmd = "SELECT tbl_almacenes.id_almacen, tbl_almacenes.Almacen, movimientos.id_prodcuto, SUM(movimientos.ub_cantidad * n) AS unidades " _
        & "FROM movimientos INNER JOIN tbl_almacenes ON movimientos.almacen = tbl_almacenes.id_almacen GROUP BY tbl_almacenes.id_almacen, tbl_almacenes.Almacen, movimientos.id_prodcuto " _
        & " HAVING SUM(movimientos.ub_cantidad*n)<>0 and movimientos.id_prodcuto = " + a + " order by tbl_almacenes.id_almacen "
        tb = leer_tabla(cmd)

        If tb.Rows.Count = 0 Then MsgBox("Sin Movimientos!!") : Exit Sub

        cmd = "select Unidad,factor from Unidades_productos where id_producto =" + id.ToString + "order by factor"
        Dim tbf As DataTable = leer_tabla(cmd)
        Dim nf As Integer = tbf.Rows.Count
        Dim column As DataColumn

        For j As Integer = 0 To nf - 1
            Dim h As String = tbf.Rows(j).Item(0).ToString.Trim(" ")
            If j > 0 Then h += "(" + tbf.Rows(j).Item(1).ToString.Trim(" ") + ")"
            column = New DataColumn(h, System.Type.GetType("System.Decimal"), "unidades /" + tbf.Rows(j).Item(1).ToString)
            tb.Columns.Add(column)
        Next j

        dgvexistencia.DataSource = tb
        With dgvexistencia
            .Columns("id_almacen").Visible = False
            .Columns("id_prodcuto").Visible = False
            .Columns("unidades").Visible = False
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            For y As Integer = 4 To .Columns.Count - 1
                .Columns(y).DefaultCellStyle.Format = "N0"
                .Columns(y).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next y
        End With

        ' define inventario inicial
        cmd = "SELECT     TOP (100) PERCENT dbo.movimientos.almacen AS No, dbo.tbl_almacenes.Almacen, dbo.movimientos.fecha, dbo.movimientos.ub_cantidad AS Contado " _
        & " FROM dbo.movimientos INNER JOIN dbo.tbl_almacenes ON dbo.movimientos.almacen = dbo.tbl_almacenes.id_almacen " _
        & " WHERE dbo.movimientos.id_doc = 11 AND dbo.movimientos.id_prodcuto = " + id.ToString _
        & " ORDER BY No"
        Dim tbini As DataTable = leer_tabla(cmd)
        dgvini.DataSource = tbini
        dgvini.Columns(0).Visible = False
        dgvini.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvini.Columns(3).DefaultCellStyle.Format = "N0"
        dgvini.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub


    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub boton_fisico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_fisico.Click
        Me.dgvexistencia.Visible = True
        Me.dgvini.Visible = False
        Me.dataresumen.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.dgvexistencia.Visible = False
        Me.dgvini.Visible = True
        Me.dataresumen.Visible = False
    End Sub



    Private Sub dataresumen_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataresumen.CellDoubleClick
        Dim col, filtro As String
        col = Me.dataresumen.Columns(Me.dataresumen.CurrentCell.ColumnIndex).Name
        filtro = col + " = '" + dataresumen.CurrentCell.Value.ToString + "'"
        If netos.Checked = True Then filtro += " and neta<>0"
        bs.Filter = filtro
    End Sub

    Private Sub boton_resumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_resumen.Click
        bs.Filter = ""
        Me.dgvexistencia.Visible = False
        Me.dgvini.Visible = False
        dataresumen.Visible = True
    End Sub





    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim cmd As String
        cmd = "SELECT Almacen, movimiento, SUM(cantidad_historica) AS Historica, SUM(Cantidad) AS Neta FROM dbo.pop_kardex " _
        & "GROUP BY Almacen, movimiento, id_prodcuto " _
        & " HAVING id_prodcuto = '" + myid.ToString + "' ORDER BY Almacen, movimiento "
        bs.DataSource = leer_tabla(cmd)
        Me.dataresumen.DataSource = bs
        Me.dgvexistencia.Visible = False
        Me.dgvini.Visible = False
        Me.dataresumen.Visible = True
        Me.boton_resumen.Visible = True

    End Sub 'Cargar Detalle

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim cmd As String
        cmd = "SELECT Almacen,fecha, movimiento,folio,serie,  cantidad_historica AS Historica, Cantidad AS Neta FROM dbo.pop_kardex " _
        & " where id_prodcuto = '" + myid.ToString + "' ORDER BY Almacen, movimiento "
        bs.DataSource = leer_tabla(cmd)
        Me.dataresumen.DataSource = bs
        Me.dgvexistencia.Visible = False
        Me.dgvini.Visible = False
        Me.dataresumen.Visible = True
        Me.boton_resumen.Visible = True


    End Sub

    Private Sub dgvini_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvini.CellDoubleClick
        If user.Esmaster Then
            Dim cantidad As String = InputBox("Teclee la nueva Cantidad", "Cambiar Inventario Inicial", "")
            If cantidad.Length < 1 Then MsgBox("No se cambio nada") : Exit Sub
            Dim alma As Integer, fecha As Date
            alma = dgvini.CurrentRow.Cells(0).Value
            fecha = dgvini.CurrentRow.Cells(2).Value

            Dim cmd As String = "update movimientos set ub_cantidad = " + cantidad
            cmd += " where almacen = " + alma.ToString + " And id_doc = 11 And id_prodcuto = " + myid.ToString
            cmd += " and (fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy-MM-dd") + " 00:00:00', 102))"
            Dim ok As Boolean = comando(cmd)
            If ok Then MsgBox("Registro Actualizado") Else MsgBox("No se actualizo", MsgBoxStyle.Information)
            If ok = True Then
                ' define inventario inicial
                cmd = "SELECT     TOP (100) PERCENT dbo.movimientos.almacen AS No, dbo.tbl_almacenes.Almacen, dbo.movimientos.fecha, dbo.movimientos.ub_cantidad AS Contado " _
                & " FROM dbo.movimientos INNER JOIN dbo.tbl_almacenes ON dbo.movimientos.almacen = dbo.tbl_almacenes.id_almacen " _
                & " WHERE dbo.movimientos.id_doc = 11 AND dbo.movimientos.id_prodcuto = " + myid.ToString _
                & " ORDER BY No"
                Dim tbini As DataTable = leer_tabla(cmd)
                dgvini.DataSource = tbini
                dgvini.Columns(0).Visible = False
                dgvini.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dgvini.Columns(3).DefaultCellStyle.Format = "N0"
                dgvini.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        End If

    End Sub

End Class