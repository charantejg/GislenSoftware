using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookShop.Models
{
    [Table("Book")]
    public class Book
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "The title is required")]
        [StringLength(25, ErrorMessage = "Title can not exceed 25 characters")]
        public string  Title { get; set; }
        [DisplayName("Book Value")]
        public double Price { get; set; }
        
        public int BookCategoryId { get; set; }
        [ForeignKey("BookCategoryId")]
        public virtual BookCategory BookCategory { get; set; }

    }
}
