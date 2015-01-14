Public Class Form1

    Private rn As New Random
    Private primero As Boolean

    Public Sub New()

        InitializeComponent()
        init()
        



    End Sub

    Public Sub init()
        PictureBox1.Image = Nothing
        PictureBox1.Enabled = True
        PictureBox2.Image = Nothing
        PictureBox2.Enabled = True
        PictureBox3.Image = Nothing
        PictureBox3.Enabled = True
        PictureBox4.Image = Nothing
        PictureBox4.Enabled = True
        PictureBox5.Image = Nothing
        PictureBox5.Enabled = True
        PictureBox6.Image = Nothing
        PictureBox6.Enabled = True
        PictureBox7.Image = Nothing
        PictureBox7.Enabled = True
        PictureBox8.Image = Nothing
        PictureBox8.Enabled = True
        PictureBox9.Image = Nothing
        PictureBox9.Enabled = True

        If rn.Next(1, 3) = 1 Then
            primero = True
            MessageBox.Show("Empieza el Jugador 1")
        Else
            primero = False
            MessageBox.Show("Empieza el Jugador 2")
        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox2.Click, PictureBox1.Click
        Dim clickedBox As PictureBox = TryCast(sender, PictureBox)
        clickedBox.Enabled = False
        Dim dir As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\img\"
        If primero Then

            clickedBox.Image = Image.FromFile(dir & "circle.png")
            clickedBox.AccessibleDescription = "primero"
        Else
            clickedBox.Image = Image.FromFile(dir & "times.png")
            clickedBox.AccessibleDescription = "segundo"
        End If

        comprobar()
        primero = Not primero

    End Sub

    Private Sub comprobar()

        If (PictureBox3.Enabled = False And PictureBox3.AccessibleDescription = PictureBox6.AccessibleDescription And PictureBox3.AccessibleDescription = PictureBox9.AccessibleDescription) OrElse (PictureBox2.Enabled = False And PictureBox2.AccessibleDescription = PictureBox5.AccessibleDescription And PictureBox2.AccessibleDescription = PictureBox8.AccessibleDescription) OrElse (PictureBox7.Enabled = False And PictureBox7.AccessibleDescription = PictureBox8.AccessibleDescription And PictureBox7.AccessibleDescription = PictureBox9.AccessibleDescription) OrElse (PictureBox4.Enabled = False And PictureBox4.AccessibleDescription = PictureBox5.AccessibleDescription And PictureBox4.AccessibleDescription = PictureBox6.AccessibleDescription) OrElse (PictureBox1.Enabled = False And PictureBox1.AccessibleDescription = PictureBox2.AccessibleDescription And PictureBox1.AccessibleDescription = PictureBox3.AccessibleDescription) OrElse (PictureBox1.Enabled = False And PictureBox1.AccessibleDescription = PictureBox5.AccessibleDescription And PictureBox1.AccessibleDescription = PictureBox9.AccessibleDescription) OrElse (PictureBox1.Enabled = False And PictureBox1.AccessibleDescription = PictureBox4.AccessibleDescription And PictureBox1.AccessibleDescription = PictureBox7.AccessibleDescription) Then
            If primero Then
                MessageBox.Show("Ha ganado el juagor 1")
            Else
                MessageBox.Show("Ha ganado el juagor 2")
            End If
            Salida()

        ElseIf PictureBox1.Enabled = True And PictureBox1.Enabled = True And PictureBox2.Enabled = True And PictureBox3.Enabled = True And PictureBox4.Enabled = True And PictureBox5.Enabled = True And PictureBox6.Enabled = True And PictureBox7.Enabled = True And PictureBox8.Enabled = True And PictureBox9.Enabled = True Then
            MessageBox.Show("Empate")
            Salida()
        End If

    End Sub

    Private Sub Salida()
        Dim result As Integer = MessageBox.Show("Quiere reiniciar la partida", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Application.Exit()
        ElseIf result = DialogResult.Yes Then
            init()
        End If
    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        init()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Ayuda.Visible = True

    End Sub
End Class
