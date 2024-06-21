Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Public submissions As List(Of Submission) = New List(Of Submission)
    Private currentIndex As Integer = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Set form properties
        Me.Text = "John Doe, Slidely Task 2 - View Submissions"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = True ' Enable KeyPreview to capture form-level key events

        ' Initialize controls and load submissions
        InitializeControls()
        LoadSubmissions()
    End Sub

    Private Sub InitializeControls()
        ' Labels
        lblViewName.Text = "Name:"
        lblViewName.AutoSize = True

        lblViewEmail.Text = "Email:"
        lblViewEmail.AutoSize = True

        lblViewPhoneNumber.Text = "Phone Number:"
        lblViewPhoneNumber.AutoSize = True

        lblViewGitHubLink.Text = "GitHub Link:"
        lblViewGitHubLink.AutoSize = True

        lblViewStopwatchTime.Text = "Stopwatch Time:"
        lblViewStopwatchTime.AutoSize = True

        ' TextBoxes
        txtViewName.ReadOnly = True
        txtViewEmail.ReadOnly = True
        txtViewPhoneNumber.ReadOnly = True
        txtViewGitHubLink.ReadOnly = True
        txtViewStopwatchTime.ReadOnly = True

        ' Buttons
        btnPrevious.Text = "Previous"
        btnNext.Text = "Next"
        btnDelete.Text = "Delete Submission"

        ' Add controls to the form
        Me.Controls.Add(lblViewName)
        Me.Controls.Add(lblViewEmail)
        Me.Controls.Add(lblViewPhoneNumber)
        Me.Controls.Add(lblViewGitHubLink)
        Me.Controls.Add(lblViewStopwatchTime)
        Me.Controls.Add(txtViewName)
        Me.Controls.Add(txtViewEmail)
        Me.Controls.Add(txtViewPhoneNumber)
        Me.Controls.Add(txtViewGitHubLink)
        Me.Controls.Add(txtViewStopwatchTime)
        Me.Controls.Add(btnPrevious)
        Me.Controls.Add(btnNext)
        Me.Controls.Add(btnDelete)
    End Sub

    Private Async Sub LoadSubmissions()
        ' Load the submissions from the backend
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read")
                response.EnsureSuccessStatusCode()
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                If submissions.Count > 0 Then
                    DisplaySubmission(currentIndex)
                Else
                    MessageBox.Show("No submissions found.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading submissions: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            txtViewName.Text = submissions(index).Name
            txtViewEmail.Text = submissions(index).Email
            txtViewPhoneNumber.Text = submissions(index).PhoneNumber
            txtViewGitHubLink.Text = submissions(index).GitHubLink
            txtViewStopwatchTime.Text = submissions(index).StopwatchTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submissions.Count = 0 Then
            MessageBox.Show("No submissions to delete.")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim submissionIdToDelete As Integer = submissions(currentIndex).Id

            ' Delete the submission from the backend
            DeleteSubmission(submissionIdToDelete)
        End If
    End Sub

    Private Async Sub DeleteSubmission(submissionId As Integer)
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete/{submissionId}")
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Submission deleted successfully.")

                ' Update the local submissions list by fetching the updated data
                LoadSubmissions()
            Catch ex As Exception
                MessageBox.Show($"Error deleting submission: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub viewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
