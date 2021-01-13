Public Class Autorizaciones

    Private Sub Autorizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.AdmintegralDataSet.cajas)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.sql_clientes' Puede moverla o quitarla según sea necesario.
        Try
            Me.Sql_clientesTableAdapter.Fill(Me.AdmintegralDataSet.sql_clientes)
            Me.AutorizacionesTableAdapter.Fill(Me.AdmintegralDataSet.autorizaciones)
            Me.AutorizacionesBindingSource.Filter = "status =0"
            Timer.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub boton_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_refresh.Click
        Me.AutorizacionesTableAdapter.Fill(Me.AdmintegralDataSet.autorizaciones)
        Me.AutorizacionesBindingSource.Filter = "status =0"
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim x As MsgBoxResult
        Dim im As Decimal
        If Me.AutorizacionesDataGridView.CurrentRow.Index < 0 Then Exit Sub
        im = Me.AutorizacionesDataGridView.CurrentRow.Cells("dgvimporte").Value
        If im = 0 Then MsgBox("Solo debe aceptar") : Exit Sub

        x = MsgBox("Autorizar esta Venta", MsgBoxStyle.YesNo, "Autorizar")
        If x = MsgBoxResult.Yes Then
            Try
                With Me.AutorizacionesDataGridView.CurrentRow
                    .Cells("dgvautoriza").Value = user.id
                    .Cells("dgvfecha").Value = Now.Date
                    .Cells("dgvstatus").Value = 2
                End With
            Catch ex As Exception

            End Try

        End If
        Me.Validate()
        Me.AutorizacionesBindingSource.EndEdit()
        Me.AutorizacionesTableAdapter.Update(Me.AdmintegralDataSet.autorizaciones)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub boton_rechazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_rechazar.Click
        Dim x As MsgBoxResult
        x = MsgBox("Rechazar ", MsgBoxStyle.YesNo, "Rechazar")
        If x = MsgBoxResult.Yes Then
            Try
                With Me.AutorizacionesDataGridView.CurrentRow
                    .Cells("dgvautoriza").Value = user.id
                    .Cells("dgvfecha").Value = Now.Date
                    .Cells("dgvstatus").Value = 1
                End With
            Catch ex As Exception

            End Try

        End If
        Me.Validate()
        Me.AutorizacionesBindingSource.EndEdit()
        Me.AutorizacionesTableAdapter.Update(Me.AdmintegralDataSet.autorizaciones)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub boton_ver_todas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ver_todas.Click
        Me.AutorizacionesBindingSource.Filter = ""
    End Sub

    Private Sub AutorizacionesDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles AutorizacionesDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AutomaticoONToolStripMenuItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomaticoONToolStripMenuItem.EnabledChanged
        Timer.Enabled = Me.AutomaticoONToolStripMenuItem.Checked
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Me.Text = "Checando"
        Me.AutorizacionesTableAdapter.Fill(Me.AdmintegralDataSet.autorizaciones)
        Me.AutorizacionesBindingSource.Filter = "status =0"
        Me.Text = "Ultimo Chequeo " + Now.TimeOfDay.ToString
        If Me.AutorizacionesDataGridView.Rows.Count > 0 Then
            Me.WindowState = FormWindowState.Normal
            Me.TopMost = True
            Me.Focus()
            Beep()
            Me.TopMost = False
        End If

    End Sub

    Private Sub AutomaticoONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomaticoONToolStripMenuItem.Click
        Me.AutomaticoONToolStripMenuItem.Checked = Not Me.AutomaticoONToolStripMenuItem.Checked
        Timer.Enabled = Me.AutomaticoONToolStripMenuItem.Checked
    End Sub

    Private Sub AutorizacionesDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AutorizacionesDataGridView.CellDoubleClick
        Dim id As Integer = Me.AutorizacionesDataGridView.CurrentRow.Cells("id_cliente").Value
        Try
            'My.Forms.cxc_info.info(id, True)
            'My.Forms.cxc_info.Show()
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            My.Forms.cxc.Show()
            My.Forms.cxc.carga_cliente(id)
            My.Forms.cxc.idtxt.Text = id.ToString
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        Dim im As Decimal
        Try
            If Me.AutorizacionesDataGridView.CurrentRow.Index < 0 Then Exit Sub
            im = Me.AutorizacionesDataGridView.CurrentRow.Cells("dgvimporte").Value
            If im > 0 Then MsgBox("Debe de autorizar o Rechazar") : Exit Sub
            Me.AutorizacionesBindingSource.RemoveCurrent()
            Me.Validate()
            Me.AutorizacionesBindingSource.EndEdit()
            Me.AutorizacionesTableAdapter.Update(Me.AdmintegralDataSet.autorizaciones)
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim ix As MsgBoxResult
        ix = MsgBox("Seguro que quiere salir", MsgBoxStyle.YesNo, "Cerrar Autorizacion")
        If ix = MsgBoxResult.Yes Then Me.Close()
    End Sub


    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class