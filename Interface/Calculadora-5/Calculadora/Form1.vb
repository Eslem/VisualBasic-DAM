Public Class Form1

    Dim valorGuardado As Decimal = 0
    Dim operador As String
    Dim isCientifica As Boolean = False

    Dim mostrando As Boolean

    Private Sub clickedNumber(value As String)
        'borro el resultado mostrado'
        If mostrando = True Then
            TextBox1.Text = ""
            mostrando = False
        End If
        TextBox1.Text = TextBox1.Text & value
        TextBox1.Focus()
        Dim position As Integer = TextBox1.Text.Length
        TextBox1.Select(position, position)
    End Sub


    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one.Click
        clickedNumber(1)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles two.Click
        clickedNumber(2)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles three.Click
        clickedNumber(3)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles four.Click
        clickedNumber(4)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles five.Click
        clickedNumber(5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles six.Click
        clickedNumber(6)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seven.Click
        clickedNumber(7)
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        clickedNumber(8)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zero.Click
        clickedNumber(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nine.Click
        clickedNumber(9)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If mostrando = True Then
            TextBox1.Text = ""
            mostrando = False
        End If
        TextBox1.Text = TextBox1.Text & 0
        TextBox1.Focus()

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
            If operador = "division" Then
                valorGuardado = valorGuardado / Val(TextBox1.Text)
            End If
            If operador = "xey" Then
                valorGuardado = valorGuardado ^ Val(TextBox1.Text)
            End If

            TextBox1.Text = valorGuardado
            mostrando = True

        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plus.Click
        calcularAnterior()
        operador = "suma"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equalsButton.Click
        calcularAnterior()
        operador = ""
        TextBox1.Text = valorGuardado
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus.Click
        calcularAnterior()
        operador = "resta"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles times.Click
        calcularAnterior()
        operador = "mult"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dividedBy.Click
        calcularAnterior()
        operador = "division"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.Click
        TextBox1.Text = ""
        valorGuardado = 0
        operador = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles ce.Click
        TextBox1.Text = ""
    End Sub

    Private Sub dot_Click(sender As Object, e As EventArgs) Handles dot.Click
        clickedNumber(".")
    End Sub

    
    Private Sub percent_Click(sender As Object, e As EventArgs) Handles percent.Click
        Dim operador = valorGuardado * TextBox1.Text / 100
        TextBox1.Text = operador
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim operador = 1 / TextBox1.Text
        TextBox1.Text = operador
    End Sub

    Private Sub sign_Click(sender As Object, e As EventArgs) Handles sign.Click
        If mostrando = True Then
            TextBox1.Text = ""
            mostrando = False
        End If
        Dim value As String
        value = TextBox1.Text
        If value.StartsWith("-") Then
            value = value.Remove(0, 1)
        Else
            value = "-" & value
        End If

        TextBox1.Text = value

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If isCientifica Then
            Button6.ForeColor = Color.FromArgb(238, 238, 238)
            Button7.ForeColor = Color.FromArgb(129, 129, 129)
            isCientifica = False
        End If
        cientificButtons()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If Not isCientifica Then
            Button7.ForeColor = Color.FromArgb(238, 238, 238)
            Button6.ForeColor = Color.FromArgb(129, 129, 129)
            isCientifica = True
        End If
        cientificButtons()
    End Sub

    Private Sub cientificButtons()
        If (isCientifica) Then
            Button1.Visible = True
            Button5.Visible = True
            Button3.Visible = True
            Button4.Visible = True
        Else
            Button1.Visible = False
            Button5.Visible = False
            Button3.Visible = False
            Button4.Visible = False
        End If

    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim operador = Val(TextBox1.Text)
        TextBox1.Text = operador ^ 2
        mostrando = True
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim operador = Val(TextBox1.Text)
        TextBox1.Text = operador ^ 3
        mostrando = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        calcularAnterior()
        operador = "xey"
    End Sub

    Function factorial(ByVal n As Integer) As Integer
        If n <= 1 Then
            Return 1
        Else
            Return factorial(n - 1) * n
        End If
    End Function

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim operador = Val(TextBox1.Text)
        TextBox1.Text = factorial(operador)
        mostrando = True
    End Sub

    Private Sub VerAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAyudaToolStripMenuItem.Click
        Acerca.Show()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Ayuda.Show()
    End Sub
End Class
