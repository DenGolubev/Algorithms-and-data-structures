using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson3_Exercise_1
{
    public class Program
    {
        static float[] myArray;
        GenerateArrayPointClass pointClass = new GenerateArrayPointClass();
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadKey();

            
        }
        public float[] newArray(float[] array)
        {
            array = pointClass.CreateMyArray();
            return array;
        }
        [Benchmark]
        public void PointClassFsqrt()
        {
            GenerateArrayPointClass array = new GenerateArrayPointClass();
            array.CalculatingPointClassFloat();
        }

        [Benchmark]
        public void PointStructFsqrt()
        {
            GenerateAnyPointStruct pointStruct = new GenerateAnyPointStruct();
            pointStruct.CalculatingPointStructFsqrt();
        }

        [Benchmark]
        public void PointStructDsqrt()
        {
            GenerateAnyPointStruct pointStruct = new GenerateAnyPointStruct();
            pointStruct.CalculatingPointStructDsqrt();
        }

        [Benchmark]
        public void PointStructD()
        {
            GenerateAnyPointStruct pointStruct = new GenerateAnyPointStruct();
            pointStruct.CalculatingPointStructF();
        }
    }
}
