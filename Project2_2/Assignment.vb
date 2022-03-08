Public Class Assignment
    Private Sub Assignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to log out?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            MessageBox.Show("Successfully log out!")
            Application.Exit()
        End If
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Dashboardform.Show()
        Me.Hide()
    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        CourseSelection.Show()
        Me.Hide()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        MessageBox.Show("Data saved!")


    End Sub
End Class