namespace PatrykRuczkinLab4PracDom.Models
{
    public class RecipeViewModel
    {
        public RecipeViewModel(int id, string name, string description, decimal price, string photo)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Photo = photo;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }

    }
}