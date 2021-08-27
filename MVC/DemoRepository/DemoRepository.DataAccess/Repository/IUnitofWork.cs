using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository.DataAccess.Repository
{
  public interface IUnitofWork: IDisposable
  {
     // IBookRepository bookRepository { get; set; }
      void Save();
  }


}
