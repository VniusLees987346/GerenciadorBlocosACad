<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaClasse
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
        Me.TB_Codigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.LabNatureza = New System.Windows.Forms.Label
        Me.DeletarCla = New System.Windows.Forms.Button
        Me.AlterarCla = New System.Windows.Forms.Button
        Me.InserirCla = New System.Windows.Forms.Button
        Me.DtGrid_Classe = New System.Windows.Forms.DataGridView
        Me.CB_Natureza = New System.Windows.Forms.ComboBox
        Me.TB_Classe = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DtGrid_Classe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_Codigo
        '
        Me.TB_Codigo.Enabled = False
        Me.TB_Codigo.Location = New System.Drawing.Point(79, 62)
        Me.TB_Codigo.Name = "TB_Codigo"
        Me.TB_Codigo.Size = New System.Drawing.Size(165, 20)
        Me.TB_Codigo.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Código "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(265, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 25)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Pesquisar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabNatureza
        '
        Me.LabNatureza.AutoSize = True
        Me.LabNatureza.Location = New System.Drawing.Point(9, 98)
        Me.LabNatureza.Name = "LabNatureza"
        Me.LabNatureza.Size = New System.Drawing.Size(50, 13)
        Me.LabNatureza.TabIndex = 31
        Me.LabNatureza.Text = "Natureza"
        '
        'DeletarCla
        '
        Me.DeletarCla.Location = New System.Drawing.Point(172, 183)
        Me.DeletarCla.Name = "DeletarCla"
        Me.DeletarCla.Size = New System.Drawing.Size(72, 21)
        Me.DeletarCla.TabIndex = 30
        Me.DeletarCla.Text = "Deletar "
        Me.DeletarCla.UseVisualStyleBackColor = True
        '
        'AlterarCla
        '
        Me.AlterarCla.Location = New System.Drawing.Point(289, 183)
        Me.AlterarCla.Name = "AlterarCla"
        Me.AlterarCla.Size = New System.Drawing.Size(72, 21)
        Me.AlterarCla.TabIndex = 29
        Me.AlterarCla.Text = "Alterar "
        Me.AlterarCla.UseVisualStyleBackColor = True
        '
        'InserirCla
        '
        Me.InserirCla.Location = New System.Drawing.Point(12, 183)
        Me.InserirCla.Name = "InserirCla"
        Me.InserirCla.Size = New System.Drawing.Size(101, 21)
        Me.InserirCla.TabIndex = 28
        Me.InserirCla.Text = "Inserir"
        Me.InserirCla.UseVisualStyleBackColor = True
        '
        'DtGrid_Classe
        '
        Me.DtGrid_Classe.AllowUserToAddRows = False
        Me.DtGrid_Classe.AllowUserToDeleteRows = False
        Me.DtGrid_Classe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGrid_Classe.Location = New System.Drawing.Point(12, 231)
        Me.DtGrid_Classe.Name = "DtGrid_Classe"
        Me.DtGrid_Classe.Size = New System.Drawing.Size(349, 279)
        Me.DtGrid_Classe.TabIndex = 27
        '
        'CB_Natureza
        '
        Me.CB_Natureza.FormattingEnabled = True
        Me.CB_Natureza.Location = New System.Drawing.Point(78, 98)
        Me.CB_Natureza.Name = "CB_Natureza"
        Me.CB_Natureza.Size = New System.Drawing.Size(283, 21)
        Me.CB_Natureza.TabIndex = 37
        '
        'TB_Classe
        '
        Me.TB_Classe.Location = New System.Drawing.Point(79, 134)
        Me.TB_Classe.Name = "TB_Classe"
        Me.TB_Classe.Size = New System.Drawing.Size(282, 20)
        Me.TB_Classe.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Classe"
        '
        'TelaClasse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 518)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Classe)
        Me.Controls.Add(Me.CB_Natureza)
        Me.Controls.Add(Me.TB_Codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabNatureza)
        Me.Controls.Add(Me.DeletarCla)
        Me.Controls.Add(Me.AlterarCla)
        Me.Controls.Add(Me.InserirCla)
        Me.Controls.Add(Me.DtGrid_Classe)
        Me.Name = "TelaClasse"
        Me.Text = "Form1"
        CType(Me.DtGrid_Classe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabNatureza As System.Windows.Forms.Label
    Friend WithEvents DeletarCla As System.Windows.Forms.Button
    Friend WithEvents AlterarCla As System.Windows.Forms.Button
    Friend WithEvents InserirCla As System.Windows.Forms.Button
    Friend WithEvents DtGrid_Classe As System.Windows.Forms.DataGridView
    Friend WithEvents CB_Natureza As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Classe As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
