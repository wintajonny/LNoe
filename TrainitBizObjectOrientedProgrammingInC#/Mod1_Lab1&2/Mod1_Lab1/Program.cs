using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lab 1
            var Car1 = new Car();

            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;
            
            Console.WriteLine($"This car is painted {Car1.Color}, was build in {Car1.Year}, and has {Car1.Mileage} miles on it.");
            */


            var Car2 = new Car("Red", 2008);
            var Car3 = new Car(2005, 100000);

            Console.WriteLine($"This car is painted {Car2.Color}, was build in {Car2.Year}, and has {Car2.Mileage} miles on it.");

            int carCount = Car.CountCars();

            Console.WriteLine($"There are {carCount} cars on inventory right now");


        }
    }


    public class Car{
        private static int numberOfCars = 0;


        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            numberOfCars++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            numberOfCars++;
        }

        public Car()
        {
            numberOfCars++;
        }

        public static int CountCars()
        {
            return numberOfCars;
        }




    }



}
