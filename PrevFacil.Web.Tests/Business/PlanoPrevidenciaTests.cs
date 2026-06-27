using NUnit.Framework;
using PrevFacil.Web.Business;
using System;

namespace PrevFacil.Web.Tests.Business
{
    [TestFixture]
    public class PlanoPrevidenciaTests
    {
        [Test]
        public void PlanoPrevidencia_NovoObjeto_DeveTerPropriedadesPadrao()
        {
            var plano = new PlanoPrevidencia();

            Assert.Multiple(() =>
            {
                Assert.That(plano.NumeroInscricao, Is.Null);
                Assert.That(plano.NomePlano, Is.Null);
                Assert.That(plano.SaldoAcumulado, Is.EqualTo(0m));
                Assert.That(plano.ValorContribuicaoMensal, Is.EqualTo(0m));
                Assert.That(plano.DataAdesao, Is.EqualTo(DateTime.MinValue));
            });
        }

        [Test]
        public void PlanoPrevidencia_DefinirPropriedades_DeveArmazenarCorretamente()
        {
            var plano = new PlanoPrevidencia
            {
                NumeroInscricao = "1913.045.882",
                NomePlano = "Plano Peculio Ouro Tradicional",
                SaldoAcumulado = 35420.50m,
                ValorContribuicaoMensal = 250.00m,
                DataAdesao = new DateTime(2020, 1, 15)
            };

            Assert.Multiple(() =>
            {
                Assert.That(plano.NumeroInscricao, Is.EqualTo("1913.045.882"));
                Assert.That(plano.NomePlano, Is.EqualTo("Plano Peculio Ouro Tradicional"));
                Assert.That(plano.SaldoAcumulado, Is.EqualTo(35420.50m));
                Assert.That(plano.ValorContribuicaoMensal, Is.EqualTo(250.00m));
                Assert.That(plano.DataAdesao, Is.EqualTo(new DateTime(2020, 1, 15)));
            });
        }

        [Test]
        public void PlanoPrevidencia_DefinirSaldoAcumulado_DeveAtualizar()
        {
            var plano = new PlanoPrevidencia();
            plano.SaldoAcumulado = 1000.50m;

            Assert.That(plano.SaldoAcumulado, Is.EqualTo(1000.50m));
        }

        [Test]
        public void PlanoPrevidencia_DefinirValorContribuicaoMensal_DeveAtualizar()
        {
            var plano = new PlanoPrevidencia();
            plano.ValorContribuicaoMensal = 500.75m;

            Assert.That(plano.ValorContribuicaoMensal, Is.EqualTo(500.75m));
        }
    }
}
