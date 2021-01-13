Imports System.IO
Imports System.Drawing.Printing
Public Class agentes_pedidos

    Private Sub agentes_pedidos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
        Me.TextBox1.Text = adap.path(4).ToString.Trim
        Me.FolderBrowserDialog1.SelectedPath = TextBox1.Text
        ' Default printer       
        Dim pd As New Printing.PrintDocument
        Dim Impresoras As String
        Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

        ' recorre las impresoras instaladas=
        For Each Impresoras In PrinterSettings.InstalledPrinters
            ComboBox1.Items.Add(Impresoras.ToString)
        Next
        ComboBox1.Text = s_Default_Printer
    End Sub
    Private Sub cargar()
        If TextBox1.TextLength = 0 Then Exit Sub
        listbox.Items.Clear()
        Dim dir As New DirectoryInfo(TextBox1.Text)
        For Each file As FileInfo In dir.GetFiles("*.txt")
            listbox.Items.Add(file.Name)
            'Alguna otra opción aquí
        Next
    End Sub

    Private Sub boton_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_quitar.Click
        For j As Integer = 0 To ListBox.Items.Count - 1
            ListBox.SetItemChecked(j, False)
        Next j
    End Sub

    Private Sub boton_seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_seleccionar.Click
        For j As Integer = 0 To listbox.Items.Count - 1
            listbox.SetItemChecked(j, True)
        Next j
    End Sub

    Private Sub boton_carpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_carpeta.Click
        Me.FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = Me.FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cargar()
    End Sub

    Private Sub boton_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_imprimir.Click
        For j As Integer = 0 To listbox.CheckedItems.Count - 1
            Dim f As String = TextBox1.Text + "\" + listbox.CheckedItems.Item(j)
            Imprimir.SendFileToPrinter(ComboBox1.Text, f)
            Imprimir.SendStringToPrinter(ComboBox1.Text, "File : " + listbox.CheckedItems.Item(j).Trim)
            Imprimir.SendStringToPrinter(ComboBox1.Text, Microsoft.VisualBasic.Chr(12))
        Next
    End Sub
    Private Sub imprime(ByVal file As String)
        
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
End Class