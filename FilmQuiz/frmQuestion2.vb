﻿Public Class frmQuestion2
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer3.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer1.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion3.Show()
        Me.Hide()

    End Sub
End Class