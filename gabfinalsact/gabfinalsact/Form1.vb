Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub
End Class
