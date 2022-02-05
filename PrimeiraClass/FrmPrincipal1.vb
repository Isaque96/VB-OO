Public Class FrmPrincipal1
    Public Sub New()
        InitializeComponent()

        Me.Text = "1 - Primeira Classe"
        LblPrincipal.Text = "Primeira Classe"
        BtnAcao.Text = "Conta da Isabela"
        BtnAcao2.Text = "Conta do Bruno"
        BtnValRef.Text = "Clique Aqui"
    End Sub

    Private Sub BtnAcao_Click(sender As Object, e As EventArgs) Handles BtnAcao.Click
        Dim ContaDaIsabela As New ContaCorrente With {
            .Titular = "Isabela",
            .Agencia = 863,
            .Conta = 863141,
            .Saldo = Val(TxbSaldo.Text)
        }

        MsgBox("O Saldo da Conta da " + ContaDaIsabela.Titular + " na Cc: " + ContaDaIsabela.Agencia.ToString() _
               + " - " + ContaDaIsabela.Conta.ToString() + " é " + ContaDaIsabela.Saldo.ToString())

        Dim Incremento As Double = Val(TxbIncremento.Text)
        ContaDaIsabela.Saldo += Incremento

        MsgBox("O Saldo da Conta da " + ContaDaIsabela.Titular + " na Cc: " + ContaDaIsabela.Agencia.ToString() _
               + " - " + ContaDaIsabela.Conta.ToString() + " é " + ContaDaIsabela.Saldo.ToString())
    End Sub

    Private Sub BtnAcao2_Click(sender As Object, e As EventArgs) Handles BtnAcao2.Click
        Dim ContaDoBruno As New ContaCorrente

        MsgBox(ContaDoBruno.Titular)
        MsgBox(ContaDoBruno.Agencia)
        MsgBox(ContaDoBruno.Conta)
        MsgBox(ContaDoBruno.Saldo)

        ContaDoBruno.Saldo += 100
        MsgBox(ContaDoBruno.Saldo)
    End Sub

    Private Sub BtnValRef_Click(sender As Object, e As EventArgs) Handles BtnValRef.Click
        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade

        MsgBox("O valor da Idade é " + idade.ToString() + " e o valor da Idade2 é " + idade2.ToString())

        idade = 30

        MsgBox("O valor da Idade é " + idade.ToString() + " e o valor da Idade2 é " + idade2.ToString())

        Dim ContaDaGabriela As New ContaCorrente()
        Dim ContaDaGabrielaCosta As New ContaCorrente()

        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        ContaDaGabrielaCosta = ContaDaGabriela

        MsgBox("Valor da Conta da Gabriela " + ContaDaGabriela.Saldo.ToString() + " e da Conta da Gabriela Costa" _
               + ContaDaGabrielaCosta.Saldo.ToString())

        ContaDaGabriela.Saldo = 300
        MsgBox("Valor da Conta da Gabriela " + ContaDaGabriela.Saldo.ToString() + " e da Conta da Gabriela Costa" _
               + ContaDaGabrielaCosta.Saldo.ToString())
    End Sub
End Class
