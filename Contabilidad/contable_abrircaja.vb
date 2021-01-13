Public Class contable_abrircaja
    Dim bs As New BindingSource
    Dim tbl As DataTable
    Dim fechareporte As Date = Now.Date

    Private Sub contable_abrircaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.AdmintegralDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.log_cajas' Puede moverla o quitarla según sea necesario.
        Me.Log_cajasTableAdapter.Fill(Me.AdmintegralDataSet.log_cajas)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        filtrar()
    End Sub
    Private Sub filtrar()
        Dim filtro As String = "fecha = '" + fechareporte + "'"
        Me.Log_cajasBindingSource.Filter = filtro
        consultar(fechareporte)
        If Me.Log_cajasDataGridView.Rows.Count = 0 Then Exit Sub
        bs.Filter = "ncaja = " + Me.Log_cajasDataGridView.CurrentRow.Cells("idcaja").Value.ToString
        Me.Text = "Resumen de caja del dia " + Format(fechareporte, "d")
    End Sub

    Private Sub consultar(ByVal fecha As Date)
        Dim cmd As String
        Dim fecha1 As String = Format(Date.Now, "yyyy/MM/dd")
        'sleccionar resumen de los pag
        'cmd = "SELECT dbo.Pagos.caja, dbo.cajas.Nombre as ncaja, dbo.tbl_formasdepago.id_fp AS ID, dbo.tbl_formasdepago.Descripcion, SUM(dbo.pagos_detalle.abono) AS Importe FROM dbo.Pagos INNER JOIN " _
        '& "dbo.pagos_detalle ON dbo.Pagos.id_pago = dbo.pagos_detalle.id_pago INNER JOIN dbo.tbl_formasdepago ON dbo.Pagos.id_fp = dbo.tbl_formasdepago.id_fp INNER JOIN " _
        '& " dbo.usuarios ON dbo.Pagos.id_user = dbo.usuarios.id_usuario INNER JOIN dbo.cajas ON dbo.Pagos.caja = dbo.cajas.id_caja " _
        '& " GROUP BY dbo.tbl_formasdepago.id_fp, dbo.Pagos.caja, dbo.Pagos.fecha, dbo.tbl_formasdepago.Descripcion, dbo.cajas.Nombre " _
        '& "HAVING (dbo.Pagos.fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102))"
        cmd = "SELECT dbo.Documentos.ncaja,dbo.Documentos.id_cartera as ID, dbo.tbl_tipoventa.Descripcion, SUM(dbo.Documentos.Importe) AS Importe FROM dbo.Documentos INNER JOIN "
        cmd += "dbo.tbl_tipoventa ON dbo.Documentos.id_cartera = dbo.tbl_tipoventa.tipo_venta WHERE dbo.Documentos.status = 0 and dbo.Documentos.id_cartera < 3 "
        cmd += "GROUP BY dbo.Documentos.ncaja,dbo.Documentos.id_cartera, dbo.Documentos.serie, dbo.Documentos.fechafactura, dbo.tbl_tipoventa.Descripcion "
        cmd += "HAVING dbo.Documentos.fechafactura = CONVERT(DATETIME, '" + fecha1 + "', 102) "
        cmd += " ORDER BY dbo.Documentos.id_cartera,Documentos.ncaja"
        tbl = leer_tabla(cmd)
        bs.DataSource = tbl
        Me.dgvpagos.DataSource = bs
        With dgvpagos
            .Columns("importe").DefaultCellStyle.Format = "N2"
            .Columns("importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = True
        End With

    End Sub


    Private Sub Log_cajasDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Log_cajasDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Me.ReportViewer1.Visible = False Then
            Me.Close()
        Else
            sfecha.Enabled = True
            Me.ReportViewer1.Visible = False
        End If
    End Sub


    Private Sub Log_cajasDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Log_cajasDataGridView.CellContentClick
        bs.Filter = "ncaja = " + Me.Log_cajasDataGridView.CurrentRow.Cells("idcaja").Value.ToString
    End Sub

    Private Sub Log_cajasDataGridView_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Log_cajasDataGridView.RowEnter
        Try
            bs.Filter = "ncaja = " + Me.Log_cajasDataGridView.CurrentRow.Cells("idcaja").Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub boton_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_imprimir.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        If Me.ReportViewer1.Visible = False Then
            Genera_resumen(fechareporte)
            Me.ReportViewer1.Dock = DockStyle.Fill
            Me.ReportViewer1.Refresh()
            Me.ReportViewer1.Visible = True
            sfecha.Enabled = False
        Else
            sfecha.Enabled = True
            Me.ReportViewer1.Visible = False
        End If
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub Genera_resumen(ByVal fecha As Date)

        Dim da As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        Dim cmd As String, tabla_resumen As New DataTable
        cmd = "SELECT * from rpt_resumen_cobranza"
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da.Fill(tabla_resumen)
        Dim da_cobranza As New Data.SqlClient.SqlDataAdapter
        Dim tbl As New DataTable, im(0 To 200, 0 To 14) As Double, id, fp As Integer, nombres(0 To 200)

        cmd = "SELECT dbo.Pagos.caja as id, rtrim(dbo.cajas.Nombre) +' / '+ rtrim(dbo.usuarios.Nombre) as Caja,  dbo.tbl_formasdepago.id_fp AS fp, SUM(dbo.pagos_detalle.abono) AS Importe FROM dbo.Pagos INNER JOIN " _
        & "dbo.pagos_detalle ON dbo.Pagos.id_pago = dbo.pagos_detalle.id_pago AND dbo.Pagos.caja = dbo.pagos_detalle.caja INNER JOIN dbo.tbl_formasdepago ON dbo.Pagos.id_fp = dbo.tbl_formasdepago.id_fp INNER JOIN " _
        & " dbo.usuarios ON dbo.Pagos.id_user = dbo.usuarios.id_usuario INNER JOIN dbo.cajas ON dbo.Pagos.caja = dbo.cajas.id_caja " _
        & " where dbo.pagos.agente <>100 " _
                & " GROUP BY dbo.tbl_formasdepago.id_fp, dbo.Pagos.caja, dbo.Pagos.fecha, dbo.tbl_formasdepago.Descripcion, dbo.usuarios.Nombre, dbo.cajas.Nombre " _
        & "HAVING  (dbo.Pagos.fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy/M/dd") + "', 102))"

        da_cobranza = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_cobranza.Fill(tbl)

        For j As Integer = 0 To tbl.Rows.Count - 1
            id = tbl.Rows(j).Item("id")
            fp = tbl.Rows(j).Item("fp")
            nombres(id) = tbl.Rows(j).Item("caja")
            im(id, fp) += tbl.Rows(j).Item("importe")
            im(id, 14) += 1
        Next
        tabla_resumen.Clear()
        For j As Integer = 0 To 200
            If im(j, 14) > 0 Then
                Dim dr As DataRow = tabla_resumen.NewRow
                dr(0) = j
                dr(1) = nombres(j)
                dr(2) = im(j, 1) 'efectivo
                dr(3) = im(j, 3) 'cheque
                dr(4) = im(j, 2) ' ótros
                dr(5) = im(j, 4) + im(j, 5) 'credito y debito
                dr(6) = im(j, 6) 'nota de credito
                dr(7) = im(j, 11) 'exento
                tabla_resumen.Rows.Add(dr)
            End If
        Next

        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("resumen", tabla_resumen)
        ReportViewer1.LocalReport.DataSources.Add(datasource)

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Format(fecha, "D"), False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub boton_abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_abrir.Click
        Dim x1 As usuario = autoriza_funcion(4) ' abrir caja
        If x1.id = 0 Then Exit Sub
        Me.Log_cajasDataGridView.CurrentRow.Cells("dgvcerrada").Value = False
        Me.Validate()
        Me.Log_cajasBindingSource.EndEdit()
        Me.Log_cajasTableAdapter.Update(Me.AdmintegralDataSet.log_cajas)
        MsgBox("recuerde que debe de cancelar la factura de ventas al publico en General")
    End Sub 'Abrir Caja

   
    Private Sub sfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sfecha.ValueChanged
        If sfecha.Value > Now.Date Then MsgBox("La fecha debe ser menor a hoy") : Exit Sub
        fechareporte = sfecha.Value.Date : filtrar()
        boton_abrir.Enabled = fechareporte = Now.Date
    End Sub 'cambiar fecha

   

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_refresh.Click
        Me.Log_cajasTableAdapter.Fill(Me.AdmintegralDataSet.log_cajas)
        filtrar() : Dim cmd As String : Dim fecha1 As String = Format(Date.Now, "yyyy/MM/dd")
        cmd = "SELECT tbl_retiros.caja, cajas.Nombre, SUM(tbl_retiros.importe) AS Importe, SUM(tbl_retiros.vales) AS vales, SUM(tbl_retiros.dolares) AS DLLS "
        cmd += " FROM tbl_retiros INNER JOIN cajas ON tbl_retiros.caja = cajas.id_caja WHERE "
        cmd += " (tbl_retiros.fecha >  CONVERT(DATETIME, '" + fecha1 + " 00:00:00', 102)) AND (tbl_retiros.fecha < CONVERT(DATETIME, '" + fecha1 + " 23:00:00', 102))"
        cmd = "GROUP BY tbl_retiros.caja, cajas.Nombre"
    End Sub
End Class