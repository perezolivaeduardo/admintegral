Public Class cxc_reportes
    Dim tabla_resumen As New DataTable
    Private Sub cxc_reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.Agentes' Puede moverla o quitarla según sea necesario.
        Me.AgentesTableAdapter.Fill(Me.admintegralDataSet.Agentes)
    End Sub

    Public Sub cargar_reporte(ByVal id As Integer, ByVal fecha As Date, ByVal fechaAL As Date)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.cxc_Reporte_de_cobranza' Puede moverla o quitarla según sea necesario.
        'Try
        Me.admintegralDataSet.cxc_Reporte_de_cobranza.Clear()
        Me.cxc_Reporte_de_cobranzaTableAdapter.FillByperiodo(Me.admintegralDataSet.cxc_Reporte_de_cobranza, id, fecha.Date, fechaAL)

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = rptlogo
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
        Me.SplitContainer1.Panel2Collapsed = False
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        id.Text = Me.NombreComboBox.SelectedValue
    End Sub

    Private Sub Boton_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_reporte.Click
        If id.Text = "" Then MsgBox("Teclee un vendedor") : Exit Sub
        Try
            cargar_reporte(id.Text, fecha.Value.Date, fechaAL.Value)
            Me.ReportViewer2.Visible = False
            Me.ReportViewer1.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ReportViewer2.Visible = True
        Me.ReportViewer1.Visible = False
        Genera_resumen(fecha.Value)
    End Sub

    Private Sub Genera_resumen(ByVal fecha As Date)

        Dim da As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        Dim cmd As String
        cmd = "SELECT   * from rpt_resumen_cobranza"
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da.Fill(tabla_resumen)

        Dim da_cobranza As New Data.SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim im(0 To 200, 0 To 15) As Double
        Dim id, fp As Integer
        cmd = "SELECT id_agente, Nombre, fp, SUM(abono) AS Importe, SUM(exento) AS exento, SUM(al10) AS al10, SUM(iva10) AS iva , sum(ieps) as ieps " _
        & "FROM cxc_Reporte_de_cobranza WHERE  (fecha_apliacion = CONVERT(DATETIME, '" + cfecha(fecha) + "', 102))" _
        & " GROUP BY id_agente, Nombre, fp, fecha"

        da_cobranza = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_cobranza.Fill(tbl)

        For j As Integer = 0 To tbl.Rows.Count - 1
            id = tbl.Rows(j).Item("id_agente")
            fp = tbl.Rows(j).Item("fp")
            Try
                im(id, fp) += tbl.Rows(j).Item("importe")
                im(id, 11) += tbl.Rows(j).Item("exento")
                im(id, 12) += tbl.Rows(j).Item("al10")
                im(id, 13) += tbl.Rows(j).Item("iva")
                im(id, 15) += tbl.Rows(j).Item("ieps")
                im(id, 14) += 1
            Catch ex As Exception

            End Try

        Next
        tabla_resumen.Clear()
        For j As Integer = 0 To 200
            If im(j, 14) > 0 Then
                Dim dr As DataRow = tabla_resumen.NewRow
                dr(0) = j
                Dim ix As Integer = Me.AgentesBindingSource.Find("id_agente", j)
                Me.AgentesBindingSource.Position = ix
                dr(1) = Me.NombreComboBox.Text
                dr(2) = im(j, 1) 'efectivo
                dr(3) = im(j, 3) 'cheque
                dr(4) = im(j, 2) ' ótros
                dr(5) = im(j, 4) + im(j, 5) 'credito y debito
                dr(6) = im(j, 6) 'nota de credito
                dr(7) = im(j, 11) 'exento
                dr(8) = im(j, 12) 'al10
                dr(9) = im(j, 13) 'iva
                dr(10) = im(j, 15) 'ieps
                tabla_resumen.Rows.Add(dr)
            End If
        Next

        Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("resumen", tabla_resumen)
        ReportViewer2.LocalReport.DataSources.Add(datasource)

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Format(fecha, "D"), False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("piva", "16", False)
        rp(2) = rptlogo
        Me.ReportViewer2.LocalReport.EnableExternalImages = True
        Me.ReportViewer2.LocalReport.SetParameters(rp)
        Me.ReportViewer2.RefreshReport()

    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim ix As Integer = Me.AgentesBindingSource.Find("id_agente", id.Text)
            If ix < 0 Then
                MsgBox("No Existe este agente")
                Me.AgentesBindingSource.Position = 0
            Else
                Me.AgentesBindingSource.Position = ix
            End If
        End If
    End Sub

    Private Sub Genera_resumen_x_iva(ByVal fecha As Date, ByVal piva As Integer)

        Dim da As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        Dim cmd As String
        cmd = "SELECT   * from rpt_resumen_cobranza"
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da.Fill(tabla_resumen)

        Dim da_cobranza As New Data.SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim im(0 To 200, 0 To 14) As Double
        Dim id, fp As Integer
        cmd = "SELECT id_agente, Nombre, fp, SUM(abono) AS Importe, SUM(exento) AS exento, SUM(al10) AS al10, SUM(iva10) AS iva " _
        & "FROM cxc_Reporte_de_cobranza WHERE  (fecha_apliacion = CONVERT(DATETIME, '" + cfecha(fecha) + "', 102)) and piva=" + piva.ToString _
        & " GROUP BY id_agente, Nombre, fp, fecha"

        da_cobranza = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_cobranza.Fill(tbl)

        For j As Integer = 0 To tbl.Rows.Count - 1
            id = tbl.Rows(j).Item("id_agente")
            fp = tbl.Rows(j).Item("fp")
            Try
                im(id, fp) += tbl.Rows(j).Item("importe")
                im(id, 11) += tbl.Rows(j).Item("exento")
                im(id, 12) += tbl.Rows(j).Item("al10")
                im(id, 13) += tbl.Rows(j).Item("iva")
                im(id, 14) += 1
            Catch ex As Exception

            End Try

        Next
        tabla_resumen.Clear()
        For j As Integer = 0 To 200
            If im(j, 14) > 0 Then
                Dim dr As DataRow = tabla_resumen.NewRow
                dr(0) = j
                Dim ix As Integer = Me.AgentesBindingSource.Find("id_agente", j)
                Me.AgentesBindingSource.Position = ix
                dr(1) = Me.NombreComboBox.Text
                dr(2) = im(j, 1) 'efectivo
                dr(3) = im(j, 3) 'cheque
                dr(4) = im(j, 2) ' ótros
                dr(5) = im(j, 4) + im(j, 5) 'credito y debito
                dr(6) = im(j, 6) 'nota de credito
                dr(7) = im(j, 11) 'exento
                dr(8) = im(j, 12) 'al10
                dr(9) = im(j, 13) 'iva
                tabla_resumen.Rows.Add(dr)
            End If
        Next

        Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("resumen", tabla_resumen)
        ReportViewer2.LocalReport.DataSources.Add(datasource)

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Format(fecha, "D"), False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("piva", piva.ToString, True)
        rp(2) = rptlogo
        Me.ReportViewer2.LocalReport.EnableExternalImages = True
        Me.ReportViewer2.LocalReport.SetParameters(rp)
        Me.ReportViewer2.RefreshReport()
    End Sub
   
    Private Sub boton_resumen_x_iva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_resumen_x_iva.Click
        Me.ReportViewer2.Visible = True
        Me.ReportViewer1.Visible = False
        Dim piva As Integer = InputBox("teclee el % de iva (10 u 11) para el reporte")
        If piva <> 10 And piva <> 11 Then MsgBox("teclee un % valido") : Exit Sub
        Genera_resumen_x_iva(fecha.Value, piva)
    End Sub

    Private Sub fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecha.ValueChanged
        fechaAL.Value = fecha.Value
    End Sub
End Class