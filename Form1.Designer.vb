<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpenFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditUppercase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditLowercase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsert = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearchFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearchFindReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatBold = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatItalic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatUnderline = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatStrikeout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFormatLeftAlign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatCenterAlign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatRightAlign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFormatColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatBackground = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormatSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFormatFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tol = New System.Windows.Forms.ToolStrip()
        Me.tolNew = New System.Windows.Forms.ToolStripButton()
        Me.tolOpen = New System.Windows.Forms.ToolStripButton()
        Me.tolSave = New System.Windows.Forms.ToolStripButton()
        Me.sepTol1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tolUndo = New System.Windows.Forms.ToolStripButton()
        Me.tolRedo = New System.Windows.Forms.ToolStripButton()
        Me.tolCut = New System.Windows.Forms.ToolStripButton()
        Me.tolCopy = New System.Windows.Forms.ToolStripButton()
        Me.tolPaste = New System.Windows.Forms.ToolStripButton()
        Me.sepTol2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tolImage = New System.Windows.Forms.ToolStripButton()
        Me.tolList = New System.Windows.Forms.ToolStripButton()
        Me.sepTol3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tolFind = New System.Windows.Forms.ToolStripButton()
        Me.sepTol4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tolBold = New System.Windows.Forms.ToolStripButton()
        Me.tolItalic = New System.Windows.Forms.ToolStripButton()
        Me.tolUnderline = New System.Windows.Forms.ToolStripButton()
        Me.tolStrikeout = New System.Windows.Forms.ToolStripButton()
        Me.tolLeftAlign = New System.Windows.Forms.ToolStripButton()
        Me.tolCenterAlign = New System.Windows.Forms.ToolStripButton()
        Me.tolRightAlign = New System.Windows.Forms.ToolStripButton()
        Me.tolTextColor = New System.Windows.Forms.ToolStripButton()
        Me.tolBackground = New System.Windows.Forms.ToolStripButton()
        Me.tolFont = New System.Windows.Forms.ToolStripButton()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.stt = New System.Windows.Forms.StatusStrip()
        Me.sttDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sttOpenFiles = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.sepHelp1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpHelpTopics = New System.Windows.Forms.ToolStripMenuItem()
        Me.sepTol5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tolHelp = New System.Windows.Forms.ToolStripButton()
        Me.mnu.SuspendLayout()
        Me.tol.SuspendLayout()
        Me.stt.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.EditToolStripMenuItem, Me.mnuInsert, Me.mnuSearch, Me.FormatToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.mnuHelp})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(554, 24)
        Me.mnu.TabIndex = 1
        Me.mnu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileOpenFolder, Me.mnuFileSep1, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileSep2, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Image = CType(resources.GetObject("mnuFileNew.Image"), System.Drawing.Image)
        Me.mnuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(195, 22)
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Image = CType(resources.GetObject("mnuFileOpen.Image"), System.Drawing.Image)
        Me.mnuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(195, 22)
        Me.mnuFileOpen.Text = "&Open..."
        '
        'mnuFileOpenFolder
        '
        Me.mnuFileOpenFolder.Name = "mnuFileOpenFolder"
        Me.mnuFileOpenFolder.Size = New System.Drawing.Size(195, 22)
        Me.mnuFileOpenFolder.Text = "Open Folder"
        '
        'mnuFileSep1
        '
        Me.mnuFileSep1.Name = "mnuFileSep1"
        Me.mnuFileSep1.Size = New System.Drawing.Size(192, 6)
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Enabled = False
        Me.mnuFileSave.Image = CType(resources.GetObject("mnuFileSave.Image"), System.Drawing.Image)
        Me.mnuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(195, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Enabled = False
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(195, 22)
        Me.mnuFileSaveAs.Text = "Save &As..."
        '
        'mnuFileSep2
        '
        Me.mnuFileSep2.Name = "mnuFileSep2"
        Me.mnuFileSep2.Size = New System.Drawing.Size(192, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(195, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditUndo, Me.mnuEditRedo, Me.mnuEditSep1, Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste, Me.mnuEditSep2, Me.mnuEditSelectAll, Me.mnuEditSep3, Me.mnuEditUppercase, Me.mnuEditLowercase})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'mnuEditUndo
        '
        Me.mnuEditUndo.Enabled = False
        Me.mnuEditUndo.Image = CType(resources.GetObject("mnuEditUndo.Image"), System.Drawing.Image)
        Me.mnuEditUndo.Name = "mnuEditUndo"
        Me.mnuEditUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuEditUndo.Size = New System.Drawing.Size(164, 22)
        Me.mnuEditUndo.Text = "&Undo"
        '
        'mnuEditRedo
        '
        Me.mnuEditRedo.Enabled = False
        Me.mnuEditRedo.Image = CType(resources.GetObject("mnuEditRedo.Image"), System.Drawing.Image)
        Me.mnuEditRedo.Name = "mnuEditRedo"
        Me.mnuEditRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuEditRedo.Size = New System.Drawing.Size(164, 22)
        Me.mnuEditRedo.Text = "&Redo"
        '
        'mnuEditSep1
        '
        Me.mnuEditSep1.Name = "mnuEditSep1"
        Me.mnuEditSep1.Size = New System.Drawing.Size(161, 6)
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Enabled = False
        Me.mnuEditCut.Image = CType(resources.GetObject("mnuEditCut.Image"), System.Drawing.Image)
        Me.mnuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(164, 22)
        Me.mnuEditCut.Text = "Cu&t"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Enabled = False
        Me.mnuEditCopy.Image = CType(resources.GetObject("mnuEditCopy.Image"), System.Drawing.Image)
        Me.mnuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(164, 22)
        Me.mnuEditCopy.Text = "&Copy"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Enabled = False
        Me.mnuEditPaste.Image = CType(resources.GetObject("mnuEditPaste.Image"), System.Drawing.Image)
        Me.mnuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(164, 22)
        Me.mnuEditPaste.Text = "&Paste"
        '
        'mnuEditSep2
        '
        Me.mnuEditSep2.Name = "mnuEditSep2"
        Me.mnuEditSep2.Size = New System.Drawing.Size(161, 6)
        '
        'mnuEditSelectAll
        '
        Me.mnuEditSelectAll.Enabled = False
        Me.mnuEditSelectAll.Name = "mnuEditSelectAll"
        Me.mnuEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuEditSelectAll.Size = New System.Drawing.Size(164, 22)
        Me.mnuEditSelectAll.Text = "Select &All"
        '
        'mnuEditSep3
        '
        Me.mnuEditSep3.Name = "mnuEditSep3"
        Me.mnuEditSep3.Size = New System.Drawing.Size(161, 6)
        '
        'mnuEditUppercase
        '
        Me.mnuEditUppercase.Enabled = False
        Me.mnuEditUppercase.Name = "mnuEditUppercase"
        Me.mnuEditUppercase.Size = New System.Drawing.Size(164, 22)
        Me.mnuEditUppercase.Text = "UPPERCASE"
        '
        'mnuEditLowercase
        '
        Me.mnuEditLowercase.Enabled = False
        Me.mnuEditLowercase.Name = "mnuEditLowercase"
        Me.mnuEditLowercase.Size = New System.Drawing.Size(164, 22)
        Me.mnuEditLowercase.Text = "lowercase"
        '
        'mnuInsert
        '
        Me.mnuInsert.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInsertImage, Me.mnuInsertList})
        Me.mnuInsert.Name = "mnuInsert"
        Me.mnuInsert.Size = New System.Drawing.Size(48, 20)
        Me.mnuInsert.Text = "&Insert"
        '
        'mnuInsertImage
        '
        Me.mnuInsertImage.Enabled = False
        Me.mnuInsertImage.Image = CType(resources.GetObject("mnuInsertImage.Image"), System.Drawing.Image)
        Me.mnuInsertImage.Name = "mnuInsertImage"
        Me.mnuInsertImage.Size = New System.Drawing.Size(107, 22)
        Me.mnuInsertImage.Text = "&Image"
        '
        'mnuInsertList
        '
        Me.mnuInsertList.Enabled = False
        Me.mnuInsertList.Image = CType(resources.GetObject("mnuInsertList.Image"), System.Drawing.Image)
        Me.mnuInsertList.Name = "mnuInsertList"
        Me.mnuInsertList.Size = New System.Drawing.Size(107, 22)
        Me.mnuInsertList.Text = "&List"
        '
        'mnuSearch
        '
        Me.mnuSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSearchFind, Me.mnuSearchFindReplace})
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(54, 20)
        Me.mnuSearch.Text = "&Search"
        '
        'mnuSearchFind
        '
        Me.mnuSearchFind.Enabled = False
        Me.mnuSearchFind.Image = CType(resources.GetObject("mnuSearchFind.Image"), System.Drawing.Image)
        Me.mnuSearchFind.Name = "mnuSearchFind"
        Me.mnuSearchFind.Size = New System.Drawing.Size(173, 22)
        Me.mnuSearchFind.Text = "&Find..."
        '
        'mnuSearchFindReplace
        '
        Me.mnuSearchFindReplace.Enabled = False
        Me.mnuSearchFindReplace.Name = "mnuSearchFindReplace"
        Me.mnuSearchFindReplace.Size = New System.Drawing.Size(173, 22)
        Me.mnuSearchFindReplace.Text = "Find and &Replace..."
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFormatBold, Me.mnuFormatItalic, Me.mnuFormatUnderline, Me.mnuFormatStrikeout, Me.mnuFormatSep1, Me.mnuFormatLeftAlign, Me.mnuFormatCenterAlign, Me.mnuFormatRightAlign, Me.mnuFormatSep2, Me.mnuFormatColor, Me.mnuFormatBackground, Me.mnuFormatSep3, Me.mnuFormatFont})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "F&ormat"
        '
        'mnuFormatBold
        '
        Me.mnuFormatBold.Enabled = False
        Me.mnuFormatBold.Image = CType(resources.GetObject("mnuFormatBold.Image"), System.Drawing.Image)
        Me.mnuFormatBold.Name = "mnuFormatBold"
        Me.mnuFormatBold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuFormatBold.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatBold.Text = "&Bold"
        '
        'mnuFormatItalic
        '
        Me.mnuFormatItalic.Enabled = False
        Me.mnuFormatItalic.Image = CType(resources.GetObject("mnuFormatItalic.Image"), System.Drawing.Image)
        Me.mnuFormatItalic.Name = "mnuFormatItalic"
        Me.mnuFormatItalic.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuFormatItalic.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatItalic.Text = "&Italic"
        '
        'mnuFormatUnderline
        '
        Me.mnuFormatUnderline.Enabled = False
        Me.mnuFormatUnderline.Image = CType(resources.GetObject("mnuFormatUnderline.Image"), System.Drawing.Image)
        Me.mnuFormatUnderline.Name = "mnuFormatUnderline"
        Me.mnuFormatUnderline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuFormatUnderline.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatUnderline.Text = "&Underline"
        '
        'mnuFormatStrikeout
        '
        Me.mnuFormatStrikeout.Enabled = False
        Me.mnuFormatStrikeout.Image = CType(resources.GetObject("mnuFormatStrikeout.Image"), System.Drawing.Image)
        Me.mnuFormatStrikeout.Name = "mnuFormatStrikeout"
        Me.mnuFormatStrikeout.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatStrikeout.Text = "&Strikeout"
        '
        'mnuFormatSep1
        '
        Me.mnuFormatSep1.Name = "mnuFormatSep1"
        Me.mnuFormatSep1.Size = New System.Drawing.Size(208, 6)
        '
        'mnuFormatLeftAlign
        '
        Me.mnuFormatLeftAlign.Enabled = False
        Me.mnuFormatLeftAlign.Image = CType(resources.GetObject("mnuFormatLeftAlign.Image"), System.Drawing.Image)
        Me.mnuFormatLeftAlign.Name = "mnuFormatLeftAlign"
        Me.mnuFormatLeftAlign.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuFormatLeftAlign.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatLeftAlign.Text = "&Left Alignment"
        '
        'mnuFormatCenterAlign
        '
        Me.mnuFormatCenterAlign.Enabled = False
        Me.mnuFormatCenterAlign.Image = CType(resources.GetObject("mnuFormatCenterAlign.Image"), System.Drawing.Image)
        Me.mnuFormatCenterAlign.Name = "mnuFormatCenterAlign"
        Me.mnuFormatCenterAlign.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuFormatCenterAlign.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatCenterAlign.Text = "&Center Alignment"
        '
        'mnuFormatRightAlign
        '
        Me.mnuFormatRightAlign.Enabled = False
        Me.mnuFormatRightAlign.Image = CType(resources.GetObject("mnuFormatRightAlign.Image"), System.Drawing.Image)
        Me.mnuFormatRightAlign.Name = "mnuFormatRightAlign"
        Me.mnuFormatRightAlign.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuFormatRightAlign.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatRightAlign.Text = "&Right Alignment"
        '
        'mnuFormatSep2
        '
        Me.mnuFormatSep2.Name = "mnuFormatSep2"
        Me.mnuFormatSep2.Size = New System.Drawing.Size(208, 6)
        '
        'mnuFormatColor
        '
        Me.mnuFormatColor.Enabled = False
        Me.mnuFormatColor.Image = CType(resources.GetObject("mnuFormatColor.Image"), System.Drawing.Image)
        Me.mnuFormatColor.Name = "mnuFormatColor"
        Me.mnuFormatColor.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatColor.Text = "&Text Color..."
        '
        'mnuFormatBackground
        '
        Me.mnuFormatBackground.Enabled = False
        Me.mnuFormatBackground.Image = CType(resources.GetObject("mnuFormatBackground.Image"), System.Drawing.Image)
        Me.mnuFormatBackground.Name = "mnuFormatBackground"
        Me.mnuFormatBackground.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatBackground.Text = "&Background Color..."
        '
        'mnuFormatSep3
        '
        Me.mnuFormatSep3.Name = "mnuFormatSep3"
        Me.mnuFormatSep3.Size = New System.Drawing.Size(208, 6)
        '
        'mnuFormatFont
        '
        Me.mnuFormatFont.Enabled = False
        Me.mnuFormatFont.Image = CType(resources.GetObject("mnuFormatFont.Image"), System.Drawing.Image)
        Me.mnuFormatFont.Name = "mnuFormatFont"
        Me.mnuFormatFont.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFormatFont.Size = New System.Drawing.Size(211, 22)
        Me.mnuFormatFont.Text = "&Font..."
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem1, Me.StatusBarToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'ToolBarToolStripMenuItem1
        '
        Me.ToolBarToolStripMenuItem1.Checked = True
        Me.ToolBarToolStripMenuItem1.CheckOnClick = True
        Me.ToolBarToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem1.Name = "ToolBarToolStripMenuItem1"
        Me.ToolBarToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ToolBarToolStripMenuItem1.Text = "&Tool bar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status bar"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout, Me.ContactToolStripMenuItem, Me.sepHelp1, Me.mnuHelpHelpTopics})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuHelpAbout.Text = "&About..."
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContactToolStripMenuItem.Text = "&Contact"
        '
        'tol
        '
        Me.tol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tolNew, Me.tolOpen, Me.tolSave, Me.sepTol1, Me.tolUndo, Me.tolRedo, Me.tolCut, Me.tolCopy, Me.tolPaste, Me.sepTol2, Me.tolImage, Me.tolList, Me.sepTol3, Me.tolFind, Me.sepTol4, Me.tolBold, Me.tolItalic, Me.tolUnderline, Me.tolStrikeout, Me.tolLeftAlign, Me.tolCenterAlign, Me.tolRightAlign, Me.tolTextColor, Me.tolBackground, Me.tolFont, Me.sepTol5, Me.tolHelp})
        Me.tol.Location = New System.Drawing.Point(0, 24)
        Me.tol.Name = "tol"
        Me.tol.Size = New System.Drawing.Size(554, 25)
        Me.tol.TabIndex = 3
        Me.tol.Text = "ToolStrip1"
        '
        'tolNew
        '
        Me.tolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolNew.Image = CType(resources.GetObject("tolNew.Image"), System.Drawing.Image)
        Me.tolNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolNew.Name = "tolNew"
        Me.tolNew.Size = New System.Drawing.Size(23, 22)
        Me.tolNew.Text = "New"
        '
        'tolOpen
        '
        Me.tolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolOpen.Image = CType(resources.GetObject("tolOpen.Image"), System.Drawing.Image)
        Me.tolOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolOpen.Name = "tolOpen"
        Me.tolOpen.Size = New System.Drawing.Size(23, 22)
        Me.tolOpen.Text = "Open"
        '
        'tolSave
        '
        Me.tolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolSave.Enabled = False
        Me.tolSave.Image = CType(resources.GetObject("tolSave.Image"), System.Drawing.Image)
        Me.tolSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolSave.Name = "tolSave"
        Me.tolSave.Size = New System.Drawing.Size(23, 22)
        Me.tolSave.Text = "Save"
        '
        'sepTol1
        '
        Me.sepTol1.Name = "sepTol1"
        Me.sepTol1.Size = New System.Drawing.Size(6, 25)
        '
        'tolUndo
        '
        Me.tolUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolUndo.Enabled = False
        Me.tolUndo.Image = CType(resources.GetObject("tolUndo.Image"), System.Drawing.Image)
        Me.tolUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolUndo.Name = "tolUndo"
        Me.tolUndo.Size = New System.Drawing.Size(23, 22)
        Me.tolUndo.Text = "Undo"
        Me.tolUndo.ToolTipText = "Undo"
        '
        'tolRedo
        '
        Me.tolRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolRedo.Enabled = False
        Me.tolRedo.Image = CType(resources.GetObject("tolRedo.Image"), System.Drawing.Image)
        Me.tolRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolRedo.Name = "tolRedo"
        Me.tolRedo.Size = New System.Drawing.Size(23, 22)
        Me.tolRedo.Text = "Redo"
        '
        'tolCut
        '
        Me.tolCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolCut.Enabled = False
        Me.tolCut.Image = CType(resources.GetObject("tolCut.Image"), System.Drawing.Image)
        Me.tolCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolCut.Name = "tolCut"
        Me.tolCut.Size = New System.Drawing.Size(23, 22)
        Me.tolCut.Text = "Cut"
        '
        'tolCopy
        '
        Me.tolCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolCopy.Enabled = False
        Me.tolCopy.Image = CType(resources.GetObject("tolCopy.Image"), System.Drawing.Image)
        Me.tolCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolCopy.Name = "tolCopy"
        Me.tolCopy.Size = New System.Drawing.Size(23, 22)
        Me.tolCopy.Text = "Copy"
        '
        'tolPaste
        '
        Me.tolPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolPaste.Enabled = False
        Me.tolPaste.Image = CType(resources.GetObject("tolPaste.Image"), System.Drawing.Image)
        Me.tolPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolPaste.Name = "tolPaste"
        Me.tolPaste.Size = New System.Drawing.Size(23, 22)
        Me.tolPaste.Text = "Paste"
        '
        'sepTol2
        '
        Me.sepTol2.Name = "sepTol2"
        Me.sepTol2.Size = New System.Drawing.Size(6, 25)
        '
        'tolImage
        '
        Me.tolImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolImage.Enabled = False
        Me.tolImage.Image = CType(resources.GetObject("tolImage.Image"), System.Drawing.Image)
        Me.tolImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolImage.Name = "tolImage"
        Me.tolImage.Size = New System.Drawing.Size(23, 22)
        Me.tolImage.Text = "Image"
        '
        'tolList
        '
        Me.tolList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolList.Enabled = False
        Me.tolList.Image = CType(resources.GetObject("tolList.Image"), System.Drawing.Image)
        Me.tolList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolList.Name = "tolList"
        Me.tolList.Size = New System.Drawing.Size(23, 22)
        Me.tolList.Text = "List"
        '
        'sepTol3
        '
        Me.sepTol3.Name = "sepTol3"
        Me.sepTol3.Size = New System.Drawing.Size(6, 25)
        '
        'tolFind
        '
        Me.tolFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolFind.Enabled = False
        Me.tolFind.Image = CType(resources.GetObject("tolFind.Image"), System.Drawing.Image)
        Me.tolFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolFind.Name = "tolFind"
        Me.tolFind.Size = New System.Drawing.Size(23, 22)
        Me.tolFind.Text = "Find"
        '
        'sepTol4
        '
        Me.sepTol4.Name = "sepTol4"
        Me.sepTol4.Size = New System.Drawing.Size(6, 25)
        '
        'tolBold
        '
        Me.tolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolBold.Enabled = False
        Me.tolBold.Image = CType(resources.GetObject("tolBold.Image"), System.Drawing.Image)
        Me.tolBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolBold.Name = "tolBold"
        Me.tolBold.Size = New System.Drawing.Size(23, 22)
        Me.tolBold.Text = "Bold"
        '
        'tolItalic
        '
        Me.tolItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolItalic.Enabled = False
        Me.tolItalic.Image = CType(resources.GetObject("tolItalic.Image"), System.Drawing.Image)
        Me.tolItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolItalic.Name = "tolItalic"
        Me.tolItalic.Size = New System.Drawing.Size(23, 22)
        Me.tolItalic.Text = "Italic"
        '
        'tolUnderline
        '
        Me.tolUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolUnderline.Enabled = False
        Me.tolUnderline.Image = CType(resources.GetObject("tolUnderline.Image"), System.Drawing.Image)
        Me.tolUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolUnderline.Name = "tolUnderline"
        Me.tolUnderline.Size = New System.Drawing.Size(23, 22)
        Me.tolUnderline.Text = "Underline"
        Me.tolUnderline.ToolTipText = "Underline"
        '
        'tolStrikeout
        '
        Me.tolStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolStrikeout.Enabled = False
        Me.tolStrikeout.Image = CType(resources.GetObject("tolStrikeout.Image"), System.Drawing.Image)
        Me.tolStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolStrikeout.Name = "tolStrikeout"
        Me.tolStrikeout.Size = New System.Drawing.Size(23, 22)
        Me.tolStrikeout.Text = "Strikeout"
        '
        'tolLeftAlign
        '
        Me.tolLeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolLeftAlign.Enabled = False
        Me.tolLeftAlign.Image = CType(resources.GetObject("tolLeftAlign.Image"), System.Drawing.Image)
        Me.tolLeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolLeftAlign.Name = "tolLeftAlign"
        Me.tolLeftAlign.Size = New System.Drawing.Size(23, 22)
        Me.tolLeftAlign.Text = "Left Alignment"
        '
        'tolCenterAlign
        '
        Me.tolCenterAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolCenterAlign.Enabled = False
        Me.tolCenterAlign.Image = CType(resources.GetObject("tolCenterAlign.Image"), System.Drawing.Image)
        Me.tolCenterAlign.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolCenterAlign.Name = "tolCenterAlign"
        Me.tolCenterAlign.Size = New System.Drawing.Size(23, 22)
        Me.tolCenterAlign.Text = "Center Alignment"
        '
        'tolRightAlign
        '
        Me.tolRightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolRightAlign.Enabled = False
        Me.tolRightAlign.Image = CType(resources.GetObject("tolRightAlign.Image"), System.Drawing.Image)
        Me.tolRightAlign.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolRightAlign.Name = "tolRightAlign"
        Me.tolRightAlign.Size = New System.Drawing.Size(23, 22)
        Me.tolRightAlign.Text = "Right Alignment"
        '
        'tolTextColor
        '
        Me.tolTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolTextColor.Enabled = False
        Me.tolTextColor.Image = CType(resources.GetObject("tolTextColor.Image"), System.Drawing.Image)
        Me.tolTextColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolTextColor.Name = "tolTextColor"
        Me.tolTextColor.Size = New System.Drawing.Size(23, 22)
        Me.tolTextColor.Text = "Text Color"
        '
        'tolBackground
        '
        Me.tolBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolBackground.Enabled = False
        Me.tolBackground.Image = CType(resources.GetObject("tolBackground.Image"), System.Drawing.Image)
        Me.tolBackground.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolBackground.Name = "tolBackground"
        Me.tolBackground.Size = New System.Drawing.Size(23, 22)
        Me.tolBackground.Text = "Background Color"
        '
        'tolFont
        '
        Me.tolFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolFont.Enabled = False
        Me.tolFont.Image = CType(resources.GetObject("tolFont.Image"), System.Drawing.Image)
        Me.tolFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolFont.Name = "tolFont"
        Me.tolFont.Size = New System.Drawing.Size(23, 22)
        Me.tolFont.Text = "Font"
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Rich Text Files|*.rtf"
        '
        'stt
        '
        Me.stt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sttDateTime, Me.sttOpenFiles})
        Me.stt.Location = New System.Drawing.Point(0, 507)
        Me.stt.Name = "stt"
        Me.stt.Size = New System.Drawing.Size(554, 24)
        Me.stt.TabIndex = 4
        Me.stt.Text = "StatusStrip1"
        '
        'sttDateTime
        '
        Me.sttDateTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.sttDateTime.Name = "sttDateTime"
        Me.sttDateTime.Size = New System.Drawing.Size(99, 19)
        Me.sttDateTime.Text = "00/00/0000 00:00"
        '
        'sttOpenFiles
        '
        Me.sttOpenFiles.Name = "sttOpenFiles"
        Me.sttOpenFiles.Size = New System.Drawing.Size(114, 19)
        Me.sttOpenFiles.Text = "Rich Text Files Editor"
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 10
        '
        'sepHelp1
        '
        Me.sepHelp1.Name = "sepHelp1"
        Me.sepHelp1.Size = New System.Drawing.Size(177, 6)
        '
        'mnuHelpHelpTopics
        '
        Me.mnuHelpHelpTopics.Image = CType(resources.GetObject("mnuHelpHelpTopics.Image"), System.Drawing.Image)
        Me.mnuHelpHelpTopics.Name = "mnuHelpHelpTopics"
        Me.mnuHelpHelpTopics.Size = New System.Drawing.Size(180, 22)
        Me.mnuHelpHelpTopics.Text = "Help Topics"
        '
        'sepTol5
        '
        Me.sepTol5.Name = "sepTol5"
        Me.sepTol5.Size = New System.Drawing.Size(6, 25)
        '
        'tolHelp
        '
        Me.tolHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolHelp.Image = CType(resources.GetObject("tolHelp.Image"), System.Drawing.Image)
        Me.tolHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolHelp.Name = "tolHelp"
        Me.tolHelp.Size = New System.Drawing.Size(23, 20)
        Me.tolHelp.Text = "Help"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 531)
        Me.Controls.Add(Me.stt)
        Me.Controls.Add(Me.tol)
        Me.Controls.Add(Me.mnu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnu
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rich Text Editor"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.tol.ResumeLayout(False)
        Me.tol.PerformLayout()
        Me.stt.ResumeLayout(False)
        Me.stt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuEditUndo As ToolStripMenuItem
    Friend WithEvents mnuEditRedo As ToolStripMenuItem
    Friend WithEvents mnuEditSep1 As ToolStripSeparator
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuEditSep2 As ToolStripSeparator
    Friend WithEvents mnuEditSelectAll As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFormatBold As ToolStripMenuItem
    Friend WithEvents mnuFormatItalic As ToolStripMenuItem
    Friend WithEvents mnuFormatUnderline As ToolStripMenuItem
    Friend WithEvents mnuFormatStrikeout As ToolStripMenuItem
    Friend WithEvents mnuFormatSep1 As ToolStripSeparator
    Friend WithEvents mnuFormatLeftAlign As ToolStripMenuItem
    Friend WithEvents mnuFormatCenterAlign As ToolStripMenuItem
    Friend WithEvents mnuFormatRightAlign As ToolStripMenuItem
    Friend WithEvents mnuFormatSep2 As ToolStripSeparator
    Friend WithEvents mnuFormatColor As ToolStripMenuItem
    Friend WithEvents mnuFormatBackground As ToolStripMenuItem
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSep1 As ToolStripSeparator
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileSep2 As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents tol As ToolStrip
    Friend WithEvents tolNew As ToolStripButton
    Friend WithEvents tolOpen As ToolStripButton
    Friend WithEvents tolSave As ToolStripButton
    Friend WithEvents sepTol1 As ToolStripSeparator
    Friend WithEvents tolUndo As ToolStripButton
    Friend WithEvents tolRedo As ToolStripButton
    Friend WithEvents tolCut As ToolStripButton
    Friend WithEvents tolCopy As ToolStripButton
    Friend WithEvents tolPaste As ToolStripButton
    Friend WithEvents sepTol4 As ToolStripSeparator
    Friend WithEvents tolBold As ToolStripButton
    Friend WithEvents tolItalic As ToolStripButton
    Friend WithEvents tolUnderline As ToolStripButton
    Friend WithEvents tolStrikeout As ToolStripButton
    Friend WithEvents tolLeftAlign As ToolStripButton
    Friend WithEvents tolCenterAlign As ToolStripButton
    Friend WithEvents tolRightAlign As ToolStripButton
    Friend WithEvents tolTextColor As ToolStripButton
    Friend WithEvents tolFont As ToolStripButton
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents mnuFormatSep3 As ToolStripSeparator
    Friend WithEvents mnuFormatFont As ToolStripMenuItem
    Friend WithEvents tolBackground As ToolStripButton
    Friend WithEvents stt As StatusStrip
    Friend WithEvents sttDateTime As ToolStripStatusLabel
    Friend WithEvents sttOpenFiles As ToolStripStatusLabel
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents tmrClock As Timer
    Friend WithEvents mnuFileOpenFolder As ToolStripMenuItem
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuEditSep3 As ToolStripSeparator
    Friend WithEvents mnuEditUppercase As ToolStripMenuItem
    Friend WithEvents mnuEditLowercase As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuSearchFind As ToolStripMenuItem
    Friend WithEvents mnuSearchFindReplace As ToolStripMenuItem
    Friend WithEvents tolFind As ToolStripButton
    Friend WithEvents sepTol3 As ToolStripSeparator
    Friend WithEvents mnuInsert As ToolStripMenuItem
    Friend WithEvents tolImage As ToolStripButton
    Friend WithEvents sepTol2 As ToolStripSeparator
    Friend WithEvents mnuInsertImage As ToolStripMenuItem
    Friend WithEvents mnuInsertList As ToolStripMenuItem
    Friend WithEvents tolList As ToolStripButton
    Friend WithEvents sepHelp1 As ToolStripSeparator
    Friend WithEvents mnuHelpHelpTopics As ToolStripMenuItem
    Friend WithEvents sepTol5 As ToolStripSeparator
    Friend WithEvents tolHelp As ToolStripButton
End Class
