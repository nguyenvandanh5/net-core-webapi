using AutoMapper;
using MyWebApiApp.Data.BookContext;
using MyWebApiApp.Models;

namespace MyWebApiApp.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
