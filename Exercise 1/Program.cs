using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
                SimpleNumber number = new SimpleNumber();
                Console.WriteLine("Введите число");
                number.CheckNumber(int.Parse(Console.ReadLine()));
                Console.ReadKey();
            
        }
    }
}
