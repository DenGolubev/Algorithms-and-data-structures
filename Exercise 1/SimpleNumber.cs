using System;

namespace Exercise_1
{
    class SimpleNumber
    {
        int d = 0;
        int i = 2;
        public void CheckNumber(int number)
        {
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    break;
                }
                else i++;
            }
            if (d == 0) Console.WriteLine($"Вы ввели простое число {number}");
            }
    }
}
