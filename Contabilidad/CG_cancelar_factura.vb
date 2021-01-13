Public Class CG_cancelar_factura
    Dim doc As DataRow
    Dim ultima_fecha As DateTime
    Private Sub Foliotxt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Foliotxt.Enter
        boton_cancelar.Enabled = False
        Status.Text = "Teclee la serie y el folio juntos"
        Foliotxt.SelectAll()
    End Sub

    Private Sub Foliotxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Foliotxt.KeyPress
        If e.KeyChar = chr13 Then
            cargar_documento()
            Foliotxt.SelectAll()
        End If
    End Sub
    Private Sub cargar_documento()
        If Foliotxt.TextLength = 0 Then Exit Sub
        tentra.Visible = False : lbltentra.Visible = False
        Dim td, folio As Integer, s As String
        If opticket.Checked = True Then td = 5
        If opfactura.Checked = True Then td = 6
        If opncredito.Checked = True Then td = 7
        If optraspaso.Checked = True Then td = 3 : tentra.Visible = True : lbltentra.Visible = True

        s = Mid(Foliotxt.Text, 1, 1)
        folio = Mid(Foliotxt.Text, 2)

        Try
            doc = leer_documento(td, folio, s)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Me.boton_cancelar.Enabled = True
        fechatxt.Text = Format(doc.Item("fechafactura"), "d")
        estatus.Text = "Activa"
        If doc.Item("status") = 1 Then estatus.Text = "Cancelada"
        If doc.Item("id_cartera") = 0 Then forma.Text = "Contado"
        If doc.Item("id_cartera") = 2 Then forma.Text = "credito"
        If doc.Item("id_cartera") = 3 Then forma.Text = "Global"
        cliente.Text = "(" + doc.Item("id_directorio").ToString + ") " + doc.Item("nombre")
        importe.Text = Format(doc.Item("importe"), "N2")
        If td = 3 Then
            tentra.Text = doc.Item("id_almacen_entrada")
        End If

        If doc.Item("status") <> 0 Then Me.boton_cancelar.Enabled = False : Status.Text = "Ya esta Cancelada" : Exit Sub

        If doc.Item("id_cartera") = 0 And td <> 3 Then
            forma.Text = "Contado"
            If doc.Item("fechafactura") < Now.Date Then
                Me.boton_cancelar.Enabled = False
                Status.Text = "No puede cancelar factura de contado de dias anteriores"
                Me.boton_cancelar.Enabled = False
            End If
        End If

        Status.Text = "Verificando Pagos"
        Dim tbl As DataTable, cmd As String
        cmd = "Select * from cxc_pagos_detalle where td=" + td.ToString + " and folio =" + folio.ToString + "  and serie = '" + s + "'"
        tbl = leer_tabla(cmd)
        If tbl.Rows.Count > 0 And doc.Item("fechafactura") < Now.Date Then
            Me.boton_cancelar.Enabled = False
            Status.Text = "Tiene Pagos" : Beep()
            Exit Sub
        End If

        'validando fecha de envio de reporte de hacienda fei
        If CDate(Me.fechatxt.Text) < ultima_fecha Then
            Status.Text = "Fecha Menor a fecha de envio del reporte"
            Me.boton_cancelar.Enabled = False
        End If
        Status.Text = "Ok."

    End Sub

    Private Sub Boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_salir.Click
        Me.Close()
    End Sub

    Private Sub CG_cancelar_factura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ultima_fecha = leer_tabla("select ultimo_envio_fei from generales ").Rows(0).Item(0)
        Me.Text = "Ultima fecha de envio del reporte para hacienda " + ultima_fecha.ToShortDateString
        Me.Foliotxt.Focus()

    End Sub

    Private Sub boton_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cancelar.Click
        cancelar()
        Foliotxt.Text = ""
        Foliotxt.Focus()
    End Sub
    Private Sub cancelar()
        ' id user.Esmaster=False then Dim x1 As usuario = autoriza_fquncion(1)
        '  If x1.id = 0 Then Exit Sub
        Dim plista As String

        Dim td, folio As Integer, s As String
        If opticket.Checked = True Then td = 5
        If opfactura.Checked = True Then td = 6
        If opncredito.Checked = True Then td = 7
        If optraspaso.Checked = True Then td = 3
        s = Mid(Foliotxt.Text, 1, 1)
        folio = Mid(Foliotxt.Text, 2)
        plista = td.ToString + "/" + s + "-" + folio.ToString

        Dim adap As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim adap1 As New admintegralDataSetTableAdapters.DocumentosTableAdapter

        Dim x As MsgBoxResult
        x = MsgBox("Quiere Cancelar el Folio :" + folio.ToString, MsgBoxStyle.YesNo, "Cancelar")
        If x <> MsgBoxResult.Yes Then Exit Sub

        Try
            Status.Text = "Anulando Movimientos"
            adap.anular_movimientos(td, folio, s)
            If td = 3 Then
                adap.anular_movimientos(4, folio, s)
                adap1.UpdateStatus(1, user.id, 4, folio, s)
            End If

            Status.Text = "Cancelando Documento"
            adap1.UpdateStatus(1, user.id, td, folio, s)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If td = 7 Then 'notas de credito
            Dim cmd As String = "delete from pagos where id_fp=6 and referencia = " + folio.ToString
            Dim ok As Boolean = comando(cmd)
            If ok = False Then MsgBox("No se Borro el Pago con la NC") Else MsgBox("Se borro el  pago")
        End If

        Status.Text = "Documento Cancelado!"
        If doc.Item("fechafactura") = Now.Date And doc.Item("id_cartera") = 0 Then
            Status.Text = "Borrando Pago"
            Try
                Dim apd As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter
                Dim dt As New DataTable
                dt = apd.GetDataBydocumento(td, folio, s)
                If dt.Rows.Count = 0 Then MsgBox("Sin Pagos") : Exit Try
                Status.Text = "Borrando Pagos"
                For j As Integer = 0 To dt.Rows.Count - 1
                    With dt.Rows(j)
                        apd.Delete(.Item(0), .Item(1), .Item(2), .Item(3), .Item(4), My.Settings.ncaja)
                    End With
                Next
            Catch ex As Exception
                MsgBox("Error al Borrar Pagos")
            End Try

        End If
        Me.boton_cancelar.Enabled = False
        lista.Items.Add(plista)
        MsgBox("Documento Cancelado  !!!")
        Status.Text = ""
        adap.Connection.Close()
        adap1.Connection.Close()
    End Sub

    Private Sub Foliotxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Foliotxt.TextChanged
        Me.boton_cancelar.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim td, folio As Integer, s As String, plista As String

        For j As Integer = 0 To lista.Items.Count - 1
            plista = lista.Items(j)
            td = Mid(plista, 1, 1)
            s = Mid(plista, 3, 1)
            folio = Mid(plista, 5)

            Try
                doc = leer_documento(td, folio, s)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            If doc.Item("status") = 1 Then
                lista.SetItemChecked(j, True)
            Else
                MsgBox("Este folio no se cancelo " + s + "-" + folio.ToString)
                lista.SetItemChecked(j, False)
            End If
        Next
    End Sub 'VALIDAR DOCUMENTOS CANCELADOS
End Class