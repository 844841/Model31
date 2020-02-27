using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model31.Models
{
    public class Book
    {
        [Required]
        [Key]
         public int Bid { get; set; }
        [Display(Name ="Book Title")]
        [Required]
        public string Btitle { get; set; }

        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public double price { get; set; }
        [Display (Name ="Author Name")]
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }
        
    }
}
