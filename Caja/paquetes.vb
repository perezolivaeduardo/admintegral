Public Class paquetes

   
    Private Sub PaquetesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub paquetes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Paquetes_detalleTableAdapter.Fill(Me.IntegraDataSet.paquetes_detalle)
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.paquetes' Puede moverla o quitarla según sea necesario.
        Me.PaquetesTableAdapter.Fill(Me.IntegraDataSet.paquetes)

    End Sub

    Private Sub PaquetesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaquetesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaquetesBindingSource.EndEdit()
        Me.PaquetesTableAdapter.Update(Me.IntegraDataSet.paquetes)

        Me.Paquetes_detalleBindingSource.EndEdit()
        Me.Paquetes_detalleTableAdapter.Update(Me.IntegraDataSet.paquetes_detalle)

    End Sub

    Private Sub panelcaptura_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelcaptura.Panel1.Paint

    End Sub

    Private Sub Paquetes_detalleDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Paquetes_detalleDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim adap As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        My.Forms.Buscar_productos.ShowDialog()
        Me.id.Text = producto.a1id
        Me.descripciontextbox.Text = producto.a2descripcion
        Me.unitario.Text = adap.GetcodigoByid(producto.a1id, 1).Rows(0).Item("venta").ToString
        Me.iva.Text = producto.a6iva
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iva.TextChanged

    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Dim adap As New integraDataSetTableAdapters.paquetes_detalleTableAdapter
        adap.Insert(Me.PaquetesDataGridView.CurrentRow.Cells(0).Value, Me.id.Text, Me.cantidad.Text, Me.unitario.Text, Me.iva.Text, True, Me.descripciontextbox.Text)
        Me.Paquetes_detalleTableAdapter.Fill(Me.IntegraDataSet.paquetes_detalle)
        Me.id.Text = ""
        Me.descripciontextbox.Text = ""
        Me.cantidad.Text = "1"
        Me.iva.Text = ""
        Me.unitario.Text = ""
        Me.id.Focus()
    End Sub

    Private Sub Paquetes_detalleDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Paquetes_detalleDataGridView.CellDoubleClick
        Me.Paquetes_detalleBindingSource.RemoveCurrent()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.PaquetesBindingSource.EndEdit()
        Me.PaquetesTableAdapter.Update(Me.IntegraDataSet.paquetes)

        Me.Paquetes_detalleBindingSource.EndEdit()
        Me.Paquetes_detalleTableAdapter.Update(Me.IntegraDataSet.paquetes_detalle)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sb, iva, tt As Decimal
        sb = 0 : iva = 0 : tt = 0
        With Me.Paquetes_detalleDataGridView
            For j As Integer = 0 To .Rows.Count - 1
                sb += .Rows(j).Cells("dgvprecio").Value
                iva += .Rows(j).Cells("dgvprecio").Value * (.Rows(j).Cells("dgviva").Value / 100)
            Next
            tt = sb + iva
        End With
        Me.SubTextBox.Text = sb
        Me.IvaTextBox.Text = iva
        Me.TotalTextBox.Text = tt
    End Sub

    Private Sub SplitContainer2_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sb, iva, tt, cant As Decimal
        sb = 0 : iva = 0 : tt = 0 : cant = Me.pcant.Text
        With Me.Paquetes_detalleDataGridView
            For j As Integer = 0 To .Rows.Count - 1
                sb += .Rows(j).Cells("dgvprecio").Value * cant
                iva += (.Rows(j).Cells("dgvprecio").Value * (.Rows(j).Cells("dgviva").Value / 100)) * cant
            Next
            tt = sb + iva
        End With
        Me.pst.Text = sb
        Me.piva.Text = iva
        Me.ptot.Text = tt
    End Sub
End Class