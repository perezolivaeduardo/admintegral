Public Class cxc_liquidaciones
    Dim bsclientes As New BindingSource
    Dim bsfacturas As New BindingSource
    Dim bsagente As New BindingSource
    Dim dsfac As New DataSet("Auxiliar")
    Dim tblsaldos As DataTable = dsfac.Tables.Add("tblsaldos")
    Dim tblfacturas As DataTable = dsfac.Tables.Add("tblfacturas")
    Dim tabla_pago As New DataTable
    Dim info_caja As Integer = My.Settings.ncaja
    Dim dschof As New DataSet("pagos")
    Dim tablachofer As DataTable = dschof.Tables.Add("tablachofer")
    Dim tblcobranza As New DataTable

    Private Sub cxc_liquidaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.tbl_formasdepago' Puede moverla o quitarla según sea necesario.
        Me.Tbl_formasdepagoTableAdapter.Fill(Me.AdmintegralDataSet.tbl_formasdepago)

        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Agentes' Puede moverla o quitarla según sea necesario.
        Me.AgentesTableAdapter.Fill(Me.AdmintegralDataSet.Agentes)
        Me.id_agente.Text = Me.NombreComboBox.SelectedValue
        bsagente.DataSource = Me.AdmintegralDataSet.Agentes

        Dim column As DataColumn
        column = New DataColumn("Id", System.Type.GetType("System.Int32"))
        column.Caption = "Id" : column.AllowDBNull = True
        column.Unique = False : tabla_pago.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("fp", System.Type.GetType("System.Int32"))
        column.Caption = "FP" : column.AllowDBNull = False
        column.Unique = False : tabla_pago.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("importe", System.Type.GetType("System.Decimal"))
        column.Caption = "importe"
        column.Unique = False : tabla_pago.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Saldo", System.Type.GetType("System.Decimal"))
        column.Caption = "Saldo"
        column.Unique = False : tabla_pago.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Abono", System.Type.GetType("System.Decimal"))
        column.Caption = "Abono"
        column.Unique = False : tabla_pago.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        crear_grid_chofer()
        dgvchofer.DataSource = tablachofer
        For j As Integer = 3 To 5
            With dgvchofer.Columns(j)
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
            End With
        Next

    End Sub ' Carga Forma

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        id_agente.Text = Me.NombreComboBox.SelectedValue
    End Sub

    Private Sub boton_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Ok.Click
        grupo.Visible = True
        preparar_cobranza()
    End Sub 'desencadena carga de clientes y facturas del agente seleccionado

    Private Sub preparar_cobranza()
        Me.SplitContainer1.Panel2Collapsed = False
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer2.Panel1Collapsed = False
        Me.SplitContainer4.Panel1Collapsed = False
        Me.SplitContainer4.Panel2Collapsed = True
        grupo.Visible = True
        If id_agente.TextLength = 0 Then Exit Sub
        tblsaldos.Clear()
        tblfacturas.Clear()
        cargar(id_agente.Text, 1)
    End Sub

    Private Sub dgvClientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        If Me.dgvClientes.CurrentCell.ColumnIndex = 0 Then
            Me.SplitContainer3.Panel2Collapsed = False
            Me.SplitContainer2.Panel1Collapsed = True
            Me.pgidcliente.Text = Me.dgvClientes.CurrentRow.Cells("id").Value.ToString
            Me.pgcliente.Text = Me.dgvClientes.CurrentRow.Cells("Nombre").Value.ToString
            saldo.Text = Format(Me.dgvClientes.CurrentRow.Cells("saldo").Value, "N2")
            Me.pgboleta.Text = siguiente_boleta(Me.id_agente.Text)
            Dim ok As Boolean = validar_boleta(Me.pgboleta.Text, Me.id_agente.Text)
            If ok = False Then pgboleta.Text = "" : Beep() : MsgBox("Cambie el numero de Boleta")
            Me.cargar_facturas_cliente(pgidcliente.Text) '<<<======
            Me.DescripcionComboBox.SelectedIndex = 1
            Me.pgforma.Focus()
        End If
    End Sub 'Selecciona un cliente para registrar Pago

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        Try
            bsfacturas.Filter = "id =" + Me.dgvClientes.CurrentRow.Cells("id").Value.ToString
        Catch ex As Exception
        End Try
    End Sub ' Selecciona cliente por combobox

    Private Sub cargar(ByVal agente As Integer, ByVal tipo As Integer)
        'Carga los clientes del agente
        Dim agentecliente As Integer
        Dim da_saldos As New Data.SqlClient.SqlDataAdapter
        Dim da_cobranza As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        Dim da_folio As New Data.SqlClient.SqlDataAdapter
        Dim cmd, cmdcobranza As String
        If tipo = 1 Then
            cmd = "SELECT Id_directorio as ID,Nombre,saldo,id_agente from cxc_saldos where saldo>0 and id_agente = " + agente.ToString
        Else
            cmd = "SELECT Id_directorio as ID,Nombre,saldo,id_agente from cxc_saldos where saldo>0 and id_directorio = " + agente.ToString
        End If
        cmdcobranza = "select * from tmp_pagos where agente=" + agente.ToString
        da_cobranza = New Data.SqlClient.SqlDataAdapter(cmdcobranza, cs)
        da_cobranza.SelectCommand.CommandTimeout = 3000
        da_saldos = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_saldos.SelectCommand.CommandTimeout = 3000
        'carga cobranza de chavos
        da_cobranza.Fill(tblcobranza)
        Combocobranza.Visible = False
        If tblcobranza.Rows.Count > 0 Then
            Combocobranza.Items.Clear()
            For j As Integer = 0 To tblcobranza.Rows.Count - 1
                Combocobranza.Items.Add(tblcobranza.Rows(j).Item("folio"))
            Next
            Combocobranza.Visible = True
        End If
        da_saldos.Fill(dsfac.Tables("tblsaldos"))
        bsclientes.DataSource = dsfac.Tables("tblsaldos")
        bsclientes.Filter = "nombre like '9999'"
        Me.dgvClientes.DataSource = bsclientes

        Me.bsclientes.Filter = ""
        Me.dgvClientes.Columns("saldo").DefaultCellStyle.Format = "N2"
        Me.dgvClientes.Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvClientes.Columns("id_agente").Visible = False

        If tipo <> 1 Then cargar_facturas()

        If Me.dgvClientes.Rows.Count = 0 Then Me.SplitContainer1.Panel2Collapsed = True : Exit Sub
        If tipo = 2 Then
            Try
                Me.SplitContainer3.Panel2Collapsed = False
                Me.SplitContainer2.Panel1Collapsed = True
                Me.pgidcliente.Text = Me.dgvClientes.Rows(0).Cells("id").Value.ToString
                Me.pgcliente.Text = Me.dgvClientes.Rows(0).Cells("Nombre").Value.ToString
                saldo.Text = Format(Me.dgvClientes.Rows(0).Cells("saldo").Value, "N2")
                agentecliente = Me.dgvClientes.Rows(0).Cells("id_agente").Value.ToString
                Me.pgboleta.Text = siguiente_boleta(Me.id_agente.Text)
                Dim ix1 As Integer = Me.bsagente.Find("id_agente", agentecliente)
                bsagente.Position = ix1
                Me.idagentecliente.Text = agentecliente.ToString
                Me.agentecliente.Text = AdmintegralDataSet.Agentes.Rows(ix1).Item("nombre")
                Me.idagentecliente.Visible = True
                Me.agentecliente.Visible = True
                lblagente.Visible = True
                Me.pgforma.Focus()
            Catch ex As Exception

            End Try
        Else
            lblagente.Visible = False
            Me.idagentecliente.Visible = False
            Me.agentecliente.Visible = False
        End If

    End Sub 'Carga Los clientes por agente

    Private Sub cargar_facturas_cliente(ByVal id As Integer)
        If Me.dgvClientes.Rows.Count = 0 Then Exit Sub
        Dim da_facturas As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        ' Me.bsclientes.Filter = "s=1"
        Dim cmd As String
        cmd = "SELECT  dbo.cxc_saldos_x_factura.id_directorio as id,  dbo.cxc_saldos_x_factura.Nombre, dbo.cxc_saldos_x_factura.Folio, dbo.cxc_saldos_x_factura.serie, dbo.cxc_saldos_x_factura.fecha, " _
        & "dbo.cxc_saldos_x_factura.vence, dbo.cxc_saldos_x_factura.Importe, dbo.cxc_saldos_x_factura.Abonos, dbo.cxc_saldos_x_factura.Saldo,0.00 as Abono,dbo.cxc_saldos_x_factura.dias " _
        & "FROM dbo.cxc_saldos_x_factura where  "
        Dim mifiltro As String = ""
        If chkvencidas.Checked = True Then
            mifiltro = "(dbo.cxc_saldos_x_factura.Saldo>0 and  dbo.cxc_saldos_x_factura.vence < " + Format(Now.Date, "d") + ") and "
        Else
            mifiltro = "(dbo.cxc_saldos_x_factura.Saldo>0) and "
        End If

        mifiltro += " dbo.cxc_saldos_x_factura.id_directorio = " + id.ToString

        cmd = cmd + mifiltro + "order by Nombre,vence,folio"
        tblfacturas.Clear()
        da_facturas = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_facturas.SelectCommand.CommandTimeout = 3000
        da_facturas.Fill(dsfac.Tables("tblfacturas"))
        bsfacturas.DataSource = tblfacturas
        dgvfacturas.DataSource = bsfacturas

        Me.dgvfacturas.Columns(0).Visible = False
        Me.dgvfacturas.Columns(1).Visible = False

        For j As Integer = 0 To Me.dgvfacturas.Columns.Count - 1
            Me.dgvfacturas.Columns(j).ReadOnly = True
            If j > 5 Then
                Me.dgvfacturas.Columns(j).DefaultCellStyle.Format = "N2"
                Me.dgvfacturas.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
            Me.dgvfacturas.Columns("Abono").DefaultCellStyle.BackColor = Color.CornflowerBlue
            Me.dgvfacturas.Columns("Abono").DefaultCellStyle.Format = "N2"
            Me.dgvfacturas.Columns("abono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next
        Me.dgvfacturas.Columns("abono").ReadOnly = False
        For j As Integer = 1 To Me.dgvClientes.Columns.Count - 1
            Me.dgvClientes.Columns(j).ReadOnly = True
        Next
        califica()
    End Sub 'Cargar las facturas de todos los cliente

    Private Sub cargar_facturas()
        If Me.dgvClientes.Rows.Count = 0 Then Exit Sub
        Dim da_facturas As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        ' Me.bsclientes.Filter = "s=1"
        Dim cmd As String
        cmd = "SELECT  dbo.cxc_saldos_x_factura.id_directorio as id,  dbo.cxc_saldos_x_factura.Nombre, dbo.cxc_saldos_x_factura.Folio, dbo.cxc_saldos_x_factura.serie, dbo.cxc_saldos_x_factura.fecha, " _
        & "dbo.cxc_saldos_x_factura.vence, dbo.cxc_saldos_x_factura.Importe, dbo.cxc_saldos_x_factura.Abonos, dbo.cxc_saldos_x_factura.Saldo,0.00 as Abono,dbo.cxc_saldos_x_factura.dias " _
        & "FROM dbo.cxc_saldos_x_factura where  "
        Dim mifiltro As String = ""
        If chkvencidas.Checked = True Then
            mifiltro = "(dbo.cxc_saldos_x_factura.Saldo>0 and  dbo.cxc_saldos_x_factura.vence < " + Format(Now.Date, "d") + ") and "
        Else
            mifiltro = "(dbo.cxc_saldos_x_factura.Saldo>0) and "
        End If
        For j As Integer = 0 To Me.dgvClientes.Rows.Count - 1
            If j > 0 Then mifiltro += " or "
            mifiltro += " dbo.cxc_saldos_x_factura.id_directorio = " + Me.dgvClientes.Rows(j).Cells("id").Value.ToString
        Next j
        cmd = cmd + mifiltro + "order by Nombre,vence"
        da_facturas = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_facturas.SelectCommand.CommandTimeout = 3000
        da_facturas.Fill(dsfac.Tables("tblfacturas"))
        bsfacturas.DataSource = tblfacturas
        dgvfacturas.DataSource = bsfacturas

        Me.dgvfacturas.Columns(0).Visible = False
        Me.dgvfacturas.Columns(1).Visible = False

        For j As Integer = 0 To Me.dgvfacturas.Columns.Count - 1
            Me.dgvfacturas.Columns(j).ReadOnly = True
            If j > 5 Then
                Me.dgvfacturas.Columns(j).DefaultCellStyle.Format = "N2"
                Me.dgvfacturas.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
            Me.dgvfacturas.Columns("Abono").DefaultCellStyle.BackColor = Color.CornflowerBlue
            Me.dgvfacturas.Columns("Abono").DefaultCellStyle.Format = "N2"
            Me.dgvfacturas.Columns("abono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next
        Me.dgvfacturas.Columns("abono").ReadOnly = False

        For j As Integer = 1 To Me.dgvClientes.Columns.Count - 1
            Me.dgvClientes.Columns(j).ReadOnly = True
        Next
        califica()
    End Sub 'Cargar las facturas de todos los cliente

    Private Sub califica()
        Dim dias As Integer
        For j As Integer = 0 To dgvfacturas.Rows.Count - 1
            dgvfacturas.Rows(j).DefaultCellStyle.BackColor = Color.Yellow
            dias = dgvfacturas.Rows(j).Cells("dias").Value
            If dgvfacturas.Rows(j).Cells("saldo").Value > 0 Then
                If dias > 15 Then
                    dgvfacturas.Rows(j).DefaultCellStyle.BackColor = Color.Pink
                Else
                    If dias < 0 Then
                        dgvfacturas.Rows(j).DefaultCellStyle.BackColor = Color.GreenYellow
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub NombreComboBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.Enter, id_agente.Enter, Button1.Enter, boton_un_cliente.Enter, boton_Ok.Enter
        Me.SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub boton_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_reporte.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.cxc_reportes.Show()
        My.Forms.cxc_reportes.id.Text = id_agente.Text
        My.Forms.cxc_reportes.fecha.Value = Me.fecha.Value.Date
        My.Forms.cxc_reportes.cargar_reporte(Me.id_agente.Text, Me.fecha.Value.Date, Me.fecha.Value.Date)
        My.Forms.cxc_reportes.WindowState = FormWindowState.Maximized
        My.Forms.cxc_reportes.Show()
        My.Forms.cxc_reportes.Focus()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
    End Sub ' LLama y carga forma de reporte de cobrranza


    Private Sub dgvfacturas_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfacturas.CellEndEdit, dgvfacturas.CellValueChanged
        tblfacturas.AcceptChanges()
        'dgvfacturas.Columns(
        aplicadotxt.Text = Format(tblfacturas.Compute("sum(abono)", ""), "N2")
        dgvfacturas.CurrentCell = dgvfacturas.CurrentRow.Cells("abono")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.ReportViewer.Visible = True Then
            Me.ReportViewer.Visible = False
            Me.SplitContainer1.Visible = True
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.SplitContainer3.SplitterDistance = Me.pgboleta.Text
    End Sub

    Private Sub Boton_salir_boleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_salir_boleta.Click
        salir_boleta()
    End Sub

    Private Sub salir_boleta()
        With dgvfacturas
            For j As Integer = 0 To .Rows.Count - 1
                .Rows(j).Cells("abono").Value = 0
            Next j
        End With
        Me.pgidcliente.Text = ""
        Me.pgcliente.Text = ""
        Me.pgboleta.Text = ""
        Me.pgimporte.Text = ""
        Me.pgdocumento.Text = ""
        Me.pgreferencia.Text = ""
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer2.Panel1Collapsed = False
        Me.SplitContainer2.Panel2Collapsed = True
        filtrocliente.Text = "" : filtrocliente.Focus()
        Me.DescripcionComboBox.SelectedIndex = 1
    End Sub 'rutina para salir Boleta

    Private Sub Boton_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_aplicar.Click
        aplicar_abono()
    End Sub
    Private Sub aplicar_abono()
        Dim im As Decimal
        Try
            im = Me.pgimporte.Text
        Catch ex As Exception
            im = 0
        End Try
        If im = 0 Then Exit Sub
        Dim r As Integer = Me.dgvfacturas.Rows.Count - 1, cr As Integer = 0
        With Me.dgvfacturas
            While cr <= r
                Dim s As Double = .Rows(cr).Cells("saldo").Value
                If im > s Then
                    im -= s : .Rows(cr).Cells("abono").Value = s
                Else
                    .Rows(cr).Cells("abono").Value = im : im = 0
                End If
                cr += 1
            End While
        End With
        Me.boton_guardar.Enabled = True
    End Sub

    Private Sub pgimporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pgimporte.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            aplicar_abono()
        End If
    End Sub

    Private Sub aplicadotxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aplicadotxt.TextChanged
        If pgimporte.Text <> aplicadotxt.Text Then
            pgimporte.Text = Format(CDbl(aplicadotxt.Text), "N2")
        End If
        If CDbl(aplicadotxt.Text) > 0 Then
            Me.boton_guardar.Enabled = True
        Else
            Me.boton_guardar.Enabled = False
        End If
    End Sub

    Private Sub guardar_boleta()
        Dim apago As New admintegralDataSetTableAdapters.PagosTableAdapter
        Dim dr1 As DataRow = tabla_pago.NewRow
        Try
            Dim nidp As Integer = apago.nuevo_id(My.Settings.ncaja)            ' Obtienen el nuevo ID del pago
            apago.Insert(nidp, info_caja, user.id, Me.pgboleta.Text, Me.id_agente.Text, Me.pgfecha.Value.Date, Me.pgidcliente.Text, 2, Me.pgforma.Text, Me.pgreferencia.Text, Me.pgimporte.Text, True, Me.pgdocumento.Text, Me.pgvence.Value.Date)
            dr1(0) = nidp
            apago.Connection.Close()
        Catch ex As Exception
            MsgBox("No se guardo pago")
            MsgBox(ex.Message)
        End Try

        Dim p As pago_detalle, im As Double
        Dim adap1 As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter
        With dgvfacturas
            For j As Integer = 0 To .Rows.Count - 1
                im = .Rows(j).Cells("abono").Value
                If im > 0 Then
                    p.id = dr1(0)
                    p.td = 6
                    p.folio = .Rows(j).Cells("folio").Value
                    p.serie = .Rows(j).Cells("serie").Value
                    p.importe = .Rows(j).Cells("abono").Value
                    Try
                        adap1.Insert(p.id, p.td, p.folio, p.serie, im, My.Settings.ncaja)
                        adap1.Dispose()
                        .Rows(j).Cells("abono").Value = 0
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox("Error al Guardar Detalle de pago")
                    End Try
                End If
            Next
        End With
    End Sub ' ******************+   guardar pagos ***************

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        guardar_boleta()
        pgvence.Value = pgfecha.Value
        salir_boleta()
    End Sub

    Private Sub filtrocliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrocliente.TextChanged
        Dim filtro, idt As String
        idt = "0"
        If Val(filtrocliente.Text) > 0 Then idt = filtrocliente.Text

        If filtrocliente.TextLength > 0 Then
            filtro = "nombre like '%" + filtrocliente.Text + "%' or id = " + idt
            Me.bsclientes.Filter = filtro
        Else
            Me.bsclientes.Filter = ""
        End If
    End Sub 'Filtro por nombre de cliente

    Private Sub boton_cambiar_boleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cambiar_boleta.Click
        Dim nueva_boleta As Long
        nueva_boleta = InputBox("Teclee el numero Inicial de Recibo", "Nuevo Block", "")
        Dim ok As Boolean = validar_boleta(nueva_boleta, Me.id_agente.Text)
        If ok = False Then
            Dim x As MsgBoxResult
            x = MsgBox("Este folio no ha sido asignado a este agente, Debe de asignarlo primero, quiere hacerlo en este momento", MsgBoxStyle.YesNo, "Boock no asignado")
            If x = MsgBoxResult.Yes Then
                If nueva_boleta Mod 50 = 1 Then
                    ok = asignar_bloc(Me.id_agente.Text, nueva_boleta)
                    If ok = True Then
                        pgboleta.Text = nueva_boleta.ToString
                    Else
                        MsgBox("No se pudo asignar ese numero")
                        nueva_boleta = ""
                        Exit Sub
                    End If
                Else
                    Dim ini As Long, msg As String
                    ini = (x - (x Mod 50)) + 1
                    msg = ini.ToString + "-" + Str(ini + 49)
                    MsgBox("Solicite que se asigne el bloc con serie " + msg)
                    Try
                        nueva_boleta = ""
                    Catch ex As Exception

                    End Try

                    Exit Sub
                End If
            End If
        Else
            pgboleta.Text = nueva_boleta.ToString
        End If
    End Sub 'Cambiar boleta de cobro

    Private Sub id_agente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id_agente.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim ix As Integer = Me.AgentesBindingSource.Find("id_agente", id_agente.Text)
            If ix < 0 Then
                MsgBox("No Existe este agente")
                Me.AgentesBindingSource.Position = 0
            Else
                Me.AgentesBindingSource.Position = ix
                preparar_cobranza()
                filtrocliente.Focus()
            End If
        End If
    End Sub 'buscar agente por ID

    Private Sub boton_un_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_un_cliente.Click
        My.Forms.Buscar_clientes.ShowDialog()
        If My.Forms.Buscar_clientes.DialogResult = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Me.SplitContainer1.Panel2Collapsed = False
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer2.Panel1Collapsed = False
        Me.SplitContainer4.Panel1Collapsed = False
        Me.SplitContainer4.Panel2Collapsed = True

        If id_agente.TextLength = 0 Then Exit Sub
        tblsaldos.Clear()
        tblfacturas.Clear()
        cargar(id_cliente, 2)
        grupo.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_cancelar.Click
        Dim x As MsgBoxResult
        x = MsgBox("Quiere Cancelar el folio " + pgboleta.Text + "?", MsgBoxStyle.YesNo, "Cancelar Recibo")
        If x = MsgBoxResult.No Then Exit Sub

        Dim apago As New admintegralDataSetTableAdapters.PagosTableAdapter
        Try
            Dim nidp As Integer = apago.nuevo_id(My.Settings.ncaja) 'obtiene id
            apago.Insert(nidp, info_caja, user.id, Me.pgboleta.Text, Me.id_agente.Text, Me.pgfecha.Value.Date, 0, 2, 0, "Cancelado", 0, True, "", Me.pgvence.Value.Date)
            MsgBox(pgboleta.Text + " - Cancelada!")
            Me.pgboleta.Text = siguiente_boleta(Me.id_agente.Text)
        Catch ex As Exception
            MsgBox("No se guardo pago")
        End Try
    End Sub ' Cancelar Boleta

    Private Sub boton_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_borrar.Click
        Dim x As Integer = InputBox("Teclee el numero de recibo que quiere Borrar (Solo puede borrar del Dia) ", "Borrar Recibos", "")
        If x < 1 Then Exit Sub
        Dim adap As New admintegralDataSetTableAdapters.PagosTableAdapter
        Dim dr As DataRow
        Try
            dr = adap.GetDataByfolio(x).Rows(0)
        Catch ex As Exception
            MsgBox("No Existe")
            Exit Sub
        End Try

        If dr("fecha") <> Today.Date Then
            MsgBox("No se puede borrar pagos de otras fechas")
            Exit Sub
        End If
        Dim cmd As String = "Select * From agentes where id_agente =" + dr("agente").ToString
        Dim nagente
        Try
            Dim tb As DataTable = leer_tabla(cmd)
            nagente = tb.Rows(0).Item("nombre").ToString
        Catch ex As Exception
            MsgBox("No se encuentra el Agente!!")
            nagente = "No se pudo Definir"
        End Try
        Dim x1 As MsgBoxResult, msg As String
        msg = chr10 + "Recibo :" + x.ToString + chr13 + chr10 + "Agente : " + nagente + chr13 + chr10 + "Importe : " + Format(dr("importe"), "N2") + chr13 + chr10
        x1 = MsgBox("Seguro que quiere borrar  " + msg, MsgBoxStyle.YesNo, "Confirmar Borrar")
        If x1 = MsgBoxResult.Yes Then
            Try
                adap.Borra_pago(dr(0), dr("caja"))
                MsgBox("Recibo borrado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        My.Forms.cxc_reasignar_recibo.ShowDialog()
    End Sub

    Private Sub pgforma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pgforma.TextChanged
        Dim fp As Integer = pgforma.Text
        If fp = 3 Then
            pgvence.Enabled = True
            pgdocumento.Enabled = True
            pgreferencia.Enabled = True
            pgdocumento.Focus()
            Exit Sub
        Else
            pgvence.Enabled = False
            pgdocumento.Enabled = False
            pgreferencia.Enabled = False
            pgdocumento.Text = ""
            pgreferencia.Text = ""
        End If
        pgimporte.Focus()
    End Sub

    Private Sub pgdocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pgdocumento.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            pgreferencia.Focus()
        End If
    End Sub

    Private Sub pgreferencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pgreferencia.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            pgimporte.Focus()
        End If
    End Sub

    Private Sub DescripcionComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionComboBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim fp As Integer = pgforma.Text
            If fp = 3 Then
                pgdocumento.Focus()
            Else
                pgvence.Value = pgfecha.Value
                pgimporte.Focus()
            End If
        End If
    End Sub

    Private Sub pgfecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pgfecha.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            pgvence.Focus()
        End If
    End Sub

    Private Sub pgvence_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pgvence.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            pgimporte.Focus()
        End If
    End Sub

    Private Sub dgvfacturas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfacturas.CellClick
        If e.ColumnIndex = 8 Then
            With dgvfacturas.CurrentRow
                If .Cells(9).Value = .Cells(8).Value Then
                    .Cells(9).Value = 0
                Else
                    .Cells(9).Value = .Cells(8).Value
                End If
            End With
            tblfacturas.AcceptChanges()
            aplicadotxt.Text = Format(tblfacturas.Compute("sum(abono)", ""), "N2")
            dgvfacturas.CurrentCell = dgvfacturas.CurrentRow.Cells("abono")
        End If
    End Sub

    Private Sub folio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dfolio.KeyPress
        Dim serie As String, f As String, dt As DataRow
        If e.KeyChar = chr13 Then
            serie = Mid(dfolio.Text, 1, 1)
            f = Mid(dfolio.Text, 2)
            dt = leer_saldo(6, f, serie)
            Try
                dcliente.Text = dt.Item("nombre")
                dfecha.Text = dt.Item("fecha")
                dimporte.Text = Format(dt.Item("importe"), "N2")
                dsaldo.Text = Format(dt.Item("saldo"), "N2")
                abono.Text = Format(dt.Item("saldo"), "N2")
                If dt.Item("saldo") = 0 Then Beep() : MsgBox("No tiene saldo esta factura") : Exit Sub
                abono.Focus()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.SplitContainer1.Panel2Collapsed = False
        Me.SplitContainer2.Panel1Collapsed = True
        Me.SplitContainer2.Panel2Collapsed = False
        Me.SplitContainer3.Panel1Collapsed = False
        Me.SplitContainer3.Panel2Collapsed = False
        Me.SplitContainer4.Panel1Collapsed = True
        Me.SplitContainer4.Panel2Collapsed = False
        Me.pgboleta.Text = siguiente_boleta(Me.id_agente.Text)
        grupo.Visible = False
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.SplitContainer2.Panel1Collapsed = True
        Me.SplitContainer2.Panel2Collapsed = False
        Me.SplitContainer3.Panel1Collapsed = False
        Me.SplitContainer3.Panel2Collapsed = False
        Me.SplitContainer4.Panel1Collapsed = False
        Me.SplitContainer4.Panel2Collapsed = True
    End Sub

    Private Sub crear_grid_chofer()
        Dim column As New DataColumn

        column = New DataColumn("Folio", System.Type.GetType("System.String"))
        column.Caption = "Folio" : column.AllowDBNull = False : column.ReadOnly = True
        column.Unique = False : tablachofer.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Serie", System.Type.GetType("System.String"))
        column.Caption = "Serie" : column.AllowDBNull = False
        column.Unique = False : tablachofer.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Fecha", System.Type.GetType("System.String"))
        column.ReadOnly = True : column.Caption = "Fecha" : column.AllowDBNull = False
        column.Unique = False : tablachofer.Columns.Add(column)   ' Add the Column to the DataColumnCollection.


        column = New DataColumn("Importe", System.Type.GetType("System.Decimal"))
        column.Caption = "Importe" : column.DefaultValue = 0
        column.ReadOnly = True : column.ReadOnly = True
        column.Unique = False : tablachofer.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Saldo", System.Type.GetType("System.Decimal"))
        column.Caption = "Saldo" : column.DefaultValue = 0 : column.ReadOnly = True
        column.Unique = False : tablachofer.Columns.Add(column)   ' Add the Column to the DataColumnCollection.

        column = New DataColumn("Abono", System.Type.GetType("System.Decimal"))
        column.Caption = "Abono" : column.DefaultValue = 0 : column.ReadOnly = False
        column.Unique = False : tablachofer.Columns.Add(column)   ' Add the Column to the DataColumnCollection.


    End Sub

    Private Sub abono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles abono.KeyPress
        If e.KeyChar = chr13 Then
            agregar_row_chofer()
            Me.dcliente.Text = ""
            Me.dfecha.Text = ""
            Me.dimporte.Text = ""
            Me.dsaldo.Text = ""
            Me.abono.Text = ""
            Me.dfolio.Text = ""
            dfolio.Focus()
        End If
    End Sub

    Private Sub agregar_row_chofer()
        Dim dt As DataRow = tablachofer.NewRow
        Dim serie, f As String
        serie = Mid(dfolio.Text, 1, 1)
        f = Mid(dfolio.Text, 2)
        dt(0) = f
        dt(1) = serie
        dt(2) = Me.dfecha.Text
        dt(3) = Me.dimporte.Text
        dt(4) = Me.dsaldo.Text
        dt(5) = Me.abono.Text
        tablachofer.Rows.Add(dt)
        tablachofer.AcceptChanges()
        Dim t As Double
        t = tablachofer.Compute("sum(abono)", "")
        Me.pgimporte.Text = Format(t, "N2")

    End Sub

    Private Sub guardar_chofer()
        Dim apago As New admintegralDataSetTableAdapters.PagosTableAdapter
        Dim dr1 As DataRow = tabla_pago.NewRow
        Try
            Dim nidp As Integer = apago.nuevo_id(My.Settings.ncaja) ' Obtienen el nuevo ID del pago
            apago.Insert(nidp, info_caja, user.id, Me.pgboleta.Text, Me.id_agente.Text, Me.pgfecha.Value.Date, 0, 2, Me.pgforma.Text, Me.pgreferencia.Text, Me.pgimporte.Text, True, Me.pgdocumento.Text, Me.pgvence.Value.Date)
            dr1(0) = nidp
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("No se guardo pago")
            Exit Sub
        End Try

        Dim p As pago_detalle, im As Double
        Dim adap1 As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter
        With dgvchofer
            For j As Integer = 0 To .Rows.Count - 1
                im = .Rows(j).Cells("abono").Value
                If im > 0 Then
                    p.id = dr1(0)
                    p.td = 6
                    p.folio = .Rows(j).Cells("folio").Value
                    p.serie = .Rows(j).Cells("serie").Value
                    p.importe = .Rows(j).Cells("abono").Value
                    Try
                        adap1.Insert(p.id, p.td, p.folio, p.serie, im, My.Settings.ncaja)
                        adap1.Dispose()
                        .Rows(j).Cells("abono").Value = 0
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox("Error al Guardar Detalle de pago")
                    End Try
                End If
            Next
        End With
    End Sub

    Private Sub dgvchofer_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvchofer.CellValueChanged
        tablachofer.AcceptChanges()
        Dim t As Double
        t = tablachofer.Compute("sum(abono)", "")
        Me.pgimporte.Text = Format(t, "N2")
    End Sub

    Private Sub boton_reinicia_chofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_reinicia_chofer.Click
        tablachofer.Clear()
        dgvchofer.Refresh()
        Dim t As Double
        Try
            t = tablachofer.Compute("sum(abono)", "")
            Me.pgimporte.Text = Format(t, "N2")
        Catch ex As Exception
            Me.pgimporte.Text = "0.00"
        End Try

    End Sub

    Private Sub boton_guarda_chofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guarda_chofer.Click
        Dim x As MsgBoxResult = MsgBox("Guardar Recibo", MsgBoxStyle.YesNo, "Guardar")
        If x = MsgBoxResult.Yes Then
            guardar_chofer()
            Me.pgboleta.Text = siguiente_boleta(Me.id_agente.Text)
            Me.pgidcliente.Text = ""
            Me.pgcliente.Text = ""
            Me.pgimporte.Text = ""
            Me.pgdocumento.Text = ""
            Me.pgreferencia.Text = ""

            tablachofer.Clear()
            dgvchofer.Refresh()
            Dim t As Double
            Try
                t = tablachofer.Compute("sum(abono)", "")
                Me.pgimporte.Text = Format(t, "N2")
            Catch ex As Exception
                Me.pgimporte.Text = "0.00"
            End Try
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Try
            My.Forms.cxc_info.info(Me.pgidcliente.Text, True)
            My.Forms.cxc_info.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub filtrocliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles filtrocliente.KeyPress
        If e.KeyChar = chr13 Then
            If dgvClientes.Rows.Count = 1 Then
                Me.SplitContainer3.Panel2Collapsed = False
                Me.SplitContainer2.Panel1Collapsed = True
                Me.pgidcliente.Text = Me.dgvClientes.CurrentRow.Cells("id").Value.ToString
                Me.pgcliente.Text = Me.dgvClientes.CurrentRow.Cells("Nombre").Value.ToString
                saldo.Text = Format(Me.dgvClientes.CurrentRow.Cells("saldo").Value, "N2")
                Me.pgboleta.Text = siguiente_boleta(Me.id_agente.Text)
                Me.cargar_facturas_cliente(pgidcliente.Text) '<<<======
                Me.pgforma.Focus()
            End If
        End If
    End Sub

    Private Sub pgvence_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pgvence.ValueChanged
        If pgvence.Value < pgfecha.Value Then
            MsgBox("la fecha no puede ser menor")
            pgvence.Value = pgfecha.Value
            Exit Sub
        End If
        If DateDiff(DateInterval.Day, pgfecha.Value, pgvence.Value) > cia.dias_posfechado Then
            MsgBox("No puede ser mayor a " + cia.dias_posfechado.ToString + " Dias de posfechado")
            pgvence.Value = pgfecha.Value.AddDays(cia.dias_posfechado)
        End If
    End Sub

    Private Sub Combocobranza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combocobranza.SelectedIndexChanged
        Dim filtro As String
        filtro = "id = " + tblcobranza.Rows(Combocobranza.SelectedIndex.ToString).Item("idcliente").ToString
        Me.bsclientes.Filter = filtro
        Me.boton_carga_cobranza.Visible = True
    End Sub

    Private Sub boton_carga_cobranza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_carga_cobranza.Click
        Dim rw As Integer = Me.Combocobranza.SelectedIndex
        Me.SplitContainer3.Panel2Collapsed = False
        Me.SplitContainer2.Panel1Collapsed = True
        Me.pgidcliente.Text = Me.dgvClientes.CurrentRow.Cells("id").Value.ToString
        Me.pgcliente.Text = Me.dgvClientes.CurrentRow.Cells("Nombre").Value.ToString
        saldo.Text = Format(Me.dgvClientes.CurrentRow.Cells("saldo").Value, "N2")
        ' Me.pgboleta.Text = siguiente_boleta(Me.id_agente.Text)
        Me.cargar_facturas_cliente(pgidcliente.Text) '<<<======

        With tblcobranza.Rows(rw)
            Me.Tbl_formasdepagoBindingSource.Position = Me.Tbl_formasdepagoBindingSource.Find("id_fp", .Item("fp"))
            pgdocumento.Text = .Item("banco")
            pgreferencia.Text = .Item("referencia")
            pgimporte.Text = .Item("importe")
            pgboleta.Text = .Item("folio")
        End With
        Me.pgforma.Focus()
    End Sub


    Private Sub Boton_saltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_saltar.Click
        Dim x As MsgBoxResult
        x = MsgBox("Quiere Saltar el folio " + pgboleta.Text + "?", MsgBoxStyle.YesNo, "Saltar Recibo")
        If x = MsgBoxResult.No Then Exit Sub
        Dim apago As New admintegralDataSetTableAdapters.PagosTableAdapter
        Try
            Dim nidp As Integer = apago.nuevo_id(My.Settings.ncaja)
            apago.Insert(nidp, info_caja, user.id, Me.pgboleta.Text, Me.id_agente.Text, Me.pgfecha.Value.Date, 0, 2, 9, "Ocupado", 0, True, "", Me.pgvence.Value.Date)
            MsgBox(pgboleta.Text + " - Ocupado!")
            Me.pgboleta.Text = siguiente_boleta(Me.id_agente.Text)
        Catch ex As Exception
            MsgBox("No se guardo pago")
        End Try
    End Sub

    Private Sub pgboleta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pgboleta.TextChanged
        If pgboleta.TextLength = 0 Then Exit Sub
        Dim cmd As String = "SELECT     COUNT(folio) AS cantidad FROM dbo.Pagos WHERE folio = " + pgboleta.Text
        Dim tb As DataTable = leer_tabla(cmd)
        If tb.Rows(0).Item(0) > 0 Then
            MsgBox("Ya existen Registros con ese Folio") : Beep()
            pgboleta.BackColor = Color.Red
        Else
            pgboleta.BackColor = Color.CornflowerBlue
        End If
    End Sub
End Class