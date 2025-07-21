using AutoMapper;
using Spread.PraticalEvaluation.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Spread.PraticalEvaluation.UI.Web.Models.Cadastros
{
    public class AuthorViewModel : BaseViewModel<int>
    {

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo 'Nome do autor' deve ser preenchido.")]
        public string Name { get; set; }
    }
}
