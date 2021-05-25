using System;
using System.Collections.Specialized;
using System.Threading;

namespace TrafficLightTuples
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

            //if (args.Length > 0)
            //{
            //    if (Enum.IsDefined(typeof(TrafficLight), args[0]))
            //    {
            //        currentLight = (TrafficLight)Enum.Parse(typeof(TrafficLight), args[0]);
            //    }
            //}
            TrafficLight currentLight = TrafficLight.Red;
            TrafficLight previousLight = TrafficLight.Red;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current Light: {currentLight}");
                (currentLight, previousLight) = NextLight(currentLight, previousLight);
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Switch to the next TrafficLight
        /// </summary>
        static (TrafficLight Current, TrafficLight Previous) NextLight(TrafficLight currentLight, TrafficLight previousLight) => (currentLight, previousLight) switch
        {
            (TrafficLight.Red, _) => (TrafficLight.Green, currentLight),
            (TrafficLight.Green, _) => (TrafficLight.GreenBlink, currentLight),
            (TrafficLight.GreenBlink, _) => (TrafficLight.Amber, currentLight),
            (TrafficLight.Amber, TrafficLight.GreenBlink) => (TrafficLight.Red,currentLight),
            _ => (TrafficLight.Amber, currentLight)
        };
    }
}
