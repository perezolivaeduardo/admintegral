Public Class surtido_sugerido

    Private Sub surtido_sugerido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.ToolStrip1.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.AlmacenComboBox.SelectedValue < 1 Then
            MsgBox("Seleccione una tienda")
            Exit Sub
        End If
        Dim alma As Integer
        alma = Me.AlmacenComboBox.SelectedValue
        Me.Surtido_sugeridoTableAdapter.FillByalmacen(Me.ReporteDataSet.surtido_sugerido, alma)
        Me.Panel1.Visible = False
        Me.ToolStrip1.Visible = True

    End Sub

    Private Sub grupotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grupotxt.TextChanged
        filtrar()
    End Sub

    Private Sub proveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedor.TextChanged
        filtrar()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Me.ReportViewer1.Visible = True
        Try
            Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Catch ex As Exception

        End Try

        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", Me.Surtido_sugeridoBindingSource.List)
        ReportViewer1.LocalReport.DataSources.Add(datasource)

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("almacen", Me.AlmacenComboBox.Text, False)
        ReportViewer1.LocalReport.EnableExternalImages = True
        rp(1) = rptlogo
        Me.ReportViewer1.LocalReport.SetParameters(rp)

        Me.ReportViewer1.RefreshReport()

        'Me.ReportViewer1.PrintDialog()
    End Sub

    Private Sub ReportViewer1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.VisibleChanged
        Me.ToolStripButton1.Visible = Not Me.ReportViewer1.Visible
        Me.btn_cerrar.Visible = Me.ReportViewer1.Visible
        If Me.ReportViewer1.Visible = True Then
            Me.ReportViewer2.Visible = False
        End If
    End Sub

    Private Sub btn_otra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_otra.Click
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = False
        Me.ToolStrip1.Visible = False
        Me.Panel1.Visible = True
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = False
    End Sub

    Private Sub minimo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimo.ValueChanged, peso.ValueChanged
        filtrar()
    End Sub

    Private Sub filtrar()
        Dim f As String
        If minimo.Value > 0 Then
            f = "sugerido >= " + minimo.Value.ToString
        Else
            If peso.Value > 0 Then
                f = "valor >= " + Me.peso.Value.ToString
            Else
                f = "sugerido >= 0"
            End If
        End If


        If grupotxt.TextLength > 0 Then
            f += " and grupo like '%" + grupotxt.Text + "%'"
        End If

        If Me.proveedor.TextLength > 0 Then
            f += " and Nombre like '%" + Me.proveedor.Text + "%'"
        End If

        Me.Surtido_sugeridoBindingSource.Filter = f
    End Sub

    Private Sub btn_relacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_relacion.Click
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        Try
            Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)
        Catch ex As Exception

        End Try
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", Me.Surtido_sugeridoBindingSource.List)
        ReportViewer2.LocalReport.DataSources.Add(datasource)

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("almacen", Me.AlmacenComboBox.Text, False)
        Me.ReportViewer2.LocalReport.SetParameters(rp)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub ReportViewer2_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer2.VisibleChanged
        Me.ToolStripButton1.Visible = Not Me.ReportViewer1.Visible
        Me.btn_cerrar.Visible = Me.ReportViewer2.Visible
        If Me.ReportViewer2.Visible = True Then
            Me.ReportViewer1.Visible = False
        End If
    End Sub
End Class