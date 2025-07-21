using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;

namespace Spread.PraticalEvaluation.Infra.Data.Repositories
{
    public class AuthorRepository : BaseRepository<int, Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext context) : base(context)
        {

        }
    }
}
