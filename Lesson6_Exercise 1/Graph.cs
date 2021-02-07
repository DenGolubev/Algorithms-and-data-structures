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

        public HashSet<int> DFS(int index, int[,] matrix)
        {
            var list = new HashSet<int>();
            list.Add(index);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[index, j] == 1)
                {
                    matrix[index, j] = matrix[j, index] = 0;
                    list.UnionWith(DFS(j, matrix));

                }
            }
            return list;
        }
        public void PrintDFS(HashSet<int> result)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
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
