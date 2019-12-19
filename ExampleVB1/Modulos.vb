Public Module Modulos

    'Calculo Adição
    Public Function Adicao(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        Return n1 + n2
    End Function

    'Calculo Subtração
    Public Function Subtracao(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        Return n1 - n2
    End Function

    'Calculo Multiplicação
    Public Function Multiplicacao(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        Return n1 * n2
    End Function

    'Calculo Divisão
    Public Function Divisao(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        Return n1 / n2
    End Function

    'Calculo Exponencial
    Public Function Exponencial(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        Return n1 ^ n2
    End Function

    'Calculo Fatorial
    Public Function Fatorial(ByVal n1 As Integer) As Integer
        Dim result As Integer = 1
        Dim counter
        For counter = n1 To 1 Step -1
            result *= counter
        Next
        Return result
    End Function

End Module
