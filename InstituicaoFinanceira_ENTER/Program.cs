using static InstituicaoFinanceira_ENTER.ContaBancaria;

namespace InstituicaoFinanceira_ENTER
{
  

    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
            Console.Write("\n==InstituicaoFinanceira_ENTER==");
            Console.WriteLine("1 - Abertura de Conta Corrente");
            Console.WriteLine("2 - Abertura de Conta Poupança");
            Console.WriteLine("3 - Abertura de Conta Empresarial");
            Console.WriteLine("4 - Acessar Conta");
            Console.WriteLine("5 - Consultar Extrato");
            Console.WriteLine("6 - Encerrar Contrato");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opcao valida:");

                string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                ContaCorrente Corrente = new ContaCorrente();

                 Console.WriteLine("Informe o nome completo do titular: ");
                 Corrente.Titular = Console.ReadLine();

                 Console.WriteLine("Digite o valor do Depósito inicial: ");
                 Corrente.Saldo = double.Parse(Console.ReadLine());
        
                        Corrente.ExibirDetalhes();
                    break;
                case "2":
                ContaPoupanca Poupanca = new ContaPoupanca();

                 Console.WriteLine("Informe o nome completo do titular: ");
                 Poupanca.Titular = Console.ReadLine();

                 Console.WriteLine("Digite o valor do Depósito inicial: ");
                 Poupanca.Saldo = double.Parse(Console.ReadLine());
        
                        Poupanca.ExibirDetalhes();
                    break;
                case "3":
                ContaEmpresarial Empresarial = new ContaEmpresarial();

                 Console.WriteLine("Informe o nome completo do titular: ");
                 Empresarial.Titular = Console.ReadLine();

                 Console.WriteLine("Digite o valor do Depósito inicial: ");
                 Empresarial.Saldo = double.Parse(Console.ReadLine());
        
                        Empresarial.ExibirDetalhes();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "0":
                    break;
                default:
                    break;

            }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
