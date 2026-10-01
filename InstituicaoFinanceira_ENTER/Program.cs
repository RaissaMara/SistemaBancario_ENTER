using System;
using System.Collections.Generic;
using InstituicaoFinanceira_ENTER;
using InstituicaoFinanceira_ENTER.Interfaces;

namespace InstituicaoFinanceira_ENTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaAtual = null;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n==InstituicaoFinanceira_ENTER==");
                Console.WriteLine("1 - Abertura de Conta Corrente");
                Console.WriteLine("2 - Abertura de Conta Poupança");
                Console.WriteLine("3 - Abertura de Conta Empresarial");
                Console.WriteLine("4 - Depositar");
                Console.WriteLine("5 - Sacar");
                Console.WriteLine("6 - Consultar Extrato");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opcao valida: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Informe o nome completo do titular: ");
                        string titularC = Console.ReadLine();

                        Console.Write("Digite o valor do depósito inicial: ");
                        double saldoC = double.Parse(Console.ReadLine());

                        contaAtual = new ContaCorrente(titularC, saldoC);
                        contaAtual.ExibirDetalhes();
                        break;

                    case "2":
                        Console.Write("Informe o nome completo do titular: ");
                        string titularP = Console.ReadLine();

                        Console.Write("Digite o valor do depósito inicial: ");
                        double saldoP = double.Parse(Console.ReadLine());

                        contaAtual = new ContaPoupanca(titularP, saldoP);
                        contaAtual.ExibirDetalhes();
                        break;

                    case "3":
                        Console.Write("Informe a razão social da empresa: ");
                        string razaoSocial = Console.ReadLine();

                        Console.Write("Digite o valor do depósito inicial: ");
                        double saldoE = double.Parse(Console.ReadLine());

                        Console.Write("Digite o CNPJ da empresa: ");
                        string cnpj = Console.ReadLine();

                        ContaEmpresarial empresarial = new ContaEmpresarial(razaoSocial, saldoE, cnpj);
                        empresarial.ExibirDetalhes();
                        contaAtual = empresarial;
                        break;

                    case "4": // Depositar
                        if (contaAtual != null)
                        {
                            Console.Write("Digite o valor para depósito: ");
                            double valorDep = double.Parse(Console.ReadLine());
                            contaAtual.Depositar(valorDep);
                            Console.WriteLine("Depósito realizado com sucesso!");
                            contaAtual.ExibirDetalhes();
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma conta ativa. Abra uma conta primeiro.");
                        }
                        break;

                    case "5":
                        if (contaAtual != null)
                        {
                            Console.WriteLine("=== Extrato da Conta ===");
                            foreach (var op in contaAtual.Extrato)
                            {
                                Console.WriteLine(op);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma conta ativa.");
                        }
                        break;


                    case "6":
                        if (contaAtual != null)
                        {
                            Console.WriteLine("=== Extrato da Conta ===");
                            foreach (var op in contaAtual.Extrato)
                            {
                                Console.WriteLine(op);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma conta ativa.");
                        }
                        break;

                    case "0":
                        continuar = false;
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
