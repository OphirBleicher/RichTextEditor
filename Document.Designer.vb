<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Document
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtf = New System.Windows.Forms.RichTextBox()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'rtf
        '
        Me.rtf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtf.Location = New System.Drawing.Point(0, 0)
        Me.rtf.Name = "rtf"
        Me.rtf.Size = New System.Drawing.Size(234, 211)
        Me.rtf.TabIndex = 0
        Me.rtf.Text = ""
        '
        'dlgSave
        '
        Me.dlgSave.DefaultExt = "*.rtf"
        Me.dlgSave.Filter = "Rich Text Files|*.rtf"
        '
        'dlgFont
        '
        Me.dlgFont.FontMustExist = True
        Me.dlgFont.ShowEffects = False
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|BMP|*.bmp"
        '
        'Document
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 211)
        Me.Controls.Add(Me.rtf)
        Me.Name = "Document"
        Me.Text = "Document1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtf As RichTextBox
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents dlgOpen As OpenFileDialog
End Class
