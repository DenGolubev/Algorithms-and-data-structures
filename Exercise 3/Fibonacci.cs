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
            int a = 0;
            int b = 1;
            int c = 0;
            if (d == 0) return 0;
            if (d == 1) return 1;
            for (int i = 0; i < d; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }

        public void recursionResult(int num)
        {
            Console.Clear();
            Console.WriteLine($"Рекурсия. Число Фиббоначи {num}-й последовательности = { recursionFibonachiNumber(num)}");
            Console.ReadKey();
        }

        public void cyclicResult(int num)
        {
            Console.Clear();
            Console.WriteLine($"Цикл. Число Фиббоначи {num}-й последовательности = { cyclicFibonachiNumber(num)}");
            Console.ReadKey();
        }
    }
}
