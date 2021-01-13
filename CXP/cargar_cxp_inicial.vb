Public Class cargar_cxp_inicial

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Me.id_directorio.Text = gprov.id
        Me.DocumentosTableAdapter.FillByentradasXprov(Me.IntegraDataSet.Documentos, id_directorio.Text)
        Me.Cxp_facturasTableAdapter.FillByid(Me.IntegraDataSet.cxp_facturas, id_directorio.Text)
    End Sub

  

    Private Sub cargar_cxp_inicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SplitContainer2_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub DocumentosDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Try
            With dgv.CurrentRow
                Me.Cxp_facturasTableAdapter.Insert(Me.id_directorio.Text, .Cells("dgvfactura").Value, .Cells("dgvff").Value, .Cells("dgvreg").Value, .Cells("dgvvence").Value, .Cells("dgviva10").Value + .Cells("dgviva15").Value, .Cells("dgvimporte").Value, 0, 0, .Cells("ieps").Value)
                Me.Cxp_facturasTableAdapter.FillByid(Me.IntegraDataSet.cxp_facturas, id_directorio.Text)
            End With
        Catch ex As Exception
            MsgBox("No se puede agregar, puede ser que ya exista el registro")
        End Try
        
    End Sub

    Private Sub Cxp_facturasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cxp_facturasDataGridView.CellDoubleClick
        Me.Cxp_facturasBindingSource.RemoveCurrent()
        Me.Validate()
        Me.Cxp_facturasBindingSource.EndEdit()
        Me.Cxp_facturasTableAdapter.Update(Me.IntegraDataSet.cxp_facturas)

    End Sub
End Class