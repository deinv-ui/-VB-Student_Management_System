<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntroPage
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
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.barProgress = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Meiryo", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblStudent.Location = New System.Drawing.Point(225, 387)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(447, 41)
        Me.lblStudent.TabIndex = 0
        Me.lblStudent.Text = "Student Management System "
        Me.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStudent.UseWaitCursor = True
        '
        'barProgress
        '
        Me.barProgress.BackColor = System.Drawing.Color.IndianRed
        Me.barProgress.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.barProgress.ForeColor = System.Drawing.Color.IndianRed
        Me.barProgress.Location = New System.Drawing.Point(212, 452)
        Me.barProgress.Name = "barProgress"
        Me.barProgress.Size = New System.Drawing.Size(471, 14)
        Me.barProgress.TabIndex = 2
        Me.barProgress.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources._2350
        Me.PictureBox1.Location = New System.Drawing.Point(-116, -130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1147, 691)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'IntroPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(906, 516)
        Me.Controls.Add(Me.barProgress)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "IntroPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IntroPage"
        Me.UseWaitCursor = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStudent As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents barProgress As ProgressBar
End Class
