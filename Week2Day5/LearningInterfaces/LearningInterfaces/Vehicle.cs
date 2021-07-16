using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
    class Vehicle
    {
        

        public string RegistrationNumber { get; set; }
        public void Display()
        {

        }
    }

    class Car: Vehicle
    {
        public string CarModel { get; set; }

    }

    class Jeep: Vehicle
    {
        
    }
}
