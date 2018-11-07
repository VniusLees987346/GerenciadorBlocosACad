Public Class TelaNatureza

    Private Sub TelaNatureza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AtualizaGrid()
        AtualizaCampos()
    End Sub

    Private Sub InserirSim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserirNat.Click

        If TB_DescNat.Text <> "" Then
            Dim existeDesc As New Select_dao
            If existeDesc.DescExiste("natureza", TB_DescNat.Text) Then
                MsgBox("Já existe uma natureza cadastrada com o este nome, Por Favor insira um nome diferente para cadastrar uma Natureza ")
            Else
                Dim InsereNat As New Select_dao
                InsereNat.InsereNatureza(TB_DescNat.Text)
                AtualizaGrid()
            End If
        Else
            MsgBox("O campo descrição deve ser Preenchido !")
        End If

    End Sub

    Private Sub AtualizaGrid()

        Dim SelectTab As New Select_dao
        DtGrid_Natureza.DataSource = SelectTab.GetDtAdp("natureza")
        TB_Codigo.Clear()
        TB_DescNat.Clear()


    End Sub

    Private Sub DtGrid_Natureza_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DtGrid_Natureza.DataBindingComplete
        DtGrid_Natureza.Columns("nat_id").Visible = False

        DtGrid_Natureza.Columns("nat_desc").HeaderText = "Descrição Da Natureza"
        DtGrid_Natureza.Columns("nat_desc").Width = 600
    End Sub

    Private Sub DtGrid_Natureza_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtGrid_Natureza.RowHeaderMouseClick

        AtualizaCampos()

    End Sub

    Private Sub AtualizaCampos()
        If DtGrid_Natureza.RowCount > 0 Then
            Dim preenche As New Select_dao
            Dim linha As DataGridViewRow = DtGrid_Natureza.CurrentRow
            Dim id As Integer = linha.Cells(0).Value.ToString
            Dim desc As String = linha.Cells(1).Value.ToString

            'Agora irei preencher os text box com os dados da natureza  selecionado no data grid 
            TB_Codigo.Text = id
            TB_DescNat.Text = desc
        End If

    End Sub

    Private Sub DeletarNat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletarNat.Click
        Dim del As New Select_dao
        del.DeletaLinha("natureza", TB_Codigo.Text)

        AtualizaGrid()
    End Sub

    Private Sub AlterarNat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarNat.Click
        If TB_Codigo.Text <> "" Then

            Dim update As New Select_dao
            update.AtualizaLinha("natureza", TB_Codigo.Text, "", TB_DescNat.Text)

            AtualizaGrid()
        Else
            MsgBox("O campo Código deve ser Preenchido !")
        End If
    End Sub
End Class