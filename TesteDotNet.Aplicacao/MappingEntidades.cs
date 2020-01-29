using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TesteDotNet.Aplicacao.Dto;
using TesteDotNet.Dominio.Entidades;

namespace TesteDotNet.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Calculadora, CalculadoraDto>();
            CreateMap<CalculadoraDto, Calculadora>();
        }
    }
}
