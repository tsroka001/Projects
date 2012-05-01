<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRealEstateCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRealEstateCalculator))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProgramInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tbxPropValue = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblPropValue = New System.Windows.Forms.Label
        Me.lblEnteredValue = New System.Windows.Forms.Label
        Me.lblMin = New System.Windows.Forms.Label
        Me.lbxInput = New System.Windows.Forms.ListBox
        Me.lbxResults = New System.Windows.Forms.ListBox
        Me.gbxAnalysis = New System.Windows.Forms.GroupBox
        Me.tbxStDev = New System.Windows.Forms.TextBox
        Me.tbxMean = New System.Windows.Forms.TextBox
        Me.tbxMode = New System.Windows.Forms.TextBox
        Me.tbxMax = New System.Windows.Forms.TextBox
        Me.tbxMedian = New System.Windows.Forms.TextBox
        Me.tbxMin = New System.Windows.Forms.TextBox
        Me.lblStDev = New System.Windows.Forms.Label
        Me.lblMean = New System.Windows.Forms.Label
        Me.lblMode = New System.Windows.Forms.Label
        Me.lblMax = New System.Windows.Forms.Label
        Me.lblMedian = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.MenuStrip.SuspendLayout()
        Me.gbxAnalysis.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramInfoToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ProgramInfoToolStripMenuItem
        '
        Me.ProgramInfoToolStripMenuItem.Name = "ProgramInfoToolStripMenuItem"
        Me.ProgramInfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgramInfoToolStripMenuItem.Text = "Program Info"
        '
        'tbxPropValue
        '
        Me.tbxPropValue.Location = New System.Drawing.Point(112, 32)
        Me.tbxPropValue.MaxLength = 30
        Me.tbxPropValue.Name = "tbxPropValue"
        Me.tbxPropValue.Size = New System.Drawing.Size(164, 20)
        Me.tbxPropValue.TabIndex = 0
        Me.tbxPropValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(339, 381)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(420, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPropValue
        '
        Me.lblPropValue.AutoSize = True
        Me.lblPropValue.BackColor = System.Drawing.Color.Transparent
        Me.lblPropValue.Location = New System.Drawing.Point(12, 35)
        Me.lblPropValue.Name = "lblPropValue"
        Me.lblPropValue.Size = New System.Drawing.Size(79, 13)
        Me.lblPropValue.TabIndex = 3
        Me.lblPropValue.Text = "Property Value:"
        '
        'lblEnteredValue
        '
        Me.lblEnteredValue.AutoSize = True
        Me.lblEnteredValue.BackColor = System.Drawing.Color.Transparent
        Me.lblEnteredValue.Location = New System.Drawing.Point(12, 63)
        Me.lblEnteredValue.Name = "lblEnteredValue"
        Me.lblEnteredValue.Size = New System.Drawing.Size(119, 13)
        Me.lblEnteredValue.TabIndex = 4
        Me.lblEnteredValue.Text = "Entered Property Value:"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(279, 19)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(27, 13)
        Me.lblMin.TabIndex = 5
        Me.lblMin.Text = "Min:"
        '
        'lbxInput
        '
        Me.lbxInput.FormattingEnabled = True
        Me.lbxInput.Location = New System.Drawing.Point(19, 79)
        Me.lbxInput.Name = "lbxInput"
        Me.lbxInput.Size = New System.Drawing.Size(257, 121)
        Me.lbxInput.TabIndex = 6
        Me.lbxInput.TabStop = False
        '
        'lbxResults
        '
        Me.lbxResults.FormattingEnabled = True
        Me.lbxResults.Location = New System.Drawing.Point(6, 15)
        Me.lbxResults.Name = "lbxResults"
        Me.lbxResults.Size = New System.Drawing.Size(257, 147)
        Me.lbxResults.TabIndex = 7
        Me.lbxResults.TabStop = False
        '
        'gbxAnalysis
        '
        Me.gbxAnalysis.BackColor = System.Drawing.Color.Transparent
        Me.gbxAnalysis.Controls.Add(Me.tbxStDev)
        Me.gbxAnalysis.Controls.Add(Me.tbxMean)
        Me.gbxAnalysis.Controls.Add(Me.tbxMode)
        Me.gbxAnalysis.Controls.Add(Me.tbxMax)
        Me.gbxAnalysis.Controls.Add(Me.tbxMedian)
        Me.gbxAnalysis.Controls.Add(Me.tbxMin)
        Me.gbxAnalysis.Controls.Add(Me.lblStDev)
        Me.gbxAnalysis.Controls.Add(Me.lblMean)
        Me.gbxAnalysis.Controls.Add(Me.lblMode)
        Me.gbxAnalysis.Controls.Add(Me.lblMax)
        Me.gbxAnalysis.Controls.Add(Me.lblMedian)
        Me.gbxAnalysis.Controls.Add(Me.lbxResults)
        Me.gbxAnalysis.Controls.Add(Me.lblMin)
        Me.gbxAnalysis.Location = New System.Drawing.Point(13, 207)
        Me.gbxAnalysis.Name = "gbxAnalysis"
        Me.gbxAnalysis.Size = New System.Drawing.Size(493, 168)
        Me.gbxAnalysis.TabIndex = 8
        Me.gbxAnalysis.TabStop = False
        Me.gbxAnalysis.Text = "Property Value Analysis:"
        '
        'tbxStDev
        '
        Me.tbxStDev.Location = New System.Drawing.Point(382, 139)
        Me.tbxStDev.Name = "tbxStDev"
        Me.tbxStDev.ReadOnly = True
        Me.tbxStDev.Size = New System.Drawing.Size(100, 20)
        Me.tbxStDev.TabIndex = 14
        Me.tbxStDev.TabStop = False
        Me.tbxStDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxMean
        '
        Me.tbxMean.Location = New System.Drawing.Point(382, 115)
        Me.tbxMean.Name = "tbxMean"
        Me.tbxMean.ReadOnly = True
        Me.tbxMean.Size = New System.Drawing.Size(100, 20)
        Me.tbxMean.TabIndex = 14
        Me.tbxMean.TabStop = False
        Me.tbxMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxMode
        '
        Me.tbxMode.Location = New System.Drawing.Point(382, 91)
        Me.tbxMode.Name = "tbxMode"
        Me.tbxMode.ReadOnly = True
        Me.tbxMode.Size = New System.Drawing.Size(100, 20)
        Me.tbxMode.TabIndex = 14
        Me.tbxMode.TabStop = False
        Me.tbxMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxMax
        '
        Me.tbxMax.Location = New System.Drawing.Point(382, 67)
        Me.tbxMax.Name = "tbxMax"
        Me.tbxMax.ReadOnly = True
        Me.tbxMax.Size = New System.Drawing.Size(100, 20)
        Me.tbxMax.TabIndex = 14
        Me.tbxMax.TabStop = False
        Me.tbxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxMedian
        '
        Me.tbxMedian.Location = New System.Drawing.Point(382, 43)
        Me.tbxMedian.Name = "tbxMedian"
        Me.tbxMedian.ReadOnly = True
        Me.tbxMedian.Size = New System.Drawing.Size(100, 20)
        Me.tbxMedian.TabIndex = 14
        Me.tbxMedian.TabStop = False
        Me.tbxMedian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxMin
        '
        Me.tbxMin.Location = New System.Drawing.Point(382, 19)
        Me.tbxMin.Name = "tbxMin"
        Me.tbxMin.ReadOnly = True
        Me.tbxMin.Size = New System.Drawing.Size(100, 20)
        Me.tbxMin.TabIndex = 13
        Me.tbxMin.TabStop = False
        Me.tbxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStDev
        '
        Me.lblStDev.AutoSize = True
        Me.lblStDev.Location = New System.Drawing.Point(279, 139)
        Me.lblStDev.Name = "lblStDev"
        Me.lblStDev.Size = New System.Drawing.Size(101, 13)
        Me.lblStDev.TabIndex = 12
        Me.lblStDev.Text = "Standard Deviation:"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(279, 115)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(37, 13)
        Me.lblMean.TabIndex = 11
        Me.lblMean.Text = "Mean:"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(279, 91)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(37, 13)
        Me.lblMode.TabIndex = 10
        Me.lblMode.Text = "Mode:"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(279, 67)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(30, 13)
        Me.lblMax.TabIndex = 9
        Me.lblMax.Text = "Max:"
        '
        'lblMedian
        '
        Me.lblMedian.AutoSize = True
        Me.lblMedian.Location = New System.Drawing.Point(279, 43)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(45, 13)
        Me.lblMedian.TabIndex = 8
        Me.lblMedian.Text = "Median:"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Location = New System.Drawing.Point(12, 386)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(60, 13)
        Me.lblVersion.TabIndex = 10
        Me.lblVersion.Text = "Version 1.0"
        '
        'frmRealEstateCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(514, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.gbxAnalysis)
        Me.Controls.Add(Me.lbxInput)
        Me.Controls.Add(Me.lblEnteredValue)
        Me.Controls.Add(Me.lblPropValue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tbxPropValue)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmRealEstateCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tom's Real Estate Calculator"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.gbxAnalysis.ResumeLayout(False)
        Me.gbxAnalysis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbxPropValue As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPropValue As System.Windows.Forms.Label
    Friend WithEvents lblEnteredValue As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lbxInput As System.Windows.Forms.ListBox
    Friend WithEvents lbxResults As System.Windows.Forms.ListBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbxAnalysis As System.Windows.Forms.GroupBox
    Friend WithEvents lblStDev As System.Windows.Forms.Label
    Friend WithEvents lblMean As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMedian As System.Windows.Forms.Label
    Friend WithEvents tbxStDev As System.Windows.Forms.TextBox
    Friend WithEvents tbxMean As System.Windows.Forms.TextBox
    Friend WithEvents tbxMode As System.Windows.Forms.TextBox
    Friend WithEvents tbxMax As System.Windows.Forms.TextBox
    Friend WithEvents tbxMedian As System.Windows.Forms.TextBox
    Friend WithEvents tbxMin As System.Windows.Forms.TextBox
    Friend WithEvents ProgramInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
