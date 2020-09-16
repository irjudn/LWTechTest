using Consumer.FibonacciReference;
using System;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciServiceSoapClient fibonacciClient = new FibonacciServiceSoapClient();

            Console.Write("Fibonacci(10) = {0}", fibonacciClient.Fibonacci(10));
            Console.ReadLine();
        }
    }
}
