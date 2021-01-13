Class cotizaciones
    Public tipo_venta As Integer ' nota,factura,dev, nota credito
    Dim credito As Boolean = False
    Dim como_pago As Integer
    Dim bs As New BindingSource
    Dim bsexistencia As New BindingSource
    Dim tarjetacredito As Boolean = True
    Dim nueva As Boolean = True

    Dim info_caja As Integer = My.Settings.ncaja
    Dim info_serie As String
    Dim info_lista As Integer
    Dim info_factor As Decimal = 1
    Dim dsdoc As New DataSet("Facturas")
    Dim tabledoc As DataTable = dsdoc.Tables.Add("tabledoc")
    Dim mytable As DataTable = dsdoc.Tables.Add("mytable")
    Dim factor_iva1_venta As String
    Dim factor_iva2_venta As String


    Dim tabla_pago As New DataTable
    Dim jalada_td As Integer = 0
    Dim jalada_folio As Long = 0
    Dim jalada_serie As String = 0
    Dim id_autorizacion As Integer
    Dim autorizacion_pesos As Decimal
    Dim ancho_ticket As Integer = 36


    Dim monitor_guardar As Boolean
    Dim monitor_facturas As Boolean
    Dim monitor_boletas As Boolean  'pagos head
    Dim monitor_pago As Boolean
    Public tipo_cotizacion As Boolean = False
    Public Sub especial()
        tipo_cotizacion = True
        dgv.Columns("ud_costo").Visible = True
        dgv.Columns("ud_costo").ReadOnly = True
        mytable.Columns("ud_pventa").Expression = ""
        mytable.Columns("ud_pventa").ReadOnly = False
        dgv.Columns("ud_pventa").ReadOnly = False
        Panel.Visible = True
    End Sub


    Private Sub caja_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.Close()
        Main.MenuStrip.Enabled = True
        Main.barra_menu1.Enabled = True
    End Sub 'cerrar cajaada

    Private Sub caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tblexistencia As New DataTable
        factor_iva1_venta = (My.Settings.iva / 100).ToString 'iva10
        factor_iva2_venta = (My.Settings.iva2 / 100).ToString 'iva15


        Me.Refresh()
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True

        crear_grid()

        Me.TabControl1.SelectTab(1)
        Me.totaltxt.Text = "0.00" : totalizar()
        Me.TopMost = False

        Me.Refresh()
        Try
            Me.Lista_de_ventasTableAdapter.Fill(Me.AdmintegralDataSet.Lista_de_ventas)
        Catch ex As Exception

        End Try
        Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)


        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tabla As New DataTable() 'tabla del detalle de pedido
        Dim cmd, cs As String

        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT * FROM sql_cotizacion"
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        'Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.Fill(tblexistencia)
        bsexistencia.DataSource = tblexistencia
        dgvpedido.DataSource = bsexistencia
        For j As Integer = 0 To 3 : dgvpedido.Columns(j).ReadOnly = True : Next j
        dgvpedido.Columns(4).ReadOnly = False
        dgvpedido.Columns(5).ReadOnly = False
        dgvpedido.Columns(6).Visible = False
        dgvpedido.Columns(7).Visible = False

        inicializa_nota()
        Me.Text = "COTIZACIONES"
        Me.tipo_venta = 8
    End Sub 'Leer form

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click, boton_cliente.Click
        pedir_cliente()
    End Sub 'Boton Solicita Cliente

    Private Sub pedir_cliente()
        My.Forms.Buscar_clientes.ShowDialog()
        idcliente.Text = id_cliente
        ' If id_cliente = 0 Then Exit Sub
        cargar_cliente()
        totalizar()
    End Sub 'Solicita Clientes

    Private Sub cargar_cliente()
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tabla As New DataTable() 'tabla del detalle de pedido
        Dim cmd, cs As String
        cs = My.Settings.AdmintegralConnectionString.ToString
        'cmd = "SELECT saldos_por_cliente.* FROM saldos_por_cliente WHERE id_directorio = " + id_cliente.ToString
        cmd = "SELECT Directorio.* FROM Directorio WHERE  tipo=2 and id_directorio = " + id_cliente.ToString
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.Fill(tabla)
        If tabla.Rows.Count = 0 Then
            MsgBox("No Exitse") : Exit Sub
            '    cmd = "SELECT saldos_por_cliente.* FROM saldos_por_cliente WHERE id_directorio = 0"
            '    AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
            '    AdaptadorDeDatos.Fill(tabla)
            '    idcliente.Text = "0"
        End If
        Me.cnombre.Text = tabla.Rows(0).Item("Nombre").ToString
        Me.cdireccion.Text = tabla.Rows(0).Item("Direccion").ToString
        Me.csaldo.Text = Format(tabla.Rows(0).Item("limite"), "N2")
        Me.cciudad.Text = tabla.Rows(0).Item("ciudad").ToString
        Me.ccolonia.Text = tabla.Rows(0).Item("Colonia").ToString
        Me.cdias.Text = tabla.Rows(0).Item("Dias").ToString
        Me.climite.Text = tabla.Rows(0).Item("Limite").ToString
        Me.Listatxt.Text = tabla.Rows(0).Item("ruta").ToString
        Me.ccomercial.Text = tabla.Rows(0).Item("comercial").ToString
        Me.cagente.Text = tabla.Rows(0).Item("id_agente").ToString
        Dim adap As New admintegralDataSetTableAdapters.ListasTableAdapter
        info_factor = adap.Factor(Me.Listatxt.Text)
        Main.StatusStrip1.Items(2).Text = info_factor
        'Actualiza: si hay renglones modifica el valor
        For j As Integer = 0 To mytable.Rows.Count - 1
            mytable.Rows(j).Item("ud_flista") = info_factor
        Next

        If idcliente.Text = 0 Then
            lblsaldo.Visible = False
            csaldo.Visible = False
            Me.sucursaltxt.Text = "Publico General"
        Else
            lblsaldo.Visible = False
            csaldo.Visible = False
        End If
    End Sub '

    Private Sub crear_grid_totales()
        Dim column As New DataColumn

        column = New DataColumn("F", System.Type.GetType("System.Int32"))
        column.Caption = "F" : column.AllowDBNull = False
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("sub0", System.Type.GetType("System.Decimal"))
        column.Caption = "Sub0" : column.DefaultValue = 0
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("sub10", System.Type.GetType("System.Decimal"))
        column.Caption = "sub10" : column.DefaultValue = 0
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("desc0", System.Type.GetType("System.Decimal"))
        column.Caption = "Desc." : column.DefaultValue = 0
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("desc10", System.Type.GetType("System.Decimal"))
        column.Caption = "Desc." : column.DefaultValue = 0
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("iva", System.Type.GetType("System.Decimal"))
        column.Caption = "IVA" : column.DefaultValue = 0
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.


        column = New DataColumn("NF", System.Type.GetType("System.Int32"))
        column.Caption = "NF" : column.AllowDBNull = True

        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("td", System.Type.GetType("System.Int32"))
        column.Caption = "td" : column.AllowDBNull = True
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "total" : column.Caption = "Total" : column.DefaultValue = 0
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "pesogramos" : column.Caption = "pesogramos" : column.DefaultValue = 0
        column.Unique = False : tabledoc.Columns.Add(column)   ' Add the Column to the DataColumnCollection.


        dgvdoc.DataSource = tabledoc

        'Crea data set y genera relation

        Dim pcol As DataColumn = dsdoc.Tables("tabledoc").Columns("F")
        Dim child As DataColumn = dsdoc.Tables("mytable").Columns("NF")

        Dim facrelation As DataRelation
        facrelation = New DataRelation("facturas", pcol, child)
        dsdoc.Relations.Add(facrelation)

        tabledoc.Columns("sub0").Expression = "sum(child.al0)"
        tabledoc.Columns("sub10").Expression = "sum(child.al10)"
        tabledoc.Columns("desc0").Expression = "sum(child.dal0) "
        tabledoc.Columns("desc10").Expression = "sum(child.dal10) "
        tabledoc.Columns("iva").Expression = "sum(child.subiva10)"
        tabledoc.Columns("total").Expression = "sum(child.total)"
        tabledoc.Columns("pesogramos").Expression = "sum(child.peso)"

        Dim dr As DataRow = tabledoc.NewRow
        dr(0) = 1
        tabledoc.Rows.Add(dr)

        '************************* crea tabla pagos

        column = New DataColumn("Id", System.Type.GetType("System.Int32"))
        column.Caption = "Id" : column.AllowDBNull = True
        column.Unique = False : tabla_pago.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("fp", System.Type.GetType("System.Int32"))
        column.Caption = "FP" : column.AllowDBNull = False
        column.Unique = False : tabla_pago.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("importe", System.Type.GetType("System.Decimal"))
        column.Caption = "importe"
        column.Unique = False : tabla_pago.Columns.Add(column)   ' Add the Column to the DataColumnCollection.
        Me.dgvpago.DataSource = tabla_pago

    End Sub 'Genera grid totales y pagos

    Private Sub crear_grid()
        ' Declare variables for DataColumn and DataRow objects.
        Dim column As New DataColumn

        column = New DataColumn("codigo", System.Type.GetType("System.String"))
        column.AllowDBNull = False : mytable.Columns.Add(column)

        column = New DataColumn("Id", System.Type.GetType("System.Int32"))
        column.Unique = False
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        ' and add to DataTable.    
        column = New DataColumn("iva", System.Type.GetType("System.Int32"))
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        ' and add to DataTable.    
        column = New DataColumn("piva", System.Type.GetType("System.Int32"), "iif (iva>0, " + My.Settings.iva.ToString + ",0)")
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Descripcion", System.Type.GetType("System.String"))
        column.Caption = "Producto" : mytable.Columns.Add(column)

        column = New DataColumn("Und", System.Type.GetType("System.String"))
        column.Caption = "und" : mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn("factor", System.Type.GetType("System.Decimal"))
        mytable.Columns.Add(column) ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Cantidad", System.Type.GetType("System.Decimal"))
        column.Caption = "Cant" : mytable.Columns.Add(column)

        column = New DataColumn("ud_Costo", System.Type.GetType("System.Decimal"))
        column.Caption = "Costo" : mytable.Columns.Add(column)

        column = New DataColumn("ud_plventa", System.Type.GetType("System.Decimal"))
        column.Caption = "PL" : mytable.Columns.Add(column)

        column = New DataColumn("ud_flista", System.Type.GetType("System.Decimal"))
        column.DefaultValue = 1 : mytable.Columns.Add(column)

        column = New DataColumn("ud_pventa", System.Type.GetType("System.Decimal"), "ud_flista * ud_plventa")
        column.Caption = "Unit." : mytable.Columns.Add(column)

        column = New DataColumn("pdesc", System.Type.GetType("System.Decimal")) 'porcentaje de descuento (solo para formula)
        column.DefaultValue = 0 : mytable.Columns.Add(column)

        column = New DataColumn("UD_VDesc", System.Type.GetType("System.Decimal"))
        column.Caption = "Desc." : column.DefaultValue = 0
        column.Expression = "ud_pventa * pdesc"
        column.ReadOnly = True
        mytable.Columns.Add(column)

        column = New DataColumn("UD_vneto", System.Type.GetType("System.Decimal"), "ud_pventa - UD_VDesc") 'Venta Neto nETO
        mytable.Columns.Add(column)

        column = New DataColumn("Importe", System.Type.GetType("System.Decimal"), "cantidad * ud_vneto") 'IMPORTE
        column.Caption = "Importe" : column.ReadOnly = True
        mytable.Columns.Add(column)

        column = New DataColumn("UD_iva10", System.Type.GetType("System.Decimal"), "iif(piva<17 and piva>0,ud_vneto*" + factor_iva1_venta + ",0)")
        column.Caption = "*" + column.ColumnName : mytable.Columns.Add(column)

        column = New DataColumn("UD_iva15", System.Type.GetType("System.Decimal"), "iif(piva>20,ud_vneto*" + factor_iva2_venta + ",0)")
        column.Caption = "*" + column.ColumnName : mytable.Columns.Add(column)

        column = New DataColumn("pieps", System.Type.GetType("System.Decimal"))    '<==== PIEPS
        column.Caption = "PIEPS" + column.ColumnName : mytable.Columns.Add(column)


        column = New DataColumn("ieps", System.Type.GetType("System.Decimal"), "iif(pieps<>0,ud_vneto*(pieps/100),0)")  '<====IEPS
        column.Caption = "IEPS" + column.ColumnName : mytable.Columns.Add(column)


        'Columnas de Unidad Base
        '================================================================================
        column = New DataColumn("UB_Cantidad", System.Type.GetType("System.Decimal"), "factor * Cantidad")
        mytable.Columns.Add(column)
        column = New DataColumn("UB_Costo", System.Type.GetType("System.Decimal"), "ud_costo / factor")
        mytable.Columns.Add(column)
        column = New DataColumn("UB_pventa", System.Type.GetType("System.Decimal"), "ud_vneto / factor")
        mytable.Columns.Add(column)
        column = New DataColumn("Ub_pDesc", System.Type.GetType("System.Decimal"), "ud_vdesc /  factor")
        mytable.Columns.Add(column)
        column = New DataColumn("Ub_iva10", System.Type.GetType("System.Decimal"), "ud_iva10 / factor")
        mytable.Columns.Add(column)
        column = New DataColumn("Ub_iva15", System.Type.GetType("System.Decimal"), "ud_iva15 / factor")
        mytable.Columns.Add(column)
        column = New DataColumn("Ub_ieps", System.Type.GetType("System.Decimal"), "ieps / factor") '<======IEPS
        mytable.Columns.Add(column)


        column = New DataColumn("subdesc", System.Type.GetType("System.Decimal"), "ud_vdesc * cantidad")
        mytable.Columns.Add(column)
        column = New DataColumn("subiva10", System.Type.GetType("System.Decimal"), "ud_iva10 * cantidad")
        mytable.Columns.Add(column)
        column = New DataColumn("subiva15", System.Type.GetType("System.Decimal"), "ud_iva15 * cantidad")
        mytable.Columns.Add(column)

        column = New DataColumn("subieps", System.Type.GetType("System.Decimal"), "ieps * cantidad") '<======IEPS
        mytable.Columns.Add(column)
        '*****************************************************************
        'SUB TOTALES
        '******************************************************************
        column = New DataColumn("al0", System.Type.GetType("System.Decimal"), "iif (iva=0, ud_pventa * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("al10", System.Type.GetType("System.Decimal"), "iif (iva=" + My.Settings.iva.ToString + ", ud_pventa * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("al15", System.Type.GetType("System.Decimal"), "iif (iva=" + My.Settings.iva2.ToString + ", ud_pventa * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
         '**********************************************************************
        ' sub-totales DESCUENTo
        '**********************************************************************

        column = New DataColumn("dal0", System.Type.GetType("System.Decimal"), "iif (iva=0, ud_vdesc * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("dal10", System.Type.GetType("System.Decimal"), "iif (iva=" + My.Settings.iva.ToString + ", ud_vdesc * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("dal15", System.Type.GetType("System.Decimal"), "iif (iva=" + My.Settings.iva2.ToString + ", ud_vdesc * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("peso", System.Type.GetType("System.Decimal"))
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("total", System.Type.GetType("System.Decimal"))
        column.Expression = "al0 + al10+ al15 - subdesc +subiva10+ subiva15+subieps" 'calcula total
        mytable.Columns.Add(column)

        column = New DataColumn("ud_Id", System.Type.GetType("System.Int32"))
        column.Caption = "ud_id" : column.Unique = False
        mytable.Columns.Add(column) ' Add the Column to the DataColumnCollection.

        ' Create new DataColumn, set DataType, ColumnName 
        column = New DataColumn("N", System.Type.GetType("System.Int32"))
        column.DefaultValue = 1 : column.Unique = False : mytable.Columns.Add(column)

        column = New DataColumn("F", System.Type.GetType("System.Int32"), " ((N /" + My.Settings.LineasXfactura.ToString + ")-.5 )+1 ")
        column.AllowDBNull = False : column.Unique = False : mytable.Columns.Add(column)

        column = New DataColumn("NF", System.Type.GetType("System.Int32"))
        column.AllowDBNull = False : mytable.Columns.Add(column)

        ' Create new DataColumn, set DataType, ColumnName 
        column = New DataColumn("separar", System.Type.GetType("System.Boolean"))
        column.DefaultValue = 0 : column.Unique = False : mytable.Columns.Add(column)

        'asigna la abla al datagrid
        bs.DataSource = mytable
        dgv.DataSource = bs

        '**********************************************************************
        ' Oculta columnas de calculo
        'dgv.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("id").ReadOnly = True
        dgv.Columns("Descripcion").ReadOnly = True
        dgv.Columns("Cantidad").ReadOnly = True
        dgv.Columns("und").ReadOnly = True
        dgv.Columns("Factor").ReadOnly = True
        dgv.Columns("Codigo").ReadOnly = True
        dgv.Columns("ud_pventa").ReadOnly = True
        dgv.Columns("ud_pventa").DefaultCellStyle.Format = "N4"
        dgv.Columns("peso").ReadOnly = True
        dgv.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv.Columns("descripcion").DefaultCellStyle.BackColor = Color.LightBlue



        dgv.Columns("Importe").DefaultCellStyle.Format = "N2"
        dgv.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("ud_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        With dgv
            .Columns("id").Visible = False
            .Columns("ud_costo").Visible = False
            .Columns("pdesc").Visible = False
            .Columns("ud_id").Visible = False
            .Columns("N").Visible = False
            .Columns("F").Visible = False
            .Columns("NF").Visible = False
            .Columns("factor").Visible = False
            .Columns("ud_plventa").Visible = False
            .Columns("ud_flista").Visible = False
            .Columns("ud_pventa").HeaderText = "Unit."
            For j As Integer = 8 To .Columns.Count - 1
                .Columns(j).DefaultCellStyle.Format = "N2"
                .Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next
            .Columns("iva").Visible = False
            .Columns("piva").Visible = False
            .Columns("pdesc").Visible = False
            .Columns("ub_pventa").Visible = False
            .Columns("ud_vdesc").Visible = False
            .Columns("ud_vneto").Visible = False
            .Columns("ud_iva10").Visible = False
            .Columns("ud_iva15").Visible = False

            .Columns("ub_cantidad").Visible = False
            .Columns("ub_Costo").Visible = False
            .Columns("ub_pdesc").Visible = False
            .Columns("ub_iva10").Visible = False
            .Columns("ub_iva15").Visible = False
            .Columns("ub_ieps").Visible = False
            .Columns("ieps").Visible = True   '<====IEPS
            .Columns("pieps").Visible = True   '<===IEPS
            .Columns("subieps").Visible = False


            .Columns("subdesc").Visible = False
            .Columns("subiva10").Visible = False
            .Columns("subiva15").Visible = False
            .Columns("al0").Visible = False
            .Columns("al10").Visible = False
            .Columns("al15").Visible = False '<====
            .Columns("dal0").Visible = False
            .Columns("dal10").Visible = False
            .Columns("dal15").Visible = False
            .Columns("peso").Visible = False
        End With
        crear_grid_totales()
    End Sub

    Private Sub linea_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles linea.GotFocus
        linea.SelectAll()
    End Sub '****************************************************************crear el grid

    Private Sub linea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles linea.KeyPress
        Dim cant, x, y As Integer, id As String, filtro As String
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            x = InStr(linea.Text, ".")
            y = InStr(linea.Text, "*") 'caja
            If x > 1 Then
                cant = linea.Text.Substring(0, x - 1)
                id = Mid(linea.Text, x + 1)
                canttxt.Text = cant
                idtxt.Text = id
            Else
                If y > 1 Then
                    cant = linea.Text.Substring(0, y - 1)
                    id = Mid(linea.Text, y + 1)
                    canttxt.Text = cant
                    idtxt.Text = id
                Else
                    cant = 1
                    idtxt.Text = linea.Text
                End If
            End If
            Me.Lista_de_ventasBindingSource.Filter = ""
            Dim ix As Integer = Me.Lista_de_ventasBindingSource.Find("codigo", Me.idtxt.Text)
            If ix < 0 Then
                MsgBox("No Existe")
                linea.Text = ""
                Exit Sub
            Else
                Me.Lista_de_ventasBindingSource.Position = ix
                If y > 0 Then ' filtra para ubicar uniad de compra
                    Dim undcompra As Und = sk_leer_UndCompra(Id_productoTextBox.Text) 'determina unidad de compra
                    filtro = "id_producto = " + Me.Id_productoTextBox.Text + " and id_unidad = " + undcompra.a9_uc_id.ToString
                    Me.Lista_de_ventasBindingSource.Filter = filtro
                    If Me.Lista_de_ventasBindingSource.Position < 0 Then
                        MsgBox("No existe x Caja")
                        Me.Lista_de_ventasBindingSource.Filter = ""
                        Exit Sub
                    End If
                End If

                ' verifica si ya existe en la factura
                Dim alta As Boolean = False
                Dim ix1 As Integer
                For ix1 = 0 To mytable.Rows.Count - 1
                    With mytable.Rows(ix1)
                        If .Item("id") = Me.Id_productoTextBox.Text And .Item("ud_id") = Me.Id_unidadTextBox.Text Then
                            cant += .Item("cantidad")
                            .Item("cantidad") = cant
                            totalizar()
                            linea.Text = ""
                            alta = True
                        End If
                    End With
                Next
                If alta = False Then
                    Dim dr As DataRow = mytable.NewRow
                    dr("id") = Me.Id_productoTextBox.Text
                    dr("iva") = Me.IvaTextBox.Text
                    dr("piva") = Me.IvaTextBox.Text
                    dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                    dr("und") = Me.UnidadTextBox.Text
                    dr("factor") = Me.FactorTextBox.Text
                    dr("cantidad") = cant
                    dr("ud_costo") = Me.CostoTextBox.Text
                    dr("ud_plventa") = Me.VentaTextBox.Text
                    'dr("ud_flista") = info_factor 'factor precio lista
                    dr("pieps") = Me.IepsTextBox.Text '<======IEPS

                    If Me.Precio_unicoCheckBox.Checked = False Then dr("ud_flista") = info_factor Else dr("ud_flista") = 1 'factor precio lista
                    dr("ud_pventa") = Math.Round(dr("ud_plventa") * dr("ud_flista"), 2)


                    'dr("ud_pventa") = Int(dr("ud_plventa") * info_factor * 100) / 100
                    dr("pdesc") = 0
                    dr("nf") = 1
                    dr("peso") = Me.PesoTextBox.Text
                    dr("ud_id") = Me.Id_unidadTextBox.Text
                    dr("codigo") = idtxt.Text
                    '  dr("empaque") = Me.UnidadesTextBox.Text
                    mytable.Rows.Add(dr)
                End If
                totalizar()
                Me.lineastxt.Text = dgv.Rows.Count - 1
                If dgv.RowCount > dgv.DisplayedRowCount(False) Then
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - dgv.DisplayedRowCount(False) - 1
                End If
                Me.linea.Text = "" : Me.linea.Focus()
                Dim fileName As New System.IO.StreamWriter("C:\tmp\cotizaciones.tmp", True)
                fileName.WriteLine(idtxt.Text + "," + Me.Id_unidadTextBox.Text + "," + cant.ToString)
                fileName.Close()
            End If
            bs.Filter = ""
            Me.Lista_de_ventasBindingSource.Filter = ""
        End If
    End Sub '******************************************* LINEA DE CAPTURA

    Private Sub totalizar()
        Me.lineastxt.Text = dgv.Rows.Count - 1
        Try
            totaltxt.Text = Format(mytable.Compute("sum(total)", ""), "N2")
        Catch ex As Exception
            totaltxt.Text = "0.00"
        End Try
        Try
            txtcosto.Text = Format(mytable.Compute("sum(tcosto)", ""), "N2")
        Catch ex As Exception

        End Try

        Dim td, tc, co As Decimal
        If totaltxt.Text = "" Then
            td = 0 : tc = 0 : co = 0
        Else
            co = CDbl(totaltxt.Text)
            td = co * cia.comidebito
            tc = co * cia.comicredito
            total_debito.Text = Format(td, "N2")
            Total_credito.Text = Format(tc, "N2")
        End If

        Dim ix As Integer = bs.Find("codigo", "0000000000")
        'If ix < 1 Then
        '    total_debito.Text = Format(td, "N2")
        '    Total_credito.Text = Format(tc, "N2")
        '    total_debito.Visible = True
        '    Total_credito.Visible = True
        'End If
    End Sub 'Totalizar

    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        mytable.AcceptChanges()
        totalizar()
    End Sub ' Todo:recalcula total cuando se cambia el grid

    Private Sub CodigoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoComboBox.SelectedIndexChanged
        Me.linea.Text = Me.CodigoComboBox.Text
    End Sub

    Private Sub idcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idcliente.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            id_cliente = idcliente.Text
            cargar_cliente()
            e.Handled = True
            linea.Focus()
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim x As MsgBoxResult
        x = MsgBox("Seguro que quiere Borra la Cotizacion", MsgBoxStyle.YesNo, "Iniciar de Nuevo")
        If x = MsgBoxResult.Yes Then
            mytable.Clear()
            tabledoc.Clear()
            Dim dr As DataRow = tabledoc.NewRow
            dr(0) = 1 : tabledoc.Rows.Add(dr)
            tabla_pago.Clear()
            Me.totaltxt.Text = "0.00"
            totalizar()
            TabControl1.SelectedIndex = 1
            Me.linea.Focus()
            Try
                My.Computer.FileSystem.DeleteFile("C:\tmp\factura.tmp", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Catch ex As Exception

            End Try
        End If
    End Sub ' **********************************************Boton Borrar NOTA

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedIndex <> 3 Then
            TabControl1.SelectedIndex = 1 'Boton_imprimir.Enabled = False
            totalizar()
        End If
    End Sub ' impide que cambien el TAB con un CLick

    Private Sub SuspenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspenderToolStripMenuItem.Click
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\tmp\factura.tmp")
        If fileExists = False Then MsgBox("No hay nada que suspender") : Exit Sub
        Dim archivo As New SaveFileDialog
        archivo.Title = "Tecle una Referencia"
        archivo.Filter = "TMP (*.TMP)|*.TMP"
        archivo.InitialDirectory = "c:\tmp\susependidadas\"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.MoveFile("C:\tmp\factura.tmp", archivo.FileName, True)
            MsgBox("Archivo guardado : " + archivo.FileName)
        Else
            MsgBox("No se guardo nada")
        End If

    End Sub  'SUSPENDER ********************* Guarda

    Private Sub CARGAR_aRCHIVO(ByVal archivo As String)
        Dim frefile As Integer, a As String, c1, c2 As String, ix As Integer
        frefile = FreeFile() : c1 = "" : c2 = ""
        FileOpen(frefile, archivo, OpenMode.Input)
        'Dim fileName As New System.IO.StreamWriter("C:\tmp\factura.tmp", True)

        Do Until EOF(frefile)
            Try
                a = LineInput(frefile)
                c1 = Mid(a, 1, InStr(a, ",") - 1) : c2 = Mid(a, InStr(a, ",") + 1)
                ix = Me.Lista_de_ventasBindingSource.Find("codigo", c1)
            Catch ex As Exception
                ix = -1
            End Try

            If ix >= 0 Then
                Me.Lista_de_ventasBindingSource.Position = ix
                Dim dr As DataRow = mytable.NewRow
                dr("id") = Me.Id_productoTextBox.Text
                dr("iva") = Me.IvaTextBox.Text
                dr("piva") = Me.IvaTextBox.Text
                dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                dr("und") = Me.UnidadTextBox.Text
                dr("factor") = Me.FactorTextBox.Text
                dr("cantidad") = c2
                dr("ud_costo") = Me.CostoTextBox.Text
                dr("ud_plventa") = Me.VentaTextBox.Text
                dr("ud_flista") = info_factor 'factor precio lista
                dr("pdesc") = 0
                dr("nf") = 1
                dr("peso") = Me.PesoTextBox.Text
                dr("ud_id") = Me.Id_unidadTextBox.Text
                dr("codigo") = c1
                mytable.Rows.Add(dr)

                '  fileName.WriteLine(c1 + "," + c2)

                Me.linea.Text = "" : Me.linea.Focus()
            End If
        Loop
        '  fileName.Close()
        totalizar()

        FileClose(frefile)
    End Sub '****************************************************carga un archivo TMP

    Private Sub CargarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarToolStripMenuItem.Click
        Dim archivo As New OpenFileDialog

        archivo.InitialDirectory = "c:\tmp\suspendidas\"
        archivo.Title = "Seleccione Un archvio"
        archivo.Filter = "TMP (*.TMP)|*.TMP"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            CARGAR_aRCHIVO(archivo.FileName)
            If dgv.RowCount > dgv.DisplayedRowCount(False) Then
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - dgv.DisplayedRowCount(False) - 1
            End If
            Windows.Forms.Cursor.Current = Cursors.Default
        End If
    End Sub ' ******* Cargar 

    Private Sub guardar_imprimir()
        monitor_facturas = False
        guardar_cotizacion()
        inicializa_nota()
    End Sub '**************************************************** Guardar e Imprimir

    Sub guardar_cotizacion()
        

        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim result As Boolean
        Dim d As New Mi_Documento
        Dim r As DataRow, j As Integer
        Main.StatusStrip1.Items(2).Text = "Guardando Documentos"
        d.a00_id_doc = 10 'Cotizacion
        Dim f As Long
        If nueva = True Then

            Try
                f = afolio.siguiente(10, "")
            Catch ex As Exception
                f = 1
            End Try
        Else
            f = folio.Text
            ' ===============    Borara Documento   =================
            '________________________________________________________
            Try
                Dim adap As New admintegralDataSetTableAdapters.DocumentosTableAdapter
                adap.borrar_documento(10, f)
                Dim adap1 As New admintegralDataSetTableAdapters.movimientosTableAdapter
                adap1.borrar_movimientos(10, f, "")
            Catch ex As Exception

            End Try

        End If


        d.a01_Folio = f
        d.a02_serie = " "
        d.a03_Almacen = 0 'dato de caja
        d.a04_id_directorio = Me.idcliente.Text
        d.a05_tipo_directorio = 2
        d.a06_fecha_registro = CDate(Date.Now.ToString)
        d.a07_Folio_pedido = 0 'todo: Pedir numero de pedido
        d.a08_factura = ""
        d.a09_fecha_factura = CDate(Date.Now.Date)
        d.a10_fecha_surtido = CDate(Date.Now.Date)
        d.a11_fecha_vence = CDate(fvence.Value.Date)
        d.a12_pdesc = 0
        d.a13_flete = 0
        d.a14_sub0 = tabledoc.Rows(0).Item("sub0")
        d.a15_sub10 = tabledoc.Rows(0).Item("sub10")
        d.a16_sub15 = 0 'No se usa
        d.a17_iva10 = tabledoc.Rows(0).Item("IVA")
        d.a18_iva15 = 0 'no se usa
        d.a19_desc0 = tabledoc.Rows(0).Item("desc0")
        d.a20_desc10 = tabledoc.Rows(0).Item("desc10")
        d.a21_desc15 = 0 ' no se usa se puede calcular de mytable dal15
        d.a22_importe = tabledoc.Rows(0).Item("total")
        tabledoc.Rows(0).Item("NF") = d.a01_Folio
        tabledoc.Rows(0).Item("TD") = d.a00_id_doc
        If credito = True Then d.a23_idcartera = 2 Else d.a23_idcartera = 0 ' CxC o Contado
        d.a24_status = 0
        d.a25_almaentrada = 0
        d.a26_diasc = IIf(Me.cdias.Text = "", 0, Me.cdias.Text)
        d.a27_pviva = 10
        d.a32_pesoengramos = tabledoc.Rows(0).Item("pesogramos")
        result = Agregar_documento(d) 'Funcion que guarda el documento en la tabla
        If result = False Then
            MsgBox("No se guardo el documento, " + d.a01_Folio)
            Exit Sub
        End If

        For j = 0 To mytable.Rows.Count - 1
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
            m.a13_Cdesc = 0
            m.a14_cflete = 0
            m.a15_civa10 = 0
            m.a16_civa15 = 0
            m.a17_cventa = r.Item("ud_vneto")
            m.a18_cvdesc = r.Item("ud_vdesc")
            m.a19_cviva10 = r.Item("ud_iva10")
            m.a20_cviva15 = r.Item("ud_iva15")
            m.a21_ub_cant = r.Item("ub_cantidad")
            m.a22_ub_costo = r.Item("ub_costo")
            m.a23_ub_Cdesc = 0
            m.a24_ub_cflete = 0
            m.a25_ub_civa10 = 0
            m.a26_ub_civa15 = 0
            m.a27_ub_cventa = r.Item("ub_pventa")
            m.a28_ub_cvdesc = r.Item("ub_pdesc")
            m.a29_ub_cviva10 = r.Item("ub_iva10")
            m.a30_ub_cviva15 = r.Item("ub_iva15")
            m.a32_caducidad = Now.Date
            ' If tipo_venta <> 7 Then m.a31_signo = -1 Else m.a31_signo = 1
            m.a31_signo = 0
            result = agregar_movimiento(m)
            If result = False Then
                MsgBox("No se guardo este producto")
            End If

        Next

        Try
            'actualiza la tabla de comentarios
            Dim adapcomentario As New admintegralDataSetTableAdapters.ComentariosTableAdapter
            Dim comentario As String = comentarios.Text
            adapcomentario.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, " ", user.nick, comentario)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Main.StatusStrip1.Items(2).Text = "Documento Guardado correcto"
        monitor_guardar = True

    End Sub '**************************************************************** Guardar Ventas


    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim a As String
        a = dgv.CurrentRow.Cells("codigo").Value.ToString
        Dim x As MsgBoxResult
        x = MsgBox("Borrar este producto :" + a, MsgBoxStyle.YesNo, "Borrar ")
        If x = MsgBoxResult.Yes Then
            If Me.dgv.CurrentRow.Index >= 0 Then
                Try
                    bs.RemoveCurrent()
                    totalizar()
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub ' Borrar producto

    Private Sub inicializa_nota()
        'Borra Tabla e inicializs variables
        mytable.Rows.Clear() : mytable.Clear() : tabledoc.Clear()
        Dim dr As DataRow = tabledoc.NewRow
        dr(0) = 1 : tabledoc.Rows.Add(dr)
        tabla_pago.Clear()

        Dim a As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim f As Long
        Try
            f = a.siguiente(10, "")
        Catch ex As Exception
            f = 1
        End Try
        a.Dispose()
        Me.folio.Text = f.ToString

        Me.idcliente.Text = "0"
        id_cliente = 0
        Me.cnombre.Text = "Publico en General"
        cargar_cliente()
        TabControl1.SelectedIndex = 1
        totalizar() 'Boton_imprimir.Enabled = False
        linea.Visible = True
        Me.linea.Focus()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub BuscarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProductoToolStripMenuItem.Click
        My.Forms.Buscar_productos.ShowDialog()
        Me.linea.Text += producto.a7codigo
        linea.Focus()
    End Sub

    Private Sub Agregar_Un_producto_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar_Un_producto_menu.Click
        totalizar()
        TabControl1.SelectedIndex = 1 'Boton_imprimir.Enabled = False
        linea.Focus()
    End Sub


    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_puerta.Click, Boton_salir.Click
        If My.Settings.solocaja = False Then
            Me.Close()
            Main.MenuStrip.Enabled = True
            Main.barra_menu1.Enabled = True
        Else
            MsgBox("Esta estacion esta configurada como solo caja")
        End If
    End Sub

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        guardar_cotizacion()
        My.Forms.cotizacion_relacion.imprimir(folio.Text)
        My.Forms.cotizacion_relacion.refill()
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.Close()
        My.Forms.cotizacion_relacion.Show()
        My.Forms.cotizacion_relacion.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ConsultarExistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarExistenciaToolStripMenuItem.Click
        Dim a, factor As String
        a = "" : factor = ""
        Try
            a = dgv.CurrentRow.Cells("id").Value.ToString
            factor = dgv.CurrentRow.Cells("factor").Value
            lblprod.Text = dgv.CurrentRow.Cells("Descripcion").Value
            lblunidad.Text = "Unidad: " + dgv.CurrentRow.Cells("Und").Value
        Catch ex As Exception
            MsgBox("Seleccione un producto")
        End Try

        Dim cmd As String, tb As New DataTable

        cmd = "SELECT tbl_almacenes.id_almacen, tbl_almacenes.Almacen, movimientos.id_prodcuto, SUM(movimientos.ub_cantidad * n) AS unidades " _
        & "FROM movimientos INNER JOIN tbl_almacenes ON movimientos.almacen = tbl_almacenes.id_almacen GROUP BY tbl_almacenes.id_almacen, tbl_almacenes.Almacen, movimientos.id_prodcuto " _
        & " HAVING SUM(movimientos.ub_cantidad*n)>0 and movimientos.id_prodcuto = " + a
        tb = leer_tabla(cmd)
        grupo1.Visible = False
        If tb.Rows.Count = 0 Then MsgBox("Sin Movimientos!!") : Exit Sub
        grupo1.Visible = True

        Dim column As DataColumn
        column = New DataColumn("factor", System.Type.GetType("System.Decimal"))
        column.DefaultValue = factor : tb.Columns.Add(column)

        column = New DataColumn("Exist", System.Type.GetType("System.Decimal"), "unidades / factor")
        tb.Columns.Add(column)

        dgvexistencia.DataSource = tb

        With dgvexistencia
            .Columns("id_almacen").Visible = False
            .Columns("id_prodcuto").Visible = False
            .Columns("unidades").Visible = False
            .Columns("factor").Visible = False
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Exist").DefaultCellStyle.Format = "N0"
            .Columns("Exist").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub filtropedido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles filtropedido.KeyPress
        If e.KeyChar = chr13 Then
            Me.dgvpedido.Focus()
            Me.dgvpedido.CurrentCell = Me.dgvpedido.Rows(0).Cells(4)
        End If
    End Sub

    Private Sub boton_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_agregar.Click, btn_agregar.Click
        dgvpedido.RefreshEdit()
        agregar_seleccionados()
    End Sub
    Private Sub agregar_seleccionados()
        Dim filtro As String = "und<>0 or cj<>0"
        Dim idpz, idcj, id, cantpz, cantcj As Integer
        filtro = filtro
        bsexistencia.Filter = filtro

        '============================================================================
        For j As Integer = 0 To dgvpedido.Rows.Count - 1
            With dgvpedido.Rows(j)
                cantpz = .Cells("und").Value : cantcj = .Cells("cj").Value
                idpz = .Cells(6).Value : idcj = .Cells(7).Value
                id = .Cells("id_producto").Value
            End With
            If cantpz > 0 Then agregar(id, idpz, cantpz)
            If cantcj > 0 Then agregar(id, idcj, cantcj)
        Next j
        bsexistencia.Filter = ""
        For j As Integer = 0 To dgvpedido.Rows.Count - 1
            With dgvpedido.Rows(j)
                Try
                    .Cells("und").Value = 0
                    .Cells("cj").Value = 0
                Catch ex As Exception
                End Try
            End With
        Next j
        totalizar()
        Me.TabControl1.SelectTab(1)
        linea.Focus()
    End Sub
    '******************************************** Agregar seleccion

    Private Sub agregar(ByVal id As Integer, ByVal ud_id As Integer, ByVal cant As Integer)
        Dim filtro As String
        filtro = "id_producto = " + id.ToString + " and id_unidad = " + ud_id.ToString
        Me.Lista_de_ventasBindingSource.Filter = filtro

        ' ================================  Verifica si ya existe en la factura
        Dim alta As Boolean = False
        Dim ix1 As Integer
        For ix1 = 0 To mytable.Rows.Count - 1
            With mytable.Rows(ix1)
                If .Item("id") = id And .Item("ud_id") = ud_id Then
                    cant += .Item("cantidad")
                    .Item("cantidad") = cant
                    Exit Sub
                End If
            End With
        Next

        If alta = False Then
            Dim dr As DataRow = mytable.NewRow
            dr("id") = Me.Id_productoTextBox.Text
            dr("iva") = Me.IvaTextBox.Text
            dr("piva") = Me.IvaTextBox.Text
            dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
            dr("und") = Me.UnidadTextBox.Text
            dr("factor") = Me.FactorTextBox.Text
            dr("cantidad") = cant
            dr("ud_costo") = Me.CostoTextBox.Text
            dr("ud_plventa") = Me.VentaTextBox.Text
            dr("ud_flista") = info_factor 'factor precio lista
            dr("ud_pventa") = Int(dr("ud_plventa") * info_factor * 100) / 100
            dr("pdesc") = 0
            dr("nf") = 1
            dr("peso") = Me.PesoTextBox.Text
            dr("ud_id") = Me.Id_unidadTextBox.Text
            dr("codigo") = Me.CodigoComboBox.Text
            mytable.Rows.Add(dr)
        End If
    End Sub

    Private Sub ExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TabControl1.SelectTab(5)
    End Sub

    Public Sub repetir_documento(ByVal td As Integer, ByVal folio As Integer, ByVal serie As String, ByVal borrar As Boolean)
        Dim adoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim lista As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        Dim status As Integer, fecha As Date, id As Integer, idud, cantidad As Integer
        Dim docum As DataRow, tablamov As New DataTable

        Try
            docum = adoc.GetDataByKey(td, folio, serie).Rows(0)
        Catch ex As Exception
            MsgBox("No se encuantra ese documento")
            Exit Sub
        End Try

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        status = docum("status")
        fecha = docum("fechafactura")
        id_cliente = docum("id_directorio") : idcliente.Text = id_cliente
        tipo_venta = td
        tablamov = amov.GetDataByKey(td, folio, serie)
        For j As Integer = 0 To tablamov.Rows.Count - 1
            id = tablamov.Rows(j).Item("id_prodcuto")
            idud = tablamov.Rows(j).Item("ud")
            cantidad = tablamov.Rows(j).Item("cantidad")

            Dim filtro As String = "id_producto = " + id.ToString + " and id_unidad = " + idud.ToString
            Me.Lista_de_ventasBindingSource.Filter = filtro
            If Me.Lista_de_ventasBindingSource.Position < 0 Then
            Else
                Dim dr As DataRow = mytable.NewRow
                dr("id") = Me.Id_productoTextBox.Text
                dr("iva") = Me.IvaTextBox.Text
                dr("piva") = Me.IvaTextBox.Text
                dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                dr("und") = Me.UnidadTextBox.Text
                dr("factor") = Me.FactorTextBox.Text
                dr("cantidad") = cantidad
                dr("ud_costo") = Me.CostoTextBox.Text
                dr("ud_plventa") = Me.VentaTextBox.Text
                dr("ud_flista") = info_factor 'factor precio lista
                dr("ud_pventa") = Int(dr("ud_plventa") * info_factor * 100) / 100
                dr("pdesc") = 0
                dr("nf") = 1
                dr("peso") = Me.PesoTextBox.Text
                dr("ud_id") = Me.Id_unidadTextBox.Text
                dr("codigo") = Me.CodigoTextBox1.Text
                mytable.Rows.Add(dr)
                Me.linea.Text = "" : Me.linea.Focus()
            End If
        Next
        Dim adap As New admintegralDataSetTableAdapters.ComentariosTableAdapter
        Dim dr1 As DataRow
        dr1 = adap.GetDataBykey(td, folio, serie).Rows(0)
        comentarios.Text = dr1.Item("comentarios")
        adap.Dispose()

        Me.Lista_de_ventasBindingSource.Filter = ""
        If idcliente.Text > 0 Then cargar_cliente()
        totalizar()
        Me.folio.Text = folio.ToString
        nueva = False
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub 'Carga a memoria documento y lo cancela o Borra


    Private Sub CapturaVariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaVariosToolStripMenuItem.Click
        Me.TabControl1.SelectTab(5)
        Me.filtropedido.Text = ""
        Me.filtropedido.Focus()
    End Sub

    Private Sub filtropedido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtropedido.TextChanged
        Dim filtro As String
        filtro = preparar_filtro("Descripcion", filtropedido.Text)
        bsexistencia.Filter = filtro
    End Sub

    Private Sub dgvpedido_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvpedido.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub linea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linea.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_margen.Click
        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                dgv.Rows(j).Cells("ud_pventa").Value = dgv.Rows(j).Cells("ud_costo").Value * (1 + (Me.txtmargen.Text / 100))
            End With
            totalizar()
        Next
    End Sub

    Private Sub txtajustar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtajustar.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Decimal
        x = 1 + (((CDbl(Me.txtajustar.Text) * 100) / CDbl(Me.txtcosto.Text) - 100) / 100)
        txtmargen.Text = x.ToString
        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                dgv.Rows(j).Cells("ud_pventa").Value = dgv.Rows(j).Cells("ud_costo").Value * (1 + (Me.txtmargen.Text / 100))
            End With
            totalizar()
        Next
    End Sub

    Private Sub dgv_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class