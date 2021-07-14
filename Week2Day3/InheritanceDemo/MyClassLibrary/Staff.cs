using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
  public class Staff : User
    {

        public Staff()
        {
            
        }

        private void Init()
        {
            var objCustomer = new Customer();
            objCustomer.GeneralInfo();

        }
       
    }
}
