using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Get(int id)
        {
            return Ok("Customer Id is " + id);
        }

        public IActionResult GetSomeData([FromQuery] string firstname, [FromQuery] string lastname)
        {

            return Ok("The values are " + firstname +"  and " + lastname);

        }

        #region Headers

        /// <summary>
        /// This method is a demo of header parameter
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult HeaderDemo([FromHeader] string token)
        {
            return Ok("Received the token " + token);
        }

        #endregion

        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            book.Title = book.Title + "new value";
            return Ok(book);
        }

        [HttpPost]
        public IActionResult UploadFile([FromForm] string name, [FromForm] IFormFile file)
        {
            return Ok("success");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
