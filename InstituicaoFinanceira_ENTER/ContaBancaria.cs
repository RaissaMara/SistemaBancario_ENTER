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

        public ContaBancaria(string titular, Saldo deposito)
        { 
            Id = numeroContaID++;
            Titular = titular;
            Saldo = deposito;
        }
        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Conta Bancária: {Id} || Titular: {Titular} || Saldo Disponível: R$ {Saldo:F2}");
        }

        public class ContaCorrente: ContaBancaria, ITaxaSaque 
        { 
        
            public double CalcularTaxaSaque()
            {
                return (Saque * taxaSaque) - Saldo;
                //Saldo--;
            }

            public override void ExibirDetalhes()
            {
                    base.ExibirDetalhes();
                Console.WriteLine($" Saque + taxa: R$ {CalcularTaxaSaque:F2}");
            }
        }

        public class ContaPoupanca: ContaBancaria, IRendimento 
        {
        
            public double CalcularRendimento()
            {
                return (Saldo * TaxaRendimento);
                //Saldo++;
            }


        }

        public class ContaEmpresarial: ContaBancaria, IContaComPagamento 
        {
            public double PagarTributo() //guia de imposto DAS para subtrair do saldo
            {
            
            }

            //limiteExtra += limiteDisponivel;

        }


    }
}
