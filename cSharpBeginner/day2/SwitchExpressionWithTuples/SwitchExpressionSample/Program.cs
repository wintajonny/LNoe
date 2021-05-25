using System;
using System.Threading;

namespace SwitchExpressionSample
{

    enum TrafficLight
    {
        Amber,
        Red,
        Green
    }

    class Program
    {

        static (TrafficLight Current, TrafficLight Previous) NextLight(TrafficLight currentLight, TrafficLight previousLight)
        {
            return (currentLight, previousLight) switch
            {
                (TrafficLight.Red, _) => (TrafficLight.Amber, currentLight),
                (TrafficLight.Green, _) => (TrafficLight.Amber, currentLight),
                (TrafficLight.Amber, TrafficLight.Red) => (TrafficLight.Green, currentLight),
                (TrafficLight.Amber, TrafficLight.Green) => (TrafficLight.Red, currentLight),
                _ => (TrafficLight.Amber, currentLight)
            };
        }


        static void Main(string[] args)
        {

            TrafficLight currentLight = TrafficLight.Red;
            TrafficLight previousLight = TrafficLight.Red;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("current light: " + currentLight);
                (currentLight, previousLight) = NextLight(currentLight, previousLight);
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }
}
