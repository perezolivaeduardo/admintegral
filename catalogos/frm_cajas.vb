Public Class frm_cajas
    Private Sub CajasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SeriesBindingSource.EndEdit()
        Me.SeriesTableAdapter.Update(Me.AdmintegralDataSet.Series) ' Actualiza Serie

        Me.Tbl_almacenesBindingSource.EndEdit()
        Me.Tbl_almacenesTableAdapter.Update(Me.AdmintegralDataSet.tbl_almacenes) 'almacenes

        Me.CajasBindingSource.EndEdit()
        Me.CajasTableAdapter.Update(Me.AdmintegralDataSet.cajas) 'Cajas
    End Sub 'Guardar Cambios

    Private Sub frm_cajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Series' Puede moverla o quitarla según sea necesario.
        Me.SeriesTableAdapter.Fill(Me.AdmintegralDataSet.Series)
        Me.CajasTableAdapter.Fill(Me.AdmintegralDataSet.cajas)
    End Sub 'leer cajas

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.SeriesBindingSource.EndEdit()
        Me.SeriesTableAdapter.Update(Me.AdmintegralDataSet.Series) ' Actualiza Serie

        Me.Tbl_almacenesBindingSource.EndEdit()
        Me.Tbl_almacenesTableAdapter.Update(Me.AdmintegralDataSet.tbl_almacenes) 'almacenes

        Me.CajasBindingSource.EndEdit()
        Me.CajasTableAdapter.Update(Me.AdmintegralDataSet.cajas) 'Cajas
        Me.Close()
    End Sub 'cerrar forma

    Private Sub boton_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_test.Click

        Dim f As New System.IO.StreamWriter("c:\tmp\cajon.txt", False)
        Dim cadena As String = Microsoft.VisualBasic.Chr(27) + Me.Abrir_cajonTextBox.Text
        f.WriteLine(cadena)
        f.Close()
        Try
            Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, "c:\tmp\cajon.txt")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        dgv.Visible = Not dgv.Visible
    End Sub

    Private Sub dgv_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        Try
        Catch ex As Exception
        End Try
    End Sub


End Class