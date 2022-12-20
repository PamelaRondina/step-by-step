using Pam.Business.Core.Data;
using Pam.Business.Core.Models;
using Pam.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pam.Infra.Data.Repository
{
    /*Abstract Class = não se pode instanciar sozinha, deve ser herdar*/
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        /*criar acesso ao contexto*/
        protected readonly MeuDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository()
        {
            Db = new MeuDbContext();
            DbSet = Db.Set<TEntity>();
        }       

        /*método de leitura*/
        public Task<TEntity> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        /*método de leitura*/
        public Task<List<TEntity>> ObterTodos()
        {
            throw new NotImplementedException();
        }
        public Task Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }                    

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
