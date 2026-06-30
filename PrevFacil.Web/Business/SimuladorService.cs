using System;

namespace PrevFacil.Web.Business
{
    public class SimuladorService
    {
        public decimal SimularSaldoFuturo(decimal valorMensal, int meses, decimal saldoAtual = 0)
        {
            if (valorMensal < 0)
                throw new ArgumentException("O valor mensal não pode ser negativo.", nameof(valorMensal));

            if (meses < 0)
                throw new ArgumentException("O número de meses não pode ser negativo.", nameof(meses));

            decimal taxaJurosMensal = 0.005m;
            decimal total = saldoAtual;

            for (int i = 0; i < meses; i++)
            {
                total = (total + valorMensal) * (1 + taxaJurosMensal);
            }

            return total;
        }
    }
}