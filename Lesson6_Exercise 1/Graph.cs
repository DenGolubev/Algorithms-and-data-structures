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

        #region Добавление вершин
        public void AddV(Vertex vertex)
        {
            V.Add(vertex);
        }

        #endregion

        #region Добавление ребер
        public void AddE(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            E.Add(edge);
        }

        #endregion

        #region DFS
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
        #endregion

        #region PrintDFS
        public void PrintDFS(HashSet<int> result)
        {
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }

        #endregion

        #region BFS
        public void BFS(int index, int[][] adjvertices)
        {
            Queue<int> q = new Queue<int>();    //Это очередь, хранящая номера вершин
            //int u = 0;
            int u = adjvertices.Length - 1;
            bool[] used = new bool[u + 1];  //массив отмечающий посещённые вершины
            int[][] g = adjvertices; //массив содержащий записи смежных вершин

            used[u] = true;     //массив, хранящий состояние вершины(посещали мы её или нет)

            q.Enqueue(index);
            Console.Write(index + " ");
            while (q.Count != 0)
            {
                u = q.Peek();
                q.Dequeue();
                Console.Write(index + u + " ");

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[u][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            q.Enqueue(i);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        #endregion

        #region Конвертация двумерного массива в Jagged

        public T[][] ToJagged<T>(T[,] array)
        {
            var result = new T[array.GetLength(0)][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new T[array.GetLength(1)];
                for (int j = 0; j < result[i].Length; j++)
                {
                    result[i][j] = array[i, j];
                }
            }
            return result;
        }

        #endregion

        #region Matrix
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
        #endregion
    }
}
