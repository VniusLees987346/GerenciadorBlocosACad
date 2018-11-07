<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaNatureza
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
        Me.LabNatureza = New System.Windows.Forms.Label
        Me.DeletarNat = New System.Windows.Forms.Button
        Me.AlterarNat = New System.Windows.Forms.Button
        Me.InserirNat = New System.Windows.Forms.Button
        Me.DtGrid_Natureza = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TB_DescNat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TB_Codigo = New System.Windows.Forms.TextBox
        CType(Me.DtGrid_Natureza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabNatureza
        '
        Me.LabNatureza.AutoSize = True
        Me.LabNatureza.Location = New System.Drawing.Point(9, 123)
        Me.LabNatureza.Name = "LabNatureza"
        Me.LabNatureza.Size = New System.Drawing.Size(50, 13)
        Me.LabNatureza.TabIndex = 16
        Me.LabNatureza.Text = "Natureza"
        '
        'DeletarNat
        '
        Me.DeletarNat.Location = New System.Drawing.Point(140, 157)
        Me.DeletarNat.Name = "DeletarNat"
        Me.DeletarNat.Size = New System.Drawing.Size(72, 21)
        Me.DeletarNat.TabIndex = 15
        Me.DeletarNat.Text = "Deletar "
        Me.DeletarNat.UseVisualStyleBackColor = True
        '
        'AlterarNat
        '
        Me.AlterarNat.Location = New System.Drawing.Point(266, 157)
        Me.AlterarNat.Name = "AlterarNat"
        Me.AlterarNat.Size = New System.Drawing.Size(72, 21)
        Me.AlterarNat.TabIndex = 14
        Me.AlterarNat.Text = "Alterar "
        Me.AlterarNat.UseVisualStyleBackColor = True
        '
        'InserirNat
        '
        Me.InserirNat.Location = New System.Drawing.Point(12, 157)
        Me.InserirNat.Name = "InserirNat"
        Me.InserirNat.Size = New System.Drawing.Size(72, 21)
        Me.InserirNat.TabIndex = 12
        Me.InserirNat.Text = "Inserir"
        Me.InserirNat.UseVisualStyleBackColor = True
        '
        'DtGrid_Natureza
        '
        Me.DtGrid_Natureza.AllowUserToAddRows = False
        Me.DtGrid_Natureza.AllowUserToDeleteRows = False
        Me.DtGrid_Natureza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGrid_Natureza.Location = New System.Drawing.Point(12, 202)
        Me.DtGrid_Natureza.Name = "DtGrid_Natureza"
        Me.DtGrid_Natureza.Size = New System.Drawing.Size(326, 316)
        Me.DtGrid_Natureza.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 25)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Pesquisar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 23
        '
        'TB_DescNat
        '
        Me.TB_DescNat.Location = New System.Drawing.Point(79, 120)
        Me.TB_DescNat.Name = "TB_DescNat"
        Me.TB_DescNat.Size = New System.Drawing.Size(259, 20)
        Me.TB_DescNat.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Código "
        '
        'TB_Codigo
        '
        Me.TB_Codigo.Enabled = False
        Me.TB_Codigo.Location = New System.Drawing.Point(79, 85)
        Me.TB_Codigo.Name = "TB_Codigo"
        Me.TB_Codigo.Size = New System.Drawing.Size(133, 20)
        Me.TB_Codigo.TabIndex = 26
        '
        'TelaNatureza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 521)
        Me.Controls.Add(Me.TB_Codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_DescNat)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabNatureza)
        Me.Controls.Add(Me.DeletarNat)
        Me.Controls.Add(Me.AlterarNat)
        Me.Controls.Add(Me.InserirNat)
        Me.Controls.Add(Me.DtGrid_Natureza)
        Me.Name = "TelaNatureza"
        Me.Text = "Controle de Natureza"
        CType(Me.DtGrid_Natureza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabNatureza As System.Windows.Forms.Label
    Friend WithEvents DeletarNat As System.Windows.Forms.Button
    Friend WithEvents AlterarNat As System.Windows.Forms.Button
    Friend WithEvents InserirNat As System.Windows.Forms.Button
    Friend WithEvents DtGrid_Natureza As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_DescNat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_Codigo As System.Windows.Forms.TextBox
End Class
