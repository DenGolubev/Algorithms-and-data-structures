using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Exercise_1
{
    class Field
    {
        public void myField()
        {
            Console.WriteLine("введите колличество клеток");
            int a = int.Parse(Console.ReadLine());
            int[][] mass = new int[a][];
            //var point = 
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    mass[i][j] = 0;
                }
            }

            //mass[0][0] = 1;
            //if (mass[0][0] == 1)
            //{
            //    for (int i = 0; i < mass.GetLength(0); i++)
            //    {

            //        for (int y = 0; y < mass.GetLength(1); y++)
            //        {

            //            if (mass[i][y] == 1)
            //            {
                            
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    mass[0][0] = 1;
            //}
            
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(mass[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
