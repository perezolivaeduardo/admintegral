
Namespace My
    
    'Esta clase le permite controlar eventos específicos en la clase de configuración:
    ' El evento SettingChanging se desencadena antes de cambiar un valor de configuración.
    ' El evento PropertyChanged se desencadena después de cambiar el valor de configuración.
    ' El evento SettingsLoaded se desencadena después de cargar los valores de configuración.
    ' El evento SettingsSaving se desencadena antes de guardar los valores de configuración.
    Partial Friend NotInheritable Class MySettings
        Private Sub MySettings_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
            If e.PropertyName.Equals("sqlserver") Then
                Me("AdmintegralConnectionString") = Me.sqlserver
                Me("Admintegral") = Me.sqlserver
                Me("integraConnectionString") = Me.sqlserver
            End If

            If e.PropertyName.Equals("sqlsat") Then
                Me("SAT_catalogosConnectionString") = Me.sqlsat
            End If


        End Sub

    End Class
End Namespace
