namespace PatrykRuczkinLab5PracDom.Models
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFullName { get; set; }
        public string CategoryName { get; set; }
        public string PublisherName { get; set; }
        public string Description { get; set; }
        public int YearOfRelease { get; set; }
    }
}