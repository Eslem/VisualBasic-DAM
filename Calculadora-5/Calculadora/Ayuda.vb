Public Class Ayuda
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        WebBrowser1.Navigate("file:///" & IO.Path.GetFullPath("help\index.html"))
        ' Add any initialization after the InitializeComponent() call.
    End Sub
End Class