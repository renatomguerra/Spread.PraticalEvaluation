using Spread.PraticalEvaluation.Application.Interfaces;
using Spread.PraticalEvaluation.Application.Services.Generic;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.Infra.Data.Context;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;

namespace Spread.PraticalEvaluation.Application.Services
{
    public class BookAppService : AppService<int, Book, ApplicationDbContext>, IBookAppService
    {
        public BookAppService(IUnitOfWork<ApplicationDbContext> unitOfWork) : base(unitOfWork, unitOfWork.BookRepository)
        {
        }

    }
}
