using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;

namespace Spread.PraticalEvaluation.Infra.Data.Repositories
{
    public class BookRepository : BaseRepository<int, Book>, IBookRepository
    {
        public BookRepository(DbContext context) : base(context)
        {

        }
    }
}
