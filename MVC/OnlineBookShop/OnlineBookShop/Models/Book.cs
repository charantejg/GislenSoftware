using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookShop.Models
{
    public class Book
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "The title is required")]
        [StringLength(25, ErrorMessage = "Title can not exceed 25 characters")]
        public string  Title { get; set; }
        [DisplayName("Book Value")]
        public double Price { get; set; }

    }
}
