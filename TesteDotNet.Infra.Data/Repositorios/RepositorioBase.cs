using System;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Interfaces.Repositorios;
using TesteDotNet.Infra.Data.Contextos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;



namespace TesteDotNet.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade>
          where TEntidade : EntidadeBase
    {
        //protected readonly Contexto contexto;

        public RepositorioBase(Contexto contexto)
            : base()
        {
            //this.contexto = contexto;
        }

        public void Alterar(TEntidade entidade)
        {
            /*
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Attach(entidade);
            contexto.Entry(entidade).State = EntityState.Modified;
            contexto.SendChanges();
            */
        }

        public void Excluir(int id)
        {
            /*
            var entidade = SelecionarPorId(id);
            if (entidade != null)
            {
                contexto.InitTransacao();
                contexto.Set<TEntidade>().Remove(entidade);
                contexto.SendChanges();
            }
            */
        }

        public void Excluir(TEntidade entidade)
        {
            /*
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Remove(entidade);
            contexto.SendChanges();
            */
        }

        public int Incluir(TEntidade entidade)
        {
            /*
            contexto.InitTransacao();
            var id = contexto.Set<TEntidade>().Add(entidade).Entity.Id;
            contexto.SendChanges();
            return id;
            */
            return 0;
        }

        
        public TEntidade SelecionarPorId(int id)
        {
            //return contexto.Set<TEntidade>().Find(id);
            return null;
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            //return contexto.Set<TEntidade>().ToList();
            return null;
        }
    }
}
