using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Spread.PraticalEvaluation.Application.Interfaces;
using Spread.PraticalEvaluation.Application.Interfaces.Generic;
using Spread.PraticalEvaluation.Application.Services;
using Spread.PraticalEvaluation.Application.Services.Generic;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.Infra.Data.Context;
using Spread.PraticalEvaluation.Infra.Data.Repositories;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces;
using Spread.PraticalEvaluation.Infra.Data.Repositories.Interfaces.Generic;
using System;

namespace Spread.PraticalEvaluation.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ApplicationConnection");

            #region Conexão com o banco de dados
            
            services.AddSingleton<IConfiguration>(provider => configuration);
            services.AddDbContext<ApplicationDbContext>(optionsAction => optionsAction.UseSqlServer(connectionString), ServiceLifetime.Singleton);
            services.AddScoped<DbContext, ApplicationDbContext>();

            #endregion

            #region Repositórios

            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
 
            #endregion

            #region Serviços

            services.AddScoped(typeof(IAppService<,,>), typeof(AppService<,,>));
            services.AddScoped<IAuthorAppService, AuthorAppService>();
            services.AddScoped<IBookAppService, BookAppService>();
            services.AddScoped<ICategoryAppService, CategoryAppService>();
            
            #endregion

        }
    }
}
