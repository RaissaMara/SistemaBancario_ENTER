using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoFinanceira_ENTER.Interfaces
{
    internal interface ITaxaSaque
    {
        double CalcularTaxaSaque(double valorSaque);
    }
}
