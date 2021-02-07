using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Exercise_1
{
    class Vertex
    {
        public int Node { get; set; }
        public Vertex(int nodeNumber)
        {
            Node = nodeNumber;
        }
        public override string ToString()
        {
            return Node.ToString();
        }
    }
}
