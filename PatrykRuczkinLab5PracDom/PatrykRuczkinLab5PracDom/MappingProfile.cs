using AutoMapper;
using PatrykRuczkinLab5PracDom.Models;
using PatrykRuczkinLab5PracDom.Models.DbModels;
using PatrykRuczkinLab5PracDom.Models.Dtos;

namespace PatrykRuczkinLab5PracDom
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookViewModel>()
                .ForMember(m => m.AuthorFullName, c => c.MapFrom(s => $"{s.Author.FirstName} {s.Author.LastName}"))
                .ForMember(m => m.CategoryName, c => c.MapFrom(s => s.Category.Name));

            CreateMap<Book, BookDetailsViewModel>()
                .ForMember(m => m.AuthorFullName, c => c.MapFrom(s => $"{s.Author.FirstName} {s.Author.LastName}"))
                .ForMember(m => m.CategoryName, c => c.MapFrom(s => s.Category.Name))
                .ForMember(m => m.PublisherName, c => c.MapFrom(s => s.Publisher.Name));

            CreateMap<Publisher, PublisherViewModel>();
            CreateMap<Publisher, PublisherDetailsViewModel>();

            CreateMap<Category, CategoryViewModel>();
            


            CreateMap<Author, AuthorViewModel>()
                .ForMember(m => m.FullName, c => c.MapFrom(s => $"{s.FirstName} {s.LastName}"));


            CreateMap<AddBookDto, Book>();

            CreateMap<EditBookDto, Book>();
        }
    }
}