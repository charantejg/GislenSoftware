using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
   public class User
    {
        public  int  UserId { get; set; }
        public string UserName { get; set; }

        //protected
        protected string UserType { get; set; } 

        protected void UserInfoProtected()
        {
            Console.WriteLine($"{UserId}, {UserName} ");
        }
        
        public void UserInfoPublic()
        {
            Console.WriteLine($"{UserId}, {UserName} ");
        }
        

    }
}
