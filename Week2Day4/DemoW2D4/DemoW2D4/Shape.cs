using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoW2D4
{
   abstract class Shape : SuperClass
    {
        public abstract void Draw();

        public string GetColor()
        {
            return "White";
        }

    }


   class SuperClass
   {
       public void DrawSuper()
       {
           Console.WriteLine("Super shape is completed");
        }
   }


    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Square shape is compelted");
        }
    }


}
