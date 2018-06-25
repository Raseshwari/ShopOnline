using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [Display(Name = "Book Name")]
        [Required, MaxLength(60)]
        public string BookName { get; set; }

        [Display(Name = "Author"), Required]
        public string BookAuthor { get; set; }

        public BookType Type { get; set; }
    }
}
