Public Class Form1
    Private newDocumentNumber As Integer = 1
    Public documents As New List(Of Document)
    Public focusedForm As Document = Nothing

    Private Function CreateNewDocument() As Document
        Dim doc As New Document
        doc.NewDocument(newDocumentNumber)
        doc.TopLevel = False
        doc.MdiParent = Me
        documents.Add(doc)
        Return doc
    End Function

    Private Sub NewDocument()
        Dim doc As Document = CreateNewDocument()
        doc.NewDocument(newDocumentNumber)
        newDocumentNumber += 1
        doc.Show()
        EnableControls(True)
        focusedForm = doc
    End Sub

    Public Sub OpenDocument(Optional path As String = "")
        Dim filename As String = path
        If filename = "" Then
            Dim r As DialogResult = dlgOpen.ShowDialog
            If r = vbCancel Then
                Return
            End If
            filename = dlgOpen.FileName
        End If
        Dim doc As Document = CreateNewDocument()
        doc.OpenDocument(filename)
        doc.Show()
        EnableControls(True)
        focusedForm = doc
    End Sub

    Private Sub SaveDocument()
        focusedForm.SaveDocument()
    End Sub

    Private Sub SaveDocumentAs()
        focusedForm.SaveDocumentAs()
    End Sub

    Public Sub EnableControls(enabled As Boolean)
        mnuFileSave.Enabled = enabled
        mnuFileSaveAs.Enabled = enabled
        mnuEditUndo.Enabled = enabled
        mnuEditRedo.Enabled = enabled
        mnuEditCut.Enabled = enabled
        mnuEditCopy.Enabled = enabled
        mnuEditPaste.Enabled = enabled
        mnuEditSelectAll.Enabled = enabled
        mnuFormatBold.Enabled = enabled
        mnuFormatItalic.Enabled = enabled
        mnuFormatUnderline.Enabled = enabled
        mnuFormatStrikeout.Enabled = enabled
        mnuFormatLeftAlign.Enabled = enabled
        mnuFormatCenterAlign.Enabled = enabled
        mnuFormatRightAlign.Enabled = enabled
        mnuFormatColor.Enabled = enabled
        mnuFormatBackground.Enabled = enabled
        mnuFormatFont.Enabled = enabled
        tolSave.Enabled = enabled
        tolUndo.Enabled = enabled
        tolRedo.Enabled = enabled
        tolCut.Enabled = enabled
        tolCopy.Enabled = enabled
        tolPaste.Enabled = enabled
        tolBold.Enabled = enabled
        tolItalic.Enabled = enabled
        tolUnderline.Enabled = enabled
        tolStrikeout.Enabled = enabled
        tolLeftAlign.Enabled = enabled
        tolCenterAlign.Enabled = enabled
        tolRightAlign.Enabled = enabled
        tolTextColor.Enabled = enabled
        tolBackground.Enabled = enabled
        tolFont.Enabled = enabled
        mnuEditUppercase.Enabled = enabled
        mnuEditLowercase.Enabled = enabled
        mnuSearchFind.Enabled = enabled
        mnuSearchFindReplace.Enabled = enabled
        tolFind.Enabled = enabled
        mnuInsertImage.Enabled = enabled
        tolImage.Enabled = enabled
        tolList.Enabled = enabled
        mnuInsertList.Enabled = enabled
    End Sub

    Private Sub tolNew_Click(sender As Object, e As EventArgs) Handles tolNew.Click
        NewDocument()
    End Sub
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        NewDocument()
    End Sub

    Private Sub tolOpen_Click(sender As Object, e As EventArgs) Handles tolOpen.Click
        OpenDocument()
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        OpenDocument()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim a As New AboutBox
        a.ShowDialog(Me)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrClock.Start()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        sttDateTime.Text = DateTime.Now.ToString("G")
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        System.Environment.Exit(0)
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        SaveDocument()
    End Sub

    Private Sub tolSave_Click(sender As Object, e As EventArgs) Handles tolSave.Click
        SaveDocument()
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        SaveDocumentAs()
    End Sub

    Private Sub mnuEditUndo_Click(sender As Object, e As EventArgs) Handles mnuEditUndo.Click
        focusedForm.rtf.Undo()
    End Sub

    Private Sub tolUndo_Click(sender As Object, e As EventArgs) Handles tolUndo.Click
        focusedForm.rtf.Undo()
    End Sub

    Private Sub mnuEditRedo_Click(sender As Object, e As EventArgs) Handles mnuEditRedo.Click
        focusedForm.rtf.Redo()
    End Sub

    Private Sub tolRedo_Click(sender As Object, e As EventArgs) Handles tolRedo.Click
        focusedForm.rtf.Redo()
    End Sub

    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        focusedForm.rtf.Cut()
    End Sub

    Private Sub tolCut_Click(sender As Object, e As EventArgs) Handles tolCut.Click
        focusedForm.rtf.Cut()
    End Sub

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        focusedForm.rtf.Copy()
    End Sub

    Private Sub tolCopy_Click(sender As Object, e As EventArgs) Handles tolCopy.Click
        focusedForm.rtf.Copy()
    End Sub

    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        focusedForm.rtf.Paste()
    End Sub

    Private Sub tolPaste_Click(sender As Object, e As EventArgs) Handles tolPaste.Click
        focusedForm.rtf.Paste()
    End Sub

    Private Sub mnuFileOpenFolder_Click(sender As Object, e As EventArgs) Handles mnuFileOpenFolder.Click
        Dim r As DialogResult = dlgFolder.ShowDialog
        If r = vbCancel Then
            Return
        End If
        Dim doc As New FolderView
        doc.TopLevel = False
        doc.MdiParent = Me
        doc.Show()
        doc.StartLoadingDirectory(dlgFolder.SelectedPath)
    End Sub

    Public Sub OpenImage(fileName As String)
        Dim imgForm As New ImageViewer
        imgForm.TopLevel = False
        imgForm.MdiParent = Me
        imgForm.pic.Image = New Bitmap(fileName)
        imgForm.Show()
    End Sub

    Public Sub OpenTXT(fileName As String)
        Dim txtForm As New TextViewer
        txtForm.TopLevel = False
        txtForm.MdiParent = Me
        txtForm.LoadFile(fileName)
        txtForm.Show()
    End Sub

    Private Sub tolBold_Click(sender As Object, e As EventArgs) Handles tolBold.Click
        focusedForm.Bold()
    End Sub

    Private Sub mnuFormatBold_Click(sender As Object, e As EventArgs) Handles mnuFormatBold.Click
        focusedForm.Bold()
    End Sub

    Private Sub tolItalic_Click(sender As Object, e As EventArgs) Handles tolItalic.Click
        focusedForm.Italic()
    End Sub

    Private Sub mnuFormatItalic_Click(sender As Object, e As EventArgs) Handles mnuFormatItalic.Click
        focusedForm.Italic()
    End Sub

    Private Sub mnuFormatUnderline_Click(sender As Object, e As EventArgs) Handles mnuFormatUnderline.Click
        focusedForm.Underline()
    End Sub

    Private Sub tolUnderline_Click(sender As Object, e As EventArgs) Handles tolUnderline.Click
        focusedForm.Underline()
    End Sub

    Private Sub mnuFormatStrikeout_Click(sender As Object, e As EventArgs) Handles mnuFormatStrikeout.Click
        focusedForm.Strikeout()
    End Sub

    Private Sub tolStrikeout_Click(sender As Object, e As EventArgs) Handles tolStrikeout.Click
        focusedForm.Strikeout()
    End Sub

    Private Sub mnuFormatLeftAlign_Click(sender As Object, e As EventArgs) Handles mnuFormatLeftAlign.Click
        focusedForm.LeftAlign()
    End Sub

    Private Sub tolLeftAlign_Click(sender As Object, e As EventArgs) Handles tolLeftAlign.Click
        focusedForm.LeftAlign()
    End Sub

    Private Sub tolCenterAlign_Click(sender As Object, e As EventArgs) Handles tolCenterAlign.Click
        focusedForm.CenterAlign()
    End Sub

    Private Sub mnuFormatCenterAlign_Click(sender As Object, e As EventArgs) Handles mnuFormatCenterAlign.Click
        focusedForm.CenterAlign()
    End Sub

    Private Sub tolRightAlign_Click(sender As Object, e As EventArgs) Handles tolRightAlign.Click
        focusedForm.RightAlign()
    End Sub

    Private Sub mnuFormatRightAlign_Click(sender As Object, e As EventArgs) Handles mnuFormatRightAlign.Click
        focusedForm.RightAlign()
    End Sub

    Private Sub tolTextColor_Click(sender As Object, e As EventArgs) Handles tolTextColor.Click
        focusedForm.TextColor()
    End Sub

    Private Sub mnuFormatColor_Click(sender As Object, e As EventArgs) Handles mnuFormatColor.Click
        focusedForm.TextColor()
    End Sub

    Private Sub tolBackground_Click(sender As Object, e As EventArgs) Handles tolBackground.Click
        focusedForm.BackgroundColor()
    End Sub

    Private Sub mnuFormatBackground_Click(sender As Object, e As EventArgs) Handles mnuFormatBackground.Click
        focusedForm.BackgroundColor()
    End Sub

    Private Sub mnuFormatFont_Click(sender As Object, e As EventArgs) Handles mnuFormatFont.Click
        focusedForm.ChangeFont()
    End Sub

    Private Sub tolFont_Click(sender As Object, e As EventArgs) Handles tolFont.Click
        focusedForm.ChangeFont()
    End Sub

    Private Sub mnuEditSelectAll_Click(sender As Object, e As EventArgs) Handles mnuEditSelectAll.Click
        focusedForm.rtf.SelectAll()
    End Sub

    Private Sub ToolBarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolBarToolStripMenuItem1.Click
        tol.Visible = Not tol.Visible
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        stt.Visible = Not stt.Visible
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        Dim frm As New Contact
        frm.ShowDialog()
    End Sub

    Private Sub mnuEditUppercase_Click(sender As Object, e As EventArgs) Handles mnuEditUppercase.Click
        focusedForm.rtf.SelectedText = StrConv(focusedForm.rtf.SelectedText, vbUpperCase)
    End Sub

    Private Sub mnuEditLowercase_Click(sender As Object, e As EventArgs) Handles mnuEditLowercase.Click
        focusedForm.rtf.SelectedText = StrConv(focusedForm.rtf.SelectedText, vbLowerCase)
    End Sub

    Private Sub mnuSearchFind_Click(sender As Object, e As EventArgs) Handles mnuSearchFind.Click
        focusedForm.FindText()
    End Sub

    Private Sub tolFind_Click(sender As Object, e As EventArgs) Handles tolFind.Click
        focusedForm.FindText()
    End Sub

    Private Sub mnuSearchFindReplace_Click(sender As Object, e As EventArgs) Handles mnuSearchFindReplace.Click
        focusedForm.ReplaceText()
    End Sub

    Private Sub tolImage_Click(sender As Object, e As EventArgs) Handles tolImage.Click
        focusedForm.InsertImage()
    End Sub

    Private Sub mnuInsertImage_Click(sender As Object, e As EventArgs) Handles mnuInsertImage.Click
        focusedForm.InsertImage()
    End Sub

    Private Sub mnuInsertList_Click(sender As Object, e As EventArgs) Handles mnuInsertList.Click
        focusedForm.InsertBulletList()
    End Sub

    Private Sub tolList_Click(sender As Object, e As EventArgs) Handles tolList.Click
        focusedForm.InsertBulletList()
    End Sub

    Private Sub mnuHelpHelpTopics_Click(sender As Object, e As EventArgs) Handles mnuHelpHelpTopics.Click
        OpenDocument("help.rtf")
    End Sub

    Private Sub tolHelp_Click(sender As Object, e As EventArgs) Handles tolHelp.Click
        OpenDocument("help.rtf")
    End Sub
End Class
