Public Class Main
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        version.Text = "Ver. " + My.Application.Info.Version.ToString
        My.Settings.sqlserver = "Data Source=MATRIX\SQLEXPRESS;Initial Catalog=integral;Integrated Security=True;Connect Timeout=60"
        Me.Refresh()

        metodos(0) = "No definido"
        metodos(1) = "01"
        metodos(2) = "28"
        metodos(3) = "04"
        metodos(4) = "02"
        metodos(5) = "03"
        While login = False

            My.Forms.frm_login.ShowDialog()
            If My.Forms.frm_login.DialogResult = Windows.Forms.DialogResult.Cancel Then Me.Close() : End
            '  If login = False Then MsgBox("Verificar Usuario y Contraseña")
            login = True
        End While
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        If My.Computer.Name = "matrix" Then Me.FEIToolStripMenuItem.Enabled = True
        'Carga INI
        '==============================================================================================
        Dim f As Integer = FreeFile()
        Dim x As String
        Try
            FileOpen(FreeFile, "c:\tmp\caja.ini", OpenMode.Input)
            With My.Settings
                .ncaja = LineInput(f)
                .solocaja = LineInput(f)
                .almacen = LineInput(f)
                x = LineInput(f)
                .margen = LineInput(f)
                .puedeAutorizar = LineInput(f)
                .impresora_ticket = LineInput(f)
                .impresora_factura = LineInput(f)
                .Impresora_reportes = LineInput(f)
                .sqlserver = LineInput(f)
                .Cobrar_tarjeta = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                .sqlsat = LineInput(f)
            End With
            FileClose(f)
        Catch ex As Exception
            FileClose(f)
        End Try
        Try
            Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
            Dim logofile As String = adap.path(8).ToString
            rptlogo = New Microsoft.Reporting.WinForms.ReportParameter("logo", logofile, True)
        Catch ex As Exception
            My.Forms.configuracion.ShowDialog()
            Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
            Dim logofile As String = adap.path(8).ToString
            rptlogo = New Microsoft.Reporting.WinForms.ReportParameter("logo", logofile, True)
        End Try

        tool1.Text = user.id.ToString + ".-" + user.nombre
        If My.Settings.solocaja = True Then cargar_caja()
        'Carga Datos Generales
        '==============================================================================================

        Dim g As New admintegralDataSetTableAdapters.GeneralesTableAdapter
        Dim drc As DataRow
        drc = g.GetData.Rows(0)
        cia.nombre = drc.Item("Nombre").ToString
        cia.direccion = drc.Item("Direccion").ToString
        cia.ciudad = drc.Item("ciudad").ToString
        cia.Edo = drc.Item("Edo").ToString
        cia.CP = drc.Item("CP").ToString
        cia.rfc = drc.Item("RFC").ToString
        cia.comidebito = 1 + (drc.Item("comision_debito") / 100)
        cia.comicredito = 1 + (drc.Item("comision_credito") / 100)
        cia.tienda = CInt(drc.Item("tienda").ToString)
        cia.aviso = drc.Item("Aviso").ToString
        cia.dias_posfechado = drc.Item("dias_posfechado")
        My.Settings.tipodecambio = drc.Item("tipodecambio")
        g.Dispose()
        define_menu()
        If user.id = 1 Then boton_sistemas.Visible = True
        esterminal = My.Settings.terminal  ' deermina si es terminal (Sucursal)
        Dim db As String = Mid(My.Settings.AdmintegralConnectionString, 1, InStr(My.Settings.AdmintegralConnectionString.ToString, ";"))
        If InStr(db, "ABARROTERA") > 0 Then esterminal = False
        If esterminal = False Then
            Me.Text = "Sistema de Administracion Integral -" + cia.nombre + " " + Format(Now.Date, "d")
        Else
            Me.Text = "Sucursal - " + cia.nombre + " " + Format(Now.Date, "d")
            Dim adap As New admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
            cia.direccion_sucursal = adap.GetDataByid(My.Settings.almacen).Rows(0).Item("direccion")
        End If
        Me.boton_exportar.Enabled = esterminal
        cargar_catalogo()


        If My.Settings.terminal = False Then
            'determina si ya se corrieron las consultas
            Dim cjadap As New admintegralDataSetTableAdapters.log_cajasTableAdapter

            If cjadap.GetDataBycaja_fecha(0, CDate(Now.Date)).Rows.Count < 1 Then
                cjadap.Insert(0, Now.Date, Now, user.id, Now, 0, 0, 0, False, 0, "")
            End If
        End If
        actualizar_existencia()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub ' load y login

    Private Sub DepartamentosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_cat_deptos.MdiParent = Me
        My.Forms.frm_cat_deptos.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub ' Catalogo de Deptos

    Private Sub GruposToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposToolStripMenuItem1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_cat_grupos.MdiParent = Me
        My.Forms.frm_cat_grupos.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'catalogo de grupos

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click, ttb_productos.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_productos.Show()
        My.Forms.frm_productos.WindowState = FormWindowState.Maximized
        'Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'catalogo de productos

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        My.Forms.Frm_About.ShowDialog()
    End Sub 'About

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click, ttb_proveedores.Click
        My.Forms.frm_cat_provedores.MdiParent = Me
        My.Forms.frm_cat_provedores.tipo_catalogo = 1
        My.Forms.frm_cat_provedores.Show()
        My.Forms.frm_cat_provedores.TabControl1.SelectedIndex = 0
    End Sub ' catalogo de proveedores

    Private Sub ClientesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem2.Click, ttb_clientes.Click, CatalogoToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_cat_provedores.MdiParent = Me
        My.Forms.frm_cat_provedores.tipo_catalogo = 2
        My.Forms.frm_cat_provedores.Show()
        My.Forms.frm_cat_provedores.TabControl1.SelectedIndex = 0
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'catalogo de Clientes


    Private Sub ListasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListasToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_listas.MdiParent = Me
        My.Forms.frm_listas.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub ' Listas

    Private Sub CajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_cajas.MdiParent = Me
        My.Forms.frm_cajas.StartPosition = FormStartPosition.CenterScreen
        My.Forms.frm_cajas.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'catalogo de cajas

    Private Sub AgentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentesToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_agentes.MdiParent = Me
        My.Forms.frm_agentes.StartPosition = FormStartPosition.CenterScreen
        My.Forms.frm_agentes.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'catalogo de agentes

    Private Sub ttb_pedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttb_pedidos.Click, PedidosToolStripMenuItem1.Click
        My.Forms.Pedidos_Relacion.MdiParent = Me
        My.Forms.Pedidos_Relacion.Show()
    End Sub ' relacion de pedidos

    Private Sub ttb_Entradas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttb_Entradas.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.Entrada_nueva.MdiParent = Me
        My.Forms.Entrada_nueva.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'Entradas

    Private Sub ttb_devoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttb_devoluciones.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        '  My.Forms.devolucion_nueva.MdiParent = Me
        My.Forms.devolucion_nueva.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'relacion de devolcuiones

    Private Sub apagarmenu()
        For j As Integer = 0 To Me.MenuStrip.Items.Count - 1
            Me.MenuStrip.Items(j).Visible = False
        Next
    End Sub

    Private Sub cargar_caja()
        Dim adap As New admintegralDataSetTableAdapters.log_cajasTableAdapter
        Try
            Dim dr1 As DataRow
            dr1 = adap.GetDataBycaja_fecha(My.Settings.ncaja, CDate(Now.Date)).Rows(0)
            If dr1("cerrada") = True Then My.Forms.caja_corte.Show() : Exit Sub
        Catch ex As Exception
        End Try
        cargar_catalogo()
        Me.MenuStrip.Visible = False
        Me.barra_menu1.Visible = False
        My.Forms.caja.MdiParent = Me
        My.Forms.caja.Show()
    End Sub 'Abrir Caja

    Private Sub CajasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajasToolStripMenuItem.Click
        My.Forms.frm_cajas.MdiParent = Me
        My.Forms.frm_cajas.Show()
    End Sub

    Private Sub ConfigurarEstacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurarEstacionToolStripMenuItem.Click
        My.Forms.configuracion.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cerrar.Click
        End
    End Sub

    Private Sub RelacionDeCobranzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelacionDeCobranzaToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.cxc_relaciones.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub RegistroDeCobranzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeCobranzaToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.cxc_liquidaciones.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub tbb_nuevo_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbb_nuevo_producto.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_new_producto.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ReporteDeCobranzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeCobranzaToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.cxc_reportes.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub boton_cxc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cxc.Click, SaldosToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.cxc.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ChequesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequesToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.cxc_relacion_Cheques.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub boton_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_exportar.Click
        My.Forms.Exportar_Informacion.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttb_cotizaciones.Click
        My.Forms.cotizacion_relacion.Show()
    End Sub


    Private Sub define_menu()
        Dim cmd As String
        cmd = "SELECT   id_user, nivel, opcion, valor FROM tbl_menus " _
        & "WHERE id_user = " + user.id.ToString
        Dim tbl As DataTable = leer_tabla(cmd)
        Dim op(0 To 15, 0 To 20) As Boolean
        Dim x, y, j As Integer

        For j = 0 To tbl.Rows.Count - 1
            x = tbl.Rows(j).Item(1)
            y = tbl.Rows(j).Item(2)
            op(x, y) = tbl.Rows(j).Item(3)
        Next
        For j = 0 To 6
            Me.MenuStrip.Items(j).Enabled = op(j, 0)
        Next j
        If op(11, 0) = True Then My.Forms.Autorizaciones.Show()
        Me.EntradasToolStripMenuItem1.Visible = False
        Me.ProductosToolStripMenuItem1.Visible = False
        Me.PendientesToolStripMenuItem.Visible = False
        If op(10, 0) = True Then
            Me.PendientesToolStripMenuItem.Visible = True
            monitorear() ' verifica si hay entradas o productos pendiente 
        End If
        boton_cxc.Enabled = op(11, 0)
    End Sub

    Private Sub monitorear()
        Dim cmd As String
        cmd = "SELECT Documentos.Folio from documentos  WHERE  Documentos.td = 12 and Documentos.status=0"
        Dim tmptbl As DataTable = leer_tabla(cmd)
        If tmptbl.Rows.Count > 0 Then
            Me.EntradasToolStripMenuItem1.Visible = True
        End If
        cmd = "select * from tmp_productos"
        tmptbl = leer_tabla(cmd)
        If tmptbl.Rows.Count > 0 Then
            Me.ProductosToolStripMenuItem1.Visible = True
        End If
    End Sub ' Monitoreo de documento externos

    Private Sub PermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosToolStripMenuItem.Click
        My.Forms.usuarios.Show()
    End Sub

    Private Sub CXCToolStripMenuItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CXCToolStripMenuItem.EnabledChanged
        Me.boton_cxc.Enabled = Me.CXCToolStripMenuItem.Enabled
    End Sub

    Private Sub CatalogosToolStripMenuItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogosToolStripMenuItem.EnabledChanged
        Dim b As Boolean = Not Me.CajasToolStripMenuItem.Enabled
        Me.tbb_nuevo_producto.Enabled = b
        Me.ttb_productos.Enabled = b
        Me.ttb_clientes.Enabled = b
        Me.ttb_proveedores.Enabled = b
    End Sub

    Private Sub AlmacenesToolStripMenuItem1_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacenesToolStripMenuItem1.EnabledChanged
        Dim b As Boolean = Not Me.CajasToolStripMenuItem.Enabled
        Me.ttb_pedidos.Enabled = b
        Me.ttb_Entradas.Enabled = b
        Me.ttb_devoluciones.Enabled = b
        Me.boton_traspaso.Enabled = b
    End Sub

    Private Sub VentasToolStripMenuItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.EnabledChanged
        Dim b As Boolean = Me.VentasToolStripMenuItem.Enabled
        Me.ttb_caja.Enabled = b
        Me.ttb_ncredito.Enabled = b
        Me.ttb_cotizaciones.Enabled = b
    End Sub


    Private Sub NcreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NcreditoToolStripMenuItem.Click
        My.Forms.ncredito_relacion.Show()
    End Sub

    Private Sub CajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem.Click, ttb_caja.Click
        cargar_caja()
    End Sub

    Private Sub ModuloContableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloContableToolStripMenuItem.Click, ModuloContableToolStripMenuItem1.Click
        My.Forms.reportes_contables.Show()
    End Sub

    Private Sub ToolStripMenuItem1_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.EnabledChanged
        Me.ttb_contabilidad.Enabled = Me.ToolStripMenuItem1.Enabled
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        My.Forms.Consultas.Show()
    End Sub ' abre forma de consultas test

    Private Sub ExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasToolStripMenuItem.Click
        My.Forms.Inventarios_captura.Show()
    End Sub

    Private Sub KardexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KardexToolStripMenuItem.Click
        My.Forms.Kardex.Show()
    End Sub

    Private Sub CancelarFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarFacturaToolStripMenuItem.Click
        My.Forms.CG_cancelar_factura.Show()
    End Sub

    Private Sub AbrirCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirCajaToolStripMenuItem.Click, boton_caja_general.Click, CortesDeCajaToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.contable_abrircaja.ShowDialog()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub CajaEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaEntradasToolStripMenuItem.Click
        My.Forms.caja_entradas.Show()
    End Sub

    Private Sub VerUnDocumentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerUnDocumentoToolStripMenuItem.Click, VerUnDocumentoToolStripMenuItem1.Click
        My.Forms.pedir_documento.ShowDialog()
        My.Forms.Consultar_una_factura.Show()
        My.Forms.Consultar_una_factura.Focus()
    End Sub

    Private Sub EntradasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem1.Click
        My.Forms.Entrada_nueva.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.frm_productos.Show()
        My.Forms.frm_productos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        My.Forms.AboutBox1.ShowDialog()
    End Sub

    Private Sub boton_traspaso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_traspaso.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.traspasos.Show()
        My.Forms.traspasos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CajaGeneralToolStripMenuItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaGeneralToolStripMenuItem.EnabledChanged
        Me.boton_caja_general.Enabled = CajaGeneralToolStripMenuItem.Enabled
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_importar.Click
        My.Forms.Importar_informacion.Show()
    End Sub

    Private Sub boton_exportar_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_exportar.EnabledChanged
        Me.boton_importar.Enabled = boton_exportar.Enabled
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.Devolucion_relacion.Show()
        My.Forms.Devolucion_relacion.WindowState = FormWindowState.Maximized
    End Sub

  
    Private Sub PermisosEspecialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosEspecialesToolStripMenuItem.Click
        funciones.Show()
    End Sub

    Private Sub DiarioDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiarioDeVentasToolStripMenuItem.Click
        My.Forms.diario_ventas.Show()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.Entradas_relacion.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ttb_ncredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttb_ncredito.Click
        My.Forms.caja.tipo_venta = 7
        My.Forms.caja.Show()
    End Sub ' detalle de notas de credito

    Private Sub boton_Kardex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Kardex.Click
        My.Forms.Citas.Show()
    End Sub

    Private Sub ReporteExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteExistenciasToolStripMenuItem.Click
        My.Forms.Existencias_reporte.Show()
    End Sub

    Private Sub EtiquetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetasToolStripMenuItem.Click
        My.Forms.catalogo_y_etiquetas.Show()
    End Sub

    
   

    Private Sub RelacionDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelacionDeFacturasToolStripMenuItem.Click
        My.Forms.diario_ventas.Show()
    End Sub


    Private Sub CambioDePrecioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDePrecioToolStripMenuItem.Click
        My.Forms.cambio_de_precios.Show()
    End Sub

   

    Private Sub ImportarInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarInventarioToolStripMenuItem.Click
        My.Forms.Inventario_Importar.Show()
    End Sub

    Private Sub VtasXDiaXTiendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VtasXDiaXTiendaToolStripMenuItem.Click
        My.Forms.est_ventas_x_dia_tda.Show()
    End Sub

    Private Sub ttb_pedidos_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttb_pedidos.EnabledChanged
        Me.boton_estadistica.Enabled = ttb_pedidos.Enabled
        Me.boton_Kardex.Enabled = ttb_pedidos.Enabled
    End Sub

    
    Private Sub ToolStripButton2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        My.Forms.agentes_pedidos.Show()
    End Sub

    Private Sub MiKardexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiKardexToolStripMenuItem.Click
        My.Forms.Kardex_resumen.caragr(1109)
        My.Forms.Kardex_resumen.Show()
    End Sub

  


    Private Sub CobranzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobranzaToolStripMenuItem.Click
        My.Forms.Estadistica_de_cobranza.Show()

    End Sub

    Private Sub ListaDeEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeEntradasToolStripMenuItem.Click
        My.Forms.lista_de_entradas.Show()
    End Sub

    Private Sub LIstaDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIstaDePreciosToolStripMenuItem.Click
        My.Forms.catalogos.Show()
    End Sub

    Private Sub ResumDeCobranzaXDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumDeCobranzaXDiaToolStripMenuItem.Click
        My.Forms.cxc_resumen_diario.Show()
    End Sub

    Private Sub AbrirCajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirCajaToolStripMenuItem1.Click
        My.Forms.caja.abrir_cajon()
    End Sub

    Private Sub CotizacionEspecialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionEspecialToolStripMenuItem.Click
        My.Forms.cotizaciones.Show()
        My.Forms.cotizaciones.especial()
    End Sub


 

    Private Sub ReporteDeExistenciasGlobalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeExistenciasGlobalToolStripMenuItem.Click
        My.Forms.inventario_global.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        My.Forms.poliza_compras.Show()
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresosToolStripMenuItem.Click
        My.Forms.Poliza_ingresos.Show()
    End Sub

    Private Sub RespaldarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RespaldarToolStripMenuItem.Click
        Dim cmd As String
        cmd = "BACKUP DATABASE [integra] TO  DISK = N'C:\Tmp\integra_espo.bak' WITH NOFORMAT, NOINIT,  NAME = N'integra-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        MsgBox("Respaldo " + comando(cmd).ToString)
    End Sub

    Private Sub UtilidadXTiendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilidadXTiendaToolStripMenuItem.Click
        My.Forms.Margenes_por_tienda.Show()
    End Sub

    Private Sub ProductosSinMvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosSinMvToolStripMenuItem.Click
        My.Forms.Productos_sin_movimiento.Show()
    End Sub

   

    Private Sub actualizar_base()
        Dim cmd As String = "ALTER TABLE dbo.cajas ADD	fei_serie nchar(3) NULL"
        comando(cmd) 'agrega el campo de fei_serie cajas

    End Sub

  



    Private Sub SugerenciaDeSurtidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SugerenciaDeSurtidosToolStripMenuItem.Click
        My.Forms.surtido_sugerido.Show()
        My.Forms.surtido_sugerido.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CreraExistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreraExistenciaToolStripMenuItem.Click
        actualizar_existencia()
    End Sub

    Private Sub VerFoliosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerFoliosToolStripMenuItem.Click
        My.Forms.ver_folios.Show()
    End Sub

    Private Sub VentasVsRecuperacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasVsRecuperacionToolStripMenuItem.Click
        My.Forms.estadistica_agentes.Show()
    End Sub


    Private Sub RegistroInicialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroInicialToolStripMenuItem.Click
        My.Forms.cargar_cxp_inicial.Show()
    End Sub

    Private Sub NotasDeCargoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasDeCargoToolStripMenuItem2.Click
        my.Forms.Ncargo.Show()
    End Sub

    Private Sub RegistrarPagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarPagosToolStripMenuItem.Click
        My.Forms.cxp_pagos.Show()
    End Sub

    Private Sub AntiguedadDeSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AntiguedadDeSaldosToolStripMenuItem.Click
       
    End Sub

    Private Sub CompletoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompletoToolStripMenuItem.Click
        My.Forms.cxp_antiguedad.completo()
        My.Forms.cxp_antiguedad.Show()
    End Sub

    Private Sub UnProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnProveedorToolStripMenuItem.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        My.Forms.cxp_antiguedad.un_proveedor(gprov.id)
        My.Forms.cxp_antiguedad.Show()
    End Sub

    Private Sub ReporteVentasExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteVentasExistenciasToolStripMenuItem.Click
        My.Forms.reporte_ventas_existencia.Show()
    End Sub

    

    Private Sub PAQUETESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAQUETESToolStripMenuItem.Click
        My.Forms.paquetes.Show()
    End Sub

    Private Sub SeleccionarProductosASepararToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarProductosASepararToolStripMenuItem.Click
        My.Forms.separar_productos.Show()
    End Sub

    
    Private Sub TestToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles TestToolStripMenuItem2.Click
        My.Forms.factura_global.Show()
    End Sub

    Private Sub DatosDelEmisorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatosDelEmisorToolStripMenuItem.Click
        My.Forms.Emisor.ShowDialog()
    End Sub

  
    Private Sub VerBitacoraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerBitacoraToolStripMenuItem.Click
        Dim file As String = "c:\tmp\logfile" + Now.Month.ToString + ".txt"
        Try
            Process.Start(file)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CatalogoSatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoSatToolStripMenuItem.Click
        My.Forms.CATALOGOS_SAT.Show()
    End Sub

    Private Sub CadenaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CadenaToolStripMenuItem.Click
        MsgBox(My.Settings.SAT_catalogosConnectionString.ToString)
    End Sub

    Private Sub ReporteDeExistenciasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteDeExistenciasToolStripMenuItem.Click
        My.Forms.Existencias_reporte.Show()
    End Sub

    Private Sub InventarioFisicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioFisicoToolStripMenuItem.Click
        My.Forms.Inventario_Importar.Show()
    End Sub

    Private Sub CierreDeMesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CierreDeMesToolStripMenuItem.Click
        Dim frm As New cierre_de_mes
        frm.ShowDialog()
    End Sub

    Private Sub InventarioAleatorioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioAleatorioToolStripMenuItem.Click
        Dim frm As New Inventario_aleatorio
        frm.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
End Class
