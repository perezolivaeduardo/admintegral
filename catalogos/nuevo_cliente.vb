Public Class nuevo_cliente

    Private Sub DirectorioBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
      
    End Sub

    Private Sub nuevo_cliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SAT_catalogosDataSet.sat_uso' Puede moverla o quitarla según sea necesario.
        Me.Sat_usoTableAdapter.Fill(Me.SAT_catalogosDataSet.sat_uso)
        'TODO: esta línea de código carga datos en la tabla 'SAT_catalogosDataSet.sat_formasdepago' Puede moverla o quitarla según sea necesario.
        Me.Sat_formasdepagoTableAdapter.Fill(Me.SAT_catalogosDataSet.sat_formasdepago)
        'TODO: esta línea de código carga datos en la tabla 'SAT_catalogosDataSet.sat_metodosdepago' Puede moverla o quitarla según sea necesario.
        Me.Sat_metodosdepagoTableAdapter.Fill(Me.SAT_catalogosDataSet.sat_metodosdepago)
        'TODO: esta línea de código carga datos en la tabla 'AdmintegralDataSet.Directorio' Puede moverla o quitarla según sea necesario.
        Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)
        Dim cmd As String, nuevo_id As Integer
        cmd = "SELECT MAX(id_directorio)+1 AS ID FROM Directorio GROUP BY tipo HAVING(tipo = 2)"
        Dim tb As New DataTable
        tb = leer_tabla(cmd)
        nuevo_id = tb.Rows(0).Item(0)
        Me.DirectorioBindingSource.AddNew()
        Me.Id_directorioTextBox.Text = nuevo_id
        Me.TipoTextBox.Text = 2
        Me.NombreTextBox.Focus()
    End Sub

    Private Sub DescripcionComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DescripcionComboBox.SelectedIndexChanged
        MetodoTextBox.Text = DescripcionComboBox.SelectedValue
    End Sub

    Private Sub DescripcionComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DescripcionComboBox1.SelectedIndexChanged
        FormaTextBox.Text = DescripcionComboBox1.SelectedValue
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.DirectorioBindingSource.EndEdit()
        Me.DirectorioTableAdapter.Update(Me.AdmintegralDataSet.Directorio)
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        DirectorioBindingSource.CancelEdit()
        Me.Dispose()
    End Sub

    Private Sub UsoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles UsoComboBox.SelectedIndexChanged
        UsoTextBox.Text = UsoComboBox.SelectedValue
    End Sub
End Class