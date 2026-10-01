using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoFinanceira_ENTER.Interfaces
{
    internal interface IRendimento
    {
        double CalcularRendimento();
        void AplicarRendimento(int diaAtual);
    }
}
