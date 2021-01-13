Public Class Kardex
    Dim bs As New BindingSource
    Dim bsresumen As New BindingSource
    Dim tblresumenxtipo As New DataTable
    Dim tbl As New DataTable
    Public Sub cargar(ByVal id As Integer)
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tblresumenalmacen As New DataTable
        Dim tblresumen As New DataTable
        Dim cmd As String
        Dim tblexistencia As New DataTable
        Me.id.Text = id

        Dim cs As String = My.Settings.AdmintegralConnectionString
        cmd = "SELECT * from sql_kardex where id_prodcuto = " + id.ToString + " order by Fecha DESC"
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        AdaptadorDeDatos.Fill(tbl)
        dgv.DataSource = tbl
        bs.DataSource = tbl
        For j As Integer = 0 To 7 : dgv.Columns(j).Visible = False : Next
        dgv.Columns("folio").Visible = True
        dgv.Columns("serie").Visible = True

        dgv.Columns("iva").Visible = False
        dgv.Columns("und_compra").Visible = False
        If tbl.Rows.Count > 0 Then
            Try
                dgv.Columns(15).HeaderText = Trim(dgv.Rows(0).Cells(14).Value)
                dgv.Columns(13).HeaderText = Trim(dgv.Rows(0).Cells(7).Value)
            Catch ex As Exception

            End Try

            Dim cmdres As String
            cmdres = "SELECT id_almacen, Almacen, Unidad, movimiento, AVG(Costo) AS Costo, AVG(Venta) AS Venta, SUM(ub_cantidad) AS cantidad, und_compra, SUM(cantidad_und_conpra) " _
            & " AS cajas FROM sql_kardex WHERE id_prodcuto = " + id.ToString _
            & " GROUP BY id_almacen, Almacen, Descripcion, Unidad, movimiento, und_compra "
            AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmdres, cs)
            AdaptadorDeDatos.Fill(tblresumenalmacen)
            dgvalmacen.DataSource = tblresumenalmacen
            Me.bsresumen.DataSource = tblresumenalmacen
            For j As Integer = 0 To 2 : dgvalmacen.Columns(j).Visible = False : Next
            dgvalmacen.Columns(7).Visible = False
            Try
                dgvalmacen.Columns(6).HeaderText = Trim(dgvalmacen.Rows(0).Cells(2).Value)
                dgvalmacen.Columns(8).HeaderText = Trim(dgvalmacen.Rows(0).Cells(7).Value)
            Catch ex As Exception

            End Try
            Dim cmdresumen As String
            cmdresumen = "SELECT Unidad, movimiento, AVG(Costo) AS Costo, AVG(Venta) AS Venta, SUM(ub_cantidad) AS cantidad, und_compra, SUM(cantidad_und_conpra) " _
            & " AS cajas FROM sql_kardex WHERE id_prodcuto = " + id.ToString _
            & " GROUP BY  Descripcion, Unidad, movimiento, und_compra "
            AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmdresumen, cs)
            AdaptadorDeDatos.Fill(tblresumen)
            dgvresumen.DataSource = tblresumen
            dgvresumen.Columns(0).Visible = False
        End If


        '' Carga Existencias por Almacen
        cmd = "SELECT dbo.tbl_almacenes.id_almacen, dbo.tbl_almacenes.Almacen, SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) AS Existencia, max(dbo.sql_factores.factoruc) as EMP, " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n)/ max(dbo.sql_factores.factoruc) as Cajas " _
        & "FROM dbo.movimientos INNER JOIN dbo.tbl_almacenes ON dbo.movimientos.almacen = dbo.tbl_almacenes.id_almacen " _
        & "  INNER JOIN dbo.sql_factores ON dbo.movimientos.id_prodcuto = dbo.sql_factores.id_Producto" _
        & " GROUP BY dbo.movimientos.id_prodcuto, dbo.tbl_almacenes.Almacen, dbo.tbl_almacenes.id_almacen " _
        & "HAVING dbo.movimientos.id_prodcuto = " + id.ToString & "ORDER BY dbo.tbl_almacenes.id_almacen "

        Try
            AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
            AdaptadorDeDatos.Fill(tblexistencia)
            Me.Dgvexistencia.DataSource = tblexistencia
            Existencia.Text = Format(tblexistencia.Compute("sum (cajas)", ""), "N3")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
    End Sub

    Private Sub id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim nid As Integer
            nid = id.Text
            If nid > 0 Then cargar(nid)
        End If
    End Sub

    Private Sub Id_almacenTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_almacenTextBox.TextChanged
        Dim filtro As String = "id_almacen =" + Id_almacenTextBox.Text
        bs.Filter = filtro
        bsresumen.Filter = filtro
    End Sub

    Private Sub vista_estrecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vista_estrecha.CheckedChanged
        If vista_estrecha.Checked = True Then
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Else
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.nentrada.Text = tbl.Compute("sum (ub_cantidad)", "td=1")
        Catch ex As Exception

        End Try

        Me.ndevoluc.Text = tbl.Compute("sum (ub_cantidad)", "td=2").ToString
        
        Me.nventas.Text = tbl.Compute("sum (ub_cantidad)", "td=5 or td=6")
       


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(fnexistencia(Me.Id_almacenTextBox.Text, id.Text, Now.Date))
    End Sub
End Class