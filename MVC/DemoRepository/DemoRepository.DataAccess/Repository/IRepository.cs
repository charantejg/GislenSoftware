using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository.DataAccess.Repository
{
   public interface IRepository<T> where T: class
   {
       T Get(int id);

       IEnumerable<T> GetAll();

       void Add(T entity);
       void Remove(T entity);

   }
}
