Public Class Emisor

    Private Sub EmisorBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Emisor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FeiDataset.emisor' Puede moverla o quitarla según sea necesario.
        Me.EmisorTableAdapter.Fill(Me.FeiDataset.emisor)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Guardar Cambios?"
        msgtitulo = "GUARDAR"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.Yes Then
            Me.Validate()
            Me.EmisorBindingSource.EndEdit()
            Me.EmisorTableAdapter.Update(Me.FeiDataset.emisor)
        End If

        Me.Close()


    End Sub
End Class