using Spread.PraticalEvaluation.Application.Interfaces;
using Spread.PraticalEvaluation.Application.Services.Generic;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.Infra.Data.Context;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;

namespace Spread.PraticalEvaluation.Application.Services
{
    public class CategoryAppService : AppService<short, Category, ApplicationDbContext>, ICategoryAppService
    {
        public CategoryAppService(IUnitOfWork<ApplicationDbContext> unitOfWork) : base(unitOfWork, unitOfWork.CategoryRepository)
        {
        }

    }
}
