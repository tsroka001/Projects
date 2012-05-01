<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterestCalc
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
        Me.tbxDeposit = New System.Windows.Forms.TextBox
        Me.tbxInterest = New System.Windows.Forms.TextBox
        Me.tbxMonths = New System.Windows.Forms.TextBox
        Me.tbxAmount = New System.Windows.Forms.TextBox
        Me.tbxGoal = New System.Windows.Forms.TextBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.gbxGoal = New System.Windows.Forms.GroupBox
        Me.lblMonthstoGoal = New System.Windows.Forms.Label
        Me.lblGoal = New System.Windows.Forms.Label
        Me.lbxResults = New System.Windows.Forms.ListBox
        Me.lblDeposit = New System.Windows.Forms.Label
        Me.lblInterest = New System.Windows.Forms.Label
        Me.lblMonths = New System.Windows.Forms.Label
        Me.lblPercent = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.gbxGoal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxDeposit
        '
        Me.tbxDeposit.Location = New System.Drawing.Point(146, 13)
        Me.tbxDeposit.Name = "tbxDeposit"
        Me.tbxDeposit.Size = New System.Drawing.Size(100, 20)
        Me.tbxDeposit.TabIndex = 0
        '
        'tbxInterest
        '
        Me.tbxInterest.Location = New System.Drawing.Point(204, 46)
        Me.tbxInterest.Name = "tbxInterest"
        Me.tbxInterest.Size = New System.Drawing.Size(42, 20)
        Me.tbxInterest.TabIndex = 1
        '
        'tbxMonths
        '
        Me.tbxMonths.Location = New System.Drawing.Point(204, 79)
        Me.tbxMonths.Name = "tbxMonths"
        Me.tbxMonths.Size = New System.Drawing.Size(42, 20)
        Me.tbxMonths.TabIndex = 2
        '
        'tbxAmount
        '
        Me.tbxAmount.Location = New System.Drawing.Point(133, 43)
        Me.tbxAmount.Name = "tbxAmount"
        Me.tbxAmount.Size = New System.Drawing.Size(100, 20)
        Me.tbxAmount.TabIndex = 0
        '
        'tbxGoal
        '
        Me.tbxGoal.Location = New System.Drawing.Point(191, 95)
        Me.tbxGoal.Name = "tbxGoal"
        Me.tbxGoal.ReadOnly = True
        Me.tbxGoal.Size = New System.Drawing.Size(42, 20)
        Me.tbxGoal.TabIndex = 1
        Me.tbxGoal.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(13, 393)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(95, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(177, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gbxGoal
        '
        Me.gbxGoal.Controls.Add(Me.lblMonthstoGoal)
        Me.gbxGoal.Controls.Add(Me.lblGoal)
        Me.gbxGoal.Controls.Add(Me.tbxAmount)
        Me.gbxGoal.Controls.Add(Me.tbxGoal)
        Me.gbxGoal.Location = New System.Drawing.Point(13, 266)
        Me.gbxGoal.Name = "gbxGoal"
        Me.gbxGoal.Size = New System.Drawing.Size(239, 121)
        Me.gbxGoal.TabIndex = 3
        Me.gbxGoal.TabStop = False
        Me.gbxGoal.Text = "Goal Predictor"
        '
        'lblMonthstoGoal
        '
        Me.lblMonthstoGoal.AutoSize = True
        Me.lblMonthstoGoal.Location = New System.Drawing.Point(7, 76)
        Me.lblMonthstoGoal.Name = "lblMonthstoGoal"
        Me.lblMonthstoGoal.Size = New System.Drawing.Size(171, 13)
        Me.lblMonthstoGoal.TabIndex = 6
        Me.lblMonthstoGoal.Text = "How Many Months to Reach Goal:"
        '
        'lblGoal
        '
        Me.lblGoal.AutoSize = True
        Me.lblGoal.Location = New System.Drawing.Point(7, 25)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(71, 13)
        Me.lblGoal.TabIndex = 5
        Me.lblGoal.Text = "Goal Amount:"
        '
        'lbxResults
        '
        Me.lbxResults.FormattingEnabled = True
        Me.lbxResults.Location = New System.Drawing.Point(15, 112)
        Me.lbxResults.Name = "lbxResults"
        Me.lbxResults.Size = New System.Drawing.Size(237, 147)
        Me.lbxResults.TabIndex = 9
        Me.lbxResults.TabStop = False
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(12, 20)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(43, 13)
        Me.lblDeposit.TabIndex = 10
        Me.lblDeposit.Text = "Deposit"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Location = New System.Drawing.Point(12, 49)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(134, 13)
        Me.lblInterest.TabIndex = 11
        Me.lblInterest.Text = "Interest (example 4 for 4%):"
        '
        'lblMonths
        '
        Me.lblMonths.AutoSize = True
        Me.lblMonths.Location = New System.Drawing.Point(12, 82)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(99, 13)
        Me.lblMonths.TabIndex = 12
        Me.lblMonths.Text = "How Many Months:"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(246, 49)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(15, 13)
        Me.lblPercent.TabIndex = 13
        Me.lblPercent.Text = "%"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(86, 428)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(98, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "© Tom Sroka 2010"
        '
        'frmInterestCalc
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(270, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblMonths)
        Me.Controls.Add(Me.lblInterest)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.lbxResults)
        Me.Controls.Add(Me.gbxGoal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tbxMonths)
        Me.Controls.Add(Me.tbxInterest)
        Me.Controls.Add(Me.tbxDeposit)
        Me.Name = "frmInterestCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tom's Interest Calc"
        Me.gbxGoal.ResumeLayout(False)
        Me.gbxGoal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxDeposit As System.Windows.Forms.TextBox
    Friend WithEvents tbxInterest As System.Windows.Forms.TextBox
    Friend WithEvents tbxMonths As System.Windows.Forms.TextBox
    Friend WithEvents tbxAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbxGoal As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gbxGoal As System.Windows.Forms.GroupBox
    Friend WithEvents lblMonthstoGoal As System.Windows.Forms.Label
    Friend WithEvents lblGoal As System.Windows.Forms.Label
    Friend WithEvents lbxResults As System.Windows.Forms.ListBox
    Friend WithEvents lblDeposit As System.Windows.Forms.Label
    Friend WithEvents lblInterest As System.Windows.Forms.Label
    Friend WithEvents lblMonths As System.Windows.Forms.Label
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
