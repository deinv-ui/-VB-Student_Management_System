<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnregister = New System.Windows.Forms.LinkLabel()
        Me.btnpwd = New System.Windows.Forms.LinkLabel()
        Me.cbpwd = New System.Windows.Forms.CheckBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.Label()
        Me.txtlogin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnregister
        '
        Me.btnregister.AutoSize = True
        Me.btnregister.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.LinkColor = System.Drawing.Color.Red
        Me.btnregister.Location = New System.Drawing.Point(709, 378)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(55, 16)
        Me.btnregister.TabIndex = 13
        Me.btnregister.TabStop = True
        Me.btnregister.Text = "Register"
        Me.btnregister.UseWaitCursor = True
        Me.btnregister.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'btnpwd
        '
        Me.btnpwd.AutoSize = True
        Me.btnpwd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpwd.LinkColor = System.Drawing.Color.Red
        Me.btnpwd.Location = New System.Drawing.Point(709, 278)
        Me.btnpwd.Name = "btnpwd"
        Me.btnpwd.Size = New System.Drawing.Size(105, 16)
        Me.btnpwd.TabIndex = 14
        Me.btnpwd.TabStop = True
        Me.btnpwd.Text = "Forgot Password"
        Me.btnpwd.UseWaitCursor = True
        Me.btnpwd.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'cbpwd
        '
        Me.cbpwd.AutoSize = True
        Me.cbpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpwd.Location = New System.Drawing.Point(460, 293)
        Me.cbpwd.Name = "cbpwd"
        Me.cbpwd.Size = New System.Drawing.Size(157, 20)
        Me.cbpwd.TabIndex = 12
        Me.cbpwd.Text = "Remember Password"
        Me.cbpwd.UseVisualStyleBackColor = True
        Me.cbpwd.UseWaitCursor = True
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.OrangeRed
        Me.btnlogin.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(446, 349)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(255, 62)
        Me.btnlogin.TabIndex = 11
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.UseVisualStyleBackColor = False
        Me.btnlogin.UseWaitCursor = True
        '
        'txtpwd
        '
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(446, 265)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(257, 26)
        Me.txtpwd.TabIndex = 9
        Me.txtpwd.UseWaitCursor = True
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(446, 175)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(257, 26)
        Me.txtuser.TabIndex = 10
        Me.txtuser.UseWaitCursor = True
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.Location = New System.Drawing.Point(455, 235)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(86, 19)
        Me.pwd.TabIndex = 6
        Me.pwd.Text = "Password"
        Me.pwd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pwd.UseWaitCursor = True
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(455, 146)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(59, 19)
        Me.user.TabIndex = 7
        Me.user.Text = "UserId"
        Me.user.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.user.UseWaitCursor = True
        '
        'txtlogin
        '
        Me.txtlogin.AutoSize = True
        Me.txtlogin.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlogin.Location = New System.Drawing.Point(529, 59)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(130, 44)
        Me.txtlogin.TabIndex = 8
        Me.txtlogin.Text = "Log In"
        Me.txtlogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtlogin.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources._5293
        Me.PictureBox1.Location = New System.Drawing.Point(-254, -131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1055, 716)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(840, 487)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.btnpwd)
        Me.Controls.Add(Me.cbpwd)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.txtlogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.Text = "Login"
        Me.UseWaitCursor = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnregister As LinkLabel
    Friend WithEvents btnpwd As LinkLabel
    Friend WithEvents cbpwd As CheckBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtpwd As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents pwd As Label
    Friend WithEvents user As Label
    Friend WithEvents txtlogin As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
