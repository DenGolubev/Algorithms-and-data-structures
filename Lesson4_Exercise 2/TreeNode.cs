using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_2
{
    public class TreeNode: IComparable, IEnumerable<int>
    {
        public int Value { get; set; }
        public TreeNode NodeLeft { get; set; }
        public TreeNode NodeRight { get; set; }
        public TreeNode NodeRoot { get; set; }

        public void Add(int value)
        {
            if (Value == 0 || Value == value)
            {
                Value = value;
                return;
            }
            else if (Value > value)
            {
                if (NodeLeft == null) NodeLeft = new TreeNode();
                Add(value, NodeLeft, this);
            }
            else
            {
                if (NodeRight == null) NodeRight = new TreeNode();
                Add(value, NodeRight, this);
            }

        }

        private void Add(int value, TreeNode node, TreeNode root)
        {
            if (node.Value == 0 || node.Value == value)
            {
                node.Value = value;
                node.NodeRoot = root;
                return;
            }
            if (node.Value > value)
            {
                if (node.NodeLeft == null) node.NodeLeft = new TreeNode();
                Add(value, node.NodeLeft, node);
            }
            else
            {
                if (node.NodeRight == null) node.NodeRight = new TreeNode();
                Add(value, node.NodeRight, node);
            }
        }

        public TreeNode Find(int value)
        {
            if (Value == value) return this;
            if (Value > value)
            {
                return Find(value, NodeLeft);
            }
            return Find(value, NodeRight);
        }

        public TreeNode Find(int value, TreeNode node)
        {
            if (node == null) return null;

            if (node.Value == value) return node;
            if (node.Value > value)
            {
                return Find(value, node.NodeLeft);
            }
            return Find(value, node.NodeRight);
        }
        public int CompareTo(object obj)
        {
            return CompareTo(obj);
        }

        public IEnumerator<int> GetEnumerator()
        {
            if (NodeLeft != null)
            {
                foreach (var v in NodeLeft)
                {
                    yield return v;
                }
            }
            yield return Value;

            if (NodeRight != null)
            {
                foreach (var v in NodeRight)
                {
                    yield return v;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }
    }
}
