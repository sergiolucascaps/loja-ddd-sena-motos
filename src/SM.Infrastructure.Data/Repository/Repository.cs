using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SM.Infrastructure.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected SenaMotosContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(SenaMotosContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            return DbSet.Add(obj);
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            //SaveChanges(); // Comentado pois foi implementado UnitOfWork

            return obj;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            #region Usando Dapper
            //TODO: Implementar com Dapper
            #endregion

            #region Usando Entity Framework

            return DbSet.Find(id);

            #endregion
        }

        // Exemplo de obter Todos com Paginação
        //public IEnumerable<TEntity> ObterTodos(int t, int s)
        public virtual IEnumerable<TEntity> ObterTodos()
        {
            //return DbSet.Take(t).Skip(s).ToList();
            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            //DbSet.Remove(ObterPorId(id)); ou
            DbSet.Remove(DbSet.Find(id));
            //SaveChanges(); // Comentado pois foi implementado UnitOfWork
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
