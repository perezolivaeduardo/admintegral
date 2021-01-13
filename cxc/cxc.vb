Imports System.Object
Public Class cxc
    Dim bspagos As New BindingSource
    Dim bsfacturas As New BindingSource
    Dim tblfacturas As New DataTable
    Dim tblpagos As New DataTable
    Dim tblsaldos As New DataTable

    Private Sub cxc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Directorio' Puede moverla o quitarla según sea necesario.
        '   Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)
        Dim da_saldos As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        Dim cmd As String
        'carga los clientes con movimientos que no sean Agente 0 (Incobrables)
        cmd = "SELECT Id_directorio as ID,Nombre,limite,Comentarios,comercial,Direccion+' '+ciudad as Direccion,id_agente,ruta,email from Directorio where tipo=2 and id_agente>=0"
        da_saldos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_saldos.SelectCommand.CommandTimeout = 3000
        da_saldos.Fill(tblsaldos)
        Me.DirectorioBindingSource.Filter = "id = -1"
        Me.DirectorioBindingSource.DataSource = tblsaldos
        dgv.DataSource = Me.DirectorioBindingSource
        Me.Text = "Saldos por Cliente "
        dgv.Columns(2).Visible = False ' limite
        dgv.Columns(3).Visible = False 'comentarios
        dgv.Columns("Direccion").Visible = False 'comentarios
        Me.ReportViewer.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("facturas", bsfacturas.DataSource)
        Me.SplitContainer2.Panel1Collapsed = True
        Me.ReportViewer.LocalReport.EnableExternalImages = True
    End Sub

    Private Sub filtrotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrotxt.TextChanged
        Dim filtro As String = "Nombre like'%" + filtrotxt.Text + "%' or Comercial like'%" + filtrotxt.Text + "%'"
        Try
            Me.DirectorioBindingSource.Filter = filtro
        Catch ex As Exception
            Me.DirectorioBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub boton_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.SplitContainer2.Panel1Collapsed = Not Me.SplitContainer2.Panel1Collapsed
        If Me.SplitContainer2.Panel1Collapsed = False Then
            filtrotxt.Focus()
        End If
    End Sub

    Private Sub dgv_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        Try
            Me.idtxt.Text = Me.dgv.CurrentRow.Cells(0).Value
            Me.nombre.Text = Me.dgv.CurrentRow.Cells(1).Value
            Me.limite.Text = Format(Me.dgv.CurrentRow.Cells(2).Value, "N2")
            Me.comentarios.Text = Me.dgv.CurrentRow.Cells(3).Value + " "
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Me.idtxt.Text = Me.dgv.CurrentRow.Cells(0).Value
        Me.nombre.Text = Me.dgv.CurrentRow.Cells(1).Value
        Me.limite.Text = Format(Me.dgv.CurrentRow.Cells(2).Value, "N2")
        Me.comentarios.Text = Me.dgv.CurrentRow.Cells(3).Value + " "
        Me.SplitContainer2.Panel1Collapsed = True
        cargar_facturas(idtxt.Text, True)
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub cargar_facturas(ByVal id As Integer, ByVal todas As Boolean)
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim da_facturas As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        Dim cmd As String
        cmd = "SELECT folio,serie,fecha,vence,Importe,Abonos,saldo,dias from cxc_saldos_x_factura where id_directorio= " + id.ToString
        cmd += " order by Dias DESC"
        da_facturas = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        tblfacturas.Clear()
        da_facturas.SelectCommand.CommandTimeout = 3000
        da_facturas.Fill(tblfacturas)

        bsfacturas.DataSource = tblfacturas
        'bsfacturas.Filter = "Saldo>0"
        Me.dgvfacturas.DataSource = bsfacturas
        Me.Solosaldos.Checked = True
        califica()
        Try
            saldotxt.Text = Format(tblfacturas.Compute("sum(saldo)", ""), "N2")
            disponible.Text = Format(CDbl(limite.Text) - CDbl(saldotxt.Text), "N2")
            For j As Integer = 4 To 6
                dgvfacturas.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvfacturas.Columns(j).DefaultCellStyle.Format = "N2"
            Next
        Catch ex As Exception

        End Try

        Dim dapagos As New Data.SqlClient.SqlDataAdapter

        cmd = "Select boleta,fecha,banco,referencia,abono,folio,serie from cxc_pagos_detalle where id_directorio = " + id.ToString
        dapagos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        tblpagos.Clear()
        dapagos.SelectCommand.CommandTimeout = 3000
        dapagos.Fill(tblpagos)
        bspagos.DataSource = tblpagos
        dgvpagos.DataSource = bspagos
        dgvpagos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvpagos.Columns(4).DefaultCellStyle.Format = "N2"
        dgvpagos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvpagos.Columns(5).Visible = False
        dgvpagos.Columns(6).Visible = False

        'pasa parametro al reporte
        Dim rp(0 To 0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("cliente", idtxt.Text + ".- " + Me.nombre.Text, False)
        Me.ReportViewer.LocalReport.SetParameters(rp)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub idtxt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idtxt.Enter
        Me.SplitContainer2.Panel1Collapsed = True
    End Sub

    Private Sub idtxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idtxt.KeyPress
        If e.KeyChar = Chr(13) Then
            carga_cliente(idtxt.Text)
        End If
    End Sub
    Public Sub carga_cliente(ByVal cliente As Integer)

        Me.DirectorioBindingSource.Filter = ""
        Dim ix As Integer = Me.DirectorioBindingSource.Find("id", cliente)
        limite.Text = ""
        disponible.Text = ""
        saldotxt.Text = ""
        If ix >= 0 Then
            Me.DirectorioBindingSource.Position = ix
            Me.nombre.Text = Me.dgv.CurrentRow.Cells(1).Value
            Me.limite.Text = Format(Me.dgv.CurrentRow.Cells(2).Value, "N2")
            Me.comentarios.Text = Me.dgv.CurrentRow.Cells(3).Value + " "
            Me.Direcciontxt.Text = Me.dgv.CurrentRow.Cells("Direccion").Value
            Me.Id_agenteTextBox.Text = Me.dgv.CurrentRow.Cells("id_agente").Value
            Me.RutaTextBox.Text = Me.dgv.CurrentRow.Cells("Ruta").Value
            Try
                Me.email.Text = Me.dgv.CurrentRow.Cells("email").Value

            Catch ex As Exception
                MsgBox("no tiene mail")
            End Try
            cargar_facturas(cliente, True)
            lblcheques.Visible = False
            Try
                Dim cmd As String = "SELECT COUNT(Id_cli) AS cheques FROM cxc_relacion_Cheques WHERE Id_cli = " + cliente.ToString + " AND fecha_apliacion > '" + Format(Now.Date, "d") + "'"
                Dim tb1 As DataTable = leer_tabla(cmd)
                If tb1.Rows.Count > 0 Then
                    lblcheques.Text = "Tiene " + tb1.Rows(0).Item(0).ToString + " Cheques Pendientes"
                    lblcheques.Visible = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvfacturas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfacturas.CellDoubleClick
        Dim folio, serie, filtro As String
        folio = dgvfacturas.CurrentRow.Cells("folio").Value
        serie = dgvfacturas.CurrentRow.Cells("serie").Value
        filtro = "folio =" + folio + " and serie = '" + serie + "'"
        bspagos.Filter = filtro
    End Sub

    Private Sub boton_todoslospagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_todoslospagos.Click
        bspagos.Filter = ""
    End Sub

    Private Sub boton_reporte_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_reporte.Click
        Me.ReportViewer.LocalReport.DataSources.RemoveAt(0)

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter

        If Solosaldos.Checked = True Then
            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("saldo", 0, False) ' >0 solo saldos >-1 Todas aun con saldo cero
        Else
            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("saldo", -1, False) ' >0 solo saldos >-1 Todas aun con saldo cero
        End If

        Me.ReportViewer.LocalReport.SetParameters(rp)

        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("facturas", bsfacturas.DataSource)
        ReportViewer.LocalReport.DataSources.Add(datasource)

        Me.ReportViewer.BringToFront()
        Me.ReportViewer.Visible = Not Me.ReportViewer.Visible
        ReportViewer.RefreshReport()
    End Sub

    Private Sub boton_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_excel.Click
        Dim file1 As String = "\Auxiliar_cliente_" + idtxt.Text + ".xls"
        Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim deviceInfo As String
        Dim bytes As Byte()
        Dim file As String
        file = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        deviceInfo = "< deviceInfo ><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"

        bytes = ReportViewer.LocalReport.Render("Excel", Nothing, _
          mimeType, encoding, extension, streamids, warnings)

        Dim fs As New System.IO.FileStream(file + file1, System.IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        Dim x As MsgBoxResult
        x = MessageBox.Show("Reporte exportado a " + file + file1 + ",  quiere Abrir el archvo? ", "Abrir Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        If x = MsgBoxResult.Yes Then
            Dim Proceso As New Process()
            Proceso.StartInfo.FileName = file + file1
            Proceso.StartInfo.Arguments = ""
            Proceso.Start()
        End If
    End Sub

    Private Sub boton_calculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_calculadora.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub califica()
        Dim dias As Integer
        For j As Integer = 0 To dgvfacturas.Rows.Count - 1
            dgvfacturas.Rows(j).DefaultCellStyle.BackColor = Color.White
            dias = dgvfacturas.Rows(j).Cells("dias").Value
            If dgvfacturas.Rows(j).Cells("saldo").Value > 0 Then
                If dias > 15 Then
                    dgvfacturas.Rows(j).DefaultCellStyle.BackColor = Color.Pink
                Else
                    If dias < 0 Then
                        dgvfacturas.Rows(j).DefaultCellStyle.BackColor = Color.GreenYellow
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Solosaldos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Solosaldos.CheckedChanged
        If Solosaldos.Checked = True Then
            bsfacturas.Filter = "Saldo>0"
        Else
            bsfacturas.Filter = ""
        End If
        califica()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            My.Forms.cxc_info.info(Me.idtxt.Text, True)
            My.Forms.cxc_info.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If Me.ReportViewer.Visible = True Then
            ReportViewer.Visible = False
        Else
            Me.Close()

        End If
    End Sub

    Private Sub actualiza_comentarios()
        Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
            conection.Open()
            Dim cmd As String, AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
            Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
            cmd = "UPDATE [integra].[dbo].[Directorio] " _
            & "SET [Comentarios] = '" + Me.comentarios.Text + "'"
            cmd = cmd + " WHERE [tipo] = 2 And [id_directorio] = " + Me.idtxt.Text
            Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
            AdaptadorDeDatos.UpdateCommand = Command
            AdaptadorDeDatos.UpdateCommand.ExecuteNonQuery()
            Me.dgv.CurrentRow.Cells(3).Value = Me.comentarios.Text
        End Using
    End Sub

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        actualiza_comentarios()
        boton_guardar.Visible = False
    End Sub

    Private Sub comentarios_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comentarios.TextChanged
        Me.boton_guardar.Visible = True
    End Sub

    Private Sub DirectorioBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectorioBindingSource.PositionChanged
        Me.boton_guardar.Visible = False
    End Sub

    Private Sub comentarios_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles comentarios.Validated
        Me.boton_guardar.Visible = True
    End Sub

    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.idtxt.Text = Me.dgv.CurrentRow.Cells(0).Value
            Me.nombre.Text = Me.dgv.CurrentRow.Cells(1).Value
            Me.limite.Text = Format(Me.dgv.CurrentRow.Cells(2).Value, "N2")
            Me.comentarios.Text = Me.dgv.CurrentRow.Cells(3).Value + " "
            Me.SplitContainer2.Panel1Collapsed = True
            cargar_facturas(idtxt.Text, True)
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
        End If
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Stop
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Boton_buscar_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDetalleDeLaFacturaToolStripMenuItem.Click
        Dim folio As Single, serie As String
        folio = Me.dgvfacturas.CurrentRow.Cells(0).Value
        serie = Me.dgvfacturas.CurrentRow.Cells(1).Value
        My.Forms.Consultar_una_factura.cargar_docuemnto(6, folio, serie)
        My.Forms.Consultar_una_factura.Show()
    End Sub


    Private Sub boton_Cheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Cheques.Click
        My.Forms.cxc_relacion_Cheques.cheques_x_ID(idtxt.Text)
        My.Forms.cxc_relacion_Cheques.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.cxc_auxiliar.cargar_auxiliar(Me.idtxt.Text, idtxt.Text + " - " + nombre.Text, saldotxt.Text)
        My.Forms.cxc_auxiliar.ShowDialog()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub

    Private Sub lblcheques_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcheques.DoubleClick
        My.Forms.cxc_relacion_Cheques.cheques_x_ID(idtxt.Text)
        My.Forms.cxc_relacion_Cheques.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        My.Forms.cxc_catalogo.Show()
    End Sub

    Private Sub boton_compras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_compras.Click
        If idtxt.TextLength > 0 Then
            My.Forms.cxc_productos_comprados.cargar(idtxt.Text, 6)
            My.Forms.cxc_productos_comprados.Text = "Productos comprados por " + nombre.Text
            My.Forms.cxc_productos_comprados.Show()
        End If
    End Sub

    Private Sub VerCFDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerCFDToolStripMenuItem.Click
        Dim folio, serie As String

        folio = Me.dgvfacturas.CurrentRow.Cells(0).Value
        serie = Me.dgvfacturas.CurrentRow.Cells(1).Value

        Dim adap As New feiDatasetTableAdapters.fei_cfdTableAdapter
        Dim dr As DataRow
        Try
            dr = adap.GetDataByid(6, folio.ToString.Trim, serie.Trim).Rows(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ini()
        Dim fserie As String = dr.Item("fei_serie")
        Dim ffolio As String = dr.Item("fei_folio").ToString.Trim
        Dim pdffile As String
        pdffile = dfei.ruta + "CFD_" + fserie + ffolio + ".pdf"
        Try
            Process.Start(pdffile)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub boton_Cotizaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Cotizaciones.Click
        If idtxt.TextLength > 0 Then
            My.Forms.cxc_productos_comprados.cargar(idtxt.Text, 10)
            My.Forms.cxc_productos_comprados.Text = "Productos COTIZADOS A : " + nombre.Text
            My.Forms.cxc_productos_comprados.Show()
        End If
    End Sub

    Private Sub EnviarArchivosCFDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarArchivosCFDToolStripMenuItem.Click
        If Me.email.TextLength = 0 Then MsgBox("Definir email!!!")
        Dim folio, serie As String

        folio = Me.dgvfacturas.CurrentRow.Cells(0).Value
        serie = Me.dgvfacturas.CurrentRow.Cells(1).Value

        Dim adap As New feiDatasetTableAdapters.fei_cfdTableAdapter
        Dim dr As DataRow
        Try
            dr = adap.GetDataByid(6, folio.ToString.Trim, serie.Trim).Rows(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ini()
        Dim fserie As String = dr.Item("fei_serie")
        Dim ffolio As String = dr.Item("fei_folio").ToString.Trim
        Dim pdffile, xmlfile As String
        pdffile = dfei.ruta + "CFD_" + fserie + ffolio + ".pdf"
        pdffile = dfei.ruta + "CFD_" + fserie + ffolio + ".xml"


        smtp = buzon()
        Dim para As String = Me.email.Text
        Dim ok As Boolean = mandar_correo(para, "Factura Electronica", "Anexamos archivo con factura electronica. " + cr + lf + "Para cualquier duda escribir a abarroterabara@yahoo.com.mx", pdffile, xmlfile)
        If ok = True Then MsgBox("Correo enviado!") Else MsgBox("Eroor al enviar archivo")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim adap As New feiDatasetTableAdapters.DirectorioTableAdapter
        adap.actualiza_mail(email.Text, idtxt.Text)
        Dim adap1 As New feiDatasetTableAdapters.fei_clientesTableAdapter
        adap1.actualizar_mail(email.Text, idtxt.Text)
        adap.Dispose()
        adap1.Dispose()
    End Sub
End Class