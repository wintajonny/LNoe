using System;
using System.Threading;
using C = MyCalculator;
using Calc = MyCalculator.Math;

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
        static TrafficLight NextLightClassicSwitch(TrafficLight light)
        {
            TrafficLight nextLight;
            switch (light)
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

        static TrafficLight NextLightSwitchExpression(TrafficLight light)
        {
            return light switch
            {
                TrafficLight.Amber => TrafficLight.Red,
                TrafficLight.Red => TrafficLight.Green,
                TrafficLight.Green => TrafficLight.Amber,
                _ => TrafficLight.Amber
            };
        }


        static void Main(string[] args)
        {
            C.Math m = new C.Math();
            m.Add(4, 38);
            Calc m2 = new Calc();


            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            TrafficLight currentLight = TrafficLight.Amber;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("current light: " + currentLight);
                currentLight = NextLightClassicSwitch(currentLight);
                Thread.Sleep(1000);
            }
      
        }
    }
}
