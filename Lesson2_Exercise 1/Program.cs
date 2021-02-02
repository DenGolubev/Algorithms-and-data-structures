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
            listlinkedList(linkedList);
            Console.WriteLine("Введите элемент после которого необходимо вставить новый узел:");
            var newItem = linkedList.FindNode(int.Parse(Console.ReadLine()));
            linkedList.AddNodeAfter(newItem, 23);
            listlinkedList(linkedList);
            Console.WriteLine($"Всего в вашем списке {linkedList.GetCount()} узлов");
            Console.WriteLine("Введите элемент для поиска:");
            Console.WriteLine(linkedList.FindNode(int.Parse(Console.ReadLine())));
            Console.WriteLine("Введите элемент для удаления:");
            linkedList.RemoveNode(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите элемент для удаления:");
            linkedList.RemoveNode(linkedList.FindNode(int.Parse(Console.ReadLine())));
            Console.WriteLine($"Всего в вашем списке {linkedList.GetCount()} узлов");
            listlinkedList(linkedList);
            Console.ReadKey();
        }
        public static void listlinkedList(MyLinkedList linkedList)
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
