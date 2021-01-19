using System;
using System.Collections;

namespace Lesson2_Exercise_1
{
    class MyLinkedList : ILinkedList
    {
        public int Value { get; set; }
        public Node Tail { get; set; }
        public Node Head { get; set; }
        public int Count { get; set; }

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
            var currentNode = Head;
            while(currentNode.NextNode != null)
            {
               node = currentNode.NextNode
            }
                        
        }

        public Node FindNode(int searchValue)
        {
            var currentItem = Head;
            while (currentItem != null)
            {
                if (currentItem.Value == searchValue)
                {
                    return currentItem;
                }
                currentItem = currentItem.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            var currentItem = Head;
            int counter = 0;
            while (currentItem != null)
            {                
                currentItem = currentItem.NextNode;
                counter++;
            }
            return counter;
        }

        public void RemoveNode(int index)
        {
            var currentItem = Head;
            while (currentItem != null)
            {
                if (currentItem.Value == index)
                {
                    currentItem.PrevNode.NextNode = currentItem.NextNode;
                    currentItem.NextNode.PrevNode = currentItem.PrevNode;
                    Count--;
                    return;
                }
                currentItem = currentItem.NextNode;
            }
        }

        public void RemoveNode(Node node)
        {
            var currentItem = node;
            if(currentItem.NextNode == null)
            {
                node = null;
                return;
            }
            node.PrevNode = node.NextNode;
            node.NextNode = node.PrevNode.NextNode;

        }

        public IEnumerator GetEnumerator()
        {
            var currentItem = Head;
            while (currentItem != null)
            {
                yield return currentItem;
                currentItem = currentItem.NextNode;
            }
        }
    }
}
