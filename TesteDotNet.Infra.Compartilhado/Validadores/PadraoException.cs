using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TesteDotNet.Infra.Compartilhado.Validadores
{
    [Serializable]
    public class PadraoException : Exception
    {
        public Dictionary<string, string> dicionarioValidacao;

        public PadraoException()
        {
        }

        public PadraoException(string message) : base(message)
        {
        }

        public PadraoException(Dictionary<string, string> dicionarioValidacao)
        {
            this.dicionarioValidacao = dicionarioValidacao;
        }

        public PadraoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PadraoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
