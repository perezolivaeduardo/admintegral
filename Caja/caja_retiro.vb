Public Class caja_retiro
    Dim cmd As String, tbl As New DataTable, tbl1 As New DataTable
    Dim DA As New Data.SqlClient.SqlDataAdapter
    Dim ancho_ticket As Integer = 36
    Dim tblmonedas As New DataTable
    Dim dm As New Data.SqlClient.SqlDataAdapter

    Private Sub caja_retiro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub caja_retiro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.Dispose()
        caja.Show()
    End Sub

    Private Sub caja_retiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim x1 As usuario = autoriza_funcion(4)
        If x1.id = 0 Then Me.Close() : Exit Sub
        cajatxt.Text = My.Settings.ncaja.ToString
        Usern.Text = x1.nombre
        userid.Text = x1.id
        Dim cs As String = My.Settings.AdmintegralConnectionString.ToString
        cmd = "SELECT caja,folio, fecha, importe ,vales,dolares as Dll, id_usuario "
        cmd += "FROM tbl_retiros "
        cmd += "WHERE (CONVERT(varchar, fecha, 3) = '" + Format(Date.Now, "dd/MM/yy") + "') AND caja = " + cajatxt.Text
        DA = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(DA)
        DA.Fill(tbl)

        Dim da1 As New Data.SqlClient.SqlDataAdapter
        cmd = "SELECT MAX(ISNULL(folio, 0))+1 AS folio FROM tbl_retiros where caja = " + My.Settings.ncaja.ToString
        cmd += " GROUP BY caja"
        da1 = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder1 As New Data.SqlClient.SqlCommandBuilder(da1)
        da1.Fill(tbl1)

        Try
            folio.Text = tbl1.Rows(0).Item(0).ToString
        Catch ex As Exception
            folio.Text = "1"
        End Try



        'tblmonedas.Reset()
        cmd = "Select * From tbl_monedas"
        dm = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        dm.Fill(tblmonedas)

        ' and add to DataTable.    
        Dim column = New DataColumn()
        column.DataType = System.Type.GetType("System.Double")
        column.ColumnName = "Importe"
        column.Caption = "Importe"
        column.Expression = "denominacion * cantidad"
        column.DefaultValue = 0
        Try
            tblmonedas.Columns.Add(column)
        Catch ex As Exception

        End Try

        dgvmoneda.DataSource = tblmonedas
        With Me.dgvmoneda
            .AutoResizeColumns()
            .Columns(0).HeaderText = "Denom."
            .Columns(0).DefaultCellStyle.Format = "N"
            .Columns(1).DefaultCellStyle.Format = "N"
            .Columns(2).DefaultCellStyle.Format = "N"
            .Columns(0).ReadOnly = True
            .Columns(2).ReadOnly = True
            Me.dgvmoneda.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Me.dgvmoneda.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Me.dgvmoneda.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        End With
        Try
            dgvmoneda.CurrentCell = dgvmoneda.Rows(0).Cells("cantidad")
        Catch ex As Exception
        End Try


    End Sub

    Private Sub Boton_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_aceptar.Click
        Dim i1, i2 As Single
        i1 = Importe.Text
        i2 = InputBox("Teclee de nuevo el importe que va a retirar", "")
        Try
            If i1 <> i2 Then MsgBox("No coinciden, Intente e Nuevo") : Exit Sub

        Catch ex As Exception
            MsgBox("Debe de teclear la misma catnitdad")
        End Try

        Dim dr As DataRow
        dr = tbl.NewRow
        dr(0) = cajatxt.Text
        dr(1) = folio.Text
        dr(2) = Date.Now
        dr(3) = Importe.Text
        dr(4) = TextBox2.Text 'vales
        dr(5) = TextBox1.Text 'dolares
        dr(6) = userid.Text
        tbl.Rows.Add(dr)
        DA.Update(tbl)
        encabezado("c:\tmp\retiro.txt", "RETIRO DE EFECTIVO", ancho_ticket)
        Dim f As New System.IO.StreamWriter("c:\tmp\retiro.txt", True)
        f.WriteLine(" ")
        Dim fo As String = "FOLIO :" + folio.Text
        f.WriteLine(fo.PadLeft(38))
        f.WriteLine("Tienda :" + cia.tienda.ToString + " Cj.:" + My.Settings.ncaja.ToString)
        f.WriteLine("Fecha: " + Format(Now.Date, "d") + " Hora : " + Format(Now, "t"))
        f.WriteLine("Cajero: " + user.nombre)
       
        f.WriteLine("")
        f.WriteLine("Recibi la cantidad de " + Format(CDbl(Importe.Text), "N0"))
        f.WriteLine("De la siguiente manera:")
        f.WriteLine("")
        For J As Integer = 0 To tblmonedas.Rows.Count - 1
            With tblmonedas.Rows(J)
                If .Item("cantidad") > 0 Then
                    Dim c1, c2, c3 As String
                    c1 = Format(.Item(0), "###,###").PadLeft(8)
                    c2 = Format(.Item(1), "###,###").PadLeft(8)
                    c3 = Format(.Item(2), "###,###").PadLeft(8)
                    f.WriteLine(c1 + c2 + c3)
                End If
            End With
        Next
        Dim t As String
        f.WriteLine("--------------------------")
        t = "Total:".PadRight(10) + Importe.Text.PadLeft(14)
        f.WriteLine(t)
        If TextBox2.Text > 0 Then
            Try
                t = "Vales:".PadRight(10) + Format(Val(TextBox2.Text), "###,###").PadLeft(14)
                f.WriteLine(t)
                Dim st As Single = CDbl(Importe.Text) + CDbl(TextBox2.Text)
                f.WriteLine("--------------------------")
                t = "Total :".PadRight(10) + Format(st, "###,###").PadLeft(14)
                f.WriteLine(t)
            Catch ex As Exception
            End Try
        End If
        If TextBox1.Text > 0 Then
            Try
                t = "Dolares:".PadRight(10) + Format(Val(TextBox2.Text), "###,###").PadLeft(14)
                f.WriteLine(t)
            Catch ex As Exception

            End Try

        End If
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("---------------------------")
        f.WriteLine(Usern.Text)
        f.WriteLine("Recibi")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.WriteLine("")
        f.Close()
        Dim x As MsgBoxResult
        While x <> MsgBoxResult.Yes And x <> MsgBoxResult.Cancel
            Imprimir.SendFileToPrinter(My.Settings.impresora_ticket, "c:\tmp\retiro.txt")
            x = MsgBox("Se imprimio bien el Recibo", MsgBoxStyle.YesNoCancel, "Impresion")
        End While
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_checar.Click
        Dim dgv As New DataGridView
        If Panel1.Visible = False Then
            Panel1.Visible = True
            dgv.Visible = False
        Else

            dgv.Parent = Me.SplitContainer1.Panel1
            dgv.Dock = DockStyle.Fill
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            dgv.DataSource = tbl
            Panel1.Visible = False
            With dgv
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .AutoResizeColumns()
                .Columns(0).Visible = False
                .Columns(2).DefaultCellStyle.Format = "t"
                .Columns(2).HeaderText = "Hora"
                For j As Integer = 3 To 5
                    .Columns(j).DefaultCellStyle.Format = "N0"
                    .Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            End With
        End If


    End Sub

    Private Sub Boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_salir.Click
        Me.Close()
    End Sub

    Private Sub Importe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Importe.TextChanged
        validar()
    End Sub
    Private Sub validar()
        Me.Boton_aceptar.Enabled = False
        Try
            If Val(Importe.Text) > 0 Or Val(Me.TextBox1.Text) > 0 Or Val(Me.TextBox2.Text) > 0 Then
                Me.Boton_aceptar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub dgvmoneda_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmoneda.CellValueChanged
        Try
            If dgvmoneda.CurrentCell.ColumnIndex = 1 Then
                Me.tblmonedas.AcceptChanges()
                Dim cc As Double = tblmonedas.Compute("sum(Importe)", "")
                Importe.Text = Format(cc, "N0")
                dgvmoneda.CurrentCell = dgvmoneda.CurrentRow.Cells("cantidad")
            End If
Catch ex As Exception
        End Try

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = chr13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        TextBox2.SelectAll()
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        TextBox1.SelectAll()
    End Sub

    Private Sub dgvmoneda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmoneda.CellContentClick

    End Sub
End Class