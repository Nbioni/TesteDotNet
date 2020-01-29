using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Interfaces.Repositorios;
using TesteDotNet.Dominio.Interfaces.Servicos;

namespace TesteDotNet.Dominio.Servicos
{
    public class HistoricoCalculadoraServico : ServicoBase<HistoricoCalculadora>, IHistoricoCalculadoraServico
    {
        public HistoricoCalculadoraServico(IHistoricoCalculadoraRepositorio repositorio)
            : base(repositorio)
        {

        }
    }
}
