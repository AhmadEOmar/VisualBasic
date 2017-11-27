<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TuitionCalculator
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
        Me.InputInfoLable = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreditHoursText = New System.Windows.Forms.TextBox()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TutionCost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'InputInfoLable
        '
        Me.InputInfoLable.AutoSize = True
        Me.InputInfoLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InputInfoLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputInfoLable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InputInfoLable.Location = New System.Drawing.Point(35, 48)
        Me.InputInfoLable.Name = "InputInfoLable"
        Me.InputInfoLable.Size = New System.Drawing.Size(164, 17)
        Me.InputInfoLable.TabIndex = 0
        Me.InputInfoLable.Text = "Enter number of credit hours"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select student ype to calculate tuition:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A - In-State Student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B - Out-of-State " & _
    "Student"
        '
        'CreditHoursText
        '
        Me.CreditHoursText.Location = New System.Drawing.Point(222, 47)
        Me.CreditHoursText.Name = "CreditHoursText"
        Me.CreditHoursText.Size = New System.Drawing.Size(100, 20)
        Me.CreditHoursText.TabIndex = 2
        '
        'ButtonA
        '
        Me.ButtonA.Location = New System.Drawing.Point(74, 191)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(75, 40)
        Me.ButtonA.TabIndex = 3
        Me.ButtonA.Text = "A"
        Me.ButtonA.UseVisualStyleBackColor = True
        '
        'ButtonB
        '
        Me.ButtonB.Location = New System.Drawing.Point(222, 191)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(75, 39)
        Me.ButtonB.TabIndex = 4
        Me.ButtonB.Text = "B"
        Me.ButtonB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Your tution is:"
        '
        'TutionCost
        '
        Me.TutionCost.BackColor = System.Drawing.SystemColors.Control
        Me.TutionCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TutionCost.Location = New System.Drawing.Point(163, 254)
        Me.TutionCost.Name = "TutionCost"
        Me.TutionCost.Size = New System.Drawing.Size(100, 13)
        Me.TutionCost.TabIndex = 6
        '
        'TuitionCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 315)
        Me.Controls.Add(Me.TutionCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonB)
        Me.Controls.Add(Me.ButtonA)
        Me.Controls.Add(Me.CreditHoursText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputInfoLable)
        Me.Name = "TuitionCalculator"
        Me.Text = "Tuition Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputInfoLable As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CreditHoursText As System.Windows.Forms.TextBox
    Friend WithEvents ButtonA As System.Windows.Forms.Button
    Friend WithEvents ButtonB As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TutionCost As System.Windows.Forms.TextBox

End Class
