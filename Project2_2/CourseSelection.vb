Public Class CourseSelection
    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Dashboardform.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnAss_Click(sender As Object, e As EventArgs) Handles btnAss.Click
        Assignment.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to log out?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            MessageBox.Show("Successfully log out!")
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Attendance.Show()
        Me.Hide()
    End Sub
End Class