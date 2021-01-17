using System;


namespace Lesson2_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            MyLinkedList linkedList = new MyLinkedList(value);
            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(5);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
