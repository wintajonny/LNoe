using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("client - wait for service");
            Console.ReadLine();

            CancellationTokenSource cts = new(10000);



        }
    }
}
