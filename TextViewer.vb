Public Class TextViewer
    Public Sub LoadFile(path As String)
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(path)
        TextBox1.Text = fileReader
    End Sub

    Private Sub TextViewer_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Form1.focusedForm = Nothing
        Form1.EnableControls(False)
    End Sub
End Class