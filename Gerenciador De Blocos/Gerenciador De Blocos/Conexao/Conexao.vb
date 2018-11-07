Imports System.Data.OleDb

Module Conexao
    Dim con As New OleDbConnection

    Public Function Conecta() As OleDb.OleDbConnection
        Dim path As New PathControle

        With con
            If .State = ConnectionState.Open Then Return con

            .ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path.RetPathApp & "/G/Gerenciador_de_ Blocos.accdb;" & _
                                 "Jet OLEDB:Database password=9152")
            .Open()
            If Not .State = ConnectionState.Open Then Return Nothing
        End With

        Return con

    End Function
End Module
