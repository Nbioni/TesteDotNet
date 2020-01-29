using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;

namespace TesteDotNet.Dominio.Interfaces.Servicos
{
    public interface ICalculadoraServico : IServicoBase<Calculadora>
    {
        double Soma(double a, double b);
        double Soma(params double[] nNumeros);

        double Subtracao(double a, double b);

        double Multiplicacao(double a, double b);
        double Divisao(double a, double b);
        double Media(params double[] nNumeros);
        bool CriarArquivo();
        string LerArquivo();
    }
}
