Imports Microsoft.Win32

Public Class frm_cat_provedores
    Public tipo_catalogo As Integer
    Dim nuevo_id
    Dim es_nuevo As Boolean = False
    Private Sub DirectorioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectorioBindingNavigatorSaveItem.Click
        Me.Validate()
        Try
            Me.DirectorioBindingSource.EndEdit()
        Catch ex As Exception

        End Try

        Me.DirectorioTableAdapter.Update(Me.AdmintegralDataSet.Directorio)

        
    End Sub

    Private Sub frm_cat_provedores_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub frm_cat_provedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Listas' Puede moverla o quitarla según sea necesario.
        Me.ListasTableAdapter.Fill(Me.AdmintegralDataSet.Listas)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Agentes' Puede moverla o quitarla según sea necesario.
        Me.AgentesTableAdapter.Fill(Me.AdmintegralDataSet.Agentes)
        'TODO: esta línea de código carga datos en la tabla 'FeiDataset.fei_clientes' Puede moverla o quitarla según sea necesario.

        If tipo_catalogo = 1 Then
            Me.Text = "Catalogo de Proveedores"
            Me.Label1.Text = "Provedores"
            Me.DirectorioBindingSource.Filter = "id_directorio<40"
        End If
        If tipo_catalogo = 2 Then
            Me.Text = "Catalogo de Clientes"
            Me.Label1.Text = "Clientes"
            Me.DirectorioBindingSource.Filter = "id_directorio<40"
        End If

        Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)
        Me.DirectorioBindingSource.Filter = "tipo = " + tipo_catalogo.ToString
        Me.KeyPreview = False
    End Sub ' lee la forma 

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub ' boton add

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call guardar_nuevo()
        Me.Panel1.Visible = False
    End Sub 'Guardar NUevo

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DirectorioBindingSource.CancelEdit()
        Me.TabControl1.SelectedIndex = 0
        Me.Panel1.Visible = False
    End Sub 'Cancela nuevo

    Private Sub guardar_nuevo()
        If es_nuevo Then
            Me.User_alta.Text = user.id
            Me.fecha_alta.Value = Now
        End If

        Try
            Me.Validate()
            Me.DirectorioBindingSource.EndEdit()
            Me.DirectorioTableAdapter.Update(Me.AdmintegralDataSet.Directorio)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub 'Guardar

    Private Sub DirectorioDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DirectorioDataGridView.CellEndEdit
        Me.DirectorioBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub Boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_salir.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub TabControl1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TabControl1.KeyUp
        Me.DirectorioBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub filtro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles filtro.KeyPress
        If e.KeyChar = chr13 Then
            'Try
            If filtro.TextLength > 0 Then
                Dim f As String = "(Nombre like '%" + filtro.Text + "%'" + " or comercial like '%" + filtro.Text + "%' or direccion like '%" + filtro.Text + "%' or colonia like '%" + filtro.Text + "%') and id_directorio>1 and tipo = " + tipo_catalogo.ToString
                Me.DirectorioBindingSource.Filter = f
            Else

            End If
            ' Catch ex As Exception
            'Me.DirectorioBindingSource.Filter = "id_directorio <0"
            '  End Try
        End If
    End Sub

    Private Sub id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Dim x As Integer
            Try
                x = Me.DirectorioBindingSource.Find("id_directorio", id.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If x < 0 Then
                MsgBox("No existe!!")
            Else
                Me.DirectorioBindingSource.Position = x
            End If
            id.Text = ""
        End If

    End Sub

    Private Sub Id_agenteTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_agenteTextBox.TextChanged
        'suspendido.Visible = False
        'If Id_agenteTextBox.Text = "0" Then
        '    suspendido.Visible = True
        'End If
    End Sub 'Swich suspendido visible nvisible

    Private Sub frm_cat_provedores_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = chr13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TabControl1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.TabIndex = 0 Then
            Me.KeyPreview = False
        Else
            Me.KeyPreview = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Id_directorioTextBox.Text = nuevo_id
        Me.TipoTextBox.Text = Me.tipo_catalogo
    End Sub

    Private Sub RFCLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.RFCTextBox.Text = "XAXX010101000"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btp_crear_fei.Click
        'Dim feiadap As New feiDatasetTableAdapters.fei_clientesTableAdapter
        'If Me.RFCTextBox.TextLength < 12 Then MsgBox("Teclee un rfc valido") : Exit Sub
        'Try
        '    feiadap.Insert(Me.Id_directorioTextBox.Text, Me.RFCTextBox.Text, Me.NombreTextBox.Text, Me.DireccionTextBox.Text, NointeriorTextBox.Text, "", "", Me.ColoniaTextBox.Text, Me.CiudadTextBox.Text, "", Me.EdoTextBox.Text, "México", Me.CPTextBox.Text, Me.EmailTextBox.Text, MetodoTextBox.Text, CuentaTextBox.Text, "G03")
        'Catch ex As Exception

        'End Try

    End Sub

   
    Private Sub RFCTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RFCTextBox.TextChanged
        Me.RFCTextBox1.Text = Me.RFCTextBox.Text

    End Sub

    Private Sub NombreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreTextBox.TextChanged
        Me.NombreTextBox1.Text = Me.NombreTextBox.Text
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'Me.TabControl1.SelectedIndex = 1
        'Panel1.Visible = True
        'Dim cmd As String
        'cmd = "SELECT MAX(id_directorio)+1 AS ID FROM Directorio GROUP BY tipo HAVING(tipo = " + tipo_catalogo.ToString + ")"
        'Dim tb As New DataTable
        'tb = leer_tabla(cmd)
        'nuevo_id = tb.Rows(0).Item(0)
        'es_nuevo = True
        'Me.DirectorioBindingSource.AddNew()
        'Me.Id_directorioTextBox.Text = nuevo_id
        'Me.TipoTextBox.Text = tipo_catalogo
        'Me.NombreTextBox.Focus()
        Dim FRM As New nuevo_cliente
        FRM.ShowDialog()
        Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)

    End Sub

    Private Sub CPTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPTextBox.TextChanged
        Me.CodigopostalTextBox.Text = Me.CPTextBox.Text
    End Sub

    Private Sub EmailTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailTextBox1.TextChanged
        Me.EmailTextBox.Text = Me.EmailTextBox1.Text
    End Sub

    Private Sub RFCTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RFCTextBox.Validating
        Me.RFCTextBox.Text = Me.RFCTextBox.Text.Replace("-", "")
        If RFCTextBox.TextLength < 12 Then
            MsgBox("Validar RFC") : e.Cancel = True
            Dim ix As MsgBoxResult = MsgBox("Quiere poner el generico", MsgBoxStyle.YesNo, "")
            If ix = MsgBoxResult.Yes Then Me.RFCTextBox.Text = "XAXX010101000" : e.Cancel = False
        End If
    End Sub


    Private Sub DescripcionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionComboBox.SelectedIndexChanged
        Me.RutaTextBox.Text = Me.DescripcionComboBox.SelectedValue
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Me.Id_agenteTextBox.Text = Me.NombreComboBox.SelectedValue
    End Sub


    Private Sub MetodoComboBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles formacombo.TextChanged, formacombo.TextChanged
        FormaTextBox.Text = formacombo.SelectedValue
    End Sub

    

    Private Sub Tool_verfacturas_Click(sender As System.Object, e As System.EventArgs) Handles Tool_verfacturas.Click
        Me.TabControl1.SelectedIndex = 3
        Dim idc As Integer
        idc = DirectorioDataGridView.CurrentRow.Cells(0).Value
        Me.Sql_documentos_clientesTableAdapter.FillBycliente(Me.AdmintegralDataSet.sql_documentos_clientes, idc)
    End Sub

    Private Sub Sql_documentos_clientesDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_documentos_clientesDataGridView.CellDoubleClick, Sql_documentos_clientesDataGridView.CellClick
        Dim serie, folio, filexml, filepdf, email As String
        serie = Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvserie").Value
        folio = Sql_documentos_clientesDataGridView.CurrentRow.Cells("dgvfolio").Value
        ini()
        Dim rutaGuardar As String
        rutaGuardar = dfei.ruta  '
        filexml = rutaGuardar + "\CFDI33_" + serie.ToString.Trim + folio.ToString.Trim + ".xml"
        filepdf = rutaGuardar + "\CFDI33_" + serie.ToString.Trim + folio.ToString.Trim + ".pdf"
        email = DirectorioDataGridView.CurrentRow.Cells("dgvemail").Value
        eemail.Text = email
        epdf.Text = filepdf
        exml.Text = filexml

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            Process.Start(epdf.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        smtp = buzon()
        'para = "freddyfe82@hotmail.com"

        Dim ok As Boolean = mandar_correo(eemail.Text, "Factura Electronica", "Anexamos archivo con factura electronica. " + cr + lf + "Para cualquier duda escribir a abarroterabara@yahoo.com.mx", epdf.Text, exml.Text)
        If ok = True Then MsgBox("Correo enviado!") Else MsgBox("Eroor al enviar archivo")

    End Sub

   
End Class
