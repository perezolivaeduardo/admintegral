Public Class caja_relacion_nc

    Public Sub cargar_notas(ByVal fecha As Date)
        Me.Sql_documentos_clientesTableAdapter.FillByserie_fecha(Me.AdmintegralDataSet.sql_documentos_clientes, "  ", fecha)
    End Sub

    Private Sub boton_todas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_todas.Click
        Me.Sql_documentos_clientesTableAdapter.FillBytipo_serie(Me.AdmintegralDataSet.sql_documentos_clientes, 7, "  ")
    End Sub

    Private Sub Boton_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_cancelar.Click

        If Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvstatus").Value = 1 Then
            MsgBox("Esta Factuara ya esta cancelada")
            Exit Sub
        End If


        Dim x1 As usuario = autoriza_funcion(1)
        If x1.id = 0 Then Exit Sub

        Dim adap As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim adap1 As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim td, folio As Integer, serie As String
        Dim x As MsgBoxResult
        If Me.Sql_documentos_clientesDataGridView.Rows.Count = 0 Then Exit Sub
        Try
            td = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvtd").Value
            folio = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvfolio").Value
            serie = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvserie").Value
            x = MsgBox("Quiere Cancelar el Folio :" + folio.ToString, MsgBoxStyle.YesNo, "Borrar Archivo")
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
                    apd.Delete(.Item(0), .Item(1), .Item(2), .Item(3), .Item(4), My.Settings.ncaja)
                End With
            Next
            cargar_notas(Now.Date)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub boton_del_dia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_del_dia.Click
        cargar_notas(Now.Date)
    End Sub

    Private Sub caja_relacion_nc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        cargar_notas(fecha.Value.Date)
    End Sub

    Private Sub VerCFDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerCFDToolStripMenuItem.Click
        Dim td, folio, serie As String
        Try
            td = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvtd").Value
            folio = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvfolio").Value
            serie = Me.Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvserie").Value
        Catch ex As Exception
            MsgBox("Seleccione una NOta") : Exit Sub
        End Try


        Dim adap As New feiDatasetTableAdapters.fei_cfdTableAdapter
        Dim dr As DataRow

        Try
            dr = adap.GetDataByid(td, folio, serie).Rows(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim fserie As String = dr.Item("fei_serie")
        Dim ffolio As String = dr.Item("fei_folio").ToString.Trim
        Dim pdffile As String
        pdffile = dfei.ruta + "CFD_" + fserie + ffolio + ".pdf"
        Try
            Process.Start(pdffile)
        Catch ex As Exception
            MsgBox(ex.Message + pdffile)
        End Try
    End Sub
End Class