using System;
using System.Threading;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner();
            Console.WriteLine("Main completed");
            Console.ReadLine();
        }

        static async void Runner()
        {
            Task? resultTask = null;
            try
            {
                Console.WriteLine("runner started");
                Task t1 = ThrowAfterAsync("one", 3000);
                Task t2 = ThrowAfterAsync("two", 2000);
                resultTask = Task.WhenAll(t2, t1);

                await resultTask;
                Console.WriteLine("runner completed");
            }
            catch (MyException ex)
            {
                Console.WriteLine($"error: {ex.Message}");

                Console.WriteLine("inner exceptions");
                var aggex = resultTask.Exception;
                foreach (var innerex in aggex?.InnerExceptions)
                {
                    Console.WriteLine(innerex.Message);
                }
            }

        }

        static Task ThrowAfterAsync(string message, int ms)
        {
            return Task.Run(() =>
            {
                ThrowAfter(message, ms);
            });
        }

        static async void ThrowAfter(string message, int ms)
        {
            Console.WriteLine($"ThrowAfter started with {message}");
            // Thread.Sleep(ms);
            await Task.Delay(ms);
            Console.WriteLine($"Throwing now {message}");
            throw new MyException(message);
        }
    }



    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }

    }
}
