using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Spread.PraticalEvaluation.Application.Interfaces;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.Infra.Data.Context;
using Spread.PraticalEvaluation.UI.Web.Controllers.Generic;
using Spread.PraticalEvaluation.UI.Web.Models.Cadastros;

namespace Spread.PraticalEvaluation.UI.Web.Controllers.Cadastros
{
    public class BookController : CrudController<int, Book, BookViewModel, ApplicationDbContext>
    {
        private readonly IAuthorAppService _authorAppService;
        private readonly ICategoryAppService _categoryAppService;
        public BookController(IUnitOfWork<ApplicationDbContext> unitOfWork, 
                              IBookAppService service, 
                              IAuthorAppService authorAppService, 
                              ICategoryAppService categoryAppService) : base(unitOfWork, service)
        {
            _authorAppService = authorAppService;
            _categoryAppService = categoryAppService;
        }

        protected override void OnLoadPage()
        {
            ViewBag.AuthorList = _authorAppService.GetAll().Select(author => new SelectListItem(author.Name, author.Id.ToString())).ToList();
            ViewBag.CategoryList = _categoryAppService.GetAll().Select(category => new SelectListItem(category.Name, category.Id.ToString())).ToList(); ;
        }
               
    }

}
