Imports Autodesk.AutoCAD.Interop
Imports System.Data.OleDb

Public Class DesenhaSimbolo

    'Public Sub set_acd()
    'Dim retAcdApp As New RetornaAcadApplication
    '    acd = retAcdApp.Get_acd
    'End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim iniciando As New Inicial
        'iniciando.Iniciando()

        Dim SelectTab As New Select_dao
        Dim dr As OleDbDataReader = SelectTab.GetDtRder("natureza")


        While (dr.Read())
            CB_Natureza.Items.Add(dr("nat_desc"))
        End While


        AtualizaGrid()
        If DataGridView1.Rows.Count > 0 Then
            AtualizaCampos(DataGridView1.Rows.Item(0))
        End If

        AtualizaGridSimDaClasse()
        If DGV_SimDaCla.Rows.Count > 0 Then
            AtualizaCampos(DGV_SimDaCla.Rows.Item(0))
        End If
        'set_acd()
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
        AtualizaGrid()
        AtualizaGridSimDaClasse()

    End Sub


    Private Sub AtualizaGrid()
        Dim SelectTab As New Select_dao
        DataGridView1.DataSource = SelectTab.GetDtAdp("simbolos")
    End Sub

    Private Sub AtualizaGridSimDaClasse()
        Dim SelectTab As New Select_dao
        DGV_SimDaCla.DataSource = SelectTab.GetDtAdpSimDaClasse(SelectTab.GetIdClasse(CB_Classe.Text))
    End Sub



    Private Sub AtualizaCampos(ByVal row As DataGridViewRow)

        Dim preenche As New Select_dao
        Dim linha As DataGridViewRow = row
        Dim id As Integer = linha.Cells(0).Value.ToString
        Dim id_cla As String = linha.Cells(1).Value.ToString
        Dim desc As String = linha.Cells(2).Value.ToString
        'MsgBox(id)
        'Agora irei preencher os text box e os combobox com os dados do simbolo selecionado no data grid 
        TB_sim.Text = desc


        Dim id_nat As String = preenche.GetId_NatDaClasse(id_cla)
        Dim natureza As String = preenche.GetDescricaoNat(id_nat)
        CB_Natureza.Text = natureza
        Dim classe As String = preenche.GetDescricaoClasse(id_cla)
        CB_Classe.Text = classe

    End Sub
    Public Sub SetaUser(ByVal Str As String)
        ValidaRefAcad()
        Dim TDwg As AcadDocument
        TDwg = acd.ActiveDocument
        TDwg.SetVariable("users2", Str)

    End Sub

    Private Sub CB_Classe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Classe.SelectedIndexChanged
        AtualizaGridSimDaClasse()
    End Sub

    Private Sub DataGridView1_DataBindingComplete1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.Columns("sim_id").Visible = False
        DataGridView1.Columns("sim_id_cla").Visible = False
        DataGridView1.Columns("sim_desc").HeaderText = "Descrição Do Simbolo"
        DataGridView1.Columns("sim_desc").Width = 370
    End Sub




    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        AtualizaCampos(DataGridView1.CurrentRow)
        AtualizaGridSimDaClasse()

    End Sub

    Private Sub DGV_SimDaCla_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DGV_SimDaCla.DataBindingComplete
        DGV_SimDaCla.Columns("sim_id").Visible = False
        DGV_SimDaCla.Columns("sim_id_cla").Visible = False
        DGV_SimDaCla.Columns("sim_desc").HeaderText = "Descrição Do Simbolo"
        DGV_SimDaCla.Columns("sim_desc").Width = 370
    End Sub

    Private Sub DGV_SimDaCla_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_SimDaCla.RowHeaderMouseClick
        AtualizaCampos(DGV_SimDaCla.CurrentRow)

    End Sub

    Private Sub BT_Desenhar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Desenhar.Click

        ValidaRefAcad()

        Try
            SetaUser(TB_sim.Text)
            Dim ChamaLisp As New Chamada_De_Lisps

            ChamaLisp.DesenhaSimbolo(acd)
            Me.Dispose(True)

        Catch
            MsgBox("Erro ao tentar desenhar um simbolo")
        End Try
    End Sub



End Class