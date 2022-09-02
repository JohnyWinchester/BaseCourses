using System;

namespace AndreyMatveew03Algorithm03
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 03.
    //Задание 3. Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив.
    //Функция возвращает индекс найденного элемента или -1, если элемент не найден.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 6, 0, 9));
            Console.ReadKey();
        }

        static int BinarySearch(int[] array, int number, int leftBorder, int rightBorder)
        {
            while (leftBorder <= rightBorder)
            {
                var middle = (leftBorder + rightBorder) / 2;

                if (number == array[middle])
                {
                    return middle;
                }
                else if (number < array[middle])
                {
                    rightBorder = middle - 1;
                }
                else
                {
                    leftBorder = middle + 1;
                }
            }
            return -1;
        }
    }
}
