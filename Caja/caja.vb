Imports System
Imports System.Text
Imports Microsoft.VisualBasic
Class caja
    Public tipo_venta As Integer ' nota,factura,dev, nota credito
    Dim credito As Boolean = False
    Dim como_pago As Integer
    Dim bs As New BindingSource
    Dim tarjetacredito As Boolean = True
    Dim negativo As Boolean = False
    Dim pedirprecio As Boolean = False
    Dim id_contado, id_vales As Long
    Dim path_tickets As String = "c:\tmp\tickets\" + Format(Now.Date, "ddMMMyyyy")
    Dim sihay As Boolean = False
    Dim facturar_paquete As Boolean = False
    Dim mdescripcion, munidad, mprecio As String
    Dim FACT_OXXO As Boolean = False

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
    Dim jalada_saldo As Single
    Dim id_autorizacion As Integer
    Dim autorizacion_pesos As Decimal
    Dim ancho_ticket As Integer = 36
    Dim tmpfile As String

    Dim monitor_guardar As Boolean
    Dim monitor_facturas As Boolean
    Dim monitor_boletas As Boolean  'pagos head
    Dim monitor_pago As Boolean

    Private Sub caja_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Main.MenuStrip.Visible = True
        Main.barra_menu1.Visible = True
    End Sub 'cerrar cajaada

    Private Sub caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Directorio' Puede moverla o quitarla según sea necesario.
        Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)
        'TODO: esta línea de código carga datos en la tabla 'FeiDataset.fei_metodos' Puede moverla o quitarla según sea necesario.
        Me.Fei_metodosTableAdapter.Fill(Me.FeiDataset.fei_metodos)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Directorio' Puede moverla o quitarla según sea necesario.
        factor_iva1_venta = (My.Settings.iva / 100).ToString 'iva10
        factor_iva2_venta = (My.Settings.iva2 / 100).ToString 'iva15
        Try
            MkDir(path_tickets)
        Catch ex As Exception

        End Try
        Me.ActivadoModuloDeCFDToolStripMenuItem.Checked = My.Settings.FEI_activo
        If My.Settings.separar = True Then
            lblsepara.Text = "Especial"
        Else
            lblsepara.Text = "Normal"
        End If

        Me.lbldolares.Text = "Dolares (T.C.: " + My.Settings.tipodecambio.ToString + ")"

        Me.boton_traspasos.Visible = esterminal
        Panel1.Visible = True
        Me.folionc.Visible = False
        Label20.Visible = True
        Label21.Visible = True
        If tipo_venta = 7 Then
            txtconcepto.Visible = True : txtrecibio.Visible = True
            Me.ToolStrip2.Visible = True
            Me.ToolStripButton1.Owner = Me.ToolStrip2
            Me.boton_cliente.Owner = Me.ToolStrip2
            Me.Boton_imprimir.Owner = Me.ToolStrip2
            Me.boton_repetir.Owner = Me.ToolStrip2
            Me.ToolStrip1.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Dim a As New admintegralDataSetTableAdapters.foliosTableAdapter
            Dim f As Long
            Try
                f = a.siguiente(7, "NC")
            Catch ex As Exception
                f = 1
            End Try

            a.Dispose()
            Me.folionc.Text = "Folio " + f.ToString
            Me.folionc.Visible = True
            idcliente.Enabled = False
        End If

        If info_caja = 0 Then
            My.Forms.frm_selecciona_caja.ShowDialog()
            info_caja = My.Forms.frm_selecciona_caja.ncaja
        End If

        Me.CajasTableAdapter.FillBy(Me.AdmintegralDataSet.cajas, info_caja)
        Me.Refresh()
        Me.Text = "Caja :" + Me.Id_cajaTextBox.Text + " Serie :" + Me.SerieTextBox.Text + " User: " + user.nombre + " Suc. " + Me.sucursaltxt.Text
        Me.WindowState = FormWindowState.Maximized

        If Me.AdmintegralDataSet.cajas.Rows.Count = 0 Then
            MsgBox("No Existe La caja No." + info_caja.ToString + ",Salga y defina corretamente el No. de Caja")
            Exit Sub
        End If
        Main.status2.Text = "Caja No." + info_caja.ToString + " Serie '" + Me.SerieTextBox.Text + "'"
        info_serie = Me.SerieTextBox.Text

        'Valida id de pago de contado
        id_contado = id_pago(info_caja, 1, Now.Date)
        If id_contado = 0 Then
            crear_pago(info_caja, 1, Now.Date, user.id)
            id_contado = id_pago(info_caja, 1, Now.Date)
        End If

        'Valida id de pago con vales
        id_vales = id_pago(info_caja, 2, Now.Date)
        If id_vales = 0 Then
            crear_pago(info_caja, 2, Now.Date, user.id)
            id_vales = id_pago(info_caja, 2, Now.Date)
        End If

        'TODO: inicializa Log de caja y verifica si no esta cerrada

        If Me.Log_cajasTableAdapter.GetDataBycaja_fecha(info_caja, CDate(Now.Date)).Rows.Count > 0 Then
            Me.Log_cajasTableAdapter.FillBycaja_fecha(Me.AdmintegralDataSet.log_cajas, info_caja, CDate(Now.Date))
        Else
            inicializar_caja()
        End If

        crear_grid()


        Me.SeriesTableAdapter.FillByserie(Me.AdmintegralDataSet.Series, SerieTextBox.Text)
        Me.TabControl1.SelectTab(1)
        Me.totaltxt.Text = "0.00" ' totalizar()
        Me.TopMost = False

        'Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)
        'se hizo cambui ek ka kusta de venta se agrego un campo mas
        Try
            Me.Lista_de_ventasTableAdapter.Fill(Me.AdmintegralDataSet.Lista_de_ventas)
        Catch ex As Exception

        End Try


        If tipo_venta = 7 Then
            Me.Text = "Notas de Credito"
            cargar_factura()
            Exit Sub
        End If

        If My.Settings.impresora_ticket = "ND" Then
            credito = True : Me.lblcredito.Text = "Credito"
            Me.boton_credito.Text = "Contado"
            Me.boton_pago_contado.Enabled = False
            Me.boton_pago_tarjeta.Enabled = False
            Me.boton_pago_credito.Enabled = True

            tipo_venta = 6 : Me.lbltipoventa.Text = "Factura"
            Label19.Visible = True : facturastxt.Visible = True
            Me.boton_factura.Text = "Ticket"

        Else
            Me.tipo_venta = 5 : Me.lbltipoventa.Text = "Ticket"
            id_cliente = 0
            cargar_cliente()
        End If
        validar_folios()
        tmpfile = "c:\tmp\factura.txt"
        My.Settings.tmpfile = tmpfile
        Try
            tmpfile = "c:\tmp\operacion_" + FolioTextBox.Text + RemisionTextBox.Text + ".tmp"
            status2.Text = tmpfile
            My.Settings.tmpfile = tmpfile
            My.Settings.Save()
        Catch ex As Exception
            tmpfile = "c:\tmp\op" + Now.TimeOfDay.ToString + ".tmp"
            My.Settings.tmpfile = tmpfile
            My.Settings.Save()
        End Try
        linea.Focus()

    End Sub 'Leer form

    Private Sub inicializar_caja()
        Me.Log_cajasTableAdapter.Insert(info_caja, Now.Date, Now, user.id, Now, 0, id_contado, id_vales, False, 0, "")
    End Sub ' crear registro log de caja

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
        FACT_OXXO = False : Me.logo_oxxo.Visible = False
        'valida que exista en datos facturacion electronica

        
        FACT_OXXO = False : Me.logo_oxxo.Visible = False
        If id_cliente.ToString = OXXO_id Then FACT_OXXO = True : Me.logo_oxxo.Visible = True

        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tabla As New DataTable() 'tabla del detalle de pedido
        Dim cmd, cs As String
        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT saldos_por_cliente.* FROM saldos_por_cliente WHERE id_directorio = " + id_cliente.ToString
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        'Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.SelectCommand.CommandTimeout = 3000
        AdaptadorDeDatos.Fill(tabla)
        If tabla.Rows.Count = 0 Then
            cmd = "SELECT saldos_por_cliente.* FROM saldos_por_cliente WHERE id_directorio = 0"
            AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
            AdaptadorDeDatos.SelectCommand.CommandTimeout = 3000
            AdaptadorDeDatos.Fill(tabla)
            idcliente.Text = "0"
        End If
        Me.cnombre.Text = tabla.Rows(0).Item("Nombre").ToString
        Me.cdireccion.Text = tabla.Rows(0).Item("Direccion").ToString
        Me.csaldo.Text = Format(tabla.Rows(0).Item("credito"), "N2")
        Me.ccolonia.Text = tabla.Rows(0).Item("Colonia").ToString
        Me.cdias.Text = tabla.Rows(0).Item("Dias").ToString
        Me.crfc.Text = tabla.Rows(0).Item("rfc").ToString
        Me.cemail.Text = tabla.Rows(0).Item("email").ToString
        Me.FormaTextBox.Text = tabla.Rows(0).Item("forma").ToString
      
        If (crfc.Text.Trim.Length < 12 Or crfc.Text.Trim.Length > 13 Or crfc.Text.Contains("-") = True) And idcliente.Text <> "0" Then
            MsgBox("Validar RFC, solicitar a oficina de credito que ponga bien su R.F.C.!!!")
            id_cliente = 0 : idcliente.Text = "0"
        End If

        Me.cdesglosar.Checked = tabla.Rows(0).Item("desglosar")
        Me.climite.Text = tabla.Rows(0).Item("Limite").ToString
        Me.cciudad.Text = tabla.Rows(0).Item("Ciudad").ToString
        Me.Listatxt.Text = tabla.Rows(0).Item("ruta").ToString
        Me.ccomercial.Text = tabla.Rows(0).Item("comercial").ToString
        Me.cagente.Text = tabla.Rows(0).Item("id_agente").ToString
        Me.ccp.Text = tabla.Rows(0).Item("CP").ToString
        Me.telefono.Text = tabla.Rows(0).Item("telefono").ToString
        Dim adap As New admintegralDataSetTableAdapters.ListasTableAdapter
        info_factor = adap.Factor(Me.Listatxt.Text)
        Main.StatusStrip1.Items(2).Text = info_factor
        'Actualiza: si hay renglones modifica el valor
        For j As Integer = 0 To mytable.Rows.Count - 1
            mytable.Rows(j).Item("ud_flista") = info_factor
            mytable.Rows(j).Item("ud_pventa") = mytable.Rows(j).Item("ud_plventa") * info_factor
        Next

        If idcliente.Text = 0 Then
            lblsaldo.Visible = False
            csaldo.Visible = False
            Me.cnombre.Text = "Publico General"
            Me.excedetxt.Visible = False
            Me.lblexcede.Visible = False
            Me.boton_autorizar.Visible = False
            leyendatxt.Text = "."
        Else
            lblsaldo.Visible = True
            csaldo.Visible = True
            Try
                leyendatxt.Text = Int(leer_tabla("select leyenda from directorio where tipo=2 and id_directorio =" + idcliente.Text).Rows(0).Item(0))
            Catch ex As Exception
                leyendatxt.Text = "."
            End Try
        End If
        If credito Then totalizar()

    End Sub '

    Private Sub FacturaNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaNotaToolStripMenuItem.Click, boton_factura.Click
        If tipo_venta = 5 Then
            tipo_venta = 6 : Me.lbltipoventa.Text = "Factura"
            dividir_factura()
            Label19.Visible = True
            facturastxt.Visible = True
            Me.boton_factura.Text = "Ticket"
            If idcliente.Text = "0" Then
                pedir_cliente()
                If id_cliente = 0 Then
                    Me.tipo_venta = 5 : Me.lbltipoventa.Text = "Ticket"
                    Me.boton_factura.Text = "Factura"
                End If
            End If
        Else
            If My.Settings.impresora_ticket = "ND" Then MsgBox("No puede imprimir Ticket") : Exit Sub
            Me.tipo_venta = 5 : Me.lbltipoventa.Text = "Ticket"
            dividir_ticket()
            Me.boton_factura.Text = "Factura"
            Label19.Visible = False
            facturastxt.Visible = False

            If credito = True Then
                credito = False : Me.lblcredito.Text = "Contado"
                Me.boton_credito.Text = "Credito"
                Me.mnu_pago_contado.Enabled = True
                Me.boton_pago_contado.Enabled = True
                Me.boton_pago_tarjeta.Enabled = True
                Me.boton_pago_credito.Enabled = False
                Me.excedetxt.Visible = False
                Me.lblexcede.Visible = False
                Me.boton_autorizar.Visible = False
            End If

        End If
    End Sub 'Swich Factura Nota

    Private Sub CreditoContadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditoContadoToolStripMenuItem.Click, boton_credito.Click
        If credito = True Then
            credito = False : Me.lblcredito.Text = "Contado"
            Me.boton_credito.Text = "Credito"
            Me.mnu_pago_contado.Enabled = True
            Me.boton_pago_contado.Enabled = True
            Me.boton_pago_tarjeta.Enabled = True
            Me.boton_pago_credito.Enabled = False
            Me.excedetxt.Visible = False
            Me.lblexcede.Visible = False
            Me.boton_autorizar.Visible = False
            Me.Boton_imprimir.Enabled = False
            Boton_avisar.Visible = False
        Else
            credito = True : Me.lblcredito.Text = "Credito"
            Boton_avisar.Visible = True
            Me.boton_credito.Text = "Contado"
            Me.boton_pago_contado.Enabled = False
            Me.boton_pago_tarjeta.Enabled = False
            Me.boton_pago_credito.Enabled = True

            tipo_venta = 6 : Me.lbltipoventa.Text = "Factura"
            Label19.Visible = True : facturastxt.Visible = True
            Me.boton_factura.Text = "Ticket"

            If idcliente.Text = "0" Then
                pedir_cliente() ' pide cliente si no se teclee se regresa a contado
                If id_cliente = 0 Then
                    credito = False : Me.lblcredito.Text = "Contado"
                    Me.boton_credito.Text = "Credito"
                    Me.mnu_pago_contado.Enabled = True
                    Me.boton_pago_contado.Enabled = True
                    Me.boton_pago_tarjeta.Enabled = True
                    Me.boton_pago_credito.Enabled = False
                End If
            End If
            Try
                If Me.totaltxt.Text > 0 Then totalizar()
            Catch ex As Exception

            End Try

        End If
    End Sub ' Swich credito contado

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

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")   '<=============IEPS
        column.ColumnName = "ieps" : column.Caption = "ieps" : column.DefaultValue = 0
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
        tabledoc.Columns("ieps").Expression = "sum(child.subieps)" '<=============IEPS del documento
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
        column = New DataColumn("piva", System.Type.GetType("System.Int32"), "iif (iva>0," + My.Settings.iva.ToString + ",0)")
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Descripcion", System.Type.GetType("System.String"))
        column.Caption = "Producto": mytable.Columns.Add(column)

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

        'column = New DataColumn("ud_pventa", System.Type.GetType("System.Decimal"), "(ud_flista * ud_plventa)")
        column = New DataColumn("ud_pventa", System.Type.GetType("System.Decimal"))
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
    End Sub '****************************************************************crear el grid

    Private Sub linea_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles linea.GotFocus
        linea.SelectAll()
    End Sub

    Private Sub linea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles linea.KeyPress, mod_linea.KeyPress
        'agregar producto a la grid
        Dim id As String

        'linea de captura
        Dim cant, x, y, p As Integer, filtro As String : Dim checa As String = ""
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Mid(linea.Text, 1, 1) = "V" Then checa = "V" : linea.Text = linea.Text.Substring(1)
            x = InStr(linea.Text, ".")
            y = InStr(linea.Text, "*") 'caja
            p = InStr(UCase(linea.Text), "P")
            If p > 0 Then
                cant = Val(linea.Text.Substring(0, p - 1))
                id = Mid(linea.Text, p + 1)
                If cant = 0 Then cant = 1
                Cargar_Paquete(id, cant)
                Exit Sub
            End If
            If x > 1 Then
                cant = Val(linea.Text.Substring(0, x - 1))
                id = Mid(linea.Text, x + 1)
                canttxt.Text = cant
                idtxt.Text = id
            Else
                If y > 1 Then
                    cant = Val(linea.Text.Substring(0, y - 1))
                    id = Mid(linea.Text, y + 1)
                    canttxt.Text = cant
                    idtxt.Text = id
                Else
                    cant = 1
                    idtxt.Text = linea.Text
                End If
            End If
            If negativo Then cant = cant * -1

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
                Else
                    'si no pidio por caja verifica que no sea unidad de detalle
                    If AlmacenTextBox.Text = 0 Then
                        Try
                            Dim miadap As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
                            Dim rw1 As DataRow = miadap.GetDataunidad(idtxt.Text).Rows(0)
                            miadap.Dispose()
                            Dim miadap1 As New admintegralDataSetTableAdapters.productosTableAdapter
                            Dim rw2 As DataRow = miadap1.GetDataById(Id_productoTextBox.Text).Rows(0)
                            If rw1.Item("id_unidad") = rw2.Item("und_detalle") And rw2.Item("und_detalle") <> rw2.Item("und_venta") Then
                                MsgBox("No se puede vender a detalle")
                                linea.Text = ""
                                Exit Sub
                            End If
                        Catch ex As Exception

                        End Try

                    End If
                End If

                If checa = "V" Then
                    Dim ixi As MsgBoxResult
                    Try
                        checa = "Producto :" + Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "") + chr10 + chr13
                        checa += "Und :" + Me.UnidadTextBox.Text + chr10 + chr13
                        Dim pu As Single
                        If Me.Precio_unicoCheckBox.Checked = False Then
                            pu = Int(Me.VentaTextBox.Text * info_factor * 100) / 100
                        Else
                            pu = Int(Me.VentaTextBox.Text * 100) / 100
                        End If
                        checa += "                    Precio : " + Format(pu, "N2")
                        ixi = MsgBox(checa, MsgBoxStyle.YesNo, "IMPRIMIR")
                        If ixi = MsgBoxResult.Yes Then

                            Dim l1, l2, l3 As String
                            mdescripcion = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                            munidad = Me.UnidadTextBox.Text
                            If Me.Precio_unicoCheckBox.Checked = False Then
                                pu = Int(Me.VentaTextBox.Text * info_factor * 100) / 100
                            Else
                                pu = Int(Me.VentaTextBox.Text * 100) / 100
                            End If
                            mprecio = Format(pu, "N2")

                            Try
                                Me.PrintDocument.PrinterSettings.PrinterName = My.Settings.impresora_ticket
                                Me.PrintDocument.Print()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try

                            ' Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, filenota)
                        End If
                        Exit Sub
                    Catch ex As Exception
                        Exit Sub
                    End Try
                End If
                ' verifica si ya existe en la factura

                Dim alta As Boolean = False
                Dim ix1 As Integer
                For ix1 = 0 To mytable.Rows.Count - 1
                    Try
                        With mytable.Rows(ix1)
                            If .Item("id") = Me.Id_productoTextBox.Text And .Item("ud_id") = Me.Id_unidadTextBox.Text Then
                                cant += .Item("cantidad")
                                .Item("cantidad") = cant
                                linea.Text = ""
                                alta = True
                            End If
                        End With
                        mytable.AcceptChanges()
                    Catch ex As Exception

                    End Try
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
                    dr("pieps") = Me.IepsTextBox.Text '<======IEPS

                    dr("ud_plventa") = Me.VentaTextBox.Text

                    If Me.Precio_unicoCheckBox.Checked = False Then dr("ud_flista") = info_factor Else dr("ud_flista") = 1 'factor precio lista
                    dr("ud_pventa") = Math.Round(dr("ud_plventa") * dr("ud_flista"), 2)


                    If pedirprecio Then
                        Dim msg As String = "Producto : " + dr("descripcion") + chr10 + chr13 + chr10
                        'msg += "Costo : " + Format(dr("ud_costo"), "N2") + chr10 + chr13
                        msg += "Venta : " + Format(dr("ud_pventa"), "N2") + chr10 + chr13
                        msg += chr10 + "Teclee el precio de venta."
                        Dim nprecio As Single, ok As Boolean = False
                        While ok = False
                            nprecio = Val(InputBox(msg, "Cambiar Precio", ""))
                            If nprecio < dr("ud_costo") Then
                                MsgBox("El precio de Venta debe de ser mayor al costo")
                            Else
                                ok = True
                            End If
                        End While
                        dr("ud_plventa") = nprecio
                        dr("ud_flista") = 1
                        dr("ud_pventa") = nprecio
                    End If

                    If FACT_OXXO = True Then

                        dr("ud_plventa") = poxxo(Id_productoTextBox.Text)
                        dr("ud_flista") = 1
                        dr("ud_pventa") = dr("ud_plventa")

                        If dr("ud_plventa") = 0 Then
                            MsgBox("No es productos Oxxo")
                            Exit Sub
                        End If
                    End If

                    dr("pdesc") = 0
                    dr("nf") = 1
                    dr("peso") = Me.PesoTextBox.Text
                    dr("ud_id") = Me.Id_unidadTextBox.Text
                    dr("codigo") = idtxt.Text
                    dr("separar") = IIf(Me.SepararCheckBox.Checked = True, 1, 0)
                    mytable.Rows.Add(dr)
                End If
                totalizar()
                If negativo Then
                    For j As Integer = 0 To dgv.Rows.Count - 1
                        If dgv.Rows(j).Cells("cantidad").Value < 0 Then
                            dgv.Rows(j).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next

                End If
                Me.lineastxt.Text = dgv.Rows.Count - 1
                If dgv.RowCount > dgv.DisplayedRowCount(False) Then
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - dgv.DisplayedRowCount(False) - 1
                End If
                Me.linea.Text = "" : Me.linea.Focus()
                Try
                    'Dim fileName As New System.IO.StreamWriter(tmpfile, True, System.Text.ASCIIEncoding.Unicode)
                    'fileName.WriteLine(idtxt.Text + "," + Me.Id_unidadTextBox.Text + "," + cant.ToString)
                    'fileName.Close()
                    mytable.WriteXml(tmpfile)
                Catch ex As Exception

                End Try

            End If
            bs.Filter = ""
            Me.Lista_de_ventasBindingSource.Filter = ""
        End If
    End Sub '******************************************* LINEA DE CAPTURA

    Private Sub verifica_precio()
        Dim cv As String = InputBox("Codigo del producto", "Verificar Precio", "")
        linea.Text = "V" + cv
        Dim cant, x, y As Integer, id As String, filtro As String : Dim checa As String = ""
        If Mid(linea.Text, 1, 1) = "V" Then checa = "V" : linea.Text = linea.Text.Substring(1)
        x = InStr(linea.Text, ".")
        y = InStr(linea.Text, "*") 'caja
        If x > 1 Then
            cant = Val(linea.Text.Substring(0, x - 1))
            id = Mid(linea.Text, x + 1)
            canttxt.Text = cant
            idtxt.Text = id
        Else
            If y > 1 Then
                cant = Val(linea.Text.Substring(0, y - 1))
                id = Mid(linea.Text, y + 1)
                canttxt.Text = cant
                idtxt.Text = id
            Else
                cant = 1
                idtxt.Text = linea.Text
            End If
        End If

        Dim ix As Integer = Me.Lista_de_ventasBindingSource.Find("codigo", Me.idtxt.Text)
        If ix < 0 Then
            MsgBox("No Existe")
            linea.Text = ""
            Exit Sub
        Else
            Me.Lista_de_ventasBindingSource.Position = ix
            MsgBox(Me.IvaTextBox.Text)
            If y > 0 Then ' filtra para ubicar uniad de compra
                Dim undcompra As Und = sk_leer_UndCompra(Id_productoTextBox.Text) 'determina unidad de compra
                filtro = "id_producto = " + Me.Id_productoTextBox.Text + " and id_unidad = " + undcompra.a9_uc_id.ToString
                Me.Lista_de_ventasBindingSource.Filter = filtro
                If Me.Lista_de_ventasBindingSource.Position < 0 Then
                    MsgBox("No existe x Caja")
                    Me.Lista_de_ventasBindingSource.Filter = ""
                    Exit Sub
                End If
            Else
                'si no pidio por caja verifica que no sea unidad de detalle
                If AlmacenTextBox.Text = 0 Then
                    Try
                        Dim miadap As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
                        Dim rw1 As DataRow = miadap.GetDataunidad(idtxt.Text).Rows(0)
                        miadap.Dispose()
                        Dim miadap1 As New admintegralDataSetTableAdapters.productosTableAdapter
                        Dim rw2 As DataRow = miadap1.GetDataById(Id_productoTextBox.Text).Rows(0)
                        If rw1.Item("id_unidad") = rw2.Item("und_detalle") And rw2.Item("und_detalle") <> rw2.Item("und_venta") Then
                            MsgBox("No se puede vender a detalle")
                            linea.Text = ""
                            Exit Sub
                        End If
                    Catch ex As Exception

                    End Try

                End If
            End If

            If checa = "V" Then
                Try
                    Dim prod, und, precio As String
                    prod = "Producto :" + Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                    und = "Und :" + Me.UnidadTextBox.Text
                    Dim pu As Single
                    If Me.Precio_unicoCheckBox.Checked = False Then
                        pu = Int(Me.VentaTextBox.Text * info_factor * 100) / 100
                    Else
                        pu = Int(Me.VentaTextBox.Text * 100) / 100
                    End If
                    precio = "Precio : " + Format(pu, "N2")
                    My.Forms.ver_precio.mensage(prod, und, precio)
                    My.Forms.ver_precio.ShowDialog()
                    linea.Text = ""
                    Exit Sub
                Catch ex As Exception
                    Exit Sub
                End Try
            End If
        End If

    End Sub

    Private Sub totalizar()
        If tipo_venta = 5 Then dividir_ticket() Else dividir_factura()
        tabledoc.AcceptChanges()
        Me.lineastxt.Text = dgv.Rows.Count - 1
        Try
            totaltxt.Text = Format(mytable.Compute("sum(total)", ""), "N2")
        Catch ex As Exception
            totaltxt.Text = "0.00"
        End Try
        Dim td, tc, co, limite As Decimal
        If totaltxt.Text = "" Then
            td = 0 : tc = 0 : co = 0
        Else
            co = CDbl(totaltxt.Text)
            td = co * cia.comidebito
            tc = co * cia.comicredito
        End If

        If tipo_venta = 7 Then
            total_debito.Visible = False
            Total_credito.Visible = False
            If co > 0 Then
                Me.Boton_imprimir.Enabled = True
            Else
                Me.Boton_imprimir.Enabled = False
            End If
            Exit Sub
        End If

        Dim ix As Integer = bs.Find("codigo", "0000000000")
        If ix < 1 Then
            total_debito.Text = Format(td, "N2")
            Total_credito.Text = Format(tc, "N2")
            total_debito.Visible = True
            Total_credito.Visible = True
        End If

        If credito Then
            Try
                limite = (CDbl(csaldo.Text)) + 99999999

            Catch ex As Exception
                limite = 0
            End Try

            If co > limite And Me.idcliente.Text <> "0" Then
                Dim por_autorizar As Decimal
                por_autorizar = co - limite
                excedetxt.Text = Format(por_autorizar, "N2")
                excedetxt.Visible = True
                lblexcede.Visible = True
                If co > 0 Then Me.boton_autorizar.Visible = True
                Boton_imprimir.Enabled = False
            Else
                excedetxt.Visible = False
                lblexcede.Visible = False
                Me.boton_autorizar.Visible = False
                Boton_imprimir.Enabled = True
            End If
        Else
            excedetxt.Visible = False
            lblexcede.Visible = False
            Me.boton_autorizar.Visible = False
        End If
    End Sub 'Totalizar

    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        mytable.AcceptChanges()
        totalizar()
    End Sub ' Todo:recalcula total cuando se cambia el grid


    Private Sub idcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idcliente.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            FACT_OXXO = False : Me.logo_oxxo.Visible = False

            id_cliente = idcliente.Text
            Me.excedetxt.Visible = False
            Me.lblexcede.Visible = False
            Me.boton_autorizar.Visible = False

            cargar_cliente()
            e.Handled = True
            linea.Focus()
        End If

    End Sub

    Private Sub lblsaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsaldo.Click
        extraer_definicion(mytable, "c:\tmp\Tabla_caja.txt")
    End Sub 'todo: Borrar genera definicion de Grid de caja 

    Private Sub cdias_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdias.TextChanged
        fvence.Value = Date.Now.AddDays(cdias.Text)
    End Sub 'calcula dias de vencimiento

    Private Sub DiarioDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiarioDeVentasToolStripMenuItem.Click
        My.Forms.diario_ventas.cargar_reporte(info_serie, Now.Date, "Diario de Ventas", Now.Date)
        My.Forms.diario_ventas.ShowDialog()
    End Sub 'Diario de Ventas

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click, BorrarNotaToolStripMenuItem.Click
        Dim x As MsgBoxResult
        x = MsgBox("Seguro que quiere Limpiar la Nota", MsgBoxStyle.YesNo, "Iniciar de Nuevo")
        If x = MsgBoxResult.Yes Then
            panel_paquete.Visible = False
            mytable.Clear()
            tabledoc.Clear()
            Dim dr As DataRow = tabledoc.NewRow
            dr(0) = 1 : tabledoc.Rows.Add(dr)
            tabla_pago.Clear()
            Dll.Text = "0"

            Me.totaltxt.Text = "0.00"
            totalizar()
            TabControl1.SelectedIndex = 1
            Me.linea.Focus()
            Try
                My.Computer.FileSystem.DeleteFile(tmpfile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Catch ex As Exception

            End Try
            jalada_td = 0
            jalada_folio = 0
            jalada_serie = 0
            id_cliente = 0
            cargar_cliente()
        End If
    End Sub ' **********************************************Boton Borrar NOTA

    Private Sub dividir_factura()
        mytable.AcceptChanges()
        If tipo_venta = 5 Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'agrupa
        For j As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows(j).Cells("N").Value = j + 1
            dgv.Rows(j).Cells("NF").Value = 1
        Next j
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub '***************************************************** Dividir  Factura

    Private Sub dividir_ticket()
        mytable.AcceptChanges()
        If My.Settings.separar = False Or tipo_venta <> 5 Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'determina si hay que separar
        sihay = False
        With dgv
            For j As Integer = 0 To .Rows.Count - 1
                If dgv.Rows(j).Cells("separar").Value = True Then
                    sihay = True : Exit For
                End If
            Next
        End With

        Dim f As Integer
        If sihay = False Then
            f = 1
        Else
            f = 2
        End If

        If tabledoc.Rows.Count = 1 Then
            Dim dr As DataRow = tabledoc.NewRow
            dr(0) = 2
            tabledoc.Rows.Add(dr)
        End If

        With dgv
            For j As Integer = 0 To .Rows.Count - 1
                If dgv.Rows(j).Cells("separar").Value = True Then
                    dgv.Rows(j).Cells("nf").Value = 1
                    dgv.Rows(j).Cells("n").Value = j
                Else
                    dgv.Rows(j).Cells("n").Value = j
                    dgv.Rows(j).Cells("nf").Value = 2
                End If
            Next
        End With
        facturastxt.Text = f
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub  'dividir tiket


    Private Sub calcular_cambio()
        Dim pdolar As Decimal = 0
        Try
            pdolar = Val(Me.Dll.Text) * My.Settings.tipodecambio
        Catch ex As Exception
            pdolar = 0
        End Try

        If tipo_venta = 7 Then Exit Sub
        Dim t1, t2, t3, t4, total, tcambio As Double
        Try
            If Me.totaltxt.Text = 0 Then Exit Sub
        Catch ex As Exception
        End Try

        If como_pago = 1 Then 'Contado
            total = CDbl(Me.totaltxt.Text)
            Try
                If Me.pago_efectivotxt.Text = "" Then t1 = 0 Else t1 = CDbl(Me.pago_efectivotxt.Text) + pdolar
                If Me.pago_valestxt.Text = "" Then t2 = 0 Else t2 = CDbl(Me.pago_valestxt.Text)
                If Me.pago_bancostxt.Text = "" Then t3 = 0 Else t3 = CDbl(Me.pago_bancostxt.Text)
                If Me.pago_nctxt.Text = "" Then t4 = 0 Else t4 = CDbl(Me.pago_nctxt.Text)

            Catch ex As Exception
            End Try
        Else
            If Me.Tarjeta_importe.Text = " " Then t1 = 0 Else t1 = CDbl(Me.Tarjeta_importe.Text)
            If Me.tarjeta_efectivo.Text = "" Then t2 = 0 Else t2 = CDbl(Me.tarjeta_efectivo.Text) + pdolar
            If Me.tarjeta_vales.Text = "" Then t3 = 0 Else t3 = CDbl(Me.tarjeta_vales.Text)
            If Me.pago_nctxt.Text = "" Then t4 = 0 Else t4 = CDbl(Me.pago_nctxt.Text)
            If tarjetacredito = True Then
                total = Me.Total_credito.Text
            Else
                total = Me.total_debito.Text
            End If
        End If

        Try
            Dim tpagado As Double
            tpagado = t1 + t2 + t3 + t4
            tcambio = total - tpagado
            If tcambio > 1 Then
                lblcambio.Text = "Falta"
                Boton_imprimir.Enabled = False
            Else
                If Math.Abs(tcambio) > t1 And Math.Abs(tcambio) - t1 > 20 Then
                    MsgBox("No se puede regresar Dinero")
                    Boton_imprimir.Enabled = False
                Else
                    lblcambio.Text = "Cambio"
                    Boton_imprimir.Enabled = True
                End If
            End If
            Me.cambiotxt.Text = Format(tcambio, "N2")
            Me.txtpagado.Text = Format(tpagado, "N2")
            If como_pago > 1 And (pago_banco.TextLength = 0 Or Banco_tarjeta.TextLength = 0) Then Boton_imprimir.Enabled = False
        Catch ex As Exception
        End Try

    End Sub

    Private Sub pago_efectivotxt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pago_efectivotxt.Click, pago_valestxt.Enter, pago_valestxt.Click
        sender.SelectAll()
    End Sub 'Calcula Cambio

    Private Sub pago_efectivotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pago_efectivotxt.TextChanged, pago_valestxt.TextChanged, pago_bancostxt.TextChanged, tarjeta_vales.TextChanged, tarjeta_efectivo.TextChanged, pago_nctxt.TextChanged, Dll.TextChanged
        calcular_cambio()
    End Sub

    Private Sub pago_efectivotxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pago_efectivotxt.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
        If e.KeyChar = chr13 Then
            SendKeys.Send("{TAB}")

        End If

    End Sub

    Private Sub boton_pago_contado_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles boton_pago_contado.EnabledChanged
        Me.mnu_pago_contado.Enabled = Me.boton_pago_contado.Enabled
    End Sub

    Private Sub boton_pago_tarjeta_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_pago_tarjeta.EnabledChanged
        Me.mnu_Pago_credito.Enabled = Me.boton_pago_tarjeta.Enabled
        Me.mnu_Pago_debito.Enabled = Me.boton_pago_tarjeta.Enabled
    End Sub

    Private Sub lineastxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lineastxt.TextChanged
        Dim f As Integer = Me.lineastxt.Text \ My.Settings.LineasXfactura + 1
        If tipo_venta = 6 Then
            facturastxt.Text = f
        Else
            facturastxt.Text = 1
        End If
    End Sub ' define cuantos renglones y cuantas facturas

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedIndex <> 3 And TabControl1.SelectedIndex <> 5 Then
            ProductosBindingSource.Filter = ""
            borrar_comision()
            TabControl1.SelectedIndex = 1 : Boton_imprimir.Enabled = False
            totalizar()
        Else
            If TabControl1.SelectedIndex = 5 Then
                inicia_nota()
                ProductosBindingSource.Filter = "id_grupo=100"
            End If

        End If
    End Sub ' impide que cambien el TAB con un CLick

    Private Sub borrar_comision()
        Dim ix As Integer
        While ix > -1

            Try
                ix = bs.Find("codigo", "0000000000")
                If ix > -1 Then
                    bs.RemoveAt(ix)
                End If
            Catch ex As Exception
            End Try
        End While
    End Sub 'Borrar Comision

    Private Sub inicia_nota()
        Dim x As MsgBoxResult

        panel_paquete.Visible = False
        mytable.Clear()
        tabledoc.Clear()
        Dim dr As DataRow = tabledoc.NewRow
        dr(0) = 1 : tabledoc.Rows.Add(dr)
        tabla_pago.Clear()
        Dll.Text = "0"

        Me.totaltxt.Text = "0.00"
        totalizar()
        mod_linea.Focus()
        Try
            My.Computer.FileSystem.DeleteFile(tmpfile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Catch ex As Exception

        End Try
        jalada_td = 0
        jalada_folio = 0
        jalada_serie = 0
        id_cliente = 0
        cargar_cliente()

    End Sub

    Private Sub Boton_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_imprimir.Click, ImprimirToolStripMenuItem.Click
        dividir_factura()
        If tipo_venta = 5 And My.Settings.separar = True Then dividir_ticket()
        Try
            If credito = True And id_cliente = 0 Then Exit Sub
            If credito = True Then como_pago = 4
            If totaltxt.Text < 1 Then Exit Sub
        Catch ex As Exception
        End Try

        If tipo_venta <> 5 Then
            Dim frmalerta As New alerta_de_facturacion
            With frmalerta
                .RFC.Text = crfc.Text
                .NOMBRE.Text = cnombre.Text
                .EMAIL.Text = cemail.Text
                .USO.Text = UsoTextBox.Text
                .FORMA.Text = FormaTextBox.Text
                .forma_descripcion.Text = formaComboBox.Text

                If credito = True Then
                    .METODO.Text = "PPD"
                Else
                    .METODO.Text = "PUE"

                End If
            End With
            frmalerta.ShowDialog()
            If frmalerta.DialogResult = Windows.Forms.DialogResult.Cancel Then
                MsgBox("No se imprime") : Exit Sub
            Else
                With frmalerta
                    crfc.Text = .RFC.Text()
                    cnombre.Text = .NOMBRE.Text
                    cemail.Text = .EMAIL.Text
                    MetodoTextBox.Text = .METODO.Text
                    UsoTextBox.Text = .USO.Text
                    FormaTextBox.Text = .FORMA.Text
                    formaComboBox.Text = .forma_descripcion.Text
                End With
            End If
        End If

        guardar_imprimir()

    End Sub '********************************************************Boton Imprimir Guardar *********

    Private Sub boton_relacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_relacion.Click
        My.Forms.caja_relacion.cargar_tabla(SerieTextBox.Text, CDate(Now.Date))
        My.Forms.caja_relacion.Show()
        My.Forms.caja_relacion.Focus()
    End Sub ' Boton desplegar facturas/notas

    Private Sub boton_repetir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_repetir.Click
        Pedir_folio.ShowDialog()
        If Pedir_folio.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim td, folio As Integer, serie As String
            If Pedir_folio.factura.Checked = True Then td = 6 Else td = 5
            Try
                folio = IIf(Pedir_folio.folio.Text = "", 0, Pedir_folio.folio.Text)
            Catch ex As Exception
                folio = 0
            End Try
            serie = Pedir_folio.serie.Text + " "
            repetir_documento(td, folio, Trim(serie), False)
        End If
    End Sub ' Boton repetir Factura

    Private Sub repetir_documento(ByVal td As Integer, ByVal folio As Integer, ByVal serie As String, ByVal borrar As Boolean)
        Dim adoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim lista As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        Dim status As Integer, fecha As Date, id As Integer, idud, cantidad As Integer, pl As Double
        Dim docum As DataRow, tablamov As New DataTable
        jalada_td = td
        jalada_folio = folio
        jalada_serie = UCase(serie)
        Try
            docum = adoc.GetDataByKey(td, folio, serie).Rows(0)
        Catch ex As Exception
            MsgBox("No se encuantra ese documento")
            Exit Sub
        End Try
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        status = docum("status")
        fecha = docum("fechafactura")
        If status = 1 Then
            Dim x As MsgBoxResult
            x = MsgBox("Este folio esta cancelado, Quiere Cargarlo ", MsgBoxStyle.YesNo, "Repetir Documento")
            If x <> MsgBoxResult.Yes Then Exit Sub
        End If

        If docum("id_cartera") = 2 Then credito = True Else credito = False
        id_cliente = docum("id_directorio") : idcliente.Text = id_cliente
        cargar_cliente()
        'Defini menus y labels segun tipo de venta
        If tipo_venta <> 7 Then
            tipo_venta = td
            If tipo_venta = 6 Then
                Me.lbltipoventa.Text = "Factura"
                Label19.Visible = True
                facturastxt.Visible = True
                Me.boton_factura.Text = "Ticket"
            Else
                Me.tipo_venta = 5 : Me.lbltipoventa.Text = "Ticket"
                Me.boton_factura.Text = "Factura"
                Label19.Visible = False
                facturastxt.Visible = False
            End If
        End If

        tablamov = amov.GetDataByKey(td, folio, serie)
        For j As Integer = 0 To tablamov.Rows.Count - 1
            id = tablamov.Rows(j).Item("id_prodcuto")
            idud = tablamov.Rows(j).Item("ud")
            cantidad = tablamov.Rows(j).Item("cantidad")
            pl = tablamov.Rows(j).Item("venta")
            Dim filtro As String = "id_producto = " + id.ToString + " and id_unidad = " + idud.ToString
            Me.Lista_de_ventasBindingSource.Filter = filtro
            ' Me.Lista_de_ventasBindingSource.Position = Me.Lista_de_ventasBindingSource.Find("codigo", codigo)
            If Me.Lista_de_ventasBindingSource.Position < 0 Then
            Else
                Dim dr As DataRow = mytable.NewRow
                dr("id") = Me.Id_productoTextBox.Text
                dr("iva") = Me.IvaTextBox.Text
                dr("piva") = tablamov.Rows(j).Item("piva")
                dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                dr("und") = Me.UnidadTextBox.Text
                dr("factor") = tablamov.Rows(j).Item("factor")
                If tipo_venta <> 7 Then dr("cantidad") = cantidad Else dr("cantidad") = 0
                dr("ud_costo") = Me.CostoTextBox.Text
                dr("ud_plventa") = pl / info_factor
                dr("ud_flista") = info_factor 'info_factor 'factor precio lista
                dr("ud_pventa") = pl
                dr("pdesc") = 0
                dr("nf") = 1
                dr("pieps") = Me.IepsTextBox.Text
                dr("peso") = Me.PesoTextBox.Text
                dr("ud_id") = Me.Id_unidadTextBox.Text
                dr("codigo") = Me.CodigoTextBox.Text
                mytable.Rows.Add(dr)
                Me.linea.Text = "" : Me.linea.Focus()
            End If
        Next
        jalada_td = td
        jalada_folio = folio
        jalada_serie = UCase(serie)

        If fecha <> Now.Date And tipo_venta <> 7 Then
            MsgBox("No es de Hoy")
            jalada_td = 0
            jalada_folio = 0
            jalada_serie = 0
        End If
        Me.Lista_de_ventasBindingSource.Filter = ""

        If tipo_venta <> 7 Then

            If credito = False Then
                credito = False : Me.lblcredito.Text = "Contado"
                Me.boton_credito.Text = "Credito"
                Me.mnu_pago_contado.Enabled = True
                Me.boton_pago_contado.Enabled = True
                Me.boton_pago_tarjeta.Enabled = True
                Me.boton_pago_credito.Enabled = False
                Me.excedetxt.Visible = False
                Me.lblexcede.Visible = False
                Me.boton_autorizar.Visible = False
                Me.Boton_imprimir.Enabled = False
                Boton_avisar.Visible = False
            Else
                credito = True : Me.lblcredito.Text = "Credito"
                Boton_avisar.Visible = True
                Me.boton_credito.Text = "Contado"
                Me.boton_pago_contado.Enabled = False
                Me.boton_pago_tarjeta.Enabled = False
                Me.boton_pago_credito.Enabled = True
                tipo_venta = 6 : Me.lbltipoventa.Text = "Factura"
                Label19.Visible = True : facturastxt.Visible = True
                Me.boton_factura.Text = "Ticket"
            End If

            totalizar()
            dividir_factura()
        End If
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub 'Carga a memoria documento y lo cancela o Borra

    Private Sub SuspenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspenderToolStripMenuItem.Click
        Dim archivo As New SaveFileDialog
        archivo.Title = "Tecle una Referencia"
        archivo.Filter = "TMP (*.TMP)|*.TMP"
        archivo.InitialDirectory = "c:\tmp\susependidadas\"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            mytable.WriteXml(archivo.FileName)
            MsgBox("Archivo guardado : " + archivo.FileName)
        Else
            MsgBox("No se guardo nada")
        End If
    End Sub  'SUSPENDER ********************* Guarda

    Private Sub CARGAR_aRCHIVO(ByVal archivo As String)
        Dim frefile As Integer, a As String, c1, c2, c3 As String, ix As Integer
        frefile = FreeFile()
        FileOpen(frefile, archivo, OpenMode.Input)
        'Dim fileName As New System.IO.StreamWriter("C:\tmp\factura.tmp", True)
        Do Until EOF(frefile)
            Try
                a = LineInput(frefile)
                Dim i1, i2 As Integer
                i1 = InStr(a, ",") : i2 = InStr(i1 + 1, a, ",")
                c1 = Mid(a, 1, i1 - 1) : c2 = Mid(a, i1 + 1, (i2 - i1) - 1) : c3 = Mid(a, i2 + 1)

                ix = Me.Lista_de_ventasBindingSource.Find("codigo", c1)
                Me.Lista_de_ventasBindingSource.Position = ix


                'Dim filtro As String = "id_producto = " + c1.ToString + " and id_unidad = " + c2.ToString
                'Me.Lista_de_ventasBindingSource.Filter = filtro
                Dim dr As DataRow = mytable.NewRow
                dr("id") = Me.Id_productoTextBox.Text
                dr("iva") = Me.IvaTextBox.Text
                dr("piva") = Me.IvaTextBox.Text
                dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                dr("und") = Me.UnidadTextBox.Text
                dr("factor") = Me.FactorTextBox.Text
                dr("cantidad") = c3
                dr("ud_costo") = Me.CostoTextBox.Text
                dr("ud_plventa") = Me.VentaTextBox.Text
                dr("ud_flista") = info_factor 'factor precio lista
                dr("ud_pventa") = Int(dr("ud_plventa") * info_factor * 100) / 100
                dr("pdesc") = 0
                dr("nf") = 1
                dr("peso") = Me.PesoTextBox.Text
                dr("ud_id") = Me.Id_unidadTextBox.Text
                dr("codigo") = Me.listaventas_codigo.Text
                mytable.Rows.Add(dr)
            Catch ex As Exception
                ix = -1
            End Try
        Loop
        '  fileName.Close()
        totalizar()
        FileClose(frefile)
        Me.Lista_de_ventasBindingSource.Filter = ""
        Me.linea.Text = "" : Me.linea.Focus()

    End Sub '****************************************************carga un archivo TMP

    Private Sub CargarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarToolStripMenuItem.Click
        Dim archivo As New OpenFileDialog
        archivo.InitialDirectory = "c:\tmp\suspendidas\"
        archivo.Title = "Seleccione Un archvio"
        archivo.Filter = "TMP (*.TMP)|*.TMP"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            mytable.ReadXml(archivo.FileName)
            totalizar()
        End If
    End Sub ' ******* Cargar 

    Private Sub Tarjeta_importe_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tarjeta_importe.Enter
        sender.SelectAll()
    End Sub ' seleccion del texto al tomar foco

    Private Sub Tarjeta_importe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tarjeta_importe.TextChanged, pago_banco.TextChanged, Banco_tarjeta.TextChanged
        Try
            Me.tarjeta_efectivo.Enabled = False
            Me.tarjeta_vales.Enabled = False
            Dim i As Decimal = CDbl(Tarjeta_importe.Text)
            If i > Me.totaltxt.Text Then
                If tarjetacredito = True Then
                    Me.Tarjeta_importe.Text = Me.Total_credito.Text
                Else
                    Me.Tarjeta_importe.Text = Me.total_debito.Text
                End If
            Else
                Me.tarjeta_efectivo.Enabled = True
                Me.tarjeta_vales.Enabled = True
            End If
            calcular_cambio()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub boton_autorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_autorizar.Click
        Dim t As Double = excedetxt.Text
        Dim adap As New admintegralDataSetTableAdapters.autorizacionesTableAdapter
        Dim msg As String
        msg = InputBox("Teclee un mensaje para cobranza", "Solicitar mas credito", "")
        adap.Insert(info_caja, Date.Now, user.id, Me.idcliente.Text, t, 0, Date.Now, 0, msg)
        Me.boton_cancelar_solicitud.Visible = True
        Me.boton_autorizar.Visible = False
        Me.Boton_ver_Autorzaciones.Visible = True
        Me.lblstatus.Visible = True
        Me.lblstatus.Text = "Pendiente"
        adap.Dispose()
        Timer1.Enabled = True
    End Sub

    Private Sub verificar_autorizacion()
        Me.Timer1.Enabled = False
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tabla As New DataTable() 'tabla del detalle de pedido
        Dim cmd, cs As String
        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT autorizaciones.* FROM autorizaciones WHERE archivada=0 and importe>0 and id_cliente = " + id_cliente.ToString
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.SelectCommand.CommandTimeout = 3000
        AdaptadorDeDatos.Fill(tabla)
        Me.Boton_imprimir.Enabled = False
        Try
            If tabla.Rows.Count = 0 Then
                lblstatus.Visible = False
                Me.Boton_ver_Autorzaciones.Visible = False
                Me.boton_autorizar.Visible = True
                Timer1.Enabled = False
            End If
        Catch ex As Exception
            Exit Sub
        End Try
        Try
            If tabla.Rows(0).Item("status") = 1 Then
                My.Forms.Mensage.mensaje.Text = "No autorizado"
                My.Forms.Mensage.ShowDialog()
                lblstatus.Visible = False
                Me.Boton_ver_Autorzaciones.Visible = False
                Timer1.Enabled = False
                archivar_autorizaciones() 'Borra Autorizaciones ya pasadas
                totalizar()
                Exit Sub
            End If
            If tabla.Rows(0).Item("status") = 0 Then
                Me.Timer1.Enabled = True
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            id_autorizacion = tabla.Rows(0).Item("id")
            autorizacion_pesos = tabla.Rows(0).Item("importe")
        Catch ex As Exception
            id_autorizacion = 0 : autorizacion_pesos = 0
        End Try
        If autorizacion_pesos > 0 Then
            If csaldo.Text = "" Then csaldo.Text = "0"
            Dim nuevo_saldo As Decimal = CDbl(Me.csaldo.Text) + autorizacion_pesos
            Me.csaldo.Text = Format(nuevo_saldo, "n2")
            If nuevo_saldo + 2 > CDbl(Me.totaltxt.Text) Then
                Me.Boton_imprimir.Enabled = True
            End If
            Timer1.Enabled = False
            lblstatus.Visible = False
            Me.Boton_ver_Autorzaciones.Visible = False
            My.Forms.Mensage.mensaje.Text = "Autorizado"
            My.Forms.Mensage.ShowDialog()
        End If
        archivar_autorizaciones() 'Borra Autorizaciones ya pasadas
    End Sub

    Private Sub excedetxt_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excedetxt.VisibleChanged
        Me.boton_pago_credito.Enabled = Not excedetxt.Visible
    End Sub

    Private Sub guardar_imprimir()
      

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        '1-Gusradar facturas
        '2-guarda formas de pago
        '3-Guardar Detalle de formas de pago
        monitor_facturas = False : Dim j As Integer
        For j = 1 To tabledoc.Rows.Count
            '  Try comentado
            If dgvdoc.Rows(j - 1).Cells("total").Value > 0 Then
                monitor_guardar = False

                'manda a guardar la venta
                '====================================
                guardar_venta(j)

                If monitor_guardar = False Then
                    MsgBox("No se guardo la factura,reportar al administrador,Verificar Folios")
                    Exit Sub
                End If
                'Si es documento jalado y es de hoy lo cancela y borra los pagos
                If jalada_folio > 0 And tipo_venta <> 7 And tipo_venta <> 10 Then
                    marcar_documento(jalada_td, jalada_folio, jalada_serie)
                    'Borra Pagos
                    Try
                        Dim apd As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter
                        Dim dt As New DataTable
                        dt = apd.GetDataBydocumento(jalada_td, jalada_folio, jalada_serie)
                        If dt.Rows.Count = 0 Then MsgBox("Sin Pagos") : Exit Try
                        For jj As Integer = 0 To dt.Rows.Count - 1
                            With dt.Rows(jj)
                                apd.Delete(.Item(0), .Item(1), .Item(2), .Item(3), .Item(4), My.Settings.ncaja)
                            End With
                        Next jj
                    Catch ex As Exception

                    End Try
                    jalada_folio = 0 : jalada_td = 0 : jalada_serie = ""
                End If

            End If
            'Catch ex As Exception
            'bitacora("Error en rutina de envio a guardar venta " + ex.Message)
            '  MsgBox(ex.Message)
            '  End Try
        Next
        If como_pago <> 4 Then ' si no es a credito
            monitor_boletas = False
            define_formasdepago()
            If monitor_boletas = False Then
                MsgBox("No se guardo algun pago")
            End If
            guardar_detalle_pago()
        End If
        '****** FALTA Imprimir

        If tipo_venta <> 7 And Val(Me.cambiotxt.Text) < 0 Then
            My.Forms.Mensage.mensaje.Text = "Cambio " + Me.cambiotxt.Text
            My.Forms.Mensage.ShowDialog()
        End If
        inicializa_nota()
    End Sub '**************************************************** Guardar e Imprimir


    Private Sub define_formasdepago()
        Dim banco, cheque As String
        Dim im(0 To 6) As Double
        If pago_efectivotxt.Text = "" Then pago_efectivotxt.Text = "0"
        If pago_valestxt.Text = "" Then pago_valestxt.Text = "0"
        If pago_bancostxt.Text = "" Then pago_bancostxt.Text = "0"
        If pago_nctxt.Text = "" Then pago_nctxt.Text = "0"
        Dim pdolar As Double = 0
        Try
            pdolar = Val(Me.Dll.Text) * My.Settings.tipodecambio
        Catch ex As Exception
            pdolar = 0
        End Try

        If como_pago = 1 Then
            im(1) = CDbl(pago_efectivotxt.Text) + pdolar + CDbl(cambiotxt.Text) 'Efectivo
            im(2) = CDbl(pago_valestxt.Text) 'Vales
            im(3) = CDbl(pago_bancostxt.Text) 'Bancos
            im(6) = CDbl(pago_nctxt.Text) ' Notas de Credito
        ElseIf como_pago > 1 Then
            im(1) = CDbl(tarjeta_efectivo.Text) + pdolar + CDbl(cambiotxt.Text)  ' bancos
            im(2) = CDbl(tarjeta_vales.Text) ' vales
            im(6) = CDbl(pago_nctxt.Text) ' Notas de Credito
            If tarjetacredito = True Then
                im(4) = CDbl(Tarjeta_importe.Text)
            Else
                im(5) = CDbl(Tarjeta_importe.Text)
            End If
        End If
        Dim apago As New admintegralDataSetTableAdapters.PagosTableAdapter
        dgvpago.DataSource = tabla_pago
        tabla_pago.Clear()
        For j As Integer = 1 To 6
            banco = ""
            cheque = ""
            If im(j) <> 0 Then
                If j = 3 Then 'BANCO CHEQUE
                    banco = Me.Pago_bancotxt.Text
                    cheque = Me.Pago_ncheque.Text
                Else 'Si es tarjeta de Credito
                    If j = 4 Or j = 5 Then
                        banco = Me.pago_banco.Text
                        cheque = Me.Banco_tarjeta.Text
                    End If
                End If

                If j = 4 Then 'Nota de Credito
                    banco = "N.C."
                    cheque = Me.pago_num_notatxt.Text
                End If

                Try
                    Dim dr1 As DataRow = tabla_pago.NewRow
                    If j > 2 Then
                        Dim nidp As Integer = apago.nuevo_id(My.Settings.ncaja)
                        apago.Insert(nidp, info_caja, user.id, 0, 0, Now.Date, Me.idcliente.Text, 2, j, cheque, im(j), True, banco, Now.Date)
                        dr1(0) = nidp : dr1(1) = 1 : dr1(2) = im(j)
                        tabla_pago.Rows.Add(dr1)
                    Else
                        If j = 1 Then dr1(0) = id_contado : dr1(0) = id_contado : dr1(1) = 1 : dr1(2) = im(j) : tabla_pago.Rows.Add(dr1)
                        If j = 2 Then dr1(0) = id_vales : dr1(0) = id_vales : dr1(1) = 1 : dr1(2) = im(j) : tabla_pago.Rows.Add(dr1)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox("No se guardo " + j.ToString + Format(im(j).ToString))
                End Try
            End If
        Next j
        monitor_boletas = True
    End Sub '************************************************** Guarda Boletas de pago

    Private Sub guardar_detalle_pago()
        Dim p As pago_detalle
        Dim adap As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter

        'define se se dieron dolares y guara los dolares
        '==============================================================
        If Val(Me.Dll.Text) > 0 Then
            Dim pdolar As Decimal = 0
            Dim dolares As Double
            Try
                dolares = CDbl(Me.Dll.Text)
                pdolar = Val(Me.Dll.Text) * My.Settings.tipodecambio
            Catch ex As Exception
                pdolar = 0
            End Try
            Try
                p.id = tabla_pago.Rows(0).Item("id")
                p.td = tabledoc.Rows(0).Item("td")
                p.folio = tabledoc.Rows(0).Item("NF")
                p.serie = Me.SerieTextBox.Text
                Dim adapdll As New integraDataSetTableAdapters.dolaresTableAdapter
                adapdll.Insert(Id_cajaTextBox.Text, p.td, p.folio, p.serie, Now.Date.ToShortDateString, dolares, My.Settings.tipodecambio, pdolar, 0)
            Catch ex As Exception

            End Try

        End If


        '************************************  Si solo hay un pago y una factura
        '==================================================================================================
        If tabledoc.Rows.Count = 1 And tabla_pago.Rows.Count = 1 Then ' si solo hay un pago y una factura
            p.id = tabla_pago.Rows(0).Item("id")
            p.td = tabledoc.Rows(0).Item("td")
            p.folio = tabledoc.Rows(0).Item("NF")
            p.serie = Me.SerieTextBox.Text
            p.importe = Math.Round(tabla_pago.Rows(0).Item("importe"), 2)
            Try
                adap.Insert(p.id, p.td, p.folio, p.serie, p.importe, My.Settings.ncaja)
                adap.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Error al Guardar Detalle de pago")
            End Try
            Exit Sub
        End If
        '************************************  Si solo hay un pago y varias facturas
        '==================================================================================================
        If tabledoc.Rows.Count > 1 And tabla_pago.Rows.Count = 1 Then
            p.id = tabla_pago.Rows(0).Item("id")
            For j As Integer = 0 To Me.tabledoc.Rows.Count - 1
                Try
                    p.td = tabledoc.Rows(j).Item("td")
                    p.folio = tabledoc.Rows(j).Item("NF")
                    p.serie = Me.SerieTextBox.Text
                    p.importe = CDbl(Math.Round(tabledoc.Rows(j).Item("total"), 2))
                    Try
                        adap.Insert(p.id, p.td, p.folio, p.serie, p.importe, My.Settings.ncaja)
                    Catch ex As Exception
                        MsgBox("Error al Guardar Detalle de pago")
                    End Try
                Catch ex As Exception
                End Try
            Next
            adap.Dispose()
            Exit Sub
        End If
        '************************************  Si hay una factura y varios pagos
        '==================================================================================================
        If tabla_pago.Rows.Count > 1 And tabledoc.Rows.Count = 1 Then
            p.td = tabledoc.Rows(0).Item("td")
            p.folio = tabledoc.Rows(0).Item("NF")
            p.serie = Me.SerieTextBox.Text

            For j As Integer = 0 To Me.tabla_pago.Rows.Count - 1
                p.id = tabla_pago.Rows(j).Item("id")
                p.importe = Math.Round(tabla_pago.Rows(j).Item("importe"), 2)
                Try
                    adap.Insert(p.id, p.td, p.folio, p.serie, p.importe, My.Settings.ncaja)
                Catch ex As Exception
                    MsgBox("Error al Guardar Detalle de pago")
                End Try
            Next
            adap.Dispose()
            Exit Sub
        End If

        If tabla_pago.Rows.Count > 1 And tabledoc.Rows.Count > 1 Then
            Dim pa, d As Integer, ip As Double, di(0 To 10) As Double
            For d = 0 To tabledoc.Rows.Count - 1
                Try
                    di(d) = Math.Round(Me.tabledoc.Rows(d).Item("total"), 2)
                Catch ex As Exception

                End Try
            Next
            d = 0
            For pa = 0 To tabla_pago.Rows.Count - 1 'por cada pago
                ip = tabla_pago.Rows(pa).Item("importe")
                While ip > 0.001
                    p.id = tabla_pago.Rows(pa).Item("id")
                    p.td = tabledoc.Rows(d).Item("td")
                    p.folio = tabledoc.Rows(d).Item("NF")
                    p.serie = Me.SerieTextBox.Text
                    If ip > di(d) Then
                        p.importe = di(d)
                        ip = ip - di(d) : d = d + 1
                    Else
                        p.importe = ip
                        di(d) -= ip : ip = 0
                    End If
                    p.importe = Math.Round(p.importe, 2)
                    Try
                        adap.Insert(p.id, p.td, p.folio, p.serie, p.importe, My.Settings.ncaja)
                    Catch ex As Exception
                        MsgBox("Error al guardar uno de los pagos en multi pago/documento")
                    End Try
                End While
            Next
            adap.Dispose()
        End If
    End Sub '************************************************* Guardar Pagode Detalle

    Private Sub aplicar_NC(ByVal nc As Integer, ByVal id As Integer, ByVal importe As Single)
        Dim apago As New admintegralDataSetTableAdapters.PagosTableAdapter
        Dim dr1 As DataRow = tabla_pago.NewRow
        Dim nidp As Integer = apago.nuevo_id(My.Settings.ncaja) ' Obtienen el nuevo ID del pago
        Try
            apago.Insert(nidp, info_caja, user.id, nc, 99, Now.Date, id, 2, 6, nc, importe, True, "N. Credito", Now.Date)
            apago.Dispose()
        Catch ex As Exception
            bitacora("No se guardo N.Credito " + nc)
        End Try

        Dim adap1 As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter
        Try
            adap1.Insert(nidp, jalada_td, jalada_folio, jalada_serie, importe, My.Settings.ncaja)
            adap1.Dispose()
        Catch ex As Exception
            bitacora("Aplicando NC " + ex.Message)
        End Try
    End Sub

    Private Sub Boton_corte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_corte.Click, CerraCajaToolStripMenuItem.Click


        SerieTextBox.Text = "BB"
        validar_folios()


        Me.SeriesTableAdapter.FillByserie(Me.AdmintegralDataSet.Series, SerieTextBox.Text)
        Dim x As MsgBoxResult
        x = MsgBox("Seguro que Quiere Hacer Corte de Caja? (Se generara la factura de ventas al publico en general CFDI)" + SerieTextBox.Text, MsgBoxStyle.YesNo, "Corte de Caja")

        Try
            'cambia tipo 3 a tipo 0 
            Dim cmd1 As String = "UPDATE Documentos set id_cartera = 0 WHERE td = 5 AND status = 0 AND id_cartera = 3 AND ncaja = [ncaja]"
            cmd1 = cmd1.Replace("[ncaja]", info_caja.ToString)
            comando(cmd1)
        Catch ex As Exception

        End Try

        'validar_pagos()
        Me.ToolStripStatusLabel1.Text = "Pagos Validados"
        If x = MsgBoxResult.Yes Then
            'Imprimir resumen de operaciones
            resumen_entradas()

            'Borra Pagos de Facturas que se Cancelaron
            Try
                Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
                    conection.Open()
                    Dim cmd As String
                    Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                    Dim cs As String = My.Settings.AdmintegralConnectionString.ToString

                    cmd = "DELETE FROM pagos_detalle FROM Documentos INNER JOIN  pagos_detalle ON Documentos.Folio = pagos_detalle.folio AND Documentos.serie = pagos_detalle.serie AND Documentos.td = pagos_detalle.id_doc WHERE Documentos.status = 1"
                    Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                    AdaptadorDeDatos.DeleteCommand = Command
                    AdaptadorDeDatos.DeleteCommand.ExecuteNonQuery()
                End Using
            Catch ex As Exception

            End Try
            Dim drlog As DataRow
            drlog = Me.Log_cajasTableAdapter.GetDataBycaja_fecha(info_caja, CDate(Now.Date)).Rows(0)
            Try

                crear_factura_publico(Now.Date)

            Catch ex As Exception

            End Try


            If My.Settings.impresora_ticket = "ND" Then
                My.Forms.diario_ventas.cargar_reporte(info_serie, Now.Date, "Diario de Ventas", Now.Date)
                My.Forms.diario_ventas.ShowDialog()
            Else
                My.Forms.caja_corte.Show()
                Me.Close()
            End If
        End If
    End Sub ' ****** Corte de caja

    Private Sub validar_pagos()
        Dim cmd As String
        cmd = "Update [integra].[dbo].[pagos_detalle] SET [abono] = dbo.Documentos.Importe FROM dbo.pagos_detalle INNER JOIN " _
        & " dbo.Documentos ON dbo.pagos_detalle.id_doc = dbo.Documentos.td AND dbo.pagos_detalle.folio = dbo.Documentos.Folio AND " _
        & "dbo.pagos_detalle.serie = dbo.Documentos.serie And dbo.pagos_detalle.abono > dbo.Documentos.Importe"
        Actualiza_registros(cmd)

        cmd = "UPDATE [integra].[dbo].[pagos_detalle] SET [abono] = dbo.Documentos.Importe FROM dbo.pagos_detalle RIGHT OUTER JOIN " _
        & "dbo.Documentos ON dbo.pagos_detalle.id_doc = dbo.Documentos.td AND dbo.pagos_detalle.folio = dbo.Documentos.Folio AND " _
        & " dbo.pagos_detalle.serie = dbo.Documentos.serie " _
        & " WHERE (dbo.Documentos.Importe - dbo.pagos_detalle.abono > 0 And dbo.Documentos.Importe - dbo.pagos_detalle.abono < 1)"
        Actualiza_registros(cmd)

        cmd = "UPDATE [integra].[dbo].[pagos_detalle] SET [abono] = dbo.Documentos.Importe FROM dbo.pagos_detalle RIGHT OUTER JOIN " _
     & "dbo.Documentos ON dbo.pagos_detalle.id_doc = dbo.Documentos.td AND dbo.pagos_detalle.folio = dbo.Documentos.Folio AND " _
     & " dbo.pagos_detalle.serie = dbo.Documentos.serie " _
     & " WHERE (dbo.pagos_detalle.abono-dbo.Documentos.Importe  > 0 And  dbo.pagos_detalle.abono-dbo.Documentos.Importe  < 1)"
        Actualiza_registros(cmd)
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim a As String
        If dgv.CurrentCell.ColumnIndex = 11 Then
            Dim rw = Me.dgv.CurrentRow.Index
            If pedirprecio Then
                With dgv.CurrentRow
                    Dim msg As String = "Producto : " + .Cells("descripcion").Value + chr10 + chr13 + chr10
                    'msg += "Costo : " + Format(.Cells("ud_costo").Value, "N2") + chr10 + chr13
                    msg += "Venta : " + Format(.Cells("ud_pventa").Value, "N2") + chr10 + chr13
                    msg += chr10 + "Teclee el precio de venta."
                    Dim nprecio As Single, ok As Boolean = False
                    While ok = False
                        nprecio = Val(InputBox(msg, "Cambiar Precio", .Cells("ud_pventa").Value))
                        If nprecio < .Cells("ud_costo").Value Then
                            MsgBox("El precio de Venta debe de ser mayor al costo")
                        Else
                            ok = True
                        End If
                    End While
                    .Cells("ud_plventa").Value = nprecio
                    .Cells("ud_flista").Value = 1
                    .Cells("ud_pventa").Value = nprecio
                    mytable.AcceptChanges()
                    Exit Sub
                End With
            End If
            Exit Sub
        End If

        a = dgv.CurrentRow.Cells("codigo").Value.ToString
        If a.Length < 1 Then Exit Sub
        Dim x As MsgBoxResult
        x = MsgBox("Borrar este producto :" + a, MsgBoxStyle.YesNo, "Borrar ")
        If x = MsgBoxResult.Yes Then
            If Me.dgv.CurrentRow.Index >= 0 Then
                Try
                    bs.RemoveCurrent()
                    mytable.AcceptChanges()
                Catch ex As Exception

                End Try
                totalizar()
            End If
        End If
        linea.Focus()
    End Sub ' Borrar producto

    Private Sub carga_comision(ByVal tipo As Integer)
        borrar_comision()
        totalizar()
        Dim c As Double = 0
        Try
            c = mytable.Compute("sum(total)", "")
        Catch ex As Exception
        End Try
        c = c / (1 + factor_iva1_venta)
        Dim comision As Double
        If tipo = 1 Then comision = c * (cia.comidebito - 1) : lbltipotarjeta.Text = "Debito" : tarjetacredito = False 'opdebito.Checked = True
        If tipo = 2 Then comision = c * (cia.comicredito - 1) : lbltipotarjeta.Text = "Credito" : tarjetacredito = True 'opcredito.Checked = True
        '=============================================================================================
        Me.Lista_de_ventasBindingSource.Position = Me.Lista_de_ventasBindingSource.Find("codigo", "0000000000")
        Dim dr As DataRow = mytable.NewRow
        dr("id") = Me.Id_productoTextBox.Text
        dr("iva") = Me.IvaTextBox.Text
        dr("piva") = Me.IvaTextBox.Text
        dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
        dr("und") = Me.UnidadTextBox.Text
        dr("factor") = Me.FactorTextBox.Text
        dr("cantidad") = 1
        dr("ud_costo") = comision
        dr("ud_plventa") = comision
        dr("ud_flista") = 1 'factor precio lista
        dr("ud_pventa") = comision
        dr("pdesc") = 0
        dr("nf") = 1
        dr("peso") = Me.PesoTextBox.Text

        dr("ud_id") = Me.Id_unidadTextBox.Text
        dr("codigo") = "0000000000"

        dr.Item("pieps") = 0
        dr.Item("ieps") = 0
        dr.Item("ub_ieps") = 0

        dr.Item("ub_pventa") = 0
        dr.Item("ub_pdesc") = 0
        dr.Item("ub_iva10") = 0
        dr.Item("ub_iva15") = 0




        mytable.Rows.Add(dr)
        totalizar()
        '================================================================================================
        Try
            If Val(Me.totaltxt.Text) = 0 Then MsgBox("No ha nada para cobrar") : Exit Sub
        Catch ex As Exception

        End Try

        Me.TabControl1.SelectTab(2)
        Me.GroupEfectivo.Visible = False
        Me.Grouptarjeta.Visible = True
        Me.pago_banco.Text = ""
        Me.Banco_tarjeta.Text = ""
        Me.tarjeta_efectivo.Text = "0.00"
        Me.tarjeta_vales.Text = "0.00"
        Me.Tarjeta_importe.Text = totaltxt.Text

        Me.pago_banco.Focus()

        Me.cambiotxt.Text = "0.00"

        ' dividir_factura()
    End Sub '********************Carga comision

    'como_pago
    '1 efectivo
    '2 debito
    '3 credito
    '4 a credito  CXC


    Private Sub pagar_contado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_pago_contado.Click, boton_pago_contado.Click, Button1.Click
        borrar_comision()
        totalizar()
        Dim xd As Single
        Try
            If Val(Me.totaltxt.Text) = 0 Then MsgBox("No ha nada para cobrar") : Exit Sub
        Catch ex As Exception

        End Try

        como_pago = 1
        comisiontxt.Text = ""
        Me.TabControl1.SelectTab(2)
        Me.GroupEfectivo.Visible = True
        Me.Grouptarjeta.Visible = False

        Me.pago_banco.Text = ""
        Me.pago_efectivotxt.Text = "0.00"
        Me.cambiotxt.Text = "0.00"

        dividir_factura()

        If xd = 0 Then Me.pago_efectivotxt.Text = Me.totaltxt.Text Else If CDbl(Me.totaltxt.Text) - xd > 0 Then pago_efectivotxt.Text = CDbl(Me.totaltxt.Text) - xd

        calcular_cambio()


        Me.pago_efectivotxt.SelectAll()
        Me.pago_efectivotxt.Focus()
    End Sub

    Private Sub DebitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitoToolStripMenuItem.Click, mnu_Pago_debito.Click, Button2.Click
        como_pago = 2
        carga_comision(1)
    End Sub 'boton caragr comision debito

    Private Sub CreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditoToolStripMenuItem.Click, mnu_Pago_credito.Click, Button3.Click
        como_pago = 3
        carga_comision(2)
    End Sub 'boton caragr comision credito

    Private Sub boton_pago_credito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_pago_credito.Click
        como_pago = 4
       

        Dim frmalerta As New alerta_de_facturacion
        With frmalerta
            .RFC.Text = crfc.Text
            .NOMBRE.Text = cnombre.Text
            .EMAIL.Text = cemail.Text
            .METODO.Text = "PPD"
            .USO.Text = UsoTextBox.Text
            .FORMA.Text = FormaTextBox.Text
            .forma_descripcion.Text = formaComboBox.Text
        End With

        frmalerta.ShowDialog()

        If frmalerta.DialogResult = Windows.Forms.DialogResult.Cancel Then
            MsgBox("No se imprime") : Exit Sub
        Else
            With frmalerta
                crfc.Text = .RFC.Text()
                cnombre.Text = .NOMBRE.Text
                cemail.Text = .EMAIL.Text
                MetodoTextBox.Text = .METODO.Text
                UsoTextBox.Text = .USO.Text
                FormaTextBox.Text = .FORMA.Text
                formaComboBox.Text = .forma_descripcion.Text
            End With

        End If


        dividir_factura()

        guardar_imprimir()
    End Sub

    Private Sub inicializa_nota()
        'Borra Tabla e inicializs variables
        sihay = False
        mytable.Rows.Clear()
        mytable.Clear()
        tabledoc.Clear()
        Dim dr As DataRow = tabledoc.NewRow
        dr(0) = 1 : tabledoc.Rows.Add(dr)
        tabla_pago.Clear()
        Me.cambiotxt.Text = "0.0"
        Me.txtpagado.Text = "0.0"
        Me.pago_nctxt.Text = "0.0"
        Me.pago_num_notatxt.Text = ""
        negativo = False
        linea.BackColor = Color.LightSteelBlue
        Dll.Text = "0"


        If tipo_venta = 7 Then
            Me.ToolStrip2.Visible = True
            Me.ToolStripButton1.Owner = Me.ToolStrip2
            Me.boton_cliente.Owner = Me.ToolStrip2
            Me.Boton_imprimir.Owner = Me.ToolStrip2
            Me.boton_repetir.Owner = Me.ToolStrip2
            Me.ToolStrip1.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Dim a As New admintegralDataSetTableAdapters.foliosTableAdapter
            Dim f As Long = a.siguiente(7, "NC")
            a.Dispose()
            Me.folionc.Text = "Folio " + f.ToString
            Me.folionc.Visible = True
        End If

        Dim ix As MsgBoxResult = MsgBoxResult.No
        If id_cliente > 0 And tipo_venta = 6 Then ix = MsgBox("Mismo Cliente", MsgBoxStyle.YesNo, "")
        If ix = MsgBoxResult.No Then
            Me.idcliente.Text = "0"
            id_cliente = 0
            Me.cnombre.Text = "Publico en General"
        End If
        cargar_cliente()
        TabControl1.SelectedIndex = 1
        totalizar()

        '**************************************** NOTA DE CREDITO   *********************************
        If tipo_venta <> 7 Then
            Me.Pago_bancotxt.Text = ""
            Me.Pago_ncheque.Text = ""
            Me.pago_efectivotxt.Text = "0"
            Me.pago_bancostxt.Text = "0"
            Me.pago_valestxt.Text = "0"
            Boton_imprimir.Enabled = False

            If ix = MsgBoxResult.No Then
                If My.Settings.impresora_ticket = "ND" Then
                    credito = True : Me.lblcredito.Text = "Credito"
                    Me.boton_credito.Text = "Contado"
                    Me.boton_pago_contado.Enabled = False
                    Me.boton_pago_tarjeta.Enabled = False
                    Me.boton_pago_credito.Enabled = False
                    tipo_venta = 6 : Me.lbltipoventa.Text = "Factura"
                    Label19.Visible = True : facturastxt.Visible = True
                    Me.boton_factura.Text = "Ticket"
                    pedir_cliente()
                Else
                    credito = False : Me.lblcredito.Text = "Contado"
                    Me.boton_credito.Text = "Credito" : Me.mnu_pago_contado.Enabled = True : Me.tipo_venta = 5
                    Me.lbltipoventa.Text = "Ticket"
                    Me.boton_factura.Text = "Factura"
                    Me.boton_pago_contado.Enabled = True
                    Me.boton_pago_tarjeta.Enabled = True
                    Me.boton_pago_credito.Enabled = False
                End If
            End If
        Else
            cargar_factura()
            linea.Visible = False
            Exit Sub
        End If
        Try
            tmpfile = "c:\tmp\operacion_" + FolioTextBox.Text + RemisionTextBox.Text + ".tmp"
            status2.Text = tmpfile
            My.Settings.tmpfile = tmpfile
            My.Settings.Save()
        Catch ex As Exception
            tmpfile = "c:\tmp\op" + Now.TimeOfDay.ToString + ".tmp"
        End Try
        linea.Visible = True
        validar_folios()
        Me.linea.Focus()
    End Sub

    Private Sub boton_retirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_retirar.Click
        My.Forms.caja_retiro.Show()
        caja_retiro.WindowState = FormWindowState.Normal

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        'cerrar nota de credito
        Me.Close()
    End Sub

    Private Sub imprimir_ticket(ByVal folio As String, ByVal id As Integer)


        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Imprimir Nota ?"
        msgtitulo = "Imprimir Nota"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub




        If como_pago = 1 Then abrir_cajon()
        Dim filenota As String = path_tickets + "\ticket" + folio.ToString + ".txt"
        encabezado(filenota, "Tiket de Venta", ancho_ticket)
        Dim f As New System.IO.StreamWriter(filenota, True, System.Text.ASCIIEncoding.Unicode)
        If esterminal = True Then
            f.WriteLine(centrar(cia.direccion_sucursal, ancho_ticket))
        End If
        f.WriteLine(" ")
        f.WriteLine("Tienda :" + Me.sucursaltxt.Text.Trim)
        f.WriteLine("Cj.:" + info_caja.ToString + " - " + user.user)
        f.WriteLine("Nota :" + folio)
        f.WriteLine("Fecha: " + Format(Now.Date, "d") + " Hora : " + Format(Now, "t"))
        If Me.idcliente.Text <> 0 Then
            f.WriteLine(Me.idcliente.Text + "-" + Me.cnombre.Text)
        End If
        f.WriteLine("----------------------------------------")
        f.WriteLine("Cant.  Concepto       Unitario  Importe ")
        f.WriteLine("----------------------------------------")
        Dim r As DataRow
        Dim l As String
        For j As Integer = 0 To mytable.Rows.Count - 1

            r = mytable.Rows(j)
            If r.Item("NF") = id And r("ud_vneto") > 0 Then
                l = Format(r("cantidad"), "###").PadRight(4) + Mid(r("descripcion").ToString, 1, 19)
                Dim unitario As Single = r("ud_vneto") + r("ud_iva10")
                l += Format(unitario, " ###.##").PadLeft(7)
                l += Format(r("Total"), "N2").PadLeft(9)
                f.WriteLine(l)
            Else
                MsgBox("Costo Cero")
            End If

        Next j
        f.WriteLine(Mid("----------------------------------------", 1, ancho_ticket))
        Dim subt As Double = tabledoc.Rows(id - 1).Item("sub0") + tabledoc.Rows(id - 1).Item("sub10")
        Dim iva As Double = tabledoc.Rows(id - 1).Item("iva")
        Dim ieps As Double = tabledoc.Rows(id - 1).Item("ieps")
        Dim tt As Double = tabledoc.Rows(id - 1).Item("total")

        f.WriteLine("SUB   :".PadLeft(ancho_ticket - 16) + Format(subt, "N2").PadLeft(11))
        f.WriteLine("IVA :".PadLeft(ancho_ticket - 16) + Format(iva, "N2").PadLeft(11))
        f.WriteLine("IEPS :".PadLeft(ancho_ticket - 16) + Format(ieps, "N2").PadLeft(11))
        f.WriteLine("Total :".PadLeft(ancho_ticket - 16) + Format(tt, "N2").PadLeft(11))


        Dim t1, t2, t3, t4 As Double
        If como_pago = 1 Then 'Contado
            Try
                If Me.pago_efectivotxt.Text = "" Then t1 = 0 Else t1 = CDbl(Me.pago_efectivotxt.Text)
                If Me.pago_valestxt.Text = "" Then t2 = 0 Else t2 = CDbl(Me.pago_valestxt.Text)
                If Me.pago_bancostxt.Text = "" Then t3 = 0 Else t3 = CDbl(Me.pago_bancostxt.Text)
                If Me.pago_nctxt.Text = "" Then t4 = 0 Else t4 = CDbl(Me.pago_nctxt.Text)
                If t1 > 0 Then f.WriteLine("Efectivo :".PadLeft(ancho_ticket - 16) + Format(t1, "N2").PadLeft(11))
                If t2 > 0 Then f.WriteLine("Vales :".PadLeft(ancho_ticket - 16) + Format(t2, "N2").PadLeft(11))
                If t3 > 0 Then
                    f.WriteLine("Cheque :".PadLeft(ancho_ticket - 16) + Format(t3, "N2").PadLeft(11))
                    f.WriteLine("banco" + Me.Pago_bancotxt.Text)
                    f.WriteLine("Cheque NO: " + Me.Pago_ncheque.Text)
                End If
                If t4 > 0 Then
                    l = "N.C. " + Me.pago_num_notatxt.Text + " :"
                    f.WriteLine(l.PadLeft(ancho_ticket - 16) + Format(t4, "N2").PadLeft(11))
                End If


            Catch ex As Exception
            End Try
        Else
            If Me.Tarjeta_importe.Text = "" Then t1 = 0 Else t1 = CDbl(Me.Tarjeta_importe.Text)
            If Me.tarjeta_efectivo.Text = "" Then t2 = 0 Else t2 = CDbl(Me.tarjeta_efectivo.Text)
            If Me.tarjeta_vales.Text = "" Then t3 = 0 Else t3 = CDbl(Me.tarjeta_vales.Text)
            If t1 > 0 Then f.WriteLine("Tarjeta :".PadLeft(ancho_ticket - 16) + Format(t1, "N2").PadLeft(11))
            If t2 > 0 Then f.WriteLine("Efectivo :".PadLeft(ancho_ticket - 16) + Format(t2, "N2").PadLeft(11))
            If t3 > 0 Then f.WriteLine("Vales :".PadLeft(ancho_ticket - 16) + Format(t3, "N2").PadLeft(11))
            f.WriteLine(Me.pago_banco.Text)
            f.WriteLine("Tarjeta No.: " + Me.Banco_tarjeta.Text)
        End If



        f.WriteLine("Cambio :".PadLeft(ancho_ticket - 16) + Format(CDbl(cambiotxt.Text), "N2").PadLeft(11))

        f.WriteLine("")
        If My.Settings.separar = False Then Dim cant As Integer = mytable.Compute("sum(cantidad)", "") : f.WriteLine("Total de Articulos : " + cant.ToString)

        Dim ct As String
        ct = Mid(Format(tt - Fix(tt), ".00"), 2, 2)
        f.WriteLine("Son:(" + Num2Text(Fix(tt)) + " PESOS " + ct.ToString + "/100 M.N.)")
        f.WriteLine("")
        f.WriteLine("Una vez recibida NO SE ACEPTA CAMBIO O DEVOLUCIONES")
        f.WriteLine("")
        f.WriteLine(centrar("Gracias por su Compra", ancho_ticket))
        f.WriteLine(cia.aviso)
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, filenota)
        'If My.Computer.Name = "LAP" Then System.Diagnostics.Process.Start(filenota)
    End Sub '=================== IMPRIMIR TICKET ============================

    Private Sub imprimir_factura(ByVal folio As String, ByVal id As Integer, ByVal desglosar As Boolean)
        If como_pago = 1 Then abrir_cajon()
        Dim l As String, j As Integer, en As String
        Dim archivo As String = "c:\tmp\" + folio + ".txt", cc As String, nl As Integer = 0
        Dim f As New System.IO.StreamWriter(archivo, False, System.Text.ASCIIEncoding.Unicode)
        cc = Microsoft.VisualBasic.Chr(27) + Microsoft.VisualBasic.Chr(15)
        f.WriteLine(cc)
        f.Write(" ")
        For j = 0 To 6 : f.WriteLine("") : Next j : en = eñe(cnombre.Text)
        f.WriteLine("                " + en) 'Nombre
        f.WriteLine("                " + idcliente.Text.ToString + "  Agente: " + Me.cagente.Text.ToString + " " + Me.ccomercial.Text.ToString) ' Numero/agente/comercial
        f.WriteLine("                " + eñe(Me.cdireccion.Text).PadRight(84) + folio)
        l = Me.ccolonia.Text.Trim + "  " + eñe(Me.cciudad.Text).Trim + "  " + cedo.Text.Trim
        f.WriteLine("                " + l)
        l = Me.crfc.Text + "  CP: " + Me.ccp.Text
        f.WriteLine("                " + l.ToString.PadRight(84) + Format(Now.Date, "d"))
        f.WriteLine("Cancun, Q.Roo.".PadLeft(112))
        For j = 0 To 1 : f.WriteLine("") : Next j
        Dim r As DataRow
        Dim fcod, fdesc, funidad, fcant, funi, fimporte, fiva As String

        For j = 0 To mytable.Rows.Count - 1
            r = mytable.Rows(j)
            If r.Item("NF") = id Then
                fcod = r.Item("codigo").ToString.PadRight(20)
                fdesc = Mid(eñe(r.Item("descripcion")).ToString.PadRight(60), 1, 55)
                funidad = r.Item("und").ToString.PadRight(5)
                fcant = r.Item("Cantidad").ToString.PadLeft(10)
                If desglosar = False Then
                    Dim unitario As Single = r("ud_vneto") + r("ud_iva10")
                    funi = Format(unitario, "N2").PadLeft(18)
                    fimporte = Format(CDbl(r("Total")), "N2").PadLeft(18)
                Else
                    Dim unitario As Single = r("ud_vneto")
                    funi = Format(unitario, "N2").PadLeft(18)
                    fimporte = Format(CDbl(r("importe")), "N2").PadLeft(18)
                End If
                fiva = r.Item("piva").ToString
                l = fcod + fdesc + funidad + fcant + funi + fimporte + "  " + fiva
                f.WriteLine(l) : nl += 1
            End If
        Next j
        l = "---------------------------------------------------------------------------------------------------------------------------------------"
        f.WriteLine(l) : nl += 1

        Dim subt As Double = tabledoc.Rows(id - 1).Item("sub0") + tabledoc.Rows(id - 1).Item("sub10")
        Dim iva As Double = tabledoc.Rows(id - 1).Item("iva")
        Dim t1 As Double = tabledoc.Rows(id - 1).Item("total")

        If desglosar = False Then
            l = "*** I.V.A. INCLUIDO ***".PadRight(80) + " TOTAL ".PadLeft(30) + Format(t1, "N2").ToString.PadLeft(22)
            f.WriteLine(l) : nl += 1

        Else
            l = " Subtotal :".PadLeft(110) + Format(subt, "N2").PadLeft(17) : f.WriteLine(l) : nl += 1
            l = "I.V.A." + My.Settings.iva.ToString + "% :" : l = l.PadLeft(110) + Format(iva, "N2").PadLeft(17) : f.WriteLine(l) : nl += +1
            l = " TOTAL :".PadLeft(110) + Format(t1, "N2").PadLeft(17) : f.WriteLine(l) : nl += 1
        End If

        Dim ct As String, l1 As String
        ct = Mid(Format(CDbl(t1) - Fix(CDbl(t1)), ".##"), 2, 2)
        f.WriteLine("Son:(" + Num2Text(Fix(t1)) + " PESOS " + ct.ToString + "/100 M.N.)")

        For j = nl To 26 : f.WriteLine("") : Next (j)
        'Pie de Hoja
        If credito = True Then l1 = "Credito" Else l1 = "Contado"
        l = "Una vez recibida la Mercancia no se aceptan".PadRight(95) + l1 + " / " + user.user
        f.WriteLine(l) : nl += 1
        l = "Cambios o Devoluciones.  -  " '+ tmpfile
        l = l.PadRight(95) + "PAGO EN UNA SOLA EXHIBICION"
        f.WriteLine(l) : nl += 1
        If esterminal = True Then
            Dim l2 As String = "Expedido: " + Me.sucursaltxt.Text.Trim + " , " + cia.direccion_sucursal.Trim
            l = l2.PadRight(110)
        Else
            l = ".".PadRight(95)
        End If
        l += Format(Date.Now, "t").ToString : If credito Then l += " F.V. " + Format(Me.fvence.Value, "d")
        f.WriteLine(l) : nl += 1
        f.WriteLine("") : nl += 1
        'Pagare
        l = Format(Date.Now, "d").PadLeft(40) + Format(t1, "N2").PadLeft(60)
        f.WriteLine(l)
        f.WriteLine("") : f.WriteLine("")
        l = Format(Date.Now, "d").PadLeft(48) + Format(t1, "N2").PadLeft(50)
        f.WriteLine(l)
        f.WriteLine("Son:(" + Num2Text(Fix(t1)) + " PESOS " + ct.ToString + "/100 M.N.)")
        For j = 1 To 4 : f.WriteLine("") : Next j
        f.WriteLine("                    " + eñe(cnombre.Text))
        f.WriteLine("")
        f.WriteLine("                    " + eñe(cdireccion.Text))
        l = Me.ccolonia.Text.Trim + "  " + eñe(Me.cciudad.Text).Trim + "  " + cedo.Text.Trim
        f.WriteLine("                    " + l)
        'For j = 1 To 6 : f.WriteLine("") : Next j
        f.WriteLine(Microsoft.VisualBasic.Chr(12))
        '*********************   Enviar  *********************************
        f.Close()
        'Imprimir.SendStringToPrinter(My.Settings.impresora_factura, cc)
        Imprimir.SendFileToPrinter(My.Settings.impresora_factura, archivo)
        'Imprimir.SendStringToPrinter(My.Settings.impresora_factura, Microsoft.VisualBasic.Chr(12))
    End Sub '================== Imprimir FACTURA ============================

    Private Sub boton_UPD_folios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_UPD_folios.Click
        validar_folios()
    End Sub

    Private Sub validar_folios()
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tblfolio As New DataTable
        Dim cmd As String
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        'cmd = "SELECT * from fn_siguiente_folio where serie = '" + Me.SerieTextBox.Text + "'"
        cmd = "SELECT td, serie, MAX(Folio) + 1 AS Folio FROM dbo.Documentos GROUP BY td, serie HAVING  serie = '" + Me.SerieTextBox.Text + "'"

        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        AdaptadorDeDatos.SelectCommand.CommandTimeout = 3000
        'Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        AdaptadorDeDatos.Fill(tblfolio)
        If tblfolio.Rows.Count = 0 Then
            MsgBox("Primer documeto de la serie")
            Me.RemisionTextBox.Text = "1"
            Me.FolioTextBox.Text = "1"
        End If

        Dim r As DataRow
        For Each r In tblfolio.Rows
            If r("td") = 5 Then Me.RemisionTextBox.Text = r("folio").ToString
            If r("td") = 6 Then Me.FolioTextBox.Text = r("folio").ToString
        Next
        Me.SeriesBindingSource.EndEdit()
        Me.SeriesTableAdapter.Update(Me.AdmintegralDataSet.Series)

    End Sub

    Private Sub BuscarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProductoToolStripMenuItem.Click
        My.Forms.Buscar_productos.ShowDialog()
        Me.linea.Text += producto.a7codigo
        linea.Focus()
    End Sub

    Private Sub CargarUltimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarUltimaToolStripMenuItem.Click

        Dim archivo As New OpenFileDialog
        archivo.InitialDirectory = "c:\tmp\"
        archivo.Title = "Seleccione Un archvio"
        archivo.Filter = "TMP (*.TMP)|opera*.TMP"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            mytable.ReadXml(archivo.FileName)
            totalizar()
        End If
    End Sub

    Public Sub abrir_cajon()
        Dim f As New System.IO.StreamWriter("c:\tmp\cajon.txt", False)
        Dim cadena As String = Microsoft.VisualBasic.Chr(27) + Me.Abrir_cajonTextBox.Text
        f.WriteLine(cadena)
        f.Close()
        Try
            Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, "c:\tmp\cajon.txt")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        abrir_cajon()
    End Sub

    Private Sub Agregar_Un_producto_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar_Un_producto_menu.Click
        borrar_comision()
        totalizar()
        TabControl1.SelectedIndex = 1 : Boton_imprimir.Enabled = False
        linea.Focus()
    End Sub

    Private Sub Boton_imprimir_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_imprimir.EnabledChanged
        Me.ImprimirToolStripMenuItem.Enabled = Me.Boton_imprimir.Enabled
    End Sub

    Private Sub Boton_ver_Autorzaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_ver_Autorzaciones.Click
        verificar_autorizacion()
    End Sub

    Private Sub archivar_autorizaciones()
        Try
            Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
                conection.Open()
                Dim cmd As String
                Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                Dim cs As String = My.Settings.AdmintegralConnectionString.ToString

                cmd = "UPDATE [integra].[dbo].[autorizaciones] SET [archivada] = 1 WHERE [Status] > 0 and id_cliente = " + id_cliente.ToString
                Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.UpdateCommand = Command
                AdaptadorDeDatos.UpdateCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub totaltxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totaltxt.TextChanged
        Totalpagar.Text = totaltxt.Text
        mod_total.Text = totaltxt.Text
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_puerta.Click, Boton_salir.Click
        Dim x As MsgBoxResult
        x = MsgBox("Quiere Salir de la caja", MsgBoxStyle.YesNo, "Salir de Caja")
        If x = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        My.Forms.caja_Relacion_de_Chofer.s.Text = info_serie
        My.Forms.caja_Relacion_de_Chofer.ShowDialog()
    End Sub 'relacion de Chofer

    Private Sub cargar_factura()
        Pedir_folio.ShowDialog()
        If Pedir_folio.DialogResult = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            Dim td, folio As Integer, serie As String
            If Pedir_folio.factura.Checked = True Then td = 6 Else td = 5
            Try
                folio = IIf(Pedir_folio.folio.Text = "", 0, Pedir_folio.folio.Text)
            Catch ex As Exception
                Me.Close()
                Exit Sub
            End Try
            serie = Pedir_folio.serie.Text + " "

            repetir_documento(td, folio, Trim(serie), False) '<=======

            If tipo_venta = 7 Then
                Me.txtconcepto.Text = ""
                Me.txtrecibio.Text = ""
                dgv.Columns("Cantidad").ReadOnly = False
                Try
                    Dim cmd As String = "Select saldo from cxc_saldos_x_factura where td=" + td.ToString + " and folio=" + folio.ToString + " and serie = '" + serie.ToString + "'"
                    Dim tmptbl As DataTable = leer_tabla(cmd)
                    jalada_saldo = tmptbl.Rows(0).Item(0)
                Catch ex As Exception
                    jalada_saldo = -1
                End Try

                Dim info As String
                If td = 5 Then info = "Tiket " Else info = "Factura "
                info += jalada_serie.ToString + jalada_folio.ToString + " Saldo " + Format(jalada_saldo, "N2")
                Me.Text = "Nota de Credito de " + info
            End If

        End If
    End Sub

    Private Sub boton_NC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_NC.Click
        cargar_factura()
    End Sub

    Private Sub Pago_bancotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pago_bancotxt.TextChanged
        Dim x As Decimal
        x = CDbl(pago_bancostxt.Text)
        If x = 0 Then
            pago_bancostxt.Text = Me.cambiotxt.Text
        End If
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.Lista_de_ventasTableAdapter.Fill(Me.AdmintegralDataSet.Lista_de_ventas)
        Me.Lista_de_ventasBindingSource.Filter = ""
        caja_status.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub crear_factura_publico(ByVal fecha As Date)

        Dim afolio As New admintegralDataSetTableAdapters.fn_siguiente_folioTableAdapter
        Dim d As New Mi_Documento
        Dim r As DataRow
        'adaptador de pagos
        Dim adapa As New admintegralDataSetTableAdapters.PagosTableAdapter
        Dim adapago As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter

        Dim DA As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        Dim cmd As String, tbl As New DataTable



        validar_folios()
        SerieTextBox.Text = "BB"
        info_serie = Me.SerieTextBox.Text

        Me.SeriesTableAdapter.FillByserie(Me.AdmintegralDataSet.Series, SerieTextBox.Text)

        cmd = "SELECT min(folio) as inicial,max(folio) as final,  SUM(sub0) AS sub, SUM(sub10) AS sub10, SUM(sub15) AS sub15, SUM(iva10) AS iva10, SUM(iva15) AS iva15, SUM(descuento0) AS desc0, SUM(descunto10) AS desc10, SUM(descunto15) AS desc15, SUM(Importe) AS importe, sum(ieps) as ieps " _
        & " FROM Documentos WHERE    status = 0 AND td = 5 AND fechasurtido = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102) " _
        & " GROUP BY serie HAVING serie = 'AA'"
        DA = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(DA)
        DA.SelectCommand.CommandTimeout = 3000
        DA.Fill(tbl)

        Dim sql1 As String
        sql1 = "SELECT productos.id_Producto, productos.Descripcion, SUM(movimientos.ub_cantidad * tbl_Tipodoc.natgrupo) AS cantidad, movimientos.venta,  " _
            & " SUM(movimientos.ub_cantidad * tbl_Tipodoc.natgrupo * movimientos.venta) AS subtotal, " _
            & "SUM(ROUND(movimientos.ub_vta_iva10 * movimientos.ub_cantidad, 2)) AS iva, " _
            & " SUM(ROUND(movimientos.ub_ieps * movimientos.ub_cantidad, 2)) AS ieps, " _
            & " SUM(ROUND(movimientos.ub_cantidad * tbl_Tipodoc.natgrupo * movimientos.venta + movimientos.ub_vta_iva10 * movimientos.ub_cantidad + ROUND(movimientos.ub_ieps * movimientos.ub_cantidad,2), 2)) AS total ,  Unidades_productos.Unidad, " _
            & " productos.iva AS piva, productos.ieps AS pieps, Unidades_productos.Codigo " _
            & " FROM movimientos INNER JOIN productos ON movimientos.id_prodcuto = productos.id_Producto INNER JOIN tbl_Tipodoc ON movimientos.id_doc = tbl_Tipodoc.td INNER JOIN " _
            & " Unidades_productos ON movimientos.id_prodcuto = Unidades_productos.id_producto AND movimientos.ud = Unidades_productos.id_unidad " _
            & " INNER JOIN Documentos ON movimientos.id_doc = Documentos.td AND movimientos.folio_doc = Documentos.Folio AND movimientos.serie = Documentos.serie  " _
            & " WHERE (movimientos.status = 0) " _
            & " AND (movimientos.fecha = CONVERT(DATETIME, '[fecha] 00:00:00', 102)) " _
            & " GROUP BY tbl_Tipodoc.grupo, productos.Descripcion, movimientos.id_doc, movimientos.venta, productos.id_Producto,Unidades_productos.Unidad, " _
            & "productos.iva, productos.ieps,  Unidades_productos.Codigo" _
            & " HAVING      (tbl_Tipodoc.grupo = 'Ventas' OR tbl_Tipodoc.grupo =  'Compras') AND (movimientos.id_doc = 5)" _
            & "ORDER BY productos.id_Producto"

        sql1 = sql1.Replace("[fecha]", Format(fecha, "yyyy-MM-dd"))
        mytable.Clear()
        mytable = leer_tabla(sql1)


        If tbl.Rows.Count > 0 Then
            With tbl.Rows(0)
                d.a00_id_doc = 6
                d.a01_Folio = Me.FolioTextBox.Text
                d.a02_serie = info_serie
                d.a03_Almacen = AlmacenTextBox.Text 'dato de caja
                d.a04_id_directorio = 0
                d.a05_tipo_directorio = 2
                d.a06_fecha_registro = CDate(fecha)
                d.a07_Folio_pedido = 0 'todo: Pedir numero de pedido
                d.a08_factura = ""
                d.a09_fecha_factura = CDate(fecha)
                d.a10_fecha_surtido = CDate(fecha)
                d.a11_fecha_vence = CDate(fecha)
                d.a12_pdesc = 0
                d.a13_flete = 0
                d.a14_sub0 = .Item("sub")
                d.a15_sub10 = .Item("sub10")
                d.a16_sub15 = .Item("sub15")
                d.a17_iva10 = .Item("iva10")
                d.a18_iva15 = .Item("iva15")
                d.a19_desc0 = .Item("desc0")
                d.a20_desc10 = .Item("desc10")
                d.a21_desc15 = .Item("desc15")
                d.a22_importe = .Item("importe")
                d.a36_ieps = Math.Round(.Item("ieps"), 2) '<===IEPS

                d.a23_idcartera = 3 'factura del dia
                d.a24_status = 0
                d.a25_almaentrada = 0
                d.a26_diasc = 0
                d.a27_pviva = 11



                Dim result As Boolean = Agregar_documento(d) 'Funcion que guarda el documento en la tabla
                If result = False Then
                    MsgBox("No se guardo la Factura del Dia, " + d.a01_Folio)
                    Exit Sub
                End If

                'Dim j As Integer = 0
                'r = mytable.Rows(j)

                'Dim m As New mi_movimientos
                'm.a01_Almacen = d.a03_Almacen
                'm.a02_id_doc = d.a00_id_doc
                'm.a03_Folio = d.a01_Folio
                'm.a04_serie = d.a02_serie
                'm.a05_num = j
                'm.a06_fecha = d.a10_fecha_surtido
                'm.a07_idproducto = "0" 'r.Item("id")
                'm.a08_factor = 1 ' r.Item("factor")
                'm.a09_piva = 16 ' r.Item("piva")
                'm.a10_ud = "NA" 'r.Item("ud_id")
                'm.a11_cantidad = 1 'r.Item("cantidad")
                'm.a12_costo = 0 ' r.Item("ud_costo")
                'm.a13_Cdesc = 0
                'm.a14_cflete = 0
                'm.a15_civa10 = 0
                'm.a16_civa15 = 0
                'm.a17_cventa = 0 'r.Item("ud_vneto")
                'm.a18_cvdesc = 0 'r.Item("ud_vdesc")
                'm.a19_cviva10 = 0 'r.Item("ud_iva10")
                'm.a20_cviva15 = 0 ' r.Item("ud_iva15")
                'm.a21_ub_cant = 1 'r.Item("ub_cantidad")
                'm.a22_ub_costo = 0 ' r.Item("ub_costo")
                'm.a35_vta_ieps = 8 ' r.Item("ieps")

                'm.a23_ub_Cdesc = 0
                'm.a24_ub_cflete = 0
                'm.a25_ub_civa10 = 0
                'm.a26_ub_civa15 = 0
                'm.a37_ub_cieps = 0

                'm.a27_ub_cventa = r.Item("ub_pventa")
                'm.a28_ub_cvdesc = r.Item("ub_pdesc")
                'm.a29_ub_cviva10 = r.Item("ub_iva10")
                'm.a30_ub_cviva15 = r.Item("ub_iva15")
                'm.a36_ub_ieps = r.Item("ub_ieps")

                'If tipo_venta <> 7 Then m.a31_signo = -1 Else m.a31_signo = 1
                'Try

                '    Dim adapm As New admintegralDataSetTableAdapters.movimientosTableAdapter
                '    adapm.Insert(m.a01_Almacen, m.a02_id_doc, m.a03_Folio, m.a04_serie, m.a05_num, m.a06_fecha, m.a07_idproducto, m.a08_factor, m.a09_piva, m.a10_ud, m.a11_cantidad, m.a12_costo, m.a13_Cdesc, m.a14_cflete, m.a15_civa10, m.a16_civa15, m.a17_cventa, m.a18_cvdesc, m.a19_cviva10, m.a20_cviva15, m.a21_ub_cant, m.a22_ub_costo, m.a23_ub_Cdesc, m.a24_ub_cflete, m.a25_ub_civa10, m.a26_ub_civa15, m.a27_ub_cventa, m.a28_ub_cvdesc, m.a29_ub_cviva10, m.a30_ub_cviva15, 0, m.a31_signo, Now.Date, m.a33_pieps, m.a34_cos_ieps, m.a35_vta_ieps, m.a36_ub_ieps, m.a37_ub_cieps)
                '    adapm.Connection.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    MsgBox("Error al guardar movimiento")
                'End Try


                Try
                    'actualiza la tabla de comentarios
                    Dim adapcomentario As New admintegralDataSetTableAdapters.ComentariosTableAdapter
                    Dim comentario As String
                    Dim cjadap As New admintegralDataSetTableAdapters.cajasTableAdapter
                    Dim sucursal As String = "Caja : " + cjadap.GetDataBy(My.Settings.ncaja).Rows(0).Item("nombre") + " "
                    sucursal += cia.direccion_sucursal + "  "
                    sucursal += "Ventas del Dia " + Format(fecha, "d").ToString + " "
                    comentario = sucursal + lf + cr + "Tickets de Venta del " + .Item("inicial").ToString + " al " + .Item("final").ToString
                    adapcomentario.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, "", user.id.ToString + " " + user.nick, comentario)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With
            MsgBox("Factura Creada :" + d.a01_Folio.ToString + d.a02_serie)
            FolioTextBox.Text = d.a01_Folio + 1
            Me.SeriesBindingSource.EndEdit()
            Me.SeriesTableAdapter.Update(Me.AdmintegralDataSet.Series)



            'yo lo quite
            ''GENERA CFDI
            'My.Forms.cfdi_Acp.genera(d.a00_id_doc, d.a02_serie, d.a01_Folio, My.Settings.ncaja, "01", "", id_cliente, telefono.Text)

            'GENERA PAGO DE FACTURA
            Dim ncaja As Integer = Me.Id_cajaTextBox.Text
            Dim nidp As Integer = adapa.nuevo_id(ncaja)

            Try
                adapa.Insert(nidp, ncaja, 0, 0, 100, CDate(fecha), 0, 2, 1, "", 0, True, "De contado", fecha)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            adapago.Insert(nidp, d.a00_id_doc, d.a01_Folio, d.a02_serie, d.a22_importe, ncaja)

        Else
            MsgBox("No hay Tickets para Facturar")
            Exit Sub
        End If

        'genera factura de fin de dia. CFDI
        '  My.Forms.fei_generacfd.genera_GLOBAL(d.a00_id_doc, d.a02_serie, d.a01_Folio, My.Settings.ncaja)
        Dim adap As New admintegralDataSetTableAdapters.log_cajasTableAdapter
        adap.cierra_caja(fecha, user.id, True, d.a01_Folio, d.a02_serie, info_caja, fecha)
    End Sub

    Sub guardar_venta(ByVal indice As Integer)

        '====================================================================
        ' gaurdar ventas
        '====================================================================

        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim adap As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim result As Boolean
        Dim d As New Mi_Documento
        Dim r As DataRow, j As Integer

        Main.StatusStrip1.Items(2).Text = "Guardando Documentos"
        d.a00_id_doc = Me.tipo_venta 'Remis/fact/NC
        If tipo_venta <> 7 Then
            Try
                If Me.tipo_venta = 5 Then d.a01_Folio = RemisionTextBox.Text Else d.a01_Folio = FolioTextBox.Text
                d.a02_serie = SerieTextBox.Text
            Catch ex As Exception
                bitacora("error al asignar sig. folio " + ex.Message)
                MsgBox(ex.Message)
            End Try
        Else
            Dim f As Long
            Try
                f = afolio.siguiente(7, "NC")
            Catch ex As Exception
                f = 1
            End Try
            d.a01_Folio = f
            d.a02_serie = " "
        End If

        d.a03_Almacen = AlmacenTextBox.Text 'dato de caja
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
        d.a14_sub0 = Math.Round(tabledoc.Rows(indice - 1).Item("sub0"), 2)
        d.a15_sub10 = Math.Round(tabledoc.Rows(indice - 1).Item("sub10"), 2)
        d.a16_sub15 = 0 'No se usa
        d.a17_iva10 = Math.Round(tabledoc.Rows(indice - 1).Item("IVA"), 2)
        d.a19_desc0 = Math.Round(tabledoc.Rows(indice - 1).Item("desc0"), 2)
        d.a20_desc10 = Math.Round(tabledoc.Rows(indice - 1).Item("desc10"), 2)
        d.a21_desc15 = 0 ' no se usa se puede calcular de mytable dal15
        d.a22_importe = Math.Round(tabledoc.Rows(indice - 1).Item("total"), 2)

        d.a36_ieps = Math.Round(tabledoc.Rows(indice - 1).Item("ieps"), 2) '<===IEPS

        tabledoc.Rows(indice - 1).Item("NF") = d.a01_Folio
        tabledoc.Rows(indice - 1).Item("TD") = d.a00_id_doc
        If credito = True Then d.a23_idcartera = 2 Else d.a23_idcartera = 0 ' CxC o Contado
        If Me.tipo_venta = 5 And sihay = True And indice = 1 Then d.a23_idcartera = 3
        d.a24_status = 0
        d.a25_almaentrada = 0
        d.a26_diasc = IIf(Me.cdias.Text = "", 0, Me.cdias.Text)
        d.a27_pviva = My.Settings.iva
        d.a32_pesoengramos = tabledoc.Rows(indice - 1).Item("pesogramos")

        d.a37_metodo = MetodoTextBox.Text
        d.a38_forma = FormaTextBox.Text
        d.a39_uso = UsoTextBox.Text

        If tipo_venta = 7 Then
            d.a33_nc_td = jalada_td
            d.a34_nc_folio = jalada_folio
            d.a35_nc_serie = UCase(jalada_serie)
        End If

        result = Agregar_documento(d) 'Funcion que guarda el documento en la tabla

        If result = False Then
            MsgBox("No se guardo el documento, " + d.a01_Folio)
            bitacora("No se guardo el Documento : " + d.a01_Folio + d.a02_serie)
            Exit Sub
        End If

        For j = 0 To mytable.Rows.Count - 1
            r = mytable.Rows(j)
            If r.Item("NF") = indice And r.Item("cantidad") > 0 Then
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


                m.a33_pieps = r.Item("pieps")
                m.a34_cos_ieps = 0
                m.a35_vta_ieps = r.Item("ieps")
                m.a36_ub_ieps = r.Item("ub_ieps")
                m.a37_ub_cieps = 0

                m.a27_ub_cventa = r.Item("ub_pventa")
                m.a28_ub_cvdesc = r.Item("ub_pdesc")
                m.a29_ub_cviva10 = r.Item("ub_iva10")
                m.a30_ub_cviva15 = r.Item("ub_iva15")



                If tipo_venta <> 7 Then m.a31_signo = -1 Else m.a31_signo = 1
                Try
                    adap.Insert(m.a01_Almacen, m.a02_id_doc, m.a03_Folio, m.a04_serie, m.a05_num, m.a06_fecha, m.a07_idproducto, m.a08_factor, m.a09_piva, m.a10_ud, m.a11_cantidad, m.a12_costo, m.a13_Cdesc, m.a14_cflete, m.a15_civa10, m.a16_civa15, m.a17_cventa, m.a18_cvdesc, m.a19_cviva10, m.a20_cviva15, m.a21_ub_cant, m.a22_ub_costo, m.a23_ub_Cdesc, m.a24_ub_cflete, m.a25_ub_civa10, m.a26_ub_civa15, m.a27_ub_cventa, m.a28_ub_cvdesc, m.a29_ub_cviva10, m.a30_ub_cviva15, 0, m.a31_signo, Now.Date, m.a33_pieps, m.a34_cos_ieps, m.a35_vta_ieps, m.a36_ub_ieps, m.a37_ub_cieps)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox("Error al guardar movimiento")
                End Try
            End If
        Next
        adap.Connection.Close()
        Main.StatusStrip1.Items(2).Text = "Documento Guardado correcto"

        Dim kmetodo, kcuenta As String

        kmetodo = MetodoTextBox.Text

        ''=================================================
        ''    Mandar a generar CFDI
        '=================================================

        If tipo_venta = 6 Then My.Forms.cfdi_Acp.genera(d.a00_id_doc, d.a02_serie, d.a01_Folio, My.Settings.ncaja)

        If tipo_venta = 7 Then My.Forms.cfdi_Acp.genera_nc(d.a00_id_doc, d.a02_serie, d.a01_Folio, My.Settings.ncaja)


        Main.StatusStrip1.Items(2).Text = "Se genero CFD"

        If tipo_venta = 7 Then
            'actualiza la tabla de comentarios
            Dim adap3 As New admintegralDataSetTableAdapters.ComentariosTableAdapter
            adap3.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, "", txtrecibio.Text, txtconcepto.Text)
            adap3.Dispose()

            Dim ref As String
            If jalada_td = 5 Then
                ref = "Tiket :" + jalada_serie.ToString + jalada_folio.ToString
            Else
                ref = "Factura :" + jalada_serie.ToString + jalada_folio.ToString
            End If
            If d.a22_importe - jalada_saldo < 0.5 Then ref += " *"
            If d.a22_importe - jalada_saldo < 0.5 Then aplicar_NC(d.a01_Folio, d.a04_id_directorio, d.a22_importe)
            monitor_guardar = True : Exit Sub
        End If


        'Aumenta contador de folios
        Main.StatusStrip1.Items(2).Text = "Actualizando Folios"
        If tipo_venta = 5 Then
            Dim nnfolio As Long = d.a01_Folio
            imprimir_ticket(d.a01_Folio.ToString + d.a02_serie.ToString, indice)
            tabledoc.Rows(indice - 1).Item("NF") = nnfolio
            RemisionTextBox.Text = d.a01_Folio + 1
        ElseIf tipo_venta = 6 Then
            Dim ibien, ibienl As MsgBoxResult
            Dim nnfolio As Long = d.a01_Folio
            ibien = MsgBoxResult.No

            If como_pago = 1 Then abrir_cajon()

            tabledoc.Rows(indice - 1).Item("NF") = nnfolio
            FolioTextBox.Text = nnfolio + 1
        End If


        Try
            Me.SeriesBindingSource.EndEdit()
            Me.SeriesTableAdapter.Update(Me.AdmintegralDataSet.Series)
            monitor_guardar = True
            Main.StatusStrip1.Items(2).Text = "Folios Aplicados"
        Catch ex As Exception
            MsgBox(ex.Message)
            bitacora(ex.Message)
        End Try


    End Sub '**************************************************************** Guardar Ventas


    Private Sub Cargar_Pedido(ByVal archivo As String)
        Dim frefile As Integer, a As String, c1, c2 As String, ix, sn As Integer, s, sp(0 To 4) As String, agente As String, nomcli As String
        frefile = FreeFile() : FileOpen(frefile, archivo, OpenMode.Input)
        a = LineInput(frefile) : c1 = "" : c2 = ""
        If a <> "Pedido" Then
            FileClose(frefile)
            MsgBox("Este archivo no Es pedido")
        End If
        'lee cliente y lo carga
        agente = LineInput(frefile)
        nomcli = LineInput(frefile)
        a = LineInput(frefile)
        id_cliente = a
        idcliente.Text = a

        cargar_cliente()
        Dim msg As String = ""
        While a <> "Inicia"
            a = LineInput(frefile)
            If a <> "Inicia" Then msg += a
        End While
        MsgBox(msg)
        Do Until EOF(frefile)
            Try
                a = LineInput(frefile) : sn = 0
                Dim split As String() = a.Split(New [Char]() {","})
                For Each s In split
                    sp(sn) = s : sn += 1
                Next
                c1 = sp(0)
                c2 = sp(1)

                Dim filtro As String = "id_producto = " + c1.ToString + " and id_unidad = " + c2.ToString
                Me.Lista_de_ventasBindingSource.Filter = filtro

            Catch ex As Exception
                ix = -1
            End Try

            If Me.Lista_de_ventasBindingSource.Count > 0 Then

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
                dr("ud_pventa") = Int(dr("ud_plventa") * info_factor * 100) / 100
                dr("pdesc") = 0
                dr("nf") = 1
                dr("peso") = Me.PesoTextBox.Text
                dr("ud_id") = Me.Id_unidadTextBox.Text
                dr("codigo") = c1
                mytable.Rows.Add(dr)
                Me.linea.Text = "" : Me.linea.Focus()
            End If
        Loop
        '  fileName.Close()
        totalizar()
        FileClose(frefile)
        Me.Lista_de_ventasBindingSource.Filter = ""
    End Sub '****************************************************carga un archivo TMP



    Private Sub CargarPEDIDOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarPEDIDOToolStripMenuItem.Click
        Dim miadap As New admintegralDataSetTableAdapters.pathsTableAdapter

        'Dim cs As String = My.Settings.AdmintegralConnectionString
        'Dim tbl As New DataTable, 
        Dim path_home_pedidos As String
        'Dim sql As String = "SELECT path from paths where id=4" ' CARPETA DE RECPCION DE PEDIDOS
        'Dim AD As New Data.SqlClient.SqlDataAdapter
        'AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        'AD.Fill(tbl)
        path_home_pedidos = miadap.path(4).ToString.Trim

        Dim archivo As New OpenFileDialog
        archivo.InitialDirectory = path_home_pedidos
        archivo.Title = "Seleccione Un archvio"
        archivo.Filter = "ped (*.ped)|*.ped"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Cargar_Pedido(archivo.FileName)
            If dgv.RowCount > dgv.DisplayedRowCount(False) Then
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - dgv.DisplayedRowCount(False) - 1
            End If
            Windows.Forms.Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub ventanaweb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.Save()
    End Sub

    Private Sub FacturarCotizacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarCotizacionToolStripMenuItem.Click
        Try
            Dim cotiza As Integer = InputBox("Teclee el numero de cotizacion", "Facturar Cotizacion", "")
            If cotiza < 1 Then Exit Sub
            repetir_documento(10, cotiza, " ", False)
        Catch ex As Exception

        End Try
    End Sub 'Facturar Cotizacion

    Private Sub lbltipoventa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgv.Columns("N").Visible = True
        dgv.Columns("F").Visible = True
        dgv.Columns("NF").Visible = True
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        verificar_autorizacion()
    End Sub

    Private Sub pago_valestxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pago_valestxt.KeyPress, pago_num_notatxt.KeyPress, pago_nctxt.KeyPress, Pago_ncheque.KeyPress, Pago_bancotxt.KeyPress, pago_bancostxt.KeyPress, tarjeta_vales.KeyPress, Tarjeta_importe.KeyPress, tarjeta_efectivo.KeyPress, pago_banco.KeyPress, Banco_tarjeta.KeyPress
        If e.KeyChar = chr13 Then
            SendKeys.Send("{tab}")
        End If

    End Sub

    Private Sub Boton_avisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_avisar.Click
        Try
            If Val(idcliente.Text) < 1 Then Exit Sub
        Catch ex As Exception

        End Try
        Try
            Dim adap As New admintegralDataSetTableAdapters.autorizacionesTableAdapter
            adap.Insert(info_caja, Date.Now, user.id, Me.idcliente.Text, 0, 0, Date.Now, 0, "")
            adap.Dispose()
            Me.Boton_avisar.Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub boton_Entradas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Entradas.Click
        My.Forms.caja_entradas.Show()
    End Sub

    Private Sub lblexcede_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblexcede.Click
        Me.verificar_autorizacion()
    End Sub


    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub chequechk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chequechk.CheckedChanged
        Me.GroupBox2.Visible = chequechk.Checked
    End Sub

    Private Sub boton_Solicita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Solicita.Click

        Dim f As New System.IO.StreamWriter("c:\tmp\ticket.txt", False, System.Text.ASCIIEncoding.Unicode)
        f.WriteLine(" Solicitar Autorizacion ")
        f.WriteLine(" ")
        f.WriteLine(" ")
        f.WriteLine("Cj.:" + Trim(Me.sucursaltxt.Text) + " - " + Trim(user.nombre))
        f.WriteLine(" ") : f.WriteLine(" ")
        f.WriteLine("Tipo tarjeta :" + lbltipotarjeta.Text)
        f.WriteLine("Banco : " + pago_banco.Text)
        f.WriteLine("Ref: " + Banco_tarjeta.Text)
        f.WriteLine(" ")
        f.WriteLine("Importe : " + Tarjeta_importe.Text)
        f.WriteLine(" ")
        f.WriteLine(" ")
        f.WriteLine(" ")
        f.WriteLine(" ")
        f.WriteLine(" ")
        f.WriteLine(" ")
        f.WriteLine(" ")
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, "c:\tmp\ticket.txt")
    End Sub

    Private Sub DevolucionesEnVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionesEnVentaToolStripMenuItem.Click
        If negativo = False Then
            Dim x1 As usuario = autoriza_funcion(2)
            If x1.id = 0 Then Exit Sub
            negativo = True
            linea.BackColor = Color.Red
        Else
            linea.BackColor = Color.LightSteelBlue
            negativo = False
        End If
    End Sub

    Private Sub CambiarprecioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarprecioToolStripMenuItem.Click
        If pedirprecio = False Then
            Dim x1 As usuario = autoriza_funcion(3)
            If x1.id = 0 Then Exit Sub
            pedirprecio = True
        Else
            pedirprecio = False
        End If
        imgcambiarprecio.Visible = pedirprecio
    End Sub

    Private Sub boton_traspasos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_traspasos.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.traspasos.Show()
        My.Forms.traspasos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cargar_lista()
        Me.Lista_de_ventasTableAdapter.Fill(Me.AdmintegralDataSet.Lista_de_ventas)
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        dividir_factura()
        dgv.Columns("N").Visible = True
        dgv.Columns("NF").Visible = True
        dgv.Columns("f").Visible = True
    End Sub

    Private Sub boton_resumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_resumen.Click
        Dim tbl As DataTable, cmd As String
        Dim fecha As String = Format(Date.Now, "yyyy/MM/dd")
        cmd = "SELECT dbo.Documentos.id_cartera as ID, dbo.tbl_tipoventa.Descripcion, SUM(dbo.Documentos.Importe) AS Importe FROM dbo.Documentos INNER JOIN "
        cmd += "dbo.tbl_tipoventa ON dbo.Documentos.id_cartera = dbo.tbl_tipoventa.tipo_venta WHERE dbo.Documentos.status = 0 and (dbo.Documentos.td=5 or dbo.Documentos.td=6) "
        cmd += "GROUP BY dbo.Documentos.id_cartera, dbo.Documentos.serie, dbo.Documentos.fechafactura, dbo.tbl_tipoventa.Descripcion, dbo.Documentos.ncaja "
        cmd += "HAVING dbo.Documentos.fechafactura = CONVERT(DATETIME, '" + fecha + "', 102) AND Documentos.ncaja = " + My.Settings.ncaja.ToString
        cmd += " ORDER BY dbo.Documentos.id_cartera,Documentos.ncaja"
        tbl = leer_tabla(cmd)
        cmd = "Resumen de Operaciones :" + chr10 + chr13 + chr10 + chr13
        For j As Integer = 0 To tbl.Rows.Count - 1
            cmd += tbl.Rows(j).Item(1).ToString.Trim + ": " + Format(tbl.Rows(j).Item(2), "N2") + chr10 + chr13
        Next
        MsgBox(cmd)
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(tipo_venta)
    End Sub

    Private Sub ConvertirPiezasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertirPiezasToolStripMenuItem.Click
        Dim f As Integer = dgv.CurrentRow.Cells("factor").Value
        If f > 1 Then
            dgv.CurrentRow.Cells("und").Value = "Pz."
            Dim co As Decimal = dgv.CurrentRow.Cells("Ud_costo").Value / f : dgv.CurrentRow.Cells("Ud_costo").Value = co
            Dim pv As Decimal = dgv.CurrentRow.Cells("ud_pventa").Value / f : dgv.CurrentRow.Cells("ud_pventa").Value = pv
            dgv.CurrentRow.Cells("factor").Value = 1
        End If
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        For j As Integer = 0 To dgv.Columns.Count - 1
            dgv.Columns(j).Visible = True
        Next
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Dim archivo As New OpenFileDialog
        archivo.InitialDirectory = "c:\tmp"
        archivo.Title = "Seleccione Un archvio"
        archivo.Filter = "txt (*.Txt)|*.txt"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Imprimir.SendFileToPrinter(My.Settings.impresora_factura, archivo.FileName)
        End If
    End Sub

    Private Sub ToolStripButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Process.Start("c:\tmp\bajar_Actualizacion.exe")
    End Sub

    Private Sub boton_cancelar_solicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cancelar_solicitud.Click
        Dim cmd As String
        cmd = "delete  FROM autorizaciones WHERE archivada=0 and importe>0 and id_cliente = " + id_cliente.ToString
        Try
            comando(cmd)
        Catch ex As Exception

        End Try
        'My.Forms.Mensage.mensaje.Text = "No autorizado"
        'My.Forms.Mensage.ShowDialog()
        lblstatus.Visible = False
        Me.Boton_ver_Autorzaciones.Visible = False
        Timer1.Enabled = False
        totalizar()
        Me.boton_cancelar_solicitud.Visible = False
    End Sub

    Private Sub AbrirCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirCajaToolStripMenuItem.Click
        abrir_cajon()
    End Sub
    Private Sub resumen_entradas()
        Dim ne, nd As Integer, cmd As String
        ne = 0 : nd = 0
        Try
            cmd = "Select td,serie, folio,id_directorio as Id,Nombre,factura,fechafactura as fecha,importe,status from sql_documentos where td=12 and serie ='" + Me.SerieTextBox.Text
            cmd += "' and fechafactura ='" + Now.Date.ToShortDateString + "' "
            cmd += " order by folio desc "
            ne = leer_tabla(cmd).Rows.Count
        Catch ex As Exception

        End Try

        Try
            cmd = "Select td,serie, folio,id_directorio as Id,Nombre,factura,fechafactura as fecha,importe,status from sql_documentos where td=13 and serie ='" + Me.SerieTextBox.Text
            cmd += "' and fechafactura ='" + Now.Date.ToShortDateString + "' "
            cmd += " order by folio desc "
            nd = leer_tabla(cmd).Rows.Count
        Catch ex As Exception

        End Try

        Try

            Dim f As New System.IO.StreamWriter("c:\tmp\resumen_diario.txt", False, System.Text.ASCIIEncoding.Unicode)
            f.WriteLine(centrar(cia.nombre, ancho_ticket))
            f.WriteLine(" ")
            f.WriteLine(centrar("Resumen de Entradas", ancho_ticket))
            f.WriteLine(" ")
            f.WriteLine("Cj.:" + Trim(Me.sucursaltxt.Text) + " - " + Trim(user.nombre))
            f.WriteLine("Fecha: " + Format(Now.Date, "d") + " Hora : " + Format(Now, "t"))
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine("Total de Entradas     :" + ne.ToString)
            f.WriteLine("Total de Devoluciones :" + nd.ToString)
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine("Entrego : ________________________ ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine("Recibio : ________________________ ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine("------------------------------------------")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.WriteLine(" ")
            f.Close()
            Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, "c:\tmp\resumen_diario.txt")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResumenDeDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDeDocumentosToolStripMenuItem.Click
        resumen_entradas()
    End Sub



    Private Sub boton_reimprimir_ticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_reimprimir_ticket.Click
        Dim archivo As New OpenFileDialog
        archivo.InitialDirectory = "C:\Tmp\tickets"
        archivo.Title = "Seleccione Un archvio"
        archivo.Filter = "txt (*.Txt)|*.txt"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, archivo.FileName)
        End If
    End Sub

    Private Sub ToolStripButton9_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.ButtonClick
        Dim path As String = rcarpeta.Text + "operacion_"
        Dim folio As String = rfolio.Text
        Dim file As String = path + folio.ToString.Trim + ".tmp"
        'Dim archivo As New OpenFileDialog
        'archivo.InitialDirectory = rcarpeta.Text
        'archivo.Title = "Seleccione Un archvio"
        'archivo.Filter = "TMP (*.TMP)|opera*.TMP"

        Dim f As Decimal = folio + 1
        rfolio.Text = f.ToString
        mytable.ReadXml(file)
        totalizar()

    End Sub

    Private Sub VerificarPrecioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarPrecioToolStripMenuItem.Click
        verifica_precio()
    End Sub

    Private Sub TipoDeCambioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeCambioToolStripMenuItem.Click
        Dim x As Double
        x = InputBox("Teclee el tipo de cambio para los dolares", "Tipo de Cambio", My.Settings.tipodecambio.ToString)
        Try
            If x < 10 Then MsgBox("No puede ser menor de 10 pesos") : Exit Sub
        Catch ex As Exception
            x = 11.5
        End Try

        If x > 10 Then
            My.Settings.tipodecambio = x.ToString
            Me.lbldolares.Text = "Dolares (T.C.: " + My.Settings.tipodecambio.ToString + ")"
            Dim adap As New reporteDataSetTableAdapters.GeneralesTableAdapter
            adap.actualiza_tipo_de_cambio(x, 1)
        Else
            MsgBox("defina un tipo de cambio valido")
        End If

    End Sub

    Private Sub ActivadoModuloDeCFDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivadoModuloDeCFDToolStripMenuItem.Click
        My.Settings.FEI_activo = Not My.Settings.FEI_activo
        MsgBox("Modulo de Facturacio " + My.Settings.FEI_activo.ToString)
    End Sub

    Private Sub EliminarDocumentosToolSrgotripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarDocumentosToolStripMenuItem.Click
        Dim x1 As usuario = autoriza_funcion(3)
        If x1.id = 0 Then Exit Sub
        My.Forms.eliminar_documento.ShowDialog()
    End Sub

    Private Sub leyendatxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leyendatxt.TextChanged
        Try
            If Val(leyendatxt.Text) > 0 Then
                lblleyenda.Text = "Se motrara leyenda al " + leyendatxt.Text + "%"
            Else
                lblleyenda.Text = "Sin Leyenda"
            End If
        Catch ex As Exception
            lblleyenda.Text = "Sin Leyenda"
        End Try

    End Sub

    Private Sub Cargar_Paquete(ByVal Paquete As Integer, ByVal pkcant As Integer)

        Dim c1, c2 As String, ix, cant As Integer, unitario As Single
        Dim tblpkm As DataTable = leer_tabla("select * from paquetes where idpaquete=" + Paquete.ToString)
        Dim tblpk As DataTable = leer_tabla("select * from paquetes_detalle where idpaquete=" + Paquete.ToString)

        pcantidad.Text = pkcant
        pdescripcion.Text = tblpkm.Rows(0).Item("descripcion")
        psub.Text = tblpkm.Rows(0).Item("sub")
        piva.Text = tblpkm.Rows(0).Item("iva")
        pTOTAL.Text = tblpkm.Rows(0).Item("total")


        For j As Integer = 0 To tblpk.Rows.Count - 1
            c1 = tblpk.Rows(j).Item("codigo")
            c2 = 1
            cant = tblpk.Rows(j).Item("cantidad")
            unitario = tblpk.Rows(j).Item("precio")

            Try
                Dim filtro As String = "id_producto = " + c1.ToString + " and id_unidad = " + c2.ToString
                Me.Lista_de_ventasBindingSource.Filter = filtro
            Catch ex As Exception
                ix = -1
            End Try

            If Me.Lista_de_ventasBindingSource.Count > 0 Then

                Dim dr As DataRow = mytable.NewRow
                dr("id") = Me.Id_productoTextBox.Text
                dr("iva") = Me.IvaTextBox.Text
                dr("piva") = Me.IvaTextBox.Text
                dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                dr("und") = Me.UnidadTextBox.Text
                dr("factor") = Me.FactorTextBox.Text
                dr("cantidad") = cant * pkcant
                dr("ud_costo") = Me.CostoTextBox.Text
                dr("ud_plventa") = unitario
                dr("ud_flista") = 1
                dr("ud_pventa") = unitario
                dr("pdesc") = 0
                dr("nf") = 1
                dr("peso") = Me.PesoTextBox.Text
                dr("ud_id") = Me.Id_unidadTextBox.Text
                dr("codigo") = c1
                mytable.Rows.Add(dr)
            End If
        Next j
        '  fileName.Close()
        totalizar()
        Me.Lista_de_ventasBindingSource.Filter = ""
        Me.linea.Text = "" : Me.linea.Focus()
        facturar_paquete = False
        Dim ix1 As MsgBoxResult = MsgBox("Facturar por concepto?", MsgBoxStyle.YesNo, "")
        If ix1 = MsgBoxResult.Yes Then
            facturar_paquete = True
            panel_paquete.Visible = True
        End If



    End Sub '****************************************************carga un archivo TMP

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub ActivarDesactivarFacturacionFDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivarDesactivarFacturacionFDiaToolStripMenuItem.Click
        Me.ActivadoModuloDeCFDToolStripMenuItem.Checked = Not My.Settings.separar
        My.Settings.separar = Not My.Settings.separar
        If My.Settings.separar = True Then
            lblsepara.Text = "Especial"
        Else
            lblsepara.Text = "Normal"
        End If
    End Sub


    Private Sub PrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim normal As New Font("Arial", 14, FontStyle.Regular) 'define el tipo de letra
        Dim bfont As New Font("Arial", 14, FontStyle.Bold) 'define tipo mas grande
        Dim bold As New Font("Arial", 18, FontStyle.Bold) 'define el tipo de letra
        Dim bold1 As New Font("Arial", 24, FontStyle.Bold) 'define el tipo de letra
        Dim tfont As New Object, j As Integer, llinea As Integer
        Dim srcRect As New Rectangle(1, 1, 160, 186)
        Dim units As GraphicsUnit = GraphicsUnit.Pixel
        tfont = Brushes.Black 'define el color
        llinea = 0
        Dim d1, d2, d3, d4 As String
        d1 = "" : d2 = "" : d3 = ""

        If mdescripcion.Length > 45 Then
            d1 = mdescripcion.Substring(0, 15)
            d2 = mdescripcion.Substring(10, 15)
            d3 = mdescripcion.Substring(30, 15)
            d4 = mdescripcion.Substring(45, mdescripcion.Length - 45)
            e.Graphics.DrawString(d1, bold, tfont, 1, llinea)
            llinea += 30 : e.Graphics.DrawString(d2, bold, tfont, 1, llinea)
            llinea += 30 : e.Graphics.DrawString(d3, bold, tfont, 1, llinea)
            llinea += 30 : e.Graphics.DrawString(d4, bold, tfont, 1, llinea)
        Else
            If mdescripcion.Length > 30 Then
                d1 = mdescripcion.Substring(0, 15)
                d2 = mdescripcion.Substring(15, 15)
                d3 = mdescripcion.Substring(30, mdescripcion.Length - 31)
                e.Graphics.DrawString(d1, bold, tfont, 1, llinea)
                llinea += 30 : e.Graphics.DrawString(d2, bold, tfont, 1, llinea)
                llinea += 30 : e.Graphics.DrawString(d3, bold, tfont, 1, llinea)
            Else
                If mdescripcion.Length > 15 Then
                    d1 = mdescripcion.Substring(0, 15)
                    d2 = mdescripcion.Substring(15, mdescripcion.Length - 15)
                    e.Graphics.DrawString(d1, bold, tfont, 1, llinea)
                    llinea += 30 : e.Graphics.DrawString(d2, bold, tfont, 1, llinea)
                Else
                    e.Graphics.DrawString(mdescripcion, bold, tfont, 1, llinea)
                End If
            End If
        End If
        llinea += 50 : e.Graphics.DrawString(munidad, normal, tfont, 1, llinea)
        Dim mc As Integer = 300
        mprecio = "$ " + mprecio
        mc = 300 - (mprecio.Length * 26)
        e.Graphics.DrawString(mprecio, bold1, tfont, mc, llinea)
        llinea += 40 : e.Graphics.DrawString(linea.Text, bfont, tfont, 1, llinea)
        llinea += 80 : e.Graphics.DrawString(" ", bfont, tfont, 1, llinea)
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        Dim id As String
        Dim miid As String
        miid = InputBox("Telcee el codigo del producto", "Imprimir Precio")
        'linea de captura
        Dim cant, x, y, p As Integer, filtro As String : Dim checa As String = ""
        linea.Text = "V" + miid
        If Mid(linea.Text, 1, 1) = "V" Then checa = "V" : linea.Text = linea.Text.Substring(1)
        x = InStr(linea.Text, ".")
        y = InStr(linea.Text, "*") 'caja
        p = InStr(UCase(linea.Text), "P")
        If p > 0 Then
            cant = Val(linea.Text.Substring(0, p - 1))
            id = Mid(linea.Text, p + 1)
            If cant = 0 Then cant = 1
            Cargar_Paquete(id, cant)
            Exit Sub
        End If
        If x > 1 Then
            cant = Val(linea.Text.Substring(0, x - 1))
            id = Mid(linea.Text, x + 1)
            canttxt.Text = cant
            idtxt.Text = id
        Else
            If y > 1 Then
                cant = Val(linea.Text.Substring(0, y - 1))
                id = Mid(linea.Text, y + 1)
                canttxt.Text = cant
                idtxt.Text = id
            Else
                cant = 1
                idtxt.Text = linea.Text
            End If
        End If
        If negativo Then cant = cant * -1

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
            Else
                'si no pidio por caja verifica que no sea unidad de detalle
                If AlmacenTextBox.Text = 0 Then
                    Try
                        Dim miadap As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
                        Dim rw1 As DataRow = miadap.GetDataunidad(idtxt.Text).Rows(0)
                        miadap.Dispose()
                        Dim miadap1 As New admintegralDataSetTableAdapters.productosTableAdapter
                        Dim rw2 As DataRow = miadap1.GetDataById(Id_productoTextBox.Text).Rows(0)
                        If rw1.Item("id_unidad") = rw2.Item("und_detalle") And rw2.Item("und_detalle") <> rw2.Item("und_venta") Then
                            MsgBox("No se puede vender a detalle")
                            linea.Text = ""
                            Exit Sub
                        End If
                    Catch ex As Exception

                    End Try

                End If
            End If

            If checa = "V" Then
                Dim ixi As MsgBoxResult
                Try
                    checa = "Producto :" + Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "") + chr10 + chr13
                    checa += "Und :" + Me.UnidadTextBox.Text + chr10 + chr13
                    Dim pu As Single
                    If Me.Precio_unicoCheckBox.Checked = False Then
                        pu = Int(Me.VentaTextBox.Text * info_factor * 100) / 100
                    Else
                        pu = Int(Me.VentaTextBox.Text * 100) / 100
                    End If
                    checa += "                    Precio : " + Format(pu, "N2")
                    ixi = MsgBox(checa, MsgBoxStyle.YesNo, "IMPRIMIR")
                    If ixi = MsgBoxResult.Yes Then
                        Dim filenota As String = path_tickets + "\precio.txt"
                        Dim f As New System.IO.StreamWriter(filenota, False)
                        Dim l1, l2, l3 As String
                        mdescripcion = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                        munidad = Me.UnidadTextBox.Text
                        If Me.Precio_unicoCheckBox.Checked = False Then
                            pu = Int(Me.VentaTextBox.Text * info_factor * 100) / 100
                        Else
                            pu = Int(Me.VentaTextBox.Text * 100) / 100
                        End If
                        Dim mipiva = Me.IvaTextBox.Text
                        If mipiva > 0 Then
                            pu = pu * (1 + (mipiva / 100))
                        End If
                        mprecio = Format(pu, "N2")
                        Try
                            Me.PrintDocument.PrinterSettings.PrinterName = My.Settings.impresora_ticket
                            Me.PrintDocument.Print()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                        Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, filenota)
                    End If
                    Exit Sub
                Catch ex As Exception
                    Exit Sub
                End Try
            End If
        End If

        bs.Filter = ""
        Me.Lista_de_ventasBindingSource.Filter = ""

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub FacturarCostoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarCostoToolStripMenuItem.Click
        Try
            Dim cotiza As Integer = InputBox("Teclee el numero de cotizacion", "Facturar Cotizacion a Costo", "")
            If cotiza < 1 Then Exit Sub
            cotizar_costo(10, cotiza, " ", False, True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cotizar_costo(ByVal td As Integer, ByVal folio As Integer, ByVal serie As String, ByVal borrar As Boolean, ByVal civa As Boolean)
        'Rutina para facturar a cozto

        Dim adoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim lista As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        Dim status As Integer, fecha As Date, id As Integer, idud, cantidad As Integer, pl As Double
        Dim docum As DataRow, tablamov As New DataTable
        info_factor = 1
        jalada_td = td
        jalada_folio = folio
        jalada_serie = UCase(serie)
        Try
            docum = adoc.GetDataByKey(td, folio, serie).Rows(0)
        Catch ex As Exception
            MsgBox("No se encuantra ese documento")
            Exit Sub
        End Try
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        status = docum("status")
        fecha = docum("fechafactura")

        If docum("id_cartera") = 2 Then credito = True Else credito = False
        id_cliente = docum("id_directorio") : idcliente.Text = id_cliente
        cargar_cliente()
        'Defini menus y labels segun tipo de venta
        If tipo_venta <> 7 Then
            tipo_venta = td
            If tipo_venta = 6 Then
                Me.lbltipoventa.Text = "Factura"
                Label19.Visible = True
                facturastxt.Visible = True
                Me.boton_factura.Text = "Ticket"
            Else
                Me.tipo_venta = 5 : Me.lbltipoventa.Text = "Ticket"
                Me.boton_factura.Text = "Factura"
                Label19.Visible = False
                facturastxt.Visible = False
            End If
        End If

        tablamov = amov.GetDataByKey(td, folio, serie)
        For j As Integer = 0 To tablamov.Rows.Count - 1

            id = tablamov.Rows(j).Item("id_prodcuto")
            idud = tablamov.Rows(j).Item("ud")
            cantidad = tablamov.Rows(j).Item("cantidad")

            '   pl = tablamov.Rows(j).Item("venta")

            Dim filtro As String = "id_producto = " + id.ToString + " and id_unidad = " + idud.ToString
            Me.Lista_de_ventasBindingSource.Filter = filtro
            ' Me.Lista_de_ventasBindingSource.Position = Me.Lista_de_ventasBindingSource.Find("codigo", codigo)
            If Me.Lista_de_ventasBindingSource.Position < 0 Then
            Else
                If (civa = True And Me.IvaTextBox.Text > 0) Or (civa = False And Me.IvaTextBox.Text = 0) Then
                    Dim dr As DataRow = mytable.NewRow
                    dr("id") = Me.Id_productoTextBox.Text
                    dr("iva") = Me.IvaTextBox.Text
                    dr("piva") = tablamov.Rows(j).Item("piva")
                    dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                    dr("und") = Me.UnidadTextBox.Text
                    dr("factor") = tablamov.Rows(j).Item("factor")
                    If tipo_venta <> 7 Then dr("cantidad") = cantidad Else dr("cantidad") = 0
                    dr("ud_costo") = Me.CostoTextBox.Text
                    pl = Math.Round(Val(Me.CostoTextBox.Text), 2)
                    dr("ud_plventa") = pl / info_factor
                    dr("ud_flista") = info_factor 'info_factor 'factor precio lista
                    dr("ud_pventa") = pl
                    dr("pdesc") = 0
                    dr("nf") = 1
                    dr("peso") = Me.PesoTextBox.Text
                    dr("ud_id") = Me.Id_unidadTextBox.Text
                    dr("codigo") = Me.CodigoTextBox.Text
                    mytable.Rows.Add(dr)
                    Me.linea.Text = "" : Me.linea.Focus()
                End If
            End If
        Next

        jalada_td = 0
        jalada_folio = 0
        jalada_serie = ""

        If fecha <> Now.Date And tipo_venta <> 7 Then
            MsgBox("No es de Hoy")
            jalada_td = 0
            jalada_folio = 0
            jalada_serie = 0
        End If
        Me.Lista_de_ventasBindingSource.Filter = ""

        If tipo_venta <> 7 Then

            If credito = False Then
                credito = False : Me.lblcredito.Text = "Contado"
                Me.boton_credito.Text = "Credito"
                Me.mnu_pago_contado.Enabled = True
                Me.boton_pago_contado.Enabled = True
                Me.boton_pago_tarjeta.Enabled = True
                Me.boton_pago_credito.Enabled = False
                Me.excedetxt.Visible = False
                Me.lblexcede.Visible = False
                Me.boton_autorizar.Visible = False
                Me.Boton_imprimir.Enabled = False
                Boton_avisar.Visible = False
            Else
                credito = True : Me.lblcredito.Text = "Credito"
                Boton_avisar.Visible = True
                Me.boton_credito.Text = "Contado"
                Me.boton_pago_contado.Enabled = False
                Me.boton_pago_tarjeta.Enabled = False
                Me.boton_pago_credito.Enabled = True
                tipo_venta = 6 : Me.lbltipoventa.Text = "Factura"
                Label19.Visible = True : facturastxt.Visible = True
                Me.boton_factura.Text = "Ticket"
            End If

            totalizar()
            dividir_factura()
        End If
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub 'Carga a memoria documento y lo cancela o Borra

    Private Sub FacturaCostoSIVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaCostoSIVAToolStripMenuItem.Click
        Try
            Dim cotiza As Integer = InputBox("Teclee el numero de cotizacion", "Facturar Cotizacion a Costo", "")
            If cotiza < 1 Then Exit Sub
            cotizar_costo(10, cotiza, " ", False, False)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub MetodoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles formaComboBox.SelectedIndexChanged
        FormaTextBox.Text = formaComboBox.SelectedValue
    End Sub

    Private Sub TimbrarPublicoEnGeneraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TimbrarPublicoEnGeneraToolStripMenuItem.Click
        My.Forms.factura_global.Show()
    End Sub

    Private Sub GenerarDocumentoDeCiereToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarDocumentoDeCiereToolStripMenuItem.Click
        Dim f As String
        f = InputBox("Teclee la fecha", "", "")
        If Not IsDate(f) Then Exit Sub
        crear_factura_publico(CDate(f))
    End Sub


    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles mod_linea.TextChanged
        linea.Text = mod_linea.Text
    End Sub


    Private Sub mod_descripcion_Validated(sender As System.Object, e As System.EventArgs) Handles mod_descripcion.Validated
        Dim adap As New admintegralDataSetTableAdapters.productosTableAdapter
        adap.actualiza_descripcion(mod_descripcion.Text, mod_total.Text, mod_id.Text)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        mod_descripcion.Enabled = True
    End Sub

    Private Sub BTN_NUEVO_CLIENTE_Click(sender As System.Object, e As System.EventArgs) Handles BTN_NUEVO_CLIENTE.Click
        Dim FRM As New nuevo_cliente
        FRM.ShowDialog()
        Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)
    End Sub

    Private Sub DescripcionComboBox_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles DescripcionComboBox.SelectedValueChanged
        mod_linea.Text = DescripcionComboBox.SelectedValue
        mod_descripcion.Text = DescripcionComboBox.Text
        Try
            bs.RemoveCurrent()
        Catch ex As Exception

        End Try
        agrega_servicio()
    End Sub

    Private Sub agrega_servicio()
        'agregar producto a la grid
        Dim id As String
        If linea.TextAlign < 1 Then Exit Sub

        'linea de captura
        Dim cant, x, y, p As Integer, filtro As String : Dim checa As String = ""
      
            If Mid(linea.Text, 1, 1) = "V" Then checa = "V" : linea.Text = linea.Text.Substring(1)
            x = InStr(linea.Text, ".")
            y = InStr(linea.Text, "*") 'caja
            p = InStr(UCase(linea.Text), "P")
            If p > 0 Then
                cant = Val(linea.Text.Substring(0, p - 1))
                id = Mid(linea.Text, p + 1)
                If cant = 0 Then cant = 1
                Cargar_Paquete(id, cant)
                Exit Sub
            End If
            If x > 1 Then
                cant = Val(linea.Text.Substring(0, x - 1))
                id = Mid(linea.Text, x + 1)
                canttxt.Text = cant
                idtxt.Text = id
            Else
                If y > 1 Then
                    cant = Val(linea.Text.Substring(0, y - 1))
                    id = Mid(linea.Text, y + 1)
                    canttxt.Text = cant
                    idtxt.Text = id
                Else
                    cant = 1
                    idtxt.Text = linea.Text
                End If
            End If
            If negativo Then cant = cant * -1

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
                Else
                    'si no pidio por caja verifica que no sea unidad de detalle
                    If AlmacenTextBox.Text = 0 Then
                        Try
                            Dim miadap As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
                            Dim rw1 As DataRow = miadap.GetDataunidad(idtxt.Text).Rows(0)
                            miadap.Dispose()
                            Dim miadap1 As New admintegralDataSetTableAdapters.productosTableAdapter
                            Dim rw2 As DataRow = miadap1.GetDataById(Id_productoTextBox.Text).Rows(0)
                            If rw1.Item("id_unidad") = rw2.Item("und_detalle") And rw2.Item("und_detalle") <> rw2.Item("und_venta") Then
                                MsgBox("No se puede vender a detalle")
                                linea.Text = ""
                                Exit Sub
                            End If
                        Catch ex As Exception

                        End Try

                    End If
                End If

                If checa = "V" Then
                    Dim ixi As MsgBoxResult
                    Try
                        checa = "Producto :" + Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "") + chr10 + chr13
                        checa += "Und :" + Me.UnidadTextBox.Text + chr10 + chr13
                        Dim pu As Single
                        If Me.Precio_unicoCheckBox.Checked = False Then
                            pu = Int(Me.VentaTextBox.Text * info_factor * 100) / 100
                        Else
                            pu = Int(Me.VentaTextBox.Text * 100) / 100
                        End If
                        checa += "                    Precio : " + Format(pu, "N2")
                        ixi = MsgBox(checa, MsgBoxStyle.YesNo, "IMPRIMIR")
                        If ixi = MsgBoxResult.Yes Then

                            Dim l1, l2, l3 As String
                            mdescripcion = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                            munidad = Me.UnidadTextBox.Text
                            If Me.Precio_unicoCheckBox.Checked = False Then
                                pu = Int(Me.VentaTextBox.Text * info_factor * 100) / 100
                            Else
                                pu = Int(Me.VentaTextBox.Text * 100) / 100
                            End If
                            mprecio = Format(pu, "N2")

                            Try
                                Me.PrintDocument.PrinterSettings.PrinterName = My.Settings.impresora_ticket
                                Me.PrintDocument.Print()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try

                            ' Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, filenota)
                        End If
                        Exit Sub
                    Catch ex As Exception
                        Exit Sub
                    End Try
                End If
                ' verifica si ya existe en la factura

                Dim alta As Boolean = False
                Dim ix1 As Integer
                For ix1 = 0 To mytable.Rows.Count - 1
                    Try
                        With mytable.Rows(ix1)
                            If .Item("id") = Me.Id_productoTextBox.Text And .Item("ud_id") = Me.Id_unidadTextBox.Text Then
                                cant += .Item("cantidad")
                                .Item("cantidad") = cant
                                linea.Text = ""
                                alta = True
                            End If
                        End With
                        mytable.AcceptChanges()
                    Catch ex As Exception

                    End Try
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
                    dr("pieps") = Me.IepsTextBox.Text '<======IEPS

                    dr("ud_plventa") = Me.VentaTextBox.Text

                    If Me.Precio_unicoCheckBox.Checked = False Then dr("ud_flista") = info_factor Else dr("ud_flista") = 1 'factor precio lista
                    dr("ud_pventa") = Math.Round(dr("ud_plventa") * dr("ud_flista"), 2)


                    If pedirprecio Then
                        Dim msg As String = "Producto : " + dr("descripcion") + chr10 + chr13 + chr10
                        'msg += "Costo : " + Format(dr("ud_costo"), "N2") + chr10 + chr13
                        msg += "Venta : " + Format(dr("ud_pventa"), "N2") + chr10 + chr13
                        msg += chr10 + "Teclee el precio de venta."
                        Dim nprecio As Single, ok As Boolean = False
                        While ok = False
                            nprecio = Val(InputBox(msg, "Cambiar Precio", ""))
                            If nprecio < dr("ud_costo") Then
                                MsgBox("El precio de Venta debe de ser mayor al costo")
                            Else
                                ok = True
                            End If
                        End While
                        dr("ud_plventa") = nprecio
                        dr("ud_flista") = 1
                        dr("ud_pventa") = nprecio
                    End If

                    If FACT_OXXO = True Then

                        dr("ud_plventa") = poxxo(Id_productoTextBox.Text)
                        dr("ud_flista") = 1
                        dr("ud_pventa") = dr("ud_plventa")

                        If dr("ud_plventa") = 0 Then
                            MsgBox("No es productos Oxxo")
                            Exit Sub
                        End If
                    End If

                    dr("pdesc") = 0
                    dr("nf") = 1
                    dr("peso") = Me.PesoTextBox.Text
                    dr("ud_id") = Me.Id_unidadTextBox.Text
                    dr("codigo") = idtxt.Text
                    dr("separar") = IIf(Me.SepararCheckBox.Checked = True, 1, 0)
                    mytable.Rows.Add(dr)
                End If
                totalizar()
                If negativo Then
                    For j As Integer = 0 To dgv.Rows.Count - 1
                        If dgv.Rows(j).Cells("cantidad").Value < 0 Then
                            dgv.Rows(j).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next

                End If
                Me.lineastxt.Text = dgv.Rows.Count - 1
                If dgv.RowCount > dgv.DisplayedRowCount(False) Then
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - dgv.DisplayedRowCount(False) - 1
                End If
                Me.linea.Text = "" : Me.linea.Focus()
                Try
                    'Dim fileName As New System.IO.StreamWriter(tmpfile, True, System.Text.ASCIIEncoding.Unicode)
                    'fileName.WriteLine(idtxt.Text + "," + Me.Id_unidadTextBox.Text + "," + cant.ToString)
                    'fileName.Close()
                    mytable.WriteXml(tmpfile)
                Catch ex As Exception

                End Try

            End If
            bs.Filter = ""
            Me.Lista_de_ventasBindingSource.Filter = ""
    End Sub
End Class