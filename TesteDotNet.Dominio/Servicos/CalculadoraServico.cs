using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Interfaces.Repositorios;
using TesteDotNet.Dominio.Interfaces.Servicos;
using System.Linq;

namespace TesteDotNet.Dominio.Servicos
{
    public class CalculadoraServico : ServicoBase<Calculadora>, ICalculadoraServico
    {
        protected readonly ICalculadoraRepositorio repositorio;

        public CalculadoraServico(ICalculadoraRepositorio repositorio) : base(repositorio)
        {
            this.repositorio = repositorio;
        }


        public double Soma(double a, double b)
        {
            //repositorio.Soma(a,b);
            return a+b;
        }

        public double Soma(double[] nNumeros)
        {
            double resultado = 0;
            foreach(var n in nNumeros.ToList())
            {
                resultado += n;
            }
            //repositorio.Soma(nNumeros);
            return resultado;
        }

        public double Subtracao(double a, double b)
        {
            //repositorio.Subtracao(a, b);
            return a-b;
        }

        public double Multiplicacao(double a, double b)
        {
            //repositorio.Multiplicacao(a, b);
            return a*b;
        }

        public double Divisao(double a, double b)
        {
            //repositorio.Divisao(a, b);
            return a/b;
        }
        public double Media(double[] nNumeros)
        {
            double resultado = 0;
            foreach (var n in nNumeros.ToList())
            {
                resultado += n;
            }
            //repositorio.Soma(nNumeros);
            return resultado / nNumeros.Length;
        }

        public bool CriarArquivo()
        {
            string path = Directory.GetCurrentDirectory();
            string subPath = path.Split("TesteDotNet.UI").First() + "TesteDotNet.UI\\Data\\";
            if (!Directory.Exists(subPath))
                return false;
            else
            {
                StreamWriter writer = new StreamWriter(subPath+"ArquivoDeOperacoes.txt");

                string texto = "José;Soma;10;2\n" +
                                "Adailtom;Divisão;10;2\n" +
                                "Raimundo;Multiplicacao;10;2\n" +
                                "Antonio;Subtração;10;2\n" +
                                "Joaquim;Subtração;10;2\n" +
                                "Paula;Divisão;10;2\n\n" +
                                "Nahaliel Bioni Alves da Silva;Soma;10;20;2;5;12";

                writer.Write(texto);
                writer.Close();
                return true;
            }
        }

        public string LerArquivo()
        {
            string path = Directory.GetCurrentDirectory();
            string subPath = path.Split("TesteDotNet.UI").First() + "TesteDotNet.UI\\Data\\";
            if (!Directory.Exists(subPath))
                return "ERRO! - O diretório 'TesteDotNet.UI/Data' não foi encontrado.";
            else
            {
                if(!File.Exists(subPath + "ArquivoDeOperacoes.txt"))
                    return "ERRO! - O diretório 'TesteDotNet.UI/Data' não foi encontrado.";
                else
                {
                    string text = System.IO.File.ReadAllText(subPath + "ArquivoDeOperacoes.txt");
                    return text;
                }
            }
        }
    }
}
