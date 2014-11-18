Public Class ImagePicker
    Dim startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Result = OpenFileDialog1.ShowDialog()

        If Result = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            startSoundPlayer.Play()
        End If

    End Sub
End Class