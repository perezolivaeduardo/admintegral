Module fei
    Structure tfei
        Dim rfc As String
        Dim certificado As String
        Dim llave As String
        Dim licencia As String
        Dim password As String
        Dim ruta As String
    End Structure
    Public dfei As tfei, cr As String, lf As String
    Public metodos(0 To 5) As String

    Public Function lee_emisor() As DataRow
        Dim adap As New feiDatasetTableAdapters.emisorTableAdapter
        lee_emisor = adap.GetData.Rows(0)
    End Function

    Public Function siguiente_folio(ByVal serie As String)
        Dim cmd As String = "SELECT     fei_serie, MAX(fei_folio) AS folio FROM fei_cfd  GROUP BY fei_serie HAVING  fei_serie = '" + serie + "'"
        Dim t As DataTable = leer_tabla(cmd)
        If t.Rows.Count = 0 Then
            siguiente_folio = 1
        Else
            siguiente_folio = t.Rows(0).Item("folio") + 1
        End If
    End Function

    Public Function fnn(ByVal f As String) As String

        If f.Length = 0 Then
            fnn = "" : Exit Function
        Else
            fnn = f.Trim()
        End If
        If fnn = " " Or fnn = "" Or fnn = "  " Then fnn = ""
        While InStr(fnn, "  ") > 0
            fnn = fnn.Replace("  ", " ")
        End While

    End Function

    Public Sub ini()
        Dim adap As New feiDatasetTableAdapters.emisorTableAdapter
        cr = Microsoft.VisualBasic.Chr(13)
        lf = Microsoft.VisualBasic.Chr(10)
        Try
            dfei.certificado = adap.Getemisor.Rows(0).Item("certificado")
            dfei.licencia = adap.Getemisor.Rows(0).Item("licencia")
            dfei.llave = adap.Getemisor.Rows(0).Item("llaveprivada")
            dfei.password = adap.Getemisor.Rows(0).Item("clavefiel")
            dfei.ruta = adap.Getemisor.Rows(0).Item("rutaarchivodigital")
        Catch ex As Exception

        End Try
       


    End Sub

    Function nombre_del_reporte(ByVal rfc As String, ByVal periodo As String)
        nombre_del_reporte = "1" + rfc + periodo + ".txt"
    End Function

    Function pipe(ByVal valor As String)
        pipe = valor.Trim + "|"
    End Function

    Function fn_uso(ByVal uso As String) As String
        Dim sql As String = "select uso from sat_uso where id_uso='[id]'"
        sql = sql.Replace("[id]", uso)
        Try
            Return leer_sat(sql).Rows(0).Item(0)
        Catch ex As Exception
            Return "-"
        End Try

    End Function
    Public Function formato_sat(ByVal importe As Decimal) As String
        Return Format(importe, "######.00")
    End Function

    Function fn_metodo(ByVal metodo As String) As String
        Dim sql As String = "select descripcion from sat_metodosdepago where metodo='[id]'"
        sql = sql.Replace("[id]", metodo)
        Try
            Return leer_sat(sql).Rows(0).Item(0)
        Catch ex As Exception
            Return "-"
        End Try

    End Function

    Function fn_forma(ByVal forma As String) As String
        Dim sql As String = "select descripcion from sat_formasdepago where formaDEpago='[id]'"
        sql = sql.Replace("[id]", forma)
        Try
            Return leer_sat(sql).Rows(0).Item(0)
        Catch ex As Exception
            Return "-"
        End Try

    End Function

    Function uuid(ByVal file As String) As String
        Dim ds As New DataSet
        ds.Clear()
        Try
            ds.ReadXml(file)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        End Try
        Return ds.Tables("TimbreFiscalDigital").Rows(0).Item("UUID")

    End Function

End Module
