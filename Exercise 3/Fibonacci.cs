using System;

namespace Exercise_3
{
    class Fibonacci
    {
        private int recursionFibonachiNumber(int d)
        {
            if (d == 0) return 0;
            else if (d == 1) return 1;
            else return recursionFibonachiNumber(d - 1) + recursionFibonachiNumber(d - 2);
        }

        private int cyclicFibonachiNumber(int d)
        {

            return d;
        }

        public void Result(int num)
        {
            Console.Clear();
            Console.WriteLine($"Рекурсия. Число Фиббоначи {num}-й последовательности = { recursionFibonachiNumber(num)}");
            Console.ReadKey();
        }
    }
}
