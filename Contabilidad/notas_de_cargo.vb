Public Class notas_de_cargo
    Dim tblcargo As New DataTable
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String = "Select * from tmp_notas_de_cargo ORDER BY dbo.Documentos.fechafactura DESC"
        Dim tbl As DataTable = leer_tabla(cmd)
        dgv.DataSource = tbl
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub boton_genera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_genera.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String = "Select * from tmp_notas_de_cargo ORDER BY dbo.Documentos.fechafactura DESC"
        Dim tbl As DataTable = leer_tabla(cmd)
        Dim adap As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim factura, serie As String
        Dim cargo As Decimal
        Dim id, folio As Integer
        For j As Integer = 0 To tbl.Rows.Count - 1
            With tbl.Rows(j)
                factura = .Item("serie") + .Item("folio").ToString
                cargo = .Item("cargo")
                id = .Item("id_directorio")
                folio = .Item("folio")
                serie = .Item("serie")
                adap.Insert(6, j + 1, "NC", 0, id, 2, Now.Date, 0, factura, "11/1/2010", "11/1/2010", .Item("vence"), 0, 0, cargo, 0, 0, 0, 0, 0, 0, 0, cargo, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, folio, serie, 0, 0, "", "", "")
            End With
        Next
    End Sub
    Private Sub imprimir_nc(ByVal nc As Integer)
        Dim cmd As String, adapf As New admintegralDataSetTableAdapters.DocumentosTableAdapter, serie, folio As String, drf As DataRow
        cmd = "SELECT     dbo.Documentos.td, dbo.Documentos.Folio, dbo.Documentos.serie, dbo.Directorio.Nombre, dbo.Directorio.Direccion, dbo.Directorio.Colonia, dbo.Directorio.Ciudad, " _
        & " dbo.Directorio.Edo, dbo.Directorio.CP, dbo.Directorio.RFC, dbo.Documentos.factura, dbo.Documentos.fechafactura, dbo.Documentos.fechasurtido, " _
        & " dbo.Documentos.vence, dbo.Documentos.Importe, dbo.Documentos.nc_td, dbo.Documentos.nc_folio, dbo.Documentos.nc_serie,dbo.Directorio.id_agente, dbo.Documentos.id_directorio " _
        & " FROM dbo.Documentos INNER JOIN dbo.Directorio ON dbo.Documentos.id_directorio = dbo.Directorio.id_directorio AND dbo.Documentos.tipo_directorio = dbo.Directorio.tipo " _
        & " WHERE dbo.Documentos.serie = 'nc' and folio=" + nc.ToString
        Dim tbl As DataTable = leer_tabla(cmd)
        tblcargo = tbl
        If tbl.Rows.Count = 0 Then Beep() : MsgBox("No Existe") : Exit Sub
        serie = Trim(tbl.Rows(0).Item("nc_serie").ToString) : folio = tbl.Rows(0).Item("nc_folio").ToString
        drf = adapf.GetDataByKey(6, folio, serie).Rows(0)
        Me.nc_nombre.Text = Trim(tbl.Rows(0).Item("id_directorio")) + ".- " + tbl.Rows(0).Item("Nombre")
        Me.Nc_direccion1.Text = tbl.Rows(0).Item("Direccion").ToString.Trim + " " + tbl.Rows(0).Item("colonia").ToString.Trim
        Me.nc_ciudad.Text = tbl.Rows(0).Item("ciudad").ToString.Trim
        Me.nc_rfc.Text = tbl.Rows(0).Item("rfc").ToString.Trim
        Me.idagente.Text = tbl.Rows(0).Item("id_agente").ToString.Trim
        Me.nc_importe.Text = Format(tbl.Rows(0).Item("Importe"), "N2")
        Me.TextBox1.Text = "1% Complementario del IVA de acuerdo a la Ley. Fact. " + Trim(tbl.Rows(0).Item("nc_serie").ToString) + tbl.Rows(0).Item("nc_folio").ToString
        Me.TextBox1.Text = "ESTE COMPROBANTE ES COMPLEMENTARIO DEL EXPEDIDO DEL FOLIO " + serie + folio
        Me.TextBox2.Text = "CON FECHA :" + Format(drf.Item("fechafactura"), "d")

    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim id As Integer
        id = dgv.CurrentRow.Cells("folio").Value.ToString
        imprimir_nc(id)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim nc As Integer
        Try
            nc = InputBox("Teclee numero ", "", "")
        Catch ex As Exception
            Exit Sub
        End Try

        imprimir_nc(nc)
    End Sub

    Private Sub Imprime(ByVal tbl As DataTable, ByVal concepto As String, ByVal concepto1 As String)
        Dim archivo As String = "c:\tmp\ncargo" + tbl.Rows(0).Item("folio").ToString + ".txt", cc As String, nl As Integer = 0
        Dim f As New System.IO.StreamWriter(archivo, False)
        cc = Microsoft.VisualBasic.Chr(27) + Microsoft.VisualBasic.Chr(15)
        Dim l As String, t1 As Decimal
        f.WriteLine(cc)
        Dim espacio As String = "                             "
        Dim espacio1 As String = "                     "
        For j As Integer = 0 To 3 : f.WriteLine("") : Next j
        With tbl.Rows(0)
            l = espacio1 + "Nombre   :" + .Item("nombre").ToString.PadRight(80) + Now.Date.Day.ToString + " " + Now.Date.Month.ToString + "    " + Now.Date.Year.ToString
            f.WriteLine(l) 'Nombre y fecha
            f.WriteLine(espacio1 + "Direccion:" + .Item("Direccion").ToString.Trim + " " + .Item("colonia").ToString.Trim)
            f.WriteLine(espacio1 + "Ciudad   :" + .Item("ciudad").ToString.Trim)
            l = espacio1 + "R.F.C.   " + .Item("rfc").ToString.Trim
            f.WriteLine("") : f.WriteLine(l.PadRight(100) + "Cancun, Q.Roo.")
            For j As Integer = 0 To 4 : f.WriteLine("") : Next j
            l = concepto.PadRight(115) + Format(.Item("importe"), "N2")
            f.WriteLine(l)
            l = concepto1.PadRight(115)
            f.WriteLine(l)
            For j As Integer = 0 To 3 : f.WriteLine("") : Next j
            t1 = .Item("importe")
            Dim ct As String
            ct = Mid(Format(CDbl(t1) - Fix(CDbl(t1)), ".00"), 2, 2)
            f.WriteLine(" ")
            f.WriteLine("    Son:(" + Num2Text(Fix(t1)) + " PESOS " + ct.ToString + "/100 M.N.)")
            f.WriteLine(" ")
            l = "Control : " + .Item("folio").ToString + " Agente: " + Me.idagente.Text
            f.WriteLine(l.PadLeft(60))
            For j1 As Integer = 0 To lineasnc.Text : f.WriteLine(" ") : Next j1
            f.Close()
            Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, archivo)

        End With
    End Sub

    Private Sub Boton_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Imprimir.Click
        Imprime(tblcargo, Me.TextBox1.Text, Me.TextBox2.Text)
    End Sub

End Class