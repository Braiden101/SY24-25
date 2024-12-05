Class MainWindow
    Private Sub Fill1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Fill1.MouseDown, FIll2.MouseDown, Fill3.MouseDown, Fill4.MouseDown, Fill5.MouseDown, Fill6.MouseDown, Fill7.MouseDown, Fill8.MouseDown
        Brush1.Fill = sender.Fill
    End Sub
End Class
