using System;
using MyClassLibrary;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var square = new Square();
            square.Draw();

            var shapes = new Shapes();
            shapes = square;
            shapes.Draw();



        }
    }
}
