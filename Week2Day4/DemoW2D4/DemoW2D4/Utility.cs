using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoW2D4
{
   static class Utility
    {
        public static int   DefaultVlaue { get; set; }

        public static DateTime GetCurrentTimeInUTC()
        {
            return DateTime.Now.ToUniversalTime();
        }

        public static DateTime GetIndiaCurrentTime()
        {
            return DateTime.Now;
        }


    }
}
