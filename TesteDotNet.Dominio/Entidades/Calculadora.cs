using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Infra.Compartilhado.Enumeradores;


namespace TesteDotNet.Dominio.Entidades
{
    public class Calculadora : EntidadeBase
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
