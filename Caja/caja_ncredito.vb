Public Class caja_ncredito
    Dim cnombre As String
    Dim cdireccion As String
    Dim cciudad, cestado As String
    Dim crfc As String
    Dim csub0 As Decimal
    Dim csub10 As Decimal
    Dim civa10 As Decimal
    Dim ctotal As Decimal
    Dim SERIE, FOLIO, td
    Private Sub foliotxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles foliotxt.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            SERIE = Mid(foliotxt.Text, 1, 1)
            FOLIO = Mid(foliotxt.Text, 2, foliotxt.TextLength - 1)
            If Me.opfactura.Checked = True Then td = 6 Else td = 5
            Dim dt As DataTable
            dt = ldocumento(td, FOLIO, SERIE)
            If dt.Rows.Count = 0 Then
                MsgBox("NO existe")
            Else
                Me.txtconcepto.Text = "Bonificacion sobre la factura " + Me.foliotxt.Text
                leer(dt)
                Me.txtconcepto.Focus()
            End If
        End If

    End Sub

    Private Sub leer(ByVal dt As DataTable)
        nombretxt.Text = dt.Rows(0).Item("Nombre")
        fechatxt.Text = dt.Rows(0).Item("fechafactura")
        importetxt.Text = Format(dt.Rows(0).Item("importe"), "n2")

        Try
            Dim cmd As String = "Select abonos, saldo from cxc_saldos_x_factura where td=" + td.ToString + " and folio=" + FOLIO.ToString + " and serie = '" + SERIE.ToString + "'"
            Dim tmptbl As DataTable = leer_tabla(cmd)
            abonadotxt.Text = Format(tmptbl.Rows(0).Item("abonos"), "n2")
            Me.saldotxt.Text = Format(tmptbl.Rows(0).Item("saldo"), "n2")
            'If tmptbl.Rows(0).Item("saldo") < 1 Then Me.txtbono.Enabled = False Else Me.txtbono.Enabled = True
        Catch ex As Exception

        End Try

        statustxt.Text = dt.Rows(0).Item("status")
        ncreditotxt.Text = dt.Rows(0).Item("nc_folio").ToString

        If Val(ncreditotxt.Text) > 0 Then
            MsgBox("Ya tiene Nota de Credito ")
            'Exit Sub
        End If
        Me.Boton_generar.Enabled = True

    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub Boton_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_generar.Click
        Me.Boton_generar.Enabled = False
        SERIE = Mid(foliotxt.Text, 1, 1)
        FOLIO = Mid(foliotxt.Text, 2, foliotxt.TextLength - 1)
        If Me.opfactura.Checked = True Then td = 6 Else td = 5
        Dim dt As DataTable, d As New Mi_Documento

        dt = cdocumento(td, FOLIO, SERIE) 'Carga Venta a memoria

        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim doc As New admintegralDataSetTableAdapters.DocumentosTableAdapter

        Dim f As Long
        Try
            f = afolio.siguiente(7, "NC")
        Catch ex As Exception
            f = 1
        End Try
        With dt.Rows(0)
            d.a00_id_doc = 7
            d.a01_Folio = f
            d.a02_serie = " "
            d.a03_Almacen = .Item("almacen")
            d.a04_id_directorio = .Item("id_directorio")
            d.a05_tipo_directorio = .Item("tipo_directorio")
            d.a06_fecha_registro = Date.Now
            d.a07_Folio_pedido = 0
            d.a08_factura = " "
            d.a09_fecha_factura = .Item("fechafactura")
            d.a10_fecha_surtido = CDate(Date.Now.Date)
            d.a11_fecha_vence = Date.Now
            d.a12_pdesc = .Item(12)
            d.a13_flete = .Item(13)
            d.a14_sub0 = .Item(14)
            d.a15_sub10 = .Item(15)
            d.a16_sub15 = .Item(16)
            d.a17_iva10 = .Item(17)
            d.a18_iva15 = .Item(18)
            d.a19_desc0 = .Item(19)
            d.a20_desc10 = .Item(20)
            d.a21_desc15 = .Item(21)
            d.a22_importe = .Item(22)
            d.a23_idcartera = 4 'nota de credito para cancelar una fectura
            d.a24_status = 0 'pendiente de imprimir
            d.a33_nc_td = .Item(0) 'td factura
            d.a34_nc_folio = .Item(1) 'folio factura
            d.a35_nc_serie = .Item(2) 'serie factura

            Dim result As Boolean = Agregar_documento(d) 'Funcion que guarda el documento en la tabla
            If result = False Then
                MsgBox("No se guardo el documento")
                Exit Sub
            End If

            'actualiza la tabla de comentarios
            Dim adap As New admintegralDataSetTableAdapters.ComentariosTableAdapter
            adap.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, "", Mid(txtrecibio.Text, 1, 20), txtconcepto.Text)
            adap.Dispose()

            'genera comando para poner naturaleza en ceros
            Try
                Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
                    conection.Open()
                    Dim cmd1 As String
                    Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                    Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
                    cmd1 = "UPDATE movimientos " & _
                    "SET n=0 " & _
                    "WHERE id_doc = " + d.a33_nc_td.ToString & " and folio_doc =" + d.a34_nc_folio.ToString + " and serie = '" + d.a35_nc_serie + "'"
                    Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd1, conection)
                    AdaptadorDeDatos.UpdateCommand = Command
                    AdaptadorDeDatos.UpdateCommand.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox("No se pudo actualizar la tabla de Movimientos")
                MsgBox(ex.Message)
            End Try

            Try
                doc.Update_ncredito(d.a00_id_doc, d.a01_Folio, d.a02_serie, d.a33_nc_td, d.a34_nc_folio, d.a35_nc_serie)
            Catch ex As Exception
                MsgBox("No se actualizo la factura con los datos de la note de credito")
                MsgBox(ex.Message)
            End Try
        End With
        'Dim conceptodev As String
        'If d.a33_nc_td = 5 Then
        '    conceptodev = "        Devolucion total del Ticket " + d.a35_nc_serie.ToString + d.a34_nc_folio.ToString
        'Else
        '    conceptodev = "        Devolucion total de la factura " + d.a35_nc_serie.ToString + d.a34_nc_folio.ToString
        'End If

        'My.Forms.fei_generacfd.genera_nc_total(7, d.a02_serie, d.a01_Folio, 16, conceptodev)
        'Exit Sub
        'Leer datos del cliente
        Dim cmd As String = "Select * from Directorio where tipo=2 and id_directorio=" + d.a04_id_directorio.ToString
        Dim drcli As DataRow = leer_tabla(cmd).Rows(0)

        '================================================================================================================
        '        IMPRIMIR NOTA DE CREDITO
        '========================================================================================================
        Dim l As String, j As Integer
        Dim archivo As String = "c:\tmp\ncred" + FOLIO + ".txt", cc As String, nl As Integer = 0
        Dim fil As New System.IO.StreamWriter(archivo, False)
        cc = Microsoft.VisualBasic.Chr(27) + Microsoft.VisualBasic.Chr(15)
        fil.WriteLine(cc)
        fil.WriteLine("") : fil.WriteLine("") : fil.WriteLine("")
        l = "  Agente: " + drcli.Item("id_agente").ToString : l = l.PadLeft(90) : fil.WriteLine(l)
        l = Now.Date.Day.ToString + "         " + Now.Date.Month.ToString + "        " + Now.Date.Year.ToString : l = l.PadLeft(128) : fil.WriteLine(l)
        fil.WriteLine(" ")
        l = "                           " + drcli("Nombre").ToString : l = l.PadRight(110) + "R :" + drcli("id_directorio").ToString : fil.WriteLine(l) 'Nombre
        fil.WriteLine("                           " + drcli.Item("Direccion").ToString)
        l = drcli("colonia").ToString.Trim + "  " + drcli("ciudad").ToString.Trim + "  " + drcli("edo").ToString.Trim
        fil.WriteLine("                           " + l)
        l = "      " + drcli("rfc").ToString.PadRight(84) + d.a01_Folio.ToString + "  " + d.a35_nc_serie.ToString + d.a34_nc_folio.ToString
        fil.WriteLine("                " + l)
        For j = 0 To 2 : fil.WriteLine("") : Next j
        nl = 1
        If d.a33_nc_td = 5 Then
            l = "        Devolucion total del Ticket " + d.a35_nc_serie.ToString + d.a34_nc_folio.ToString
        Else
            l = "        Devolucion total de la factura " + d.a35_nc_serie.ToString + d.a34_nc_folio.ToString
        End If
        fil.WriteLine(l)
        For jj As Integer = nl To 16 : fil.WriteLine(" ") : Next jj
        Dim subt As Double = d.a14_sub0
        Dim sub10 As Double = d.a15_sub10
        Dim iva As Double = d.a17_iva10
        Dim t1 As Double = d.a22_importe
        l = " Exento :".PadLeft(120) + Format(subt, "N2").PadLeft(10) : fil.WriteLine(l) : nl += 1
        l = "     " + txtconcepto.Text.PadRight(55)
        l = l + "Gravado " + Trim(My.Settings.iva.ToString) + "%:".PadLeft(60) + Format(sub10, "N2").PadLeft(10) : fil.WriteLine(l) : nl += +1
        l = "     Verifico :" + txtrecibio.Text.PadRight(45)
        l = l + "I.V.A. " + Trim(My.Settings.iva.ToString) + "% :".PadLeft(60) + Format(iva, "N2").PadLeft(10) : fil.WriteLine(l) : nl += +1
        l = " TOTAL :".PadLeft(120) + Format(t1, "N2").PadLeft(10) : fil.WriteLine(l) : nl += 1

        Dim ct As String
        ct = Mid(Format(CDbl(t1) - Fix(CDbl(t1)), ".##"), 2, 2)
        fil.WriteLine(" ")
        fil.WriteLine("    Son:(" + Num2Text(Fix(t1)) + " PESOS " + ct.ToString + "/100 M.N.)")
        For jj As Integer = 1 To 7 : fil.WriteLine(" ") : Next jj
        '*********************   Enviar  *********************************
        fil.Close()
        Dim x As MsgBoxResult = MsgBox("Imprimir? ", MsgBoxStyle.YesNo, "")
        If x = MsgBoxResult.Yes Then Imprimir.SendFileToPrinter(My.Settings.impresora_factura, archivo)

    End Sub

    Private Sub Boton_bonifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_generar.Click, boton_bonificar.Click
        Me.boton_bonificar.Enabled = False
        SERIE = Mid(foliotxt.Text, 1, 1)
        FOLIO = Mid(foliotxt.Text, 2, foliotxt.TextLength - 1)
        If Me.opfactura.Checked = True Then td = 6 Else td = 5
        Dim dt As DataTable, d As New Mi_Documento
        Dim bonificacion As Single = Val(Me.txtbono.Text)
        dt = cdocumento(td, FOLIO, SERIE) 'Carga Venta a memoria

        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim doc As New admintegralDataSetTableAdapters.DocumentosTableAdapter

        Dim f As Long
        Try
            f = afolio.siguiente(7, "NC")
        Catch ex As Exception
            f = 1
        End Try
        With dt.Rows(0)
            d.a00_id_doc = 7
            d.a01_Folio = f
            d.a02_serie = ""
            d.a03_Almacen = .Item("almacen")
            d.a04_id_directorio = .Item("id_directorio")
            d.a05_tipo_directorio = .Item("tipo_directorio")
            d.a06_fecha_registro = Date.Now
            d.a07_Folio_pedido = 0
            d.a08_factura = " "
            d.a09_fecha_factura = CDate(Date.Now.Date)
            d.a10_fecha_surtido = CDate(Date.Now.Date)
            d.a11_fecha_vence = Date.Now.Date
            d.a12_pdesc = 0
            d.a13_flete = 0
            d.a14_sub0 = bonificacion
            d.a15_sub10 = 0
            d.a16_sub15 = 0
            d.a17_iva10 = 0
            d.a18_iva15 = 0
            d.a19_desc0 = 0
            d.a20_desc10 = 0
            d.a21_desc15 = 0
            d.a22_importe = bonificacion
            If chkDevol.Checked = True Then d.a23_idcartera = 4 Else d.a23_idcartera = 5 'Bonificacion
            d.a24_status = 0 'pendiente de imprimir
            d.a33_nc_td = .Item(0) 'td factura
            d.a34_nc_folio = .Item(1) 'folio factura
            d.a35_nc_serie = .Item(2) 'serie factura

            Dim result As Boolean = Agregar_documento(d) 'Funcion que guarda el documento en la tabla
            If result = False Then
                MsgBox("No se guardo el documento")
                Exit Sub
            End If

            'actualiza la tabla de comentarios
            Dim adap As New admintegralDataSetTableAdapters.ComentariosTableAdapter
            adap.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, "", Mid(txtrecibio.Text, 1, 20), txtconcepto.Text)
            adap.Dispose()

            'Marca la factura con la nota de credito 
            Try
                doc.Update_ncredito(d.a00_id_doc, d.a01_Folio, d.a02_serie, d.a33_nc_td, d.a34_nc_folio, d.a35_nc_serie)
            Catch ex As Exception
                MsgBox("No se actualizo la factura con los datos de la note de credito")
                MsgBox(ex.Message)
            End Try
            Dim concepto As String
            concepto = txtconcepto.Text
            'CFDI
            ' My.Forms.fei_generacfd.genera_nc_bonificacion(d.a00_id_doc, d.a02_serie, d.a01_Folio, 16, concepto, Me.txtrecibio.Text)

        End With
    End Sub


    Private Sub txtbono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbono.TextChanged
        Dim i As Single
        Try
            i = Val(txtbono.Text)
        Catch ex As Exception
            i = 0
        End Try
        If i > 0 Then
            Boton_generar.Enabled = False
            boton_bonificar.Enabled = True
        Else
            Boton_generar.Enabled = True
            boton_bonificar.Enabled = False
        End If
    End Sub

    Private Sub chkDevol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDevol.CheckedChanged

    End Sub
End Class