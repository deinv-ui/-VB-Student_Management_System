<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Dim ContactnoLabel As System.Windows.Forms.Label
        Dim DateofBirthLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CoursesLabel As System.Windows.Forms.Label
        Dim StudentICLabel As System.Windows.Forms.Label
        Dim StudentNameLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNex = New System.Windows.Forms.Button()
        Me.btnPre = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Project2.Database1DataSet()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.btnDash = New System.Windows.Forms.Button()
        Me.btnAss = New System.Windows.Forms.Button()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentICTextBox = New System.Windows.Forms.TextBox()
        Me.CoursesTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DateofBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ContactnoTextBox = New System.Windows.Forms.TextBox()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test1 = New Project2.Test1()
        Me.StudentTableAdapter = New Project2.Test1TableAdapters.StudentTableAdapter()
        Me.StudentTableAdapter1 = New Project2.Database1DataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New Project2.Database1DataSetTableAdapters.TableAdapterManager()
        ContactnoLabel = New System.Windows.Forms.Label()
        DateofBirthLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CoursesLabel = New System.Windows.Forms.Label()
        StudentICLabel = New System.Windows.Forms.Label()
        StudentNameLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactnoLabel
        '
        ContactnoLabel.AutoSize = True
        ContactnoLabel.Location = New System.Drawing.Point(838, 345)
        ContactnoLabel.Name = "ContactnoLabel"
        ContactnoLabel.Size = New System.Drawing.Size(59, 13)
        ContactnoLabel.TabIndex = 13
        ContactnoLabel.Text = "Contactno:"
        '
        'DateofBirthLabel
        '
        DateofBirthLabel.AutoSize = True
        DateofBirthLabel.Location = New System.Drawing.Point(838, 320)
        DateofBirthLabel.Name = "DateofBirthLabel"
        DateofBirthLabel.Size = New System.Drawing.Size(66, 13)
        DateofBirthLabel.TabIndex = 11
        DateofBirthLabel.Text = "Dateof Birth:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(838, 293)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'CoursesLabel
        '
        CoursesLabel.AutoSize = True
        CoursesLabel.Location = New System.Drawing.Point(838, 267)
        CoursesLabel.Name = "CoursesLabel"
        CoursesLabel.Size = New System.Drawing.Size(48, 13)
        CoursesLabel.TabIndex = 7
        CoursesLabel.Text = "Courses:"
        '
        'StudentICLabel
        '
        StudentICLabel.AutoSize = True
        StudentICLabel.Location = New System.Drawing.Point(838, 241)
        StudentICLabel.Name = "StudentICLabel"
        StudentICLabel.Size = New System.Drawing.Size(60, 13)
        StudentICLabel.TabIndex = 5
        StudentICLabel.Text = "Student IC:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(838, 215)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(78, 13)
        StudentNameLabel.TabIndex = 3
        StudentNameLabel.Text = "Student Name:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(838, 189)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNex)
        Me.Panel1.Controls.Add(Me.btnPre)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnnew)
        Me.Panel1.Controls.Add(Me.comboCourse)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.txtIC)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblBirth)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblIC)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblContact)
        Me.Panel1.Controls.Add(Me.lblCourse)
        Me.Panel1.Controls.Add(Me.btnLogo)
        Me.Panel1.Controls.Add(Me.btnDash)
        Me.Panel1.Controls.Add(Me.btnAss)
        Me.Panel1.Controls.Add(Me.btnCourse)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(StudentNameLabel)
        Me.Panel1.Controls.Add(Me.StudentNameTextBox)
        Me.Panel1.Controls.Add(StudentICLabel)
        Me.Panel1.Controls.Add(Me.StudentICTextBox)
        Me.Panel1.Controls.Add(CoursesLabel)
        Me.Panel1.Controls.Add(Me.CoursesTextBox)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(DateofBirthLabel)
        Me.Panel1.Controls.Add(Me.DateofBirthDateTimePicker)
        Me.Panel1.Controls.Add(ContactnoLabel)
        Me.Panel1.Controls.Add(Me.ContactnoTextBox)
        Me.Panel1.Controls.Add(Me.StudentDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 520)
        Me.Panel1.TabIndex = 0
        '
        'btnNex
        '
        Me.btnNex.BackColor = System.Drawing.Color.OrangeRed
        Me.btnNex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNex.ForeColor = System.Drawing.Color.White
        Me.btnNex.Location = New System.Drawing.Point(762, 395)
        Me.btnNex.Name = "btnNex"
        Me.btnNex.Size = New System.Drawing.Size(70, 35)
        Me.btnNex.TabIndex = 59
        Me.btnNex.Text = "Next"
        Me.btnNex.UseVisualStyleBackColor = False
        '
        'btnPre
        '
        Me.btnPre.BackColor = System.Drawing.Color.OrangeRed
        Me.btnPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPre.ForeColor = System.Drawing.Color.White
        Me.btnPre.Location = New System.Drawing.Point(686, 395)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(70, 35)
        Me.btnPre.TabIndex = 59
        Me.btnPre.Text = "Previous"
        Me.btnPre.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProfile.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Location = New System.Drawing.Point(0, 207)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(146, 45)
        Me.btnProfile.TabIndex = 13
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(384, 395)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 35)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtDate
        '
        Me.txtDate.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "DateofBirth", True))
        Me.txtDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(659, 164)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(173, 26)
        Me.txtDate.TabIndex = 28
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "Student"
        Me.StudentBindingSource1.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.OrangeRed
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(293, 395)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(72, 35)
        Me.btnsave.TabIndex = 22
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.OrangeRed
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(205, 395)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(72, 35)
        Me.btnnew.TabIndex = 22
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'comboCourse
        '
        Me.comboCourse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Courses", True))
        Me.comboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Items.AddRange(New Object() {"DIIT", "DBCS", "DCS"})
        Me.comboCourse.Location = New System.Drawing.Point(659, 259)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(173, 28)
        Me.comboCourse.TabIndex = 27
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(472, 395)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(72, 35)
        Me.btnexit.TabIndex = 22
        Me.btnexit.Text = "Delete"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'txtIC
        '
        Me.txtIC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "StudentIC", True))
        Me.txtIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIC.Location = New System.Drawing.Point(659, 212)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(173, 26)
        Me.txtIC.TabIndex = 26
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(315, 302)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 26)
        Me.txtEmail.TabIndex = 26
        '
        'txtContact
        '
        Me.txtContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Contactno", True))
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(315, 259)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(173, 26)
        Me.txtContact.TabIndex = 26
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "ID", True))
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(315, 212)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(173, 26)
        Me.txtID.TabIndex = 26
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "StudentName", True))
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(315, 164)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(173, 26)
        Me.txtName.TabIndex = 26
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.BackColor = System.Drawing.Color.Transparent
        Me.lblBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirth.Location = New System.Drawing.Point(526, 170)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(98, 20)
        Me.lblBirth.TabIndex = 25
        Me.lblBirth.Text = "Day of birth :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(207, 170)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 20)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "Name :"
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.BackColor = System.Drawing.Color.Transparent
        Me.lblIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(526, 215)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(100, 20)
        Me.lblIC.TabIndex = 24
        Me.lblIC.Text = "IC/Passport :"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(207, 218)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(72, 20)
        Me.lblUser.TabIndex = 18
        Me.lblUser.Text = "User ID :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(207, 310)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 20)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "Email :"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(207, 265)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(73, 20)
        Me.lblContact.TabIndex = 20
        Me.lblContact.Text = "Contact :"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(523, 262)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(76, 20)
        Me.lblCourse.TabIndex = 21
        Me.lblCourse.Text = "Courses :"
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.OrangeRed
        Me.btnLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo.ForeColor = System.Drawing.Color.White
        Me.btnLogo.Location = New System.Drawing.Point(12, 12)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(91, 42)
        Me.btnLogo.TabIndex = 23
        Me.btnLogo.Text = "Log out"
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'btnDash
        '
        Me.btnDash.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDash.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDash.ForeColor = System.Drawing.Color.White
        Me.btnDash.Location = New System.Drawing.Point(0, 169)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Size = New System.Drawing.Size(130, 44)
        Me.btnDash.TabIndex = 16
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
        Me.btnAss.TabIndex = 15
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
        Me.btnCourse.TabIndex = 14
        Me.btnCourse.Text = "Courses"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources._4829769
        Me.PictureBox1.Location = New System.Drawing.Point(-317, -333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1540, 910)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(922, 186)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "StudentName", True))
        Me.StudentNameTextBox.Location = New System.Drawing.Point(922, 212)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StudentNameTextBox.TabIndex = 4
        '
        'StudentICTextBox
        '
        Me.StudentICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "StudentIC", True))
        Me.StudentICTextBox.Location = New System.Drawing.Point(922, 238)
        Me.StudentICTextBox.Name = "StudentICTextBox"
        Me.StudentICTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StudentICTextBox.TabIndex = 6
        '
        'CoursesTextBox
        '
        Me.CoursesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Courses", True))
        Me.CoursesTextBox.Location = New System.Drawing.Point(922, 264)
        Me.CoursesTextBox.Name = "CoursesTextBox"
        Me.CoursesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CoursesTextBox.TabIndex = 8
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(922, 290)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'DateofBirthDateTimePicker
        '
        Me.DateofBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentBindingSource1, "DateofBirth", True))
        Me.DateofBirthDateTimePicker.Location = New System.Drawing.Point(922, 316)
        Me.DateofBirthDateTimePicker.Name = "DateofBirthDateTimePicker"
        Me.DateofBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateofBirthDateTimePicker.TabIndex = 12
        '
        'ContactnoTextBox
        '
        Me.ContactnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Contactno", True))
        Me.ContactnoTextBox.Location = New System.Drawing.Point(922, 342)
        Me.ContactnoTextBox.Name = "ContactnoTextBox"
        Me.ContactnoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContactnoTextBox.TabIndex = 14
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource1
        Me.StudentDataGridView.Location = New System.Drawing.Point(12, 373)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.Size = New System.Drawing.Size(411, 117)
        Me.StudentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StudentIC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StudentIC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Courses"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Courses"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DateofBirth"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DateofBirth"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Contactno"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contactno"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Test1
        '
        'Test1
        '
        Me.Test1.DataSetName = "Test1"
        Me.Test1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter1
        '
        Me.StudentTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter1
        Me.TableAdapterManager.UpdateOrder = Project2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserpwdTableAdapter = Nothing
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(906, 516)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomePage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBirth As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnnew As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCourse As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents btnAss As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Test1 As Test1
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As Test1TableAdapters.StudentTableAdapter
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents StudentBindingSource1 As BindingSource
    Friend WithEvents StudentTableAdapter1 As Database1DataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents StudentICTextBox As TextBox
    Friend WithEvents CoursesTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DateofBirthDateTimePicker As DateTimePicker
    Friend WithEvents ContactnoTextBox As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents txtIC As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnNex As Button
    Friend WithEvents btnPre As Button
    Friend WithEvents StudentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
