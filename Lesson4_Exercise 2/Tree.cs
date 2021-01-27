using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_2
{
    class TreeNode<T>: IComparable<T> where T: IComparable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> NodeLeft { get; set; }
        public TreeNode<T> NodeRight { get; set; }

        public int CompareTo(T other)
        {
            return CompareTo(other);
        }

        public TreeNode<int> Tree(int node)
        {
            TreeNode<int> newNode = null;
            if (node == 0) return null;
            if (Value == null) return Value = node;
           
            return newNode;
        }
    }

}
