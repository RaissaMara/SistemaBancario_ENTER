using InstituicaoFinanceira_ENTER.Interfaces;
using System;

namespace InstituicaoFinanceira_ENTER
{
    public class ContaPoupanca : ContaBancaria, IRendimento
    {
        public double TaxaRendimento { get; private set; }
        public int DiaAniversario { get; private set; }

        public ContaPoupanca(string titular, double saldoInicial, double taxaRendimento = 0.05, int diaAniversario = 1)
            : base(titular, saldoInicial)
        {
            TaxaRendimento = taxaRendimento;
            DiaAniversario = diaAniversario;
        }

        public double CalcularRendimento() => Saldo * TaxaRendimento;

        public void AplicarRendimento(int diaAtual)
        {
            if (diaAtual == DiaAniversario)
            {
                double rendimento = CalcularRendimento();
                Depositar(rendimento);
                RegistrarOperacao($"Rendimento aplicado: R$ {rendimento:F2}");
            }
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Dia do Aniversário: {DiaAniversario} || Taxa de Rendimento: {TaxaRendimento * 100}%");
        }
    }
}
