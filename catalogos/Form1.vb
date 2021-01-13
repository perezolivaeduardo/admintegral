Public Class Form1

    Private Sub Cfdi_documentos_relacionadosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Cfdi_documentos_relacionadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Cfdi_documentos_relacionadosBindingSource.EndEdit()
        Me.Cfdi_documentos_relacionadosTableAdapter.Update(Me.FeiDataset.cfdi_documentos_relacionados)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FeiDataset.cfdi_documentos_relacionados' Puede moverla o quitarla según sea necesario.
        Me.Cfdi_documentos_relacionadosTableAdapter.Fill(Me.FeiDataset.cfdi_documentos_relacionados)

    End Sub
End Class