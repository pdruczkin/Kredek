using Microsoft.EntityFrameworkCore;
using PatrykRuczkinLab5PracDom.Models;
using PatrykRuczkinLab5PracDom.Models.Dtos;

namespace PatrykRuczkinLab5PracDom.Models.DbModels
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PatrykRuczkinLab5PracDom.Models.BookViewModel> BookViewModel { get; set; }
        public DbSet<PatrykRuczkinLab5PracDom.Models.BookDetailsViewModel> BookDetailsViewModel { get; set; }
        public DbSet<PatrykRuczkinLab5PracDom.Models.AuthorViewModel> AuthorViewModel { get; set; }
        public DbSet<PatrykRuczkinLab5PracDom.Models.CategoryViewModel> CategoryViewModel { get; set; }
        public DbSet<PatrykRuczkinLab5PracDom.Models.PublisherViewModel> PublisherViewModel { get; set; }
        public DbSet<PatrykRuczkinLab5PracDom.Models.PublisherDetailsViewModel> PublisherDetailsViewModel { get; set; }
        public DbSet<PatrykRuczkinLab5PracDom.Models.Dtos.AddBookDto> AddBookDto { get; set; }

    }
}