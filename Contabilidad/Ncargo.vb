Public Class Ncargo
    Dim folio As Integer
    Private Sub Ncargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim msg As String
        Dim adap As New integraDataSetTableAdapters.DocumentosTableAdapter
        msg = "Nota de Cargo " + My.Settings.ncargo + adap.siguiente_nc(My.Settings.ncargo).ToString
        Me.Text = msg
        adap.Dispose()
        folio = adap.siguiente_nc(My.Settings.ncargo)
    End Sub

    Private Sub subtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtotal.TextChanged
        If subtotal.Text.Length = 0 Then Exit Sub
        Dim st As Decimal = Val(subtotal.Text)
        Dim iv As Decimal = Math.Round(st * 0.11, 2)
        Dim tt As Decimal = st + iv
        Me.iva.Text = Format(iv, "N2")
        Me.total.Text = Format(tt, "N2")
    End Sub

    Private Sub btn_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cliente.Click
        My.Forms.Buscar_clientes.ShowDialog()
        idcliente.Text = id_cliente

    End Sub

    Private Sub idcliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idcliente.Leave
        carga_cliente()
    End Sub

    Private Sub carga_cliente()
        If Me.idcliente.Text.Length = 0 Then Exit Sub
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.fei_clientes' Puede moverla o quitarla según sea necesario.
        Me.Fei_clientesTableAdapter.FillByid(Me.IntegraDataSet.fei_clientes, Me.idcliente.Text)
    End Sub

    Private Sub idcliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idcliente.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            carga_cliente()
        End If
    End Sub

    Private Sub guardar_ncargo()
        Dim adap As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim cadap As New admintegralDataSetTableAdapters.ComentariosTableAdapter

        Dim factura As String
        Dim st, iv, tt As Decimal

        st = Me.subtotal.Text
        iv = Me.iva.Text
        tt = Me.total.Text

        'CFDI
        factura = My.Settings.ncargo + folio.ToString
        adap.Insert(6, folio, My.Settings.ncargo, 0, Me.idcliente.Text, 2, Now.Date, 0, factura, Now.Date.ToShortDateString, Now.Date.ToShortDateString, Now.Date.ToShortDateString, 0, 0, 0, st, 0, iv, 0, 0, 0, 0, tt, 3, 0, 0, 0, 11, 0, user.id, 0, 0, 0, 0, 0, "", 0, 0, "", "", "")
        cadap.Insert(6, folio, My.Settings.ncargo, 0, user.nick, Me.concepto.Text)
        ' My.Forms.fei_generacfd.genera_nota_de_cargo(6, My.Settings.ncargo, folio, 20, Me.concepto.Text, autoriza.Text, metodo.Text, cuenta.Text) 'CAJA 20 TOMA LA SERIE PARA NOTAS DE CARGO
        Me.Close()
    End Sub

    Private Sub DefinirSerieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinirSerieToolStripMenuItem.Click
        Dim serie As String = InputBox("Teclee la serie para las notas de cargo", "", "")
        My.Settings.ncargo = serie
        My.Settings.Save()
        Dim msg As String
        Dim adap As New integraDataSetTableAdapters.DocumentosTableAdapter
        msg = "Nota de Cargo " + My.Settings.ncargo + adap.siguiente_nc(My.Settings.ncargo).ToString
        Me.Text = msg
        adap.Dispose()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        guardar_ncargo()
    End Sub
End Class