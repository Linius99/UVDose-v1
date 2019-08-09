Public Class FitzpatrickQuiz

    Private Sub CmbGeneticQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGeneticQ1.SelectedIndexChanged
        If cmbGeneticQ1.SelectedItem = "" Then
            cmbGeneticQ2.Enabled = False
        Else cmbGeneticQ2.Enabled = True
        End If

    End Sub

    Private Sub CmbGeneticQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGeneticQ2.SelectedIndexChanged
        If cmbGeneticQ2.SelectedItem = "" Then
            cmbGeneticQ3.Enabled = False
        Else cmbGeneticQ3.Enabled = True
        End If
    End Sub

    Private Sub CmbGeneticQ3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGeneticQ3.SelectedIndexChanged
        If cmbGeneticQ3.SelectedItem = "" Then
            cmbGeneticQ4.Enabled = False
        Else cmbGeneticQ4.Enabled = True
        End If
    End Sub

    Private Sub CmbGeneticQ4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGeneticQ4.SelectedIndexChanged
        If cmbGeneticQ4.SelectedItem = "" Then
            cmbSensitivityQ1.Enabled = False
        Else cmbSensitivityQ1.Enabled = True
        End If
    End Sub

    Private Sub CmbSensitivityQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSensitivityQ1.SelectedIndexChanged
        If cmbSensitivityQ1.SelectedItem = "" Then
            cmbSensitivityQ2.Enabled = False
        Else cmbSensitivityQ2.Enabled = True
        End If
    End Sub

    Private Sub CmbSensitivityQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSensitivityQ2.SelectedIndexChanged
        If cmbSensitivityQ2.SelectedItem = "" Then
            cmbSensitivityQ3.Enabled = False
        Else cmbSensitivityQ3.Enabled = True
        End If
    End Sub

    Private Sub CmbSensitivityQ3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSensitivityQ3.SelectedIndexChanged
        If cmbSensitivityQ3.SelectedItem = "" Then
            cmbSensitivityQ4.Enabled = False
        Else cmbSensitivityQ4.Enabled = True
        End If
    End Sub

    Private Sub CmbSensitivityQ4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSensitivityQ4.SelectedIndexChanged
        If cmbSensitivityQ4.SelectedItem = "" Then
            cmbTanQ1.Enabled = False
        Else cmbTanQ1.Enabled = True
        End If
    End Sub

    Private Sub CmbTanQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTanQ1.SelectedIndexChanged
        If cmbTanQ1.SelectedItem = "" Then
            cmbTanQ2.Enabled = False
        Else cmbTanQ2.Enabled = True
        End If
    End Sub

    Private Sub CmbTanQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTanQ2.SelectedIndexChanged
        If cmbTanQ2.SelectedItem = "" Then
            btnSubmitQuiz.Enabled = False
        Else btnSubmitQuiz.Enabled = True
        End If
    End Sub

    Private Sub BtnSubmitQuiz_Click(sender As Object, e As EventArgs) Handles btnSubmitQuiz.Click
        Dim score As Integer = 0
        Dim fitzType As String = ""

        score = (cmbGeneticQ1.SelectedIndex + cmbGeneticQ2.SelectedIndex +
            cmbGeneticQ3.SelectedIndex + cmbGeneticQ4.SelectedIndex +
            cmbSensitivityQ1.SelectedIndex + cmbSensitivityQ2.SelectedIndex +
            cmbSensitivityQ3.SelectedIndex + cmbSensitivityQ4.SelectedIndex +
            cmbTanQ1.SelectedIndex + cmbTanQ2.SelectedIndex)

        Select Case score
            Case 0 To 6
                fitzType = "Type I (1)"
            Case 7 To 13
                fitzType = "Type II (2)"
            Case 14 To 20
                fitzType = "Type III (3)"
            Case 21 To 27
                fitzType = "Type IV (4)"
            Case 28 To 34
                fitzType = "Type V (5)"
            Case 35 To 40
                fitzType = "Type VI (6)"
        End Select

        MessageBox.Show("Your Fitzpatrick Skin Type is: " + fitzType & Environment.NewLine +
                        "Click OK to Save")


        UVDose.lblSkinType.Text = "Your Fitzpatrick Skin Type is: " + fitzType
        UVDose.lblSkinType.Visible = True
        UVDose.cmbSkinType.Enabled = False
        UVDose.cmbSkinType.Text = fitzType

        Me.Close()
    End Sub
End Class