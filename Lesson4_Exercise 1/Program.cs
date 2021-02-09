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
        static BechmarkClass bechmark = new BechmarkClass();

        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            //bechmark.BeginTest();
            Console.ReadKey();
        }

        
    }
    public class BechmarkClass
    {
        static GetPass getpass = new GetPass();
        static PasswordArray array = new PasswordArray(10);
        static Generator generator = new Generator();
        static string[] myPass = array.GenStringstoArray();
        PasswordHash searchPass = new PasswordHash() { Pass = generator.GenString(10), IDPass = generator.GenID(5) };
        string searchdata = generator.GenString(10);


        public void BeginTest()
        {
            array.GenStringstoArray();
            getpass.GetingStartGeneration();

            //SearchData();
            //Console.WriteLine(SearchDataHash());
        }

        [Benchmark]
        public string SearchData()
        {
            if (myPass.Equals(searchdata)) return searchdata;
            return searchdata = null;
        }
        [Benchmark]
        public bool SearchDataHash()
        {
            if (getpass.Equals(searchPass)) return true;
            return false;
        }
    }
}
