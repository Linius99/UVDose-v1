<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FitzpatrickQuiz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblQuizInstruct = New System.Windows.Forms.Label()
        Me.lblGeneticQ2 = New System.Windows.Forms.Label()
        Me.lblGeneticQ1 = New System.Windows.Forms.Label()
        Me.lblGenetic = New System.Windows.Forms.Label()
        Me.lblGeneticQ3 = New System.Windows.Forms.Label()
        Me.lblGeneticQ4 = New System.Windows.Forms.Label()
        Me.lblSensitivity = New System.Windows.Forms.Label()
        Me.lblSensitivityQ4 = New System.Windows.Forms.Label()
        Me.lblSensitivityQ3 = New System.Windows.Forms.Label()
        Me.lblSensitivityQ1 = New System.Windows.Forms.Label()
        Me.lblSensitivtyQ2 = New System.Windows.Forms.Label()
        Me.lblTan = New System.Windows.Forms.Label()
        Me.lblTanQ2 = New System.Windows.Forms.Label()
        Me.lblTanQ1 = New System.Windows.Forms.Label()
        Me.btnSubmitQuiz = New System.Windows.Forms.Button()
        Me.cmbGeneticQ1 = New System.Windows.Forms.ComboBox()
        Me.cmbTanQ2 = New System.Windows.Forms.ComboBox()
        Me.cmbTanQ1 = New System.Windows.Forms.ComboBox()
        Me.cmbSensitivityQ4 = New System.Windows.Forms.ComboBox()
        Me.cmbSensitivityQ3 = New System.Windows.Forms.ComboBox()
        Me.cmbSensitivityQ2 = New System.Windows.Forms.ComboBox()
        Me.cmbSensitivityQ1 = New System.Windows.Forms.ComboBox()
        Me.cmbGeneticQ4 = New System.Windows.Forms.ComboBox()
        Me.cmbGeneticQ3 = New System.Windows.Forms.ComboBox()
        Me.cmbGeneticQ2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblQuizInstruct
        '
        Me.lblQuizInstruct.AutoSize = True
        Me.lblQuizInstruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuizInstruct.Location = New System.Drawing.Point(12, 27)
        Me.lblQuizInstruct.Name = "lblQuizInstruct"
        Me.lblQuizInstruct.Size = New System.Drawing.Size(843, 25)
        Me.lblQuizInstruct.TabIndex = 3
        Me.lblQuizInstruct.Text = "For the questions below, select the option from the dropdown which describes you " &
    "best"
        '
        'lblGeneticQ2
        '
        Me.lblGeneticQ2.AutoSize = True
        Me.lblGeneticQ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneticQ2.Location = New System.Drawing.Point(81, 150)
        Me.lblGeneticQ2.Name = "lblGeneticQ2"
        Me.lblGeneticQ2.Size = New System.Drawing.Size(523, 25)
        Me.lblGeneticQ2.TabIndex = 4
        Me.lblGeneticQ2.Text = "What is the colour of your hair (naturally and before aging)?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblGeneticQ1
        '
        Me.lblGeneticQ1.AutoSize = True
        Me.lblGeneticQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneticQ1.Location = New System.Drawing.Point(81, 110)
        Me.lblGeneticQ1.Name = "lblGeneticQ1"
        Me.lblGeneticQ1.Size = New System.Drawing.Size(290, 25)
        Me.lblGeneticQ1.TabIndex = 5
        Me.lblGeneticQ1.Text = "What is the colour of your eyes?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblGenetic
        '
        Me.lblGenetic.AutoSize = True
        Me.lblGenetic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenetic.Location = New System.Drawing.Point(29, 70)
        Me.lblGenetic.Name = "lblGenetic"
        Me.lblGenetic.Size = New System.Drawing.Size(217, 25)
        Me.lblGenetic.TabIndex = 6
        Me.lblGenetic.Text = "Genetic (Physical traits)"
        '
        'lblGeneticQ3
        '
        Me.lblGeneticQ3.AutoSize = True
        Me.lblGeneticQ3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneticQ3.Location = New System.Drawing.Point(81, 189)
        Me.lblGeneticQ3.Name = "lblGeneticQ3"
        Me.lblGeneticQ3.Size = New System.Drawing.Size(453, 25)
        Me.lblGeneticQ3.TabIndex = 7
        Me.lblGeneticQ3.Text = "What is the colour of your skin (unexposed areas)?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblGeneticQ4
        '
        Me.lblGeneticQ4.AutoSize = True
        Me.lblGeneticQ4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneticQ4.Location = New System.Drawing.Point(81, 227)
        Me.lblGeneticQ4.Name = "lblGeneticQ4"
        Me.lblGeneticQ4.Size = New System.Drawing.Size(388, 25)
        Me.lblGeneticQ4.TabIndex = 8
        Me.lblGeneticQ4.Text = "Do you have freckles on unexposed areas?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSensitivity
        '
        Me.lblSensitivity.AutoSize = True
        Me.lblSensitivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSensitivity.Location = New System.Drawing.Point(29, 275)
        Me.lblSensitivity.Name = "lblSensitivity"
        Me.lblSensitivity.Size = New System.Drawing.Size(332, 25)
        Me.lblSensitivity.TabIndex = 9
        Me.lblSensitivity.Text = "Sensitivity (reaction to sun exposure)"
        '
        'lblSensitivityQ4
        '
        Me.lblSensitivityQ4.AutoSize = True
        Me.lblSensitivityQ4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSensitivityQ4.Location = New System.Drawing.Point(81, 451)
        Me.lblSensitivityQ4.Name = "lblSensitivityQ4"
        Me.lblSensitivityQ4.Size = New System.Drawing.Size(294, 25)
        Me.lblSensitivityQ4.TabIndex = 13
        Me.lblSensitivityQ4.Text = "Is your face sensitive to the sun?"
        '
        'lblSensitivityQ3
        '
        Me.lblSensitivityQ3.AutoSize = True
        Me.lblSensitivityQ3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSensitivityQ3.Location = New System.Drawing.Point(81, 413)
        Me.lblSensitivityQ3.Name = "lblSensitivityQ3"
        Me.lblSensitivityQ3.Size = New System.Drawing.Size(216, 25)
        Me.lblSensitivityQ3.TabIndex = 12
        Me.lblSensitivityQ3.Text = "How brown do you get?"
        '
        'lblSensitivityQ1
        '
        Me.lblSensitivityQ1.AutoSize = True
        Me.lblSensitivityQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSensitivityQ1.Location = New System.Drawing.Point(81, 315)
        Me.lblSensitivityQ1.Name = "lblSensitivityQ1"
        Me.lblSensitivityQ1.Size = New System.Drawing.Size(478, 50)
        Me.lblSensitivityQ1.TabIndex = 11
        Me.lblSensitivityQ1.Text = "What happens to you skin if you stay in the sun for an " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "extended period?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSensitivtyQ2
        '
        Me.lblSensitivtyQ2.AutoSize = True
        Me.lblSensitivtyQ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSensitivtyQ2.Location = New System.Drawing.Point(81, 376)
        Me.lblSensitivtyQ2.Name = "lblSensitivtyQ2"
        Me.lblSensitivtyQ2.Size = New System.Drawing.Size(347, 25)
        Me.lblSensitivtyQ2.TabIndex = 10
        Me.lblSensitivtyQ2.Text = "Do you turn brown after sun exposure?"
        '
        'lblTan
        '
        Me.lblTan.AutoSize = True
        Me.lblTan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTan.Location = New System.Drawing.Point(29, 491)
        Me.lblTan.Name = "lblTan"
        Me.lblTan.Size = New System.Drawing.Size(327, 25)
        Me.lblTan.TabIndex = 14
        Me.lblTan.Text = "Intentional exposure (tanning habits)"
        '
        'lblTanQ2
        '
        Me.lblTanQ2.AutoSize = True
        Me.lblTanQ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanQ2.Location = New System.Drawing.Point(81, 573)
        Me.lblTanQ2.Name = "lblTanQ2"
        Me.lblTanQ2.Size = New System.Drawing.Size(506, 50)
        Me.lblTanQ2.TabIndex = 16
        Me.lblTanQ2.Text = "When did you last expose your skin to the sun or artificial " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tanning sources (ta" &
    "nning beds)?"
        '
        'lblTanQ1
        '
        Me.lblTanQ1.AutoSize = True
        Me.lblTanQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanQ1.Location = New System.Drawing.Point(81, 534)
        Me.lblTanQ1.Name = "lblTanQ1"
        Me.lblTanQ1.Size = New System.Drawing.Size(200, 25)
        Me.lblTanQ1.TabIndex = 15
        Me.lblTanQ1.Text = "How often to you tan?"
        '
        'btnSubmitQuiz
        '
        Me.btnSubmitQuiz.Enabled = False
        Me.btnSubmitQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitQuiz.Location = New System.Drawing.Point(446, 643)
        Me.btnSubmitQuiz.Name = "btnSubmitQuiz"
        Me.btnSubmitQuiz.Size = New System.Drawing.Size(158, 47)
        Me.btnSubmitQuiz.TabIndex = 17
        Me.btnSubmitQuiz.Text = "Submit"
        Me.btnSubmitQuiz.UseVisualStyleBackColor = True
        '
        'cmbGeneticQ1
        '
        Me.cmbGeneticQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneticQ1.DropDownWidth = 150
        Me.cmbGeneticQ1.FormattingEnabled = True
        Me.cmbGeneticQ1.Items.AddRange(New Object() {"Light blue or green, grey", "Blue, green, grey", "Dark blue/green, light brown (hazel)", "Dark brown", "Brownish black"})
        Me.cmbGeneticQ1.Location = New System.Drawing.Point(674, 110)
        Me.cmbGeneticQ1.Name = "cmbGeneticQ1"
        Me.cmbGeneticQ1.Size = New System.Drawing.Size(297, 28)
        Me.cmbGeneticQ1.TabIndex = 18
        '
        'cmbTanQ2
        '
        Me.cmbTanQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTanQ2.DropDownWidth = 150
        Me.cmbTanQ2.Enabled = False
        Me.cmbTanQ2.FormattingEnabled = True
        Me.cmbTanQ2.Items.AddRange(New Object() {"More than three months ago", "In the last 2-3 months", "In the last 2 months", "In the last week", "In the last day"})
        Me.cmbTanQ2.Location = New System.Drawing.Point(674, 573)
        Me.cmbTanQ2.Name = "cmbTanQ2"
        Me.cmbTanQ2.Size = New System.Drawing.Size(297, 28)
        Me.cmbTanQ2.TabIndex = 23
        '
        'cmbTanQ1
        '
        Me.cmbTanQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTanQ1.DropDownWidth = 150
        Me.cmbTanQ1.Enabled = False
        Me.cmbTanQ1.FormattingEnabled = True
        Me.cmbTanQ1.Items.AddRange(New Object() {"Never", "Rarely", "Sometimes", "Often", "Always"})
        Me.cmbTanQ1.Location = New System.Drawing.Point(674, 533)
        Me.cmbTanQ1.Name = "cmbTanQ1"
        Me.cmbTanQ1.Size = New System.Drawing.Size(297, 28)
        Me.cmbTanQ1.TabIndex = 24
        '
        'cmbSensitivityQ4
        '
        Me.cmbSensitivityQ4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSensitivityQ4.DropDownWidth = 150
        Me.cmbSensitivityQ4.Enabled = False
        Me.cmbSensitivityQ4.FormattingEnabled = True
        Me.cmbSensitivityQ4.Items.AddRange(New Object() {"Very sensitive", "Sensitive", "Mildly sensitive", "Resistant", "Very resistant"})
        Me.cmbSensitivityQ4.Location = New System.Drawing.Point(674, 451)
        Me.cmbSensitivityQ4.Name = "cmbSensitivityQ4"
        Me.cmbSensitivityQ4.Size = New System.Drawing.Size(297, 28)
        Me.cmbSensitivityQ4.TabIndex = 25
        '
        'cmbSensitivityQ3
        '
        Me.cmbSensitivityQ3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSensitivityQ3.DropDownWidth = 150
        Me.cmbSensitivityQ3.Enabled = False
        Me.cmbSensitivityQ3.FormattingEnabled = True
        Me.cmbSensitivityQ3.Items.AddRange(New Object() {"Hardly or not at all", "Light tan", "Medium tan", "Dark tan", "Very dark tan"})
        Me.cmbSensitivityQ3.Location = New System.Drawing.Point(674, 413)
        Me.cmbSensitivityQ3.Name = "cmbSensitivityQ3"
        Me.cmbSensitivityQ3.Size = New System.Drawing.Size(297, 28)
        Me.cmbSensitivityQ3.TabIndex = 26
        '
        'cmbSensitivityQ2
        '
        Me.cmbSensitivityQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSensitivityQ2.DropDownWidth = 150
        Me.cmbSensitivityQ2.Enabled = False
        Me.cmbSensitivityQ2.FormattingEnabled = True
        Me.cmbSensitivityQ2.Items.AddRange(New Object() {"Never", "Rarely", "Sometimes", "Often", "Always"})
        Me.cmbSensitivityQ2.Location = New System.Drawing.Point(674, 372)
        Me.cmbSensitivityQ2.Name = "cmbSensitivityQ2"
        Me.cmbSensitivityQ2.Size = New System.Drawing.Size(297, 28)
        Me.cmbSensitivityQ2.TabIndex = 27
        '
        'cmbSensitivityQ1
        '
        Me.cmbSensitivityQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSensitivityQ1.DropDownWidth = 150
        Me.cmbSensitivityQ1.Enabled = False
        Me.cmbSensitivityQ1.FormattingEnabled = True
        Me.cmbSensitivityQ1.Items.AddRange(New Object() {"Severe burns, blistering, peeling ", "Moderate burns, blistering, peeling", "Burns sometimes followed by peeling", "Rare burns", "No burns"})
        Me.cmbSensitivityQ1.Location = New System.Drawing.Point(674, 315)
        Me.cmbSensitivityQ1.Name = "cmbSensitivityQ1"
        Me.cmbSensitivityQ1.Size = New System.Drawing.Size(297, 28)
        Me.cmbSensitivityQ1.TabIndex = 28
        '
        'cmbGeneticQ4
        '
        Me.cmbGeneticQ4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneticQ4.DropDownWidth = 150
        Me.cmbGeneticQ4.Enabled = False
        Me.cmbGeneticQ4.FormattingEnabled = True
        Me.cmbGeneticQ4.Items.AddRange(New Object() {"Many", "Several", "Few", "Rare", "None"})
        Me.cmbGeneticQ4.Location = New System.Drawing.Point(674, 227)
        Me.cmbGeneticQ4.Name = "cmbGeneticQ4"
        Me.cmbGeneticQ4.Size = New System.Drawing.Size(297, 28)
        Me.cmbGeneticQ4.TabIndex = 29
        '
        'cmbGeneticQ3
        '
        Me.cmbGeneticQ3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneticQ3.DropDownWidth = 150
        Me.cmbGeneticQ3.Enabled = False
        Me.cmbGeneticQ3.FormattingEnabled = True
        Me.cmbGeneticQ3.Items.AddRange(New Object() {"Pink", "Very pale", "Light brown or olive", "Brown", "Dark brown"})
        Me.cmbGeneticQ3.Location = New System.Drawing.Point(674, 189)
        Me.cmbGeneticQ3.Name = "cmbGeneticQ3"
        Me.cmbGeneticQ3.Size = New System.Drawing.Size(297, 28)
        Me.cmbGeneticQ3.TabIndex = 30
        '
        'cmbGeneticQ2
        '
        Me.cmbGeneticQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneticQ2.DropDownWidth = 150
        Me.cmbGeneticQ2.Enabled = False
        Me.cmbGeneticQ2.FormattingEnabled = True
        Me.cmbGeneticQ2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmbGeneticQ2.Items.AddRange(New Object() {"Red", "Blonde", "Chestnut or dark blonde", "Dark brown", "Black"})
        Me.cmbGeneticQ2.Location = New System.Drawing.Point(674, 150)
        Me.cmbGeneticQ2.Name = "cmbGeneticQ2"
        Me.cmbGeneticQ2.Size = New System.Drawing.Size(297, 28)
        Me.cmbGeneticQ2.TabIndex = 31
        '
        'FitzpatrickQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 712)
        Me.Controls.Add(Me.cmbGeneticQ2)
        Me.Controls.Add(Me.cmbGeneticQ3)
        Me.Controls.Add(Me.cmbGeneticQ4)
        Me.Controls.Add(Me.cmbSensitivityQ1)
        Me.Controls.Add(Me.cmbSensitivityQ2)
        Me.Controls.Add(Me.cmbSensitivityQ3)
        Me.Controls.Add(Me.cmbSensitivityQ4)
        Me.Controls.Add(Me.cmbTanQ1)
        Me.Controls.Add(Me.cmbTanQ2)
        Me.Controls.Add(Me.cmbGeneticQ1)
        Me.Controls.Add(Me.btnSubmitQuiz)
        Me.Controls.Add(Me.lblTanQ2)
        Me.Controls.Add(Me.lblTanQ1)
        Me.Controls.Add(Me.lblTan)
        Me.Controls.Add(Me.lblSensitivityQ4)
        Me.Controls.Add(Me.lblSensitivityQ3)
        Me.Controls.Add(Me.lblSensitivityQ1)
        Me.Controls.Add(Me.lblSensitivtyQ2)
        Me.Controls.Add(Me.lblSensitivity)
        Me.Controls.Add(Me.lblGeneticQ4)
        Me.Controls.Add(Me.lblGeneticQ3)
        Me.Controls.Add(Me.lblGenetic)
        Me.Controls.Add(Me.lblGeneticQ1)
        Me.Controls.Add(Me.lblGeneticQ2)
        Me.Controls.Add(Me.lblQuizInstruct)
        Me.MaximizeBox = False
        Me.Name = "FitzpatrickQuiz"
        Me.Text = "Fitzpatrick Skin Type Quiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuizInstruct As Label
    Friend WithEvents lblGeneticQ2 As Label
    Friend WithEvents lblGeneticQ1 As Label
    Friend WithEvents lblGenetic As Label
    Friend WithEvents lblGeneticQ3 As Label
    Friend WithEvents lblGeneticQ4 As Label
    Friend WithEvents lblSensitivity As Label
    Friend WithEvents lblSensitivityQ4 As Label
    Friend WithEvents lblSensitivityQ3 As Label
    Friend WithEvents lblSensitivityQ1 As Label
    Friend WithEvents lblSensitivtyQ2 As Label
    Friend WithEvents lblTan As Label
    Friend WithEvents lblTanQ2 As Label
    Friend WithEvents lblTanQ1 As Label
    Friend WithEvents btnSubmitQuiz As Button
    Friend WithEvents cmbGeneticQ1 As ComboBox
    Friend WithEvents cmbTanQ2 As ComboBox
    Friend WithEvents cmbTanQ1 As ComboBox
    Friend WithEvents cmbSensitivityQ4 As ComboBox
    Friend WithEvents cmbSensitivityQ3 As ComboBox
    Friend WithEvents cmbSensitivityQ2 As ComboBox
    Friend WithEvents cmbSensitivityQ1 As ComboBox
    Friend WithEvents cmbGeneticQ4 As ComboBox
    Friend WithEvents cmbGeneticQ3 As ComboBox
    Friend WithEvents cmbGeneticQ2 As ComboBox
End Class
