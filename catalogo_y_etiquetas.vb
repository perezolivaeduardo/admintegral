Public Class catalogo_y_etiquetas

    Dim filelista As String = "c:\tmp\proveedores_excluidos_etiquetas.ppp"

    Private Sub catalogo_y_etiquetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Directorio' Puede moverla o quitarla según sea necesario.
        Me.DirectorioTableAdapter.FillBytipo(Me.admintegralDataSet.Directorio, 1)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.admintegralDataSet.Grupos)
        cargar_lista(filelista)
    End Sub

    Private Sub idgp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idgp.KeyPress
        If e.KeyChar = chr13 Then

            Me.GruposBindingSource.Position = Me.GruposBindingSource.Find("id_grupos", idgp.Text)
            

        End If
    End Sub

   

    Private Sub GrupoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoComboBox.SelectedIndexChanged
        idgp.Text = GrupoComboBox.SelectedValue
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        id_prov.Text = Me.NombreComboBox.SelectedValue
    End Sub

    Private Sub id_prov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id_prov.KeyPress
        If e.KeyChar = chr13 Then
            ' Me.DirectorioBindingSource.Position = Me.DirectorioBindingSource.Find(id_directorio", id_prov.Text)
        End If
    End Sub


    Private Sub boton_add_prov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_add_prov.Click
        agregar_prov(idtxt.Text)
        guardar_lista(filelista)
    End Sub

    Private Sub agregar_prov(ByVal id As String)
        Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        Dim nombre As String
        Try
            nombre = adap.GetDataByID(id, 1).Rows(0).Item("Nombre")
        Catch ex As Exception
            idtxt.Text = ""
            idtxt.Focus()
            Exit Sub
        End Try

        Lista.Items.Add(id)
        Me.listanombres.Items.Add(nombre)
        idtxt.Text = "" : idtxt.Focus()
        prepara_filtro()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Lista.DoubleClick
        Dim ix As Integer = Lista.SelectedIndex
        Try
            Lista.Items.RemoveAt(ix)
            listanombres.Items.RemoveAt(ix)
            prepara_filtro()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub idtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idtxt.KeyPress
        If e.KeyChar = chr13 Then
            agregar_prov(idtxt.Text)
        End If
    End Sub

    Private Sub prepara_filtro()
        Dim f As String, j As Integer
        f = ""
        For j = 0 To Lista.Items.Count - 1
            f += " and dbo.productos.id_Directorio<>" + Lista.Items(j)
        Next
        filtro.Text = f
        : If Lista.Items.Count > 0 Then Me.aplicar_filtros.Checked = True Else Me.aplicar_filtros.Checked = False
    End Sub

    Private Sub Button_con_iva(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CMD, f1, f2 As String
        f1 = 1 + (Factortxt.Text / 100).ToString
        f2 = 1 + (ivatxt.Text / 100).ToString
        f1 = "* " + f1 : f2 = "* " + f2
        CMD = "SELECT dbo.Unidades_productos.id_producto, dbo.Unidades_productos.id_unidad, dbo.Unidades_productos.Codigo, dbo.Unidades_productos.Unidad, dbo.Unidades_productos.factor, dbo.Unidades_productos.unidades, dbo.Unidades_productos.costo, " _
        & "CASE WHEN dbo.productos.precio_unico=0 THEN round(round((dbo.Unidades_productos.venta " + f1 + "),2)" + f2 + ",2) ELSE dbo.Unidades_productos.venta " + f2 + " END AS venta, dbo.productos.Descripcion, dbo.productos.iva, dbo.productos.precio_unico, dbo.productos.und_venta, dbo.productos.und_compra " _
        & " FROM dbo.productos INNER JOIN dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto " _
        & " WHERE dbo.productos.status=0 and dbo.productos.precio_unico=0 and dbo.Unidades_productos.id_unidad = 1 AND dbo.productos.iva > 0 "
        If Me.aplicar_filtros.Checked = True Then CMD += filtro.Text
        Dim tbl As DataTable
        tbl = leer_tabla(CMD)
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("lista", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter
        Dim factor As Decimal = 1 + (Val(Me.Factortxt.Text) / 100)
        Dim codigo As String
        codigo = Mid(".........", 1, Val(Factortxt.Text))
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("FACTOR", factor, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("codigo", codigo, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("iva", Me.ivatxt.Text, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(3) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Lista_de_ventas' Puede moverla o quitarla según sea necesario.
        Me.Lista_de_ventasTableAdapter.FillBytest(Me.admintegralDataSet.Lista_de_ventas)
        Me.ReportViewer1.RefreshReport()
    End Sub              'carga con Iva

    Private Sub boton_sin_iva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_sin_iva.Click
        Dim CMD, f1 As String
        f1 = 1 + (Factortxt.Text / 100).ToString
        f1 = "* " + f1
        CMD = "SELECT dbo.Unidades_productos.id_producto, dbo.Unidades_productos.id_unidad, dbo.Unidades_productos.Codigo, dbo.Unidades_productos.Unidad, dbo.Unidades_productos.factor, dbo.Unidades_productos.unidades, dbo.Unidades_productos.costo, " _
        & "CASE WHEN dbo.productos.precio_unico=0 THEN round((dbo.Unidades_productos.venta " + f1 + "),2) ELSE dbo.Unidades_productos.venta END AS venta, dbo.productos.Descripcion, dbo.productos.iva, dbo.productos.precio_unico, dbo.productos.und_venta, dbo.productos.und_compra " _
        & " FROM dbo.productos INNER JOIN dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto " _
        & " WHERE dbo.productos.status=0 and  dbo.productos.precio_unico=0 and dbo.Unidades_productos.id_unidad = 1 AND dbo.productos.iva =0 "
        If Me.aplicar_filtros.Checked = True Then CMD += filtro.Text
        Dim tbl As DataTable
        tbl = leer_tabla(CMD)
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("lista", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter
        Dim factor As Decimal = 1 + (Val(Me.Factortxt.Text) / 100)
        Dim codigo As String
        codigo = Mid(".........", 1, Val(Factortxt.Text))
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("FACTOR", factor, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("codigo", codigo, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("iva", Me.ivatxt.Text, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(3) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Lista_de_ventas' Puede moverla o quitarla según sea necesario.
        Me.Lista_de_ventasTableAdapter.FillBytest(Me.admintegralDataSet.Lista_de_ventas)
        Me.ReportViewer1.RefreshReport()
    End Sub         'Carga con sin iva

    Private Sub boton_cargar_grupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cargar_grupo.Click
        Dim CMD, f1, f2 As String
        f1 = 1 + (Factortxt.Text / 100).ToString
        f2 = 1 + (ivatxt.Text / 100).ToString
        f1 = "* " + f1 : f2 = "* " + f2
        CMD = "SELECT dbo.Unidades_productos.id_producto, dbo.Unidades_productos.id_unidad, dbo.Unidades_productos.Codigo, dbo.Unidades_productos.Unidad, dbo.Unidades_productos.factor, dbo.Unidades_productos.unidades, dbo.Unidades_productos.costo, " _
        & "CASE WHEN dbo.productos.precio_unico=0 THEN round(round((dbo.Unidades_productos.venta " + f1 + "),2)" + f2 + ",2) ELSE dbo.Unidades_productos.venta " + f2 + " END AS venta, dbo.productos.Descripcion, dbo.productos.iva, dbo.productos.precio_unico, dbo.productos.und_venta, dbo.productos.und_compra " _
        & " FROM dbo.productos INNER JOIN dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto " _
        & " WHERE dbo.productos.status=0 and dbo.productos.precio_unico=0 and  dbo.Unidades_productos.id_unidad = 1  AND dbo.productos.id_Grupo = " + idgp.Text + " "
        If Me.aplicar_filtros.Checked = True Then CMD += filtro.Text
        Dim tbl As DataTable
        tbl = leer_tabla(CMD)
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("lista", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter
        Dim factor As Decimal = 1 + (Val(Me.Factortxt.Text) / 100)
        Dim codigo As String
        codigo = Mid(".........", 1, Val(Factortxt.Text))
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("FACTOR", factor, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("codigo", codigo, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("iva", Me.ivatxt.Text, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(3) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Lista_de_ventas' Puede moverla o quitarla según sea necesario.
        Me.Lista_de_ventasTableAdapter.FillBytest(Me.admintegralDataSet.Lista_de_ventas)
        Me.ReportViewer1.RefreshReport()
    End Sub    'cargar 

    Private Sub cargar_lista(ByVal file As String)
        Lista.Items.Clear() : listanombres.Items.Clear()
        Dim f As Integer = FreeFile()

        FileOpen(f, file, OpenMode.Input)
        
        Dim id, a1, nombre As String, xx As Integer
        Try
            While Not EOF(f)
                a1 = LineInput(f) : xx = InStr(a1, ",")
                id = "" : nombre = ""
                id = Mid(a1, 1, xx - 1)
                nombre = Mid(a1, xx + 1)
                Lista.Items.Add(id)
                listanombres.Items.Add(nombre)
            End While
            FileClose(f)
        Catch ex As Exception
            FileClose(f)
        End Try

    End Sub
    Private Sub guardar_lista(ByVal file As String)

        Dim fileName As New System.IO.StreamWriter(file, False)
        For j As Integer = 0 To Lista.Items.Count - 1
            Dim l As String = Lista.Items(j).ToString + "," + listanombres.Items(j).ToString
            fileName.WriteLine(l)
        Next
        fileName.Close()
    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        Lista.Items.Clear()
        listanombres.Items.Clear()
    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        If Me.SaveFileDialog1.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
        Try
            guardar_lista(Me.SaveFileDialog1.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        If Me.OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
        cargar_lista(Me.OpenFileDialog1.FileName)
    End Sub

    Private Sub boton_validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_validar.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String
        ' pone status a 0 de todos
        cmd = "update dbo.productos set status=0 FROM productos "
        comando(cmd)
        cmd = "update dbo.productos set status=1 FROM productos LEFT OUTER JOIN movimientos ON productos.id_Producto = movimientos.id_prodcuto WHERE movimientos.id_prodcuto Is NULL"
        comando(cmd)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub boton_todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_todos.Click
        Dim CMD, f1, f2 As String
        f1 = 1 + (Factortxt.Text / 100).ToString
        f2 = 1 + (ivatxt.Text / 100).ToString
        f1 = "* " + f1 : f2 = "* " + f2
        CMD = "SELECT dbo.Unidades_productos.id_producto, dbo.Unidades_productos.id_unidad, dbo.Unidades_productos.Codigo, dbo.Unidades_productos.Unidad, dbo.Unidades_productos.factor, dbo.Unidades_productos.unidades, dbo.Unidades_productos.costo, " _
        & "CASE WHEN dbo.productos.precio_unico=0 THEN round(round((dbo.Unidades_productos.venta " + f1 + "),2)" + f2 + ",2) ELSE dbo.Unidades_productos.venta " + f2 + " END AS venta, dbo.productos.Descripcion, dbo.productos.iva, dbo.productos.precio_unico, dbo.productos.und_venta, dbo.productos.und_compra " _
        & " FROM dbo.productos INNER JOIN dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto " _
        & " WHERE dbo.productos.status=0 and  dbo.productos.precio_unico=0 and dbo.Unidades_productos.id_unidad = 1 "
        If Me.aplicar_filtros.Checked = True Then CMD += filtro.Text
        CMD += " Order by dbo.productos.id_Grupo "
        Dim tbl As DataTable
        tbl = leer_tabla(CMD)
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("lista", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter
        Dim factor As Decimal = 1 + (Val(Me.Factortxt.Text) / 100)
        Dim codigo As String
        codigo = Mid(".........", 1, Val(Factortxt.Text))
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("FACTOR", factor, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("codigo", codigo, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("iva", Me.ivatxt.Text, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(3) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Lista_de_ventas' Puede moverla o quitarla según sea necesario.
        Me.Lista_de_ventasTableAdapter.FillBytest(Me.admintegralDataSet.Lista_de_ventas)
        Me.ReportViewer1.RefreshReport()
    End Sub



End Class