using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Application.Interfaces.Generic;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.Infra.Data.Repositories;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces.Generic;

namespace Spread.PraticalEvaluation.Application.Services.Generic
{
    public class AppService<TDataKeyType, TEntity, TDbContext>: IAppService<TDataKeyType, TEntity, TDbContext>
        where TEntity: BaseEntity<TDataKeyType>
        where TDbContext : DbContext
    {
        private IUnitOfWork<TDbContext> _unitOfWork;
        private IBaseRepository<TDataKeyType, TEntity> _repository;

        public AppService(IUnitOfWork<TDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public AppService(IUnitOfWork<TDbContext> unitOfWork, IBaseRepository<TDataKeyType, TEntity> repository) 
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
            _unitOfWork.Commit();
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
            _unitOfWork.Commit();
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public TEntity? Get(TDataKeyType id)
        {
            return _repository.Get(id);
        }

        public IList<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _repository.Find(predicate);
        }

        public IList<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

    }
}
