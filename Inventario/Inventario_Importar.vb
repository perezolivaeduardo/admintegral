Imports System.Data.OleDb
Public Class Inventario_Importar
    Dim datos As New DataSet
    Dim colalmacen, colfecha, colid, colcant, almacen As Integer
    Dim tbl_excel As New DataTable
    Dim dbstock As New BindingSource
    Dim tblstock As New DataTable

    Dim bs As New BindingSource
    Dim ds1 As New DataSet
    Dim tbl As DataTable = ds1.Tables.Add("inventario")

    Private Sub Inventario_Importar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AdmintegralDataSet.EnforceConstraints = False
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.sql_existencias_x_almacen' Puede moverla o quitarla según sea necesario.
        '  Me.sql_existencias_x_almacenTableAdapter.Fill(Me.AdmintegralDataSet.sql_existencias_x_almacen)
        Me.GruposTableAdapter.Fill(Me.AdmintegralDataSet.Grupos)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        Me.idalmacen.Text = Me.AlmacenComboBox.SelectedValue
        Me.ReportViewerresume.RefreshReport()
        Dim sql As String
        sql = "SELECT MAX(fecha) AS Expr1 FROM movimientos WHERE n = 0"
        lblufecha.Text = "Fecha Ultimo Inventario : " + leer_tabla(sql).Rows(0).Item(0).ToString

    End Sub

    Private Sub Tbl_almacenesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_almacenesBindingSource.EndEdit()
        Me.Tbl_almacenesTableAdapter.Update(Me.AdmintegralDataSet.tbl_almacenes)

    End Sub


    Private Sub AlmacenComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacenComboBox.SelectedIndexChanged
        Me.idalmacen.Text = Me.AlmacenComboBox.SelectedValue
    End Sub

    Private Sub boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton.Click
        Me.OpenFileDialog.ShowDialog()
        Me.filetxt.Text = Me.OpenFileDialog.FileName
        datos.Clear()
        Cargar(dgv, Me.filetxt.Text, "Hoja1")
        Try
            If datos.Tables(0).Rows.Count > 0 Then
                Me.boton_valida.Enabled = True
            End If
        Catch ex As Exception
            Exit Sub
        End Try

        Try
            colcant = Me.dgv.Columns("contado").Index
            Me.dgv.Columns("contado").DefaultCellStyle.ForeColor = Color.Green
        Catch ex As Exception
            MsgBox("No se encuatra la columna de conteo")
            Me.boton_valida.Enabled = False
        End Try
        Try
            colalmacen = Me.dgv.Columns("almacen").Index
        Catch ex As Exception

        End Try
        Try
            colfecha = Me.dgv.Columns("fecha").Index
            Me.dgv.Columns("fecha").DefaultCellStyle.ForeColor = Color.Green
        Catch ex As Exception
            MsgBox("No se encuatra la columna de fechaconteo")
            Me.boton_valida.Enabled = False
        End Try
        Try
            colid = Me.dgv.Columns("id_producto").Index
            Me.dgv.Columns("id_producto").DefaultCellStyle.ForeColor = Color.Green
        Catch ex As Exception
            MsgBox("No se encuatra la columna de id_producto")
        End Try
        Try
            Me.Fecha_inventario.Value = datos.Tables(0).Rows(0).Item(colfecha)
        Catch ex As Exception

        End Try
        Try
            almacen = datos.Tables(0).Rows(0).Item(colalmacen)
        Catch ex As Exception

        End Try
        lblbarra.Text = colfecha.ToString + "-" + colid.ToString + "-" + colcant.ToString
        Me.Tbl_almacenesBindingSource.Position = Me.Tbl_almacenesBindingSource.Find("id_almacen", almacen)
    End Sub

    Sub Cargar( _
          ByVal dgView As DataGridView, _
          ByVal SLibro As String, _
          ByVal sHoja As String)

        'HDR=YES : Con encabezado
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                           "Data Source=" & SLibro & ";" & _
                           "Extended Properties=""Excel 8.0;HDR=YES"""
        Try
            ' cadena de conexión
            Dim cn As New OleDbConnection(cs)

            If Not System.IO.File.Exists(SLibro) Then
                MsgBox("No se encontró el Libro: " & _
                        SLibro, MsgBoxStyle.Critical, _
                        "Ruta inválida")
                Exit Sub
            End If
            ' se conecta con la hoja sheet 1
            Dim dAdapter As New OleDbDataAdapter("Select * From [" + sHoja + "$]", cs)
            ' agrega los datos
            dAdapter.Fill(datos)

            With dgView
                ' llena el DataGridView
                .DataSource = datos.Tables(0)
            End With
        Catch oMsg As Exception
            MsgBox(oMsg.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub boton_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_aplicar.Click
        Dim ix As MsgBoxResult = MsgBox("Seguro que quiere apliar este inventario?, Modificaran", MsgBoxStyle.YesNo, "")
        If ix = MsgBoxResult.Yes Then
            lblstatus.Text = "Aplicando.." : lblstatus.Visible = True
            aplicar()
        End If
        : lblstatus.Visible = True
        MsgBox("Aplicado!!")
    End Sub

    Private Function validar_hoja() As Boolean
        Dim almacen As Integer, fecha As Date
        almacen = Me.idalmacen.Text : fecha = Me.Fecha_inventario.Value
        validar_hoja = True
        Dim id, cant As Integer
        With datos.Tables(0)
            barra.Maximum = .Rows.Count
            For j As Integer = 0 To .Rows.Count - 1
                barra.Value = j
                dgv.Rows(j).DefaultCellStyle.BackColor = Color.WhiteSmoke
                id = dgv.Rows(j).Cells("id_producto").Value
                dgv.Rows(j).Cells("empaque").Value = fnexistencia(almacen, id, Me.Fecha_inventario.Value)
                If j = 0 Then
                    If IsDate(.Rows(j).Item(colfecha)) = False Then
                        dgv.Rows(j).DefaultCellStyle.BackColor = Color.Red
                        validar_hoja = False
                    End If
                End If
                Try
                    cant = .Rows(j).Item(colcant)
                Catch ex As Exception
                    .Rows(j).Item(colcant) = 0
                End Try
            Next

            If validar_hoja = False Then Exit Function
        End With
        Me.boton_aplicar.Enabled = True
    End Function

    Private Sub boton_valida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles boton_valida.Click
        Dim ok As Boolean = validar_hoja()
        Me.boton_aplicar.Enabled = ok
    End Sub

    Private Sub IgualarFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgualarFechaToolStripMenuItem.Click
        Dim f As String = datos.Tables(0).Rows(0).Item(colfecha).ToString
        Dim ix As MsgBoxResult = MsgBox("Poner esta Fecha " + f + " a toda la Hoja?", MsgBoxStyle.YesNo)
        If ix = MsgBoxResult.Yes Then
            For j As Integer = 0 To datos.Tables(0).Rows.Count - 1
                datos.Tables(0).Rows(j).Item(colfecha) = f
            Next
        End If
    End Sub

    Private Sub CambiarFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarFechaToolStripMenuItem.Click
        Dim f As String = InputBox("Teclee la Fecha que quiere asignar al Inventario", Date.Now)
        For j As Integer = 0 To datos.Tables(0).Rows.Count - 1
            datos.Tables(0).Rows(j).Item(colfecha) = f
        Next
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim cmd As String = "SELECT dbo.tbl_almacenes.Almacen, dbo.Documentos.fechafactura as fecha, dbo.Documentos.Folio, dbo.Documentos.serie, dbo.Documentos.almacen as alma FROM dbo.Documentos INNER JOIN " _
        & " dbo.tbl_almacenes ON dbo.Documentos.almacen = dbo.tbl_almacenes.id_almacen WHERE dbo.Documentos.td = 11 "
        Dim tbl As DataTable = leer_tabla(cmd)
        dgvinv.DataSource = tbl
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim almacen, folio As Integer, serie As String, fecha As Date
        Try
            serie = dgvinv.CurrentRow.Cells("serie").Value
            folio = dgvinv.CurrentRow.Cells("folio").Value
            fecha = dgvinv.CurrentRow.Cells("fecha").Value
            Dim cmd As String = "Delete from documentos where td=11 and folio =" + folio.ToString + " and serie ='" + serie + "'"
            comando(cmd)
            cmd = "delete from inventario_fisico where almacen = " + almacen.ToString + " and fecha = " + fnfecha(fecha)
            comando(cmd)
        Catch ex As Exception
            MsgBox("Error :" + ex.Message)
        End Try

    End Sub

    Private Sub dgvinv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvinv.CellDoubleClick
        Dim almacen As Integer, fecha As Date
        almacen = dgvinv.CurrentRow.Cells("alma").Value
        fecha = dgvinv.CurrentRow.Cells("fecha").Value
        Me.rpt_inventario_fisicoTableAdapter.FillBy_Alma_fecha(Me.AdmintegralDataSet.rpt_inventario_fisico, fecha, almacen)
        Me.ReportViewer5.Visible = False
        Me.ReportViewer1.Visible = True
        Me.ReportViewer1.RefreshReport()
    End Sub ' reporte de inventarios refresca la informacion

    Private Sub boton_imprimir_Existencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_imprimir_Existencias.Click
        Dim cmd As String, al As Integer
        al = Me.AlmacenComboBox.SelectedValue
        cmd = "SELECT dbo.productos.id_Directorio, dbo.Unidades_productos.Codigo, dbo.productos.id_Producto AS Id, dbo.productos.id_Grupo AS Gp, " _
        & " dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, Unidades_productos_1.Unidad AS [Und.Base], " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) AS Existencia, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Unidad AS [Und.comp], " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) / dbo.Unidades_productos.unidades AS Ecompra, Unidades_productos_1.costo, " _
        & " Unidades_productos_1.venta, dbo.movimientos.almacen, MIN(dbo.productos_stoks.stock) AS stock, " _
        & "MIN(dbo.productos_stoks.stock) - SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) AS dif , dbo.Grupos.Grupo " _
        & "FROM dbo.productos INNER JOIN dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND  " _
        & "  dbo.productos.und_compra = dbo.Unidades_productos.id_unidad INNER JOIN " _
        & "dbo.movimientos ON dbo.productos.id_Producto = dbo.movimientos.id_prodcuto INNER JOIN " _
        & "dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
        & "dbo.productos.und_detalle = Unidades_productos_1.id_unidad INNER JOIN " _
        & "dbo.productos_stoks ON dbo.movimientos.id_prodcuto = dbo.productos_stoks.id_producto AND dbo.movimientos.almacen = dbo.productos_stoks.id_almacen  INNER JOIN dbo.Grupos ON dbo.productos.id_Grupo = dbo.Grupos.id_grupos " _
        & "  WHERE (dbo.movimientos.n <> 0) AND dbo.productos.id_Grupo<>100 and dbo.movimientos.fecha <  " & fnfecha(Me.fecha_existencia.Value) + " " _
        & " GROUP BY dbo.productos.id_Producto, dbo.productos.id_Grupo, dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, " _
        & " dbo.productos.id_Directorio, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Codigo, Unidades_productos_1.costo, Unidades_productos_1.venta, " _
        & " dbo.Unidades_productos.Unidad, Unidades_productos_1.Unidad, dbo.movimientos.almacen, dbo.Grupos.Grupo " _
        & " HAVING  (SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) <> 0) and dbo.movimientos.almacen = " + al.ToString _
        & " [filtro]" _
        & " ORDER BY Gp, dbo.productos.Descripcion "

        If Radiotodos.Checked = True Then
            cmd = cmd.Replace("[filtro]", "")
        End If

        If Radiopositivos.Checked = True Then
            cmd = cmd.Replace("[filtro]", " and SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n)>0 ")
        End If

        If Radionegavtivos.Checked = True Then
            cmd = cmd.Replace("[filtro]", " and SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n)<0 ")
        End If




        Clipboard.SetText(cmd)

        Dim tbl As New DataTable
        tbl = leer_tabla(cmd)
        'redefine dataset en el reporte
        Try
            Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)
        Catch ex As Exception

        End Try
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer2.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer2.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_existencias_x_almacen' Puede moverla o quitarla según sea necesario.
        'Me.sql_existencias_x_almacenTableAdapter.FillBy_Almacen(Me.AdmintegralDataSet.sql_existencias_x_almacen, al)
        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Reporte de Existencias al " + Format(Me.fecha_existencia.Value, "d"), False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("Almacen", Me.AlmacenComboBox.Text, False)
        rp(2) = rptlogo
        Me.ReportViewer2.Visible = True
        Me.ReportViewerresume.Visible = False
        Me.ReportViewer2.LocalReport.SetParameters(rp)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub boton_preparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_preparar.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String = "Select * from paths where id = 7"
        Dim tb As DataTable = leer_tabla(cmd)
        Dim path As String = Trim(tb.Rows(0).Item(2).ToString)
        Me.filenametxt.Text = path + "inv_" + Trim(Me.combo_almacen.Text) + "_" + Format(Me.fecha_conteo.Value, "ddMMMyyyy") + ".xls"
        lblfilename.Text = Me.filenametxt.Text
        cargar_grupos()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub cargar_grupos()
        Dim alma As String = Me.combo_almacen.SelectedValue
        Dim g() As String
        g = selecgrupos.Text.Split(",")
        If g.GetLength(0) = 0 Then Exit Sub
        Dim cmd As String
        cmd = "SELECT  " + alma + " as Almacen, '" + Me.fecha_conteo.Value.ToShortDateString + "' as Fecha, "
        cmd += "dbo.productos.id_Producto, dbo.Unidades_productos.Codigo AS [Codigo Pz], Unidades_productos_1.Codigo AS [Codigo Exh], " _
        & " dbo.productos.id_Grupo,dbo.Grupos.Grupo, dbo.productos.Descripcion, Unidades_productos_2.factor AS Empaque, ' ' as Contado " _
        & " FROM         dbo.productos INNER JOIN " _
                      & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND " _
                      & "dbo.productos.und_detalle = dbo.Unidades_productos.id_unidad INNER JOIN " _
                      & "dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
                      & "dbo.productos.und_venta = Unidades_productos_1.id_unidad INNER JOIN " _
                      & "dbo.Unidades_productos AS Unidades_productos_2 ON dbo.productos.id_Producto = Unidades_productos_2.id_producto AND " _
                      & "dbo.productos.und_compra = Unidades_productos_2.id_unidad " _
                      & " INNER JOIN dbo.Grupos ON dbo.productos.id_Grupo = dbo.Grupos.id_grupos " _
                      & "GROUP BY dbo.productos.id_Producto, dbo.productos.Descripcion, dbo.productos.und_venta, dbo.productos.und_compra, dbo.productos.und_detalle, " _
                      & " Unidades_productos_2.factor, dbo.productos.id_Directorio, dbo.productos.id_Grupo, Unidades_productos_1.Codigo, dbo.productos.precio_unico, " _
                      & "dbo.Unidades_productos.Codigo,  dbo.Grupos.Grupo "
        cmd = cmd + " HAVING  dbo.productos.id_Grupo = " + g(0).ToString

        For j As Integer = 1 To g.GetLength(0) - 1
            If g(j).Length > 0 Then cmd += " or dbo.productos.id_grupo = " + g(j).ToString
        Next
        cmd += " ORDER BY dbo.productos.id_Grupo, dbo.productos.Descripcion"
        tbl_excel = leer_tabla(cmd)
        Me.Text = "Existen " + tbl_excel.Rows.Count.ToString + " Registros en la Tabla"
        tbl_excel.Columns(3).DataType = System.Type.GetType("System.String")
        tbl_excel.Columns(4).DataType = System.Type.GetType("System.String")
        ' Me.ReportViewer3.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("Tabla", tbl_excel)
        ReportViewer3.LocalReport.DataSources.Add(datasource)

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter

        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("tienda", Me.combo_almacen.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Me.fecha_conteo.Value.ToLongDateString, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("archivo", Me.filenametxt.Text, False)
        Me.ReportViewer3.LocalReport.SetParameters(rp)


        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub boton_guardar_hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar_hoja.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        tbl_excel.TableName = "Tabla"
        'tbl_excel.WriteXmlSchema(Me.filenametxt.Text, True)
        tbl_excel.WriteXml(Me.filenametxt.Text)
        Windows.Forms.Cursor.Current = Cursors.Default
        MsgBox("Archivo Guardado", MsgBoxStyle.Information)

    End Sub

    Private Sub selecgrupos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selecgrupos.TextChanged
        Me.selecgrupos.Text = Me.selecgrupos.Text.Replace(".", ",")
        If selecgrupos.TextLength > 0 Then
            Me.boton_preparar.Enabled = True
        Else
            Me.boton_preparar.Enabled = False
        End If
    End Sub

    Private Sub aplicar()
        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim f, id, cant, almacen As Integer
        almacen = Me.AlmacenComboBox.SelectedValue
        Try
            f = afolio.siguiente(11, almacen.ToString)
        Catch ex As Exception
            f = 1
            'MsgBox(ex.Message)
        End Try
        lblstatus.Text = "Guardando Documento"
        Dim d As New Mi_Documento
        d.a00_id_doc = 11
        d.a01_Folio = f
        d.a02_serie = almacen
        d.a03_Almacen = almacen
        d.a06_fecha_registro = Me.Fecha_inventario.Value
        d.a09_fecha_factura = Me.Fecha_inventario.Value
        d.a10_fecha_surtido = Me.Fecha_inventario.Value
        d.a11_fecha_vence = Me.Fecha_inventario.Value
        Dim result As Boolean = Agregar_documento(d)

        lblstatus.Text = "Documento Guardado"
        Dim adapm As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim producto As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Dim invfisico As New admintegralDataSetTableAdapters.inventario_fisicoTableAdapter
        Dim costou As Single
        With datos.Tables(0)
            For j As Integer = 0 To .Rows.Count - 1
                barra.Value = j : id = .Rows(j).Item(colid) : cant = .Rows(j).Item(colcant)
                Try
                    costou = producto.GetDataByid(id).Rows(0).Item("costo")
                Catch ex As Exception
                    costou = 0
                End Try

                Try
                    invfisico.Insert(id, almacen, Me.Fecha_inventario.Value, cant, fnexistencia(almacen, id, Me.Fecha_inventario.Value), costou)
                Catch ex As Exception
                    MsgBox("Error : " + ex.Message)
                End Try
                Try
                    adapm.anula_anteriores_al_inventario(almacen, Me.Fecha_inventario.Value, id)
                Catch ex As Exception
                    MsgBox("Error al actualizar Existencias" + ex.Message)
                End Try

                'guarda la existenci on fecha de ayer, ya que es la inicial de Hoy
                Try
                    adapm.Insert(almacen, 11, f, almacen, j, Me.Fecha_inventario.Value.AddDays(-1), id, 1, 0, 1, cant, costou, 0, 0, 0, 0, 0, 0, 0, 0, cant, costou, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, Now.Date, 0, 0, 0, 0, 0)
                Catch ex As Exception
                    MsgBox("Error al guardar Inventario)" + ex.Message)
                End Try

                Me.Refresh()
            Next j
        End With
    End Sub

    Private Sub Boton_refresh_stoks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_refresh_stoks.Click
        Me.Boton_refresh_stoks.Visible = False
        lblstat.Text = "Verificando Nuevos"
        Me.Refresh()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String
        cmd = " INSERT INTO productos_stoks (stock, promedio, id_almacen, id_producto) SELECT 12 AS stok, 0 AS promedio, sys_stoks.id_almacen AS Expr1, sys_stoks.id_Producto AS Expr2 "
        cmd += " FROM productos_stoks AS productos_stoks_1 RIGHT OUTER JOIN "
        cmd += " sys_stoks ON productos_stoks_1.id_almacen = sys_stoks.id_almacen AND productos_stoks_1.id_producto = sys_stoks.id_Producto "
        cmd += " WHERE productos_stoks_1.id_producto IS NULL AND productos_stoks_1.id_almacen IS NULL "
        Dim ok As Boolean = comando(cmd)
        lblstat.Text = "Calculando Promedios"
        Me.Refresh()
        cmd = "UPDATE integra.dbo.productos_stoks SET [promedio] = dbo.stok_ventas_promedio.promedio FROM dbo.productos_stoks INNER JOIN "
        cmd += " dbo.stok_ventas_promedio ON dbo.productos_stoks.id_producto = dbo.stok_ventas_promedio.id_prodcuto AND dbo.productos_stoks.id_almacen = dbo.stok_ventas_promedio.almacen "
        Dim ok1 As Boolean = comando(cmd)
        lblstat.Text = "Terminado..."
        Windows.Forms.Cursor.Current = Cursors.Default
        lblstat.Text = ""
        Me.Boton_refresh_stoks.Visible = True
    End Sub

    Private Sub AlmacenComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacenComboBox2.SelectedIndexChanged

    End Sub

  

    Private Sub combogrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combogrupo.SelectedIndexChanged
        idgrupo.Text = Me.combogrupo.SelectedValue
    End Sub

    Private Sub idgrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idgrupo.TextChanged
        Dim filtro As String = "id_grupos = " + idgrupo.Text
        Try
            dbstock.Filter = filtro
        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub boton_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeStockYExistToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String
        cmd = "SELECT     TOP 100 PERCENT dbo.productos_stoks.id_almacen, dbo.Grupos.id_grupos, dbo.Grupos.Grupo, dbo.productos.id_Producto, dbo.productos.Descripcion, "
        cmd += "dbo.movimientos.almacen, dbo.productos_stoks.stock, dbo.productos_stoks.promedio, SUM(ISNULL(dbo.movimientos.ub_cantidad * dbo.movimientos.n, 0)) AS Existencia "

        cmd += " FROM dbo.movimientos RIGHT OUTER JOIN dbo.productos_stoks INNER JOIN dbo.productos ON dbo.productos_stoks.id_producto = dbo.productos.id_Producto INNER JOIN "
        cmd += " dbo.Grupos ON dbo.productos.id_Grupo = dbo.Grupos.id_grupos ON dbo.movimientos.almacen = dbo.productos_stoks.id_almacen AND "
        cmd += " dbo.movimientos.id_prodcuto = dbo.productos_stoks.id_producto "


        cmd += " GROUP BY dbo.movimientos.almacen, dbo.productos_stoks.id_almacen, dbo.Grupos.id_grupos, dbo.Grupos.Grupo, dbo.productos.Descripcion, dbo.productos_stoks.stock, "
        cmd += "dbo.productos_stoks.promedio, dbo.productos.id_Producto"

        cmd += " HAVING (SUM(ISNULL(dbo.movimientos.ub_cantidad * dbo.movimientos.n, 0)) IS NOT NULL) AND (dbo.movimientos.almacen IS NOT NULL) "
        cmd += " and dbo.productos_stoks.id_almacen = " + Me.AlmacenComboBox2.SelectedValue.ToString
        cmd += " ORDER BY dbo.Grupos.Grupo, dbo.productos.Descripcion "
        tblstock = leer_tabla(cmd)
        'dgvstock.DataSource = tblstock
        dgvstock.Visible = False
        Me.ReportViewer4.Visible = True
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tblstock", tblstock)
        ReportViewer4.LocalReport.DataSources.Add(datasource)
        ReportViewer4.RefreshReport()
        Windows.Forms.Cursor.Current = Cursors.Default

    End Sub

    Private Sub SugerenciaDeSurtidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SugerenciaDeSurtidoToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String
        cmd = "SELECT     TOP 100 PERCENT dbo.productos_stoks.id_almacen, dbo.Grupos.id_grupos, dbo.Grupos.Grupo, dbo.productos.id_Producto, dbo.productos.Descripcion, "
        cmd += "dbo.movimientos.almacen, dbo.productos_stoks.stock, dbo.productos_stoks.promedio, SUM(ISNULL(dbo.movimientos.ub_cantidad * dbo.movimientos.n, 0)) AS Existencia "

        cmd += " FROM dbo.movimientos RIGHT OUTER JOIN dbo.productos_stoks INNER JOIN dbo.productos ON dbo.productos_stoks.id_producto = dbo.productos.id_Producto INNER JOIN "
        cmd += " dbo.Grupos ON dbo.productos.id_Grupo = dbo.Grupos.id_grupos ON dbo.movimientos.almacen = dbo.productos_stoks.id_almacen AND "
        cmd += " dbo.movimientos.id_prodcuto = dbo.productos_stoks.id_producto "


        cmd += " GROUP BY dbo.movimientos.almacen, dbo.productos_stoks.id_almacen, dbo.Grupos.id_grupos, dbo.Grupos.Grupo, dbo.productos.Descripcion, dbo.productos_stoks.stock, "
        cmd += "dbo.productos_stoks.promedio, dbo.productos.id_Producto"

        cmd += " HAVING (SUM(ISNULL(dbo.movimientos.ub_cantidad * dbo.movimientos.n, 0)) IS NOT NULL) AND (dbo.movimientos.almacen IS NOT NULL) "
        cmd += " AND (SUM(ISNULL(dbo.movimientos.ub_cantidad * dbo.movimientos.n, 0)) < dbo.productos_stoks.stock) "
        cmd += " and dbo.productos_stoks.id_almacen= " + Me.AlmacenComboBox2.SelectedValue.ToString
        cmd += " ORDER BY dbo.Grupos.Grupo, dbo.productos.Descripcion "
        tblstock = leer_tabla(cmd)
        'dgvstock.DataSource = tblstock
        dgvstock.Visible = False
        Me.ReportViewer4.Visible = True

        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tblstock", tblstock)
        ReportViewer4.LocalReport.DataSources.Add(datasource)
        ReportViewer4.RefreshReport()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mife, mife1 As Date
        mife1 = "01/01/2011"
        mife = Me.fecha_existencia.Value.AddDays(+1)
        Dim cmd As String
        cmd = "SELECT dbo.productos.id_Directorio, dbo.Unidades_productos.Codigo, dbo.productos.id_Producto AS Id, dbo.productos.id_Grupo AS Gp, " _
        & " dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, Unidades_productos_1.Unidad AS [Und.Base], " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) AS Existencia, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Unidad AS [Und.comp], " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) / dbo.Unidades_productos.unidades AS Ecompra, Unidades_productos_1.costo, " _
        & " Unidades_productos_1.venta, dbo.movimientos.almacen, dbo.tbl_almacenes.Almacen AS sucursal FROM dbo.productos INNER JOIN " _
        & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND " _
        & " dbo.productos.und_compra = dbo.Unidades_productos.id_unidad INNER JOIN " _
        & " dbo.movimientos ON dbo.productos.id_Producto = dbo.movimientos.id_prodcuto INNER JOIN " _
        & " dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
        & " dbo.productos.und_detalle = Unidades_productos_1.id_unidad  INNER JOIN dbo.tbl_almacenes ON dbo.movimientos.almacen = dbo.tbl_almacenes.id_almacen " _
        & "  WHERE  dbo.movimientos.fecha >" & fnfecha(mife1) + " and  dbo.movimientos.fecha <  " & fnfecha(mife) + " " _
        & " GROUP BY dbo.productos.id_Producto, dbo.productos.id_Grupo, dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, " _
        & " dbo.productos.id_Directorio, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Codigo, Unidades_productos_1.costo, Unidades_productos_1.venta, " _
        & " dbo.Unidades_productos.Unidad, Unidades_productos_1.Unidad, dbo.movimientos.almacen, dbo.tbl_almacenes.Almacen " _
        & " ORDER BY Gp, dbo.productos.Descripcion "
        Dim tbl As New DataTable
        tbl = leer_tabla(cmd)
        'redefine dataset en el reporte
        Me.ReportViewerresume.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("admintegralDataSet_sql_existencias_x_almacen", tbl)
        Me.ReportViewerresume.LocalReport.DataSources.Add(datasource)

        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_existencias_x_almacen' Puede moverla o quitarla según sea necesario.
        'Me.sql_existencias_x_almacenTableAdapter.FillBy_Almacen(Me.AdmintegralDataSet.sql_existencias_x_almacen, al)
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Reporte de Existencias al " + Format(Me.fecha_existencia.Value, "d"), False)

        Me.ReportViewer2.Visible = False
        Me.ReportViewerresume.Visible = True

        Me.ReportViewerresume.LocalReport.SetParameters(rp)
        ReportViewerresume.RefreshReport()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As String, al As Integer
        al = Me.AlmacenComboBox.SelectedValue
        cmd = "SELECT dbo.productos.id_Directorio, dbo.Unidades_productos.Codigo, dbo.productos.id_Producto AS Id, dbo.productos.id_Grupo AS Gp, " _
        & " dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, Unidades_productos_1.Unidad AS [Und.Base], " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) AS Existencia, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Unidad AS [Und.comp], " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) / dbo.Unidades_productos.unidades AS Ecompra, Unidades_productos_1.costo, " _
        & " Unidades_productos_1.venta, dbo.movimientos.almacen FROM dbo.productos INNER JOIN " _
        & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND " _
        & " dbo.productos.und_compra = dbo.Unidades_productos.id_unidad INNER JOIN " _
        & " dbo.movimientos ON dbo.productos.id_Producto = dbo.movimientos.id_prodcuto INNER JOIN " _
        & " dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
        & " dbo.productos.und_detalle = Unidades_productos_1.id_unidad " _
        & "  WHERE  dbo.productos.id_Grupo<>150 and dbo.movimientos.fecha <  " & fnfecha(Me.fecha_existencia.Value) + " " _
        & " GROUP BY dbo.productos.id_Producto, dbo.productos.id_Grupo, dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, " _
        & " dbo.productos.id_Directorio, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Codigo, Unidades_productos_1.costo, Unidades_productos_1.venta, " _
        & " dbo.Unidades_productos.Unidad, Unidades_productos_1.Unidad, dbo.movimientos.almacen " _
        & " HAVING  dbo.movimientos.almacen = " + al.ToString + "and  SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n)<0" _
        & " ORDER BY Gp, dbo.productos.Descripcion "
        Dim tbl As New DataTable
        tbl = leer_tabla(cmd)
        'redefine dataset en el reporte
        Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("admintegralDataSet_sql_existencias_x_almacen", tbl)
        ReportViewer2.LocalReport.DataSources.Add(datasource)

        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_existencias_x_almacen' Puede moverla o quitarla según sea necesario.
        'Me.sql_existencias_x_almacenTableAdapter.FillBy_Almacen(Me.AdmintegralDataSet.sql_existencias_x_almacen, al)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Reporte de Existencias al " + Format(Me.fecha_existencia.Value, "d"), False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("Almacen", Me.AlmacenComboBox.Text, False)
        Me.ReportViewer2.Visible = True
        Me.ReportViewerresume.Visible = False
        Me.ReportViewer2.LocalReport.SetParameters(rp)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.boton_hoja_prov.Enabled = False
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        idprov.Text = gprov.id
        nombreprov.Text = gprov.nombre
        Me.boton_hoja_prov.Enabled = True
    End Sub 'Buscar Proveedor

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_hoja_prov.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String = "Select * from paths where id = 7"
        Dim tb As DataTable = leer_tabla(cmd)
        Dim path As String = Trim(tb.Rows(0).Item(2).ToString)
        Me.filenametxt.Text = path + "inv_" + Trim(Me.combo_almacen.Text) + "_" + Format(Me.fecha_conteo.Value, "ddMMMyyyy") + ".xls"
        lblfilename.Text = Me.filenametxt.Text
        cargar_provedor()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub ' Prepara ja por proveedorho


    Private Sub cargar_provedor()
        Dim alma As String = Me.combo_almacen.SelectedValue
        Dim g() As String
        g = selecgrupos.Text.Split(",")
        If g.GetLength(0) = 0 Then Exit Sub
        Dim cmd As String
        cmd = "SELECT  " + alma + " as Almacen, '" + Me.fecha_conteo.Value.ToShortDateString + "' as Fecha, "
        cmd += "dbo.productos.id_Producto, dbo.Unidades_productos.Codigo AS [Codigo Pz], Unidades_productos_1.Codigo AS [Codigo Exh], " _
        & " dbo.productos.id_Grupo,dbo.Grupos.Grupo, dbo.productos.Descripcion, Unidades_productos_2.factor AS Empaque, ' ' as Contado " _
        & " FROM         dbo.productos INNER JOIN " _
                      & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND " _
                      & "dbo.productos.und_detalle = dbo.Unidades_productos.id_unidad INNER JOIN " _
                      & "dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
                      & "dbo.productos.und_venta = Unidades_productos_1.id_unidad INNER JOIN " _
                      & "dbo.Unidades_productos AS Unidades_productos_2 ON dbo.productos.id_Producto = Unidades_productos_2.id_producto AND " _
                      & "dbo.productos.und_compra = Unidades_productos_2.id_unidad " _
                      & " INNER JOIN dbo.Grupos ON dbo.productos.id_Grupo = dbo.Grupos.id_grupos " _
                      & "GROUP BY dbo.productos.id_Producto, dbo.productos.Descripcion, dbo.productos.und_venta, dbo.productos.und_compra, dbo.productos.und_detalle, " _
                      & " Unidades_productos_2.factor, dbo.productos.id_Directorio, dbo.productos.id_Grupo, Unidades_productos_1.Codigo, dbo.productos.precio_unico, " _
                      & "dbo.Unidades_productos.Codigo,  dbo.Grupos.Grupo " _
                      & " HAVING dbo.productos.id_Directorio = " + idprov.Text
        cmd += " ORDER BY dbo.productos.id_Grupo, dbo.productos.Descripcion"
        tbl_excel = leer_tabla(cmd)
        Me.Text = "Existen " + tbl_excel.Rows.Count.ToString + " Registros en la Tabla"
        tbl_excel.Columns(3).DataType = System.Type.GetType("System.String")
        tbl_excel.Columns(4).DataType = System.Type.GetType("System.String")
        Try
            Me.ReportViewer3.LocalReport.DataSources.RemoveAt(0)
        Catch ex As Exception

        End Try


        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("Tabla", tbl_excel)
        ReportViewer3.LocalReport.DataSources.Add(datasource)

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter

        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("tienda", Me.combo_almacen.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Me.fecha_conteo.Value.ToLongDateString, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("archivo", Me.filenametxt.Text, False)
        Me.ReportViewer3.LocalReport.SetParameters(rp)


        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String = "Select * from paths where id = 7"
        Dim tb As DataTable = leer_tabla(cmd)
        Dim path As String = Trim(tb.Rows(0).Item(2).ToString)
        Me.filenametxt.Text = path + "inv_" + Trim(Me.combo_almacen.Text) + "_" + Format(Me.fecha_conteo.Value, "ddMMMyyyy") + ".xls"
        lblfilename.Text = Me.filenametxt.Text
        cargar_todo()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub cargar_todo()
        Dim alma As String = Me.combo_almacen.SelectedValue
        Dim g() As String
        g = selecgrupos.Text.Split(",")
        If g.GetLength(0) = 0 Then Exit Sub
        Dim cmd As String
        cmd = "SELECT  " + alma + " as Almacen, '" + Me.fecha_conteo.Value.ToShortDateString + "' as Fecha, "
        cmd += "dbo.productos.id_Producto, dbo.Unidades_productos.Codigo AS [Codigo Pz], Unidades_productos_1.Codigo AS [Codigo Exh], " _
        & " dbo.productos.id_Grupo,dbo.Grupos.Grupo, dbo.productos.Descripcion, Unidades_productos_2.factor AS Empaque, ' ' as Contado " _
        & " FROM         dbo.productos INNER JOIN " _
                      & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND " _
                      & "dbo.productos.und_detalle = dbo.Unidades_productos.id_unidad INNER JOIN " _
                      & "dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
                      & "dbo.productos.und_venta = Unidades_productos_1.id_unidad INNER JOIN " _
                      & "dbo.Unidades_productos AS Unidades_productos_2 ON dbo.productos.id_Producto = Unidades_productos_2.id_producto AND " _
                      & "dbo.productos.und_compra = Unidades_productos_2.id_unidad " _
                      & " INNER JOIN dbo.Grupos ON dbo.productos.id_Grupo = dbo.Grupos.id_grupos " _
                      & "GROUP BY dbo.productos.id_Producto, dbo.productos.Descripcion, dbo.productos.und_venta, dbo.productos.und_compra, dbo.productos.und_detalle, " _
                      & " Unidades_productos_2.factor, dbo.productos.id_Directorio, dbo.productos.id_Grupo, Unidades_productos_1.Codigo, dbo.productos.precio_unico, " _
                      & "dbo.Unidades_productos.Codigo,  dbo.Grupos.Grupo "
        cmd = cmd + " HAVING  dbo.productos.id_Grupo > 0 "

        cmd += " ORDER BY dbo.productos.id_Grupo, dbo.productos.Descripcion"
        tbl_excel = leer_tabla(cmd)
        Me.Text = "Existen " + tbl_excel.Rows.Count.ToString + " Registros en la Tabla"
        tbl_excel.Columns(3).DataType = System.Type.GetType("System.String")
        tbl_excel.Columns(4).DataType = System.Type.GetType("System.String")
        Try
            Me.ReportViewer3.LocalReport.DataSources.RemoveAt(0)
        Catch ex As Exception

        End Try

        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("Tabla", tbl_excel)
        ReportViewer3.LocalReport.DataSources.Add(datasource)
        ReportViewer3.LocalReport.EnableExternalImages = True

        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter

        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("tienda", Me.combo_almacen.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Me.fecha_conteo.Value.ToLongDateString, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("archivo", Me.filenametxt.Text, False)
        rp(3) = rptlogo
        Me.ReportViewer3.LocalReport.SetParameters(rp)


        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim filtro As String = txtexcluir.Text

        Dim grupos As String() = filtro.Split(",")
        Dim grupo As String, mng As Integer = 0
        filtro = ""
        For Each grupo In grupos
            mng += 1
            filtro += " and dbo.productos.id_Grupo <> " + grupo
        Next

        Dim cmd As String, al As Integer
        al = Me.AlmacenComboBox.SelectedValue
        cmd = "SELECT '" + Me.fecha_existencia.Value.ToShortDateString + "' as fecha, dbo.productos.id_Directorio as prov , dbo.Unidades_productos.Codigo, dbo.productos.id_Producto AS Id, dbo.productos.id_Grupo AS Gp, " _
      & " RTRIM(dbo.productos.Descripcion) as Descripcion, Unidades_productos_1.Unidad AS [Und.Base], " _
      & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) AS Existencia, dbo.Unidades_productos.unidades as emp, " _
      & " Unidades_productos_1.costo, " _
      & " Unidades_productos_1.venta, dbo.movimientos.almacen,0 as contado FROM dbo.productos INNER JOIN " _
      & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND " _
      & " dbo.productos.und_detalle = dbo.Unidades_productos.id_unidad INNER JOIN " _
      & " dbo.movimientos ON dbo.productos.id_Producto = dbo.movimientos.id_prodcuto INNER JOIN " _
      & " dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
      & " dbo.productos.und_detalle = Unidades_productos_1.id_unidad " _
      & "  WHERE dbo.movimientos.fecha <  " & fnfecha(Me.fecha_existencia.Value) + " " + filtro + " " _
      & " GROUP BY dbo.productos.id_Producto, dbo.productos.id_Grupo, dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, " _
      & " dbo.productos.id_Directorio, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Codigo, Unidades_productos_1.costo, Unidades_productos_1.venta, " _
      & " dbo.Unidades_productos.Unidad, Unidades_productos_1.Unidad, dbo.movimientos.almacen " _
      & " HAVING  dbo.movimientos.almacen = " + al.ToString _
      & " ORDER BY Gp, dbo.productos.Descripcion "
        Dim tbl As New DataTable
        tbl = leer_tabla(cmd)
        tbl.TableName = "Inventario"
        tbl.WriteXml(Me.filename.Text) : MsgBox("guardado")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim ff As New SaveFileDialog
        ff.Filter = "Archivos xml|*.xml"
        ff.AddExtension = True
        ff.ShowDialog()
        Me.filename.Text = ff.FileName

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

        Dim almacen As Integer, fecha As Date
        almacen = dgvinv.CurrentRow.Cells("alma").Value
        fecha = dgvinv.CurrentRow.Cells("fecha").Value
        Me.rpt_inventario_fisicoTableAdapter.FillBy_Alma_fecha(Me.AdmintegralDataSet.rpt_inventario_fisico, fecha, almacen)
        Me.ReportViewer5.Visible = True
        Me.ReportViewer1.Visible = False
        Me.ReportViewer5.RefreshReport()
    End Sub

    Private Sub btn_resumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_resumen.Click
        My.Forms.resumen_existencias.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bta_abrir_inv.Click
      
        Dim filename As String
        Dim ff As New OpenFileDialog
        ff.ShowDialog()
        filename = ff.FileName

        tbl.ReadXmlSchema(filename)
        tbl.Clear()

        If tbl.Columns.Count = 15 Then
            tbl.Columns.RemoveAt(14)
            tbl.Columns.RemoveAt(13)
        End If

        tbl.Columns("Existencia").DataType = System.Type.GetType("System.Decimal")
        tbl.Columns("costo").DataType = System.Type.GetType("System.Decimal")
        tbl.Columns("contado").DataType = System.Type.GetType("System.Int32")

        tbl.ReadXml(filename)
        Try
            Dim column As New DataColumn

            column = New DataColumn("dif", System.Type.GetType("System.Int32"), "contado-existencia")
            column.Caption = "dif" : column.AllowDBNull = False
            column.Unique = False : tbl.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

            column = New DataColumn("importe", System.Type.GetType("System.Decimal"), "dif*costo")
            column.Caption = "importe" : column.DefaultValue = 0
            column.Unique = False : tbl.Columns.Add(column)   ' Add the Column to the DataColumnCollection.
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        bs.DataSource = ds1.Tables("inventario")
        Me.dgvcontado.DataSource = bs
        Me.fileinvtxt.Text = filename

        alma.Text = Me.dgvcontado.Rows(0).Cells("almacen").Value
        Me.fconteo.Text = Me.dgvcontado.Rows(0).Cells("fecha").Value
        Dim aadap As New admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
        Me.kalma.Text = aadap.GetDataByid(alma.Text).Rows(0).Item("almacen")
        If tbl.Rows.Count > 0 Then Me.btn_aplica.Enabled = True Else Me.btn_aplica.Enabled = False
    End Sub

    Private Sub aplicar_new()
        'aolica inventario
        '=======================================

        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim f, id, cant, almacen As Integer
        almacen = Me.alma.Text
        Try
            f = afolio.siguiente(11, almacen.ToString)
        Catch ex As Exception
            f = 1
            'MsgBox(ex.Message)
        End Try
        Me.kfolio.Text = f
        lblstatus.Text = "Guardando Documento"
        Dim d As New Mi_Documento
        d.a00_id_doc = 11
        d.a01_Folio = f
        d.a02_serie = almacen
        d.a03_Almacen = almacen
        d.a06_fecha_registro = CDate(Me.fconteo.Text).ToShortDateString
        d.a09_fecha_factura = CDate(Me.fconteo.Text).ToShortDateString
        d.a10_fecha_surtido = CDate(Me.fconteo.Text).ToShortDateString
        d.a11_fecha_vence = CDate(Me.fconteo.Text).ToShortDateString
        Dim result As Boolean = Agregar_documento(d)

        lblstatus.Text = "Documento Guardado"
        Dim adapm As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim producto As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Dim invfisico As New admintegralDataSetTableAdapters.inventario_fisicoTableAdapter
        Dim costou As Single
        With tbl
            For j As Integer = 0 To .Rows.Count - 1
                Me.Text = "Reg. " + j.ToString + " de " + .Rows.Count.ToString
                id = .Rows(j).Item("id") : cant = .Rows(j).Item("contado")
                Try
                    costou = producto.GetDataByid(id).Rows(0).Item("costo")
                Catch ex As Exception
                    costou = 0
                End Try

                Try
                    invfisico.Insert(id, almacen, CDate(Me.fconteo.Text).ToShortDateString, cant, fnexistencia(almacen, id, CDate(Me.fconteo.Text).ToShortDateString), costou)
                Catch ex As Exception
                    MsgBox("Error : " + ex.Message)
                End Try
                Try
                    adapm.anula_anteriores_al_inventario(almacen, CDate(Me.fconteo.Text).ToShortDateString, id)
                Catch ex As Exception
                    MsgBox("Error al actualizar Existencias" + ex.Message)
                End Try

                'guarda la existenci on fecha de ayer, ya que es la inicial de Hoy
                Try
                    adapm.Insert(almacen, 11, f, almacen, j, CDate(Me.fconteo.Text).AddDays(-1), id, 1, 0, 1, cant, costou, 0, 0, 0, 0, 0, 0, 0, 0, cant, costou, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, Now.Date, 0, 0, 0, 0, 0)
                Catch ex As Exception
                    MsgBox("Error al guardar Inventario)" + ex.Message)
                End Try

                Me.Refresh()
            Next j
        End With
        MsgBox("Terminado!!")
    End Sub

    Private Sub btn_aplica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aplica.Click
        Dim ix As MsgBoxResult = MsgBox("Seguro que quiere aplicar el inventario", MsgBoxStyle.YesNo, "Aplicar Invenario")
        If ix = MsgBoxResult.No Then Exit Sub
        lblfolio.Visible = True
        kfolio.Visible = True
        aplicar_new()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub dgvstock_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvstock.CellEndEdit
        Dim id, alma, stk As Integer
        With Me.dgvstock.CurrentRow
            alma = .Cells(0).Value
            id = .Cells(3).Value
            stk = .Cells(6).Value
        End With
        Dim madap As New reporteDataSetTableAdapters.productos_stoksTableAdapter
        madap.actualizar_stock(stk, id, alma)
        madap.Connection.Close()
        madap.Dispose()
    End Sub

    Private Sub filtrar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrar.TextChanged
        If filtrar.TextLength = 0 Then
            dbstock.Filter = ""
        Else
            dbstock.Filter = "descripcion like '%" + filtrar.Text + "%'"

        End If
    End Sub

    Private Sub Button9_Click_1(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim cmd As String, al As Integer
        al = Me.AlmacenComboBox.SelectedValue
        cmd = "SELECT dbo.productos.id_Directorio, dbo.Unidades_productos.Codigo, dbo.productos.id_Producto AS Id, dbo.productos.id_Grupo AS Gp, " _
        & " dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, Unidades_productos_1.Unidad AS [Und.Base], " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) AS Existencia, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Unidad AS [Und.comp], " _
        & " SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) / dbo.Unidades_productos.unidades AS Ecompra, Unidades_productos_1.costo, " _
        & " Unidades_productos_1.venta, dbo.movimientos.almacen, MIN(dbo.productos_stoks.stock) AS stock, " _
        & "MIN(dbo.productos_stoks.stock) - SUM(dbo.movimientos.ub_cantidad * dbo.movimientos.n) AS dif , dbo.Grupos.Grupo " _
        & "FROM         dbo.productos INNER JOIN " _
        & "            dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto AND  " _
        & "  dbo.productos.und_compra = dbo.Unidades_productos.id_unidad INNER JOIN " _
        & "dbo.movimientos ON dbo.productos.id_Producto = dbo.movimientos.id_prodcuto INNER JOIN " _
        & "dbo.Unidades_productos AS Unidades_productos_1 ON dbo.productos.id_Producto = Unidades_productos_1.id_producto AND " _
        & "dbo.productos.und_detalle = Unidades_productos_1.id_unidad INNER JOIN " _
        & "dbo.productos_stoks ON dbo.movimientos.id_prodcuto = dbo.productos_stoks.id_producto AND dbo.movimientos.almacen = dbo.productos_stoks.id_almacen  INNER JOIN dbo.Grupos ON dbo.productos.id_Grupo = dbo.Grupos.id_grupos " _
        & "  WHERE dbo.productos.id_Grupo<>150 and dbo.movimientos.fecha <  " & fnfecha(Me.fecha_existencia.Value) + " " _
        & " GROUP BY dbo.productos.id_Producto, dbo.productos.id_Grupo, dbo.productos.Descripcion, dbo.productos.peso, dbo.productos.margen, dbo.productos.iva, " _
        & " dbo.productos.id_Directorio, dbo.Unidades_productos.unidades, dbo.Unidades_productos.Codigo, Unidades_productos_1.costo, Unidades_productos_1.venta, " _
        & " dbo.Unidades_productos.Unidad, Unidades_productos_1.Unidad, dbo.movimientos.almacen, dbo.Grupos.Grupo " _
        & " HAVING  dbo.movimientos.almacen = " + al.ToString _
        & " ORDER BY Gp, dbo.productos.Descripcion "

        Clipboard.SetText(cmd)

        Dim tbl As New DataTable
        tbl = leer_tabla(cmd)

        exportar_tabla_Excel(tbl, "c:\tmp\inventario.xls")
        MsgBox("Exportado a c:\tmp\inventario.xls")
    End Sub

  
    Private Sub btn_cargar_archivo_stock_Click(sender As System.Object, e As System.EventArgs) Handles btn_cargar_archivo_stock.Click

    End Sub
End Class