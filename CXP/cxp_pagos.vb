Public Class cxp_pagos

    Private Sub Cxp_chequesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Cxp_chequesBindingSource.EndEdit()
        Me.Cxp_chequesTableAdapter.Update(Me.IntegraDataSet.cxp_cheques)

    End Sub

    Private Sub cxp_pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.cxp_saldos_dias' Puede moverla o quitarla según sea necesario.
        'Me.Cxp_chequesTableAdapter.Fill(Me.IntegraDataSet.cxp_cheques)
        Me.Cxp_chequesBindingSource.AddNew()
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Me.Id_directorioTextBox.Text = gprov.id
        nombre.Text = gprov.nombre
        cargar(Me.Id_directorioTextBox.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar_proveedor.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Me.Id_directorioTextBox.Text = gprov.id
        nombre.Text = gprov.nombre
        cargar(Me.Id_directorioTextBox.Text)
    End Sub

 
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Me.Validate()
        'guarda el cheque
        Me.Cxp_chequesBindingSource.EndEdit()
        Me.Cxp_chequesTableAdapter.Update(Me.IntegraDataSet.cxp_cheques)
        'guarda el detalle del cheque
        Me.Cxp_abonosBindingSource.EndEdit()
        Me.Cxp_abonosTableAdapter.Update(Me.IntegraDataSet.cxp_abonos)

        'manda a actualizar el campo de abono en cada factura en la tabla de cxp:abonos
        Dim fact As String
        For j As Integer = 0 To Me.Cxp_abonosDataGridView.Rows.Count - 1
            fact = Me.Cxp_abonosDataGridView.Rows(j).Cells("dgvfactabono").Value
            actualiza_factura_cxp(Me.Id_directorioTextBox.Text, fact)
        Next
        Me.Close()
    End Sub

    Private Sub btn_registra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registra.Click
        Me.SplitContainer1.Panel2.Enabled = False
        Dim cmd As String = "select * from cxp_cheques where id_directorio =" + Me.Id_directorioTextBox.Text + " and id_banco='" + Me.Id_bancoTextBox.Text + "' and referencia ='" + Me.ReferenciaTextBox.Text + "'"
        If leer_tabla(cmd).Rows.Count > 0 Then MsgBox("Ya existe este cheque") : Exit Sub
        Me.SplitContainer1.Panel2.Enabled = True
        Me.Cxp_abonosTableAdapter.FillBykey(Me.IntegraDataSet.cxp_abonos, Me.Id_directorioTextBox.Text, Me.Id_bancoTextBox.Text, Me.ReferenciaTextBox.Text)
        totaliza()
    End Sub
    Private Sub cargar(ByVal id As Integer)
        Me.Cxp_saldos_diasTableAdapter.FillByid(Me.IntegraDataSet.cxp_saldos_dias, id)
    End Sub

    Private Sub Id_directorioTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id_directorioTextBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            cargar(Me.Id_directorioTextBox.Text)
        End If
    End Sub

    Private Sub validar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_directorioTextBox.TextChanged, ReferenciaTextBox.TextChanged, Id_bancoTextBox.TextChanged
        btn_registra.Enabled = True
        If Me.Id_directorioTextBox.Text.Length = 0 Then btn_registra.Enabled = False
        If Me.Id_bancoTextBox.Text.Length = 0 Then btn_registra.Enabled = False
        If Me.ReferenciaTextBox.Text.Length = 0 Then btn_registra.Enabled = False
    End Sub

    Private Sub Cxp_saldos_diasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cxp_saldos_diasDataGridView.CellDoubleClick
        Dim factura As String
        Dim importe As Decimal
        factura = Me.Cxp_saldos_diasDataGridView.CurrentRow.Cells("dgvfactura").Value
        importe = Me.Cxp_saldos_diasDataGridView.CurrentRow.Cells("dgvimporte").Value
        Try
            Me.Cxp_abonosTableAdapter.Insert(Me.Id_directorioTextBox.Text, Me.Id_bancoTextBox.Text, Me.ReferenciaTextBox.Text, factura, importe)
            Me.Cxp_abonosTableAdapter.FillBykey(Me.IntegraDataSet.cxp_abonos, Me.Id_directorioTextBox.Text, Me.Id_bancoTextBox.Text, Me.ReferenciaTextBox.Text)
        Catch ex As Exception

        End Try

        totaliza()
    End Sub

    
    Private Sub totaliza()
        Dim total As Decimal = 0
        For j As Integer = 0 To Me.Cxp_abonosDataGridView.Rows.Count - 1
            total += Me.Cxp_abonosDataGridView.Rows(j).Cells("dgvabono").Value
        Next
        Me.ImporteTextBox.Text = Format(total, "N2")
    End Sub

    Private Sub Cxp_abonosDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cxp_abonosDataGridView.CellDoubleClick
        Me.Cxp_abonosBindingSource.RemoveCurrent()
        Me.Validate()
        Me.Cxp_abonosBindingSource.EndEdit()
        Me.Cxp_abonosTableAdapter.Update(Me.IntegraDataSet.cxp_abonos)
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'cancela guardar 
        Me.Cxp_chequesBindingSource.CancelEdit()
        Me.Cxp_abonosTableAdapter.borra_abonos(Me.Id_directorioTextBox.Text, Me.Id_bancoTextBox.Text, Me.ReferenciaTextBox.Text)
    End Sub
End Class