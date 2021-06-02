using MyClassLib;
using System;

namespace CSharpSamples
{
    public enum Light
    {
        Red,
        Amber,
        Green,
        BlinkGreen
    };

    class Program
    {
        static void Main(string[] args)
        {
            ShowNextLight();

            //Tuple<string, int> t1 = Tuple.Create("abc", 42);  // read-only class tuple

            //// t1.Item2 = 11;
            //(string Demo, int X) t2 = ("magic", 42);  // read-write value-tuple

            //t2.X = 11;
            //ValueTuple<string, int> t3 = ("magic", 42);

            //var nextLight = GetNextLight(Light.Red);
            //int? i1 = null;
            //Nullable<int> i2 = null;

            //string? s1 = null;
            //Console.WriteLine(s1);

            //Foo(null!);  // ! - null-forgiving operator

            //Demo d1 = new();
            //string? s3 = d1.GetANullableString();

            //string? s4 = d1.GetAString();

            //s4 = null;
        }

        private static void ShowNextLight()
        {
            Light current = Light.Red;
            Light prev = Light.Red;
            for (int i = 0; i < 20; i++)
            {
                (current, prev) = GetNextLightv2(current, prev);
                Console.WriteLine($"current: {current}");
            }
        }

        static void Foo(string s)
        {           
            if (s is null) throw new ArgumentNullException(nameof(s));

            string s2 = s.ToUpper();
            Console.WriteLine(s2);
        }

        static Light GetNextLight(Light light) =>
        
            //switch (light)
            //{
            //    case Light.Red:
            //        break;
            //    case Light.Amber:
            //        break;
            //    case Light.Green:
            //        break;
            //    default:
            //        break;
            //}

            light switch
            {
                Light.Red => Light.Amber,
                Light.Amber => Light.Green,
                Light.Green => Light.Red,
                _ => throw new InvalidOperationException("invalid light value")
            };


        static (Light Current, Light Prev) GetNextLightv2(Light currentLight, Light previousLight)
        {
            return (currentLight, previousLight) switch
            {
                (Light.Red, _) => (Light.Amber, currentLight),
                (Light.Amber, Light.Red) => (Light.Green, currentLight),
                (Light.Green, _) => (Light.Amber, currentLight),
                (Light.Amber, Light.Green) => (Light.Red, currentLight),
                _ => throw new InvalidOperationException("invalid light state")
            };
        }

        static (Light Current, Light Prev) GetNextLightv3(Light currentLight, Light previousLight)
        {
            return (currentLight, previousLight) switch
            {
                (Light.Red, _) => (Light.Amber, currentLight),
                (Light.Amber, Light.Red) => (Light.Green, currentLight),
                (Light.Green, _) => (Light.BlinkGreen, currentLight),
                (Light.BlinkGreen, _) => (Light.Red, currentLight),
                (Light.Amber, Light.Green) => (Light.Red, currentLight),
                _ => throw new InvalidOperationException("invalid light state")
            };
        }

        static LightState GetNextLightv4(LightState lightState)
        {
            return lightState switch
            {
                { CurrentLight: Light.Red } => new LightState { CurrentLight = Light.Amber, PreviousLight = lightState.CurrentLight, Count = 1, TimeSeconds = 5},
                { CurrentLight: Light.Amber, PreviousLight: Light.Red} => new LightState { CurrentLight = Light.Green, PreviousLight = lightState.CurrentLight, Count = 1, TimeSeconds = 1},
                { CurrentLight: Light.Green } => new LightState { CurrentLight = Light.BlinkGreen, PreviousLight = lightState.CurrentLight, Count = 1, TimeSeconds = 1 },
                { CurrentLight: Light.BlinkGreen, Count: <= 3} => new LightState { CurrentLight = Light.BlinkGreen, PreviousLight =  lightState.CurrentLight, Count = lightState.Count + 1, TimeSeconds = 1},
                { CurrentLight: Light.BlinkGreen } => new LightState { CurrentLight = Light.Red, PreviousLight = lightState.CurrentLight, Count = 1, TimeSeconds = 1 },
                _ => new LightState {  CurrentLight = Light.Amber, PreviousLight = lightState.CurrentLight}

            };
            //return (currentLight, previousLight) switch
            //{
            //    (Light.Red, _) => (Light.Amber, currentLight),
            //    (Light.Amber, Light.Red) => (Light.Green, currentLight),
            //    (Light.Green, _) => (Light.BlinkGreen, currentLight),
            //    (Light.BlinkGreen, _) => (Light.Red, currentLight),
            //    (Light.Amber, Light.Green) => (Light.Red, currentLight),
            //    _ => throw new InvalidOperationException("invalid light state")
            //};
        }

        static LightState1 GetNextLightv5(LightState1 lightState)
        {
            return lightState switch
            {
                { CurrentLight: Light.Red } => lightState with { CurrentLight = Light.Amber, PreviousLight = lightState.CurrentLight },
                { CurrentLight: Light.Amber, PreviousLight: Light.Red } => lightState with { CurrentLight = Light.Green, PreviousLight = lightState.CurrentLight, TimeSeconds = 1 },
                { CurrentLight: Light.Green } => lightState with { CurrentLight = Light.BlinkGreen, PreviousLight = lightState.CurrentLight, Count = 1, TimeSeconds = 1 },
                { CurrentLight: Light.BlinkGreen, Count: <= 3 } => lightState with { CurrentLight = Light.BlinkGreen, PreviousLight = lightState.CurrentLight, Count = lightState.Count + 1, TimeSeconds = 1 },
                { CurrentLight: Light.BlinkGreen } => lightState with { CurrentLight = Light.Red, PreviousLight = lightState.CurrentLight, Count = 1, TimeSeconds = 1 },
                _ => throw new NotImplementedException("Implement other cases")

            };

        }


    }

    public class LightState
    {
        public Light CurrentLight { get; set; }
        public Light PreviousLight { get; set; }
        public int TimeSeconds { get; set; }
        public int Count { get; set; }
    }

    public record LightState1(Light CurrentLight, Light PreviousLight, int TimeSeconds, int Count);

}
