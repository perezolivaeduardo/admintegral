Imports System.IO
Public Class caja_Depurar

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        listbox.Items.Clear()
        Dim dir As New DirectoryInfo("c:\tmp\")
        dir.GetFiles()
        For Each file As FileInfo In dir.GetFiles("*.*")
            If file.CreationTime < CDate("1/1/2010") Then
                listbox.Items.Add(file.Name)
                listbox.Items.Add(file.CreationTime.Date.ToShortDateString())
            End If
        Next
    End Sub
End Class