using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Application.Interfaces;
using Spread.PraticalEvaluation.Application.Interfaces.Generic;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.Infra.Data.Context;
using Spread.PraticalEvaluation.UI.Web.Controllers.Generic;
using Spread.PraticalEvaluation.UI.Web.Models.Cadastros;

namespace Spread.PraticalEvaluation.UI.Web.Controllers.Cadastros
{
    public class AuthorController: CrudController<int, Author, AuthorViewModel, ApplicationDbContext>
    {
        public AuthorController(IUnitOfWork<ApplicationDbContext> unitOfWork, IAuthorAppService service) : base(unitOfWork, service)
        {
        }
       
    }
}
