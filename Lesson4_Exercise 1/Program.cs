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
            AddData array = new AddData();
            array.addNumbertoArray();
            array.addNumbertoHash();
        }
    }
}
