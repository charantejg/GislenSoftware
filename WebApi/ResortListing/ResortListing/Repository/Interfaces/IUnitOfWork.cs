using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResortListing.Data;

namespace ResortListing.Repository.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Resort> Resorts { get; }
        Task Save();

    }
}
