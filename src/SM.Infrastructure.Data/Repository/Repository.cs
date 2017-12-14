using Dapper;
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

        public Repository()
        {
            Db = new SenaMotosContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            var objRetorno = DbSet.Add(obj);
            SaveChanges();
            return objRetorno;
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();

            return obj;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
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
            SaveChanges();
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
