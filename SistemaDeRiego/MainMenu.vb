Public Class MainMenu

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DireccionDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DireccionDelSistemaToolStripMenuItem.Click
        ControlCarro.MdiParent = Me
        ControlCarro.Show()
    End Sub

    Private Sub EstadoDelTanqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDelTanqueToolStripMenuItem.Click
        TanqueLLeno.MdiParent = Me
        TanqueLLeno.Show()
    End Sub

    Private Sub TiempoDeRegadoYControlDeLaBombaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiempoDeRegadoYControlDeLaBombaToolStripMenuItem.Click
        Configuracion.MdiParent = Me
        Configuracion.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ToolStripComboBox1.Items.Add(sp)
        Next
        ToolStripComboBox2.Items.Add(9600)
        ToolStripComboBox2.Items.Add(57600)
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try

            SerialComunication.setPort(ToolStripComboBox1.Text)
            MessageBox.Show("Puerto Cambiado a " + SerialComunication.getPort)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub ToolStripTextBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        Try
            Dim baud As Integer
            Int32.TryParse(ToolStripComboBox2.Text, baud)
            SerialComunication.setBaudRate(baud)
            MessageBox.Show("Baudrate cambiado a " & SerialComunication.getBaudRate)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BaudRideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaudRideToolStripMenuItem.Click

    End Sub
End Class