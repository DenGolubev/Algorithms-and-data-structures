using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();
            tree.Add(8);
            tree.Add(5);
            tree.Add(12);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(10);
            tree.Add(15);
            Console.WriteLine("Введите значение узла");
            int a = int.Parse(Console.ReadLine());
            tree.Remove(a);
            Console.WriteLine($"Наличие узла {a} в дереве - {tree.Contains(a)}");
            Console.ReadKey();
        }
               
    }
}
