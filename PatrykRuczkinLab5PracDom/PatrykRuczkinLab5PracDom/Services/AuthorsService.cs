using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PatrykRuczkinLab5PracDom.Models;
using PatrykRuczkinLab5PracDom.Models.DbModels;

namespace PatrykRuczkinLab5PracDom.Services
{
    public interface IAuthorsService
    {
        List<AuthorViewModel> GetByFullName(string fullName);
        Author GetById(int id);
    }

    public class AuthorsService : IAuthorsService
    {
        //mapper used to map objects between 2 classes
        private readonly IMapper _mapper;

        //database provider
        private readonly DatabaseContext _context;

        public AuthorsService(IMapper mapper, DatabaseContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public List<AuthorViewModel> GetByFullName(string fullName)
        {

            var names = fullName.Split(" ");

            var authors = _context
                .Authors
                .Include(a => a.Books)
                .Include(a => a.Books).ThenInclude(b => b.Category)
                .Include(a => a.Books).ThenInclude(b => b.Publisher)
                .Where(a => a.FirstName == names[0] && a.LastName == names[1]);

            var authorsViewModel = _mapper.Map<List<AuthorViewModel>>(authors);

            return authorsViewModel;
        }

        public Author GetById(int id)
        {
            var author = _context
                .Authors
                .Include(a => a.Books)
                .Include(a => a.Books).ThenInclude(b => b.Category)
                .Include(a => a.Books).ThenInclude(b => b.Publisher)
                .SingleOrDefault(a => a.Id == id);

            return author;
        }
    }
}