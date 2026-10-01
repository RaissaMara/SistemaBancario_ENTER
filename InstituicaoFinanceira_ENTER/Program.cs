namespace InstituicaoFinanceira_ENTER
{

    public enum Saldo
    {
        Corrente,
        Poupanca,
        Empresarial
    }

    class Contrato
    {
        private int numeroContaID = 00345;

        public int Id { get; private set; }
        public string Titular { get; set; }
        public Saldo TipoConta { get; set; }

        public Contrato(string titular, Saldo valor)
        {
            Id = numeroContaID++;
            Titular = titular;
            TipoConta = valor;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nº da Conta:{Id} - Titular:{Titular} - Tipo da Conta:{TipoConta}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> listContratos = new List<Contrato>();

            listContratos.Add(new Contrato("Informe o nome completo", Saldo.Corrente));
            listContratos.Add(new Contrato("Informe o nome completo", Saldo.Poupanca));
            listContratos.Add(new Contrato("Informe o nome completo", Saldo.Empresarial));

            Console.WriteLine("====Abertura de Conta Corrente====");
            var contratosCorrente = listContratos.Where(c => c.TipoConta == Saldo.Corrente);
            foreach (var contrato in contratosCorrente)
            {
                contrato.Exibir();
            }

            Console.WriteLine("Informe o tipo de Conta: ");
            Contrato contrato3 = listContratos.FirstOrDefault(c => c.Id == 3);
            if (contrato3 != null)
            {
                contrato3.Exibir();
            }
            else 
            { 
                Console.WriteLine("Contrato não encontrado"); 
            }


            Console.WriteLine("\n==InstituicaoFinanceira_ENTER==");
            Console.WriteLine("1 - Abertura de Conta");
            Console.WriteLine("2 - Acessar Conta");
            Console.WriteLine("3 - Depositar Valor");
            Console.WriteLine("4 - Consultar Saldo");
            Console.WriteLine("5 - Saque um Valor");
            Console.WriteLine("6 - Consultar Extrato");
            Console.WriteLine("6 - Encerrar Contrato");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opcao valida:");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "0":
                    break;
                default:
                    break;

            }


        }
    }
}
