using System;
using System.Threading;

namespace TrafficLightSwitchExpression
{
    class Program
    {

        enum TrafficLight
        {
            Amber = 0,
            Red = 1,
            Green = 2
        }

        static void Main(string[] args)
        {
            int delay;
            Console.WriteLine("Input your desired delay between the lights (in MS):");
            var delayString = Console.ReadLine();
            if (!int.TryParse(delayString, out delay)) delay = 1000;
            TrafficLight currentLight = TrafficLight.Amber;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("current light: " + currentLight);
                currentLight = ChangeTrafficLight(currentLight);
                Thread.Sleep(delay);
            }

        }

        static TrafficLight ChangeTrafficLight (TrafficLight inputTrafficLight)
        {
            return inputTrafficLight switch
            {
                TrafficLight.Amber => TrafficLight.Red,
                TrafficLight.Red => TrafficLight.Green,
                TrafficLight.Green => TrafficLight.Amber,
                _ => TrafficLight.Amber
            };
        }

    }
}
