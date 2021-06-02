using System;
using System.Threading;
using System.Threading.Tasks;

namespace PoolSample
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadPool.GetAvailableThreads(out int worker, out int io);
            Console.WriteLine($"worker: {worker}, io: {io}");

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(MyJob);

            }
            Console.ReadLine();
        }

        static void MyJob(object o)
        {
            Task t1 = new Task(MyMethod);
            t1.Start()
            Console.WriteLine($"running in a thread {Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.IsThreadPoolThread}");
        }
    }
}
