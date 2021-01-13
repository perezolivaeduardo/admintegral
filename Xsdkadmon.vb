Module Xsdkadmon
    Public user As New usuario
    Public esterminal As Boolean = False
    Public login As Boolean
    Public gprov As tipo_provedor
    Public producto As entrada_producto
    Public id_cliente As Integer
    Public cia As generales
    Public catbs As New BindingSource
    Public ncotiza As Integer
    Public chr13 As String = Microsoft.VisualBasic.Chr(13)
    Public chr10 As String = Microsoft.VisualBasic.Chr(10)
    Public chr14 As String = Microsoft.VisualBasic.Chr(14)
    Public chr15 As String = Microsoft.VisualBasic.Chr(15)
    Public chr27 As String = Microsoft.VisualBasic.Chr(27)
    Public tabla_catalogo As New DataTable() 'tabla del detalle de pedido
    Public sql_servidor, sql_catalogo As String
    Public espacios As String = "                                                               "
    Public selectable As New DataTable
    Public selectarray As New ArrayList
    Public productos(0 To 0) As entrada_producto
    Public rptlogo As Microsoft.Reporting.WinForms.ReportParameter
    Public smtp As New cartero
    Public filesepara As String
    Public OXXO_id As Integer = 4012
    Public mi_compu As String = "MATRIX"
   
  

    Structure cartero
        Dim servidor As String
        Dim user As String
        Dim pw As String
        Dim email As String
        Dim puerto As String
    End Structure

    Function buzon() As cartero
        
        buzon.servidor = "casabaroudi.com"
        buzon.user = "cfd@casabaroudi.com"
        buzon.pw = "cfdbara"
        buzon.puerto = 26
        buzon.email = "cfd@casabaroudi.com"

    End Function


    Structure MIproducto
        Dim depto As Integer
        Dim grupo As Integer
        Dim marca As String
        Dim id_directorio As Integer
        Dim descripcion As String
        Dim PESO As String
        Dim margen As String
        Dim iva As String
        Dim comisionable As Boolean
        Dim comision As String
        Dim fechas As Date
        Dim idusuario As Integer
        Dim status
        Dim caducidad As Boolean
        Dim tipo As Integer
        Dim precio_unico As Boolean
        Dim pieps As Single
    End Structure

    Structure usuario
        Dim id As Integer
        Dim nick As String
        Dim nombre As String
        Dim Esmaster As Boolean
        Dim user As String
    End Structure

    Structure Und
        Dim a1_id As Integer
        Dim a2_unidad As String
        Dim a3_factor As Double
        Dim a4_costo As Double
        Dim a5_ventas As Double
        Dim a6_ub_unidad As String
        Dim a7_ub_costo As Double
        Dim a8_ub_ventas As Double
        Dim a9_uc_id As Integer
    End Structure

    Structure generales
        Dim nombre As String
        Dim direccion As String
        Dim ciudad As String
        Dim Edo As String
        Dim CP As String
        Dim rfc As String
        Dim comidebito As Single
        Dim comicredito As Single
        Dim tienda As Integer
        Dim sucursal As String
        Dim aviso As String
        Dim dias_posfechado As Integer
        Dim direccion_sucursal As String
    End Structure

    Structure tipo_provedor
        Dim id As Long
        Dim nombre As String
        Dim dias As Integer
        Dim iva As Integer
        Dim comentarios As String
    End Structure

    Structure entrada_producto
        Dim a1id As Long
        Dim a2descripcion As String
        Dim a3factor As Double
        Dim a4uc As String
        Dim a5ub As String
        Dim a6iva As Int16
        Dim a7codigo As String
        Dim a8costo As Decimal
        Dim a9idprov As Integer
        Dim a9caducidad As Boolean
        Dim ieps As Single
    End Structure

    Structure Mimovimiento
        Dim a01_id_doc As Integer
        Dim a02_Folio As Double
        Dim a03_serie As String
        Dim a04_Almacen As Integer
        Dim a05_numero As Integer
        Dim a06_fecha As Date
        Dim a07_id_producto As Long
        Dim a08_factor As Double
        Dim a09_iva As Integer
        Dim a10_ud As Integer
        Dim a11_signo As Integer
    End Structure

    Structure Mi_Documento
        Dim a00_id_doc As Integer
        Dim a01_Folio As Double
        Dim a02_serie As String
        Dim a03_Almacen As Integer
        Dim a04_id_directorio As Integer
        Dim a05_tipo_directorio As Integer
        Dim a06_fecha_registro As String
        Dim a07_Folio_pedido As Long
        Dim a08_factura As String
        Dim a09_fecha_factura As String
        Dim a10_fecha_surtido As String
        Dim a11_fecha_vence As String
        Dim a12_pdesc As Single
        Dim a13_flete As Double
        Dim a14_sub0 As Double
        Dim a15_sub10 As Double
        Dim a16_sub15 As Double
        Dim a17_iva10 As Double
        Dim a18_iva15 As Double
        Dim a19_desc0 As Double
        Dim a20_desc10 As Double
        Dim a21_desc15 As Double
        Dim a22_importe As Double
        Dim a23_idcartera As Integer
        Dim a24_status As Integer
        Dim a25_almaentrada As Integer
        Dim a26_diasc As Integer
        Dim a27_pviva As Integer
        Dim a31_abonado As Decimal
        Dim a32_pesoengramos As Long
        Dim a33_nc_td As Integer
        Dim a34_nc_folio As Integer
        Dim a35_nc_serie As String
        Dim a36_ieps As Decimal
        Dim a37_metodo As String
        Dim a38_forma As String
        Dim a39_uso As String
    End Structure

    Structure mi_movimientos
        Dim a01_Almacen As Integer
        Dim a02_id_doc As Integer
        Dim a03_Folio As Double
        Dim a04_serie As String
        Dim a05_num As Single
        Dim a06_fecha As Date
        Dim a07_idproducto As Long
        Dim a08_factor As Decimal
        Dim a09_piva As Int16
        Dim a10_ud As String
        Dim a11_cantidad As Decimal
        Dim a12_costo As Decimal
        Dim a13_Cdesc As Decimal
        Dim a14_cflete As Decimal
        Dim a15_civa10 As Decimal
        Dim a16_civa15 As Decimal
        Dim a17_cventa As Decimal
        Dim a18_cvdesc As Decimal
        Dim a19_cviva10 As Decimal
        Dim a20_cviva15 As Decimal
        Dim a21_ub_cant As Decimal
        Dim a22_ub_costo As Decimal
        Dim a23_ub_Cdesc As Decimal
        Dim a24_ub_cflete As Decimal
        Dim a25_ub_civa10 As Decimal
        Dim a26_ub_civa15 As Decimal
        Dim a27_ub_cventa As Decimal
        Dim a28_ub_cvdesc As Decimal
        Dim a29_ub_cviva10 As Decimal
        Dim a30_ub_cviva15 As Decimal
        Dim a31_signo As Integer
        Dim a32_caducidad As Date
        Dim a33_pieps As Decimal
        Dim a34_cos_ieps As Decimal
        Dim a35_vta_ieps As Decimal
        Dim a36_ub_ieps As Decimal
        Dim a37_ub_cieps As Decimal
    End Structure

    Structure pago_detalle
        Dim id As Long
        Dim td As Int16
        Dim folio As Long
        Dim serie As String
        Dim importe As Decimal
    End Structure

    Function identificacion(ByVal usuario As String, ByVal pw As String, ByVal modulo As Integer) As Boolean  '0=no admitido
        Dim tblusuarios As New admintegralDataSetTableAdapters.usuariosTableAdapter
        user.id = 0
        Try
            user.id = tblusuarios.lee_id(usuario, pw)
            user.user = usuario
            user.nick = tblusuarios.GetDataByid(user.id).Rows(0).Item("nick")
            user.nombre = tblusuarios.GetDataByid(user.id).Rows(0).Item("Nombre")
            user.Esmaster = tblusuarios.GetDataByid(user.id).Rows(0).Item("master")
            identificacion = True

        Catch ex As Exception
            identificacion = False
        End Try
    End Function

    Function autoriza_funcion(ByVal fn As Integer) As usuario
        Dim usr As New usuario, pw As String
        usr.id = 0
        'My.Forms.Autorizacion.ShowDialog()
        My.Forms.frm_pidepw.ShowDialog()
        If frm_pidepw.DialogResult = DialogResult.Cancel Then
            autoriza_funcion = usr
            Exit Function
        End If

        Dim tblusuarios As New admintegralDataSetTableAdapters.usuariosTableAdapter
        'nm = My.Forms.frm_pidepw.usuariotxt.Text
        pw = My.Forms.frm_pidepw.pwtxt.Text

        Try
            usr.id = tblusuarios.leer_id_desde_pw(pw)
            usr.nombre = tblusuarios.GetDataByid(usr.id).Rows(0).Item("Nombre")
        Catch ex As Exception
            autoriza_funcion = usr
            Exit Function
        End Try

        Dim permisos As New admintegralDataSetTableAdapters.tbl_permisosTableAdapter
        Try
            If permisos.permiso(usr.id, fn) = 1 Then
                autoriza_funcion = usr
                Exit Function
            Else
                '   usr.id = 0
                '  autoriza_funcion = usr : Exit Function
            End If
        Catch ex As Exception
            ' usr.id = 0
            ' autoriza_funcion = usr : Exit Function
        End Try
        If usr.id > 0 Then
            Dim msg As String = "Solicite el codigo de autorizacion "
            Dim aut As String = InputBox(msg, "", "")
            If aut <> clavedinamica() Then
                MsgBox("Codigo de autorizacion Invalido")
                usr.id = 0
            End If
        Else
        End If
        autoriza_funcion = usr
    End Function

    Public Function sk_leer_UndCompra(ByVal id As Long) As Und
        Dim u As New Und, rw As DataRow
        Dim adam As admintegralDataSetTableAdapters.sql_factoresTableAdapter
        adam = New admintegralDataSetTableAdapters.sql_factoresTableAdapter

        If adam.GetDataByid(id).Rows.Count > 0 Then
            rw = adam.GetDataByid(id).Rows(0)
            u.a1_id = rw.Item("id_producto")
            u.a2_unidad = rw.Item("uc")
            u.a3_factor = rw.Item("factoruc")
            u.a4_costo = rw.Item("costouc")
            u.a5_ventas = rw.Item("ventauc")
            u.a6_ub_unidad = rw.Item("ub")
            u.a7_ub_costo = rw.Item("costoub")
            u.a8_ub_ventas = rw.Item("ventaub")
            u.a9_uc_id = rw.Item("iduc")
        Else
            u.a1_id = -1
        End If
        sk_leer_UndCompra = u
        adam.Dispose()
    End Function ' Lee los datos de la unidad de compra segun ID

    Public Function leer_id(ByVal codigo As String) As Long
        Dim adap As admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        adap = New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Try
            leer_id = adap.leer_id(codigo)
        Catch ex As Exception
            leer_id = -1
        End Try
    End Function 'recupera un ID en BASE AL CODIGO DE BARRA

    Public Function leer_cod_prov(ByVal codigo As String, ByVal id_prov As Integer) As Long
        Dim adap As New admintegralDataSetTableAdapters.productosTableAdapter
        Try
            leer_cod_prov = adap.GetDataBycod_prov(codigo, id_prov).Rows(0).Item(0) ' lee el id del producto
        Catch ex As Exception
            leer_cod_prov = -1
        End Try
    End Function ' lee el id de un producto en base al codigo del proveedor

    Public Function preparar_filtro(ByVal campo As String, ByVal valor As String) As String
        Dim y1, y2 As Integer, f1, f2, f3 As String
        valor = valor.TrimEnd(" ")
        y1 = InStr(valor, " ") : f1 = "" : f2 = "" : f3 = ""
        If y1 > 0 Then
            f1 = Mid(valor, 1, y1 - 1) : f2 = Mid(valor, y1 + 1)
            preparar_filtro = campo + " like '%" + f1 + "%' and " + campo + " like '%" + f2 + "%'"
            y2 = InStr(f2, " ")
            If y2 > 0 Then
                valor = f2
                f2 = Mid(valor, 1, y2 - 1) : f3 = Mid(valor, y2 + 1)
                preparar_filtro = campo + " like '%" + f1 + "%' and " + campo + " like '%" + f2 + "%'  and " + campo + " like '%" + f3 + "%'"
            End If
        Else
            preparar_filtro = campo + " like '%" + valor + "%' "
        End If
    End Function

    Public Function preparar_buscar(ByVal campo As String, ByVal valor As String) As String
        preparar_buscar = campo + " = " + valor
    End Function

    Public Function pedir_proveedor() As DialogResult
        pedir_proveedor = My.Forms.buscar_provedor.ShowDialog()
    End Function

    Public Function Agregar_documento(ByVal d As Mi_Documento) As Boolean
        Try
            Dim ieps As Decimal
            ieps = 0
            Dim adap As New admintegralDataSetTableAdapters.DocumentosTableAdapter
            adap.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, d.a03_Almacen, d.a04_id_directorio, d.a05_tipo_directorio, CDate(d.a06_fecha_registro), d.a07_Folio_pedido, d.a08_factura, CDate(d.a09_fecha_factura), CDate(d.a10_fecha_surtido), CDate(d.a11_fecha_vence), d.a12_pdesc, d.a13_flete, d.a14_sub0, d.a15_sub10, d.a16_sub15, d.a17_iva10, d.a18_iva15, d.a19_desc0, d.a20_desc10, d.a21_desc15, d.a22_importe, d.a23_idcartera, d.a24_status, d.a25_almaentrada, d.a26_diasc, d.a27_pviva, My.Settings.ncaja.ToString, user.id, 0, d.a31_abonado, d.a32_pesoengramos, d.a33_nc_td, d.a34_nc_folio, d.a35_nc_serie, 0, d.a36_ieps, d.a37_metodo, d.a38_forma, d.a39_uso)
            Agregar_documento = True
            adap.Connection.Close()
        Catch ex As Exception
            If d.a00_id_doc <> 11 Then
                MsgBox(ex.Message)
            End If
            Agregar_documento = False
        End Try
    End Function

    Public Function agregar_movimiento(ByVal d As mi_movimientos) As Boolean
        Try
            If Not IsDate(d.a32_caducidad) Then
                d.a32_caducidad = Now.Date
            End If
        Catch ex As Exception
            d.a32_caducidad = Now.Date
        End Try

        Try
            Dim adap As New admintegralDataSetTableAdapters.movimientosTableAdapter
            adap.Insert(d.a01_Almacen, d.a02_id_doc, d.a03_Folio, d.a04_serie, d.a05_num, d.a06_fecha.Date, d.a07_idproducto, d.a08_factor, d.a09_piva, d.a10_ud, d.a11_cantidad, d.a12_costo, d.a13_Cdesc, d.a14_cflete, d.a15_civa10, d.a16_civa15, d.a17_cventa, d.a18_cvdesc, d.a19_cviva10, d.a20_cviva15, d.a21_ub_cant, d.a22_ub_costo, d.a23_ub_Cdesc, d.a24_ub_cflete, d.a25_ub_civa10, d.a26_ub_civa15, d.a27_ub_cventa, d.a28_ub_cvdesc, d.a29_ub_cviva10, d.a30_ub_cviva15, 0, d.a31_signo, d.a32_caducidad, d.a33_pieps, d.a34_cos_ieps, d.a35_vta_ieps, d.a36_ub_ieps, d.a37_ub_cieps)
            agregar_movimiento = True
            adap.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message + chr13 + " Row" + d.a05_num.ToString)
            bitacora("Agergar_movimiento : " + ex.Message)
            agregar_movimiento = False
        End Try
    End Function

    Public Function leer_provedor(ByVal id As Integer) As Boolean
        Try
            Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
            Dim tabla As New DataTable() 'tabla del detalle de pedido
            Dim cmd, cs As String
            cs = My.Settings.AdmintegralConnectionString.ToString
            cmd = "SELECT id_directorio, Nombre,dias FROM Directorio  WHERE tipo = 1 and id_Directorio = " + id.ToString
            AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
            Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
            AdaptadorDeDatos.Fill(tabla)
            gprov.nombre = tabla.Rows(0).Item("Nombre")
            leer_provedor = True
        Catch ex As Exception
            leer_provedor = False
        End Try
    End Function

    Public Sub extraer_definicion(ByVal tabla As DataTable, ByVal file As String)
        Dim j As Integer, nombre, expresion As String
        Dim fileName As New System.IO.StreamWriter(file, False)
        fileName.WriteLine("Definicion de Tabla")
        fileName.WriteLine("")
        With tabla
            For j = 0 To .Columns.Count - 1
                nombre = .Columns(j).ColumnName
                expresion = .Columns(j).Expression
                fileName.WriteLine(nombre + "|" + expresion)
            Next
        End With
        fileName.Close()
    End Sub

    Public Function centrar(ByVal valor As String, ByVal ancho As Integer)
        Dim s As String = Trim(valor)
        Dim sp As String = "                                                   "
        If s.Length > ancho Then
            centrar = s
            Exit Function
        End If
        Dim x = (ancho - s.Length) \ 2
        s = Mid(sp, 1, x) + s
        centrar = s
    End Function

    Public Sub encabezado(ByVal file As String, ByVal hed As String, ByVal ancho As Integer)
        Dim f As New System.IO.StreamWriter(file, False)
        f.WriteLine(centrar(hed, ancho))
        f.WriteLine(centrar(cia.nombre, ancho))
        f.WriteLine(centrar(cia.direccion, ancho))
        Dim DIREC As String
        DIREC = Trim(cia.ciudad) + ", " + Trim(cia.Edo) + ", C.P." + Trim(cia.CP)
        f.WriteLine(centrar(DIREC, ancho))
        f.WriteLine(centrar("R.F.C.: " + cia.rfc, ancho))
        f.Close()
    End Sub

    Public Sub cargar_catalogo()
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim cmd, cs As String
        cs = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT productos.id_Producto, productos.id_Directorio, productos.Descripcion, sql_Undcompra.factorc, " _
        & "sql_Undcompra.factorc * sql_Undcompra.ub_costo AS Costoc, sql_Undcompra.ub_costo ,  sql_Undcompra.ub_venta," _
        & " productos.iva, productos.caducidad, sql_Undcompra.Codigo, sql_Undcompra.uc, sql_Undcompra.iduc, "
        cmd = cmd + "sql_Undcompra.Ub_und, productos.caducidad, productos.ieps "
        cmd = cmd + "FROM productos INNER JOIN sql_Undcompra ON productos.id_Producto = sql_Undcompra.id_Producto where productos.id_Grupo <> " + My.Settings.grupo_suspendidos.ToString
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        'Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(AdaptadorDeDatos)
        tabla_catalogo.Clear()
        AdaptadorDeDatos.Fill(tabla_catalogo)
        catbs.DataSource = tabla_catalogo
    End Sub

    Function ldocumento(ByVal td As String, ByVal folio As Integer, ByVal serie As String) As DataTable
        Dim p1, p2, p3, cmd As String, DT As New DataTable
        p1 = " WHERE DOCUMENTOS.TD =" + td + " and "
        p2 = "documentos.folio = " + folio.ToString + " and "
        p3 = "documentos.serie = '" + serie.ToString + "'"
        cmd = "SELECT Documentos.td, tbl_Tipodoc.Descripciom, Documentos.Folio, Documentos.serie, Documentos.almacen, Directorio.id_directorio, Directorio.Nombre,Documentos.fechafactura, Documentos.Importe, Documentos.status, Documentos.Abonado, Documentos.nc_td, Documentos.nc_folio, "
        cmd += " Documentos.nc_serie FROM Documentos INNER JOIN "
        cmd += "Directorio ON Documentos.id_directorio = Directorio.id_directorio AND Documentos.tipo_directorio = Directorio.tipo INNER JOIN "
        cmd += " tbl_Tipodoc ON Documentos.td = tbl_Tipodoc.td " + p1 + p2 + p3
        Dim adap As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        adap = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        adap.Fill(DT)
        ldocumento = DT
    End Function

    Function cdocumento(ByVal td As String, ByVal folio As Integer, ByVal serie As String) As DataTable
        Dim p1, p2, p3, cmd As String, DT As New DataTable
        p1 = " WHERE DOCUMENTOS.TD =" + td + " and "
        p2 = "documentos.folio = " + folio.ToString + " and "
        p3 = "documentos.serie = '" + serie.ToString + "'"
        cmd = "SELECT * from Documentos " + p1 + p2 + p3
        Dim adap As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        adap = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        adap.Fill(DT) : cdocumento = DT

    End Function

    Function fnsp(ByVal campo As String, ByVal len As Integer)
        fnsp = Mid(campo.TrimEnd() + espacios, 1, len)
    End Function

    Function validar_boleta(ByVal boleta As Long, ByVal Agente As Integer) As Boolean
        Dim mydt As New DataTable
        Dim cmd As String
        cmd = "SELECT  count(id_agente) FROM tbl_boletas where id_agente = " + Agente.ToString + " and " + boleta.ToString + " between inicial and final group by id_agente"
        Dim adap As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        adap = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        adap.Fill(mydt)
        Try
            If mydt.Rows.Count > 0 Then
                validar_boleta = True
                Exit Function
            Else
                validar_boleta = False
            End If
        Catch ex As Exception
            validar_boleta = False
        End Try

    End Function

    Function siguiente_boleta(ByVal agente As Integer) As Long
        Dim mydt As New DataTable
        Dim cmd As String
        cmd = "SELECT MAX(folio) AS folio, agente FROM dbo.Pagos where agente = " + agente.ToString + " GROUP BY agente"
        Dim adap As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        adap = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        adap.Fill(mydt)
        Try
            siguiente_boleta = mydt.Rows(0).Item(0) + 1
        Catch ex As Exception
            siguiente_boleta = InputBox("Teclee el numero de la boleta, inicial", "Primera Boleta", "")
        End Try
    End Function

    Function asignar_bloc(ByVal agente As Integer, ByVal boleta_inicial As Long) As Boolean
        Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
            conection.Open()
            Dim cmd As String
            Dim adap As New Data.SqlClient.SqlDataAdapter
            Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
            cmd = "INSERT INTO [integra].[dbo].[tbl_boletas] ([id_agente] ,[inicial]) " _
             + " VALUES (" + agente.ToString + "," + boleta_inicial.ToString + ")"

            Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
            adap.InsertCommand = Command
            Try
                adap.InsertCommand.ExecuteNonQuery()
                asignar_bloc = True
            Catch ex As Exception
                MsgBox("Este Bloc ya esta asignado")
                asignar_bloc = False
            End Try


        End Using
    End Function

    Function cfecha(ByVal fecha As Date)
        cfecha = Format(fecha, "yyyy-MM-dd")
    End Function

    Function fnfecha(ByVal fecha As Date)
        fnfecha = " CONVERT(DATETIME,'" + cfecha(fecha) + "',102)"
    End Function

    Function leer_tabla(ByVal cmd As String) As DataTable
        Dim da As New SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim cs As String = My.Settings.AdmintegralConnectionString
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(da)
        da.Fill(tbl)
        leer_tabla = tbl

    End Function

    Function leer_sat(ByVal cmd As String) As DataTable
        Dim da As New SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim cs As String = My.Settings.SAT_catalogosConnectionString
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(da)
        da.Fill(tbl)
        leer_sat = tbl

    End Function


    Function leer_documento(ByVal td As Integer, ByVal folio As Long, ByVal serie As String) As DataRow

        Dim sql As String
        sql = "SELECT        Almacen, Descripciom, Importe, Nombre, descuento0, descunto10, descunto15, diasc, factura, fechafactura, fechasurtido, flete, folio_pedido, id_almacen, id_almacen_entrada, id_cartera, id_directorio, ieps, " _
        & " iva10, iva15, nc_folio, nc_serie, nc_td, ncaja, pesoengramos, porciento_descuento, serie, status, sub0, sub10, sub15, td, vence FROM sql_documentos_clientes " _
        & " WHERE (td = @td) AND (Folio = @Folio) AND (serie = '@serie') ORDER BY Folio"
        sql = sql.Replace("@td", td.ToString)
        sql = sql.Replace("@Folio", folio.ToString)
        sql = sql.Replace("@serie", serie)

        leer_documento = leer_tabla(sql).Rows(0)

        'Dim adap As New admintegralDataSetTableAdapters.sql_documentos_clientesTableAdapter
        'Try
        '    adap.ClearBeforeFill = True
        '    If adap.lee_un_documento(td, folio, serie).HasErrors = False Then
        '        leer_documento = adap.lee_un_documento(td, folio, serie).Rows(0)
        '    Else
        '        leer_documento = Nothing
        '    End If
        'Catch ex As Exception

        'End Try

    End Function

    Function leer_saldo(ByVal td As Integer, ByVal folio As Long, ByVal serie As String) As DataRow
        Dim adap As New admintegralDataSetTableAdapters.cxc_saldos_x_facturaTableAdapter
        If adap.GetDataByDoc(td, folio, serie).Rows.Count > 0 Then
            leer_saldo = adap.GetDataByDoc(td, folio, serie).Rows(0)
        Else
            leer_saldo = Nothing
        End If
    End Function

    Function leer_folio(ByVal td As Integer, ByVal serie As String) As Long
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim cmd As String, tbltmp As New DataTable
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT * from fn_siguiente_folio where td =" + td.ToString + " and " + "serie = '" + serie + "'"
        AdaptadorDeDatos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        AdaptadorDeDatos.Fill(tbltmp)
        If tbltmp.Rows.Count = 0 Then
            leer_folio = 1
        Else
            leer_folio = tbltmp.Rows(0).Item("folio")
        End If
    End Function 'Determina el siguiente numero de folio segun la tabla de folioscrear_pago

    Public Sub marcar_documento(ByVal td As Integer, ByVal folio As Long, ByVal serie As String)
        Dim adoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
        adoc.UpdateStatus(1, user.id, td, folio, serie) ' Marca como cancelado 
        amov.borrar_movimientos(td, folio, serie) ' Elimina los movimientos
        adoc.Dispose() : amov.Dispose()
    End Sub ' Macar los documentos para ser cancelados (cancela)

    Public Sub borrar_registros(ByVal tabla As String)
        Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
            conection.Open()
            Dim cmd As String
            Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
            Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
            cmd = "DELETE FROM " + tabla
            Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
            AdaptadorDeDatos.DeleteCommand = Command
            AdaptadorDeDatos.DeleteCommand.ExecuteNonQuery()
        End Using

    End Sub ' Borrar registros de una tabla

    Public Function clavedinamica() As Single
        Dim d, m As Integer
        d = Now.Day
        m = Now.Month
        clavedinamica = m * d * 3.14
    End Function ' calcula clave dimamica

    Public Function bitacora(ByVal linea As String) As Boolean
        Dim file As String = "c:\tmp\logfile" + Now.Month.ToString + ".txt"
        Dim f As New System.IO.StreamWriter(file, True)
        Try

            Dim l As String
            l = user.nick.ToString + "|" + Now.ToShortDateString + "|" + My.Settings.ncaja.ToString + "| " + linea
            f.WriteLine(l)
            f.Close()
            bitacora = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "bITACORA")
            bitacora = False
        End Try
        f.CLOSE()
    End Function 'Bitacora

    Public Function sqlname(ByVal cs As String) As Boolean
        Try
            Dim i1, i2, i3, i4 As Integer
            i1 = InStr(cs, "=") + 1
            i2 = InStr(cs, ";") - 1
            i3 = InStr(i2 + 1, cs, "=")
            i4 = InStr(i3, cs, ";") - 1
            sql_servidor = Mid(cs, i1, i2 - i1)
            sql_catalogo = Mid(cs, i3 + 1, i4 - i3)
        Catch ex As Exception
            MsgBox("Cadena de Conexion Invalida")
        End Try

    End Function

    Function Actualiza_registros(ByVal cmd As String) As Boolean
        Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
            conection.Open()
            Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
            Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
            Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
            AdaptadorDeDatos.UpdateCommand = Command
            AdaptadorDeDatos.UpdateCommand.ExecuteNonQuery()
        End Using
    End Function

    Function id_pago(ByVal caja As Integer, ByVal fp As Integer, ByVal fecha As Date) As Single
        Dim cmd As String
        cmd = " SELECT id_pago FROM Pagos " _
        & " WHERE caja = " + caja.ToString + " AND id_fp = N'" + fp.ToString + "' AND fecha = CONVERT(DATETIME, '" + cfecha(fecha.Date) + "', 102)"
        Dim tb As DataTable = leer_tabla(cmd)
        If tb.Rows.Count = 0 Then
            id_pago = 0
        Else
            id_pago = tb.Rows(0).Item(0)
        End If
    End Function

    Function crear_pago(ByVal caja As Integer, ByVal fp As Integer, ByVal fecha As Date, ByVal agente As Integer) As Boolean
        Dim adap As New admintegralDataSetTableAdapters.PagosTableAdapter
        Dim nidp As Integer = adap.nuevo_id(My.Settings.ncaja)
        Try
            adap.Insert(nidp, caja, user.id, 0, 0, fecha, 0, 2, fp, "De contado", 0, True, "-", fecha)
            crear_pago = True
        Catch ex As Exception
            crear_pago = False
        End Try
    End Function

    Public Function comando(ByVal cmd As String) As Boolean
        Try
            Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
                conection.Open()
                Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.UpdateCommand = Command
                AdaptadorDeDatos.UpdateCommand.ExecuteNonQuery()
                AdaptadorDeDatos.Dispose()
                comando = True
            End Using
        Catch ex As Exception
            MsgBox("No se aplico comando " + cmd)
            MsgBox(ex.Message)
            comando = False
        End Try
    End Function

    Public Function eñe(ByVal palabra As String) As String
        'eñe = palabra.Replace("ñ", "¤")
        eñe = palabra.Replace("Ñ", "¥")
    End Function

    Public Function fnexistencia(ByVal almacen As Integer, ByVal id As Integer, ByVal fecha As Date) As Integer
        Dim cmd As String = "SELECT   SUM(ub_cantidad * n) AS Existencia  FROM dbo.movimientos " _
        & " WHERE almacen = " + almacen.ToString + " AND id_prodcuto = " + id.ToString + " AND fecha < " + fnfecha(fecha)
        Try
            Dim t As DataTable = leer_tabla(cmd)
            fnexistencia = t.Rows(0).Item(0)
        Catch ex As Exception

            fnexistencia = 0
        End Try

    End Function

    Public Function validar_nuevos_productos() As Boolean
        Try
            Dim cmd As String = "SELECT productos.id_Producto FROM productos LEFT OUTER JOIN productos_info ON productos.id_Producto = productos_info.Id WHERE productos_info.Id Is NULL"
            Dim tbl As DataTable = leer_tabla(cmd)
            If tbl.Rows.Count > 0 Then
                Dim adap As New reporteDataSetTableAdapters.productos_infoTableAdapter
                For j As Integer = 0 To tbl.Rows.Count - 1
                    adap.Insert(tbl.Rows(j).Item(0), Now.Date, 0, Now.Date, 0)
                Next
                adap.Dispose()
            End If
            validar_nuevos_productos = True
        Catch ex As Exception
            validar_nuevos_productos = False
        End Try

    End Function

    Public Function validar_si_existe(ByVal id As Integer) As Boolean
        Dim cmd As String = "select id_producto from productos where id_producto=" + id.ToString
        Dim tbl As DataTable
        tbl = leer_tabla(cmd)
        If tbl.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validar_si_existe_en_fijos(ByVal id As Integer) As Boolean
        Dim cmd As String = "select id_producto from inv_aleatorio_fijos where id_producto=" + id.ToString
        Dim tbl As DataTable
        tbl = leer_tabla(cmd)
        If tbl.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validar_si_existe_en_aleatorios(ByVal id As Integer, ByVal fecha As Date)
        Dim cmd As String = "select * from inv_aleatorio WHERE fecha = CONVERT(DATETIME, '[fecha] 00:00:00', 103) and id_producto=" + id.ToString
        cmd = cmd.Replace("[fecha]", Format("yyyy-MM-dd", Now.Date))
        If leer_tabla(cmd).Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function abonos_al(ByVal folio As String, ByVal serie As String, ByVal fecha_corte As Date) As Decimal
        Dim cmd As String
        cmd = "SELECT isnull(SUM(dbo.pagos_detalle.abono),0) AS Abonos " _
        & " FROM dbo.pagos_detalle INNER JOIN dbo.Pagos ON dbo.pagos_detalle.id_pago = dbo.Pagos.id_pago AND dbo.pagos_detalle.caja = dbo.Pagos.caja " _
        & " WHERE (dbo.Pagos.fecha <= CONVERT(DATETIME, '[fecha] 00:00:00', 102)) AND dbo.pagos_detalle.id_doc = 6 AND dbo.pagos_detalle.folio = [folio] AND " _
        & " dbo.pagos_detalle.serie = '[serie]'"
        cmd = cmd.Replace("[fecha]", Format(fecha_corte, "yyyy-MM-dd"))
        cmd = cmd.Replace("[folio]", folio.ToString)
        cmd = cmd.Replace("[serie]", serie)
        Dim t As DataTable = leer_tabla(cmd)
        If t.Rows.Count = 1 Then abonos_al = t.Rows(0).Item(0)
    End Function

    Public Function comando1(ByVal cmd As String) As Boolean
        Try
            Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
                conection.Open()
                Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.UpdateCommand = Command
                AdaptadorDeDatos.UpdateCommand.ExecuteNonQuery()
                AdaptadorDeDatos.Dispose()
                comando1 = True
            End Using
        Catch ex As Exception
            comando1 = False
        End Try
    End Function

    Public Function mandar_correo(ByVal para As String, ByVal asunto As String, ByVal mensaje As String, ByVal attach As String, ByVal attach1 As String) As Boolean

        Dim message As New Net.Mail.MailMessage(smtp.email, para, asunto, mensaje)
        Dim emailClient As New Net.Mail.SmtpClient(smtp.servidor, smtp.puerto)
        emailClient.Credentials = New Net.NetworkCredential(smtp.user, smtp.pw)
        If attach.Length > 0 Then
            Dim attachement As New System.Net.Mail.Attachment(attach)
            message.Attachments.Add(attachement)
        End If

        If attach1.Length > 0 Then
            Dim attachement1 As New System.Net.Mail.Attachment(attach1)
            message.Attachments.Add(attachement1)
        End If

        Try
            emailClient.Send(message)
            mandar_correo = True
            Exit Function
        Catch ex As Exception
            MsgBox(ex.Message)
            mandar_correo = True
        End Try
        mandar_correo = False
    End Function
    'Función que comprueba si una diección de email es válida
    '*********************************************************************************
    Public Function Validar_Email(ByVal Email As String) As Boolean

        Dim i As Integer, iLen As Integer, caracter As String
        Dim pos As Integer, bp As Boolean, iPos As Integer, iPos2 As Integer

        On Error GoTo Err_Sub

        Email = Trim$(Email)

        If Email = vbNullString Then
            Exit Function
        End If

        Email = LCase$(Email)
        iLen = Len(Email)


        For i = 1 To iLen
            caracter = Mid(Email, i, 1)

            If (Not (caracter Like "[a-z]")) And (Not (caracter Like "[0-9]")) Then

                If InStr(1, "_-" & "." & "@", caracter) > 0 Then
                    If bp = True Then
                        Exit Function
                    Else
                        bp = True

                        If i = 1 Or i = iLen Then
                            Exit Function
                        End If

                        If caracter = "@" Then
                            If iPos = 0 Then
                                iPos = i
                            Else

                                Exit Function
                            End If
                        End If
                        If caracter = "." Then
                            iPos2 = i
                        End If

                    End If
                Else

                    Exit Function
                End If
            Else
                bp = False
            End If
        Next i
        If iPos = 0 Or iPos2 = 0 Then
            Exit Function
        End If

        If iPos2 < iPos Then
            Exit Function
        End If


        Validar_Email = True

        Exit Function
