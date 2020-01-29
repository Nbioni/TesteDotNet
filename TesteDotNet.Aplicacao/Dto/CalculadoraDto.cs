using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Infra.Compartilhado.Enumeradores;

namespace TesteDotNet.Aplicacao.Dto
{
    public class CalculadoraDto : DtoBase
    {
        /// <summary>
        /// Opção selecionada
        /// </summary>
        public EnumOpcoes opcao;

        /// <summary>
        /// Os valores como nas regras devem estar separados por ;
        /// </summary>
        public string valores;

        /// <summary>
        /// Resposta ao resultado da operação
        /// </summary>
        public string resposta;
    }
}
