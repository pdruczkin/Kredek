using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatrykRuczkinLab5PracDom.Models.DbModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string  Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}