Err_Sub:
        On Error Resume Next
        Validar_Email = False
    End Function

    Public Function actualiza_factura_cxp(ByVal id As Integer, ByVal factura As String) As Boolean
        Try
            Dim abono As Decimal
            abono = leer_tabla("select SUM(importe) AS ABONOS from cxp_abonos where id_directorio = " + id.ToString + " and factura = '" + factura + "'").Rows(0).Item(0)
            Dim adap As New integraDataSetTableAdapters.cxp_facturasTableAdapter
            adap.actualiza_abonos(abono, id, factura)
            actualiza_factura_cxp = True
        Catch ex As Exception
            actualiza_factura_cxp = False
        End Try
        
    End Function

    Function poxxo(ByVal id As Integer) As Decimal
        Dim cmd As String
        cmd = "SELECT     precio_oxxo FROM dbo.productos WHERE id_Producto = " + id.ToString
        Try
            poxxo = leer_tabla(cmd).Rows(0).Item(0)
        Catch ex As Exception
            poxxo = 0
        End Try

    End Function


    Function exportar_Excel(ByVal Datagrid As DataGridView, ByVal archivo As String, Optional ByVal renglones As Integer = 0) As Boolean

        ' -- Variables para Excel   
        Dim Obj_Excel As Object
        Dim Obj_Libro As Object
        Dim Obj_Hoja As Object
        Dim N_filas As Integer = 0
        Dim dialogo As New SaveFileDialog

        My.Computer.FileSystem.WriteAllText(archivo, String.Empty, False)

        On Error GoTo Error_Handler
        Dim i As Integer
        Dim j As Integer
        N_filas = Datagrid.Rows.Count
        If N_filas = 0 Then
            MsgBox("No hay datos para exportar a excel. Se ha indicado 0 en el parámetro Filas ") : Exit Function
        Else
            ' -- Crear nueva instancia de Excel   
            Obj_Excel = CreateObject("Excel.Application")
            ' -- Agregar nuevo libro   
            Obj_Libro = Obj_Excel.Workbooks.Open(archivo)
            ' -- Referencia a la Hoja activa ( la que añade por defecto Excel )   
            Obj_Hoja = Obj_Excel.ActiveSheet
            Obj_Hoja.cells(1, 1) = ""

            Dim iCol As Integer = 0
            ' --  Recorrer el Datagrid ( Las columnas )   
            For i = 0 To Datagrid.Columns.Count - 1
                If Datagrid.Columns(i).Visible Then
                    ' -- Incrementar índice de columna   
                    iCol = iCol + 1
                    ' -- Obtener el caption de la columna   Pone encabezados de columna
                    Obj_Hoja.Cells(1 + renglones, iCol) = Datagrid.Columns(i).HeaderText
                    ' -- Recorrer las filas   
                    For j = 0 To N_filas - 1
                        ' -- Asignar el valor a la celda del Excel   
                        Obj_Hoja.Cells(j + 2 + renglones, iCol) = _
                        Datagrid.Rows(j).Cells(i).Value
                    Next
                End If
            Next

            ' -- Hacer excel visible   
            Obj_Excel.Visible = True
            '  Obj_Excel.save()
            ' -- Opcional : colocar en negrita y de color rojo los enbezados en la hoja   
            With Obj_Hoja
                ' -- Autoajustar las cabeceras   
                .Columns("A:Z").AutoFit()
            End With
        End If


        ' -- Eliminar las variables de objeto excel   
        Obj_Hoja = Nothing
        Obj_Libro = Nothing
        Obj_Excel = Nothing

        Exit Function
        ' -- Error   
