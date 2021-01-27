namespace UnitTest
{
    using Xunit;
    using Calculadora;

    public class UnitTest1
    {
        [Theory]
        //[InlineData("+", 10, 5, 15)]
        //[InlineData("-", 10, 5, 5)]
        //[InlineData("/", 10, 5, 2)]
        //[InlineData("*", 10, 5, 50)]
        [InlineData("+", 1, 1, 2)]
        [InlineData("-", 1, 1, 0)]
        [InlineData("/", 1, 1, 1)]
        [InlineData("*", 0, 1, 0)]
        public void Calcular_Test(string operador, int x, int y, int resultado)
        {
            Assert.Equal(resultado, Calculadora.Calcular(operador, x, y));
        }

    }
}
