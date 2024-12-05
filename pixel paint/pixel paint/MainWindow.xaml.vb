Class MainWindow
    Private Sub fill_1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles fill_1.MouseDown, fill_2.MouseDown, fill_3.MouseDown, fill_4.MouseDown, fill_5.MouseDown, fill_6.MouseDown, fill_7.MouseDown, fill_8.MouseDown
        brush_1.Fill = sender.fill
    End Sub
End Class
