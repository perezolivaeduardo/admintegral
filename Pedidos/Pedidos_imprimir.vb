Public Class Pedidos_imprimir

    Private Sub Pedidos_imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub cargar(ByVal pedido As Integer)
        'TODO: esta línea de código carga datos en la tabla 'admintegralDataSet.sql_pedido_detalle' Puede moverla o quitarla según sea necesario.
        Me.sql_pedido_detalleTableAdapter.FillById(Me.admintegralDataSet.sql_pedido_detalle, pedido)
        Me.Reportpedido.RefreshReport()
        Me.Reportpedido.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

    End Sub


    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class