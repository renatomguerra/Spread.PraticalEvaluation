using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Application.Interfaces;
using Spread.PraticalEvaluation.Application.Services.Generic;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.Infra.Data.Context;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;

namespace Spread.PraticalEvaluation.Application.Services
{
    public class AuthorAppService : AppService<int, Author, ApplicationDbContext>, IAuthorAppService
    {
        public AuthorAppService(IUnitOfWork<ApplicationDbContext> unitOfWork): base(unitOfWork,unitOfWork.AuthorRepository)
        {
        }

    }
}
