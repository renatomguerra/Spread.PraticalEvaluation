using AutoMapper;
using Spread.PraticalEvaluation.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Spread.PraticalEvaluation.UI.Web.Models.Cadastros
{
    public class BookViewModel : BaseViewModel<int>
    {
        [DisplayName("Título")]
        [Required(ErrorMessage = "O campo 'Título' deve ser preenchido.")]
        public string Title { get; set; }

        [DisplayName("Autor")]        
        [Required(ErrorMessage = "O campo 'Autor' deve ser preenchido.")]
        public string AuthorId { get; set; }

        public AuthorViewModel? Author { get; set; }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "O campo 'Categoria' deve ser preenchido.")]
        public string CategoryId { get; set; }

        public CategoryViewModel? Category { get; set; }

    }
}
