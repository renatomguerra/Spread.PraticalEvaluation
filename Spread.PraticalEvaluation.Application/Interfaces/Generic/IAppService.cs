using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Domain.Entities;

namespace Spread.PraticalEvaluation.Application.Interfaces.Generic
{
    public interface IAppService<TDataKeyType, TEntity, TDbContext>
          where TEntity : BaseEntity<TDataKeyType>
          where TDbContext: DbContext  
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity? Get(TDataKeyType id);
        IList<TEntity> Find(Func<TEntity, bool> predicate);
        IList<TEntity> GetAll();
    }
}
