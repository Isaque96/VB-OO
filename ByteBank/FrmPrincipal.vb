Imports ByteBank.ByteBank

Public Class FrmPrincipal
    Dim ContaDaGabriela As New ContaCorrente(100)
    Dim ContaDoBruno As New ContaCorrente(500)
    Dim Bruno As New Cliente("Bruno", "10987654321")
    Dim Gabriela As New Cliente("Gabriela", "12345678910")

    Public Sub New()
        InitializeComponent()

        'Inicializando Conta da Gabriela
        Gabriela.Cidade = "São Paulo"
        Gabriela.Profissao = "Desenvolvedor"

        ContaDaGabriela.Titular = Gabriela
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        ContaDaGabriela.Saldo = -100

        LblBemVindo.Text = "Bem Vindo " + ContaDaGabriela.Titular.Nome + " / Ag: " + ContaDaGabriela.Agencia.ToString() _
            + " / Cc: " + ContaDaGabriela.Conta.ToString() + " CPF: " + ContaDaGabriela.Titular.CPF
        TxbSaldoAtual.Text = ContaDaGabriela.Saldo.ToString()

        'Inicializando a Conta do Bruno
        Bruno.Cidade = "Rio de Janeiro"
        Bruno.Profissao = "Setor Administrativo"

        ContaDoBruno.Titular = Bruno
        ContaDoBruno.Agencia = 863
        ContaDoBruno.Conta = 863224

        LblBemVindo2.Text = "Bem Vindo " + ContaDoBruno.Titular.Nome + " / Ag: " + ContaDoBruno.Agencia.ToString() _
            + " / Cc: " + ContaDoBruno.Conta.ToString() + " CPF: " + ContaDoBruno.Titular.CPF
        TxbSaldoAtual2.Text = ContaDoBruno.Saldo.ToString()

        LblNumeroClientes.Text = "Número total de Clientes Cadastrados no Banco é: " + Cliente.NumerosClientes.ToString()
    End Sub

    Private Sub BtnSacar_Click(sender As Object, e As EventArgs) Handles BtnSacar.Click
        TxbResultado.Text = String.Empty
        TxbSaldo.Text = String.Empty

        Dim ValorSacar As Double = Val(TxbValor.Text)
        Dim RetornoSaque As Boolean = ContaDaGabriela.Sacar(ValorSacar)

        If Not RetornoSaque Then
            TxbResultado.Text = "Saldo Insuficiente"
        Else
            TxbSaldo.Text = ContaDaGabriela.Saldo.ToString()
            TxbResultado.Text = "Saque Efetuado com Sucesso"
            ContaDaGabriela.Extrato += Now.ToString() + " - Saque de " + ValorSacar.ToString() + " reais Saldo: R$ " +
                ContaDaGabriela.Saldo.ToString() + vbCrLf
        End If

        TxbExtrato.Text = ContaDaGabriela.Extrato
        TxbSaldoAtual.Text = TxbSaldo.Text
    End Sub

    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles BtnDepositar.Click
        TxbResultado.Text = String.Empty
        TxbSaldo.Text = String.Empty

        Dim ValorDeposito As Double = Val(TxbValor.Text)
        ContaDaGabriela.Depositar(ValorDeposito)

        TxbSaldo.Text = ContaDaGabriela.Saldo.ToString()
        TxbResultado.Text = "Depósito Efetuado com Sucesso"
        TxbSaldoAtual.Text = TxbSaldo.Text
        ContaDaGabriela.Extrato += Now.ToString() + " - Depósito de " + ValorDeposito.ToString() + " reais Saldo: R$ " +
                ContaDaGabriela.Saldo.ToString() + vbCrLf
        TxbExtrato.Text = ContaDaGabriela.Extrato
    End Sub

    Private Sub BtnDepositar2_Click(sender As Object, e As EventArgs) Handles BtnDepositar2.Click
        TxbResultado2.Text = String.Empty
        TxbSaldo2.Text = String.Empty

        Dim ValorDeposito As Double = Val(TxbValor2.Text)
        ContaDoBruno.Depositar(ValorDeposito)

        TxbSaldo2.Text = ContaDoBruno.Saldo.ToString()
        TxbResultado2.Text = "Depósito Efetuado com Sucesso"
        TxbSaldoAtual2.Text = TxbSaldo.Text
        ContaDoBruno.Extrato += Now.ToString() + " - Depósito de " + ValorDeposito.ToString() + " reais Saldo: R$ " +
                ContaDoBruno.Saldo.ToString() + vbCrLf
        TxbExtrato2.Text = ContaDoBruno.Extrato
    End Sub

    Private Sub BtnSacar2_Click(sender As Object, e As EventArgs) Handles BtnSacar2.Click
        TxbResultado2.Text = String.Empty
        TxbSaldo2.Text = String.Empty

        Dim ValorSacar As Double = Val(TxbValor2.Text)
        Dim RetornoSaque As Boolean = ContaDoBruno.Sacar(ValorSacar)

        If Not RetornoSaque Then
            TxbResultado2.Text = "Saldo Insuficiente"
        Else
            TxbSaldo2.Text = ContaDoBruno.Saldo.ToString()
            TxbResultado2.Text = "Saque Efetuado com Sucesso"
            ContaDoBruno.Extrato += Now.ToString() + " - Saque de " + ValorSacar.ToString() + " reais Saldo: R$ " +
                ContaDoBruno.Saldo.ToString() + vbCrLf
        End If

        TxbExtrato2.Text = ContaDoBruno.Extrato
        TxbSaldoAtual2.Text = TxbSaldo2.Text
    End Sub

    Private Sub BtnTransferir_Click(sender As Object, e As EventArgs) Handles BtnTransferir.Click
        TxbResultado.Text = String.Empty
        TxbSaldo.Text = String.Empty

        Dim ValorTransferencia As Double = Val(TxbValor.Text)
        Dim RetornoTransferencia As Boolean = ContaDaGabriela.Transferir(ValorTransferencia, ContaDoBruno)

        If Not RetornoTransferencia Then
            TxbResultado.Text = "Não foi possível Transferir"
        Else
            TxbSaldo.Text = ContaDaGabriela.Saldo.ToString()
            TxbSaldo2.Text = ContaDoBruno.Saldo.ToString()

            TxbResultado.Text = "Transferência efetuada com Sucesso"
            TxbSaldoAtual.Text = TxbSaldo.Text
            TxbSaldoAtual2.Text = TxbSaldo2.Text

            ContaDaGabriela.Extrato += Now.ToString() + " - Transferência de " + ValorTransferencia.ToString() +
                " reais Saldo: R$ " + ContaDaGabriela.Saldo.ToString() + vbCrLf

            ContaDoBruno.Extrato += Now.ToString() + " - Transferência de " + ValorTransferencia.ToString() +
                " reais Saldo: R$ " + ContaDoBruno.Saldo.ToString() + vbCrLf
        End If

        TxbExtrato.Text = ContaDaGabriela.Extrato
        TxbExtrato2.Text = ContaDoBruno.Extrato
    End Sub

    Private Sub BtnTransferir2_Click(sender As Object, e As EventArgs) Handles BtnTransferir2.Click
        TxbResultado2.Text = String.Empty
        TxbSaldo2.Text = String.Empty

        Dim ValorTransferencia As Double = Val(TxbValor2.Text)
        Dim RetornoTransferencia As Boolean = ContaDoBruno.Transferir(ValorTransferencia, ContaDaGabriela)

        If Not RetornoTransferencia Then
            TxbResultado2.Text = "Não foi possível Transferir"
        Else
            TxbSaldo.Text = ContaDaGabriela.Saldo.ToString()
            TxbSaldo2.Text = ContaDoBruno.Saldo.ToString()

            TxbResultado2.Text = "Transferência efetuada com Sucesso"
            TxbSaldoAtual.Text = TxbSaldo.Text
            TxbSaldoAtual2.Text = TxbSaldo2.Text

            ContaDaGabriela.Extrato += Now.ToString() + " - Transferência de " + ValorTransferencia.ToString() +
                " reais Saldo: R$ " + ContaDaGabriela.Saldo.ToString() + vbCrLf

            ContaDoBruno.Extrato += Now.ToString() + " - Transferência de " + ValorTransferencia.ToString() +
                " reais Saldo: R$ " + ContaDoBruno.Saldo.ToString() + vbCrLf
        End If

        TxbExtrato.Text = ContaDaGabriela.Extrato
        TxbExtrato2.Text = ContaDoBruno.Extrato
    End Sub

    Private Sub BtnNomeGabriela_Click(sender As Object, e As EventArgs) Handles BtnNomeGabriela.Click
        Dim Nome As String = TxbNomeGabriela.Text
        Gabriela.Nome = Nome

        LblBemVindo.Text = "Bem Vindo " + ContaDaGabriela.Titular.Nome + " / Ag: " + ContaDaGabriela.Agencia.ToString() _
            + " / Cc: " + ContaDaGabriela.Conta.ToString()
    End Sub

    Private Sub BtnNomeBruno_Click(sender As Object, e As EventArgs) Handles BtnNomeBruno.Click
        Dim Nome As String = TxbNomeBruno.Text
        Bruno.Nome = Nome

        LblBemVindo.Text = "Bem Vindo " + ContaDoBruno.Titular.Nome + " / Ag: " + ContaDoBruno.Agencia.ToString() _
            + " / Cc: " + ContaDoBruno.Conta.ToString()
    End Sub
End Class
