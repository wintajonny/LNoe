using System;
using System.Threading;

namespace trafficLight
{
    class Program
    {

        enum TrafficLights
        {
            Amber = 1,
            Red = 0,
            Green = 2,
            GreenBlink = 3
        }

        static void Main(string[] args)
        {
            //TrafficLights trafficLight = (TrafficLights)1;
            TrafficLights previousLight = TrafficLights.Red;
            TrafficLights currentLight = TrafficLights.Red;
            //TrafficLights trafficLight = new TrafficLights();

            for(int i = 0; i < 10; i++)
            {
                (currentLight, previousLight) = ChangeTrafficLight(currentLight,previousLight);
                Console.WriteLine("currentLight: " + currentLight);
                Thread.Sleep(1000);
            }
            
        }

        static (TrafficLights, TrafficLights) ChangeTrafficLight(TrafficLights currentLight, TrafficLights previousLight)
        {
            return (currentLight, previousLight) switch
            {
                (TrafficLights.Red, _) => (TrafficLights.Amber, currentLight),
                (TrafficLights.Amber, TrafficLights.Red) => (TrafficLights.Green, currentLight),
                (TrafficLights.Green, TrafficLights.Amber) => (TrafficLights.GreenBlink, currentLight),
                (TrafficLights.GreenBlink, TrafficLights.Green) => (TrafficLights.Amber, currentLight),
                (TrafficLights.Amber, TrafficLights.GreenBlink) => (TrafficLights.Red, currentLight),
                (_,_) => (TrafficLights.Red, TrafficLights.Red)
            };
        }
    }
}
