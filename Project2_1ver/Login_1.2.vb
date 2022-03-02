Public Class Login
    Private Sub txtlogin_Click(sender As Object, e As EventArgs) Handles txtlogin.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test1.Userpwd' table. You can move, or remove it, as needed.
        Me.UserpwdTableAdapter.Fill(Me.Test1.Userpwd)
        'TODO: This line of code loads data into the 'Student11DataSet.userpwd' table. You can move, or remove it, as needed.


    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        Me.UserpwdTableAdapter.FillBy(Me.Test1.Userpwd, txtuser.Text, txtpwd.Text)
    End Sub

    Private Sub txtpwd_TextChanged(sender As Object, e As EventArgs) Handles txtpwd.TextChanged
        Me.UserpwdTableAdapter.FillBy(Me.Test1.Userpwd, txtuser.Text, txtpwd.Text)
    End Sub
End Class
