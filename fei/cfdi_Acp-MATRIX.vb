Imports TimbradoAcp
Imports System.IO
Imports System.Linq
Imports System.Xml
Imports System.Xml.Serialization
Imports Microsoft.Win32

Public Class cfdi_Acp
    Dim ds As New DataSet
    Dim dstimbre As New DataSet
    Dim local As Boolean = False
    Dim txtQRCode As String
    Dim CadenaOriginalTimbre As String
    Dim rutaXml As String
    Dim para As String

    Public Sub genera(ByVal td As Integer, ByVal serie As String, ByVal folio As Single, ByVal fcaja As Integer)
        Dim cmd As String
        cmd = "select * from cfdi_factura33 where td=" + td.ToString + " and serie='" + serie.ToString + "' and folio=" + folio.ToString
        Dim tbl As DataTable = leer_tabla(cmd)

        If tbl.Rows.Count < 1 Then
            MsgBox("No se encontro en fei_factura " + td.ToString + " serie " + serie.ToString + " Folio " + folio.ToString)
            Exit Sub
        End If

        Fei_facturaBindingSource.DataSource = tbl
        Dim subtotal As Decimal, total As Decimal

        'lee datos del emisor
        Dim DT As DataRow = lee_emisor()
        'leer serie
        Dim acajas As New admintegralDataSetTableAdapters.cajasTableAdapter
        Dim fei_serie As String = Trim(acajas.GetDataBy(fcaja).Rows(0).Item("fei_serie"))
        Dim fei_folio As String = siguiente_folio(fei_serie)

        'inicia generacion de CFD
        Dim afolios As New feiDatasetTableAdapters.fei_foliosTableAdapter ' pedir autorizacion y año
        Dim aemisor As New feiDatasetTableAdapters.emisorTableAdapter
        '=================================================================
        '  Datos de la factura Encabezado                                |
        '=================================================================

        bitacora("Inicia comprobante")
        Dim comp As New Comprobante()

        comp.Version = "3.3"
        comp.Serie = fnn(fei_serie)
        comp.Folio = fnn(fei_folio)
        comp.Fecha = DateTime.Now
        comp.Sello = ""
        comp.NoCertificado = ""
        comp.Certificado = ""

        comp.Moneda = "MXN"

        comp.SubTotal = formato_sat(subtotal) 'subtotal
        comp.Total = formato_sat(tbl.Rows(0).Item("f_total"))

        comp.TipoDeComprobante = "I"
        comp.MetodoPago = tbl.Rows(0).Item("metodo") ' catalogo 

        comp.FormaPago = tbl.Rows(0).Item("forma") 'catalogo biene como parametros


        comp.CondicionesDePago = "Contado"
        comp.Descuento = "0.00" ' Math.Round(Convert.ToDecimal(0), 2) ' Descuento
        comp.TipoCambio = Convert.ToDecimal(1)
        comp.LugarExpedicion = DT.Item("codigopostal")

        bitacora("INICIA EMISOR")

        ' Agregar Datos Emisor
        '==================================================================================================
        Dim dr_emisor As DataRow
        dr_emisor = aemisor.Getemisor.Rows(0)

        Dim emisor As New ComprobanteEmisor
        emisor.Rfc = fnn(dr_emisor.Item("RFC"))
        emisor.Nombre = fnn(dr_emisor.Item("Nombre"))
        emisor.RegimenFiscal = "601"
        comp.Emisor = emisor

        bitacora("inicia receptor")
        'datos de receptor
        ' RECEPTOR
        '===================================================================================
        Dim receptor As New ComprobanteReceptor
        receptor.Rfc = fnn(tbl.Rows(0).Item("rfc"))
        receptor.Nombre = tbl.Rows(0).Item("Nombre")
        receptor.UsoCFDI = tbl.Rows(0).Item("uso")
        para = tbl.Rows(0).Item("email")
        comp.Receptor = receptor


        '====================================================================
        ' CONCEPTOS                                                         |
        '====================================================================

        Dim listaConceptos As New List(Of ComprobanteConcepto)

        Dim Timp_trasladado_iva As Decimal
        Dim timp_traslado_ieps As Decimal
        bitacora("Inicia conceptos")

        For j As Integer = 0 To tbl.Rows.Count - 1

            If tbl.Rows(j).Item("cantidad") > 0 Then
                ' Creamos un objeto de tipo ComprobanteConcepto
                Dim concepto As New ComprobanteConcepto
                concepto.ClaveProdServ = tbl.Rows(j).Item("codigo_sat")
                concepto.ClaveUnidad = tbl.Rows(0).Item("unidad_sat")
                concepto.Cantidad = Convert.ToDecimal(tbl.Rows(j).Item("cantidad"))
                concepto.Unidad = fnn(tbl.Rows(j).Item("unidad"))
                concepto.Descuento = formato_sat(0)
                concepto.NoIdentificacion = tbl.Rows(j).Item("id_prodcuto")
                concepto.Descripcion = fnn(tbl.Rows(j).Item("Descripcion")).Replace("  ", " ")
                concepto.ValorUnitario = formato_sat(Convert.ToDecimal(fnn(tbl.Rows(j).Item("venta"))))
                concepto.Importe = formato_sat(Convert.ToDecimal(tbl.Rows(j).Item("cantidad") * tbl.Rows(j).Item("venta")))
                subtotal += concepto.Importe

                Dim oImpuestosConcepto1 As New ComprobanteConceptoImpuestos()
                Dim listaTrasladosConcepto1 As New List(Of ComprobanteConceptoImpuestosTraslado)
                If tbl.Rows(j).Item("iva") > 0 Then
                    Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()
                    'Agregar Impuesto al concepto IVA
                    '====================================
                    oTraslado1Concepto1.Base = formato_sat(Convert.ToDecimal(concepto.Importe))
                    oTraslado1Concepto1.Impuesto = "002" ' IVA CATALOGO
                    oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                    oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0.16)
                    oTraslado1Concepto1.Importe = formato_sat(Convert.ToDecimal(tbl.Rows(j).Item("iva")))
                    listaTrasladosConcepto1.Add(oTraslado1Concepto1)
                    Timp_trasladado_iva += Math.Round(Convert.ToDecimal(tbl.Rows(j).Item("iva")), 2)

                Else
                    Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()

                    'Agregar tasa 0
                    '====================================
                    oTraslado1Concepto1.Base = formato_sat(Convert.ToDecimal(concepto.Importe))
                    oTraslado1Concepto1.Impuesto = "002" ' IVA CATALOGO
                    oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                    oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0)
                    oTraslado1Concepto1.Importe = "0.00"
                    listaTrasladosConcepto1.Add(oTraslado1Concepto1)


                End If

                If tbl.Rows(j).Item("Vta_ieps") > 0 Then
                    Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()

                    'Agregar Impuesto al concepto IVA
                    '====================================

                    oTraslado1Concepto1.Base = Math.Round(Convert.ToDecimal(concepto.Importe), 2)
                    oTraslado1Concepto1.Impuesto = "003" ' IVA CATALOGO
                    oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                    oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0.08)
                    oTraslado1Concepto1.Importe = formato_sat(Convert.ToDecimal(tbl.Rows(j).Item("Vta_ieps")))
                    listaTrasladosConcepto1.Add(oTraslado1Concepto1)
                    timp_traslado_ieps += formato_sat(Convert.ToDecimal(tbl.Rows(j).Item("Vta_ieps")))
                End If
                oImpuestosConcepto1.Traslados = listaTrasladosConcepto1.ToArray()
                concepto.Impuestos = oImpuestosConcepto1
                listaConceptos.Add(concepto)
            End If
        Next
        bitacora("termina conceptos")
        comp.Conceptos = listaConceptos.ToArray()

        '===========================================================================================================================

        'impuestode del documento
        Dim impuestos As New ComprobanteImpuestos
        impuestos.TotalImpuestosRetenidos = "0.00"
        impuestos.TotalImpuestosTrasladados = formato_sat(Convert.ToDecimal(Timp_trasladado_iva + timp_traslado_ieps))

        Dim listaTraslados As New List(Of ComprobanteImpuestosTraslado)
        If impuestos.TotalImpuestosTrasladados > 0 Then
            'trasldos del documento
            If Timp_trasladado_iva > 0 Then
                Dim traslado1 As New ComprobanteImpuestosTraslado
                traslado1.Impuesto = "002" 'iva catalogo
                traslado1.TipoFactor = "Tasa"
                traslado1.TasaOCuota = Convert.ToDecimal(0.16)
                traslado1.Importe = formato_sat(Convert.ToDecimal(Timp_trasladado_iva))
                listaTraslados.Add(traslado1)
            End If

            If timp_traslado_ieps > 0 Then
                Dim traslado2 As New ComprobanteImpuestosTraslado
                traslado2.Impuesto = "003" 'IEPS catalogo
                traslado2.TipoFactor = "Tasa"
                traslado2.TasaOCuota = Convert.ToDecimal(0.08)
                traslado2.Importe = formato_sat(Convert.ToDecimal(timp_traslado_ieps))
                listaTraslados.Add(traslado2)
            End If
        Else
            Dim traslado1 As New ComprobanteImpuestosTraslado
            traslado1.Impuesto = "002" 'iva catalogo
            traslado1.TipoFactor = "Tasa"
            traslado1.TasaOCuota = Convert.ToDecimal(0)
            traslado1.Importe = Convert.ToDecimal(0)
            listaTraslados.Add(traslado1)

        End If
        impuestos.Traslados = listaTraslados.ToArray()

        comp.Impuestos = impuestos
        comp.SubTotal = formato_sat(subtotal)
        comp.Total = formato_sat(subtotal + comp.Impuestos.TotalImpuestosTrasladados)

        bitacora("manda a timbrar")

        ' Dim respuesta = New TimbraCFDI("http://gw1.acpdelsureste.net/productos/cfdi.php?wsdl").timbraCFDI(comp, "usuario_demo33", "usuario_demo33")
        Dim respuesta = New TimbraCFDI("http://gw1.acpdelsureste.net/productos/cfdi.php?wsdl").timbraCFDI(comp, dr_emisor.Item("certificado"), dr_emisor.Item("llaveprivada"))
        bitacora("Regresa_timbrar")

        Dim xml As String = respuesta(0) 'obtiene archivo XML
        Dim pdf64 As String = respuesta(1) ' Obtiene PDF
        Dim mensaje As String = respuesta(2) 'Obtiene Respuesta
        Dim codigo As String = respuesta(3) ' obtiene codigo 
        bitacora("Recupero respuesta")
        If codigo <> 200 Then
            MsgBox(codigo + " / " + mensaje)
        End If

        Dim archivoxml, archivopdf As String
        archivoxml = dr_emisor.Item("rutaarchivodigital") + "\cfdi33_" + comp.Serie + folio.ToString + ".xml"
        archivopdf = dr_emisor.Item("rutaarchivodigital") + "\cfdi33_" + comp.Serie + folio.ToString + ".pdf"

        'GUARDA LOS ARCHVIOS
        My.Computer.FileSystem.WriteAllText(archivoxml, respuesta(0), False)
        Base64Decode(pdf64, archivopdf)
        bitacora("Guardo Archivo")


        'Genera Registro del CFD en la base de datos
        Dim acfd As New feiDatasetTableAdapters.fei_cfdTableAdapter
        Dim f As Nullable(Of Date)

        With comp
            Try
                acfd.Insert(.Serie, .Folio, "-", "-", .Fecha, .TipoDeComprobante, 0, f, comp.Receptor.Rfc, comp.Receptor.Nombre, td, .Folio, .Serie, CDbl(comp.Total), CDbl(.Impuestos.TotalImpuestosTrasladados), "0", archivoxml, "", comp.FormaPago, comp.CondicionesDePago, comp.MetodoPago, " ", " ")
            Catch ex As Exception
                MsgBox("Error al Generar el Registro, " + cr + ex.Message, MsgBoxStyle.Exclamation, "iNSERTAR REGISTRO")
                bitacora("Error al generar CFD " + comp.Folio.ToString + comp.Serie.ToString + Microsoft.VisualBasic.Chr(13) + ex.Message.ToString)
            End Try

        End With

        'MANDAR CORREO
        smtp = buzon()
        mandar_correo(para, cia.nombre + " CFDI seire " + comp.Serie + " Folio " + comp.Folio, "Anexamos archivos de comprobante fiscal Digital", archivopdf, archivoxml)
        MsgBox("Correo enviado")

        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Quiere ver el PDF "
        msgtitulo = "VER PDF"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.Yes Then
            Process.Start(archivopdf)
        End If

    End Sub



    Public Sub genera_nc(ByVal td As Integer, ByVal serie As String, ByVal folio As Single, ByVal fcaja As Integer)
        Dim cmd As String
        cmd = "select * from cfdi_factura33 where td=" + td.ToString + " and serie='" + serie.ToString + "' and folio=" + folio.ToString
        Dim tbl As DataTable = leer_tabla(cmd)

        If tbl.Rows.Count < 1 Then
            MsgBox("No se encontro en fei_factura " + td.ToString + " serie " + serie.ToString + " Folio " + folio.ToString)
            Exit Sub
        End If

        Fei_facturaBindingSource.DataSource = tbl
        Dim subtotal As Decimal, total As Decimal

        'lee datos del emisor
        Dim DT As DataRow = lee_emisor()
        'leer serie
        Dim acajas As New admintegralDataSetTableAdapters.cajasTableAdapter
        Dim fei_serie As String = Trim(acajas.GetDataBy(fcaja).Rows(0).Item("fei_serie"))
        Dim fei_folio As String = siguiente_folio(fei_serie)

        'inicia generacion de CFD
        Dim afolios As New feiDatasetTableAdapters.fei_foliosTableAdapter ' pedir autorizacion y año
        Dim aemisor As New feiDatasetTableAdapters.emisorTableAdapter
        '=================================================================
        '  Datos de la factura Encabezado                                |
        '=================================================================

        bitacora("Inicia comprobante")
        Dim comp As New Comprobante()

        comp.Version = "3.3"
        comp.Serie = "NC" 'fnn(fei_serie)
        comp.Folio = folio ' fnn(fei_folio)
        comp.Fecha = DateTime.Now
        comp.Sello = ""
        comp.NoCertificado = ""
        comp.Certificado = ""

        comp.Moneda = "MXN"

        comp.SubTotal = formato_sat(subtotal) 'subtotal
        comp.Total = formato_sat(tbl.Rows(0).Item("f_total"))

        comp.TipoDeComprobante = "E"
        comp.MetodoPago = tbl.Rows(0).Item("metodo") ' catalogo 

        comp.FormaPago = tbl.Rows(0).Item("forma") 'catalogo biene como parametros


        comp.CondicionesDePago = "Contado"
        comp.Descuento = "0.00" ' Math.Round(Convert.ToDecimal(0), 2) ' Descuento
        comp.TipoCambio = Convert.ToDecimal(1)
        comp.LugarExpedicion = DT.Item("codigopostal")

        bitacora("INICIA EMISOR")

        ' Agregar Datos Emisor
        '==================================================================================================
        Dim dr_emisor As DataRow
        dr_emisor = aemisor.Getemisor.Rows(0)

        Dim emisor As New ComprobanteEmisor
        emisor.Rfc = fnn(dr_emisor.Item("RFC"))
        emisor.Nombre = fnn(dr_emisor.Item("Nombre"))
        emisor.RegimenFiscal = "601"
        comp.Emisor = emisor

        bitacora("inicia receptor")
        'datos de receptor
        ' RECEPTOR
        '===================================================================================
        Dim receptor As New ComprobanteReceptor
        receptor.Rfc = tbl.Rows(0).Item("rfc")
        receptor.Nombre = tbl.Rows(0).Item("Nombre")
        receptor.UsoCFDI = tbl.Rows(0).Item("uso")
        para = tbl.Rows(0).Item("email")
        comp.Receptor = receptor


        '====================================================================
        ' CONCEPTOS                                                         |
        '====================================================================

        Dim listaConceptos As New List(Of ComprobanteConcepto)

        Dim Timp_trasladado_iva As Decimal
        Dim timp_traslado_ieps As Decimal
        bitacora("Inicia conceptos")
        Dim tiene_tasa0 As Boolean

        For j As Integer = 0 To tbl.Rows.Count - 1

            If tbl.Rows(j).Item("cantidad") > 0 Then
                ' Creamos un objeto de tipo ComprobanteConcepto
                Dim concepto As New ComprobanteConcepto
                concepto.ClaveProdServ = tbl.Rows(j).Item("codigo_sat")
                concepto.ClaveUnidad = tbl.Rows(0).Item("unidad_sat")
                concepto.Cantidad = Convert.ToDecimal(tbl.Rows(j).Item("cantidad"))
                concepto.Unidad = fnn(tbl.Rows(j).Item("unidad"))
                concepto.NoIdentificacion = tbl.Rows(j).Item("id_prodcuto")
                concepto.Descripcion = fnn(tbl.Rows(j).Item("Descripcion")).Replace("  ", " ")
                concepto.ValorUnitario = Convert.ToDecimal(fnn(tbl.Rows(j).Item("venta")))
                concepto.Importe = Convert.ToDecimal(tbl.Rows(j).Item("cantidad") * tbl.Rows(j).Item("venta"))
                subtotal += concepto.Importe

                Dim oImpuestosConcepto1 As New ComprobanteConceptoImpuestos()

                Dim listaTrasladosConcepto1 As New List(Of ComprobanteConceptoImpuestosTraslado)

                If tbl.Rows(j).Item("iva") > 0 Then

                    Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()

                    'Agregar Impuesto al concepto IVA
                    '====================================
                    oTraslado1Concepto1.Base = Math.Round(Convert.ToDecimal(concepto.Importe), 2)
                    oTraslado1Concepto1.Impuesto = "002" ' IVA CATALOGO
                    oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                    oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0.16)
                    oTraslado1Concepto1.Importe = Math.Round(Convert.ToDecimal(tbl.Rows(j).Item("iva")), 2)
                    listaTrasladosConcepto1.Add(oTraslado1Concepto1)

                    Timp_trasladado_iva += Math.Round(Convert.ToDecimal(tbl.Rows(j).Item("iva")), 2)

                Else
                    Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()

                    'Agregar tasa 0
                    '====================================
                    oTraslado1Concepto1.Base = Math.Round(Convert.ToDecimal(concepto.Importe), 2)
                    oTraslado1Concepto1.Impuesto = "002" ' IVA CATALOGO
                    oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                    oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0)
                    oTraslado1Concepto1.Importe = "0.00"
                    listaTrasladosConcepto1.Add(oTraslado1Concepto1)
                    tiene_tasa0 = True

                End If

                If tbl.Rows(j).Item("Vta_ieps") > 0 Then
                    Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()

                    'Agregar Impuesto al concepto IVA
                    '====================================

                    oTraslado1Concepto1.Base = Math.Round(Convert.ToDecimal(concepto.Importe), 2)
                    oTraslado1Concepto1.Impuesto = "003" ' IVA CATALOGO
                    oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                    oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0.08)
                    oTraslado1Concepto1.Importe = Math.Round(Convert.ToDecimal(tbl.Rows(j).Item("Vta_ieps")), 2)
                    listaTrasladosConcepto1.Add(oTraslado1Concepto1)


                    timp_traslado_ieps += Math.Round(Convert.ToDecimal(tbl.Rows(j).Item("Vta_ieps")), 2)
                End If

                oImpuestosConcepto1.Traslados = listaTrasladosConcepto1.ToArray()
                concepto.Impuestos = oImpuestosConcepto1
                listaConceptos.Add(concepto)
            End If
        Next
        bitacora("termina conceptos")
        comp.Conceptos = listaConceptos.ToArray()

        '===========================================================================================================================

        'impuestode del documento
        Dim impuestos As New ComprobanteImpuestos
        impuestos.TotalImpuestosRetenidos = "0.00"
        impuestos.TotalImpuestosTrasladados = formato_sat(Convert.ToDecimal(Timp_trasladado_iva + timp_traslado_ieps))

        'trasldos del documento
        Dim listaTraslados As New List(Of ComprobanteImpuestosTraslado)

        If Timp_trasladado_iva > 0 Then
            Dim traslado1 As New ComprobanteImpuestosTraslado
            traslado1.Impuesto = "002" 'iva catalogo
            traslado1.TipoFactor = "Tasa"
            traslado1.TasaOCuota = Convert.ToDecimal(0.16)
            traslado1.Importe = Math.Round(Convert.ToDecimal(Timp_trasladado_iva), 2)
            listaTraslados.Add(traslado1)
        End If

        If tiene_tasa0 Then
            Dim traslado1 As New ComprobanteImpuestosTraslado
            traslado1.Impuesto = "002" 'iva catalogo
            traslado1.TipoFactor = "Tasa"
            traslado1.TasaOCuota = Convert.ToDecimal(0)
            traslado1.Importe = formato_sat(0)
            listaTraslados.Add(traslado1)
        End If


        If timp_traslado_ieps > 0 Then
            Dim traslado2 As New ComprobanteImpuestosTraslado
            traslado2.Impuesto = "003" 'IEPS catalogo
            traslado2.TipoFactor = "Tasa"
            traslado2.TasaOCuota = Convert.ToDecimal(0.08)
            traslado2.Importe = Math.Round(Convert.ToDecimal(timp_traslado_ieps), 2)
            listaTraslados.Add(traslado2)
        End If
        impuestos.Traslados = listaTraslados.ToArray()

        comp.Impuestos = impuestos

        comp.SubTotal = formato_sat(subtotal)
        comp.Total = formato_sat(subtotal + comp.Impuestos.TotalImpuestosTrasladados)

        bitacora("manda a timbrar")

        ' Dim respuesta = New TimbraCFDI("http://gw1.acpdelsureste.net/productos/cfdi.php?wsdl").timbraCFDI(comp, "usuario_demo33", "usuario_demo33")
        Dim respuesta = New TimbraCFDI("http://gw1.acpdelsureste.net/productos/cfdi.php?wsdl").timbraCFDI(comp, dr_emisor.Item("certificado"), dr_emisor.Item("llaveprivada"))
        bitacora("Regresa_timbrar")

        Dim xml As String = respuesta(0) 'obtiene archivo XML
        Dim pdf64 As String = respuesta(1) ' Obtiene PDF
        Dim mensaje As String = respuesta(2) 'Obtiene Respuesta
        Dim codigo As String = respuesta(3) ' obtiene codigo 
        bitacora("Recupero respuesta")
        If codigo <> 200 Then
            MsgBox(codigo + " / " + mensaje)
        End If

        Dim archivoxml, archivopdf As String
        archivoxml = dr_emisor.Item("rutaarchivodigital") + "\cfdi33_" + comp.Serie + folio.ToString + ".xml"
        archivopdf = dr_emisor.Item("rutaarchivodigital") + "\cfdi33_" + comp.Serie + folio.ToString + ".pdf"

        'GUARDA LOS ARCHVIOS
        My.Computer.FileSystem.WriteAllText(archivoxml, respuesta(0), False)
        Base64Decode(pdf64, archivopdf)
        bitacora("Guardo Archivo")


        'Genera Registro del CFD en la base de datos
        Dim acfd As New feiDatasetTableAdapters.fei_cfdTableAdapter
        Dim f As Nullable(Of Date)

        With comp
            Try
                acfd.Insert(.Serie, .Folio, "", "", .Fecha, .TipoDeComprobante, 0, f, comp.Receptor.Rfc, comp.Receptor.Nombre, td, folio, serie, CDbl(comp.Total), CDbl(.Impuestos.TotalImpuestosTrasladados), "1", archivoxml, comp.NoCertificado, comp.FormaPago, comp.CondicionesDePago, comp.MetodoPago, "", "")
            Catch ex As Exception
                MsgBox("Error al Generar el Registro, " + cr + ex.Message)
                bitacora("Error al generar CFD " + comp.Folio.ToString + comp.Serie.ToString + Microsoft.VisualBasic.Chr(13) + ex.Message.ToString)
            End Try

        End With

        'MANDAR CORREO
        smtp = buzon()
        mandar_correo(para, cia.nombre + " CFDI seire " + comp.Serie + " Folio " + comp.Folio, "Anexamos archivos de comprobante fiscal Digital", archivopdf, archivoxml)
        MsgBox("Correo enviado")

        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Quiere ver el PDF "
        msgtitulo = "VER PDF"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.Yes Then
            Process.Start(archivopdf)
        End If

    End Sub


    Private Sub Base64Decode(ByVal sbase64 As String, ByVal file As String)
        Dim sImagenTemporal As String = file

        Dim fs As FileStream = New FileStream(sImagenTemporal, FileMode.Create)
        Dim bw As BinaryWriter = New BinaryWriter(fs)
        Dim bytes() As Byte

        Try
            bytes = Convert.FromBase64String(sbase64)
            bw.Write(bytes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            fs.Close()
        End Try

    End Sub


End Class