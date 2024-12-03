Imports System.Windows.Media.Media3D

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)


        CESSNA.Visibility = Visibility.Hidden
        PIPER.Visibility = Visibility.Hidden
        B17.Visibility = Visibility.Visible
        Label1.Content =
        "MaxSpeed: 311mph
        Weight 65500lbs
        Designer Boeing Company
        model 1935"




    End Sub

    Private Sub Button3_Click(sender As Object, e As RoutedEventArgs) Handles Button3.Click
        CESSNA.Visibility = Visibility.Visible
        PIPER.Visibility = Visibility.Hidden
        B17.Visibility = Visibility.Hidden
        Label1.Content =
        "MaxSpeed: 188mph
        Weight 1669lbs
        Designer Cessna Aircraft Company
        model 1956"


    End Sub

    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs) Handles Button2.Click


        CESSNA.Visibility = Visibility.Hidden
        PIPER.Visibility = Visibility.Visible
        B17.Visibility = Visibility.Hidden
        Label1.Content =
        "MaxSpeed: 136mph
        Weight 1365lbs
        Designer Piper Aircraft Corporation
        model 1964"


    End Sub
End Class
