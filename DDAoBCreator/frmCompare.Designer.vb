<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompare
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rtbL = New System.Windows.Forms.RichTextBox()
        Me.rtbR = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.cmsCompareOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkDifferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkSameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.cmsCompareOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 319)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rtbL)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rtbR)
        Me.SplitContainer1.Size = New System.Drawing.Size(550, 296)
        Me.SplitContainer1.SplitterDistance = 234
        Me.SplitContainer1.TabIndex = 1
        '
        'rtbL
        '
        Me.rtbL.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.rtbL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbL.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbL.ForeColor = System.Drawing.Color.White
        Me.rtbL.Location = New System.Drawing.Point(0, 0)
        Me.rtbL.Name = "rtbL"
        Me.rtbL.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.rtbL.Size = New System.Drawing.Size(234, 296)
        Me.rtbL.TabIndex = 6
        Me.rtbL.Text = ""
        '
        'rtbR
        '
        Me.rtbR.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.rtbR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbR.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbR.ForeColor = System.Drawing.Color.White
        Me.rtbR.Location = New System.Drawing.Point(0, 0)
        Me.rtbR.Name = "rtbR"
        Me.rtbR.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.rtbR.Size = New System.Drawing.Size(312, 296)
        Me.rtbR.TabIndex = 5
        Me.rtbR.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pbStatus)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnCompare)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(550, 23)
        Me.Panel2.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReset.Location = New System.Drawing.Point(453, 0)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(97, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCompare
        '
        Me.btnCompare.ContextMenuStrip = Me.cmsCompareOptions
        Me.btnCompare.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCompare.Location = New System.Drawing.Point(0, 0)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(94, 23)
        Me.btnCompare.TabIndex = 3
        Me.btnCompare.Text = "Compare"
        Me.ToolTip1.SetToolTip(Me.btnCompare, "Right-click to bring up options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colorizes the text fields where bytes are dif" & _
        "ferent.")
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'cmsCompareOptions
        '
        Me.cmsCompareOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkDifferencesToolStripMenuItem, Me.MarkSameToolStripMenuItem})
        Me.cmsCompareOptions.Name = "cmsCompareOptions"
        Me.cmsCompareOptions.Size = New System.Drawing.Size(164, 48)
        '
        'MarkDifferencesToolStripMenuItem
        '
        Me.MarkDifferencesToolStripMenuItem.Checked = True
        Me.MarkDifferencesToolStripMenuItem.CheckOnClick = True
        Me.MarkDifferencesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MarkDifferencesToolStripMenuItem.Name = "MarkDifferencesToolStripMenuItem"
        Me.MarkDifferencesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MarkDifferencesToolStripMenuItem.Text = "Mark Differences"
        '
        'MarkSameToolStripMenuItem
        '
        Me.MarkSameToolStripMenuItem.CheckOnClick = True
        Me.MarkSameToolStripMenuItem.Name = "MarkSameToolStripMenuItem"
        Me.MarkSameToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MarkSameToolStripMenuItem.Text = "Mark Same"
        '
        'pbStatus
        '
        Me.pbStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pbStatus.Location = New System.Drawing.Point(94, 0)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(359, 23)
        Me.pbStatus.TabIndex = 7
        '
        'frmCompare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 319)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(174, 345)
        Me.Name = "frmCompare"
        Me.Text = "frmCompare"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.cmsCompareOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents rtbL As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbR As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Friend WithEvents cmsCompareOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MarkDifferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkSameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
End Class
