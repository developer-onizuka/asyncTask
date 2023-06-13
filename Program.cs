using System;
using System.Threading;
using System.Threading.Tasks;

public class test
{
    static async Task Main()
    {
        Console.WriteLine("Start Program");

        Console.WriteLine("Run Child process");
        Task child = MethodAsync();

        for (int i = 1; i <= 2; i++) 
        {
            GetThreadId($"Main Heavy process #{i} *");
            Task.Delay(1000).Wait();
        }
        Console.WriteLine("All of Main Heavy processes completed");

        await child;
        Console.WriteLine("Confirm all of child processes completed after Main processes finished");
    }

    static async Task MethodAsync()
    {
        for (int i = 1; i <= 10; i++) 
        {
            GetThreadId($"ChildAsync process #{i}");
            await Task.Delay(300);
        }
    }

    static void GetThreadId(string str) 
    {
        int threadId = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"Thread {threadId} -----> {str}");
    }
}
