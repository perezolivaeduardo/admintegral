Public Class Estadistica_de_cobranza

    Private Sub Estadistica_de_cobranza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SplitContainer2.Panel1Collapsed = False
        Me.SplitContainer2.Panel2Collapsed = True
    End Sub

    Private Sub boton_por_agente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_por_agente.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.Reportagente.Visible = True
        Me.Reportzona.Visible = False
    End Sub

    Private Sub boton_por_zona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_por_zona.Click
        Me.Reportagente.Visible = False
        Me.Reportzona.Visible = True
    End Sub

    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.rpt_cobranza_x_zona_agenteTableAdapter.FillByperiodo(Me.reporteDataSet.rpt_cobranza_x_zona_agente, del.Value.ToShortDateString, al.Value.ToShortDateString)
        Windows.Forms.Cursor.Current = Cursors.Default

        Me.SplitContainer2.Panel1Collapsed = True
        Me.SplitContainer2.Panel2Collapsed = False

        Me.Reportagente.Visible = True
        Me.Reportzona.Visible = False

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter, reporte As String
        reporte = "Reporte de cobranza por Agente del " + del.Value.ToShortDateString + " al " + al.Value.ToShortDateString
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        Me.Reportagente.LocalReport.SetParameters(rp)
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.Reportagente.RefreshReport()


        reporte = "Reporte de cobranza por Zona del " + del.Value.ToShortDateString + " al " + al.Value.ToShortDateString
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        Me.Reportzona.LocalReport.SetParameters(rp)
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.Reportzona.RefreshReport()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.SplitContainer2.Panel1Collapsed = False
        Me.SplitContainer2.Panel2Collapsed = True
        Me.Reportzona.Visible = False
        Me.Reportagente.Visible = False
    End Sub

    Private Sub boton_Esc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Esc.Click
        Me.Close()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub
End Class