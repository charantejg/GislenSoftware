using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Customer
    {
        private readonly Login _login;
        private readonly DbConnection _dbConnection;

        public Customer()
        {
            
        }
        public Customer(Login login, DbConnection dbConnection)
        {
            _login = login;
            _dbConnection = dbConnection;
        }

        protected void InfoAboutGold()
        {

        }

       protected internal void GeneralInfo()
        {

        }

        public double WalletBalance { get; set; }


        public void DisplayCustomerInfo()
        {
            
        }
    }
}
