Public Class Fopciones

    Private Sub Fopciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Creo  la tabla de colores
        If FMaster.colores = 0 Then FMaster.colores = 4
        For i = 1 To FMaster.colores
            Dim mibolacolores As New PictureBox
            mibolacolores.Parent = Me
            mibolacolores.Name = "bolacoloresconf" & i
            mibolacolores.Width = 50
            mibolacolores.Height = 50
            mibolacolores.BackColor = Color.White
            mibolacolores.Left = (mibolacolores.Width + 20) * (i - 1) + 20
            mibolacolores.Top = 30
            mibolacolores.BorderStyle = BorderStyle.FixedSingle
            AddHandler mibolacolores.MouseClick, AddressOf mibolacoloresclic
        Next
    End Sub

    Private Sub mibolacoloresclic(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            sender.backcolor = ColorDialog.Color

        End If
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        For i = 1 To FMaster.colores
            FMaster.acolores(i - 1) = Controls("bolacoloresconf" & i).BackColor

            FMaster.pcolores.Controls("bolacolores" & i).BackColor = Controls("bolacoloresconf" & i).BackColor

        Next
        FMaster.NuevoJuegoToolStripMenuItem_Click(sender, e)
    End Sub
End Class