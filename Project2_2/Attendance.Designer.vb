<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StudentAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAtten = New System.Windows.Forms.TextBox()
        Me.AttendanceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceDataSet = New Project2.AttendanceDataSet()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lblAtten = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.btnAss = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnDash = New System.Windows.Forms.Button()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceTableAdapter = New Project2.AttendanceDataSetTableAdapters.AttendanceTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Database1DataSet = New Project2.Database1DataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New Project2.Database1DataSetTableAdapters.StudentTableAdapter()
        CType(Me.StudentAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentAttendanceBindingSource
        '
        Me.StudentAttendanceBindingSource.DataMember = "StudentAttendance"
        '
        'txtAtten
        '
        Me.txtAtten.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AttendanceBindingSource1, "StudentName", True))
        Me.txtAtten.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtten.Location = New System.Drawing.Point(217, 142)
        Me.txtAtten.Name = "txtAtten"
        Me.txtAtten.Size = New System.Drawing.Size(382, 29)
        Me.txtAtten.TabIndex = 79
        '
        'AttendanceBindingSource1
        '
        Me.AttendanceBindingSource1.DataMember = "Attendance"
        Me.AttendanceBindingSource1.DataSource = Me.AttendanceDataSet
        '
        'AttendanceDataSet
        '
        Me.AttendanceDataSet.DataSetName = "AttendanceDataSet"
        Me.AttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.OrangeRed
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(720, 139)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(108, 38)
        Me.Button9.TabIndex = 78
        Me.Button9.Text = "List All"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.OrangeRed
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(605, 139)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 38)
        Me.Button8.TabIndex = 76
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'lblAtten
        '
        Me.lblAtten.AutoSize = True
        Me.lblAtten.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtten.Location = New System.Drawing.Point(213, 105)
        Me.lblAtten.Name = "lblAtten"
        Me.lblAtten.Size = New System.Drawing.Size(126, 24)
        Me.lblAtten.TabIndex = 75
        Me.lblAtten.Text = "Attendance"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Project2.My.Resources.Resources._4829769
        Me.PictureBox2.Location = New System.Drawing.Point(-317, -333)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1540, 910)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 81
        Me.PictureBox2.TabStop = False
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.OrangeRed
        Me.btnLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo.ForeColor = System.Drawing.Color.White
        Me.btnLogo.Location = New System.Drawing.Point(12, 12)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(91, 42)
        Me.btnLogo.TabIndex = 86
        Me.btnLogo.Text = "Log out"
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'btnAss
        '
        Me.btnAss.BackColor = System.Drawing.Color.OrangeRed
        Me.btnAss.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAss.ForeColor = System.Drawing.Color.White
        Me.btnAss.Location = New System.Drawing.Point(2, 259)
        Me.btnAss.Name = "btnAss"
        Me.btnAss.Size = New System.Drawing.Size(130, 47)
        Me.btnAss.TabIndex = 84
        Me.btnAss.Text = "Assignments"
        Me.btnAss.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.OrangeRed
        Me.btnProfile.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Location = New System.Drawing.Point(2, 215)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(130, 45)
        Me.btnProfile.TabIndex = 82
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnDash
        '
        Me.btnDash.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDash.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDash.ForeColor = System.Drawing.Color.White
        Me.btnDash.Location = New System.Drawing.Point(2, 177)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Size = New System.Drawing.Size(130, 44)
        Me.btnDash.TabIndex = 85
        Me.btnDash.Text = "Dashboard"
        Me.btnDash.UseVisualStyleBackColor = False
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCourse.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.ForeColor = System.Drawing.Color.White
        Me.btnCourse.Location = New System.Drawing.Point(2, 303)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(146, 48)
        Me.btnCourse.TabIndex = 83
        Me.btnCourse.Text = "Courses"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.AttendanceRateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AttendanceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(217, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 251)
        Me.DataGridView1.TabIndex = 87
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'AttendanceRateDataGridViewTextBoxColumn
        '
        Me.AttendanceRateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceRate"
        Me.AttendanceRateDataGridViewTextBoxColumn.HeaderText = "AttendanceRate"
        Me.AttendanceRateDataGridViewTextBoxColumn.Name = "AttendanceRateDataGridViewTextBoxColumn"
        '
        'AttendanceBindingSource
        '
        Me.AttendanceBindingSource.DataMember = "Attendance"
        Me.AttendanceBindingSource.DataSource = Me.AttendanceDataSet
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(41, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 38)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Attendance"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(41, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 65)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Course Selection"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Database1DataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(906, 516)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtAtten)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.lblAtten)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.btnAss)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnDash)
        Me.Controls.Add(Me.btnCourse)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance"
        CType(Me.StudentAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAtten As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents lblAtten As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogo As Button
    Friend WithEvents btnAss As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents btnCourse As Button

    Friend WithEvents StudentAttendanceBindingSource As BindingSource

    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbsencesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AttendanceDataSet As AttendanceDataSet
    Friend WithEvents AttendanceBindingSource As BindingSource
    Friend WithEvents AttendanceTableAdapter As AttendanceDataSetTableAdapters.AttendanceTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AttendanceBindingSource1 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As Database1DataSetTableAdapters.StudentTableAdapter
End Class
