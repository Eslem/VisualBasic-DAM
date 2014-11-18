Public Class Fmain

    Private Sub AñadirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirToolStripMenuItem.Click

        'Si hago esto, solo me crea una hija
        'Fhija.MdiParent = Me
        'Fhija.Show()


        'Si hago esto, me crea una hija cada vez que pulse
        Dim hija As New Fhija
        hija.MdiParent = Me
        hija.Show()
        actualizar_barra_estado()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        'Asi borro l aultima creada
        'If MdiChildren.Length > 0 Then MdiChildren(MdiChildren.Length - 1).Dispose()

        'Podriamos borrar solo el activo
        If MdiChildren.Length > 0 Then Me.ActiveMdiChild.Close()

        actualizar_barra_estado()
    End Sub

  
   
End Class
