using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Shapes
    {
        public int  Height { get; set; }
        public int  Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("This is parent shape draw method");
        }
        
    }


    class Square: Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("This is Square shape Draw method");
        }
        
    }


}
