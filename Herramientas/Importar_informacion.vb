Imports System.IO
Public Class Importar_informacion
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim ds2 As New DataSet
    Dim bs As New BindingSource
    Dim fileprecios As String

    Private Sub boton_usb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_usb.Click
        Dim f As String, er As Integer = 1
        Me.OpenFileDialog1.CheckFileExists = True
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then Beep() : Exit Sub
        f = Me.OpenFileDialog1.FileName
        If InStr(f, "Tabla") > 0 Then er = 0
        If InStr(f, "Precio") > 0 Then er = 0
        'If er = 1 Then MsgBox("No son archivos de actualizacion") : Exit Sub

        ListBox1.Items.Clear()
        Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo(f)
        ListBox1.Items.Add("Actualizando Datos")
        ListBox1.Items.Add("Fecha del Archivo :" + fileData.LastAccessTime.Date.ToShortDateString)
        ListBox1.Items.Add("============================")
        Dim t As DataTable
        ds.ReadXmlSchema(f)
        ds.ReadXml(f)
        status.Maximum = ds.Tables.Count + 1 : status.Value = 1
        For Each t In ds.Tables
            borrar_tabla(t.TableName)
            tablatxt.Text = t.TableName
            Actualizar(t.TableName)
            Me.Refresh()
        Next
        MsgBox("Transferencia Terminada!!")
        Me.Close()
    End Sub

    Private Sub borrar_tabla(ByVal tabla As String)
        Using conection As New SqlClient.SqlConnection(My.Settings.AdmintegralConnectionString)
            conection.Open()
            Dim cmd As String
            Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
            Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
            cmd = "DELETE FROM " + tabla
            Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
            AdaptadorDeDatos.DeleteCommand = Command
            AdaptadorDeDatos.DeleteCommand.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Actualizar(ByVal tabla As String)
        Me.ListBox1.Items.Add(tabla + " " + ds.Tables(tabla).Rows.Count.ToString)
        Dim dslocal As DataSet
        dslocal = New admintegralDataSet
        status1.Maximum = ds.Tables(tabla).Rows.Count
        For j As Integer = 0 To ds.Tables(tabla).Rows.Count - 1
            status1.Value = j
            Try
                dslocal.Tables(Trim(tabla)).ImportRow(ds.Tables(tabla).Rows(j))
            Catch ex As Exception
            End Try
        Next j
        status1.Value = status1.Maximum
        tablatxt.Text = "Aplicando " + tabla
        Me.Refresh()
        dgv.DataSource = dslocal.Tables(tabla)
        tabla = Trim(tabla)

        'modificado recientemente
        If tabla = "fei_clientes" Then
            Dim adap As New admintegralDataSetTableAdapters.fei_clientesTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "paquetes" Then
            Dim adap As New admintegralDataSetTableAdapters.paquetesTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "paquetes_detalle" Then
            Dim adap As New admintegralDataSetTableAdapters.paquetes_detalleTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "productos_stoks" Then
            Dim adap As New admintegralDataSetTableAdapters.productos_stoksTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "Agentes" Then
            Dim adap As New admintegralDataSetTableAdapters.AgentesTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        '=======================================================
        If tabla = "autorizaciones" Then
            Dim adap As New admintegralDataSetTableAdapters.autorizacionesTableAdapter
        End If

        If LCase(tabla) = "cajas" Then
            Dim adap As New admintegralDataSetTableAdapters.cajasTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "Comentarios" Then
            Dim adap As New admintegralDataSetTableAdapters.ComentariosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "Departamentos" Then
            Dim adap As New admintegralDataSetTableAdapters.DepartamentosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "Directorio" Then
            Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "Documentos" Then
            Dim adap As New admintegralDataSetTableAdapters.DocumentosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "Generales" Then
            Dim adap As New admintegralDataSetTableAdapters.GeneralesTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If



        If tabla = "log_cajas" Then
            Dim adap As New admintegralDataSetTableAdapters.log_cajasTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "Grupos" Then
            Dim adap As New admintegralDataSetTableAdapters.GruposTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "Listas" Then
            Dim adap As New admintegralDataSetTableAdapters.ListasTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "movimientos" Then
            Dim adap As New admintegralDataSetTableAdapters.movimientosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "pagos" Then
            Dim adap As New admintegralDataSetTableAdapters.PagosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "pagos_detalle" Then
            Dim adap As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "paths" Then
            Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "productos" Then
            Dim adap As New admintegralDataSetTableAdapters.productosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "series" Then
            Dim adap As New admintegralDataSetTableAdapters.SeriesTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "tbl_formasdepago" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_formasdepagoTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "tbl_funciones_sistema" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_funciones_sistemaTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "tbl_menu_opciones" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_menu_opcionesTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "tbl_menus" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_menusTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "tbl_Tipodoc" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_TipodocTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "tbl_monedas" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_monedasTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "tbl_permisos" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_permisosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "tbl_status" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_statusTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "usuarios" Then
            Dim adap As New admintegralDataSetTableAdapters.usuariosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
        If tabla = "tbl_almacenes" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "tbl_formasdepago" Then
            Dim adap As New admintegralDataSetTableAdapters.tbl_formasdepagoTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If

        If tabla = "Unidades_productos" Then
            Dim adap As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
            adap.Update(dslocal.Tables(tabla))
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'Dim f As String
        'Me.OpenFileDialog1.CheckFileExists = True
        'If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then Beep() : Exit Sub
        'f = Me.OpenFileDialog1.FileName
        'ListBox1.Items.Clear()
        'Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo(f)
        'ListBox1.Items.Add("Tablas en el Archivo:")
        'ListBox1.Items.Add("Fecha :" + fileData.LastAccessTime.Date.ToShortDateString)
        'ListBox1.Items.Add("============================")
        'Dim t As DataTable
        'ds.ReadXmlSchema(f)
        'ds.ReadXml(f)
        'For Each t In ds.Tables
        '    Me.ListBox1.Items.Add(t.TableName)
        'Next
        Dim f As String
        Me.OpenFileDialog1.CheckFileExists = True
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then Beep() : Exit Sub
        f = Me.OpenFileDialog1.FileName
        ListBox1.Items.Clear()
        Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo(f)
        ListBox1.Items.Add("Actualizando Datos")
        ListBox1.Items.Add("Fecha del Archivo :" + fileData.LastAccessTime.Date.ToShortDateString)
        ListBox1.Items.Add("============================")
        Dim t As New DataTable
        ds1.ReadXmlSchema(f)
        ds1.ReadXml(f)
        bs.DataSource = ds1.Tables("pagos_detalle")
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ListBox1.Visible = CheckBox1.Checked
    End Sub

    Private Sub boton_internet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    My.Computer.FileSystem.DeleteFile("C:\tmp\tablas.xml", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        'Catch ex As Exception

        'End Try
        'Try
        '    My.Computer.FileSystem.DeleteFile("C:\tmp\" + fileprecios, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        'Catch ex As Exception

        'End Try
        'Me.boton_usb.Visible = False
        'Me.Boton_actualiza_net.Visible = True
        'bajar() 'baja archivos de tablas y precios
        Process.Start("c:\tmp\bajar_Actualizacion.exe")
    End Sub

    Private Sub bajar()
        Try
            My.Computer.FileSystem.DeleteFile("C:\tmp\tablas.xml", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("C:\tmp\" + fileprecios, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch ex As Exception
        End Try

        Dim filedestino As String = "c:\tmp\tablas.xml"
        Dim fileorigen As String = "http://" + "www.casabaroudi.com/net/tiendas/tablas.xml"
        Me.Refresh()
        Try
            My.Computer.Network.DownloadFile(fileorigen, filedestino, "", "", True, 100, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        filedestino = "c:\tmp\" + fileprecios
        fileorigen = "http://" + "www.casabaroudi.com/net/tiendas/" + fileprecios
        Try
            My.Computer.Network.DownloadFile(fileorigen, filedestino, "", "", True, 100, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Importar_informacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim adap As New admintegralDataSetTableAdapters.cajasTableAdapter
        Dim ncj As Integer
        ncj = My.Settings.ncaja
        Dim dr As DataRow
        dr = adap.GetDataBy(ncj).Rows(0)
        fileprecios = "Precios_" + Trim(dr(1)) + ".xml"
        Dim sucursal As String = Trim(dr(1))
        My.Computer.FileSystem.WriteAllText("C:\tmp\sucursal.ini", sucursal, False)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Satus.Refresh()
    End Sub
    Public Sub bajar_internet()
        Dim adap As New admintegralDataSetTableAdapters.cajasTableAdapter
        Dim ncj As Integer
        ncj = My.Settings.ncaja
        Dim dr As DataRow
        dr = adap.GetDataBy(ncj).Rows(0)
        fileprecios = "Precios_" + Trim(dr(1)) + ".xml"
        Try
            My.Computer.FileSystem.DeleteFile("C:\tmp\tablas.xml", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.DeleteFile("C:\tmp\" + fileprecios, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch ex As Exception

        End Try

        Dim filedestino As String = "c:\tmp\tablas.xml"
        Dim fileorigen As String = "http://" + "www.casabaroudi.com/net/tiendas/tablas.xml"
        Me.Refresh()
        Try
            My.Computer.Network.DownloadFile(fileorigen, filedestino, "", "", True, 100, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        filedestino = "c:\tmp\" + fileprecios
        fileorigen = "http://" + "www.casabaroudi.com/net/tiendas/" + fileprecios
        Try
            My.Computer.Network.DownloadFile(fileorigen, filedestino, "", "", True, 100, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Boton_actualiza_net_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_actualiza_net.Click
        Dim f As String = "c:\tmp\tablas.xml"
        Dim f1 As String = "c:\tmp\" + fileprecios
        ListBox1.Items.Clear()
        Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo(f)
        ListBox1.Items.Add("Actualizando Datos")
        ListBox1.Items.Add("Fecha del Archivo :" + fileData.LastAccessTime.Date.ToShortDateString)
        ListBox1.Items.Add("============================")
        ListBox1.Items.Add("Archivos Descargado")
        '  MsgBox("Archivos Descargados", MsgBoxStyle.Information)
        ListBox1.Refresh()
        Dim t As DataTable
        ds.ReadXmlSchema(f)
        ds.ReadXml(f)
        ds.ReadXmlSchema(f1)
        ds.ReadXml(f1)
        status.Maximum = ds.Tables.Count + 1 : status.Value = 1
        For Each t In ds.Tables
            status.Value += 1 : tablatxt.Text = t.TableName
            borrar_tabla(t.TableName)
            'MsgBox(t.TableName)
            Actualizar(t.TableName)
            Me.Refresh()
        Next
        MsgBox("Transferencia Terminada!!")
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class