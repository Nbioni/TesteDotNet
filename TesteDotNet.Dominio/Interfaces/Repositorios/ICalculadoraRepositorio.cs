using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;

namespace TesteDotNet.Dominio.Interfaces.Repositorios
{
    public interface ICalculadoraRepositorio : IRepositorioBase<Calculadora>
    {
        void Soma(string values);
        void Soma(params int[] nNumeros);

        void Subtracao(int a, int b);

        void Multiplicacao(int a, int b);

        void Divisao(int a, int b);
    }
}
