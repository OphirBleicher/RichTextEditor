Public Class Replace
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim findText As String = TextBox1.Text
        Dim replaceText As String = TextBox2.Text
        Dim rtf As RichTextBox = Form1.focusedForm.rtf
        Dim i As Integer = rtf.Find(findText)
        If i <> -1 Then
            rtf.Select(i, findText.Length)
            rtf.SelectedText = replaceText
            MsgBox("Replaced '" & findText & "' with '" & replaceText & "'.", vbInformation, "Replace")
        Else
            MsgBox("Text '" & findText & "' not found.", vbExclamation, "Replace")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim findText As String = TextBox1.Text
        Dim replaceText As String = TextBox2.Text
        Dim rtf As RichTextBox = Form1.focusedForm.rtf
        Dim i As Integer = rtf.Find(findText)
        While (True)
            If i <> -1 Then
                rtf.Select(i, findText.Length)
                rtf.SelectedText = replaceText
                i = rtf.Find(findText)
            Else
                MsgBox("Replaced.", vbInformation, "Replace")
                Exit While
            End If
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class