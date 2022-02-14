﻿Imports ByteBank.ByteBank

Class ContaCorrente
#Region "Construtores"
    Public Sub New(n_Saldo As Double)
        Saldo = n_Saldo
    End Sub
#End Region
#Region "Propriedades"
    Public Property Extrato As String
    Public Property Conta As Integer
    Public Property Agencia As Integer

    Private m_Titular As Cliente
    Public Property Titular As Cliente
        Get
            Return m_Titular
        End Get
        Set(value As Cliente)
            m_Titular = value
        End Set
    End Property

    Private m_Saldo As Double = 100
    Public Property Saldo As Double
        Get
            Return m_Saldo
        End Get
        Set(value As Double)
            If value < 0 Then
                m_Saldo = 0
            Else
                m_Saldo = value
            End If
        End Set
    End Property
#End Region

#Region "Métodos"
    Public Function Sacar(ValorSacar As Double) As Boolean
        Dim Retorno As Boolean

        If m_Saldo < ValorSacar Then
            Retorno = False
        Else
            m_Saldo -= ValorSacar
            Retorno = True
        End If

        Return Retorno
    End Function

    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean
        Dim Retorno As Boolean

        If m_Saldo <= ValorTransferencia Then
            Retorno = False
        Else
            m_Saldo -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If

        Return Retorno
    End Function

    Public Sub Depositar(ValorDepositar As Double)
        m_Saldo += ValorDepositar
    End Sub

    'Public Sub SetSaldo(SaldoInicial As Double)
    '    If SaldoInicial < 0 Then
    '        m_Saldo = 0
    '    Else
    '        m_Saldo = SaldoInicial
    '    End If

    '    m_Saldo = SaldoInicial
    'End Sub

    'Public Function GetSaldo() As Double
    '    Return m_Saldo
    'End Function
#End Region

End Class