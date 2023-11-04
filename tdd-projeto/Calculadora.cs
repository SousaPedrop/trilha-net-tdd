using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tdd_projeto
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;

        public Calculadora(string data)
        {
            this.data = data;
            historico = new List<string>();
        }
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            historico.Insert(0, $"res: {resultado} - {data}");

            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            historico.Insert(0, $"res: {resultado} - {data}");

            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            historico.Insert(0, $"res: {resultado} - {data}");

            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            historico.Insert(0, $"res: {resultado} - {data}");

            return resultado;
        }
        
        public List<string> RetornarHistorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}