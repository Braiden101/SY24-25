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
        Loser2 = New Timer(components)
        Avitar = New PictureBox()
        Timer1 = New Timer(components)
        Enemy1 = New PictureBox()
        Enemy2 = New PictureBox()
        Platform1 = New PictureBox()
        Coin = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox8 = New PictureBox()
        ScoreLable = New Label()
        Timer2 = New Timer(components)
        jumpTimer = New Timer(components)
        BigWin = New Label()
        PictureBox5 = New PictureBox()
        PictureBox2 = New PictureBox()
        Enemy5 = New PictureBox()
        Enemy3 = New PictureBox()
        Enemy4 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox14 = New PictureBox()
        Loser1 = New Label()
        CType(Avitar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy5, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Loser2
        ' 
        Loser2.Interval = 1000
        ' 
        ' Avitar
        ' 
        Avitar.Image = CType(resources.GetObject("Avitar.Image"), Image)
        Avitar.Location = New Point(29, 122)
        Avitar.Name = "Avitar"
        Avitar.Size = New Size(58, 66)
        Avitar.SizeMode = PictureBoxSizeMode.Zoom
        Avitar.TabIndex = 0
        Avitar.TabStop = False
        Avitar.Tag = "-1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Enemy1
        ' 
        Enemy1.Image = CType(resources.GetObject("Enemy1.Image"), Image)
        Enemy1.Location = New Point(345, 163)
        Enemy1.Name = "Enemy1"
        Enemy1.Size = New Size(48, 25)
        Enemy1.SizeMode = PictureBoxSizeMode.Zoom
        Enemy1.TabIndex = 3
        Enemy1.TabStop = False
        Enemy1.Tag = "Enemy"
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(292, 345)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(34, 24)
        Enemy2.SizeMode = PictureBoxSizeMode.Zoom
        Enemy2.TabIndex = 4
        Enemy2.TabStop = False
        Enemy2.Tag = "Enemy"
        ' 
        ' Platform1
        ' 
        Platform1.BackColor = Color.Maroon
        Platform1.Location = New Point(1, 194)
        Platform1.Name = "Platform1"
        Platform1.Size = New Size(509, 16)
        Platform1.TabIndex = 5
        Platform1.TabStop = False
        Platform1.Tag = "Wall"
        ' 
        ' Coin
        ' 
        Coin.Image = CType(resources.GetObject("Coin.Image"), Image)
        Coin.Location = New Point(592, 945)
        Coin.Name = "Coin"
        Coin.Size = New Size(51, 55)
        Coin.SizeMode = PictureBoxSizeMode.Zoom
        Coin.TabIndex = 2
        Coin.TabStop = False
        Coin.Tag = "a"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Maroon
        PictureBox1.Location = New Point(1, 1006)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(659, 23)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        PictureBox1.Tag = "Wall"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Maroon
        PictureBox8.Location = New Point(107, 375)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(544, 12)
        PictureBox8.TabIndex = 13
        PictureBox8.TabStop = False
        PictureBox8.Tag = "Wall"
        ' 
        ' ScoreLable
        ' 
        ScoreLable.AutoSize = True
        ScoreLable.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScoreLable.Location = New Point(280, 26)
        ScoreLable.Name = "ScoreLable"
        ScoreLable.Size = New Size(0, 54)
        ScoreLable.TabIndex = 22
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' jumpTimer
        ' 
        ' 
        ' BigWin
        ' 
        BigWin.AutoSize = True
        BigWin.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BigWin.Location = New Point(249, 17)
        BigWin.Name = "BigWin"
        BigWin.Size = New Size(0, 54)
        BigWin.TabIndex = 27
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Maroon
        PictureBox5.Location = New Point(12, 571)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(544, 10)
        PictureBox5.TabIndex = 28
        PictureBox5.TabStop = False
        PictureBox5.Tag = "Wall"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Maroon
        PictureBox2.Location = New Point(116, 771)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(544, 15)
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        PictureBox2.Tag = "Wall"
        ' 
        ' Enemy5
        ' 
        Enemy5.Image = CType(resources.GetObject("Enemy5.Image"), Image)
        Enemy5.Location = New Point(179, 970)
        Enemy5.Name = "Enemy5"
        Enemy5.Size = New Size(37, 30)
        Enemy5.SizeMode = PictureBoxSizeMode.Zoom
        Enemy5.TabIndex = 30
        Enemy5.TabStop = False
        Enemy5.Tag = "Enemy"
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), Image)
        Enemy3.Location = New Point(401, 534)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(38, 31)
        Enemy3.SizeMode = PictureBoxSizeMode.Zoom
        Enemy3.TabIndex = 31
        Enemy3.TabStop = False
        Enemy3.Tag = "Enemy"
        ' 
        ' Enemy4
        ' 
        Enemy4.Image = CType(resources.GetObject("Enemy4.Image"), Image)
        Enemy4.Location = New Point(237, 736)
        Enemy4.Name = "Enemy4"
        Enemy4.Size = New Size(43, 29)
        Enemy4.SizeMode = PictureBoxSizeMode.Zoom
        Enemy4.TabIndex = 32
        Enemy4.TabStop = False
        Enemy4.Tag = "Enemy"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.Maroon
        PictureBox10.Location = New Point(649, -49)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(11, 1059)
        PictureBox10.TabIndex = 34
        PictureBox10.TabStop = False
        PictureBox10.Tag = "Wall"
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.Maroon
        PictureBox13.Location = New Point(1, -1)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(655, 15)
        PictureBox13.TabIndex = 35
        PictureBox13.TabStop = False
        PictureBox13.Tag = "Wall"
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackColor = Color.Maroon
        PictureBox14.Location = New Point(1, -1)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(10, 1008)
        PictureBox14.TabIndex = 36
        PictureBox14.TabStop = False
        PictureBox14.Tag = "Wall"
        ' 
        ' Loser1
        ' 
        Loser1.AutoSize = True
        Loser1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Loser1.Location = New Point(249, 17)
        Loser1.Name = "Loser1"
        Loser1.Size = New Size(48, 54)
        Loser1.TabIndex = 37
        Loser1.Text = "d"
        Loser1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(663, 1055)
        Controls.Add(Loser1)
        Controls.Add(PictureBox14)
        Controls.Add(PictureBox13)
        Controls.Add(PictureBox10)
        Controls.Add(Enemy4)
        Controls.Add(Enemy3)
        Controls.Add(Enemy5)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox5)
        Controls.Add(BigWin)
        Controls.Add(ScoreLable)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox1)
        Controls.Add(Platform1)
        Controls.Add(Enemy2)
        Controls.Add(Enemy1)
        Controls.Add(Coin)
        Controls.Add(Avitar)
        Name = "Form1"
        Tag = "0"
        Text = "Form1"
        CType(Avitar, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy1, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform1, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy5, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avitar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Platform1 As PictureBox
    Friend WithEvents Coin As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents ScoreLable As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents jumpTimer As Timer
    Friend WithEvents BigWin As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Enemy5 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Enemy4 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Loser1 As Label
    Friend WithEvents Loser2 As Timer

End Class
