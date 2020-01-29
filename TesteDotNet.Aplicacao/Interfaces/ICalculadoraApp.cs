using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Aplicacao.Dto;
using TesteDotNet.Dominio.Entidades;

namespace TesteDotNet.Aplicacao.Interfaces
{
    public interface ICalculadoraApp : IAppBase<Calculadora, CalculadoraDto>
    {
        string Soma(string values);
        string SomaIlimitada(string values);
        string SomaIlimitadaPares(string values);

        string Subtracao(string values);

        string Multiplicacao(string values);
        string Divisao(string values);

        string MediaIlimitada(string values);

        string CriarArquivo();
        Dictionary<string, string> LerArquivo();

    }
}
