Public Class Fnivel

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        FMaster.Nivel = 0
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        'If RadioButton1.Checked Then
        '    FMaster.Nivel = 1
        'ElseIf RadioButton2.Checked Then
        '    FMaster.Nivel = 2
        'Else : FMaster.Nivel = 3
        'End If
        Dim a As RadioButton
        For i = 1 To 3
            a = GroupBox1.Controls("RadioButton" & i)
            If a.Checked Then FMaster.Nivel = i
        Next

    End Sub
End Class