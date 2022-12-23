using Pam.Business.Core.Data;
using Pam.Business.Core.Models;
using Pam.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pam.Infra.Data.Repository
{
    /*Abstract Class = não se pode instanciar sozinha, deve ser herdar*/
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        /*criar acesso ao contexto*/
        protected readonly MeuDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(MeuDbContext db)
        {
            /*Contexto em geral*/
            Db = db;
            /*Acesso rápido a minha Entidade*/
            DbSet = Db.Set<TEntity>();
        }       

        /*método de leitura*/
        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            /*método "FindAsync" serve para encontrar a entidade através da PK*/
            return await DbSet.FindAsync(id);
        }

        /*método de leitura que trará uma lista*/
        public virtual async Task<List<TEntity>> ObterTodos()
        {
            /*Retorna uma lista de forma assíncrona*/
            return await DbSet.ToListAsync(); 
        }
        /*Método que implementa uma expressão*/
        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            /*Desabilita o Track*/
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync(); 
        }

        /*Inicia a transformação de dados*/
        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }
                       

        public virtual async Task Remover(Guid id)
        {
            Db.Entry(new TEntity { Id = id }).State = EntityState.Deleted;
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {/*? = Só chama o método se tiver ums instância definida*/
            Db?.Dispose();
        }
    }
}
