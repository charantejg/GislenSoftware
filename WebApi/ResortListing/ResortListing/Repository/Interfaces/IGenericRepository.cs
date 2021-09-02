using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortListing.Repository.Interfaces
{
   public interface IGenericRepository<T> where T : class
   {
       Task<IList<T>> GetAll();
       Task<T> Get();
       Task Insert(T entity);
        //update - can be kept out of generic repository 
        void Delete(T entity);
       Task Delete(int id);
   }
}
