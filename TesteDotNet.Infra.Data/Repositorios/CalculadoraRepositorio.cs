using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Interfaces.Repositorios;
using TesteDotNet.Infra.Data.Contextos;

namespace TesteDotNet.Infra.Data.Repositorios
{
    public class CalculadoraRepositorio : RepositorioBase<Calculadora>, ICalculadoraRepositorio
    {
        public CalculadoraRepositorio(Contexto contexto)
            : base(contexto)
        {
        }
        public void Soma(string values)
        {
            //Registraria em alguma base de dados
        }

        public void Soma(int[] nNumeros)
        {
        }

        public void Subtracao(int a, int b)
        {
        }

        public void Multiplicacao(int a, int b)
        {
        }

        public void Divisao(int a, int b)
        {
        }
    }
}
