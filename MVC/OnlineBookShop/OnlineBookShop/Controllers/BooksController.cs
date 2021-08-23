using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookShop.Data;
using OnlineBookShop.Models;

namespace OnlineBookShop.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BooksController(ApplicationDbContext db)
        {
            _db = db;
            
        }

        public IActionResult Index()
        {
            IEnumerable<Book> bookList = _db.Books;
            
            return View(bookList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book objBook)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(objBook);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(objBook);

        }

      
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objBook = _db.Books.FirstOrDefault(x => x.Id == id);
            if (objBook == null)
            {
                return NotFound();
            }

            return View(objBook);

        }

        [HttpPost]
        public IActionResult Update(Book objBook)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Update(objBook);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objBook);

        }

        

    }
}
