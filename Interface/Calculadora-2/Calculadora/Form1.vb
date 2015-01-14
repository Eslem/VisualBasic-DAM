Public Class Form1

    Dim valorGuardado As Integer = 0
    Dim operador As String
    Dim mostrando As Boolean

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'borro el resultado mostrado'
        If mostrando = True Then
            TextBox1.Text = ""
            mostrando = False
        End If

        TextBox1.Text = TextBox1.Text & 1

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & 0


    End Sub

    Public Sub calcularAnterior()
        If (valorGuardado = 0) Then
            valorGuardado = Val(TextBox1.Text)
            TextBox1.Text = ""
        Else
            If operador = "suma" Then
                valorGuardado = valorGuardado + Val(TextBox1.Text)
            End If
            If operador = "resta" Then
                valorGuardado = valorGuardado - Val(TextBox1.Text)
            End If
            If operador = "mult" Then
                valorGuardado = valorGuardado * Val(TextBox1.Text)
            End If
            If operador = "division" Then
                valorGuardado = valorGuardado / Val(TextBox1.Text)
            End If

            TextBox1.Text = valorGuardado
            mostrando = True

        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        calcularAnterior()
        operador = "suma"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        calcularAnterior()
        operador = ""
        TextBox1.Text = valorGuardado
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        calcularAnterior()
        TextBox1.Text = ""
        operador = "resta"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        calcularAnterior()
        TextBox1.Text = ""
        operador = "mult"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        calcularAnterior()
        TextBox1.Text = ""
        operador = "division"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox1.Text = ""
        valorGuardado = 0
        operador = ""
    End Sub
End Class
