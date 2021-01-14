using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleNumber number = new SimpleNumber();
            Console.WriteLine("Введите число");
            int checkNumber = int.Parse(Console.ReadLine());
            if (number.CheckNumber(checkNumber)) Console.WriteLine($"Вы ввели простое число {checkNumber}");
            else Console.WriteLine($"Вы ввели не простое число {checkNumber}");
            Console.ReadKey();
        }
    }
}
