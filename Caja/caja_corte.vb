Imports System.Object
Public Class caja_corte
    Dim tblmonedas As New DataTable
    Dim total_retirado As Double
    Private Sub calcular()
        Dim DA As New Data.SqlClient.SqlDataAdapter
        Dim DAcob As New Data.SqlClient.SqlDataAdapter
        Dim dm As New Data.SqlClient.SqlDataAdapter
        Dim daretiros As New Data.SqlClient.SqlDataAdapter
        Dim adaplog As New Data.SqlClient.SqlDataAdapter

        Dim cmd As String, tbl As New DataTable, tblcobrado As New DataTable
        Dim tblresumen As New DataTable
        Dim DAresumen As New Data.SqlClient.SqlDataAdapter
        Dim tblfolios As New DataTable
        Dim dafolios As New Data.SqlClient.SqlDataAdapter
        Dim tblretiros As New DataTable
        Dim tbllog As New DataTable
        Dim fecha As String = Format(Date.Now, "yyyy/MM/dd")

        ' resumen por documento
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT dbo.tbl_Tipodoc.Descripciom AS Documento, dbo.tbl_tipoventa.Descripcion AS Forma, SUM(dbo.Documentos.Importe) AS Importe "
        cmd += " FROM dbo.Documentos INNER JOIN dbo.tbl_Tipodoc ON dbo.Documentos.td = dbo.tbl_Tipodoc.td INNER JOIN "
        cmd += "dbo.tbl_tipoventa ON dbo.Documentos.id_cartera = dbo.tbl_tipoventa.tipo_venta"
        cmd += " WHERE Documentos.td > 4 and dbo.tbl_tipoventa.tipo_venta < 3 "
        cmd += "GROUP BY Documentos.ncaja, Documentos.fechafactura, Documentos.status, dbo.tbl_Tipodoc.Descripciom, dbo.tbl_tipoventa.Descripcion "
        cmd += " HAVING   Documentos.ncaja = " + My.Settings.ncaja.ToString + " AND Documentos.fechafactura = CONVERT(DATETIME, '" + fecha + "', 102) AND Documentos.status = 0"
        DA = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(DA)
        DA.Fill(tbl)
        dgv.DataSource = tbl

        'resumen formas de pago
        'cmd = "SELECT tbl_formasdepago.id_fp as ID ,tbl_formasdepago.Descripcion, SUM(pagos_detalle.abono) AS Importe FROM Pagos INNER JOIN "
        'cmd += " pagos_detalle ON Pagos.id_pago = pagos_detalle.id_pago INNER JOIN tbl_formasdepago ON Pagos.id_fp = tbl_formasdepago.id_fp"
        'cmd += " GROUP BY  tbl_formasdepago.id_fp,Pagos.caja, Pagos.fecha, tbl_formasdepago.Descripcion "
        'cmd += " HAVING Pagos.fecha = CONVERT(DATETIME, '" + fecha + "', 102) AND Pagos.caja = " + My.Settings.ncaja.ToString

        cmd = "SELECT dbo.Documentos.id_cartera as ID, dbo.tbl_tipoventa.Descripcion, SUM(dbo.Documentos.Importe) AS Importe FROM dbo.Documentos INNER JOIN "
        cmd += "dbo.tbl_tipoventa ON dbo.Documentos.id_cartera = dbo.tbl_tipoventa.tipo_venta WHERE (dbo.Documentos.td>=5 and dbo.Documentos.td<8) and dbo.Documentos.status = 0 and dbo.Documentos.id_cartera < 3 "
        cmd += "GROUP BY dbo.Documentos.id_cartera, dbo.Documentos.serie, dbo.Documentos.fechafactura, dbo.tbl_tipoventa.Descripcion, dbo.Documentos.ncaja "
        cmd += "HAVING  dbo.Documentos.fechafactura = CONVERT(DATETIME, '" + fecha + "', 102) AND Documentos.ncaja = " + My.Settings.ncaja.ToString
        cmd += " ORDER BY dbo.Documentos.id_cartera,Documentos.ncaja"

        DAcob = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        DAcob.Fill(tblcobrado)
        Me.dgcobrado.DataSource = tblcobrado

        cmd = "Select * From tbl_monedas"
        dm = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        dm.Fill(tblmonedas)

        ' and add to DataTable.    
        Dim column = New DataColumn()
        column.DataType = System.Type.GetType("System.Double")
        column.ColumnName = "Importe"
        column.Caption = "Importe" + column.ColumnName
        column.Expression = "denominacion * cantidad"
        column.DefaultValue = 0
        tblmonedas.Columns.Add(column)

        Me.dgvmoneda.DataSource = tblmonedas

        Me.dgcobrado.Columns(2).DefaultCellStyle.Format = "N2"
        Me.dgcobrado.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgcobrado.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dgv.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.dgv.Columns(1).DefaultCellStyle.Format = "N2"
        Me.dgv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        With Me.dgvmoneda
            .AutoResizeColumns()
            .Columns(0).HeaderText = "Denom."
            .Columns(0).DefaultCellStyle.Format = "N2"
            .Columns(1).DefaultCellStyle.Format = "N"
            .Columns(2).DefaultCellStyle.Format = "N"
            .Columns(0).ReadOnly = True
            .Columns(2).ReadOnly = True
            Me.dgvmoneda.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Me.dgvmoneda.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Me.dgvmoneda.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        End With
        'Folios
        cmd = "SELECT tbl_Tipodoc.Descripciom, tbl_status.status, COUNT(Documentos.Folio) AS Cant, SUM(Documentos.Importe) AS Importe "
        cmd += "FROM Documentos INNER JOIN tbl_Tipodoc ON Documentos.td = tbl_Tipodoc.td INNER JOIN "
        cmd += " tbl_status ON Documentos.status = tbl_status.idstatus "
        cmd += "WHERE Documentos.fechafactura = CONVERT(DATETIME, '" + fecha + "', 102) AND Documentos.ncaja = " + My.Settings.ncaja.ToString
        cmd += "GROUP BY Documentos.td, tbl_Tipodoc.Descripciom, tbl_status.idstatus, tbl_status.status HAVING(Documentos.td > 4)"
        DAresumen = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        DAresumen.Fill(tblresumen)
        dgvresumen.DataSource = tblresumen
        dgvresumen.Columns(3).DefaultCellStyle.Format = "N2"
        dgvresumen.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        '===============================================================================================================0
        '          Folios
        '===============================================================================================================0

        cmd = "SELECT tbl_Tipodoc.Descripciom as documento, min(Documentos.Folio) as Inicial,max(Documentos.folio) as Final "
        cmd += "FROM Documentos INNER JOIN tbl_Tipodoc ON Documentos.td = tbl_Tipodoc.td INNER JOIN "
        cmd += " tbl_status ON Documentos.status = tbl_status.idstatus "
        cmd += "WHERE Documentos.fechafactura = CONVERT(DATETIME, '" + fecha + "', 102) AND Documentos.ncaja = " + My.Settings.ncaja.ToString
        cmd += "GROUP BY Documentos.td, tbl_Tipodoc.Descripciom HAVING(Documentos.td > 4)"
        dafolios = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        dafolios.Fill(tblfolios)
        dgvfolios.DataSource = tblfolios


        '*******************Retiros
        cmd = "SELECT dbo.tbl_retiros.fecha, dbo.tbl_retiros.importe+dbo.tbl_retiros.vales as Importe, dbo.usuarios.Nombre"
        cmd += " FROM dbo.usuarios INNER JOIN dbo.tbl_retiros ON dbo.usuarios.id_usuario = dbo.tbl_retiros.id_usuario "
        cmd += "WHERE (CONVERT(varchar, fecha, 3) = '" + Format(Date.Now, "dd/MM/yy") + "') AND caja = " + My.Settings.ncaja.ToString
        daretiros = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        daretiros.Fill(tblretiros)
        Try 'lee total retirado y agrega renglon a tabla de monedas
            total_retirado = tblretiros.Compute("sum(importe)", "")
            Dim nrt As DataRow
            nrt = tblmonedas.NewRow
            nrt(0) = 1
            nrt(1) = total_retirado * 1
            tblmonedas.Rows.Add(nrt)
        Catch ex As Exception

        End Try

        Try
            Dim c As Double = tblcobrado.Compute("sum(importe)", "")
            Cobrado.Text = Format(c, "N2")
        Catch ex As Exception

        End Try

        cmd = "SELECT * "
        cmd += " FROM log_cajas "
        cmd += "WHERE (CONVERT(varchar, fecha, 3) = '" + Format(Date.Now, "dd/MM/yy") + "') AND id_caja = " + My.Settings.ncaja.ToString
        adaplog = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        adaplog.Fill(tbllog)
        Try
            foliotxt.Text = tbllog.Rows(0).Item("folio")
            serietxt.Text = tbllog.Rows(0).Item("serief")
        Catch ex As Exception

        End Try


        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)

        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("datos", tblfolios)
        Dim datasource1 = New Microsoft.Reporting.WinForms.ReportDataSource("fpago", tblcobrado)
        Dim datasource2 = New Microsoft.Reporting.WinForms.ReportDataSource("Documentos", tbl)
        Dim datasource3 = New Microsoft.Reporting.WinForms.ReportDataSource("monedas", tblmonedas)
        Dim datasource4 = New Microsoft.Reporting.WinForms.ReportDataSource("retiros", tblretiros)
        Dim datasource5 = New Microsoft.Reporting.WinForms.ReportDataSource("log", tbllog)

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter

        Dim reporte, cajero As String
        reporte = "Caja #" + My.Settings.ncaja.ToString
        cajero = user.nombre + "(" + user.id.ToString + ")"
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("caja", reporte, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("cajero", cajero, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(2) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        ReportViewer1.LocalReport.DataSources.Add(datasource1)
        ReportViewer1.LocalReport.DataSources.Add(datasource2)
        ReportViewer1.LocalReport.DataSources.Add(datasource3)
        ReportViewer1.LocalReport.DataSources.Add(datasource4)
        ReportViewer1.LocalReport.DataSources.Add(datasource5)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub caja_corte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        calcular()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dgvmoneda_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmoneda.CellEndEdit
        Try
            Me.tblmonedas.AcceptChanges()
            Dim cc As Double = tblmonedas.Compute("sum(Importe)", "")
            reportadotxt.Text = Format(cc, "N2")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvmoneda_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmoneda.CellValueChanged
        Try
            Me.tblmonedas.AcceptChanges()
            Dim cc As Double = tblmonedas.Compute("sum(Importe)", "")
            reportadotxt.Text = Format(cc, "N2")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Dim db As String = Mid(My.Settings.AdmintegralConnectionString, 1, InStr(My.Settings.AdmintegralConnectionString.ToString, ";"))
        If esterminal Then My.Forms.Exportar_Informacion.Show()
        Me.Close()
    End Sub

    Private Sub Boton_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ReportViewer1.PrintDialog()
    End Sub

    Private Sub reportadotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportadotxt.TextChanged
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub boton_facturadia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_facturadia.Click

        My.Forms.factura_global.cargar_movimientos(Now.Date)
        My.Forms.factura_global.Show()

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Dim adap As New admintegralDataSetTableAdapters.log_cajasTableAdapter
        adap.log_caja_abrir_caja(My.Settings.ncaja, Now.Date)
    End Sub
End Class