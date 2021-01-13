Public Class catalogos

    Private Sub catalogos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.admintegralDataSet.Grupos)
        Me.ListasTableAdapter.Fill(Me.admintegralDataSet.Listas)
    End Sub ' load

    Private Sub prepara_lista(ByVal factor As String, ByVal reporte As String, ByVal pz As Boolean)
        Dim cmd As String
        cmd = "SELECT     TOP 100 PERCENT dbo.productos.id_Producto, Unidades_productos_1.Codigo, dbo.productos.id_Grupo, dbo.productos.Descripcion, "
        cmd += " Unidades_productos_2.factor AS Empaque, dbo.productos.iva, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((dbo.Unidades_productos.venta * [factor] +(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100) + dbo.Unidades_productos.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((dbo.Unidades_productos.venta+(dbo.Unidades_productos.venta *  dbo.productos.ieps/100)  + dbo.Unidades_productos.venta * dbo.productos.iva / 100), 2) END AS PZ, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_1.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + Unidades_productos_1.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_1.venta+(dbo.Unidades_productos.venta *  dbo.productos.ieps/100)  + Unidades_productos_1.venta * dbo.productos.iva / 100), 2) END AS EXH, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_2.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + Unidades_productos_2.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_2.venta +(dbo.Unidades_productos.venta * dbo.productos.ieps/100) + Unidades_productos_2.venta * dbo.productos.iva / 100), 2) END AS CJ, dbo.productos.status"
        cmd += " FROM         dbo.productos INNER JOIN"
        cmd += " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND "
        cmd += " dbo.productos.und_detalle = dbo.Unidades_productos.id_unidad INNER JOIN"
        cmd += " dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND "
        cmd += " dbo.productos.und_venta = Unidades_productos_1.id_unidad INNER JOIN"
        cmd += " dbo.Unidades_productos AS Unidades_productos_2 ON dbo.productos.id_Producto = Unidades_productos_2.id_producto AND "
        cmd += " dbo.productos.und_compra = Unidades_productos_2.id_unidad"
        cmd += " GROUP BY dbo.productos.id_Producto, dbo.productos.Descripcion, dbo.productos.und_venta, dbo.productos.und_compra, dbo.productos.und_detalle, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((dbo.Unidades_productos.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + dbo.Unidades_productos.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((dbo.Unidades_productos.venta+(dbo.Unidades_productos.venta * dbo.productos.ieps/100)  + dbo.Unidades_productos.venta * dbo.productos.iva / 100), 2) END, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_1.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + Unidades_productos_1.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_1.venta +(dbo.Unidades_productos.venta * dbo.productos.ieps/100) + Unidades_productos_1.venta * dbo.productos.iva / 100), 2) END, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_2.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + Unidades_productos_2.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_2.venta+(dbo.Unidades_productos.venta * dbo.productos.ieps/100)  + Unidades_productos_2.venta * dbo.productos.iva / 100), 2) END, Unidades_productos_2.factor, "
        cmd += " dbo.productos.id_Directorio, dbo.productos.id_Grupo, dbo.productos.iva, Unidades_productos_1.Codigo, dbo.productos.precio_unico, dbo.productos.status"
        cmd += " HAVING (NOT (dbo.productos.id_Directorio = 487)) AND (NOT (dbo.productos.id_Directorio = 245)) AND (NOT (dbo.productos.id_Directorio = 416)) AND "
        cmd += " (NOT (dbo.productos.id_Directorio = 491)) AND (NOT (dbo.productos.id_Directorio = 492)) AND (NOT (dbo.productos.id_Directorio = 477)) AND "
        cmd += " (NOT (dbo.productos.id_Directorio = 486)) AND (NOT (dbo.productos.id_Directorio = 519)) AND (NOT (dbo.productos.id_Directorio = 523)) AND "
        cmd += " (NOT (dbo.productos.id_Directorio = 526)) AND (dbo.productos.status = 0) AND (dbo.productos.id_Grupo<> " + My.Settings.grupo_suspendidos.ToString + ")"
        cmd += " ORDER BY dbo.productos.id_Grupo, dbo.productos.Descripcion"

        Dim micmd As String = cmd.Replace("[factor]", factor)
        'pasa parametro al reporte
        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("pieza", pz, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(2) = rptlogo

        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Dim tbl As DataTable = leer_tabla(micmd)
        ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub prepara_lista_x_prov(ByVal factor As String, ByVal reporte As String, ByVal pz As Boolean)
        Dim cmd As String
        cmd = "SELECT     TOP 100 PERCENT dbo.productos.id_Producto, Unidades_productos_1.Codigo, dbo.productos.id_Grupo, dbo.productos.Descripcion, "
        cmd += " Unidades_productos_2.factor AS Empaque, dbo.productos.iva, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((dbo.Unidades_productos.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100) + dbo.Unidades_productos.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((dbo.Unidades_productos.venta+(dbo.Unidades_productos.venta * dbo.productos.ieps/100)  + dbo.Unidades_productos.venta * dbo.productos.iva / 100), 2) END AS PZ, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_1.venta * [factor] +(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100) + Unidades_productos_1.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_1.venta +(dbo.Unidades_productos.venta * dbo.productos.ieps/100) + Unidades_productos_1.venta * dbo.productos.iva / 100), 2) END AS EXH, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_2.venta * [factor] +(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100) + Unidades_productos_2.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_2.venta +(dbo.Unidades_productos.venta * dbo.productos.ieps/100) + Unidades_productos_2.venta * dbo.productos.iva / 100), 2) END AS CJ, dbo.productos.status"
        cmd += " FROM dbo.productos INNER JOIN"
        cmd += " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND "
        cmd += " dbo.productos.und_detalle = dbo.Unidades_productos.id_unidad INNER JOIN"
        cmd += " dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND "
        cmd += " dbo.productos.und_venta = Unidades_productos_1.id_unidad INNER JOIN"
        cmd += " dbo.Unidades_productos AS Unidades_productos_2 ON dbo.productos.id_Producto = Unidades_productos_2.id_producto AND "
        cmd += " dbo.productos.und_compra = Unidades_productos_2.id_unidad"
        cmd += " GROUP BY dbo.productos.id_Producto, dbo.productos.Descripcion, dbo.productos.und_venta, dbo.productos.und_compra, dbo.productos.und_detalle, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((dbo.Unidades_productos.venta * [factor] + dbo.Unidades_productos.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((dbo.Unidades_productos.venta + dbo.Unidades_productos.venta * dbo.productos.iva / 100), 2) END, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_1.venta * [factor] + Unidades_productos_1.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_1.venta + Unidades_productos_1.venta * dbo.productos.iva / 100), 2) END, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_2.venta * [factor] + Unidades_productos_2.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_2.venta + Unidades_productos_2.venta * dbo.productos.iva / 100), 2) END, Unidades_productos_2.factor, "
        cmd += " dbo.productos.id_Directorio, dbo.productos.id_Grupo, dbo.productos.iva, Unidades_productos_1.Codigo, dbo.productos.precio_unico, dbo.productos.status"
        cmd += " HAVING dbo.productos.id_Directorio = " + Me.idprov.Text
        If Me.chkgrupo.Checked = True Then
            cmd += " AND dbo.productos.id_Grupo = " + Me.gpotxt.Text
        End If
        cmd += " AND dbo.productos.status = 0 AND dbo.productos.id_Grupo<> " + My.Settings.grupo_suspendidos.ToString
        cmd += " ORDER BY dbo.productos.id_Grupo, dbo.productos.Descripcion"

        Dim micmd As String = cmd.Replace("[factor]", factor)
        'pasa parametro al reporte
        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("pieza", pz, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(2) = rptlogo

        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Dim tbl As DataTable = leer_tabla(micmd)
        ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub prepara_lista_x_desc(ByVal factor As String, ByVal reporte As String, ByVal pz As Boolean)
        Dim cmd As String
        cmd = "SELECT     TOP 100 PERCENT dbo.productos.id_Producto, Unidades_productos_1.Codigo, dbo.productos.id_Grupo, dbo.productos.Descripcion, "
        cmd += " Unidades_productos_2.factor AS Empaque, dbo.productos.iva, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((dbo.Unidades_productos.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + dbo.Unidades_productos.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((dbo.Unidades_productos.venta+(dbo.Unidades_productos.venta *  dbo.productos.ieps/100)  + dbo.Unidades_productos.venta * dbo.productos.iva / 100), 2) END AS PZ, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_1.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + Unidades_productos_1.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_1.venta +(dbo.Unidades_productos.venta * dbo.productos.ieps/100)  + Unidades_productos_1.venta * dbo.productos.iva / 100), 2) END AS EXH, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_2.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + Unidades_productos_2.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_2.venta+(dbo.Unidades_productos.venta * dbo.productos.ieps/100)  + Unidades_productos_2.venta * dbo.productos.iva / 100), 2) END AS CJ, dbo.productos.status"
        cmd += " FROM dbo.productos INNER JOIN"
        cmd += " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND "
        cmd += " dbo.productos.und_detalle = dbo.Unidades_productos.id_unidad INNER JOIN"
        cmd += " dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND "
        cmd += " dbo.productos.und_venta = Unidades_productos_1.id_unidad INNER JOIN"
        cmd += " dbo.Unidades_productos AS Unidades_productos_2 ON dbo.productos.id_Producto = Unidades_productos_2.id_producto AND "
        cmd += " dbo.productos.und_compra = Unidades_productos_2.id_unidad"
        cmd += " GROUP BY dbo.productos.id_Producto, dbo.productos.Descripcion, dbo.productos.und_venta, dbo.productos.und_compra, dbo.productos.und_detalle, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((dbo.Unidades_productos.venta * [factor] +(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100) + dbo.Unidades_productos.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((dbo.Unidades_productos.venta +(dbo.Unidades_productos.venta * dbo.productos.ieps/100) + dbo.Unidades_productos.venta * dbo.productos.iva / 100), 2) END, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_1.venta * [factor]+(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100)  + Unidades_productos_1.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_1.venta +(dbo.Unidades_productos.venta * dbo.productos.ieps/100)  + Unidades_productos_1.venta * dbo.productos.iva / 100), 2) END, "
        cmd += " CASE WHEN precio_unico = 0 THEN ROUND((Unidades_productos_2.venta * [factor] +(dbo.Unidades_productos.venta * [factor] * dbo.productos.ieps/100) + Unidades_productos_2.venta * [factor] * dbo.productos.iva / 100), 2) "
        cmd += " ELSE ROUND((Unidades_productos_2.venta +(dbo.Unidades_productos.venta * dbo.productos.ieps/100)  + Unidades_productos_2.venta * dbo.productos.iva / 100), 2) END, Unidades_productos_2.factor, "
        cmd += " dbo.productos.id_Directorio, dbo.productos.id_Grupo, dbo.productos.iva, Unidades_productos_1.Codigo, dbo.productos.precio_unico, dbo.productos.status"
        cmd += " HAVING dbo.productos.Descripcion like '%" + Me.txtdescripcion.Text.Trim + "%' "
        cmd += " AND dbo.productos.status = 0 AND dbo.productos.id_Grupo<> " + My.Settings.grupo_suspendidos.ToString
        cmd += " ORDER BY dbo.productos.id_Grupo, dbo.productos.Descripcion"

        Dim micmd As String = cmd.Replace("[factor]", factor)
        'pasa parametro al reporte
        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("pieza", pz, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(2) = rptlogo

        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Dim tbl As DataTable = leer_tabla(micmd)
        ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        prepara_lista(factortxt.Text, "Lista de Precios " + Trim(Me.DescripcionComboBox.Text), Me.pieza.Checked)
    End Sub

    Private Sub CargoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoTextBox.TextChanged
        factortxt.Text = CargoTextBox.Text / 100 + 1
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Validar.Click
        Dim cmd As String
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        ' pone status a 0 de todos
        cmd = "update dbo.productos set status=0 FROM productos "
        comando(cmd)
        cmd = "update dbo.productos set status=1 FROM movimientos INNER JOIN productos ON movimientos.id_prodcuto = productos.id_Producto GROUP BY movimientos.id_doc, productos.id_Producto "
        cmd += " HAVING(movimientos.id_doc = 1) "
        comando(cmd)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub factortxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles factortxt.TextChanged

    End Sub

    Private Sub boton_provedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_provedor.Click
        Dim x As New DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Me.idprov.Text = gprov.id
        Me.pvnombre.Text = gprov.nombre
    End Sub
    Private Sub cargar_proveedor()
        Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        Try
            Me.pvnombre.Text = adap.GetDataByID(idprov.Text, 1).Rows(0).Item("Nombre")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub idprov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idprov.KeyPress
        If e.KeyChar = chr13 Then
            cargar_proveedor()
        End If
    End Sub

    Private Sub boton_por_provedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_por_provedor.Click
        prepara_lista_x_prov(factortxt.Text, "Lista de Precios " + Trim(Me.DescripcionComboBox.Text), Me.pieza.Checked)
    End Sub

    Private Sub GrupoComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoComboBox.TextChanged
        Me.gpotxt.Text = Me.GrupoComboBox.SelectedValue
    End Sub

    Private Sub gpotxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gpotxt.KeyPress
        Try
            Me.GruposBindingSource.Position = Me.GruposBindingSource.Find("id_grupos", Me.gpotxt.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub boton_por_descripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_por_descripcion.Click
        prepara_lista_x_desc(factortxt.Text, "Lista de Precios " + Trim(Me.DescripcionComboBox.Text), Me.pieza.Checked)
    End Sub
End Class