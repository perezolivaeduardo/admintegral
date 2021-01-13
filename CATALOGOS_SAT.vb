Public Class CATALOGOS_SAT

    Private Sub Productos_ServiciosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Productos_ServiciosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SAT_catalogosDataSet)

    End Sub

    Private Sub CATALOGOS_SAT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SAT_catalogosDataSet.Productos_Servicios' Puede moverla o quitarla según sea necesario.
        Me.Productos_ServiciosTableAdapter.Fill(Me.SAT_catalogosDataSet.Productos_Servicios)
        lbl.Text = My.Settings.SAT_catalogosConnectionString.ToString
        Me.Refresh()
    End Sub
End Class