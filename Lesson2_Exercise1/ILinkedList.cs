using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Exercise1
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }

    interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(); // добавляет новый элемент списка
        void AddNodeAfter(); // добавляет новый элемент списка после определённого элемента
        void RemoveNode( int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению

    }
}
