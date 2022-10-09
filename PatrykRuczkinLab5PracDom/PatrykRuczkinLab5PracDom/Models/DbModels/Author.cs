using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatrykRuczkinLab5PracDom.Models.DbModels
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
       
        public ICollection<Book> Books { get; set; }
    }
}