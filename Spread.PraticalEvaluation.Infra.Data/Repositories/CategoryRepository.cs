using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;

namespace Spread.PraticalEvaluation.Infra.Data.Repositories
{
    public class CategoryRepository : BaseRepository<short, Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {

        }
    }
}
