using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository.DataAccess.Data;
using DemoRepository.Models;

namespace DemoRepository.DataAccess.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _db;

        private IRepository<Book> _books;

        public UnitofWork(ApplicationDbContext db)
        {
            _db = db;
           // bookRepository = new BookRepository(_db);
        }

        public IRepository<Book> Books => _books ??=new Repository<Book>(_db);
        
        public void Dispose()
        {
            _db.Dispose();
            
        }
        

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
