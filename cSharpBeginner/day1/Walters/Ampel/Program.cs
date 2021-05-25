using System;
using System.Threading;

namespace Ampel
{
    class Program
    {
        enum TrafficLight
        {
            Amber,
            Red,
            Green
        }
        static void Main(string[] args)
        {

            TrafficLight currentLight = TrafficLight.Amber;
            if (args.Length > 0)
            {
                if (Enum.IsDefined(typeof(TrafficLight), args[0]))
                {
                    currentLight = (TrafficLight)Enum.Parse(typeof(TrafficLight), args[0]);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current Light: {currentLight}");
                currentLight = SwitchTrafficLight(currentLight);
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Switch to the next TrafficLight
        /// </summary>
        /// <param name="light">The Current TrafficLight to be switched</param>
        /// <returns></returns>
        static TrafficLight SwitchTrafficLight(TrafficLight light) => light switch
        {
            TrafficLight.Amber => TrafficLight.Red,
            TrafficLight.Red => TrafficLight.Green,
            TrafficLight.Green => TrafficLight.Amber,
            _ => TrafficLight.Amber
        };
    }
}
