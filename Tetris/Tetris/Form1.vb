Imports System.Globalization

Public Class Form1
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Enemy1, Avitar, 5, 0)
        follow(Enemy2, Avitar, 5, 0)
        follow(Enemy3, Avitar, 5, 0)
        follow(Enemy4, Avitar, 5, 0)
        follow(Enemy5, Avitar, 5, 0)
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width - 5 Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As String
        dir = e.Tag

        move(e, 0, dir * speed)

        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height / 2 Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub follow(e As PictureBox, a As PictureBox, speedx As Integer, speedy As Integer)
        If e.Location.Y > a.Location.Y Then
            move(e, 0, -speedy)
        Else
            move(e, 0, speedy)
        End If
        If e.Location.X > a.Location.X Then
            move(e, -speedx, 0)
        Else
            move(e, speedx, 0)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avitar, -5, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Avitar, 5, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Avitar, 0, 5)
        End If
        If e.KeyCode = Keys.Space Then
            jumpTimer.Enabled = True
            Avitar.Tag = 3
        End If

    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)

        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If
        Dim z As PictureBox
        If IntersectsWith(p, "Coin", z) Then
            z.Visible = False
            Me.BackColor = Color.Green
            BigWin.Text = "Big Win"
        End If
        If IntersectsWith(p, "Enemy", z) Then


        End If
        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)

    End Sub

    Function endingWith(s As String) As Collection
        Dim coll As New Collection
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing Then
                If UCase(obj.Name).EndsWith(UCase(s)) Then
                    coll.Add(obj)
                End If
            End If
        Next
        Return coll
    End Function
    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        Return IntersectsWith(p, tag, Nothing)
    End Function
    Function IntersectsWith(p As PictureBox, tag As String, Optional ByRef other As PictureBox = Nothing) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Visible Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    other = obj
                    Return True
                End If
            End If
        Next
        Return False
    End Function
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        score += 1
        ScoreLable.Text = score

        If score - score Then

            score = 0
            score += 1
        End If
    End Sub


    Private Sub jumpTimer_Tick(sender As Object, e As EventArgs) Handles jumpTimer.Tick
        Dim t As Integer
        t = Avitar.Tag
        If t > 0 Then move(Avitar, 0, -20)
        If t < 0 Then move(Avitar, 0, 20)
        If t = -3 Then jumpTimer.Enabled = False

        Avitar.Tag = t - 1

    End Sub
    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        Else
            Dim idx As Integer
            idx = tracks(e.Name & a.Name)
            If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
                e.Location = movements(a.Name).Item(idx)
                tracks(e.Name & a.Name) = idx + 1
            End If

        End If
    End Sub







End Class
