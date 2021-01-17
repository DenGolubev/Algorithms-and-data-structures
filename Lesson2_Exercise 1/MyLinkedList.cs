using System;
using System.Collections;

namespace Lesson2_Exercise_1
{
    class MyLinkedList : ILinkedList, IEnumerable
    {
        public int Value { get; set; }
        public Node Tail { get; set; }
        public Node Head { get; set; }
        public int Count { get; set; }

        public MyLinkedList(int value)
        {
            var item = new Node(value);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void AddNode(int value)
        {
            var item = new Node(value);
            if(Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
            }
            Tail.NextNode = item;
            item.PrevNode = Tail;
            Tail = item;
            Count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public Node FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(int index)
        {
            
        }

        public void RemoveNode(Node node)
        {
            var currentItem = Head;
            while(currentItem != null)
            {
                if (currentItem.Equals(node))
                {
                    currentItem.PrevNode.NextNode = currentItem.NextNode;
                    currentItem.NextNode.PrevNode = currentItem.PrevNode;
                    Count--;
                    return;
                }
                currentItem = currentItem.NextNode;
            }
        }

        public IEnumerator GetEnumerator()
        {
            var currentItem = Head;
            while(currentItem != null)
            {
                yield return currentItem;
                currentItem = currentItem.NextNode;
            }
        }
    }
}
