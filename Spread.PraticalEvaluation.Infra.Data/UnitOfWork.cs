using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spread.PraticalEvaluation.Infra.Data
{
    public class UnitOfWork<TDbContext> : IUnitOfWork<TDbContext>
        where TDbContext : DbContext
    {
        private TDbContext _dbContext;
        private IAuthorRepository _authorRepository;
        private IBookRepository _bookRepository;
        private ICategoryRepository _categoryRepository;

        private bool disposedValue;
        public UnitOfWork(TDbContext dbContext, IAuthorRepository authorRepository, IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _dbContext = dbContext;
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public IAuthorRepository AuthorRepository { get { return _authorRepository; } }

        public IBookRepository BookRepository { get { return _bookRepository; } }

        public ICategoryRepository CategoryRepository { get { return _categoryRepository; } }

        public void Commit()
        {
           int qtde= _dbContext.SaveChanges();
        }

    }
}
