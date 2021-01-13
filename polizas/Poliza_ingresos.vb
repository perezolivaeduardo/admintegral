Public Class Poliza_ingresos
    Dim Mytable As New DataTable
    Dim minipoliza As New DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        poliza(Me.fecha.Value)
        crear_poliza(False)
    End Sub

    Private Sub poliza(ByVal ini As DateTime)
        Me.grupo_poliza.Visible = True
        Dim tbl As New DataTable, cmd As String, da As New SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString
        cmd = "SELECT   SUM(sub0) AS sub0, SUM(sub10) AS sub10, SUM(iva10) AS iva10, SUM(Importe) AS importe " _
        & " FROM sql_documentos_clientes WHERE td = 6 AND status = 0 " _
        & " and fechasurtido = CONVERT(DATETIME, '" + Format(ini, "yyyy-M-dd") + "', 102) "
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(da)
        da.Fill(tbl)
        With tbl.Rows(0)
            i1.Text = Format(.Item(3), "N2")
            i2.Text = Format(.Item(0), "N2")
            i3.Text = Format(.Item(1), "N2")
            i4.Text = Format(.Item(2), "N2")
        End With

        cmd = "SELECT  SUM(exento) + SUM(al10) + SUM(iva10) AS importe " _
       & "FROM cxc_Reporte_de_cobranza WHERE  (fecha_apliacion = CONVERT(DATETIME, '" + cfecha(ini) + "', 102))"

        i5.Text = Format(leer_tabla(cmd).Rows(0).Item(0), "N2")

        cmd = "SELECT   SUM(iva10) AS iva " _
        & "FROM cxc_Reporte_de_cobranza WHERE  (fecha_apliacion = CONVERT(DATETIME, '" + cfecha(ini) + "', 102)) and piva= 10"
        Try
            i6.Text = Format(leer_tabla(cmd).Rows(0).Item(0), "N2")
        Catch ex As Exception
            i6.Text = "0.00"
        End Try


        cmd = "SELECT   SUM(iva10) AS iva " _
       & "FROM cxc_Reporte_de_cobranza WHERE  (fecha_apliacion = CONVERT(DATETIME, '" + cfecha(ini) + "', 102)) and piva= 11"
        i7.Text = Format(leer_tabla(cmd).Rows(0).Item(0), "N2")

    End Sub

    Private Sub Poliza_ingresos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DATOS_POLIZA()
    End Sub

    Private Sub DATOS_POLIZA()
        Dim a As String
        a = "poliza_I_" + Format(fecha.Value, "dd-MMM-yyyy") + ".txt"
        Me.archivo.Text = a
        Dim subcarpeta As String = Format(fecha.Value, "MMMyyyy")
        Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
        Me.carpetadestino.Text = Trim(adap.path(12)) + subcarpeta

        Try
            MkDir(carpetadestino.Text)
        Catch ex As Exception

        End Try
        referencia.Text = "PI-" + Format(fecha.Value, "dd")

    End Sub

    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        DATOS_POLIZA()
    End Sub

    Private Sub crear_poliza(ByVal anexar As Boolean)
        Dim filepoliza As String = Me.carpetadestino.Text.Trim + "\" + Me.archivo.Text.Trim
        Dim cgadap As New integraDataSetTableAdapters.sys_cgcuentasTableAdapter

        '==========================================================================================
        ' Inicia definicion de poliza
        '==========================================================================================
        Dim p As New ppoliza
        p.poliza = "P  "
        p.fecha = Format(fecha.Value, "yyyyMMdd") + " "
        p.tipo = "   1" ' Diario
        p.folio = "           "
        p.clase = "1 "
        p.iddiario = "0          "
        p.concepto = Me.concepto.Text.PadRight(101, " ")
        p.sistorig = "11 "
        p.impresa = "0 "
        p.ajuste = "0 "
        Dim encabezado As String

        'DEFINE NOMBRE DEL ARCHVIO
        Dim fp As New System.IO.StreamWriter(filepoliza, anexar)
        Dim mpoliza As String
        Dim guia As String = "P  20100517    3       239 1 0          COMPRAS A CREDITO DEL DIA                                                                            11 1 0 "
        Dim guiam As String = "M  1256000010000                  P.D.- 24   0 110718.08            0          0.0                  COMPRAS A CREDITO DEL DIA                                                                                 "

        encabezado = p.poliza + p.fecha + p.tipo + p.folio + p.clase + p.iddiario + p.concepto + p.sistorig + p.impresa + p.ajuste
        fp.WriteLine(encabezado)
        ' fp.WriteLine(guia)
        'fp.WriteLine(guiam)

        Dim pm As mpoliza

        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(7)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "0 ".PadRight(2)
        pm.importe = CDbl(i1.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)

        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(8)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "1 ".PadRight(2)
        pm.importe = CDbl(i2.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)

        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(9)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "1 ".PadRight(2)
        pm.importe = CDbl(i3.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)

        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(10)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "1 ".PadRight(2)
        pm.importe = CDbl(i4.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)

        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(7)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "1 ".PadRight(2)
        pm.importe = CDbl(i5.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)

        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(10)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "0 ".PadRight(2)
        pm.importe = CDbl(i7.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)


        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(11)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "0 ".PadRight(2)
        pm.importe = CDbl(i6.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)


        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(12)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "1 ".PadRight(2)
        pm.importe = CDbl(i6.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)

        pm.movimiento = "M  "
        pm.idcuenta = cuenta(cgadap.cta(13)).Trim.PadRight(30, " ") + " "
        pm.referencia = referencia.Text.PadRight(11)
        pm.tipomov = "1 ".PadRight(2)
        pm.importe = CDbl(i7.Text).ToString.PadRight(21)
        pm.iddiario = p.iddiario.PadRight(11)
        pm.importeme = "0.0".PadRight(21)
        pm.concepto = Me.concepto.Text.ToString.PadRight(101)
        pm.idsegneg = "     "
        mpoliza = pm.movimiento + pm.idcuenta + pm.referencia + pm.tipomov + pm.importe + pm.iddiario + pm.importeme + pm.concepto + pm.idsegneg
        fp.WriteLine(mpoliza)

        fp.Close()
        If verpoliza.Checked = True And anexar = False Then Process.Start(filepoliza)
        If anexar = False Then MsgBox("Poliza Terminada")
    End Sub

    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Shell("explorer.exe root =" + Me.carpetadestino.Text, vbNormalFocus)
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

    End Sub

    Private Sub Preparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Preparar.Click

        fecha.Value = del.Value
        While fecha.Value <= al.Value
            DATOS_POLIZA()
            poliza(Me.fecha.Value)
            archivo.Text = "poliza_ingresos" + Format(del.Value, "ddMMyyy") + "_al_" + Format(al.Value, "ddMMyyy") + ".txt"
            'determina si ensima o no la pliza
            If del.Value.ToShortDateString = al.Value.ToShortDateString Then crear_poliza(False) Else crear_poliza(True)
            fecha.Value = fecha.Value.AddDays(1)
        End While
        archivo.Text = "poliza_ingresos" + Format(del.Value, "ddMMyyy") + "_al_" + Format(al.Value, "ddMMyyy") + ".txt"
        Dim filepoliza As String = Me.carpetadestino.Text.Trim + "\" + Me.archivo.Text.Trim
        MsgBox("Poliza Terminada")
        If verpoliza.Checked = True Then Process.Start(filepoliza)
    End Sub
End Class