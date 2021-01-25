using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson4_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordHash hash = new PasswordHash();
            PasswordArray array = new PasswordArray(10000);
            string[] myPass = array.GenStringstoArray();
            var hashSet = hash.GenStringstoHashSet();
            for (int i = 0; i < 10; i++)
            {
                hashSet = hash.GenStringstoHashSet();
            }
            //foreach (var item in myPass)
            //{
            //    Console.WriteLine(item);
            //}
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
    }
}
