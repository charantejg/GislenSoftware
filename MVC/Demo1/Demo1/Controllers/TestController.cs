using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Demo1.Controllers
{
    public class TestController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public TestController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StatusCodeCheck()
        {
            return Ok();

        }

        public IActionResult StatusCodeCheckwihObject()
        {
            return Ok(new { bookname= "Let us c" });

            // NotFound()
            //Unauthorized()


        }

        public IActionResult NotfoundObject()
        {
            var result = new NotFoundObjectResult(new
            {
                 message = "404 not found" ,
                 Details =" this is a common error"
            });

            return result;

        }

        public IActionResult RedirectDemo()
        {
            return Redirect("https://www.google.com");

            //LocalRedirect 
        }

        public IActionResult RedirectDemo2()
        {
            return RedirectToAction("Index", "Book");
        }

        public FileResult DownloadFile()
        {
            return File("/files/Roth_2017_UXUIDesign_Final.pdf", "application/pdf");

        }

        public FileContentResult DownloadContent()
        {
            var myfile = System.IO.File.ReadAllBytes("wwwroot/files/Roth_2017_UXUIDesign_Final.pdf");

            return new FileContentResult(myfile, "application/pdf");
        }

        public PhysicalFileResult DownloadPhysicalFile()
        {
            var myFile = _env + "wwwroot/files/Roth_2017_UXUIDesign_Final.pdf";
          var result = DownloadFile(myFile);
          return result;

        }

        private PhysicalFileResult DownloadFile(string path)
        {
            return new PhysicalFileResult(path, "application/pdf");
        }
        

      

    }
}
;