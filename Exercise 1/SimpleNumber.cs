using System;

namespace Exercise_1
{
    class SimpleNumber
    {
        int d = 0;
        int i = 2;
        bool check = false;
        public bool CheckNumber(int number)
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
            if (d == 0) check = true;
            else check = false;
            return check;
        }
    }
}
//
//