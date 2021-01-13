Public Class frm_new_producto

    Dim producto As New MIproducto
    Dim id As Integer

    Private Sub frm_new_producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Unidades_productosTableAdapter.Fill(Me.AdmintegralDataSet.Unidades_productos)
        Me.DirectorioTableAdapter.Fill(Me.AdmintegralDataSet.Directorio)
        Me.GruposTableAdapter.Fill(Me.AdmintegralDataSet.Grupos)
        Me.DepartamentosTableAdapter.Fill(Me.AdmintegralDataSet.Departamentos)
        Me.ProductosTableAdapter.Fill(Me.AdmintegralDataSet.productos)
        Dim adap As New AdmintegralDataSetTableAdapters.productosTableAdapter
        id = adap.productos_nuevo_id.ToString
        lblid.Text = id.ToString
        Nuevo()
        Me.Enabled = True
    End Sub


    Private Sub MargenTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MargenTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub IvaTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IvaTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles costotxt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ventatxt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComisionTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComisionTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Boton_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Salir.Click
        Me.ProductosBindingSource.CancelEdit()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub costotxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles costotxt.Leave
        Dim sugerido As Single = 0, costo As Single = Val(costotxt.Text)
        Dim m As Single = Val(Me.MargenTextBox.Text)
        If costo > 0 Then
            ventatxt.Text = costo * (1 + (m / 100))
        Else
            costotxt.Text = "0.00"
            ventatxt.Text = "0.00"
        End If
    End Sub 'calcula precio de venta

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.ProductosBindingSource.EndEdit()
            Me.ProductosTableAdapter.Update(Me.AdmintegralDataSet.productos)
            agregar_unidad(id, 1, Me.codigo.Text, Me.unidadtxt.Text, False, 1, 1, Me.costotxt.Text, Me.ventatxt.Text)
        Catch ex As Exception

        End Try

        producto.depto = Me.DepartamentoComboBox.SelectedIndex
        producto.grupo = Me.GrupoComboBox.SelectedIndex
        producto.marca = Me.MarcaTextBox.Text
        producto.id_directorio = Me.NombreComboBox.SelectedIndex
        producto.descripcion = Me.DescripcionTextBox.Text
        producto.PESO = Me.PesoTextBox.Text
        producto.margen = Me.MargenTextBox.Text
        producto.iva = Me.IvaTextBox.Text
        producto.comisionable = Me.ComisionableCheckBox.CheckState
        producto.comision = Me.ComisionTextBox.Text
        producto.tipo = 1
        producto.caducidad = Me.CaducidadCheckBox.CheckState

        otro_producto()
        Me.codigo.Text = ""
        Me.Cve_provedorTextBox.Focus()
    End Sub ' guarda y pide otro igual

    Private Sub otro_producto()
        id = id + 1
        Nuevo()
        Me.DepartamentoComboBox.SelectedIndex = producto.depto
        Me.GrupoComboBox.SelectedIndex = producto.grupo
        Me.MarcaTextBox.Text = producto.marca
        Me.NombreComboBox.SelectedIndex = producto.id_directorio
        Me.DescripcionTextBox.Text = producto.descripcion
        Me.PesoTextBox.Text = producto.PESO
        Me.MargenTextBox.Text = producto.margen
        Me.IvaTextBox.Text = producto.iva
        Me.ComisionableCheckBox.Checked = producto.comisionable
        Me.ComisionTextBox.Text = producto.comision
        Me.CaducidadCheckBox.Checked = producto.caducidad
    End Sub ' genera uno nuevo con datos igual

    Private Sub Nuevo()
        Me.ProductosBindingSource.AddNew()
        Me.Id_productoTextBox.Text = id
        Me.ComisionableCheckBox.CheckState = CheckState.Checked
        Me.CaducidadCheckBox.CheckState = CheckState.Unchecked
        Me.IvaTextBox.Text = My.Settings.iva.ToString
        Me.MargenTextBox.Text = My.Settings.Margen
        Me.ComisionTextBox.Text = My.Settings.Comision
        Me.DepartamentoComboBox.SelectedIndex = 0
        Me.GrupoComboBox.SelectedIndex = 0
        Me.Und_compraTextBox.Text = 1
        Me.Und_detalleTextBox.Text = 1
        Me.Und_ventaTextBox.Text = 1
        Me.Fecha_altaTextBox.Text = Now.Date
        Me.Id_usuarioTextBox.Text = user.id
        Me.StatusTextBox.Text = 0
    End Sub ' genera nuevo registro en memoria

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        Try
            Me.Validate()
            Me.ProductosBindingSource.EndEdit()
            Me.ProductosTableAdapter.Update(Me.AdmintegralDataSet.productos)
            agregar_unidad(id, 1, Me.codigo.Text, Me.unidadtxt.Text, False, 1, 1, Me.costotxt.Text, Me.ventatxt.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.ProductosBindingSource.CancelEdit()
            Me.Close()
            Exit Sub
        End Try
        id = id + 1
        Nuevo()
    End Sub 'Guardar y nuevo

    Private Sub IvaTextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IvaTextBox.Validated
        Dim iva As Int16 = Val(IvaTextBox.Text)
        If iva <> 0 And iva <> My.Settings.iva Then
            Me.ErrorP.SetError(IvaTextBox, "El iva debe de ser 0% o " + My.Settings.iva.ToString)
        Else
            Me.ErrorP.SetError(IvaTextBox, Nothing)
        End If

    End Sub

    Private Sub agregar_unidad(ByVal id_productos As Long, ByVal idund As Integer, ByVal codigo As Long, _
    ByVal und As String, ByVal operador As Boolean, ByVal factor As Single, ByVal unidades As Double, _
    ByVal costo As Single, ByVal venta As Single)
        Dim adap As New AdmintegralDataSetTableAdapters.Unidades_productosTableAdapter
        adap.Insert(id_productos, idund, codigo, und, operador, factor, unidades, costo, venta, " ")
        adap.Connection.Close()
    End Sub 'agrega registro deunidades

   
    Private Sub CaducidadCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaducidadCheckBox.CheckedChanged
        If Me.CaducidadCheckBox.Checked = True Then
            Me.CaducidadLabel.ForeColor = Color.Black
        Else
            Me.CaducidadLabel.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Id_DirectorioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_DirectorioTextBox.TextChanged
        Try
            Dim x As Integer
            x = Val(Id_DirectorioTextBox.Text)
            Dim ix As Integer = Me.DirectorioBindingSource.Find("id_directorio", x.ToString)
            Me.DirectorioBindingSource.Position = ix
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Id_GrupoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_GrupoTextBox.TextChanged
        Dim x As Integer
        Try
            x = Val(Id_GrupoTextBox.Text)
            Dim ix As Integer = Me.GruposBindingSource.Find("id_grupos", x)
            Me.GruposBindingSource.Position = ix
        Catch ex As Exception

        End Try

    End Sub
End Class
