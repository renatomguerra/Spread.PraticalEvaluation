using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data.Context;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces.Generic;

namespace Spread.PraticalEvaluation.Infra.Data.Repositories
{
    public class BaseRepository<TDataKeyType, TEntity> : IBaseRepository<TDataKeyType, TEntity> where TEntity : BaseEntity<TDataKeyType>
    {
        private DbContext _context;       

        public BaseRepository(DbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }
        public TEntity? Get(TDataKeyType id)
        {
            return _context.Find<TEntity>(id);
        }

        public IList<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

    }
}
