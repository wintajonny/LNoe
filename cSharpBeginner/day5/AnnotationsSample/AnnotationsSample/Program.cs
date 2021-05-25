using AnnotationsSample;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[assembly: MySample("global setting")]

namespace AnnotationsSample
{


    class Program
    {
        static void Main(string[] args)
        {
            // Foo();

            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            var types = thisAssembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type.Name);

                var attributes = type.GetCustomAttributes();
                foreach (var attr in attributes)
                {
                    if (attr is MySampleAttribute mySampleAttribute)
                    {
                        Console.WriteLine($"Found {nameof(MySampleAttribute)} on {type.Name}");
                        Console.WriteLine($"{mySampleAttribute.PositionalString} {mySampleAttribute.NamedInt}");
                        mySampleAttribute.SomeAction();
                    }
                }
            }
        }

        [Obsolete("Use Bar instead")]
        static void Foo()
        {

        }

        static void Bar()
        {

        }
    }

    public record MyRecord([property: MySample("property attribute")] int MyProp1, string MyProp2);

    [MySample("required", NamedInt = 42)]
    class Test
    {
        [MySample("method info")]
        public void Foo()
        {

        }

        [field: MySample("field attribute")]
        public string MyAutoProp { get; set; }
    }

    public class Person
    {
        [XmlAttribute("Vorname")]
        public string? FirstName { get; set; }

        [StringLength(20)]
        public string? LastName { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public string Name => FirstName + " " + LastName;
    }
}
