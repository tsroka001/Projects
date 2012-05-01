<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.tbxTest1 = New System.Windows.Forms.TextBox
        Me.tbxTest2 = New System.Windows.Forms.TextBox
        Me.tbxTest3 = New System.Windows.Forms.TextBox
        Me.tbxAverage = New System.Windows.Forms.TextBox
        Me.tbxLetterGrade = New System.Windows.Forms.TextBox
        Me.cbxDropLowestGrade = New System.Windows.Forms.CheckBox
        Me.lblLetterGrade = New System.Windows.Forms.Label
        Me.lblTest2 = New System.Windows.Forms.Label
        Me.lblTest3 = New System.Windows.Forms.Label
        Me.lblAverage = New System.Windows.Forms.Label
        Me.lblText1 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(21, 249)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(115, 249)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(209, 249)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbxTest1
        '
        Me.tbxTest1.Location = New System.Drawing.Point(168, 41)
        Me.tbxTest1.MaxLength = 3
        Me.tbxTest1.Name = "tbxTest1"
        Me.tbxTest1.Size = New System.Drawing.Size(100, 20)
        Me.tbxTest1.TabIndex = 0
        Me.tbxTest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxTest2
        '
        Me.tbxTest2.Location = New System.Drawing.Point(168, 74)
        Me.tbxTest2.MaxLength = 3
        Me.tbxTest2.Name = "tbxTest2"
        Me.tbxTest2.Size = New System.Drawing.Size(100, 20)
        Me.tbxTest2.TabIndex = 1
        Me.tbxTest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxTest3
        '
        Me.tbxTest3.Location = New System.Drawing.Point(168, 107)
        Me.tbxTest3.MaxLength = 3
        Me.tbxTest3.Name = "tbxTest3"
        Me.tbxTest3.Size = New System.Drawing.Size(100, 20)
        Me.tbxTest3.TabIndex = 2
        Me.tbxTest3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxAverage
        '
        Me.tbxAverage.Location = New System.Drawing.Point(168, 140)
        Me.tbxAverage.Name = "tbxAverage"
        Me.tbxAverage.ReadOnly = True
        Me.tbxAverage.Size = New System.Drawing.Size(100, 20)
        Me.tbxAverage.TabIndex = 6
        Me.tbxAverage.TabStop = False
        Me.tbxAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxLetterGrade
        '
        Me.tbxLetterGrade.Location = New System.Drawing.Point(168, 209)
        Me.tbxLetterGrade.Name = "tbxLetterGrade"
        Me.tbxLetterGrade.ReadOnly = True
        Me.tbxLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.tbxLetterGrade.TabIndex = 7
        Me.tbxLetterGrade.TabStop = False
        Me.tbxLetterGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDropLowestGrade
        '
        Me.cbxDropLowestGrade.AutoSize = True
        Me.cbxDropLowestGrade.Location = New System.Drawing.Point(12, 174)
        Me.cbxDropLowestGrade.Name = "cbxDropLowestGrade"
        Me.cbxDropLowestGrade.Size = New System.Drawing.Size(118, 17)
        Me.cbxDropLowestGrade.TabIndex = 8
        Me.cbxDropLowestGrade.TabStop = False
        Me.cbxDropLowestGrade.Text = "Drop Lowest Grade"
        Me.cbxDropLowestGrade.UseVisualStyleBackColor = True
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.AutoSize = True
        Me.lblLetterGrade.Location = New System.Drawing.Point(32, 209)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(69, 13)
        Me.lblLetterGrade.TabIndex = 9
        Me.lblLetterGrade.Text = "Letter Grade:"
        '
        'lblTest2
        '
        Me.lblTest2.AutoSize = True
        Me.lblTest2.Location = New System.Drawing.Point(32, 74)
        Me.lblTest2.Name = "lblTest2"
        Me.lblTest2.Size = New System.Drawing.Size(40, 13)
        Me.lblTest2.TabIndex = 10
        Me.lblTest2.Text = "Test 2:"
        '
        'lblTest3
        '
        Me.lblTest3.AutoSize = True
        Me.lblTest3.Location = New System.Drawing.Point(32, 107)
        Me.lblTest3.Name = "lblTest3"
        Me.lblTest3.Size = New System.Drawing.Size(40, 13)
        Me.lblTest3.TabIndex = 11
        Me.lblTest3.Text = "Test 3:"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(32, 140)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(50, 13)
        Me.lblAverage.TabIndex = 12
        Me.lblAverage.Text = "Average:"
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Location = New System.Drawing.Point(32, 41)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(40, 13)
        Me.lblText1.TabIndex = 13
        Me.lblText1.Text = "Test 1:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(103, 285)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(98, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "© Tom Sroka 2010"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(305, 311)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblText1)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTest3)
        Me.Controls.Add(Me.lblTest2)
        Me.Controls.Add(Me.lblLetterGrade)
        Me.Controls.Add(Me.cbxDropLowestGrade)
        Me.Controls.Add(Me.tbxLetterGrade)
        Me.Controls.Add(Me.tbxAverage)
        Me.Controls.Add(Me.tbxTest3)
        Me.Controls.Add(Me.tbxTest2)
        Me.Controls.Add(Me.tbxTest1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tom's Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tbxTest1 As System.Windows.Forms.TextBox
    Friend WithEvents tbxTest2 As System.Windows.Forms.TextBox
    Friend WithEvents tbxTest3 As System.Windows.Forms.TextBox
    Friend WithEvents tbxAverage As System.Windows.Forms.TextBox
    Friend WithEvents tbxLetterGrade As System.Windows.Forms.TextBox
    Friend WithEvents cbxDropLowestGrade As System.Windows.Forms.CheckBox
    Friend WithEvents lblLetterGrade As System.Windows.Forms.Label
    Friend WithEvents lblTest2 As System.Windows.Forms.Label
    Friend WithEvents lblTest3 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblText1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
