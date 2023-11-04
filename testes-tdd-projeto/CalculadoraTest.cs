using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tdd_projeto;
using Xunit;

namespace testes_tdd
{
    public class CalculadoraTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(15, 5, 10)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            // Given
            Calculadora calc = new Calculadora();
            // When

            // Then
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            // Given
            Calculadora calc = new Calculadora();
            // When
            calc.Somar(1, 2);
            calc.Somar(3, 4);
            calc.Somar(5, 6);
            calc.Somar(7, 8);

            var lista = calc.RetornarHistorico();

            // Then
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}