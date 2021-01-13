Public Class cxc_info
    Dim idcliente As Integer
    Public Sub info(ByVal id As Integer, ByVal estadistica As Boolean)
        Dim cmd As String = "select * from cxc_info where [id_directorio] = " + id.ToString
        Dim tbl As DataTable = leer_tabla(cmd)
        If tbl.Rows.Count > 0 Then
            Dim dr As DataRow = tbl.Rows(0)
            nombre.Text = dr("id_directorio").ToString + "-" + dr("Nombre")
            agente.Text = dr("agente")
            zona.Text = "Ruta " + dr("expr1").ToString + ": " + dr("ruta")
            direccion.Text = dr("direccion")
            colonia.Text = dr("colonia")
            idcliente = id
            saldo.Text = Format(dr("saldo"), "N2")
            disponibletxt.Text = Format(dr("disponible"), "N2")
            limitetxt.Text = Format(dr("limite"), "N2")
        Else
            MsgBox("No Existe Id" + id.ToString, MsgBoxStyle.Exclamation)
        End If

        If estadistica = True Then
            Pagos()

        End If

    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
    Private Sub Pagos()
        Dim cmd, cmd1, cmd3 As String
        'Pagos
        cmd = "SELECT Pagos.folio, Pagos.fecha_apliacion AS Fecha, tbl_formasdepago.Descripcion AS Forma, Pagos.banco, Pagos.referencia, Pagos.Importe " _
        & "FROM         Pagos INNER JOIN tbl_formasdepago ON Pagos.id_fp = tbl_formasdepago.id_fp " _
        & "  WHERE Pagos.id_directorio = " + idcliente.ToString + " ORDER BY Pagos.fecha DESC"
        Dim tblpagos As DataTable = leer_tabla(cmd)
        dgvpagos.DataSource = tblpagos

        dgvpagos.Columns(5).DefaultCellStyle.Format = "N2"
        dgvpagos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        cmd1 = "SELECT id_directorio, SUM(Saldo) AS Vencido, MAX(Dias) AS Max, MIN(Dias) AS Min, COUNT(Folio) AS facturas " _
        & " FROM cxc_saldos_x_factura WHERE Dias>0 AND Saldo>0 " _
        & " GROUP BY id_directorio HAVING id_directorio = " + idcliente.ToString
        Dim tblestad As DataTable = leer_tabla(cmd1)
        If tblestad.Rows.Count > 0 Then
            saldovencido.Text = Format(tblestad.Rows(0).Item("Vencido"), "N2")
            facturasvencidas.Text = tblestad.Rows(0).Item("facturas")
            diasmax.Text = tblestad.Rows(0).Item("Max")
            diasmin.Text = tblestad.Rows(0).Item("min")
        End If

        'Pagos
        cmd3 = "SELECT     serie +str( Folio)  as folio , fecha, Importe, Abonos, Saldo, Dias FROM cxc_saldos_x_factura " _
        & " WHERE id_directorio = " + idcliente.ToString _
        & " ORDER BY fecha DESC, Folio DESC"
        Dim tblfacturas As DataTable = leer_tabla(cmd3)
        dgvcompras.DataSource = tblfacturas
        For j As Integer = 2 To 4
            dgvcompras.Columns(j).DefaultCellStyle.Format = "N2"
            dgvcompras.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next

    End Sub

    Private Sub boton_grafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_grafica.Click
        Pagos()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class