Public Class FindAndReplace
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index As Integer = Form1.focusedForm.rtf.Find(TextBox1.Text)
        If index = -1 Then  ' not found
            MsgBox("Text not found.", MsgBoxStyle.Information, "Find")
        Else
            Form1.focusedForm.rtf.SelectionStart = index
            Form1.focusedForm.rtf.SelectionLength = TextBox1.Text.Length
            Form1.focusedForm.rtf.ScrollToCaret()
        End If
    End Sub
End Class