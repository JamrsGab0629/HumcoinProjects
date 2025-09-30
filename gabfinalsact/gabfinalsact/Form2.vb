Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBreadSticks.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles chkOlives.CheckedChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub txtSodaCan_TextChanged(sender As Object, e As EventArgs) Handles txtSodaCan.TextChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSoda15LTotal.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles txtJuiceTotal.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged_2(sender As Object, e As EventArgs) Handles txtDrinksTotal.TextChanged

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim total As Integer = 0
        Dim toppingsTotal As Integer = 0
        Dim sideOrdersTotal As Integer = 0
        Dim drinksTotal As Integer = 0


        If rbSmall.Checked Then
            total += 250
        ElseIf rbMedium.Checked Then
            total += 350
        ElseIf rbLarge.Checked Then
            total += 400
        End If

        If chkCheese.Checked Then toppingsTotal += 25
        If chkPepperoni.Checked Then toppingsTotal += 50
        If chkSausage.Checked Then toppingsTotal += 40
        If chkOnions.Checked Then toppingsTotal += 15
        If chkOlives.Checked Then toppingsTotal += 25

        txtToppingsTotal.Text = toppingsTotal.ToString()
        total += toppingsTotal


        Dim breadSticksTotal As Integer = Val(txtBreadSticks.Text) * 30
        Dim chickenWingsTotal As Integer = Val(txtChickenWings.Text) * 90

        txtBreadSticksTotal.Text = breadSticksTotal.ToString()
        txtChickenWingsTotal.Text = chickenWingsTotal.ToString()

        sideOrdersTotal = breadSticksTotal + chickenWingsTotal
        txtSideOrdersTotal.Text = sideOrdersTotal.ToString()
        total += sideOrdersTotal


        Dim sodaCanTotal As Integer = Val(txtSodaCan.Text) * 30
        Dim soda8ozTotal As Integer = Val(txtSoda8oz.Text) * 15
        Dim soda15LTotal As Integer = Val(txtSoda15L.Text) * 60
        Dim juiceTotal As Integer = Val(txtJuice.Text) * 30
        Dim waterTotal As Integer = Val(txtWater.Text) * 20

        txtSodaCanTotal.Text = sodaCanTotal.ToString()
        txtSoda8ozTotal.Text = soda8ozTotal.ToString()
        txtSoda15LTotal.Text = soda15LTotal.ToString()
        txtJuiceTotal.Text = juiceTotal.ToString()
        txtWaterTotal.Text = waterTotal.ToString()

        drinksTotal = sodaCanTotal + soda8ozTotal + soda15LTotal + juiceTotal + waterTotal
        txtDrinksTotal.Text = drinksTotal.ToString()
        total += drinksTotal


        txtTotal.Text = total.ToString()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class