Error_Handler:

        MsgBox(Err.Description, vbCritical)
        On Error Resume Next

        Obj_Hoja = Nothing
        Obj_Libro = Nothing
        Obj_Excel = Nothing
    End Function

    Function exportar_tabla_Excel(ByVal datagrid As DataTable, ByVal archivo As String, Optional ByVal titulo1 As String = "", _
                                 Optional ByVal titulo2 As String = "", Optional ByVal col As String = "A:A") As Boolean

        ' -- Variables para Excel   
        Dim Obj_Excel As Object
        Dim Obj_Libro As Object
        Dim Obj_Hoja As Object
        Dim N_filas As Integer = 0
        Dim dialogo As New SaveFileDialog
        Dim lin_head As Integer = 4

        My.Computer.FileSystem.WriteAllText(archivo, String.Empty, False)

        On Error GoTo Error_Handler
        Dim i As Integer
        Dim j As Integer
        N_filas = datagrid.Rows.Count
        If N_filas = 0 Then
            MsgBox("No hay datos para exportar a excel. Se ha indicado 0 en el parámetro Filas ") : Return False
        Else
            ' -- Crear nueva instancia de Excel   
            Obj_Excel = CreateObject("Excel.Application")
            ' -- Agregar nuevo libro   
            Obj_Libro = Obj_Excel.Workbooks.Open(archivo)
            ' -- Referencia a la Hoja activa ( la que añade por defecto Excel )   
            Obj_Hoja = Obj_Excel.ActiveSheet
            Obj_Hoja.name = "Datos"

            ''''Define encabezado
            Obj_Hoja.Cells(1, 1) = titulo1
            Obj_Hoja.Cells(2, 1) = titulo2
            Obj_Hoja.Cells(3, 1) = "Fecha : " + Now.Date.ToShortDateString + "  Hora : " + Now.Date.ToShortTimeString

            Obj_Excel.Columns(col).Select()
            Obj_Excel.Selection.NumberFormat = "@"

            Dim iCol As Integer = 0
            ' --  Recorrer el Datagrid ( Las columnas )   
            For i = 0 To datagrid.Columns.Count - 1
                If datagrid.Columns(i).ColumnName <> "COSTO" Then
                    ' -- Incrementar índice de columna   
                    iCol = iCol + 1
                    ' -- Obtener el caption de la columna   
                    Obj_Hoja.Cells(1 + lin_head, iCol) = datagrid.Columns(i).ColumnName
                    ' -- Recorrer las filas   
                    For j = 0 To N_filas - 1
                        ' -- Asignar el valor a la celda del Excel  

                        Obj_Hoja.Cells(j + 2 + lin_head, iCol) = datagrid.Rows(j).Item(i)

                    Next
                End If
            Next
            ' -- Hacer excel visible   
            Obj_Excel.Visible = True
            ' -- Opcional : colocar en negrita y de color rojo los enbezados en la hoja   
            With Obj_Hoja
                ' -- Autoajustar las cabeceras   
                .Columns("A:Z").AutoFit()
            End With
        End If
        ' -- Eliminar las variables de objeto excel   

        Obj_Hoja = Nothing
        Obj_Libro = Nothing
        Obj_Excel = Nothing
        'Obj_Excel.save()
        MsgBox("Se guardo el archivo " + archivo)

        'Obj_Excel.close()


        Return True

        ' -- Error   
Error_Handler:

        MsgBox(Err.Description, vbCritical)
        ' On Error Resume Next
        Obj_Hoja = Nothing
        Obj_Libro = Nothing
        Obj_Excel = Nothing
    End Function
    

End Module
