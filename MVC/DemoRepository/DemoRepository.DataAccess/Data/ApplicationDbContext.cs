using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoRepository.DataAccess.Data
{
   public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }


    }
}
