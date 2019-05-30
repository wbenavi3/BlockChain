Public Class Class_Controlador
    Property Dir1 As String
    Property Dir2 As String
    Property Nose As Integer
    Property Prev As Integer
    Property Tranz As Integer
    Property Hash As String
    Public Function consulta() As Class_Controlador
        Dim Controla As Class_Controlador
        Dim request As HttpRequest
        Dim Url As String = ""


        Dim rutaGuardado As String = "C:\PruebUni\Prueba.txt"
        Dim Ver As String = System.IO.File.ReadAllText(rutaGuardado)


    End Function

End Class
