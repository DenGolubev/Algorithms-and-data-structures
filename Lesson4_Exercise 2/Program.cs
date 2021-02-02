using System;

namespace Lesson4_Exercise_2
{
    class Program
    {
         static int number { get; set; }
        static void Main(string[] args)
        {
            #region Заполнение дерева
            Tree<int> tree = new Tree<int>();
            tree.Add(8);
            tree.Add(5);
            tree.Add(13);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(10);
            tree.Add(15);
            #endregion

            Console.WriteLine(new string('-', 50));

            #region Обход в глубину - DFS - Прямой обход
            Console.WriteLine("Обход в глубину - DFS - Прямой обход (CLR – center, left, right)");
            foreach (var item in tree.PreOrder())
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine(new string('-', 50));

            #region Удаление узла
            Console.WriteLine("Введите значение узла для удаления");
            number = int.Parse(Console.ReadLine());
            tree.Remove(number);
            #endregion

            Console.WriteLine(new string('-', 50));

            #region Обход в глубину - DFS - Прямой обход
            Console.WriteLine("Обход в глубину - DFS - Прямой обход (CLR – center, left, right)");
            foreach (var item in tree.PreOrder())
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Поиск узла
            Console.WriteLine("Введите значение узла для поиска");
            number = int.Parse(Console.ReadLine());
            tree.Contains(number);
            Console.WriteLine($"Наличие узла {number} в дереве - {tree.Contains(number)}");
            #endregion

            Console.WriteLine(new string('-', 50));

            #region Обход в ширину - BFS
            Console.WriteLine("Обход в ширину - BFS");
            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine(new string('-', 50));

            #region Обход в глубину - DFS - Прямой обход
            Console.WriteLine("Обход в глубину - DFS - Прямой обход (CLR – center, left, right)");
            foreach (var item in tree.PreOrder())
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine(new string('-', 50));

            #region Обход в глубину - DFS - Обратный обход
            Console.WriteLine("Обход в глубину - DFS - Обратный обход (LRC – left, right, center)");
            foreach (var item in tree.PostOrder())
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine(new string('-', 50));

            #region Обход в глубину - DFS - Симметричный обход
            Console.WriteLine("Обход в глубину - DFS - Симметричный обход (LCR – left, center, right)");
            foreach (var item in tree.InfixOrder())
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.ReadKey();
        }
               
    }
}
