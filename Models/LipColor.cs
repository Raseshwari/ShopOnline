using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Models
{
    public class LipColor 
    {
        [Key]
        public int Cprodid { get; set; }

        [Required, MaxLength(60)]
        [Display(Name = "Brand Name")]
        public string Cprodname { get; set; }

        [Display(Name ="Shade")]
        public CShadeColor CShade { get; set; }
    }
}
