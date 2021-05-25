using System;
using System.Threading;

namespace trafficLight
{
    class Program
    {

        enum TrafficLights
        {
            Amber,
            Red,
            Green
        }

        static void Main(string[] args)
        {
            TrafficLights trafficLight = (TrafficLights)1;
            //TrafficLights trafficLight = TrafficLights.Amber;
            //TrafficLights trafficLight = new TrafficLights();

            for(int i = 0; i < 10; i++)
            {
                trafficLight = ChangeTrafficLight(trafficLight);
                Console.WriteLine("currentLight: " + trafficLight);
                Thread.Sleep(1000);
            }
            
        }

        static TrafficLights ChangeTrafficLight(TrafficLights trafficLights)
        {
            return trafficLights switch
            {
                TrafficLights.Amber => TrafficLights.Red,
                TrafficLights.Red => TrafficLights.Green,
                TrafficLights.Green => TrafficLights.Amber,
                _ => TrafficLights.Amber
            };
        }
    }
}
