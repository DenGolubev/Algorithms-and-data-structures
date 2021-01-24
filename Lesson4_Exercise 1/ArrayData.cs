using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_1
{
    class AddData
    {
        Generator gen = new Generator();
        public void addNumbertoArray()
        {
            int count = 0;
            var mas = gen.GenStringstoArray(100);
            foreach (var item in mas)
            {
                Console.WriteLine($"Array {++count} {item}");
            }
            Console.ReadKey();
        }

        public void addNumbertoHash()
        {
            int count = 0;
            var mas = gen.GenStringstoHashSet(100);
            foreach (var item in mas)
            {
                Console.WriteLine($"Hash {++count} {item}");
            }
            Console.ReadKey();
        }
    }
}
