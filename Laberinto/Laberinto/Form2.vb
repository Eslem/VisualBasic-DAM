Public Class Form2

    ' This SoundPlayer plays a sound whenever the player hits a wall.
    Dim startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")

    ' This SoundPlayer plays a sound when the player finishes the game.
    Dim finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MoveToStart()
    End Sub

    Private Sub FinishLabel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishLabel.MouseEnter
        finishSoundPlayer.Play()
        MessageBox.Show("Congratulations")
        ''Otras caracteristicas
        MoveToStart()
        ''Close()
    End Sub

    ''' <summary>
    ''' Move the pointer to a point 10 pixels down and to the right
    ''' of the starting point in the upper-left corner of the maze.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MoveToStart()
        startSoundPlayer.Play()
        Dim startingPoint = Panel1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub wall_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        ' When the mouse pointer hits a wall or enters the panel,
        ' call the MoveToStart() method.
        MoveToStart()

    End Sub
End Class