using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Infra.Compartilhado.Enumeradores;

namespace TesteDotNet.Infra.Compartilhado.Validadores
{
    public class ValidadorEntradas
    {
        public ValidadorEntradas() { }

        public List<double> conversorValores(EnumOpcoes operacao, string valores)
        {
            Dictionary<string, string> dicionarioValidacao = new Dictionary<string, string>();
            List<double> listaValores = new List<double>();
            if (!valores.Contains(";"))
            {
                dicionarioValidacao.Add(operacao.ToString(), "Não contém o separador de valores ';'. Valores: "+valores);
            }
            else
            {
                var splitValores = valores.Split(';');
                int contadorKey = 0;
                foreach (var i in splitValores)
                {
                    contadorKey++;
                    double d;
                    if(double.TryParse(i, out d))
                        listaValores.Add(d);
                    else
                        dicionarioValidacao.Add("Posição "+contadorKey+" - "+operacao.ToString(), "O valor '" + i + "' não é válido. Valores: " + valores);
                }
            }

            if (dicionarioValidacao.Count > 0)
                throw new PadraoException(dicionarioValidacao);
            else
                return listaValores;
        }
    }
}
