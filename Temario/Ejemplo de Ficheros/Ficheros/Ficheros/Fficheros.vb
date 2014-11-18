Imports System.IO

Public Class Fficheros

    Private Sub Bcargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcargar.Click
        cargar_lineas()
        TLineas.Text = obtener_numero_lineas()
    End Sub

    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        escribir_texto(Etexto.Text)

    End Sub

    Private Sub Fficheros_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        srEscritor.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        srEscritor.Close()
    End Sub

 
    Private Sub Fdirectorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fdirectorios.Click
        directorios()
    End Sub
End Class
