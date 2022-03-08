<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Me.btnregister = New System.Windows.Forms.LinkLabel()
        Me.btnpwd = New System.Windows.Forms.LinkLabel()
        Me.cbpwd = New System.Windows.Forms.CheckBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.UserpwdBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test1 = New Project2.Test1()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.Label()
        Me.txtlogin = New System.Windows.Forms.Label()
        Me.UserpwdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UserpwdTableAdapter = New Project2.Test1TableAdapters.UserpwdTableAdapter()
        Me.TableAdapterManager = New Project2.Test1TableAdapters.TableAdapterManager()
        Me.UserpwdBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Project2.Database1DataSet()
        Me.UserpwdBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserpwdDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserpwdBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserpwdBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserpwdBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserpwdBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserpwdBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserpwdTableAdapter1 = New Project2.Database1DataSetTableAdapters.UserpwdTableAdapter()
        Me.TableAdapterManager1 = New Project2.Database1DataSetTableAdapters.TableAdapterManager()
        Me.Database1DataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        CType(Me.UserpwdBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(40, 239)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 21
        IDLabel.Text = "ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(40, 265)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 23
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(40, 291)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 25
        PasswordLabel.Text = "Password:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(40, 317)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 27
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(40, 343)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 29
        LastNameLabel.Text = "Last Name:"
        '
        'btnregister
        '
        Me.btnregister.AutoSize = True
        Me.btnregister.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.LinkColor = System.Drawing.Color.Red
        Me.btnregister.Location = New System.Drawing.Point(777, 388)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(55, 16)
        Me.btnregister.TabIndex = 13
        Me.btnregister.TabStop = True
        Me.btnregister.Text = "Register"
        Me.btnregister.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'btnpwd
        '
        Me.btnpwd.AutoSize = True
        Me.btnpwd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpwd.LinkColor = System.Drawing.Color.Red
        Me.btnpwd.Location = New System.Drawing.Point(777, 288)
        Me.btnpwd.Name = "btnpwd"
        Me.btnpwd.Size = New System.Drawing.Size(105, 16)
        Me.btnpwd.TabIndex = 14
        Me.btnpwd.TabStop = True
        Me.btnpwd.Text = "Forgot Password"
        Me.btnpwd.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'cbpwd
        '
        Me.cbpwd.AutoSize = True
        Me.cbpwd.Checked = True
        Me.cbpwd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpwd.Location = New System.Drawing.Point(528, 303)
        Me.cbpwd.Name = "cbpwd"
        Me.cbpwd.Size = New System.Drawing.Size(157, 20)
        Me.cbpwd.TabIndex = 12
        Me.cbpwd.Text = "Remember Password"
        Me.cbpwd.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.OrangeRed
        Me.btnlogin.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(514, 359)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(255, 62)
        Me.btnlogin.TabIndex = 11
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtpwd
        '
        Me.txtpwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource1, "Password", True))
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(514, 275)
        Me.txtpwd.Margin = New System.Windows.Forms.Padding(5)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(257, 26)
        Me.txtpwd.TabIndex = 9
        Me.txtpwd.UseSystemPasswordChar = True
        '
        'UserpwdBindingSource1
        '
        Me.UserpwdBindingSource1.DataMember = "Userpwd"
        Me.UserpwdBindingSource1.DataSource = Me.Test1
        '
        'Test1
        '
        Me.Test1.DataSetName = "Test1"
        Me.Test1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtuser
        '
        Me.txtuser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource1, "Username", True))
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(514, 185)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(5)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(257, 26)
        Me.txtuser.TabIndex = 10
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.Location = New System.Drawing.Point(523, 245)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(86, 19)
        Me.pwd.TabIndex = 6
        Me.pwd.Text = "Password"
        Me.pwd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(523, 156)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(87, 19)
        Me.user.TabIndex = 7
        Me.user.Text = "Username"
        Me.user.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtlogin
        '
        Me.txtlogin.AutoSize = True
        Me.txtlogin.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlogin.Location = New System.Drawing.Point(597, 69)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(130, 44)
        Me.txtlogin.TabIndex = 8
        Me.txtlogin.Text = "Log In"
        Me.txtlogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UserpwdBindingSource
        '
        Me.UserpwdBindingSource.DataMember = "Userpwd"
        Me.UserpwdBindingSource.DataSource = Me.Test1BindingSource
        '
        'Test1BindingSource
        '
        Me.Test1BindingSource.DataSource = Me.Test1
        Me.Test1BindingSource.Position = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources._5293
        Me.PictureBox1.Location = New System.Drawing.Point(-303, -131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1321, 716)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'UserpwdTableAdapter
        '
        Me.UserpwdTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project2.Test1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserpwdTableAdapter = Me.UserpwdTableAdapter
        '
        'UserpwdBindingSource2
        '
        Me.UserpwdBindingSource2.DataMember = "Userpwd"
        Me.UserpwdBindingSource2.DataSource = Me.Database1DataSetBindingSource
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserpwdBindingSource3
        '
        Me.UserpwdBindingSource3.DataMember = "Userpwd"
        Me.UserpwdBindingSource3.DataSource = Me.Database1DataSetBindingSource1
        '
        'Database1DataSetBindingSource1
        '
        Me.Database1DataSetBindingSource1.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource1.Position = 0
        '
        'UserpwdDataGridView
        '
        Me.UserpwdDataGridView.AutoGenerateColumns = False
        Me.UserpwdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserpwdDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn})
        Me.UserpwdDataGridView.DataSource = Me.UserpwdBindingSource1
        Me.UserpwdDataGridView.Location = New System.Drawing.Point(28, 32)
        Me.UserpwdDataGridView.Name = "UserpwdDataGridView"
        Me.UserpwdDataGridView.Size = New System.Drawing.Size(345, 148)
        Me.UserpwdDataGridView.TabIndex = 21
        Me.UserpwdDataGridView.Visible = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'UserpwdBindingSource7
        '
        Me.UserpwdBindingSource7.DataMember = "Userpwd"
        Me.UserpwdBindingSource7.DataSource = Me.Database1DataSetBindingSource
        '
        'UserpwdBindingSource8
        '
        Me.UserpwdBindingSource8.DataMember = "Userpwd"
        Me.UserpwdBindingSource8.DataSource = Me.Database1DataSetBindingSource1
        '
        'UserpwdBindingSource4
        '
        Me.UserpwdBindingSource4.DataMember = "Userpwd"
        Me.UserpwdBindingSource4.DataSource = Me.Database1DataSet
        '
        'UserpwdBindingSource6
        '
        Me.UserpwdBindingSource6.DataMember = "Userpwd"
        Me.UserpwdBindingSource6.DataSource = Me.Database1DataSet
        '
        'UserpwdBindingSource5
        '
        Me.UserpwdBindingSource5.DataMember = "Userpwd"
        Me.UserpwdBindingSource5.DataSource = Me.Database1DataSet
        '
        'UserpwdTableAdapter1
        '
        Me.UserpwdTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.StudentTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Project2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UserpwdTableAdapter = Me.UserpwdTableAdapter1
        '
        'Database1DataSetBindingSource2
        '
        Me.Database1DataSetBindingSource2.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource2.Position = 0
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource4, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(107, 236)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 22
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource4, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(107, 262)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 24
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource4, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(107, 288)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 26
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource4, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(107, 314)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 28
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource4, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(107, 340)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 30
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(906, 516)
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
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.UserpwdDataGridView)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.UserpwdBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Test1BindingSource As BindingSource
    Friend WithEvents Test1 As Test1
    Friend WithEvents UserpwdBindingSource As BindingSource
    Friend WithEvents UserpwdTableAdapter As Test1TableAdapters.UserpwdTableAdapter
    Friend WithEvents TableAdapterManager As Test1TableAdapters.TableAdapterManager
    Friend WithEvents UserpwdBindingSource1 As BindingSource
    Friend WithEvents Database1DataSetBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents UserpwdBindingSource2 As BindingSource
    Friend WithEvents UserpwdTableAdapter1 As Database1DataSetTableAdapters.UserpwdTableAdapter
    Friend WithEvents UserpwdBindingSource3 As BindingSource
    Friend WithEvents Database1DataSetBindingSource1 As BindingSource
    Friend WithEvents UserpwdBindingSource4 As BindingSource
    Friend WithEvents TableAdapterManager1 As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserpwdBindingSource6 As BindingSource
    Friend WithEvents UserpwdBindingSource5 As BindingSource
    Friend WithEvents UserpwdDataGridView As DataGridView
    Friend WithEvents UserpwdBindingSource7 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserpwdBindingSource8 As BindingSource
    Friend WithEvents Database1DataSetBindingSource2 As BindingSource
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
End Class
