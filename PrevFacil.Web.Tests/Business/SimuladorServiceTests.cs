using NUnit.Framework;
using PrevFacil.Web.Business;

namespace PrevFacil.Web.Tests.Business
{
    [TestFixture]
    public class SimuladorServiceTests
    {
        private SimuladorService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new SimuladorService();
        }

        [Test]
        public void SimularSaldoFuturo_ComValorMensalEMeses_DeveRetornarValorPositivo()
        {
            decimal resultado = _service.SimularSaldoFuturo(100m, 12);

            Assert.That(resultado, Is.GreaterThan(1200m));
        }

        [Test]
        public void SimularSaldoFuturo_ComSaldoAtual_DeveIncluirSaldoNoCalculo()
        {
            decimal semSaldo = _service.SimularSaldoFuturo(100m, 6, 0);
            decimal comSaldo = _service.SimularSaldoFuturo(100m, 6, 1000m);

            Assert.That(comSaldo, Is.GreaterThan(semSaldo));
        }

        [Test]
        public void SimularSaldoFuturo_UmMes_DeveAplicarJurosCorretamente()
        {
            decimal resultado = _service.SimularSaldoFuturo(100m, 1);

            Assert.That(resultado, Is.EqualTo(100.50m).Within(0.001m));
        }

        [Test]
        public void SimularSaldoFuturo_DoisMeses_DeveAplicarJurosCompostos()
        {
            decimal resultado = _service.SimularSaldoFuturo(100m, 2);

            Assert.That(resultado, Is.EqualTo(201.5025m).Within(0.001m));
        }

        [Test]
        public void SimularSaldoFuturo_TresMesesComSaldoInicial_DeveCalcularCorretamente()
        {
            decimal resultado = _service.SimularSaldoFuturo(200m, 3, 1000m);

            Assert.That(resultado, Is.EqualTo(1621.09515m).Within(0.001m));
        }

        [Test]
        public void SimularSaldoFuturo_MesesZero_DeveRetornarSaldoAtual()
        {
            decimal resultado = _service.SimularSaldoFuturo(100m, 0, 500m);

            Assert.That(resultado, Is.EqualTo(500m));
        }

        [Test]
        public void SimularSaldoFuturo_ValorMensalZero_DeveAplicarJurosNoSaldoAtual()
        {
            decimal resultado = _service.SimularSaldoFuturo(0m, 12, 1000m);

            Assert.That(resultado, Is.EqualTo(1061.67781m).Within(0.001m));
        }

        [Test]
        public void SimularSaldoFuturo_TudoZero_DeveRetornarZero()
        {
            decimal resultado = _service.SimularSaldoFuturo(0m, 0);

            Assert.That(resultado, Is.EqualTo(0m));
        }

        [Test]
        public void SimularSaldoFuturo_MuitosMeses_NaoDeveLancarExcecao()
        {
            Assert.That(() => _service.SimularSaldoFuturo(500m, 360), Throws.Nothing);
        }

        [Test]
        public void SimularSaldoFuturo_SaldoAtualNegativo_DeveAceitar()
        {
            decimal resultado = _service.SimularSaldoFuturo(100m, 1, -500m);

            Assert.That(resultado, Is.EqualTo(-402m).Within(0.001m));
        }
    }
}
