using System.Collections.Generic;
using PatrykRuczkinLab5PracDom.Models.DbModels;

namespace PatrykRuczkinLab5PracDom.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ICollection<BookViewModel> Books { get; set; }
    }
}