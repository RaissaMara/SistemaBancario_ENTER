using InstituicaoFinanceira_ENTER.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoFinanceira_ENTER
{
    public class ContaEmpresarial : ContaBancaria, IContaComPagamento
    {


        public double PagarTributo() //guia de imposto DAS para subtrair do saldo
        {

        }

        //limiteExtra += limiteDisponivel;
    }
}
