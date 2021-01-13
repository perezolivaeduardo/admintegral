Public Class cxc_reasignar_recibo
    Dim tblfacturas As New DataTable
    Private Sub PagosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PagosBindingSource.EndEdit()
        Me.PagosTableAdapter.Update(Me.AdmintegralDataSet.Pagos)

    End Sub

    Private Sub cxc_reasignar_recibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Tbl_formasdepagoTableAdapter.FillBysincancelada(Me.AdmintegralDataSet.tbl_formasdepago)
        Me.AgentesTableAdapter.Fill(Me.AdmintegralDataSet.Agentes)

    End Sub

    Private Sub cargar_folio(ByVal folio As Long)
        Me.boton_modificar.Visible = False
        Try
            Me.PagosTableAdapter.FillByfolio(Me.AdmintegralDataSet.Pagos, folio)
            If Me.AdmintegralDataSet.Pagos.Rows.Count > 0 Then
                Dim id As Long = Me.AdmintegralDataSet.Pagos.Rows(0).Item(0)
                Me.Pagos_detalleTableAdapter.FillByidpago(Me.AdmintegralDataSet.pagos_detalle, id)
                Me.boton_modificar.Visible = True
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub foliotxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles foliotxt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            cargar_folio(Me.foliotxt.Text)
            foliotxt.SelectAll()
        End If
    End Sub

    Private Sub foliotxt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles foliotxt.Enter
        total.Visible = False
        dgvfacturas.Visible = False
        boton_modificar.Visible = False
        Me.Width = 568
        Me.DesktopLocation = New Point(100, 200)
        foliotxt.SelectAll()
    End Sub

    Private Sub cargar_facturas(ByVal id As Integer)
        tblfacturas.Clear()
        Dim da_facturas As New Data.SqlClient.SqlDataAdapter
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        ' Me.bsclientes.Filter = "s=1"
        Dim cmd As String
        cmd = "SELECT  dbo.cxc_saldos_x_factura.id_directorio as id,  dbo.cxc_saldos_x_factura.Nombre, dbo.cxc_saldos_x_factura.Folio, dbo.cxc_saldos_x_factura.serie as S, dbo.cxc_saldos_x_factura.fecha, " _
        & "dbo.cxc_saldos_x_factura.vence, dbo.cxc_saldos_x_factura.Importe, dbo.cxc_saldos_x_factura.Abonos, dbo.cxc_saldos_x_factura.Saldo,0.00 as Abono " _
        & "FROM dbo.cxc_saldos_x_factura where "
        Dim mifiltro As String = ""
        mifiltro += " dbo.cxc_saldos_x_factura.id_directorio = " + id.ToString
        cmd = cmd + mifiltro + "order by vence"
        da_facturas = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        da_facturas.Fill(tblfacturas)
        dgvfacturas.DataSource = tblfacturas


        Me.dgvfacturas.Columns(0).Visible = False
        Me.dgvfacturas.Columns(1).Visible = False

        For j As Integer = 0 To Me.dgvfacturas.Columns.Count - 2
            Me.dgvfacturas.Columns(j).ReadOnly = True
            If j > 5 Then
                Me.dgvfacturas.Columns(j).DefaultCellStyle.Format = "N2"
                Me.dgvfacturas.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
            Me.dgvfacturas.Columns("Abono").DefaultCellStyle.BackColor = Color.Coral
            Me.dgvfacturas.Columns("Abono").DefaultCellStyle.Format = "N2"
            Me.dgvfacturas.Columns("abono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgvfacturas.Columns("abono").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        dgvfacturas.Visible = True
        total.Visible = True
        Me.Width = 872
    End Sub

    Private Sub boton_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_modificar.Click
        Dim x1 As usuario = autoriza_funcion(6) ' Modificar pagos
        If x1.id = 0 Then MsgBox("No Autorizado") : Exit Sub
        cargar_facturas(Me.Id_directorioTextBox.Text)
    End Sub

    Private Sub total_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.VisibleChanged
        Me.Boton_aplicar.Visible = total.Visible
    End Sub

    Private Sub dgvfacturas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfacturas.CellEndEdit
        tblfacturas.AcceptChanges()
        Dim im As Decimal = Me.ImporteTextBox.Text

        total.Text = Format(tblfacturas.Compute("sum(abono)", ""), "N2")
        Dim imp As Decimal = total.Text
        If imp > im Then
            MsgBox("La suma debe de dar " + Format(im, "N2"))
        End If
        If im = imp Then Me.Boton_aplicar.Visible = True Else Me.Boton_aplicar.Visible = False
        Try
            dgvfacturas.CurrentCell = dgvfacturas.CurrentRow.Cells(9)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvfacturas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvfacturas.CellValidating
        With dgvfacturas
            Try
                If .CurrentRow.Cells(9).Value > .CurrentRow.Cells(8).Value Then
                    Dim x As MsgBoxResult = MsgBox("Exede al saldo, quiere aplicar?", MsgBoxStyle.YesNo, "Exede el saldo")
                    If x = MsgBoxResult.No Then
                        .CurrentRow.Cells(9).Value = 0 : e.Cancel = True
                    Else
                    End If
                    total.Text = Format(tblfacturas.Compute("sum(abono)", ""), "N2")
                End If
            Catch ex As Exception

            End Try
        End With

    End Sub

    Private Sub Boton_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_aplicar.Click
        Dim id As Long = Me.Id_pagoTextBox.Text
        'Borra detalle del pago segun su ID
        Dim adap As New admintegralDataSetTableAdapters.pagos_detalleTableAdapter
        adap.DeletebyID(id, Me.CajaTextBox.Text)
        Dim im As Decimal, folio As Long, serie As String
        With dgvfacturas
            For j As Integer = 0 To .Rows.Count - 1
                im = .Rows(j).Cells("abono").Value
                If im > 0 Then
                    folio = .Rows(j).Cells("folio").Value
                    serie = .Rows(j).Cells("s").Value
                    Try
                        adap.Insert(id, 6, folio, serie, im, My.Settings.ncaja)
                    Catch ex As Exception
                        MsgBox("No se grabo bien el abono, intente de nuevo")
                    End Try
                End If
            Next
        End With
        Me.foliotxt.Focus()
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
End Class