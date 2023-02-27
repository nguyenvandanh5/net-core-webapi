using AutoMapper;
using MyWebApiApp.Data;
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
