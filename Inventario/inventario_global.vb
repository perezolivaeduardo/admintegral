Public Class inventario_global


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim cmd As String = "", reporte As String = ""
        If chkprov.Checked = True And chkgrupo.Checked = False Then
            cmd = "SELECT grupo,id_directorio,Codigo, Descripcion, sucursal, SUM(Existencia) AS Existencia, AVG(costo) AS Costo, SUM(Existencia * costo) AS Importe " _
        & " FROM dbo.sql_Existencias_x_almacen INNER JOIN dbo.Grupos ON dbo.sql_Existencias_x_almacen.Gp = dbo.Grupos.id_grupos " _
        & "WHERE (id_Directorio = [provedor]) GROUP BY id_directorio,grupo , Codigo, Descripcion, sucursal  " _
        & "HAVING      (id_directorio = [provedor]) order by grupo,descripcion"
            cmd = cmd.Replace("[provedor]", pvtxt.Text)
            reporte = Me.provedortxt.Text
        ElseIf chkprov.Checked = True And chkgrupo.Checked = True Then
            cmd = "SELECT grupo,id_directorio,Codigo, Descripcion, sucursal, SUM(Existencia) AS Existencia, AVG(costo) AS Costo, SUM(Existencia * costo) AS Importe " _
                    & " FROM dbo.sql_Existencias_x_almacen INNER JOIN dbo.Grupos ON dbo.sql_Existencias_x_almacen.Gp = dbo.Grupos.id_grupos " _
                    & "WHERE id_Directorio = [provedor] and grupo ='[grupo]' GROUP BY id_directorio,grupo , Codigo, Descripcion, sucursal  " _
                    & "HAVING id_directorio = [provedor] and grupo ='[grupo]' order by grupo,descripcion"
            cmd = cmd.Replace("[provedor]", pvtxt.Text)
            cmd = cmd.Replace("[grupo]", Me.GrupoComboBox.Text)
            reporte = Me.provedortxt.Text + Microsoft.VisualBasic.Chr(13) + Me.GrupoComboBox.Text
        ElseIf chkprov.Checked = False And chkgrupo.Checked = True Then
            cmd = "SELECT grupo,Codigo, Descripcion, sucursal, SUM(Existencia) AS Existencia, AVG(costo) AS Costo, SUM(Existencia * costo) AS Importe " _
                                & " FROM dbo.sql_Existencias_x_almacen INNER JOIN dbo.Grupos ON dbo.sql_Existencias_x_almacen.Gp = dbo.Grupos.id_grupos " _
                                & "WHERE  grupo ='[grupo]' GROUP BY grupo , Codigo, Descripcion, sucursal  " _
                                & "HAVING grupo ='[grupo]' order by grupo,descripcion"
            cmd = cmd.Replace("[grupo]", Me.GrupoComboBox.Text)
            reporte = "Grupo : " + Me.GrupoComboBox.Text
        End If
        Dim tbl As DataTable = leer_tabla(cmd)
        Dim im(0 To tbl.Rows.Count) As Decimal
        For j As Integer = 0 To tbl.Rows.Count - 1
            Dim c As String = tbl.Rows(j).Item("codigo").ToString.Trim
            im(j) = tbl.Compute("sum(importe)", "Codigo ='" + c + "'")
        Next
        Dim i As Integer
        For i = 0 To tbl.Rows.Count - 1
            tbl.Rows(i).Item("importe") = im(i)
        Next

        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub inventario_global_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'reporteDataSet.sql_existencias_x_grupo' Puede moverla o quitarla según sea necesario.
        Me.sql_existencias_x_grupoTableAdapter.Fill(Me.reporteDataSet.sql_existencias_x_grupo)
        Me.GruposTableAdapter.Fill(Me.AdmintegralDataSet.Grupos)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Me.pvtxt.Text = gprov.id
        Me.provedortxt.Text = gprov.nombre
    End Sub

    Private Sub pvtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pvtxt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
            Try
                Me.provedortxt.Text = adap.GetDataByID(pvtxt.Text, 1).Rows(0).Item("Nombre")
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub GrupoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoComboBox.SelectedIndexChanged
        Me.gptxt.Text = Me.GrupoComboBox.SelectedValue
    End Sub

    Private Sub gptxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gptxt.KeyPress
        Me.GruposBindingSource.Position = Me.GruposBindingSource.Find("id_grupos", gptxt.Text)
    End Sub

    Private Sub gptxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gptxt.TextChanged
        If gptxt.TextLength > 0 Then
            chkgrupo.Checked = True
        Else
            chkgrupo.Checked = False
        End If
    End Sub

    Private Sub pvtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pvtxt.TextChanged
        If Me.provedortxt.TextLength > 0 Then
            chkprov.Checked = True
        Else
            chkprov.Checked = False
        End If
    End Sub


    Private Sub descripciontxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles descripciontxt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim cmd As String = "", reporte As String = ""

            cmd = "SELECT grupo,id_directorio,Codigo, Descripcion, sucursal, SUM(Existencia) AS Existencia, AVG(costo) AS Costo, SUM(Existencia * costo) AS Importe " _
        & " FROM dbo.sql_Existencias_x_almacen INNER JOIN dbo.Grupos ON dbo.sql_Existencias_x_almacen.Gp = dbo.Grupos.id_grupos " _
        & "where Descripcion like '%[descripcion]%'  GROUP BY id_directorio,grupo , Codigo, Descripcion, sucursal  " _
        & "HAVING  Descripcion like '%[descripcion]%' order by grupo,descripcion"

            cmd = cmd.Replace("[descripcion]", Me.descripciontxt.Text)
            reporte = "Descripcion : " + Me.descripciontxt.Text

            Dim tbl As DataTable = leer_tabla(cmd)
            Dim im(0 To tbl.Rows.Count) As Decimal
            For j As Integer = 0 To tbl.Rows.Count - 1
                Dim c As String = tbl.Rows(j).Item("codigo").ToString.Trim
                im(j) = tbl.Compute("sum(importe)", "Codigo ='" + c + "'")
            Next
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                tbl.Rows(i).Item("importe") = im(i)
            Next

            Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
            Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tabla", tbl)
            ReportViewer1.LocalReport.DataSources.Add(datasource)

            Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
            Me.ReportViewer1.LocalReport.SetParameters(rp)
            Me.ReportViewer1.RefreshReport()
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
        End If
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
End Class