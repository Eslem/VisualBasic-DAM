Public Class WebForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Console.WriteLine(vbDirectory.ToString())
        WebBrowser1.Navigate("file:////" & IO.Path.GetFullPath("help\index.html"))
    End Sub
End Class