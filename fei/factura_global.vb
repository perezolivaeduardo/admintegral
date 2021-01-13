Imports TimbradoAcp
Imports System.IO
Imports System.Linq
Imports System.Xml
Imports System.Xml.Serialization
Imports Microsoft.Win32

Public Class factura_global
    Dim dsdoc As New DataSet("Facturas")
    Dim tabledoc As DataTable = dsdoc.Tables.Add("tabledoc")
    Dim mytable As DataTable = dsdoc.Tables.Add("mytable")
    Dim mst, miva, mieps, tt, t0, t16 As Single
    Dim ds As New DataSet
    Dim dstimbre As New DataSet
    Dim local As Boolean = False
    Dim txtQRCode As String
    Dim CadenaOriginalTimbre As String
    Dim rutaXml As String



    Public Sub cargar_movimientos(ByVal kfecha As Date)
        Dim sql As String
        sql = "SELECT * from cfdi_global33 where FECHA = CONVERT(DATETIME, '[fecha] 00:00:00', 102) "
        sql = sql.Replace("[fecha]", Format(kfecha, "yyyy-MM-dd"))
        mytable.Clear()
        mytable = leer_tabla(sql)

        Clipboard.SetText(sql)

        If mytable.Rows.Count = 0 Then
            MsgBox("Sin Movimientos")
            Exit Sub

        End If
        dgv.DataSource = mytable

        mst = Format(mytable.Compute("sum(sub)", ""), "N2")
        miva = Format(mytable.Compute("sum(iva)", ""), "N2")
        mieps = Format(mytable.Compute("sum(ieps)", ""), "N2")
        tt = Format(mytable.Compute("sum(tot)", ""), "N2")
        t0 = Format(mytable.Compute("sum(sub)", "piva<1"), "N2")
        Try
            t16 = Format(mytable.Compute("sum(sub)", "piva>0"), "N2")
        Catch ex As Exception

        End Try


        tasa0.Text = Format(t0, "N2")
        tasa16.Text = Format(t16, "n2")


        st.Text = Format(mst, "N2")
        iv.Text = Format(miva, "n2")
        ieps.Text = Format(mieps, "n2")
        total.Text = Format(tt, "n2")

        'determina folios del dia
        sql = "SELECT    MIN(movimientos.folio_doc) AS del, MAX(movimientos.folio_doc) AS al FROM movimientos INNER JOIN tbl_Tipodoc ON movimientos.id_doc = tbl_Tipodoc.td " _
        & " WHERE     (movimientos.status = 0) AND (movimientos.fecha = CONVERT(DATETIME, '[fecha] 00:00:00', 102)) GROUP BY tbl_Tipodoc.grupo, movimientos.id_doc " _
        & "HAVING      (tbl_Tipodoc.grupo = 'Ventas' OR tbl_Tipodoc.grupo = 'Compras ') AND (movimientos.id_doc = 5)"

        sql = sql.Replace("[fecha]", Format(kfecha, "yyyy-MM-dd"))

        Dim tbl As New DataTable
        tbl = leer_tabla(sql)
        del.Text = tbl.Rows(0).Item(0)
        al.Text = tbl.Rows(0).Item(1)
        txtleyenda.Text = "Notas de ventas del dia " + fecha.Value.ToLongDateString + ", Folios del " + del.Text + " al " + al.Text
    End Sub


    Public Sub genera(ByVal fcaja As Integer, ByVal metodo As String)


        Dim fei_xlm, archivoqr As String
        Dim tbl As DataTable


        Dim DT As DataRow = lee_emisor()
        'leer serie
        Dim acajas As New admintegralDataSetTableAdapters.cajasTableAdapter
        Dim fei_serie As String = Trim(acajas.GetDataBy(fcaja).Rows(0).Item("fei_serie")) 'caja tres serie de facturas globales
        Dim fei_folio As String = siguiente_folio(fei_serie)


        'inicia generacion de CFD

        Dim afolios As New feiDatasetTableAdapters.fei_foliosTableAdapter ' pedir autorizacion y año
        Dim aemisor As New feiDatasetTableAdapters.emisorTableAdapter
        '=================================================================
        '  Datos de la factura Encabezado                                |
        '=================================================================
        'fei_xlm = "CFD_factura_" + fei_serie.ToString + fei_folio.ToString + ".xml"
        fei_xlm = "CFD_" + fei_serie.ToString.Trim + fei_folio.ToString.Trim + ".xml"
        archivoqr = "CFD_" + fei_serie.ToString.Trim + fei_folio.ToString.Trim + ".bmp"

        Dim comp As New Comprobante()


        comp.Version = "3.3"
        comp.Serie = fnn(fei_serie)
        comp.Folio = fnn(fei_folio)
        comp.Fecha = DateTime.Now
        comp.Sello = ""
        comp.NoCertificado = ""
        comp.Certificado = ""

        comp.Moneda = "MXN"

        comp.TipoDeComprobante = "I"
        comp.FormaPago = forma.Text  'catalogo biene como parametros
        comp.MetodoPago = metodo ' catalogo 
        comp.CondicionesDePago = "Contado"
        comp.Descuento = "0.00" ' Math.Round(Convert.ToDecimal(0), 2) ' Descuento
        comp.TipoCambio = Convert.ToDecimal(1)

        ' Agregar Datos Emisor
        '==================================================================================================
        ' Agregar Datos Emisor
        '==================================================================================================
        Dim dr_emisor As DataRow
        dr_emisor = aemisor.Getemisor.Rows(0)

        Dim emisor As New ComprobanteEmisor
        emisor.Rfc = fnn(dr_emisor.Item("RFC"))
        emisor.Nombre = fnn(dr_emisor.Item("Nombre"))
        emisor.RegimenFiscal = "601"
        comp.Emisor = emisor
        comp.LugarExpedicion = dr_emisor.Item("codigopostal")

        'Agregar Datos Receptor 
        '===================================================================================
        Dim Sql As String = "select * from fei_clientes where id =0"
        Dim receptor As New ComprobanteReceptor

        Dim Timp_trasladado_iva As Decimal
        Dim timp_traslado_ieps As Decimal
        Dim mst, mtt As Decimal


        tbl = leer_tabla(Sql)
        With tbl.Rows(0)
            'Agregar Datos Receptor 
            '================================================================================
            receptor.Rfc = fnn(.Item("RFC"))
            receptor.Nombre = fnn("Público en General")
            receptor.UsoCFDI = "P01"
            comp.Receptor = receptor
        End With

        Dim listaConceptos As New List(Of ComprobanteConcepto)

        With mytable.Rows
            ' CONCEPTOS
            '=======================================================================



            For j As Integer = 0 To mytable.Rows.Count - 1
                If mytable.Rows(j).Item("sub") > 0 Then
                    ' Creamos un objeto de tipo ComprobanteConcepto
                    Dim concepto As New ComprobanteConcepto
                    concepto.ClaveProdServ = "01010101"
                    concepto.ClaveUnidad = "ACT"
                    concepto.Cantidad = 1
                    concepto.Descuento = "0.00"
                    ' concepto.Unidad = fnn(mytable.Rows(j).Item("unidad")) ****no debe existir
                    concepto.NoIdentificacion = mytable.Rows(j).Item("folio")
                    concepto.Descripcion = "Venta"
                    concepto.ValorUnitario = formato_sat(Convert.ToDecimal(fnn(mytable.Rows(j).Item("sub"))))
                    concepto.Importe = formato_sat(concepto.Cantidad * concepto.ValorUnitario)
                    mst += concepto.Importe ' Suma al subtotal



                    Dim oImpuestosConcepto1 As New ComprobanteConceptoImpuestos()
                    Dim listaTrasladosConcepto1 As New List(Of ComprobanteConceptoImpuestosTraslado)

                    If mytable.Rows(j).Item("iva") > 0 Then
                        Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()
                        'Agregar Impuesto al concepto IVA
                        '====================================
                        oTraslado1Concepto1.Base = Math.Round(Convert.ToDecimal(concepto.Importe), 2)
                        oTraslado1Concepto1.Impuesto = "002" ' IVA CATALOGO
                        oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                        oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0.16)
                        oTraslado1Concepto1.Importe = Math.Round(Convert.ToDecimal(mytable.Rows(j).Item("iva")), 2)
                        listaTrasladosConcepto1.Add(oTraslado1Concepto1)
                        Timp_trasladado_iva += Math.Round(Convert.ToDecimal(mytable.Rows(j).Item("iva")), 2)
                    Else
                        Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()
                        'Agregar Impuesto al concepto IVA
                        '====================================
                        oTraslado1Concepto1.Base = Math.Round(Convert.ToDecimal(concepto.Importe), 2)
                        oTraslado1Concepto1.Impuesto = "002" ' IVA CATALOGO
                        oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                        oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0)
                        oTraslado1Concepto1.Importe = "0.00"
                        listaTrasladosConcepto1.Add(oTraslado1Concepto1)
                    End If

                    If mytable.Rows(j).Item("ieps") > 0 Then
                        Dim oTraslado1Concepto1 As New ComprobanteConceptoImpuestosTraslado()

                        'Agregar Impuesto al concepto IEPS
                        '====================================
                        oTraslado1Concepto1.Base = Math.Round(Convert.ToDecimal(concepto.Importe), 2)
                        oTraslado1Concepto1.Impuesto = "003" ' IVA CATALOGO
                        oTraslado1Concepto1.TipoFactor = "Tasa" ' Catalogo
                        oTraslado1Concepto1.TasaOCuota = Convert.ToDecimal(0.08)
                        oTraslado1Concepto1.Importe = Math.Round(Convert.ToDecimal(mytable.Rows(j).Item("ieps")), 2)
                        listaTrasladosConcepto1.Add(oTraslado1Concepto1)
                        timp_traslado_ieps += Math.Round(Convert.ToDecimal(mytable.Rows(j).Item("ieps")), 2)
                    End If

                    oImpuestosConcepto1.Traslados = listaTrasladosConcepto1.ToArray()
                    concepto.Impuestos = oImpuestosConcepto1

                    listaConceptos.Add(concepto)
                End If
            Next
        End With


        '        usuario = "admin29139"
        '        contraseña = "Aa44228$"

        comp.Conceptos = listaConceptos.ToArray()

        mtt = mst + Timp_trasladado_iva + timp_traslado_ieps

        'AQUI PONE SUBTOTAL Y TOTAL
        '============================================
        comp.SubTotal = formato_sat(mst) ' ponela suma de los conceptos
        comp.Total = formato_sat(mtt) ' ponel el total del comprobante

        '===========================================================================================================================

        'impuestode del documento
        Dim impuestos As New ComprobanteImpuestos
        impuestos.TotalImpuestosRetenidos = "0.00"
        ' impuestos.TotalImpuestosRetenidos = formato_sat(Convert.ToDecimal(0.0))
        impuestos.TotalImpuestosTrasladados = Math.Round(Convert.ToDecimal(Timp_trasladado_iva + timp_traslado_ieps), 2)

        'trasldos del documento
        Dim listaTraslados As New List(Of ComprobanteImpuestosTraslado)


        'tasa0 Cero
        Dim traslado3 As New ComprobanteImpuestosTraslado
        traslado3.Impuesto = "002" 'iva catalogo
        traslado3.TipoFactor = "Tasa"
        traslado3.TasaOCuota = Convert.ToDecimal(0.0)
        traslado3.Importe = "0.000000"
        listaTraslados.Add(traslado3)

       
        If Timp_trasladado_iva > 0 Then
            Dim traslado1 As New ComprobanteImpuestosTraslado
            traslado1.Impuesto = "002" 'iva catalogo
            traslado1.TipoFactor = "Tasa"
            traslado1.TasaOCuota = Convert.ToDecimal(0.16)
            traslado1.Importe = Math.Round(Convert.ToDecimal(Timp_trasladado_iva), 2)
            listaTraslados.Add(traslado1)
        End If

        If timp_traslado_ieps > 0 Then
          

            Dim traslado2 As New ComprobanteImpuestosTraslado
            traslado2.Impuesto = "003" 'IEPS catalogo
            traslado2.TipoFactor = "Tasa"
            traslado2.TasaOCuota = Convert.ToDecimal(0.08)
            traslado2.Importe = Math.Round(Convert.ToDecimal(timp_traslado_ieps), 2)
            listaTraslados.Add(traslado2)
            impuestos.Traslados = listaTraslados.ToArray()
        End If


        impuestos.Traslados = listaTraslados.ToArray()

        comp.Impuestos = impuestos

        Dim arrayLeyendas(4) As String
        Dim respuesta = New TimbraCFDI("http://gw1.acpdelsureste.net/productos/cfdi.php?wsdl").timbraCFDI(comp, dr_emisor.Item("certificado"), dr_emisor.Item("llaveprivada"), arrayLeyendas)


        Dim xml As String = respuesta(0) 'obtiene archivo XML
        Dim pdf64 As String = respuesta(1) ' Obtiene PDF
        Dim mensaje As String = respuesta(2) 'Obtiene Respuesta
        Dim codigo As String = respuesta(3) ' obtiene codigo 

        If codigo <> 200 Then
            MsgBox(codigo + " / " + mensaje)
        End If

        Dim archivoxml, archivopdf As String
        archivoxml = dr_emisor.Item("rutaarchivodigital") + "\cfdi33_" + comp.Serie + comp.Folio.ToString + ".xml"
        archivopdf = dr_emisor.Item("rutaarchivodigital") + "\cfdi33_" + comp.Serie + comp.Folio.ToString + ".pdf"

        'GUARDA LOS ARCHVIOS
        My.Computer.FileSystem.WriteAllText(archivoxml, respuesta(0), False)
        Base64Decode(pdf64, archivopdf)

        Process.Start(archivopdf)
        Process.Start(archivoxml)

        'Genera Registro del CFD en la base de datos
        Dim acfd As New feiDatasetTableAdapters.fei_cfdTableAdapter
        Dim f As Nullable(Of Date)

        With comp
            Try
                acfd.Insert(.Serie, .Folio, "", "", .Fecha, .TipoDeComprobante, 0, f, comp.Receptor.Rfc, comp.Receptor.Nombre, 6, comp.Folio, comp.Serie, CDbl(comp.Total), CDbl(.Impuestos.TotalImpuestosTrasladados), "1", fei_xlm, comp.NoCertificado, comp.FormaPago, comp.CondicionesDePago, comp.MetodoPago, "", "")
            Catch ex As Exception
                MsgBox("Error al Generar el Registro, " + cr + ex.Message)
                bitacora("Error al generar CFD " + comp.Folio.ToString + comp.Serie.ToString + Microsoft.VisualBasic.Chr(13) + ex.Message.ToString)
            End Try

        End With


    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cargar_movimientos(CDate(fecha.Value))
        Dim acajas As New admintegralDataSetTableAdapters.cajasTableAdapter
        Dim fei_serie As String = Trim(acajas.GetDataBy(2).Rows(0).Item("fei_serie")) 'caja tres serie de facturas globales
        Dim fei_folio As String = siguiente_folio(fei_serie)
        txtfolio.Text = fei_folio


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        genera(2, metodo.Text) 'ACP ANTERIOR
    End Sub

    Private Sub Base64Decode(ByVal sbase64 As String, ByVal file As String)
        Dim sImagenTemporal As String = file
        If IsNothing(sbase64) Then Exit Sub
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