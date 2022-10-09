using System.Collections.Generic;

namespace PatrykRuczkinLab5PracDom.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<BookViewModel> Books { get; set; }
    }
}