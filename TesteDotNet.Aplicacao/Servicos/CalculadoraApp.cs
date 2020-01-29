using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TesteDotNet.Aplicacao.Dto;
using TesteDotNet.Aplicacao.Interfaces;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Interfaces.Servicos;
using TesteDotNet.Infra.Compartilhado.Enumeradores;
using TesteDotNet.Infra.Compartilhado.Validadores;
using System.Linq;
using System.Globalization;

namespace TesteDotNet.Aplicacao.Servicos
{
    public class CalculadoraApp : ServicoAppBase<Calculadora, CalculadoraDto>, ICalculadoraApp
    {
        protected readonly ICalculadoraServico servico;
        protected readonly IMapper iMapper;

        private ValidadorEntradas validador = new ValidadorEntradas();

        public CalculadoraApp(IMapper iMapper, ICalculadoraServico servico)
            : base(iMapper, servico)
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public string Soma(string values)
        {
            try {
                List<double> valores = validador.conversorValores(EnumOpcoes.Soma, values);
                if (valores.Count == 2)
                {
                    double x = servico.Soma(valores.First(), valores.Last());
                    return x.ToString();
                }
                else
                {
                    return "ERRO! - SOMA; Esta opção aceita somente dois valores. Valores: " + values;
                }
            }
            catch (PadraoException pe) {
                string resposta = "";
                foreach(var x in pe.dicionarioValidacao.ToList())
                    resposta += "ERRO! - " + x.Key.ToString() +"; "+ x.Value.ToString() +"\n";
                return resposta;
            }
        }

        public string SomaIlimitada(string values)
        {
            try
            {
                List<double> valores = validador.conversorValores(EnumOpcoes.SomaIlimitada, values);
                if (valores.Count >= 2)
                {
                    double x = servico.Soma(valores.ToArray());
                    return x.ToString();
                }
                else
                {
                    return "ERRO! - SOMA; Esta opção aceita no mínimo dois valores. Valores: " + values;
                }
            }
            catch (PadraoException pe)
            {
                string resposta = "";
                foreach (var x in pe.dicionarioValidacao.ToList())
                    resposta += "ERRO! - " + x.Key.ToString() + "; " + x.Value.ToString() + "\n";
                return resposta;
            }
        }
        public string SomaIlimitadaPares(string values)
        {
            try
            {
                List<double> valores = validador.conversorValores(EnumOpcoes.SomaIlimitadaPares, values);
                if (valores.Count >= 2)
                {
                    List<double> valoresPares = new List<double>();
                    foreach (var val in valores)
                    {
                        if (val % 2 == 0)
                            valoresPares.Add(val); //Valor é Par
                    }
                    double x = servico.Soma(valoresPares.ToArray());
                    return x.ToString();
                }
                else
                {
                    return "ERRO! - SOMA; Esta opção aceita no mínimo dois valores. Valores: " + values;
                }
            }
            catch (PadraoException pe)
            {
                string resposta = "";
                foreach (var x in pe.dicionarioValidacao.ToList())
                    resposta += "ERRO! - " + x.Key.ToString() + "; " + x.Value.ToString() + "\n";
                return resposta;
            }
        }

        public string Subtracao(string values)
        {
            try
            {
                List<double> valores = validador.conversorValores(EnumOpcoes.Soma, values);
                if (valores.Count == 2)
                {
                    double x = servico.Subtracao(valores.First(), valores.Last());
                    return x.ToString();
                }
                else
                {
                    return "ERRO! - SOMA; Esta opção aceita somente dois valores. Valores: " + values;
                }
            }
            catch (PadraoException pe)
            {
                string resposta = "";
                foreach (var x in pe.dicionarioValidacao.ToList())
                    resposta += "ERRO! - " + x.Key.ToString() + "; " + x.Value.ToString() + "\n";
                return resposta;
            }
        }

        public string Multiplicacao(string values)
        {
            try
            {
                List<double> valores = validador.conversorValores(EnumOpcoes.Soma, values);
                if (valores.Count == 2)
                {
                    double x = servico.Multiplicacao(valores.First(), valores.Last());
                    return x.ToString();
                }
                else
                {
                    return "ERRO! - SOMA; Esta opção aceita somente dois valores. Valores: " + values;
                }
            }
            catch (PadraoException pe)
            {
                string resposta = "";
                foreach (var x in pe.dicionarioValidacao.ToList())
                    resposta += "ERRO! - " + x.Key.ToString() + "; " + x.Value.ToString() + "\n";
                return resposta;
            }
        }

