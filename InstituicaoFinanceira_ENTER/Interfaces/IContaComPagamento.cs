using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoFinanceira_ENTER.Interfaces
{
    internal interface IContaComPagamento
    {
        bool PagarBoleto(string codigo, double valor);
        bool PagarTributo(string guiaImposto, double valor);
        string EmitirBoleto(double valor, string cliente);
        bool RealizarPagamentoLote(List<(double valor, ContaBancaria destino)> lista);
    }
}
