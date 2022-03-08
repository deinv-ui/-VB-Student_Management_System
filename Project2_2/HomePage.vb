Public Class HomePage
    ' code written by Tan De Xin
    ' As a management system assigment march 2022
    ' type of system :Student Management System
    ' database used: Ms Access 2022
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblCourse.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblBirth.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblIC.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter1.Fill(Me.Database1DataSet.Student)
        'TODO: This line of code loads data into the 'Test1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Test1.Student)



    End Sub

    Private Sub btnPre_Click(sender As Object, e As EventArgs) Handles btnPre.Click
        StudentBindingSource1.MovePrevious()



    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Dashboardform.Show()
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

    Private Sub comboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCourse.SelectedIndexChanged

    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click

    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub txtIC_TextChanged(sender As Object, e As EventArgs) Handles txtIC.TextChanged

    End Sub

    Private Sub txtDate_ValueChanged(sender As Object, e As EventArgs) Handles txtDate.ValueChanged

    End Sub

    Private Sub btnNex_Click(sender As Object, e As EventArgs) Handles btnNex.Click
        StudentBindingSource1.MoveNext()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        StudentBindingSource.AddNew()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        On Error GoTo SaveErr
        StudentBindingSource1.EndEdit()
        StudentTableAdapter1.Update(Database1DataSet.Student)
        MessageBox.Show("Data saved!")

SaveErr:
        Exit Sub

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'delete record
        StudentBindingSource1.RemoveCurrent()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        'declare response of user as a var
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to log out?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            MessageBox.Show("Successfully log out!")
            'Exit Apps
            Application.Exit()
        End If


    End Sub
End Class