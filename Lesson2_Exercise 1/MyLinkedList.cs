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
            var newNode = new Node(value);
            var nextItem = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextItem;
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
            int newIndex = 0;
            var newNode = Head;
            while (newNode != null)
            {
                if (newIndex == index - 1)
                {
                    RemoveNode(newNode);
                }

                newNode = newNode.NextNode;
                newIndex++;
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
