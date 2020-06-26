<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActiviadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DireccionDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoDelTanqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiempoDeRegadoYControlDeLaBombaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuertoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.BaudRideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(807, 439)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiviadesToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.SalirToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(807, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActiviadesToolStripMenuItem
        '
        Me.ActiviadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DireccionDelSistemaToolStripMenuItem, Me.EstadoDelTanqueToolStripMenuItem, Me.TiempoDeRegadoYControlDeLaBombaToolStripMenuItem})
        Me.ActiviadesToolStripMenuItem.Name = "ActiviadesToolStripMenuItem"
        Me.ActiviadesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ActiviadesToolStripMenuItem.Text = "Activiades"
        '
        'DireccionDelSistemaToolStripMenuItem
        '
        Me.DireccionDelSistemaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DireccionDelSistemaToolStripMenuItem.Name = "DireccionDelSistemaToolStripMenuItem"
        Me.DireccionDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(300, 22)
        Me.DireccionDelSistemaToolStripMenuItem.Text = "Direccion del Sistema"
        '
        'EstadoDelTanqueToolStripMenuItem
        '
        Me.EstadoDelTanqueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EstadoDelTanqueToolStripMenuItem.Name = "EstadoDelTanqueToolStripMenuItem"
        Me.EstadoDelTanqueToolStripMenuItem.Size = New System.Drawing.Size(300, 22)
        Me.EstadoDelTanqueToolStripMenuItem.Text = "Estado del tanque"
        '
        'TiempoDeRegadoYControlDeLaBombaToolStripMenuItem
        '
        Me.TiempoDeRegadoYControlDeLaBombaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TiempoDeRegadoYControlDeLaBombaToolStripMenuItem.Name = "TiempoDeRegadoYControlDeLaBombaToolStripMenuItem"
        Me.TiempoDeRegadoYControlDeLaBombaToolStripMenuItem.Size = New System.Drawing.Size(300, 22)
        Me.TiempoDeRegadoYControlDeLaBombaToolStripMenuItem.Text = "Tiempo De Regado y Control De La Bomba"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuertoToolStripMenuItem, Me.BaudRideToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'PuertoToolStripMenuItem
        '
        Me.PuertoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PuertoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.PuertoToolStripMenuItem.Name = "PuertoToolStripMenuItem"
        Me.PuertoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PuertoToolStripMenuItem.Text = "Puerto"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'BaudRideToolStripMenuItem
        '
        Me.BaudRideToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BaudRideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox2})
        Me.BaudRideToolStripMenuItem.Name = "BaudRideToolStripMenuItem"
        Me.BaudRideToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BaudRideToolStripMenuItem.Text = "Baud Ride"
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(121, 23)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 463)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActiviadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DireccionDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoDelTanqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiempoDeRegadoYControlDeLaBombaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuertoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents BaudRideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
End Class
