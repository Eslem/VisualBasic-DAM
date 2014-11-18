Public Class Form1

    Dim random As New Random
    Dim palabra As String
    Dim vidas = 5
    Public maxIntentos = 10
    Dim fallidos = 0
    Dim aciertos As Integer
    Dim perdido = True
    Dim vidaUsada = False

    Dim usadas() As Char

    Public Sub New()
        InitializeComponent()
        disableLetters(False)
    End Sub

    Private Sub startGame()

        If vidas = 0 Then
            MessageBox.Show("No tienes mas vidas ", "Ahorcado", _
      MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        removeLabels()
        disableLetters(True)
        palabra = ListBox1.Items(random.Next(9)).ToString


        addLabels()
        TextBox1.Text = "0"
        PictureBox1.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "images\AHOR0.BMP"))

        aciertos = 0
        fallidos = 0
        vidaUsada = False

        If (perdido) Then
            vidamenos()
        End If
        perdido = True

    End Sub

    Private Sub vidamenos()
        vidas = vidas - 1
        For Each objControl As Control In Me.Controls.Find("Vida" & vidas + 1, True)
            objControl.Dispose()
        Next
    End Sub

    Private Sub addLabels()
        Dim X As Integer = 300
        Dim Y As Integer = 50

        For I = 1 To palabra.ToCharArray.Length
            Dim lblTemp As New Label
            lblTemp.Text = "_"
            lblTemp.Name = "letter" & I
            lblTemp.Location = New Point(X, Y)
            lblTemp.Tag = "labelWord"
            lblTemp.Size = New Size(New Point(20, 20))
            X = X + 20
            Me.Controls.Add(lblTemp)
        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Public Sub disableLetters(enable As Boolean)
        For Each objControl As Control In Me.Controls
            If TypeOf objControl Is Button Then
                If objControl.Tag IsNot Nothing Then
                    objControl.Enabled = enable
                End If

            End If
        Next
    End Sub

    Private Sub removeLabels()
        For Each objControl As Control In Me.Controls
            If TypeOf objControl Is Label Then
                If objControl.Tag IsNot Nothing Then
                    objControl.Text = "_"

                    'Me.Controls.Remove(objControl)
                End If
            End If
        Next
    End Sub



    Private Sub letterClick(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button30.Click, Button3.Click, Button28.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click
        Dim clickedButton As Button = TryCast(sender, Button)
        existLetter(clickedButton.Text.ToLower.ToCharArray.GetValue(0))
        clickedButton.Enabled = False
    End Sub

    Private Sub existLetter(character As Char)
        Dim fail = True
        For index As Integer = 0 To palabra.ToCharArray.Length - 1
            If palabra(index) = character Then
                fail = False
                showLetter(character, index)
            End If
        Next

        If fail Then
            failLetter()
        ElseIf aciertos = palabra.ToCharArray.Length Then
            MessageBox.Show("Has adivinado la palabra", "Ahorcado", _
           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            perdido = False
            disableLetters(False)
        End If

    End Sub


    Private Sub failLetter()
        fallidos = fallidos + 1
        TextBox1.Text = fallidos.ToString
        PictureBox1.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "images\AHOR" + fallidos.ToString + ".BMP"))

        If fallidos = maxIntentos Then
            fallado()
        End If


    End Sub

    Private Sub fallado()
        PictureBox1.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "images\AHOR10.BMP"))
        MessageBox.Show("Perdiste" & Environment.NewLine & " La palabra oculta era " & palabra, "Ahorcado", _
      MessageBoxButtons.OK, MessageBoxIcon.Information)

        disableLetters(False)

        perdido = True

        If vidas = 0 Then
            MessageBox.Show("Has Perdido todas las vidas", "Ahorcado", _
     MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If

    End Sub

    Private Sub NuevoJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoJuegoToolStripMenuItem.Click
        startGame()
    End Sub

    Private Sub ComoJugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComoJugarToolStripMenuItem.Click
        ComoJugar.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.Show()
    End Sub

    Private Sub NivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NivelToolStripMenuItem.Click
        Nivel.Show()
    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        Dim word = InputBox("Introduce una palabra", "Diccionario Ahorcado", "", 100, 100)
        If word.Length > 0 Then
            ListBox1.Items.Add(word)
            MessageBox.Show(word & " introducida correctamente", "Ahorcado", _
           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Pista_Click(sender As Object, e As EventArgs) Handles Pista.Click
        If vidas = 0 Then
            MessageBox.Show("Ya no tienes vidas", "Ahorcado", _
          MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Not vidaUsada Then
                vidaUsada = True
                vidamenos()
                descubrirLetra()
            Else
                MessageBox.Show("Ya has destapado una letra en esta partida", "Ahorcado", _
         MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub showLetter(character As Char, index As Integer)
        For Each objControl As Control In Me.Controls.Find("letter" & index + 1, True)
            objControl.Text = character
        Next
        aciertos = aciertos + 1
    End Sub

    Private Sub descubrirLetra()
        For index As Integer = 0 To palabra.ToCharArray.Length - 1
            If Not isUsada(palabra(index)) Then
                showLetter(palabra(index), index)
                Return
            End If

        Next
    End Sub


    Private Function isUsada(letra As Char) As Boolean
        For Each objControl As Control In Me.Controls
            If TypeOf objControl Is Label Then
                If objControl.Tag IsNot Nothing Then
                    If letra = objControl.Text(0) Then
                        Return True

                    End If
                End If
            End If
        Next
        Return False
    End Function

End Class
