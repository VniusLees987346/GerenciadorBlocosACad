Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.Interop
Imports System.IO


Public Class TelaSimbolos

    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ValidaRefAcad()

        Dim SelectTab As New Select_dao
        Dim dr As OleDbDataReader = SelectTab.GetDtRder("natureza")


        While (dr.Read())
            CB_Natureza.Items.Add(dr("nat_desc"))
        End While


        AtualizaGrid()
        AtualizaCampos()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_InserirSim.Click
        ValidaRefAcad()
        If TB_Descricao.Text <> "" Then
            Dim existeDesc As New Select_dao
            If existeDesc.DescExiste("simbolos", TB_Descricao.Text) Then
                MsgBox("Já existe um Simbolo cadastrado com o este nome, Por Favor insira um nome diferente para cadastrar um Simbolo ")
            Else
                Dim getIdClasse As New Select_dao
                Dim idClasse As Integer = getIdClasse.GetIdClasse(CB_Classe.Text)

                Dim InsereSim As New Select_dao
                InsereSim.InsereSimbolo(idClasse, TB_Descricao.Text, "d:\\")

                SetaUser(TB_Descricao.Text)
                AtualizaGrid()

                Dim ChamaLisp As New Chamada_De_Lisps

                ChamaLisp.CriaSimbolo(acd)
                Me.Dispose(True)
            End If
        Else
            MsgBox("O campo descrição deve ser Preenchido !")
        End If



    End Sub
    Private Sub BT_Ins_Utiliz_Bco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Ins_Utiliz_Bco.Click
   
        ValidaRefAcad()
        If TB_Descricao.Text <> "" Then
            Dim existeDesc As New Select_dao
            If existeDesc.DescExiste("simbolos", TB_Descricao.Text) Then
                MsgBox("Já existe um Simbolo cadastrado com o este nome, Por Favor insira um nome diferente para cadastrar um Simbolo ")
            Else
                Dim getIdClasse As New Select_dao
                Dim idClasse As Integer = getIdClasse.GetIdClasse(CB_Classe.Text)

                Dim InsereSim As New Select_dao
                InsereSim.InsereSimbolo(idClasse, TB_Descricao.Text, "d:\\")

                'Setando o nome do bloco 
                Dim SetNomeSim As New FuncoesLisp
                SetNomeSim.NomeSim = TB_Descricao.Text

                
                AtualizaGrid()

                Dim ChamaLisp As New Chamada_De_Lisps
                ChamaLisp.CriaSimboloEx(acd)
                Me.Dispose(True)
            End If
        Else
            MsgBox("O campo descrição deve ser Preenchido !")
        End If
    End Sub

    Private Sub CB_Natureza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Natureza.SelectedIndexChanged

        CB_Classe.Items.Clear()
        ' retorna o id da natureza que foi selecionada no combobox 
        Dim getIdNat As New Select_dao
        Dim idNat As Double = getIdNat.GetIdNat(CB_Natureza.Text)

        ' insere todas as classes da natureza selecionada no combobox de classes 

        Dim SelecNat As New Select_dao
        Dim dr As OleDbDataReader = SelecNat.GetClasses(idNat)

        While (dr.Read())
            CB_Classe.Items.Add(dr("cla_desc"))
        End While

        If CB_Classe.Items.Count > 0 Then
            CB_Classe.SelectedIndex = 0
        Else
            CB_Classe.Text = ""
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.Columns("sim_id").Visible = False
        DataGridView1.Columns("sim_id_cla").Visible = False
        DataGridView1.Columns("sim_desc").HeaderText = "Descrição Do Simbolo"
        DataGridView1.Columns("sim_desc").Width = 600
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim preenche As New Select_dao
        Dim linha As DataGridViewRow = DataGridView1.CurrentRow
        Dim id As Integer = linha.Cells(0).Value.ToString
        Dim id_cla As String = linha.Cells(1).Value.ToString
        Dim desc As String = linha.Cells(2).Value.ToString
        'MsgBox(id)
        'Agora irei preencher os text box e os combobox com os dados do simbolo selecionado no data grid 
        TB_id.Text = id
        TB_Descricao.Text = desc

        Dim classe As String = preenche.GetDescricaoClasse(id_cla)
        CB_Classe.Text = classe
        Dim id_nat As String = preenche.GetId_NatDaClasse(id_cla)
        Dim natureza As String = preenche.GetDescricaoNat(id_nat)
        CB_Natureza.Text = natureza
    End Sub

    Private Sub AtualizaGrid()

        Dim SelectTab As New Select_dao
        DataGridView1.DataSource = SelectTab.GetDtAdp("simbolos")
        TB_id.Clear()
        TB_Descricao.Clear()
        CB_Classe.Text = ""
        CB_Natureza.Text = ""


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Deletar.Click


        Dim del As New Select_dao
        del.DeletaLinha("simbolos", TB_id.Text)
        DeletaArquivo(TB_Descricao.Text)
        AtualizaGrid()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Alterar.Click
        If TB_id.Text <> "" Then

            Dim update As New Select_dao
            Dim id_cla As String = update.GetIdClasse(CB_Classe.Text)
            update.AtualizaLinha("simbolos", TB_id.Text, id_cla, TB_Descricao.Text)


            AtualizaGrid()
        Else
            MsgBox("O campo Código deve ser Preenchido !")
        End If
    End Sub

    Private Sub AtualizaCampos()
        If DataGridView1.RowCount > 0 Then
            Dim preenche As New Select_dao
            Dim linha As DataGridViewRow = DataGridView1.CurrentRow

            Dim id As Integer = linha.Cells(0).Value.ToString
            Dim id_cla As String = linha.Cells(1).Value.ToString
            Dim desc As String = linha.Cells(2).Value.ToString
            'MsgBox(id)
            'Agora irei preencher os text box e os combobox com os dados do simbolo selecionado no data grid 
            TB_id.Text = id
            TB_Descricao.Text = desc

            Dim classe As String = preenche.GetDescricaoClasse(id_cla)
            CB_Classe.Text = classe
            Dim id_nat As String = preenche.GetId_NatDaClasse(id_cla)
            Dim natureza As String = preenche.GetDescricaoNat(id_nat)
            CB_Natureza.Text = natureza
        End If

    End Sub

    Public Sub SetaUser(ByVal Str As String)
        ValidaRefAcad()
        Dim TDwg As AcadDocument
        TDwg = acd.ActiveDocument
        TDwg.SetVariable("users1", Str)

    End Sub

    Public Sub DeletaArquivo(ByVal Str As String)
        Dim path As New PathControle
        Dim Dwg As String() = System.IO.Directory.GetFiles(path.RetPathApp & "/G/Simbolos/", Str & ".dwg")
        Dim Sld As String() = System.IO.Directory.GetFiles(path.RetPathApp & "/G/Simbolos/", Str & ".sld")
        If Dwg.Length > 0 And Sld.Length > 0 Then
            System.IO.File.Delete(Dwg(0))
            System.IO.File.Delete(Sld(0))
        Else
            MsgBox("O arquivo não existe ou o diretório especificado é incorreto ! Arquivo não deletado")
        End If

    End Sub





End Class
