Public Class Login
    Private Sub txtlogin_Click(sender As Object, e As EventArgs) Handles txtlogin.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Userpwd' table. You can move, or remove it, as needed.
        Me.UserpwdTableAdapter1.Fill(Me.Database1DataSet.Userpwd)
        'TODO: This line of code loads data into the 'Test1.Userpwd' table. You can move, or remove it, as needed.
        Me.UserpwdTableAdapter.Fill(Me.Test1.Userpwd)
        'TODO: This line of code loads data into the 'Student11DataSet.userpwd' table. You can move, or remove it, as needed.


    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        Me.UserpwdTableAdapter1.FillBy(Me.Database1DataSet.Userpwd, txtuser.Text, txtpwd.Text)
    End Sub

    Private Sub txtpwd_TextChanged(sender As Object, e As EventArgs) Handles txtpwd.TextChanged
        Me.UserpwdTableAdapter1.FillBy(Me.Database1DataSet.Userpwd, txtuser.Text, txtpwd.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "" And txtpwd.Text = "" Then
            MsgBox("Invalid username and password", MsgBoxStyle.OkCancel, "Message")
        ElseIf txtuser.Text = UsernameTextBox.Text And txtpwd.Text = PasswordTextBox.Text Then
            MsgBox("Successfully log in!", MsgBoxStyle.OkOnly, "Welcome " + FirstNameTextBox.Text)
            HomePage.Show()
            Me.Hide()

        Else
            MsgBox("Invalid username and password", MsgBoxStyle.OkCancel, "Message")
        End If
    End Sub

    Private Sub cbpwd_CheckedChanged(sender As Object, e As EventArgs) Handles cbpwd.CheckedChanged

    End Sub
End Class
