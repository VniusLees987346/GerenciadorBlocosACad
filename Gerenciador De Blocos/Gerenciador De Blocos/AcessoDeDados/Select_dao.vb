Imports System.Data.OleDb

Public Class Select_dao

    ' estes tres métodos a seguir selecionam retorna um dataReader de determinada classe, 
    ' Esta contido no DataReader todos os campos e todos os items

    Public Function GetDtRder(ByVal tabelas As String) As OleDbDataReader
        Dim con = Conexao.Conecta()

        Dim odc As New OleDbCommand

        odc.CommandText = "Select * from  " & tabelas
        odc.CommandType = CommandType.Text
        odc.Connection = con
        odc.ExecuteNonQuery()

        Dim dr As OleDbDataReader = odc.ExecuteReader

        Return dr
    End Function

    Public Function GetDtAdp(ByVal tabelas As String) As DataTable
        Dim con = Conexao.Conecta()
        Dim Str As String = Nothing
        Dim dt As DataTable = Nothing
        Dim da As OleDbDataAdapter
        If tabelas = "simbolos" Then
            Str = "Select sim_id, sim_id_cla, sim_desc  from  " & tabelas
        ElseIf tabelas = "natureza" Then
            Str = "Select * from  " & tabelas
        ElseIf tabelas = "classes" Then
            Str = "Select * from  " & tabelas
        Else
            MsgBox("o dado informado não corresponde a uma tabela do banco de dados desta aplicação !")
        End If

        Try
            da = New OleDbDataAdapter(Str, con)
            dt = New DataTable
            da.Fill(dt)
            da.Dispose()
        Catch ex As Exception
            MsgBox("ocorreu um erro ao selecionar os simbolos ")
        End Try

        con.Close()
        Return dt
    End Function

    Public Function GetDtAdpSimDaClasse(ByVal cod_classe As String) As DataTable
        Dim con = Conexao.Conecta()
        Dim Str As String
        Dim dt As DataTable = Nothing
        Dim da As OleDbDataAdapter

        Try
            Str = "Select sim_id, sim_id_cla, sim_desc from  simbolos where sim_id_cla = " & cod_classe & " ;"
            da = New OleDbDataAdapter(Str, con)
            dt = New DataTable
            da.Fill(dt)
            da.Dispose()
        Catch ex As Exception
            MsgBox("ocorreu um erro ao selecionar os simbolos ")
        End Try

        con.Close()
        Return dt
    End Function
    '    Public Function GetSimbolos() As OleDbDataReader
    'Dim con = Conexao.Conecta()
    '
    'Dim odc As New OleDbCommand
    '
    '   odc.CommandText = "Select * from Simbolos "
    '    odc.CommandType = CommandType.Text
    '    odc.Connection = con
    '    odc.ExecuteNonQuery()
    '
    'Dim dr As OleDbDataReader = odc.ExecuteReader
    '    Return dr
    'End Function
    'Public Function GetClasses() As OleDbDataReader
    ' Dim con = Conexao.Conecta()

    'Dim odc As New OleDbCommand
    '
    '       odc.CommandText = "Select * from Classes "
    '      odc.CommandType = CommandType.Text
    '     odc.Connection = con
    '    odc.ExecuteNonQuery()
    '
    'Dim dr As OleDbDataReader = odc.ExecuteReader
    '   Return dr
    'End Function
    '
    '
    '
    '
    '
    ' final 

    ' Retorna o Data reader contendo os dados de todas as classes de determinada natureza que foi passada como parâmetro  ( o id da nat)
    Public Function GetClasses(ByVal id_nat As Double) As OleDbDataReader
        Dim con = Conexao.Conecta()

        Dim odc As New OleDbCommand

        odc.CommandText = "Select * from classes where cla_id_nat = " & id_nat & " ;  "
        odc.CommandType = CommandType.Text
        odc.Connection = con
        odc.ExecuteNonQuery()

        Dim dr As OleDbDataReader = odc.ExecuteReader

        Return dr

        con.Close()
    End Function

    ' Abaixo segue as funções de inserção na tabela simbolos,  
    Public Sub InsereSimbolo(ByVal id_classe As Integer, ByVal sim_desc As String, ByVal sim_caminho As String)
        Dim con = Conexao.Conecta()
        Dim da As New OleDbCommand
        da.CommandText = "insert into simbolos  (sim_id_cla, sim_desc, sim_caminho) values (" & id_classe & " , '" & sim_desc & "' , '" & sim_caminho & "' ) ; "
        da.CommandType = CommandType.Text
        da.Connection = con
        da.ExecuteNonQuery()
        con.Close()
    End Sub

    ' Abaixo segue as funções de inserção na tabela natureza, 
    Public Sub InsereNatureza(ByVal nat_desc As String)
        Dim con = Conexao.Conecta()
        Dim da As New OleDbCommand
        da.CommandText = "insert into natureza  (nat_desc) values ('" & nat_desc & "' ) ; "
        da.CommandType = CommandType.Text
        da.Connection = con
        da.ExecuteNonQuery()
        con.Close()
    End Sub

    ' Abaixo segue as funções de inserção na tabela Classes, 
    Public Sub InsereClasse(ByVal cla_id_nat As String, ByVal cla_desc As String)
        Dim con = Conexao.Conecta()
        Dim da As New OleDbCommand
        da.CommandText = "insert into classes  (cla_id_nat , cla_desc) values (" & cla_id_nat & ", '" & cla_desc & "' ) ; "
        da.CommandType = CommandType.Text
        da.Connection = con
        da.ExecuteNonQuery()
        con.Close()
    End Sub

    ' Abaixo segue as funções que irão retornar o id da tabela a qual esta relacionado meu objeto 
    Public Function GetIdClasse(ByVal str_classe As String) As Integer
        If str_classe <> "" Then

            Dim con = Conexao.Conecta()

            Dim da As New OleDbDataAdapter("Select cla_id from classes where cla_desc = '" + str_classe + "' ;", con)
            Dim dr As DataRow
            Dim dt As New System.Data.DataTable

            da.Fill(dt)
            dr = dt.Rows(0)
            Dim id As Integer = dr("cla_id")
            Return id
            con.Close()
        Else
            MsgBox("É necessário passar um parâmetro !")
        End If

    End Function

    Public Function GetIdNat(ByVal str_nat As String) As Double

        Dim con = Conexao.Conecta()

        Dim da As New OleDbDataAdapter("Select nat_id from natureza where nat_desc = '" + str_nat + "' ;", con)
        Dim dr As DataRow
        Dim dt As New System.Data.DataTable

        da.Fill(dt)
        dr = dt.Rows(0)
        Dim id As Double = dr("nat_id")
        Return id
        con.Close()
    End Function

    ' Abaixo segue as funções que irão retornar a descrição da classe referente ao id passado como parametro 
    Public Function GetDescricaoClasse(ByVal str_idClasse As String) As String

        Dim con = Conexao.Conecta()

        Dim da As New OleDbDataAdapter("Select cla_desc from classes where cla_id = " + str_idClasse + " ;", con)
        Dim dr As DataRow
        Dim dt As New System.Data.DataTable

        da.Fill(dt)
        dr = dt.Rows(0)
        Dim nome_classe As String = dr("cla_desc")

        Return nome_classe
        con.Close()
    End Function

    ' Abaixo segue as funções que irão retornar a descrição da Natureza referente ao id passado como parametro 
    Public Function GetDescricaoNat(ByVal str_idNat As String) As String
        Dim con = Conexao.Conecta()

        Dim da As New OleDbDataAdapter("Select nat_desc from natureza where nat_id = " + str_idNat + " ;", con)
        Dim dr As DataRow
        Dim dt As New System.Data.DataTable

        da.Fill(dt)
        dr = dt.Rows(0)
        Dim nome_nat As String = dr("nat_desc")
        Return nome_nat
        con.Close()
    End Function

    ' Abaixo segue as funções que irão retornar o id da natureza  referente ao id da classe passado como parametro 
    Public Function GetId_NatDaClasse(ByVal str_idClasse As String) As String

        Dim con = Conexao.Conecta()

        Dim da As New OleDbDataAdapter("Select cla_id_nat from classes where cla_id = " + str_idClasse + " ;", con)
        Dim dr As DataRow
        Dim dt As New DataTable

        da.Fill(dt)
        dr = dt.Rows(0)
        Dim id_nat As Integer = dr("cla_id_nat")

        Return id_nat
    End Function

    '  função que irá realizar um delete nas tabelas de acordo com a tabela e o id passado como parametro 
    Public Sub DeletaLinha(ByVal tabelas As String, ByVal id As String)
        Dim con = Conexao.Conecta()

        Dim odc As New OleDbCommand
        Dim Str As String = Nothing

        If id <> "" Then
            If tabelas = "simbolos" Then
                Str = "delete from  " & tabelas & " where sim_id = " & id
            ElseIf tabelas = "natureza" Then
                Str = "delete from  " & tabelas & " where nat_id = " & id
            ElseIf tabelas = "classes" Then
                Str = "delete from  " & tabelas & " where cla_id = " & id
            Else
                MsgBox("o dado informado não corresponde a uma tabela do banco de dados desta aplicação !")
            End If
            odc.CommandText = Str
            odc.CommandType = CommandType.Text
            odc.Connection = con
            odc.ExecuteNonQuery()

        Else
            MsgBox("É necessário selecionar um simbolo antes de deletá-lo !")
        End If


        con.Close()


    End Sub

    '  função que irá realizar um update nas tabelas de acordo com a tabela e o id passado como parametro 
    Public Sub AtualizaLinha(ByVal tabelas As String, ByVal id As String, ByVal id_relacao As String, ByVal desc As String)
        Dim con = Conexao.Conecta()

        Dim odc As New OleDbCommand
        Dim Str As String = Nothing

        If id <> "" Then
            If tabelas = "simbolos" Then
                Str = "update " & tabelas & " set sim_id_cla = " & id_relacao & ", sim_desc = '" & desc & "' where sim_id = " & id
            ElseIf tabelas = "natureza" Then
                Str = "update " & tabelas & " set  nat_desc = '" & desc & "' where nat_id = " & id
            ElseIf tabelas = "classes" Then
                Str = "update " & tabelas & " set cla_id_nat = " & id_relacao & ", cla_desc = '" & desc & "' where cla_id = " & id
            Else
                MsgBox("o dado informado não corresponde a uma tabela do banco de dados desta aplicação !")
            End If
            odc.CommandText = Str
            odc.CommandType = CommandType.Text
            odc.Connection = con
            odc.ExecuteNonQuery()
        Else
            MsgBox("É necessário selecionar um simbolo antes de alterá-lo !")
        End If



        con.Close()

    End Sub

    '  função que irá realizar um select para saber se já existe ou não uma natureza com o nome passado  
    Public Function DescExiste(ByVal tabelas As String, ByVal desc As String) As Boolean

        Dim con = Conexao.Conecta()
        Dim dt As New DataTable
        Dim Str As String = Nothing

        If desc <> "" Then

            If tabelas = "natureza" Then
                Str = "select * from " & tabelas & " where nat_desc = '" & desc & "' ; "
            ElseIf tabelas = "classes" Then
                Str = "select * from " & tabelas & " where cla_desc = '" & desc & "' ; "
            ElseIf tabelas = "simbolos" Then
                Str = "select * from " & tabelas & " where sim_desc = '" & desc & "' ; "
            Else
                MsgBox("o dado informado não corresponde a uma tabela do banco de dados desta aplicação !")
            End If
            Dim da As New OleDbDataAdapter(Str, con)
            da.Fill(dt)
            da.Dispose()

        Else
            MsgBox("É necessário passar um parametro !")
        End If


        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
        con.Close()
    End Function
End Class
