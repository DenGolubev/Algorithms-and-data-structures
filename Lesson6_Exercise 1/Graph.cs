using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Exercise_1
{
    class Graph
    {
        List<Vertex> V = new List<Vertex>();
        List<Edge> E = new List<Edge>();
        public int VertexCount => V.Count;
        public int EdgeCount => E.Count;
        public void AddV(Vertex vertex)
        {
            V.Add(vertex);
        }
        public void AddE(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            E.Add(edge);
        }

        public int[,] GetMatrix()
        {
            var matrix = new int[V.Count, V.Count];
            foreach (var edge in E)
            {
                var row = edge.From.Node;
                var column = edge.To.Node;
                matrix[row, column] = edge.Weight;
            }
            return matrix;
        }
    }
}
