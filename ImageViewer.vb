Public Class ImageViewer
    Private Sub ImageViewer_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Form1.EnableControls(False)
        Form1.focusedForm = Nothing
    End Sub
End Class