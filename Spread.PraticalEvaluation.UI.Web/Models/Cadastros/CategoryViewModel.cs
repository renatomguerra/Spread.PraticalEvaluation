using AutoMapper;
using Spread.PraticalEvaluation.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Spread.PraticalEvaluation.UI.Web.Models.Cadastros
{
    public class CategoryViewModel : BaseViewModel<short>
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo 'Nome da categoria' deve ser preenchido.")]
        public string Name { get; set; }
    }
}
