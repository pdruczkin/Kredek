using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PatrykRuczkinLab5PracDom.Models;
using PatrykRuczkinLab5PracDom.Models.DbModels;

namespace PatrykRuczkinLab5PracDom.Services
{
    public interface ICategoryService
    {
        CategoryViewModel GetByName(string name);
    }

    public class CategoryService : ICategoryService
    {
        //mapper used to map objects between 2 classes
        private readonly IMapper _mapper;

        //database provider
        private readonly DatabaseContext _context;

        public CategoryService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public CategoryViewModel GetByName(string name)
        {
            var category = _context
                .Categories
                .Include(c => c.Books)
                .Include(c => c.Books).ThenInclude(b => b.Author)
                .Include(c => c.Books).ThenInclude(b => b.Publisher)
                .SingleOrDefault(c => c.Name == name);


            var categoryViewModel = _mapper.Map<CategoryViewModel>(category);


            return categoryViewModel;
        }
    }
}