Public Class Form1

    Dim randomizer As New Random

    Dim addend1 As Integer
    Dim addend2 As Integer

    Dim timeLeft As Integer

    Dim minuend As Integer
    Dim subtrahend As Integer

    Dim multiplicand As Integer
    Dim multiplier As Integer

    Dim dividend As Integer
    Dim divisor As Integer

    'Sound when the answer is right
    Dim rightanswerSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\notify.wav")


    Private Sub StartTheQuiz()

        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)

        plusLeftLabel.Text = addend1
        plusRightLabel.Text = addend2

        suma.Value = 0


        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)
        minusLeftLabel.Text = minuend.ToString
        minusRightLabel.Text = subtrahend.ToString
        diferencia.Value = 0

        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)
        timesLeftLabel.Text = multiplicand.ToString
        timesRightLabel.Text = multiplier.ToString
        producto.Value = 0


        divisor = randomizer.Next(2, 11)
        Dim temporaryQuotient As Integer = randomizer.Next(2, 11)
        dividend = divisor * temporaryQuotient
        dividedLeftLabel.Text = dividend.ToString
        dividedRightLabel.Text = divisor.ToString
        cociente.Value = 0

        cociente.BackColor = Color.White
        producto.BackColor = Color.White
        diferencia.BackColor = Color.White
        suma.BackColor = Color.White


        timeLabel.BackColor = Color.Transparent

        timeLeft = 30
        timeLabel.Text = "30 seconds"
        Timer1.Start()

    End Sub


    Private Sub startButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        startButton.Enabled = False
        StartTheQuiz()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If CheckTheAnswer() Then
            ' If the user got the answer right, stop the timer
            ' and show a MessageBox.
            Timer1.Stop()
            MessageBox.Show("You got all of the answers right!", "Congratulations!")
            startButton.Enabled = True
        ElseIf timeLeft > 0 Then
            ' Decrease the time left by one second and display
            ' the new time left by updating the Time Left label.
            timeLeft = timeLeft - 1
            timeLabel.Text = timeLeft & " seconds"

            If timeLeft < 6 Then
                timeLabel.BackColor = Color.Red
            End If

        Else
            ' If the user ran out of time, stop the timer, show
            ' a MessageBox, and fill in the answers.
            Timer1.Stop()
            timeLabel.Text = "Time's up!"
            MessageBox.Show("You didn't finish in time.", "Sorry")
            suma.Value = addend1 + addend2
            diferencia.Value = minuend - subtrahend
            producto.Value = multiplicand * multiplier
            cociente.Value = dividend / divisor
            startButton.Enabled = True
        End If


    End Sub

    Public Function CheckTheAnswer() As Boolean

        If ((addend1 + addend2 = suma.Value) AndAlso (minuend - subtrahend = diferencia.Value) AndAlso (multiplicand * multiplier = producto.Value) AndAlso (dividend / divisor = cociente.Value)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub answer_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suma.Enter, diferencia.Enter, producto.Enter, cociente.Enter
        Dim answerBox As NumericUpDown = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer As Integer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)
        End If
    End Sub

    Private Sub suma_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suma.ValueChanged
        If addend1 + addend2 = suma.Value Then
            rightanswerSoundPlayer.Play()
            suma.BackColor = Color.LightGreen
            SendKeys.Send(vbTab)
        End If
    End Sub


    Private Sub diferencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diferencia.ValueChanged
        If minuend - subtrahend = diferencia.Value Then
            rightanswerSoundPlayer.Play()
            diferencia.BackColor = Color.LightGreen
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub producto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles producto.ValueChanged
        If multiplicand * multiplier = producto.Value Then
            rightanswerSoundPlayer.Play()
            producto.BackColor = Color.LightGreen
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cociente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cociente.ValueChanged
        If dividend / divisor = cociente.Value Then
            rightanswerSoundPlayer.Play()
            cociente.BackColor = Color.LightGreen
        End If
    End Sub
End Class
