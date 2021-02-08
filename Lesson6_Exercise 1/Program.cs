using System;
using System.Collections.Generic;

namespace Lesson6_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph(); // Инициализация Граффа

            #region Создаем Графф
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);

            graph.AddV(v1);
            graph.AddV(v2);
            graph.AddV(v3);
            graph.AddV(v4);
            graph.AddV(v5);
            graph.AddV(v6);
            graph.AddV(v7);

            graph.AddE(v1, v2);
            graph.AddE(v1, v3);
            graph.AddE(v3, v4);
            graph.AddE(v2, v5);
            graph.AddE(v2, v6);
            graph.AddE(v6, v5);
            graph.AddE(v5, v6);
            #endregion

            var matrix = graph.GetMatrix(); //Инициализация массива матрицы межности

            #region Матрица смежности

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Матрица смежности");
            Console.WriteLine();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                for (int y = 0; y < graph.VertexCount; y++)
                {
                    Console.Write(matrix[i, y] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            #endregion

            #region Обход в глубину DFS

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Обход в глубину DFS");
            Console.WriteLine();
            var result = graph.DFS(1, matrix);
            graph.PrintDFS(result);

            #endregion

            #region Обход в ширину
            graph.BFS();
            #endregion

        }
    }
}
