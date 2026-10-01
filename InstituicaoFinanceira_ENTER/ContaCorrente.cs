using InstituicaoFinanceira_ENTER.Interfaces;
using System;

namespace InstituicaoFinanceira_ENTER
{
    public class ContaCorrente : ContaBancaria, ITaxaSaque
    {
        public double TaxaSaque { get; private set; }
        public double LimiteChequeEspecial { get; private set; }

        public ContaCorrente(string titular, double saldoInicial, double taxaSaque = 0.05)
            : base(titular, saldoInicial)
        {
            TaxaSaque = taxaSaque;
            LimiteChequeEspecial = 300;
        }

        public double CalcularTaxaSaque(double valorSaque) => valorSaque * TaxaSaque;

        public override bool Sacar(double valor)
        {
            double taxa = CalcularTaxaSaque(valor);
            double valorTotal = valor + taxa;

            if (Saldo >= valorTotal)
            {
                return base.Sacar(valorTotal);
            }
            else if ((Saldo + LimiteChequeEspecial) >= valorTotal)
            {
                double restante = valorTotal - Saldo;
                base.Sacar(Saldo);
                LimiteChequeEspecial -= restante;
                RegistrarOperacao($"Uso do cheque especial: R$ {restante:F2}");
                return true;
            }
            return false;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Taxa de Saque: {TaxaSaque * 100}% || Limite Cheque Especial: R$ {LimiteChequeEspecial:F2}");
        }
    }
}
