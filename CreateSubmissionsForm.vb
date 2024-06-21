Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionsForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero

    Private Sub CreateSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "John Doe, Slidely Task 2 - Create Submission"
        Me.KeyPreview = True ' Enable KeyPreview to capture form-level key events
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        ' Handle text changed event for Name textbox
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ' Handle text changed event for Email textbox
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged
        ' Handle text changed event for Phone Number textbox
    End Sub

    Private Sub txtGitHubLink_TextChanged(sender As Object, e As EventArgs) Handles txtGitHubLink.TextChanged
        ' Handle text changed event for GitHub Link textbox
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click
        ' Handle click event for Name label
    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click
        ' Handle click event for Email label
    End Sub

    Private Sub lblPhoneNumber_Click(sender As Object, e As EventArgs) Handles lblPhoneNumber.Click
        ' Handle click event for Phone Number label
    End Sub

    Private Sub lblGitHubLink_Click(sender As Object, e As EventArgs) Handles lblGithubLink.Click
        ' Handle click event for GitHub Link label
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            Timer1.Stop()
            btnToggleStopwatch.Text = "Resume"
        Else
            Timer1.Start()
            btnToggleStopwatch.Text = "Pause"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopwatchTime += TimeSpan.FromSeconds(1)
        lblStopwatchTime.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        ' Create a new submission
        Dim newSubmission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhoneNumber.Text,
            .GitHubLink = txtGitHubLink.Text,
            .StopwatchTime = stopwatchTime
        }

        ' Convert the submission to JSON
        Dim json As String = JsonConvert.SerializeObject(newSubmission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        ' Send the submission to the backend using HttpClient
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Submission successful!")
            Catch ex As Exception
                MessageBox.Show("Error submitting data: " & ex.Message)
            End Try
        End Using

        ' Reset the form
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""
        txtGitHubLink.Text = ""
        stopwatchTime = TimeSpan.Zero
        lblStopwatchTime.Text = "00:00:00"
        btnToggleStopwatch.Text = "Start"
        stopwatchRunning = False
    End Sub

    Private Sub CreateSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            Btnsubmit.PerformClick()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Handle click event for Label1
    End Sub
End Class
