Imports System.Windows.Forms

Public Class frm_selecciona_caja
    Public ncaja As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ncaja = Me.CajasDataGridView.CurrentRow.Cells(0).Value
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frm_selecciona_caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta l�nea de c�digo carga datos en la tabla 'AdmintegralDataSet.cajas' Puede moverla o quitarla seg�n sea necesario.
        Me.CajasTableAdapter.Fill(Me.AdmintegralDataSet.cajas)

    End Sub
End Class
