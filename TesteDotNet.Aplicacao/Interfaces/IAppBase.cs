using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Aplicacao.Dto;
using TesteDotNet.Dominio.Entidades;

namespace TesteDotNet.Aplicacao.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDto>
       where TEntidade : EntidadeBase
       where TEntidadeDto : DtoBase
    {
        int Incluir(TEntidadeDto entidade);
        void Excluir(int id);
        void Excluir(TEntidadeDto entidade);
        void Alterar(TEntidadeDto entidade);
        TEntidadeDto SelecionarPorId(int id);
        IEnumerable<TEntidadeDto> SelecionarTodos();
    }
}
