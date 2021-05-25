using System;
using System.Threading;

namespace trafficLights
{
    enum TrafficLights
    {
        Green,
        Orange,
        Red
    }
    class Program
    {
        static TrafficLights NextLightClassSwith(TrafficLights light)
        {
            TrafficLights nextLight;

            switch (light)
            {
                case TrafficLights.Orange:
                    nextLight = TrafficLights.Red;
                    break;
                case TrafficLights.Red:
                    nextLight = TrafficLights.Green;
                    break;
                case TrafficLights.Green:
                    nextLight = TrafficLights.Orange;
                    break;
                default:
                    nextLight = TrafficLights.Orange;
                    break;
            }

            return nextLight;
        }

        static void Main(string[] args)
        { 
            TrafficLights currentLight = TrafficLights.Orange;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"current light: {currentLight}");
                currentLight = NextLightClassSwith(currentLight);
                Thread.Sleep(1000);
            }
        }
    }

}