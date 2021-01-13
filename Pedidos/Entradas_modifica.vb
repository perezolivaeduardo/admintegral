
Public Class Entreadas_modifica
    Dim mytable As New DataTable
    Public npedido As Integer = 0
    Public nentrada As Integer = 0
    Dim condiferencias As Boolean = False
    Private WithEvents dgv As New DataGridView
    'Private dgv As New DataGridView
    Dim factor_iva1_venta As String
    Dim factor_iva2_venta As String


    Private Sub Entreada_nueva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        factor_iva1_venta = (My.Settings.iva / 100).ToString 'iva10
        factor_iva2_venta = (My.Settings.iva2 / 100).ToString 'iva15

        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        Me.id_provtxt.Text = gprov.id
        Me.nombreprovtxt.Text = gprov.nombre
        piva.SelectedIndex = 0
        crear_grid()
        If npedido > 0 Then cargar_pedido()
    End Sub '***** CARGAR FORMA*******

    Private Sub crear_grid()
        AddHandler dgv.CellEndEdit, AddressOf dgv_CellEndEdit
        AddHandler dgv.CellDoubleClick, AddressOf dgv_CellDoubleClick
        dgv.Parent = Me.SplitContainer2.Panel1
        dgv.VirtualMode = True
        dgv.Dock = DockStyle.Fill

        ' Declare variables for DataColumn and DataRow objects.
        Dim column As New DataColumn

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
        column.Expression = "iif(piva=" + My.Settings.iva.ToString + ",ud_cneto*" + factor_iva1_venta.tostring + ",0)"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_iva15"
        column.Caption = "*" + column.ColumnName
        column.Expression = "iif(piva=" + My.Settings.iva2.ToString + ",ud_cneto*" + factor_iva2_venta.tostring + ",0)"
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
        column.Expression = "iif (iva=" + My.Settings.iva2.ToString + ", ud_cdesc * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "id_uc"
        column.DefaultValue = 0
        mytable.Columns.Add(column)


        '**********************************************************************
        'asigna la abla al datagrid
        dgv.DataSource = mytable
        ' Oculta columnas de calculo
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv.Columns("id").ReadOnly = True
        dgv.Columns("Descripcion").ReadOnly = True
        dgv.Columns("und").ReadOnly = True
        dgv.Columns("Factor").ReadOnly = True
        dgv.Columns("UB_und").ReadOnly = True



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
        dgv.Columns("ub_cantidad").Visible = True
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
        dgv.Columns("id_uc").Visible = False
        dgv.Columns("ub_cantidad").Visible = False

        Me.ErrorProvider1.DataSource = dgv.DataSource
    End Sub 'crea el grid

    Private Sub cargar_pedido()
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim j As Integer
        Dim cmd As String
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT   Pedidos_detalle.id_producto as id, productos.Descripcion as Descripcion, productos.iva as iva, Pedidos_detalle.iduC , Pedidos_detalle.uB  as ub_und, Pedidos_detalle.uC as und, Pedidos_detalle.factorC as factor, Pedidos_detalle.pedido as cantidad, Pedidos_detalle.costoPedido as ud_costo, Pedidos_detalle.pedido as ped_cantidad, Pedidos_detalle.costoPedido as ud_costo "
        cmd = cmd + " FROM Pedidos_detalle INNER JOIN productos ON Pedidos_detalle.id_producto = productos.id_Producto"
        cmd = cmd + " WHERE (Pedidos_detalle.id_pedido = " + npedido.ToString + ")"
        Me.Text = "Entrad del Pedido No." + npedido.ToString

        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        'Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.Fill(tbl)
        If tbl.Rows.Count = 0 Then MsgBox("No Existe") : Exit Sub
        For j = 0 To tbl.Rows.Count - 1
            mytable.ImportRow(tbl.Rows(j))
        Next
        totaliza()
    End Sub ' lee el pedidn

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

    Private Sub piva_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piva.SelectedIndexChanged
        Try
            If piva.Text = "15" Then mytable.Columns("piva").Expression = "iif (iva>0, 16,0)"
            If piva.Text = "10" Then mytable.Columns("piva").Expression = "iif (iva>0, 11,0)"
            If piva.Text = "0" Then mytable.Columns("piva").Expression = "iif (iva>0, 0,0)"
            dgv.Refresh()
        Catch ex As Exception

        End Try
    End Sub

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
        End Try
    End Sub

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
                My.Computer.Keyboard.SendKeys("{enter}")
            End If
        Catch ex As Exception
        End Try
    End Sub ' Pide un producto desde buscar productos

    Private Sub guarda_documento()
        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim result As Boolean
        Dim d As New Mi_Documento
        Dim r As DataRow
        Dim j As Integer

        status1.Text = "Guardando Documentos"
        barra.Maximum = dgv.Rows.Count
        barra.Value = 1
        d.a00_id_doc = 1
        d.a01_Folio = nentrada
        d.a02_serie = ""
        d.a03_Almacen = Me.AlmacenComboBox.SelectedValue
        d.a04_id_directorio = Me.id_provtxt.Text
        d.a05_tipo_directorio = 1
        d.a06_fecha_registro = Date.Now.ToString
        d.a07_Folio_pedido = npedido
        d.a08_factura = Me.facturatxt.Text
        d.a09_fecha_factura = CDate(fechafactura.Value.Date)
        d.a10_fecha_surtido = CDate(Me.fechaentrada.Value.Date)
        d.a11_fecha_vence = fechavence.Value.Date.ToString
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
        d.a26_diasc = Me.diasc.Text
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
            m.a32_caducidad = Now.Date
            result = agregar_movimiento(m)
            If result = False Then

            End If
            Me.Refresh()
        Next
        status1.Text = "Guardando Comentarios"
        Me.Refresh()
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
        status1.Text = ""
        Me.barra.Value = 0


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

    Public Sub cargar_entrada()
        Dim adapentrada As New Data.SqlClient.SqlDataAdapter
        Dim adapdoc As New Data.SqlClient.SqlDataAdapter

        Dim tblent As New DataTable
        Dim tbldoc As New DataTable
        Dim tblcom As New DataTable

        Dim cmd As String, j As Integer
        Dim cmddoc As String

        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT        dbo.movimientos.id_prodcuto AS id, dbo.productos.iva, dbo.movimientos.piva, dbo.productos.Descripcion, dbo.movimientos.ud AS id_uc, "
        cmd = cmd + "dbo.sql_Undcompra.uc AS Und, dbo.movimientos.factor, dbo.sql_Undcompra.Ub_und, dbo.movimientos.cantidad, dbo.movimientos.costo AS ud_costo, dbo.sql_Undcompra.codigo, "
        cmd = cmd + "dbo.Documentos.porciento_descuento/100 AS pdesc, dbo.movimientos.cos_flete AS ud_cflete "
        cmd = cmd + "FROM dbo.movimientos INNER JOIN "
        cmd = cmd + "dbo.productos ON dbo.movimientos.id_prodcuto = dbo.productos.id_Producto INNER JOIN "
        cmd = cmd + "dbo.sql_Undcompra ON dbo.productos.id_Producto = dbo.sql_Undcompra.id_Producto INNER JOIN "
        cmd = cmd + "dbo.Documentos ON dbo.movimientos.serie = dbo.Documentos.serie AND dbo.movimientos.folio_doc = dbo.Documentos.Folio AND "
        cmd = cmd + "dbo.movimientos.id_doc = dbo.Documentos.td "
        cmd = cmd + "WHERE (dbo.movimientos.id_doc = 1) AND (dbo.movimientos.folio_doc = " + nentrada.ToString + ") AND (dbo.movimientos.serie = ' ')"
        adapentrada = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        adapentrada.Fill(tblent)
        If tblent.Rows.Count = 0 Then MsgBox("No existe entrada " + nentrada.ToString)
        For j = 0 To tblent.Rows.Count - 1
            mytable.ImportRow(tblent.Rows(j))
        Next
        cmddoc = "SELECT Documentos.* FROM Documentos WHERE td = 1 and Folio = " + nentrada.ToString
        adapdoc = New Data.SqlClient.SqlDataAdapter(cmddoc, cs)
        adapdoc.Fill(tbldoc)
        With tbldoc.Rows(0)
            facturatxt.Text = .Item("factura")
            fechafactura.Value = .Item("fechafactura")
            fechavence.Value = .Item("vence")
            fechaentrada.Value = .Item("fechasurtido")
            diasc.Text = .Item("diasc")
            Me.pdesctext.Text = .Item("porciento_descuento")
            piva.Text = .Item("piva")
            fletetxt.Text = .Item("flete")
            Me.AlmacenComboBox.SelectedValue = .Item("almacen")
        End With

        cmddoc = "SELECT comentarios.* FROM Comentarios WHERE td = 1 and Folio = " + nentrada.ToString
        adapdoc = New Data.SqlClient.SqlDataAdapter(cmddoc, cs)
        adapdoc.Fill(tblcom)

        Try
            With tblcom.Rows(0)
                puertatxt.Text = .Item("puerta")
                Me.Recibiotxt.Text = .Item("quien")
                Me.comentariotxt.Text = .Item("comentarios")
            End With
        Catch ex As Exception
        End Try
        mytable.AcceptChanges()
        totaliza()
        Me.GuardarToolStripButton.Enabled = False
        Me.facturatxt.Focus()
    End Sub

    Private Sub borra_documento()

        Dim folio As Integer
        folio = nentrada

        status1.Text = "Borrando Entrada " + folio.ToString
        Dim adap As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim adap1 As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim adap2 As New admintegralDataSetTableAdapters.ComentariosTableAdapter

        Try
            status1.Text = "Borrando Movimientos..."
            adap.borrar_movimientos(1, folio, "")

            status1.Text = "Borrando Documento..."
            adap1.borrar_documento(1, folio)

            status1.Text = "Borrando Comentarios"
            adap2.Borra_comentarios(1, folio)

            status1.Text = "Entrada Borrada.."

        Catch ex As Exception
            MsgBox("Error al tratar de Borrar")
        End Try
        status1.Text = "Entrada Borrada"
        ' esta opcion queda pendiente por si se va a revertir los cambios en el pedido de alguna forma
        'If np > 0 Then
        '    Dim adap2 As New admintegralDataSetTableAdapters.pedidosTableAdapter
        '    Dim adap3 As New admintegralDataSetTableAdapters.Pedidos_detalleTableAdapter
        '    status1.Text = "Actualizando Pedido"
        '    Try
        '        adap2.actualiza_entrada(0, 0, np)
        '    Catch ex As Exception
        '        MsgBox("No se actualizo el pedido " + np.ToString)
        '    End Try
        '    Try
        '        status1.Text = "Actualizando Detalle de Pedido"
        '        adap3.ped_borrar_entrada(" ", np)
        '    Catch ex As Exception

        '    End Try
        '    status1.Text = "Entrada Borrada"
        'End If
    End Sub

    Private Sub vence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vence.Click
        extraer_definicion(mytable, "C:\datos\Tabla_entrada.txt")
    End Sub

    Public Class MiGrid
        Inherits DataGridView

        Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
            Dim key As Keys = (keyData And Keys.KeyCode)
            If key = Keys.Enter Then
                Return Me.ProcessRightKey(keyData)
            End If
            Return MyBase.ProcessDialogKey(keyData)
        End Function

        Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
            If (e.KeyCode = Keys.Enter) Then
                Return Me.ProcessRightKey(e.KeyData)
            End If
            Return MyBase.ProcessDataGridViewKey(e)
        End Function

    End Class

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        totaliza()
        borra_documento()
        guarda_documento()
        Me.GuardarToolStripButton.Enabled = False
    End Sub 'Guardar (Elimina la anterior y guarda esta nueva)

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        My.Forms.documentos_imprimir.cargar(1, nentrada, " ")
        My.Forms.documentos_imprimir.Show()
    End Sub

    Private Sub GuardarToolStripButton_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.EnabledChanged
        Me.ImprimirToolStripButton.Enabled = Not Me.GuardarToolStripButton.Enabled
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If dgv.CurrentCellAddress.X = 0 Then
            pedir_producto()
        End If
    End Sub

    'Private Sub dgv_CellEndEdit1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
    '    Me.GuardarToolStripButton.Enabled = True
    '    mytable.AcceptChanges()
    '    totaliza()
    'End Sub


    Private Sub puertatxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles puertatxt.TextChanged, Recibiotxt.TextChanged, fechavence.ValueChanged, fechafactura.ValueChanged, fechaentrada.ValueChanged, facturatxt.TextChanged, comentariotxt.TextChanged
        Me.GuardarToolStripButton.Enabled = True
    End Sub

    Private Sub dgv_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEnter
        'If e.ColumnIndex > 9 Then ' Columna Codigo
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{left}")
        '    SendKeys.Send("{down}")
        '    Exit Sub
        'End If
    End Sub
    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = 0 Then ' Columna Codigo
            Dim ix As Integer
            ix = catbs.Find("codigo", dgv.CurrentRow.Cells(0).Value.ToString)
            If ix < 0 Then producto.a1id = 0 : Beep() : Exit Sub
            leer_producto(tabla_catalogo.Rows(ix))
            Exit Sub
        End If
    End Sub

    Private Sub dgv_CellEndEdit1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        mytable.AcceptChanges()
        totaliza()
    End Sub
    Private Sub leer_producto(ByVal dt As DataRow)
        Try
            producto.a1id = dt.Item("id_producto").ToString
            producto.a2descripcion = dt.Item("Descripcion").ToString
            producto.a3factor = dt.Item("factorc").ToString
            producto.a4uc = dt.Item("uc").ToString
            producto.a5ub = dt.Item("ub_und").ToString
            producto.a6iva = dt.Item("iva").ToString
            producto.a7codigo = dt.Item("codigo").ToString
            dgv.CurrentRow.Cells("id").Value = producto.a1id
            dgv.CurrentRow.Cells("Descripcion").Value = producto.a2descripcion
            dgv.CurrentRow.Cells("factor").Value = producto.a3factor
            dgv.CurrentRow.Cells("und").Value = producto.a4uc
            dgv.CurrentRow.Cells("ud_costo").Value = producto.a8costo
            dgv.CurrentRow.Cells("ub_und").Value = producto.a5ub
            dgv.CurrentRow.Cells("iva").Value = producto.a6iva
            dgv.CurrentCell = dgv.CurrentRow.Cells("cantidad")
            '   u = sk_leer_UndCompra(producto.a1id)
            dgv.CurrentRow.Cells("id_uc").Value = dt.Item("iduc")
            '  dgv.CurrentRow.Cells("Cantidad").Selected = True
        Catch ex As Exception
            MsgBox("Error al leer producto")
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
