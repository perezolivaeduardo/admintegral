Imports Microsoft.Win32
Public Class caja_relacion

    Public Sub cargar_tabla(ByVal serie As String, ByVal fecha As Date)
        'Me.Sql_documentos_clientesTableAdapter.FillByserie_fecha(Me.AdmintegralDataSet.sql_documentos_clientes, serie, fecha)
        Dim cmd As String
        cmd = "SELECT  TOP (100) PERCENT dbo.Documentos.td, dbo.tbl_Tipodoc.Descripciom, dbo.Documentos.Folio, dbo.Documentos.serie, dbo.tbl_almacenes.id_almacen, " _
        & " dbo.tbl_almacenes.Almacen, dbo.Documentos.id_directorio, dbo.Directorio.Nombre, dbo.Documentos.folio_pedido, dbo.Documentos.factura, " _
        & " dbo.Documentos.fechafactura, dbo.Documentos.fechasurtido, dbo.Documentos.vence, dbo.Documentos.porciento_descuento, dbo.Documentos.flete, " _
        & " dbo.Documentos.sub0, dbo.Documentos.sub10, dbo.Documentos.sub15, dbo.Documentos.descuento0, dbo.Documentos.descunto10, dbo.Documentos.descunto15, " _
        & "dbo.Documentos.iva10, dbo.Documentos.iva15, dbo.Documentos.Importe, dbo.Documentos.id_cartera, dbo.Documentos.status, dbo.Documentos.id_almacen_entrada,  " _
        & "dbo.Documentos.ncaja, dbo.Documentos.pesoengramos, dbo.Documentos.diasc, dbo.Documentos.nc_td, dbo.Documentos.nc_folio, dbo.Documentos.nc_serie " _
        & "FROM dbo.tbl_almacenes INNER JOIN dbo.Documentos ON dbo.tbl_almacenes.id_almacen = dbo.Documentos.almacen INNER JOIN " _
        & "dbo.Directorio ON dbo.Documentos.id_directorio = dbo.Directorio.id_directorio AND dbo.Documentos.tipo_directorio = dbo.Directorio.tipo INNER JOIN " _
        & "dbo.tbl_Tipodoc ON dbo.Documentos.td = dbo.tbl_Tipodoc.td WHERE dbo.Directorio.tipo = 2 AND dbo.Documentos.fechafactura = CONVERT(DATETIME, '[fecha] 00:00:00', 102) and dbo.Documentos.serie = '[serie]'"
        cmd = cmd.Replace("[fecha]", Format(fecha, "yyyy-M-dd"))
        cmd = cmd.Replace("[serie]", serie)
        Me.Sql_documentos_clientesBindingSource.DataSource = leer_tabla(cmd)
    End Sub

    Private Sub Boton_Facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Facturas.Click
        Dim filtro As String = "td = 6"
        Me.Sql_documentos_clientesBindingSource.Filter = filtro
    End Sub

    Private Sub Boton_Tickets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Tickets.Click
        Dim filtro As String = "td = 5"
        Me.Sql_documentos_clientesBindingSource.Filter = filtro
    End Sub

    Private Sub boton_todas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_todas.Click
        Me.Sql_documentos_clientesBindingSource.Filter = ""
    End Sub

    Private Sub Boton_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_cancelar.Click
        Try
            If Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvstatus").Value = 1 Then
                MsgBox("Esta Factuara ya esta cancelada")
                Exit Sub
            End If
        Catch ex As Exception

        End Try


        Dim x1 As usuario = autoriza_funcion(1)
        If x1.id = 0 Then MsgBox("No Autorizado") : Exit Sub

        Dim adap As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim adap1 As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim td, folio As Integer, serie As String
        Dim x As MsgBoxResult
        If Me.Sql_documentos_clientesDataGridView.Rows.Count = 0 Then Exit Sub
        Try
            td = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvtd").Value
            folio = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvfolio").Value
            serie = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvserie").Value
            x = MsgBox("Quiere Cancelar el Folio :" + folio.ToString, MsgBoxStyle.YesNo, "Cancelar")
            If x <> MsgBoxResult.Yes Then Exit Sub
        Catch ex As Exception
            MsgBox("Seleccione una factura para borrar") : Exit Sub
        End Try

        Try
            Main.status2.Text = "Borrando Movimientos..."
            adap.borrar_movimientos(td, folio, serie)
            Main.status2.Text = "Actualizar Documento..."
            adap1.UpdateStatus(1, x1.id, td, folio, serie)
            Dim apd As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter
            Dim dt As New DataTable
            dt = apd.GetDataBydocumento(td, folio, serie)
            If dt.Rows.Count = 0 Then MsgBox("Sin Pagos") : Exit Try
            For j As Integer = 0 To dt.Rows.Count - 1
                With dt.Rows(j)
                    apd.Delete(.Item(0), .Item(1), .Item(2), .Item(3), .Item(4), .Item(5))
                End With
            Next
            cargar_tabla(serie, Now.Date)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click

        Dim td As Integer, folio As String, serie As String
        Try
            td = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvtd").Value
            folio = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvfolio").Value
            serie = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvserie").Value
            My.Forms.Consultar_una_factura.cargar_docuemnto(td, folio, serie)
            My.Forms.Consultar_una_factura.Show()
            My.Forms.Consultar_una_factura.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Dim td As Integer, folio As Integer, serie As String
        td = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvtd").Value
        folio = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvfolio").Value
        serie = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvserie").Value
        ini() 'lee las rutas y licencias 
        Dim xlmfile, pdffile As String
        Dim adap As New feiDatasetTableAdapters.fei_cfdTableAdapter
        Dim r As DataRow : Dim agente As String = ""

        Try
            r = adap.GetDataByid(6, folio, serie).Rows(0)
        Catch ex As Exception
            MsgBox(ex.Message) : Exit Sub
        End Try
        Dim fei_serie As String = r.Item("fei_serie")
        Dim fei_folio As String = r.Item("fei_folio")

        Dim archivoxml As String, archivopdf As String
        archivoxml = dfei.ruta + "\cfdi33_" + fei_serie.Trim.ToString + fei_folio.ToString.Trim + ".xml"
        archivopdf = dfei.ruta + "\cfdi33_" + fei_serie.Trim.ToString + fei_folio.Trim.ToString + ".pdf"
        Process.Start(archivopdf)
    End Sub

    Private Sub Sql_documentos_clientesDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_documentos_clientesDataGridView.CellClick
        Dim td As Integer = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvtd").Value
        If td = 6 Then
            Me.btn_imprimir.Enabled = True
        Else
            Me.btn_imprimir.Enabled = False
        End If
        
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btp_por_facturar.Click
        Dim filtro As String = "id_cartera = 3"
        Me.Sql_documentos_clientesBindingSource.Filter = filtro
        Dim t As Double = 0
        If Me.Sql_documentos_clientesDataGridView.Rows.Count > 0 Then
            For j As Integer = 0 To Me.Sql_documentos_clientesDataGridView.Rows.Count - 1
                t += Me.Sql_documentos_clientesDataGridView.Rows(j).Cells("dgvimporte").Value
            Next
        End If
        MsgBox("Por Facturar $" + Format(t, "N"))
    End Sub ' muestra los pendientes por facturar

   
    Private Sub ToolStripButton1_Click_2(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class