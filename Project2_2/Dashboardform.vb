Public Class Dashboardform
    Private Sub lblActivities_Click(sender As Object, e As EventArgs) Handles lblActivities.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnAss_Click(sender As Object, e As EventArgs) Handles btnAss.Click
        Assignment.Show()
        Me.Hide()
    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        CourseSelection.Show()
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

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub
End Class