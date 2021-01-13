Public Class cxc_auxiliar

    Public Sub cargar_auxiliar(ByVal id As Integer, ByVal cliente As String, ByVal saldo As String)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.cxc_auxiliar' Puede moverla o quitarla según sea necesario.
        Me.cxc_auxiliarTableAdapter.FillBy(Me.admintegralDataSet.cxc_auxiliar, id)
        'pasa parametro al reporte
        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("cliente", cliente, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("saldo", "Salddo a la fecha :" + saldo, False)
        Me.ReportViewer1.Visible = True
        Me.ReportViewer2.Visible = False
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(2) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub cargar_catalogo(ByVal agente As Integer, ByVal nombre As String)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.cxc_catalogo' Puede moverla o quitarla según sea necesario.
        Me.cxc_catalogoTableAdapter.FillByagente(Me.admintegralDataSet.cxc_catalogo, agente)
        'pasa parametro al reporte
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter

        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("agente", nombre, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer2.LocalReport.SetParameters(rp)

        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        Me.ReportViewer2.RefreshReport()
    End Sub

    Public Sub cargar_catalogo_ruta(ByVal agente As Integer, ByVal nombre As String, ByVal ruta As Integer)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.cxc_catalogo' Puede moverla o quitarla según sea necesario.
        Me.cxc_catalogoTableAdapter.FillBygrupo(Me.admintegralDataSet.cxc_catalogo, ruta, agente)
        'pasa parametro al reporte
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter

        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("agente", nombre, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer2.LocalReport.SetParameters(rp)

        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class