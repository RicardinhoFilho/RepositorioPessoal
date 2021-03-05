using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repositorio
{
    public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        private readonly Contexto contexto;
        public RepositorioGenerico(Contexto contexto)
        {
            this.contexto = contexto;
        }
        public async Task Atualizar(TEntity entity)
        {
            try
            {
                contexto.Set<TEntity>().Update(entity);
                await contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(int id)
        {
            try
            {
                var entity = await PegarPeloId(id);
                contexto.Set<TEntity>().Remove(entity);
                await contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(TEntity entity)
        {
            try
            {
                contexto.Set<TEntity>().AddRange(entity);
                await contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Inserir(TEntity entity)
        {
            try
            {
                await contexto.AddAsync(entity);
                await contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> PegarPeloId(int id)
        {
            try
            {
                return await contexto.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> PegarTodos()
        {
            try
            {
                return await contexto.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}