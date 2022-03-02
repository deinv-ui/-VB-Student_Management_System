Public Class HomePage
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblCourse.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblBirth.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblIC.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Test1.Student)

    End Sub
End Class