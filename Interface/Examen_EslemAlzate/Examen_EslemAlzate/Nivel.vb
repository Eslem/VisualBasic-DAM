Public Class Nivel

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Form1.maxIntentos = 10
        ElseIf RadioButton2.Checked Then
            Form1.maxIntentos = 8
        ElseIf RadioButton3.Checked Then
            Form1.maxIntentos = 6
        End If

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class