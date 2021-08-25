using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookShop.Models
{
    public class BookCategory
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
