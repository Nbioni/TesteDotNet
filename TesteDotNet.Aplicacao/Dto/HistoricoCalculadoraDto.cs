using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDotNet.Aplicacao.Dto
{
    public class HistoricoCalculadoraDto : DtoBase
    {
        public List<CalculadoraDto> historico;

        /// <summary>
        /// Referente a Questão 14. Leitura do arquivo de operações
        ///  Dictionary<string, string>. Nome da Pessoa e resultado da operação
        /// </summary>
        public Dictionary<string, string> dicionarioResultado;
    }
}
