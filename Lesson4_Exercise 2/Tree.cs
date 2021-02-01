using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_2
{
    public class Tree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private TreeNode<T> Root;
        private int Count;

        #region Добавление узла
        public void Add(T value)
        {
            if(Root == null)
            {
                Root = new TreeNode<T>(value);
            }
            else
            {
                AddTo(Root, value);
            }
            Count++;
        }

        private void AddTo(TreeNode<T> node, T value)
        {
            if(value.CompareTo(node.Value) < 0)
            {
                if(node.NodeLeft == null)
                {
                    node.NodeLeft = new TreeNode<T>(value);
                }
                else
                {
                    AddTo(node.NodeLeft, value);
                }
            }
            else
            {
                if (node.NodeRight == null)
                {
                    node.NodeRight = new TreeNode<T>(value);
                }
                else
                {
                    AddTo(node.NodeRight, value);
                }
            }
        }
        #endregion

        #region Поиск узла
        public bool Contains(T value)
        {
            TreeNode<T> parent = Root;
            return Find(value, out parent) != null;
        }

        private TreeNode<T> Find(T value, out TreeNode<T> parent)
        {
            TreeNode<T> current = Root;
            parent = null;
            while(current != null)
            {
                int result = current.CompareTo(value);
                if(result > 0)
                {
                    parent = current;
                    current = current.NodeLeft;
                }else if(result < 0)
                {
                    parent = current;
                    current = current.NodeRight;
                }
                else
                {
                    break;
                }
            }
            return current;
        }
        #endregion

        #region Удаление узла
        public bool Remove(T value)
        {
            TreeNode<T> current;
            TreeNode<T> parent;
            current = Find(value, out parent);
            if(current == null)
            {
                return false;
            }
            Count--;

            if (current.NodeRight == null)
            {
                if (parent == null)
                {
                    Root = current.NodeLeft;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        parent.NodeLeft = current.NodeLeft;
                    }
                    else if (result < 0)
                    {
                        parent.NodeRight = current.NodeLeft;
                    }
                }
            }
            else if (current.NodeRight.NodeLeft == null)
            {
                current.NodeRight.NodeLeft = current.NodeLeft;
                if (parent == null)
                {
                    Root = current.NodeRight;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        parent.NodeLeft = current.NodeRight;
                    }
                    else if (result < 0)
                    {
                        parent.NodeRight = current.NodeRight;
                    }
                }
            }
            else
            {
                TreeNode<T> leftmost = current.NodeRight.NodeLeft;
                TreeNode<T> leftmostParent = current.NodeRight;

                // поиск крайнего левого потомка 
                while (leftmost.NodeLeft != null)

                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.NodeLeft;
                }

                // Правое поддерево крайнего левого узла, становится левым поддеревом его родительского узла.         
                leftmostParent.NodeLeft = leftmost.NodeLeft;

                // Присваиваем крайнему левому узлу в качестве левого потомка - левый потомок удаляемого узла,
                // а в качестве правого потомка - правый потомок удаляемого узла. 

                leftmost.NodeLeft = current.NodeLeft;
                leftmost.NodeRight = current.NodeRight;

                if (parent == null)
                {
                    Root = leftmost;
                }

                else

                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0)
                    {

                        // Если значение родительского узла(parent), больше значения удаляемого узла (current) -                  
                        // сделать левого крайнего потомка удаляемого узла(leftmost)  - левым потомком его родителя(parent). 

                        parent.NodeLeft = leftmost;
                    }

                    else if (result < 0)

                    {

                        // Если значение родительского узла(parent), меньше значения удаляемого узла (current) -                  
                        // сделать левого крайнего потомка удаляемого узла(leftmost) - правым потомком его родителя(parent).

                        parent.NodeRight = leftmost;
                    }
                }
            }
            return true;
        }
        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
