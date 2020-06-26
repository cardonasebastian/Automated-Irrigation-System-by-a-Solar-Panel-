Public Class Configuracion
    Inherits MetroFramework.Forms.MetroForm
    Dim cont As Integer = 1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If cont Mod 2 <> 0 Then
            cont = cont + 1
            SerialPort1.Write("e")
        Else
            cont = cont + 1
            SerialPort1.Write("i")
        End If
    End Sub

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.PortName = SerialComunication.getPort
        SerialPort1.BaudRate = SerialComunication.getBaudRate
        Try
            SerialPort1.Open()

        Catch ex As Exception

        End Try
    End Sub
End Class