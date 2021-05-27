using System;

namespace Module1Lab02
{
    class Program
    {
        record Person {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            DateTime birthDate = new DateTime(2000, 1, 1);
            string addressLine1 = "";
            string addressLine2 = "";
            string city = "";
            string province = "";
            int zipCode = 0;
            string country = "";

            public Person(string firstName, string lastName, DateTime birthDate, string addressLine1, string addressLine2, string city, string province, int zipCode, string country)
            {
                FirstName = firstName;
                LastName = lastName;
                this.birthDate = birthDate;
                this.addressLine1 = addressLine1;
                this.addressLine2 = addressLine2;
                this.city = city;
                this.province = province;
                this.zipCode = zipCode;
                this.country = country;
            }
        }

        record Course{
            string courseName = "";
            int credits = 0;
            int durationWeeks = 0;
            Person teacher;

            public Course(string courseName, int credits, int durationWeeks, Person teacher)
            {
                this.courseName = courseName;
                this.credits = credits;
                this.durationWeeks = durationWeeks;
                this.teacher = teacher;
            }

            public override string ToString()
            {
                return $"Course: {courseName}\n Required Credits { credits} \n Duration: {durationWeeks}\n Teacher: {teacher.FirstName} {teacher.LastName}";
            }
        }

        static void Main(string[] args)
        {

            Person teacher1 = new Person("Thomas", "Winter", new DateTime(1998, 11, 02), "Laimbach 201", "Rafles 1", "Laimbach am Ostrong", "Lower Austria", 3663, "Austria");
            Person teacher2 = new Person("Natalie", "Maier", new DateTime(1999, 01, 14), "Laimbach 201", "Rafles 1", "Weiten", "Lower Austria", 3653, "Austria");


            Course course1 = new Course("Mathe", 11, 4, teacher1);
            Course course2 = new Course("Chemie", 5, 2, teacher2);


            Console.WriteLine(course1.ToString());
            Console.WriteLine(course2.ToString());

        }
    }
}
