Public Class Document
    Private changesSaved As Boolean = True
    Private filename As String = ""
    Private Sub rtf_TextChanged(sender As Object, e As EventArgs) Handles rtf.TextChanged
        If changesSaved Then
            Text = "*" & Text
        End If
        changesSaved = False
    End Sub

    Public Sub NewDocument(number As Integer)
        Text = "Document" & number
    End Sub

    Public Sub OpenDocument(fileName As String)
        Me.filename = fileName
        rtf.LoadFile(fileName, RichTextBoxStreamType.RichText)
        Text = fileName.Split("\").Last.TrimEnd("f").TrimEnd("t").TrimEnd("r").TrimEnd(".")
        changesSaved = True
    End Sub

    Public Sub SaveDocument()
        If filename = "" Then
            SaveDocumentAs()
        End If
        rtf.SaveFile(filename, RichTextBoxStreamType.RichText)
        changesSaved = True
        Text = Text.TrimStart("*")
    End Sub

    Public Function SaveDocumentAs() As Boolean
        Dim r As DialogResult = dlgSave.ShowDialog
        If r = vbCancel Then
            Return False
        End If
        filename = dlgSave.FileName
        SaveDocument()
        Return True
    End Function

    Public Sub CloseDocument()
        If Not changesSaved Then
            Dim r As DialogResult = MsgBox("You did not save your changes in the file " + Text.TrimStart("*") + "." + vbCrLf + "Do you want to save your changes now?", vbYesNo + vbExclamation, "Changes")
            If r = vbYes Then
                SaveDocument()
            End If
        End If
        Form1.documents.Remove(Me)
        If Form1.documents.Count = 0 Then
            Form1.EnableControls(False)
            Form1.focusedForm = Nothing
        End If
    End Sub

    Private Sub Document_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseDocument()
    End Sub

    Private Sub Document_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Form1.focusedForm = Me
        Form1.EnableControls(True)
    End Sub

    Public Sub Bold()
        rtf.SelectionFont = New Font(rtf.SelectionFont, rtf.SelectionFont.Style Xor FontStyle.Bold)
    End Sub

    Public Sub Italic()
        rtf.SelectionFont = New Font(rtf.SelectionFont, rtf.SelectionFont.Style Xor FontStyle.Italic)
    End Sub

    Public Sub Underline()
        rtf.SelectionFont = New Font(rtf.SelectionFont, rtf.SelectionFont.Style Xor FontStyle.Underline)
    End Sub

    Public Sub Strikeout()
        rtf.SelectionFont = New Font(rtf.SelectionFont, rtf.SelectionFont.Style Xor FontStyle.Strikeout)
    End Sub

    Public Sub LeftAlign()
        rtf.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Public Sub CenterAlign()
        rtf.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Public Sub RightAlign()
        rtf.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Public Sub TextColor()
        Dim r As DialogResult = dlgColor.ShowDialog
        If r = vbOK Then
            rtf.SelectionColor = dlgColor.Color
        End If
    End Sub

    Public Sub BackgroundColor()
        Dim r As DialogResult = dlgColor.ShowDialog
        If r = vbOK Then
            rtf.SelectionBackColor = dlgColor.Color
        End If
    End Sub

    Public Sub ChangeFont()
        Dim r As DialogResult = dlgFont.ShowDialog
        If r = vbOK Then
            rtf.SelectionFont = New Font(dlgFont.Font.FontFamily, dlgFont.Font.Size, rtf.Font.Style)
        End If
    End Sub

    Public Sub FindText()
        Dim f As New FindAndReplace
        f.ShowDialog()
    End Sub

    Public Sub ReplaceText()
        Dim f As New Replace
        f.ShowDialog()
    End Sub

    Public Sub InsertImage()
        Dim r As DialogResult = dlgOpen.ShowDialog
        If r = vbOK Then
            Dim img As Image = Image.FromFile(dlgOpen.FileName)
            Clipboard.SetImage(img)
            rtf.Paste()
        End If
    End Sub

    Public Sub InsertBulletList()
        rtf.SelectionBullet = True
        rtf.SelectionIndent = 20
        rtf.BulletIndent = 15
    End Sub
End Class