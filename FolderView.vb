Imports System.IO
Imports System.Reflection

Public Class FolderView
    Public Sub LoadDirectory(path As String, where As TreeNode)
        LoadFiles(path, where)
        Dim directories As String() = Directory.GetDirectories(path)
        For Each directory In directories
            Dim node As TreeNode = where.Nodes.Add(directory.Split("\").Last)
            node.Tag = directory
            node.ToolTipText = node.Tag
            LoadDirectory(directory, node)
        Next
    End Sub

    Private Sub LoadFiles(path As String, where As TreeNode)
        Dim files As String() = Directory.GetFiles(path)
        For Each file In files
            Dim node As TreeNode = where.Nodes.Add(file.Split("\").Last)
            node.Tag = file
            node.ToolTipText = node.Tag
        Next
    End Sub

    Public Sub StartLoadingDirectory(path As String)
        Text = path.Split("\").Last
        Dim rootNode As TreeNode = trv.Nodes.Add(path.Split("\").Last)
        rootNode.ToolTipText = path
        rootNode.Tag = path
        LoadDirectory(path, rootNode)
    End Sub

    Private Sub FolderView_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Form1.EnableControls(False)
        Form1.focusedForm = Nothing
    End Sub

    Private Sub trv_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trv.NodeMouseDoubleClick
        Dim path As String = e.Node.Tag.ToString()
        If Directory.Exists(path) Then
            ' Do anything, it's a directory. The user can open it with the + sign or close with the - sign.
        End If
        ' It's a file, open it.
        Dim textFiles As String() = {".txt", ".py", ".css", ".js", ".java", ".cpp", ".c", ".h", ".tex", ".cs", ".vb", ".TXT", ".PY", ".CSS", ".JS", ".JAVA", ".CPP", ".C", ".H", ".TEX", ".CS", ".VB"}
        If path.EndsWith(".png") Or path.EndsWith(".jpg") Or path.EndsWith(".jpeg") Or path.EndsWith(".bmp") Then
            Form1.OpenImage(path)
        ElseIf path.EndsWith(".rtf") Then
            Form1.OpenDocument(path)
        Else
            ' Check if it is a text file
            For Each ex In textFiles
                If path.EndsWith(ex) Then
                    Form1.OpenTXT(path)
                    Return
                End If
            Next
            MsgBox("The file you asked to open is not in the supported file extensions.", vbExclamation + vbOKOnly, "ERROR")
        End If
    End Sub
End Class