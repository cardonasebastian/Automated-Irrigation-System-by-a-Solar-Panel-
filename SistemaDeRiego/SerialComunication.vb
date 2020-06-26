Module SerialComunication
    Dim baudrate As Integer
    Dim port As String

    Public Sub setPort(ByVal port1 As String)
        port = port1
    End Sub

    Public Function getPort()
        Return port
    End Function

    Public Sub setBaudRate(ByVal baudrate1 As Integer)
        baudrate = baudrate1
    End Sub

    Public Function getBaudRate() As Integer
        Return baudrate
    End Function

End Module

