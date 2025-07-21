using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;
using System;

namespace Spread.PraticalEvaluation.Infra.Data
{
    public interface IUnitOfWork<TDbContext> where TDbContext : DbContext
    {
        IAuthorRepository AuthorRepository { get; }

        IBookRepository BookRepository { get; }

        ICategoryRepository CategoryRepository { get; }

        void Commit();
    }
}
