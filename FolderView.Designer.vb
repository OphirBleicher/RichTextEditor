﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FolderView
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
        Me.trv = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'trv
        '
        Me.trv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trv.Location = New System.Drawing.Point(0, 0)
        Me.trv.Name = "trv"
        Me.trv.Size = New System.Drawing.Size(192, 343)
        Me.trv.TabIndex = 0
        '
        'FolderView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 343)
        Me.Controls.Add(Me.trv)
        Me.Name = "FolderView"
        Me.Text = "Folder"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents trv As TreeView
End Class
