using System;

namespace AndreyMatveew06Algoritm02
{
    class Program
    {
        //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 06.
        //Задание 2. Переписать программу, реализующее двоичное дерево поиска. а) Добавить в него обход дерева различными способами;
        // б) Реализовать поиск в двоичном дереве поиска;
        static void Main(string[] args)
        {
            BinaryTree tree = new();
            tree.Add(2);
            tree.Add(1);
            tree.Add(3);

            tree.TraversePreOrder(tree.Root);
            Console.WriteLine(tree.Find(1).Data);

            Console.ReadKey();
        }
    }
}
