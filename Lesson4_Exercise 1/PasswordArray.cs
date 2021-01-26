using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_1
{
    class PasswordArray
    {
        int Capacity { get; set; }
        string[] masletters { get; set; }
        Generator generator = new Generator();

        public PasswordArray(int capacity)
        {
            Capacity = capacity;
            masletters = new string[Capacity];
        }


        public string[] GenStringstoArray()
        {
            for (int i = 0; i < masletters.Length; i++)
            {
                string a = generator.GenString(10);
                if (!masletters.Equals(a)) masletters[i] = a; //Если найдено совпадение, то счетчик минусуем
                else i--;
            }
            return masletters;
        }
    }
}
