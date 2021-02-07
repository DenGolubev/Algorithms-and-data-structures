using System;


namespace Lesson2_Exercise_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            myArray array = new myArray();
            mySearch search = new mySearch();
            int[] newArray =  array.CreateArray(100);
            newArray = array.myBubbleSort(newArray);
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            int status = search.BinarySearch(newArray, 10);
            Console.WriteLine(status);
            Console.ReadKey();
        }
    }
}
