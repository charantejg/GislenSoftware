using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository.DataAccess.Data;

namespace DemoRepository.DataAccess.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _db;
        public IBookRepository bookRepository { get; set; }

        public UnitofWork(ApplicationDbContext db)
        {
            _db = db;
            bookRepository = new BookRepository(_db);
        }
        

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
