Class MainWindow
    Private Sub dutch_button_Click(sender As Object, e As RoutedEventArgs) Handles dutch_button.Click
        Dutch.Visibility = Visibility.Visible
        arthur.Visibility = Visibility.Hidden
        steve.Visibility = Visibility.Hidden
        label1.Content = "Dutch is the leader of he's own gang
he always has a plan
he always needs more money
he always says one more score"

    End Sub

    Private Sub Arthur_button_Click(sender As Object, e As RoutedEventArgs) Handles Arthur_button.Click
        Dutch.Visibility = Visibility.Hidden
        arthur.Visibility = Visibility.Visible
        steve.Visibility = Visibility.Hidden
        label1.Content = "he is dutch's right hand man
he's nick-named the ledgend of the east
he was a cowboy
he's momma died when he was a kid"
    End Sub

    Private Sub steve_button_Click(sender As Object, e As RoutedEventArgs) Handles steve_button.Click
        Dutch.Visibility = Visibility.Hidden
        arthur.Visibility = Visibility.Hidden
        steve.Visibility = Visibility.Visible
        label1.Content = "he has no story or backstory
he is from minecraft
he has 20 hit points
he wears armour"
    End Sub
End Class
