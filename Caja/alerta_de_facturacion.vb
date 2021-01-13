Imports System.Windows.Forms

Public Class alerta_de_facturacion

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub alerta_de_facturacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SAT_catalogosDataSet.sat_formasdepago' Puede moverla o quitarla según sea necesario.
        Me.Sat_formasdepagoTableAdapter.Fill(Me.SAT_catalogosDataSet.sat_formasdepago)
        'TODO: esta línea de código carga datos en la tabla 'SAT_catalogosDataSet.sat_metodosdepago' Puede moverla o quitarla según sea necesario.
        Me.Sat_metodosdepagoTableAdapter.Fill(Me.SAT_catalogosDataSet.sat_metodosdepago)
        'TODO: esta línea de código carga datos en la tabla 'SAT_catalogosDataSet.sat_uso' Puede moverla o quitarla según sea necesario.
        Me.Sat_usoTableAdapter.Fill(Me.SAT_catalogosDataSet.sat_uso)
        Me.Sat_usoBindingSource.Position = Me.Sat_usoBindingSource.Find("id_uso", "G03")
        Me.Sat_metodosdepagoBindingSource.Position = Me.Sat_metodosdepagoBindingSource.Find("METODO", METODO.Text)
        Sat_formasdepagoBindingSource.Position = Me.Sat_formasdepagoBindingSource.Find("formaDEpago", FORMA.Text)
    End Sub

    Private Sub METODO_TextChanged(sender As System.Object, e As System.EventArgs) Handles METODO.TextChanged
        Me.Sat_metodosdepagoBindingSource.Position = Me.Sat_metodosdepagoBindingSource.Find("METODO", METODO.Text)
        metodo_descripcion.Text = fn_metodo(METODO.Text)
        If metodo_descripcion.Text = "-" Then
            OK_Button.Enabled = False
        End If
        If METODO.Text = "PPD" Then
            FORMA.Text = "99"
            panel.Enabled = False
        Else
            panel.Enabled = True
        End If
    End Sub

    Private Sub USO_TextChanged(sender As System.Object, e As System.EventArgs) Handles USO.TextChanged
        uso_descripcion.Text = fn_uso(USO.Text)
        If uso_descripcion.Text = "-" Then
            OK_Button.Enabled = False
        End If
    End Sub

    Private Sub FORMA_TextChanged(sender As System.Object, e As System.EventArgs) Handles FORMA.TextChanged
        Sat_formasdepagoBindingSource.Position = Me.Sat_formasdepagoBindingSource.Find("formaDEpago", FORMA.Text)

        forma_descripcion.Text = fn_forma(FORMA.Text)
        If forma_descripcion.Text = "-" Then
            OK_Button.Enabled = False
        End If
    End Sub

    Private Sub valida()
        OK_Button.Enabled = True
        metodo_descripcion.Text = fn_metodo(METODO.Text)
        If metodo_descripcion.Text = "-" Then
            OK_Button.Enabled = False
        End If
        uso_descripcion.Text = fn_uso(USO.Text)
        If uso_descripcion.Text = "-" Then
            OK_Button.Enabled = False
        End If

        If FORMA.Text <> "PPD" Then
            forma_descripcion.Text = fn_forma(FORMA.Text)
            If forma_descripcion.Text = "-" Then
                OK_Button.Enabled = False
            End If
        Else
            FORMA.Text = "99"
        End If
    End Sub

    Private Sub btn_valida_Click(sender As System.Object, e As System.EventArgs) Handles btn_valida.Click
        valida()
    End Sub

    Private Sub EMAIL_TextChanged(sender As System.Object, e As System.EventArgs) Handles EMAIL.TextChanged
        OK_Button.Enabled = Validar_Email(EMAIL.Text)
    End Sub

    Private Sub Sat_usoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Sat_usoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SAT_catalogosDataSet)

    End Sub

    Private Sub UsoComboBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UsoComboBox.TextChanged
        USO.Text = UsoComboBox.SelectedValue
    End Sub

   
    Private Sub DescripcionComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DescripcionComboBox.SelectedIndexChanged
        METODO.Text = DescripcionComboBox.SelectedValue
    End Sub

    Private Sub FORMACOMBO_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles FORMACOMBO.SelectedIndexChanged
        FORMA.Text = FORMACOMBO.SelectedValue
    End Sub
End Class
