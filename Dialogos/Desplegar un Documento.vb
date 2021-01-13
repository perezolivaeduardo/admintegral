Public Class Consultar_una_factura
    Public Sub cargar_docuemnto(ByVal td As Integer, ByVal folio As Long, ByVal serie As String)
        Me.Sql_documento_impresionTableAdapter.FillByundocumento(Me.AdmintegralDataSet.sql_documento_impresion, td, folio, serie)
        Me.Sql_documentosTableAdapter.FillBy_un_documento(Me.AdmintegralDataSet.sql_documentos, td, folio, serie)
        cargar_pagos(folio, serie)
        Me.ReportViewer.RefreshReport()
    End Sub

    Private Sub cargar_pagos(ByVal folio As String, ByVal serie As String)
        Dim DApagos As New Data.SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim cmd As String
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        'cmd = "SELECT * from cxc_pagos_detalle where (folio = " + folio + ") AND (serie = '" + serie + "' )"
        cmd = "SELECT     * FROM cxc_pagos_detalle WHERE (folio = " + folio.ToString + ") AND (serie = '" + serie.ToString + "')"
        Try
            tbl = leer_tabla(cmd)
            dgvpagos.DataSource = tbl
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

End Class