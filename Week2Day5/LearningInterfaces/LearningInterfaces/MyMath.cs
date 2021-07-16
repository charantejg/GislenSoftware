using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
    class MyMath
    {
        private readonly float f1, f2;

        public MyMath(float f1, float f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }

        public float Add()
        {
            return f1 + f2;
        }
        
    }

    //Extension method 

    static class ExtendMath
    {
        public static int Average(this MyMath myMath)
        {
            return 5;
        }
    }
    



}
