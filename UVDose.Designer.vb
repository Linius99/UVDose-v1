<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UVDose
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
        Me.btnTakeQuiz = New System.Windows.Forms.Button()
        Me.lblQuizInstruct = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.cmbSkinType = New System.Windows.Forms.ComboBox()
        Me.lblSerialInstruct = New System.Windows.Forms.Label()
        Me.cmbComPort = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblReading = New System.Windows.Forms.Label()
        Me.lblSkinType = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTakeQuiz
        '
        Me.btnTakeQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeQuiz.Location = New System.Drawing.Point(407, 485)
        Me.btnTakeQuiz.Name = "btnTakeQuiz"
        Me.btnTakeQuiz.Size = New System.Drawing.Size(158, 56)
        Me.btnTakeQuiz.TabIndex = 0
        Me.btnTakeQuiz.Text = "Take Quiz"
        Me.btnTakeQuiz.UseVisualStyleBackColor = True
        '
        'lblQuizInstruct
        '
        Me.lblQuizInstruct.AutoSize = True
        Me.lblQuizInstruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuizInstruct.Location = New System.Drawing.Point(25, 410)
        Me.lblQuizInstruct.Name = "lblQuizInstruct"
        Me.lblQuizInstruct.Size = New System.Drawing.Size(698, 58)
        Me.lblQuizInstruct.TabIndex = 1
        Me.lblQuizInstruct.Text = "Please select your Fitzpatrick Skin Type from the dropdown box " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "below or take th" &
    "e quiz to determine it:"
        '
        'btnConnect
        '
        Me.btnConnect.Enabled = False
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(30, 74)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(158, 56)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnect.Location = New System.Drawing.Point(220, 74)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(158, 56)
        Me.btnDisconnect.TabIndex = 3
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'cmbSkinType
        '
        Me.cmbSkinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSkinType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSkinType.FormattingEnabled = True
        Me.cmbSkinType.Items.AddRange(New Object() {"Type I (1)", "Type II (2)", "Type III (3)", "Type IV (4)", "Type V (5)", "Type VI (6)", "Deselect"})
        Me.cmbSkinType.Location = New System.Drawing.Point(241, 496)
        Me.cmbSkinType.Name = "cmbSkinType"
        Me.cmbSkinType.Size = New System.Drawing.Size(137, 33)
        Me.cmbSkinType.TabIndex = 4
        '
        'lblSerialInstruct
        '
        Me.lblSerialInstruct.AutoSize = True
        Me.lblSerialInstruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialInstruct.Location = New System.Drawing.Point(25, 24)
        Me.lblSerialInstruct.Name = "lblSerialInstruct"
        Me.lblSerialInstruct.Size = New System.Drawing.Size(437, 29)
        Me.lblSerialInstruct.TabIndex = 5
        Me.lblSerialInstruct.Text = "Please select a COM Port to connect to:"
        '
        'cmbComPort
        '
        Me.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComPort.FormattingEnabled = True
        Me.cmbComPort.Items.AddRange(New Object() {"COMX", "COMY", "COMZ"})
        Me.cmbComPort.Location = New System.Drawing.Point(480, 20)
        Me.cmbComPort.Name = "cmbComPort"
        Me.cmbComPort.Size = New System.Drawing.Size(137, 33)
        Me.cmbComPort.TabIndex = 6
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(407, 90)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(210, 25)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status: Not Connected"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(25, 180)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(133, 25)
        Me.lblInput.TabIndex = 8
        Me.lblInput.Text = "Input to serial:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(301, 180)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(171, 25)
        Me.lblOutput.TabIndex = 9
        Me.lblOutput.Text = "Output from serial:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(30, 221)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(261, 101)
        Me.txtInput.TabIndex = 10
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(306, 221)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(245, 150)
        Me.txtOut.TabIndex = 11
        '
        'lblReading
        '
        Me.lblReading.AutoSize = True
        Me.lblReading.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReading.Location = New System.Drawing.Point(571, 279)
        Me.lblReading.Name = "lblReading"
        Me.lblReading.Size = New System.Drawing.Size(99, 25)
        Me.lblReading.TabIndex = 12
        Me.lblReading.Text = "UV Index:"
        '
        'lblSkinType
        '
        Me.lblSkinType.AutoSize = True
        Me.lblSkinType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkinType.Location = New System.Drawing.Point(138, 553)
        Me.lblSkinType.Name = "lblSkinType"
        Me.lblSkinType.Size = New System.Drawing.Size(295, 25)
        Me.lblSkinType.TabIndex = 13
        Me.lblSkinType.Text = "Your Fitzpatrick Skin Type is:"
        Me.lblSkinType.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.Enabled = False
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(80, 328)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(158, 43)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'UVDose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 601)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblSkinType)
        Me.Controls.Add(Me.lblReading)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbComPort)
        Me.Controls.Add(Me.lblSerialInstruct)
        Me.Controls.Add(Me.cmbSkinType)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblQuizInstruct)
        Me.Controls.Add(Me.btnTakeQuiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UVDose"
        Me.Text = "UVDose V1 (G10)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTakeQuiz As Button
    Friend WithEvents lblQuizInstruct As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents cmbSkinType As ComboBox
    Friend WithEvents lblSerialInstruct As Label
    Friend WithEvents cmbComPort As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOut As TextBox
    Friend WithEvents lblReading As Label
    Friend WithEvents lblSkinType As Label
    Friend WithEvents btnEnter As Button
End Class
