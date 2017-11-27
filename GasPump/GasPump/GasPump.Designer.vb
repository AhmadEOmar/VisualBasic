<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GasPump
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
        Me.superButton = New System.Windows.Forms.Button()
        Me.specialButton = New System.Windows.Forms.Button()
        Me.regularButton = New System.Windows.Forms.Button()
        Me.totalResultLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.gallonsTextBox = New System.Windows.Forms.TextBox()
        Me.gallonsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'superButton
        '
        Me.superButton.Location = New System.Drawing.Point(264, 82)
        Me.superButton.Name = "superButton"
        Me.superButton.Size = New System.Drawing.Size(82, 72)
        Me.superButton.TabIndex = 13
        Me.superButton.Text = "Super"
        Me.superButton.UseVisualStyleBackColor = True
        '
        'specialButton
        '
        Me.specialButton.Location = New System.Drawing.Point(145, 82)
        Me.specialButton.Name = "specialButton"
        Me.specialButton.Size = New System.Drawing.Size(82, 72)
        Me.specialButton.TabIndex = 12
        Me.specialButton.Text = "Special"
        Me.specialButton.UseVisualStyleBackColor = True
        '
        'regularButton
        '
        Me.regularButton.Location = New System.Drawing.Point(31, 82)
        Me.regularButton.Name = "regularButton"
        Me.regularButton.Size = New System.Drawing.Size(82, 72)
        Me.regularButton.TabIndex = 11
        Me.regularButton.Text = "Regular"
        Me.regularButton.UseVisualStyleBackColor = True
        '
        'totalResultLabel
        '
        Me.totalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalResultLabel.Location = New System.Drawing.Point(154, 194)
        Me.totalResultLabel.Name = "totalResultLabel"
        Me.totalResultLabel.Size = New System.Drawing.Size(121, 33)
        Me.totalResultLabel.TabIndex = 10
        Me.totalResultLabel.Text = "$0.00"
        Me.totalResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(48, 200)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(82, 20)
        Me.totalLabel.TabIndex = 9
        Me.totalLabel.Text = "Total Price:"
        '
        'gallonsTextBox
        '
        Me.gallonsTextBox.Location = New System.Drawing.Point(169, 16)
        Me.gallonsTextBox.Name = "gallonsTextBox"
        Me.gallonsTextBox.Size = New System.Drawing.Size(168, 27)
        Me.gallonsTextBox.TabIndex = 8
        '
        'gallonsLabel
        '
        Me.gallonsLabel.AutoSize = True
        Me.gallonsLabel.Location = New System.Drawing.Point(12, 19)
        Me.gallonsLabel.Name = "gallonsLabel"
        Me.gallonsLabel.Size = New System.Drawing.Size(136, 20)
        Me.gallonsLabel.TabIndex = 7
        Me.gallonsLabel.Text = "Number of gallons:"
        '
        'GasPump
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 259)
        Me.Controls.Add(Me.superButton)
        Me.Controls.Add(Me.specialButton)
        Me.Controls.Add(Me.regularButton)
        Me.Controls.Add(Me.totalResultLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.gallonsTextBox)
        Me.Controls.Add(Me.gallonsLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GasPump"
        Me.Text = "Gas Pump"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents superButton As System.Windows.Forms.Button
   Friend WithEvents specialButton As System.Windows.Forms.Button
   Friend WithEvents regularButton As System.Windows.Forms.Button
   Friend WithEvents totalResultLabel As System.Windows.Forms.Label
   Friend WithEvents totalLabel As System.Windows.Forms.Label
   Friend WithEvents gallonsTextBox As System.Windows.Forms.TextBox
   Friend WithEvents gallonsLabel As System.Windows.Forms.Label

End Class
