Imports Microsoft.Win32
Public Class poliza_compras
    Dim Mytable As New DataTable
    Dim minipoliza As New DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mytable.Clear()
        Me.FECHAPOLIZA.Text = Format(fecha.Value, "yyyyMMdd")
        lee_datos(fecha.Value)

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", fecha.Value.ToShortDateString, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("referencia", Me.referencia.Text, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)



        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", minipoliza)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.Visible = True
        Me.ReportViewer1.RefreshReport()
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Visible = True
    End Sub

    Private Sub lee_datos(ByVal fecha As Date)
        Dim filepoliza As String = Me.carpetadestino.Text.Trim + "\" + Me.archivo.Text.Trim

        Dim adap As New integraDataSetTableAdapters.cg_documentosTableAdapter
        Dim f As String = fecha.Date.ToShortDateString + " 00:00"
        Dim f1 As String = fecha.Date.ToShortDateString + " 23:59"
        Dim tbl As DataTable = adap.GetDataByperiodo(f, f1)
        Dim j As Integer
        If tbl.Rows.Count = 0 Then MsgBox("Sin moviemientos !!!", MsgBoxStyle.Exclamation) : Exit Sub
        Try
            al0.Text = Format(tbl.Compute("sum(sub0)", ""), "N2")
            al11.Text = Format(tbl.Compute("sum(sub10)", ""), "N2")
            al16.Text = Format(tbl.Compute("sum(sub15)", ""), "N2")
            iva11.Text = Format(tbl.Compute("sum(iva10)", ""), "N2")
            IVA16.Text = Format(tbl.Compute("sum(iva15)", ""), "N2")
        Catch ex As Exception

        End Try
        Dim adapcg As New integraDataSetTableAdapters.sys_cgcuentasTableAdapter
        Dim tblcg As DataTable = adapcg.GetData
        ' compras  al cero
        Dim dt As DataRow
        dt = mytable.NewRow
        dt(0) = cuenta(tblcg.Rows(0).Item(2).ToString)
        dt(1) = tblcg.Rows(0).Item(1).ToString
        dt(2) = Me.concepto.Text.Trim
        dt(3) = al0.Text
        dt("importe") = al0.Text
        dt("tipo") = "0 "
        mytable.Rows.Add(dt)

        ' compras  al 11
        dt = mytable.NewRow
        dt(0) = cuenta(tblcg.Rows(1).Item(2).ToString)
        dt(1) = tblcg.Rows(1).Item(1).ToString
        dt(2) = Me.concepto.Text.Trim
        dt(3) = al11.Text
        dt("importe") = al11.Text
        dt("tipo") = "0 "
        mytable.Rows.Add(dt)

        ' compras  al 16
        dt = mytable.NewRow
        dt(0) = cuenta(tblcg.Rows(2).Item(2).ToString)
        dt(1) = tblcg.Rows(2).Item(1).ToString
        dt(2) = Me.concepto.Text.Trim
        dt(3) = al16.Text
        dt("importe") = al16.Text
        dt("tipo") = "0 "
        mytable.Rows.Add(dt)

        ' iva al 11
        dt = mytable.NewRow
        dt(0) = cuenta(tblcg.Rows(3).Item(2).ToString)
        dt(1) = tblcg.Rows(3).Item(1).ToString
        dt(2) = Me.concepto.Text.Trim
        dt(3) = iva11.Text
        dt("importe") = iva11.Text
        dt("tipo") = "0 "
        mytable.Rows.Add(dt)

        ' iva al 16
        dt = mytable.NewRow
        dt(0) = cuenta(tblcg.Rows(4).Item(2).ToString)
        dt(1) = tblcg.Rows(4).Item(1).ToString
        dt(2) = Me.concepto.Text.Trim
        dt(3) = IVA16.Text
        dt("importe") = IVA16.Text
        dt("tipo") = "0 "
        mytable.Rows.Add(dt)

        dgv.Columns("cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("cargo").DefaultCellStyle.Format = "N2"
        dgv.Columns("abono").DefaultCellStyle = dgv.Columns("cargo").DefaultCellStyle
        dgv.Columns("importe").Visible = False
        
        minipoliza.Clear()
        For j = 0 To 4
            minipoliza.ImportRow(mytable.Rows(j))
        Next
        For j = 0 To 4
            Dim ct, sb As String
            ct = minipoliza.Rows(j).Item(0).ToString.Substring(0, 4)
            sb = minipoliza.Rows(j).Item(0).ToString.Substring(5, 4)
            minipoliza.Rows(j).Item("cta") = ct
            minipoliza.Rows(j).Item("sub") = sb
            If j < 3 Then minipoliza.Rows(j).Item("grupo") = "Almacen" Else minipoliza.Rows(j).Item("grupo") = "Iva Acreditable"
        Next
        'calcula el total de compras
        Dim totaldecompras As Decimal = mytable.Compute("sum(importe)", "tipo = 0")
        dt = minipoliza.NewRow
        dt(0) = "2005"
        dt(1) = "(Relacion Anexa)"
        dt(2) = "(Relacion Anexa)"
        dt(4) = totaldecompras
        dt("importe") = dt(4)
        dt("tipo") = "1 "
        dt("cta") = "2005"
        dt("grupo") = "Proveedores"
        minipoliza.Rows.Add(dt)

        For j = 0 To tbl.Rows.Count - 1
            With tbl.Rows(j)
                dt = mytable.NewRow
                dt(0) = cuenta(.Item("cuenta_contable"))
                dt(1) = .Item("nombre")
                dt(2) = "SEGUN FAC NO. " + .Item("factura").ToString.Trim
                dt(4) = Math.Round(.Item("importe"), 2)
                dt("tipo") = "1 "
                dt("importe") = Math.Round(.Item("importe"), 2)
                mytable.Rows.Add(dt)
            End With
        Next


        '===================================================================================
        ' Movimientos de la cuenta de orden solo tipo 1
        '===================================================================================
        Dim cc As Decimal = 0
        For j = 0 To tbl.Rows.Count - 1
            With tbl.Rows(j)
                dt = mytable.NewRow
                Dim cta As String = .Item("cuenta_contable").ToString.Replace("2005-", "6040-")
                dt(0) = cuenta(cta)
                dt(1) = .Item("nombre")
                dt(2) = "SEGUN FAC. No. " + .Item("factura").ToString.Trim
                dt(4) = .Item("sub0") + .Item("sub10") + .Item("sub15")
                dt("tipo") = "0 "

                Dim i As Decimal = .Item("sub0") + .Item("sub10") + .Item("sub15")
                dt("importe") = Math.Round(i, 2)
                Mytable.Rows.Add(dt)
                cc += Math.Round(i, 2)
            End With
        Next

        ' resumen en cuenta de compras
        dt = mytable.NewRow
        dt(0) = cuenta("6050-00000-0000")
        dt(1) = tblcg.Rows(5).Item(1).ToString
        dt(2) = Me.concepto.Text.Trim
        dt(3) = cc
        dt("importe") = cc
        dt("tipo") = "1 "
        mytable.Rows.Add(dt)
        comprastxt.Text = Format(cc, "N2")

        'Cuentas de  Orden
        dt = minipoliza.NewRow
        dt(0) = "6040"
        dt(1) = "(Relacion Anexa)"
        dt(2) = "(Relacion Anexa)"
        dt(3) = cc
        dt("importe") = dt(3)
        dt("tipo") = "0 "
        dt("cta") = "6040"
        dt("grupo") = "Compras Cuenta Control"
        minipoliza.Rows.Add(dt)

        'Cuentas de  Orden
        dt = minipoliza.NewRow
        dt(0) = "6050"
        dt(1) = ""
        dt(2) = ""
        dt(4) = cc
        dt("importe") = dt(4)
        dt("tipo") = "0 "
        dt("cta") = "6050"
        dt("grupo") = "Cuenta Control Compras "
        minipoliza.Rows.Add(dt)




        '==========================================================================================
        ' Inicia definicion de poliza
        '==========================================================================================
        Dim p As New ppoliza
        p.poliza = "P  "
        p.fecha = Me.FECHAPOLIZA.Text + " "
        p.tipo = "   3" ' Diario
        p.folio = "           "
        p.clase = "1 "
        p.iddiario = "0          "
        p.concepto = Me.concepto.Text.PadRight(101, " ")
        p.sistorig = "11 "
        p.impresa = "0 "
        p.ajuste = "0 "
        Dim encabezado As String


        'DEFINE NOMBRE DEL ARCHVIO
        Dim fp As New System.IO.StreamWriter(filepoliza, False)
        Dim mpoliza As String
        Dim guia As String = "P  20100517    3       239 1 0          COMPRAS A CREDITO DEL DIA                                                                            11 1 0 "
        Dim guiam As String = "M  1256000010000                  P.D.- 24   0 110718.08            0          0.0                  COMPRAS A CREDITO DEL DIA                                                                                 "

        encabezado = p.poliza + p.fecha + p.tipo + p.folio + p.clase + p.iddiario + p.concepto + p.sistorig + p.impresa + p.ajuste
        fp.WriteLine(encabezado)
        ' fp.WriteLine(guia)
        'fp.WriteLine(guiam)

        For j = 0 To mytable.Rows.Count - 1
            Dim pm As mpoliza
            pm.movimiento = "M  "
            pm.idcuenta = mytable.Rows(j).Item(0).ToString.PadRight(30, " ") + " "
            pm.referencia = referencia.Text.PadRight(11)
            pm.tipomov = mytable.Rows(j).Item("tipo").ToString.PadRight(2)
            pm.importe = mytable.Rows(j).Item("importe").ToString.PadRight(21)
            pm.iddiario = p.iddiario.PadRight(11)
            pm.importeme = "0.0".PadRight(21)
            pm.concepto = mytable.Rows(j).Item("concepto").ToString.PadRight(101)
            pm.idsegneg = "     "

            mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
            fp.WriteLine(mpoliza)
        Next j
        fp.Close()
        If verpoliza.Checked = True Then Process.Start(filepoliza)
    End Sub

    Private Sub crear_tabla()
        If Mytable.Columns.Count > 0 Then Exit Sub
        ' Declare variables for DataColumn and DataRow objects.
        Dim column As New DataColumn
        column = New DataColumn("cuenta", System.Type.GetType("System.String"))
        column.AllowDBNull = False : Mytable.Columns.Add(column)

        column = New DataColumn("Descripcion", System.Type.GetType("System.String"))
        column.AllowDBNull = False : Mytable.Columns.Add(column)
        column = New DataColumn("concepto", System.Type.GetType("System.String"))
        column.AllowDBNull = False : Mytable.Columns.Add(column)
        column = New DataColumn("cargo", System.Type.GetType("System.Decimal"))
        column.Unique = False
        Mytable.Columns.Add(column)
        column = New DataColumn("abono", System.Type.GetType("System.Decimal"))
        column.Unique = False
        Mytable.Columns.Add(column)

        column = New DataColumn("importe", System.Type.GetType("System.Decimal"))
        column.Unique = False
        Mytable.Columns.Add(column)
        column = New DataColumn("tipo", System.Type.GetType("System.String"))
        column.AllowDBNull = False : Mytable.Columns.Add(column)

        '=============================================================================================
        ' Declare variables for DataColumn and DataRow objects.

        column = New DataColumn("cuenta", System.Type.GetType("System.String"))
        column.AllowDBNull = False : minipoliza.Columns.Add(column)

        column = New DataColumn("Descripcion", System.Type.GetType("System.String"))
        column.AllowDBNull = False : minipoliza.Columns.Add(column)
        column = New DataColumn("concepto", System.Type.GetType("System.String"))
        column.AllowDBNull = False : minipoliza.Columns.Add(column)
        column = New DataColumn("cargo", System.Type.GetType("System.Decimal"))
        column.Unique = False
        minipoliza.Columns.Add(column)
        column = New DataColumn("abono", System.Type.GetType("System.Decimal"))
        column.Unique = False
        minipoliza.Columns.Add(column)

        column = New DataColumn("importe", System.Type.GetType("System.Decimal"))
        column.Unique = False
        minipoliza.Columns.Add(column)
        column = New DataColumn("tipo", System.Type.GetType("System.String"))
        column.AllowDBNull = False : minipoliza.Columns.Add(column)


        column = New DataColumn("cta", System.Type.GetType("System.String"))
        column.AllowDBNull = True : minipoliza.Columns.Add(column)
        column = New DataColumn("sub", System.Type.GetType("System.String"))
        column.AllowDBNull = True : minipoliza.Columns.Add(column)
        column = New DataColumn("grupo", System.Type.GetType("System.String"))
        column.AllowDBNull = True : minipoliza.Columns.Add(column)
        dgv.DataSource = minipoliza
    End Sub

    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        Dim a As String
        a = "poliza_CC_" + Format(fecha.Value, "dd-MMM-yyyy") + ".txt"
        Me.archivo.Text = a
        Dim subcarpeta As String = Format(fecha.Value, "MMMyyyy")
        Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
        Me.carpetadestino.Text = Trim(adap.path(12)) + subcarpeta

        Try
            MkDir(carpetadestino.Text)
        Catch ex As Exception

        End Try
        referencia.Text = "PD-CC-" + Format(fecha.Value, "dd")

        Me.RadioButton1.Visible = False
        Me.RadioButton2.Checked = True
        mytable.Clear() : minipoliza.Clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim subcarpeta As String = Format(fecha.Value, "MMMyyyy")
        Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
        Me.carpetadestino.Text = Trim(adap.path(12)) + subcarpeta

        crear_tabla()
        Try
            MkDir(carpetadestino.Text)
        Catch ex As Exception

        End Try
        referencia.Text = "PD-CC-" + Format(fecha.Value, "dd")
        fecha.Value = Now
    End Sub

    Private Sub archivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles archivo.TextChanged
        referencia.Text = "PD-CC-" + Format(fecha.Value, "dd")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim folder As New FolderBrowserDialog
        folder.RootFolder = Me.carpetadestino.Text
        folder.ShowDialog()
        Me.carpetadestino.Text = folder.SelectedPath
        Dim adapath As New integraDataSetTableAdapters.pathsTableAdapter
        adapath.Updatepath(Me.carpetadestino.Text, 12)
        MsgBox("nueva configuracion Guardada", MsgBoxStyle.Information)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.ReportViewer1.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.ReportViewer1.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Forms.Reporte_de_Entradas.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Shell("explorer.exe root =" + Me.carpetadestino.Text, vbNormalFocus)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
