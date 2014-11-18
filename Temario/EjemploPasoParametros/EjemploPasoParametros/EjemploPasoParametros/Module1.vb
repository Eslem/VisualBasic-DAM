Module Module1
    Class MiClase
        Friend valor As Integer
    End Class
    Sub main()
        'Ejemplo de uso de parámetros opcionales y ParamArray()
        System.Console.WriteLine(Sumar(1, 2, 3, 4)) 'Devuelve(10)
        System.Console.WriteLine(Sumar(2, 3, 4)) 'Devuelve(9)
        Dim i As Integer = 1
        System.Console.WriteLine(contador(i)) 'Devuelve(2)
        System.Console.WriteLine(contador(i, 3)) 'D evuelve(4)
        'Ejemplo de paso por referencia en tipos de referen        cia()
        Dim cls As New MiClase()
        cls.valor = 2
        prueba(cls)
        System.Console.WriteLine(cls.valor)
        'Devuelve 3
        '
        ProbandoRef()
        System.Console.ReadLine()
    End Sub
    'Ejemplo de uso de ParamArray
    Function Sumar(ByVal ParamArray elem()) As Integer
        Dim suma As Integer = 0
        Dim i As Integer
        For i = elem.GetLowerBound(0) To elem.GetUpperBound(0)
            suma += elem(i)
        Next
        Return suma
    End Function
    'Ejemplo de uso de argumentos opcionales
    Function contador(ByVal x As Integer, Optional ByVal conta As Integer = Integer.MinValue) As Integer
        If conta = Integer.MinValue Then
            Return x + 1
        Else
            Return x + conta
        End If
    End Function
    'Ejemplo de paso por valor en tipos de referencia
    Sub prueba(ByVal cls As MiClase)
        cls.valor = contador(cls.valor)
    End Sub


    Public Sub PruebaRef(ByRef uno As Integer, ByVal dos As Integer)

        ' Esta asignación afectará al parámetro      
        uno += dos      ' Esta no afectará al valor usado como segundo argumento 
        dos = 999
    End Sub
    Public Sub ProbandoRef()


        Dim uno As Integer = 5
        Dim dos As Integer = 2
        Console.WriteLine("uno= {0}, dos = {1}", uno, dos)
        PruebaRef(uno, dos)
        Console.WriteLine("uno= {0}, dos = {1}", uno, dos)
    End Sub



End Module
