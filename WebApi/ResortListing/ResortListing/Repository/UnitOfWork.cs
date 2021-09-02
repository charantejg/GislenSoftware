using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResortListing.Data;
using ResortListing.Repository.Interfaces;

namespace ResortListing.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Resort> _resorts;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Resort> Resorts => _resorts ??= new GenericRepository<Resort>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
