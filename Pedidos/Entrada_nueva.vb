Public Class Entrada_nueva
    Public mytable As New DataTable
    Public npedido As Integer = 0
    Dim condiferencias As Boolean = False
    Public WithEvents dgv As New MiGrid
    Dim cjfolio As Integer, cjserie As String
    Dim nrow As Integer
    Dim tblcambios As New DataTable
    Dim nfolio As Single
    Dim bs As New BindingSource
    Dim factor_iva1_venta As String
    Dim factor_iva2_venta As String
    Dim dspedido As New DataSet
    Dim recibiendo_pedido As Boolean

    Private Sub Entreada_nueva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.iva
        factor_iva1_venta = (My.Settings.iva / 100).ToString 'iva10
        factor_iva2_venta = (My.Settings.iva2 / 100).ToString 'iva15

        Me.Tbl_almacenesTableAdapter.Fill(Me.AdmintegralDataSet.tbl_almacenes)
        Me.id_provtxt.Text = gprov.id
        Me.nombreprovtxt.Text = gprov.nombre
        Me.diasc.Text = gprov.dias
        piva.Text = 0
        crear_grid()
        dgv.ContextMenuStrip = Me.ContextMenuStrip1
        ' Me.MainMenuStrip.Parent = Me
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width - 100
        Me.Left = 1
    End Sub '***** CARGAR FORMA*******

    Private Sub crear_grid()
        mytable.TableName = "Entrada"
        Dim column = New DataColumn()
        column = New DataColumn("id", System.Type.GetType("System.Int32"))
        tblcambios.Columns.Add(column)        ' Add the Column to the DataColumnCollection.
        column = New DataColumn("UB", System.Type.GetType("System.Int32"))
        tblcambios.Columns.Add(column)        ' Add the Column to the DataColumnCollection.
        column = New DataColumn("Descripcion", System.Type.GetType("System.String"))
        tblcambios.Columns.Add(column)
        column = New DataColumn("actual", System.Type.GetType("System.Decimal"))
        column.caption = "Costos Actual"
        tblcambios.Columns.Add(column)
        column = New DataColumn("nuevo", System.Type.GetType("System.Decimal"))
        column.caption = "Nuevo Costos"
        tblcambios.Columns.Add(column)
        column = New DataColumn("margen", System.Type.GetType("System.Decimal"))
        tblcambios.Columns.Add(column)        ' Add the Column to the DataColumnCollection.
        column = New DataColumn("Vactual", System.Type.GetType("System.Decimal"))
        column.caption = "Vta. Actual("")"
        tblcambios.Columns.Add(column)
        column = New DataColumn("Vta. Nuevo", System.Type.GetType("System.Decimal"), "(Convert((nuevo*(1+(margen/100))*100),'System.Int32'))/100")
        column.caption = "Vta. nuevo"
        tblcambios.Columns.Add(column)

        ' dgvcambios.DataSource = tblcambios
        '=======================================================================================================
        AddHandler dgv.CellEndEdit, AddressOf dgv_CellEndEdit
        AddHandler dgv.CellDoubleClick, AddressOf dgv_CellDoubleClick
        ' AddHandler dgv.ce, AddressOf dgv_CellDoubleClick
        '   AddHandler dgv.CellEnter, AddressOf dgv_CellEnter
        dgv.Parent = Me
        dgv.Dock = DockStyle.Fill
        dgv.Parent = Me.SplitContainer2.Panel1
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Declare variables for DataColumn and DataRow objects.

        ' Create new DataColumn, set DataType, ColumnName 
        column = New DataColumn("codigo", System.Type.GetType("System.String"))
        column.Caption = "Codigo" : column.Unique = False
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "Id"
        column.Caption = "id"
        column.Unique = False
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.


        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "iva"
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.


        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "piva"
        column.Caption = "*" + column.ColumnName
        column.Expression = "iif (iva>0, 16,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.


        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Descripcion"
        column.Caption = "Producto"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Und"
        column.Caption = "und"
        mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "factor"
        column.Caption = "*" + column.ColumnName
        mytable.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "ub_Und"
        column.Caption = "und"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cantidad"
        column.Caption = "Cant" : column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "ud_Costo"
        column.Caption = "Costo" : column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn() 'porcentaje de descuento (solo para formula)
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "pdesc"
        column.Caption = "*" + column.ColumnName
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_CDesc"
        column.Caption = "Desc."
        column.DefaultValue = 0
        column.Expression = "ud_costo * pdesc"
        column.ReadOnly = True : column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_CFlete"
        column.Caption = "Flete"
        column.DefaultValue = 0 : column.DefaultValue = 0
        column.ReadOnly = True
        mytable.Columns.Add(column)

        column = New DataColumn() 'cOSTOS nETO
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_Cneto"
        column.Caption = "Neto" : column.DefaultValue = 0
        column.Expression = "ud_costo - UD_CDesc"
        mytable.Columns.Add(column)

        column = New DataColumn() 'IMPORTE
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Importe"
        column.Caption = "Importe" : column.DefaultValue = 0
        column.Expression = "cantidad * ud_cneto"
        mytable.Columns.Add(column)

        ' Create new DataColumn, set DataType, ColumnName 
        column = New DataColumn("Comentarios", System.Type.GetType("System.String"))
        column.Caption = "Comentarios" : column.Unique = False
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_iva10"
        column.Caption = "*" + column.ColumnName
        column.Expression = "iif(piva=" + My.Settings.iva.ToString + ",ud_cneto*" + factor_iva1_venta.ToString + ",0)"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_iva15"
        column.Caption = "*" + column.ColumnName
        column.Expression = "iif(piva=" + My.Settings.iva2.ToString + ",ud_cneto*" + factor_iva2_venta.ToString + ",0)"
        mytable.Columns.Add(column)

        'Columnas de Unidad Base
        '================================================================================

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UB_Cantidad"
        column.Caption = "*" + column.ColumnName
        column.Expression = "factor * Cantidad"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UB_Costo"
        column.Caption = "*" + column.ColumnName
        column.ReadOnly = False
        column.Expression = "ud_cneto / factor"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ub_CDesc"
        column.Caption = "*" + column.ColumnName
        column.ReadOnly = True
        column.Expression = "ud_cdesc /  factor"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UB_CFlete"
        column.Caption = "*" + column.ColumnName
        column.Expression = " ud_cflete / factor"
        mytable.Columns.Add(column)


        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ub_iva10"
        column.Caption = "*" + column.ColumnName
        column.Expression = "ud_iva10 / factor"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ub_iva15"
        column.Caption = "*" + column.ColumnName
        column.Expression = "ud_iva15 / factor"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "subdesc"
        column.Caption = "*" + column.ColumnName
        column.Expression = "ud_cdesc * cantidad"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "subiva10"
        column.Caption = "*" + column.ColumnName
        column.Expression = "ud_iva10 * cantidad"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "subiva15"
        column.Caption = "lk*" + column.ColumnName
        column.Expression = "ud_iva15 * cantidad"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ped_cantidad"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Ped_costo"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UD_costo_base"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        '*****************************************************************
        'SUB TOTALES
        '******************************************************************
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cal0"
        column.Expression = "iif (iva=0, ud_costo * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cal10"
        column.Expression = "iif (piva=" + My.Settings.iva.ToString + ", ud_costo * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "Cal15"
        column.Expression = "iif (piva=" + My.Settings.iva2.ToString + ", ud_costo * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)
        '**********************************************************************
        ' sub-totales DESCUENTo
        '**********************************************************************

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "dal0"
        column.Expression = "iif (iva=0, ud_cdesc * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "dal10"
        column.Expression = "iif (iva=" + My.Settings.iva.ToString + ", ud_cdesc * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "dal15"
        column.Expression = "iif (iva=" + My.Settings.iva2.ToString + ", ud_cdesc * cantidad,0)"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "id_uc"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Boolean")
        column.ColumnName = "Caduca"
        column.DefaultValue = 0
        mytable.Columns.Add(column)

        ' and add to DataTable.    
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.DateTime")
        column.ColumnName = "Caducidad"
        '        column.DefaultValue = 0
        mytable.Columns.Add(column)
        'asigna la abla al datagrid


        '' PIEPS
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")   '<=============IEPS
        column.ColumnName = "pieps" : column.Caption = "ieps" : column.DefaultValue = 0
        column.Unique = False
        mytable.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "ieps"
        column.Expression = "iif(pieps<>0,ud_cneto*(pieps/100),0)"
        mytable.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "tieps"
        column.Expression = "ieps*cantidad"
        mytable.Columns.Add(column)



        'column = New DataColumn("ieps", System.Type.GetType("System.Decimal"), "iif(pieps<>0,ud_vneto*(pieps/100),0)")
        'column.Caption = "IEPS" + column.ColumnName : mytable.Columns.Add(column)

        dgv.DataSource = mytable
        ' Oculta columnas de calculo
        dgv.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("id").ReadOnly = True
        dgv.Columns("Descripcion").ReadOnly = True
        dgv.Columns("und").ReadOnly = True
        dgv.Columns("Factor").ReadOnly = True
        dgv.Columns("UB_und").ReadOnly = False

        '**********************************************************************
        dgv.Columns("Importe").DefaultCellStyle.Format = "N2"
        dgv.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("ud_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("ub_und").Visible = False
        dgv.Columns("ud_costo_base").Visible = False
        'dgv.Columns("iva").Visible = False
        'dgv.Columns("piva").Visible = False
        dgv.Columns("pdesc").Visible = False
        dgv.Columns("ud_cdesc").Visible = False
        dgv.Columns("ud_cflete").Visible = False
        dgv.Columns("ud_cneto").Visible = False
        dgv.Columns("ud_iva10").Visible = False
        dgv.Columns("ud_iva15").Visible = False
        dgv.Columns("ub_cantidad").Visible = False
        dgv.Columns("ub_Costo").Visible = False
        dgv.Columns("ub_cdesc").Visible = False
        dgv.Columns("ub_cflete").Visible = False
        dgv.Columns("ub_iva10").Visible = False
        dgv.Columns("ub_iva15").Visible = False
        dgv.Columns("id_uc").Visible = True
        dgv.Columns("subdesc").Visible = False
        dgv.Columns("subiva10").Visible = False
        dgv.Columns("subiva15").Visible = False
        dgv.Columns("ped_cantidad").Visible = False
        dgv.Columns("ped_costo").Visible = False
        dgv.Columns("cal0").Visible = False
        dgv.Columns("cal10").Visible = False
        dgv.Columns("cal15").Visible = False
        dgv.Columns("dal0").Visible = False
        dgv.Columns("dal10").Visible = False
        dgv.Columns("dal15").Visible = False
        ' dgv.Columns("ieps").Visible = False
        ' dgv.Columns("pieps").Visible = False
        ' dgv.Columns("tieps").Visible = False
        dgv.Columns("id_uc").Visible = False
        dgv.Columns("caduca").Visible = False
        dgv.Columns("caducidad").Visible = False


        'dgv.Columns("ped_cantidad").DisplayIndex = dgv.Columns("cantidad").DisplayIndex - 1
        dgv.Columns("ped_cantidad").HeaderText = "Pedido"
        'dgv.Columns("caduca").Visible = False
        dgv.Columns("ped_cantidad").DefaultCellStyle.BackColor = Color.LightGray
        Me.ErrorProvider1.DataSource = dgv.DataSource
        If npedido = 0 Then
            For j As Integer = 0 To 30
                Dim drr As DataRow
                drr = mytable.NewRow
                drr.Item(0) = ""
                mytable.Rows.Add(drr)
            Next
        End If
    End Sub 'crea el grid

    Private Sub pdesctext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pdesctext.TextChanged
        Dim pd As Double
        If CDbl(Me.pdesctext.Text) > 100 Then Me.pdesctext.Text = "100"
        Try
            pd = CDbl(Me.pdesctext.Text) / 100
        Catch ex As Exception
            pd = 0
        End Try
        Try
            mytable.Columns("pdesc").DefaultValue = pd.ToString
            For j As Integer = 0 To Me.dgv.Rows.Count - 1
                Me.dgv.Rows(j).Cells("pdesc").Value = pd.ToString
            Next
        Catch ex As Exception

        End Try
    End Sub ' rellena grid con descuento y pone como default en la celda

    Private Sub pdesctext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pdesctext.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub ' valida solo digitos en txt de  pdesc

    Private Sub totaliza()
        Try
            subtotaltxt.Text = Format(mytable.Compute("sum(importe)+sum(subdesc)", ""), "N2")
            descuentotxt.Text = Format(mytable.Compute("sum(subdesc)", ""), "N2")
            iva10txt.Text = Format(mytable.Compute("sum(subiva10)", ""), "N2")
            iva15txt.Text = Format(mytable.Compute("sum(subiva15)", ""), "N2")
            Tieps.Text = Format(mytable.Compute("sum(tieps)", ""), "N2")
            totaltxt.Text = Format(CDbl(subtotaltxt.Text) - CDbl(descuentotxt.Text) + CDbl(iva10txt.Text) + CDbl(iva15txt.Text) + CDbl(Tieps.Text), "N2")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub '************ TOTALIZAR

    Private Sub pedir_producto()
        Dim adapp As New admintegralDataSetTableAdapters.productosTableAdapter
        Dim x As DialogResult
        x = My.Forms.Buscar_productos.ShowDialog
        Try
            If producto.a1id > 0 Then
                '  My.Forms.Buscar_productos.ShowDialog()
                Dim u As Und
                u = sk_leer_UndCompra(producto.a1id)
                Me.dgv.CurrentRow.Cells("id").Value = producto.a1id
                dgv.CurrentRow.Cells("Descripcion").Value = producto.a2descripcion
                dgv.CurrentRow.Cells("factor").Value = producto.a3factor
                dgv.CurrentRow.Cells("und").Value = producto.a4uc
                dgv.CurrentRow.Cells("ub_und").Value = producto.a5ub
                dgv.CurrentRow.Cells("iva").Value = producto.a6iva
                dgv.CurrentRow.Cells("ud_Costo").Value = u.a4_costo
                dgv.CurrentRow.Cells("codigo").Value = producto.a7codigo
                dgv.CurrentRow.Cells("id_uc").Value = u.a9_uc_id
                dgv.CurrentRow.Cells("ud_Costo_base").Value = u.a4_costo
                dgv.CurrentRow.Cells("caduca").Value = producto.a9caducidad
                dgv.CurrentRow.Cells("pieps").Value = producto.ieps
                My.Computer.Keyboard.SendKeys("{enter}")
                Dim v As Integer = adapp.GetDataById(producto.a1id).Rows(0).Item("id_Directorio")
                If v <> Me.id_provtxt.Text Then
                    dgv.CurrentRow.DefaultCellStyle.BackColor = Color.Red
                    dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.White
                Else
                    dgv.CurrentRow.DefaultCellStyle.BackColor = Color.White
                    dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.Black
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub ' Pide un producto desde buscar productos

    Private Sub guarda_documento()
        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim adapund As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Dim result As Boolean
        Dim d As New Mi_Documento
        Dim r As DataRow
        Dim j, jj As Integer, newc As Double

        Dim f As Long
        Try
            f = afolio.siguiente(1, "")
        Catch ex As Exception
            f = 1
        End Try

        status1.Text = "Guardando Documentos"
        barra.Maximum = dgv.Rows.Count
        barra.Value = 1
        d.a00_id_doc = 1
        d.a01_Folio = f
        d.a02_serie = " "
        d.a03_Almacen = Me.AlmacenComboBox.SelectedValue
        d.a04_id_directorio = Me.id_provtxt.Text
        d.a05_tipo_directorio = 1
        d.a06_fecha_registro = Date.Now.ToString
        d.a07_Folio_pedido = npedido
        d.a08_factura = Me.facturatxt.Text
        d.a09_fecha_factura = CDate(fechafactura.Value.ToString)
        d.a10_fecha_surtido = CDate(fechaEntrada.Value.Date)
        d.a11_fecha_vence = fechavence.Value.ToString
        d.a12_pdesc = CDbl(Me.pdesctext.Text)
        d.a13_flete = CDbl(Me.fletetxt.Text)
        d.a14_sub0 = mytable.Compute("sum(cal0)", "")
        d.a15_sub10 = mytable.Compute("sum(cal10)", "")
        d.a16_sub15 = mytable.Compute("sum(cal15)", "")
        d.a17_iva10 = mytable.Compute("sum(subiva10)", "")
        d.a18_iva15 = mytable.Compute("sum(subiva15)", "")
        d.a19_desc0 = mytable.Compute("sum(dal0)", "")
        d.a20_desc10 = mytable.Compute("sum(dal10)", "")
        d.a21_desc15 = mytable.Compute("sum(dal15)", "")
        d.a22_importe = Me.totaltxt.Text
        d.a23_idcartera = 1 ' CxP
        d.a24_status = 0
        d.a25_almaentrada = 0
        d.a26_diasc = Val(Me.diasc.Text)
        d.a27_pviva = Me.piva.Text
        d.a36_ieps = Me.Tieps.Text

        result = Agregar_documento(d)

        If result = False Then
            MsgBox("No se guardo el documento")
            Exit Sub
        End If

        status1.Text = "Guardando Movimientos"
        ' Guarda el detalle de la entrada
        For j = 0 To mytable.Rows.Count - 1
            barra.Value = j
            r = mytable.Rows(j)
            If r.Item("cantidad") > 0 Then
                Dim m As New mi_movimientos
                m.a01_Almacen = d.a03_Almacen
                m.a02_id_doc = d.a00_id_doc
                m.a03_Folio = d.a01_Folio
                m.a04_serie = d.a02_serie
                m.a05_num = j
                m.a06_fecha = d.a10_fecha_surtido
                m.a07_idproducto = r.Item("id")
                m.a08_factor = r.Item("factor")
                m.a09_piva = r.Item("piva")
                m.a10_ud = r.Item("id_uc")
                m.a11_cantidad = r.Item("cantidad")
                m.a12_costo = r.Item("ud_costo")
                m.a13_Cdesc = r.Item("ud_cdesc")
                m.a14_cflete = r.Item("ud_cflete")
                m.a15_civa10 = r.Item("ud_iva10")
                m.a16_civa15 = r.Item("ud_iva15")
                m.a21_ub_cant = r.Item("ub_cantidad")
                m.a22_ub_costo = r.Item("ub_costo")
                m.a23_ub_Cdesc = r.Item("ub_cdesc")
                m.a24_ub_cflete = r.Item("ub_cflete")
                m.a25_ub_civa10 = r.Item("ub_iva10")
                m.a26_ub_civa15 = r.Item("ub_iva15")
                m.a31_signo = 1
                m.a32_caducidad = Now.Date
                m.a36_ub_ieps = r.Item("tieps")

                Try
                    If IsDate(r.Item("caducidad")) = True Then m.a32_caducidad = r.Item("caducidad") Else m.a32_caducidad = Now.Date
                Catch ex As Exception

                End Try

                result = agregar_movimiento(m)

                'Actualiza Costos
                Dim cmdtbl As String = "Select * from unidades_productos where id_producto= " + m.a07_idproducto.ToString
                Dim tbl As DataTable = leer_tabla(cmdtbl)
                If tbl.Rows.Count > 0 Then
                    For jj = 0 To tbl.Rows.Count - 1
                        Try
                            newc = r.Item("ub_costo") * tbl.Rows(jj).Item("unidades")
                            If newc > 0 Then adapund.Actualiza_costo(newc, m.a07_idproducto, tbl.Rows(jj).Item("id_unidad"))
                        Catch ex As Exception

                        End Try
                    Next jj
                End If
            End If
            Me.Refresh()
        Next

        status1.Text = "Guardando Comentarios"
        Me.Refresh()
        nfolio = d.a01_Folio
        'actualiza la tabla de comentarios
        Dim adap As New admintegralDataSetTableAdapters.ComentariosTableAdapter
        adap.Insert(d.a00_id_doc, d.a01_Folio, d.a02_serie, puertatxt.Text, Recibiotxt.Text, comentariotxt.Text)


        'si se va a CXP se guarda
        If acredito.Checked = True Then
            Try
                Dim acxp As New integraDataSetTableAdapters.cxp_facturasTableAdapter
                acxp.Insert(d.a04_id_directorio, d.a08_factura, d.a09_fecha_factura, d.a06_fecha_registro, d.a11_fecha_vence, d.a17_iva10 + d.a18_iva15, d.a22_importe, 0, 0, d.a36_ieps)
            Catch ex As Exception

            End Try
        End If

        If npedido > 0 Then
            status1.Text = "Actualizando Pedido"
            Dim status As Integer
            Dim adap1 As New admintegralDataSetTableAdapters.pedidosTableAdapter
            status = 12 : If condiferencias = True Then status = 13
            Try
                adap1.actualiza_entrada(d.a01_Folio, status, npedido)
                adap1.actualiza_comentarios(comentariospedido.Text, npedido)
            Catch ex As Exception

            End Try
            actualiza_pedido()
        End If

    End Sub ' Guarda documentos

    Private Sub actualiza_pedido()
        If npedido > 0 Then
            Dim adap As New admintegralDataSetTableAdapters.Pedidos_detalleTableAdapter
            Dim e, c As Double, j, id As Integer, comentario As String
            barra.Maximum = mytable.Rows.Count - 1
            For j = 0 To mytable.Rows.Count - 1
                barra.Value = j
                Try
                    id = mytable.Rows(j).Item("id").Value
                    e = mytable.Rows(j).Item("cantidad").Value
                    c = mytable.Rows(j).Item("ud_cneto").Value
                    comentario = mytable.Rows(j).Item("cantidad").ToolTipText + ","
                    comentario += mytable.Rows(j).Item("ud_cneto").ToolTipText
                    adap.ped_mov_Updateentrada(e, c, comentario, npedido, id, npedido, id)
                Catch ex As Exception

                End Try
            Next
        End If

    End Sub ' Actualiza pedido

    '****************************************************************************************************
    '**********              DATA GRID DGV                                                      *********
    '****************************************************************************************************

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = 6 Then
            Dim mf As Integer = dgv.CurrentCell.Value
            'determinar precentaciones
            Dim myid As Integer = dgv.CurrentRow.Cells("id").Value
            Dim cmd As String = "Select * from unidades_productos where id_producto = " + myid.ToString
            Dim mytbl As DataTable = leer_tabla(cmd)
            Dim msg As String = "Seleccione Presentacion O [ENTER] para salir :" + chr13 + chr10
            Dim l, ll As String
            For j As Integer = 0 To mytbl.Rows.Count - 1
                With mytbl.Rows(j)
                    ll = Trim(.Item("unidad")) + "........"
                    l = j.ToString + ".- " + ll.Substring(1, 7) + ": " + .Item("factor").ToString + chr10 + chr13
                    msg += l
                End With
            Next
            Dim ix As String = InputBox(msg, "Seleccionar Presentacion", "")
            If ix.Length = 0 Then Exit Sub
            If ix > mytbl.Rows.Count - 1 Then Exit Sub
            dgv.CurrentRow.Cells("und").Value = mytbl.Rows(ix).Item("unidad")
            dgv.CurrentRow.Cells("id_uc").Value = mytbl.Rows(ix).Item("id_unidad")
            dgv.CurrentCell.Value = mytbl.Rows(ix).Item("factor")
            dgv.CurrentRow.Cells("ud_costo").Value = mytbl.Rows(ix).Item("costo")
            dgv.CurrentRow.Cells("ud_costo_base").Value = mytbl.Rows(ix).Item("costo")
            mytable.AcceptChanges()
            totaliza()
            dgv.CurrentCell = dgv.CurrentRow.Cells(8)
            Exit Sub
        End If

        If dgv.CurrentCellAddress.X = 0 Then
            pedir_producto()
        End If
        If dgv.CurrentCellAddress.X = 4 Then
            pedir_productos()
        End If
    End Sub ' cambia la presentasion(Factor) de la entrada

    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'columna de entrada del codigo del producto
        If e.ColumnIndex = 0 Then ' Columna Codigo
            Dim ix As Integer, id As String
            id = dgv.CurrentRow.Cells(0).Value.ToString '
            producto.a1id = 0
            ix = leer_id(id) ' Lee el id del producto seg
            Dim undcompra As Und
            If ix < 1 Then
                ix = leer_cod_prov(id, id_provtxt.Text) ' busca por codigo de proveedor
            End If
            If ix < 0 Then
                MsgBox("No existe")
                Exit Sub
            End If

            undcompra = sk_leer_UndCompra(ix) 'determina unidad de compra segun su codigo

            Dim catadap As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
            'Dim dr As DataRow = mytable.NewRow
            Dim codigo As String
            codigo = catadap.GetCodigo(ix, undcompra.a9_uc_id)

            catbs.Filter = ""
            ix = catbs.Find("codigo", codigo)

            If ix >= 0 Then
                leer_producto(tabla_catalogo.Rows(ix)) 'despliega los datos en la row
                'valida si el producto es del proveedor.
                Try
                    If catadap.Getprov(ix, undcompra.a9_uc_id) <> id_provtxt.Text Then
                        'MsgBox("Este producto no es de este proveedor", MsgBoxStyle.Exclamation)
                        dgv.CurrentRow.DefaultCellStyle.BackColor = Color.Red
                        dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.White
                    Else
                        dgv.CurrentRow.DefaultCellStyle.BackColor = Color.White
                        dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Catch ex As Exception

                End Try
            End If

            dgv.CurrentCell = dgv.CurrentRow.Cells("und") 'eduardo modifico UBICA LA CELDA
            totaliza()
            Exit Sub
        End If

        ' Si no es la ciolumna cero acepta cambios y sale
        mytable.AcceptChanges()
        checar_cambios()
        totaliza() : Exit Sub ' validaciones cuando se recibe pedido
    End Sub

    Private Sub dgv_CellEndEdit1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Try
            mytable.AcceptChanges()
        Catch ex As Exception
        End Try
        totaliza()
        If e.ColumnIndex = 8 Then
            dgv.CurrentCell = dgv.Rows(e.RowIndex + 1).Cells(0)
        End If

    End Sub

    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = Keys.F3 Then
            If dgv.CurrentCellAddress.X = 0 Then
                pedir_productos()
                If dgv.CurrentCell.ColumnIndex < 2 Then dgv.CurrentCell = dgv.CurrentRow.Cells("factor")
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If dgv.CurrentCell.ColumnIndex < 2 Then dgv.CurrentCell = dgv.CurrentRow.Cells("factor")
        End If
    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Class MiGrid
        Inherits DataGridView

        Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
            Dim key As Keys = (keyData And Keys.KeyCode)
            If key = Keys.Enter Then
                Return Me.ProcessRightKey(keyData)
            End If
            Return MyBase.ProcessDialogKey(keyData)
            'comentado()
        End Function

        Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
            If (e.KeyCode = Keys.Enter) Then

                Return Me.ProcessRightKey(e.KeyData)
            End If
            Return MyBase.ProcessDataGridViewKey(e)
        End Function
    End Class

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click

        '================================
        'GUARDA E IMPRIME EL DOCUMENTO
        '================================


        Dim ok As Boolean = validar_caducidad()
        If ok = False Then Exit Sub

        totaliza()

        guarda_documento()


        If cjfolio > 0 Then
            Dim adoc As New admintegralDataSetTableAdapters.DocumentosTableAdapter
            Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
            adoc.UpdateStatus(9, user.id, 12, cjfolio, cjserie)
            adoc.Dispose() : amov.Dispose()
        End If
        My.Forms.documentos_imprimir.cargar(1, nfolio, " ")
        My.Forms.documentos_imprimir.Show()
        tblcambios.Clear()
        mytable.Clear()
        For j As Integer = 0 To 30
            Dim drr As DataRow
            drr = mytable.NewRow
            mytable.Rows.Add(drr)
        Next
        ' reinicia variables
        facturatxt.Text = ""
        pdesctext.Text = "0"
        Me.AlmacenComboBox.SelectedIndex = 0
        puertatxt.Text = ""
        Recibiotxt.Text = ""
        comentariotxt.Text = ""
        fletetxt.Text = "0"
        npedido = 0
        Me.ImprimirToolStripButton.Enabled = True
        Me.boton_validar_pedido.Visible = False
    End Sub 'Guarda e Imprime

    Private Sub dgv_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEnter


        If e.ColumnIndex > 9 Then ' Columna Codigo
            'SendKeys.Send("{left}")
            'SendKeys.Send("{left}")
            'SendKeys.Send("{left}")
            'SendKeys.Send("{left}")
            'SendKeys.Send("{left}")
            'SendKeys.Send("{left}")
            'SendKeys.Send("{left}")
            'SendKeys.Send("{left}")
            'SendKeys.Send("{left}")
            SendKeys.Send("{HOME}")
            SendKeys.Send("{down}")
            Exit Sub
        End If
    End Sub 'salta de renglon si da entre en la columna 9 =========================

    Private Sub Cargar_entrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cargar_entrada.Click
        Dim cmd, cmd1 As String
        cmd = "SELECT cajas.Nombre as tienda, Documentos.Folio, documentos.serie , Documentos.id_directorio, Directorio.Nombre, documentos.factura, documentos.importe, documentos.fechafactura, documentos.fechasurtido, documentos.vence , cajas.almacen as almacen "
        cmd += " from Documentos INNER JOIN Directorio ON Documentos.id_directorio = Directorio.id_directorio INNER JOIN cajas ON Documentos.ncaja = cajas.id_caja "
        cmd = cmd + " WHERE Directorio.tipo = 1 AND Documentos.td = 12 and Documentos.status=0"
        Dim tmptbl As DataTable = leer_tabla(cmd)


        cmd1 = "SELECT     cajas.Nombre AS tienda, COUNT(Documentos.Folio) AS Cant FROM Documentos INNER JOIN " _
        & "Directorio ON Documentos.id_directorio = Directorio.id_directorio INNER JOIN cajas ON Documentos.ncaja = cajas.id_caja WHERE     (Directorio.tipo = 1) AND (Documentos.td = 12) AND (Documentos.status = 0) " _
        & " GROUP BY cajas.Nombre"
        Dim tmptbl1 As DataTable = leer_tabla(cmd1)
        Me.dgvresumen.DataSource = tmptbl1

        Me.SplitContainer0.Visible = False
        bs.DataSource = tmptbl
        Me.dgventrada.DataSource = bs

    End Sub ' Cargar tabla de tienda

    Private Sub Boton_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Cerrar.Click
        lblcaja.Visible = False
        Me.SplitContainer0.Visible = True
    End Sub

    Private Sub boton_seleccioanr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_seleccioanr.Click
        Dim f As Integer, s As String
        Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        If dgventrada.CurrentRow.Index >= 0 Then
            With dgventrada.CurrentRow
                Me.AlmacenComboBox.SelectedValue = .Cells("almacen").Value
                Me.id_provtxt.Text = .Cells(3).Value
                Me.nombreprovtxt.Text = Trim(adap.GetDataByID(.Cells(3).Value, 1).Rows(0).Item("Nombre").ToString)
                Me.facturatxt.Text = .Cells(5).Value
                Me.fechaEntrada.Value = .Cells("fechafactura").Value
                Me.fechafactura.Value = .Cells("fechasurtido").Value
                Me.fechavence.Value = .Cells("vence").Value
                f = .Cells(1).Value
                s = .Cells(2).Value
                cargar_entrada_tienda(12, f, s)
                Me.SplitContainer0.Visible = True
                cjfolio = f : cjserie = s
                lblcaja.Visible = True
                totaliza()
            End With
        End If
    End Sub 'selecciona entrada pendiente

    Private Sub cargar_entrada_tienda(ByVal td As Integer, ByVal folio As Integer, ByVal serie As String)
        Dim prod As New admintegralDataSetTableAdapters.productosTableAdapter
        Dim amov As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim unid As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Dim tablamov As New DataTable
        Dim rwprod As DataRow

        tablamov = amov.GetDataByKey(td, folio, serie)
        Dim id, idud, cantidad, iva As Integer, costo As Single
        mytable.Clear()
        For j As Integer = 0 To tablamov.Rows.Count - 1
            id = tablamov.Rows(j).Item("id_prodcuto")
            idud = tablamov.Rows(j).Item("ud")
            cantidad = tablamov.Rows(j).Item("cantidad")
            costo = tablamov.Rows(j).Item("costo")
            iva = tablamov.Rows(j).Item("piva")
           
            If id > 0 Then
                
                Dim uni As Und = sk_leer_UndCompra(id)
                Dim dr As DataRow = mytable.NewRow
                dr("id") = id
                dr("iva") = iva
                dr("id_uc") = idud
                Try
                    dr("descripcion") = Trim(prod.descripcion(id))
                Catch ex As Exception

                End Try

                dr("und") = uni.a6_ub_unidad
                dr("factor") = 1
                dr("cantidad") = cantidad
                dr("ud_costo") = costo
                dr("pdesc") = 0
                dr("codigo") = unid.GetcodigoByid(id, 1).Rows(0).Item("codigo")
                mytable.Rows.Add(dr)
            End If
        Next
    End Sub ' Carga una entrada desde la tienda

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        My.Forms.frm_productos.Show()
        My.Forms.frm_productos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub boton_cambios_de_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cambios_de_precios.Click
        If dgvcambio.Visible = False Then
            Dim adapcat As New admintegralDataSetTableAdapters.productosTableAdapter
            Dim margen As Integer
            tblcambios.Clear()
            For j As Integer = 0 To mytable.Rows.Count - 1
                With mytable.Rows(j)
                    If .Item("ud_costo") <> .Item("ud_costo_base") And .Item("ud_costo") > 0 Then
                        margen = adapcat.GetDataById(.Item("id")).Rows(0).Item("margen")
                        Dim dt As DataRow
                        dt = tblcambios.NewRow
                        dt("id") = .Item("id")
                        dt("ub") = .Item("id_uc")
                        dt("descripcion") = .Item("descripcion")
                        dt("margen") = margen
                        dt("actual") = .Item("ud_costo_base") / .Item("factor")
                        dt("nuevo") = .Item("ud_Costo") / .Item("factor")
                        tblcambios.Rows.Add(dt)
                    End If
                End With
            Next
            dgvcambio.DataSource = tblcambios
            dgvcambio.Visible = True
            dgv.Visible = False
        Else
            dgvcambio.Visible = False
            dgv.Visible = True
        End If

    End Sub 'Muestra la tabla

    Private Sub checar_cambios()
        Dim msg, fe As String
        mytable.AcceptChanges()
        For j As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows(j).Cells("Comentarios").Value = ""
            If dgv.Rows(j).Cells("ud_costo").Value > dgv.Rows(j).Cells("ud_costo_base").Value Then
                dgv.Rows(j).DefaultCellStyle.ForeColor = Color.Red
                msg = "Cambio de " + Format(dgv.Rows(j).Cells("ud_costo_base").Value, "N2") + " a " + Format(dgv.Rows(j).Cells("ud_costo").Value, "N2")
                dgv.Rows(j).Cells("Comentarios").Value = msg
            End If

            If dgv.Rows(j).Cells("caduca").Value = True Then
                If Not IsDate(dgv.Rows(j).Cells("caducidad").Value) Then
                    msg = "Teclee la feha de caducidad para :" + chr10 + dgv.Rows(j).Cells("Descripcion").Value
                    fe = InputBox(msg, "Teclee la fecha de caducidad para este producto")
                    If IsDate(fe) Then
                        dgv.Rows(j).Cells("caducidad").Value = fe
                    End If
                End If
            End If
        Next
    End Sub ' verifica cambios de precio.

    Private Sub fechaEntrada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaEntrada.ValueChanged
        Try
            If Val(diasc.Text) > 0 Then
                Me.fechavence.Value = fechaEntrada.Value.AddDays(diasc.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub 'Calcula Vencimiento

    Private Sub dgv_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved
        totaliza()
    End Sub ' totaliza si borra una row 

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgv.Columns("iva").Visible = True
        dgv.Columns("piva").Visible = True
        dgv.Columns("ud_iva10").Visible = True
        dgv.Columns("ud_iva15").Visible = True
    End Sub

    Private Sub boton_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_proveedor.Click
        Dim x As DialogResult
        x = My.Forms.buscar_provedor.ShowDialog()
        If x <> Windows.Forms.DialogResult.OK Then Exit Sub
        Me.id_provtxt.Text = gprov.id
        Me.nombreprovtxt.Text = gprov.nombre
        Me.diasc.Text = gprov.dias
        piva.Text = gprov.iva
        Me.comentariospv.Text = gprov.comentarios
    End Sub

    Private Sub boton_relacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_relacion.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.Entradas_relacion.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub id_provtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id_provtxt.KeyPress
        If e.KeyChar = chr13 Then
            cargar_provedor()
        End If
    End Sub
    Private Sub cargar_provedor()
        Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        Dim r As DataRow, id As Integer
        id = id_provtxt.Text : r = Nothing
        Try
            r = adap.GetDataByID(id, 1).Rows(0)
        Catch ex As Exception

            Me.nombreprovtxt.Text = ""
            Me.diasc.Text = "0"
            Me.piva.Text = ""
            Me.comentariospv.Text = ""
        End Try
        Try
            Me.nombreprovtxt.Text = r.Item("Nombre")
            Me.diasc.Text = r.Item("dias")
            Me.piva.Text = r.Item("iva")
        Catch ex As Exception

        End Try


        Try
            Me.comentariospv.Text = r.Item("comentarios")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub piva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piva.TextChanged
        Try
            If piva.Text = "15" Then mytable.Columns("piva").Expression = "iif (iva>0, 15,0)"
            If piva.Text = "10" Then mytable.Columns("piva").Expression = "iif (iva>0, 10,0)"
            If piva.Text = "16" Then mytable.Columns("piva").Expression = "iif (iva>0, 16,0)"
            If piva.Text = "11" Then mytable.Columns("piva").Expression = "iif (iva>0, 11,0)"
            If piva.Text = "0" Then mytable.Columns("piva").Expression = "iif (iva>0, 0,0)"
            mytable.AcceptChanges()
            dgv.Refresh()
            totaliza()
        Catch ex As Exception

        End Try

    End Sub 'cambio de Iva

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_save.Click
        Dim filename As String
        Me.SaveFileDialog.ShowDialog()
        filename = Me.SaveFileDialog.FileName
        '  mytable.WriteXmlSchema(filename)
        mytable.WriteXml(filename)
    End Sub ' Suspender Entrada

    Private Sub boton_abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_abrir.Click
        Dim filename As String
        Me.OpenFileDialog.ShowDialog()
        filename = Me.OpenFileDialog.FileName
        'mytable.ReadXmlSchema(filename)
        mytable.Clear()
        Try
            mytable.ReadXml(filename)
            mytable.AcceptChanges()
            dgv.DataSource = mytable
        Catch ex As Exception

        End Try
    End Sub 'cargar entrada suspendida

    Private Sub ToolStripButton2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        cargar_catalogo()
    End Sub 'cargar cqatalogo

    Private Sub buscartxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscartxt.TextChanged
        Dim f As String
        If buscartxt.TextLength > 0 Then
            f = "tienda like '%" + buscartxt.Text + "%' or nombre like '%" + buscartxt.Text + "%' or factura like '%" + buscartxt.Text + "%'"
            bs.Filter = f
        Else
            bs.Filter = ""
        End If

    End Sub 'filtrar

    Private Sub actualizar_costo(ByVal ID As Integer, ByVal costo As Decimal)
        Dim cmd As String
        cmd = "UPDATE [integra].[dbo].[Unidades_productos]  SET  [costo] = " + costo.ToString + "*[factor] WHERE id_producto= " + ID.ToString
        comando(cmd)
    End Sub 'Aactualiza los costos 

    Private Sub pedir_productos()
        Dim x As DialogResult, nr As Integer
        x = My.Forms.seleccion_multiple.ShowDialog : If x = Windows.Forms.DialogResult.Cancel Then Exit Sub
        nr = dgv.CurrentRow.Index
        'Try
        If productos.Length > 0 Then
            dgv.SuspendLayout()
            For j As Integer = 0 To productos.Length - 1
                '  My.Forms.Buscar_productos.ShowDialog()
                Dim u As Und
                u = sk_leer_UndCompra(productos(j).a1id)
                With mytable.Rows(nr)
                    .Item("id") = productos(j).a1id
                    .Item("Descripcion") = productos(j).a2descripcion.Trim(" ")
                    .Item("factor") = productos(j).a3factor
                    .Item("und") = productos(j).a4uc
                    .Item("ub_und") = productos(j).a5ub
                    .Item("iva") = productos(j).a6iva
                    .Item("ud_Costo") = u.a4_costo
                    .Item("codigo") = productos(j).a7codigo
                    .Item("id_uc") = u.a1_id
                    .Item("ud_Costo_base") = u.a4_costo
                    .Item("caduca") = productos(j).a9caducidad
                    .Item("pieps") = productos(j).ieps
                End With
                nr += 1
            Next j
            'mytable.AcceptChanges()
            'dgv.DataSource = mytable
        End If
        'Catch ex As Exception
        'End Try
        dgv.ResumeLayout()
    End Sub ' Pide un producto desde buscar productos

    Private Sub SeleccionarProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarProductosToolStripMenuItem.Click
        pedir_productos()
    End Sub

    Private Sub PromociónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromociónToolStripMenuItem.Click
        If dgv.CurrentRow.Cells("pdesc").Value = 1 Then
            dgv.CurrentRow.Cells("pdesc").Value = 0
            dgv.CurrentRow.Cells("comentarios").Value = ""
        Else
            dgv.CurrentRow.Cells("pdesc").Value = 1
            dgv.CurrentRow.Cells("comentarios").Value = "*** Promoción ***"
        End If
        mytable.AcceptChanges()
        totaliza()
    End Sub ' ´poner en promocion un producto

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        npedido = InputBox("N pedido", "", 5)
        cargar_pedido()
        recibiendo_pedido = True
        dgv.Columns("ped_cantidad").Visible = True
        Me.boton_validar_pedido.Visible = True
    End Sub 'Solicitar Numero de pedido

    Private Sub cargar_pedido()
        Dim pedido, pedidoe As String
        Dim cmd As String = "Select * from paths where id = 9" ' Directorio de pedidos
        Dim tblpath As DataTable = leer_tabla(cmd)
        Dim path As String = Trim(tblpath.Rows(0).Item(2))
        pedido = path + "Pedido_" + npedido.ToString + ".xml"
        pedidoe = path + "Pedido_e" + npedido.ToString + ".xml"
        Me.Text = "Pedido No. " + npedido.ToString + "( " + pedido + ")"

        '  dspedido.ReadXmlSchema(pedido)
        dspedido.ReadXml(pedido)
        ver_tabla.cargar(dspedido.Tables("pedido"))
        Dim adap As New admintegralDataSetTableAdapters.pedidosTableAdapter
        Try
            id_provtxt.Text = adap.Getpedido(npedido).Rows(0).Item("id_directorio").ToString
            adap.Dispose()
        Catch ex As Exception

        End Try
        cargar_provedor()
    End Sub ' lee el pedido

    Private Sub leer_producto(ByVal dt As DataRow)
        If recibiendo_pedido = True Then
            Try
                dgv.CurrentRow.Cells("ped_cantidad").Value = Enpedido(dt.Item("id_producto").ToString)
                dgv.CurrentRow.Cells("cantidad").Value = Enpedido(dt.Item("id_producto").ToString)
            Catch ex As Exception
            End Try
            If dgv.CurrentRow.Cells("ped_cantidad").Value = 0 Then
                Dim ix As MsgBoxResult = MsgBox("Quiere aceptar el producto aun que no esta en el pedido??", MsgBoxStyle.YesNo)
                If ix = MsgBoxResult.No Then Exit Sub
            End If
        End If

        Try
            producto.a1id = dt.Item("id_producto").ToString
            producto.a2descripcion = dt.Item("Descripcion").ToString.Trim(" ")
            producto.a3factor = dt.Item("factorc").ToString
            producto.a4uc = dt.Item("uc").ToString
            producto.a5ub = dt.Item("ub_und").ToString
            producto.a6iva = dt.Item("iva").ToString
            producto.a7codigo = dt.Item("codigo").ToString
            producto.a8costo = dt.Item("costoc")
            producto.ieps = dt.Item("ieps")

            dgv.CurrentRow.Cells("id").Value = producto.a1id
            dgv.CurrentRow.Cells("Descripcion").Value = producto.a2descripcion.Trim
            dgv.CurrentRow.Cells("factor").Value = producto.a3factor
            dgv.CurrentRow.Cells("und").Value = producto.a4uc
            dgv.CurrentRow.Cells("ud_costo").Value = producto.a8costo
            dgv.CurrentRow.Cells("ud_costo_base").Value = producto.a8costo
            dgv.CurrentRow.Cells("ub_und").Value = producto.a5ub
            dgv.CurrentRow.Cells("iva").Value = producto.a6iva
            dgv.CurrentRow.Cells("id_uc").Value = dt.Item("iduc")
            dgv.CurrentRow.Cells("caduca").Value = dt.Item("caducidad")
            dgv.CurrentRow.Cells("pieps").Value = dt.Item("ieps")

            mytable.AcceptChanges()
        Catch ex As Exception
            MsgBox("Error al leer producto")
            MsgBox(ex.Message)
        End Try

    End Sub ' extrae los datos del producto de un datarow

    Private Function Enpedido(ByVal id As Integer) As Integer
        Dim bs As New BindingSource
        bs.DataSource = dspedido.Tables("pedido")
        Dim ix As Integer = bs.Find("clave", id)
        If ix >= 0 Then
            bs.Position = ix
            Enpedido = dspedido.Tables("pedido").Rows(ix)("pedido")
            Exit Function
        End If
        Enpedido = 0
        MsgBox("Este producto no esta en la orden de compra")

    End Function

    Private Sub validar_pedido()
        Dim r As Integer
        For r = 0 To dgv.Rows.Count - 1
            Try
                Dim ent, ped As Integer, msg As String
                ent = dgv.Rows(r).Cells("cantidad").Value
                ped = dgv.Rows(r).Cells("ped_cantidad").Value
                If ent = ped Then dgv.Rows(r).DefaultCellStyle.BackColor = Color.GreenYellow : Exit Sub
                If ent > ped Then
                    msg = "Se pidieron " + ped.ToString + ", LLegaron " + Str$(ent - ped) + " de Mas"
                    Dim dt As DataTable = DirectCast(ErrorProvider1.DataSource, DataTable)
                    dt.Rows(r).SetColumnError(0, msg)
                    'dgv.CurrentCell.ToolTipText = msg
                    'dgv.CurrentCell.Style.BackColor = Color.Red
                    dgv.Rows(r).DefaultCellStyle.BackColor = Color.Red
                    condiferencias = True
                Else
                    msg = "Se pidieron " + ped.ToString + ", LLegaron " + Str$(ped - ent) + " de Menos"
                    Dim dt As DataTable = DirectCast(ErrorProvider1.DataSource, DataTable)
                    dt.Rows(r).SetColumnError(0, msg)
                    'dgv.CurrentCell.ToolTipText = msg
                    'dgv.CurrentCell.Style.BackColor = Color.Yellow
                    dgv.Rows(r).DefaultCellStyle.BackColor = Color.Yellow
                    condiferencias = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Private Sub boton_validar_pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_validar_pedido.Click
        validar_pedido()
    End Sub

    Private Function validar_caducidad() As Boolean
        validar_caducidad = True : condiferencias = False
        Dim cant, ped As Integer
        mytable.AcceptChanges()
        For j As Integer = 0 To dgv.Rows.Count - 1
            With dgv.Rows(j)
                'Verifica si hay diferencias
                If recibiendo_pedido Then
                    cant = .Cells("ped_cantidad").Value
                    ped = .Cells("cantidad").Value
                    If cant <> ped Then condiferencias = True
                End If
                Try
                    If .Cells("caduca").Value = True Then
                        If Not IsDate(.Cells("caducidad").Value) Then
                            validar_caducidad = False
                            Exit Function
                        End If
                    End If
                Catch ex As Exception

                End Try

            End With
        Next
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ImprimirToolStripButton.Enabled = validar_caducidad()
    End Sub

    Private Sub fechafactura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechafactura.ValueChanged
        If fechafactura.Value > Now.Date Then
            fechafactura.Value = Now.Date
        End If
    End Sub


    Private Sub codigotxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigotxt.KeyPress
        Dim catadap As New admintegralDataSetTableAdapters.Lista_de_ventasTableAdapter
        Dim dr As DataRow = mytable.NewRow
        If e.KeyChar = chr13 Then
            For j As Integer = 0 To dgv.Rows.Count - 1
                If Val(dgv.Rows(j).Cells(0).Value.ToString) = 0 Then
                    dgv.CurrentCell = dgv.Rows(j).Cells(0) : j = dgv.Rows.Count - 1 : Exit For
                End If
            Next
            catbs.Filter = ""
            Dim ix As Integer = catbs.Find("codigo", codigotxt.Text)
            If ix >= 0 Then
                dgv.CurrentRow.Cells(0).Value = codigotxt.Text
                leer_producto(tabla_catalogo.Rows(ix)) 'despliega los datos en la row
                dgv.CurrentCell = dgv.CurrentRow.Cells("cantidad") 'eduardo modifico UBICA LA CELDA
                If tabla_catalogo.Rows(ix).Item("id_directorio") <> Me.id_provtxt.Text Then
                    dgv.CurrentRow.DefaultCellStyle.BackColor = Color.Red
                    dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.White
                Else
                    dgv.CurrentRow.DefaultCellStyle.BackColor = Color.White
                    dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.Black
                End If
            Else
                MsgBox("No se encuentra el producto en el catalogo de productos disponibles")
            End If
            totaliza()
            codigotxt.Text = ""
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        ver_tabla.Show()
    End Sub

    Private Sub dgvresumen_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvresumen.CellClick
        Dim tda As String = dgvresumen.CurrentRow.Cells(0).Value.ToString.Trim
        Dim f As String
        f = "tienda like '%" + tda + "%'"
        bs.Filter = f
    End Sub

    Private Sub dgventrada_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgventrada.DoubleClick
        Dim f As Integer, s As String
        Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        If dgventrada.CurrentRow.Index >= 0 Then
            With dgventrada.CurrentRow
                Me.AlmacenComboBox.SelectedValue = .Cells("almacen").Value
                Me.id_provtxt.Text = .Cells(3).Value
                Me.nombreprovtxt.Text = Trim(adap.GetDataByID(.Cells(3).Value, 1).Rows(0).Item("Nombre").ToString)
                Me.facturatxt.Text = .Cells(5).Value
                Me.fechaEntrada.Value = .Cells("fechafactura").Value
                Me.fechafactura.Value = .Cells("fechasurtido").Value
                Me.fechavence.Value = .Cells("vence").Value
                f = .Cells(1).Value
                s = .Cells(2).Value
                cargar_entrada_tienda(12, f, s)
                Me.SplitContainer0.Visible = True
                cjfolio = f : cjserie = s
                lblcaja.Visible = True
                totaliza()
            End With
        End If
    End Sub

    Private Sub diasc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diasc.TextChanged
        Me.acredito.Checked = False
        Try
            If Val(diasc.Text) > 0 Then
                Me.acredito.Checked = True
            End If
        Catch ex As Exception
            Me.acredito.Checked = False
        End Try

    End Sub

    Private Sub facturatxt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles facturatxt.Leave
        Dim existe As Integer = 0
        existe = leer_tabla("select * from cxp_facturas where id_directorio =" + Me.id_provtxt.Text + " and factura ='" + Me.facturatxt.Text + "' ").Rows.Count
        If existe > 0 Then
            MsgBox("Esta Factura ya existe en CXP")
        End If
    End Sub

    Private Sub totaltxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles totaltxt.TextChanged

    End Sub
End Class