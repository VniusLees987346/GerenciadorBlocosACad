Public Class PathControle
    Dim Path As String
    Public Function RetPathApp() As String
        Path = System.Reflection.Assembly.GetExecutingAssembly().Location


        Dim tamanho As Integer = Len(Path) - 26
        Path = Mid(Path, 1, tamanho)

        Dim camTratado As String = Replace(Path, "\", "/")

        Return camTratado
    End Function
End Class
