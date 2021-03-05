using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> PegarTodos();
        Task<TEntity> PegarPeloId(int id);
        Task Inserir(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Excluir(int id);
        Task Excluir(TEntity entity);
        
    }
}
