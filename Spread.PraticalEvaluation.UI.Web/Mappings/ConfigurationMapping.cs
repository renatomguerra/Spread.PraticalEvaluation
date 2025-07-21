using AutoMapper;
using Spread.PraticalEvaluation.Domain.Entities;
using Spread.PraticalEvaluation.UI.Web.Models.Cadastros;

namespace Spread.PraticalEvaluation.UI.Web.Mappings
{
    public class ConfigurationMapping: Profile
    {
        private ConfigurationMapping() 
        {
            CreateMap<Author, AuthorViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Book, BookViewModel>().ReverseMap();
        }   

        public static IMapper CreateMapper()
        {

            var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new ConfigurationMapping());
                });

            return config.CreateMapper();
        }

    }
}
