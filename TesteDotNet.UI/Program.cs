using System;
using TesteDotNet.Servico;
using TesteDotNet.Aplicacao.Dto;
using TesteDotNet.Aplicacao.Interfaces;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Aplicacao.Servicos;
using TesteDotNet.Dominio.Interfaces.Servicos;
using TesteDotNet.Infra.IoC;
using TesteDotNet.Infra.Data.Contextos;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using System.Linq;

namespace TesteDotNet.UI
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo!!!\n");
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }


        private static bool MainMenu()
        {
            var collection = new ServiceCollection();
            InjetorDependencias.Registrar(collection);
            var serviceProvider = collection.BuildServiceProvider();
            var calculadoraAppService = serviceProvider.GetService<ICalculadoraApp>();

            Console.WriteLine("... Calculadora TesteDotNet ...");
            Console.WriteLine("Escolha alguma operação: \n" +
                              " 0 - Soma \n" +
                              " 1 - Subtração \n" +
                              " 2 - Multiplicação \n" +
                              " 3 - Divisão \n" +
                              " 4 - Soma ilimitada \n" +
                              " 5 - Soma ilimitada de numeros pares \n" +
                              " 6 - Média ilimitada \n" +
                              " 7 - Criar arquivo de operações- Questão 13. \n" +
                              " 8 - Ler arquivo criado e executar operações. Questão 14. \n" +
                              " 9 - Limpar \n" +
                              " 10 - Sair \n" +
                              "*Observação: Digite os números separados por ';' como por exemplo: 10;30 \n" +
                              "e para valores reais use ',' como por exemplo: 10,5;30,2\n\n" +
                              "Sua opção: ");
            string opcao = Console.ReadLine();
            int numOpcao;
            var isNumeric = int.TryParse(opcao, out numOpcao);

            if (isNumeric)
            {
                string valorDigitado;
                string resposta;

                switch (numOpcao)
                {
                    case 0:
                        Console.WriteLine("\n-- Opção 0: Soma -- \n Digite dois números para serem somados: \n" +
                            "  Ex.: 20;5 \n\n Números: ");
                        valorDigitado = Console.ReadLine();
                        resposta = calculadoraAppService.Soma(valorDigitado);
                        ApresentaResposta(resposta);
                        break;
                    case 1:
                        Console.WriteLine("\n-- Opção 1: Subtração --: \n Digite dois números para serem subtraídos: \n" +
                            "  Ex.: 20;5 \n\n Números: ");
                        valorDigitado = Console.ReadLine();
                        resposta = calculadoraAppService.Subtracao(valorDigitado);
                        ApresentaResposta(resposta);
                        break;
                    case 2:
                        Console.WriteLine("\n-- Opção 2: Multiplicacao -- \n Digite dois números para serem multiplicados: \n" +
                            "  Ex.: 20;5 \n\n Números: ");
                        valorDigitado = Console.ReadLine();
                        resposta = calculadoraAppService.Multiplicacao(valorDigitado);
                        ApresentaResposta(resposta);
                        break;
                    case 3:
                        Console.WriteLine("\nOpção 3 - Divisão: \n Digite dois números para serem divididos: \n" +
                            "   Ex.: 20;5 \n\n Números: ");
                        valorDigitado = Console.ReadLine();
                        resposta = calculadoraAppService.Divisao(valorDigitado);
                        ApresentaResposta(resposta);
                        break;
                    case 4:
                        Console.WriteLine("\nOpção 4 - Soma ilimitada: \n Digite dois ou mais números para serem somados: \n" +
                            "   Ex.: 20;5;10 \n\n Números: ");
                        valorDigitado = Console.ReadLine();
                        resposta = calculadoraAppService.SomaIlimitada(valorDigitado);
                        ApresentaResposta(resposta);
                        break;
                    case 5:
                        Console.WriteLine("\nOpção 5 - Soma ilimitada de numeros pares: \n Digite dois ou mais números para serem somados: \n" +
                            "   Ex.: 20;5;10 \n\n Números: ");
                        valorDigitado = Console.ReadLine();
                        resposta = calculadoraAppService.SomaIlimitada(valorDigitado);
                        ApresentaResposta(resposta);
                        break;
                    case 6:
                        Console.WriteLine("\nOpção 6 - Média ilimitada: \n Digite dois ou mais números para calcular a média: \n" +
                            "   Ex.: 20;5;10 \n\n Números: ");
                        valorDigitado = Console.ReadLine();
                        resposta = calculadoraAppService.SomaIlimitada(valorDigitado);
                        ApresentaResposta(resposta);
                        break;
                    case 7:
                        Console.WriteLine("\nOpção 7 - Criar arquivo de operações. \n\n");
                        resposta = calculadoraAppService.CriarArquivo();
                        ApresentaResposta(resposta);
                        break;
                    case 8:
                        Console.WriteLine("\nOpção 8 - Ler arquivo de operações. \n\n");
                        var leitura = calculadoraAppService.LerArquivo();
                        Console.WriteLine("--- Dicionário RESPOSTA --- \n\n");
                        foreach(var resp in leitura)
                        {
                            if (leitura.First().Key == resp.Key)
                            {
                                Console.WriteLine("Arquivo: " + resp.Key);
                                Console.WriteLine("Conteúdo: " + resp.Value);
                            }
                            else
                            {
                                Console.WriteLine("Chave: " + resp.Key);
                                ApresentaResposta("Valor: " + resp.Value + "\n\n");
                            }
                        }
                        Console.WriteLine("--------------------------- \n\n");
                        break;
                    case 9:
                        Console.Clear();
                        break;
                    case 10:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("\n\nPressione qualquer tecla para continuar ou ESC para sair”");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if(info.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("“Obrigado por utilizar nossa calculadora”");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("** Opção inválida. Tente novamente!");
            }
            return true;
        }

        private static void ApresentaResposta(string resposta) {
            if (resposta.Contains("ERRO!"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(resposta);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nResultado: " + resposta);
                Console.ResetColor();
            }
        }
    }
}
