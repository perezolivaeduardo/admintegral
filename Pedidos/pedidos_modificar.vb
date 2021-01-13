Public Class pedidos_modificar
    Dim upd As Boolean = False
    Dim sepuedemodificar As Boolean = False
    Dim se_ha_modificado As Boolean = False
    Public Sub cargar_pedido(ByVal pedido As Integer)
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)
        Me.Pedidos_detalleTableAdapter.FillByPedido(Me.AdmintegralDataSet.Pedidos_detalle, pedido)
        Me.PedidosTableAdapter.FillByPedido(Me.AdmintegralDataSet.pedidos, pedido)

    End Sub 'cargar forma

    Public Sub calcular()
        Dim j As Integer, factor As Double, ex, v, cc, pvc As Double
        For j = 0 To dgv.Rows.Count - 1
            factor = dgv.Rows(j).Cells("FAC").Value
            ex = dgv.Rows(j).Cells("EUB").Value / factor
            v = dgv.Rows(j).Cells("VUB").Value / factor
            cc = dgv.Rows(j).Cells("costob").Value * factor
            pvc = dgv.Rows(j).Cells("pventab").Value * factor
            dgv.Rows(j).Cells("EUC").Value = ex
            dgv.Rows(j).Cells("VUC").Value = v
            dgv.Rows(j).Cells("CC").Value = cc
            dgv.Rows(j).Cells("PVC").Value = pvc
        Next
        For j = 3 To 7
            dgv.Columns(j).Visible = Not dgv.Columns(j).Visible
        Next
        For j = 17 To 22 : dgv.Columns(j).Visible = False : Next j
        calcula_subtotal()
        totaliza()
        sugerir()
    End Sub ' calcular subtotal

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cancelar.Click
        If upd = True Then
            Dim x As MsgBoxResult
            x = MsgBox("Salir sin guardar Cambios", MsgBoxStyle.YesNo, "Salir")
            If x = MsgBoxResult.No Then Exit Sub
        End If
        Try
            dgv.Dispose()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub 'Salir

    Private Sub boton_onoff_base_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_onoff_base.Click
        For j As Integer = 2 To 6
            dgv.Columns(j).Visible = Not dgv.Columns(j).Visible
            dgv.Columns(j).DefaultCellStyle.BackColor = Color.Aqua
        Next

    End Sub ' on/off colunas BASE

    Private Sub boto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boto_guardar.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Me.Validate()
            Me.Pedidos_detalleBindingSource.EndEdit()
            Me.Pedidos_detalleTableAdapter.Update(Me.AdmintegralDataSet.Pedidos_detalle)
            Me.Validate()
        Catch ex As Exception
            MsgBox("Error guardando detalle " + ex.Message)
        End Try
        Try
            Me.PedidosBindingSource.EndEdit()
            Me.PedidosTableAdapter.Update(Me.AdmintegralDataSet.pedidos)
        Catch ex As Exception
            MsgBox("Error guardando Pedido " + ex.Message)
        End Try
        Me.Dispose()
        Me.Close()
        Windows.Forms.Cursor.Current = Cursors.Default
        My.Forms.Pedidos_Relacion.recarga()
    End Sub 'Boton Guardar

    Private Sub dgv_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgv.CellBeginEdit
        If Me.sepuedemodificar = False Then
            e.Cancel = True
        End If
    End Sub ' Guardar y salir

    Private Sub dgv_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Dim c As Integer
        c = dgv.CurrentCell.ColumnIndex
        If c = 13 Or c = 14 Then
            Dim ct As Single = dgv.CurrentRow.Cells("dgvpedido").Value
            If ct > 0 Then
                Dim cu As Double = dgv.CurrentRow.Cells(9).Value ' costo unitario und.compra
                If dgv.CurrentRow.Cells(14).Value > 0 Then cu = dgv.CurrentRow.Cells(14).Value
                Dim st As Double = ct * cu
                dgv.CurrentRow.Cells(14).Value = cu
                dgv.CurrentRow.Cells(15).Value = st
            End If
            totaliza()
            upd = True
        End If
        Me.se_ha_modificado = True
    End Sub ' calcula subtoal al editar pedido o costo

    Private Sub calcula_subtotal()
        Dim j As Integer
        For j = 0 To dgv.Rows.Count - 1
            Dim ct As Integer = dgv.Rows(j).Cells(13).Value
            Dim cu As Double = dgv.Rows(j).Cells(14).Value
            Dim st As Double = ct * cu
            dgv.Rows(j).Cells(15).Value = st
        Next
    End Sub ' calcul subtotal de toda la hoja

    Private Sub totaliza()
        Dim j As Integer, tt As Double
        For j = 0 To dgv.Rows.Count - 1
            Dim st As Double = dgv.Rows(j).Cells(15).Value
            tt = tt + st
        Next

        total.Text = Format(tt, "N2")
        lblinfo.Text = Me.dgv.Rows.Count.ToString + " Productos en esta hoja de pedido."
    End Sub 'Suma subtotales y totaliza el pedido

    Private Sub sugerir()
        Dim j As Integer
        Dim v, ex As Double
        For j = 0 To dgv.Rows.Count - 1
            v = dgv.Rows(j).Cells("VUC").Value
            ex = dgv.Rows(j).Cells("EUC").Value
            If ex > 0 And v = 0 Then
                dgv.Rows(j).DefaultCellStyle.ForeColor = Color.Red
            Else
                If ex > v Then
                    dgv.Rows(j).DefaultCellStyle.ForeColor = Color.Yellow
                    dgv.Rows(j).DefaultCellStyle.BackColor = Color.Blue
                Else
                    If ex < v Then
                        dgv.Rows(j).DefaultCellStyle.ForeColor = Color.Green
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.TextChanged
        ImporteTextBox.Text = total.Text
    End Sub

    Private Sub pedidos_modificar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        dgv.Dispose()
        Me.Close()
    End Sub

    Private Sub StatusTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusTextBox.TextChanged
        If StatusTextBox.Text = "0" Or StatusTextBox.Text = "11" Then
            Me.sepuedemodificar = True
        End If
    End Sub

    Private Sub Id_directorioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_directorioTextBox.TextChanged
        leer_provedor(Me.Id_directorioTextBox.Text)
        Me.provedortxt.Text = gprov.nombre
    End Sub

    Private Sub boton_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_imprimir.Click
        If Me.se_ha_modificado = True Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Me.Validate()
                Me.Pedidos_detalleBindingSource.EndEdit()
                Me.Pedidos_detalleTableAdapter.Update(Me.AdmintegralDataSet.Pedidos_detalle)
                Me.Validate()
            Catch ex As Exception
                MsgBox("Error guardando detalle " + ex.Message)
            End Try
            Try
                Me.PedidosBindingSource.EndEdit()
                Me.PedidosTableAdapter.Update(Me.AdmintegralDataSet.pedidos)
            Catch ex As Exception
                MsgBox("Error guardando Pedido " + ex.Message)
            End Try
        End If


        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.Pedidos_imprimir.cargar(Me.Id_pedidoTextBox.Text)
        My.Forms.Pedidos_imprimir.Visible = False
        My.Forms.Pedidos_imprimir.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub boton_sugerir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_sugerir.Click
        sugerir()
    End Sub
End Class