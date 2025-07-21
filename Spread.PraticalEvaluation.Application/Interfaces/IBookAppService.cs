using Spread.PraticalEvaluation.Application.Interfaces.Generic;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data.Context;

namespace Spread.PraticalEvaluation.Application.Interfaces
{
    public interface IBookAppService: IAppService<int,Book, ApplicationDbContext>
    {
    }
}
