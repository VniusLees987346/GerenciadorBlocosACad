<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesenhaSimbolo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabClasse = New System.Windows.Forms.Label
        Me.LabDescricao = New System.Windows.Forms.Label
        Me.LabNatureza = New System.Windows.Forms.Label
        Me.B_InserirSim = New System.Windows.Forms.Button
        Me.TB_sim = New System.Windows.Forms.TextBox
        Me.BT_pesquisar = New System.Windows.Forms.Button
        Me.CB_Classe = New System.Windows.Forms.ComboBox
        Me.CB_Natureza = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TP_SimDaClasse = New System.Windows.Forms.TabPage
        Me.DGV_SimDaCla = New System.Windows.Forms.DataGridView
        Me.TP_TodosSimbolos = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BT_Desenhar = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TP_SimDaClasse.SuspendLayout()
        CType(Me.DGV_SimDaCla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_TodosSimbolos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-160, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Código "
        '
        'LabClasse
        '
        Me.LabClasse.AutoSize = True
        Me.LabClasse.Location = New System.Drawing.Point(-160, 164)
        Me.LabClasse.Name = "LabClasse"
        Me.LabClasse.Size = New System.Drawing.Size(38, 13)
        Me.LabClasse.TabIndex = 34
        Me.LabClasse.Text = "Classe"
        '
        'LabDescricao
        '
        Me.LabDescricao.AutoSize = True
        Me.LabDescricao.Location = New System.Drawing.Point(-160, 204)
        Me.LabDescricao.Name = "LabDescricao"
        Me.LabDescricao.Size = New System.Drawing.Size(58, 13)
        Me.LabDescricao.TabIndex = 33
        Me.LabDescricao.Text = "Descrição "
        '
        'LabNatureza
        '
        Me.LabNatureza.AutoSize = True
        Me.LabNatureza.Location = New System.Drawing.Point(-160, 125)
        Me.LabNatureza.Name = "LabNatureza"
        Me.LabNatureza.Size = New System.Drawing.Size(50, 13)
        Me.LabNatureza.TabIndex = 32
        Me.LabNatureza.Text = "Natureza"
        '
        'B_InserirSim
        '
        Me.B_InserirSim.Location = New System.Drawing.Point(-157, 237)
        Me.B_InserirSim.Name = "B_InserirSim"
        Me.B_InserirSim.Size = New System.Drawing.Size(72, 21)
        Me.B_InserirSim.TabIndex = 29
        Me.B_InserirSim.Text = "Inserir"
        Me.B_InserirSim.UseVisualStyleBackColor = True
        '
        'TB_sim
        '
        Me.TB_sim.Location = New System.Drawing.Point(12, 109)
        Me.TB_sim.Name = "TB_sim"
        Me.TB_sim.Size = New System.Drawing.Size(313, 20)
        Me.TB_sim.TabIndex = 51
        '
        'BT_pesquisar
        '
        Me.BT_pesquisar.Location = New System.Drawing.Point(331, 106)
        Me.BT_pesquisar.Name = "BT_pesquisar"
        Me.BT_pesquisar.Size = New System.Drawing.Size(124, 25)
        Me.BT_pesquisar.TabIndex = 50
        Me.BT_pesquisar.Text = "Pesquisar "
        Me.BT_pesquisar.UseVisualStyleBackColor = True
        '
        'CB_Classe
        '
        Me.CB_Classe.FormattingEnabled = True
        Me.CB_Classe.Location = New System.Drawing.Point(102, 56)
        Me.CB_Classe.Name = "CB_Classe"
        Me.CB_Classe.Size = New System.Drawing.Size(353, 21)
        Me.CB_Classe.TabIndex = 49
        '
        'CB_Natureza
        '
        Me.CB_Natureza.FormattingEnabled = True
        Me.CB_Natureza.Location = New System.Drawing.Point(102, 12)
        Me.CB_Natureza.Name = "CB_Natureza"
        Me.CB_Natureza.Size = New System.Drawing.Size(353, 21)
        Me.CB_Natureza.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Classe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Natureza"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TP_SimDaClasse)
        Me.TabControl1.Controls.Add(Me.TP_TodosSimbolos)
        Me.TabControl1.Location = New System.Drawing.Point(12, 171)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 279)
        Me.TabControl1.TabIndex = 52
        '
        'TP_SimDaClasse
        '
        Me.TP_SimDaClasse.Controls.Add(Me.DGV_SimDaCla)
        Me.TP_SimDaClasse.Location = New System.Drawing.Point(4, 22)
        Me.TP_SimDaClasse.Name = "TP_SimDaClasse"
        Me.TP_SimDaClasse.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_SimDaClasse.Size = New System.Drawing.Size(435, 253)
        Me.TP_SimDaClasse.TabIndex = 0
        Me.TP_SimDaClasse.Text = "Simbolos da classe Selecionada"
        Me.TP_SimDaClasse.UseVisualStyleBackColor = True
        '
        'DGV_SimDaCla
        '
        Me.DGV_SimDaCla.AllowUserToAddRows = False
        Me.DGV_SimDaCla.AllowUserToDeleteRows = False
        Me.DGV_SimDaCla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SimDaCla.Location = New System.Drawing.Point(6, 6)
        Me.DGV_SimDaCla.Name = "DGV_SimDaCla"
        Me.DGV_SimDaCla.Size = New System.Drawing.Size(423, 241)
        Me.DGV_SimDaCla.TabIndex = 53
        '
        'TP_TodosSimbolos
        '
        Me.TP_TodosSimbolos.Controls.Add(Me.DataGridView1)
        Me.TP_TodosSimbolos.Location = New System.Drawing.Point(4, 22)
        Me.TP_TodosSimbolos.Name = "TP_TodosSimbolos"
        Me.TP_TodosSimbolos.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_TodosSimbolos.Size = New System.Drawing.Size(435, 253)
        Me.TP_TodosSimbolos.TabIndex = 1
        Me.TP_TodosSimbolos.Text = "Todos os simbolos"
        Me.TP_TodosSimbolos.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(423, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'BT_Desenhar
        '
        Me.BT_Desenhar.Location = New System.Drawing.Point(483, 418)
        Me.BT_Desenhar.Name = "BT_Desenhar"
        Me.BT_Desenhar.Size = New System.Drawing.Size(360, 31)
        Me.BT_Desenhar.TabIndex = 53
        Me.BT_Desenhar.Text = "Desenhar"
        Me.BT_Desenhar.UseVisualStyleBackColor = True
        '
        'DesenhaSimbolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 503)
        Me.Controls.Add(Me.BT_Desenhar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TB_sim)
        Me.Controls.Add(Me.BT_pesquisar)
        Me.Controls.Add(Me.CB_Classe)
        Me.Controls.Add(Me.CB_Natureza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabClasse)
        Me.Controls.Add(Me.LabDescricao)
        Me.Controls.Add(Me.LabNatureza)
        Me.Controls.Add(Me.B_InserirSim)
        Me.Name = "DesenhaSimbolo"
        Me.Text = "DesenhaSimbolo"
        Me.TabControl1.ResumeLayout(False)
        Me.TP_SimDaClasse.ResumeLayout(False)
        CType(Me.DGV_SimDaCla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_TodosSimbolos.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabClasse As System.Windows.Forms.Label
    Friend WithEvents LabDescricao As System.Windows.Forms.Label
    Friend WithEvents LabNatureza As System.Windows.Forms.Label
    Friend WithEvents B_InserirSim As System.Windows.Forms.Button
    Friend WithEvents TB_sim As System.Windows.Forms.TextBox
    Friend WithEvents BT_pesquisar As System.Windows.Forms.Button
    Friend WithEvents CB_Classe As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Natureza As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TP_SimDaClasse As System.Windows.Forms.TabPage
    Friend WithEvents TP_TodosSimbolos As System.Windows.Forms.TabPage
    Friend WithEvents DGV_SimDaCla As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BT_Desenhar As System.Windows.Forms.Button
End Class
