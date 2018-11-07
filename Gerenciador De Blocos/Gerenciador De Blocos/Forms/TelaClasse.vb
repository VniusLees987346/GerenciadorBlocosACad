Imports System.Data.OleDb

Public Class TelaClasse


    Private Sub TelaClasse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim SelectTab As New Select_dao
        Dim dr As OleDbDataReader = SelectTab.GetDtRder("natureza")

        While (dr.Read())
            CB_Natureza.Items.Add(dr("nat_desc"))
        End While


        AtualizaGrid()
        AtualizaCampos()
    End Sub

    Private Sub DtGrid_Classe_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DtGrid_Classe.DataBindingComplete
        DtGrid_Classe.Columns("cla_id").Visible = False
        DtGrid_Classe.Columns("cla_id_nat").Visible = False
        DtGrid_Classe.Columns("cla_desc").HeaderText = "Descrição Da Classe"
        DtGrid_Classe.Columns("cla_desc").Width = 600
    End Sub

    Private Sub DtGrid_Classe_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtGrid_Classe.RowHeaderMouseClick

        Dim preenche As New Select_dao
        Dim linha As DataGridViewRow = DtGrid_Classe.CurrentRow
        Dim id As Integer = linha.Cells(0).Value.ToString
        Dim id_nat As String = linha.Cells(1).Value.ToString
        Dim desc As String = linha.Cells(2).Value.ToString
        'MsgBox(id)
        'Agora irei preencher os text box e os combobox com os dados do simbolo selecionado no data grid 
        TB_Codigo.Text = id
        TB_Classe.Text = desc

        Dim natureza As String = preenche.GetDescricaoNat(id_nat)
        CB_Natureza.Text = natureza
        
    End Sub

    Private Sub InserirCla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserirCla.Click
        If TB_Classe.Text <> "" Then
            Dim existeDesc As New Select_dao
            If existeDesc.DescExiste("classes", TB_Classe.Text) Then
                MsgBox("Já existe uma Classe cadastrada com o este nome, Por Favor insira um nome diferente para cadastrar uma Classe ")
            Else
                Dim getIdNat As New Select_dao
                Dim idNat As String = getIdNat.GetIdNat(CB_Natureza.Text)

                Dim InsereCla As New Select_dao
                InsereCla.InsereClasse(idNat, TB_Classe.Text)

                AtualizaGrid()
            End If
        Else
            MsgBox("O campo descrição deve ser Preenchido !")
        End If

    End Sub

    Private Sub AtualizaGrid()

        Dim SelectTab As New Select_dao
        DtGrid_Classe.DataSource = SelectTab.GetDtAdp("classes")
        TB_Codigo.Clear()
        TB_Classe.Clear()
        CB_Natureza.Text = ""


    End Sub

    Private Sub DeletarCla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletarCla.Click
        Dim del As New Select_dao
        del.DeletaLinha("classes", TB_Codigo.Text)
        AtualizaGrid()
    End Sub

    Private Sub AlterarCla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarCla.Click
        If TB_Codigo.Text <> "" Then

            Dim update As New Select_dao
            Dim id_nat As String = update.GetIdNat(CB_Natureza.Text)
            update.AtualizaLinha("classes", TB_Codigo.Text, id_nat, TB_Classe.Text)


            AtualizaGrid()
        Else
            MsgBox("O campo Código deve ser Preenchido !")
        End If
    End Sub

    Private Sub AtualizaCampos()
        If DtGrid_Classe.RowCount > 0 Then
            Dim preenche As New Select_dao
            Dim linha As DataGridViewRow = DtGrid_Classe.CurrentRow

            Dim id As Integer = linha.Cells(0).Value.ToString
            Dim id_nat As String = linha.Cells(1).Value.ToString
            Dim desc As String = linha.Cells(2).Value.ToString
            'MsgBox(id)
            'Agora irei preencher os text box e os combobox com os dados do simbolo selecionado no data grid 
            TB_Codigo.Text = id
            TB_Classe.Text = desc


            Dim natureza As String = preenche.GetDescricaoNat(id_nat)
            CB_Natureza.Text = natureza
        End If

    End Sub

End Class