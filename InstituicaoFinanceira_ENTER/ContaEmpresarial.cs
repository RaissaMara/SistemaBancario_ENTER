using InstituicaoFinanceira_ENTER.Interfaces;
using System;
using System.Collections.Generic;

namespace InstituicaoFinanceira_ENTER
{
    public class ContaEmpresarial : ContaBancaria, IContaComPagamento
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double LimiteChequeEspecial { get; private set; }

        public ContaEmpresarial(string razaoSocial, double saldoInicial, string cnpj)
            : base(razaoSocial, saldoInicial)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            LimiteChequeEspecial = 1000;
        }

        public bool PagarBoleto(string codigo, double valor)
        {
            bool sucesso = Sacar(valor);
            RegistrarOperacao(sucesso
                ? $"Boleto {codigo} pago no valor de R$ {valor:F2}"
                : $"Falha ao pagar boleto {codigo}");
            return sucesso;
        }

        public bool PagarTributo(string guiaImposto, double valor)
        {
            bool sucesso = Sacar(valor);
            RegistrarOperacao(sucesso
                ? $"Tributo {guiaImposto} pago no valor de R$ {valor:F2}"
                : $"Falha ao pagar tributo {guiaImposto}");
            return sucesso;
        }

        public string EmitirBoleto(double valor, string cliente)
        {
            string codigo = $"BOLETO-{cliente}-{DateTime.Now.Ticks}";
            RegistrarOperacao($"Boleto emitido para {cliente} no valor de R$ {valor:F2} (Código: {codigo})");
            return codigo;
        }

        public bool RealizarPagamentoLote(List<(double valor, ContaBancaria destino)> lista)
        {
            foreach (var pagamento in lista)
            {
                if (!Sacar(pagamento.valor))
                {
                    RegistrarOperacao("Falha em pagamento em lote.");
                    return false;
                }
                pagamento.destino.Depositar(pagamento.valor);
                RegistrarOperacao($"Pagamento em lote realizado: R$ {pagamento.valor:F2} para {pagamento.destino.Titular}");
            }
            return true;
        }
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Razão Social: {RazaoSocial} || CNPJ: {Cnpj} || Limite Cheque Especial: R$ {LimiteChequeEspecial:F2}");
        }
    }
}
