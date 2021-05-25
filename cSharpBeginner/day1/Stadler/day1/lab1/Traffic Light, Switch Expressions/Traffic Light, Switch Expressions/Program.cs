using System;
using System.Threading;

namespace Traffic_Light__Switch_Expressions
{
    enum TrafficLight
    {
        Amber,
        Red,
        Green        
    }
    class Program
    {
        static TrafficLight NextLightClassicSwitch(TrafficLight light)
        {
            TrafficLight nextLight;
            switch(light)
            {
                case TrafficLight.Amber:
                    nextLight = TrafficLight.Red;
                    break;
                case TrafficLight.Red:
                    nextLight = TrafficLight.Green;
                    break;
                case TrafficLight.Green:
                    nextLight = TrafficLight.Amber;
                    break;
                default:
                    nextLight = TrafficLight.Amber;
                    break;
            }
            return nextLight;
        }
        static void Main(string[] args)
        {
            TrafficLight currentLight = TrafficLight.Amber;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("current Light:" + currentLight);
                currentLight = NextLightClassicSwitch(currentLight);
                Thread.Sleep(1000);
            }

        }
    }
}
