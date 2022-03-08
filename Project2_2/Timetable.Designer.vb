<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timetable
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
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnSear = New System.Windows.Forms.Button()
        Me.lbltimetable = New System.Windows.Forms.Label()
        Me.gridTime = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnDash = New System.Windows.Forms.Button()
        Me.btnAss = New System.Windows.Forms.Button()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogo = New System.Windows.Forms.Button()
        CType(Me.gridTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(206, 108)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(369, 26)
        Me.txtTime.TabIndex = 61
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.OrangeRed
        Me.btnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.ForeColor = System.Drawing.Color.White
        Me.btnList.Location = New System.Drawing.Point(711, 98)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(108, 38)
        Me.btnList.TabIndex = 60
        Me.btnList.Text = "List All"
        Me.btnList.UseVisualStyleBackColor = False
        '
        'btnSear
        '
        Me.btnSear.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSear.ForeColor = System.Drawing.Color.White
        Me.btnSear.Location = New System.Drawing.Point(597, 98)
        Me.btnSear.Name = "btnSear"
        Me.btnSear.Size = New System.Drawing.Size(108, 38)
        Me.btnSear.TabIndex = 59
        Me.btnSear.Text = "Search"
        Me.btnSear.UseVisualStyleBackColor = False
        '
        'lbltimetable
        '
        Me.lbltimetable.AutoSize = True
        Me.lbltimetable.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimetable.Location = New System.Drawing.Point(202, 76)
        Me.lbltimetable.Name = "lbltimetable"
        Me.lbltimetable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltimetable.Size = New System.Drawing.Size(108, 24)
        Me.lbltimetable.TabIndex = 57
        Me.lbltimetable.Text = "Timetable"
        '
        'gridTime
        '
        Me.gridTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.gridTime.Location = New System.Drawing.Point(206, 153)
        Me.gridTime.Name = "gridTime"
        Me.gridTime.Size = New System.Drawing.Size(613, 274)
        Me.gridTime.TabIndex = 62
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
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
        Me.btnAss.BackColor = System.Drawing.Color.OrangeRed
        Me.btnAss.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAss.ForeColor = System.Drawing.Color.White
        Me.btnAss.Location = New System.Drawing.Point(0, 251)
        Me.btnAss.Name = "btnAss"
        Me.btnAss.Size = New System.Drawing.Size(130, 47)
        Me.btnAss.TabIndex = 65
        Me.btnAss.Text = "Assignments"
        Me.btnAss.UseVisualStyleBackColor = False
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCourse.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.ForeColor = System.Drawing.Color.White
        Me.btnCourse.Location = New System.Drawing.Point(0, 295)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(146, 48)
        Me.btnCourse.TabIndex = 64
        Me.btnCourse.Text = "Courses"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = "-317, -333"
        Me.PictureBox1.Location = New System.Drawing.Point(-350, -212)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1540, 910)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Project2.My.Resources.Resources._4829769
        Me.PictureBox2.Location = New System.Drawing.Point(-317, -333)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1540, 910)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.OrangeRed
        Me.btnLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo.ForeColor = System.Drawing.Color.White
        Me.btnLogo.Location = New System.Drawing.Point(728, 12)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(91, 42)
        Me.btnLogo.TabIndex = 69
        Me.btnLogo.Text = "Log out"
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'Timetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(906, 516)
        Me.Controls.Add(Me.btnAss)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnDash)
        Me.Controls.Add(Me.btnCourse)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnSear)
        Me.Controls.Add(Me.lbltimetable)
        Me.Controls.Add(Me.gridTime)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Timetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timetable"
        CType(Me.gridTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTime As TextBox
    Friend WithEvents btnList As Button
    Friend WithEvents btnSear As Button
    Friend WithEvents lbltimetable As Label
    Friend WithEvents gridTime As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents btnAss As Button
    Friend WithEvents btnCourse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogo As Button
End Class
