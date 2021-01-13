Module sql_utilerias
    Function crear_existencias() As Boolean
        Dim cmd As String
        cmd = "SELECT id_prodcuto, SUM(ub_cantidad * n) AS Existencia INTO existencias FROM movimientos WHERE Numero <> 0 AND almacen = 0 GROUP BY id_prodcuto "
        comando(cmd)
    End Function

    Function borrar_tablas_temporales()
        Dim cmd As String
        cmd = "drop table [catalogo_general]"
        comando(cmd)

        cmd = "delete  from pz_vendidas "
        comando(cmd)

        cmd = "DROP TABLE [dbo].[mismovimientos] "
        comando(cmd)

        cmd = "DROP TABLE [dbo].[existencias] "
        comando(cmd)

    End Function


    Function crear_catalog_general() As Boolean
        Dim cmd As String
        cmd = "SELECT     Directorio.id_directorio AS id_prov, Directorio.Nombre AS Proveedor, Grupos.id_grupos AS GP, RTRIM(Grupos.Grupo) AS Grupo, productos.id_Producto AS clave, " _
        & " Unidades_productos_1.Codigo, productos.Descripcion, productos.iva, Unidades_productos_2.Unidad AS und_detalle, Unidades_productos.Unidad AS Und_venta, " _
        & " Unidades_productos_1.Unidad AS Und_compra, Unidades_productos.factor AS PzsXExhib, Unidades_productos_1.factor / Unidades_productos.factor AS ExhibxCj, " _
        & " Unidades_productos_1.factor AS PzsXCJ, Unidades_productos_2.costo AS Costo_pz, Unidades_productos.costo AS Costo_Exhib, " _
        & " Unidades_productos_1.costo AS Costo_CJ, Unidades_productos_2.venta AS Pv_pz, Unidades_productos.venta AS Pv_Exhib, Unidades_productos_1.venta AS Pv_Cj, " _
        & "  productos.subgrupo  INTO catalogo_general FROM productos INNER JOIN " _
        & " Unidades_productos ON productos.id_Producto = Unidades_productos.id_producto AND productos.und_venta = Unidades_productos.id_unidad INNER JOIN" _
        & " Unidades_productos AS Unidades_productos_1 ON productos.id_Producto = Unidades_productos_1.id_producto AND " _
        & " productos.und_compra = Unidades_productos_1.id_unidad INNER JOIN" _
        & " Directorio ON productos.id_Directorio = Directorio.id_directorio AND productos.tipo = Directorio.tipo INNER JOIN" _
        & " Grupos ON productos.id_Grupo = Grupos.id_grupos INNER JOIN" _
        & " Unidades_productos AS Unidades_productos_2 ON productos.id_Producto = Unidades_productos_2.id_producto AND " _
        & " productos.und_detalle = Unidades_productos_2.id_unidad"
        comando(cmd)
    End Function

    Function crear_pz_vendidas() As Boolean
        Dim cmd As String
        cmd = "INSERT INTO pz_vendidas (id_prodcuto, Pz_vendidas) " _
        & "SELECT     TOP (100) PERCENT movimientos.id_prodcuto, SUM(CASE WHEN ((dbo.movimientos.id_doc = 5 OR" _
        & " dbo.movimientos.id_doc = 6 OR dbo.movimientos.id_doc = 7) AND " _
        & " (dbo.movimientos.fecha >= CONVERT(DATETIME, '[del]', 102) AND " _
        & " dbo.movimientos.fecha <= CONVERT(DATETIME, '[al]', 102))) THEN dbo.movimientos.ub_cantidad * dbo.tbl_tipodoc.natgrupo ELSE 0 END) AS Pz_vendidas " _
        & " FROM tbl_Tipodoc INNER JOIN movimientos ON tbl_Tipodoc.td = movimientos.id_doc WHERE movimientos.status = 0 AND " _
        & " (movimientos.fecha >= CONVERT(DATETIME, '2011-01-01 00:00:00', 102)) GROUP BY movimientos.id_prodcuto"

        Dim al, del As String
        al = Format(Date.Now, "yyyy-MM-dd")
        del = Format(Now.AddMonths(-1), "yyyy-MM-dd")

        cmd = cmd.Replace("[del]", del)
        cmd = cmd.Replace("[al]", al)
        comando(cmd)

        ' genera ventas or tienda
        cmd = "delete  from pz_vendidas_x_tienda "
        comando(cmd)

        cmd = "INSERT INTO pz_vendidas_x_tienda (id_prodcuto,almacen, tipo, unidades) " _
        & "SELECT     TOP (100) PERCENT movimientos.id_prodcuto,movimientos.almacen,'U.Vendidas', SUM(CASE WHEN ((dbo.movimientos.id_doc = 5 OR" _
        & " dbo.movimientos.id_doc = 6 OR dbo.movimientos.id_doc = 7) AND " _
        & " (dbo.movimientos.fecha >= CONVERT(DATETIME, '[del]', 102) AND " _
        & " dbo.movimientos.fecha <= CONVERT(DATETIME, '[al]', 102))) THEN dbo.movimientos.ub_cantidad * dbo.tbl_tipodoc.natgrupo ELSE 0 END) AS Pz_vendidas " _
        & " FROM tbl_Tipodoc INNER JOIN movimientos ON tbl_Tipodoc.td = movimientos.id_doc WHERE movimientos.status = 0 AND " _
        & " (movimientos.fecha >= CONVERT(DATETIME, '2011-01-01 00:00:00', 102)) GROUP BY movimientos.id_prodcuto,movimientos.almacen"

        al = Format(Date.Now, "yyyy-MM-dd")
        del = Format(Now.AddMonths(-1), "yyyy-MM-dd")

        cmd = cmd.Replace("[del]", del)
        cmd = cmd.Replace("[al]", al)
        comando(cmd)


    End Function

    Function crear_mis_movimientos() As Boolean
        Dim cmd As String
        cmd = " SELECT     almacen, id_doc, folio_doc, serie, Numero, fecha, id_prodcuto, factor, piva, ud, cantidad, costo, cos_desc, cos_flete, cos_iva10, cos_iva15, venta, Vta_desc, " _
        & " Vta_iva10, Vta_iva15, ub_cantidad, ub_costo, ub_cos_desc, ub_cos_flete, ub_cos_iva10, ub_cos_iva15, ub_venta, ub_vta_descuento, ub_vta_iva10, ub_vta_iva15, " _
        & " status, n, caduca      INTO mismovimientos FROM movimientos WHERE fecha > CONVERT(DATETIME, '2011-01-01 00:00:00', 102)"
        comando(cmd)
    End Function


    Function crear_reporte(ByVal idpv As Integer, ByVal fdel As Date, ByVal fal As Date) As Boolean
        Dim cmd As String
        Dim al, del As String
        al = Format(fal, "yyyy-MM-dd")
        del = Format(fdel, "yyyy-MM-dd")        ' genera ventas por tienda
        cmd = "delete  from pz_vendidas_x_tienda "
        comando(cmd)

        'cmd = "INSERT INTO pz_vendidas_x_tienda (id_prodcuto,almacen, tipo, unidades) " _
        '& "SELECT     TOP (100) PERCENT movimientos.id_prodcuto,movimientos.almacen,'U.Vendidas', SUM(CASE WHEN ((dbo.movimientos.id_doc = 5 OR" _
        '& " dbo.movimientos.id_doc = 6 OR dbo.movimientos.id_doc = 7) AND " _
        '& " (dbo.movimientos.fecha >= CONVERT(DATETIME, '[del]', 102) AND " _
        '& " dbo.movimientos.fecha <= CONVERT(DATETIME, '[al]', 102))) THEN dbo.movimientos.ub_cantidad * dbo.tbl_tipodoc.natgrupo ELSE 0 END) AS Pz_vendidas " _
        '& " FROM movimientos INNER JOIN tbl_Tipodoc ON movimientos.id_doc = tbl_Tipodoc.td " _
        '& " WHERE movimientos.status = 0  AND " _
        '& " (movimientos.fecha >= CONVERT(DATETIME, '[del] 00:00:00', 102)) GROUP BY movimientos.id_prodcuto,movimientos.almacen "

        cmd = "INSERT INTO pz_vendidas_x_tienda (id_prodcuto,almacen, tipo, unidades) " _
         & "SELECT     TOP (100) PERCENT movimientos.id_prodcuto,movimientos.almacen,'U.Vendidas', SUM(CASE WHEN ((dbo.movimientos.id_doc = 5 OR" _
         & " dbo.movimientos.id_doc = 6 OR dbo.movimientos.id_doc = 7) AND " _
         & " (dbo.movimientos.fecha >= CONVERT(DATETIME, '[del]', 102) AND " _
         & " dbo.movimientos.fecha <= CONVERT(DATETIME, '[al]', 102))) THEN dbo.movimientos.ub_cantidad * -1 ELSE 0 END) AS Pz_vendidas " _
         & " FROM movimientos " _
         & " WHERE movimientos.status = 0  AND " _
         & " (movimientos.fecha >= CONVERT(DATETIME, '[del] 00:00:00', 102)) GROUP BY movimientos.id_prodcuto,movimientos.almacen "

        cmd = cmd.Replace("[del]", del)
        cmd = cmd.Replace("[al]", al)
        cmd = cmd.Replace("[idpv]", idpv.ToString)
        comando(cmd)

        cmd = "INSERT INTO pz_vendidas_x_tienda (id_prodcuto,almacen, tipo, unidades) SELECT id_prodcuto,almacen,'exist' as tipo, SUM(ub_cantidad * n) AS unidades  " _
        & " FROM movimientos INNER JOIN catalogo_general ON movimientos.id_prodcuto = catalogo_general.clave " _
        & " WHERE movimientos.status = 0 AND n<>0 and catalogo_general.id_prov = [idpv] " _
        & " GROUP BY id_prodcuto,almacen "
        cmd = cmd.Replace("[idpv]", idpv.ToString)
        comando(cmd)

        'elimina la tabla y la genera de nuevo
        cmd = "DROP TABLE [dbo].[reporte_ventas_existencia] "
        comando(cmd)

        cmd = "SELECT clave ,id_prov, Proveedor, Codigo, Descripcion, Costo_CJ AS Costo, PzsXCJ AS Emp, Costo_pz, Pv_pz, (Pv_pz / Costo_pz - 1) * 100 AS Margen, 0 AS t1e, 0 AS t1v, 0 AS t2e, " _
        & " 0 AS t2v, 0 AS t3e, 0 AS t3v, 0 AS t4e, 0 AS t4v, 0 AS t5e, 0 AS t5v, 0 AS t6e, 0 AS t6v, GP, Grupo INTO reporte_ventas_existencia FROM catalogo_general where id_prov= " + idpv.ToString
        comando(cmd)

        'Actualiza cada una de las columnas (tienda 1 col1 )
        cmd = "UPDATE reporte_ventas_existencia set t1v = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & " WHERE  pz_vendidas_x_tienda.almacen = 1 AND pz_vendidas_x_tienda.tipo = 'U.Vendidas'"
        comando(cmd)
        cmd = "UPDATE reporte_ventas_existencia set t1e = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & "WHERE pz_vendidas_x_tienda.almacen = 1 AND pz_vendidas_x_tienda.tipo = 'exist'"
        comando(cmd)

        'Actualiza cada una de las columnas (tienda 3 col2 )
        cmd = "UPDATE reporte_ventas_existencia set t2v = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & " WHERE  pz_vendidas_x_tienda.almacen = 3 AND pz_vendidas_x_tienda.tipo = 'U.Vendidas'"
        comando(cmd)
        cmd = "UPDATE reporte_ventas_existencia set t2e = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & "WHERE pz_vendidas_x_tienda.almacen = 3 AND pz_vendidas_x_tienda.tipo = 'exist'"
        comando(cmd)

        'Actualiza cada una de las columnas (tienda 4 col2 )
        cmd = "UPDATE reporte_ventas_existencia set t3v = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & " WHERE  pz_vendidas_x_tienda.almacen = 4 AND pz_vendidas_x_tienda.tipo = 'U.Vendidas'"
        comando(cmd)
        cmd = "UPDATE reporte_ventas_existencia set t3e = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & "WHERE pz_vendidas_x_tienda.almacen = 4 AND pz_vendidas_x_tienda.tipo = 'exist'"
        comando(cmd)
        'Actualiza cada una de las columnas (tienda 5 col4 )
        cmd = "UPDATE reporte_ventas_existencia set t4v = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & " WHERE  pz_vendidas_x_tienda.almacen = 5 AND pz_vendidas_x_tienda.tipo = 'U.Vendidas'"
        comando(cmd)
        cmd = "UPDATE reporte_ventas_existencia set t4e = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & "WHERE pz_vendidas_x_tienda.almacen = 5 AND pz_vendidas_x_tienda.tipo = 'exist'"
        comando(cmd)

        'Actualiza cada una de las columnas (tienda 6 col5 )
        cmd = "UPDATE reporte_ventas_existencia set t5v = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & " WHERE  pz_vendidas_x_tienda.almacen = 6 AND pz_vendidas_x_tienda.tipo = 'U.Vendidas'"
        comando(cmd)
        cmd = "UPDATE reporte_ventas_existencia set t5e = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & "WHERE pz_vendidas_x_tienda.almacen = 6 AND pz_vendidas_x_tienda.tipo = 'exist'"
        comando(cmd)

        'Actualiza cada una de las columnas (tienda 0 col6 )
        cmd = "UPDATE reporte_ventas_existencia set t6v = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & " WHERE  pz_vendidas_x_tienda.almacen = 0 AND pz_vendidas_x_tienda.tipo = 'U.Vendidas'"
        comando(cmd)
        cmd = "UPDATE reporte_ventas_existencia set t6e = pz_vendidas_x_tienda.unidades FROM pz_vendidas_x_tienda INNER JOIN reporte_ventas_existencia ON pz_vendidas_x_tienda.id_prodcuto = reporte_ventas_existencia.clave " _
        & "WHERE pz_vendidas_x_tienda.almacen = 0 AND pz_vendidas_x_tienda.tipo = 'exist'"
        comando(cmd)
    End Function

    Public Sub actualizar_existencia()
        Dim x As Boolean
        x = borrar_tablas_temporales()
        x = crear_existencias()
        x = crear_catalog_general()
        x = crear_pz_vendidas()
        x = crear_mis_movimientos()
        Beep()
    End Sub

    Public Sub cierre_mes()
        'corre las rutinas para generar el kardex_resumen del periodo (inicial, entradas, ventas, final)
        Dim sql, cmd As String

        'elimina rgistros del periodo si existen.
        cmd = "DELETE FROM kardex_resumen FROM  kardex_resumen INNER JOIN sys_periodo ON kardex_resumen.del = sys_periodo.del AND kardex_resumen.al = sys_periodo.al"
        comando(cmd)

        'genera registros con el inventario inicial
        cmd = "INSERT INTO kardex_resumen (del, al, id, descripcion, costo, inicial, entradas, devoluciones, ventas, nc, ajustes, final) " _
        & " SELECT  sys_periodo.del, sys_periodo.al, productos.id_Producto AS Id, productos.Descripcion, AVG(movimientos.costo) AS costo, SUM(movimientos.ub_cantidad * movimientos.n) AS inicial, 0 AS entradas, 0 AS devoluciones, 0 AS venta, " _
        & " 0 AS nc, 0 AS ajustes, 0 AS final FROM productos INNER JOIN movimientos ON productos.id_Producto = movimientos.id_prodcuto INNER JOIN sys_periodo ON movimientos.fecha < sys_periodo.del " _
        & " WHERE        (movimientos.n <> 0) AND (productos.id_Grupo <> 100) AND (movimientos.almacen = 0) GROUP BY productos.id_Producto, productos.Descripcion, sys_periodo.del, sys_periodo.al " _
        & " HAVING(SUM(movimientos.ub_cantidad * movimientos.n) <> 0) ORDER BY productos.Descripcion"
        comando(cmd)

        'actualiza columna de entradas
        cmd = "UPDATE kardex_resumen SET entradas = cierre_entradas.entradas FROM kardex_resumen INNER JOIN sys_periodo ON kardex_resumen.del = sys_periodo.del AND kardex_resumen.al = sys_periodo.al INNER JOIN  cierre_entradas ON kardex_resumen.id = cierre_entradas.id_prodcuto"
        comando(cmd)

        'actualiza devoluciones
        cmd = "UPDATE kardex_resumen SET devoluciones = cierre_devoluciones.Devoluciones FROM kardex_resumen INNER JOIN sys_periodo ON kardex_resumen.del = sys_periodo.del AND kardex_resumen.al = sys_periodo.al INNER JOIN  cierre_devoluciones ON kardex_resumen.id = cierre_devoluciones.id_prodcuto"
        comando(cmd)

        'Actualiza ventas
        cmd = "UPDATE kardex_resumen SET ventas = cierre_ventas.vendidas FROM kardex_resumen INNER JOIN  sys_periodo ON kardex_resumen.del = sys_periodo.del AND kardex_resumen.al = sys_periodo.al INNER JOIN  cierre_ventas ON kardex_resumen.id = cierre_ventas.id_prodcuto"
        comando(cmd)

        'Actualiza Existencia Final
        cmd = "UPDATE kardex_resumen SET final = cierre_existencia_final.Existencia FROM kardex_resumen INNER JOIN sys_periodo ON kardex_resumen.al = sys_periodo.al AND kardex_resumen.del = sys_periodo.del INNER JOIN cierre_existencia_final ON kardex_resumen.id = cierre_existencia_final.id_prodcuto"
        comando(cmd)




    End Sub
    Public Function calcula_Existencia(ByVal id As Integer) As Integer
        Dim cmd As String, exi As Integer
        cmd = "SELECT  SUM(movimientos.ub_cantidad * n) AS unidades  from movimientos where id_prodcuto=" + id.ToString
        Try
            exi = leer_tabla(cmd).Rows(0).Item(0)
        Catch ex As Exception
            exi = 0
        End Try

        Return exi
    End Function
End Module
