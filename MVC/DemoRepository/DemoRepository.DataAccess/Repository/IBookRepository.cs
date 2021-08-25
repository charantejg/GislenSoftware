using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository.Models;

namespace DemoRepository.DataAccess.Repository
{
  public  interface IBookRepository
  {

      public void Update(Book book);
  }
}
