using System;
using System.Collections;
using System.Collections.Generic;

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

                while (leftmost.NodeLeft != null)

                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.NodeLeft;
                }

                leftmostParent.NodeLeft = leftmost.NodeLeft;

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
                        parent.NodeLeft = leftmost;
                    }

                    else if (result < 0)

                    {
                        parent.NodeRight = leftmost;
                    }
                }
            }
            return true;
        }
        #endregion

        #region Обход в ширину - BFS

        public IEnumerator<T> LevelOrder()
        {

            if (Root == null)
                yield break;

            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                yield return node.Value;
                if (node.NodeLeft != null) queue.Enqueue(node.NodeLeft);
                if (node.NodeRight != null) queue.Enqueue(node.NodeRight);
            }

        }

        #endregion

        #region Обход в глубину - DFS - Прямой обход (CLR – center, left, right)
        public List<T> PreOrder()
        {
            if(Root == null)
            {
                return new List<T>();
            }
            return PreOrder(Root);
            
        }
        
        private List<T>PreOrder(TreeNode<T> node)
        {
            var list = new List<T>();
            if(node != null)
            {
                list.Add(node.Value);
                if(node.NodeLeft != null)
                {
                    list.AddRange(PreOrder(node.NodeLeft));
                }
                if (node.NodeRight != null)
                {
                    list.AddRange(PreOrder(node.NodeRight));
                }
            }
            return list;
        }
        #endregion

        #region Обход в глубину - DFS - Обратный обход (LRC – left, right, center)
        public List<T> PostOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return PostOrder(Root);

        }

        private List<T> PostOrder(TreeNode<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.NodeLeft != null)
                {
                    list.AddRange(PostOrder(node.NodeLeft));
                }
                if (node.NodeRight != null)
                {
                    list.AddRange(PostOrder(node.NodeRight));
                }
                list.Add(node.Value);
            }
            return list;
        }
        #endregion

        #region Обход в глубину - DFS - Симметричный обход (LCR – left, center, right)
        public List<T> InfixOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return InfixOrder(Root);

        }

        private List<T> InfixOrder(TreeNode<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.NodeLeft != null)
                {
                    list.AddRange(InfixOrder(node.NodeLeft));
                }
                list.Add(node.Value);
                if (node.NodeRight != null)
                {
                    list.AddRange(InfixOrder(node.NodeRight));
                }
                
            }
            return list;
        }
        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            return LevelOrder();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
