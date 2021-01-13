Public Class caja_entradas
    Dim dsdoc As New DataSet("Entrada")
    Dim tblentrada As DataTable = dsdoc.Tables.Add("tblentrada")
    Dim tbldevolucion As DataTable = dsdoc.Tables.Add("tbldevolucion")
    Dim estemporal As Boolean = False
    Dim modoentrada As Integer = 0
    Dim mododevolucion As Integer = 1
    Dim ancho_ticket As Integer = 36
    Dim modo As Integer = modoentrada
    Dim ncredito As String
    Dim f2cancelar, t2cancelar As Integer
    Dim c, c1, c2 As String
  

    Private Sub id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
        If e.KeyChar = chr13 Then
            If id.TextLength < 1 Then MsgBox("Seleccione un proveedor") : Exit Sub
            Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
            If adap.GetDataByID(id.Text, 1).Rows.Count > 0 Then
                nombre.Text = adap.GetDataByID(id.Text, 1).Rows(0).Item("nombre")
                piva.Text = adap.GetDataByID(id.Text, 1).Rows(0).Item("iva")
                diastxt.Text = adap.GetDataByID(id.Text, 1).Rows(0).Item("Dias")
                vencetxt.Text = Now.Date.AddDays(diastxt.Text)
                niva.Text = piva.Text
                Linea.Enabled = True
                nfactura.Focus()
            Else
                nombre.Text = "" : IVA.Text = "" : id.Text = ""
                MsgBox("No existe el proveedor")
                Linea.Enabled = False
            End If
        End If
    End Sub '*************************************************    Carga Proveedor

    Private Sub caja_entradas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tmp_productos' Puede moverla o quitarla según sea necesario.
        Me.Tmp_productosTableAdapter.Fill(Me.AdmintegralDataSet.tmp_productos)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tmp_productos' Puede moverla o quitarla según sea necesario.
        Me.Tmp_productosTableAdapter.Fill(Me.AdmintegralDataSet.tmp_productos)
        fecha.Text = Now.Date
        crear_grid(0)
        crear_grid(1)
        'Formatea Grid's

        Dim adap As New admintegralDataSetTableAdapters.cajasTableAdapter
        almacen.Text = adap.GetDataBy(My.Settings.ncaja).Rows(0).Item("almacen")
        serie.Text = adap.GetDataBy(My.Settings.ncaja).Rows(0).Item("serie")
        sucursal.Text = adap.GetDataBy(My.Settings.ncaja).Rows(0).Item("nombre")
        adap.Dispose()

        With dgventrada
            For j As Integer = 1 To 4 : .Columns(j).Visible = False : Next j
            .Columns(7).Visible = False
            .Columns(10).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            For j As Integer = 9 To .Columns.Count - 1
                .Columns(j).DefaultCellStyle.Format = "N2"
                .Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next j
        End With

        With dgvdevolucion
            For j As Integer = 1 To 4 : .Columns(j).Visible = False : Next j
            .Columns(7).Visible = False
            .Columns(10).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            For j As Integer = 9 To .Columns.Count - 1
                .Columns(j).DefaultCellStyle.Format = "N2"
                .Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next j
        End With

        Me.lblmodo.Text = "Entrada"

    End Sub

    Private Sub Linea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Linea.KeyPress
        If e.KeyChar = chr13 Then
            Dim i1 As Integer
            c = Linea.Text
            i1 = InStr(c, ".")
            If i1 = 0 Then
                c = "1." + Linea.Text
                i1 = 2
            End If
            c1 = Mid(c, 1, i1 - 1)
            c2 = Mid(c, i1 + 1)
            Dim adap As New admintegralDataSetTableAdapters.Lista_de_ventas1TableAdapter
            Dim adapprod As New admintegralDataSetTableAdapters.productosTableAdapter

            If adap.GetDataBy(c2).Rows.Count > 0 Then
                Dim dt As DataRow, dtp As DataRow
                dt = adap.GetDataBy(c2).Rows(0)
                If dt(4) <> 1 Then MsgBox("Use el codigo por Pieza") : Linea.Text = "" : Exit Sub
                dtp = adapprod.GetDataById(dt(0)).Rows(0)
                If dtp("id_Directorio") <> id.Text Then MsgBox("Este producto no es de este proveedor") : Exit Sub
                Dim ndt As DataRow = dsdoc.Tables(modo).NewRow
                Try
                    ndt(0) = dt(2)
                    ndt(1) = dt(0)
                    ndt(2) = dt(1)
                    ndt(3) = dt("iva")
                    ndt(5) = dt("descripcion")
                    ndt(6) = dt("unidad")
                    ndt(7) = dt("factor")
                    ndt(8) = c1
                    Dim pu As Single = dt(6)
                    pu = InputBox("Teclee el costo del producto que esta en la nota", "Costo Unitario", pu)
                    ndt(9) = pu
                    dsdoc.Tables(modo).Rows.Add(ndt)
                    dsdoc.AcceptChanges()
                    totalizar()
                Catch ex As Exception

                End Try

            Else
                checatemporales()
                If estemporal = True Then Linea.Text = "" : Exit Sub
                Dim y As MsgBoxResult
                y = MsgBox("No Existe este codigo, quiere darlo de alta?", MsgBoxStyle.YesNo, "PRODUCTO NUEVO")
                If y = MsgBoxResult.Yes Then
                    Dim nc As String
                    nc = InputBox("Escanee de Nuevo el Producto", "Codigo del Producto", "")
                    If nc <> c2 Then
                        MsgBox("No Coinciden los codigos!!" + chr13 + " asegurese de que es un producto Nuevo e intente otra vez")
                        Linea.Text = "" : Exit Sub
                    Else
                        Me.Tmp_productosBindingSource.AddNew()
                        Me.TabControl1.SelectTab(2)
                        Me.ncodigo.Text = nc
                        Me.nprov.Text = Me.id.Text
                        Me.niva.Text = piva.Text
                        Me.ndescripcion.Focus()
                    End If

                End If
            End If
            Linea.Text = ""
            If dgventrada.RowCount > dgventrada.DisplayedRowCount(False) Then
                dgventrada.FirstDisplayedScrollingRowIndex = dgventrada.Rows.Count - dgventrada.DisplayedRowCount(False)
            End If
            If dgvdevolucion.RowCount > dgvdevolucion.DisplayedRowCount(False) Then
                dgvdevolucion.FirstDisplayedScrollingRowIndex = dgvdevolucion.Rows.Count - dgvdevolucion.DisplayedRowCount(False)
            End If
        End If
    End Sub '**********************************************   carga el producto al grid

    Private Sub dgventrada_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgventrada.CellValueChanged, dgvdevolucion.CellValueChanged
        totalizar()
    End Sub ' *********************************  Cambios en Grid = Totalizar

    Private Sub totalizar()
        dsdoc.Tables(modo).AcceptChanges()
        Try
            subtotal.Text = Format(tblentrada.Compute("sum(importe)", ""), "N2")
            IVA.Text = Format(tblentrada.Compute("sum(importeiva)", ""), "n2")
            TOTAL.Text = Format(tblentrada.Compute("sum(total)", ""), "N2")
        Catch ex As Exception
        End Try

        Try
            importenc.Text = Format(tbldevolucion.Compute("sum(total)", ""), "N2")
            If Val(importenc.Text) > 0 Then
                Me.gruponc.Visible = True
                numeronc.Enabled = True
            Else
                Me.gruponc.Visible = False
            End If
        Catch ex As Exception
        End Try

    End Sub '***************************************************   TOTALIZAR

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        modo = TabControl1.SelectedIndex
        If modo = 0 Then Me.lblmodo.Text = "Entrada" Else Me.lblmodo.Text = "Devolucion"
    End Sub '****************************   Cambio de Grid

    Private Sub crear_grid(ByVal m As Integer)
        ' Declare variables for DataColumn and DataRow objects.
        Dim column As New DataColumn

        column = New DataColumn("codigo", System.Type.GetType("System.String"))
        column.ReadOnly = True : column.AllowDBNull = False : dsdoc.Tables(m).Columns.Add(column)


        column = New DataColumn("Id", System.Type.GetType("System.Int32"))
        column.Unique = False : dsdoc.Tables(m).Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Id_ud", System.Type.GetType("System.Int32"))
        column.Unique = False : dsdoc.Tables(m).Columns.Add(column)        ' Add the Column to the DataColumnCollection.


        ' and add to DataTable.    
        column = New DataColumn("iva", System.Type.GetType("System.Int32"))
        column.DefaultValue = 0 : dsdoc.Tables(m).Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        ' and add to DataTable.    
        column = New DataColumn("piva", System.Type.GetType("System.Int32"), "iif (iva>0," + piva.Text + ",0)")
        column.DefaultValue = 0 : dsdoc.Tables(m).Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Descripcion", System.Type.GetType("System.String"))
        column.ReadOnly = True : column.Caption = "Producto" : dsdoc.Tables(m).Columns.Add(column)

        column = New DataColumn("Und", System.Type.GetType("System.String"))
        column.ReadOnly = True : column.Caption = "und" : dsdoc.Tables(m).Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn("factor", System.Type.GetType("System.Decimal"))
        dsdoc.Tables(m).Columns.Add(column) ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Cantidad", System.Type.GetType("System.Decimal"))
        column.Caption = "Cant" : dsdoc.Tables(m).Columns.Add(column)

        column = New DataColumn("Costo", System.Type.GetType("System.Decimal"))
        column.ColumnName = "ud_costo"
        column.Caption = "Costo" : dsdoc.Tables(m).Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn("iiva", System.Type.GetType("System.Decimal"), "(piva/100)*ud_costo")
        column.DefaultValue = 0 : dsdoc.Tables(m).Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn("importe", System.Type.GetType("System.Decimal"), "ud_costo*cantidad")
        column.DefaultValue = 0 : dsdoc.Tables(m).Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn("importeiva", System.Type.GetType("System.Decimal"), "iiva*cantidad")
        column.DefaultValue = 0 : dsdoc.Tables(m).Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn("total", System.Type.GetType("System.Decimal"), "importe+importeiva")
        column.DefaultValue = 0 : dsdoc.Tables(m).Columns.Add(column)

        If m = 0 Then dgventrada.DataSource = dsdoc.Tables(0)
        If m = 1 Then dgvdevolucion.DataSource = dsdoc.Tables(1)

    End Sub '**************************************************  Crear Grid

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As MsgBoxResult = MsgBox("Guardar Entrada", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            Guardar()
            Me.Close()
        End If
    End Sub

    Private Sub Guardar()
        Dim folio_entrada As Long = leer_folio(12, Me.serie.Text)
        Dim folio_devolucion As Long = leer_folio(13, Me.serie.Text)
        Dim d, dv As New Mi_Documento, result As Boolean

        d.a00_id_doc = 12 'entrada en tienda
        d.a01_Folio = folio_entrada
        d.a02_serie = Me.serie.Text
        d.a03_Almacen = almacen.Text
        d.a04_id_directorio = id.Text
        d.a05_tipo_directorio = 1
        d.a06_fecha_registro = Now.Date
        d.a08_factura = nfactura.Text
        d.a09_fecha_factura = Now.Date
        d.a10_fecha_surtido = Now.Date
        d.a11_fecha_vence = Me.vencetxt.Text
        d.a14_sub0 = subtotal.Text
        d.a17_iva10 = IVA.Text
        d.a22_importe = TOTAL.Text
        d.a23_idcartera = 3
        d.a25_almaentrada = almacen.Text
        Dim ok As Boolean = Agregar_documento(d)
        If ok = False Then
            MsgBox("No se guardo el domumento")
            Exit Sub
        End If

        'Guradar Detalle de la entrada
        Dim r As DataRow
        For j As Integer = 0 To tblentrada.Rows.Count - 1
            r = tblentrada.Rows(j)
            Dim m As New mi_movimientos
            m.a01_Almacen = d.a03_Almacen
            m.a02_id_doc = d.a00_id_doc
            m.a03_Folio = d.a01_Folio
            m.a04_serie = d.a02_serie
            m.a05_num = j
            m.a06_fecha = d.a10_fecha_surtido
            m.a07_idproducto = r.Item("id")
            m.a08_factor = r.Item("factor")
            m.a09_piva = r.Item("piva")
            m.a10_ud = r.Item("id_ud")
            m.a11_cantidad = r.Item("cantidad")
            m.a12_costo = r.Item("ud_costo")
            m.a13_Cdesc = 0
            m.a14_cflete = 0
            m.a15_civa10 = 0
            m.a16_civa15 = 0
            m.a17_cventa = r.Item("ud_costo")
            m.a18_cvdesc = 0
            m.a32_caducidad = Now.Date
            If Me.piva.Text = "10" Then
                m.a19_cviva10 = r.Item("iiva")
            Else
                m.a20_cviva15 = r.Item("iiva")
            End If
            m.a31_signo = 0
            result = agregar_movimiento(m)
            If result = False Then
                MsgBox("No se guardo este producto")
            End If
        Next

        ncredito = ""
        If Val(importenc.Text) > 0 Then
            dv.a00_id_doc = 13 'entrada en tienda
            dv.a01_Folio = folio_devolucion
            dv.a02_serie = Me.serie.Text
            dv.a03_Almacen = almacen.Text
            dv.a04_id_directorio = id.Text
            dv.a05_tipo_directorio = 1
            dv.a06_fecha_registro = Now.Date
            dv.a08_factura = numeronc.Text
            dv.a09_fecha_factura = Now.Date
            dv.a10_fecha_surtido = Now.Date
            dv.a11_fecha_vence = Now.Date
            dv.a14_sub0 = tbldevolucion.Compute("sum(importe)", "")
            dv.a17_iva10 = tbldevolucion.Compute("sum(importeiva)", "")
            dv.a22_importe = tbldevolucion.Compute("sum(total)", "")
            dv.a25_almaentrada = almacen.Text
            ok = Agregar_documento(dv)
            ncredito = dv.a02_serie.ToString + dv.a01_Folio.ToString
            If ok = False Then
                MsgBox("No se guardo la Devolucion")
            End If

            'Guradar Detalle de la Devolucion
            For j As Integer = 0 To tbldevolucion.Rows.Count - 1
                r = tbldevolucion.Rows(j)
                Dim m As New mi_movimientos
                m.a01_Almacen = dv.a03_Almacen
                m.a02_id_doc = dv.a00_id_doc
                m.a03_Folio = dv.a01_Folio
                m.a04_serie = dv.a02_serie
                m.a05_num = j
                m.a06_fecha = dv.a10_fecha_surtido
                m.a07_idproducto = r.Item("id")
                m.a08_factor = r.Item("factor")
                m.a09_piva = r.Item("piva")
                m.a10_ud = r.Item("id_ud")
                m.a11_cantidad = r.Item("cantidad")
                m.a12_costo = r.Item("ud_costo")
                m.a17_cventa = r.Item("ud_costo")
                m.a32_caducidad = Now.Date
                If Me.piva.Text = "10" Then
                    m.a19_cviva10 = r.Item("iiva")
                Else
                    m.a20_cviva15 = r.Item("iiva")
                End If
                m.a31_signo = 0
                result = agregar_movimiento(m)
                If result = False Then
                    MsgBox("No se guardo este producto")
                End If
            Next
        End If
        ' *******************************************************************************************Guardar Comentarios
        Try
            'actualiza la tabla de comentarios
            Dim adapcomentario As New admintegralDataSetTableAdapters.ComentariosTableAdapter
            Dim comentario As String = Me.comentarios.Text
            adapcomentario.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, "", user.id.ToString + " " + user.nick, comentario)
        Catch ex As Exception
        End Try

        Main.StatusStrip1.Items(2).Text = "Documento Guardado correcto"
        imprimir_contrarecibo(Trim(d.a02_serie) + "-" + Trim(d.a01_Folio.ToString))
        ok = False
        While ok = False
            Dim x As MsgBoxResult = MsgBox("Se imprimio Bien?", MsgBoxStyle.YesNo, "Imprimir Contra recibo")
            If x = MsgBoxResult.Yes Then
                ok = True
            Else
                imprimir_contrarecibo(Trim(d.a02_serie) + "-" + Trim(d.a01_Folio.ToString))
            End If
        End While
    End Sub '

    Private Sub imprimir_contrarecibo(ByVal folio As String)
        encabezado("c:\tmp\entrada.txt", "CONTRARECIBO " + folio, 40)
        Dim f As New System.IO.StreamWriter("c:\tmp\entrada.txt", True)
        f.WriteLine(" ")
        f.WriteLine("Tienda :" + sucursal.Text + " - " + user.nick)
        f.WriteLine("Fecha: " + Format(Now.Date, "d") + " Hora : " + Format(Now, "t"))

        f.WriteLine("Proveedor : " + id.Text)
        f.WriteLine(Me.nombre.Text)
        f.WriteLine("")
        f.WriteLine("No. Factura    : " + nfactura.Text)
        f.WriteLine("Importe        : " + TOTAL.Text)
        f.WriteLine("")
        If Val(importenc.Text) > 0 Then
            Dim d As Single
            d = tblentrada.Compute("sum(total)", "") - tbldevolucion.Compute("sum(total)", "")
            f.WriteLine("N.CREDITO  : " + numeronc.Text + " / " + ncredito)
            f.WriteLine("Importe    : " + importenc.Text)
            f.WriteLine("")
            f.WriteLine("")
            f.WriteLine("PAGO NETO   : " + Format(d, "N2"))
        End If
        f.WriteLine("")
        ''================================================================================================
        '' detalle de la nota
        ''================================================================================================

        'f.WriteLine("----------------------------------------")
        'f.WriteLine("Cant.  Concepto       Unitario  Importe ")
        'f.WriteLine("----------------------------------------")
        'Dim r As DataRow
        'Dim l As String
        'For j As Integer = 0 To tblentrada.Rows.Count - 1
        '    r = tblentrada.Rows(j)
        '    l = Format(r("cantidad"), "###").PadRight(4) + Mid(r("descripcion").ToString, 1, 19)
        '    Dim unitario As Single = r("ud_vneto") + r("ud_iva10")
        '    l += Format(unitario, " ###.##").PadLeft(7)
        '    l += Format(r("Total"), "N2").PadLeft(9)
        '    f.WriteLine(l)
        'Next j
        'f.WriteLine(Mid("----------------------------------------", 1, ancho_ticket))
        'f.WriteLine("Total :".PadLeft(ancho_ticket - 16) + Format(CDbl(totaltxt.Text), "N2").PadLeft(11))


        f.WriteLine("Comentarios :")
        f.WriteLine(Me.comentarios.Text)
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine(user.nombre)
        f.WriteLine("____________________________")
        f.WriteLine("      Recibi  Mercancia")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, "c:\tmp\entrada.txt")
    End Sub 'Imprimir Contra Recibo

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub ' salir

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        My.Forms.Buscar_productos.ShowDialog()
        Me.Linea.Text += producto.a7codigo
        Linea.Focus()
    End Sub


    Private Sub nfactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nfactura.KeyPress
        If e.KeyChar = chr13 Then
            Linea.Focus()
        End If
    End Sub ' 

    Private Sub dgventrada_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgventrada.CellDoubleClick
        Dim x As MsgBoxResult = MsgBox("Borrar Renglon", MsgBoxStyle.YesNo, "Borrar Renglon")
        If x = MsgBoxResult.Yes Then
            If modo = 0 Then
                'dgventrada.Rows.RemoveAt(dgventrada.CurrentRow.Index)
                tblentrada.Rows.RemoveAt(dgventrada.CurrentRow.Index)
            Else
                'dgvdevolucion.Rows.RemoveAt(dgvdevolucion.CurrentRow.Index)
                tbldevolucion.Rows.RemoveAt(dgvdevolucion.CurrentRow.Index)
            End If
        End If
        totalizar()
    End Sub

    Private Sub boton_guardar_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar_producto.Click
        Me.Validate()
        Me.Tmp_productosBindingSource.EndEdit()
        Me.Tmp_productosTableAdapter.Update(Me.AdmintegralDataSet.tmp_productos)
        Me.TabControl1.SelectTab(0)
        checatemporales()
    End Sub

    Private Sub checatemporales()
        Dim ix As Integer = Me.Tmp_productosBindingSource.Find("codigo", c2)
        estemporal = False
        If ix < 0 Then Exit Sub
        Me.Tmp_productosBindingSource.Position = ix
        estemporal = True
        With Me.Tmp_productosDataGridView.Rows(ix)
            Dim ndt As DataRow = dsdoc.Tables(modo).NewRow

            ndt(0) = .Cells("codigo").Value
            ndt(1) = 0
            ndt(2) = 0
            Try
                If Val(.Cells(4).Value) > 0 Then ndt(3) = True Else ndt(3) = False
                ndt(4) = Val(.Cells(4).Value)
            Catch ex As Exception

            End Try
            ndt(5) = .Cells("descripcion").Value
            ndt(6) = "Pz"
            ndt(7) = 1
            ndt(8) = c1
            ndt(9) = .Cells(3).Value
            dsdoc.Tables(modo).Rows.Add(ndt)
            totalizar()
            
        End With
    End Sub

    Private Sub ndescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ndescripcion.KeyPress
        If e.KeyChar = chr13 Then
            ncosto.Focus()
        End If
    End Sub

    Private Sub niva_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles niva.KeyPress
        If e.KeyChar = chr13 Then
            ndescripcion.Focus()
        End If
    End Sub

    Private Sub ncosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ncosto.KeyPress
        If e.KeyChar = chr13 Then
            niva.Focus()
        End If
    End Sub

    Private Sub BuscarProvedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProvedorToolStripMenuItem.Click
        busca_proveedor()
    End Sub
    Private Sub busca_proveedor()
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        id.Text = gprov.id
        nombre.Text = gprov.nombre
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        cargar_entradas()
        
    End Sub
    Private Sub cargar_entradas()
        Dim cmd As String = "Select td,serie, folio,id_directorio as Id,Nombre,factura,fechafactura as fecha,importe,status from sql_documentos where td=12 and serie ='" + Me.serie.Text + "' order by folio desc"
        Dim tbl As DataTable = leer_tabla(cmd)
        Me.dgvrelacion.DataSource = tbl
        Me.dgvrelacion.Columns(7).DefaultCellStyle.Format = "N2"
        For j As Integer = 0 To dgvrelacion.Rows.Count - 1
            With dgvrelacion.Rows(j)
                If .Cells("status").Value <> 0 Then .DefaultCellStyle.ForeColor = Color.Red
            End With
        Next
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        carga_devoluciones()
    End Sub
    Private Sub carga_devoluciones()
        Dim cmd As String = "Select td,serie, folio,id_directorio as Id,Nombre,factura,fechafactura as fecha,importe,status from sql_documentos where td=13 and serie ='" + Me.serie.Text + "' order by folio desc"
        Dim tbl As DataTable = leer_tabla(cmd)
        Me.dgvrelacion.DataSource = tbl
        Me.dgvrelacion.Columns(7).DefaultCellStyle.Format = "N2"
        For j As Integer = 0 To dgvrelacion.Rows.Count - 1
            With dgvrelacion.Rows(j)
                If .Cells("status").Value <> 0 Then .DefaultCellStyle.ForeColor = Color.Red
            End With
        Next
    End Sub


    Private Sub dgvrelacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvrelacion.CellClick
        If dgvrelacion.CurrentRow.Cells("fecha").Value = Now.Date Then
            Me.boton_cancelar.Text = "Calcelar folio No. " + Me.dgvrelacion.CurrentRow.Cells("folio").Value.ToString
            Me.boton_cancelar.Visible = True
            f2cancelar = Me.dgvrelacion.CurrentRow.Cells("folio").Value
            t2cancelar = Me.dgvrelacion.CurrentRow.Cells("td").Value
        Else
            Me.boton_cancelar.Visible = False
        End If
    End Sub

    Private Sub boton_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cancelar.Click
        Dim ix As MsgBoxResult
        Dim msg As String = "Quiere Cancelar el Folio No." + f2cancelar.ToString
        ix = MsgBox(msg, MsgBoxStyle.YesNo, "Cancelar Folio")
        If ix = MsgBoxResult.Yes Then
            Dim adap As New admintegralDataSetTableAdapters.DocumentosTableAdapter
            Try
                adap.UpdateStatus(1, user.id, t2cancelar, f2cancelar, Me.serie.Text)
                MsgBox("Documento Cancelado")
            Catch ex As Exception
                MsgBox("No se cancelo Producto")
            End Try

        End If
    End Sub 'Cancelar un documento

    Private Sub piva_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piva.Leave
        If piva.Text <> "0" And piva.Text <> My.Settings.iva.ToString And piva.Text <> My.Settings.iva2.ToString Then
            MsgBox("Verifique El % IVA")
            piva.Text = "0"
        End If
    End Sub

    Private Sub nfactura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nfactura.Leave
        Dim cmd As String = "Select * from documentos where td=12 and factura = '" + Me.nfactura.Text + "' and id_directorio = " + Me.id.Text
        Dim tbf As DataTable = leer_tabla(cmd)
        If tbf.Rows.Count > 0 Then
            MsgBox("Ya esta registrada esa factura")
            Me.nfactura.SelectAll()
            Me.nfactura.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        busca_proveedor()
    End Sub
End Class