using System;

namespace PrevFacil.Web.Business
{
    public class PlanoPrevidencia
    {
        public string NumeroInscricao { get; set; }
        public string NomePlano { get; set; }
        public decimal SaldoAcumulado { get; set; }
        public decimal ValorContribuicaoMensal { get; set; }
        public DateTime DataAdesao { get; set; }
    }
}