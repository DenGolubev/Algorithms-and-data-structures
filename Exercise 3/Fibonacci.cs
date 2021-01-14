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

        private int cyclicFibonachiNumber(int number)
        {
            int d = 0;
            //if (d == 0) return  0;
            //else if (d == 1) return  1;
            for (int i = 0; i < number; i++)
            {
                i = ((i - 1) + (i - 2));
                Console.WriteLine(i);
            }
            return d;
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
            Console.WriteLine($"Рекурсия. Число Фиббоначи {num}-й последовательности = { cyclicFibonachiNumber(num)}");
            Console.ReadKey();
        }
    }
}
