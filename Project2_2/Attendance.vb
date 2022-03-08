Public Class Attendance
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to log out?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            MessageBox.Show("Successfully log out!")
            Application.Exit()
        End If
    End Sub

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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.StudentAttendanceBindingSource.Filter = "StudentName LIKE'" & txtAtten.Text & "%' "
    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Database1DataSet.Student)
        'TODO: This line of code loads data into the 'AttendanceDataSet.Attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.AttendanceDataSet.Attendance)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CourseSelection.Show()
        Me.Hide()
    End Sub

    Private Sub txtAtten_TextChanged(sender As Object, e As EventArgs) Handles txtAtten.TextChanged

    End Sub
End Class