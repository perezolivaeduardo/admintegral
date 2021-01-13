Public Class cxc_catalogo


    Private Sub cxc_catalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AgentesTableAdapter.Fill(Me.AdmintegralDataSet.Agentes)
    End Sub

    Private Sub NombreComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.TextChanged
        Try
            Me.idagente.Text = Me.NombreComboBox.SelectedValue
        Catch ex As Exception

        End Try
        If Me.idagente.TextLength = 0 Then Exit Sub
        Dim cmd As String = "SELECT Listas.id, rtrim(Listas.Descripcion) as Descripcion FROM Directorio INNER JOIN Listas ON Directorio.Ruta = Listas.id WHERE (Directorio.tipo = 2) AND (Directorio.id_agente = [agente]) GROUP BY Listas.id, Listas.Descripcion"
        cmd = cmd.Replace("[agente]", Me.idagente.Text)
        Me.BindingSourcerutas.DataSource = leer_tabla(cmd)
        Me.ComboBox1.ValueMember = "id"
        Me.ComboBox1.DisplayMember = "Descripcion"

    End Sub

    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        Me.rpt_catalogo_clientesTableAdapter.FillByagente(Me.reporteDataSet.rpt_catalogo_clientes, Me.idagente.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub clientes_credito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clientes_credito.Click
        Me.rpt_catalogo_clientesTableAdapter.FillBycredito(Me.reporteDataSet.rpt_catalogo_clientes, Me.idagente.Text)

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", "Catalogo de clientes a Credito", False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Me.ruta.Text = Me.ComboBox1.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ruta.Click
        Me.rpt_catalogo_clientesTableAdapter.FillByagente_ruta(Me.reporteDataSet.rpt_catalogo_clientes, Me.idagente.Text, ruta.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class