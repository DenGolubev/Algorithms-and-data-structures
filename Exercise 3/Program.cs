using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int counter = int.Parse(Console.ReadLine());
            Fibonacci fibnum = new Fibonacci();
            //fibnum.recursionResult(counter);
            fibnum.cyclicResult(counter);
        }
    }
}
