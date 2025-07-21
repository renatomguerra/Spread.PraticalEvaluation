using Spread.PraticalEvaluation.Domain.Entities;

namespace Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces.Generic
{
    public interface IBaseRepository<TDataKeyType, TEntity>
      where TEntity : BaseEntity<TDataKeyType>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity? Get(TDataKeyType id);
        IList<TEntity> Find(Func<TEntity, bool> predicate);
        IList<TEntity> GetAll();
    }
}
