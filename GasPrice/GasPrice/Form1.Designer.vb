<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GasPrice
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
        Me.GasPriceLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PriceLocation = New System.Windows.Forms.TextBox()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.HighestButton = New System.Windows.Forms.Button()
        Me.LowestButton = New System.Windows.Forms.Button()
        Me.AverageButton = New System.Windows.Forms.Button()
        Me.OutPut = New System.Windows.Forms.TextBox()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GasPriceLabel
        '
        Me.GasPriceLabel.AutoSize = True
        Me.GasPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GasPriceLabel.Location = New System.Drawing.Point(31, 19)
        Me.GasPriceLabel.Name = "GasPriceLabel"
        Me.GasPriceLabel.Size = New System.Drawing.Size(66, 15)
        Me.GasPriceLabel.TabIndex = 1
        Me.GasPriceLabel.Text = "Gas Prices"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Price"
        '
        'PriceLocation
        '
        Me.PriceLocation.BackColor = System.Drawing.SystemColors.Control
        Me.PriceLocation.Location = New System.Drawing.Point(256, 32)
        Me.PriceLocation.Name = "PriceLocation"
        Me.PriceLocation.Size = New System.Drawing.Size(121, 20)
        Me.PriceLocation.TabIndex = 3
        '
        'EnterButton
        '
        Me.EnterButton.Location = New System.Drawing.Point(230, 96)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(121, 23)
        Me.EnterButton.TabIndex = 4
        Me.EnterButton.Text = "Enter"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'HighestButton
        '
        Me.HighestButton.Location = New System.Drawing.Point(230, 125)
        Me.HighestButton.Name = "HighestButton"
        Me.HighestButton.Size = New System.Drawing.Size(121, 23)
        Me.HighestButton.TabIndex = 5
        Me.HighestButton.Text = "Get Highest Price"
        Me.HighestButton.UseVisualStyleBackColor = True
        '
        'LowestButton
        '
        Me.LowestButton.Location = New System.Drawing.Point(230, 154)
        Me.LowestButton.Name = "LowestButton"
        Me.LowestButton.Size = New System.Drawing.Size(121, 23)
        Me.LowestButton.TabIndex = 6
        Me.LowestButton.Text = "Get Lowest Price"
        Me.LowestButton.UseVisualStyleBackColor = True
        '
        'AverageButton
        '
        Me.AverageButton.Location = New System.Drawing.Point(230, 183)
        Me.AverageButton.Name = "AverageButton"
        Me.AverageButton.Size = New System.Drawing.Size(121, 23)
        Me.AverageButton.TabIndex = 7
        Me.AverageButton.Text = "Get Average Price"
        Me.AverageButton.UseVisualStyleBackColor = True
        '
        'OutPut
        '
        Me.OutPut.BackColor = System.Drawing.SystemColors.Control
        Me.OutPut.Location = New System.Drawing.Point(208, 291)
        Me.OutPut.Name = "OutPut"
        Me.OutPut.Size = New System.Drawing.Size(169, 20)
        Me.OutPut.TabIndex = 8
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(230, 212)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(121, 23)
        Me.DisplayButton.TabIndex = 9
        Me.DisplayButton.Text = "Display"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ListView
        '
        Me.ListView.Location = New System.Drawing.Point(34, 57)
        Me.ListView.Multiline = True
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(137, 254)
        Me.ListView.TabIndex = 10
        '
        'GasPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 346)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.OutPut)
        Me.Controls.Add(Me.AverageButton)
        Me.Controls.Add(Me.LowestButton)
        Me.Controls.Add(Me.HighestButton)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.PriceLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GasPriceLabel)
        Me.Name = "GasPrice"
        Me.Text = "Gas Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GasPriceLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PriceLocation As System.Windows.Forms.TextBox
    Friend WithEvents EnterButton As System.Windows.Forms.Button
    Friend WithEvents HighestButton As System.Windows.Forms.Button
    Friend WithEvents LowestButton As System.Windows.Forms.Button
    Friend WithEvents AverageButton As System.Windows.Forms.Button
    Friend WithEvents OutPut As System.Windows.Forms.TextBox
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
    Friend WithEvents ListView As System.Windows.Forms.TextBox

End Class
