Public Class ControlCarro

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ControlCarro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.PortName = SerialComunication.getPort
        SerialPort1.BaudRate = SerialComunication.getBaudRate
        Try
            SerialPort1.Open()
            SerialPort1.Write("1")
            SerialPort1.Write("1")
            Timer1.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim buffer As String
        buffer = SerialPort1.ReadExisting & vbCrLf
        If (buffer.Equals("adelante")) Then
            PictureBox3.Visible = True
            PictureBox1.Visible = False
        ElseIf (buffer.Equals("atras")) Then
            PictureBox3.Visible = False
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SerialPort1.Write("3")
    End Sub
End Class