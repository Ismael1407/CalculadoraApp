using System;
using System.Collections.Generic;

namespace Calculadora
{
    public class Calculator
    {
        private List<string> _historico;
        private int _quantidadeOperacoes;

        public Calculator()
        {
            _historico = new List<string>();
            _quantidadeOperacoes = 0;
        }

        public int QuantidadeOperacoes => _quantidadeOperacoes;
        public List<string> GetHistorico() => new List<string>(_historico);
        public void LimparHistorico() { _historico.Clear(); _quantidadeOperacoes = 0; }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            AdicionarHistorico($"{num1} + {num2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            AdicionarHistorico($"{num1} - {num2} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            AdicionarHistorico($"{num1} × {num2} = {resultado}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            AdicionarHistorico($"{num1} ÷ {num2} = {resultado}");
            return resultado;
        }

        public double CalcularPorcentagem(int porcentagem, int numero)
        {
            double resultado = (numero * porcentagem) / 100.0;
            AdicionarHistorico($"{porcentagem}% de {numero} = {resultado}");
            return resultado;
        }

        public double RaizQuadrada(int numero)
        {
            double resultado = Math.Sqrt(numero);
            AdicionarHistorico($"√{numero} = {resultado}");
            return resultado;
        }

        private void AdicionarHistorico(string calculo)
        {
            _historico.Add(calculo);
            _quantidadeOperacoes++;
        }
    }
}