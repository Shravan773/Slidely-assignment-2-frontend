<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionsForm
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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubLink = New TextBox()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        btnToggleStopwatch = New Button()
        Btnsubmit = New Button()
        Timer1 = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(376, 93)
        txtName.Name = "txtName"
        txtName.Size = New Size(135, 23)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(376, 133)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(135, 23)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(376, 185)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(135, 23)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(376, 230)
        txtGitHubLink.Multiline = True
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(135, 44)
        txtGitHubLink.TabIndex = 3
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(230, 101)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 5
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(230, 141)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 6
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(230, 193)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(71, 15)
        lblPhoneNumber.TabIndex = 7
        lblPhoneNumber.Text = "Phone Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(226, 244)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(119, 15)
        lblGithubLink.TabIndex = 8
        lblGithubLink.Text = "Github link For Task 2"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(414, 312)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(49, 15)
        lblStopwatchTime.TabIndex = 9
        lblStopwatchTime.Text = "00:00:00"
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnToggleStopwatch.Location = New Point(167, 304)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(190, 23)
        btnToggleStopwatch.TabIndex = 10
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' Btnsubmit
        ' 
        Btnsubmit.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Btnsubmit.Location = New Point(279, 356)
        Btnsubmit.Name = "Btnsubmit"
        Btnsubmit.Size = New Size(205, 33)
        Btnsubmit.TabIndex = 11
        Btnsubmit.Text = "SUBMIT (CTRL + S)"
        Btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(258, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 15)
        Label1.TabIndex = 12
        Label1.Text = "Shravan kumar,Slidely Task 2 - Create Submissions"
        ' 
        ' CreateSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Btnsubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionsForm"
        Text = "Create Submissions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents Btnsubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
