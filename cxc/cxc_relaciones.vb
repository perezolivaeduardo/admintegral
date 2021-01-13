Public Class cxc_relaciones
    Dim bsclientes As New BindingSource
    Dim bsfacturas As New BindingSource
    Dim dsfac As New DataSet("Auxiliar")
    Dim tblsaldos As DataTable = dsfac.Tables.Add("tblsaldos")
    Dim tblfacturas As DataTable = dsfac.Tables.Add("tblfacturas")

    Private Sub cxc_liquidaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Agentes' Puede moverla o quitarla según sea necesario.
        Me.AgentesTableAdapter.Fill(Me.AdmintegralDataSet.Agentes)
        Me.id_agente.Text = Me.NombreComboBox.SelectedValue
        Me.ReportViewer.RefreshReport()
        Me.ReportViewer.RefreshReport()
        idtxt.Focus()
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        id_agente.Text = Me.NombreComboBox.SelectedValue
    End Sub

    Private Sub boton_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Ok.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.SplitContainer1.Panel2Collapsed = False
        If id_agente.TextLength = 0 Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        tblsaldos.Clear()
        tblfacturas.Clear()
        cargar(id_agente.Text)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Listas' Puede moverla o quitarla según sea necesario.
        Me.ListasTableAdapter.FillBylista(Me.AdmintegralDataSet.Listas, id_agente.Text)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.bsclientes.Filter = ""
    End Sub 'quitar filtor

    Private Sub boton_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_select.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'bsfacturas.Filter = ""
        'bsclientes.Filter = ""
        For j As Integer = 0 To Me.dgvClientes.Rows.Count - 1
            'Me.dgvClientes.Rows(j).Cells(0).Value = True
            tblsaldos.Rows(j).Item(0) = 1
        Next
        dgvfacturas.SuspendLayout()
        For j As Integer = 0 To tblfacturas.Rows.Count - 1
            'Me.dgvfacturas.Rows(j).Cells("s").Value = True
            tblfacturas.Rows(j).Item("s") = 1
        Next
        dgvfacturas.ResumeLayout()
        tblsaldos.AcceptChanges()
        contar_facturas()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'Seleccionar Todo

    Private Sub boton_deselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_deselect.Click
        For j As Integer = 0 To Me.dgvClientes.Rows.Count - 1
            Me.dgvClientes.Rows(j).Cells(0).Value = False
        Next
        For j As Integer = 0 To tblfacturas.Rows.Count - 1
            tblfacturas.Rows(j).Item("s") = 0
        Next
        contar_facturas()
    End Sub ' Quitar Seleccion

    Private Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If Me.dgvfacturas.Rows.Count = 0 Then Exit Sub
        If Me.dgvClientes.CurrentRow.Cells(0).Value = False Then
            Me.dgvClientes.CurrentRow.Cells(0).Value = True
            For j As Integer = 0 To Me.dgvfacturas.Rows.Count - 1
                dgvfacturas.Rows(j).Cells(0).Value = True
            Next
        Else
            Me.dgvClientes.CurrentRow.Cells(0).Value = 0
            For j As Integer = 0 To Me.dgvfacturas.Rows.Count - 1
                dgvfacturas.Rows(j).Cells(0).Value = False
            Next
        End If

        Try
            Me.dgvfacturas.Refresh()
            tblfacturas.AcceptChanges()
            contar_facturas()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        Try
            If solosaldos.Checked = True Then
                bsfacturas.Filter = "id_directorio =" + Me.dgvClientes.CurrentRow.Cells("id").Value.ToString + " and saldo > .2"
            Else
                bsfacturas.Filter = "id_directorio =" + Me.dgvClientes.CurrentRow.Cells("id").Value.ToString
            End If
        Catch ex As Exception
        End Try
        '  contar_facturas()
    End Sub

    Private Sub cargar(ByVal agente As Integer)
        'Carga los clientes del agente
        Dim da_saldos As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString

        Dim cmd As String
        Dim fromtxt As String = "from  dbo.cxc_saldos INNER JOIN dbo.cxc_saldos_x_factura ON dbo.cxc_saldos.id_directorio = dbo.cxc_saldos_x_factura.id_directorio"

        If Me.chktodas.Checked = False Then
            If Me.chkseleccion.Checked = True Then
                cmd = "SELECT 1 as s,dbo.cxc_saldos.Id_directorio as ID,dbo.cxc_saldos.Nombre,max(dbo.cxc_saldos.saldo) as Saldo,dbo.cxc_saldos.ruta " + fromtxt + " where dbo.cxc_saldos.saldo>0 and dbo.cxc_saldos.id_agente = " + agente.ToString
            Else
                cmd = "SELECT 0 as s,dbo.cxc_saldos.Id_directorio as ID,dbo.cxc_saldos.Nombre,max(dbo.cxc_saldos.saldo) as Saldo,dbo.cxc_saldos.ruta " + fromtxt + " where dbo.cxc_saldos.saldo>0 and dbo.cxc_saldos.id_agente = " + agente.ToString
            End If
        Else
            If Me.chkseleccion.Checked = True Then
                cmd = "SELECT 1 as s,dbo.cxc_saldos.Id_directorio as ID,dbo.cxc_saldos.Nombre,max(dbo.cxc_saldos.saldo) as Saldo,dbo.cxc_saldos.ruta " + fromtxt + " where dbo.cxc_saldos.id_agente = " + agente.ToString
            Else
                cmd = "SELECT 0 as s,dbo.cxc_saldos.Id_directorio as ID,dbo.cxc_saldos.Nombre,max(dbo.cxc_saldos.saldo) as Saldo,dbo.cxc_saldos.ruta " + fromtxt + " where dbo.cxc_saldos.id_agente = " + agente.ToString
            End If
        End If
        If Val(diasvencidos.Text) Then
            cmd += "and (dbo.cxc_saldos_x_factura.Saldo > .2) and  (dbo.cxc_saldos_x_factura.Dias >" + diasvencidos.Text + ") "
        End If
        cmd += " GROUP BY dbo.cxc_saldos.id_directorio, dbo.cxc_saldos.Nombre, dbo.cxc_saldos.ruta"

        da_saldos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_saldos.Fill(dsfac.Tables("tblsaldos"))

        Me.bsclientes.Filter = ""
        bsclientes.DataSource = dsfac.Tables("tblsaldos")

        Me.dgvClientes.DataSource = bsclientes
        Me.bsclientes.Filter = ""
        Me.dgvClientes.Columns("saldo").DefaultCellStyle.Format = "N2"
        Me.dgvClientes.Columns("ruta").Visible = False

        Me.dgvClientes.Columns.RemoveAt(0)
        Dim column As New DataGridViewCheckBoxColumn
        With column
            .Name = "S"
            .HeaderText = "S"
            .DataPropertyName = "S"
        End With
        Me.dgvClientes.Columns.Insert(0, column)
        dgvClientes.Columns(0).ReadOnly = True
        cargar_facturas() 'Cargar con clientes clientes
    End Sub

    Private Sub cargar_facturas()
        If Me.dgvClientes.Rows.Count = 0 Then Exit Sub
        Dim da_facturas As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        Dim cmd As String
        'If Me.chkseleccion.Checked = True Then 'si selecciona por default todo los registros
        '    cmd = "UPDATE  [integra].[dbo].[tmp_relaciones] set [s] = 1"
        'Else
        '    cmd = "UPDATE  [integra].[dbo].[tmp_relaciones] set [s] = 0"
        'End If
        'comando(cmd) ' Ejecuta un comando sobre la conection string 

        cmd = "SELECT 0 as s , dbo.cxc_saldos_x_factura.id_directorio,  dbo.cxc_saldos_x_factura.Nombre, dbo.cxc_saldos_x_factura.Folio, dbo.cxc_saldos_x_factura.serie, dbo.cxc_saldos_x_factura.fecha, "
        cmd += "dbo.cxc_saldos_x_factura.vence, dbo.cxc_saldos_x_factura.Importe, dbo.cxc_saldos_x_factura.Abonos, dbo.cxc_saldos_x_factura.Saldo,dbo.cxc_saldos_x_factura.Dias,dbo.cxc_saldos_x_factura.saldo_total,dbo.cxc_saldos_x_factura.Disponible, dbo.cxc_saldos_x_factura.FUPAGO as UPago, dbo.cxc_saldos_x_factura.Direccion " _
        & " FROM dbo.cxc_saldos_x_factura where "
        Dim mifiltro As String = "id_agente = " + Me.idtxt.Text + " "

        If solosaldos.Checked = True Then
            mifiltro += " and dbo.cxc_saldos_x_factura.saldo > .2 "
        End If

        If Val(Me.diasvencidos.Text) > 0 Then
            mifiltro += " and dias > " + Me.diasvencidos.Text
        End If

        If Me.chkruta.Checked = True Then
            mifiltro += " And ruta = " + Me.rutatxt.Text + " "
        End If

        cmd = cmd + mifiltro + "order by id_directorio,vence ,dbo.cxc_saldos_x_factura.Folio"
        da_facturas = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_facturas.Fill(dsfac.Tables("tblfacturas"))
        bsfacturas.DataSource = dsfac.Tables("tblfacturas")
        dgvfacturas.DataSource = bsfacturas

        dgvfacturas.Columns("importe").DefaultCellStyle.Format = "N2"
        dgvfacturas.Columns("abonos").DefaultCellStyle.Format = "N2"
        dgvfacturas.Columns("saldo").DefaultCellStyle.Format = "N2"
        Me.dgvfacturas.Columns(11).Visible = False
        Me.dgvfacturas.Columns(12).Visible = False

        Me.dgvfacturas.Columns.RemoveAt(0)
        Dim column As New DataGridViewCheckBoxColumn
        With column
            .Name = "S"
            .HeaderText = "S"
            .DataPropertyName = "S"
        End With
        Me.dgvfacturas.Columns.Insert(0, column)
        Me.dgvfacturas.Columns(1).Visible = False
        Me.dgvfacturas.Columns(2).Visible = False
        Me.dgvfacturas.Columns("S").ReadOnly = True
        For j As Integer = 1 To Me.dgvClientes.Columns.Count - 1
            Me.dgvClientes.Columns(j).ReadOnly = True
        Next

        For j As Integer = 1 To Me.dgvfacturas.Columns.Count - 1
            Me.dgvfacturas.Columns(j).ReadOnly = True
        Next
        Dim cli As Integer
        For j As Integer = 0 To tblfacturas.Rows.Count - 1
            If tblfacturas.Rows(j).Item("s") = True Then
                cli = tblfacturas.Rows(j).Item("id_directorio")
                Dim ix As Integer = bsclientes.Find("id", cli)
                Try
                    tblsaldos.Rows(ix).Item("s") = True
                Catch ex As Exception

                End Try

            End If
        Next
        contar_facturas()
    End Sub

    Private Sub NombreComboBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.Enter, id_agente.Enter
        Me.SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub boton_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_reporte.Click
        Me.ReportViewer.Parent = Me
        Me.ReportViewer.Top = 80
        Me.SplitContainer1.Visible = False
        Me.ReportViewer.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("facturas", dsfac.Tables("tblfacturas"))

        'pasa parametro al reporte
        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter

        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("titulo", "Relacion de Cobranza", False)
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("vendedor", "Vendedor # " + Me.id_agente.Text.ToString + ".- " + NombreComboBox.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", "Fecha de corte " + Format(Me.fecha_corte.Value, "D"), False)
        If solosaldos.Checked = True Then
            rp(3) = New Microsoft.Reporting.WinForms.ReportParameter("saldominimo", 1, False)
        Else
            rp(3) = New Microsoft.Reporting.WinForms.ReportParameter("saldominimo", -1, False)
        End If

        Me.ReportViewer.LocalReport.SetParameters(rp)

        ReportViewer.LocalReport.DataSources.Add(datasource)
        ReportViewer.Visible = True
        ReportViewer.RefreshReport()
        ReportViewer.Show()
        'bsfacturas.Filter = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.dgvfacturas.Rows.Count = 0 Then Exit Sub
        For j As Integer = 0 To Me.dgvfacturas.Rows.Count - 1
            Me.dgvfacturas.Rows(j).Cells("s").Value = True
        Next
        contar_facturas()
    End Sub 'Seleccionar todas las facturas

    Private Sub Boton_quitar_Seleccion_facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_quitar_Seleccion_facturas.Click
        If Me.dgvfacturas.Rows.Count = 0 Then Exit Sub
        For j As Integer = 0 To Me.dgvfacturas.Rows.Count - 1
            Me.dgvfacturas.Rows(j).Cells(0).Value = False
        Next
        contar_facturas()
    End Sub

    Private Sub contar_facturas()
        Dim x As Integer = 0
        tblfacturas.AcceptChanges()
        Try
            x = Me.tblfacturas.Compute("count(s)", "s = true ")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label2.Text = x.ToString + " Facturas Seleccionadas de " + Str(tblfacturas.Rows.Count)
        If x > 0 Then
            Me.boton_reporte.Enabled = True
        Else
            Me.boton_reporte.Enabled = False
        End If
    End Sub ' conntar Facturas

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.ReportViewer.Visible = True Then
            Me.ReportViewer.Visible = False
            Me.SplitContainer1.Visible = True
            Me.SplitContainer1.Panel2Collapsed = False
        Else
            Me.Close()
        End If
    End Sub

    Private Sub dgvClientes_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvClientes.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bsclientes.Filter = "S = true"
    End Sub

    Private Sub filtroclientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtroclientes.TextChanged
        Dim f As String
        f = "id = " + Val(filtroclientes.Text).ToString + " or nombre like '%" + filtroclientes.Text + "%'"
        bsclientes.Filter = f
    End Sub

    Private Sub dgvfacturas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfacturas.CellDoubleClick
        If dgvfacturas.CurrentRow.Cells(0).Value = False Then
            dgvfacturas.CurrentRow.Cells(0).Value = True
        Else
            dgvfacturas.CurrentRow.Cells(0).Value = False
        End If
        contar_facturas()
    End Sub

    Private Sub idtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idtxt.KeyPress
        If e.KeyChar = chr13 Then
            Dim ix As Integer = Me.AgentesBindingSource.Find("id_agente", idtxt.Text)
            If ix < 0 Then MsgBox("No Exste") : Exit Sub
            Me.AgentesBindingSource.Position = ix
            Me.SplitContainer1.Panel2Collapsed = False
            If id_agente.TextLength = 0 Then Exit Sub
            tblsaldos.Clear()
            tblfacturas.Clear()
            'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Listas' Puede moverla o quitarla según sea necesario.
            Me.ListasTableAdapter.FillBylista(Me.AdmintegralDataSet.Listas, id_agente.Text)
            Me.boton_Ok.Enabled = True
        End If
    End Sub

    Private Sub guardar_relacion()
        Dim file As String
        Dim adap1 As New admintegralDataSetTableAdapters.pathsTableAdapter
        file = adap1.path(6)
        file = file.Trim + "relacion_agente_" + idtxt.Text + fecha_corte.Value.DayOfWeek.ToString + ".txt"
        Dim fileName As New System.IO.StreamWriter(file, False)
        For j As Integer = 0 To tblfacturas.Rows.Count - 1
            If tblfacturas.Rows(j).Item("s") = True Or tblfacturas.Rows(j).Item("s") = 1 Then
                fileName.WriteLine(tblfacturas.Rows(j).Item("folio").ToString + "," + tblfacturas.Rows(j).Item("serie").ToString)
            End If
        Next
        fileName.Close()
    End Sub

    Private Sub id_agente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_agente.TextChanged
        idtxt.Text = id_agente.Text
    End Sub

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        Dim x As Integer = 0
        Try
            x = Me.tblfacturas.Compute("count(s)", "s = true ")
        Catch ex As Exception

        End Try
        If x = 0 Then
            Dim ix As MsgBoxResult = MsgBox("No hay nada seleccionado, Quiere dejar en Blanco la relacion?", MsgBoxStyle.YesNo, "Guardar Relacion de Cobranza")
            If ix = MsgBoxResult.No Then Exit Sub
        End If
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        guardar_relacion()
        MsgBox("Archivo Guardado")
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub DescripcionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionComboBox.SelectedIndexChanged
        Try
            rutatxt.Text = DescripcionComboBox.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rutatxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rutatxt.TextChanged
        Try
            Dim ix As Integer = Me.ListasBindingSource.Find("id", rutatxt.Text)
            Me.ListasBindingSource.Position = ix
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkruta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkruta.CheckedChanged
        rutatxt.Visible = chkruta.Checked
        Me.DescripcionComboBox.Visible = chkruta.Checked
        Me.boton_ruta.Visible = chkruta.Checked
        Me.boton_Ok.Visible = Not chkruta.Checked
        rutatxt.Text = DescripcionComboBox.SelectedValue
    End Sub

    Private Sub boton_ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ruta.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'Carga los clientes del agente
        Dim da_saldos As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        tblsaldos.Clear()
        tblfacturas.Clear()
        Dim cmd As String
        If Me.chkseleccion.Checked = True Then
            cmd = "SELECT 1 as s,Id_directorio as ID,Nombre,saldo,ruta from cxc_saldos where saldo>0 and id_agente = " + Me.id_agente.Text + " and Ruta = " + Me.rutatxt.Text
        Else
            cmd = "SELECT 0 as s,Id_directorio as ID,Nombre,saldo,ruta from cxc_saldos where saldo>0 and id_agente = " + Me.id_agente.Text + " and Ruta = " + Me.rutatxt.Text
        End If

        da_saldos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_saldos.Fill(dsfac.Tables("tblsaldos"))

        Me.bsclientes.Filter = ""
        bsclientes.DataSource = dsfac.Tables("tblsaldos")

        Me.dgvClientes.DataSource = bsclientes
        Me.bsclientes.Filter = ""
        Me.dgvClientes.Columns("saldo").DefaultCellStyle.Format = "N2"
        Me.dgvClientes.Columns("ruta").Visible = False

        Me.dgvClientes.Columns.RemoveAt(0)
        Dim column As New DataGridViewCheckBoxColumn
        With column
            .Name = "S"
            .HeaderText = "S"
            .DataPropertyName = "S"
        End With
        Me.dgvClientes.Columns.Insert(0, column)
        dgvClientes.Columns(0).ReadOnly = True
        cargar_facturas()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    
    Private Sub boton_leer_relacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_leer_relacion.Click
        'lee el archivo lxl
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim file As String, id As Integer
        Dim adap1 As New admintegralDataSetTableAdapters.pathsTableAdapter
        file = adap1.path(6)
        Dim miix As Integer

        file = file.Trim + "relacion_agente_" + idtxt.Text + fecha_corte.Value.DayOfWeek.ToString + ".txt"
        'file = file.Trim + "relacion_agente_" + idtxt.Text + fecha_corte.Value.DayOfWeek.ToString + ".xml"
        Dim f As Integer = FreeFile()
        Try
            FileOpen(FreeFile, file, OpenMode.Input)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim a1, nfac, s As String, xx As Integer
        While Not EOF(f)
            a1 = LineInput(f) : xx = InStr(a1, ",")
            nfac = "" : s = ""
            Try
                nfac = Mid(a1, 1, xx - 1)
                s = Mid(a1, xx + 1)
            Catch ex As Exception

            End Try
            Dim filtro As String = "folio = " + nfac + " and serie ='" + s.Trim + "'"
            bsfacturas.Filter = filtro
            miix = bsfacturas.Position
            If Me.dgvfacturas.Rows.Count = 1 Then
                Me.dgvfacturas.Rows(0).Cells("s").Value = True
                id = Me.dgvfacturas.Rows(0).Cells("id_directorio").Value
                filtro = "id = " + id.ToString
                bsclientes.Filter = filtro
                If dgvClientes.Rows.Count = 1 Then
                    dgvClientes.Rows(0).Cells("s").Value = True
                End If
            End If
        End While
        FileClose(f)
        Me.SplitContainer1.Panel2Collapsed = False
        Windows.Forms.Cursor.Current = Cursors.Default
        bsclientes.Filter = ""
        contar_facturas()
    End Sub 'caragr archvio

    Private Sub dgvfacturas_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvfacturas.DataError
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        With Me.dgvfacturas
            .Columns("fecha").DefaultCellStyle.Format = "d"
            .Columns("vence").DefaultCellStyle.Format = "d"
            .Columns("importe").DefaultCellStyle.Format = "N2"
            .Columns("abonos").DefaultCellStyle.Format = "N2"
            .Columns("saldo").DefaultCellStyle.Format = "N2"
            .Columns("saldo_total").DefaultCellStyle.Format = "N2"
        End With
    End Sub
    Private Sub idtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idtxt.TextChanged
        Me.boton_Ok.Enabled = False
    End Sub

    Private Sub solosaldos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles solosaldos.CheckedChanged
        If solosaldos.Checked = True Then
            For j As Integer = 0 To tblfacturas.Rows.Count - 1
                If tblfacturas.Rows(j).Item("saldo") < 1 Then tblfacturas.Rows(j).Item("s") = 0
            Next
            bsfacturas.Filter += " and saldo >.2"
        Else
            For j As Integer = 0 To tblfacturas.Rows.Count - 1
                If tblfacturas.Rows(j).Item("saldo") < 1 Then tblfacturas.Rows(j).Item("s") = 1
            Next
            bsfacturas.Filter = "id_directorio =" + Me.dgvClientes.CurrentRow.Cells("id").Value.ToString
        End If
        contar_facturas()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If chkruta.Checked = False Then
            My.Forms.cxc_auxiliar.cargar_catalogo(idtxt.Text, Me.NombreComboBox.Text)
            My.Forms.cxc_auxiliar.Show()
        Else
            My.Forms.cxc_auxiliar.cargar_catalogo_ruta(idtxt.Text, Me.NombreComboBox.Text, rutatxt.Text)
            My.Forms.cxc_auxiliar.Show()
        End If

    End Sub

    Private Sub idtxt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idtxt.Enter
        idtxt.SelectAll()
    End Sub
End Class