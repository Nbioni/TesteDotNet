using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Aplicacao.Interfaces;
using TesteDotNet.Aplicacao.Servicos;
using TesteDotNet.Dominio.Interfaces.Repositorios;
using TesteDotNet.Dominio.Interfaces.Servicos;
using TesteDotNet.Dominio.Servicos;
using TesteDotNet.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using TesteDotNet.Infra.Data.Contextos;

namespace TesteDotNet.Infra.IoC
{
    public class InjetorDependencias
    {

        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<ICalculadoraApp, CalculadoraApp>();
            svcCollection.AddAutoMapper(typeof(CalculadoraApp));

            //Domínio
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<ICalculadoraServico, CalculadoraServico>();
            svcCollection.AddAutoMapper(typeof(CalculadoraServico));

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<ICalculadoraRepositorio, CalculadoraRepositorio>();

            svcCollection.AddDbContext<Contexto>(ServiceLifetime.Scoped);


            //svcCollection.AddAutoMapper(typeof(CalculadoraRepositorio));


            // 'Unable to resolve service for type 'TesteDotNet.Infra.Data.Contextos.Contexto' while attempting to activate 'TesteDotNet.Infra.Data.Repositorios.CalculadoraRepositorio
        }

    }
}
