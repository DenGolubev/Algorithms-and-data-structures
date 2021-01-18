using System;


namespace Lesson2_Exercise_1
{
    class Program
    {
        static MyLinkedList linkedList = new MyLinkedList();
        static void Main(string[] args)
        {
            linkedList.AddNode(10);
            linkedList.AddNode(250);
            linkedList.AddNode(34);
            linkedList.AddNode(41);
            linkedList.AddNode(58);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Всего в вашем списке {linkedList.GetCount()} узлов");
            Console.WriteLine("Введите элемент для поиска:");
            Console.WriteLine(linkedList.FindNode(int.Parse(Console.ReadLine())));

            Console.WriteLine("Введите элемент для удаления:");
            linkedList.RemoveNode(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Всего в вашем списке {linkedList.GetCount()} узлов");
            Console.ReadKey();
        }
    }
}
