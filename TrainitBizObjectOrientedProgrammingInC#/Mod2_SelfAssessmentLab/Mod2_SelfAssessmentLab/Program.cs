using System;
using System.Collections;

namespace Mod2_SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            s1.FirstName = "Thomas";
            s1.LastName = "Winter";

            s2.FirstName = "Jonas";
            s2.LastName = "Stadler";

            s3.FirstName = "Bernhard";
            s3.LastName = "Piendl";

            Teacher t1 = new Teacher();
            t1.FirstName = "Margit";
            t1.LastName = "Höfinger";


            s1.TakeTest();
            s2.TakeTest();
            s3.TakeTest();

            t1.GradeTest();
        }
    }
}
