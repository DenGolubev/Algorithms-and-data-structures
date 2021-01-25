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
        int Capacity { get; set; }
        int[] masnumber { get; set; }
        string[] masletters { get; set; }
        HashSet<string> hashletters { get; set; }
        public Generator(int capacity)
        {
            Capacity = capacity;
            masnumber = new int[Capacity];
            masletters = new string[Capacity];
            hashletters = new HashSet<string>();
        }
        public int[] GenNumbers(int n_start, int n_end)
        {
            for (int i = 0; i < masnumber.Length; i++)
            {
                int a = rnd.Next(n_start, n_end);
                if (!masnumber.Contains(a))
                {
                    masnumber[i] = a;
                }
                else i--; 
            }
            return masnumber;
        }

        public string[] GenStringstoArray()
        {
            int lengthString = 10; //Длина генерируемой строки
            
            for (int i = 0; i < masletters.Length; i++)
            {
                string a = ""; //Инициализация пустой строки
                for (int y = 0; y < lengthString; y++)
                {
                    if( y % 3 == 0) a += Convert.ToChar(rnd.Next(65, 88)); //Условие выбора заглавных букв
                    else if( y % 2 == 0) a += Convert.ToChar(rnd.Next(97, 122));//Условие выбора маленьких букв
                    else a += Convert.ToChar(rnd.Next(48, 57));//Условие выбора цифр
                }
                if (!masletters.Equals(a)) masletters[i] = a; //Если найдено совпадение, то счетчик минусуем
                else i--;                
            }
            return masletters;
        }

        public HashSet<string> GenStringstoHashSet()
        {
            var mas = GenStringstoArray();
            foreach (var item in mas)
            {
                hashletters.Add(item);
            }
            return hashletters;
           
        }
    }
}
