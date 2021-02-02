using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_2
{
    public class TreeNode<T> : IComparable<T> where T : IComparable<T>
    {
        public T Value { get; private set; }
        public TreeNode<T> NodeLeft { get; set; }
        public TreeNode<T> NodeRight { get; set; }


        public TreeNode(T value)
        {
            Value = value;
        }
        public int CompareTo(T value)
        {
            return Value.CompareTo(value);
        }
        public int CompareNode(TreeNode<T> other)
        {
            return Value.CompareTo(other.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
