<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(900, 472)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(330, 372)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(242, 88)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.CustomBackground = False
        Me.MetroTextBox3.CustomForeColor = False
        Me.MetroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox3.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.MetroTextBox3.Location = New System.Drawing.Point(465, 291)
        Me.MetroTextBox3.Multiline = False
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.Size = New System.Drawing.Size(362, 52)
        Me.MetroTextBox3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.StyleManager = Nothing
        Me.MetroTextBox3.TabIndex = 8
        Me.MetroTextBox3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.UseStyleColors = False
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.CustomBackground = False
        Me.MetroTextBox2.CustomForeColor = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox2.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.MetroTextBox2.Location = New System.Drawing.Point(465, 173)
        Me.MetroTextBox2.Multiline = False
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.Size = New System.Drawing.Size(362, 52)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTextBox2.StyleManager = Nothing
        Me.MetroTextBox2.TabIndex = 9
        Me.MetroTextBox2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.UseStyleColors = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(790, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 472)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "Login"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
