using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;

namespace Domain.Repository {
    public abstract class ARepository<TEntity> where TEntity : class {

        private readonly MovieDbContext _dbContext;

        private readonly DbSet<TEntity> _dbSet;

        protected ARepository(MovieDbContext dbContext) {
            this._dbContext = dbContext;
            this._dbSet = dbContext.Set<TEntity>();
        }
        
        public TEntity Insert(TEntity entity) {
            var data = this._dbSet.Add(entity);
            this._dbContext.SaveChanges();

            return data.Entity;
        }

        public void Update(TEntity entity) {
            this._dbSet.Update(entity);
            this._dbContext.SaveChanges();
        }

        public TEntity GetById(object id) {
            return this._dbSet.Find(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null) {
            IQueryable<TEntity> query = this._dbSet;

            if (filter != null) {
                query = query.Where(filter);
            }
            
            return query.ToList();
        }

        public void Delete(TEntity entity) {
            _dbSet.Remove(entity);

            this._dbContext.SaveChanges();
        }

        public void Delete(object id) {
            TEntity entity = _dbSet.Find(id);
            Delete(entity);
        }
    }
}