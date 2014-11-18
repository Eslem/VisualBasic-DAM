
Imports System.IO
Module Modulo_lectura_ficheros
    Public srEscritor As StreamWriter = New StreamWriter("ficheroAux.txt")

    Public Function obtener_numero_lineas()
        Dim srLector As StreamReader = New StreamReader("fichero.txt")
        Dim ContadorLin As Integer = 0
        While Not (srLector.EndOfStream)
            ContadorLin += 1
            srLector.ReadLine()
        End While
        Return ContadorLin
    End Function
    Public Sub escribir_texto(ByVal texto As String)

        srEscritor.WriteLine(texto)
        'Hay que recordar cerrar el fichreo al finalizar la aplicacion
    End Sub
    Public Sub cargar_lineas()
        Dim srLector As StreamReader = New StreamReader("fichero.txt")
        Fficheros.lista.Items.Clear()
        While Not (srLector.EndOfStream)

            Fficheros.lista.Items.Add(srLector.ReadLine())
        End While

    End Sub


    Public Sub directorios()

        ' Get the directories currently on the C drive.
        Dim cDirs As DirectoryInfo() = New DirectoryInfo("c:\").GetDirectories()

        ' Write each directory name to a file.
        Using sw As StreamWriter = New StreamWriter("CDriveDirs.txt")
            For Each Dir As DirectoryInfo In cDirs
                sw.WriteLine(Dir.Name)
            Next
        End Using

        'Read and show each line from the file.
        Dim line As String = ""
        Using sr As StreamReader = New StreamReader("CDriveDirs.txt")
            Fficheros.lista.Items.Clear()
            line = sr.ReadLine()
            While Not (line Is Nothing)

                Fficheros.lista.Items.Add(line)
                line = sr.ReadLine()
            End While

        End Using


    End Sub
End Module
