Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports System.Net

Public Class Inventario_aleatorio



    Private Sub Inventario_aleatorio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.IntegraDataSet.productos)

        Me.Sql_inv_aleatorio_fijoTableAdapter.Fill(Me.IntegraDataSet.sql_inv_aleatorio_fijo)
      

        Dim cmd As String = "SELECT COUNT(fecha) AS existe FROM inv_aleatorio WHERE fecha = CONVERT(DATETIME, '[fecha] 00:00:00', 103)"
        cmd = cmd.Replace("[fecha]", Now.Date.ToShortDateString)
        Dim n As Integer = leer_tabla(cmd).Rows.Count
        If n = 0 Then
            Dim ix As MsgBoxResult, msg, msgtitulo As String
            msg = "No existe inventario para este dia, quiere generarlo? "
            msgtitulo = "Crear Inventario del Dia"
            ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
            If ix = MsgBoxResult.Yes Then

                generar_inventario(Now.Date)
            End If
        End If

        Me.Inv_aleatorioTableAdapter.FillByfecha(Me.IntegraDataSet.inv_aleatorio, Now.Date)
       
    End Sub

    Private Sub generar_inventario(ByVal fecha As Date)
        Dim min, max As Integer, rnd As New Random
        min = 1 : max = leer_tabla("select max(id_producto) from productos").Rows(0).Item(0)
        Dim adap_fijos As New integraDataSetTableAdapters.inv_aleatorio_fijosTableAdapter
        Dim adap As New integraDataSetTableAdapters.inv_aleatorioTableAdapter
        'elimina hoja del dia
        adap.elimina_fecha(fecha)

        Dim tbl As New DataTable
        tbl = adap_fijos.GetData
        Dim id, existenca As Integer
        For j As Integer = 0 To tbl.Rows.Count - 1
            id = tbl.Rows(j).Item(0)
            existenca = calcula_Existencia(id)
            adap.Insert(id, fecha, existenca, 0, False)
        Next
        For j As Integer = 1 To My.Settings.items_adicionales
            id = rnd.Next(min, max)
            If validar_si_existe_en_aleatorios(id, fecha) = False Then ' si no existe en la fecha de los aleatorios
                existenca = calcula_Existencia(id)
                adap.Insert(id, fecha, existenca, 0, False)
            End If

        Next

    End Sub

    Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim id As Integer
        id = Val(idtxt.Text)
        If validar_si_existe(id) = True And validar_si_existe_en_fijos(id) = False Then
            Dim adap As New integraDataSetTableAdapters.inv_aleatorio_fijosTableAdapter
            adap.Insert(id)
            adap.Dispose()
            Me.Sql_inv_aleatorio_fijoTableAdapter.Fill(Me.IntegraDataSet.sql_inv_aleatorio_fijo)
        Else
            MsgBox("Validar informacion este codigo no se dio de alta")
        End If

        idtxt.Text = ""

    End Sub

    Private Sub TabPage1_Click(sender As System.Object, e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btn_genera.Click
        generar_inventario(Now.Date)
        Me.Inv_aleatorioTableAdapter.FillByfecha(Me.IntegraDataSet.inv_aleatorio, Now.Date)
    End Sub

    Private Sub Inv_aleatorioDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Inv_aleatorioDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Validate()
        Me.Inv_aleatorioBindingSource.EndEdit()
        Me.Inv_aleatorioTableAdapter.Update(Me.IntegraDataSet.inv_aleatorio)
        MsgBox("Inventario Guardado")
    End Sub

    Private Sub Inv_aleatorioDataGridView1_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Datepiker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fconteo.ValueChanged
        Me.Inv_aleatorioTableAdapter.FillByfecha(Me.IntegraDataSet.inv_aleatorio, fconteo.Value)
        If fconteo.Value < Now.Date Then btn_genera.Enabled = False Else btn_genera.Enabled = True
    End Sub

    Private Sub guarda_movimiento(ByVal cant As Integer, ByVal id As Integer, ByVal fecha As Date)
        Dim costou As Decimal

        Dim sql As String
        sql = "Select costo from unidades_productos where id_unidad=1 and id_producto =" + id.ToString
        costou = leer_tabla(sql).Rows(0).Item(0)

        Dim adapm As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim f As String = Format(fecha, "yyyyMMdd")

        'guarda la existenci on fecha de ayer, ya que es la inicial de Hoy
        Try
            adapm.Insert(0, 15, f, 0, id, fecha, id, 1, 0, 1, cant, costou, 0, 0, 0, 0, 0, 0, 0, 0, cant, costou, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, Now.Date, 0, 0, 0, 0, 0)
            MsgBox("Aplicado")
        Catch ex As Exception
            MsgBox("Error al guardar Inventario)" + ex.Message)
        End Try
    End Sub

 

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim ix As MsgBoxResult = MsgBox("Seguro que quiere aplicar el inventario", MsgBoxStyle.YesNo, "Aplicar Invenario")
        If ix = MsgBoxResult.No Then Exit Sub
        aplicar_new()
    End Sub
    Private Sub aplicar_new()
        'aolica inventario
        '=======================================
        Dim kfolio As String
        Dim afolio As New admintegralDataSetTableAdapters.foliosTableAdapter
        Dim f, id, cant, almacen As Integer
        almacen = 0

        Try
            f = afolio.siguiente(11, almacen.ToString)
        Catch ex As Exception
            f = 1
            'MsgBox(ex.Message)
        End Try
        kfolio = f.ToString
        lblstatus.Text = "Guardando Documento"
        Dim d As New Mi_Documento
        d.a00_id_doc = 11
        d.a01_Folio = f
        d.a02_serie = almacen
        d.a03_Almacen = almacen
        d.a06_fecha_registro = CDate(Me.fconteo.Value).ToShortDateString
        d.a09_fecha_factura = CDate(Me.fconteo.Value).ToShortDateString
        d.a10_fecha_surtido = CDate(Me.fconteo.Value).ToShortDateString
        d.a11_fecha_vence = CDate(Me.fconteo.Value).ToShortDateString
        Dim result As Boolean = Agregar_documento(d)
        Dim tbl As New DataTable
        Dim adap As New integraDataSetTableAdapters.inv_aleatorioTableAdapter
        tbl = adap.GetDataByfecha(fconteo.Value)

        lblstatus.Text = "Documento Guardado"
        Dim adapm As New admintegralDataSetTableAdapters.movimientosTableAdapter
        Dim producto As New admintegralDataSetTableAdapters.Unidades_productosTableAdapter
        Dim invfisico As New admintegralDataSetTableAdapters.inventario_fisicoTableAdapter
        Dim costou As Single
        With tbl
            For j As Integer = 0 To .Rows.Count - 1
                Me.Text = "Reg. " + j.ToString + " de " + .Rows.Count.ToString
                id = .Rows(j).Item("id_producto") : cant = .Rows(j).Item("fisico")
                Try
                    costou = producto.GetDataByid(id).Rows(0).Item("costo")
                Catch ex As Exception
                    costou = 0
                End Try

                'guarda el movimiento con fecha del Dia siguiente para que aparesca como inicial del dia siguiente.
                Try
                    invfisico.Insert(id, almacen, CDate(Me.fconteo.Text).ToShortDateString, cant, fnexistencia(almacen, id, CDate(Me.fconteo.Text).AddDays(+1).ToShortDateString), costou)
                Catch ex As Exception
                    MsgBox("Error : " + ex.Message)
                End Try

                'anula movimientos anteriores para que quede como invetnatrio inicial del ldia
                Try
                    adapm.anula_anteriores_al_inventario(almacen, CDate(Me.fconteo.Text).ToShortDateString, id)
                Catch ex As Exception
                    MsgBox("Error al actualizar Existencias" + ex.Message)
                End Try

                'guarda la existenci on fecha de ayer, ya que es la inicial de Hoy
                Try
                    adapm.Insert(almacen, 11, f, almacen, j, CDate(Me.fconteo.Text).AddDays(-1), id, 1, 0, 1, cant, costou, 0, 0, 0, 0, 0, 0, 0, 0, cant, costou, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, Now.Date, 0, 0, 0, 0, 0)
                Catch ex As Exception
                    MsgBox("Error al guardar Inventario)" + ex.Message)
                End Try

                Me.Refresh()
            Next j
        End With
        MsgBox("Terminado!!")
    End Sub

   
End Class