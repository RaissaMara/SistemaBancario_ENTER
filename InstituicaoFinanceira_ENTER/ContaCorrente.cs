using InstituicaoFinanceira_ENTER.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoFinanceira_ENTER
{
    public class ContaCorrente : ContaBancaria, ITaxaSaque
    {
        public double TaxaSaque { get; private set; }
        public double LimiteChequeEspecial { get; private set; }

        public ContaCorrente(int numeroConta, string titular, double saldoInicial, double TaxaSaque)
        {
            Id = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
            this.TaxaSaque = 0.05; //5%
            LimiteChequeEspecial = 300;
        }

        public double CalcularTaxaSaque(double valorSaque)
        {
            return valorSaque * TaxaSaque;
        }

        public double CalcularTaxaSaque()
        {
            return Saldo * TaxaSaque;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($" Saque + taxa: R$ {CalcularTaxaSaque():F2}");
        }
        
    }
}
