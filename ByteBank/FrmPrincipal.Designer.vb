<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.LblPrincipal = New System.Windows.Forms.Label()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.TxbValor = New System.Windows.Forms.TextBox()
        Me.BtnSacar = New System.Windows.Forms.Button()
        Me.TxbSaldo = New System.Windows.Forms.TextBox()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.TxbResultado = New System.Windows.Forms.TextBox()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.TxbSaldoAtual = New System.Windows.Forms.TextBox()
        Me.LblSaldoAtual = New System.Windows.Forms.Label()
        Me.LblBemVindo = New System.Windows.Forms.Label()
        Me.BtnDepositar = New System.Windows.Forms.Button()
        Me.TxbExtrato = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnNomeGabriela = New System.Windows.Forms.Button()
        Me.TxbNomeGabriela = New System.Windows.Forms.TextBox()
        Me.LblNomeGabriela = New System.Windows.Forms.Label()
        Me.BtnTransferir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNomeBruno = New System.Windows.Forms.Button()
        Me.TxbNomeBruno = New System.Windows.Forms.TextBox()
        Me.LblNomeBruno = New System.Windows.Forms.Label()
        Me.BtnTransferir2 = New System.Windows.Forms.Button()
        Me.TxbExtrato2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDepositar2 = New System.Windows.Forms.Button()
        Me.TxbValor2 = New System.Windows.Forms.TextBox()
        Me.LblBemVindo2 = New System.Windows.Forms.Label()
        Me.BtnSacar2 = New System.Windows.Forms.Button()
        Me.TxbSaldoAtual2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbSaldo2 = New System.Windows.Forms.TextBox()
        Me.TxbResultado2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblNumeroClientes = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPrincipal
        '
        Me.LblPrincipal.AutoSize = True
        Me.LblPrincipal.Location = New System.Drawing.Point(9, 9)
        Me.LblPrincipal.Name = "LblPrincipal"
        Me.LblPrincipal.Size = New System.Drawing.Size(128, 13)
        Me.LblPrincipal.TabIndex = 0
        Me.LblPrincipal.Text = "2 - Byte Bank - Formulário"
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.Location = New System.Drawing.Point(10, 108)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(31, 13)
        Me.LblValor.TabIndex = 1
        Me.LblValor.Text = "Valor"
        '
        'TxbValor
        '
        Me.TxbValor.Location = New System.Drawing.Point(13, 124)
        Me.TxbValor.Name = "TxbValor"
        Me.TxbValor.Size = New System.Drawing.Size(185, 20)
        Me.TxbValor.TabIndex = 2
        '
        'BtnSacar
        '
        Me.BtnSacar.Location = New System.Drawing.Point(13, 180)
        Me.BtnSacar.Name = "BtnSacar"
        Me.BtnSacar.Size = New System.Drawing.Size(121, 23)
        Me.BtnSacar.TabIndex = 3
        Me.BtnSacar.Text = "Efetuar Saque"
        Me.BtnSacar.UseVisualStyleBackColor = True
        '
        'TxbSaldo
        '
        Me.TxbSaldo.Location = New System.Drawing.Point(13, 262)
        Me.TxbSaldo.Name = "TxbSaldo"
        Me.TxbSaldo.ReadOnly = True
        Me.TxbSaldo.Size = New System.Drawing.Size(185, 20)
        Me.TxbSaldo.TabIndex = 5
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.Location = New System.Drawing.Point(10, 246)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(63, 13)
        Me.LblSaldo.TabIndex = 4
        Me.LblSaldo.Text = "Novo Saldo"
        '
        'TxbResultado
        '
        Me.TxbResultado.Location = New System.Drawing.Point(13, 305)
        Me.TxbResultado.Name = "TxbResultado"
        Me.TxbResultado.ReadOnly = True
        Me.TxbResultado.Size = New System.Drawing.Size(185, 20)
        Me.TxbResultado.TabIndex = 7
        '
        'LblResultado
        '
        Me.LblResultado.AutoSize = True
        Me.LblResultado.Location = New System.Drawing.Point(10, 289)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(55, 13)
        Me.LblResultado.TabIndex = 6
        Me.LblResultado.Text = "Resultado"
        '
        'TxbSaldoAtual
        '
        Me.TxbSaldoAtual.Location = New System.Drawing.Point(13, 69)
        Me.TxbSaldoAtual.Name = "TxbSaldoAtual"
        Me.TxbSaldoAtual.ReadOnly = True
        Me.TxbSaldoAtual.Size = New System.Drawing.Size(185, 20)
        Me.TxbSaldoAtual.TabIndex = 9
        '
        'LblSaldoAtual
        '
        Me.LblSaldoAtual.AutoSize = True
        Me.LblSaldoAtual.Location = New System.Drawing.Point(10, 53)
        Me.LblSaldoAtual.Name = "LblSaldoAtual"
        Me.LblSaldoAtual.Size = New System.Drawing.Size(61, 13)
        Me.LblSaldoAtual.TabIndex = 8
        Me.LblSaldoAtual.Text = "Saldo Atual"
        '
        'LblBemVindo
        '
        Me.LblBemVindo.AutoSize = True
        Me.LblBemVindo.Location = New System.Drawing.Point(10, 24)
        Me.LblBemVindo.Name = "LblBemVindo"
        Me.LblBemVindo.Size = New System.Drawing.Size(85, 13)
        Me.LblBemVindo.TabIndex = 10
        Me.LblBemVindo.Text = "UsuárioDaConta"
        '
        'BtnDepositar
        '
        Me.BtnDepositar.Location = New System.Drawing.Point(13, 151)
        Me.BtnDepositar.Name = "BtnDepositar"
        Me.BtnDepositar.Size = New System.Drawing.Size(121, 23)
        Me.BtnDepositar.TabIndex = 11
        Me.BtnDepositar.Text = "Efetuar Depósito"
        Me.BtnDepositar.UseVisualStyleBackColor = True
        '
        'TxbExtrato
        '
        Me.TxbExtrato.Location = New System.Drawing.Point(204, 108)
        Me.TxbExtrato.Multiline = True
        Me.TxbExtrato.Name = "TxbExtrato"
        Me.TxbExtrato.ReadOnly = True
        Me.TxbExtrato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbExtrato.Size = New System.Drawing.Size(159, 217)
        Me.TxbExtrato.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnNomeGabriela)
        Me.GroupBox1.Controls.Add(Me.TxbNomeGabriela)
        Me.GroupBox1.Controls.Add(Me.LblNomeGabriela)
        Me.GroupBox1.Controls.Add(Me.BtnTransferir)
        Me.GroupBox1.Controls.Add(Me.TxbExtrato)
        Me.GroupBox1.Controls.Add(Me.LblValor)
        Me.GroupBox1.Controls.Add(Me.BtnDepositar)
        Me.GroupBox1.Controls.Add(Me.TxbValor)
        Me.GroupBox1.Controls.Add(Me.LblBemVindo)
        Me.GroupBox1.Controls.Add(Me.BtnSacar)
        Me.GroupBox1.Controls.Add(Me.TxbSaldoAtual)
        Me.GroupBox1.Controls.Add(Me.LblSaldo)
        Me.GroupBox1.Controls.Add(Me.LblSaldoAtual)
        Me.GroupBox1.Controls.Add(Me.TxbSaldo)
        Me.GroupBox1.Controls.Add(Me.TxbResultado)
        Me.GroupBox1.Controls.Add(Me.LblResultado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 360)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1ª Conta"
        '
        'BtnNomeGabriela
        '
        Me.BtnNomeGabriela.Location = New System.Drawing.Point(301, 69)
        Me.BtnNomeGabriela.Name = "BtnNomeGabriela"
        Me.BtnNomeGabriela.Size = New System.Drawing.Size(66, 20)
        Me.BtnNomeGabriela.TabIndex = 16
        Me.BtnNomeGabriela.Text = "..."
        Me.BtnNomeGabriela.UseVisualStyleBackColor = True
        '
        'TxbNomeGabriela
        '
        Me.TxbNomeGabriela.Location = New System.Drawing.Point(205, 69)
        Me.TxbNomeGabriela.Name = "TxbNomeGabriela"
        Me.TxbNomeGabriela.Size = New System.Drawing.Size(90, 20)
        Me.TxbNomeGabriela.TabIndex = 15
        '
        'LblNomeGabriela
        '
        Me.LblNomeGabriela.AutoSize = True
        Me.LblNomeGabriela.Location = New System.Drawing.Point(201, 53)
        Me.LblNomeGabriela.Name = "LblNomeGabriela"
        Me.LblNomeGabriela.Size = New System.Drawing.Size(35, 13)
        Me.LblNomeGabriela.TabIndex = 14
        Me.LblNomeGabriela.Text = "Nome"
        '
        'BtnTransferir
        '
        Me.BtnTransferir.Location = New System.Drawing.Point(13, 209)
        Me.BtnTransferir.Name = "BtnTransferir"
        Me.BtnTransferir.Size = New System.Drawing.Size(121, 23)
        Me.BtnTransferir.TabIndex = 13
        Me.BtnTransferir.Text = "Efetuar Transferência"
        Me.BtnTransferir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNomeBruno)
        Me.GroupBox2.Controls.Add(Me.TxbNomeBruno)
        Me.GroupBox2.Controls.Add(Me.LblNomeBruno)
        Me.GroupBox2.Controls.Add(Me.BtnTransferir2)
        Me.GroupBox2.Controls.Add(Me.TxbExtrato2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BtnDepositar2)
        Me.GroupBox2.Controls.Add(Me.TxbValor2)
        Me.GroupBox2.Controls.Add(Me.LblBemVindo2)
        Me.GroupBox2.Controls.Add(Me.BtnSacar2)
        Me.GroupBox2.Controls.Add(Me.TxbSaldoAtual2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxbSaldo2)
        Me.GroupBox2.Controls.Add(Me.TxbResultado2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 360)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2ª Conta"
        '
        'BtnNomeBruno
        '
        Me.BtnNomeBruno.Location = New System.Drawing.Point(300, 69)
        Me.BtnNomeBruno.Name = "BtnNomeBruno"
        Me.BtnNomeBruno.Size = New System.Drawing.Size(66, 20)
        Me.BtnNomeBruno.TabIndex = 18
        Me.BtnNomeBruno.Text = "..."
        Me.BtnNomeBruno.UseVisualStyleBackColor = True
        '
        'TxbNomeBruno
        '
        Me.TxbNomeBruno.Location = New System.Drawing.Point(204, 69)
        Me.TxbNomeBruno.Name = "TxbNomeBruno"
        Me.TxbNomeBruno.Size = New System.Drawing.Size(90, 20)
        Me.TxbNomeBruno.TabIndex = 17
        '
        'LblNomeBruno
        '
        Me.LblNomeBruno.AutoSize = True
        Me.LblNomeBruno.Location = New System.Drawing.Point(201, 53)
        Me.LblNomeBruno.Name = "LblNomeBruno"
        Me.LblNomeBruno.Size = New System.Drawing.Size(35, 13)
        Me.LblNomeBruno.TabIndex = 15
        Me.LblNomeBruno.Text = "Nome"
        '
        'BtnTransferir2
        '
        Me.BtnTransferir2.Location = New System.Drawing.Point(13, 209)
        Me.BtnTransferir2.Name = "BtnTransferir2"
        Me.BtnTransferir2.Size = New System.Drawing.Size(117, 23)
        Me.BtnTransferir2.TabIndex = 13
        Me.BtnTransferir2.Text = "Efetuar Transferência"
        Me.BtnTransferir2.UseVisualStyleBackColor = True
        '
        'TxbExtrato2
        '
        Me.TxbExtrato2.Location = New System.Drawing.Point(204, 108)
        Me.TxbExtrato2.Multiline = True
        Me.TxbExtrato2.Name = "TxbExtrato2"
        Me.TxbExtrato2.ReadOnly = True
        Me.TxbExtrato2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbExtrato2.Size = New System.Drawing.Size(159, 217)
        Me.TxbExtrato2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor"
        '
        'BtnDepositar2
        '
        Me.BtnDepositar2.Location = New System.Drawing.Point(13, 151)
        Me.BtnDepositar2.Name = "BtnDepositar2"
        Me.BtnDepositar2.Size = New System.Drawing.Size(117, 23)
        Me.BtnDepositar2.TabIndex = 11
        Me.BtnDepositar2.Text = "Efetuar Depósito"
        Me.BtnDepositar2.UseVisualStyleBackColor = True
        '
        'TxbValor2
        '
        Me.TxbValor2.Location = New System.Drawing.Point(13, 124)
        Me.TxbValor2.Name = "TxbValor2"
        Me.TxbValor2.Size = New System.Drawing.Size(185, 20)
        Me.TxbValor2.TabIndex = 2
        '
        'LblBemVindo2
        '
        Me.LblBemVindo2.AutoSize = True
        Me.LblBemVindo2.Location = New System.Drawing.Point(10, 24)
        Me.LblBemVindo2.Name = "LblBemVindo2"
        Me.LblBemVindo2.Size = New System.Drawing.Size(85, 13)
        Me.LblBemVindo2.TabIndex = 10
        Me.LblBemVindo2.Text = "UsuárioDaConta"
        '
        'BtnSacar2
        '
        Me.BtnSacar2.Location = New System.Drawing.Point(13, 180)
        Me.BtnSacar2.Name = "BtnSacar2"
        Me.BtnSacar2.Size = New System.Drawing.Size(117, 23)
        Me.BtnSacar2.TabIndex = 3
        Me.BtnSacar2.Text = "Efetuar Saque"
        Me.BtnSacar2.UseVisualStyleBackColor = True
        '
        'TxbSaldoAtual2
        '
        Me.TxbSaldoAtual2.Location = New System.Drawing.Point(13, 69)
        Me.TxbSaldoAtual2.Name = "TxbSaldoAtual2"
        Me.TxbSaldoAtual2.ReadOnly = True
        Me.TxbSaldoAtual2.Size = New System.Drawing.Size(185, 20)
        Me.TxbSaldoAtual2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Novo Saldo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Saldo Atual"
        '
        'TxbSaldo2
        '
        Me.TxbSaldo2.Location = New System.Drawing.Point(13, 262)
        Me.TxbSaldo2.Name = "TxbSaldo2"
        Me.TxbSaldo2.ReadOnly = True
        Me.TxbSaldo2.Size = New System.Drawing.Size(185, 20)
        Me.TxbSaldo2.TabIndex = 5
        '
        'TxbResultado2
        '
        Me.TxbResultado2.Location = New System.Drawing.Point(13, 305)
        Me.TxbResultado2.Name = "TxbResultado2"
        Me.TxbResultado2.ReadOnly = True
        Me.TxbResultado2.Size = New System.Drawing.Size(185, 20)
        Me.TxbResultado2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Resultado"
        '
        'LblNumeroClientes
        '
        Me.LblNumeroClientes.AutoSize = True
        Me.LblNumeroClientes.Location = New System.Drawing.Point(409, 9)
        Me.LblNumeroClientes.Name = "LblNumeroClientes"
        Me.LblNumeroClientes.Size = New System.Drawing.Size(99, 13)
        Me.LblNumeroClientes.TabIndex = 15
        Me.LblNumeroClientes.Text = "Numero de Clientes"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 437)
        Me.Controls.Add(Me.LblNumeroClientes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblPrincipal)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Byte Bank"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPrincipal As Label
    Friend WithEvents LblValor As Label
    Friend WithEvents TxbValor As TextBox
    Friend WithEvents BtnSacar As Button
    Friend WithEvents TxbSaldo As TextBox
    Friend WithEvents LblSaldo As Label
    Friend WithEvents TxbResultado As TextBox
    Friend WithEvents LblResultado As Label
    Friend WithEvents TxbSaldoAtual As TextBox
    Friend WithEvents LblSaldoAtual As Label
    Friend WithEvents LblBemVindo As Label
    Friend WithEvents BtnDepositar As Button
    Friend WithEvents TxbExtrato As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxbExtrato2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDepositar2 As Button
    Friend WithEvents TxbValor2 As TextBox
    Friend WithEvents LblBemVindo2 As Label
    Friend WithEvents BtnSacar2 As Button
    Friend WithEvents TxbSaldoAtual2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbSaldo2 As TextBox
    Friend WithEvents TxbResultado2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnTransferir As Button
    Friend WithEvents BtnTransferir2 As Button
    Friend WithEvents TxbNomeGabriela As TextBox
    Friend WithEvents LblNomeGabriela As Label
    Friend WithEvents LblNomeBruno As Label
    Friend WithEvents BtnNomeGabriela As Button
    Friend WithEvents BtnNomeBruno As Button
    Friend WithEvents TxbNomeBruno As TextBox
    Friend WithEvents LblNumeroClientes As Label
End Class
