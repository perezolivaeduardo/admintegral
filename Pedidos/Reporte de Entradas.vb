Public Class Reporte_de_Entradas

    Private Sub Reporte_de_Entradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False
    End Sub



    Private Sub boton_provecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_provecho.Click

        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_documentos' Puede moverla o quitarla según sea necesario.
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        If checkpv.Checked = False Then
            Me.sql_documentosTableAdapter.FillByperiodo(Me.admintegralDataSet.sql_documentos, 1, Me.fecha_del.Value.Date, Me.fecha_al.Value.Date)
            Me.ReportViewer1.RefreshReport()

        Else
            Me.sql_documentosTableAdapter.FillByprov_periodo(Me.admintegralDataSet.sql_documentos, 1, Me.fecha_del.Value.Date, Me.fecha_al.Value.Date, Me.id_provtxt.Text)
            Me.ReportViewer1.RefreshReport()
        End If
        'pasa parametro al reporte
        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha_del", Me.fecha_del.Value.Date, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("fecha_al", Me.fecha_al.Value.Date, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Relacion de Entradas", False)
        rp(3) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.id_provtxt.Text = gprov.id
        Me.nombreprovtxt.Text = gprov.nombre
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub checkpv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkpv.CheckedChanged
        Panel1.Visible = checkpv.Checked
    End Sub

    Private Sub id_provtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_provtxt.TextChanged

    End Sub
End Class