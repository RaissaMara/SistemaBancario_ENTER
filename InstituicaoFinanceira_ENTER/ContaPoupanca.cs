using InstituicaoFinanceira_ENTER.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoFinanceira_ENTER
{
    public class ContaPoupanca : ContaBancaria, IRendimento
    {
        public double TaxaRendimento { get; private set; }
        public int DiaAniversario { get; private set; }

        public ContaPoupanca(int numeroConta, string titular, double saldoInicial, double TaxaRendimento, int DiaAniversario)
        {
            Id = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
            TaxaRendimento = 0.05; //5%
            DiaAniversario = diaAniversario;
        }
        public double CalcularRendimento(double saldoInicial,double TaxaRendimento)
        {
            return saldoInicial * TaxaRendimento;
        }
        public double CalcularRendimento()
        {
            return saldoInicial * TaxaRendimento;
        }
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($" Dia do Aniversário: {DiaAniversario}");
            Console.WriteLine($" Rendimento Estimado: R$ {CalcularRendimento():F2}");
        }

    }
}
