using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_2
{
    class Program
    {
        static TreeNode node = new TreeNode();
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            insertValue();
            Console.WriteLine("Введите число для поиска");
            bool a = findValue(int.Parse(Console.ReadLine()));
            Console.WriteLine(a);

            Console.ReadKey();
        }

        public static void insertValue()
        {
            for (int i = 0; i < 15; i++)
            {
                int y = rnd.Next(3, 15);
                if (!node.Value.Equals(y))
                {
                    node.Add(y);
                }
                else
                {
                    i--;
                }

            }
            foreach (var item in node)
            {
                Console.WriteLine(item);
            }
        }

        public static bool findValue(int value)
        {
            if (node.Find(value) == null) return false;
            return true;
        }
    }
}
