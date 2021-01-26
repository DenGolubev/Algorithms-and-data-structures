using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_2
{
    class Tree<T>
    {
        public T Value;
        public Tree<T> NodeLeft; 
        public Tree<T> NodeRight; 
        public Tree<T> NodeParent;

    }
}
