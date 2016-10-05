<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtMyGuess = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCmptrResp = New System.Windows.Forms.Label()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMyGuess
        '
        Me.txtMyGuess.Location = New System.Drawing.Point(72, 44)
        Me.txtMyGuess.Name = "txtMyGuess"
        Me.txtMyGuess.Size = New System.Drawing.Size(147, 20)
        Me.txtMyGuess.TabIndex = 0
        Me.txtMyGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Enter between 1-10:"
        '
        'lblCmptrResp
        '
        Me.lblCmptrResp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCmptrResp.Location = New System.Drawing.Point(72, 67)
        Me.lblCmptrResp.Name = "lblCmptrResp"
        Me.lblCmptrResp.Size = New System.Drawing.Size(147, 80)
        Me.lblCmptrResp.TabIndex = 2
        Me.lblCmptrResp.Text = " "
        Me.lblCmptrResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.Location = New System.Drawing.Point(72, 150)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(147, 23)
        Me.btnCheckAnswer.TabIndex = 3
        Me.btnCheckAnswer.Text = "&Check answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(72, 180)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(147, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(72, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.lblCmptrResp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMyGuess)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess the Number!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMyGuess As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCmptrResp As Label
    Friend WithEvents btnCheckAnswer As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
