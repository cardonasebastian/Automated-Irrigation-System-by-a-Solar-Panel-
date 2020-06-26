Public Class Entrada
    Dim contador As Integer = 0

    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If contador = 50 Then
            Login.Show()
            Me.Hide()
            Timer1.Stop()
        Else
            contador += 1
        End If

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class