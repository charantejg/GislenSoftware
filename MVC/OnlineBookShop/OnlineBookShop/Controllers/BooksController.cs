using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBookShop.Business;
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

        public async Task<IActionResult>  Index(
            string sortOrder, 
            string searchText,
            int? pageNumber)
        {
            ViewData["TitleSortParam"] = sortOrder =="Title" ? "title_desc" : "title_asc";
            ViewData["PriceSortParam"] = sortOrder == "Price" ? "price_desc" : "price_asc";
            ViewData["currentSearch"] = searchText;

            var bookList = from books in _db.Books select books;

            if (!string.IsNullOrEmpty(searchText))
            {
                bookList = bookList.Where(x => x.Title.ToLower().
                    Contains(searchText.ToLower()));
            }

            switch (sortOrder)
            {
                case "title_asc":
                    bookList = bookList.OrderBy(x => x.Title);
                    break;
                case "title_desc":
                    bookList = bookList.OrderByDescending(x => x.Title);
                    break;
                case "price_asc":
                    bookList = bookList.OrderBy(x => x.Price);
                    break;
                case "price_desc":
                    bookList = bookList.OrderByDescending(x => x.Price);
                    break;
                default:
                    bookList = bookList.OrderBy(x => x.Id);
                    break;
            }

            int pageSize = 5;
            //return View(await bookList.ToListAsync());
            return View(Pagination<Book>.Display(bookList, pageNumber ?? 1, pageSize));

        }


        public IActionResult Create()
        {
            // get the book categories from Db
            IEnumerable<SelectListItem> myCategories = _db.BookCategories.Select(x=> 
                new SelectListItem
                {
                    Text = x.CategoryName,
                    Value =  x.Id.ToString()
                });

               ViewBag.myDropdown = myCategories;
            
            
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

        public IActionResult Delete(int? id)
        {
            var objBook = _db.Books.Find(id);
            if (objBook == null)
            {
                return NotFound();
            }

            _db.Books.Remove(objBook);
            _db.SaveChanges();
            
            return RedirectToAction("Index");
        }
        

    }
}
