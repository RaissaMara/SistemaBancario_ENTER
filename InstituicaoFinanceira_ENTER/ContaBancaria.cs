using System;
using System.Collections.Generic;

namespace InstituicaoFinanceira_ENTER
{
    public class ContaBancaria
    {
        private static int numeroContaID = 12345;

        public int Id { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public List<string> Extrato { get; private set; } = new List<string>();

        public ContaBancaria(string titular, double saldoInicial)
        {
            Id = numeroContaID++;
            Titular = titular;
            Saldo = saldoInicial;
            RegistrarOperacao($"Conta criada para {Titular} com saldo inicial de R$ {saldoInicial:F2}");
        }

        public void RegistrarOperacao(string operacao)
        {
            Extrato.Add($"{DateTime.Now}: {operacao}");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                RegistrarOperacao($"Depósito de R$ {valor:F2} realizado.");
            }
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                RegistrarOperacao($"Saque de R$ {valor:F2} realizado.");
                return true;
            }
            RegistrarOperacao($"Tentativa de saque de R$ {valor:F2} falhou (saldo insuficiente).");
            return false;
        }

        public double ConsultarSaldo() => Saldo;

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Conta Bancária: {Id} || Titular: {Titular} || Saldo Disponível: R$ {Saldo:F2}");
        }
    }
}
