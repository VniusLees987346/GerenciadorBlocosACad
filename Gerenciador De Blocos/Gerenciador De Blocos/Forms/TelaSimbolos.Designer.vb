<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaSimbolos
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.B_InserirSim = New System.Windows.Forms.Button
        Me.B_Alterar = New System.Windows.Forms.Button
        Me.B_Deletar = New System.Windows.Forms.Button
        Me.LabNatureza = New System.Windows.Forms.Label
        Me.LabDescricao = New System.Windows.Forms.Label
        Me.LabClasse = New System.Windows.Forms.Label
        Me.TB_Descricao = New System.Windows.Forms.TextBox
        Me.CB_Natureza = New System.Windows.Forms.ComboBox
        Me.CB_Classe = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TB_id = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BT_Ins_Utiliz_Bco = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 302)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(458, 326)
        Me.DataGridView1.TabIndex = 0
        '
        'B_InserirSim
        '
        Me.B_InserirSim.Location = New System.Drawing.Point(12, 3)
        Me.B_InserirSim.Name = "B_InserirSim"
        Me.B_InserirSim.Size = New System.Drawing.Size(154, 21)
        Me.B_InserirSim.TabIndex = 1
        Me.B_InserirSim.Text = "Inserir (Criando Bloco)"
        Me.B_InserirSim.UseVisualStyleBackColor = True
        '
        'B_Alterar
        '
        Me.B_Alterar.Location = New System.Drawing.Point(390, 3)
        Me.B_Alterar.Name = "B_Alterar"
        Me.B_Alterar.Size = New System.Drawing.Size(72, 21)
        Me.B_Alterar.TabIndex = 3
        Me.B_Alterar.Text = "Alterar"
        Me.B_Alterar.UseVisualStyleBackColor = True
        '
        'B_Deletar
        '
        Me.B_Deletar.Location = New System.Drawing.Point(248, 3)
        Me.B_Deletar.Name = "B_Deletar"
        Me.B_Deletar.Size = New System.Drawing.Size(72, 21)
        Me.B_Deletar.TabIndex = 4
        Me.B_Deletar.Text = "Deletar "
        Me.B_Deletar.UseVisualStyleBackColor = True
        '
        'LabNatureza
        '
        Me.LabNatureza.AutoSize = True
        Me.LabNatureza.Location = New System.Drawing.Point(9, 118)
        Me.LabNatureza.Name = "LabNatureza"
        Me.LabNatureza.Size = New System.Drawing.Size(50, 13)
        Me.LabNatureza.TabIndex = 5
        Me.LabNatureza.Text = "Natureza"
        '
        'LabDescricao
        '
        Me.LabDescricao.AutoSize = True
        Me.LabDescricao.Location = New System.Drawing.Point(9, 197)
        Me.LabDescricao.Name = "LabDescricao"
        Me.LabDescricao.Size = New System.Drawing.Size(58, 13)
        Me.LabDescricao.TabIndex = 6
        Me.LabDescricao.Text = "Descrição "
        '
        'LabClasse
        '
        Me.LabClasse.AutoSize = True
        Me.LabClasse.Location = New System.Drawing.Point(9, 157)
        Me.LabClasse.Name = "LabClasse"
        Me.LabClasse.Size = New System.Drawing.Size(38, 13)
        Me.LabClasse.TabIndex = 7
        Me.LabClasse.Text = "Classe"
        '
        'TB_Descricao
        '
        Me.TB_Descricao.Location = New System.Drawing.Point(102, 197)
        Me.TB_Descricao.Name = "TB_Descricao"
        Me.TB_Descricao.Size = New System.Drawing.Size(223, 20)
        Me.TB_Descricao.TabIndex = 8
        '
        'CB_Natureza
        '
        Me.CB_Natureza.FormattingEnabled = True
        Me.CB_Natureza.Location = New System.Drawing.Point(102, 110)
        Me.CB_Natureza.Name = "CB_Natureza"
        Me.CB_Natureza.Size = New System.Drawing.Size(223, 21)
        Me.CB_Natureza.TabIndex = 9
        '
        'CB_Classe
        '
        Me.CB_Classe.FormattingEnabled = True
        Me.CB_Classe.Location = New System.Drawing.Point(102, 154)
        Me.CB_Classe.Name = "CB_Classe"
        Me.CB_Classe.Size = New System.Drawing.Size(223, 21)
        Me.CB_Classe.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(313, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 25)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Pesquisar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_id
        '
        Me.TB_id.Enabled = False
        Me.TB_id.Location = New System.Drawing.Point(102, 79)
        Me.TB_id.Name = "TB_id"
        Me.TB_id.Size = New System.Drawing.Size(223, 20)
        Me.TB_id.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Código "
        '
        'BT_Ins_Utiliz_Bco
        '
        Me.BT_Ins_Utiliz_Bco.Location = New System.Drawing.Point(12, 42)
        Me.BT_Ins_Utiliz_Bco.Name = "BT_Ins_Utiliz_Bco"
        Me.BT_Ins_Utiliz_Bco.Size = New System.Drawing.Size(154, 21)
        Me.BT_Ins_Utiliz_Bco.TabIndex = 29
        Me.BT_Ins_Utiliz_Bco.Text = "Inserir (Utilizando Bloco)"
        Me.BT_Ins_Utiliz_Bco.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.B_InserirSim)
        Me.Panel1.Controls.Add(Me.BT_Ins_Utiliz_Bco)
        Me.Panel1.Controls.Add(Me.B_Alterar)
        Me.Panel1.Controls.Add(Me.B_Deletar)
        Me.Panel1.Location = New System.Drawing.Point(5, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 66)
        Me.Panel1.TabIndex = 30
        '
        'TelaSimbolos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TB_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_Classe)
        Me.Controls.Add(Me.CB_Natureza)
        Me.Controls.Add(Me.TB_Descricao)
        Me.Controls.Add(Me.LabClasse)
        Me.Controls.Add(Me.LabDescricao)
        Me.Controls.Add(Me.LabNatureza)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TelaSimbolos"
        Me.Text = "Controle de Símbolos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents B_InserirSim As System.Windows.Forms.Button
    Friend WithEvents B_Alterar As System.Windows.Forms.Button
    Friend WithEvents B_Deletar As System.Windows.Forms.Button
    Friend WithEvents LabNatureza As System.Windows.Forms.Label
    Friend WithEvents LabDescricao As System.Windows.Forms.Label
    Friend WithEvents LabClasse As System.Windows.Forms.Label
    Friend WithEvents TB_Descricao As System.Windows.Forms.TextBox
    Friend WithEvents CB_Natureza As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Classe As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TB_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_Ins_Utiliz_Bco As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
