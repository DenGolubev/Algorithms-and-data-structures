using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_1
{
    class SearchData
    {
        static AddData array = new AddData();
        Random rnd = new Random();
        string[] mas = array.addNumbertoArray();
        public void masSearch(string searchData)
        {
            if (mas.Equals(searchData)) Console.WriteLine("Совпадение найдено");
            else Console.WriteLine("Совпадение не найдено");
            Console.ReadKey();
        }

        public void hashSearch()
        {
            var hash = array.addNumbertoHash();
        }

        public string GenString()
        {
            string a = ""; //Инициализация пустой строки
            for (int y = 0; y < 10; y++)
            {
                if (y % 3 == 0) a += Convert.ToChar(rnd.Next(65, 88)); //Условие выбора заглавных букв
                else if (y % 2 == 0) a += Convert.ToChar(rnd.Next(97, 122));//Условие выбора маленьких букв
                else a += Convert.ToChar(rnd.Next(48, 57));//Условие выбора цифр
            }
            return a;

        }
        
           
    }
}
