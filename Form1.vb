Public Class Form1
    'Write a program that corresponds the following table:
    'Input              Output
    '---------------------------------
    ' 1                 Freshman
    ' 2                 Sophomore
    ' 3                 Junior
    ' 4                 Senior
    ' other             Incorrect Data
    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
        Dim credits As Integer
        Dim status As String
        credits = CInt(txtInput.Text)
        'If credits >= 26 Then
        'status = "Senior"
        'Else
        'If credits >= 16 Then
        'status = "Junior"
        'Else
        'If credits >= 7 Then
        'status = "Sophomore"
        'Else
        'If credits >= 0 Then
        'status = "Freshman"
        'Else
        'status = "Invalid"
        'End If
        'End If
        'End If
        'End If
        If credits >= 26 Then
            status = "Senior"
        ElseIf credits >= 16 Then
            status = "Junior"
        ElseIf credits >= 7 Then
            status = "Sophomore"
        ElseIf credits >= 0 Then
            status = "Freshman"
        Else
            status = "Invalid"
        End If
        lblMsg.Text = status
    End Sub
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtInput.Text = ""
        lblMsg.Text = ""
        txtInput.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim credits As Integer
        credits = CInt(txtInput.Text)
        Dim status As String

        Select Case (credits)
            Case 0 To 6
                status = "Freshman"
            Case 7 To 15
                status = "Sophomore"
            Case 16 To 25
                status = "Junior"
            Case >= 26
                status = "Senior"
            Case Else
                status = "Invalid"
        End Select
        lblMsg.Text = status
    End Sub
End Class