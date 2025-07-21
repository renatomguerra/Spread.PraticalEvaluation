using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spread.PraticalEvaluation.Application.Interfaces.Generic;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.Infra.Data;
using Spread.PraticalEvaluation.UI.Web.Mappings;
using Spread.PraticalEvaluation.UI.Web.Models;

namespace Spread.PraticalEvaluation.UI.Web.Controllers.Generic
{
    public class CrudController<TDataKeyType, TEntity, TViewModel, TDbContext> : Controller
        where TEntity: BaseEntity<TDataKeyType>, new()
        where TViewModel: BaseViewModel<TDataKeyType> , new()
        where TDbContext: DbContext
 

    {
        private IMapper _mapper;
        private IUnitOfWork<TDbContext> _unitOfWork;
        private IAppService<TDataKeyType, TEntity, TDbContext> _appService;

        #region Construtor(es)
        public CrudController(IUnitOfWork<TDbContext> unitOfWork, IAppService<TDataKeyType, TEntity, TDbContext> appService)         
        {
            _unitOfWork = unitOfWork;
            _appService = appService;
            _mapper = ConfigurationMapping.CreateMapper();
        }
        #endregion

        #region Método(s)
        protected virtual void OnLoadPage()
        {
            // ***** MÉTODO PARA INICIALIZAÇÃO DE DADOS (EX: CARREGAMENTO DE COMBOS, VIEWBAG, ETC *****
        }
        #endregion

        #region ActionResult
        [HttpGet]
        public virtual IActionResult List()
        {
            OnLoadPage();
            return View(_appService.GetAll().Select(entity => _mapper.Map<TViewModel>(entity)).ToList());
        }

        [HttpGet]
        public virtual ActionResult Create()
        {
            this.OnLoadPage();
            return View(new TViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public virtual ActionResult Create(TViewModel model)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    OnLoadPage();
                    return View(model);
                }

                _appService.Add(_mapper.Map<TEntity>(model));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Erro", e.Message);
                OnLoadPage();
                return View(model);
            }

            return RedirectToAction("List");
        }

        [HttpGet()]
        [Route("{controller}/Edit/{id:int}")]
        public virtual ActionResult Edit(TDataKeyType id)
        {

            TEntity? entity = null;

            try
            {
                OnLoadPage();

                entity = _appService.Get(id);
               
                if (entity == null)
                    return NotFound();
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
            }

            return View(_mapper.Map<TViewModel>(entity));
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public virtual ActionResult Edit(TViewModel model)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    OnLoadPage();
                    return View(model);
                }

                _appService.Update(_mapper.Map<TEntity>(model));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                OnLoadPage();
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet()]
        [Route("{controller}/Delete/{id:int}")]
        public virtual ActionResult Delete(TDataKeyType id)
        {
            TEntity? entity = null;
            try
            {
                entity = _appService.Get(id);
            
                if (entity == null)
                    return NotFound();
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
            }
            return View(_mapper.Map<TViewModel>(entity));
        }

        [HttpPost()]
        public virtual ActionResult Delete(TViewModel model)
        {
            try
            {
                _appService.Delete(_mapper.Map<TEntity>(model));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                return View(model);
            }

            return RedirectToAction("Index");
        }

        #endregion


    }
}
