using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookShop.Data;
using OnlineBookShop.Models;

namespace OnlineBookShop.Controllers
{
    public class BookCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<BookCategory> objCategory = _db.BookCategories;
            return View(objCategory);
        }

        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookCategory objCategory)
        {
           await _db.BookCategories.AddAsync(objCategory);
           await _db.SaveChangesAsync();

           return RedirectToAction("Index");
        }

        
    }
}
