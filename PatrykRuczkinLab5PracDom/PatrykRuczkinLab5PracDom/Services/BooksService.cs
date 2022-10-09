using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PatrykRuczkinLab5PracDom.Models;
using PatrykRuczkinLab5PracDom.Models.DbModels;
using PatrykRuczkinLab5PracDom.Models.Dtos;

namespace PatrykRuczkinLab5PracDom.Services
{
    public interface IBooksService
    {
        ICollection<BookViewModel> GetAll();

        BookDetailsViewModel GetById(int id);

        void Add(AddBookDto dto);

        void Delete(int id);

        void Edit(EditBookDto dto);

    }

    public class BooksService : IBooksService
    {
        //mapper used to map objects between 2 classes
        private readonly IMapper _mapper;

        //database provider
        private readonly DatabaseContext _context;


        public BooksService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public ICollection<BookViewModel> GetAll()
        {
            var books = _context
                .Books
                .Include(b => b.Author)
                .Include(b => b.Category)
                .ToList();


            var booksViewModels = _mapper.Map<List<BookViewModel>>(books);

            return booksViewModels;
        }

        public BookDetailsViewModel GetById(int id)
        {
            var book = _context
                .Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.Category)
                .SingleOrDefault(b => b.Id == id);

            var bookDetailsViewModel = _mapper.Map<BookDetailsViewModel>(book);

            return bookDetailsViewModel;
        }


        public void Add(AddBookDto dto)
        {
            if (_context.Authors.FirstOrDefault(a => a.Id == dto.AuthorId) == null) return;
            if (_context.Publishers.FirstOrDefault(p => p.Id == dto.PublisherId) == null) return;
            if (_context.Categories.FirstOrDefault(c => c.Id == dto.CategoryId) == null) return;


            var book = _mapper.Map<Book>(dto);

            _context.Books.Add(book);

            _context.SaveChanges();

        }


        public void Delete(int id)
        {

            var book = _context
                .Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.Category)
                .SingleOrDefault(b => b.Id == id);

            if (book == null) return;

            _context.Remove(book);

            _context.SaveChanges();

        }

        public void Edit(EditBookDto dto)
        {

            var book = _context
                .Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.Category)
                .SingleOrDefault(b => b.Id == dto.Id);

            if (book == null) return;
            
            
            book.YearOfRelease = dto.YearOfRelease;
            book.Description = dto.Description;
            book.Title = dto.Title;

            _context.Books.Update(book);
            _context.SaveChanges();

        }
    }
}