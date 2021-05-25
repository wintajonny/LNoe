using System;
using System.Threading;

namespace TrafficLight
{
    class Program
    {
        enum TrafficLight
        {
            Amber,
            Red,
            Green,
            GreenBlink
        }

        static void Main(string[] args)
        {
            int delay;
            Console.WriteLine("Input your desired delay between the lights (in MS):");
            var delayString = Console.ReadLine();
            if (!int.TryParse(delayString, out delay)) delay = 1000;
            TrafficLight currentLight = TrafficLight.Red;
            TrafficLight previousLight = TrafficLight.Red;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("current light: " + currentLight);
                (currentLight, previousLight) = ChangeTrafficLight(currentLight, previousLight);
                Thread.Sleep(delay);
            }

        }

        static (TrafficLight currentLight, TrafficLight previousLight) ChangeTrafficLight(TrafficLight inputTrafficLight, TrafficLight previousLight
            )
        {
            return (inputTrafficLight, previousLight) switch
            {
                (TrafficLight.Amber, TrafficLight.GreenBlink)   => (TrafficLight.Red, inputTrafficLight),
                (TrafficLight.Amber, TrafficLight.Red)          => (TrafficLight.Green, inputTrafficLight),
                (TrafficLight.Red, _)                           => (TrafficLight.Amber, inputTrafficLight),
                (TrafficLight.Green, _)                         => (TrafficLight.GreenBlink, inputTrafficLight),
                (TrafficLight.GreenBlink, TrafficLight.Green)   => (TrafficLight.Amber, inputTrafficLight),
                _ => (TrafficLight.Red,TrafficLight.Red)
            };
        }
    }
}
