Public Class Form1
    ' Use this Random object to choose random icons for the squares
    Dim random As New Random

    ' Each of these letters is an interesting icon
    ' in the Webdings font,
    ' and each icon appears twice in this list
    Dim temporaryArray() As String = {"!", "!", "e", "e", ",", ",", "s", "s", _
                                      "b", "b", "v", "v", "w", "w", "z", "z", "j", "j", "k", "k"}
    Dim icons As List(Of String) = temporaryArray.ToList()

    ' firstClicked points to the first Label control 
    ' that the player clicks, but it will be Nothing 
    ' if the player hasn't clicked a label yet
    Dim firstClicked As Label = Nothing

    ' secondClicked points to the second Label control 
    ' that the player clicks
    Dim secondClicked As Label = Nothing

    Dim notifySoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\notify.wav")
    Dim cleanSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\recycle.wav")
    Dim finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")


    Private Sub AssignIconsToSquares()

        ' The TableLayoutPanel has 16 labels,
        ' and the icon list has 16 icons,
        ' so an icon is pulled at random from the list
        ' and added to each label
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel As Label = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber As Integer = random.Next(icons.Count)
                iconLabel.Text = icons.ElementAt(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If
        Next

    End Sub



    Public Sub New()
        InitializeComponent()
        ' This call is required by the designer.
        AssignIconsToSquares()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click, Label15.Click, Label16.Click, Label17.Click, Label18.Click, Label19.Click, Label20.Click

        ' The timer is only on after two non-matching 
        ' icons have been shown to the player, 
        ' so ignore any clicks if the timer is running
        notifySoundPlayer.Play()

        If (Timer1.Enabled = True) Then
            Return
        End If

        Dim clickedLabel As Label = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then
            ' If the clicked label is black, the player clicked
            ' an icon that's already been revealed --
            ' ignore the click
            If (clickedLabel.ForeColor = Color.Black) Then
                Return
            End If

            ' If firstClicked is Nothing, this is the first icon 
            ' in the pair that the player clicked, 
            ' so set firstClicked to the label that the player 
            ' clicked, change its color to black, and return
            If (firstClicked Is Nothing) Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                Return
            End If
            ' If the player gets this far, the timer isn't 
            ' running and firstClicked isn't Nothing, 
            ' so this must be the second icon the player clicked
            ' Set its color to black
            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black

            CheckForWinner()

            ' If the player clicked two matching icons, keep them 
            ' black and reset firstClicked and secondClicked 
            ' so the player can click another icon
            If (firstClicked.Text = secondClicked.Text) Then
                firstClicked = Nothing
                secondClicked = Nothing
                Return
            End If

            ' If the player gets this far, the player 
            ' clicked two different icons, so start the 
            ' timer (which will wait three quarters of 
            ' a second, and then hide the icons)
            Timer1.Start()
        End If
    End Sub


    Private Sub Timer1_Tick() Handles Timer1.Tick

        ' Stop the timer
        Timer1.Stop()

        ' Hide both icons
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        cleanSoundPlayer.Play()

        ' Reset firstClicked and secondClicked 
        ' so the next time a label is
        ' clicked, the program knows it's the first click
        firstClicked = Nothing
        secondClicked = Nothing

    End Sub

    Private Sub CheckForWinner()

        ' Go through all of the labels in the TableLayoutPanel, 
        ' checking each one to see if its icon is matched
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel As Label = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                If (iconLabel.ForeColor = iconLabel.BackColor) Then
                    Return
                End If
            End If
        Next

        ' If the loop didn’t return, it didn't find 
        ' any unmatched icons
        ' That means the user won. Show a message and close the form
        MessageBox.Show("You matched all the icons!", "Congratulations")
        finishSoundPlayer.Play()
        Close()

    End Sub

End Class
