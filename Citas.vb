Public Class Citas

       Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReporteDataSet.sql_citas' Puede moverla o quitarla según sea necesario.
        Me.Sql_citasTableAdapter.FillByfecha(Me.ReporteDataSet.sql_citas, Now.Date.ToShortDateString)
        'TODO: esta línea de código carga datos en la tabla 'ReporteDataSet.agenda' Puede moverla o quitarla según sea necesario.
        Me.AgendaTableAdapter.Fill(Me.ReporteDataSet.agenda)
        'TODO: esta línea de código carga datos en la tabla 'ReporteDataSet.citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.FillByfecha(Me.ReporteDataSet.citas, Now.Date.ToShortDateString)
        Me.SplitContainer1.Panel1Collapsed = False
        Me.SplitContainer1.Panel2Collapsed = True
        Me.Timer1.Enabled = True
        valida()
    End Sub

    Private Sub btn_salir_cita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_cita.Click
        Me.CitasBindingSource.CancelEdit()
        Me.SplitContainer1.Panel1Collapsed = False
        Me.SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.SplitContainer1.Panel1Collapsed = True
        Me.SplitContainer1.Panel2Collapsed = False
        nueva_cita()
    End Sub ' Nueva Cita
    Private Sub nueva_cita()
        Me.CitasBindingSource.AddNew()
        Me.FechaTextBox.Text = Now.Date.ToShortDateString
        Me.TurnoTextBox.Text = Me.CitasTableAdapter.turno(FechaTextBox.Text)
        Me.HoraTextBox.Text = Now.ToShortTimeString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'My.Forms.Entreada_nueva.MdiParent = Me
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.Id_directorioTextBox.Text = gprov.id
        Me.nombreprovedor.Text = gprov.nombre
        validar_provedor()
    End Sub

    Private Sub Id_directorioTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id_directorioTextBox.KeyPress
        If e.KeyChar = chr13 Then
            Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
            Try
                Me.nombreprovedor.Text = adap.GetDataByID(Id_directorioTextBox.Text, 1).Rows(0).Item("nombre")
                validar_provedor()
            Catch ex As Exception

            End Try

        End If
    End Sub 'pedir proveedor

    Private Sub validar_provedor()
        Dim filtro As String
        If Id_directorioTextBox.TextLength < 1 Then Exit Sub
        Try
            filtro = "id_directorio =" + Id_directorioTextBox.Text
            Me.AgendaBindingSource.Filter = filtro
        Catch ex As Exception
        End Try
        If Me.AgendaBindingSource.Position < 0 Then
            MsgBox("No existen agentes para este proveedor, Registrar un Agente por lo menos")
            nuevo_agente()
        Else
            Me.AgenteTextBox.Text = Me.NumeroTextBox.Text
        End If
    End Sub

    Private Sub NumeroTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumeroTextBox.TextChanged
        Me.AgenteTextBox.Text = Me.NumeroTextBox.Text
    End Sub

    Private Sub AgenteTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenteTextBox1.TextChanged
        Me.Nombre_agente.Text = Me.AgenteTextBox1.Text
    End Sub

    Private Sub Panelalta_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panelalta.VisibleChanged
        If Panelalta.Visible = True Then
            Me.SplitContainer2.Panel1.Enabled = False
            Me.barra1.Enabled = False
            Me.ToolStrip1.Enabled = False
        Else
            Me.SplitContainer2.Panel1.Enabled = True
            Me.barra1.Enabled = True
            Me.ToolStrip1.Enabled = True
        End If
    End Sub

    Private Sub btn_nuevo_agente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo_agente.Click
        nuevo_agente()
    End Sub
    Private Sub nuevo_agente()
        If Me.Id_directorioTextBox.TextLength = 0 Then MsgBox("Seleccione Un proveedor") : Exit Sub
        Panelalta.Visible = True
        Me.AgendaBindingSource.AddNew()
        Me.Id_directorioTextBox1.Text = Me.Id_directorioTextBox.Text
        Me.NumeroTextBox.Text = Me.AgendaTableAdapter._next(Id_directorioTextBox.Text)
        Me.AgenteTextBox.Focus()
    End Sub

    Private Sub btn_canelar_alta_agente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_canelar_alta_agente.Click
        Me.AgendaBindingSource.CancelEdit()
        Panelalta.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Validate()
        Me.AgendaBindingSource.EndEdit()
        Me.AgendaTableAdapter.Update(Me.ReporteDataSet.agenda)
        Panelalta.Visible = False
        Me.AsuntoTextBox.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim ix As MsgBoxResult = MsgBox("Quiere cancelar", MsgBoxStyle.YesNo, "Borrar agente")
        If ix = MsgBoxResult.Yes Then
            Try
                Me.AgendaBindingSource.RemoveCurrent()
                Me.AgendaTableAdapter.Update(Me.ReporteDataSet.agenda)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_guardar.Click
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.CitasTableAdapter.Update(Me.ReporteDataSet.citas)
        Me.Sql_citasTableAdapter.Fill(Me.ReporteDataSet.sql_citas)
        Me.SplitContainer1.Panel1Collapsed = False
        Me.SplitContainer1.Panel2Collapsed = True

    End Sub ' Guarda la cita

    Private Sub Boton_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_actualizar.Click
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.CitasTableAdapter.Update(Me.ReporteDataSet.citas)
        'TODO: esta línea de código carga datos en la tabla 'ReporteDataSet.sql_citas' Puede moverla o quitarla según sea necesario.
        Me.Sql_citasTableAdapter.Fill(Me.ReporteDataSet.sql_citas)
    End Sub 'Actualizar 

    Private Sub Sql_citasDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_citasDataGridView.CellClick
        Dim f, fe, t, filtro As String
        Try
            With Me.Sql_citasDataGridView.CurrentRow
                fe = .Cells(0).Value : t = .Cells(1).Value
                f = "#" + Format(CDate(fe), "yyyy-MM-dd") + "#"
                filtro = "fecha =" + f + " and turno = " + t
                Me.CitasBindingSource.Filter = filtro
                If Me.CitasBindingSource.Position >= 0 Then
                    Me.boton_borrar_cita.Visible = True
                Else
                    Me.boton_borrar_cita.Visible = False
                End If
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub boton_modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_modifica.Click
        Me.SplitContainer1.Panel1Collapsed = True
        Me.SplitContainer1.Panel2Collapsed = False
    End Sub

    

    Private Sub Comentarios_recepcionTextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comentarios_recepcionTextBox1.Enter
        Comentarios_recepcionTextBox1.Text = Comentarios_recepcionTextBox1.Text.Trim(" ")
    End Sub

    Private Sub Sql_citasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_citasDataGridView.CellDoubleClick
        atender()
    End Sub
    Private Sub atender()
        Dim f, fe, t, filtro As String
        With Me.Sql_citasDataGridView.CurrentRow
            fe = .Cells(0).Value : t = .Cells(1).Value
            f = "#" + Format(CDate(fe), "yyyy-MM-dd") + "#"
            filtro = "fecha =" + f + " and turno = " + t
            Me.CitasBindingSource.Filter = filtro
            If Me.CitasBindingSource.Position >= 0 Then
                'actualiza Atendidos
                Me.AtendidoCheckBox.Checked = True
                Me.Validate()
                Me.CitasBindingSource.EndEdit()
                Me.CitasTableAdapter.Update(Me.ReporteDataSet.citas)
                Me.Sql_citasTableAdapter.Fill(Me.ReporteDataSet.sql_citas)

                Me.SplitContainer1.Visible = False : Me.Refresh()
                Me.boton_borrar_cita.Visible = True
                My.Forms.Kardex_express.Preparar_pedido(Me.Id_directorioTextBox.Text, Me.AgenteTextBox.Text)
                My.Forms.Kardex_express.Show()
                Me.SplitContainer1.Visible = True

            Else
                Me.boton_borrar_cita.Visible = False
            End If
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Sql_citasTableAdapter.FillByfecha(Me.ReporteDataSet.sql_citas, Now.Date.ToShortDateString)
        valida()
    End Sub
    Private Sub valida()
        For j As Integer = 0 To Me.Sql_citasDataGridView.Rows.Count - 1
            With Me.Sql_citasDataGridView.Rows(j)
                If .Cells("atendido").Value = True Then
                    .DefaultCellStyle.ForeColor = Color.IndianRed
                End If
            End With
        Next
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Sql_citasTableAdapter.FillByfecha(Me.ReporteDataSet.sql_citas, Now.Date.ToShortDateString)
        valida()
    End Sub

    Private Sub Boton_pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_pedido.Click
        My.Forms.Kardex_express.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        'carga la version anterior de pedidso con vendedores y grupos.
        My.Forms.Kardex_consultar.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim x As Boolean
        x = borrar_tablas_temporales() : MsgBox("tabka borrada")
        x = crear_existencias() : MsgBox("existencias")
        x = crear_catalog_general() : MsgBox("catalogo_general")
        x = crear_pz_vendidas() : MsgBox("pz_vendidas")
        x = crear_mis_movimientos() : MsgBox("movimientos")
    End Sub
End Class