Public Class devolucion_nueva
    Dim bs As New BindingSource
    Dim mytable As New DataTable
    Dim condiferencias As Boolean = False
    Dim tipo_de_documento
    Dim factor_iva1_venta As String
    Dim factor_iva2_venta As String
    Dim jalada_td As Integer
    Dim jalada_folio As Integer
    Dim jalada_serie As String
    Dim sub0, sub10, sub15 As Decimal

    Private Sub devolcuon_nueva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        factor_iva1_venta = (My.Settings.iva / 100).ToString 'iva10
        factor_iva2_venta = (My.Settings.iva2 / 100).ToString 'iva15

        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        Me.id_provtxt.Text = gprov.id
        Me.nombreprovtxt.Text = gprov.nombre
        piva.Text = gprov.iva
        crear_grid()
    End Sub '***** CARGAR FORMA*******

    Private Sub crear_grid()
        ' Declare variables for DataColumn and DataRow objects.
        Dim column As New DataColumn

        ' Create new DataColumn, set DataType, ColumnName 

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "Id"
        column.Caption = "id"
        column.Unique = False
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.


        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "iva"
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.


        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "piva"
        column.Caption = "*" + column.ColumnName
        column.Expression = "iif (iva>0," + piva.Text + ",0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.


        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Descripcion"
        column.Caption = "Producto"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Und"
        column.Caption = "und"
        mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "factor"
        column.Caption = "*" + column.ColumnName
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "ub_Und"
        column.Caption = "und"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cantidad"
        column.Caption = "Cant"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "ud_Costo"
        column.Caption = "Costo"
        mytable.Columns.Add(column)

        column = New DataColumn() 'porcentaje de descuento (solo para formula)
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "pdesc"
        column.Caption = "*" + column.ColumnName
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_CDesc"
        column.Caption = "Desc."
        column.DefaultValue = 0
        column.Expression = "ud_costo * pdesc"
        column.ReadOnly = True
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_CFlete"
        column.Caption = "Flete"
        column.DefaultValue = 0
        column.ReadOnly = True
        mytable.Columns.Add(column)

        column = New DataColumn() 'cOSTOS nETO
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_Cneto"
        column.Caption = "Neto"
        column.Expression = "ud_costo - UD_CDesc"
        mytable.Columns.Add(column)

        column = New DataColumn() 'IMPORTE
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Importe"
        column.Caption = "Importe"
        column.Expression = "cantidad * ud_Costo" : column.ReadOnly = True
        mytable.Columns.Add(column)


        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_iva10"
        column.Caption = "*" + column.ColumnName
        column.Expression = "iif(piva=" + My.Settings.iva.ToString + ",ud_cneto*" + factor_iva1_venta.ToString + ",0)"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_iva15"
        column.Caption = "*" + column.ColumnName
        column.Expression = "iif(piva=" + My.Settings.iva2.ToString + ",ud_cneto*" + factor_iva2_venta.ToString + ",0)"
        mytable.Columns.Add(column)

        'Columnas de Unidad Base
        '================================================================================

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UB_Cantidad"
        column.Caption = "*" + column.ColumnName
        column.Expression = "factor * Cantidad"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UB_Costo"
        column.Caption = "*" + column.ColumnName
        column.ReadOnly = False
        column.Expression = "ud_cneto / factor"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ub_CDesc"
        column.Caption = "*" + column.ColumnName
        column.ReadOnly = True
        column.Expression = "ud_cdesc /  factor"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UB_CFlete"
        column.Caption = "*" + column.ColumnName
        column.Expression = " ud_cflete / factor"
        mytable.Columns.Add(column)


        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ub_iva10"
        column.Caption = "*" + column.ColumnName
        column.Expression = "ud_iva10 / factor"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ub_iva15"
        column.Caption = "*" + column.ColumnName
        column.Expression = "ud_iva15 / factor"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "subdesc"
        column.Caption = "*" + column.ColumnName
        column.Expression = "ud_cdesc * cantidad"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "subiva10"
        column.Caption = "*" + column.ColumnName
        column.Expression = "ud_iva10 * cantidad"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "subiva15"
        column.Caption = "lk*" + column.ColumnName
        column.Expression = "ud_iva15 * cantidad"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ped_cantidad"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ped_costo"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn("ud_Id", System.Type.GetType("System.Int32"))
        column.Caption = "ud_id" : column.Unique = False
        mytable.Columns.Add(column) ' Add the Column to the DataColumnCollection.


        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Codigo"
        column.Caption = "Codigo"
        mytable.Columns.Add(column)


        '' PIEPS
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")   '<=============IEPS
        column.ColumnName = "pieps" : column.Caption = "ieps" : column.DefaultValue = 0
        column.Unique = False
        mytable.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "ieps"
        column.Expression = "iif(pieps<>0,ud_cneto*(pieps/100),0)"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "tieps"
        column.Expression = "ieps*cantidad"
        mytable.Columns.Add(column)

        'asigna la abla al datagrid
        bs.DataSource = mytable
        dgv.DataSource = bs

        ' Oculta columnas de calculo
        dgv.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv.Columns("id").ReadOnly = True
        dgv.Columns("Descripcion").ReadOnly = True
        dgv.Columns("und").ReadOnly = True
        dgv.Columns("Factor").ReadOnly = True
        dgv.Columns("UB_und").ReadOnly = True

        '*****************************************************************
        'SUB TOTALES
        '******************************************************************
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cal0"
        column.Expression = "iif (iva=0, ud_costo * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cal10"
        column.Expression = "iif (iva=" + My.Settings.iva.ToString + ", ud_costo * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cal15"
        column.Expression = "iif (iva=" + My.Settings.iva2.ToString + ", ud_costo * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)
        '**********************************************************************
        ' sub-totales DESCUENTo
        '**********************************************************************

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "dal0"
        column.Expression = "iif (iva=0, ud_cdesc * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "dal10"
        column.Expression = "iif (iva=" + My.Settings.iva.ToString + ", ud_cdesc * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "dal15"
        column.Expression = "iif (iva=" + My.Settings.iva.ToString + ", ud_cdesc * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "id_uc"
        column.DefaultValue = 0
        mytable.Columns.Add(column)


        '**********************************************************************

        dgv.Columns("Importe").DefaultCellStyle.Format = "N2"
        dgv.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("ud_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("ub_und").HeaderText = "Und"

        dgv.Columns("iva").Visible = False
        dgv.Columns("piva").Visible = False
        dgv.Columns("pdesc").Visible = False
        dgv.Columns("ud_cdesc").Visible = False
        dgv.Columns("ud_cflete").Visible = False
        dgv.Columns("ud_cneto").Visible = False
        dgv.Columns("ud_iva10").Visible = False
        dgv.Columns("ud_iva15").Visible = False
        dgv.Columns("ub_cantidad").Visible = False
        dgv.Columns("ub_Costo").Visible = False
        dgv.Columns("ub_cdesc").Visible = False
        dgv.Columns("ub_cflete").Visible = False
        dgv.Columns("ub_iva10").Visible = False
        dgv.Columns("ub_iva15").Visible = False
        dgv.Columns("subdesc").Visible = False
        dgv.Columns("subiva10").Visible = False
        dgv.Columns("subiva15").Visible = False
        dgv.Columns("ped_cantidad").Visible = False
        dgv.Columns("ped_costo").Visible = False
        dgv.Columns("cal0").Visible = False
        dgv.Columns("cal10").Visible = False
        dgv.Columns("cal15").Visible = False
        dgv.Columns("dal0").Visible = False
        dgv.Columns("dal10").Visible = False
        dgv.Columns("dal15").Visible = False
        dgv.Columns("ud_id").Visible = False
        dgv.Columns("id_uc").Visible = False
        dgv.Columns("ub_und").Visible = False
        dgv.Columns("id").Visible = False
        dgv.Columns("codigo").DisplayIndex = 0

        Me.ErrorProvider1.DataSource = dgv.DataSource
    End Sub 'crea el grid

    Private Sub pdesctext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pdesctext.TextChanged
        Dim pd As Double
        Try
            pd = CDbl(Me.pdesctext.Text) / 100
        Catch ex As Exception
            pd = 0
        End Try
        Try
            mytable.Columns("pdesc").DefaultValue = pd.ToString
            For j As Integer = 0 To Me.dgv.Rows.Count - 1
                Me.dgv.Rows(j).Cells("pdesc").Value = pd.ToString
            Next
        Catch ex As Exception

        End Try
    End Sub ' rellena grid con descuento y pone como default en la celda

    Private Sub piva_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If piva.Text = My.Settings.iva.ToString Then mytable.Columns("piva").Expression = "iif (iva>0, " + My.Settings.iva.ToString + ",0)"
            If piva.Text = My.Settings.iva2.ToString Then mytable.Columns("piva").Expression = "iif (iva>0, " + My.Settings.iva2.ToString + ",0)"
            If piva.Text = "0" Then mytable.Columns("piva").Expression = "iif (iva>0, 0,0)"
            dgv.Refresh()
        Catch ex As Exception

        End Try
    End Sub ' Modifica forula de ivaen la celda

    Private Sub pdesctext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pdesctext.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub ' Recibe solo numeros en pdesctext

    Private Sub totaliza()
        subtotaltxt.Text = ""
        descuentotxt.Text = ""
        iva10txt.Text = ""
        IEPStxt.Text = ""
        totaltxt.Text = ""
        Try
            sub0 = mytable.Compute("sum(cal0)", "")
            sub10 = mytable.Compute("sum(cal10)", "")
            sub15 = mytable.Compute("sum(cal15)", "")
            subtotaltxt.Text = Format(mytable.Compute("sum(importe)", ""), "N2")
            descuentotxt.Text = Format(mytable.Compute("sum(subdesc)", ""), "N2")
            iva10txt.Text = Format(mytable.Compute("sum(subiva10)", ""), "N2")
            IEPStxt.Text = Format(mytable.Compute("sum(tieps)", ""), "N2")
            totaltxt.Text = Format(CDbl(subtotaltxt.Text) - CDbl(descuentotxt.Text) + CDbl(iva10txt.Text) + CDbl(IEPStxt.Text), "N2")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEnter
        totaliza()
    End Sub '**********

    Private Sub guarda_documento(ByVal tipoDoc As Integer)
        'Guardar Documento
        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim result As Boolean
        Dim d As New Mi_Documento
        Dim r As DataRow
        Dim j As Integer

        Dim f As Long
        If jalada_folio > 0 And tipoDoc = 2 Then
            f = jalada_folio
            Dim adapdoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
            adapdoc.borrar_documento(2, f)
            adapdoc.Dispose()
        Else
            Try
                f = afolio.siguiente(tipoDoc, "") 'Dev. a prov. (nota de credito) or 14 Citziacion dev. a prov
            Catch ex As Exception
                f = 1
            End Try
        End If
        status1.Text = "Guardando Documentos"
        barra.Maximum = dgv.Rows.Count
        barra.Value = 1
        d.a00_id_doc = tipoDoc 'devol a prov. (n:credito)
        d.a01_Folio = f
        d.a02_serie = " "
        d.a03_Almacen = Me.AlmacenComboBox.SelectedValue
        d.a04_id_directorio = Me.id_provtxt.Text
        d.a05_tipo_directorio = 1
        d.a06_fecha_registro = Date.Now.Date.ToString
        d.a07_Folio_pedido = 0
        d.a08_factura = Me.facturatxt.Text
        d.a09_fecha_factura = CDate(fechaDevolucion.Value.ToString).Date
        d.a10_fecha_surtido = CDate(fechaDevolucion.Value.ToString).Date
        d.a11_fecha_vence = CDate(fechaDevolucion.Value.ToString).Date
        d.a12_pdesc = CDbl(Me.pdesctext.Text)
        d.a13_flete = 0
        d.a14_sub0 = mytable.Compute("sum(cal0)", "")
        d.a15_sub10 = mytable.Compute("sum(cal10)", "")
        d.a16_sub15 = mytable.Compute("sum(cal15)", "")
        d.a17_iva10 = mytable.Compute("sum(subiva10)", "")
        d.a18_iva15 = mytable.Compute("sum(subiva15)", "")
        d.a19_desc0 = mytable.Compute("sum(dal0)", "")
        d.a20_desc10 = mytable.Compute("sum(dal10)", "")
        d.a21_desc15 = mytable.Compute("sum(dal15)", "")
        d.a22_importe = Me.totaltxt.Text
        d.a23_idcartera = 1 ' CxP
        d.a24_status = 0
        d.a25_almaentrada = 0
        d.a26_diasc = 0
        d.a27_pviva = Me.piva.Text
        d.a36_ieps = mytable.Compute("sum(tieps)", "") ''IEPS 

        result = Agregar_documento(d)
        If result = False Then
            MsgBox("No se guardo el documento")
            Exit Sub
        End If

        status1.Text = "Guardando Movimientos"
        ' Guarda el detalle de la entrada
        For j = 0 To mytable.Rows.Count - 1
            barra.Value = j
            r = mytable.Rows(j)
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
            m.a10_ud = r.Item("ud_id")
            m.a11_cantidad = r.Item("cantidad")
            m.a12_costo = r.Item("ud_costo")
            m.a13_Cdesc = r.Item("ud_cdesc")
            m.a14_cflete = r.Item("ud_cflete")
            m.a15_civa10 = r.Item("ud_iva10")
            m.a16_civa15 = r.Item("ud_iva15")
            m.a21_ub_cant = r.Item("ub_cantidad")
            m.a22_ub_costo = r.Item("ub_costo")
            m.a23_ub_Cdesc = r.Item("ub_cdesc")
            m.a24_ub_cflete = r.Item("ub_cflete")
            m.a25_ub_civa10 = r.Item("ub_iva10")
            m.a26_ub_civa15 = r.Item("ub_iva15")
            m.a31_signo = -1
            m.a32_caducidad = Now.Date
            m.a33_pieps = r.Item("pieps")
            m.a34_cos_ieps = r.Item("ieps")
            m.a36_ub_ieps = r.Item("ieps")

            result = agregar_movimiento(m)
            If result = False Then
                MsgBox("No se guardo el reg" + m.a07_idproducto.ToString)
            End If
            Me.Refresh()
        Next
        status1.Text = "Guardando Comentarios" : Me.Refresh()
        'actualiza la tabla de comentarios
        Dim adap As New admintegralDataSetTableAdapters.ComentariosTableAdapter
        adap.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, puertatxt.Text, Recibiotxt.Text, comentariotxt.Text)

        If Me.boton_laser.Enabled = True Then
            My.Forms.documentos_imprimir.cargar(tipoDoc, d.a01_Folio, " ")
            My.Forms.documentos_imprimir.Show()
            Exit Sub
        End If

        Dim ok As MsgBoxResult = MsgBoxResult.No
        While ok = MsgBoxResult.No
            imprimir_devolucion(d.a01_Folio, tipoDoc)
            ok = MsgBox("Se imprimio Bien?", MsgBoxStyle.YesNo, "Imprimir Devolucion")
        End While

    End Sub '********** Guarda documentos

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        totaliza()
        Dim ix As DialogResult = MsgBox("Guardar Devolucion?", MsgBoxStyle.YesNo, "Guardar")
        If ix = Windows.Forms.DialogResult.No Then Exit Sub
        guarda_documento(2) 'Guarda como devolicion a proveedor
        ix = MsgBox("Otra Devolucion?", MsgBoxStyle.YesNo, "Devolucion")
        If ix = Windows.Forms.DialogResult.No Then Me.Close()

        Me.facturatxt.Text = ""
        Me.comentariotxt.Text = ""
        Me.Recibiotxt.Text = ""
        mytable.Clear()
        totaliza()
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        id_provtxt.Text = gprov.id
        nombreprovtxt.Text = gprov.nombre
        piva.Text = gprov.iva
    End Sub ' Guardar documento

    Private Sub linea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles linea.KeyPress
        Dim cant, x, y As Integer, id As String
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            x = InStr(linea.Text, ".")
            y = InStr(linea.Text, "*") 'caja
            If x > 1 Then
                cant = linea.Text.Substring(0, x - 1)
                id = Mid(linea.Text, x + 1)
            Else
                If y > 1 Then
                    cant = linea.Text.Substring(0, y - 1)
                    id = Mid(linea.Text, y + 1)
                Else
                    cant = 1
                    id = linea.Text
                End If
            End If
            Dim ix As Integer, undcompra As Und
            If y > 1 Then
                ix = leer_id(id) ' Lee el id del producto seg
                If ix < 1 Then
                    MsgBox("No Existe")
                    linea.Text = ""
                    Exit Sub
                Else
                    undcompra = sk_leer_UndCompra(ix) 'determina unidad de compra segun su codigo
                End If
            Else
                ix = leer_id(id) ' Lee el id del producto seg
                If ix < 1 Then
                    MsgBox("No Existe")
                    linea.Text = ""
                    Exit Sub
                Else

                End If
            End If
            Dim catadap As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
            Dim odr As DataRow
            If y > 1 Then
                odr = catadap.GetDataByid(ix, undcompra.a9_uc_id).Rows(0)
            Else
                odr = catadap.GetDataByid(ix, 1).Rows(0)
            End If

            ' verifica si ya existe en la factura
            Dim alta As Boolean = False
            Dim ix1 As Integer
            For ix1 = 0 To mytable.Rows.Count - 1
                With mytable.Rows(ix1)
                    If .Item("id") = ix.ToString And .Item("ud_id") = odr("id_unidad") Then
                        cant += .Item("cantidad")
                        .Item("cantidad") = cant
                        totaliza()
                        linea.Text = ""
                        alta = True
                    End If
                End With
            Next
            If alta = False Then
                Dim dr As DataRow = mytable.NewRow

                dr("id") = odr("id_producto")
                dr("Codigo") = odr("Codigo")
                If odr("iva") > 0 Then
                    dr("iva") = piva.Text
                    dr("piva") = piva.Text
                Else
                    dr("iva") = 0
                    dr("piva") = 0
                End If
                dr("descripcion") = Trim(odr("Descripcion")) + IIf(odr("factor") <> 1, " (" + odr("factor").ToString + ")", "")
                dr("und") = odr("unidad")
                dr("factor") = odr("factor")
                dr("cantidad") = cant
                dr("ud_costo") = odr("costo")
                dr("ud_id") = odr("id_unidad")
                dr("pdesc") = 0
                dr("pieps") = odr("ieps")
                mytable.Rows.Add(dr)
                Try
                    Dim fileName As New System.IO.StreamWriter("C:\tmp\devoluc.tmp", True)
                    fileName.WriteLine(dr("id") + "," + dr("ud_id") + "," + cant.ToString)
                    fileName.Close()
                Catch ex As Exception

                End Try
            End If
            totaliza()
            If dgv.RowCount > dgv.DisplayedRowCount(False) Then
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - dgv.DisplayedRowCount(False) - 1
            End If
            Me.linea.Text = "" : Me.linea.Focus()
        End If
    End Sub '*************** LINEA DE CAPTURA

    Private Sub BuscarProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProductosToolStripMenuItem.Click
        My.Forms.Buscar_productos.ShowDialog()
        Me.linea.Text += producto.a7codigo
        SendKeys.Send("{enter}")
        linea.Focus()
    End Sub 'Buscar Producto

    Private Sub imprimir_devolucion(ByVal folio As String, ByVal tipoDoc As Integer)
        Dim l As String, j, pg As Integer, archivo As String = "", cc As String, nl As Integer = 0
        l = ""
        If tipoDoc = 2 Then archivo = "c:\tmp\dev" + folio + ".txt"
        If tipoDoc = 14 Then archivo = "c:\tmp\Cotidev" + folio + ".txt"
        Dim f As New System.IO.StreamWriter(archivo, False)
        cc = Microsoft.VisualBasic.Chr(27) + Microsoft.VisualBasic.Chr(15)
        pg = 0 : nl = 66
        f.WriteLine(cc)
        Dim r As DataRow
        Dim fcod, fdesc, funidad, fcant, funi, fimporte, fiva As String
        For j = 0 To mytable.Rows.Count - 1
            If nl >= 50 Then
                If pg > 0 Then
                    f.WriteLine("=============== ======================================== ===== ===== ========= ===========")
                    l = "Pag. " + pg.ToString : l = l.PadLeft(75) : f.WriteLine(l)
                End If
                If pg > 0 Then l = Microsoft.VisualBasic.Chr(12) : f.WriteLine(l)
                pg = pg + 1
                If tipoDoc = 2 Then l = cia.nombre.PadRight(70) + "Devolcion No. " + folio.ToString
                If tipoDoc = 14 Then l = cia.nombre.PadRight(70) + "Cotizacion de Devolcion No. " + folio.ToString
                f.WriteLine(l) : f.WriteLine("")
                f.WriteLine("Proveedor  : " + id_provtxt.Text + ".- " + nombreprovtxt.Text) 'Nombre
                l = "Factura / Referencia : " + facturatxt.Text : l = l.PadRight(80) + "Fecha  : " + Format(fechaDevolucion.Value, "dd/mm/yyyy")
                f.WriteLine(l) ' Numero/agente/comercial
                f.WriteLine("Comentarios : " + comentariotxt.Text) : nl = +1
                f.WriteLine("=============== ================================================== ====== ===== ========= ===========  ===")
                f.WriteLine("     Codigo             Descripcion                                Unid.  Cant.  Unitario    Importe   IVA")
                f.WriteLine("=============== ================================================== ====== ===== ========= ===========  ===")
                nl = 8
            End If
            r = mytable.Rows(j)
            fcod = Mid(r.Item("Codigo").ToString.PadRight(16), 1, 16)
            fdesc = Mid(r.Item("descripcion").ToString.PadRight(60), 1, 50)
            funidad = Mid(r.Item("und").ToString.PadRight(5), 1, 6)
            fcant = Mid(r.Item("Cantidad").ToString.PadLeft(5), 1, 5)
            Dim unitario As Single = r("ud_costo")
            funi = Format(unitario, "N2").PadLeft(9)
            fimporte = Format(CDbl(r("importe")), "N2").PadLeft(12)
            fiva = r.Item("piva").ToString
            l = fcod + fdesc + " " + funidad + " " + fcant + " " + funi + fimporte + "  " + fiva.PadLeft(3)
            f.WriteLine(l) : nl += 1
        Next j
        f.WriteLine("=============== ================================================== ====== ===== ========= ===========  ") : nl += 1
        'l = "Subtotal : ".PadLeft(86) + subtotaltxt.Text.PadLeft(15) : f.WriteLine(l) : nl += 1

        If sub0 > 0 Then l = "Exento : ".PadLeft(86) + Format(sub0, "N2").PadLeft(15) : f.WriteLine(l) : nl += 1
        If sub10 > 0 Then l = "Al " + Trim(My.Settings.iva.ToString) + "% : ".PadLeft(86) + Format(sub10, "N2").PadLeft(15) : f.WriteLine(l) : nl += 1
        If sub15 > 0 Then l = "Al " + Trim(My.Settings.iva2.ToString) + "% : ".PadLeft(86) + Format(sub15, "N2").PadLeft(15) : f.WriteLine(l) : nl += 1


        If Val(iva10txt.Text) > 0 Then
            l = "IVA " + Trim(My.Settings.iva.ToString) + "% : ".PadLeft(86) + iva10txt.Text.PadLeft(15) : f.WriteLine(l) : nl += 1
        End If
        If Val(IEPStxt.Text) > 0 Then
            l = "IVA " + Trim(My.Settings.iva2.ToString) + "% : ".PadLeft(86) + IEPStxt.Text.PadLeft(15) : f.WriteLine(l) : nl += 1
        End If
        l = "=============".PadLeft(101) : f.WriteLine(l) : nl += 1
        l = "Total : ".PadLeft(86) + totaltxt.Text.PadLeft(15) : f.WriteLine(l) : nl += 1
        If tipoDoc = 2 Then
            f.WriteLine("")
            f.WriteLine("Almacen :" + AlmacenComboBox.Text) : nl += 1
            f.WriteLine("Puerta : " + puertatxt.Text) : nl += 1
            f.WriteLine("")
            f.WriteLine("+==========================+==========================+==========================+=======================+")
            f.WriteLine("|         AUTORIZO         |      TRANSPORTISTA       |          ENCARGADO       |        ENTERADO       |")
            f.WriteLine("|                          |                          |          DE ALMACEN      |                       |")
            f.WriteLine("|                          |                          |                          |                       |")
            f.WriteLine("|                          |                          |                          |                       |")
            f.WriteLine("|                          |                          |                          |                       |")
            f.WriteLine("+==========================+==========================+==========================+=======================+")
        End If
        f.WriteLine(Microsoft.VisualBasic.Chr(12))
        '*********************   Enviar  *********************************
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.impresora_factura, archivo)
    End Sub '================== Imprimir Devolucion ======================

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_relacion.Click
        My.Forms.Devolucion_relacion.Show()
        Me.Close()
    End Sub 'Relacion de devoluciones

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub 'cerrar aplicacion


    Private Sub repetir_documento(ByVal td As Integer, ByVal folio As Integer, ByVal serie As String, ByVal borrar As Boolean)
        Dim adoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim lista As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        Dim prov As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        Dim coment As New admintegralDataSetTableAdapters.ComentariosTableAdapter
        Dim status As Integer, id As Integer, idud, cantidad As Integer
        Dim docum As DataRow, tablamov As New DataTable
        mytable.Clear()
        Dim catadap As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        jalada_td = 0 : jalada_folio = 0 : jalada_serie = ""
        Try
            docum = adoc.GetDataByKey(td, folio, serie).Rows(0)
        Catch ex As Exception
            MsgBox("No se encuantra ese documento")
            Exit Sub
        End Try
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        status = docum("status")
        Me.fechaDevolucion.Value = docum("fechafactura")
        Me.facturatxt.Text = docum("factura")
        id_provtxt.Text = docum("id_directorio")
        Me.nombreprovtxt.Text = prov.GetDataByID(id_provtxt.Text, 1).Rows(0).Item("nombre")
        AlmacenComboBox.SelectedIndex = docum("almacen")
        If td <> 13 Then
            jalada_td = td : jalada_folio = folio : jalada_serie = serie
            Me.Text = "Modificacion de la Devolucion No." + folio.ToString
        End If
        Try
            puertatxt.Text = coment.GetDataBykey(td, folio, serie).Rows(0).Item("puerta")
            Recibiotxt.Text = coment.GetDataBykey(td, folio, serie).Rows(0).Item("quien")
            comentariotxt.Text = coment.GetDataBykey(td, folio, serie).Rows(0).Item("comentarios")
        Catch ex As Exception

        End Try

        tablamov = amov.GetDataByKey(td, folio, serie)
        For j As Integer = 0 To tablamov.Rows.Count - 1
            id = tablamov.Rows(j).Item("id_prodcuto")
            idud = tablamov.Rows(j).Item("ud")
            cantidad = tablamov.Rows(j).Item("cantidad")
            Dim odr As DataRow
            odr = catadap.GetDataByid(id.ToString, idud.ToString).Rows(0)
            Dim dr As DataRow = mytable.NewRow
            dr("id") = odr("id_producto")
            dr("Codigo") = odr("Codigo")
            dr("iva") = odr("iva")
            dr("piva") = odr("iva")
            dr("descripcion") = Trim(odr("Descripcion")) + IIf(odr("factor") <> 1, " (" + odr("factor").ToString + ")", "")
            dr("und") = odr("unidad")
            dr("factor") = odr("factor")
            dr("cantidad") = cantidad
            dr("ud_costo") = tablamov.Rows(j).Item("costo")
            dr("ud_id") = odr("id_unidad")
            dr("pdesc") = 0
            mytable.Rows.Add(dr)
            Me.linea.Text = "" : Me.linea.Focus()
        Next
        totaliza()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub 'Carga a memoria documento y lo cancela o Borra

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_repetir.Click
        Dim ix As Integer
        Try
            ix = InputBox("Teclee el numero de Devolucion que quiere Modificar", "", "")
            repetir_documento(2, ix, "", False)
            jalada_td = 0 : jalada_folio = 0 : jalada_serie = ""
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BuscarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProveedorToolStripMenuItem.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        id_provtxt.Text = gprov.id
        nombreprovtxt.Text = gprov.nombre
        piva.Text = gprov.iva
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim ix As MsgBoxResult = MsgBox("Quiere Borrar este Renglon", MsgBoxStyle.YesNo, "Borrar Renglon")
        If ix = MsgBoxResult.Yes Then
            bs.RemoveCurrent()
            mytable.AcceptChanges()
        End If
    End Sub


    Private Sub LeerCotizacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeerCotizacionToolStripMenuItem.Click
        Dim ix As Integer
        Try
            ix = InputBox("Teclee el numero de Cotizacion que quiere Leer", "", "")
            repetir_documento(14, ix, "", False)
            jalada_td = 0 : jalada_folio = 0 : jalada_serie = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarCotizacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCotizacionToolStripMenuItem.Click
        totaliza()
        Dim ix As DialogResult = MsgBox("Guardar COTIZACION de Devolucion?", MsgBoxStyle.YesNo, "Guardar")
        If ix = Windows.Forms.DialogResult.No Then Exit Sub
        guarda_documento(14) 'Guarda como devolicion a proveedor
    End Sub

    Private Sub CargarDevolucEnTiendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarDevolucEnTiendaToolStripMenuItem.Click
        Me.tool1.Visible = False

        txtfolio.Focus()
    End Sub

    Private Sub tool1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool1.VisibleChanged
        Me.GuardarCotizacionToolStripMenuItem.Visible = tool1.Visible
        Me.boton_relacion.Visible = tool1.Visible
        Me.boton_repetir.Visible = tool1.Visible
        Me.boton_suspender.Visible = tool1.Visible
        Me.boton_salir.Visible = tool1.Visible
        Me.GuardarToolStripButton.Visible = tool1.Visible

        Me.lblFolio.Visible = Not tool1.Visible
        Me.txtfolio.Visible = Not tool1.Visible
        Me.boton_esc.Visible = Not tool1.Visible
        Me.boton_buscar.Visible = Not tool1.Visible
    End Sub

    Private Sub boton_esc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_esc.Click
        Me.tool1.Visible = True
    End Sub

    
    Private Sub txtfolio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfolio.KeyPress
        If e.KeyChar = chr13 Then
            If txtfolio.TextLength < 1 Then Exit Sub
            Dim f, s As String
            s = Mid(txtfolio.Text, 1, 1)
            f = Mid(txtfolio.Text, 2)
            Try
                repetir_documento(13, f, s, False)
            Catch ex As Exception

            End Try

            jalada_td = 0 : jalada_folio = 0 : jalada_serie = ""
            Me.tool1.Visible = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            tool1.Visible = True
        End If
    End Sub ' teclear folio a recuperar

    Private Sub boton_laser_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_laser.EnabledChanged
        Me.boton_matris.Enabled = Not Me.boton_laser.Enabled
    End Sub

    Private Sub boton_laser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_laser.Click
        Me.boton_laser.Enabled = Not Me.boton_laser.Enabled
    End Sub

    Private Sub boton_matris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_matris.Click
        Me.boton_laser.Enabled = Not Me.boton_laser.Enabled
    End Sub

   
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        mytable.Clear() : totaliza()

    End Sub


    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_buscar.Click
        Dim S, cmd As String
        S = InputBox("Teclee la serie", "", "")
        cmd = "SELECT Folio, serie,  Almacen, id_directorio as ID, rtrim(Nombre) AS Provedor, fechafactura, Importe FROM sql_documentos " _
        & "WHERE td = 13 AND serie = '" + S + "' ORDER BY fechafactura DESC"
        My.Forms.ver_dev_tienda.caragr(cmd)
        My.Forms.ver_dev_tienda.ShowDialog()
        txtfolio.Text = My.Forms.ver_dev_tienda.resultado
    End Sub
End Class