Public Class Kardex_consultar
    Dim bs As New BindingSource
    Dim ds As New DataSet
    Dim tbl As DataTable = ds.Tables.Add("pedido")
    Dim bsventas As New BindingSource
    Dim bsvendedor As New BindingSource
    Dim dsventas As New DataSet("ventas")
    Dim tblvendedor As DataTable = dsventas.Tables.Add("tblvendedor")
    Dim tbldetalle As DataTable = dsventas.Tables.Add("tbldetalle")
    Dim tipo As Integer
    Dim pedido As String
    Dim pedidoe As String
    Dim pedidopdf As String
    Dim npedido As Integer
    Dim piedehoja As String
    Dim id_agente As Integer = 0


    Private Sub Kardex_consultar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Dim ix As MsgBoxResult = MsgBox("Quiere salir, sin guardar", MsgBoxStyle.YesNo)

    End Sub

    Private Sub Kardex_consultar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecha_al.Value = Date.Now
        fecha_del.Value = fecha_al.Value.AddDays(-30)
        Me.id_txt.Focus()
        'If user.id = 1 Then Me.boton_Exportar.Visible = True
        Me.WindowState = FormWindowState.Maximized
        Try
            Dim adap As New admintegralDataSetTableAdapters.pedidosTableAdapter
            npedido = adap.nuevo_folio.Value
        Catch ex As Exception
            npedido = 1
        End Try
        Dim cmd As String = "Select * from paths where id = 9" ' Directorio de pedidos
        Dim tblpath As DataTable = leer_tabla(cmd)
        Dim path As String = Trim(tblpath.Rows(0).Item(2))
        pedido = path + "Pedido_" + npedido.ToString + ".xml"
        pedidoe = path + "Pedido_e" + npedido.ToString + ".xml"
        pedidopdf = path + "Pedido_e" + npedido.ToString + ".pdf"
        Try
            piedehoja = My.Computer.FileSystem.ReadAllText(path + "piedehoja_pedidos.txt")
        Catch ex As Exception
        End Try
        Me.Text = "Pedido No. " + npedido.ToString + "( " + pedido + ")"

    End Sub

    Private Sub Kardex_consultar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim x As DialogResult
            x = My.Forms.buscar_provedor.ShowDialog()
            If x <> Windows.Forms.DialogResult.OK Then Exit Sub
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Windows.Forms.Cursor.Current = Cursors.Default
            Me.id_txt.Text = gprov.id
            Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
            Try
                Me.nombretxt.Text = adap.GetDataByID(id_txt.Text, 1).Rows(0).Item("Nombre")
                Me.ivapv.Text = adap.GetDataByID(id_txt.Text, 1).Rows(0).Item("iva")
                fecha_del.Focus()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub id_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id_txt.KeyPress
        'Calcula ventas del sistema 
        '==========================================================================
        If e.KeyChar = chr13 Then
            cargar_proveedor()
            If My.Settings.pedidos_calcular = CheckState.Checked Then
                Preparar_pedido()
                calcular_ventas()
                Me.AgendaTableAdapter.FillByprovedor(Me.ReporteDataSet.agenda, id_txt.Text)
                Me.Boton_preparar.Visible = False
                Dim cmd As String
                cmd = "select id_producto as id,id_grupo as gp,id_grupo_original as Gpo, descripcion from productos where  id_grupo = " + My.Settings.grupo_suspendidos + " and id_directorio = " + id_txt.Text
                Dim tb As DataTable = leer_tabla(cmd)
                If tb.Rows.Count > 0 Then
                    mostrar_desactivados.cargar(tb)
                    boton_inactivos.Enabled = True
                Else
                    boton_inactivos.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub cargar_proveedor()
        Me.ReportViewer.Visible = False
        Me.dgv.Visible = True
        Dim adap As New admintegralDataSetTableAdapters.DirectorioTableAdapter
        Try
            Me.nombretxt.Text = adap.GetDataByID(id_txt.Text, 1).Rows(0).Item("Nombre")
            Me.ivapv.Text = adap.GetDataByID(id_txt.Text, 1).Rows(0).Item("iva")
            fecha_del.Focus()
            Me.Boton_preparar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub combo_grupos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_grupos.SelectedIndexChanged

        If Me.chkgrupo.Checked = True Then
            Dim filtro As String = "Grupo = '" + combo_grupos.Text + "'"
            bs.Filter = filtro
            Me.Text = bs.Count.ToString
            If combo_grupos.Text.StartsWith("Suspend") Then
                Me.SuspenderArticuloToolStripMenuItem.Enabled = False
                Me.ReActivaArticuloToolStripMenuItem.Enabled = True
            Else
                Me.SuspenderArticuloToolStripMenuItem.Enabled = True
                Me.ReActivaArticuloToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkgrupo.CheckedChanged
        Me.combo_grupos.Visible = Me.chkgrupo.Checked
        If Me.chkgrupo.Checked = False Then
            bs.Filter = ""
            Me.Text = bs.Count.ToString
        Else
            Dim filtro As String = "Grupo = '" + combo_grupos.Text + "'"
            bs.Filter = filtro
            Me.Text = bs.Count.ToString
        End If
    End Sub

    Private Sub IdGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdGrupoToolStripMenuItem.Click
        My.Settings.id_grupo = Me.IdGrupoToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub GrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem.Click
        My.Settings.Grupo = Me.GrupoToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub PiezaXCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PiezaXCajaToolStripMenuItem.Click
        My.Settings.PZ_x_Caja = Me.PiezaXCajaToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub PiezaXExhibidorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PiezaXExhibidorToolStripMenuItem.Click
        My.Settings.Pz_X_Exhibidor = Me.PiezaXExhibidorToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub ExhibidoresXCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExhibidoresXCajaToolStripMenuItem.Click
        My.Settings.Exhi_x_caja = Me.ExhibidoresXCajaToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub CostoXPiezaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostoXPiezaToolStripMenuItem.Click
        My.Settings.Costo_x_pz = Me.CostoXPiezaToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub CostoXExhibidorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostoXExhibidorToolStripMenuItem.Click
        My.Settings.Costo_x_Exhi = Me.CostoXExhibidorToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub CostoXCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostoXCajaToolStripMenuItem.Click
        My.Settings.costo_x_caja = Me.CostoXCajaToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub define_columnas()

        dgv.Columns("iva").Visible = False

        For ii As Integer = 0 To 19 : dgv.Columns(ii).ReadOnly = True : Next ii
        dgv.Columns(6).HeaderText = "Piezas" + chr13 + "x" + chr13 + "Caja"
        dgv.Columns(7).HeaderText = "Piezas" + chr13 + "x" + chr13 + "Exhib."
        dgv.Columns(8).HeaderText = "Exhib." + chr13 + "x" + chr13 + "Caja"

        'costos
        dgv.Columns(9).HeaderText = "Costo" + chr13 + "x" + chr13 + "Pieza"
        dgv.Columns(10).HeaderText = "Costo" + chr13 + "x" + chr13 + "Exhib."
        dgv.Columns(11).HeaderText = "Costo" + chr13 + "x" + chr13 + "Caja"
        'Venta
        dgv.Columns(12).HeaderText = "P.Venta" + chr13 + "x" + chr13 + "Pieza"
        dgv.Columns(13).HeaderText = "P.Venta" + chr13 + "x" + chr13 + "Exhib."
        dgv.Columns(14).HeaderText = "P.Venta" + chr13 + "x" + chr13 + "Caja"

        dgv.Columns(15).HeaderText = "Pz's" + chr13 + "Vend."
        dgv.Columns(16).HeaderText = "Cajas" + chr13 + "Vend."


        dgv.Columns(17).HeaderText = "Exist." + chr13 + "Pz's."
        dgv.Columns(18).HeaderText = "Exist." + chr13 + "Cj's"

        dgv.Columns(21).HeaderText = "Costo" + chr13 + "Pedido"
        With dgv
            For j As Integer = 6 To 24
                .Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                If j > 8 And j <> 15 And j <> 17 Then
                    .Columns(j).DefaultCellStyle.Format = "N2"
                Else
                    .Columns(j).DefaultCellStyle.Format = "N0"
                End If
            Next
        End With

        '==========================================================================================
        With My.Settings
            Try
                dgv.Columns(0).Visible = .id_grupo
                dgv.Columns(1).Visible = .Grupo
                dgv.Columns(6).Visible = .PZ_x_Caja
                dgv.Columns(7).Visible = .Pz_X_Exhibidor
                dgv.Columns(8).Visible = .Exhi_x_caja
                'costo
                dgv.Columns(9).Visible = .Costo_x_pz
                dgv.Columns(10).Visible = .Costo_x_Exhi
                dgv.Columns(11).Visible = .costo_x_caja
                'venta
                dgv.Columns(12).Visible = .Pv_Pieza
                dgv.Columns(13).Visible = .pv_exhibidor
                dgv.Columns(14).Visible = .pv_caja
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub PorPiezaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorPiezaToolStripMenuItem.Click
        My.Settings.Pv_Pieza = Me.PorPiezaToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub PorexhibidorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorexhibidorToolStripMenuItem.Click
        My.Settings.pv_exhibidor = Me.PorexhibidorToolStripMenuItem.CheckState
        define_columnas()
    End Sub

    Private Sub PorCajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorCajaToolStripMenuItem1.Click
        My.Settings.pv_caja = Me.PorCajaToolStripMenuItem1.CheckState
        define_columnas()
    End Sub

    Private Sub GuardarDiseñoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarDiseñoToolStripMenuItem.Click
        My.Settings.Save()
    End Sub

    Private Sub MarcarColumnasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcarColumnasToolStripMenuItem.Click
        Dim mycolor As Color = Color.LightSteelBlue
        dgv.Columns(9).DefaultCellStyle.BackColor = mycolor
        dgv.Columns(10).DefaultCellStyle.BackColor = mycolor
        dgv.Columns(11).DefaultCellStyle.BackColor = mycolor

        dgv.Columns(15).DefaultCellStyle.BackColor = mycolor
        dgv.Columns(16).DefaultCellStyle.BackColor = mycolor
        dgv.Columns(17).DefaultCellStyle.BackColor = mycolor
    End Sub

    Private Sub calcular_ventas()

        Dim cmd As String
        cmd = "SELECT  proveedor,almacen,RTRIM(Grupo) as Grupo, id_agente, Agente,RTRIM(Descripcion) as Descripcion, SUM(ub_cantidad * natgrupo) AS Unidades,SUM(cantidad_und_conpra) as Cajas, SUM(ub_cantidad * natgrupo * Venta) AS Pesos "
        cmd = cmd + " FROM dbo.sql_kardex "
        cmd = cmd + " WHERE fecha >= CONVERT(DATETIME, '" + cfecha(Me.fecha_del.Value) + " 00:00:00', 102) AND fecha <= CONVERT(DATETIME, '" + cfecha(Me.fecha_al.Value) + " 00:00:00', 102) and "
        cmd = cmd + " id_directorio = " + Me.id_txt.Text + " AND (tipo_mov = N'Ventas') and ([id_grupos] <> " + My.Settings.grupo_suspendidos.ToString + ")  "
        cmd = cmd + " GROUP BY proveedor,almacen,id_agente, Agente, Descripcion, Grupo,Descripcion order by grupo,descripcion"
        tbldetalle = leer_tabla(cmd) : bsventas.DataSource = tbldetalle

        Me.dgventas.DataSource = tbldetalle
        Dim cmd1 As String
        cmd1 = "SELECT    proveedor,almacen, rtrim(Grupo) as Grupo, id_agente, Agente, SUM(ub_cantidad * natgrupo) AS Unidades,SUM(cantidad_und_conpra) as Cajas, SUM(ub_cantidad * natgrupo * Venta) AS Pesos "
        cmd1 = cmd1 + " FROM dbo.sql_kardex "
        cmd1 = cmd1 + " WHERE fecha>= CONVERT(DATETIME, '" + cfecha(Me.fecha_del.Value) + " 00:00:00', 102) AND fecha <= CONVERT(DATETIME, '" + cfecha(Me.fecha_al.Value) + " 00:00:00', 102) and "
        cmd1 = cmd1 + " id_directorio = " + Me.id_txt.Text + " AND (tipo_mov = N'Ventas') and ([id_grupos] <> " + My.Settings.grupo_suspendidos.ToString + ") "
        cmd1 = cmd1 + " GROUP BY proveedor,almacen,id_agente, Agente, Grupo"
        tblvendedor = leer_tabla(cmd1) : bsvendedor.DataSource = tblvendedor
        Me.dgvendedores.DataSource = tblvendedor
        Me.dgvendedores.Columns(0).Visible = False
        Me.dgventas.Columns(0).Visible = False

        cmd1 = "Select rtrim(dbo.sql_kardex.Grupo) as Grupo from dbo.sql_kardex  WHERE (dbo.sql_kardex.id_doc = 5 OR dbo.sql_kardex.id_doc = 6) and dbo.sql_kardex.id_directorio = " + Me.id_txt.Text
        cmd1 += " group by dbo.sql_kardex.Grupo "
        combogrupo.Items.Clear()
        combogrupo.Items.Add("Todos")
        Dim tblgp As DataTable = leer_tabla(cmd1)
        For j As Integer = 0 To tblgp.Rows.Count - 1
            combogrupo.Items.Add(tblgp.Rows(j).Item(0))
        Next
        Me.combogrupo.SelectedIndex = 0
        Me.combogrupo.Visible = True
        Me.dgvendedores.Columns("unidades").DefaultCellStyle.Format = "N0"
        Me.dgvendedores.Columns("Pesos").DefaultCellStyle.Format = "N2"
        Me.dgventas.Columns("unidades").DefaultCellStyle.Format = "N0"
        Me.dgventas.Columns("Pesos").DefaultCellStyle.Format = "N2"

        Me.dgvendedores.Columns("unidades").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvendedores.Columns("Pesos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgventas.Columns("unidades").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgventas.Columns("Pesos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Windows.Forms.Cursor.Current = Cursors.Default
        tipo = 0
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        calcular_ventas()

    End Sub

    Private Sub combogrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combogrupo.SelectedIndexChanged
        If tipo = 0 Then
            If combogrupo.SelectedIndex = 0 Then
                bsventas.Filter = ""
                Me.bsvendedor.Filter = ""
            Else
                bsventas.Filter = "Grupo = '" + Me.combogrupo.Text + "'"
                Me.bsvendedor.Filter = "Grupo = '" + Me.combogrupo.Text + "'"
            End If
        End If
    End Sub

  

    Private Sub dgvendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvendedores.Click
        Try
            Dim f As String
            If tipo = 1 Then
                f = "Agente = '" + Me.dgvendedores.CurrentRow.Cells("Agente").Value + "'"
                Me.bsventas.Filter = f
            Else
                If Me.combogrupo.SelectedIndex > 0 Then
                    f = "Agente = '" + Me.dgvendedores.CurrentRow.Cells("Agente").Value + "' and Grupo = '" + Me.combogrupo.Text + "'"
                Else
                    f = "Agente = '" + Me.dgvendedores.CurrentRow.Cells("Agente").Value + "'"
                End If
                Me.bsventas.Filter = f
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Exportar.Click
        Dim adap As New admintegralDataSetTableAdapters.pathsTableAdapter
        Dim path As String = Trim(adap.path(1))
        tbldetalle.TableName = "Detalle"
        tbldetalle.WriteXmlSchema("c:\tmp\ejemplo.xml")
        tbldetalle.WriteXml("c:\tmp\ejemplo.xml")
        System.Diagnostics.Process.Start(path + "\Resumen_Ventas_Proveedor_agente.xlsx")
    End Sub

    Private Sub Preparar_pedido()

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.Boton_preparar.Visible = False
        Dim cmd As String

        'calcula y genera 
        cmd = "DROP TABLE [dbo].[pz_vendidas]"
        comando(cmd)

        cmd = "SELECT movimientos.id_prodcuto, SUM(CASE WHEN ((dbo.movimientos.id_doc = 5 OR " _
            & " dbo.movimientos.id_doc = 6 OR dbo.movimientos.id_doc = 7) AND " _
            & " (dbo.movimientos.fecha >= CONVERT(DATETIME, '[del]', 102) AND " _
            & " dbo.movimientos.fecha <= CONVERT(DATETIME,'[al]', 102))) THEN dbo.movimientos.ub_cantidad * dbo.tbl_tipodoc.natgrupo ELSE 0 END) AS Pz_vendidas " _
            & " INTO pz_vendidas FROM tbl_Tipodoc INNER JOIN movimientos ON tbl_Tipodoc.td = movimientos.id_doc WHERE (movimientos.status = 0) AND (movimientos.fecha >= CONVERT(DATETIME, '2011-01-01 00:00:00', 102)) " _
            & " GROUP BY movimientos.id_prodcuto"
        cmd = cmd.Replace("[del]", cfecha(Me.fecha_del.Value))
        cmd = cmd.Replace("[al]", cfecha(Me.fecha_al.Value))

        comando(cmd)

        'actualiza cambo de grupo en catalogo general
        cmd = "UPDATE    catalogo_general set  GP = productos.id_Grupo FROM productos INNER JOIN catalogo_general ON productos.id_Producto = catalogo_general.clave"
        comando(cmd)

        Dim sqlperiodo As String
        sqlperiodo = " ((dbo.movimientos.id_doc = 5 OR dbo.movimientos.id_doc = 6 OR dbo.movimientos.id_doc = 7) AND (dbo.movimientos.fecha >= CONVERT(DATETIME, '" + cfecha(Me.fecha_del.Value) + "', 102) AND dbo.movimientos.fecha <= CONVERT(DATETIME, '" + cfecha(Me.fecha_al.Value) + "', 102))) "

        cmd = "SELECT  dbo.catalogo_general.GP, dbo.catalogo_general.Grupo as Grupo, dbo.catalogo_general.clave, dbo.catalogo_general.Codigo, " _
          & "RTRIM(dbo.catalogo_general.Descripcion) as Descripcion, dbo.catalogo_general.iva, dbo.catalogo_general.PzsXCJ, dbo.catalogo_general.PzsXExhib, " _
          & "dbo.catalogo_general.ExhibxCj, dbo.catalogo_general.Costo_pz, dbo.catalogo_general.Costo_Exhib, dbo.catalogo_general.Costo_CJ as [costo_pedido], " _
          & "dbo.catalogo_general.Pv_pz,dbo.catalogo_general.Pv_Exhib,  dbo.catalogo_general.Pv_Cj, " _
          & "sum(Pz_vendidas.Pz_vendidas) as Pz_vendidas " _
          & ", SUM(dbo.pz_vendidas.Pz_vendidas / dbo.catalogo_general.PzsXCJ) AS Cj_vendidas, " _
          & " MAX(dbo.existencias.Existencia) AS Exist_pz, MAX(dbo.existencias.Existencia / dbo.catalogo_general.PzsXCJ) AS Exist_cj, 0 AS Contado, " _
          & "0 AS Pedido, dbo.catalogo_general.Costo_CJ as Costo_Pedido,dbo.catalogo_general.subgrupo " _
          & " FROM  dbo.pz_vendidas RIGHT OUTER JOIN " _
          & " dbo.catalogo_general ON dbo.pz_vendidas.id_prodcuto = dbo.catalogo_general.clave LEFT OUTER JOIN dbo.existencias ON dbo.catalogo_general.clave = dbo.existencias.id_prodcuto " _
          & "WHERE (dbo.catalogo_general.id_prov = " + Me.id_txt.Text + ") and ([GP] <> " + My.Settings.grupo_suspendidos.ToString + ")  " _
          & " GROUP BY dbo.catalogo_general.GP, dbo.catalogo_general.Grupo,dbo.catalogo_general.subgrupo ,dbo.catalogo_general.clave, dbo.catalogo_general.Codigo, " _
          & "dbo.catalogo_general.Descripcion, dbo.catalogo_general.iva, dbo.catalogo_general.PzsXExhib, dbo.catalogo_general.ExhibxCj, " _
          & "dbo.catalogo_general.PzsXCJ, dbo.catalogo_general.Costo_pz, dbo.catalogo_general.Costo_Exhib, dbo.catalogo_general.Costo_CJ, " _
          & "dbo.catalogo_general.Pv_pz, dbo.catalogo_general.Pv_Exhib, dbo.catalogo_general.Pv_Cj Order by Grupo, dbo.catalogo_general.subgrupo,Descripcion "

        tbl = leer_tabla(cmd)
        bs.Filter = ""
        If ivapv.Text = "" Then ivapv.Text = "0"
        'agregar Logica a la tabla
        Dim column As DataColumn
        ' and add to DataTable.    
        column = New DataColumn("piva", System.Type.GetType("System.Int32"), "iif ( iva > 0 ," + ivapv.Text + ",0)")
        column.DefaultValue = 0
        tbl.Columns.Add(column)        ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Importe", System.Type.GetType("System.Decimal"), "Pedido * costo_pedido") 'IMPORTE
        column.Caption = "Importe" : column.ReadOnly = True
        tbl.Columns.Add(column)


        column = New DataColumn("imiva", System.Type.GetType("System.Decimal"), "Importe * (piva/100)") 'IMPORTE
        column.Caption = "IVA" : column.ReadOnly = True
        tbl.Columns.Add(column)

        bs.DataSource = tbl
        dgv.DataSource = bs.DataSource
        dgv.ReadOnly = False

        If tbl.Rows.Count > 0 Then
            Dim cmd1 As String = "Select dbo.sql_kardex.Grupo from dbo.sql_kardex  WHERE (dbo.sql_kardex.id_doc = 5 OR dbo.sql_kardex.id_doc = 6) and dbo.sql_kardex.id_directorio = " + Me.id_txt.Text
            cmd1 += " group by dbo.sql_kardex.Grupo "
            combo_grupos.Items.Clear()
            Dim tblgp As DataTable = leer_tabla(cmd1)
            For j As Integer = 0 To tblgp.Rows.Count - 1
                combo_grupos.Items.Add(tblgp.Rows(j).Item(0))
            Next
            Me.combo_grupos.SelectedIndex = 0
        End If
        define_columnas()
        Windows.Forms.Cursor.Current = Cursors.Default

    End Sub

    Private Sub Boton_imprimir_conteo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_imprimir_conteo.Click
        Me.dgv.Visible = False
        Me.ReportViewer.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.Visible = False
        Me.ReportViewer.Visible = True
        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        'pasa parametro al reporte
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        Dim peri As String = "Periodo del " + fecha_del.Value.ToShortDateString + " al " + Me.fecha_al.Value.ToShortDateString
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("proveedor", Me.id_txt.Text + "-" + Me.nombretxt.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("periodo", peri, False)
        Me.ReportViewer.LocalReport.SetParameters(rp)
        Me.ReportViewer.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tablapedido", bs.List)
        ReportViewer.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer.RefreshReport()
        Me.ReportViewer.Refresh()
        Me.ReportViewer.Visible = True
        Windows.Forms.Cursor.Current = Cursors.Default

    End Sub

    Private Sub boton_ver_grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ver_grid.Click
        Me.ReportViewer.Visible = False
        Me.ReportViewer1.Visible = False
        Me.dgv.Visible = True
        Exit Sub
    End Sub

    Private Sub boton_imprimir_pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_imprimir_pedido.Click
        Me.dgv.Visible = False
        Me.ReportViewer.Visible = False
        Me.ReportViewer1.Visible = True
        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        'pasa parametro al reporte
        Dim rp(0 To 3) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("proveedor", Me.nombretxt.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("pedido", npedido, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("agente", agente.Text, False)
        rp(3) = New Microsoft.Reporting.WinForms.ReportParameter("piedehoja", piedehoja.Trim, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Dim datasource = New Microsoft.Reporting.WinForms.ReportDataSource("tablapedido", tbl)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.Refresh()
        Me.ReportViewer1.Visible = True
        Windows.Forms.Cursor.Current = Cursors.Default


        Dim file1 As String = pedidopdf
        Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim deviceInfo As String
        Dim bytes As Byte()
        Dim lr As New Microsoft.Reporting.WinForms.LocalReport

        lr.ReportPath = "AdminTegral.pedido.rdlc"
        deviceInfo = "<DeviceInfo><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"
        bytes = ReportViewer1.LocalReport.Render("pdf", deviceInfo, mimeType, encoding, extension, streamids, warnings)

        Dim fs As New System.IO.FileStream(file1, System.IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
    End Sub

    Private Sub Boton_preparar_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_preparar.VisibleChanged
        Me.boton_ver_grid.Visible = Not Boton_preparar.Visible
        Me.Boton_imprimir_conteo.Visible = Not Boton_preparar.Visible
        Me.boton_imprimir_pedido.Visible = Not Boton_preparar.Visible
        Me.botonguarda.Visible = Not Boton_preparar.Visible
    End Sub

    Private Sub id_txt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_txt.Enter
        Me.Boton_preparar.Visible = True
    End Sub

    Private Sub dgv_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        tbl.AcceptChanges()
        Me.dgv.CurrentCell = dgv.CurrentRow.Cells("pedido")
        subtotal.Text = Format(tbl.Compute("sum(importe)", ""), "N2")
        iva.Text = Format(tbl.Compute("sum(imiva)", ""), "N2")
        total.Text = Format(tbl.Compute("sum(importe)+sum(imiva)", ""), "N2")
        tcajas.Text = tbl.Compute("sum(pedido)", "")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim x As Integer
        x = InputBox("Teclee el numero de Pedido que quiere leer", "", "")
        If x < 1 Then Exit Sub
        npedido = x
        Dim cmd As String = "Select * from paths where id = 9" ' Directorio de pedidos
        Dim tblpath As DataTable = leer_tabla(cmd)
        Dim path As String = Trim(tblpath.Rows(0).Item(2))
        pedido = path + "Pedido_" + x.ToString + ".xml"
        pedidoe = path + "Pedido_e" + x.ToString + ".xml"
        Me.Text = "Pedido No. " + x.ToString + "( " + pedido + ")"

        ds.ReadXmlSchema(pedido)
        ds.ReadXml(pedido)
        bs.DataSource = ds.Tables("pedido")
        dgv.DataSource = bs
        dgv.Refresh()
        define_columnas()
        Me.Boton_preparar.Visible = False
    End Sub

    Private Sub botonguarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonguarda.Click
        Dim ix As MsgBoxResult = MsgBox("Quiere guardar el Pedido?", MsgBoxStyle.YesNo, "")
        If ix = MsgBoxResult.Yes Then
            tbl.TableName = "pedido"
            tbl.WriteXmlSchema(pedido)
            tbl.WriteXml(pedido)
            Dim adap As New admintegralDataSetTableAdapters.pedidosTableAdapter
            adap.Insert(npedido, Me.id_txt.Text, Now.Date, agente.Text, False, 30, "", Me.ivapv.Text, 0, 0, 0, Me.total.Text)
        End If
        MsgBox("Pedido guardado")
        Me.Close()
    End Sub

    Private Sub RastrearProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RastrearProveedorToolStripMenuItem.Click
        My.Forms.Buscar_productos.ShowDialog()
        If producto.a9idprov > 0 Then
            Me.id_txt.Text = producto.a9idprov
            cargar_proveedor()
        End If
    End Sub

    Private Sub SuspenderArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspenderArticuloToolStripMenuItem.Click
        Dim gp, cv As Integer, cmd As String
        Dim ix As MsgBoxResult = MsgBox("Seguro que quiere suspender este producto", MsgBoxStyle.YesNo, "Suspender producto(s)")
        If ix = MsgBoxResult.Yes Then
            cmd = " UPDATE [integra].[dbo].[productos] SET [id_grupo_original] = [id_Grupo], [id_Grupo] = " + My.Settings.grupo_suspendidos.ToString
            'cmd += " WHERE id_producto = " + dgv.SelectedRow.Item(0).Cells("clave").Value.ToString
            cmd += " WHERE id_producto = " + dgv.Rows(dgv.SelectedCells.Item(0).RowIndex).Cells("clave").Value.ToString

            If dgv.SelectedRows.Count > 1 Then
                For j As Integer = 1 To dgv.SelectedCells.Count - 1
                    With dgv.Rows(dgv.SelectedCells.Item(j).RowIndex)
                        gp = .Cells("gp").Value
                        cv = .Cells("clave").Value
                        cmd += " or id_producto = " + cv.ToString
                    End With
                Next
            End If
            Actualiza_registros(cmd)
            For j As Integer = 0 To dgv.SelectedCells.Count - 1
                With dgv.Rows(dgv.SelectedCells.Item(j).RowIndex)
                    .Cells("GRUPO").Value = "Suspendido"
                End With
            Next
        End If
    End Sub 'Suspender un producto

    Private Sub ReActivaArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReActivaArticuloToolStripMenuItem.Click
        Dim gp, cv As Integer, cmd As String

        Dim ix As MsgBoxResult = MsgBox("Seguro que quiere Re-Activar estos productos", MsgBoxStyle.YesNo, "Activar Producto(s)")
        If ix = MsgBoxResult.Yes Then

            cmd = " UPDATE [integra].[dbo].[productos] SET [id_Grupo]=[id_grupo_original] , [id_grupo_original]=0 "
            ' cmd += " WHERE id_producto = " + dgv.SelectedRows.Item(0).Cells("clave").Value.ToString
            cmd += " WHERE id_producto = " + dgv.Rows(dgv.SelectedCells.Item(0).RowIndex).Cells("clave").Value.ToString

            If dgv.SelectedRows.Count > 1 Then
                For j As Integer = 1 To dgv.SelectedRows.Count - 1
                    With dgv.SelectedRows.Item(j)
                        gp = .Cells("gp").Value
                        cv = .Cells("clave").Value
                        cmd += " or id_producto = " + cv.ToString
                    End With
                Next
            End If
            Actualiza_registros(cmd)
            For j As Integer = 0 To dgv.SelectedRows.Count - 1
                With dgv.SelectedRows.Item(j)
                    gp = .Cells("GRUPO").Value = "Habilitado"
                End With
            Next
            MsgBox("los registros ya se han habilitado, ya los vera clasificados en su siguiente consulta")
        End If
    End Sub

    Private Sub VerEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerEntradasToolStripMenuItem.Click
        Dim id As Integer = dgv.SelectedRows.Item(0).Cells("clave").Value.ToString
        My.Forms.Kardex_resumen.caragr(id)
        My.Forms.Kardex_resumen.Show()
    End Sub

    Private Sub boton_captura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_captura.Click
        ReportViewer1.Visible = False
        Me.boton_captura.Checked = Not Me.boton_captura.Checked
        If Me.boton_captura.Checked = True Then
            For j As Integer = 7 To 19
                Try
                    dgv.Columns(j).Visible = False
                Catch ex As Exception

                End Try

            Next
            Me.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            Me.dgv.Columns("grupo").Visible = False
        Else
            define_columnas()

        End If
    End Sub

    Private Sub ToolStripButton3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim ix As MsgBoxResult = MsgBox("Quiere salir sin guardar el pedido?", MsgBoxStyle.YesNo, "Salir")
        If ix = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Public Sub preparar_pedido(ByVal pv As Integer, ByVal ag As Integer)
        id_txt.Text = pv : id_agente = ag
        If pv = 0 Then Exit Sub
        cargar_proveedor()
        Preparar_pedido()
        calcular_ventas()
        Me.Boton_preparar.Visible = False
        Try
            Me.AgendaTableAdapter.FillByprovedor(Me.ReporteDataSet.agenda, pv)
            Me.AgendaBindingSource.Position = Me.AgendaBindingSource.Find("numero", ag)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Boton_guardar_cambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_guardar_cambio.Click
        Me.Validate()
        Me.AgendaBindingSource.EndEdit()
        Me.AgendaTableAdapter.Update(Me.ReporteDataSet.agenda)
    End Sub

    Private Sub AgenteTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenteTextBox.TextChanged
        Me.agente.Text = Me.AgenteTextBox.Text
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        With dgv.CurrentRow
            Dim cv As Integer
            cv = .Cells("clave").Value
            My.Forms.Editar_producto.cargar(cv)
            My.Forms.Editar_producto.ShowDialog()
        End With

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub id_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_txt.TextChanged

    End Sub

    Private Sub boton_inactivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_inactivos.Click
        mostrar_desactivados.Text = "Acricilos inactivos de " + nombretxt.Text
        mostrar_desactivados.Show()
    End Sub


    Private Sub btn_preparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_preparar.Click
        crear_reporte(Me.id_txt.Text, fecha_del.Value, fecha_al.Value)
        Dim del, al, periodo As String
        al = Format(Date.Now, "dd-MM-yyyy")
        del = Format(Now.AddMonths(-1), "dd-MM-yyyy")
        periodo = "Periodo del " + del + " al " + al

        'TODO: esta línea de código carga datos en la tabla 'reporteDataSet.reporte_ventas_existencia' Puede moverla o quitarla según sea necesario.
        Me.reporte_ventas_existenciaTableAdapter.Fill(Me.ReporteDataSet.reporte_ventas_existencia)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", Me.nombretxt.Text, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("Periodo", periodo, False)
        Me.ReportViewer2.LocalReport.SetParameters(rp)
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class