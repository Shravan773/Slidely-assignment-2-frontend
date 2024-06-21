<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewSubmissionsForm
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
        lblViewName = New Label()
        lblViewEmail = New Label()
        lblViewPhoneNumber = New Label()
        lblViewGitHubLink = New Label()
        lblViewStopwatchTime = New Label()
        txtViewName = New TextBox()
        txtViewPhoneNumber = New TextBox()
        txtViewGitHubLink = New TextBox()
        txtViewStopwatchTime = New TextBox()
        txtViewEmail = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        Label1 = New Label()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' lblViewName
        ' 
        lblViewName.AutoSize = True
        lblViewName.Location = New Point(314, 105)
        lblViewName.Name = "lblViewName"
        lblViewName.Size = New Size(39, 15)
        lblViewName.TabIndex = 0
        lblViewName.Text = "Name"
        ' 
        ' lblViewEmail
        ' 
        lblViewEmail.AutoSize = True
        lblViewEmail.Location = New Point(317, 154)
        lblViewEmail.Name = "lblViewEmail"
        lblViewEmail.Size = New Size(36, 15)
        lblViewEmail.TabIndex = 1
        lblViewEmail.Text = "Email"
        ' 
        ' lblViewPhoneNumber
        ' 
        lblViewPhoneNumber.AutoSize = True
        lblViewPhoneNumber.Location = New Point(304, 200)
        lblViewPhoneNumber.Name = "lblViewPhoneNumber"
        lblViewPhoneNumber.Size = New Size(71, 15)
        lblViewPhoneNumber.TabIndex = 2
        lblViewPhoneNumber.Text = "Phone Num"
        ' 
        ' lblViewGitHubLink
        ' 
        lblViewGitHubLink.AutoSize = True
        lblViewGitHubLink.Location = New Point(263, 246)
        lblViewGitHubLink.Name = "lblViewGitHubLink"
        lblViewGitHubLink.Size = New Size(122, 15)
        lblViewGitHubLink.TabIndex = 3
        lblViewGitHubLink.Text = "Github Link For Task 2"
        ' 
        ' lblViewStopwatchTime
        ' 
        lblViewStopwatchTime.AutoSize = True
        lblViewStopwatchTime.Location = New Point(283, 299)
        lblViewStopwatchTime.Name = "lblViewStopwatchTime"
        lblViewStopwatchTime.Size = New Size(92, 15)
        lblViewStopwatchTime.TabIndex = 4
        lblViewStopwatchTime.Text = "Stopwatch Time"
        ' 
        ' txtViewName
        ' 
        txtViewName.Location = New Point(408, 97)
        txtViewName.Name = "txtViewName"
        txtViewName.Size = New Size(128, 23)
        txtViewName.TabIndex = 5
        ' 
        ' txtViewPhoneNumber
        ' 
        txtViewPhoneNumber.Location = New Point(408, 192)
        txtViewPhoneNumber.Name = "txtViewPhoneNumber"
        txtViewPhoneNumber.Size = New Size(128, 23)
        txtViewPhoneNumber.TabIndex = 7
        ' 
        ' txtViewGitHubLink
        ' 
        txtViewGitHubLink.Location = New Point(408, 231)
        txtViewGitHubLink.Multiline = True
        txtViewGitHubLink.Name = "txtViewGitHubLink"
        txtViewGitHubLink.Size = New Size(128, 43)
        txtViewGitHubLink.TabIndex = 8
        ' 
        ' txtViewStopwatchTime
        ' 
        txtViewStopwatchTime.Location = New Point(408, 299)
        txtViewStopwatchTime.Name = "txtViewStopwatchTime"
        txtViewStopwatchTime.Size = New Size(128, 23)
        txtViewStopwatchTime.TabIndex = 9
        ' 
        ' txtViewEmail
        ' 
        txtViewEmail.Location = New Point(408, 151)
        txtViewEmail.Name = "txtViewEmail"
        txtViewEmail.Size = New Size(128, 23)
        txtViewEmail.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnPrevious.Location = New Point(231, 352)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(185, 29)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Cyan
        btnNext.Location = New Point(452, 352)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(184, 29)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(314, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 15)
        Label1.TabIndex = 13
        Label1.Text = "Shravan kumar,Slidely Task 2 - View Submissions"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnDelete.Location = New Point(570, 403)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(128, 35)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete Submission"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' viewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 498)
        Controls.Add(btnDelete)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtViewEmail)
        Controls.Add(txtViewStopwatchTime)
        Controls.Add(txtViewGitHubLink)
        Controls.Add(txtViewPhoneNumber)
        Controls.Add(txtViewName)
        Controls.Add(lblViewStopwatchTime)
        Controls.Add(lblViewGitHubLink)
        Controls.Add(lblViewPhoneNumber)
        Controls.Add(lblViewEmail)
        Controls.Add(lblViewName)
        Name = "viewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblViewName As Label
    Friend WithEvents lblViewEmail As Label
    Friend WithEvents lblViewPhoneNumber As Label
    Friend WithEvents lblViewGitHubLink As Label
    Friend WithEvents lblViewStopwatchTime As Label
    Friend WithEvents txtViewName As TextBox
    Friend WithEvents txtViewPhoneNumber As TextBox
    Friend WithEvents txtViewGitHubLink As TextBox
    Friend WithEvents txtViewStopwatchTime As TextBox
    Friend WithEvents txtViewEmail As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
End Class
