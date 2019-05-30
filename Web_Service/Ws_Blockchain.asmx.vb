Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.IO
Imports System.ComponentModel
Imports System.Linq
Imports System
Imports System.Collections.Generic
Imports Microsoft.Ajax.Utilities

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class Ws_Blockchain
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function Crear_Block(Id_bloque As String, traza As Integer) As String
        ' nonce As Integer, nonce As String, hash As String

        'Crear_Archivo("C:\PruebUni\", "Rg_block.txt")
        'My.Computer.FileSystem.WriteAllText("C:\PruebUni\" & "Rg_block.txt", Id_bloque & " " & traza, False)


        Dim resA As String
        Dim ArchivoXml As New List(Of Class_Blockchain)
        Dim Nsub_N As Integer = 1
        'Dim Archivo As New List(Of Class_Controlador)
        Dim Block_Chain As New Class_Blockchain
        Block_Chain.Transacciones = New List(Of Class_Nodo)
        Block_Chain.Transacciones.Add(New Class_Nodo With {.Numero_Nodo = 1, .Sub_nodos = New List(Of Class_sub_nodo)})
        Block_Chain.Transacciones.ForEach(Sub(item)
                                              item.Numero_Nodo = 1
                                              item.Dir1 = "123"
                                              item.Dir2 = "456"
                                              item.Nose = "00"
                                              item.Prev = "234"
                                              item.Hash = "0000343"
                                              item.Sub_nodos = New List(Of Class_sub_nodo)
                                              item.Sub_nodos.Add(New Class_sub_nodo With {.Numero = 1, .valor_Transacion = 100000})
                                              item.Sub_nodos.Add(New Class_sub_nodo With {.Numero = 2, .valor_Transacion = 300000})
                                              item.Sub_nodos.Add(New Class_sub_nodo With {.Numero = 3, .valor_Transacion = 150000})
                                          End Sub)
        Block_Chain.Transacciones.ForEach(Sub(item)
                                              If item.Sub_nodos.Count = 3 Then
                                                  item.Estado = False
                                              Else
                                                  item.Sub_nodos.Add(New Class_sub_nodo With {.Numero = 4, .valor_Transacion = 900000})
                                              End If

                                          End Sub)

        Dim Block As New DataTable
        'Block.Columns.Add("Dir1")
        'Block.Columns.Add("nonce")
        'Block.Columns.Add("Traz")
        'Block.Columns.Add("prev")
        'Block.Columns.Add("hash")
        'Dim Row As DataRow = Block.NewRow()
        'Row("Dir1") = "123"
        'Row("nonce") = "25"
        'Row("Traz") = "2500"
        'Row("hash") = "321"
        'Block.Rows.Add(Row)
        'Row = Block.NewRow()
        'Row("Dir1") = "125"
        'Row("nonce") = "56"
        'Row("Traz") = "500"
        'Row("hash") = "521"
        'Block.Rows.Add(Row)
        'ArchivoXml = (From Reguitro In Block.AsEnumerable Select New Class_Blockchain With {
        '                 .Dir1 = Reguitro("Dir1"),
        '                 .Nose = Reguitro("nonce"),
        '                 .Tranz = Reguitro("Traz")
        '}).ToList

        'Dim x As New System.Xml.Serialization.XmlSerializer(ArchivoXml.GetType)
        'Dim msA As MemoryStream = New MemoryStream()
        'x.Serialize(msA, ArchivoXml)
        'Dim JJA As Byte() = msA.ToArray()
        'msA.Close()
        'resA = Encoding.UTF8.GetString(JJA, 0, JJA.Length)
        'Dim rutaGuardado As String = "C:\PruebUni\Block.xml"
        ''My.Computer.FileSystem.DeleteFile(rutaGuardado, resA, True)
        'If (System.IO.File.Exists(rutaGuardado)) Then
        '    System.IO.File.Delete(rutaGuardado)
        'End If
        'My.Computer.FileSystem.WriteAllText(rutaGuardado, resA, True)

        'Dim Vl As String = Class_HashDirectory.GenerateSHA256String("abc")

        'Return Vl
    End Function
    <WebMethod()>
    Public Function Registro_Block(Id_has As String) As String


        Return "Consulta"
    End Function
    <WebMethod()>
    Public Function Consulta_Traza(Id_has As Integer) As String


        Return "Consulta"
    End Function

    <WebMethod()>
    Public Function Consulta_Block(Id_has As String) As String


        Return "Consulta"
    End Function


    Public Shared Function Crear_Archivo(ByVal Ruta As String, ByVal Nom_Archivo As String) As Boolean
        Try
            Dim create As StreamWriter
            If Not IO.File.Exists(Ruta & "\" & Nom_Archivo) Then
                create = IO.File.CreateText(Ruta & "\" & Nom_Archivo)
                create.Flush() : create.Close()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class