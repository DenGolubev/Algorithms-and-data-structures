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
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadKey();
        }

        
    }
    public class BechmarkClass
    {
        static PasswordHash hash = new PasswordHash();
        static PasswordArray array = new PasswordArray(10);
        static string[] myPass = array.GenStringstoArray();
       

        public void BeginTest()
        {
            array.GenStringstoArray();
            hash.GenStringstoHashSet();
            SearchData();
            SearchDataHash();
        }

        [Benchmark]
        public string SearchData()
        {
            
            string searchdata = "";
            if (myPass.Equals(searchdata)) return searchdata;
            return searchdata = null;
        }
        [Benchmark]
        public string SearchDataHash()
        {
            
            string searchdata = "";
            if (hash.Equals(searchdata)) return searchdata;
            return searchdata = null;
        }
    }
}
