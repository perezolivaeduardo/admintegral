Public Class Entreada_nueva
    Dim mytable As New DataTable
    Public npedido As Integer = 0
    Dim condiferencias As Boolean = False
    Public WithEvents dgv As New MiGrid
    Dim cjfolio As Integer, cjserie As String
    Dim nrow As Integer
    Dim tblcambios As New DataTable
    Dim nfolio As Single
    Dim bs As New BindingSource
    Dim factor_iva1_venta As String
    Dim factor_iva2_venta As String

    Private Sub Entreada_nueva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.iva
        factor_iva1_venta = (My.Settings.iva / 100).ToString 'iva10
        factor_iva2_venta = (My.Settings.iva2 / 100).ToString 'iva15

        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        Me.id_provtxt.Text = gprov.id
        Me.nombreprovtxt.Text = gprov.nombre
        Me.diasc.Text = gprov.dias
        piva.Text = 0
        crear_grid()
        If npedido > 0 Then cargar_pedido()
    End Sub '***** CARGAR FORMA*******

    Private Sub crear_grid()
        mytable.TableName = "Entrada"
        Dim column = New DataColumn()
        column = New DataColumn("id", System.Type.GetType("System.Int32"))
        tblcambios.Columns.Add(column)        ' Add the Column to the DataColumnCollection.
        column = New DataColumn("UB", System.Type.GetType("System.Int32"))
        tblcambios.Columns.Add(column)        ' Add the Column to the DataColumnCollection.
        column = New DataColumn("Descripcion", System.Type.GetType("System.String"))
        tblcambios.Columns.Add(column)
        column = New DataColumn("actual", System.Type.GetType("System.Decimal"))
        column.caption = "Costos Actual"
        tblcambios.Columns.Add(column)
        column = New DataColumn("nuevo", System.Type.GetType("System.Decimal"))
        column.caption = "Nuevo Costos"
        tblcambios.Columns.Add(column)
        column = New DataColumn("margen", System.Type.GetType("System.Int32"))
        tblcambios.Columns.Add(column)        ' Add the Column to the DataColumnCollection.
        column = New DataColumn("Vactual", System.Type.GetType("System.Decimal"))
        column.caption = "Vta. Actual("")"
        tblcambios.Columns.Add(column)
        column = New DataColumn("Vta. Nuevo", System.Type.GetType("System.Decimal"))
        column.caption = "Vta. nuevo"
        tblcambios.Columns.Add(column)
        ' dgvcambios.DataSource = tblcambios
        '=======================================================================================================
        AddHandler dgv.CellEndEdit, AddressOf dgv_CellEndEdit
        AddHandler dgv.CellDoubleClick, AddressOf dgv_CellDoubleClick
        ' AddHandler dgv.ce, AddressOf dgv_CellDoubleClick
        '   AddHandler dgv.CellEnter, AddressOf dgv_CellEnter
        dgv.Parent = Me
        dgv.Dock = DockStyle.Fill
        dgv.Parent = Me.SplitContainer2.Panel1
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Declare variables for DataColumn and DataRow objects.

        ' Create new DataColumn, set DataType, ColumnName 
        column = New DataColumn("codigo", System.Type.GetType("System.String"))
        column.Caption = "Codigo" : column.Unique = False
        mytable.Columns.Add(column)

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
        column.Expression = "iif (iva>0, 15,0)"
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
        column.Caption = "Cant" : column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "ud_Costo"
        column.Caption = "Costo" : column.DefaultValue = 0
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
        column.ReadOnly = True : column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_CFlete"
        column.Caption = "Flete"
        column.DefaultValue = 0 : column.DefaultValue = 0
        column.ReadOnly = True
        mytable.Columns.Add(column)

        column = New DataColumn() 'cOSTOS nETO
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_Cneto"
        column.Caption = "Neto" : column.DefaultValue = 0
        column.Expression = "ud_costo - UD_CDesc"
        mytable.Columns.Add(column)

        column = New DataColumn() 'IMPORTE
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Importe"
        column.Caption = "Importe" : column.DefaultValue = 0
        column.Expression = "cantidad * ud_Costo"
        mytable.Columns.Add(column)

        ' Create new DataColumn, set DataType, ColumnName 
        column = New DataColumn("Comentarios", System.Type.GetType("System.String"))
        column.Caption = "Comentarios" : column.Unique = False
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


        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_costo_base"
        column.DefaultValue = 0
        mytable.Columns.Add(column)



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
        column.Expression = "iif (piva=" + My.Settings.iva.ToString + ", ud_costo * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cal15"
        column.Expression = "iif (piva=" + My.Settings.iva2.ToString + ", ud_costo * cantidad,0)"
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
        column.Expression = "iif (iva=" + My.Settings.iva2.ToString + ", ud_cdesc * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "id_uc"
        column.DefaultValue = 0
        mytable.Columns.Add(column)


        'asigna la abla al datagrid

        dgv.DataSource = mytable
        ' Oculta columnas de calculo
        dgv.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv.Columns("id").ReadOnly = True
        dgv.Columns("Descripcion").ReadOnly = True
        dgv.Columns("und").ReadOnly = True
        dgv.Columns("Factor").ReadOnly = True
        dgv.Columns("UB_und").ReadOnly = False

        '**********************************************************************

        dgv.Columns("Importe").DefaultCellStyle.Format = "N2"
        dgv.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("ud_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("ub_und").Visible = False
        dgv.Columns("ud_costo_base").Visible = False
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

        dgv.Columns("id_uc").Visible = False
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

        Me.ErrorProvider1.DataSource = dgv.DataSource
        If npedido = 0 Then
            For j As Integer = 0 To 30
                Dim drr As DataRow
                drr = mytable.NewRow
                mytable.Rows.Add(drr)
            Next
        End If
    End Sub 'crea el grid

    Private Sub cargar_pedido()
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim j As Integer
        Dim cmd As String
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT   Pedidos_detalle.id_producto as id, productos.Descripcion as Descripcion, productos.iva as iva, Pedidos_detalle.iduC as id_uc, Pedidos_detalle.uB  as ub_und, Pedidos_detalle.uC as und, Pedidos_detalle.factorC as factor, Pedidos_detalle.pedido as cantidad, Pedidos_detalle.costoPedido as ud_costo, Pedidos_detalle.pedido as ped_cantidad, Pedidos_detalle.costoPedido as ud_costo, dbo.Unidades_productos.Codigo "
        cmd = cmd + " FROM dbo.Pedidos_detalle INNER JOIN " & _
        " dbo.productos ON dbo.Pedidos_detalle.id_producto = dbo.productos.id_Producto INNER JOIN " & _
        " dbo.Unidades_productos ON dbo.Pedidos_detalle.id_producto = dbo.Unidades_productos.id_producto AND " & _
        " dbo.Pedidos_detalle.iduC = dbo.Unidades_productos.id_unidad "
        cmd = cmd + " WHERE  Pedidos_detalle.pedido >0 and (Pedidos_detalle.id_pedido = " + npedido.ToString + ")"
        Me.Text = "Entrad del Pedido No." + npedido.ToString

        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        'Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.Fill(tbl)
        If tbl.Rows.Count = 0 Then MsgBox("No Existe") : Exit Sub
        For j = 0 To tbl.Rows.Count - 1
            mytable.ImportRow(tbl.Rows(j))
        Next
        totaliza()
    End Sub ' lee el pedido

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

   

    Private Sub pdesctext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pdesctext.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub totaliza()
        Try
            subtotaltxt.Text = Format(mytable.Compute("sum(importe)", ""), "N2")
            descuentotxt.Text = Format(mytable.Compute("sum(subdesc)", ""), "N2")
            iva10txt.Text = Format(mytable.Compute("sum(subiva10)", ""), "N2")
            iva15txt.Text = Format(mytable.Compute("sum(subiva15)", ""), "N2")
            totaltxt.Text = Format(CDbl(subtotaltxt.Text) - CDbl(descuentotxt.Text) + CDbl(iva10txt.Text) + CDbl(iva15txt.Text), "N2")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub '************ TOTALIZAR

    Private Sub pedir_producto()
        Dim x As DialogResult
        x = My.Forms.Buscar_productos.ShowDialog
        Try
            If producto.a1id > 0 Then
                '  My.Forms.Buscar_productos.ShowDialog()
                Dim u As Und
                u = sk_leer_UndCompra(producto.a1id)
                Me.dgv.CurrentRow.Cells("id").Value = producto.a1id
                dgv.CurrentRow.Cells("Descripcion").Value = producto.a2descripcion
                dgv.CurrentRow.Cells("factor").Value = producto.a3factor
                dgv.CurrentRow.Cells("und").Value = producto.a4uc
                dgv.CurrentRow.Cells("ub_und").Value = producto.a5ub
                dgv.CurrentRow.Cells("iva").Value = producto.a6iva
                dgv.CurrentRow.Cells("ud_Costo").Value = u.a4_costo
                dgv.CurrentRow.Cells("codigo").Value = producto.a7codigo
                dgv.CurrentRow.Cells("id_uc").Value = u.a1_id
                
dgv.CurrentRow.Cells("ud_Costo_base").Value = u.a4_costo
                My.Computer.Keyboard.SendKeys("{enter}")
            End If
        Catch ex As Exception
        End Try
    End Sub ' Pide un producto desde buscar productos

    Private Sub guarda_documento()
        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim adapund As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Dim result As Boolean
        Dim d As New Mi_Documento
        Dim r As DataRow
        Dim j, jj As Integer, newc As Double

        Dim f As Long
        Try
            f = afolio.siguiente(1, "")
        Catch ex As Exception
            f = 1
        End Try

        status1.Text = "Guardando Documentos"
        barra.Maximum = dgv.Rows.Count
        barra.Value = 1
        d.a00_id_doc = 1
        d.a01_Folio = f
        d.a02_serie = " "
        d.a03_Almacen = Me.AlmacenComboBox.SelectedValue
        d.a04_id_directorio = Me.id_provtxt.Text
        d.a05_tipo_directorio = 1
        d.a06_fecha_registro = Date.Now.ToString
        d.a07_Folio_pedido = npedido
        d.a08_factura = Me.facturatxt.Text
        d.a09_fecha_factura = CDate(fechafactura.Value.ToString)
        d.a10_fecha_surtido = CDate(fechaEntrada.Value.Date)
        d.a11_fecha_vence = fechavence.Value.ToString
        d.a12_pdesc = CDbl(Me.pdesctext.Text)
        d.a13_flete = CDbl(Me.fletetxt.Text)
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
        d.a26_diasc = Val(Me.diasc.Text)
        d.a27_pviva = Me.piva.Text
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
            If r.Item("cantidad") > 0 Then
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
                m.a10_ud = r.Item("id_uc")
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
                m.a31_signo = 1
                result = agregar_movimiento(m)
                If result = False Then

                End If
                If r.Item("ud_costo") > r.Item("ud_costo_base") Then
                    'Actualiza Costos
                    Dim cmdtbl As String = "Select * from unidades_productos where id_producto= " + m.a07_idproducto.ToString
                    Dim tbl As DataTable = leer_tabla(cmdtbl)
                    If tbl.Rows.Count > 0 Then
                        For jj = 0 To tbl.Rows.Count - 1
                            Try
                                newc = r.Item("ub_costo") * tbl.Rows(jj).Item("unidades")
                                adapund.Actualiza_Costo(newc, m.a07_idproducto, tbl.Rows(jj).Item("id_unidad"))
                            Catch ex As Exception

                            End Try
                        Next jj
                    End If
                End If
            End If

            Me.Refresh()
        Next
        status1.Text = "Guardando Comentarios"
        Me.Refresh()
        nfolio = d.a01_Folio
        'actualiza la tabla de comentarios
        Dim adap As New admintegralDataSetTableAdapters.ComentariosTableAdapter
        adap.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, puertatxt.Text, Recibiotxt.Text, comentariotxt.Text)

        If npedido > 0 Then
            status1.Text = "Actualizando Pedido"
            Dim status As Integer
            Dim adap1 As New admintegralDataSetTableAdapters.pedidosTableAdapter
            status = 12 : If condiferencias = True Then status = 13
            Try
                adap1.actualiza_entrada(d.a01_Folio, status, npedido)
            Catch ex As Exception

            End Try
            actualiza_pedido()
        End If

    End Sub ' Guarda documentos

    Private Sub actualiza_pedido()
        If npedido > 0 Then
            Dim adap As New admintegralDataSetTableAdapters.Pedidos_detalleTableAdapter
            Dim e, c As Double, j, id As Integer, comentario As String
            barra.Maximum = mytable.Rows.Count - 1
            For j = 0 To mytable.Rows.Count - 1
                barra.Value = j
                Try
                    id = mytable.Rows(j).Item("id").Value
                    e = mytable.Rows(j).Item("cantidad").Value
                    c = mytable.Rows(j).Item("ud_cneto").Value
                    comentario = mytable.Rows(j).Item("cantidad").ToolTipText + ","
                    comentario += mytable.Rows(j).Item("ud_cneto").ToolTipText
                    adap.ped_mov_Updateentrada(e, c, comentario, npedido, id, npedido, id)
                Catch ex As Exception

                End Try
            Next
        End If

    End Sub ' Actualiza pedido


    Private Sub leer_producto(ByVal dt As DataRow)
        Try
            producto.a1id = dt.Item("id_producto").ToString
            producto.a2descripcion = dt.Item("Descripcion").ToString
            producto.a3factor = dt.Item("factorc").ToString
            producto.a4uc = dt.Item("uc").ToString
            producto.a5ub = dt.Item("ub_und").ToString
            producto.a6iva = dt.Item("iva").ToString
            producto.a7codigo = dt.Item("codigo").ToString
            producto.a8costo = dt.Item("costoc")
            dgv.CurrentRow.Cells("id").Value = producto.a1id
            dgv.CurrentRow.Cells("Descripcion").Value = producto.a2descripcion
            dgv.CurrentRow.Cells("factor").Value = producto.a3factor
            dgv.CurrentRow.Cells("und").Value = producto.a4uc
            dgv.CurrentRow.Cells("ud_costo").Value = producto.a8costo
            dgv.CurrentRow.Cells("ud_costo_base").Value = producto.a8costo
            dgv.CurrentRow.Cells("ub_und").Value = producto.a5ub
            dgv.CurrentRow.Cells("iva").Value = producto.a6iva
            dgv.CurrentRow.Cells("id_uc").Value = dt.Item("iduc")
            mytable.AcceptChanges()
        Catch ex As Exception
            MsgBox("Error al leer producto")
            MsgBox(ex.Message)
        End Try

    End Sub

    '****************************************************************************************************
    '**********              DATA GRID DGV                                                      *********
    '****************************************************************************************************

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = 6 Then
            Dim mf As Integer = dgv.CurrentCell.Value
            Dim ix As MsgBoxResult = MsgBox("Cambiar a este producto a Undidad Base?", MsgBoxStyle.YesNo, "Cambiar Unidad")
            If ix = MsgBoxResult.Yes Then
                dgv.CurrentCell.Value = 1
                dgv.CurrentRow.Cells("ud_costo").Value = dgv.CurrentRow.Cells("ub_costo").Value
                dgv.CurrentRow.Cells("ud_costo_base").Value = dgv.CurrentRow.Cells("ub_costo").Value
                mytable.AcceptChanges()
                totaliza()
                dgv.CurrentCell = dgv.CurrentRow.Cells(8)
            End If
            Exit Sub
        End If
        If dgv.CurrentCellAddress.X = 0 Then
            pedir_producto()
        End If
    End Sub

    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = 0 Then ' Columna Codigo
            Dim ix As Integer, id As String
            id = dgv.CurrentRow.Cells(0).Value.ToString '
            producto.a1id = 0
            ix = leer_id(id) ' Lee el id del producto seg
            Dim undcompra As Und
            If ix < 1 Then
                ix = leer_cod_prov(id, id_provtxt.Text) ' busca por codigo de proveedor
            End If
            If ix < 0 Then
                MsgBox("No existe")
                Exit Sub
            Else
                undcompra = sk_leer_UndCompra(ix) 'determina unidad de compra segun su codigo
            End If
            Dim catadap As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
            Dim dr As DataRow = mytable.NewRow
            Dim odr As DataRow
            odr = catadap.GetDataid(ix, undcompra.a9_uc_id).Rows(0)
            ix = catbs.Find("codigo", odr("codigo"))
            leer_producto(tabla_catalogo.Rows(ix))
            'My.Computer.Keyboard.SendKeys("{enter}")
            'My.Computer.Keyboard.SendKeys("{enter}")
            'My.Computer.Keyboard.SendKeys("{enter}")
            'My.Computer.Keyboard.SendKeys("{enter}")
            dgv.CurrentCell = dgv.CurrentRow.Cells("und")

            Exit Sub
        End If
        checar_cambios()
        If npedido = 0 Then totaliza() : Exit Sub ' validaciones cuando se recibe pedido
        '======================================================================
        'If dgv.CurrentCellAddress.X = dgv.Columns("cantidad").Index Then

        Try
            Dim ent, ped As Integer, msg As String
            ent = dgv.CurrentRow.Cells("cantidad").Value
            ped = dgv.CurrentRow.Cells("ped_cantidad").Value
            If ent = ped Then dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.GreenYellow : Exit Sub
            If ent > ped Then
                msg = "Se pidieron " + ped.ToString + ", LLegaron " + Str$(ent - ped) + " de Mas"
                Dim dt As DataTable = DirectCast(ErrorProvider1.DataSource, DataTable)
                dt.Rows(e.RowIndex).SetColumnError(0, msg)
                'dgv.CurrentCell.ToolTipText = msg
                'dgv.CurrentCell.Style.BackColor = Color.Red
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                condiferencias = True
            Else
                msg = "Se pidieron " + ped.ToString + ", LLegaron " + Str$(ped - ent) + " de Menos"
                Dim dt As DataTable = DirectCast(ErrorProvider1.DataSource, DataTable)
                dt.Rows(e.RowIndex).SetColumnError(0, msg)
                'dgv.CurrentCell.ToolTipText = msg
                'dgv.CurrentCell.Style.BackColor = Color.Yellow
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
                condiferencias = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' End If
        totaliza()
    End Sub

    Private Sub dgv_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
       
    End Sub ' termina la edicion de celda, verifica cambio de precio y valor pedido.

    Private Sub dgv_CellEndEdit1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        mytable.AcceptChanges()
        'If e.ColumnIndex = 0 Then dgv.CurrentCell = dgv.CurrentRow.Cells("und")
        totaliza()
    End Sub

    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = Keys.F3 Then
            If dgv.CurrentCellAddress.X = 0 Then
                pedir_producto()
                'My.Computer.Keyboard.SendKeys("{enter}")
                'My.Computer.Keyboard.SendKeys("{enter}")
                'My.Computer.Keyboard.SendKeys("{enter}")
                'My.Computer.Keyboard.SendKeys("{enter}")
                'My.Computer.Keyboard.SendKeys("{enter}")
                If dgv.CurrentCell.ColumnIndex < 2 Then dgv.CurrentCell = dgv.CurrentRow.Cells("factor")
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If dgv.CurrentCell.ColumnIndex < 2 Then dgv.CurrentCell = dgv.CurrentRow.Cells("factor")
        End If
    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        Try
        Catch ex As Exception
        End Try
    End Sub

    Public Class MiGrid
        Inherits DataGridView

        Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
            Dim key As Keys = (keyData And Keys.KeyCode)
            If key = Keys.Enter Then
                Return Me.ProcessRightKey(keyData)
            End If
            Return MyBase.ProcessDialogKey(keyData)
            'comentado()
        End Function

        Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
            If (e.KeyCode = Keys.Enter) Then

                Return Me.ProcessRightKey(e.KeyData)
            End If
            Return MyBase.ProcessDataGridViewKey(e)
        End Function
    End Class

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        totaliza()
        guarda_documento()
        If cjfolio > 0 Then
            Dim adoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
            Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
            adoc.UpdateStatus(9, user.id, 12, cjfolio, cjserie)
            adoc.Dispose() : amov.Dispose()
        End If
        My.Forms.documentos_imprimir.cargar(1, nfolio, " ")
        My.Forms.documentos_imprimir.Show()
        tblcambios.Clear()
        mytable.Clear()
        For j As Integer = 0 To 30
            Dim drr As DataRow
            drr = mytable.NewRow
            mytable.Rows.Add(drr)
        Next
    End Sub 'Guarda e Imprime

    Private Sub dgv_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEnter


        If e.ColumnIndex > 9 Then ' Columna Codigo
            SendKeys.Send("{left}")
            SendKeys.Send("{left}")
            SendKeys.Send("{left}")
            SendKeys.Send("{left}")
            SendKeys.Send("{left}")
            SendKeys.Send("{left}")
            SendKeys.Send("{left}")
            SendKeys.Send("{left}")
            SendKeys.Send("{left}")
            SendKeys.Send("{down}")
            Exit Sub
        End If
    End Sub

    Private Sub Cargar_entrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cargar_entrada.Click
        Dim cmd As String
        cmd = "SELECT cajas.Nombre as tienda, Documentos.Folio, documentos.serie , Documentos.id_directorio, Directorio.Nombre, documentos.factura, documentos.importe, documentos.fechafactura, documentos.fechasurtido, documentos.vence , cajas.almacen as almacen "
        cmd += " from Documentos INNER JOIN Directorio ON Documentos.id_directorio = Directorio.id_directorio INNER JOIN cajas ON Documentos.ncaja = cajas.id_caja "
        cmd = cmd + " WHERE Directorio.tipo = 1 AND Documentos.td = 12 and Documentos.status=0"
        Dim tmptbl As DataTable = leer_tabla(cmd)
        Me.SplitContainer0.Visible = False
        bs.DataSource = tmptbl
        Me.dgventrada.DataSource = bs
        'For j As Integer = 5 To 7 : Me.dgventrada.Columns(j).Visible = False : Next j
    End Sub ' Cargar tabla

    Private Sub Boton_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Cerrar.Click
        lblcaja.Visible = False
        Me.SplitContainer0.Visible = True
    End Sub

    Private Sub boton_seleccioanr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_seleccioanr.Click
        Dim f As Integer, s As String
        Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        If dgventrada.CurrentRow.Index >= 0 Then
            With dgventrada.CurrentRow
                Me.AlmacenComboBox.SelectedValue = .Cells("almacen").Value
                Me.id_provtxt.Text = .Cells(3).Value
                Me.nombreprovtxt.Text = Trim(adap.GetDataByID(.Cells(3).Value, 1).Rows(0).Item("Nombre").ToString)
                Me.facturatxt.Text = .Cells(5).Value
                Me.fechaEntrada.Value = .Cells("fechafactura").Value
                Me.fechafactura.Value = .Cells("fechasurtido").Value
                Me.fechavence.Value = .Cells("vence").Value
                f = .Cells(1).Value
                s = .Cells(2).Value
                cargar_entrada_tienda(12, f, s)
                Me.SplitContainer0.Visible = True
                cjfolio = f : cjserie = s
                lblcaja.Visible = True
                totaliza()
            End With
        End If
    End Sub 'selecciona entrada pendiente

    Private Sub cargar_entrada_tienda(ByVal td As Integer, ByVal folio As Integer, ByVal serie As String)
        Dim prod As New admintegralDataSetTableAdapters.productosTableAdapter
        Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim unid As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Dim tablamov As New DataTable
        tablamov = amov.GetDataByKey(td, folio, serie)
        Dim id, idud, cantidad, iva As Integer, costo As Single
        mytable.Clear()
        For j As Integer = 0 To tablamov.Rows.Count - 1
            id = tablamov.Rows(j).Item("id_prodcuto")
            idud = tablamov.Rows(j).Item("ud")
            cantidad = tablamov.Rows(j).Item("cantidad")
            costo = tablamov.Rows(j).Item("costo")
            iva = tablamov.Rows(j).Item("piva")
            Dim rwprod As DataRow

            If id > 0 Then
                rwprod = prod.GetDataById(id).Rows(0)
                Dim uni As Und = sk_leer_UndCompra(id)
                Dim dr As DataRow = mytable.NewRow
                dr("id") = id
                dr("iva") = iva
                dr("id_uc") = idud
                dr("descripcion") = Trim(rwprod("descripcion"))
                dr("und") = uni.a6_ub_unidad
                dr("factor") = 1
                dr("cantidad") = cantidad
                dr("ud_costo") = costo
                dr("pdesc") = 0
                dr("codigo") = unid.Getcodigobyid(id, 1).Rows(0).Item("codigo")
                mytable.Rows.Add(dr)
            End If
        Next
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        My.Forms.frm_productos.Show()
        My.Forms.frm_productos.WindowState = FormWindowState.Maximized
    End Sub

  
    Private Sub boton_cambios_de_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cambios_de_precios.Click
        Dim adapcat As New admintegralDataSetTableAdapters.productosTableAdapter
        Dim margen As Integer
        tblcambios.Clear()
        For j As Integer = 0 To mytable.Rows.Count - 1
            With mytable.Rows(j)
                If .Item("ud_costo") <> .Item("ud_costo_base") Then
                    margen = adapcat.GetDataById(.Item("id")).Rows(0).Item("margen")
                    Dim dt As DataRow
                    dt = tblcambios.NewRow
                    dt("id") = .Item("id")
                    dt("ub") = .Item("id_uc")
                    dt("descripcion") = .Item("descripcion")
                    dt("margen") = margen
                    dt("actual") = .Item("ud_costo_base")
                    dt("nuevo") = .Item("ud_Costo")
                    tblcambios.Rows.Add(dt)
                End If
            End With
        Next
        dgvcambio.DataSource = tblcambios
        dgvcambio.Visible = True
        dgv.Visible = False
    End Sub 'Muestra la tabla

    Private Sub checar_cambios()
        mytable.AcceptChanges()
        For j As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows(j).Cells("Comentarios").Value = ""
            If dgv.Rows(j).Cells("ud_costo").Value > dgv.Rows(j).Cells("ud_costo_base").Value Then
                dgv.Rows(j).DefaultCellStyle.ForeColor = Color.Red
                Dim msg As String = "Cambio de " + Format(dgv.Rows(j).Cells("ud_costo_base").Value, "N2") + " a " + Format(dgv.Rows(j).Cells("ud_costo").Value, "N2")
                dgv.Rows(j).Cells("Comentarios").Value = msg
            End If
        Next
    End Sub ' verifica cambios de precio.

  
    Private Sub dgvcambios_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Dim id As String
        'id = Me.dgvcambios.CurrentRow.Cells(0).Value.ToString
        'Dim cmd As String = "select * from unidades_productos where id_producto =" + id
        'Dim tabla As New DataTable
        'tabla = leer_tabla(cmd)
        'Me.dgvprecios.DataSource = tabla
    End Sub

    Private Sub fechaEntrada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaEntrada.ValueChanged
        Try
            If Val(diasc.Text) > 0 Then
                Me.fechavence.Value = fechaEntrada.Value.AddDays(diasc.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub 'Calcula Vencimiento

    Private Sub dgv_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved
        totaliza()
    End Sub ' totaliza si borra una row 

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgv.Columns("iva").Visible = True
        dgv.Columns("piva").Visible = True
        dgv.Columns("ud_iva10").Visible = True
        dgv.Columns("ud_iva15").Visible = True
    End Sub

    Private Sub boton_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_proveedor.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'My.Forms.Entreada_nueva.MdiParent = Me
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.id_provtxt.Text = gprov.id
        Me.nombreprovtxt.Text = gprov.nombre
        Me.diasc.Text = gprov.dias
        piva.Text = gprov.iva
    End Sub

    Private Sub boton_relacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_relacion.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.Entradas_relacion.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub id_provtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id_provtxt.KeyPress
        If e.KeyChar = chr13 Then
            Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
            Dim r As DataRow, id As Integer
            id = id_provtxt.Text
            r = adap.GetDataByID(id, 1).Rows(0)
            Me.nombreprovtxt.Text = r.Item("Nombre")
            Me.diasc.Text = r.Item("dias")
            Me.piva.Text = r.Item("iva")
        End If
    End Sub

    Private Sub piva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piva.TextChanged
        Try
            If piva.Text = "15" Then mytable.Columns("piva").Expression = "iif (iva>0, 15,0)"
            If piva.Text = "10" Then mytable.Columns("piva").Expression = "iif (iva>0, 10,0)"
            If piva.Text = "0" Then mytable.Columns("piva").Expression = "iif (iva>0, 0,0)"
            mytable.AcceptChanges()
            dgv.Refresh()
            totaliza()
        Catch ex As Exception

        End Try

    End Sub 'cambio de Iva

    Private Sub fletetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fletetxt.TextChanged

    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_save.Click
        Dim filename As String
        Me.SaveFileDialog.ShowDialog()
        filename = Me.SaveFileDialog.FileName
        '  mytable.WriteXmlSchema(filename)
        mytable.WriteXml(filename)
    End Sub

    Private Sub boton_abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_abrir.Click
        Dim filename As String
        Me.OpenFileDialog.ShowDialog()
        filename = Me.OpenFileDialog.FileName
        'mytable.ReadXmlSchema(filename)
        mytable.Clear()
        mytable.ReadXml(filename)
        mytable.AcceptChanges()
        dgv.DataSource = mytable
    End Sub

    Private Sub ToolStripButton2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        cargar_catalogo()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        dgv.Columns("iva").Visible = True
        dgv.Columns("piva").Visible = True
        dgv.Columns("iva").Visible = True
        dgv.Columns("piva").Visible = True

        dgv.Columns("ud_iva10").Visible = True
        dgv.Columns("ud_iva15").Visible = True
    End Sub

    Private Sub buscartxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscartxt.TextChanged
        Dim f As String
        If buscartxt.TextLength > 0 Then
            f = "tienda like '%" + buscartxt.Text + "%' or nombre like '%" + buscartxt.Text + "%' or factura like '%" + buscartxt.Text + "%'"
            bs.Filter = f
        Else
            bs.Filter = ""
        End If

    End Sub
End Class