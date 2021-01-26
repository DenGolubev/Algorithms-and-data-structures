using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_1
{
    class Generator
    {
        Random rnd = new Random();
        public string GenStringData(int lengthString)
        {
            string a = ""; //Инициализация пустой строки
            for (int y = 0; y < lengthString; y++)
            {
                if (y % 3 == 0) a += Convert.ToChar(rnd.Next(65, 88)); //Условие выбора заглавных букв
                else if (y % 2 == 0) a += Convert.ToChar(rnd.Next(97, 122));//Условие выбора маленьких букв
                else a += Convert.ToChar(rnd.Next(48, 57));//Условие выбора цифр
            }
            return a;
        }

    }
}
