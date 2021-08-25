using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository.DataAccess.Data;
using DemoRepository.Models;

namespace DemoRepository.DataAccess.Repository
{
   public class BookRepository: Repository<Book> , IBookRepository
   {
       private readonly ApplicationDbContext _db;

        
        public BookRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Book book)
        {
           //TODO:  to be implemented 
        }

   }
}
