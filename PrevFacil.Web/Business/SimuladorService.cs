namespace PrevFacil.Web.Business
{
    public class SimuladorService
    {
        public decimal SimularSaldoFuturo(decimal valorMensal, int meses, decimal saldoAtual = 0)
        {
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