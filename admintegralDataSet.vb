Partial Class admintegralDataSet
 

    Partial Class paquetesDataTable

        Private Sub paquetesDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idpaqueteColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Class GruposDataTable

    End Class

    Partial Class DirectorioDataTable

        Private Sub DirectorioDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.fecha_altaColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class movimientosDataTable

        Private Sub movimientosDataTable_movimientosRowChanging(ByVal sender As System.Object, ByVal e As movimientosRowChangeEvent) Handles Me.movimientosRowChanging

        End Sub

    End Class

    Partial Class productosDataTable

        Private Sub productosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ivaColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class sql_documento_impresionDataTable

        Private Sub sql_documento_impresionDataTable_sql_documento_impresionRowChanging(ByVal sender As System.Object, ByVal e As sql_documento_impresionRowChangeEvent) Handles Me.sql_documento_impresionRowChanging

        End Sub

    End Class

End Class

Namespace admintegralDataSetTableAdapters
    
    Partial Public Class sql_documentos_clientesTableAdapter
    End Class
End Namespace
