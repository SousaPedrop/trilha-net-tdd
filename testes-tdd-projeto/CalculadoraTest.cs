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
        [Fact]
        public void Test1()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Somar(1, 2);

            Assert.Equal(3, resultado);
        }
    }
}