Public Class UVDose
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTakeQuiz.Click
        FitzpatrickQuiz.Show()
    End Sub

    Private Sub CmbComPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComPort.SelectedIndexChanged
        btnConnect.Enabled = True
    End Sub

    Private Sub CmbSkinType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSkinType.SelectedIndexChanged
        If cmbSkinType.SelectedItem = "Deselect" Then
            btnTakeQuiz.Enabled = True
            lblSkinType.Visible = False
            lblSkinType.Text = ""
        Else btnTakeQuiz.Enabled = False
            lblSkinType.Visible = True
            lblSkinType.Text = "Your Fitzpatrick Skin Type is: " + cmbSkinType.SelectedItem
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub LblReading_Click(sender As Object, e As EventArgs) Handles lblReading.Click

    End Sub
End Class
