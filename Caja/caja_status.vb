Public Class caja_status


    Private Sub status_caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Log_cajasTableAdapter.FillBycaja_fecha(Me.AdmintegralDataSet.log_cajas, My.Settings.ncaja, CDate(Now.Date))
    End Sub

    Private Sub boton_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ok.Click
        Me.Close()
    End Sub
End Class