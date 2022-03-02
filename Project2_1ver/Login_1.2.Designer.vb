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
        Me.btnregister = New System.Windows.Forms.LinkLabel()
        Me.btnpwd = New System.Windows.Forms.LinkLabel()
        Me.cbpwd = New System.Windows.Forms.CheckBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.Label()
        Me.txtlogin = New System.Windows.Forms.Label()
        Me.UserpwdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserpwdBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test1 = New Project2.Test1()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserpwdTableAdapter = New Project2.Test1TableAdapters.UserpwdTableAdapter()
        Me.TableAdapterManager = New Project2.Test1TableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.UserpwdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserpwdBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'txtpwd
        '
        Me.txtpwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource1, "Password", True))
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(446, 265)
        Me.txtpwd.Margin = New System.Windows.Forms.Padding(5)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(257, 26)
        Me.txtpwd.TabIndex = 9
        Me.txtpwd.UseSystemPasswordChar = True
        '
        'txtuser
        '
        Me.txtuser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource1, "ID", True))
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(446, 175)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(5)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(257, 26)
        Me.txtuser.TabIndex = 10
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
        '
        'UserpwdBindingSource
        '
        Me.UserpwdBindingSource.DataMember = "Userpwd"
        Me.UserpwdBindingSource.DataSource = Me.Test1BindingSource
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources._5293
        Me.PictureBox1.Location = New System.Drawing.Point(-254, -131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1055, 716)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(39, 227)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 16
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource1, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(106, 220)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 17
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(39, 253)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 18
        UsernameLabel.Text = "Username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource1, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(106, 250)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 19
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(39, 279)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 20
        PasswordLabel.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserpwdBindingSource1, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(106, 276)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserpwdBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(36, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
        Me.DataGridView1.TabIndex = 16
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
        'Test1BindingSource
        '
        Me.Test1BindingSource.DataSource = Me.Test1
        Me.Test1BindingSource.Position = 0
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
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(846, 430)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.UserpwdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserpwdBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UserpwdBindingSource1 As BindingSource
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
End Class
