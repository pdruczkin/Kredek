using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatrykRuczkinLab5PracDom.Models.DbModels
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        
        [MaxLength(500)] 
        public string Description { get; set; }
        
        [Required]
        public int YearOfRelease { get; set; }

        [Required]
        public int PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set;}
        
        [Required]
        public int CategoryId { get; set; }


        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

    }
}