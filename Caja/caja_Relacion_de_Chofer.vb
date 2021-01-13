Public Class caja_Relacion_de_Chofer

    Private Sub caja_Relacion_de_Chofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_documentos_clientes' Puede moverla o quitarla según sea necesario.
        s.Text = caja.SerieTextBox.Text
    End Sub

    Private Sub preparar()
        Me.sql_documentos_clientesTableAdapter.FillByrelacion_chofer(Me.admintegralDataSet.sql_documentos_clientes, fi.Text, ff.Text, s.Text)
        With Me.admintegralDataSet.sql_documentos_clientes
            For j As Integer = 0 To .Rows.Count - 1
                If .Rows(j).Item("status") = 1 Then
                    .Rows(j).Item("Importe") = 0
                End If
            Next
        End With
        Dim rp(0 To 8) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("realizado", "Realizado por " + user.nick, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("inicial", fi.Text, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("final", ff.Text, False)
        rp(3) = New Microsoft.Reporting.WinForms.ReportParameter("chofer", chofer.Text, False)
        rp(4) = New Microsoft.Reporting.WinForms.ReportParameter("ayudante", ayudante.Text, False)
        rp(5) = New Microsoft.Reporting.WinForms.ReportParameter("camion", camion.Text, False)
        rp(6) = New Microsoft.Reporting.WinForms.ReportParameter("ruta", Ruta.Text, False)
        rp(7) = New Microsoft.Reporting.WinForms.ReportParameter("serie", "Serie : " + Me.s.Text, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(8) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_ok.Click
        preparar()
    End Sub

    Private Sub caja_Relacion_de_Chofer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_salir.Click
        Me.Close()
    End Sub
End Class