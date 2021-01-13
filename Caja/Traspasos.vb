Imports Microsoft.Reporting.WinForms

Class traspasos
    Public tipo_venta As Integer ' nota,factura,dev, nota credito
    Dim credito As Boolean = False
    Dim como_pago As Integer
    Dim bs As New BindingSource
    Dim bsexistencia As New BindingSource
    Dim tarjetacredito As Boolean = True
    Dim nueva As Boolean = True
    Dim info_caja As Integer = My.Settings.ncaja
    Dim info_serie As String
    Dim info_lista As Integer
    Dim info_factor As Decimal = 1
    Dim info_almacen As Integer = 0
    Dim factor_iva1_venta As String
    Dim factor_iva2_venta As String
    Dim tmpfile As String = "c:\tmp\ultimo_traspas.tmp"


    Dim tabla_pago As New DataTable
    Dim jalada_td As Integer = 0
    Dim jalada_folio As Long = 0
    Dim jalada_serie As String = 0
    Dim id_autorizacion As Integer
    Dim autorizacion_pesos As Decimal
    Dim ancho_ticket As Integer = 36
    Dim monitor_guardar As Boolean
    Dim monitor_facturas As Boolean
    Dim monitor_boletas As Boolean  'pagos head
    Dim monitor_pago As Boolean
    Dim dsdoc As New DataSet("Facturas")
    Dim mytable As DataTable = dsdoc.Tables.Add("mytable")

    Private Sub caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        factor_iva1_venta = "0.11"
        factor_iva2_venta = "0.16"
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_almacenes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        Dim tblexistencia As New DataTable
        Me.CajasTableAdapter.FillBy(Me.AdmintegralDataSet.cajas, info_caja)
        Me.Refresh()
        info_almacen = Me.AdmintegralDataSet.cajas.Rows(0).Item("almacen")
        idsalida.Text = info_almacen
        idsalida.Enabled = False
        Dim adap As New admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
        Try
            almacensalida.Text = adap.leer(info_almacen).ToString
        Catch ex As Exception
            MsgBox("Teclee numero de almacen")
            Exit Sub
        End Try

        Me.Refresh()
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True
        crear_grid()
        Me.TabControl1.SelectTab(1)
        totalizar()
        Me.TopMost = False
        Me.Refresh()
        Me.Lista_de_ventasTableAdapter.Fill(Me.AdmintegralDataSet.Lista_de_ventas)
        Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
        Dim tabla As New DataTable() 'tabla del detalle de pedido

        inicializa_nota()
        Me.Text = "Traspasos"
        Me.tipo_venta = 3 'Traspasos 
        Me.idsalida.Focus()
    End Sub 'Leer form

    Private Sub crear_grid()
        ' Declare variables for DataColumn and DataRow objects.
        Dim column As New DataColumn

        column = New DataColumn("codigo", System.Type.GetType("System.String"))
        column.AllowDBNull = False : mytable.Columns.Add(column)

        column = New DataColumn("Id", System.Type.GetType("System.Int32"))
        column.Unique = False
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        ' and add to DataTable.    
        column = New DataColumn("iva", System.Type.GetType("System.Int32"))
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        ' and add to DataTable.    
        column = New DataColumn("piva", System.Type.GetType("System.Int32"), "iif (iva>0, 11,0)")
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Descripcion", System.Type.GetType("System.String"))
        column.Caption = "Producto" : mytable.Columns.Add(column)

        column = New DataColumn("Und", System.Type.GetType("System.String"))
        column.Caption = "und" : mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn("factor", System.Type.GetType("System.Decimal"))
        mytable.Columns.Add(column) ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Cantidad", System.Type.GetType("System.Decimal"))
        column.Caption = "Cant" : mytable.Columns.Add(column)

        column = New DataColumn("ud_Costo", System.Type.GetType("System.Decimal"))
        column.Caption = "Costo" : mytable.Columns.Add(column)

        column = New DataColumn("ud_plventa", System.Type.GetType("System.Decimal"))
        column.Caption = "PL" : mytable.Columns.Add(column)

        column = New DataColumn("ud_flista", System.Type.GetType("System.Decimal"))
        column.DefaultValue = 1 : mytable.Columns.Add(column)

        column = New DataColumn("ud_pventa", System.Type.GetType("System.Decimal"), "ud_flista * ud_plventa")
        column.Caption = "Unit." : mytable.Columns.Add(column)

        column = New DataColumn("pdesc", System.Type.GetType("System.Decimal")) 'porcentaje de descuento (solo para formula)
        column.DefaultValue = 0 : mytable.Columns.Add(column)

        column = New DataColumn("UD_VDesc", System.Type.GetType("System.Decimal"))
        column.Caption = "Desc." : column.DefaultValue = 0
        column.Expression = "ud_pventa * pdesc"
        column.ReadOnly = True
        mytable.Columns.Add(column)

        column = New DataColumn("UD_vneto", System.Type.GetType("System.Decimal"), "ud_pventa - UD_VDesc") 'Venta Neto nETO
        mytable.Columns.Add(column)

        column = New DataColumn("Importe", System.Type.GetType("System.Decimal"), "cantidad * ud_vneto") 'IMPORTE
        column.Caption = "Importe" : column.ReadOnly = True
        mytable.Columns.Add(column)


        column = New DataColumn("UD_iva10", System.Type.GetType("System.Decimal"), "iif(piva<15 and piva>0,ud_vneto*" + factor_iva1_venta.ToString + " ,0)")
        column.Caption = "IVAS" : mytable.Columns.Add(column)

        column = New DataColumn("UD_iva15", System.Type.GetType("System.Decimal"), "iif(piva>14,ud_vneto*" + factor_iva2_venta.ToString + ",0)")
        column.Caption = "*" + column.ColumnName : mytable.Columns.Add(column)

        'Columnas de Unidad Base
        '================================================================================
        column = New DataColumn("UB_Cantidad", System.Type.GetType("System.Decimal"), "factor * Cantidad")
        mytable.Columns.Add(column)
        column = New DataColumn("UB_Costo", System.Type.GetType("System.Decimal"), "ud_costo / factor")
        mytable.Columns.Add(column)
        column = New DataColumn("UB_pventa", System.Type.GetType("System.Decimal"), "ud_vneto / factor")
        mytable.Columns.Add(column)
        column = New DataColumn("Ub_pDesc", System.Type.GetType("System.Decimal"), "ud_vdesc /  factor")
        mytable.Columns.Add(column)
        column = New DataColumn("Ub_iva10", System.Type.GetType("System.Decimal"), "ud_iva10 / factor")
        mytable.Columns.Add(column)
        column = New DataColumn("Ub_iva15", System.Type.GetType("System.Decimal"), "ud_iva15 / factor")
        mytable.Columns.Add(column)
        column = New DataColumn("subdesc", System.Type.GetType("System.Decimal"), "ud_vdesc * cantidad")
        mytable.Columns.Add(column)
        column = New DataColumn("subiva10", System.Type.GetType("System.Decimal"), "ud_iva10 * cantidad")
        mytable.Columns.Add(column)
        column = New DataColumn("subiva15", System.Type.GetType("System.Decimal"), "ud_iva15 * cantidad")
        mytable.Columns.Add(column)
        '*****************************************************************
        'SUB TOTALES
        '******************************************************************
        column = New DataColumn("al0", System.Type.GetType("System.Decimal"), "iif (iva=0, ud_pventa * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("al10", System.Type.GetType("System.Decimal"), "iif (iva<14 and iva>0, ud_pventa * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("al15", System.Type.GetType("System.Decimal"), "iif (iva>14, ud_pventa * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        '**********************************************************************
        ' sub-totales DESCUENTo
        '**********************************************************************

        column = New DataColumn("dal0", System.Type.GetType("System.Decimal"), "iif (iva=0, ud_vdesc * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("dal10", System.Type.GetType("System.Decimal"), "iif (iva<14 and iva>0, ud_vdesc * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("dal15", System.Type.GetType("System.Decimal"), "iif (iva>14, ud_vdesc * cantidad,0)")
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("peso", System.Type.GetType("System.Decimal"))
        column.DefaultValue = 0 : mytable.Columns.Add(column)
        column = New DataColumn("total", System.Type.GetType("System.Decimal"))
        column.Expression = "al0 + al10 - subdesc +subiva10"
        mytable.Columns.Add(column)

        column = New DataColumn("ud_Id", System.Type.GetType("System.Int32"))
        column.Caption = "ud_id" : column.Unique = False
        mytable.Columns.Add(column) ' Add the Column to the DataColumnCollection.

        ' Create new DataColumn, set DataType, ColumnName 
        column = New DataColumn("N", System.Type.GetType("System.Int32"))
        column.DefaultValue = 1 : column.Unique = False : mytable.Columns.Add(column)

        column = New DataColumn("F", System.Type.GetType("System.Int32"), " ((N / 25)-.51 )+1 ")
        column.AllowDBNull = False : column.Unique = False : mytable.Columns.Add(column)

        column = New DataColumn("NF", System.Type.GetType("System.Int32"))
        column.AllowDBNull = False : mytable.Columns.Add(column)

        '*************************** aumenta existencia y stock
        column = New DataColumn("exis", System.Type.GetType("System.Int32"))
        column.Caption = "Exis" : column.Unique = False
        mytable.Columns.Add(column) ' Add the Column to the DataColumnCollection.

        column = New DataColumn("stock", System.Type.GetType("System.Int32"))
        column.Caption = "stock" : column.Unique = False
        mytable.Columns.Add(column) ' Add the Column to the DataColumnCollection.



        'asigna la abla al datagrid
        bs.DataSource = mytable
        dgv.DataSource = bs

        '**********************************************************************
        ' Oculta columnas de calculo
        'dgv.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv.Columns("id").ReadOnly = True
        dgv.Columns("Descripcion").ReadOnly = True
        dgv.Columns("und").ReadOnly = True
        dgv.Columns("Factor").ReadOnly = True
        dgv.Columns("Codigo").ReadOnly = True
        dgv.Columns("ud_pventa").ReadOnly = True
        dgv.Columns("peso").ReadOnly = True
        dgv.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv.Columns("descripcion").DefaultCellStyle.BackColor = Color.LightBlue

        dgv.Columns("Importe").Visible = False
        dgv.Columns("ud_costo").Visible = False
        dgv.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        With dgv
            .Columns("id").Visible = False
            .Columns("ud_costo").Visible = False
            .Columns("pdesc").Visible = False
            .Columns("ud_id").Visible = False
            .Columns("N").Visible = False
            .Columns("F").Visible = False
            .Columns("NF").Visible = False
            .Columns("factor").Visible = False
            .Columns("ud_plventa").Visible = False
            .Columns("ud_flista").Visible = False
            .Columns("ud_pventa").HeaderText = "Unit."
            For j As Integer = 8 To .Columns.Count - 1
                .Columns(j).DefaultCellStyle.Format = "N2"
                .Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next
            .Columns("iva").Visible = False
            .Columns("piva").Visible = False
            .Columns("pdesc").Visible = False
            .Columns("ub_pventa").Visible = False
            .Columns("ud_vdesc").Visible = False
            .Columns("ud_vneto").Visible = False
            .Columns("ud_iva10").Visible = False
            .Columns("ud_iva10").HeaderText = "I.V.A."
            .Columns("ud_iva15").Visible = False

            .Columns("importe").Visible = False
            .Columns("ub_cantidad").Visible = False
            .Columns("ub_Costo").Visible = False
            .Columns("ub_pdesc").Visible = False
            .Columns("ub_iva10").Visible = False
            .Columns("ub_iva15").Visible = False

            .Columns("subdesc").Visible = False
            .Columns("subiva10").Visible = False
            .Columns("subiva15").Visible = False
            .Columns("al0").Visible = False
            .Columns("al10").Visible = False
            .Columns("al15").Visible = False
            .Columns("dal0").Visible = False
            .Columns("dal10").Visible = False
            .Columns("dal15").Visible = False
            .Columns("peso").Visible = False
        End With

    End Sub

    Private Sub linea_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles linea.GotFocus
        linea.SelectAll()
    End Sub '****************************************************************crear el grid

    Private Sub linea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles linea.KeyPress
        Dim cant, x, y As Integer, id As String, filtro As String
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            x = InStr(linea.Text, ".")
            y = InStr(linea.Text, "*") 'caja
            If x > 1 Then
                cant = linea.Text.Substring(0, x - 1)
                id = Mid(linea.Text, x + 1)
                canttxt.Text = cant
                idtxt.Text = id
            Else
                If y > 1 Then
                    cant = linea.Text.Substring(0, y - 1)
                    id = Mid(linea.Text, y + 1)
                    canttxt.Text = cant
                    idtxt.Text = id
                Else
                    cant = 1
                    idtxt.Text = linea.Text
                End If
            End If
            Me.Lista_de_ventasBindingSource.Filter = ""
            Dim ix As Integer = Me.Lista_de_ventasBindingSource.Find("codigo", Me.idtxt.Text)
            If ix < 0 Then
                MsgBox("No Existe")
                linea.Text = ""
                Exit Sub
            Else
                Me.Lista_de_ventasBindingSource.Position = ix
                If y > 0 Then ' filtra para ubicar uniad de compra
                    Dim undcompra As Und = sk_leer_UndCompra(Id_productoTextBox.Text) 'determina unidad de compra
                    filtro = "id_producto = " + Me.Id_productoTextBox.Text + " and id_unidad = " + undcompra.a9_uc_id.ToString
                    Me.Lista_de_ventasBindingSource.Filter = filtro
                    If Me.Lista_de_ventasBindingSource.Position < 0 Then
                        MsgBox("No existe x Caja")
                        Me.Lista_de_ventasBindingSource.Filter = ""
                        Exit Sub
                    End If
                End If
                Dim cmd As String, miexistencia As Integer, mistock As Integer, mipedido As Integer
                Try
                    cmd = "SELECT SUM(ub_cantidad * n) AS Existencia FROM dbo.movimientos WHERE (n <> 0) AND (almacen = [alma]) AND (id_prodcuto = [prod])"
                    cmd = cmd.Replace("[alma]", identrada.Text)
                    cmd = cmd.Replace("[prod]", Me.Id_productoTextBox.Text)
                    miexistencia = leer_tabla(cmd).Rows(0).Item(0)
                    If miexistencia < 0 Then miexistencia = 0
                Catch ex As Exception
                    miexistencia = 0
                End Try

                Try
                    cmd = "select stock from productos_stoks where id_producto= " + Me.Id_productoTextBox.Text + " and id_almacen= " + identrada.Text
                    mistock = leer_tabla(cmd).Rows(0).Item(0)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    mistock = 0
                End Try

                'ajusta la cantidad al stock no deja que se pase
                mipedido = mistock - miexistencia
                If mipedido < 0 Then mipedido = 0
                If mistock > 0 And (cant * Me.FactorTextBox.Text) > mipedido Then
                    MsgBox("Se excede el Stock")
                    cant = mipedido
                End If
                If cant = 0 Then Exit Sub

                '' si el stock es cero lo pide
                If mistock = 0 And My.Settings.terminal = False Then
                    Dim nstock As Integer
                    nstock = InputBox("Este producto no tiene stock, teclee la cantidad de stock que quiera definir para este producto en esta tienda", "Definir Stock", cant)
                    If nstock <> 0 Then
                        cmd = "UPDATE [integral].[dbo].[productos_stoks] SET [stock] = " + nstock.ToString + " WHERE id_producto= " + Me.Id_productoTextBox.Text + " and id_almacen= " + identrada.Text
                        If comando(cmd) = True Then mistock = nstock Else MsgBox("NO se actualizo el Stock!!!")
                    End If
                End If


                ' verifica si ya existe en la factura
                Dim alta As Boolean = False
                Dim ix1 As Integer
                For ix1 = 0 To mytable.Rows.Count - 1
                    With mytable.Rows(ix1)
                        If .Item("id") = Me.Id_productoTextBox.Text And .Item("ud_id") = Me.Id_unidadTextBox.Text Then
                            cant += .Item("cantidad")
                            .Item("cantidad") = cant
                            totalizar()
                            linea.Text = ""
                            alta = True
                        End If
                    End With
                Next
                If alta = False Then
                    Dim dr As DataRow = mytable.NewRow
                    dr("id") = Me.Id_productoTextBox.Text
                    dr("iva") = Me.IvaTextBox.Text
                    dr("piva") = Me.IvaTextBox.Text
                    dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                    dr("und") = Me.UnidadTextBox.Text
                    dr("factor") = Me.FactorTextBox.Text
                    dr("cantidad") = cant
                    dr("ud_costo") = Me.CostoTextBox.Text
                    dr("ud_plventa") = Me.VentaTextBox.Text
                    dr("ud_flista") = info_factor 'factor precio lista
                    dr("ud_pventa") = Int(dr("ud_plventa") * info_factor * 100) / 100
                    dr("pdesc") = 0
                    dr("nf") = 1
                    dr("peso") = Me.PesoTextBox.Text
                    dr("ud_id") = Me.Id_unidadTextBox.Text
                    dr("codigo") = idtxt.Text
                    dr("stock") = mistock
                    dr("exis") = miexistencia
                    mytable.Rows.Add(dr)
                End If
                totalizar()
                Me.lineastxt.Text = dgv.Rows.Count - 1
                If dgv.RowCount > dgv.DisplayedRowCount(False) Then
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - dgv.DisplayedRowCount(False) - 1
                End If
                Me.linea.Text = "" : Me.linea.Focus()
                Try
                    mytable.WriteXml(tmpfile)
                Catch ex As Exception

                End Try
                End If
                bs.Filter = ""
                Me.Lista_de_ventasBindingSource.Filter = ""
        End If
    End Sub '******************************************* LINEA DE CAPTURA

    Private Sub totalizar()
        Me.lineastxt.Text = dgv.Rows.Count - 1
    End Sub 'Totalizar

    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        mytable.AcceptChanges()
        totalizar()
    End Sub ' Todo:recalcula total cuando se cambia el grid

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim x As MsgBoxResult
        x = MsgBox("Seguro que quiere Borra el traspaso", MsgBoxStyle.YesNo, "Iniciar de Nuevo")
        If x = MsgBoxResult.Yes Then
            mytable.Clear()
            totalizar()
            TabControl1.SelectedIndex = 1
            Me.linea.Focus()
            Try
                My.Computer.FileSystem.DeleteFile("C:\tmp\traspaso.tmp", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Catch ex As Exception
            End Try
        End If
    End Sub ' ***************************************Boton Borrar NOTA

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedIndex <> 3 Then
            TabControl1.SelectedIndex = 1 'Boton_imprimir.Enabled = False
            totalizar()
        End If
    End Sub ' impide que cambien el TAB con un CLick

    Private Sub SuspenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspenderToolStripMenuItem.Click
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists(tmpfile)
        If fileExists = False Then MsgBox("No hay nada que suspender") : Exit Sub
        Dim archivo As New SaveFileDialog
        archivo.Title = "Tecle una Referencia"
        archivo.Filter = "TMP (*.TMP)|*.TMP"
        archivo.InitialDirectory = "c:\tmp\susependidadas\"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.MoveFile(tmpfile, archivo.FileName, True)
            MsgBox("Archivo guardado : " + archivo.FileName)
        Else
            MsgBox("No se guardo nada")
        End If

    End Sub  'SUSPENDER ********************* Guarda

    Private Sub CARGAR_aRCHIVO(ByVal archivo As String)
        Try
            mytable.ReadXml(archivo)
            totalizar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub '****************************************************carga un archivo TMP

    Private Sub CargarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarToolStripMenuItem.Click
        Dim archivo As New OpenFileDialog

        archivo.InitialDirectory = "c:\tmp\suspendidas\"
        archivo.Title = "Seleccione Un archvio"
        archivo.Filter = "TMP (*.TMP)|*.TMP"
        If archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            CARGAR_aRCHIVO(archivo.FileName)
            If dgv.RowCount > dgv.DisplayedRowCount(False) Then
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - dgv.DisplayedRowCount(False) - 1
            End If
            Windows.Forms.Cursor.Current = Cursors.Default
        End If
    End Sub ' ******* Cargar 


    Sub guardar_traspaso()
        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim result As Boolean, d As New Mi_Documento, r As DataRow, j As Integer, f As Long
        Main.StatusStrip1.Items(2).Text = "Guardando Documentos"
        d.a00_id_doc = 3 'Traspaso salida
        Try
            f = afolio.siguiente(3, info_almacen) ' la serie es 
        Catch ex As Exception
            f = 1
        End Try
        d.a01_Folio = f
        d.a02_serie = info_almacen
        d.a03_Almacen = idsalida.Text
        d.a04_id_directorio = 0
        d.a05_tipo_directorio = 2
        d.a06_fecha_registro = CDate(Date.Now.ToString)
        d.a07_Folio_pedido = 0 'todo: Pedir numero de pedido
        d.a08_factura = ""
        d.a09_fecha_factura = CDate(Date.Now.Date)
        d.a10_fecha_surtido = CDate(Date.Now.Date)
        d.a11_fecha_vence = CDate(Date.Now.Date)
        d.a25_almaentrada = identrada.Text
        d.a24_status = 0
        d.a26_diasc = 0
        d.a32_pesoengramos = 0 'Peso en gramos
        result = Agregar_documento(d) 'Funcion que guarda el documento en la tabla
        If result = False Then MsgBox("No se guardo el documento, " + d.a01_Folio.ToString) : Exit Sub
        ' =================================     guarda comentarios
        Try
            'actualiza la tabla de comentarios
            Dim adapcomentario As New admintegralDataSetTableAdapters.ComentariosTableAdapter
            Dim comentario As String = comentarios.Text
            adapcomentario.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, " ", user.nick, comentario)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        d.a00_id_doc = 4
        d.a03_Almacen = identrada.Text
        result = Agregar_documento(d) '
        If result = False Then MsgBox("No se guardo el documento, " + d.a01_Folio.ToString) : Exit Sub
        ' =================================     guarda comentarios
        Try
            'actualiza la tabla de comentarios
            Dim adapcomentario As New admintegralDataSetTableAdapters.ComentariosTableAdapter
            Dim comentario As String = comentarios.Text
            adapcomentario.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, " ", user.nick, comentario)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For j = 0 To mytable.Rows.Count - 1
            r = mytable.Rows(j)
            Dim m As New mi_movimientos
            m.a01_Almacen = Me.idsalida.Text 'almacen'ALMACEN SALIDA
            m.a02_id_doc = 3
            m.a03_Folio = d.a01_Folio
            m.a04_serie = d.a02_serie
            m.a05_num = j
            m.a06_fecha = d.a10_fecha_surtido
            m.a07_idproducto = r.Item("id")
            m.a08_factor = r.Item("factor")
            m.a09_piva = r.Item("piva")
            m.a10_ud = r.Item("ud_id")
            m.a11_cantidad = r.Item("cantidad")
            m.a12_costo = r.Item("ud_costo")
            m.a13_Cdesc = 0
            m.a14_cflete = 0
            m.a15_civa10 = 0
            m.a16_civa15 = 0
            m.a17_cventa = r.Item("ud_vneto")
            m.a18_cvdesc = r.Item("ud_vdesc")
            m.a19_cviva10 = r.Item("ud_iva10")
            m.a20_cviva15 = r.Item("ud_iva15")
            m.a21_ub_cant = r.Item("ub_cantidad")
            m.a22_ub_costo = r.Item("ub_costo")
            m.a23_ub_Cdesc = 0
            m.a24_ub_cflete = 0
            m.a25_ub_civa10 = 0
            m.a26_ub_civa15 = 0
            m.a27_ub_cventa = r.Item("ub_pventa")
            m.a28_ub_cvdesc = r.Item("ub_pdesc")
            m.a29_ub_cviva10 = r.Item("ub_iva10")
            m.a30_ub_cviva15 = r.Item("ub_iva15")
            m.a31_signo = -1
            m.a32_caducidad = Now.Date

            'guara traspaso salida
            result = agregar_movimiento(m)
            If result = False Then MsgBox("No se guardo este producto, borre el traspaso e intente de nuevo")

            'guarda traspaso entrada
            m.a01_Almacen = Me.identrada.Text 'almacen
            m.a02_id_doc = 4 'traspaso entrada
            m.a31_signo = 1
            m.a32_caducidad = Now.Date
            result = agregar_movimiento(m)
            If result = False Then MsgBox("No se guardo este producto, borre el traspaso e intente de nuevo")
        Next
        folio.Text = d.a01_Folio

        If jalada_folio > 0 Then
            marcar_documento(3, jalada_folio, jalada_serie) ' cancela el domuento salida
            marcar_documento(4, jalada_folio, jalada_serie) ' cancela el domuento Entrada
            MsgBox("Se Cancelo el Traspaso No." + jalada_folio.ToString)
            jalada_folio = 0 : jalada_td = 0 : jalada_serie = ""
        End If
        Dim bien As MsgBoxResult = MsgBoxResult.No
        While bien = MsgBoxResult.No
            'imprimir_traspaso("SALIDA")
            imprimir_traspaso_costeado("SALIDA")
            bien = MsgBox("Se imprimio Bien", MsgBoxStyle.YesNo, "Impresion de Traspaso")
        End While

        Main.StatusStrip1.Items(2).Text = "Documento Guardado correcto"
        monitor_guardar = True
    End Sub '**************************************************************** Guardar Ventas

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim a As String
        a = dgv.CurrentRow.Cells("codigo").Value.ToString
        Dim x As MsgBoxResult
        x = MsgBox("Borrar este producto :" + a, MsgBoxStyle.YesNo, "Borrar ")
        If x = MsgBoxResult.Yes Then
            If Me.dgv.CurrentRow.Index >= 0 Then
                Try
                    bs.RemoveCurrent()
                    mytable.AcceptChanges()
                    totalizar()
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub ' Borrar producto

    Private Sub inicializa_nota()
        mytable.Clear()

        TabControl1.SelectedIndex = 1
        totalizar()
        linea.Visible = True
        jalada_folio = 0
        jalada_td = 0
        jalada_serie = ""
        Me.linea.Focus()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub BuscarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProductoToolStripMenuItem.Click
        My.Forms.Buscar_productos.ShowDialog()
        Me.linea.Text += producto.a7codigo
        linea.Focus()
    End Sub

    Private Sub Agregar_Un_producto_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar_Un_producto_menu.Click
        totalizar()
        TabControl1.SelectedIndex = 1 'Boton_imprimir.Enabled = False
        linea.Focus()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_puerta.Click, Boton_salir.Click
        If My.Settings.solocaja = False Then
            Me.Close()
            Main.MenuStrip.Enabled = True
            Main.barra_menu1.Enabled = True
        Else
            MsgBox("Esta estacion esta configurada como solo caja")
        End If
    End Sub

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        guardar_traspaso()
        inicializa_nota()

    End Sub

    Private Sub ConsultarExistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarExistenciaToolStripMenuItem.Click
        Dim a, factor As String
        a = "" : factor = ""
        Try
            a = dgv.CurrentRow.Cells("id").Value.ToString
            factor = dgv.CurrentRow.Cells("factor").Value
            lblprod.Text = dgv.CurrentRow.Cells("Descripcion").Value
            lblunidad.Text = "Unidad: " + dgv.CurrentRow.Cells("Und").Value
        Catch ex As Exception
            MsgBox("Seleccione un producto")
        End Try

        Dim cmd As String, tb As New DataTable

        cmd = "SELECT tbl_almacenes.id_almacen, tbl_almacenes.Almacen, movimientos.id_prodcuto, SUM(movimientos.ub_cantidad * n) AS unidades " _
        & "FROM movimientos INNER JOIN tbl_almacenes ON movimientos.almacen = tbl_almacenes.id_almacen GROUP BY tbl_almacenes.id_almacen, tbl_almacenes.Almacen, movimientos.id_prodcuto " _
        & " HAVING SUM(movimientos.ub_cantidad*n)>0 and movimientos.id_prodcuto = " + a
        tb = leer_tabla(cmd)
        grupo1.Visible = False
        If tb.Rows.Count = 0 Then MsgBox("Sin Movimientos!!") : Exit Sub
        grupo1.Visible = True


        Dim column As DataColumn
        column = New DataColumn("factor", System.Type.GetType("System.Decimal"))
        column.DefaultValue = factor : tb.Columns.Add(column)

        column = New DataColumn("Exist", System.Type.GetType("System.Decimal"), "unidades / factor")
        tb.Columns.Add(column)


        dgvexistencia.DataSource = tb


        With dgvexistencia
            .Columns("id_almacen").Visible = False
            .Columns("id_prodcuto").Visible = False
            .Columns("unidades").Visible = False
            .Columns("factor").Visible = False
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Exist").DefaultCellStyle.Format = "N0"
            .Columns("Exist").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub filtropedido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles filtropedido.KeyPress
        If e.KeyChar = chr13 Then
            Me.dgvpedido.Focus()
            Me.dgvpedido.CurrentCell = Me.dgvpedido.Rows(0).Cells(4)
        End If
    End Sub

    Private Sub boton_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_agregar.Click, btn_agregar.Click
        dgvpedido.RefreshEdit()
        agregar_seleccionados()
    End Sub

    Private Sub agregar_seleccionados()
        Dim filtro As String = "und<>0 or cj<>0"
        Dim idpz, idcj, id, cantpz, cantcj As Integer
        filtro = filtro
        bsexistencia.Filter = filtro

        '============================================================================
        For j As Integer = 0 To dgvpedido.Rows.Count - 1
            With dgvpedido.Rows(j)
                cantpz = .Cells("und").Value : cantcj = .Cells("cj").Value
                idpz = .Cells(6).Value : idcj = .Cells(7).Value
                id = .Cells("id_producto").Value
            End With
            If cantpz > 0 Then agregar(id, idpz, cantpz)
            If cantcj > 0 Then agregar(id, idcj, cantcj)
        Next j
        bsexistencia.Filter = ""
        For j As Integer = 0 To dgvpedido.Rows.Count - 1
            With dgvpedido.Rows(j)
                Try
                    .Cells("und").Value = 0
                    .Cells("cj").Value = 0
                Catch ex As Exception
                End Try
            End With
        Next j
        totalizar()
        Me.TabControl1.SelectTab(1)
        linea.Focus()
    End Sub
    '******************************************** Agregar seleccion

    Private Sub agregar(ByVal id As Integer, ByVal ud_id As Integer, ByVal cant As Integer)
        Dim filtro As String
        filtro = "id_producto = " + id.ToString + " and id_unidad = " + ud_id.ToString
        Me.Lista_de_ventasBindingSource.Filter = filtro

        ' ================================  Verifica si ya existe en la factura
        Dim alta As Boolean = False
        Dim ix1 As Integer
        For ix1 = 0 To mytable.Rows.Count - 1
            With mytable.Rows(ix1)
                If .Item("id") = id And .Item("ud_id") = ud_id Then
                    cant += .Item("cantidad")
                    .Item("cantidad") = cant
                    Exit Sub
                End If
            End With
        Next

        If alta = False Then
            Dim dr As DataRow = mytable.NewRow
            dr("id") = Me.Id_productoTextBox.Text
            dr("iva") = Me.IvaTextBox.Text
            dr("piva") = Me.IvaTextBox.Text
            dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
            dr("und") = Me.UnidadTextBox.Text
            dr("factor") = Me.FactorTextBox.Text
            dr("cantidad") = cant
            dr("ud_costo") = Me.CostoTextBox.Text
            dr("ud_plventa") = Me.VentaTextBox.Text
            dr("ud_flista") = info_factor 'factor precio lista
            dr("ud_pventa") = Int(dr("ud_plventa") * info_factor * 100) / 100
            dr("pdesc") = 0
            dr("nf") = 1
            dr("peso") = Me.PesoTextBox.Text
            dr("ud_id") = Me.Id_unidadTextBox.Text
            dr("codigo") = Me.CodigoTextBox1.Text()
            mytable.Rows.Add(dr)
        End If
    End Sub

    Private Sub ExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TabControl1.SelectTab(5)
    End Sub

    Public Sub repetir_documento(ByVal td As Integer, ByVal folio As Integer, ByVal serie As String, ByVal borrar As Boolean)
        Dim adoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
        Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim lista As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        Dim status As Integer, fecha As Date, id As Integer, idud, cantidad As Integer
        Dim docum As DataRow, tablamov As New DataTable
        Try
            docum = adoc.GetDataByKey(td, folio, serie).Rows(0)
        Catch ex As Exception
            MsgBox("No se encuantra ese documento")
            Exit Sub
        End Try
        jalada_td = td
        jalada_folio = folio
        jalada_serie = serie
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        status = docum("status")
        fecha = docum("fechafactura")
        id_cliente = docum("id_directorio")
        tipo_venta = td
        tablamov = amov.GetDataByKey(td, folio, serie)
        For j As Integer = 0 To tablamov.Rows.Count - 1
            id = tablamov.Rows(j).Item("id_prodcuto")
            idud = tablamov.Rows(j).Item("ud")
            cantidad = tablamov.Rows(j).Item("cantidad")
            Dim filtro As String = "id_producto = " + id.ToString + " and id_unidad = " + idud.ToString
            Me.Lista_de_ventasBindingSource.Filter = filtro
            If Me.Lista_de_ventasBindingSource.Position < 0 Then
            Else
                Dim dr As DataRow = mytable.NewRow
                dr("id") = Me.Id_productoTextBox.Text
                dr("iva") = Me.IvaTextBox.Text
                dr("piva") = Me.IvaTextBox.Text
                dr("descripcion") = Trim(Me.DescripcionTextBox.Text) + IIf(FactorTextBox.Text <> "1", " (" + Me.FactorTextBox.Text + ")", "")
                dr("und") = Me.UnidadTextBox.Text
                dr("factor") = Me.FactorTextBox.Text
                dr("cantidad") = cantidad
                dr("ud_costo") = Me.CostoTextBox.Text
                dr("ud_plventa") = Me.VentaTextBox.Text
                dr("ud_flista") = info_factor 'factor precio lista
                dr("ud_pventa") = Int(dr("ud_plventa") * info_factor * 100) / 100
                dr("pdesc") = 0
                dr("nf") = 1
                dr("peso") = Me.PesoTextBox.Text
                dr("ud_id") = Me.Id_unidadTextBox.Text
                dr("codigo") = Me.CodigoTextBox1.Text
                mytable.Rows.Add(dr)
                Me.linea.Text = "" : Me.linea.Focus()
            End If
        Next
        Dim adap As New admintegralDataSetTableAdapters.ComentariosTableAdapter
        Dim dr1 As DataRow
        Try
            dr1 = adap.GetDataBykey(td, folio, serie).Rows(0)
            comentarios.Text = dr1.Item("comentarios")
            adap.Dispose()
        Catch ex As Exception
        End Try
        Me.Lista_de_ventasBindingSource.Filter = "" : totalizar()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub 'Carga a memoria documento y lo cancela o Borra

    Private Sub CapturaVariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaVariosToolStripMenuItem.Click
        Me.TabControl1.SelectTab(2)
        Me.filtropedido.Text = ""
        Me.filtropedido.Focus()
    End Sub

    Private Sub filtropedido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtropedido.TextChanged
        Dim filtro As String
        filtro = preparar_filtro("Descripcion", filtropedido.Text)
        bsexistencia.Filter = filtro
    End Sub

    Private Sub dgvpedido_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvpedido.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub idsalida_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idsalida.KeyPress, identrada.KeyPress
        If e.KeyChar = chr13 Then
            Dim op As New TextBox
            Dim almacen As String
            op = sender
            Dim adap As New admintegralDataSetTableAdapters.tbl_almacenesTableAdapter
            Try
                almacen = adap.leer(op.Text).ToString
            Catch ex As Exception
                MsgBox("Teclee numero de almacen")
                Exit Sub
            End Try
            If op.Name = "idsalida" Then
                Me.almacensalida.Text = almacen
                Me.identrada.Focus()
            Else
                Me.almacenentrada.Text = almacen
                If Me.idsalida.Text = Me.identrada.Text Then MsgBox("No puede ser ") : Exit Sub
                Me.puerta.Focus()
            End If
        End If
    End Sub 'LEE ALMACEN

    Private Sub puerta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles puerta.KeyPress
        If e.KeyChar = chr13 Then
            Me.quien.Focus()
        End If
    End Sub

    Private Sub quien_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles quien.KeyPress
        If e.KeyChar = chr13 Then
            Me.linea.Focus()
        End If
    End Sub

    Private Sub imprimir_traspaso(ByVal reporte As String)
        Dim l As String, j As Integer, pg As Integer = 1
        Dim archivo As String = "c:\tmp\trasp" + reporte + folio.Text + ".txt", cc As String, nl As Integer = 0
        Dim f As New System.IO.StreamWriter(archivo, False)
        cc = Microsoft.VisualBasic.Chr(27) + Microsoft.VisualBasic.Chr(14)
        f.WriteLine(cc)
        l = "Traspaso No.: " + folio.Text
        f.WriteLine("Abarrotera Bara, S.A. de C.V.")
        f.WriteLine(l.PadLeft(68))
        f.WriteLine("                ")
        f.WriteLine("Fecha : " + Now.Date)
        f.WriteLine("Almacen de Salida  : " + idsalida.Text + " " + almacensalida.Text) 'Almacen Salida
        f.WriteLine("Almacen de Entrada : " + identrada.Text + " " + almacenentrada.Text) ' Numero/agente/comercial
        f.WriteLine("                ")
        f.WriteLine("Puerta : " + puerta.Text)
        f.WriteLine("                ")
        f.WriteLine("  CONDIGO               Descricpion                             UND.   Cant.")
        f.WriteLine("================ ============================================== =====  =====")
        Dim r As DataRow
        Dim fcod, fdesc, funidad, fcant As String, max As Integer = 49
        nl = 0 : Dim npg As Integer = ((mytable.Rows.Count - 1) \ 50) + 1
        For j = 0 To mytable.Rows.Count - 1
            r = mytable.Rows(j)
            fcod = Mid(r.Item("codigo").ToString.PadRight(14), 1, 17)
            fdesc = Mid(r.Item("descripcion").ToString.PadRight(48), 1, 48)
            funidad = r.Item("und").ToString.PadRight(5)
            fcant = r.Item("Cantidad").ToString.PadLeft(5)
            l = fcod + fdesc + funidad + fcant + "  ....."
            f.WriteLine(l) : nl += 1
            If nl > max Then
                f.WriteLine("================ ============================================== =====  =====")
                f.WriteLine("                                                        Pg." + pg.ToString + " de " + npg.ToString)
                pg += 1 : f.WriteLine(Microsoft.VisualBasic.Chr(12))
                nl = 1
            End If
        Next j
        f.WriteLine("================ ============================================== =====  =====")
        f.WriteLine("                                                        Pg." + pg.ToString + " de " + npg.ToString)
        l = comentarios.Text : f.WriteLine(l) : nl += 1
        l = "Traspaso No.: " + folio.Text
        f.WriteLine(l.PadLeft(68))
        f.WriteLine("")
        f.WriteLine("______________________       ______________________    _____________________")
        f.WriteLine()
        l = "Recibio: " + quien.Text : l = l.PadRight(25)
        l = l + "   Transporto                 RECIBIO : Nombre y Firma"
        f.WriteLine(l)
        f.WriteLine("Elaboro :" + user.nombre)
        f.WriteLine("")
        f.WriteLine("[  ]Faltantes Traspaso No.:_________")
        f.WriteLine(Microsoft.VisualBasic.Chr(12))
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.impresora_factura, archivo)
    End Sub '================== Imprimir FACTURA ============================

    Private Sub imprimir_traspaso_costeado(ByVal reporte As String)
        Dim l As String, j As Integer, pg As Integer = 1
        Dim archivo As String = "c:\tmp\trasp" + reporte + folio.Text + ".txt", cc As String, nl As Integer = 0
        Dim f As New System.IO.StreamWriter(archivo, False)
        cc = Microsoft.VisualBasic.Chr(27) + Microsoft.VisualBasic.Chr(14)
        f.WriteLine(cc)
        l = "Traspaso No.: " + folio.Text
        f.WriteLine("Abarrotera Bara, S.A. de C.V.")
        f.WriteLine(l.PadLeft(68))
        f.WriteLine("                ")
        f.WriteLine("Fecha : " + Now.Date)
        f.WriteLine("Almacen de Salida  : " + idsalida.Text + " " + almacensalida.Text) 'Almacen Salida
        f.WriteLine("Almacen de Entrada : " + identrada.Text + " " + Almacenentrada.Text) ' Numero/agente/comercial
        f.WriteLine("                ")
        f.WriteLine("Puerta : " + puerta.Text)
        f.WriteLine("                ")
        f.WriteLine("  CONDIGO               Descricpion              UND.  Cant.    Unit.     Importe ")
        f.WriteLine("================ ============================== =====  =====  ========= ==========")
        Dim r As DataRow
        Dim fcod, fdesc, funidad, fcant As String, max As Integer = 49
        Dim cu As String, mim As Double, mims As String, tt As Double = 0
        nl = 0 : Dim npg As Integer = ((mytable.Rows.Count - 1) \ 50) + 1
        For j = 0 To mytable.Rows.Count - 1
            r = mytable.Rows(j)
            fcod = Mid(r.Item("codigo").ToString.PadRight(14), 1, 17)
            fdesc = Mid(r.Item("descripcion").ToString.PadRight(30), 1, 30)
            funidad = r.Item("und").ToString.PadRight(5)
            fcant = r.Item("Cantidad").ToString.PadLeft(5)
            cu = Format(r.Item("ud_Costo"), "#,###.00")
            mim = r.Item("ud_Costo") * r.Item("cantidad")
            mims = Format(mim, "##,###.00")
            tt += mim
            l = fcod + fdesc + funidad + fcant + " " + cu.PadLeft(9) + " " + mims.PadLeft(12)
            f.WriteLine(l) : nl += 1
            If nl > max Then
                f.WriteLine("================ ============================== =====  ===== ========= ==========")
                f.WriteLine("                                                        Pg." + pg.ToString + " de " + npg.ToString)
                pg += 1 : f.WriteLine(Microsoft.VisualBasic.Chr(12))
                nl = 1
            End If
        Next j
        f.WriteLine("================ ============================== =====  ===== ========= ==========")
        l = " Total     ".PadLeft(68) + Format(tt, "##,###.00").PadLeft(12) : f.WriteLine(l) : nl += 1
        f.WriteLine(" ")
        f.WriteLine("")
        f.WriteLine("                             RECIBE CHOFER PARA SU                         ")
        f.WriteLine(" ENTREGA DOCUMENTOS          TRASLADO A LA SUCURSAL       AUTORIZA SALIDA   ")
        f.WriteLine("")
        f.WriteLine("______________________       ______________________    _____________________")
        f.WriteLine("    NOMBRE Y FIRMA              NOMBRE Y FIRMA            JOSE LUIS CANCHE  ")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("   RECIBE ENCARGADO          ACEPTA FACTURISTA           ACEPTA AYUDANTE   ")
        f.WriteLine("")
        f.WriteLine("______________________       ______________________    _____________________")
        f.WriteLine(" SELLO,NOMBRE Y FIRMA              NOMBRE Y FIRMA            NOMBRE Y FIRMA  ")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("NOTA:   FAVOR DE NO ACEPTAR PRODUCTO  EN MAL ESTADO, CADUCADO,  PORQUE NO SE APLICARA")
        f.WriteLine("DEVOLUCIONES(POSTERIORES)")
        f.WriteLine()
        f.WriteLine()
        
        'f.WriteLine("Elaboro :" + user.nombre)
        'f.WriteLine("")
        'f.WriteLine("[  ]Faltantes Traspaso No.:_________")
        l = comentarios.Text : f.WriteLine(l) : nl += 1
        l = "Traspaso No.: " + folio.Text : f.WriteLine(l.PadLeft(68))
        f.WriteLine("                                                        Pg." + pg.ToString + " de " + npg.ToString)
        f.WriteLine(Microsoft.VisualBasic.Chr(12))
        f.Close()
        Imprimir.SendFileToPrinter(My.Settings.impresora_factura, archivo)
    End Sub '================== Imprimir FACTURA ============================

    Private Sub boton_repetir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_repetir.Click
        Dim f As Integer
        Try
            f = InputBox("Teclee el numero de Traspaso que quiere Repetir (Teclee '0' para salir.", "Repetir un Traspaso", "")
        Catch ex As Exception
            Exit Sub
        End Try
        If Val(f) < 1 Then Exit Sub
        Dim td, serie As String
        td = 3
        serie = info_almacen
        repetir_documento(td, f, Trim(serie), False)
    End Sub
  
    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        My.Forms.Traspasos_relacion.Show()
    End Sub

    Private Sub Almacenentrada_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Almacenentrada.SelectedValueChanged
        Me.identrada.Text = Almacenentrada.SelectedValue
    End Sub

    Private Sub boton_reimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_reimprimir.Click
        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim j As Integer
        j = afolio.siguiente(3, info_almacen)
        j = j - 1
        j = InputBox("Teclee el numero de Traspaso que quiere Reimprimir (Solo puede reimprimir traspasos hechos en esta terminal)", "Reimrimir", j)
        Dim archivo As String = "c:\tmp\traspsalida" + j.ToString + ".txt"
        Imprimir.SendStringToPrinter(My.Settings.impresora_factura, "************   REIMPRESION   ***********")
        Imprimir.SendFileToPrinter(My.Settings.impresora_factura, archivo)
    End Sub

    Private Sub CargarUltimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarUltimaToolStripMenuItem.Click

        Try
            mytable.ReadXml(tmpfile)
        Catch ex As Exception

        End Try

        totalizar()

    End Sub ' cargar el archivo tmpfile

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        Me.Lista_de_ventasTableAdapter.Fill(Me.AdmintegralDataSet.Lista_de_ventas)
    End Sub
End Class