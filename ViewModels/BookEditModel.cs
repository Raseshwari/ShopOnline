using ShopOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.ViewModels
{
    public class BookEditModel
    {
        [Required, MaxLength(60)]
        public string BookName { get; set; }
        public BookType Type { get; set; }

        [Required]
        public string BookAuthor { get; set; }
    }
}
