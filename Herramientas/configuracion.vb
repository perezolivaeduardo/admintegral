Imports System.Drawing.Printing

Public Class configuracion
    Dim sql_local As String = "Data Source=MATRIX\SQLEXPRESS;Initial Catalog=integral;Integrated Security=True"
    Dim sql_server As String = "Data Source=ABARROTERABARA;Initial Catalog=integra;User ID=sa"
    Dim cadenas(0 To 5) As String

    Private Sub configuracion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        My.Settings.Save()
    End Sub

    Private Sub configuracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Generales' Puede moverla o quitarla según sea necesario.
        Me.GeneralesTableAdapter.Fill(Me.AdmintegralDataSet.Generales)
        Dim pd As New Printing.PrintDocument
        Dim Impresoras As String

        ' Default printer       
        Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

        ' recorre las impresoras instaladas=
        For Each Impresoras In PrinterSettings.InstalledPrinters
            ComboBox1.Items.Add(Impresoras.ToString)
        Next

        'general
        With My.Settings
            Me.ncajatxt.Text = .ncaja
            Me.solocajachk.Checked = .solocaja
            Me.almacentxt.Text = .almacen
            Me.lineasxfacturatxt.Text = .LineasXfactura
            Me.IVAtxt.Text = .iva
            Me.margentxt.Text = .margen
            Me.iva2.Text = .iva2
        End With

        Try
            Dim folderExists As Boolean
            folderExists = My.Computer.FileSystem.DirectoryExists("C:\tmp")
            If folderExists = False Then
                My.Computer.FileSystem.CreateDirectory("c:\tmp")
                My.Computer.FileSystem.CreateDirectory("c:\tmp\suspendidas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        verifica_registro_comisiones()

        'carga Cadenas de conexion del ini
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("c:\datos\integral.ini")
        If fileExists Then
            combocadena.Items.Clear()
            Dim l, nombre, cadena As String, i As Integer = 0
            Dim f As Integer = FreeFile() : FileOpen(FreeFile, "c:\datos\integral.ini", OpenMode.Input)
            While Not EOF(f)
                l = LineInput(f)
                nombre = Mid(l, 1, InStr(l, ","))
                cadena = Mid(l, InStr(l, ",") + 1)
                cadenas(i) = cadena : i += 1
                combocadena.Items.Add(nombre)
            End While
            FileClose(f)
        End If

    End Sub

    
    Private Sub Boton_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_test.Click
        Dim f As New System.IO.StreamWriter("C:\datos\tmp.txt", True)
        f.WriteLine(cia.nombre)
        f.WriteLine(cia.direccion)
        f.WriteLine(cia.ciudad)
        f.WriteLine(cia.Edo)
        f.WriteLine(cia.CP)
        f.WriteLine(cia.rfc)
        f.WriteLine("Impresora Rollo :" + Me.txtrollo.Text)
        f.WriteLine("Impresora Factura :" + Me.txtfactura.Text)
        f.WriteLine("Impresora Reportes :" + Me.txtreporte.Text)
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, "c:\datos\TMP.txt")
        

    End Sub


    Private Sub PrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim mfont As New Font("Arial", 10, FontStyle.Regular) 'define el tipo de letra
        Dim bfont As New Font("Arial", 10, FontStyle.Bold) 'define tipo mas grande
        Dim nfont As New Font("Arial", 14, FontStyle.Bold) 'define el tipo de letra
        Dim chiquifont As New Font("Arial", 8, FontStyle.Regular) 'define el tipo de letra
        e.Graphics.DrawString("", nfont, Brushes.Black, 1, 1)
        e.Graphics.DrawString("", nfont, Brushes.Black, 1, 2)
        e.Graphics.DrawString("", nfont, Brushes.Black, 1, 3)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.GeneralesBindingSource.EndEdit()
        Me.GeneralesTableAdapter.Update(Me.AdmintegralDataSet.Generales)
        'Carga los datos a las variables globales
        Dim g As New admintegralDataSetTableAdapters.GeneralesTableAdapter
        Dim drc As DataRow
        drc = g.GetData.Rows(0)
        cia.nombre = drc.Item("Nombre")
        cia.direccion = drc.Item("Direccion")
        cia.ciudad = drc.Item("ciudad")
        cia.Edo = drc.Item("Edo")
        cia.CP = drc.Item("CP")
        cia.rfc = drc.Item("RFC")
        cia.comidebito = 1 + (drc.Item("comision_debito") / 100)
        cia.comicredito = 1 + (drc.Item("comision_credito") / 100)
        g.Dispose()
        Try
            My.Computer.FileSystem.CreateDirectory("C:\datos")
        Catch ex As Exception

        End Try
    End Sub 'Guardar solo generales

    Private Sub Boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_salir.Click
        Me.Close()
    End Sub 'Boton Salir

    Private Sub boto_facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boto_facturas.Click
        Dim f As New System.IO.StreamWriter("C:\datos\tmp.txt", True)
        f.WriteLine(cia.nombre)
        f.WriteLine(cia.direccion)
        f.WriteLine(cia.ciudad)
        f.WriteLine(cia.Edo)
        f.WriteLine(cia.CP)
        f.WriteLine(cia.rfc)
        f.WriteLine("Impresora Rollo :" + Me.txtrollo.Text)
        f.WriteLine("Impresora Factura :" + Me.txtfactura.Text)
        f.WriteLine("Impresora Reportes :" + Me.txtreporte.Text)
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.impresora_factura, "c:\datos\TMP.txt")
    End Sub ' Prueba Impresora facturas

    Private Sub boton_reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_reportes.Click
        Dim f As New System.IO.StreamWriter("C:\datos\tmp.txt", True)
        f.WriteLine(cia.nombre)
        f.WriteLine(cia.direccion)
        f.WriteLine(cia.ciudad)
        f.WriteLine(cia.Edo)
        f.WriteLine(cia.CP)
        f.WriteLine(cia.rfc)
        f.WriteLine("Impresora Rollo :" + Me.txtrollo.Text)
        f.WriteLine("Impresora Factura :" + Me.txtfactura.Text)
        f.WriteLine("Impresora Reportes :" + Me.txtreporte.Text)
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.Impresora_reportes, "c:\datos\TMP.txt")
    End Sub ' Prueba impresora de reportes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With My.Settings
            .ncaja = Me.ncajatxt.Text
            .solocaja = Me.solocajachk.Checked
            .almacen = Me.almacentxt.Text
            '.LineasXfactura = Me.lineasxfacturatxt.Text
            .iva = Me.IVAtxt.Text
            .margen = Me.margentxt.Text
            .impresora_ticket = Me.txtrollo.Text
            .impresora_factura = Me.txtfactura.Text
            .Impresora_reportes = Me.txtreporte.Text
            .iva2 = Me.iva2.Text
        End With
        My.Settings.Save()
        Dim f As New System.IO.StreamWriter("C:\tmp\caja.ini", False)
        With My.Settings
            f.WriteLine(.ncaja)
            f.WriteLine(.solocaja)
            f.WriteLine(.almacen)
            f.WriteLine(.iva)
            f.WriteLine(.margen)
            f.WriteLine(.puedeAutorizar)
            f.WriteLine(.impresora_ticket)
            f.WriteLine(.impresora_factura)
            f.WriteLine(.Impresora_reportes)
            f.WriteLine(.sqlserver)
            f.WriteLine(.Cobrar_tarjeta)
            f.WriteLine(.terminal)
        End With
        f.Close()
        MsgBox("Se guardo caja.ini")

    End Sub


    Private Sub verifica_registro_comisiones()
        Dim adap As New admintegralDataSetTableAdapters.productosTableAdapter
        Dim adap1 As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Dim midt As DataRow
        midt = adap.GetData.FindByid_Producto(0)
        Try
            Me.lblregistro.Text = "Registro para cargo de comisiones O.K."
        Catch ex As Exception
            adap.Insert(9999, 0, 0, 0, "pi", 0, 1, "Comisiones", 0, 0, 10, 0, 0, Now.Date, 0, 0, 1, 1, 1, False, False, False, 0, 0, False, 0, 0, "01010101", "H87")
            adap1.Insert(0, 1, "0000000000", "%", False, 1, 1, 0, 0, " ")
            Me.lblregistro.Text = "Registro para cargo de comisiones Generado!"
        End Try
    End Sub

    Private Sub okrollo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okrollo.Click
        Me.txtrollo.Text = ComboBox1.SelectedItem
        My.Settings.impresora_ticket = Me.txtrollo.Text
        My.Settings.Save()
    End Sub ' Selecciona impresora Rollo

    Private Sub okfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okfactura.Click
        Me.txtfactura.Text = ComboBox1.SelectedItem
        My.Settings.impresora_factura = Me.txtfactura.Text
        My.Settings.Save()
    End Sub ' Selecciona impresora factura

    Private Sub okreportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okreportes.Click
        txtreporte.Text = ComboBox1.SelectedItem
        My.Settings.Impresora_reportes = Me.txtreporte.Text
        My.Settings.Save()
    End Sub ' Selecciona impresora reportes


    
    Private Sub boton_cadena_conex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cadena_conex.Click
        Me.TextBox5.Text = cadenas(combocadena.SelectedIndex)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.OpenFileDialog1.ShowDialog()
        logotipotxt.Text = "file://" + Me.OpenFileDialog1.FileName
        Me.imagenlogo.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
        Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
        Try
            adap.Insert(8, "logotipo", logotipotxt.Text)
        Catch ex As Exception
            adap.actualizar(logotipotxt.Text, 8)
        End Try

    End Sub
End Class