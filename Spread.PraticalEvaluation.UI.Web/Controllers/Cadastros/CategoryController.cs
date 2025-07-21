using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Application.Interfaces;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.Infra.Data.Context;
using Spread.PraticalEvaluation.UI.Web.Controllers.Generic;
using Spread.PraticalEvaluation.UI.Web.Models.Cadastros;

namespace Spread.PraticalEvaluation.UI.Web.Controllers.Cadastros
{
    public class CategoryController : CrudController<short, Category, CategoryViewModel, ApplicationDbContext>
    {
        public CategoryController(IUnitOfWork<ApplicationDbContext> unitOfWork, ICategoryAppService service) : base(unitOfWork, service)
        {
        }

    }

}
