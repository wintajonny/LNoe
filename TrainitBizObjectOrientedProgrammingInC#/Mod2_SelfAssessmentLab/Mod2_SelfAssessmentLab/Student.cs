using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssessmentLab
{
    class Student : Person
    {



        public void TakeTest()
        {
            Console.WriteLine( FirstName + " " + LastName + " is taking a test");
        }
    }
}