        public string Divisao(string values)
        {
            try
            {
                List<double> valores = validador.conversorValores(EnumOpcoes.Soma, values);
                if (valores.Count == 2)
                {
                    double x = servico.Divisao(valores.First(), valores.Last());
                    return x.ToString();
                }
                else
                {
                    return "ERRO! - SOMA; Esta opção aceita somente dois valores. Valores: " + values;
                }
            }
            catch (PadraoException pe)
            {
                string resposta = "";
                foreach (var x in pe.dicionarioValidacao.ToList())
                    resposta += "ERRO! - " + x.Key.ToString() + "; " + x.Value.ToString() + "\n";
                return resposta;
            }
        }
        public string MediaIlimitada(string values)
        {
            try
            {
                List<double> valores = validador.conversorValores(EnumOpcoes.SomaIlimitada, values);
                if (valores.Count >= 2)
                {
                    double x = servico.Media(valores.ToArray());
                    return x.ToString();
                }
                else
                {
                    return "ERRO! - SOMA; Esta opção aceita no mínimo dois valores. Valores: " + values;
                }
            }
            catch (PadraoException pe)
            {
                string resposta = "";
                foreach (var x in pe.dicionarioValidacao.ToList())
                    resposta += "ERRO! - " + x.Key.ToString() + "; " + x.Value.ToString() + "\n";
                return resposta;
            }
        }

        public string CriarArquivo()
        {
            try
            {
                if (servico.CriarArquivo())
                    return "Arquivo criado com sucesso!";
                else
                    return "ERRO! - O diretório 'TesteDotNet.UI/Data' não foi encontrado.";
            }
            catch (Exception e)
            {
                return "ERRO! - Ocorreu um erro ao tentar criar o arquivo. Erro: "+e.Message;
            }
        }
        public Dictionary<string, string> LerArquivo()
        {
            Dictionary<string, string> resposta = new Dictionary<string, string>();
            try
            {
                string texto = servico.LerArquivo();
                resposta.Add("ArquivoDeOperacoes.txt", texto);
                if (!texto.Contains("ERRO!"))
                {
                    var linhas = texto.Split('\n');
                    int contador = 0;
                    foreach (string linha in linhas)
                    {
                        contador++;
                        if (!string.IsNullOrEmpty(linha))
                        {
                            var parametros = linha.Split(';');
                            if(parametros.Length < 4)
                            {
                                resposta.Add(contador + "ERRO!", " Arquivo com linha invalida. Linha: " + linha + "\n\n O Padrão deve ser: Nome;Operação;parametros com no mínimo 2 parâmetros!");
                                return resposta;
                            }

                            string nome = parametros.First();
                            string operacao = parametros[1].ToUpper();
                            string valor = linha.Substring(nome.Length+1+operacao.Length+1);
                            string resultado = "";
                            switch (operacao)
                            {
                                case "SOMA":
                                    if(valor.Split(';').Length == 2)
                                    {
                                        resultado = Soma(valor);
                                        resposta.Add(nome, resultado);
                                    }
                                    else if(valor.Split(';').Length > 2)
                                    {
                                        resultado = SomaIlimitada(valor);
                                        resposta.Add(nome, resultado);
                                    }
                                    break;

                                case "SUBTRAÇÃO":
                                    resultado = Subtracao(valor);
                                    resposta.Add(nome, resultado);
                                    break;

                                case "MULTIPLICAÇÃO":
                                    resultado = Multiplicacao(valor);
                                    resposta.Add(nome, resultado);
                                    break;

                                case "DIVISÃO":
                                    resultado = Divisao(valor);
                                    resposta.Add(nome, resultado);
                                    break;

                                case "MÉDIA":
                                    resultado = MediaIlimitada(valor);
                                    resposta.Add(nome, resultado);
                                    break;

                                default:
                                    resposta.Add(nome, "ERRO! - Operacao inválida: " + operacao + ".\n Verifique se foi digitado corretamente a operação.");
                                    break;
                            }
                        }
                        else
                        {
                            resposta.Add("Linha " + contador + " - ERRO!", "Linha em Branco.");
                        }
                    }
                    return resposta;
                }
                else
                {
                    resposta.Add("ERRO!", texto);
                    return resposta;
                }
            }
            catch (Exception e)
            {
                resposta.Add("ERRO!", "Ocorreu um erro ao tentar criar o arquivo.Erro: " + e.Message);
                return resposta;
            }
        }
    }
}
