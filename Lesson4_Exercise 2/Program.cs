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
            var tree = new Tree();
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(10);
            tree.Insert(30);
            tree.Insert(80);
            tree.Insert(29);
            tree.Insert(31);
            tree.Insert(32);
            tree.Insert(70);
            TreeExtensions.Print(tree);
           
            Console.ReadKey();
        }

        
    }
}
