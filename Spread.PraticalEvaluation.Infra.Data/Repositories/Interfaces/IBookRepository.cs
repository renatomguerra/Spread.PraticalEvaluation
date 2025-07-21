using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces.Generic;

namespace Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces
{
    public interface IBookRepository: IBaseRepository<int,Book>
    {
    }
}
