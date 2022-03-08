<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assignment
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
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.lblLec = New System.Windows.Forms.Label()
        Me.lblAss = New System.Windows.Forms.Label()
        Me.Remarks = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblUnfin = New System.Windows.Forms.Label()
        Me.lblfin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDash = New System.Windows.Forms.Button()
        Me.btnAss = New System.Windows.Forms.Button()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnLogo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Items.AddRange(New Object() {"Tutorial 8", "", "Final Project"})
        Me.ListBox3.Location = New System.Drawing.Point(613, 154)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(207, 199)
        Me.ListBox3.TabIndex = 61
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Items.AddRange(New Object() {"Tutorial 5", "", "Assignment 1"})
        Me.ListBox2.Location = New System.Drawing.Point(374, 154)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(207, 199)
        Me.ListBox2.TabIndex = 60
        '
        'lblLec
        '
        Me.lblLec.AutoSize = True
        Me.lblLec.BackColor = System.Drawing.Color.Transparent
        Me.lblLec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLec.Location = New System.Drawing.Point(179, 116)
        Me.lblLec.Name = "lblLec"
        Me.lblLec.Size = New System.Drawing.Size(161, 25)
        Me.lblLec.TabIndex = 59
        Me.lblLec.Text = "Lecture's note"
        '
        'lblAss
        '
        Me.lblAss.AutoSize = True
        Me.lblAss.BackColor = System.Drawing.Color.Transparent
        Me.lblAss.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAss.Location = New System.Drawing.Point(368, 68)
        Me.lblAss.Name = "lblAss"
        Me.lblAss.Size = New System.Drawing.Size(221, 31)
        Me.lblAss.TabIndex = 58
        Me.lblAss.Text = "Assignment List"
        '
        'Remarks
        '
        Me.Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remarks.FormattingEnabled = True
        Me.Remarks.ItemHeight = 15
        Me.Remarks.Items.AddRange(New Object() {"Mid term 20 March 2022.", "", "Approval letter for programme "})
        Me.Remarks.Location = New System.Drawing.Point(181, 154)
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(171, 199)
        Me.Remarks.TabIndex = 57
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(676, 374)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(143, 38)
        Me.btnSubmit.TabIndex = 56
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblUnfin
        '
        Me.lblUnfin.AutoSize = True
        Me.lblUnfin.BackColor = System.Drawing.Color.Transparent
        Me.lblUnfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnfin.Location = New System.Drawing.Point(612, 116)
        Me.lblUnfin.Name = "lblUnfin"
        Me.lblUnfin.Size = New System.Drawing.Size(85, 24)
        Me.lblUnfin.TabIndex = 58
        Me.lblUnfin.Text = "Unfinish"
        '
        'lblfin
        '
        Me.lblfin.AutoSize = True
        Me.lblfin.BackColor = System.Drawing.Color.Transparent
        Me.lblfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfin.Location = New System.Drawing.Point(370, 115)
        Me.lblfin.Name = "lblfin"
        Me.lblfin.Size = New System.Drawing.Size(67, 24)
        Me.lblfin.TabIndex = 58
        Me.lblfin.Text = "Finish"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources._4829769
        Me.PictureBox1.Location = New System.Drawing.Point(-317, -333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1540, 910)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'btnDash
        '
        Me.btnDash.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDash.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDash.ForeColor = System.Drawing.Color.White
        Me.btnDash.Location = New System.Drawing.Point(0, 169)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Size = New System.Drawing.Size(130, 44)
        Me.btnDash.TabIndex = 66
        Me.btnDash.Text = "Dashboard"
        Me.btnDash.UseVisualStyleBackColor = False
        '
        'btnAss
        '
        Me.btnAss.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAss.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAss.ForeColor = System.Drawing.Color.White
        Me.btnAss.Location = New System.Drawing.Point(0, 251)
        Me.btnAss.Name = "btnAss"
        Me.btnAss.Size = New System.Drawing.Size(146, 47)
        Me.btnAss.TabIndex = 65
        Me.btnAss.Text = "Assignments"
        Me.btnAss.UseVisualStyleBackColor = False
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCourse.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.ForeColor = System.Drawing.Color.White
        Me.btnCourse.Location = New System.Drawing.Point(0, 295)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(130, 48)
        Me.btnCourse.TabIndex = 64
        Me.btnCourse.Text = "Courses"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.OrangeRed
        Me.btnProfile.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Location = New System.Drawing.Point(0, 207)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(130, 45)
        Me.btnProfile.TabIndex = 63
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.OrangeRed
        Me.btnLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo.ForeColor = System.Drawing.Color.White
        Me.btnLogo.Location = New System.Drawing.Point(12, 12)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(91, 42)
        Me.btnLogo.TabIndex = 67
        Me.btnLogo.Text = "Log out"
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'Assignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(906, 516)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.btnDash)
        Me.Controls.Add(Me.btnAss)
        Me.Controls.Add(Me.btnCourse)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.lblLec)
        Me.Controls.Add(Me.lblfin)
        Me.Controls.Add(Me.lblUnfin)
        Me.Controls.Add(Me.lblAss)
        Me.Controls.Add(Me.Remarks)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Assignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assignment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents lblLec As Label
    Friend WithEvents lblAss As Label
    Friend WithEvents Remarks As ListBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblUnfin As Label
    Friend WithEvents lblfin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDash As Button
    Friend WithEvents btnAss As Button
    Friend WithEvents btnCourse As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogo As Button
End Class
