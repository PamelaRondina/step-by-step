using Pam.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pam.Business.Core.Data
{
    //Entity representa a Entidade
    // 
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        //métodos
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);

        //retornar uma coleção de entidade com o método Buscar, que recebe uma expressão lambida em cima da entidade que estou trabalhando, que busca no banco o formato que quisermos
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        //método para salvar no banco
        //retorna um inteiro (número de linhas afetadas após persistir no BD)
        Task<int> SaveChanges();
    }
}
