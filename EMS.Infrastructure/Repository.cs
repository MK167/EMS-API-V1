using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq;
using System.Linq.Expressions;

namespace EMS.Infrastructure
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly DbContext Context;
        private readonly DbSet<TEntity> DbSet;

        public Repository(DbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            var query = DbSet.AsQueryable();
            if (include != null) query = include(query);
            return query.Where(predicate).ToList();
        }

        public TEntity FirstOrDefult(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            var query = DbSet.AsQueryable();
            if (include != null) query = include(query);
            return query.FirstOrDefault(predicate);
        }

        public TEntity Get(object id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            var query = DbSet.AsQueryable();
            if (include != null) query = include(query);
            return query.ToList();
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public TEntity SingleOrDefult(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            var query = DbSet.AsQueryable();
            if (include != null) query = include(query);
            return query.SingleOrDefault(predicate);
        }

        public void Update(TEntity original, TEntity newEntity)
        {
            Context.Entry(original).CurrentValues.SetValues(newEntity);
        }
    }
}
