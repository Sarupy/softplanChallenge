using API_2;

namespace Tests
{
    [TestFixture]
    public class MathTests
    {
        private MathService _mathService;

        [SetUp]
        public void Setup()
        {
            _mathService = new MathService();
        }

        [Test]
        public void TestarCalculoDeJurosCompostos()
        {
            var retorno = _mathService.CalcularJurosCompostos(100, 0.01, 5);

            if (retorno == 105.1)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}