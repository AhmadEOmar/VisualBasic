<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeEntry
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HourBox = New System.Windows.Forms.TextBox()
        Me.SubmitTime = New System.Windows.Forms.Button()
        Me.GetPayment = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClearTime = New System.Windows.Forms.Button()
        Me.TimeRecords = New System.Windows.Forms.Label()
        Me.TimeListBox = New System.Windows.Forms.ListBox()
        Me.PaymentLable = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Time (Hours) for each day."
        '
        'HourBox
        '
        Me.HourBox.Location = New System.Drawing.Point(39, 66)
        Me.HourBox.Name = "HourBox"
        Me.HourBox.Size = New System.Drawing.Size(157, 20)
        Me.HourBox.TabIndex = 1
        '
        'SubmitTime
        '
        Me.SubmitTime.Location = New System.Drawing.Point(39, 103)
        Me.SubmitTime.Name = "SubmitTime"
        Me.SubmitTime.Size = New System.Drawing.Size(157, 23)
        Me.SubmitTime.TabIndex = 2
        Me.SubmitTime.Text = "Submit time"
        Me.SubmitTime.UseVisualStyleBackColor = True
        '
        'GetPayment
        '
        Me.GetPayment.Enabled = False
        Me.GetPayment.Location = New System.Drawing.Point(39, 159)
        Me.GetPayment.Name = "GetPayment"
        Me.GetPayment.Size = New System.Drawing.Size(157, 23)
        Me.GetPayment.TabIndex = 3
        Me.GetPayment.Text = "Get payment"
        Me.GetPayment.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your payment is:"
        '
        'ClearTime
        '
        Me.ClearTime.Location = New System.Drawing.Point(39, 369)
        Me.ClearTime.Name = "ClearTime"
        Me.ClearTime.Size = New System.Drawing.Size(154, 23)
        Me.ClearTime.TabIndex = 6
        Me.ClearTime.Text = "Clear time"
        Me.ClearTime.UseVisualStyleBackColor = True
        '
        'TimeRecords
        '
        Me.TimeRecords.AutoSize = True
        Me.TimeRecords.Location = New System.Drawing.Point(248, 33)
        Me.TimeRecords.Name = "TimeRecords"
        Me.TimeRecords.Size = New System.Drawing.Size(68, 13)
        Me.TimeRecords.TabIndex = 8
        Me.TimeRecords.Text = "Time records"
        '
        'TimeListBox
        '
        Me.TimeListBox.FormattingEnabled = True
        Me.TimeListBox.Location = New System.Drawing.Point(234, 66)
        Me.TimeListBox.Name = "TimeListBox"
        Me.TimeListBox.Size = New System.Drawing.Size(183, 329)
        Me.TimeListBox.TabIndex = 9
        '
        'PaymentLable
        '
        Me.PaymentLable.BackColor = System.Drawing.SystemColors.Control
        Me.PaymentLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaymentLable.Cursor = System.Windows.Forms.Cursors.Default
        Me.PaymentLable.Location = New System.Drawing.Point(45, 252)
        Me.PaymentLable.Name = "PaymentLable"
        Me.PaymentLable.Size = New System.Drawing.Size(151, 102)
        Me.PaymentLable.TabIndex = 10
        Me.PaymentLable.Text = ""
        '
        'TimeEntry
        '
        Me.AcceptButton = Me.SubmitTime
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 469)
        Me.Controls.Add(Me.PaymentLable)
        Me.Controls.Add(Me.TimeListBox)
        Me.Controls.Add(Me.TimeRecords)
        Me.Controls.Add(Me.ClearTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GetPayment)
        Me.Controls.Add(Me.SubmitTime)
        Me.Controls.Add(Me.HourBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "TimeEntry"
        Me.Text = "Time Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HourBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitTime As System.Windows.Forms.Button
    Friend WithEvents GetPayment As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClearTime As System.Windows.Forms.Button
    Friend WithEvents TimeRecords As System.Windows.Forms.Label
    Friend WithEvents TimeListBox As System.Windows.Forms.ListBox
    Friend WithEvents PaymentLable As System.Windows.Forms.RichTextBox

End Class
