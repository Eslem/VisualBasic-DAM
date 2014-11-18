Public Class FMaster
    Public acolores() As Color = {Color.Aquamarine, Color.AliceBlue, Color.Yellow, Color.Olive, Color.Red, Color.Green}
    Public Nivel As Integer
    Public colores As Integer
    Public max_intentos, intentos As Integer
    Const max_elementos = 4
    Public clic As Integer
    Public fila As Integer
    Public combinacion(max_elementos) As Color
    Public encontradas(max_elementos) As Boolean
    Public encontradasnegras(max_elementos) As Boolean

    Public Sub NuevoJuegoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoJuegoToolStripMenuItem.Click
        If Nivel = 0 Then Fnivel.ShowDialog()
        OpcionesToolStripMenuItem.Enabled = True

        borrar_componentes()

        fila = 1
        intentos = 0
        Select Case Nivel
            Case 0 : Nivel = 1
            Case 1 : colores = 4
                max_intentos = 10
            Case 2 : colores = 5
                max_intentos = 8

            Case 3 : colores = 6
                max_intentos = 6

        End Select
        clic = -1
        'creo la combinacion a encontrar
        Randomize()
        Dim rndcolor As New Random
        For i = 1 To max_elementos
            combinacion(i - 1) = acolores(rndcolor.Next(colores))
        Next

        ' creo los componenetes de la pprimera fila

        For i = 1 To max_elementos
            Dim mibola As New PictureBox
            mibola.Parent = Me
            mibola.Name = "bola" & fila & i
            mibola.Width = 20
            mibola.Height = 20
            mibola.BackColor = Color.White
            mibola.Left = mibola.Width * i * 2
            mibola.Top = 50
            mibola.BorderStyle = BorderStyle.FixedSingle
            AddHandler mibola.MouseClick, AddressOf mibolaclic

        Next

        'Creo el boton de comprobar

        Dim miboton As New Button
        miboton.Parent = Me
        miboton.Name = "btncomprobar"
        miboton.Left = 200
        miboton.Top = 50
        miboton.Width = 50
        miboton.Text = "Comprobar"
        AddHandler miboton.Click, AddressOf mibotonclic

        'Creo  la tabla de colores

        For i = 1 To colores
            Dim mibolacolores As New PictureBox
            mibolacolores.Parent = pcolores
            mibolacolores.Name = "bolacolores" & i
            mibolacolores.Width = 20
            mibolacolores.Height = 20
            mibolacolores.BackColor = acolores(i - 1)
            mibolacolores.Left = (mibolacolores.Width + 20) * (i - 1) + 20
            mibolacolores.Top = 30
            mibolacolores.BorderStyle = BorderStyle.FixedSingle

        Next

        'Muestro la solucion
        For i = 1 To max_elementos
            Dim mibolacolores As New PictureBox
            mibolacolores.Parent = psecreta
            mibolacolores.Name = "bolasolucion" & i
            mibolacolores.Width = 20
            mibolacolores.Height = 20
            mibolacolores.BackColor = combinacion(i - 1)
            mibolacolores.Left = (mibolacolores.Width + 20) * (i - 1) + 20
            mibolacolores.Top = 30
            mibolacolores.BorderStyle = BorderStyle.FixedSingle

        Next

        'psecreta.Visible = False

    End Sub

    Private Sub borrar_componentes()
        'borro el boton
        If Controls("btncomprobar") IsNot Nothing Then Controls("btncomprobar").Dispose()

        'borro los colores
        For i = 1 To colores
            If pcolores.Controls("bolacolores") IsNot Nothing Then pcolores.Controls("bolacolores" & i).Dispose()
        Next

        'borro la solucion
        If psecreta.Controls("bolasolucion1") IsNot Nothing Then
            For i = 1 To max_elementos
                psecreta.Controls("bolasolucion" & i).Dispose()
            Next
        End If
        'borro las respuestas
        For j = 1 To fila
            For i = 1 To max_elementos

                Controls("bola" & j & i).Dispose()


            Next i
        Next j

        ' borro las negras y blancas
        'no se cuantas hay exactamente...busco todos los llamados bolaresul

        For i = Controls.Count - 1 To 0 Step -1
            If Strings.Left(Controls(i).Name, 9) = "bolaresul" Then
                Controls(i).Dispose()
            End If
        Next
    End Sub


    Private Sub mibolaclic(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            clic = clic + 1
        End If


        If e.Button = Windows.Forms.MouseButtons.Right Then
            clic = clic - 1
            If clic < 0 Then clic = colores
        End If

        sender.BackColor = acolores(clic Mod colores)

    End Sub



    Private Sub mibotonclic(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'compruebo la linea

        For i = 1 To max_elementos
            encontradasnegras(i) = False
            encontradas(i) = False
        Next

        'Negras en el sitio
        Dim negras, blancas As Integer
        For i = 1 To max_elementos
            If Controls("bola" & fila & i).BackColor = combinacion(i - 1) Then
                negras = negras + 1
                encontradasnegras(i) = True
            End If
        Next

        For i = 1 To negras
            Dim mibola As New PictureBox
            mibola.Parent = Me
            mibola.Name = "bolaresul" & fila & i
            mibola.Width = 20
            mibola.Height = 20
            mibola.BackColor = Color.Black
            mibola.Top = 50 * fila
            mibola.Left = mibola.Width * i * 2 + 250
        Next i

        If negras = max_elementos Then
            MsgBox("has ganado")
            psecreta.Visible = True
            Exit Sub
        End If

        'Blancas fuera del sitio
        ' si ya tengo una negra encontrada no busco mas
        'si no hay negra busco si esta en algun otro lugar y marco ese lugar para que otra del mismo color
        ' no pueda cogerla tambien
        For i = 1 To max_elementos
            If Not encontradasnegras(i) Then
                For j = 1 To max_elementos
                    If (Controls("bola" & fila & i).BackColor = combinacion(j - 1)) And _
                        Not encontradas(j) Then
                        blancas = blancas + 1
                        encontradas(j) = True
                        Exit For
                    End If
                Next j
            End If
        Next i

        For i = negras + 1 To negras + blancas
            Dim mibola As New PictureBox
            mibola.Parent = Me
            mibola.Name = "bolaresul" & fila & i
            mibola.Width = 20
            mibola.Height = 20
            mibola.BackColor = Color.White
            mibola.Top = 50 * fila
            mibola.Left = mibola.Width * i * 2 + 250
        Next i

        'Compruebo los intentos

        intentos = intentos + 1
        If intentos = max_intentos Then
            MsgBox("Ha perdido")
            psecreta.Visible = True
            Exit Sub
        End If

        ' creo los componenetes de la siguiente fila
        fila = fila + 1
        For i = 1 To max_elementos
            Dim mibola As New PictureBox
            mibola.Parent = Me
            mibola.Name = "bola" & fila & i
            mibola.Width = 20
            mibola.Height = 20
            mibola.BackColor = Color.White
            mibola.Left = mibola.Width * i * 2
            mibola.Top = 50 * fila
            mibola.BorderStyle = BorderStyle.FixedSingle
            AddHandler mibola.MouseClick, AddressOf mibolaclic

        Next

        'Bajo el boton de comprobar
        Controls("btncomprobar").Top = 50 * fila

    End Sub


    Private Sub NivelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NivelToolStripMenuItem.Click
        Fnivel.ShowDialog()
        NuevoJuegoToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcionesToolStripMenuItem.Click
        Fopciones.ShowDialog()

    End Sub
End Class
