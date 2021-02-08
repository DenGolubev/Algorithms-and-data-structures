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
        public void BFS()
        {
            Random rand = new Random();
            Queue<int> q = new Queue<int>();    //Это очередь, хранящая номера вершин
            string exit = "";
            int u;
            do
            {
                Console.WriteLine("Задать размер массива самостоятельно? ");
                if (Console.ReadLine() == "да")
                {
                    Console.WriteLine("Введите размер:");
                    u = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (u < 3)
                    {
                        Console.WriteLine("Вы ввели некорректный размер массива. Программа автоматически заменила размер.");
                        u = rand.Next(3, 5);
                    }
                }
                else
                    u = rand.Next(3, 5);
                bool[] used = new bool[u + 1];  //массив отмечающий посещённые вершины
                int[][] g = new int[u + 1][];   //массив содержащий записи смежных вершин

                for (int i = 0; i < u + 1; i++)
                {
                    g[i] = new int[u + 1];
                    Console.Write("\n({0}) вершина -->[", i + 1);
                    for (int j = 0; j < u + 1; j++)
                    {
                        g[i][j] = rand.Next(0, 2);
                    }
                    g[i][i] = 0;
                    foreach (var item in g[i])
                    {
                        Console.Write(" {0}", item);
                    }
                    Console.Write("]\n");

                }


                used[u] = true;     //массив, хранящий состояние вершины(посещали мы её или нет)

                q.Enqueue(u);
                Console.WriteLine("Начинаем обход с {0} вершины", u + 1);
                while (q.Count != 0)
                {
                    u = q.Peek();
                    q.Dequeue();
                    Console.WriteLine("Перешли к узлу {0}", u + 1);

                    for (int i = 0; i < g.Length; i++)
                    {
                        if (Convert.ToBoolean(g[u][i]))
                        {
                            if (!used[i])
                            {
                                used[i] = true;
                                q.Enqueue(i);
                                Console.WriteLine("Добавили в очередь узел {0}", i + 1);
                            }
                        }
                    }
                }
                Console.WriteLine("Завершить программу?");
                exit = Console.ReadLine();
                Console.Clear();
            } while (exit != "да" || exit != "lf");
            Console.ReadKey();

            Console.ReadKey();
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
