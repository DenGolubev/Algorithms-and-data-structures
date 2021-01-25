using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_1
{
    class AddData
    {
        Generator gen = new Generator(10000);
        
        public string[] addNumbertoArray()
        {
            var mas = gen.GenStringstoArray();
            return mas;
        }

        public HashSet<string> addNumbertoHash()
        {
            var mas = gen.GenStringstoHashSet();
            return mas;
        }
    }
}
