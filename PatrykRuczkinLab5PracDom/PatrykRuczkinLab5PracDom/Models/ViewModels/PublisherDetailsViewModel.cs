using System.Collections.Generic;
using PatrykRuczkinLab5PracDom.Models.DbModels;

namespace PatrykRuczkinLab5PracDom.Models
{
    public class PublisherDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int YearOfEstablishment { get; set; }
        
        public List<BookViewModel> Books { get; set; }
    }
}