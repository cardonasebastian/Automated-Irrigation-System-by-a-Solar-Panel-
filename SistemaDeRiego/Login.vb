
Imports MetroFramework
Public Class Login
    Inherits MetroFramework.Forms.MetroForm
    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    

   

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (MetroTextBox2.Text.Equals("FERNANDO") And MetroTextBox3.Text.Equals("SEBASTIAN")) Then
            MessageBox.Show("Bienvenido " + MetroTextBox2.Text)
            MainMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o Contraseña Incorrecta")
            MetroTextBox2.Text = ""
            MetroTextBox3.Text = ""

        End If
        

    End Sub

    Private Sub MetroTextBox2_Click(sender As Object, e As EventArgs) Handles MetroTextBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
