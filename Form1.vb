Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not (String.IsNullOrEmpty(TextBox1.Text)) Then
            Dim vbMarks As Decimal = CDec(TextBox1.Text)
            Label5.Text = getGrade(vbMarks)
        End If
        If Not (String.IsNullOrEmpty(TextBox2.Text)) Then
            Label7.Text = getGrade(CDec(TextBox2.Text))
        End If
    End Sub

    Function getGrade(mark As Decimal) As String
        If mark >= 75 Then
            Return "A"
        ElseIf mark >= 65 Then
            Return "B"
        ElseIf mark >= 55 Then
            Return "C"
        ElseIf mark >= 45 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function

    Function getGradeBySelectCase(mark As Decimal) As String
        Select Case mark
            Case >= 75
                Return "A"
            Case >= 65
                Return "B"
            Case >= 55
                Return "C"
            Case >= 45
                Return "D"
            Case Else
                Return "F"
        End Select
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not (String.IsNullOrEmpty(TextBox1.Text)) Then
            Label5.Text = getGradeBySelectCase(CDec(TextBox1.Text))
        End If
    End Sub


End Class
