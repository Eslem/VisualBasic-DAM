Module Module1
    Public Sub actualizar_barra_estado()
        Fmain.etiqueta.Text = "Ventanas hijas: " & Fmain.MdiChildren.Length
    End Sub
End Module
