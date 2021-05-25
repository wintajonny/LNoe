using System;

namespace InheritanceWithRecords
{
    public class MyData
    {
        public int X { get; set; }
    }

    public record Position(int X, int Y);
    public record Size(int Width, int Height);
    public abstract record Shape(Position Position, Size Size)
    {
      //  public MyData? Data { get; set; }
        public void Draw() => DisplayShape();
        protected virtual void DisplayShape()
        {
            Console.WriteLine($"Shape with {Position} and {Size}");
        }
    }

    public record Rectangle(Position Position, Size Size) : Shape(Position, Size)
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Rectangle with {Position} and {Size}");
        }
    }

    public record Ellipse(Position Position, Size Size) : Shape(Position, Size)
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Ellipse with {Position} and {Size}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new(new Position(20, 20), new Size(40, 80));
            r1.Draw();

            Shape s1 = new Ellipse(new Position(80, 20), new Size(20, 60));
            s1.Draw();
          //  s1.Data = new MyData() { X = 42 };

            Ellipse e1 = new(new Position(80, 20), new Size(20, 60));
          //  e1.Data = new MyData() { X = 42 };
            if (s1 == e1)
            {
                Console.WriteLine("the same values");
            }
        }
    }
}
