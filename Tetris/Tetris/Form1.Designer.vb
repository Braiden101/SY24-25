<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Avitar = New PictureBox()
        Timer1 = New Timer(components)
        PictureBox3 = New PictureBox()
        Enemy = New PictureBox()
        Enemy2 = New PictureBox()
        CType(Avitar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avitar
        ' 
        Avitar.Image = CType(resources.GetObject("Avitar.Image"), Image)
        Avitar.Location = New Point(12, 12)
        Avitar.Name = "Avitar"
        Avitar.Size = New Size(207, 125)
        Avitar.SizeMode = PictureBoxSizeMode.Zoom
        Avitar.TabIndex = 0
        Avitar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(517, 81)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(95, 88)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(430, 185)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(130, 81)
        Enemy.SizeMode = PictureBoxSizeMode.Zoom
        Enemy.TabIndex = 3
        Enemy.TabStop = False
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(201, 293)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(130, 81)
        Enemy2.SizeMode = PictureBoxSizeMode.Zoom
        Enemy2.TabIndex = 4
        Enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(663, 1055)
        Controls.Add(Enemy2)
        Controls.Add(Enemy)
        Controls.Add(PictureBox3)
        Controls.Add(Avitar)
        Name = "Form1"
        Text = "Form1"
        CType(Avitar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avitar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox

End Class
