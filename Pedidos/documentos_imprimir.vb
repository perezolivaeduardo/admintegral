Public Class documentos_imprimir
    Dim mtd, mfolio, mserie As String
    Public Sub cargar(ByVal td As String, ByVal folio As String, ByVal serie As String)
        mtd = td : mfolio = folio : mserie = serie
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_documento_impresion' Puede moverla o quitarla según sea necesario.
        Try
            Me.admintegralDataSet.sql_documento_impresion.Clear()
            Me.sql_documento_impresionTableAdapter.FillByundocumento(Me.admintegralDataSet.sql_documento_impresion, td, folio, serie)
            Me.ReportViewer1.LocalReport.EnableExternalImages = True
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            ' MsgBox("No se pudo leer el documento, intente de nuevo")
            Me.boton_leer.Visible = True
        End Try

    End Sub

    Private Sub boton_leer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_leer.Click
        cargar(mtd, mfolio, mserie)
    End Sub

    Private Sub documentos_imprimir_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class