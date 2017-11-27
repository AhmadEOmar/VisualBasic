<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageApplication
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
        Me.Test1Score = New System.Windows.Forms.Label()
        Me.Test2Score = New System.Windows.Forms.Label()
        Me.Test3Score = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Average = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AverageOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Test1Score
        '
        Me.Test1Score.AutoSize = True
        Me.Test1Score.Location = New System.Drawing.Point(33, 26)
        Me.Test1Score.Name = "Test1Score"
        Me.Test1Score.Size = New System.Drawing.Size(68, 13)
        Me.Test1Score.TabIndex = 0
        Me.Test1Score.Text = "Test 1 Score"
        '
        'Test2Score
        '
        Me.Test2Score.AutoSize = True
        Me.Test2Score.Location = New System.Drawing.Point(33, 92)
        Me.Test2Score.Name = "Test2Score"
        Me.Test2Score.Size = New System.Drawing.Size(68, 13)
        Me.Test2Score.TabIndex = 1
        Me.Test2Score.Text = "Test 2 Score"
        '
        'Test3Score
        '
        Me.Test3Score.AutoSize = True
        Me.Test3Score.Location = New System.Drawing.Point(33, 155)
        Me.Test3Score.Name = "Test3Score"
        Me.Test3Score.Size = New System.Drawing.Size(68, 13)
        Me.Test3Score.TabIndex = 2
        Me.Test3Score.Text = "Test 3 Score"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(164, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(164, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Average
        '
        Me.Average.Location = New System.Drawing.Point(90, 194)
        Me.Average.Name = "Average"
        Me.Average.Size = New System.Drawing.Size(126, 23)
        Me.Average.TabIndex = 6
        Me.Average.Text = "Calculate Average"
        Me.Average.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "AverageScore"
        '
        'AverageOutput
        '
        Me.AverageOutput.BackColor = System.Drawing.SystemColors.Control
        Me.AverageOutput.Location = New System.Drawing.Point(164, 240)
        Me.AverageOutput.Name = "AverageOutput"
        Me.AverageOutput.Size = New System.Drawing.Size(100, 20)
        Me.AverageOutput.TabIndex = 8
        '
        'AverageApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 289)
        Me.Controls.Add(Me.AverageOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Average)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Test3Score)
        Me.Controls.Add(Me.Test2Score)
        Me.Controls.Add(Me.Test1Score)
        Me.Name = "AverageApplication"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Test1Score As System.Windows.Forms.Label
    Friend WithEvents Test2Score As System.Windows.Forms.Label
    Friend WithEvents Test3Score As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Average As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AverageOutput As System.Windows.Forms.TextBox

End Class
