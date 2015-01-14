Imports System.IO

Public Class Fmain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ruta, rutaexe As String

        ruta = Application.StartupPath
        MessageBox.Show("La ruta de inicio es " & ruta)
        rutaexe = Application.ExecutablePath
        MessageBox.Show("La ruta del ejecutable es " & rutaexe)

        'Para subir niveles uso GetDirectoryName, y los puedo concantenar para subir mas de 1 nivel
        MessageBox.Show("Tras subir 2 nivles, la ruta es " & Path.GetDirectoryName(Path.GetDirectoryName(ruta)))



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        'Crear componentes en tiempo de ejecucion
        'En este caso 9 imagenes
        For i = 1 To 9
            Dim miimagen As New PictureBox

            With miimagen
                'Como si estuvieramos en diseño, le ponemos el nombre y las propiedades que deseemos
                .Name = "imagen" & i
                .Width = 50
                .Height = 50
                'Modificamos el left para que no nos superponga los controles
                .Left = .Width * (i - 1)

                'Cargamos una imagen, desde la carpeta qu etenemos creada
                .Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                .BorderStyle = BorderStyle.FixedSingle

                'Es fundamental indicarle quien es el padre del control, sino, no sabra donde ponerlo
                .Parent = Me


            End With

        Next

    End Sub
End Class
