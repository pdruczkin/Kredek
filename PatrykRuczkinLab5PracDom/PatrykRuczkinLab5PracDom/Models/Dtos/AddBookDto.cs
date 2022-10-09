using Microsoft.EntityFrameworkCore;

namespace PatrykRuczkinLab5PracDom.Models.Dtos
{
    [Keyless]
    public class AddBookDto
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public int YearOfRelease { get; set; }

        public int PublisherId { get; set; }

        public int CategoryId { get; set; }

        public int AuthorId { get; set; }

    }
}