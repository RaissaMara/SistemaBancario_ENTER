using InstituicaoFinanceira_ENTER.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InstituicaoFinanceira_ENTER
{
    public class ContaBancaria
    {
        private int numeroContaID = 12345;

        public int Id { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string titular, double Saldo)
        {
            Id = numeroContaID++;
            Titular = titular;
            Saldo = saldoInicial;
        }
        public virtual void ExibirDetalhes()
        {
            ContaBancaria.ExibirDetalhes();
            Console.WriteLine($"Conta Bancária: {Id} || Titular: {Titular} || Saldo Disponível: R$ {Saldo:F2}");
        }
    }
    
}
