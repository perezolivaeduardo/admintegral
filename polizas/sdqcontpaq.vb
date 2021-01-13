Module sdqcontpaq
    Structure ppoliza
        Dim poliza As String    '2
        Dim fecha As String     '8
        Dim tipo As String      '4
        Dim folio As String     '9
        Dim clase As String     '2
        Dim iddiario As String  '10
        Dim concepto As String  '100
        Dim sistorig As String  '2
        Dim impresa As String   '1
        Dim ajuste As String    '
    End Structure

    Structure mpoliza
        Dim movimiento As String    '2
        Dim idcuenta As String      '30
        Dim referencia As String    '10
        Dim tipomov As String       '1
        Dim importe As String       '20
        Dim iddiario As String      '10
        Dim importeme As String     '20
        Dim concepto As String      '100
        Dim idsegneg As String      '4
    End Structure
    Function cuenta(ByVal ct As String) As String
        cuenta = ct.Substring(0, 4)
        cuenta = cuenta + ct.Substring(5, 5)
        cuenta = cuenta + ct.Substring(11, 4)
    End Function
End Module