using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TesteDotNet.Aplicacao.Dto;
using TesteDotNet.Aplicacao.Interfaces;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Interfaces.Servicos;

namespace TesteDotNet.Aplicacao.Servicos
{
    public class HistoricoCalculadoraApp : ServicoAppBase<HistoricoCalculadora, HistoricoCalculadoraDto>, IHistoricoCalculadoraApp
    {
        public HistoricoCalculadoraApp(IMapper iMapper, IHistoricoCalculadoraServico servico)
            : base(iMapper, servico)
        {

        }
    }
}
