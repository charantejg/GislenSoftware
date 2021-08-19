using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Models;
using Demo1.ViewModel;

namespace Demo1.Controllers
{
  
    public class BookController : Controller
    {
        
        public IActionResult Index()
        {
            var book = new Book {Id = 101, Title = "Let us C"};

            return View(book);
        }

       
        public IActionResult Details()
        {
            var customerBooks = new CustomerBooks();
            customerBooks.book = new Book() {Id = 101, Title = "Let us C"};
            customerBooks.customer = new Customer() {Id = 1,Name = "Shahaj"};

            return View(customerBooks);
        }



    }
    
}
